using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using PKHeX.Core;
using BDSPSeedFinderPlugin.Helpers;

namespace BDSPSeedFinderPlugin;

public sealed class BDSPSeedFinderPlugin : IPlugin
{
    public string Name => "BDSP Seed Finder";
    public int Priority => 1;

    public ISaveFileProvider SaveFileEditor { get; private set; } = null!;
    public IPKMView PKMEditor { get; private set; } = null!;
    private ToolStripMenuItem? PluginMenuItem { get; set; }

    public void Initialize(params object[] args)
    {
        Console.WriteLine($"Loading {Name}...");

        if (PluginVersion.HasVersionMismatch())
            Console.WriteLine($"[{Name}] {PluginVersion.GetCompatibilityMessage()}");

        SaveFileEditor = (ISaveFileProvider)Array.Find(args, z => z is ISaveFileProvider)!;
        PKMEditor = (IPKMView)Array.Find(args, z => z is IPKMView)!;
        var menu = (ToolStrip)Array.Find(args, z => z is ToolStrip)!;
        LoadMenuStrip(menu);
    }

    private void LoadMenuStrip(ToolStrip menuStrip)
    {
        var items = menuStrip.Items;
        if (items.Find("Menu_Tools", false)[0] is not ToolStripDropDownItem tools)
            throw new ArgumentException(null, nameof(menuStrip));
        AddPluginControl(tools);
    }

    private void AddPluginControl(ToolStripDropDownItem tools)
    {
        PluginMenuItem = new ToolStripMenuItem(Name)
        {
            ShortcutKeys = Keys.Control | Keys.Shift | Keys.B,
            Image = CreateIcon()
        };

        PluginMenuItem.Click += (_, _) => ShowSeedFinderForm();
        tools.DropDownItems.Add(PluginMenuItem);
    }

    private static Bitmap CreateIcon()
    {
        var bmp = new Bitmap(16, 16);
        using var g = Graphics.FromImage(bmp);
        g.SmoothingMode = SmoothingMode.AntiAlias;

        var points = new Point[]
        {
            new(8, 2), new(13, 8), new(8, 14), new(3, 8)
        };

        using (var brush = new LinearGradientBrush(
            new Rectangle(0, 0, 16, 16),
            Color.FromArgb(200, 100, 180, 255),
            Color.FromArgb(200, 255, 200, 230),
            45f))
        {
            g.FillPolygon(brush, points);
        }

        using (var pen = new Pen(Color.FromArgb(255, 80, 130, 200), 1))
            g.DrawPolygon(pen, points);

        var shine = new Point[] { new(8, 4), new(10, 6), new(8, 8), new(6, 6) };
        using var shineBrush = new SolidBrush(Color.FromArgb(80, 255, 255, 255));
        g.FillPolygon(shineBrush, shine);

        return bmp;
    }

    private void ShowSeedFinderForm()
    {
        try
        {
            using var form = new GUI.Gen8bSeedFinderForm(SaveFileEditor, PKMEditor);
            form.ShowDialog();
        }
        catch (Exception ex)
        {
            WinFormsUtil.Error($"Error loading {Name}:", ex.Message);
        }
    }

    public void NotifySaveLoaded()
    {
        if (PluginMenuItem != null)
        {
            var sav = SaveFileEditor.SAV;
            PluginMenuItem.Enabled = sav.Version is GameVersion.BD or GameVersion.SP or GameVersion.BDSP;
        }
    }

    public bool TryLoadFile(string filePath) => false;
}
