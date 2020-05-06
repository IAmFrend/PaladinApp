namespace PaladinApp
{
    partial class Connection_Form
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
            this.lbServer = new System.Windows.Forms.Label();
            this.cbServer = new System.Windows.Forms.ComboBox();
            this.lbDatabase = new System.Windows.Forms.Label();
            this.cbDatabase = new System.Windows.Forms.ComboBox();
            this.btChecked = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbServer
            // 
            this.lbServer.AutoSize = true;
            this.lbServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbServer.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.lbServer.Location = new System.Drawing.Point(0, 0);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(79, 25);
            this.lbServer.TabIndex = 0;
            this.lbServer.Text = "Сервер";
            // 
            // cbServer
            // 
            this.cbServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbServer.Enabled = false;
            this.cbServer.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.cbServer.FormattingEnabled = true;
            this.cbServer.Location = new System.Drawing.Point(0, 25);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(522, 31);
            this.cbServer.TabIndex = 1;
            this.cbServer.SelectedIndexChanged += new System.EventHandler(this.CbServer_SelectedIndexChanged);
            // 
            // lbDatabase
            // 
            this.lbDatabase.AutoSize = true;
            this.lbDatabase.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDatabase.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.lbDatabase.Location = new System.Drawing.Point(0, 56);
            this.lbDatabase.Name = "lbDatabase";
            this.lbDatabase.Size = new System.Drawing.Size(130, 25);
            this.lbDatabase.TabIndex = 2;
            this.lbDatabase.Text = "База данных";
            // 
            // cbDatabase
            // 
            this.cbDatabase.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDatabase.Enabled = false;
            this.cbDatabase.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.cbDatabase.FormattingEnabled = true;
            this.cbDatabase.Location = new System.Drawing.Point(0, 81);
            this.cbDatabase.Name = "cbDatabase";
            this.cbDatabase.Size = new System.Drawing.Size(522, 31);
            this.cbDatabase.TabIndex = 3;
            // 
            // btChecked
            // 
            this.btChecked.Dock = System.Windows.Forms.DockStyle.Left;
            this.btChecked.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btChecked.Location = new System.Drawing.Point(0, 112);
            this.btChecked.Name = "btChecked";
            this.btChecked.Size = new System.Drawing.Size(171, 87);
            this.btChecked.TabIndex = 4;
            this.btChecked.Text = "Проверить";
            this.btChecked.UseVisualStyleBackColor = true;
            this.btChecked.Click += new System.EventHandler(this.BtChecked_Click);
            // 
            // btCancel
            // 
            this.btCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCancel.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btCancel.Location = new System.Drawing.Point(351, 112);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(171, 87);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // btConnect
            // 
            this.btConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btConnect.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btConnect.Location = new System.Drawing.Point(171, 112);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(180, 87);
            this.btConnect.TabIndex = 6;
            this.btConnect.Text = "Подключить";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.BtConnect_Click);
            // 
            // Connection_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 199);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btChecked);
            this.Controls.Add(this.cbDatabase);
            this.Controls.Add(this.lbDatabase);
            this.Controls.Add(this.cbServer);
            this.Controls.Add(this.lbServer);
            this.Name = "Connection_Form";
            this.Text = "Соединение с сервером";
            this.Load += new System.EventHandler(this.Connection_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.ComboBox cbServer;
        private System.Windows.Forms.Label lbDatabase;
        private System.Windows.Forms.ComboBox cbDatabase;
        private System.Windows.Forms.Button btChecked;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btConnect;
    }
}