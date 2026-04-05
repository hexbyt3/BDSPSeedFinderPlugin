using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PKHeX.Core;
using BDSPSeedFinderPlugin.Helpers;

namespace BDSPSeedFinderPlugin.GUI;

public partial class Gen8bSeedFinderForm : Form
{
    private readonly ISaveFileProvider _saveFileEditor;
    private readonly IPKMView _pkmEditor;
    private CancellationTokenSource? _searchCts;
    private readonly List<SeedResult> _results = [];
    private readonly Dictionary<int, SeedResult> _gridRowToResult = [];
    private readonly Lock _resultsLock = new();

    private Panel _previewPanel = null!;
    private PictureBox _previewSprite = null!;
    private Label _previewTitle = null!;
    private Label _previewDetails = null!;
    private Label _previewStats = null!;
    private static readonly HttpClient _httpClient = new();

    private const int FlawlessIVCount = 3;

    public Gen8bSeedFinderForm(ISaveFileProvider saveFileEditor, IPKMView pkmEditor)
    {
        _saveFileEditor = saveFileEditor;
        _pkmEditor = pkmEditor;
        InitializeComponent();
        InitializePreviewPanel();
        LoadSpeciesList();
        UpdateAbilityList();
        LoadNatureList();
        LoadTrainerData();
        FormClosing += (_, _) => _searchCts?.Cancel();
    }

    private void InitializePreviewPanel()
    {
        _previewPanel = new Panel
        {
            Dock = DockStyle.Bottom,
            Height = 160,
            BackColor = Color.FromArgb(40, 40, 44),
            Padding = new Padding(10),
            Visible = false,
        };

        _previewSprite = new PictureBox
        {
            Location = new Point(10, 10),
            Size = new Size(68, 56),
            SizeMode = PictureBoxSizeMode.Zoom,
            BackColor = Color.Transparent,
        };

        _previewTitle = new Label
        {
            Location = new Point(85, 10),
            AutoSize = true,
            ForeColor = Color.White,
            Font = new Font(Font.FontFamily, 10f, FontStyle.Bold),
        };

        _previewDetails = new Label
        {
            Location = new Point(85, 34),
            AutoSize = true,
            ForeColor = Color.LightGray,
            Font = new Font(Font.FontFamily, 8.5f),
        };

        _previewStats = new Label
        {
            Location = new Point(85, 75),
            AutoSize = true,
            ForeColor = Color.LightGray,
            Font = new Font("Consolas", 9f),
        };

        _previewPanel.Controls.AddRange([_previewSprite, _previewTitle, _previewDetails, _previewStats]);
        resultsPanel.Controls.Add(_previewPanel);
    }

    private void LoadSpeciesList()
    {
        speciesCombo.Items.Clear();
        speciesCombo.Items.Add(new ComboItem("Mesprit", 481));
        speciesCombo.Items.Add(new ComboItem("Cresselia", 488));
        speciesCombo.DisplayMember = "Text";
        speciesCombo.SelectedIndex = 0;
        speciesCombo.SelectedIndexChanged += (_, _) => UpdateAbilityList();
    }

    private void UpdateAbilityList()
    {
        var species = GetSelectedSpecies();
        if (species == 0)
            return;

        var pi = PersonalTable.BDSP[species, 0];
        var names = GameInfo.Strings.abilitylist;
        var a1 = names[pi.Ability1];
        var a2 = names[pi.Ability2];

        var prev = abilityCombo.SelectedIndex;
        abilityCombo.Items.Clear();

        if (pi.Ability1 == pi.Ability2)
            abilityCombo.Items.AddRange(["Any", a1]);
        else
            abilityCombo.Items.AddRange(["Any", $"{a1} (1)", $"{a2} (2)"]);

        abilityCombo.SelectedIndex = Math.Clamp(prev, 0, abilityCombo.Items.Count - 1);
    }

    private void LoadNatureList()
    {
        natureCombo.Items.Clear();
        natureCombo.Items.Add("Any");
        var natures = GameInfo.Strings.natures;
        foreach (var n in natures)
            natureCombo.Items.Add(n);
        natureCombo.SelectedIndex = 0;
    }

    private void LoadTrainerData()
    {
        var sav = _saveFileEditor.SAV;
        var tid7 = sav.ID32 % 1000000;
        var sid7 = sav.ID32 / 1000000;
        tidNum.Value = tid7;
        sidNum.Value = sid7;
    }

