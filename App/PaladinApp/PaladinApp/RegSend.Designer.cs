namespace PaladinApp
{
    partial class RegSend
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
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.tbFirstname = new System.Windows.Forms.TextBox();
            this.lblPatronymic = new System.Windows.Forms.Label();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Имя";
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbName.Location = new System.Drawing.Point(0, 25);
            this.tbName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(298, 32);
            this.tbName.TabIndex = 1;
            this.tbName.TextChanged += new System.EventHandler(this.Tb_TextChanged);
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblfirstname.Location = new System.Drawing.Point(0, 57);
            this.lblfirstname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(98, 25);
            this.lblfirstname.TabIndex = 2;
            this.lblfirstname.Text = "Фамилия";
            // 
            // tbFirstname
            // 
            this.tbFirstname.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbFirstname.Location = new System.Drawing.Point(0, 82);
            this.tbFirstname.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.Size = new System.Drawing.Size(298, 32);
            this.tbFirstname.TabIndex = 3;
            this.tbFirstname.TextChanged += new System.EventHandler(this.Tb_TextChanged);
            // 
            // lblPatronymic
            // 
            this.lblPatronymic.AutoSize = true;
            this.lblPatronymic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPatronymic.Location = new System.Drawing.Point(0, 114);
            this.lblPatronymic.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPatronymic.Name = "lblPatronymic";
            this.lblPatronymic.Size = new System.Drawing.Size(101, 25);
            this.lblPatronymic.TabIndex = 4;
            this.lblPatronymic.Text = "Отчество";
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPatronymic.Location = new System.Drawing.Point(0, 139);
            this.tbPatronymic.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(298, 32);
            this.tbPatronymic.TabIndex = 5;
            this.tbPatronymic.TextChanged += new System.EventHandler(this.Tb_TextChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCategory.Location = new System.Drawing.Point(0, 171);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(108, 25);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Категория";
            // 
            // cbCategory
            // 
            this.cbCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Старший",
            "1",
            "2",
            "3",
            "Помощник"});
            this.cbCategory.Location = new System.Drawing.Point(0, 196);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(298, 31);
            this.cbCategory.TabIndex = 7;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogin.Location = new System.Drawing.Point(0, 227);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(278, 25);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "Адрес обратных сообщений";
            // 
            // tbLogin
            // 
            this.tbLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLogin.Location = new System.Drawing.Point(0, 252);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(298, 32);
            this.tbLogin.TabIndex = 9;
            this.tbLogin.TextChanged += new System.EventHandler(this.Tb_TextChanged);
            // 
            // btCancel
            // 
            this.btCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btCancel.Location = new System.Drawing.Point(0, 284);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(149, 49);
            this.btCancel.TabIndex = 14;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // btSend
            // 
            this.btSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSend.Enabled = false;
            this.btSend.Location = new System.Drawing.Point(155, 284);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(143, 49);
            this.btSend.TabIndex = 15;
            this.btSend.Text = "Отправить";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.BtSend_Click);
            // 
            // RegSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 333);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.tbPatronymic);
            this.Controls.Add(this.lblPatronymic);
            this.Controls.Add(this.tbFirstname);
            this.Controls.Add(this.lblfirstname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "RegSend";
            this.Text = "Заявка на регистрацию";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegSend_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.TextBox tbFirstname;
        private System.Windows.Forms.Label lblPatronymic;
        private System.Windows.Forms.TextBox tbPatronymic;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSend;
    }
}