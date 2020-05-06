namespace PaladinApp
{
    partial class AbonementForm
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
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblCurClient = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblAbonement = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblAction = new System.Windows.Forms.Label();
            this.cbAction = new System.Windows.Forms.ComboBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.lblCurPrice = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbGroup
            // 
            this.cbGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Location = new System.Drawing.Point(0, 90);
            this.cbGroup.Margin = new System.Windows.Forms.Padding(8);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(255, 29);
            this.cbGroup.TabIndex = 9;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGroup.Location = new System.Drawing.Point(0, 69);
            this.lblGroup.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(67, 21);
            this.lblGroup.TabIndex = 8;
            this.lblGroup.Text = "Группа";
            // 
            // lblCurClient
            // 
            this.lblCurClient.AutoSize = true;
            this.lblCurClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCurClient.Location = new System.Drawing.Point(0, 48);
            this.lblCurClient.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCurClient.Name = "lblCurClient";
            this.lblCurClient.Size = new System.Drawing.Size(202, 21);
            this.lblCurClient.TabIndex = 7;
            this.lblCurClient.Text = "Имя Фамилия Отчество";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblClient.Location = new System.Drawing.Point(0, 27);
            this.lblClient.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(72, 21);
            this.lblClient.TabIndex = 6;
            this.lblClient.Text = "Клиент:";
            // 
            // lblAbonement
            // 
            this.lblAbonement.AutoSize = true;
            this.lblAbonement.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAbonement.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.lblAbonement.Location = new System.Drawing.Point(0, 0);
            this.lblAbonement.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblAbonement.Name = "lblAbonement";
            this.lblAbonement.Size = new System.Drawing.Size(259, 27);
            this.lblAbonement.TabIndex = 5;
            this.lblAbonement.Text = "Добавление абонемента";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStart.Location = new System.Drawing.Point(0, 119);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(71, 21);
            this.lblStart.TabIndex = 10;
            this.lblStart.Text = "Начало:";
            // 
            // dtpStart
            // 
            this.dtpStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpStart.Location = new System.Drawing.Point(0, 140);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(255, 29);
            this.dtpStart.TabIndex = 11;
            this.dtpStart.ValueChanged += new System.EventHandler(this.DtpStart_ValueChanged);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEnd.Location = new System.Drawing.Point(0, 169);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(98, 21);
            this.lblEnd.TabIndex = 12;
            this.lblEnd.Text = "Окончание";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpEnd.Enabled = false;
            this.dtpEnd.Location = new System.Drawing.Point(0, 190);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(255, 29);
            this.dtpEnd.TabIndex = 13;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.DtpEnd_ValueChanged);
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAction.Location = new System.Drawing.Point(0, 219);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(61, 21);
            this.lblAction.TabIndex = 14;
            this.lblAction.Text = "Акция";
            // 
            // cbAction
            // 
            this.cbAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAction.FormattingEnabled = true;
            this.cbAction.Location = new System.Drawing.Point(0, 240);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(255, 29);
            this.cbAction.TabIndex = 15;
            this.cbAction.SelectedIndexChanged += new System.EventHandler(this.CbAction_SelectedIndexChanged);
            // 
            // btAdd
            // 
            this.btAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btAdd.Enabled = false;
            this.btAdd.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btAdd.Location = new System.Drawing.Point(0, 317);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(255, 41);
            this.btAdd.TabIndex = 19;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // lblCurPrice
            // 
            this.lblCurPrice.AutoSize = true;
            this.lblCurPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCurPrice.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.lblCurPrice.Location = new System.Drawing.Point(0, 290);
            this.lblCurPrice.Name = "lblCurPrice";
            this.lblCurPrice.Size = new System.Drawing.Size(181, 25);
            this.lblCurPrice.TabIndex = 18;
            this.lblCurPrice.Text = "0 рублей 0 копеек";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrice.Location = new System.Drawing.Point(0, 269);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(85, 21);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "К оплате:";
            // 
            // AbonementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 358);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lblCurPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.cbAction);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.cbGroup);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.lblCurClient);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblAbonement);
            this.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AbonementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление абонемента";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AbonementForm_FormClosing);
            this.Load += new System.EventHandler(this.AbonementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblCurClient;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblAbonement;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.ComboBox cbAction;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label lblCurPrice;
        private System.Windows.Forms.Label lblPrice;
    }
}