    private uint GetID32() => (uint)((uint)sidNum.Value * 1000000 + (uint)tidNum.Value);

    private ushort GetSelectedSpecies()
    {
        if (speciesCombo.SelectedItem is ComboItem item)
            return (ushort)item.Value;
        return 0;
    }

    #region Search

    private async void SearchButton_Click(object? sender, EventArgs e)
    {
        if (_searchCts != null)
        {
            _searchCts.Cancel();
            searchButton.Text = "Search";
            return;
        }

        var species = GetSelectedSpecies();
        if (species == 0)
        {
            WinFormsUtil.Error("Please select a species.");
            return;
        }

        if (!uint.TryParse(startSeedTextBox.Text, System.Globalization.NumberStyles.HexNumber, null, out var startSeed) ||
            !uint.TryParse(endSeedTextBox.Text, System.Globalization.NumberStyles.HexNumber, null, out var endSeed))
        {
            WinFormsUtil.Error("Invalid seed range. Use hex format (e.g., 00000000 - FFFFFFFF).");
            return;
        }

        if (startSeed > endSeed)
        {
            WinFormsUtil.Error("Start seed must be less than or equal to end seed.");
            return;
        }

        _results.Clear();
        _gridRowToResult.Clear();
        resultsGrid.Rows.Clear();

        _searchCts = new CancellationTokenSource();
        searchButton.Text = "Stop";
        progressBar.Visible = true;
        progressBar.Value = 0;

        var id32 = GetID32();
        var maxResults = (int)maxSeedsNum.Value;
        var shinyCriteria = shinyCombo.SelectedIndex;
        var natureCriteria = natureCombo.SelectedIndex - 1; // -1 = Any
        var abilityCriteria = abilityCombo.SelectedIndex; // 0=Any, 1=Ability1, 2=Ability2

        var ivRanges = new IVRange[]
        {
            new((int)ivHpMin.Value, (int)ivHpMax.Value),
            new((int)ivAtkMin.Value, (int)ivAtkMax.Value),
            new((int)ivDefMin.Value, (int)ivDefMax.Value),
            new((int)ivSpaMin.Value, (int)ivSpaMax.Value),
            new((int)ivSpdMin.Value, (int)ivSpdMax.Value),
            new((int)ivSpeMin.Value, (int)ivSpeMax.Value),
        };

        var token = _searchCts.Token;
        var sw = Stopwatch.StartNew();

        try
        {
            await Task.Run(() => SearchSeeds(startSeed, endSeed, id32, species, maxResults,
                shinyCriteria, natureCriteria, abilityCriteria, ivRanges, token), token);
        }
        catch (OperationCanceledException) { }

        sw.Stop();
        progressBar.Visible = false;
        searchButton.Text = "Search";
        statusLabel.Text = $"Found {_results.Count} results in {sw.Elapsed.TotalSeconds:F1}s";
        _searchCts = null;
    }

    private void SearchSeeds(uint startSeed, uint endSeed, uint id32, ushort species,
        int maxResults, int shinyCriteria, int natureCriteria, int abilityCriteria,
        IVRange[] ivRanges, CancellationToken token)
    {
        long totalSeeds = (long)endSeed - startSeed + 1;
        long checkedSeeds = 0;
        var resultsBag = new ConcurrentBag<SeedResult>();

        var options = new ParallelOptions
        {
            MaxDegreeOfParallelism = Environment.ProcessorCount,
            CancellationToken = token,
        };

        const int batchSize = 50000;
        long batchCount = (totalSeeds + batchSize - 1) / batchSize;

        try
        {
            Parallel.For(0, batchCount, options, batchIdx =>
            {
                if (token.IsCancellationRequested || resultsBag.Count >= maxResults)
                    return;

                long batchStart = startSeed + batchIdx * batchSize;
                long batchEnd = Math.Min(batchStart + batchSize - 1, endSeed);

                for (long s = batchStart; s <= batchEnd; s++)
                {
                    if (token.IsCancellationRequested || resultsBag.Count >= maxResults)
                        return;

                    uint seed = (uint)s;
                    if (seed == int.MaxValue) // Unity exclusion
                        continue;

                    if (!QuickVerifySeed(seed, id32, shinyCriteria, natureCriteria, abilityCriteria, ivRanges))
                        continue;

                    var pk = GenerateRoamingPokemon(seed, id32, species);
                    if (pk == null)
                        continue;

                    var result = new SeedResult(seed, pk);
                    resultsBag.Add(result);
                    Invoke(() => AddResultToGrid(result));
                }

                var count = Interlocked.Add(ref checkedSeeds, batchEnd - batchStart + 1);
                if (count % 500000 < batchSize)
                {
                    var pct = (int)(count * 100 / totalSeeds);
                    Invoke(() =>
                    {
                        progressBar.Value = Math.Min(pct, 100);
                        statusLabel.Text = $"Searching... {count:N0}/{totalSeeds:N0} seeds ({pct}%)";
                    });
                }
            });
        }
        catch (OperationCanceledException) { }

        lock (_resultsLock)
        {
            _results.AddRange(resultsBag.OrderBy(r => r.Seed));
        }
    }

