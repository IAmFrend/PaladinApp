namespace PaladinApp
{
    partial class WorkActionsForm
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
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.btEndless = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.tbProperties = new System.Windows.Forms.TextBox();
            this.lblProperties = new System.Windows.Forms.Label();
            this.nudDiscont = new System.Windows.Forms.NumericUpDown();
            this.lblDiscont = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscont)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpEnd
            // 
            this.dtpEnd.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpEnd.Enabled = false;
            this.dtpEnd.Location = new System.Drawing.Point(0, 98);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(5);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(333, 29);
            this.dtpEnd.TabIndex = 23;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.DtpEnd_ValueChanged);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEnd.Location = new System.Drawing.Point(0, 77);
            this.lblEnd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(98, 21);
            this.lblEnd.TabIndex = 22;
            this.lblEnd.Text = "Окончание";
            // 
            // dtpStart
            // 
            this.dtpStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpStart.Location = new System.Drawing.Point(0, 48);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(5);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(333, 29);
            this.dtpStart.TabIndex = 21;
            this.dtpStart.ValueChanged += new System.EventHandler(this.DtpStart_ValueChanged);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStart.Location = new System.Drawing.Point(0, 27);
            this.lblStart.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(71, 21);
            this.lblStart.TabIndex = 20;
            this.lblStart.Text = "Начало:";
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAction.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.lblAction.Location = new System.Drawing.Point(0, 0);
            this.lblAction.Margin = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(202, 27);
            this.lblAction.TabIndex = 15;
            this.lblAction.Text = "Добавление акции";
            // 
            // btEndless
            // 
            this.btEndless.Dock = System.Windows.Forms.DockStyle.Top;
            this.btEndless.Location = new System.Drawing.Point(0, 127);
            this.btEndless.Name = "btEndless";
            this.btEndless.Size = new System.Drawing.Size(333, 28);
            this.btEndless.TabIndex = 24;
            this.btEndless.Text = "Сделать бессрочной";
            this.btEndless.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEndless.UseVisualStyleBackColor = true;
            this.btEndless.Click += new System.EventHandler(this.BtEndless_Click);
            // 
            // btAdd
            // 
            this.btAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btAdd.Enabled = false;
            this.btAdd.Location = new System.Drawing.Point(0, 256);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(333, 35);
            this.btAdd.TabIndex = 33;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // tbProperties
            // 
            this.tbProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbProperties.Location = new System.Drawing.Point(0, 226);
            this.tbProperties.Name = "tbProperties";
            this.tbProperties.Size = new System.Drawing.Size(333, 29);
            this.tbProperties.TabIndex = 32;
            this.tbProperties.TextChanged += new System.EventHandler(this.TbProperties_TextChanged);
            // 
            // lblProperties
            // 
            this.lblProperties.AutoSize = true;
            this.lblProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProperties.Location = new System.Drawing.Point(0, 205);
            this.lblProperties.Name = "lblProperties";
            this.lblProperties.Size = new System.Drawing.Size(214, 21);
            this.lblProperties.TabIndex = 31;
            this.lblProperties.Text = "Условия предоставления:";
            // 
            // nudDiscont
            // 
            this.nudDiscont.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudDiscont.Location = new System.Drawing.Point(0, 176);
            this.nudDiscont.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDiscont.Name = "nudDiscont";
            this.nudDiscont.Size = new System.Drawing.Size(333, 29);
            this.nudDiscont.TabIndex = 30;
            this.nudDiscont.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDiscont
            // 
            this.lblDiscont.AutoSize = true;
            this.lblDiscont.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDiscont.Location = new System.Drawing.Point(0, 155);
            this.lblDiscont.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDiscont.Name = "lblDiscont";
            this.lblDiscont.Size = new System.Drawing.Size(69, 21);
            this.lblDiscont.TabIndex = 29;
            this.lblDiscont.Text = "Скидка";
            // 
            // WorkActionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 291);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbProperties);
            this.Controls.Add(this.lblProperties);
            this.Controls.Add(this.nudDiscont);
            this.Controls.Add(this.lblDiscont);
            this.Controls.Add(this.btEndless);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblAction);
            this.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "WorkActionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление акции";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WorkActionsForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscont)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Button btEndless;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox tbProperties;
        private System.Windows.Forms.Label lblProperties;
        private System.Windows.Forms.NumericUpDown nudDiscont;
        private System.Windows.Forms.Label lblDiscont;
    }
}