namespace BDSPSeedFinderPlugin.GUI;

partial class Gen8bSeedFinderForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        mainPanel = new System.Windows.Forms.Panel();
        splitContainer = new System.Windows.Forms.SplitContainer();
        searchPanel = new System.Windows.Forms.Panel();
        resultsPanel = new System.Windows.Forms.Panel();
        statusStrip = new System.Windows.Forms.StatusStrip();
        statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        progressBar = new System.Windows.Forms.ToolStripProgressBar();

        // Target Pokemon Group
        targetGroup = new System.Windows.Forms.GroupBox();
        speciesCombo = new System.Windows.Forms.ComboBox();
        lblSpecies = new System.Windows.Forms.Label();

        // Search Criteria Group
        criteriaGroup = new System.Windows.Forms.GroupBox();
        lblAbility = new System.Windows.Forms.Label();
        abilityCombo = new System.Windows.Forms.ComboBox();
        lblNature = new System.Windows.Forms.Label();
        natureCombo = new System.Windows.Forms.ComboBox();
        lblShiny = new System.Windows.Forms.Label();
        shinyCombo = new System.Windows.Forms.ComboBox();
        lblTID = new System.Windows.Forms.Label();
        tidNum = new System.Windows.Forms.NumericUpDown();
        lblSID = new System.Windows.Forms.Label();
        sidNum = new System.Windows.Forms.NumericUpDown();

        // IV Ranges Group
        ivGroup = new System.Windows.Forms.GroupBox();
        lblHP = new System.Windows.Forms.Label();
        hpMinNum = new System.Windows.Forms.NumericUpDown();
        hpMaxNum = new System.Windows.Forms.NumericUpDown();
        lblAtk = new System.Windows.Forms.Label();
        atkMinNum = new System.Windows.Forms.NumericUpDown();
        atkMaxNum = new System.Windows.Forms.NumericUpDown();
        lblDef = new System.Windows.Forms.Label();
        defMinNum = new System.Windows.Forms.NumericUpDown();
        defMaxNum = new System.Windows.Forms.NumericUpDown();
        lblSpA = new System.Windows.Forms.Label();
        spaMinNum = new System.Windows.Forms.NumericUpDown();
        spaMaxNum = new System.Windows.Forms.NumericUpDown();
        lblSpD = new System.Windows.Forms.Label();
        spdMinNum = new System.Windows.Forms.NumericUpDown();
        spdMaxNum = new System.Windows.Forms.NumericUpDown();
        lblSpe = new System.Windows.Forms.Label();
        speMinNum = new System.Windows.Forms.NumericUpDown();
        speMaxNum = new System.Windows.Forms.NumericUpDown();

        // Search Options Group
        optionsGroup = new System.Windows.Forms.GroupBox();
        lblStartSeed = new System.Windows.Forms.Label();
        startSeedTextBox = new System.Windows.Forms.TextBox();
        lblEndSeed = new System.Windows.Forms.Label();
        endSeedTextBox = new System.Windows.Forms.TextBox();
        lblMaxResults = new System.Windows.Forms.Label();
        maxResultsNum = new System.Windows.Forms.NumericUpDown();
        searchButton = new System.Windows.Forms.Button();
        exportButton = new System.Windows.Forms.Button();

        // Results Grid
        resultsGrid = new System.Windows.Forms.DataGridView();

        mainPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
        splitContainer.Panel1.SuspendLayout();
        splitContainer.Panel2.SuspendLayout();
        splitContainer.SuspendLayout();
        searchPanel.SuspendLayout();
        resultsPanel.SuspendLayout();
        statusStrip.SuspendLayout();
        targetGroup.SuspendLayout();
        criteriaGroup.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)tidNum).BeginInit();
        ((System.ComponentModel.ISupportInitialize)sidNum).BeginInit();
        ivGroup.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)hpMinNum).BeginInit();
        ((System.ComponentModel.ISupportInitialize)hpMaxNum).BeginInit();
        ((System.ComponentModel.ISupportInitialize)atkMinNum).BeginInit();
        ((System.ComponentModel.ISupportInitialize)atkMaxNum).BeginInit();
        ((System.ComponentModel.ISupportInitialize)defMinNum).BeginInit();
        ((System.ComponentModel.ISupportInitialize)defMaxNum).BeginInit();
        ((System.ComponentModel.ISupportInitialize)spaMinNum).BeginInit();
        ((System.ComponentModel.ISupportInitialize)spaMaxNum).BeginInit();
        ((System.ComponentModel.ISupportInitialize)spdMinNum).BeginInit();
        ((System.ComponentModel.ISupportInitialize)spdMaxNum).BeginInit();
        ((System.ComponentModel.ISupportInitialize)speMinNum).BeginInit();
        ((System.ComponentModel.ISupportInitialize)speMaxNum).BeginInit();
        optionsGroup.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)maxResultsNum).BeginInit();
        ((System.ComponentModel.ISupportInitialize)resultsGrid).BeginInit();
        SuspendLayout();

        // mainPanel
        mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        mainPanel.Controls.Add(splitContainer);
        mainPanel.Controls.Add(statusStrip);

        // splitContainer
        splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
        splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
        splitContainer.SplitterDistance = 320;
        splitContainer.Panel1.Controls.Add(searchPanel);
        splitContainer.Panel2.Controls.Add(resultsPanel);

        // searchPanel
        searchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        searchPanel.AutoScroll = true;
        searchPanel.Padding = new System.Windows.Forms.Padding(8);

        int y = 8;

        // === Target Pokemon Group ===
        targetGroup.Text = "Target Pokemon";
        targetGroup.Location = new System.Drawing.Point(8, y);
        targetGroup.Size = new System.Drawing.Size(295, 60);

        lblSpecies.Text = "Species:";
        lblSpecies.Location = new System.Drawing.Point(10, 24);
        lblSpecies.AutoSize = true;

        speciesCombo.Location = new System.Drawing.Point(75, 21);
        speciesCombo.Size = new System.Drawing.Size(205, 23);
        speciesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

        targetGroup.Controls.AddRange([lblSpecies, speciesCombo]);
        searchPanel.Controls.Add(targetGroup);
        y += 68;

        // === Search Criteria Group ===
        criteriaGroup.Text = "Search Criteria";
        criteriaGroup.Location = new System.Drawing.Point(8, y);
        criteriaGroup.Size = new System.Drawing.Size(295, 175);

        int cy = 22;
        lblAbility.Text = "Ability:";
        lblAbility.Location = new System.Drawing.Point(10, cy);
        lblAbility.AutoSize = true;
        abilityCombo.Location = new System.Drawing.Point(75, cy - 3);
        abilityCombo.Size = new System.Drawing.Size(205, 23);
        abilityCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        abilityCombo.Items.AddRange(["Any", "Ability 1", "Ability 2"]);
        abilityCombo.SelectedIndex = 0;
        cy += 30;

        lblNature.Text = "Nature:";
        lblNature.Location = new System.Drawing.Point(10, cy);
        lblNature.AutoSize = true;
        natureCombo.Location = new System.Drawing.Point(75, cy - 3);
        natureCombo.Size = new System.Drawing.Size(205, 23);
        natureCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cy += 30;

        lblShiny.Text = "Shiny:";
        lblShiny.Location = new System.Drawing.Point(10, cy);
        lblShiny.AutoSize = true;
        shinyCombo.Location = new System.Drawing.Point(75, cy - 3);
        shinyCombo.Size = new System.Drawing.Size(205, 23);
        shinyCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        shinyCombo.Items.AddRange(["Random", "Never", "Always", "Square", "Star"]);
        shinyCombo.SelectedIndex = 0;
        cy += 30;

        lblTID.Text = "TID:";
        lblTID.Location = new System.Drawing.Point(10, cy);
        lblTID.AutoSize = true;
        tidNum.Location = new System.Drawing.Point(75, cy - 3);
        tidNum.Size = new System.Drawing.Size(90, 23);
        tidNum.Maximum = 999999;

        lblSID.Text = "SID:";
        lblSID.Location = new System.Drawing.Point(170, cy);
        lblSID.AutoSize = true;
        sidNum.Location = new System.Drawing.Point(200, cy - 3);
        sidNum.Size = new System.Drawing.Size(80, 23);
        sidNum.Maximum = 4294;

        criteriaGroup.Controls.AddRange([lblAbility, abilityCombo, lblNature, natureCombo, lblShiny, shinyCombo, lblTID, tidNum, lblSID, sidNum]);
        searchPanel.Controls.Add(criteriaGroup);
        y += 183;

        // === IV Ranges Group ===
        ivGroup.Text = "IV Ranges";
        ivGroup.Location = new System.Drawing.Point(8, y);
        ivGroup.Size = new System.Drawing.Size(295, 200);

        string[] statNames = ["HP", "Atk", "Def", "SpA", "SpD", "Spe"];
        System.Windows.Forms.Label[] statLabels = [lblHP, lblAtk, lblDef, lblSpA, lblSpD, lblSpe];
        System.Windows.Forms.NumericUpDown[] minNums = [hpMinNum, atkMinNum, defMinNum, spaMinNum, spdMinNum, speMinNum];
        System.Windows.Forms.NumericUpDown[] maxNums = [hpMaxNum, atkMaxNum, defMaxNum, spaMaxNum, spdMaxNum, speMaxNum];

        int iy = 20;
        for (int i = 0; i < 6; i++)
        {
            statLabels[i].Text = statNames[i] + ":";
            statLabels[i].Location = new System.Drawing.Point(10, iy + 3);
            statLabels[i].AutoSize = true;

            minNums[i].Location = new System.Drawing.Point(55, iy);
            minNums[i].Size = new System.Drawing.Size(55, 23);
            minNums[i].Maximum = 31;
            minNums[i].Value = 0;

            var dash = new System.Windows.Forms.Label();
            dash.Text = "-";
            dash.Location = new System.Drawing.Point(113, iy + 3);
            dash.AutoSize = true;

            maxNums[i].Location = new System.Drawing.Point(125, iy);
            maxNums[i].Size = new System.Drawing.Size(55, 23);
            maxNums[i].Maximum = 31;
            maxNums[i].Value = 31;

            ivGroup.Controls.AddRange([statLabels[i], minNums[i], dash, maxNums[i]]);
            iy += 28;
        }

        searchPanel.Controls.Add(ivGroup);
        y += 208;

        // === Search Options Group ===
        optionsGroup.Text = "Search Options";
        optionsGroup.Location = new System.Drawing.Point(8, y);
        optionsGroup.Size = new System.Drawing.Size(295, 165);

        int oy = 22;
        lblStartSeed.Text = "Start Seed:";
        lblStartSeed.Location = new System.Drawing.Point(10, oy);
        lblStartSeed.AutoSize = true;
        startSeedTextBox.Location = new System.Drawing.Point(90, oy - 3);
        startSeedTextBox.Size = new System.Drawing.Size(190, 23);
        startSeedTextBox.Text = "00000000";
        startSeedTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        oy += 28;

        lblEndSeed.Text = "End Seed:";
        lblEndSeed.Location = new System.Drawing.Point(10, oy);
        lblEndSeed.AutoSize = true;
        endSeedTextBox.Location = new System.Drawing.Point(90, oy - 3);
        endSeedTextBox.Size = new System.Drawing.Size(190, 23);
        endSeedTextBox.Text = "FFFFFFFF";
        endSeedTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        oy += 28;

        lblMaxResults.Text = "Max Results:";
        lblMaxResults.Location = new System.Drawing.Point(10, oy);
        lblMaxResults.AutoSize = true;
        maxResultsNum.Location = new System.Drawing.Point(90, oy - 3);
        maxResultsNum.Size = new System.Drawing.Size(90, 23);
        maxResultsNum.Minimum = 1;
        maxResultsNum.Maximum = 10000;
        maxResultsNum.Value = 100;
        oy += 32;

        searchButton.Text = "Search";
        searchButton.Location = new System.Drawing.Point(10, oy);
        searchButton.Size = new System.Drawing.Size(135, 35);
        searchButton.Click += SearchButton_Click;

        exportButton.Text = "Export Results";
        exportButton.Location = new System.Drawing.Point(150, oy);
        exportButton.Size = new System.Drawing.Size(135, 35);
        exportButton.Click += ExportButton_Click;

        optionsGroup.Controls.AddRange([lblStartSeed, startSeedTextBox, lblEndSeed, endSeedTextBox, lblMaxResults, maxResultsNum, searchButton, exportButton]);
        searchPanel.Controls.Add(optionsGroup);

        // === Results Grid ===
        resultsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
        resultsGrid.AllowUserToAddRows = false;
        resultsGrid.AllowUserToDeleteRows = false;
        resultsGrid.AllowUserToResizeRows = false;
        resultsGrid.ReadOnly = true;
        resultsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        resultsGrid.MultiSelect = false;
        resultsGrid.RowHeadersVisible = false;
        resultsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        resultsGrid.DoubleBuffered(true);

        resultsGrid.BackgroundColor = System.Drawing.Color.FromArgb(45, 45, 48);
        resultsGrid.GridColor = System.Drawing.Color.FromArgb(60, 60, 60);
        resultsGrid.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
        resultsGrid.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
        resultsGrid.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
        resultsGrid.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
        resultsGrid.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(50, 50, 54);
        resultsGrid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
        resultsGrid.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
        resultsGrid.EnableHeadersVisualStyles = false;

        resultsGrid.Columns.AddRange(
            new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "Seed", HeaderText = "Seed", Width = 90, FillWeight = 15 },
            new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "Shiny", HeaderText = "Shiny", Width = 50, FillWeight = 8 },
            new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "Nature", HeaderText = "Nature", Width = 80, FillWeight = 12 },
            new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "Ability", HeaderText = "Ability", Width = 70, FillWeight = 10 },
            new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "IVs", HeaderText = "IVs", Width = 130, FillWeight = 22 },
            new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "Height", HeaderText = "Height", Width = 50, FillWeight = 8 },
            new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "Weight", HeaderText = "Weight", Width = 50, FillWeight = 8 }
        );

        resultsGrid.CellDoubleClick += ResultsGrid_CellDoubleClick;
        resultsGrid.SelectionChanged += ResultsGrid_SelectionChanged;

        resultsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        resultsPanel.Controls.Add(resultsGrid);

        // statusStrip
        statusStrip.Items.AddRange([statusLabel, progressBar]);
        statusLabel.Text = "Ready";
        statusLabel.Spring = true;
        statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        progressBar.Visible = false;
        progressBar.Size = new System.Drawing.Size(200, 16);

        // Form
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(950, 600);
        MinimumSize = new System.Drawing.Size(850, 500);
        Controls.Add(mainPanel);
        Text = "BDSP Roaming Seed Finder";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

        mainPanel.ResumeLayout(false);
        splitContainer.Panel1.ResumeLayout(false);
        splitContainer.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
        splitContainer.ResumeLayout(false);
        searchPanel.ResumeLayout(false);
        resultsPanel.ResumeLayout(false);
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        targetGroup.ResumeLayout(false);
        targetGroup.PerformLayout();
        criteriaGroup.ResumeLayout(false);
        criteriaGroup.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)tidNum).EndInit();
        ((System.ComponentModel.ISupportInitialize)sidNum).EndInit();
        ivGroup.ResumeLayout(false);
        ivGroup.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)hpMinNum).EndInit();
        ((System.ComponentModel.ISupportInitialize)hpMaxNum).EndInit();
        ((System.ComponentModel.ISupportInitialize)atkMinNum).EndInit();
        ((System.ComponentModel.ISupportInitialize)atkMaxNum).EndInit();
        ((System.ComponentModel.ISupportInitialize)defMinNum).EndInit();
        ((System.ComponentModel.ISupportInitialize)defMaxNum).EndInit();
        ((System.ComponentModel.ISupportInitialize)spaMinNum).EndInit();
        ((System.ComponentModel.ISupportInitialize)spaMaxNum).EndInit();
        ((System.ComponentModel.ISupportInitialize)spdMinNum).EndInit();
        ((System.ComponentModel.ISupportInitialize)spdMaxNum).EndInit();
        ((System.ComponentModel.ISupportInitialize)speMinNum).EndInit();
        ((System.ComponentModel.ISupportInitialize)speMaxNum).EndInit();
        optionsGroup.ResumeLayout(false);
        optionsGroup.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)maxResultsNum).EndInit();
        ((System.ComponentModel.ISupportInitialize)resultsGrid).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel mainPanel;
    private System.Windows.Forms.SplitContainer splitContainer;
    private System.Windows.Forms.Panel searchPanel;
    private System.Windows.Forms.Panel resultsPanel;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    private System.Windows.Forms.ToolStripProgressBar progressBar;

    private System.Windows.Forms.GroupBox targetGroup;
    private System.Windows.Forms.Label lblSpecies;
    private System.Windows.Forms.ComboBox speciesCombo;

    private System.Windows.Forms.GroupBox criteriaGroup;
    private System.Windows.Forms.Label lblAbility;
    private System.Windows.Forms.ComboBox abilityCombo;
    private System.Windows.Forms.Label lblNature;
    private System.Windows.Forms.ComboBox natureCombo;
    private System.Windows.Forms.Label lblShiny;
    private System.Windows.Forms.ComboBox shinyCombo;
    private System.Windows.Forms.Label lblTID;
    private System.Windows.Forms.NumericUpDown tidNum;
    private System.Windows.Forms.Label lblSID;
    private System.Windows.Forms.NumericUpDown sidNum;

    private System.Windows.Forms.GroupBox ivGroup;
    private System.Windows.Forms.Label lblHP;
    private System.Windows.Forms.NumericUpDown hpMinNum;
    private System.Windows.Forms.NumericUpDown hpMaxNum;
    private System.Windows.Forms.Label lblAtk;
    private System.Windows.Forms.NumericUpDown atkMinNum;
    private System.Windows.Forms.NumericUpDown atkMaxNum;
    private System.Windows.Forms.Label lblDef;
    private System.Windows.Forms.NumericUpDown defMinNum;
    private System.Windows.Forms.NumericUpDown defMaxNum;
    private System.Windows.Forms.Label lblSpA;
    private System.Windows.Forms.NumericUpDown spaMinNum;
    private System.Windows.Forms.NumericUpDown spaMaxNum;
    private System.Windows.Forms.Label lblSpD;
    private System.Windows.Forms.NumericUpDown spdMinNum;
    private System.Windows.Forms.NumericUpDown spdMaxNum;
    private System.Windows.Forms.Label lblSpe;
    private System.Windows.Forms.NumericUpDown speMinNum;
    private System.Windows.Forms.NumericUpDown speMaxNum;

    private System.Windows.Forms.GroupBox optionsGroup;
    private System.Windows.Forms.Label lblStartSeed;
    private System.Windows.Forms.TextBox startSeedTextBox;
    private System.Windows.Forms.Label lblEndSeed;
    private System.Windows.Forms.TextBox endSeedTextBox;
    private System.Windows.Forms.Label lblMaxResults;
    private System.Windows.Forms.NumericUpDown maxResultsNum;
    private System.Windows.Forms.Button searchButton;
    private System.Windows.Forms.Button exportButton;

    private System.Windows.Forms.DataGridView resultsGrid;
}

internal static class DataGridViewExtensions
{
    public static void DoubleBuffered(this System.Windows.Forms.DataGridView dgv, bool setting)
    {
        var type = dgv.GetType();
        var prop = type.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
        prop?.SetValue(dgv, setting, null);
    }
}