    private static bool QuickVerifySeed(uint seed, uint id32, int shinyCriteria, int natureCriteria, int abilityCriteria, IVRange[] ivRanges)
    {
        var xoro = new Xoroshiro128Plus8b(seed);

        var fakeTID = xoro.NextUInt();
        var pid = xoro.NextUInt();

        // Revise PID (inline GetRevisedPID logic)
        pid = RevisePID(fakeTID, pid, id32);

        // Shiny check
        var finalXor = ShinyXor(pid, id32);
        bool isShiny = finalXor < 16;
        bool isSquare = finalXor == 0;

        if (shinyCriteria == 1 && !isShiny) return false; // Yes = must be shiny

        // IVs
        Span<int> ivs = stackalloc int[6];
        ivs.Fill(-1);

        int determined = 0;
        while (determined < FlawlessIVCount)
        {
            var idx = (int)xoro.NextUInt(6);
            if (ivs[idx] != -1)
                continue;
            ivs[idx] = 31;
            determined++;
        }

        for (int i = 0; i < 6; i++)
        {
            if (ivs[i] == -1)
                ivs[i] = (int)xoro.NextUInt(32);
        }

        // Check IV ranges: [HP, ATK, DEF, SPA, SPD, SPE]
        for (int i = 0; i < 6; i++)
        {
            if (ivs[i] < ivRanges[i].Min || ivs[i] > ivRanges[i].Max)
                return false;
        }

        // Ability
        int ability = (int)xoro.NextUInt(2);
        if (abilityCriteria != 0 && ability != abilityCriteria - 1)
            return false;

        // Nature (only checked if specified)
        // Nature isn't generated from the seed for roamers (assumed Synchronize),
        // but we check it against the user's desired nature for result filtering.
        // Since nature is freely settable via Synchronize, we don't filter here.
        // The user's nature choice is applied during full generation.

        return true;
    }

    private static uint RevisePID(uint fakeTID, uint pid, uint id32)
    {
        var fakeXor = ShinyXor(pid, fakeTID);
        var realXor = ShinyXor(pid, id32);

        var fakeType = GetShinyType(fakeXor);
        var realType = GetShinyType(realXor);

        if (fakeType == realType)
            return pid;

        if (fakeXor >= 16) // Not shiny with fake TID
            return pid ^ 0x1000_0000;

        // Shiny with fake TID but wrong type — reconstruct upper half
        var low = pid & 0xFFFF;
        var tid16 = (ushort)(id32 & 0xFFFF);
        var sid16 = (ushort)(id32 >> 16);
        return (((fakeXor == 0 ? 0u : 1u) ^ tid16 ^ sid16 ^ low) << 16) | low;
    }

    private static uint ShinyXor(uint pid, uint id32)
    {
        var val = pid ^ id32;
        return (val >> 16) ^ (val & 0xFFFF);
    }

    private static int GetShinyType(uint xor) => xor switch
    {
        0 => 0,    // Square
        < 16 => 1, // Star
        _ => 2,    // Not shiny
    };

