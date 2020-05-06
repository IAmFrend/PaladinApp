namespace PaladinApp
{
    partial class ThemeForm
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
            this.lblTheme = new System.Windows.Forms.Label();
            this.lblThemeName = new System.Windows.Forms.Label();
            this.tbThemeName = new System.Windows.Forms.TextBox();
            this.lblThemeAbout = new System.Windows.Forms.Label();
            this.btInsertUpdate = new System.Windows.Forms.Button();
            this.tbThemeAbout = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTheme.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.lblTheme.Location = new System.Drawing.Point(0, 0);
            this.lblTheme.Margin = new System.Windows.Forms.Padding(22, 0, 22, 0);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(225, 27);
            this.lblTheme.TabIndex = 16;
            this.lblTheme.Text = "Работа с тематиками";
            // 
            // lblThemeName
            // 
            this.lblThemeName.AutoSize = true;
            this.lblThemeName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblThemeName.Location = new System.Drawing.Point(0, 27);
            this.lblThemeName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblThemeName.Name = "lblThemeName";
            this.lblThemeName.Size = new System.Drawing.Size(84, 21);
            this.lblThemeName.TabIndex = 17;
            this.lblThemeName.Text = "Название";
            // 
            // tbThemeName
            // 
            this.tbThemeName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbThemeName.Location = new System.Drawing.Point(0, 48);
            this.tbThemeName.Margin = new System.Windows.Forms.Padding(5);
            this.tbThemeName.Name = "tbThemeName";
            this.tbThemeName.Size = new System.Drawing.Size(369, 29);
            this.tbThemeName.TabIndex = 18;
            this.tbThemeName.TextChanged += new System.EventHandler(this.TbTheme_TextChanged);
            // 
            // lblThemeAbout
            // 
            this.lblThemeAbout.AutoSize = true;
            this.lblThemeAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblThemeAbout.Location = new System.Drawing.Point(0, 77);
            this.lblThemeAbout.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblThemeAbout.Name = "lblThemeAbout";
            this.lblThemeAbout.Size = new System.Drawing.Size(93, 21);
            this.lblThemeAbout.TabIndex = 19;
            this.lblThemeAbout.Text = "Описание:";
            // 
            // btInsertUpdate
            // 
            this.btInsertUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btInsertUpdate.Enabled = false;
            this.btInsertUpdate.Location = new System.Drawing.Point(0, 132);
            this.btInsertUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btInsertUpdate.Name = "btInsertUpdate";
            this.btInsertUpdate.Size = new System.Drawing.Size(369, 37);
            this.btInsertUpdate.TabIndex = 20;
            this.btInsertUpdate.Text = "Добавить";
            this.btInsertUpdate.UseVisualStyleBackColor = true;
            this.btInsertUpdate.Click += new System.EventHandler(this.BtInsertUpdate_Click);
            // 
            // tbThemeAbout
            // 
            this.tbThemeAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbThemeAbout.Location = new System.Drawing.Point(0, 98);
            this.tbThemeAbout.Margin = new System.Windows.Forms.Padding(5);
            this.tbThemeAbout.Name = "tbThemeAbout";
            this.tbThemeAbout.Size = new System.Drawing.Size(369, 29);
            this.tbThemeAbout.TabIndex = 21;
            this.tbThemeAbout.TextChanged += new System.EventHandler(this.TbTheme_TextChanged);
            // 
            // ThemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 169);
            this.Controls.Add(this.tbThemeAbout);
            this.Controls.Add(this.btInsertUpdate);
            this.Controls.Add(this.lblThemeAbout);
            this.Controls.Add(this.tbThemeName);
            this.Controls.Add(this.lblThemeName);
            this.Controls.Add(this.lblTheme);
            this.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ThemeForm";
            this.Text = "Работа с тематиками";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThemeForm_FormClosing);
            this.Load += new System.EventHandler(this.ThemeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.Label lblThemeName;
        private System.Windows.Forms.TextBox tbThemeName;
        private System.Windows.Forms.Label lblThemeAbout;
        private System.Windows.Forms.Button btInsertUpdate;
        private System.Windows.Forms.TextBox tbThemeAbout;
    }
}