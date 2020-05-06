namespace PaladinApp
{
    partial class Autorization_Form
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
            this.gbEnterType = new System.Windows.Forms.GroupBox();
            this.rbTrainer = new System.Windows.Forms.RadioButton();
            this.rbManager = new System.Windows.Forms.RadioButton();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tbUserLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbUserPassword = new System.Windows.Forms.TextBox();
            this.btEnter = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btReg = new System.Windows.Forms.Button();
            this.gbEnterType.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEnterType
            // 
            this.gbEnterType.Controls.Add(this.rbTrainer);
            this.gbEnterType.Controls.Add(this.rbManager);
            this.gbEnterType.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbEnterType.Location = new System.Drawing.Point(0, 0);
            this.gbEnterType.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.gbEnterType.Name = "gbEnterType";
            this.gbEnterType.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.gbEnterType.Size = new System.Drawing.Size(418, 71);
            this.gbEnterType.TabIndex = 0;
            this.gbEnterType.TabStop = false;
            this.gbEnterType.Text = "Тип входа";
            // 
            // rbTrainer
            // 
            this.rbTrainer.AutoSize = true;
            this.rbTrainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.rbTrainer.Location = new System.Drawing.Point(315, 30);
            this.rbTrainer.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rbTrainer.Name = "rbTrainer";
            this.rbTrainer.Size = new System.Drawing.Size(97, 36);
            this.rbTrainer.TabIndex = 1;
            this.rbTrainer.Text = "Тренер";
            this.rbTrainer.UseVisualStyleBackColor = true;
            this.rbTrainer.CheckedChanged += new System.EventHandler(this.RbTrainer_CheckedChanged);
            // 
            // rbManager
            // 
            this.rbManager.AutoSize = true;
            this.rbManager.Checked = true;
            this.rbManager.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbManager.Location = new System.Drawing.Point(6, 30);
            this.rbManager.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rbManager.Name = "rbManager";
            this.rbManager.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbManager.Size = new System.Drawing.Size(128, 36);
            this.rbManager.TabIndex = 0;
            this.rbManager.TabStop = true;
            this.rbManager.Text = "Менеджер";
            this.rbManager.UseVisualStyleBackColor = true;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogin.Location = new System.Drawing.Point(0, 71);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(70, 25);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Логин";
            // 
            // tbUserLogin
            // 
            this.tbUserLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbUserLogin.Location = new System.Drawing.Point(0, 96);
            this.tbUserLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbUserLogin.Name = "tbUserLogin";
            this.tbUserLogin.Size = new System.Drawing.Size(418, 32);
            this.tbUserLogin.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPassword.Location = new System.Drawing.Point(0, 128);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 25);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Пароль";
            // 
            // tbUserPassword
            // 
            this.tbUserPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbUserPassword.Location = new System.Drawing.Point(0, 153);
            this.tbUserPassword.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbUserPassword.Name = "tbUserPassword";
            this.tbUserPassword.Size = new System.Drawing.Size(418, 32);
            this.tbUserPassword.TabIndex = 4;
            // 
            // btEnter
            // 
            this.btEnter.Dock = System.Windows.Forms.DockStyle.Left;
            this.btEnter.Location = new System.Drawing.Point(0, 185);
            this.btEnter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(134, 51);
            this.btEnter.TabIndex = 5;
            this.btEnter.Text = "Войти";
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.Click += new System.EventHandler(this.BtEnter_Click);
            // 
            // btClose
            // 
            this.btClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btClose.Location = new System.Drawing.Point(292, 185);
            this.btClose.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(126, 51);
            this.btClose.TabIndex = 6;
            this.btClose.Text = "Отмена";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.BtLeave_Click);
            // 
            // btReg
            // 
            this.btReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btReg.Enabled = false;
            this.btReg.Location = new System.Drawing.Point(134, 185);
            this.btReg.Name = "btReg";
            this.btReg.Size = new System.Drawing.Size(158, 51);
            this.btReg.TabIndex = 7;
            this.btReg.Text = "Регистрация";
            this.btReg.UseVisualStyleBackColor = true;
            this.btReg.Click += new System.EventHandler(this.BtReg_Click);
            // 
            // Autorization_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 236);
            this.Controls.Add(this.btReg);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btEnter);
            this.Controls.Add(this.tbUserPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbUserLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.gbEnterType);
            this.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Autorization_Form";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Autorization_Form_FormClosing);
            this.gbEnterType.ResumeLayout(false);
            this.gbEnterType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEnterType;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox tbUserLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbUserPassword;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.RadioButton rbTrainer;
        private System.Windows.Forms.RadioButton rbManager;
        private System.Windows.Forms.Button btReg;
    }
}