    private PB8? GenerateRoamingPokemon(uint seed, uint id32, ushort species)
    {
        var pi = PersonalTable.BDSP[species, 0];
        byte gender = species == (int)Species.Cresselia ? (byte)1 : (byte)2;
        int natureIdx = natureCombo.SelectedIndex - 1;
        var nature = natureIdx >= 0 ? (Nature)natureIdx : Nature.Hardy;

        var pk = new PB8
        {
            Species = species,
            Form = 0,
            CurrentLevel = 50,
            MetLevel = 50,
            MetLocation = 197,
            MetDate = EncounterDate.GetDateSwitch(),
            Ball = (byte)Ball.Poke,
            ID32 = id32,
            Version = _saveFileEditor.SAV.Version == GameVersion.SP ? GameVersion.SP : GameVersion.BD,
            Language = _saveFileEditor.SAV.Language,
            OriginalTrainerGender = _saveFileEditor.SAV.Gender,
            OriginalTrainerName = _saveFileEditor.SAV.OT,
            OriginalTrainerFriendship = pi.BaseFriendship,
            Gender = gender,
            Nature = nature,
            StatNature = nature,
            Nickname = SpeciesName.GetSpeciesNameGeneration(species, _saveFileEditor.SAV.Language, 8),
        };

        var xoro = new Xoroshiro128Plus8b(seed);

        pk.EncryptionConstant = seed;

        var fakeTID = xoro.NextUInt();
        var pid = xoro.NextUInt();
        pk.PID = RevisePID(fakeTID, pid, id32);

        Span<int> ivs = stackalloc int[6];
        ivs.Fill(-1);
        int determined = 0;
        while (determined < FlawlessIVCount)
        {
            var idx = (int)xoro.NextUInt(6);
            if (ivs[idx] != -1)
                continue;
            ivs[idx] = 31;
            determined++;
        }

        for (int i = 0; i < 6; i++)
        {
            if (ivs[i] == -1)
                ivs[i] = (int)xoro.NextUInt(32);
        }

        pk.IV_HP = ivs[0];
        pk.IV_ATK = ivs[1];
        pk.IV_DEF = ivs[2];
        pk.IV_SPA = ivs[3];
        pk.IV_SPD = ivs[4];
        pk.IV_SPE = ivs[5];

        pk.RefreshAbility((int)xoro.NextUInt(2));
        pk.HeightScalar = (byte)(xoro.NextUInt(0x81) + xoro.NextUInt(0x80));
        pk.WeightScalar = (byte)(xoro.NextUInt(0x81) + xoro.NextUInt(0x80));

        EncounterUtil.SetEncounterMoves(pk, pk.Version, 50);
        pk.ResetPartyStats();

        return pk;
    }

    #endregion

    #region Results

    private void AddResultToGrid(SeedResult result)
    {
        var pk = result.Pokemon;
        var xor = ShinyXor(pk.PID, pk.ID32);
        bool isShiny = xor < 16;
        string shinyStr = isShiny ? (xor == 0 ? "■" : "★") : "—";
        string ivStr = $"{pk.IV_HP}/{pk.IV_ATK}/{pk.IV_DEF}/{pk.IV_SPA}/{pk.IV_SPD}/{pk.IV_SPE}";

        var row = resultsGrid.Rows.Add(
            result.Seed.ToString("X8"),
            shinyStr,
            pk.Nature.ToString(),
            GetAbilityName(pk),
            ivStr,
            pk.HeightScalar,
            pk.WeightScalar
        );

        _gridRowToResult[row] = result;

        if (isShiny)
        {
            resultsGrid.Rows[row].DefaultCellStyle.ForeColor = xor == 0 ? Color.DeepSkyBlue : Color.Gold;
        }
    }

    private static string GetAbilityName(PB8 pk)
    {
        var pi = PersonalTable.BDSP[pk.Species, pk.Form];
        int abilityIdx = pk.AbilityNumber >> 1;
        int abilityId = abilityIdx switch
        {
            0 => pi.Ability1,
            1 => pi.Ability2,
            _ => pi.AbilityH,
        };
        return GameInfo.Strings.abilitylist[abilityId];
    }

