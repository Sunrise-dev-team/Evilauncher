namespace EIStarter
{
    partial class Options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControlOptions = new System.Windows.Forms.TabControl();
            this.tabGraphics = new System.Windows.Forms.TabPage();
            this.cbbAudio = new System.Windows.Forms.ComboBox();
            this.lbTexturesQ = new System.Windows.Forms.Label();
            this.cbbTextures = new System.Windows.Forms.ComboBox();
            this.lbShadowingFreq = new System.Windows.Forms.Label();
            this.cbbShadowing = new System.Windows.Forms.ComboBox();
            this.lbTerrainQ = new System.Windows.Forms.Label();
            this.lbShadowsQ = new System.Windows.Forms.Label();
            this.lbLightingFreq = new System.Windows.Forms.Label();
            this.lbFiltering = new System.Windows.Forms.Label();
            this.lbMovies = new System.Windows.Forms.Label();
            this.cbbMovies = new System.Windows.Forms.ComboBox();
            this.cbbLighting = new System.Windows.Forms.ComboBox();
            this.cbbTerrain = new System.Windows.Forms.ComboBox();
            this.cbbShadows = new System.Windows.Forms.ComboBox();
            this.cbbFiltering = new System.Windows.Forms.ComboBox();
            this.cbFPSCursor = new System.Windows.Forms.CheckBox();
            this.cbDithering = new System.Windows.Forms.CheckBox();
            this.cbAntialiasing = new System.Windows.Forms.CheckBox();
            this.cbMipMapping = new System.Windows.Forms.CheckBox();
            this.cbFullscreen = new System.Windows.Forms.CheckBox();
            this.lbResolution = new System.Windows.Forms.Label();
            this.cbbResolutions = new System.Windows.Forms.ComboBox();
            this.lbAdapter = new System.Windows.Forms.Label();
            this.lbAudio = new System.Windows.Forms.Label();
            this.cbbAdapter = new System.Windows.Forms.ComboBox();
            this.tabAddon = new System.Windows.Forms.TabPage();
            this.lbDrawRadiusObjects = new System.Windows.Forms.Label();
            this.lbDrawRadiusTerrain = new System.Windows.Forms.Label();
            this.cbOnMinimizePause = new System.Windows.Forms.CheckBox();
            this.nbDrawRadiusObjects = new System.Windows.Forms.NumericUpDown();
            this.nbDrawRadiusTerrain = new System.Windows.Forms.NumericUpDown();
            this.tabMultiplayer = new System.Windows.Forms.TabPage();
            this.cbMPConsoleSupport = new System.Windows.Forms.CheckBox();
            this.cbMPDisableMQ = new System.Windows.Forms.CheckBox();
            this.cbMPSecondSpeed = new System.Windows.Forms.CheckBox();
            this.tabPaths = new System.Windows.Forms.TabPage();
            this.tabCamera = new System.Windows.Forms.TabPage();
            this.propGridCamera = new System.Windows.Forms.PropertyGrid();
            this.tabUtils = new System.Windows.Forms.TabPage();
            this.cbCharFixWinXP = new System.Windows.Forms.CheckBox();
            this.cbbPreset = new System.Windows.Forms.ComboBox();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btApplyPreset = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.NTRtbExeName = new System.Windows.Forms.TextBox();
            this.lbEXEName = new System.Windows.Forms.Label();
            this.NTRtbPathCD = new System.Windows.Forms.TextBox();
            this.NTRtbPathRes = new System.Windows.Forms.TextBox();
            this.NTRtbPathGameWork = new System.Windows.Forms.TextBox();
            this.lbPathCD = new System.Windows.Forms.Label();
            this.lbPathRes = new System.Windows.Forms.Label();
            this.btApplyPaths = new System.Windows.Forms.Button();
            this.lbPathGameWorkdir = new System.Windows.Forms.Label();
            this.tbPathsHelpDesc = new System.Windows.Forms.TextBox();
            this.lbPathCDDesc = new System.Windows.Forms.Label();
            this.lbPathResDesc = new System.Windows.Forms.Label();
            this.lbPathGameWorkdirDesc = new System.Windows.Forms.Label();
            this.lbEXENameDesc = new System.Windows.Forms.Label();
            this.NTRbtBrowse1 = new System.Windows.Forms.Button();
            this.NTRbtBrowse2 = new System.Windows.Forms.Button();
            this.NTRbtBrowse3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControlOptions.SuspendLayout();
            this.tabGraphics.SuspendLayout();
            this.tabAddon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbDrawRadiusObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbDrawRadiusTerrain)).BeginInit();
            this.tabMultiplayer.SuspendLayout();
            this.tabPaths.SuspendLayout();
            this.tabCamera.SuspendLayout();
            this.tabUtils.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(1, 1);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControlOptions);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cbbPreset);
            this.splitContainer1.Panel2.Controls.Add(this.btOk);
            this.splitContainer1.Panel2.Controls.Add(this.btCancel);
            this.splitContainer1.Panel2.Controls.Add(this.btApplyPreset);
            this.splitContainer1.Size = new System.Drawing.Size(462, 352);
            this.splitContainer1.SplitterDistance = 309;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControlOptions
            // 
            this.tabControlOptions.Controls.Add(this.tabGraphics);
            this.tabControlOptions.Controls.Add(this.tabAddon);
            this.tabControlOptions.Controls.Add(this.tabMultiplayer);
            this.tabControlOptions.Controls.Add(this.tabCamera);
            this.tabControlOptions.Controls.Add(this.tabPaths);
            this.tabControlOptions.Controls.Add(this.tabUtils);
            this.tabControlOptions.HotTrack = true;
            this.tabControlOptions.Location = new System.Drawing.Point(4, 5);
            this.tabControlOptions.Margin = new System.Windows.Forms.Padding(5);
            this.tabControlOptions.Name = "tabControlOptions";
            this.tabControlOptions.Padding = new System.Drawing.Point(10, 3);
            this.tabControlOptions.SelectedIndex = 0;
            this.tabControlOptions.Size = new System.Drawing.Size(454, 305);
            this.tabControlOptions.TabIndex = 0;
            // 
            // tabGraphics
            // 
            this.tabGraphics.Controls.Add(this.cbbAudio);
            this.tabGraphics.Controls.Add(this.lbTexturesQ);
            this.tabGraphics.Controls.Add(this.cbbTextures);
            this.tabGraphics.Controls.Add(this.lbShadowingFreq);
            this.tabGraphics.Controls.Add(this.cbbShadowing);
            this.tabGraphics.Controls.Add(this.lbTerrainQ);
            this.tabGraphics.Controls.Add(this.lbShadowsQ);
            this.tabGraphics.Controls.Add(this.lbLightingFreq);
            this.tabGraphics.Controls.Add(this.lbFiltering);
            this.tabGraphics.Controls.Add(this.lbMovies);
            this.tabGraphics.Controls.Add(this.cbbMovies);
            this.tabGraphics.Controls.Add(this.cbbLighting);
            this.tabGraphics.Controls.Add(this.cbbTerrain);
            this.tabGraphics.Controls.Add(this.cbbShadows);
            this.tabGraphics.Controls.Add(this.cbbFiltering);
            this.tabGraphics.Controls.Add(this.cbFPSCursor);
            this.tabGraphics.Controls.Add(this.cbDithering);
            this.tabGraphics.Controls.Add(this.cbAntialiasing);
            this.tabGraphics.Controls.Add(this.cbMipMapping);
            this.tabGraphics.Controls.Add(this.cbFullscreen);
            this.tabGraphics.Controls.Add(this.lbResolution);
            this.tabGraphics.Controls.Add(this.cbbResolutions);
            this.tabGraphics.Controls.Add(this.lbAdapter);
            this.tabGraphics.Controls.Add(this.lbAudio);
            this.tabGraphics.Controls.Add(this.cbbAdapter);
            this.tabGraphics.Location = new System.Drawing.Point(4, 22);
            this.tabGraphics.Margin = new System.Windows.Forms.Padding(5);
            this.tabGraphics.Name = "tabGraphics";
            this.tabGraphics.Padding = new System.Windows.Forms.Padding(1);
            this.tabGraphics.Size = new System.Drawing.Size(446, 279);
            this.tabGraphics.TabIndex = 0;
            this.tabGraphics.Text = "Graphics";
            this.tabGraphics.UseVisualStyleBackColor = true;
            // 
            // cbbAudio
            // 
            this.cbbAudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAudio.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbbAudio.FormattingEnabled = true;
            this.cbbAudio.Items.AddRange(new object[] {
            "Off",
            "Normal",
            "Safe"});
            this.cbbAudio.Location = new System.Drawing.Point(3, 255);
            this.cbbAudio.Name = "cbbAudio";
            this.cbbAudio.Size = new System.Drawing.Size(77, 21);
            this.cbbAudio.TabIndex = 25;
            // 
            // lbTexturesQ
            // 
            this.lbTexturesQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTexturesQ.Location = new System.Drawing.Point(215, 123);
            this.lbTexturesQ.Name = "lbTexturesQ";
            this.lbTexturesQ.Size = new System.Drawing.Size(136, 13);
            this.lbTexturesQ.TabIndex = 24;
            this.lbTexturesQ.Text = "Textures quality";
            this.lbTexturesQ.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbbTextures
            // 
            this.cbbTextures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbTextures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTextures.FormattingEnabled = true;
            this.cbbTextures.Items.AddRange(new object[] {
            "high",
            "normal",
            "low"});
            this.cbbTextures.Location = new System.Drawing.Point(354, 119);
            this.cbbTextures.Name = "cbbTextures";
            this.cbbTextures.Size = new System.Drawing.Size(88, 21);
            this.cbbTextures.TabIndex = 23;
            // 
            // lbShadowingFreq
            // 
            this.lbShadowingFreq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbShadowingFreq.Location = new System.Drawing.Point(215, 259);
            this.lbShadowingFreq.Name = "lbShadowingFreq";
            this.lbShadowingFreq.Size = new System.Drawing.Size(136, 13);
            this.lbShadowingFreq.TabIndex = 22;
            this.lbShadowingFreq.Text = "Shadowing freq.";
            this.lbShadowingFreq.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbbShadowing
            // 
            this.cbbShadowing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbShadowing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbShadowing.FormattingEnabled = true;
            this.cbbShadowing.Items.AddRange(new object[] {
            "Fast",
            "Normal",
            "Rare"});
            this.cbbShadowing.Location = new System.Drawing.Point(354, 255);
            this.cbbShadowing.Name = "cbbShadowing";
            this.cbbShadowing.Size = new System.Drawing.Size(88, 21);
            this.cbbShadowing.TabIndex = 21;
            // 
            // lbTerrainQ
            // 
            this.lbTerrainQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTerrainQ.Location = new System.Drawing.Point(215, 191);
            this.lbTerrainQ.Name = "lbTerrainQ";
            this.lbTerrainQ.Size = new System.Drawing.Size(136, 13);
            this.lbTerrainQ.TabIndex = 20;
            this.lbTerrainQ.Text = "Terrain LOD";
            this.lbTerrainQ.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbShadowsQ
            // 
            this.lbShadowsQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbShadowsQ.Location = new System.Drawing.Point(215, 157);
            this.lbShadowsQ.Name = "lbShadowsQ";
            this.lbShadowsQ.Size = new System.Drawing.Size(136, 13);
            this.lbShadowsQ.TabIndex = 19;
            this.lbShadowsQ.Text = "Shadows quality";
            this.lbShadowsQ.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbLightingFreq
            // 
            this.lbLightingFreq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLightingFreq.Location = new System.Drawing.Point(215, 225);
            this.lbLightingFreq.Name = "lbLightingFreq";
            this.lbLightingFreq.Size = new System.Drawing.Size(136, 13);
            this.lbLightingFreq.TabIndex = 18;
            this.lbLightingFreq.Text = "Lighting freq.";
            this.lbLightingFreq.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbFiltering
            // 
            this.lbFiltering.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFiltering.Location = new System.Drawing.Point(215, 89);
            this.lbFiltering.Name = "lbFiltering";
            this.lbFiltering.Size = new System.Drawing.Size(136, 13);
            this.lbFiltering.TabIndex = 17;
            this.lbFiltering.Text = "Filtering";
            this.lbFiltering.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbMovies
            // 
            this.lbMovies.AutoSize = true;
            this.lbMovies.Location = new System.Drawing.Point(85, 225);
            this.lbMovies.Name = "lbMovies";
            this.lbMovies.Size = new System.Drawing.Size(41, 13);
            this.lbMovies.TabIndex = 16;
            this.lbMovies.Text = "Movies";
            // 
            // cbbMovies
            // 
            this.cbbMovies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMovies.FormattingEnabled = true;
            this.cbbMovies.Items.AddRange(new object[] {
            "Off",
            "1:1",
            "Fit"});
            this.cbbMovies.Location = new System.Drawing.Point(3, 221);
            this.cbbMovies.Name = "cbbMovies";
            this.cbbMovies.Size = new System.Drawing.Size(77, 21);
            this.cbbMovies.TabIndex = 15;
            // 
            // cbbLighting
            // 
            this.cbbLighting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbLighting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLighting.FormattingEnabled = true;
            this.cbbLighting.Items.AddRange(new object[] {
            "Fast",
            "Normal",
            "Rare"});
            this.cbbLighting.Location = new System.Drawing.Point(354, 221);
            this.cbbLighting.Name = "cbbLighting";
            this.cbbLighting.Size = new System.Drawing.Size(88, 21);
            this.cbbLighting.TabIndex = 14;
            // 
            // cbbTerrain
            // 
            this.cbbTerrain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbTerrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTerrain.FormattingEnabled = true;
            this.cbbTerrain.Items.AddRange(new object[] {
            "High",
            "normal",
            "Low"});
            this.cbbTerrain.Location = new System.Drawing.Point(355, 187);
            this.cbbTerrain.Name = "cbbTerrain";
            this.cbbTerrain.Size = new System.Drawing.Size(87, 21);
            this.cbbTerrain.TabIndex = 13;
            // 
            // cbbShadows
            // 
            this.cbbShadows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbShadows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbShadows.FormattingEnabled = true;
            this.cbbShadows.Items.AddRange(new object[] {
            "None",
            "Low",
            "Smooth"});
            this.cbbShadows.Location = new System.Drawing.Point(355, 153);
            this.cbbShadows.Name = "cbbShadows";
            this.cbbShadows.Size = new System.Drawing.Size(87, 21);
            this.cbbShadows.TabIndex = 12;
            // 
            // cbbFiltering
            // 
            this.cbbFiltering.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbFiltering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFiltering.FormattingEnabled = true;
            this.cbbFiltering.Items.AddRange(new object[] {
            "point",
            "bilinear",
            "thrilinear"});
            this.cbbFiltering.Location = new System.Drawing.Point(355, 85);
            this.cbbFiltering.Name = "cbbFiltering";
            this.cbbFiltering.Size = new System.Drawing.Size(87, 21);
            this.cbbFiltering.TabIndex = 11;
            // 
            // cbFPSCursor
            // 
            this.cbFPSCursor.AutoSize = true;
            this.cbFPSCursor.Location = new System.Drawing.Point(5, 191);
            this.cbFPSCursor.Name = "cbFPSCursor";
            this.cbFPSCursor.Size = new System.Drawing.Size(137, 17);
            this.cbFPSCursor.TabIndex = 9;
            this.cbFPSCursor.Text = "FPS independed cursor";
            this.cbFPSCursor.UseVisualStyleBackColor = true;
            // 
            // cbDithering
            // 
            this.cbDithering.AutoSize = true;
            this.cbDithering.Location = new System.Drawing.Point(5, 165);
            this.cbDithering.Name = "cbDithering";
            this.cbDithering.Size = new System.Drawing.Size(68, 17);
            this.cbDithering.TabIndex = 7;
            this.cbDithering.Text = "Dithering";
            this.cbDithering.UseVisualStyleBackColor = true;
            // 
            // cbAntialiasing
            // 
            this.cbAntialiasing.AutoSize = true;
            this.cbAntialiasing.Location = new System.Drawing.Point(5, 139);
            this.cbAntialiasing.Name = "cbAntialiasing";
            this.cbAntialiasing.Size = new System.Drawing.Size(79, 17);
            this.cbAntialiasing.TabIndex = 6;
            this.cbAntialiasing.Text = "Antialiasing";
            this.cbAntialiasing.UseVisualStyleBackColor = true;
            // 
            // cbMipMapping
            // 
            this.cbMipMapping.AutoSize = true;
            this.cbMipMapping.Location = new System.Drawing.Point(5, 113);
            this.cbMipMapping.Name = "cbMipMapping";
            this.cbMipMapping.Size = new System.Drawing.Size(87, 17);
            this.cbMipMapping.TabIndex = 5;
            this.cbMipMapping.Text = "Mip-Mapping";
            this.cbMipMapping.UseVisualStyleBackColor = true;
            // 
            // cbFullscreen
            // 
            this.cbFullscreen.AutoSize = true;
            this.cbFullscreen.Location = new System.Drawing.Point(5, 87);
            this.cbFullscreen.Name = "cbFullscreen";
            this.cbFullscreen.Size = new System.Drawing.Size(76, 17);
            this.cbFullscreen.TabIndex = 4;
            this.cbFullscreen.Text = "FullScreen";
            this.cbFullscreen.UseVisualStyleBackColor = true;
            // 
            // lbResolution
            // 
            this.lbResolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbResolution.AutoSize = true;
            this.lbResolution.Location = new System.Drawing.Point(4, 41);
            this.lbResolution.Name = "lbResolution";
            this.lbResolution.Size = new System.Drawing.Size(57, 13);
            this.lbResolution.TabIndex = 3;
            this.lbResolution.Text = "Resolution";
            // 
            // cbbResolutions
            // 
            this.cbbResolutions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbResolutions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbResolutions.FormattingEnabled = true;
            this.cbbResolutions.Location = new System.Drawing.Point(3, 56);
            this.cbbResolutions.MaxDropDownItems = 10;
            this.cbbResolutions.Name = "cbbResolutions";
            this.cbbResolutions.Size = new System.Drawing.Size(439, 21);
            this.cbbResolutions.TabIndex = 2;
            // 
            // lbAdapter
            // 
            this.lbAdapter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAdapter.AutoSize = true;
            this.lbAdapter.Location = new System.Drawing.Point(4, 2);
            this.lbAdapter.Name = "lbAdapter";
            this.lbAdapter.Size = new System.Drawing.Size(44, 13);
            this.lbAdapter.TabIndex = 1;
            this.lbAdapter.Text = "Adapter";
            // 
            // lbAudio
            // 
            this.lbAudio.AutoSize = true;
            this.lbAudio.Location = new System.Drawing.Point(88, 259);
            this.lbAudio.Name = "lbAudio";
            this.lbAudio.Size = new System.Drawing.Size(34, 13);
            this.lbAudio.TabIndex = 26;
            this.lbAudio.Text = "Audio";
            // 
            // cbbAdapter
            // 
            this.cbbAdapter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbAdapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAdapter.FormattingEnabled = true;
            this.cbbAdapter.Location = new System.Drawing.Point(3, 17);
            this.cbbAdapter.MaxDropDownItems = 10;
            this.cbbAdapter.Name = "cbbAdapter";
            this.cbbAdapter.Size = new System.Drawing.Size(439, 21);
            this.cbbAdapter.TabIndex = 0;
            // 
            // tabAddon
            // 
            this.tabAddon.Controls.Add(this.lbDrawRadiusObjects);
            this.tabAddon.Controls.Add(this.lbDrawRadiusTerrain);
            this.tabAddon.Controls.Add(this.cbOnMinimizePause);
            this.tabAddon.Controls.Add(this.nbDrawRadiusObjects);
            this.tabAddon.Controls.Add(this.nbDrawRadiusTerrain);
            this.tabAddon.Location = new System.Drawing.Point(4, 22);
            this.tabAddon.Name = "tabAddon";
            this.tabAddon.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddon.Size = new System.Drawing.Size(446, 279);
            this.tabAddon.TabIndex = 1;
            this.tabAddon.Text = "Addon";
            this.tabAddon.UseVisualStyleBackColor = true;
            // 
            // lbDrawRadiusObjects
            // 
            this.lbDrawRadiusObjects.AutoSize = true;
            this.lbDrawRadiusObjects.Location = new System.Drawing.Point(127, 57);
            this.lbDrawRadiusObjects.Name = "lbDrawRadiusObjects";
            this.lbDrawRadiusObjects.Size = new System.Drawing.Size(100, 13);
            this.lbDrawRadiusObjects.TabIndex = 12;
            this.lbDrawRadiusObjects.Text = "Objects draw radius";
            // 
            // lbDrawRadiusTerrain
            // 
            this.lbDrawRadiusTerrain.AutoSize = true;
            this.lbDrawRadiusTerrain.Location = new System.Drawing.Point(127, 33);
            this.lbDrawRadiusTerrain.Name = "lbDrawRadiusTerrain";
            this.lbDrawRadiusTerrain.Size = new System.Drawing.Size(117, 13);
            this.lbDrawRadiusTerrain.TabIndex = 11;
            this.lbDrawRadiusTerrain.Text = "Landscape draw radius";
            // 
            // cbOnMinimizePause
            // 
            this.cbOnMinimizePause.AutoSize = true;
            this.cbOnMinimizePause.Location = new System.Drawing.Point(15, 90);
            this.cbOnMinimizePause.Name = "cbOnMinimizePause";
            this.cbOnMinimizePause.Size = new System.Drawing.Size(162, 17);
            this.cbOnMinimizePause.TabIndex = 10;
            this.cbOnMinimizePause.Text = "Pause when minimized game";
            this.cbOnMinimizePause.UseVisualStyleBackColor = true;
            // 
            // nbDrawRadiusObjects
            // 
            this.nbDrawRadiusObjects.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nbDrawRadiusObjects.Location = new System.Drawing.Point(15, 55);
            this.nbDrawRadiusObjects.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nbDrawRadiusObjects.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nbDrawRadiusObjects.Name = "nbDrawRadiusObjects";
            this.nbDrawRadiusObjects.ReadOnly = true;
            this.nbDrawRadiusObjects.Size = new System.Drawing.Size(106, 20);
            this.nbDrawRadiusObjects.TabIndex = 3;
            this.nbDrawRadiusObjects.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nbDrawRadiusObjects.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nbDrawRadiusTerrain
            // 
            this.nbDrawRadiusTerrain.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nbDrawRadiusTerrain.Location = new System.Drawing.Point(15, 29);
            this.nbDrawRadiusTerrain.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nbDrawRadiusTerrain.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nbDrawRadiusTerrain.Name = "nbDrawRadiusTerrain";
            this.nbDrawRadiusTerrain.ReadOnly = true;
            this.nbDrawRadiusTerrain.Size = new System.Drawing.Size(106, 20);
            this.nbDrawRadiusTerrain.TabIndex = 2;
            this.nbDrawRadiusTerrain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nbDrawRadiusTerrain.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // tabMultiplayer
            // 
            this.tabMultiplayer.Controls.Add(this.cbMPConsoleSupport);
            this.tabMultiplayer.Controls.Add(this.cbMPDisableMQ);
            this.tabMultiplayer.Controls.Add(this.cbMPSecondSpeed);
            this.tabMultiplayer.Location = new System.Drawing.Point(4, 22);
            this.tabMultiplayer.Name = "tabMultiplayer";
            this.tabMultiplayer.Padding = new System.Windows.Forms.Padding(3);
            this.tabMultiplayer.Size = new System.Drawing.Size(446, 279);
            this.tabMultiplayer.TabIndex = 2;
            this.tabMultiplayer.Text = "Multiplayer";
            this.tabMultiplayer.UseVisualStyleBackColor = true;
            // 
            // cbMPConsoleSupport
            // 
            this.cbMPConsoleSupport.AutoSize = true;
            this.cbMPConsoleSupport.Location = new System.Drawing.Point(18, 67);
            this.cbMPConsoleSupport.Name = "cbMPConsoleSupport";
            this.cbMPConsoleSupport.Size = new System.Drawing.Size(102, 17);
            this.cbMPConsoleSupport.TabIndex = 13;
            this.cbMPConsoleSupport.Text = "Console support";
            this.cbMPConsoleSupport.UseVisualStyleBackColor = true;
            // 
            // cbMPDisableMQ
            // 
            this.cbMPDisableMQ.AutoSize = true;
            this.cbMPDisableMQ.Location = new System.Drawing.Point(18, 45);
            this.cbMPDisableMQ.Name = "cbMPDisableMQ";
            this.cbMPDisableMQ.Size = new System.Drawing.Size(210, 17);
            this.cbMPDisableMQ.TabIndex = 12;
            this.cbMPDisableMQ.Text = "Do not load .MQ (Quest) files from Host";
            this.cbMPDisableMQ.UseVisualStyleBackColor = true;
            // 
            // cbMPSecondSpeed
            // 
            this.cbMPSecondSpeed.AutoSize = true;
            this.cbMPSecondSpeed.Location = new System.Drawing.Point(18, 23);
            this.cbMPSecondSpeed.Name = "cbMPSecondSpeed";
            this.cbMPSecondSpeed.Size = new System.Drawing.Size(133, 17);
            this.cbMPSecondSpeed.TabIndex = 11;
            this.cbMPSecondSpeed.Text = "Second speed support";
            this.cbMPSecondSpeed.UseVisualStyleBackColor = true;
            // 
            // tabPaths
            // 
            this.tabPaths.Controls.Add(this.NTRbtBrowse3);
            this.tabPaths.Controls.Add(this.NTRbtBrowse2);
            this.tabPaths.Controls.Add(this.NTRbtBrowse1);
            this.tabPaths.Controls.Add(this.lbEXENameDesc);
            this.tabPaths.Controls.Add(this.lbPathGameWorkdirDesc);
            this.tabPaths.Controls.Add(this.lbPathResDesc);
            this.tabPaths.Controls.Add(this.lbPathCDDesc);
            this.tabPaths.Controls.Add(this.tbPathsHelpDesc);
            this.tabPaths.Controls.Add(this.lbPathGameWorkdir);
            this.tabPaths.Controls.Add(this.btApplyPaths);
            this.tabPaths.Controls.Add(this.lbPathRes);
            this.tabPaths.Controls.Add(this.lbPathCD);
            this.tabPaths.Controls.Add(this.NTRtbPathGameWork);
            this.tabPaths.Controls.Add(this.NTRtbPathRes);
            this.tabPaths.Controls.Add(this.NTRtbPathCD);
            this.tabPaths.Controls.Add(this.lbEXEName);
            this.tabPaths.Controls.Add(this.NTRtbExeName);
            this.tabPaths.Location = new System.Drawing.Point(4, 22);
            this.tabPaths.Name = "tabPaths";
            this.tabPaths.Size = new System.Drawing.Size(446, 279);
            this.tabPaths.TabIndex = 3;
            this.tabPaths.Text = "Paths";
            this.tabPaths.UseVisualStyleBackColor = true;
            // 
            // tabCamera
            // 
            this.tabCamera.Controls.Add(this.propGridCamera);
            this.tabCamera.Location = new System.Drawing.Point(4, 22);
            this.tabCamera.Name = "tabCamera";
            this.tabCamera.Padding = new System.Windows.Forms.Padding(3);
            this.tabCamera.Size = new System.Drawing.Size(446, 279);
            this.tabCamera.TabIndex = 4;
            this.tabCamera.Text = "Camera";
            this.tabCamera.UseVisualStyleBackColor = true;
            // 
            // propGridCamera
            // 
            this.propGridCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGridCamera.HelpVisible = false;
            this.propGridCamera.Location = new System.Drawing.Point(3, 3);
            this.propGridCamera.Name = "propGridCamera";
            this.propGridCamera.Size = new System.Drawing.Size(440, 273);
            this.propGridCamera.TabIndex = 0;
            // 
            // tabUtils
            // 
            this.tabUtils.Controls.Add(this.cbCharFixWinXP);
            this.tabUtils.Location = new System.Drawing.Point(4, 22);
            this.tabUtils.Name = "tabUtils";
            this.tabUtils.Padding = new System.Windows.Forms.Padding(3);
            this.tabUtils.Size = new System.Drawing.Size(446, 279);
            this.tabUtils.TabIndex = 5;
            this.tabUtils.Text = "Utils";
            this.tabUtils.UseVisualStyleBackColor = true;
            // 
            // cbCharFixWinXP
            // 
            this.cbCharFixWinXP.AutoSize = true;
            this.cbCharFixWinXP.Location = new System.Drawing.Point(22, 35);
            this.cbCharFixWinXP.Name = "cbCharFixWinXP";
            this.cbCharFixWinXP.Size = new System.Drawing.Size(166, 17);
            this.cbCharFixWinXP.TabIndex = 11;
            this.cbCharFixWinXP.Text = "Russian charset fix for WinXP";
            this.cbCharFixWinXP.UseVisualStyleBackColor = true;
            // 
            // cbbPreset
            // 
            this.cbbPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPreset.Enabled = false;
            this.cbbPreset.FormattingEnabled = true;
            this.cbbPreset.Location = new System.Drawing.Point(7, 9);
            this.cbbPreset.Name = "cbbPreset";
            this.cbbPreset.Size = new System.Drawing.Size(108, 21);
            this.cbbPreset.TabIndex = 26;
            this.cbbPreset.Visible = false;
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btOk.Location = new System.Drawing.Point(274, 5);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(88, 29);
            this.btOk.TabIndex = 1;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(369, 5);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(88, 29);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btApplyPreset
            // 
            this.btApplyPreset.Enabled = false;
            this.btApplyPreset.Location = new System.Drawing.Point(121, 5);
            this.btApplyPreset.Name = "btApplyPreset";
            this.btApplyPreset.Size = new System.Drawing.Size(88, 29);
            this.btApplyPreset.TabIndex = 3;
            this.btApplyPreset.Text = "Apply preset";
            this.btApplyPreset.UseVisualStyleBackColor = true;
            this.btApplyPreset.Visible = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(4, 46);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(45, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Low";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(4, 29);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Medium";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "High";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // NTRtbExeName
            // 
            this.NTRtbExeName.BackColor = System.Drawing.SystemColors.Window;
            this.NTRtbExeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NTRtbExeName.Location = new System.Drawing.Point(5, 147);
            this.NTRtbExeName.Name = "NTRtbExeName";
            this.NTRtbExeName.Size = new System.Drawing.Size(436, 20);
            this.NTRtbExeName.TabIndex = 0;
            // 
            // lbEXEName
            // 
            this.lbEXEName.AutoSize = true;
            this.lbEXEName.Location = new System.Drawing.Point(3, 131);
            this.lbEXEName.Name = "lbEXEName";
            this.lbEXEName.Size = new System.Drawing.Size(116, 13);
            this.lbEXEName.TabIndex = 1;
            this.lbEXEName.Text = "Game Engine Filename";
            // 
            // NTRtbPathCD
            // 
            this.NTRtbPathCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NTRtbPathCD.Location = new System.Drawing.Point(5, 21);
            this.NTRtbPathCD.Name = "NTRtbPathCD";
            this.NTRtbPathCD.Size = new System.Drawing.Size(401, 20);
            this.NTRtbPathCD.TabIndex = 2;
            // 
            // NTRtbPathRes
            // 
            this.NTRtbPathRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NTRtbPathRes.Location = new System.Drawing.Point(5, 63);
            this.NTRtbPathRes.Name = "NTRtbPathRes";
            this.NTRtbPathRes.Size = new System.Drawing.Size(401, 20);
            this.NTRtbPathRes.TabIndex = 3;
            // 
            // NTRtbPathGameWork
            // 
            this.NTRtbPathGameWork.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NTRtbPathGameWork.Location = new System.Drawing.Point(5, 105);
            this.NTRtbPathGameWork.Name = "NTRtbPathGameWork";
            this.NTRtbPathGameWork.Size = new System.Drawing.Size(401, 20);
            this.NTRtbPathGameWork.TabIndex = 4;
            // 
            // lbPathCD
            // 
            this.lbPathCD.AutoSize = true;
            this.lbPathCD.Location = new System.Drawing.Point(3, 5);
            this.lbPathCD.Name = "lbPathCD";
            this.lbPathCD.Size = new System.Drawing.Size(47, 13);
            this.lbPathCD.TabIndex = 5;
            this.lbPathCD.Text = "CD Path";
            // 
            // lbPathRes
            // 
            this.lbPathRes.AutoSize = true;
            this.lbPathRes.Location = new System.Drawing.Point(3, 47);
            this.lbPathRes.Name = "lbPathRes";
            this.lbPathRes.Size = new System.Drawing.Size(114, 13);
            this.lbPathRes.TabIndex = 6;
            this.lbPathRes.Text = "Game Resources Path";
            // 
            // btApplyPaths
            // 
            this.btApplyPaths.Location = new System.Drawing.Point(311, 176);
            this.btApplyPaths.Name = "btApplyPaths";
            this.btApplyPaths.Size = new System.Drawing.Size(130, 32);
            this.btApplyPaths.TabIndex = 7;
            this.btApplyPaths.Text = "Apply Paths";
            this.btApplyPaths.UseVisualStyleBackColor = true;
            this.btApplyPaths.Click += new System.EventHandler(this.btApplyPaths_Click);
            // 
            // lbPathGameWorkdir
            // 
            this.lbPathGameWorkdir.AutoSize = true;
            this.lbPathGameWorkdir.Location = new System.Drawing.Point(3, 89);
            this.lbPathGameWorkdir.Name = "lbPathGameWorkdir";
            this.lbPathGameWorkdir.Size = new System.Drawing.Size(100, 13);
            this.lbPathGameWorkdir.TabIndex = 8;
            this.lbPathGameWorkdir.Text = "Game Workdir Path";
            // 
            // tbPathsHelpDesc
            // 
            this.tbPathsHelpDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPathsHelpDesc.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbPathsHelpDesc.Location = new System.Drawing.Point(6, 176);
            this.tbPathsHelpDesc.Multiline = true;
            this.tbPathsHelpDesc.Name = "tbPathsHelpDesc";
            this.tbPathsHelpDesc.Size = new System.Drawing.Size(299, 100);
            this.tbPathsHelpDesc.TabIndex = 9;
            this.tbPathsHelpDesc.Text = "[] - part which edit in text box\r\n{} - \"variable\":\r\n    install path - where is o" +
    "riginal Game.exe\r\n    name - name of file\r\n    extension - extension of file (e." +
    "g. \"exe\")\r\n\r\n";
            // 
            // lbPathCDDesc
            // 
            this.lbPathCDDesc.Location = new System.Drawing.Point(217, 5);
            this.lbPathCDDesc.Name = "lbPathCDDesc";
            this.lbPathCDDesc.Size = new System.Drawing.Size(190, 13);
            this.lbPathCDDesc.TabIndex = 10;
            this.lbPathCDDesc.Text = "[ {install path}\\ ]";
            this.lbPathCDDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbPathResDesc
            // 
            this.lbPathResDesc.Location = new System.Drawing.Point(220, 47);
            this.lbPathResDesc.Name = "lbPathResDesc";
            this.lbPathResDesc.Size = new System.Drawing.Size(187, 13);
            this.lbPathResDesc.TabIndex = 11;
            this.lbPathResDesc.Text = "[ {install path}\\Res\\ ]";
            this.lbPathResDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbPathGameWorkdirDesc
            // 
            this.lbPathGameWorkdirDesc.Location = new System.Drawing.Point(220, 89);
            this.lbPathGameWorkdirDesc.Name = "lbPathGameWorkdirDesc";
            this.lbPathGameWorkdirDesc.Size = new System.Drawing.Size(187, 13);
            this.lbPathGameWorkdirDesc.TabIndex = 12;
            this.lbPathGameWorkdirDesc.Text = "[ {install path}\\ ]";
            this.lbPathGameWorkdirDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbEXENameDesc
            // 
            this.lbEXENameDesc.Location = new System.Drawing.Point(254, 131);
            this.lbEXENameDesc.Name = "lbEXENameDesc";
            this.lbEXENameDesc.Size = new System.Drawing.Size(187, 13);
            this.lbEXENameDesc.TabIndex = 13;
            this.lbEXENameDesc.Text = "\"Engine\\\"[{name}.{extension}]";
            this.lbEXENameDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NTRbtBrowse1
            // 
            this.NTRbtBrowse1.Location = new System.Drawing.Point(411, 21);
            this.NTRbtBrowse1.Name = "NTRbtBrowse1";
            this.NTRbtBrowse1.Size = new System.Drawing.Size(30, 20);
            this.NTRbtBrowse1.TabIndex = 14;
            this.NTRbtBrowse1.Text = "...";
            this.NTRbtBrowse1.UseVisualStyleBackColor = true;
            this.NTRbtBrowse1.Click += new System.EventHandler(this.NTRbtBrowse1_Click);
            // 
            // NTRbtBrowse2
            // 
            this.NTRbtBrowse2.Location = new System.Drawing.Point(411, 63);
            this.NTRbtBrowse2.Name = "NTRbtBrowse2";
            this.NTRbtBrowse2.Size = new System.Drawing.Size(30, 20);
            this.NTRbtBrowse2.TabIndex = 15;
            this.NTRbtBrowse2.Text = "...";
            this.NTRbtBrowse2.UseVisualStyleBackColor = true;
            this.NTRbtBrowse2.Click += new System.EventHandler(this.NTRbtBrowse2_Click);
            // 
            // NTRbtBrowse3
            // 
            this.NTRbtBrowse3.Location = new System.Drawing.Point(411, 105);
            this.NTRbtBrowse3.Name = "NTRbtBrowse3";
            this.NTRbtBrowse3.Size = new System.Drawing.Size(30, 20);
            this.NTRbtBrowse3.TabIndex = 16;
            this.NTRbtBrowse3.Text = "...";
            this.NTRbtBrowse3.UseVisualStyleBackColor = true;
            this.NTRbtBrowse3.Click += new System.EventHandler(this.NTRbtBrowse3_Click);
            // 
            // Options
            // 
            this.AcceptButton = this.btOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(464, 354);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Options";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControlOptions.ResumeLayout(false);
            this.tabGraphics.ResumeLayout(false);
            this.tabGraphics.PerformLayout();
            this.tabAddon.ResumeLayout(false);
            this.tabAddon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbDrawRadiusObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbDrawRadiusTerrain)).EndInit();
            this.tabMultiplayer.ResumeLayout(false);
            this.tabMultiplayer.PerformLayout();
            this.tabPaths.ResumeLayout(false);
            this.tabPaths.PerformLayout();
            this.tabCamera.ResumeLayout(false);
            this.tabUtils.ResumeLayout(false);
            this.tabUtils.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControlOptions;
        private System.Windows.Forms.TabPage tabGraphics;
        private System.Windows.Forms.TabPage tabAddon;
        private System.Windows.Forms.TabPage tabMultiplayer;
        //private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btApplyPreset;
        private System.Windows.Forms.ComboBox cbbPreset;
        //private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbAudio;
        private System.Windows.Forms.ComboBox cbbAudio;
        private System.Windows.Forms.Label lbTexturesQ;
        private System.Windows.Forms.ComboBox cbbTextures;
        private System.Windows.Forms.Label lbShadowingFreq;
        private System.Windows.Forms.ComboBox cbbShadowing;
        private System.Windows.Forms.Label lbTerrainQ;
        private System.Windows.Forms.Label lbShadowsQ;
        private System.Windows.Forms.Label lbLightingFreq;
        private System.Windows.Forms.Label lbFiltering;
        private System.Windows.Forms.Label lbMovies;
        private System.Windows.Forms.ComboBox cbbMovies;
        private System.Windows.Forms.ComboBox cbbLighting;
        private System.Windows.Forms.ComboBox cbbTerrain;
        private System.Windows.Forms.ComboBox cbbShadows;
        private System.Windows.Forms.ComboBox cbbFiltering;
        private System.Windows.Forms.CheckBox cbFPSCursor;
        private System.Windows.Forms.CheckBox cbDithering;
        private System.Windows.Forms.CheckBox cbAntialiasing;
        private System.Windows.Forms.CheckBox cbMipMapping;
        private System.Windows.Forms.CheckBox cbFullscreen;
        private System.Windows.Forms.Label lbResolution;
        private System.Windows.Forms.ComboBox cbbResolutions;
        private System.Windows.Forms.Label lbAdapter;
        private System.Windows.Forms.ComboBox cbbAdapter;
        private System.Windows.Forms.TabPage tabPaths;
        private System.Windows.Forms.NumericUpDown nbDrawRadiusTerrain;
        private System.Windows.Forms.NumericUpDown nbDrawRadiusObjects;
        private System.Windows.Forms.TabPage tabCamera;
        private System.Windows.Forms.PropertyGrid propGridCamera;
        private System.Windows.Forms.TabPage tabUtils;
        private System.Windows.Forms.CheckBox cbOnMinimizePause;
        private System.Windows.Forms.CheckBox cbMPConsoleSupport;
        private System.Windows.Forms.CheckBox cbMPDisableMQ;
        private System.Windows.Forms.CheckBox cbMPSecondSpeed;
        private System.Windows.Forms.CheckBox cbCharFixWinXP;
        private System.Windows.Forms.Label lbDrawRadiusTerrain;
        private System.Windows.Forms.Label lbDrawRadiusObjects;
        private System.Windows.Forms.Label lbEXEName;
        private System.Windows.Forms.TextBox NTRtbExeName;
        private System.Windows.Forms.TextBox NTRtbPathGameWork;
        private System.Windows.Forms.TextBox NTRtbPathRes;
        private System.Windows.Forms.TextBox NTRtbPathCD;
        private System.Windows.Forms.Label lbPathRes;
        private System.Windows.Forms.Label lbPathCD;
        private System.Windows.Forms.Label lbPathGameWorkdir;
        private System.Windows.Forms.Button btApplyPaths;
        private System.Windows.Forms.TextBox tbPathsHelpDesc;
        private System.Windows.Forms.Label lbPathCDDesc;
        private System.Windows.Forms.Label lbPathResDesc;
        private System.Windows.Forms.Label lbEXENameDesc;
        private System.Windows.Forms.Label lbPathGameWorkdirDesc;
        private System.Windows.Forms.Button NTRbtBrowse1;
        private System.Windows.Forms.Button NTRbtBrowse3;
        private System.Windows.Forms.Button NTRbtBrowse2;
    }
}