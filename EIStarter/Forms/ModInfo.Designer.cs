namespace EIStarter
{
    partial class ModInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModInfo));
            this.NTRtbModInfo = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btChangelog = new System.Windows.Forms.Button();
            this.btReadme = new System.Windows.Forms.Button();
            this.NTRbtModAction = new System.Windows.Forms.Button();
            this.btModFolder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NTRtbModInfo
            // 
            this.NTRtbModInfo.AcceptsReturn = true;
            this.NTRtbModInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NTRtbModInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NTRtbModInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NTRtbModInfo.Location = new System.Drawing.Point(13, 13);
            this.NTRtbModInfo.Margin = new System.Windows.Forms.Padding(39, 35, 3, 3);
            this.NTRtbModInfo.Multiline = true;
            this.NTRtbModInfo.Name = "NTRtbModInfo";
            this.NTRtbModInfo.ReadOnly = true;
            this.NTRtbModInfo.Size = new System.Drawing.Size(217, 188);
            this.NTRtbModInfo.TabIndex = 1;
            this.NTRtbModInfo.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(13);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.NTRtbModInfo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(378, 201);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btModFolder, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btChangelog, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btReadme, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.NTRbtModAction, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(0, 234);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(147, 201);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btChangelog
            // 
            this.btChangelog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btChangelog.Location = new System.Drawing.Point(3, 71);
            this.btChangelog.MaximumSize = new System.Drawing.Size(0, 61);
            this.btChangelog.Name = "btChangelog";
            this.btChangelog.Size = new System.Drawing.Size(141, 28);
            this.btChangelog.TabIndex = 2;
            this.btChangelog.Text = "Changelog";
            this.btChangelog.UseVisualStyleBackColor = true;
            this.btChangelog.Click += new System.EventHandler(this.button3_Click);
            // 
            // btReadme
            // 
            this.btReadme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btReadme.Location = new System.Drawing.Point(3, 37);
            this.btReadme.MaximumSize = new System.Drawing.Size(0, 61);
            this.btReadme.Name = "btReadme";
            this.btReadme.Size = new System.Drawing.Size(141, 28);
            this.btReadme.TabIndex = 1;
            this.btReadme.Text = "Read Me";
            this.btReadme.UseVisualStyleBackColor = true;
            this.btReadme.Click += new System.EventHandler(this.button2_Click);
            // 
            // NTRbtModAction
            // 
            this.NTRbtModAction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NTRbtModAction.Location = new System.Drawing.Point(3, 3);
            this.NTRbtModAction.MaximumSize = new System.Drawing.Size(0, 61);
            this.NTRbtModAction.Name = "NTRbtModAction";
            this.NTRbtModAction.Size = new System.Drawing.Size(141, 28);
            this.NTRbtModAction.TabIndex = 0;
            this.NTRbtModAction.Text = "button1";
            this.NTRbtModAction.UseVisualStyleBackColor = true;
            this.NTRbtModAction.Click += new System.EventHandler(this.button1_Click);
            // 
            // btModFolder
            // 
            this.btModFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btModFolder.Location = new System.Drawing.Point(3, 105);
            this.btModFolder.MaximumSize = new System.Drawing.Size(0, 61);
            this.btModFolder.Name = "btModFolder";
            this.btModFolder.Size = new System.Drawing.Size(141, 28);
            this.btModFolder.TabIndex = 3;
            this.btModFolder.Text = "Open in Explorer...";
            this.btModFolder.UseVisualStyleBackColor = true;
            this.btModFolder.Click += new System.EventHandler(this.button4_Click);
            // 
            // ModInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 201);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModInfo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ModInfo";
            this.Load += new System.EventHandler(this.ModInfo_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox NTRtbModInfo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btChangelog;
        private System.Windows.Forms.Button btReadme;
        private System.Windows.Forms.Button NTRbtModAction;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btModFolder;
    }
}