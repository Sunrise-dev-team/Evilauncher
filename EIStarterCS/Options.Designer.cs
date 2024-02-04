namespace EIStarterCS
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
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            tabControlOptions = new System.Windows.Forms.TabControl();
            tabGraphics = new System.Windows.Forms.TabPage();
            cbbAudio = new System.Windows.Forms.ComboBox();
            lbTexturesQ = new System.Windows.Forms.Label();
            cbbTextures = new System.Windows.Forms.ComboBox();
            lbShadowingFreq = new System.Windows.Forms.Label();
            cbbShadowing = new System.Windows.Forms.ComboBox();
            lbTerrainQ = new System.Windows.Forms.Label();
            lbShadowsQ = new System.Windows.Forms.Label();
            lbLightingFreq = new System.Windows.Forms.Label();
            lbFiltering = new System.Windows.Forms.Label();
            lbMovies = new System.Windows.Forms.Label();
            cbbMovies = new System.Windows.Forms.ComboBox();
            cbbLighting = new System.Windows.Forms.ComboBox();
            cbbTerrain = new System.Windows.Forms.ComboBox();
            cbbShadows = new System.Windows.Forms.ComboBox();
            cbbFiltering = new System.Windows.Forms.ComboBox();
            cbFPSCursor = new System.Windows.Forms.CheckBox();
            cbDithering = new System.Windows.Forms.CheckBox();
            cbAntialiasing = new System.Windows.Forms.CheckBox();
            cbMipMapping = new System.Windows.Forms.CheckBox();
            cbFullscreen = new System.Windows.Forms.CheckBox();
            lbResolution = new System.Windows.Forms.Label();
            cbbResolutions = new System.Windows.Forms.ComboBox();
            lbAdapter = new System.Windows.Forms.Label();
            lbAudio = new System.Windows.Forms.Label();
            cbbAdapter = new System.Windows.Forms.ComboBox();
            tabAddon = new System.Windows.Forms.TabPage();
            lbDrawRadiusObjects = new System.Windows.Forms.Label();
            lbDrawRadiusTerrain = new System.Windows.Forms.Label();
            cbOnMinimizePause = new System.Windows.Forms.CheckBox();
            nbDrawRadiusObjects = new System.Windows.Forms.NumericUpDown();
            nbDrawRadiusTerrain = new System.Windows.Forms.NumericUpDown();
            tabMultiplayer = new System.Windows.Forms.TabPage();
            cbMPConsoleSupport = new System.Windows.Forms.CheckBox();
            cbMPDisableMQ = new System.Windows.Forms.CheckBox();
            cbMPSecondSpeed = new System.Windows.Forms.CheckBox();
            tabGame = new System.Windows.Forms.TabPage();
            tabCamera = new System.Windows.Forms.TabPage();
            propGridCamera = new System.Windows.Forms.PropertyGrid();
            tabUtils = new System.Windows.Forms.TabPage();
            cbCharFixWinXP = new System.Windows.Forms.CheckBox();
            cbbPreset = new System.Windows.Forms.ComboBox();
            btOk = new System.Windows.Forms.Button();
            btCancel = new System.Windows.Forms.Button();
            btApplyPreset = new System.Windows.Forms.Button();
            radioButton3 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControlOptions.SuspendLayout();
            tabGraphics.SuspendLayout();
            tabAddon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbDrawRadiusObjects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nbDrawRadiusTerrain).BeginInit();
            tabMultiplayer.SuspendLayout();
            tabCamera.SuspendLayout();
            tabUtils.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new System.Drawing.Point(1, 1);
            splitContainer1.Margin = new System.Windows.Forms.Padding(6);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tabControlOptions);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(cbbPreset);
            splitContainer1.Panel2.Controls.Add(btOk);
            splitContainer1.Panel2.Controls.Add(btCancel);
            splitContainer1.Panel2.Controls.Add(btApplyPreset);
            splitContainer1.Size = new System.Drawing.Size(539, 406);
            splitContainer1.SplitterDistance = 357;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 0;
            // 
            // tabControlOptions
            // 
            tabControlOptions.Controls.Add(tabGraphics);
            tabControlOptions.Controls.Add(tabAddon);
            tabControlOptions.Controls.Add(tabMultiplayer);
            tabControlOptions.Controls.Add(tabGame);
            tabControlOptions.Controls.Add(tabCamera);
            tabControlOptions.Controls.Add(tabUtils);
            tabControlOptions.HotTrack = true;
            tabControlOptions.Location = new System.Drawing.Point(5, 6);
            tabControlOptions.Margin = new System.Windows.Forms.Padding(6);
            tabControlOptions.Name = "tabControlOptions";
            tabControlOptions.Padding = new System.Drawing.Point(10, 3);
            tabControlOptions.SelectedIndex = 0;
            tabControlOptions.Size = new System.Drawing.Size(530, 352);
            tabControlOptions.TabIndex = 0;
            // 
            // tabGraphics
            // 
            tabGraphics.Controls.Add(cbbAudio);
            tabGraphics.Controls.Add(lbTexturesQ);
            tabGraphics.Controls.Add(cbbTextures);
            tabGraphics.Controls.Add(lbShadowingFreq);
            tabGraphics.Controls.Add(cbbShadowing);
            tabGraphics.Controls.Add(lbTerrainQ);
            tabGraphics.Controls.Add(lbShadowsQ);
            tabGraphics.Controls.Add(lbLightingFreq);
            tabGraphics.Controls.Add(lbFiltering);
            tabGraphics.Controls.Add(lbMovies);
            tabGraphics.Controls.Add(cbbMovies);
            tabGraphics.Controls.Add(cbbLighting);
            tabGraphics.Controls.Add(cbbTerrain);
            tabGraphics.Controls.Add(cbbShadows);
            tabGraphics.Controls.Add(cbbFiltering);
            tabGraphics.Controls.Add(cbFPSCursor);
            tabGraphics.Controls.Add(cbDithering);
            tabGraphics.Controls.Add(cbAntialiasing);
            tabGraphics.Controls.Add(cbMipMapping);
            tabGraphics.Controls.Add(cbFullscreen);
            tabGraphics.Controls.Add(lbResolution);
            tabGraphics.Controls.Add(cbbResolutions);
            tabGraphics.Controls.Add(lbAdapter);
            tabGraphics.Controls.Add(lbAudio);
            tabGraphics.Controls.Add(cbbAdapter);
            tabGraphics.Location = new System.Drawing.Point(4, 24);
            tabGraphics.Margin = new System.Windows.Forms.Padding(6);
            tabGraphics.Name = "tabGraphics";
            tabGraphics.Padding = new System.Windows.Forms.Padding(1);
            tabGraphics.Size = new System.Drawing.Size(522, 324);
            tabGraphics.TabIndex = 0;
            tabGraphics.Text = "Graphics";
            tabGraphics.UseVisualStyleBackColor = true;
            // 
            // cbbAudio
            // 
            cbbAudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbAudio.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            cbbAudio.FormattingEnabled = true;
            cbbAudio.Items.AddRange(new object[] { "Off", "Normal", "Safe" });
            cbbAudio.Location = new System.Drawing.Point(4, 294);
            cbbAudio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbbAudio.Name = "cbbAudio";
            cbbAudio.Size = new System.Drawing.Size(89, 21);
            cbbAudio.TabIndex = 25;
            // 
            // lbTexturesQ
            // 
            lbTexturesQ.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lbTexturesQ.Location = new System.Drawing.Point(251, 142);
            lbTexturesQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbTexturesQ.Name = "lbTexturesQ";
            lbTexturesQ.Size = new System.Drawing.Size(159, 15);
            lbTexturesQ.TabIndex = 24;
            lbTexturesQ.Text = "Textures quality";
            lbTexturesQ.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbbTextures
            // 
            cbbTextures.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cbbTextures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbTextures.FormattingEnabled = true;
            cbbTextures.Items.AddRange(new object[] { "high", "normal", "low" });
            cbbTextures.Location = new System.Drawing.Point(413, 137);
            cbbTextures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbbTextures.Name = "cbbTextures";
            cbbTextures.Size = new System.Drawing.Size(102, 23);
            cbbTextures.TabIndex = 23;
            // 
            // lbShadowingFreq
            // 
            lbShadowingFreq.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lbShadowingFreq.Location = new System.Drawing.Point(251, 299);
            lbShadowingFreq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbShadowingFreq.Name = "lbShadowingFreq";
            lbShadowingFreq.Size = new System.Drawing.Size(159, 15);
            lbShadowingFreq.TabIndex = 22;
            lbShadowingFreq.Text = "Shadowing freq.";
            lbShadowingFreq.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbbShadowing
            // 
            cbbShadowing.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cbbShadowing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbShadowing.FormattingEnabled = true;
            cbbShadowing.Items.AddRange(new object[] { "Fast", "Normal", "Rare" });
            cbbShadowing.Location = new System.Drawing.Point(413, 294);
            cbbShadowing.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbbShadowing.Name = "cbbShadowing";
            cbbShadowing.Size = new System.Drawing.Size(102, 23);
            cbbShadowing.TabIndex = 21;
            // 
            // lbTerrainQ
            // 
            lbTerrainQ.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lbTerrainQ.Location = new System.Drawing.Point(251, 220);
            lbTerrainQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbTerrainQ.Name = "lbTerrainQ";
            lbTerrainQ.Size = new System.Drawing.Size(159, 15);
            lbTerrainQ.TabIndex = 20;
            lbTerrainQ.Text = "Terrain LOD";
            lbTerrainQ.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbShadowsQ
            // 
            lbShadowsQ.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lbShadowsQ.Location = new System.Drawing.Point(251, 181);
            lbShadowsQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbShadowsQ.Name = "lbShadowsQ";
            lbShadowsQ.Size = new System.Drawing.Size(159, 15);
            lbShadowsQ.TabIndex = 19;
            lbShadowsQ.Text = "Shadows quality";
            lbShadowsQ.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbLightingFreq
            // 
            lbLightingFreq.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lbLightingFreq.Location = new System.Drawing.Point(251, 260);
            lbLightingFreq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbLightingFreq.Name = "lbLightingFreq";
            lbLightingFreq.Size = new System.Drawing.Size(159, 15);
            lbLightingFreq.TabIndex = 18;
            lbLightingFreq.Text = "Lighting freq.";
            lbLightingFreq.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbFiltering
            // 
            lbFiltering.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lbFiltering.Location = new System.Drawing.Point(251, 103);
            lbFiltering.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbFiltering.Name = "lbFiltering";
            lbFiltering.Size = new System.Drawing.Size(159, 15);
            lbFiltering.TabIndex = 17;
            lbFiltering.Text = "Filtering";
            lbFiltering.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbMovies
            // 
            lbMovies.AutoSize = true;
            lbMovies.Location = new System.Drawing.Point(99, 260);
            lbMovies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbMovies.Name = "lbMovies";
            lbMovies.Size = new System.Drawing.Size(45, 15);
            lbMovies.TabIndex = 16;
            lbMovies.Text = "Movies";
            // 
            // cbbMovies
            // 
            cbbMovies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbMovies.FormattingEnabled = true;
            cbbMovies.Items.AddRange(new object[] { "Off", "1:1", "Fit" });
            cbbMovies.Location = new System.Drawing.Point(4, 255);
            cbbMovies.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbbMovies.Name = "cbbMovies";
            cbbMovies.Size = new System.Drawing.Size(89, 23);
            cbbMovies.TabIndex = 15;
            // 
            // cbbLighting
            // 
            cbbLighting.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cbbLighting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbLighting.FormattingEnabled = true;
            cbbLighting.Items.AddRange(new object[] { "Fast", "Normal", "Rare" });
            cbbLighting.Location = new System.Drawing.Point(413, 255);
            cbbLighting.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbbLighting.Name = "cbbLighting";
            cbbLighting.Size = new System.Drawing.Size(102, 23);
            cbbLighting.TabIndex = 14;
            cbbLighting.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
            // 
            // cbbTerrain
            // 
            cbbTerrain.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cbbTerrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbTerrain.FormattingEnabled = true;
            cbbTerrain.Items.AddRange(new object[] { "High", "normal", "Low" });
            cbbTerrain.Location = new System.Drawing.Point(414, 216);
            cbbTerrain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbbTerrain.Name = "cbbTerrain";
            cbbTerrain.Size = new System.Drawing.Size(101, 23);
            cbbTerrain.TabIndex = 13;
            cbbTerrain.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // cbbShadows
            // 
            cbbShadows.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cbbShadows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbShadows.FormattingEnabled = true;
            cbbShadows.Items.AddRange(new object[] { "None", "Low", "Smooth" });
            cbbShadows.Location = new System.Drawing.Point(414, 177);
            cbbShadows.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbbShadows.Name = "cbbShadows";
            cbbShadows.Size = new System.Drawing.Size(101, 23);
            cbbShadows.TabIndex = 12;
            cbbShadows.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // cbbFiltering
            // 
            cbbFiltering.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cbbFiltering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbFiltering.FormattingEnabled = true;
            cbbFiltering.Items.AddRange(new object[] { "point", "bilinear", "thrilinear" });
            cbbFiltering.Location = new System.Drawing.Point(414, 98);
            cbbFiltering.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbbFiltering.Name = "cbbFiltering";
            cbbFiltering.Size = new System.Drawing.Size(101, 23);
            cbbFiltering.TabIndex = 11;
            cbbFiltering.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // cbFPSCursor
            // 
            cbFPSCursor.AutoSize = true;
            cbFPSCursor.Location = new System.Drawing.Point(6, 220);
            cbFPSCursor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbFPSCursor.Name = "cbFPSCursor";
            cbFPSCursor.Size = new System.Drawing.Size(147, 19);
            cbFPSCursor.TabIndex = 9;
            cbFPSCursor.Text = "FPS independed cursor";
            cbFPSCursor.UseVisualStyleBackColor = true;
            // 
            // cbDithering
            // 
            cbDithering.AutoSize = true;
            cbDithering.Location = new System.Drawing.Point(6, 190);
            cbDithering.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbDithering.Name = "cbDithering";
            cbDithering.Size = new System.Drawing.Size(75, 19);
            cbDithering.TabIndex = 7;
            cbDithering.Text = "Dithering";
            cbDithering.UseVisualStyleBackColor = true;
            // 
            // cbAntialiasing
            // 
            cbAntialiasing.AutoSize = true;
            cbAntialiasing.Location = new System.Drawing.Point(6, 160);
            cbAntialiasing.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbAntialiasing.Name = "cbAntialiasing";
            cbAntialiasing.Size = new System.Drawing.Size(88, 19);
            cbAntialiasing.TabIndex = 6;
            cbAntialiasing.Text = "Antialiasing";
            cbAntialiasing.UseVisualStyleBackColor = true;
            // 
            // cbMipMapping
            // 
            cbMipMapping.AutoSize = true;
            cbMipMapping.Location = new System.Drawing.Point(6, 130);
            cbMipMapping.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbMipMapping.Name = "cbMipMapping";
            cbMipMapping.Size = new System.Drawing.Size(100, 19);
            cbMipMapping.TabIndex = 5;
            cbMipMapping.Text = "Mip-Mapping";
            cbMipMapping.UseVisualStyleBackColor = true;
            // 
            // cbFullscreen
            // 
            cbFullscreen.AutoSize = true;
            cbFullscreen.Location = new System.Drawing.Point(6, 100);
            cbFullscreen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbFullscreen.Name = "cbFullscreen";
            cbFullscreen.Size = new System.Drawing.Size(80, 19);
            cbFullscreen.TabIndex = 4;
            cbFullscreen.Text = "FullScreen";
            cbFullscreen.UseVisualStyleBackColor = true;
            // 
            // lbResolution
            // 
            lbResolution.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbResolution.AutoSize = true;
            lbResolution.Location = new System.Drawing.Point(5, 47);
            lbResolution.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbResolution.Name = "lbResolution";
            lbResolution.Size = new System.Drawing.Size(63, 15);
            lbResolution.TabIndex = 3;
            lbResolution.Text = "Resolution";
            // 
            // cbbResolutions
            // 
            cbbResolutions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbbResolutions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbResolutions.FormattingEnabled = true;
            cbbResolutions.Location = new System.Drawing.Point(4, 65);
            cbbResolutions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbbResolutions.MaxDropDownItems = 10;
            cbbResolutions.Name = "cbbResolutions";
            cbbResolutions.Size = new System.Drawing.Size(511, 23);
            cbbResolutions.TabIndex = 2;
            // 
            // lbAdapter
            // 
            lbAdapter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbAdapter.AutoSize = true;
            lbAdapter.Location = new System.Drawing.Point(5, 2);
            lbAdapter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbAdapter.Name = "lbAdapter";
            lbAdapter.Size = new System.Drawing.Size(49, 15);
            lbAdapter.TabIndex = 1;
            lbAdapter.Text = "Adapter";
            // 
            // lbAudio
            // 
            lbAudio.AutoSize = true;
            lbAudio.Location = new System.Drawing.Point(103, 299);
            lbAudio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbAudio.Name = "lbAudio";
            lbAudio.Size = new System.Drawing.Size(39, 15);
            lbAudio.TabIndex = 26;
            lbAudio.Text = "Audio";
            // 
            // cbbAdapter
            // 
            cbbAdapter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbbAdapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbAdapter.FormattingEnabled = true;
            cbbAdapter.Location = new System.Drawing.Point(4, 20);
            cbbAdapter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbbAdapter.MaxDropDownItems = 10;
            cbbAdapter.Name = "cbbAdapter";
            cbbAdapter.Size = new System.Drawing.Size(511, 23);
            cbbAdapter.TabIndex = 0;
            // 
            // tabAddon
            // 
            tabAddon.Controls.Add(lbDrawRadiusObjects);
            tabAddon.Controls.Add(lbDrawRadiusTerrain);
            tabAddon.Controls.Add(cbOnMinimizePause);
            tabAddon.Controls.Add(nbDrawRadiusObjects);
            tabAddon.Controls.Add(nbDrawRadiusTerrain);
            tabAddon.Location = new System.Drawing.Point(4, 24);
            tabAddon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabAddon.Name = "tabAddon";
            tabAddon.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabAddon.Size = new System.Drawing.Size(522, 324);
            tabAddon.TabIndex = 1;
            tabAddon.Text = "Addon";
            tabAddon.UseVisualStyleBackColor = true;
            // 
            // lbDrawRadiusObjects
            // 
            lbDrawRadiusObjects.AutoSize = true;
            lbDrawRadiusObjects.Location = new System.Drawing.Point(148, 66);
            lbDrawRadiusObjects.Name = "lbDrawRadiusObjects";
            lbDrawRadiusObjects.Size = new System.Drawing.Size(111, 15);
            lbDrawRadiusObjects.TabIndex = 12;
            lbDrawRadiusObjects.Text = "Objects draw radius";
            // 
            // lbDrawRadiusTerrain
            // 
            lbDrawRadiusTerrain.AutoSize = true;
            lbDrawRadiusTerrain.Location = new System.Drawing.Point(148, 38);
            lbDrawRadiusTerrain.Name = "lbDrawRadiusTerrain";
            lbDrawRadiusTerrain.Size = new System.Drawing.Size(127, 15);
            lbDrawRadiusTerrain.TabIndex = 11;
            lbDrawRadiusTerrain.Text = "Landscape draw radius";
            // 
            // cbOnMinimizePause
            // 
            cbOnMinimizePause.AutoSize = true;
            cbOnMinimizePause.Location = new System.Drawing.Point(18, 104);
            cbOnMinimizePause.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbOnMinimizePause.Name = "cbOnMinimizePause";
            cbOnMinimizePause.Size = new System.Drawing.Size(181, 19);
            cbOnMinimizePause.TabIndex = 10;
            cbOnMinimizePause.Text = "Pause when minimized game";
            cbOnMinimizePause.UseVisualStyleBackColor = true;
            // 
            // nbDrawRadiusObjects
            // 
            nbDrawRadiusObjects.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            nbDrawRadiusObjects.Location = new System.Drawing.Point(18, 63);
            nbDrawRadiusObjects.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            nbDrawRadiusObjects.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nbDrawRadiusObjects.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            nbDrawRadiusObjects.Name = "nbDrawRadiusObjects";
            nbDrawRadiusObjects.ReadOnly = true;
            nbDrawRadiusObjects.Size = new System.Drawing.Size(124, 23);
            nbDrawRadiusObjects.TabIndex = 3;
            nbDrawRadiusObjects.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nbDrawRadiusObjects.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // nbDrawRadiusTerrain
            // 
            nbDrawRadiusTerrain.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            nbDrawRadiusTerrain.Location = new System.Drawing.Point(18, 34);
            nbDrawRadiusTerrain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            nbDrawRadiusTerrain.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nbDrawRadiusTerrain.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            nbDrawRadiusTerrain.Name = "nbDrawRadiusTerrain";
            nbDrawRadiusTerrain.ReadOnly = true;
            nbDrawRadiusTerrain.Size = new System.Drawing.Size(124, 23);
            nbDrawRadiusTerrain.TabIndex = 2;
            nbDrawRadiusTerrain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nbDrawRadiusTerrain.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // tabMultiplayer
            // 
            tabMultiplayer.Controls.Add(cbMPConsoleSupport);
            tabMultiplayer.Controls.Add(cbMPDisableMQ);
            tabMultiplayer.Controls.Add(cbMPSecondSpeed);
            tabMultiplayer.Location = new System.Drawing.Point(4, 24);
            tabMultiplayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabMultiplayer.Name = "tabMultiplayer";
            tabMultiplayer.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabMultiplayer.Size = new System.Drawing.Size(522, 324);
            tabMultiplayer.TabIndex = 2;
            tabMultiplayer.Text = "Multiplayer";
            tabMultiplayer.UseVisualStyleBackColor = true;
            // 
            // cbMPConsoleSupport
            // 
            cbMPConsoleSupport.AutoSize = true;
            cbMPConsoleSupport.Location = new System.Drawing.Point(21, 77);
            cbMPConsoleSupport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbMPConsoleSupport.Name = "cbMPConsoleSupport";
            cbMPConsoleSupport.Size = new System.Drawing.Size(113, 19);
            cbMPConsoleSupport.TabIndex = 13;
            cbMPConsoleSupport.Text = "Console support";
            cbMPConsoleSupport.UseVisualStyleBackColor = true;
            // 
            // cbMPDisableMQ
            // 
            cbMPDisableMQ.AutoSize = true;
            cbMPDisableMQ.Location = new System.Drawing.Point(21, 52);
            cbMPDisableMQ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbMPDisableMQ.Name = "cbMPDisableMQ";
            cbMPDisableMQ.Size = new System.Drawing.Size(237, 19);
            cbMPDisableMQ.TabIndex = 12;
            cbMPDisableMQ.Text = "Do not load .MQ (Quest) files from Host";
            cbMPDisableMQ.UseVisualStyleBackColor = true;
            // 
            // cbMPSecondSpeed
            // 
            cbMPSecondSpeed.AutoSize = true;
            cbMPSecondSpeed.Location = new System.Drawing.Point(21, 27);
            cbMPSecondSpeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbMPSecondSpeed.Name = "cbMPSecondSpeed";
            cbMPSecondSpeed.Size = new System.Drawing.Size(143, 19);
            cbMPSecondSpeed.TabIndex = 11;
            cbMPSecondSpeed.Text = "Second speed support";
            cbMPSecondSpeed.UseVisualStyleBackColor = true;
            // 
            // tabGame
            // 
            tabGame.Location = new System.Drawing.Point(4, 24);
            tabGame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabGame.Name = "tabGame";
            tabGame.Size = new System.Drawing.Size(522, 324);
            tabGame.TabIndex = 3;
            tabGame.Text = "Game";
            tabGame.UseVisualStyleBackColor = true;
            // 
            // tabCamera
            // 
            tabCamera.Controls.Add(propGridCamera);
            tabCamera.Location = new System.Drawing.Point(4, 24);
            tabCamera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabCamera.Name = "tabCamera";
            tabCamera.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabCamera.Size = new System.Drawing.Size(522, 324);
            tabCamera.TabIndex = 4;
            tabCamera.Text = "Camera";
            tabCamera.UseVisualStyleBackColor = true;
            // 
            // propGridCamera
            // 
            propGridCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            propGridCamera.HelpVisible = false;
            propGridCamera.Location = new System.Drawing.Point(4, 3);
            propGridCamera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            propGridCamera.Name = "propGridCamera";
            propGridCamera.Size = new System.Drawing.Size(514, 318);
            propGridCamera.TabIndex = 0;
            // 
            // tabUtils
            // 
            tabUtils.Controls.Add(cbCharFixWinXP);
            tabUtils.Location = new System.Drawing.Point(4, 24);
            tabUtils.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabUtils.Name = "tabUtils";
            tabUtils.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabUtils.Size = new System.Drawing.Size(522, 324);
            tabUtils.TabIndex = 5;
            tabUtils.Text = "Utils";
            tabUtils.UseVisualStyleBackColor = true;
            // 
            // cbCharFixWinXP
            // 
            cbCharFixWinXP.AutoSize = true;
            cbCharFixWinXP.Location = new System.Drawing.Point(26, 40);
            cbCharFixWinXP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbCharFixWinXP.Name = "cbCharFixWinXP";
            cbCharFixWinXP.Size = new System.Drawing.Size(179, 19);
            cbCharFixWinXP.TabIndex = 11;
            cbCharFixWinXP.Text = "Russian charset fix for WinXP";
            cbCharFixWinXP.UseVisualStyleBackColor = true;
            // 
            // cbbPreset
            // 
            cbbPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbPreset.FormattingEnabled = true;
            cbbPreset.Location = new System.Drawing.Point(8, 10);
            cbbPreset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbbPreset.Name = "cbbPreset";
            cbbPreset.Size = new System.Drawing.Size(125, 23);
            cbbPreset.TabIndex = 26;
            // 
            // btOk
            // 
            btOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btOk.Location = new System.Drawing.Point(320, 6);
            btOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btOk.Name = "btOk";
            btOk.Size = new System.Drawing.Size(103, 33);
            btOk.TabIndex = 1;
            btOk.Text = "OK";
            btOk.UseVisualStyleBackColor = true;
            btOk.Click += button2_Click;
            // 
            // btCancel
            // 
            btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btCancel.Location = new System.Drawing.Point(430, 6);
            btCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btCancel.Name = "btCancel";
            btCancel.Size = new System.Drawing.Size(103, 33);
            btCancel.TabIndex = 0;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = true;
            // 
            // btApplyPreset
            // 
            btApplyPreset.Location = new System.Drawing.Point(141, 6);
            btApplyPreset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btApplyPreset.Name = "btApplyPreset";
            btApplyPreset.Size = new System.Drawing.Size(103, 33);
            btApplyPreset.TabIndex = 3;
            btApplyPreset.Text = "Apply preset";
            btApplyPreset.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new System.Drawing.Point(4, 46);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new System.Drawing.Size(45, 17);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Low";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(4, 29);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(62, 17);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Medium";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new System.Drawing.Point(4, 12);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(47, 17);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "High";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            AcceptButton = btOk;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btCancel;
            ClientSize = new System.Drawing.Size(541, 408);
            Controls.Add(splitContainer1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Options";
            Padding = new System.Windows.Forms.Padding(1);
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Options";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControlOptions.ResumeLayout(false);
            tabGraphics.ResumeLayout(false);
            tabGraphics.PerformLayout();
            tabAddon.ResumeLayout(false);
            tabAddon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nbDrawRadiusObjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)nbDrawRadiusTerrain).EndInit();
            tabMultiplayer.ResumeLayout(false);
            tabMultiplayer.PerformLayout();
            tabCamera.ResumeLayout(false);
            tabUtils.ResumeLayout(false);
            tabUtils.PerformLayout();
            ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabGame;
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
    }
}