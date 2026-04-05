namespace BDSPSeedFinderPlugin.GUI
{
    partial class Gen8bSeedFinderForm
    {
        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();

            this.searchPanel = new System.Windows.Forms.Panel();
            this.speciesGroup = new System.Windows.Forms.GroupBox();
            this.speciesLabel = new System.Windows.Forms.Label();
            this.speciesCombo = new System.Windows.Forms.ComboBox();

            this.criteriaGroup = new System.Windows.Forms.GroupBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.genderCombo = new System.Windows.Forms.ComboBox();
            this.abilityLabel = new System.Windows.Forms.Label();
            this.abilityCombo = new System.Windows.Forms.ComboBox();
            this.natureLabel = new System.Windows.Forms.Label();
            this.natureCombo = new System.Windows.Forms.ComboBox();
            this.shinyLabel = new System.Windows.Forms.Label();
            this.shinyCombo = new System.Windows.Forms.ComboBox();
            this.tidLabel = new System.Windows.Forms.Label();
            this.tidNum = new System.Windows.Forms.NumericUpDown();
            this.sidLabel = new System.Windows.Forms.Label();
            this.sidNum = new System.Windows.Forms.NumericUpDown();

            this.ivGroup = new System.Windows.Forms.GroupBox();
            this.ivMinLabel = new System.Windows.Forms.Label();
            this.ivMaxLabel = new System.Windows.Forms.Label();
            this.ivHpLabel = new System.Windows.Forms.Label();
            this.ivHpMin = new System.Windows.Forms.NumericUpDown();
            this.ivHpMax = new System.Windows.Forms.NumericUpDown();
            this.ivAtkLabel = new System.Windows.Forms.Label();
            this.ivAtkMin = new System.Windows.Forms.NumericUpDown();
            this.ivAtkMax = new System.Windows.Forms.NumericUpDown();
            this.ivDefLabel = new System.Windows.Forms.Label();
            this.ivDefMin = new System.Windows.Forms.NumericUpDown();
            this.ivDefMax = new System.Windows.Forms.NumericUpDown();
            this.ivSpaLabel = new System.Windows.Forms.Label();
            this.ivSpaMin = new System.Windows.Forms.NumericUpDown();
            this.ivSpaMax = new System.Windows.Forms.NumericUpDown();
            this.ivSpdLabel = new System.Windows.Forms.Label();
            this.ivSpdMin = new System.Windows.Forms.NumericUpDown();
            this.ivSpdMax = new System.Windows.Forms.NumericUpDown();
            this.ivSpeLabel = new System.Windows.Forms.Label();
            this.ivSpeMin = new System.Windows.Forms.NumericUpDown();
            this.ivSpeMax = new System.Windows.Forms.NumericUpDown();

            this.searchOptionsGroup = new System.Windows.Forms.GroupBox();
            this.maxSeedsLabel = new System.Windows.Forms.Label();
            this.maxSeedsNum = new System.Windows.Forms.NumericUpDown();
            this.startSeedLabel = new System.Windows.Forms.Label();
            this.startSeedTextBox = new System.Windows.Forms.TextBox();
            this.endSeedLabel = new System.Windows.Forms.Label();
            this.endSeedTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();

            this.resultsPanel = new System.Windows.Forms.Panel();
            this.resultsGrid = new System.Windows.Forms.DataGridView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();

            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.speciesGroup.SuspendLayout();
            this.criteriaGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tidNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sidNum)).BeginInit();
            this.ivGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ivHpMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivHpMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivAtkMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivAtkMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivDefMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivDefMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivSpaMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivSpaMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivSpdMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivSpdMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivSpeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivSpeMax)).BeginInit();
            this.searchOptionsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxSeedsNum)).BeginInit();
            this.resultsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 750);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.statusStrip);
            this.MinimumSize = new System.Drawing.Size(1100, 750);
            this.Name = "Gen8bSeedFinderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BDSP Roaming Seed Finder";

            // mainPanel
            this.mainPanel.Controls.Add(this.splitContainer);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1100, 728);
            this.mainPanel.TabIndex = 0;

            // splitContainer
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Panel1.Controls.Add(this.searchPanel);
            this.splitContainer.Panel2.Controls.Add(this.resultsPanel);
            this.splitContainer.Size = new System.Drawing.Size(1100, 728);
            this.splitContainer.SplitterDistance = 380;
            this.splitContainer.TabIndex = 0;

            // searchPanel
            this.searchPanel.AutoScroll = true;
            this.searchPanel.Controls.Add(this.searchOptionsGroup);
            this.searchPanel.Controls.Add(this.ivGroup);
            this.searchPanel.Controls.Add(this.criteriaGroup);
            this.searchPanel.Controls.Add(this.speciesGroup);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPanel.Location = new System.Drawing.Point(0, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Padding = new System.Windows.Forms.Padding(5);
            this.searchPanel.Size = new System.Drawing.Size(380, 728);
            this.searchPanel.TabIndex = 0;

            // speciesGroup
            this.speciesGroup.Controls.Add(this.speciesCombo);
            this.speciesGroup.Controls.Add(this.speciesLabel);
            this.speciesGroup.Location = new System.Drawing.Point(8, 8);
            this.speciesGroup.Name = "speciesGroup";
            this.speciesGroup.Size = new System.Drawing.Size(360, 55);
            this.speciesGroup.TabIndex = 0;
            this.speciesGroup.TabStop = false;
            this.speciesGroup.Text = "Target Pokémon";

            // speciesLabel
            this.speciesLabel.AutoSize = true;
            this.speciesLabel.Location = new System.Drawing.Point(10, 25);
            this.speciesLabel.Name = "speciesLabel";
            this.speciesLabel.Size = new System.Drawing.Size(49, 15);
            this.speciesLabel.TabIndex = 0;
            this.speciesLabel.Text = "Species:";

            // speciesCombo
            this.speciesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speciesCombo.FormattingEnabled = true;
            this.speciesCombo.Location = new System.Drawing.Point(80, 22);
            this.speciesCombo.Name = "speciesCombo";
            this.speciesCombo.Size = new System.Drawing.Size(270, 23);
            this.speciesCombo.TabIndex = 1;

            // criteriaGroup
            this.criteriaGroup.Controls.Add(this.sidNum);
            this.criteriaGroup.Controls.Add(this.sidLabel);
            this.criteriaGroup.Controls.Add(this.tidNum);
            this.criteriaGroup.Controls.Add(this.tidLabel);
            this.criteriaGroup.Controls.Add(this.shinyCombo);
            this.criteriaGroup.Controls.Add(this.shinyLabel);
            this.criteriaGroup.Controls.Add(this.natureCombo);
            this.criteriaGroup.Controls.Add(this.natureLabel);
            this.criteriaGroup.Controls.Add(this.abilityCombo);
            this.criteriaGroup.Controls.Add(this.abilityLabel);
            this.criteriaGroup.Controls.Add(this.genderCombo);
            this.criteriaGroup.Controls.Add(this.genderLabel);
            this.criteriaGroup.Location = new System.Drawing.Point(8, 68);
            this.criteriaGroup.Name = "criteriaGroup";
            this.criteriaGroup.Size = new System.Drawing.Size(360, 115);
            this.criteriaGroup.TabIndex = 1;
            this.criteriaGroup.TabStop = false;
            this.criteriaGroup.Text = "Search Criteria";

            // genderLabel
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(10, 25);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(48, 15);
            this.genderLabel.TabIndex = 0;
            this.genderLabel.Text = "Gender:";

            // genderCombo
            this.genderCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderCombo.FormattingEnabled = true;
            this.genderCombo.Items.AddRange(new object[] { "Random", "Male", "Female", "Genderless" });
            this.genderCombo.Location = new System.Drawing.Point(80, 22);
            this.genderCombo.Name = "genderCombo";
            this.genderCombo.Size = new System.Drawing.Size(100, 23);
            this.genderCombo.TabIndex = 1;
            this.genderCombo.SelectedIndex = 0;

            // abilityLabel
            this.abilityLabel.AutoSize = true;
            this.abilityLabel.Location = new System.Drawing.Point(10, 55);
            this.abilityLabel.Name = "abilityLabel";
            this.abilityLabel.Size = new System.Drawing.Size(44, 15);
            this.abilityLabel.TabIndex = 2;
            this.abilityLabel.Text = "Ability:";

            // abilityCombo
            this.abilityCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.abilityCombo.FormattingEnabled = true;
            this.abilityCombo.Items.AddRange(new object[] { "Any", "Ability 1", "Ability 2" });
            this.abilityCombo.Location = new System.Drawing.Point(80, 52);
            this.abilityCombo.Name = "abilityCombo";
            this.abilityCombo.Size = new System.Drawing.Size(100, 23);
            this.abilityCombo.TabIndex = 3;
            this.abilityCombo.SelectedIndex = 0;

            // natureLabel
            this.natureLabel.AutoSize = true;
            this.natureLabel.Location = new System.Drawing.Point(190, 25);
            this.natureLabel.Name = "natureLabel";
            this.natureLabel.Size = new System.Drawing.Size(46, 15);
            this.natureLabel.TabIndex = 4;
            this.natureLabel.Text = "Nature:";

            // natureCombo
            this.natureCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.natureCombo.FormattingEnabled = true;
            this.natureCombo.Location = new System.Drawing.Point(240, 22);
            this.natureCombo.Name = "natureCombo";
            this.natureCombo.Size = new System.Drawing.Size(110, 23);
            this.natureCombo.TabIndex = 5;

            // shinyLabel
            this.shinyLabel.AutoSize = true;
            this.shinyLabel.Location = new System.Drawing.Point(190, 55);
            this.shinyLabel.Name = "shinyLabel";
            this.shinyLabel.Size = new System.Drawing.Size(39, 15);
            this.shinyLabel.TabIndex = 6;
            this.shinyLabel.Text = "Shiny:";

            // shinyCombo
            this.shinyCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shinyCombo.FormattingEnabled = true;
            this.shinyCombo.Items.AddRange(new object[] { "No", "Yes" });
            this.shinyCombo.Location = new System.Drawing.Point(240, 52);
            this.shinyCombo.Name = "shinyCombo";
            this.shinyCombo.Size = new System.Drawing.Size(110, 23);
            this.shinyCombo.TabIndex = 7;
            this.shinyCombo.SelectedIndex = 0;

            // tidLabel
            this.tidLabel.AutoSize = true;
            this.tidLabel.Location = new System.Drawing.Point(10, 85);
            this.tidLabel.Name = "tidLabel";
            this.tidLabel.Size = new System.Drawing.Size(41, 15);
            this.tidLabel.TabIndex = 8;
            this.tidLabel.Text = "TID:";

            // tidNum
            this.tidNum.Location = new System.Drawing.Point(80, 82);
            this.tidNum.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            this.tidNum.Name = "tidNum";
            this.tidNum.Size = new System.Drawing.Size(100, 23);
            this.tidNum.TabIndex = 9;

            // sidLabel
            this.sidLabel.AutoSize = true;
            this.sidLabel.Location = new System.Drawing.Point(190, 85);
            this.sidLabel.Name = "sidLabel";
            this.sidLabel.Size = new System.Drawing.Size(41, 15);
            this.sidLabel.TabIndex = 10;
            this.sidLabel.Text = "SID:";

            // sidNum
            this.sidNum.Location = new System.Drawing.Point(240, 82);
            this.sidNum.Maximum = new decimal(new int[] { 4294, 0, 0, 0 });
            this.sidNum.Name = "sidNum";
            this.sidNum.Size = new System.Drawing.Size(110, 23);
            this.sidNum.TabIndex = 11;

            // ivGroup
            this.ivGroup.Controls.Add(this.ivMaxLabel);
            this.ivGroup.Controls.Add(this.ivMinLabel);
            this.ivGroup.Controls.Add(this.ivSpeMax);
            this.ivGroup.Controls.Add(this.ivSpeMin);
            this.ivGroup.Controls.Add(this.ivSpeLabel);
            this.ivGroup.Controls.Add(this.ivSpdMax);
            this.ivGroup.Controls.Add(this.ivSpdMin);
            this.ivGroup.Controls.Add(this.ivSpdLabel);
            this.ivGroup.Controls.Add(this.ivSpaMax);
            this.ivGroup.Controls.Add(this.ivSpaMin);
            this.ivGroup.Controls.Add(this.ivSpaLabel);
            this.ivGroup.Controls.Add(this.ivDefMax);
            this.ivGroup.Controls.Add(this.ivDefMin);
            this.ivGroup.Controls.Add(this.ivDefLabel);
            this.ivGroup.Controls.Add(this.ivAtkMax);
            this.ivGroup.Controls.Add(this.ivAtkMin);
            this.ivGroup.Controls.Add(this.ivAtkLabel);
            this.ivGroup.Controls.Add(this.ivHpMax);
            this.ivGroup.Controls.Add(this.ivHpMin);
            this.ivGroup.Controls.Add(this.ivHpLabel);
            this.ivGroup.Location = new System.Drawing.Point(8, 189);
            this.ivGroup.Name = "ivGroup";
            this.ivGroup.Size = new System.Drawing.Size(360, 110);
            this.ivGroup.TabIndex = 2;
            this.ivGroup.TabStop = false;
            this.ivGroup.Text = "IV Ranges";

            // ivMinLabel
            this.ivMinLabel.AutoSize = true;
            this.ivMinLabel.Location = new System.Drawing.Point(40, 20);
            this.ivMinLabel.Name = "ivMinLabel";
            this.ivMinLabel.Size = new System.Drawing.Size(28, 15);
            this.ivMinLabel.TabIndex = 0;
            this.ivMinLabel.Text = "Min";

            // ivMaxLabel
            this.ivMaxLabel.AutoSize = true;
            this.ivMaxLabel.Location = new System.Drawing.Point(85, 20);
            this.ivMaxLabel.Name = "ivMaxLabel";
            this.ivMaxLabel.Size = new System.Drawing.Size(30, 15);
            this.ivMaxLabel.TabIndex = 1;
            this.ivMaxLabel.Text = "Max";

            // Row 1: HP, ATK, DEF
            // ivHpLabel
            this.ivHpLabel.AutoSize = true;
            this.ivHpLabel.Location = new System.Drawing.Point(10, 45);
            this.ivHpLabel.Name = "ivHpLabel";
            this.ivHpLabel.Size = new System.Drawing.Size(26, 15);
            this.ivHpLabel.Text = "HP:";

            // ivHpMin
            this.ivHpMin.Location = new System.Drawing.Point(40, 43);
            this.ivHpMin.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            this.ivHpMin.Size = new System.Drawing.Size(40, 23);

            // ivHpMax
            this.ivHpMax.Location = new System.Drawing.Point(85, 43);
            this.ivHpMax.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            this.ivHpMax.Size = new System.Drawing.Size(40, 23);
            this.ivHpMax.Value = new decimal(new int[] { 31, 0, 0, 0 });

            // ivAtkLabel
            this.ivAtkLabel.AutoSize = true;
            this.ivAtkLabel.Location = new System.Drawing.Point(130, 45);
            this.ivAtkLabel.Name = "ivAtkLabel";
            this.ivAtkLabel.Size = new System.Drawing.Size(30, 15);
            this.ivAtkLabel.Text = "ATK:";

            // ivAtkMin
            this.ivAtkMin.Location = new System.Drawing.Point(165, 43);
            this.ivAtkMin.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            this.ivAtkMin.Size = new System.Drawing.Size(40, 23);

            // ivAtkMax
            this.ivAtkMax.Location = new System.Drawing.Point(210, 43);
            this.ivAtkMax.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            this.ivAtkMax.Size = new System.Drawing.Size(40, 23);
            this.ivAtkMax.Value = new decimal(new int[] { 31, 0, 0, 0 });

            // ivDefLabel
            this.ivDefLabel.AutoSize = true;
            this.ivDefLabel.Location = new System.Drawing.Point(255, 45);
            this.ivDefLabel.Name = "ivDefLabel";
            this.ivDefLabel.Size = new System.Drawing.Size(30, 15);
            this.ivDefLabel.Text = "DEF:";

            // ivDefMin
            this.ivDefMin.Location = new System.Drawing.Point(290, 43);
            this.ivDefMin.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            this.ivDefMin.Size = new System.Drawing.Size(40, 23);

            // ivDefMax
            this.ivDefMax.Location = new System.Drawing.Point(335, 43);
            this.ivDefMax.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            this.ivDefMax.Size = new System.Drawing.Size(40, 23);
            this.ivDefMax.Value = new decimal(new int[] { 31, 0, 0, 0 });

            // Row 2: SPA, SPD, SPE
            // ivSpaLabel
            this.ivSpaLabel.AutoSize = true;
            this.ivSpaLabel.Location = new System.Drawing.Point(10, 75);
            this.ivSpaLabel.Name = "ivSpaLabel";
            this.ivSpaLabel.Size = new System.Drawing.Size(29, 15);
            this.ivSpaLabel.Text = "SPA:";

            // ivSpaMin
            this.ivSpaMin.Location = new System.Drawing.Point(40, 73);
            this.ivSpaMin.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            this.ivSpaMin.Size = new System.Drawing.Size(40, 23);

            // ivSpaMax
            this.ivSpaMax.Location = new System.Drawing.Point(85, 73);
            this.ivSpaMax.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            this.ivSpaMax.Size = new System.Drawing.Size(40, 23);
            this.ivSpaMax.Value = new decimal(new int[] { 31, 0, 0, 0 });

            // ivSpdLabel
            this.ivSpdLabel.AutoSize = true;
            this.ivSpdLabel.Location = new System.Drawing.Point(130, 75);
            this.ivSpdLabel.Name = "ivSpdLabel";
            this.ivSpdLabel.Size = new System.Drawing.Size(30, 15);
            this.ivSpdLabel.Text = "SPD:";

            // ivSpdMin
            this.ivSpdMin.Location = new System.Drawing.Point(165, 73);
            this.ivSpdMin.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            this.ivSpdMin.Size = new System.Drawing.Size(40, 23);

            // ivSpdMax
            this.ivSpdMax.Location = new System.Drawing.Point(210, 73);
            this.ivSpdMax.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            this.ivSpdMax.Size = new System.Drawing.Size(40, 23);
            this.ivSpdMax.Value = new decimal(new int[] { 31, 0, 0, 0 });

            // ivSpeLabel
            this.ivSpeLabel.AutoSize = true;
            this.ivSpeLabel.Location = new System.Drawing.Point(255, 75);
            this.ivSpeLabel.Name = "ivSpeLabel";
            this.ivSpeLabel.Size = new System.Drawing.Size(28, 15);
            this.ivSpeLabel.Text = "SPE:";

            // ivSpeMin
            this.ivSpeMin.Location = new System.Drawing.Point(290, 73);
            this.ivSpeMin.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            this.ivSpeMin.Size = new System.Drawing.Size(40, 23);

            // ivSpeMax
            this.ivSpeMax.Location = new System.Drawing.Point(335, 73);
            this.ivSpeMax.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            this.ivSpeMax.Size = new System.Drawing.Size(40, 23);
            this.ivSpeMax.Value = new decimal(new int[] { 31, 0, 0, 0 });

            // searchOptionsGroup
            this.searchOptionsGroup.Controls.Add(this.exportButton);
            this.searchOptionsGroup.Controls.Add(this.searchButton);
            this.searchOptionsGroup.Controls.Add(this.endSeedTextBox);
            this.searchOptionsGroup.Controls.Add(this.endSeedLabel);
            this.searchOptionsGroup.Controls.Add(this.startSeedTextBox);
            this.searchOptionsGroup.Controls.Add(this.startSeedLabel);
            this.searchOptionsGroup.Controls.Add(this.maxSeedsNum);
            this.searchOptionsGroup.Controls.Add(this.maxSeedsLabel);
            this.searchOptionsGroup.Location = new System.Drawing.Point(8, 305);
            this.searchOptionsGroup.Name = "searchOptionsGroup";
            this.searchOptionsGroup.Size = new System.Drawing.Size(360, 150);
            this.searchOptionsGroup.TabIndex = 3;
            this.searchOptionsGroup.TabStop = false;
            this.searchOptionsGroup.Text = "Search Options";

            // maxSeedsLabel
            this.maxSeedsLabel.AutoSize = true;
            this.maxSeedsLabel.Location = new System.Drawing.Point(10, 30);
            this.maxSeedsLabel.Name = "maxSeedsLabel";
            this.maxSeedsLabel.Size = new System.Drawing.Size(72, 15);
            this.maxSeedsLabel.Text = "Max Results:";

            // maxSeedsNum
            this.maxSeedsNum.Location = new System.Drawing.Point(90, 28);
            this.maxSeedsNum.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.maxSeedsNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.maxSeedsNum.Name = "maxSeedsNum";
            this.maxSeedsNum.Size = new System.Drawing.Size(80, 23);
            this.maxSeedsNum.TabIndex = 1;
            this.maxSeedsNum.Value = new decimal(new int[] { 100, 0, 0, 0 });

            // startSeedLabel
            this.startSeedLabel.AutoSize = true;
            this.startSeedLabel.Location = new System.Drawing.Point(10, 60);
            this.startSeedLabel.Name = "startSeedLabel";
            this.startSeedLabel.Size = new System.Drawing.Size(63, 15);
            this.startSeedLabel.Text = "Start Seed:";

            // startSeedTextBox
            this.startSeedTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startSeedTextBox.Location = new System.Drawing.Point(75, 57);
            this.startSeedTextBox.MaxLength = 8;
            this.startSeedTextBox.Name = "startSeedTextBox";
            this.startSeedTextBox.Size = new System.Drawing.Size(130, 22);
            this.startSeedTextBox.TabIndex = 3;
            this.startSeedTextBox.Text = "00000000";
            this.startSeedTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;

            // endSeedLabel
            this.endSeedLabel.AutoSize = true;
            this.endSeedLabel.Location = new System.Drawing.Point(210, 60);
            this.endSeedLabel.Name = "endSeedLabel";
            this.endSeedLabel.Size = new System.Drawing.Size(31, 15);
            this.endSeedLabel.Text = "End:";

            // endSeedTextBox
            this.endSeedTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endSeedTextBox.Location = new System.Drawing.Point(245, 57);
            this.endSeedTextBox.MaxLength = 8;
            this.endSeedTextBox.Name = "endSeedTextBox";
            this.endSeedTextBox.Size = new System.Drawing.Size(105, 22);
            this.endSeedTextBox.TabIndex = 5;
            this.endSeedTextBox.Text = "FFFFFFFF";
            this.endSeedTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;

            // searchButton
            this.searchButton.Location = new System.Drawing.Point(10, 90);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(170, 50);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);

            // exportButton
            this.exportButton.Location = new System.Drawing.Point(185, 90);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(165, 50);
            this.exportButton.TabIndex = 7;
            this.exportButton.Text = "Export Results";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.ExportButton_Click);

            // resultsPanel
            this.resultsPanel.Controls.Add(this.resultsGrid);
            this.resultsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsPanel.Location = new System.Drawing.Point(0, 0);
            this.resultsPanel.Name = "resultsPanel";
            this.resultsPanel.Size = new System.Drawing.Size(716, 728);
            this.resultsPanel.TabIndex = 0;

            // resultsGrid
            this.resultsGrid.AllowUserToAddRows = false;
            this.resultsGrid.AllowUserToDeleteRows = false;
            this.resultsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "Seed", Width = 90 },
                new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "Shiny", Width = 50 },
                new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "Nature", Width = 80 },
                new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "Ability", Width = 100 },
                new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "IVs", Width = 130 },
                new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "Height", Width = 55 },
                new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "Weight", Width = 55 }
            });
            this.resultsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsGrid.Location = new System.Drawing.Point(0, 0);
            this.resultsGrid.Name = "resultsGrid";
            this.resultsGrid.ReadOnly = true;
            this.resultsGrid.RowTemplate.Height = 25;
            this.resultsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultsGrid.Size = new System.Drawing.Size(716, 728);
            this.resultsGrid.TabIndex = 0;

            this.resultsGrid.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.resultsGrid.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.resultsGrid.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.resultsGrid.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.resultsGrid.GridColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.resultsGrid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.resultsGrid.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.resultsGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.resultsGrid.EnableHeadersVisualStyles = false;

            this.resultsGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ResultsGrid_CellDoubleClick);
            this.resultsGrid.SelectionChanged += new System.EventHandler(this.ResultsGrid_SelectionChanged);

            // statusStrip
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.statusLabel, this.progressBar });
            this.statusStrip.Location = new System.Drawing.Point(0, 728);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1100, 22);
            this.statusStrip.TabIndex = 1;

            // statusLabel
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Ready";

            // progressBar
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(200, 16);
            this.progressBar.Visible = false;

            this.mainPanel.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.speciesGroup.ResumeLayout(false);
            this.speciesGroup.PerformLayout();
            this.criteriaGroup.ResumeLayout(false);
            this.criteriaGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tidNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sidNum)).EndInit();
            this.ivGroup.ResumeLayout(false);
            this.ivGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ivHpMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivHpMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivAtkMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivAtkMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivDefMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivDefMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivSpaMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivSpaMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivSpdMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivSpdMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivSpeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivSpeMax)).EndInit();
            this.searchOptionsGroup.ResumeLayout(false);
            this.searchOptionsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxSeedsNum)).EndInit();
            this.resultsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Panel resultsPanel;

        private System.Windows.Forms.GroupBox speciesGroup;
        private System.Windows.Forms.Label speciesLabel;
        private System.Windows.Forms.ComboBox speciesCombo;

        private System.Windows.Forms.GroupBox criteriaGroup;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.ComboBox genderCombo;
        private System.Windows.Forms.Label abilityLabel;
        private System.Windows.Forms.ComboBox abilityCombo;
        private System.Windows.Forms.Label natureLabel;
        private System.Windows.Forms.ComboBox natureCombo;
        private System.Windows.Forms.Label shinyLabel;
        private System.Windows.Forms.ComboBox shinyCombo;
        private System.Windows.Forms.Label tidLabel;
        private System.Windows.Forms.NumericUpDown tidNum;
        private System.Windows.Forms.Label sidLabel;
        private System.Windows.Forms.NumericUpDown sidNum;

        private System.Windows.Forms.GroupBox ivGroup;
        private System.Windows.Forms.Label ivMinLabel;
        private System.Windows.Forms.Label ivMaxLabel;
        private System.Windows.Forms.Label ivHpLabel;
        private System.Windows.Forms.NumericUpDown ivHpMin;
        private System.Windows.Forms.NumericUpDown ivHpMax;
        private System.Windows.Forms.Label ivAtkLabel;
        private System.Windows.Forms.NumericUpDown ivAtkMin;
        private System.Windows.Forms.NumericUpDown ivAtkMax;
        private System.Windows.Forms.Label ivDefLabel;
        private System.Windows.Forms.NumericUpDown ivDefMin;
        private System.Windows.Forms.NumericUpDown ivDefMax;
        private System.Windows.Forms.Label ivSpaLabel;
        private System.Windows.Forms.NumericUpDown ivSpaMin;
        private System.Windows.Forms.NumericUpDown ivSpaMax;
        private System.Windows.Forms.Label ivSpdLabel;
        private System.Windows.Forms.NumericUpDown ivSpdMin;
        private System.Windows.Forms.NumericUpDown ivSpdMax;
        private System.Windows.Forms.Label ivSpeLabel;
        private System.Windows.Forms.NumericUpDown ivSpeMin;
        private System.Windows.Forms.NumericUpDown ivSpeMax;

        private System.Windows.Forms.GroupBox searchOptionsGroup;
        private System.Windows.Forms.Label maxSeedsLabel;
        private System.Windows.Forms.NumericUpDown maxSeedsNum;
        private System.Windows.Forms.Label startSeedLabel;
        private System.Windows.Forms.TextBox startSeedTextBox;
        private System.Windows.Forms.Label endSeedLabel;
        private System.Windows.Forms.TextBox endSeedTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button exportButton;

        private System.Windows.Forms.DataGridView resultsGrid;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
    }
}
