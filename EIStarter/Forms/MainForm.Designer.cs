namespace EIStarter
{
    partial class StarterForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StarterForm));
            this.btPlay = new System.Windows.Forms.Button();
            this.btOptions = new System.Windows.Forms.Button();
            this.btReadme = new System.Windows.Forms.Button();
            this.btWeb = new System.Windows.Forms.Button();
            this.btUninstall = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.cbbMod = new System.Windows.Forms.ComboBox();
            this.btLang = new System.Windows.Forms.Button();
            this.btModInfo = new System.Windows.Forms.Button();
            this.NTRlbAddonVer = new System.Windows.Forms.LinkLabel();
            this.btSkin = new System.Windows.Forms.Button();
            this.NTRlbDebug1 = new System.Windows.Forms.Label();
            this.NTRimgLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NTRimgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btPlay
            // 
            this.btPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btPlay.BackColor = System.Drawing.Color.Transparent;
            this.btPlay.FlatAppearance.BorderSize = 0;
            this.btPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPlay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btPlay.ForeColor = System.Drawing.Color.SteelBlue;
            this.btPlay.Location = new System.Drawing.Point(272, 91);
            this.btPlay.Margin = new System.Windows.Forms.Padding(0);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(147, 35);
            this.btPlay.TabIndex = 0;
            this.btPlay.Text = "Play";
            this.btPlay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPlay.UseVisualStyleBackColor = false;
            this.btPlay.Click += new System.EventHandler(this.button1_Click);
            this.btPlay.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.btPlay.MouseLeave += new System.EventHandler(this._MouseLeave);
            this.btPlay.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this._ChangeUICues);
            // 
            // btOptions
            // 
            this.btOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btOptions.BackColor = System.Drawing.Color.Transparent;
            this.btOptions.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btOptions.FlatAppearance.BorderSize = 0;
            this.btOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOptions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btOptions.ForeColor = System.Drawing.Color.SteelBlue;
            this.btOptions.Location = new System.Drawing.Point(272, 126);
            this.btOptions.Margin = new System.Windows.Forms.Padding(0);
            this.btOptions.Name = "btOptions";
            this.btOptions.Size = new System.Drawing.Size(147, 35);
            this.btOptions.TabIndex = 2;
            this.btOptions.Text = "Settings";
            this.btOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btOptions.UseVisualStyleBackColor = false;
            this.btOptions.Click += new System.EventHandler(this.button2_Click);
            this.btOptions.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.btOptions.MouseLeave += new System.EventHandler(this._MouseLeave);
            this.btOptions.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this._ChangeUICues);
            // 
            // btReadme
            // 
            this.btReadme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btReadme.BackColor = System.Drawing.Color.Transparent;
            this.btReadme.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btReadme.FlatAppearance.BorderSize = 0;
            this.btReadme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btReadme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btReadme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReadme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btReadme.ForeColor = System.Drawing.Color.SteelBlue;
            this.btReadme.Location = new System.Drawing.Point(272, 161);
            this.btReadme.Margin = new System.Windows.Forms.Padding(0);
            this.btReadme.Name = "btReadme";
            this.btReadme.Size = new System.Drawing.Size(147, 35);
            this.btReadme.TabIndex = 3;
            this.btReadme.Text = "Info";
            this.btReadme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReadme.UseVisualStyleBackColor = false;
            this.btReadme.Click += new System.EventHandler(this.button3_Click);
            this.btReadme.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.btReadme.MouseLeave += new System.EventHandler(this._MouseLeave);
            this.btReadme.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this._ChangeUICues);
            // 
            // btWeb
            // 
            this.btWeb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btWeb.BackColor = System.Drawing.Color.Transparent;
            this.btWeb.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btWeb.FlatAppearance.BorderSize = 0;
            this.btWeb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btWeb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btWeb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btWeb.ForeColor = System.Drawing.Color.SteelBlue;
            this.btWeb.Location = new System.Drawing.Point(272, 196);
            this.btWeb.Margin = new System.Windows.Forms.Padding(0);
            this.btWeb.Name = "btWeb";
            this.btWeb.Size = new System.Drawing.Size(147, 35);
            this.btWeb.TabIndex = 4;
            this.btWeb.Text = "Web";
            this.btWeb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btWeb.UseVisualStyleBackColor = false;
            this.btWeb.Click += new System.EventHandler(this.button4_Click);
            this.btWeb.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.btWeb.MouseLeave += new System.EventHandler(this._MouseLeave);
            this.btWeb.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this._ChangeUICues);
            // 
            // btUninstall
            // 
            this.btUninstall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btUninstall.BackColor = System.Drawing.Color.Transparent;
            this.btUninstall.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btUninstall.FlatAppearance.BorderSize = 0;
            this.btUninstall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btUninstall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btUninstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUninstall.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btUninstall.ForeColor = System.Drawing.Color.SteelBlue;
            this.btUninstall.Location = new System.Drawing.Point(272, 231);
            this.btUninstall.Margin = new System.Windows.Forms.Padding(0);
            this.btUninstall.Name = "btUninstall";
            this.btUninstall.Size = new System.Drawing.Size(147, 35);
            this.btUninstall.TabIndex = 5;
            this.btUninstall.Text = "Uninstall";
            this.btUninstall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUninstall.UseVisualStyleBackColor = false;
            this.btUninstall.Click += new System.EventHandler(this.button5_Click);
            this.btUninstall.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.btUninstall.MouseLeave += new System.EventHandler(this._MouseLeave);
            this.btUninstall.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this._ChangeUICues);
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.BackColor = System.Drawing.Color.Transparent;
            this.btExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btExit.ForeColor = System.Drawing.Color.SteelBlue;
            this.btExit.Location = new System.Drawing.Point(272, 266);
            this.btExit.Margin = new System.Windows.Forms.Padding(0);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(147, 35);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Exit";
            this.btExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.button6_Click);
            this.btExit.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.btExit.MouseLeave += new System.EventHandler(this._MouseLeave);
            this.btExit.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this._ChangeUICues);
            // 
            // cbbMod
            // 
            this.cbbMod.BackColor = System.Drawing.Color.Black;
            this.cbbMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbbMod.ForeColor = System.Drawing.Color.SteelBlue;
            this.cbbMod.FormattingEnabled = true;
            this.cbbMod.ItemHeight = 15;
            this.cbbMod.Location = new System.Drawing.Point(415, 98);
            this.cbbMod.MaxDropDownItems = 10;
            this.cbbMod.Name = "cbbMod";
            this.cbbMod.Size = new System.Drawing.Size(169, 23);
            this.cbbMod.TabIndex = 1;
            this.cbbMod.SelectedIndexChanged += new System.EventHandler(this.ModCombo_SelectedIndexChanged);
            // 
            // btLang
            // 
            this.btLang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btLang.BackColor = System.Drawing.Color.Transparent;
            this.btLang.FlatAppearance.BorderSize = 0;
            this.btLang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btLang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLang.ForeColor = System.Drawing.Color.SteelBlue;
            this.btLang.Location = new System.Drawing.Point(11, 302);
            this.btLang.Name = "btLang";
            this.btLang.Size = new System.Drawing.Size(90, 48);
            this.btLang.TabIndex = 7;
            this.btLang.Text = "Lang";
            this.btLang.UseVisualStyleBackColor = false;
            this.btLang.Click += new System.EventHandler(this.langbtn_Click);
            this.btLang.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.btLang.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // btModInfo
            // 
            this.btModInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btModInfo.BackColor = System.Drawing.Color.Transparent;
            this.btModInfo.FlatAppearance.BorderSize = 0;
            this.btModInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btModInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btModInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btModInfo.ForeColor = System.Drawing.Color.SteelBlue;
            this.btModInfo.Location = new System.Drawing.Point(552, 93);
            this.btModInfo.Name = "btModInfo";
            this.btModInfo.Size = new System.Drawing.Size(32, 37);
            this.btModInfo.TabIndex = 10;
            this.btModInfo.Text = "i";
            this.btModInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btModInfo.UseVisualStyleBackColor = false;
            this.btModInfo.Click += new System.EventHandler(this.infobtn_Click);
            this.btModInfo.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.btModInfo.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // NTRlbAddonVer
            // 
            this.NTRlbAddonVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NTRlbAddonVer.BackColor = System.Drawing.Color.Transparent;
            this.NTRlbAddonVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NTRlbAddonVer.LinkColor = System.Drawing.Color.SteelBlue;
            this.NTRlbAddonVer.Location = new System.Drawing.Point(422, 338);
            this.NTRlbAddonVer.Name = "NTRlbAddonVer";
            this.NTRlbAddonVer.Size = new System.Drawing.Size(213, 18);
            this.NTRlbAddonVer.TabIndex = 9;
            this.NTRlbAddonVer.TabStop = true;
            this.NTRlbAddonVer.Text = "Parhelion(Addon.dll) vUNK";
            this.NTRlbAddonVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NTRlbAddonVer.VisitedLinkColor = System.Drawing.Color.SteelBlue;
            this.NTRlbAddonVer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NTRlbAddonVer_LinkClicked);
            // 
            // btSkin
            // 
            this.btSkin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSkin.BackColor = System.Drawing.Color.Transparent;
            this.btSkin.FlatAppearance.BorderSize = 0;
            this.btSkin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btSkin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btSkin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSkin.ForeColor = System.Drawing.Color.SteelBlue;
            this.btSkin.Location = new System.Drawing.Point(107, 302);
            this.btSkin.Name = "btSkin";
            this.btSkin.Size = new System.Drawing.Size(90, 48);
            this.btSkin.TabIndex = 8;
            this.btSkin.Text = "Skin";
            this.btSkin.UseVisualStyleBackColor = false;
            this.btSkin.Click += new System.EventHandler(this.skinbtn_Click);
            this.btSkin.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.btSkin.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // NTRlbDebug1
            // 
            this.NTRlbDebug1.AutoSize = true;
            this.NTRlbDebug1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NTRlbDebug1.ForeColor = System.Drawing.Color.Lime;
            this.NTRlbDebug1.Location = new System.Drawing.Point(8, 9);
            this.NTRlbDebug1.Name = "NTRlbDebug1";
            this.NTRlbDebug1.Size = new System.Drawing.Size(0, 13);
            this.NTRlbDebug1.TabIndex = 11;
            // 
            // NTRimgLogo
            // 
            this.NTRimgLogo.BackColor = System.Drawing.Color.Transparent;
            this.NTRimgLogo.Location = new System.Drawing.Point(176, 9);
            this.NTRimgLogo.Name = "NTRimgLogo";
            this.NTRimgLogo.Size = new System.Drawing.Size(288, 79);
            this.NTRimgLogo.TabIndex = 12;
            this.NTRimgLogo.TabStop = false;
            this.NTRimgLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StarterForm_MouseMove);
            // 
            // StarterForm
            // 
            this.AcceptButton = this.btPlay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btExit;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.NTRlbDebug1);
            this.Controls.Add(this.btSkin);
            this.Controls.Add(this.NTRlbAddonVer);
            this.Controls.Add(this.btModInfo);
            this.Controls.Add(this.btLang);
            this.Controls.Add(this.cbbMod);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btUninstall);
            this.Controls.Add(this.btWeb);
            this.Controls.Add(this.btReadme);
            this.Controls.Add(this.btOptions);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.NTRimgLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StarterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StarterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StarterForm_FormClosing);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StarterForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.NTRimgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btOptions;
        private System.Windows.Forms.Button btReadme;
        private System.Windows.Forms.Button btWeb;
        private System.Windows.Forms.Button btUninstall;
        private System.Windows.Forms.Button btExit;
        public System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.ComboBox cbbMod;
        private System.Windows.Forms.Button btLang;
        private System.Windows.Forms.Button btModInfo;
        private System.Windows.Forms.LinkLabel NTRlbAddonVer;
        private System.Windows.Forms.Button btSkin;
        private System.Windows.Forms.Label NTRlbDebug1;
        private System.Windows.Forms.PictureBox NTRimgLogo;
    }
}