    private void ResultsGrid_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || !_gridRowToResult.TryGetValue(e.RowIndex, out var result))
            return;

        _pkmEditor.PopulateFields(result.Pokemon, false);
        statusLabel.Text = $"Loaded seed {result.Seed:X8} into editor.";
    }

    private void ResultsGrid_SelectionChanged(object? sender, EventArgs e)
    {
        if (resultsGrid.SelectedRows.Count == 0)
        {
            _previewPanel.Visible = false;
            return;
        }

        var rowIdx = resultsGrid.SelectedRows[0].Index;
        if (!_gridRowToResult.TryGetValue(rowIdx, out var result))
        {
            _previewPanel.Visible = false;
            return;
        }

        UpdatePreviewPanel(result);
        _previewPanel.Visible = true;
    }

    private void UpdatePreviewPanel(SeedResult result)
    {
        var pk = result.Pokemon;
        var xor = ShinyXor(pk.PID, pk.ID32);
        bool isShiny = xor < 16;
        string shinyTag = isShiny ? (xor == 0 ? " ■" : " ★") : "";

        var speciesName = SpeciesName.GetSpeciesNameGeneration(pk.Species, (int)LanguageID.English, 8);
        _previewTitle.Text = $"{speciesName}{shinyTag}";
        _previewTitle.ForeColor = isShiny ? (xor == 0 ? Color.DeepSkyBlue : Color.Gold) : Color.White;

        _previewDetails.Text = $"Seed: {result.Seed:X8}  |  {pk.Nature}  |  {GetAbilityName(pk)}  |  H:{pk.HeightScalar} W:{pk.WeightScalar}";

        _previewStats.Text = $"HP  {pk.IV_HP,2}  |  Atk {pk.IV_ATK,2}  |  Def {pk.IV_DEF,2}  |  SpA {pk.IV_SPA,2}  |  SpD {pk.IV_SPD,2}  |  Spe {pk.IV_SPE,2}";

        _ = LoadSpriteAsync(pk);
    }

    private async Task LoadSpriteAsync(PB8 pk)
    {
        try
        {
            var url = GetSpriteUrl(pk);
            var data = await _httpClient.GetByteArrayAsync(url);
            using var ms = new MemoryStream(data);
            _previewSprite.Image = Image.FromStream(ms);
        }
        catch
        {
            _previewSprite.Image = null;
        }
    }

    private static string GetSpriteUrl(PB8 pk)
    {
        bool isShiny = pk.IsShiny;
        var species = pk.Species.ToString();
        var shiny = isShiny ? "_shiny" : "";
        return $"https://raw.githubusercontent.com/kwsch/PKHeX/master/PKHeX.Drawing.PokeSprite/resources/img/Artwork%20Pokemon%20Sprites/a_{species}{shiny}.png";
    }

    private void ExportButton_Click(object? sender, EventArgs e)
    {
        if (_results.Count == 0 && _gridRowToResult.Count == 0)
        {
            WinFormsUtil.Alert("No results to export.");
            return;
        }

        using var sfd = new SaveFileDialog
        {
            Filter = "CSV Files|*.csv",
            FileName = $"BDSP_Seeds_{DateTime.Now:yyyyMMdd_HHmmss}.csv",
        };

        if (sfd.ShowDialog() != DialogResult.OK)
            return;

        var lines = new List<string> { "Seed,Shiny,Nature,Ability,HP,ATK,DEF,SPA,SPD,SPE,Height,Weight,EC,PID,TID,SID" };

        foreach (var kvp in _gridRowToResult.OrderBy(x => x.Value.Seed))
        {
            var r = kvp.Value;
            var pk = r.Pokemon;
            var xor = ShinyXor(pk.PID, pk.ID32);
            var shinyStr = xor < 16 ? (xor == 0 ? "Square" : "Star") : "No";
            var tid7 = pk.ID32 % 1000000;
            var sid7 = pk.ID32 / 1000000;
            lines.Add($"{r.Seed:X8},{shinyStr},{pk.Nature},{GetAbilityName(pk)},{pk.IV_HP},{pk.IV_ATK},{pk.IV_DEF},{pk.IV_SPA},{pk.IV_SPD},{pk.IV_SPE},{pk.HeightScalar},{pk.WeightScalar},{pk.EncryptionConstant:X8},{pk.PID:X8},{tid7},{sid7}");
        }

        File.WriteAllLines(sfd.FileName, lines);
        statusLabel.Text = $"Exported {lines.Count - 1} results to {Path.GetFileName(sfd.FileName)}";
    }

    #endregion

    private record SeedResult(uint Seed, PB8 Pokemon);
    private record ComboItem(string Text, int Value) { public override string ToString() => Text; }
    private record struct IVRange(int Min, int Max);
}
