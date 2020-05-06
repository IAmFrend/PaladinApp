namespace PaladinApp
{
    partial class TrainerForm
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
            this.lblTrainers = new System.Windows.Forms.Label();
            this.dgTrainers = new System.Windows.Forms.DataGridView();
            this.tbTrainerPatronymic = new System.Windows.Forms.TextBox();
            this.lblTrainerPatronymic = new System.Windows.Forms.Label();
            this.tbTrainerName = new System.Windows.Forms.TextBox();
            this.lblTrainerName = new System.Windows.Forms.Label();
            this.tbTrainerFirstname = new System.Windows.Forms.TextBox();
            this.lblTrainerFirstname = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.tbTrainerConfirm = new System.Windows.Forms.TextBox();
            this.lblTrainerConfirm = new System.Windows.Forms.Label();
            this.tbTrainerPassword = new System.Windows.Forms.TextBox();
            this.lblTrainerPassword = new System.Windows.Forms.Label();
            this.tbTrainerLogin = new System.Windows.Forms.TextBox();
            this.lblTrainerLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrainers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTrainers
            // 
            this.lblTrainers.AutoSize = true;
            this.lblTrainers.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTrainers.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.lblTrainers.Location = new System.Drawing.Point(0, 0);
            this.lblTrainers.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTrainers.Name = "lblTrainers";
            this.lblTrainers.Size = new System.Drawing.Size(89, 25);
            this.lblTrainers.TabIndex = 0;
            this.lblTrainers.Text = "Тренера";
            // 
            // dgTrainers
            // 
            this.dgTrainers.AllowUserToAddRows = false;
            this.dgTrainers.AllowUserToDeleteRows = false;
            this.dgTrainers.AllowUserToOrderColumns = true;
            this.dgTrainers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTrainers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgTrainers.Location = new System.Drawing.Point(0, 25);
            this.dgTrainers.Margin = new System.Windows.Forms.Padding(5);
            this.dgTrainers.Name = "dgTrainers";
            this.dgTrainers.ReadOnly = true;
            this.dgTrainers.Size = new System.Drawing.Size(631, 242);
            this.dgTrainers.TabIndex = 1;
            this.dgTrainers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgTrainers_CellContentClick);
            this.dgTrainers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgTrainers_CellContentClick);
            // 
            // tbTrainerPatronymic
            // 
            this.tbTrainerPatronymic.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTrainerPatronymic.Location = new System.Drawing.Point(0, 388);
            this.tbTrainerPatronymic.Name = "tbTrainerPatronymic";
            this.tbTrainerPatronymic.Size = new System.Drawing.Size(631, 29);
            this.tbTrainerPatronymic.TabIndex = 31;
            // 
            // lblTrainerPatronymic
            // 
            this.lblTrainerPatronymic.AutoSize = true;
            this.lblTrainerPatronymic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTrainerPatronymic.Location = new System.Drawing.Point(0, 367);
            this.lblTrainerPatronymic.Name = "lblTrainerPatronymic";
            this.lblTrainerPatronymic.Size = new System.Drawing.Size(86, 21);
            this.lblTrainerPatronymic.TabIndex = 30;
            this.lblTrainerPatronymic.Text = "Отчество";
            // 
            // tbTrainerName
            // 
            this.tbTrainerName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTrainerName.Location = new System.Drawing.Point(0, 338);
            this.tbTrainerName.Name = "tbTrainerName";
            this.tbTrainerName.Size = new System.Drawing.Size(631, 29);
            this.tbTrainerName.TabIndex = 29;
            // 
            // lblTrainerName
            // 
            this.lblTrainerName.AutoSize = true;
            this.lblTrainerName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTrainerName.Location = new System.Drawing.Point(0, 317);
            this.lblTrainerName.Name = "lblTrainerName";
            this.lblTrainerName.Size = new System.Drawing.Size(44, 21);
            this.lblTrainerName.TabIndex = 28;
            this.lblTrainerName.Text = "Имя";
            // 
            // tbTrainerFirstname
            // 
            this.tbTrainerFirstname.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTrainerFirstname.Location = new System.Drawing.Point(0, 288);
            this.tbTrainerFirstname.Name = "tbTrainerFirstname";
            this.tbTrainerFirstname.Size = new System.Drawing.Size(631, 29);
            this.tbTrainerFirstname.TabIndex = 27;
            // 
            // lblTrainerFirstname
            // 
            this.lblTrainerFirstname.AutoSize = true;
            this.lblTrainerFirstname.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTrainerFirstname.Location = new System.Drawing.Point(0, 267);
            this.lblTrainerFirstname.Name = "lblTrainerFirstname";
            this.lblTrainerFirstname.Size = new System.Drawing.Size(82, 21);
            this.lblTrainerFirstname.TabIndex = 26;
            this.lblTrainerFirstname.Text = "Фамилия";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCategory.Location = new System.Drawing.Point(0, 417);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(94, 21);
            this.lbCategory.TabIndex = 32;
            this.lbCategory.Text = "Категория";
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
            this.cbCategory.Location = new System.Drawing.Point(0, 438);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(631, 29);
            this.cbCategory.TabIndex = 33;
            // 
            // btDelete
            // 
            this.btDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btDelete.Location = new System.Drawing.Point(314, 617);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(317, 41);
            this.btDelete.TabIndex = 48;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.BtDelete_Click);
            // 
            // btInsert
            // 
            this.btInsert.Dock = System.Windows.Forms.DockStyle.Left;
            this.btInsert.Location = new System.Drawing.Point(0, 617);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(308, 41);
            this.btInsert.TabIndex = 47;
            this.btInsert.Text = "Добавить";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.BtInsert_Click);
            // 
            // tbTrainerConfirm
            // 
            this.tbTrainerConfirm.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTrainerConfirm.Location = new System.Drawing.Point(0, 588);
            this.tbTrainerConfirm.Name = "tbTrainerConfirm";
            this.tbTrainerConfirm.Size = new System.Drawing.Size(631, 29);
            this.tbTrainerConfirm.TabIndex = 46;
            // 
            // lblTrainerConfirm
            // 
            this.lblTrainerConfirm.AutoSize = true;
            this.lblTrainerConfirm.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTrainerConfirm.Location = new System.Drawing.Point(0, 567);
            this.lblTrainerConfirm.Name = "lblTrainerConfirm";
            this.lblTrainerConfirm.Size = new System.Drawing.Size(175, 21);
            this.lblTrainerConfirm.TabIndex = 45;
            this.lblTrainerConfirm.Text = "Подтвердить пароль";
            // 
            // tbTrainerPassword
            // 
            this.tbTrainerPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTrainerPassword.Location = new System.Drawing.Point(0, 538);
            this.tbTrainerPassword.Name = "tbTrainerPassword";
            this.tbTrainerPassword.Size = new System.Drawing.Size(631, 29);
            this.tbTrainerPassword.TabIndex = 44;
            // 
            // lblTrainerPassword
            // 
            this.lblTrainerPassword.AutoSize = true;
            this.lblTrainerPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTrainerPassword.Location = new System.Drawing.Point(0, 517);
            this.lblTrainerPassword.Name = "lblTrainerPassword";
            this.lblTrainerPassword.Size = new System.Drawing.Size(69, 21);
            this.lblTrainerPassword.TabIndex = 43;
            this.lblTrainerPassword.Text = "Пароль";
            // 
            // tbTrainerLogin
            // 
            this.tbTrainerLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTrainerLogin.Location = new System.Drawing.Point(0, 488);
            this.tbTrainerLogin.Name = "tbTrainerLogin";
            this.tbTrainerLogin.Size = new System.Drawing.Size(631, 29);
            this.tbTrainerLogin.TabIndex = 42;
            // 
            // lblTrainerLogin
            // 
            this.lblTrainerLogin.AutoSize = true;
            this.lblTrainerLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTrainerLogin.Location = new System.Drawing.Point(0, 467);
            this.lblTrainerLogin.Name = "lblTrainerLogin";
            this.lblTrainerLogin.Size = new System.Drawing.Size(61, 21);
            this.lblTrainerLogin.TabIndex = 41;
            this.lblTrainerLogin.Text = "Логин";
            // 
            // TrainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 658);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.tbTrainerConfirm);
            this.Controls.Add(this.lblTrainerConfirm);
            this.Controls.Add(this.tbTrainerPassword);
            this.Controls.Add(this.lblTrainerPassword);
            this.Controls.Add(this.tbTrainerLogin);
            this.Controls.Add(this.lblTrainerLogin);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.tbTrainerPatronymic);
            this.Controls.Add(this.lblTrainerPatronymic);
            this.Controls.Add(this.tbTrainerName);
            this.Controls.Add(this.lblTrainerName);
            this.Controls.Add(this.tbTrainerFirstname);
            this.Controls.Add(this.lblTrainerFirstname);
            this.Controls.Add(this.dgTrainers);
            this.Controls.Add(this.lblTrainers);
            this.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TrainerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с тренерами";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrainerForm_FormClosing);
            this.Load += new System.EventHandler(this.TrainerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTrainers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrainers;
        private System.Windows.Forms.DataGridView dgTrainers;
        private System.Windows.Forms.TextBox tbTrainerPatronymic;
        private System.Windows.Forms.Label lblTrainerPatronymic;
        private System.Windows.Forms.TextBox tbTrainerName;
        private System.Windows.Forms.Label lblTrainerName;
        private System.Windows.Forms.TextBox tbTrainerFirstname;
        private System.Windows.Forms.Label lblTrainerFirstname;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.TextBox tbTrainerConfirm;
        private System.Windows.Forms.Label lblTrainerConfirm;
        private System.Windows.Forms.TextBox tbTrainerPassword;
        private System.Windows.Forms.Label lblTrainerPassword;
        private System.Windows.Forms.TextBox tbTrainerLogin;
        private System.Windows.Forms.Label lblTrainerLogin;
    }
}