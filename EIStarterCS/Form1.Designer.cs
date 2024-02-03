namespace EIStarterCS
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
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            ModCombo = new System.Windows.Forms.ComboBox();
            langbtn = new System.Windows.Forms.Button();
            infobtn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            button1.ForeColor = System.Drawing.Color.SteelBlue;
            button1.Location = new System.Drawing.Point(237, 91);
            button1.Margin = new System.Windows.Forms.Padding(0);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(200, 30);
            button1.TabIndex = 0;
            button1.Text = "Play";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseEnter += _MouseEnter;
            button1.MouseLeave += _MouseLeave;
            button1.ChangeUICues += _ChangeUICues;
            // 
            // button2
            // 
            button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            button2.BackColor = System.Drawing.Color.Transparent;
            button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            button2.ForeColor = System.Drawing.Color.SteelBlue;
            button2.Location = new System.Drawing.Point(237, 126);
            button2.Margin = new System.Windows.Forms.Padding(0);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(200, 30);
            button2.TabIndex = 2;
            button2.Text = "Settings";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.MouseEnter += _MouseEnter;
            button2.MouseLeave += _MouseLeave;
            button2.ChangeUICues += _ChangeUICues;
            // 
            // button3
            // 
            button3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            button3.BackColor = System.Drawing.Color.Transparent;
            button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            button3.ForeColor = System.Drawing.Color.SteelBlue;
            button3.Location = new System.Drawing.Point(237, 161);
            button3.Margin = new System.Windows.Forms.Padding(0);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(200, 30);
            button3.TabIndex = 3;
            button3.Text = "Info";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            button3.MouseEnter += _MouseEnter;
            button3.MouseLeave += _MouseLeave;
            button3.ChangeUICues += _ChangeUICues;
            // 
            // button4
            // 
            button4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            button4.BackColor = System.Drawing.Color.Transparent;
            button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            button4.ForeColor = System.Drawing.Color.SteelBlue;
            button4.Location = new System.Drawing.Point(237, 196);
            button4.Margin = new System.Windows.Forms.Padding(0);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(200, 30);
            button4.TabIndex = 4;
            button4.Text = "Web";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            button4.MouseEnter += _MouseEnter;
            button4.MouseLeave += _MouseLeave;
            button4.ChangeUICues += _ChangeUICues;
            // 
            // button5
            // 
            button5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            button5.BackColor = System.Drawing.Color.Transparent;
            button5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            button5.ForeColor = System.Drawing.Color.SteelBlue;
            button5.Location = new System.Drawing.Point(237, 231);
            button5.Margin = new System.Windows.Forms.Padding(0);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(200, 30);
            button5.TabIndex = 5;
            button5.Text = "Uninstall";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            button5.MouseEnter += _MouseEnter;
            button5.MouseLeave += _MouseLeave;
            button5.ChangeUICues += _ChangeUICues;
            // 
            // button6
            // 
            button6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            button6.BackColor = System.Drawing.Color.Transparent;
            button6.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            button6.ForeColor = System.Drawing.Color.SteelBlue;
            button6.Location = new System.Drawing.Point(237, 266);
            button6.Margin = new System.Windows.Forms.Padding(0);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(200, 30);
            button6.TabIndex = 6;
            button6.Text = "Exit";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            button6.MouseEnter += _MouseEnter;
            button6.MouseLeave += _MouseLeave;
            button6.ChangeUICues += _ChangeUICues;
            // 
            // ModCombo
            // 
            ModCombo.BackColor = System.Drawing.Color.Black;
            ModCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ModCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ModCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            ModCombo.ForeColor = System.Drawing.Color.SteelBlue;
            ModCombo.FormattingEnabled = true;
            ModCombo.ItemHeight = 15;
            ModCombo.Location = new System.Drawing.Point(484, 97);
            ModCombo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ModCombo.MaxDropDownItems = 10;
            ModCombo.Name = "ModCombo";
            ModCombo.Size = new System.Drawing.Size(170, 23);
            ModCombo.TabIndex = 1;
            ModCombo.SelectedIndexChanged += ModCombo_SelectedIndexChanged;
            // 
            // langbtn
            // 
            langbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            langbtn.BackColor = System.Drawing.Color.Transparent;
            langbtn.FlatAppearance.BorderSize = 0;
            langbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            langbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            langbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            langbtn.Location = new System.Drawing.Point(13, 293);
            langbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            langbtn.Name = "langbtn";
            langbtn.Size = new System.Drawing.Size(105, 55);
            langbtn.TabIndex = 7;
            langbtn.UseVisualStyleBackColor = false;
            langbtn.Click += langbtn_Click;
            langbtn.MouseEnter += _MouseEnter;
            langbtn.MouseLeave += _MouseLeave;
            // 
            // infobtn
            // 
            infobtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            infobtn.BackColor = System.Drawing.Color.Transparent;
            infobtn.FlatAppearance.BorderSize = 0;
            infobtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            infobtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            infobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            infobtn.ForeColor = System.Drawing.Color.SteelBlue;
            infobtn.Location = new System.Drawing.Point(590, 91);
            infobtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            infobtn.Name = "infobtn";
            infobtn.Size = new System.Drawing.Size(37, 43);
            infobtn.TabIndex = 8;
            infobtn.Text = "i";
            infobtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            infobtn.UseVisualStyleBackColor = false;
            infobtn.Click += infobtn_Click;
            infobtn.MouseEnter += _MouseEnter;
            infobtn.MouseLeave += _MouseLeave;
            // 
            // StarterForm
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(44, 44, 44);
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            CancelButton = button6;
            ClientSize = new System.Drawing.Size(640, 360);
            Controls.Add(infobtn);
            Controls.Add(langbtn);
            Controls.Add(ModCombo);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "StarterForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "StarterForm";
            FormClosing += StarterForm_FormClosing;
            MouseMove += StarterForm_MouseMove;
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ModCombo;
        private System.Windows.Forms.Button langbtn;
        private System.Windows.Forms.Button infobtn;
    }
}

