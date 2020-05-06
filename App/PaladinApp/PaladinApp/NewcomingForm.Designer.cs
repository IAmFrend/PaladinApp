namespace PaladinApp
{
    partial class NewcomingForm
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
            this.lblNewcoming = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblCurClient = new System.Windows.Forms.Label();
            this.lblAbonement = new System.Windows.Forms.Label();
            this.cbAbonement = new System.Windows.Forms.ComboBox();
            this.lblAbonAbout = new System.Windows.Forms.Label();
            this.lbAbonAbout = new System.Windows.Forms.ListBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.cbWork = new System.Windows.Forms.ComboBox();
            this.lblWork = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNewcoming
            // 
            this.lblNewcoming.AutoSize = true;
            this.lblNewcoming.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNewcoming.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.lblNewcoming.Location = new System.Drawing.Point(0, 0);
            this.lblNewcoming.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNewcoming.Name = "lblNewcoming";
            this.lblNewcoming.Size = new System.Drawing.Size(254, 27);
            this.lblNewcoming.TabIndex = 0;
            this.lblNewcoming.Text = "Добавление посещения";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblClient.Location = new System.Drawing.Point(0, 27);
            this.lblClient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(72, 21);
            this.lblClient.TabIndex = 1;
            this.lblClient.Text = "Клиент:";
            // 
            // lblCurClient
            // 
            this.lblCurClient.AutoSize = true;
            this.lblCurClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCurClient.Location = new System.Drawing.Point(0, 48);
            this.lblCurClient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCurClient.Name = "lblCurClient";
            this.lblCurClient.Size = new System.Drawing.Size(202, 21);
            this.lblCurClient.TabIndex = 2;
            this.lblCurClient.Text = "Имя Фамилия Отчество";
            // 
            // lblAbonement
            // 
            this.lblAbonement.AutoSize = true;
            this.lblAbonement.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAbonement.Location = new System.Drawing.Point(0, 69);
            this.lblAbonement.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAbonement.Name = "lblAbonement";
            this.lblAbonement.Size = new System.Drawing.Size(102, 21);
            this.lblAbonement.TabIndex = 3;
            this.lblAbonement.Text = "Абонемент:";
            // 
            // cbAbonement
            // 
            this.cbAbonement.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbAbonement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAbonement.FormattingEnabled = true;
            this.cbAbonement.Location = new System.Drawing.Point(0, 90);
            this.cbAbonement.Margin = new System.Windows.Forms.Padding(5);
            this.cbAbonement.Name = "cbAbonement";
            this.cbAbonement.Size = new System.Drawing.Size(339, 29);
            this.cbAbonement.TabIndex = 4;
            this.cbAbonement.SelectedIndexChanged += new System.EventHandler(this.CbAbonement_SelectedIndexChanged);
            // 
            // lblAbonAbout
            // 
            this.lblAbonAbout.AutoSize = true;
            this.lblAbonAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAbonAbout.Location = new System.Drawing.Point(0, 119);
            this.lblAbonAbout.Name = "lblAbonAbout";
            this.lblAbonAbout.Size = new System.Drawing.Size(211, 21);
            this.lblAbonAbout.TabIndex = 5;
            this.lblAbonAbout.Text = "Сведения об абонименте";
            // 
            // lbAbonAbout
            // 
            this.lbAbonAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbAbonAbout.Enabled = false;
            this.lbAbonAbout.FormattingEnabled = true;
            this.lbAbonAbout.ItemHeight = 21;
            this.lbAbonAbout.Location = new System.Drawing.Point(0, 140);
            this.lbAbonAbout.Name = "lbAbonAbout";
            this.lbAbonAbout.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbAbonAbout.Size = new System.Drawing.Size(339, 88);
            this.lbAbonAbout.TabIndex = 6;
            // 
            // btAdd
            // 
            this.btAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btAdd.Enabled = false;
            this.btAdd.Location = new System.Drawing.Point(0, 279);
            this.btAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(339, 37);
            this.btAdd.TabIndex = 17;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // cbWork
            // 
            this.cbWork.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbWork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWork.Enabled = false;
            this.cbWork.FormattingEnabled = true;
            this.cbWork.Location = new System.Drawing.Point(0, 249);
            this.cbWork.Margin = new System.Windows.Forms.Padding(5);
            this.cbWork.Name = "cbWork";
            this.cbWork.Size = new System.Drawing.Size(339, 29);
            this.cbWork.TabIndex = 16;
            // 
            // lblWork
            // 
            this.lblWork.AutoSize = true;
            this.lblWork.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWork.Location = new System.Drawing.Point(0, 228);
            this.lblWork.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWork.Name = "lblWork";
            this.lblWork.Size = new System.Drawing.Size(105, 21);
            this.lblWork.TabIndex = 15;
            this.lblWork.Text = "Тренировка";
            // 
            // NewcomingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 316);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.cbWork);
            this.Controls.Add(this.lblWork);
            this.Controls.Add(this.lbAbonAbout);
            this.Controls.Add(this.lblAbonAbout);
            this.Controls.Add(this.cbAbonement);
            this.Controls.Add(this.lblAbonement);
            this.Controls.Add(this.lblCurClient);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblNewcoming);
            this.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "NewcomingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Добавление посещения";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NCForm_FormClosing);
            this.Load += new System.EventHandler(this.NewcomingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewcoming;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblCurClient;
        private System.Windows.Forms.Label lblAbonement;
        private System.Windows.Forms.ComboBox cbAbonement;
        private System.Windows.Forms.Label lblAbonAbout;
        private System.Windows.Forms.ListBox lbAbonAbout;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ComboBox cbWork;
        private System.Windows.Forms.Label lblWork;
    }
}