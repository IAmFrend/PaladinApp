namespace PaladinApp
{
    partial class TrainerInterface
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
            this.lblGroup = new System.Windows.Forms.Label();
            this.dgGroup = new System.Windows.Forms.DataGridView();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.tgctrlTrainer = new System.Windows.Forms.TabControl();
            this.tbpgGroup = new System.Windows.Forms.TabPage();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.nudCost = new System.Windows.Forms.NumericUpDown();
            this.lblCost = new System.Windows.Forms.Label();
            this.cbTheme = new System.Windows.Forms.ComboBox();
            this.lblTheme = new System.Windows.Forms.Label();
            this.cbWorkPlace = new System.Windows.Forms.ComboBox();
            this.lblWorkplace = new System.Windows.Forms.Label();
            this.tbpgWork = new System.Windows.Forms.TabPage();
            this.btWorkInsert = new System.Windows.Forms.Button();
            this.btWorkDelete = new System.Windows.Forms.Button();
            this.btCheck = new System.Windows.Forms.Button();
            this.gbWorkLength = new System.Windows.Forms.GroupBox();
            this.nudEndMinute = new System.Windows.Forms.NumericUpDown();
            this.lblEndMinute = new System.Windows.Forms.Label();
            this.nudEndHour = new System.Windows.Forms.NumericUpDown();
            this.lblEndHour = new System.Windows.Forms.Label();
            this.gbWorkTime = new System.Windows.Forms.GroupBox();
            this.nudStartMinute = new System.Windows.Forms.NumericUpDown();
            this.lblStartMinute = new System.Windows.Forms.Label();
            this.nudStartHour = new System.Windows.Forms.NumericUpDown();
            this.lblStartHour = new System.Windows.Forms.Label();
            this.cbWorkDay = new System.Windows.Forms.ComboBox();
            this.lblWorkDay = new System.Windows.Forms.Label();
            this.dgWork = new System.Windows.Forms.DataGridView();
            this.tbpgTheme = new System.Windows.Forms.TabPage();
            this.btTmUpdate = new System.Windows.Forms.Button();
            this.btTmDelete = new System.Windows.Forms.Button();
            this.btTmInsert = new System.Windows.Forms.Button();
            this.gbThemeSearch = new System.Windows.Forms.GroupBox();
            this.tbThemeSearch = new System.Windows.Forms.TextBox();
            this.btThemeSearch = new System.Windows.Forms.Button();
            this.dgTheme = new System.Windows.Forms.DataGridView();
            this.tbpgTimetable = new System.Windows.Forms.TabPage();
            this.btTimetable = new System.Windows.Forms.Button();
            this.dgTimetable = new System.Windows.Forms.DataGridView();
            this.tbpgPersonal = new System.Windows.Forms.TabPage();
            this.btRevoke = new System.Windows.Forms.Button();
            this.btTrainerDarwback = new System.Windows.Forms.Button();
            this.btTrainerConfirm = new System.Windows.Forms.Button();
            this.tbTrainerConfirm = new System.Windows.Forms.TextBox();
            this.lblTrainerConfirm = new System.Windows.Forms.Label();
            this.tbTrainerPassword = new System.Windows.Forms.TextBox();
            this.lblTrainerPassword = new System.Windows.Forms.Label();
            this.tbTrainerLogin = new System.Windows.Forms.TextBox();
            this.lblTrainerLogin = new System.Windows.Forms.Label();
            this.tbCat = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.tbTrainerPatronymic = new System.Windows.Forms.TextBox();
            this.lblTrainerPatronymic = new System.Windows.Forms.Label();
            this.tbTrainerName = new System.Windows.Forms.TextBox();
            this.lblTrainerName = new System.Windows.Forms.Label();
            this.tbTrainerFirstname = new System.Windows.Forms.TextBox();
            this.lblTrainerFirstname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgGroup)).BeginInit();
            this.gbSearch.SuspendLayout();
            this.tgctrlTrainer.SuspendLayout();
            this.tbpgGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).BeginInit();
            this.tbpgWork.SuspendLayout();
            this.gbWorkLength.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndHour)).BeginInit();
            this.gbWorkTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgWork)).BeginInit();
            this.tbpgTheme.SuspendLayout();
            this.gbThemeSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTheme)).BeginInit();
            this.tbpgTimetable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTimetable)).BeginInit();
            this.tbpgPersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGroup.Location = new System.Drawing.Point(0, 0);
            this.lblGroup.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(72, 21);
            this.lblGroup.TabIndex = 0;
            this.lblGroup.Text = "Группы";
            // 
            // dgGroup
            // 
            this.dgGroup.AllowUserToAddRows = false;
            this.dgGroup.AllowUserToDeleteRows = false;
            this.dgGroup.AllowUserToOrderColumns = true;
            this.dgGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgGroup.Location = new System.Drawing.Point(0, 21);
            this.dgGroup.Margin = new System.Windows.Forms.Padding(5);
            this.dgGroup.Name = "dgGroup";
            this.dgGroup.ReadOnly = true;
            this.dgGroup.Size = new System.Drawing.Size(627, 136);
            this.dgGroup.TabIndex = 1;
            this.dgGroup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgGroup_CellClick);
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.tbSearch);
            this.gbSearch.Controls.Add(this.btSearch);
            this.gbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearch.Location = new System.Drawing.Point(0, 157);
            this.gbSearch.Margin = new System.Windows.Forms.Padding(5);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Padding = new System.Windows.Forms.Padding(5);
            this.gbSearch.Size = new System.Drawing.Size(627, 60);
            this.gbSearch.TabIndex = 4;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Поиск";
            // 
            // tbSearch
            // 
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSearch.Location = new System.Drawing.Point(5, 27);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(522, 29);
            this.tbSearch.TabIndex = 2;
            // 
            // btSearch
            // 
            this.btSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSearch.Location = new System.Drawing.Point(527, 27);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(95, 28);
            this.btSearch.TabIndex = 1;
            this.btSearch.Text = "Искать";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.BtSearch_Click);
            // 
            // btClose
            // 
            this.btClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btClose.Location = new System.Drawing.Point(0, 635);
            this.btClose.Margin = new System.Windows.Forms.Padding(5);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(627, 29);
            this.btClose.TabIndex = 5;
            this.btClose.Text = "Выйти";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // tgctrlTrainer
            // 
            this.tgctrlTrainer.Controls.Add(this.tbpgGroup);
            this.tgctrlTrainer.Controls.Add(this.tbpgWork);
            this.tgctrlTrainer.Controls.Add(this.tbpgTheme);
            this.tgctrlTrainer.Controls.Add(this.tbpgTimetable);
            this.tgctrlTrainer.Controls.Add(this.tbpgPersonal);
            this.tgctrlTrainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgctrlTrainer.Location = new System.Drawing.Point(0, 217);
            this.tgctrlTrainer.Margin = new System.Windows.Forms.Padding(5);
            this.tgctrlTrainer.Name = "tgctrlTrainer";
            this.tgctrlTrainer.SelectedIndex = 0;
            this.tgctrlTrainer.Size = new System.Drawing.Size(627, 418);
            this.tgctrlTrainer.TabIndex = 6;
            this.tgctrlTrainer.SelectedIndexChanged += new System.EventHandler(this.TgctrlTrainer_SelectedIndexChanged);
            // 
            // tbpgGroup
            // 
            this.tbpgGroup.Controls.Add(this.btDelete);
            this.tbpgGroup.Controls.Add(this.btUpdate);
            this.tbpgGroup.Controls.Add(this.btInsert);
            this.tbpgGroup.Controls.Add(this.nudCost);
            this.tbpgGroup.Controls.Add(this.lblCost);
            this.tbpgGroup.Controls.Add(this.cbTheme);
            this.tbpgGroup.Controls.Add(this.lblTheme);
            this.tbpgGroup.Controls.Add(this.cbWorkPlace);
            this.tbpgGroup.Controls.Add(this.lblWorkplace);
            this.tbpgGroup.Location = new System.Drawing.Point(4, 30);
            this.tbpgGroup.Margin = new System.Windows.Forms.Padding(5);
            this.tbpgGroup.Name = "tbpgGroup";
            this.tbpgGroup.Padding = new System.Windows.Forms.Padding(5);
            this.tbpgGroup.Size = new System.Drawing.Size(619, 384);
            this.tbpgGroup.TabIndex = 0;
            this.tbpgGroup.Text = "Группы";
            this.tbpgGroup.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDelete.Location = new System.Drawing.Point(5, 243);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(609, 44);
            this.btDelete.TabIndex = 8;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.BtDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btUpdate.Location = new System.Drawing.Point(5, 199);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(609, 44);
            this.btUpdate.TabIndex = 7;
            this.btUpdate.Text = "Изменить";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.BtUpdate_Click);
            // 
            // btInsert
            // 
            this.btInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btInsert.Location = new System.Drawing.Point(5, 155);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(609, 44);
            this.btInsert.TabIndex = 6;
            this.btInsert.Text = "Добавить";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.BtInsert_Click);
            // 
            // nudCost
            // 
            this.nudCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudCost.Location = new System.Drawing.Point(5, 126);
            this.nudCost.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.nudCost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCost.Name = "nudCost";
            this.nudCost.Size = new System.Drawing.Size(609, 29);
            this.nudCost.TabIndex = 5;
            this.nudCost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCost.Location = new System.Drawing.Point(5, 105);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(99, 21);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "Стоимость";
            // 
            // cbTheme
            // 
            this.cbTheme.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTheme.FormattingEnabled = true;
            this.cbTheme.Location = new System.Drawing.Point(5, 76);
            this.cbTheme.Name = "cbTheme";
            this.cbTheme.Size = new System.Drawing.Size(609, 29);
            this.cbTheme.TabIndex = 3;
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTheme.Location = new System.Drawing.Point(5, 55);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(84, 21);
            this.lblTheme.TabIndex = 2;
            this.lblTheme.Text = "Тематика";
            // 
            // cbWorkPlace
            // 
            this.cbWorkPlace.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbWorkPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorkPlace.FormattingEnabled = true;
            this.cbWorkPlace.Location = new System.Drawing.Point(5, 26);
            this.cbWorkPlace.Name = "cbWorkPlace";
            this.cbWorkPlace.Size = new System.Drawing.Size(609, 29);
            this.cbWorkPlace.TabIndex = 1;
            // 
            // lblWorkplace
            // 
            this.lblWorkplace.AutoSize = true;
            this.lblWorkplace.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWorkplace.Location = new System.Drawing.Point(5, 5);
            this.lblWorkplace.Name = "lblWorkplace";
            this.lblWorkplace.Size = new System.Drawing.Size(160, 21);
            this.lblWorkplace.TabIndex = 0;
            this.lblWorkplace.Text = "Место проведения";
            // 
            // tbpgWork
            // 
            this.tbpgWork.Controls.Add(this.btWorkInsert);
            this.tbpgWork.Controls.Add(this.btWorkDelete);
            this.tbpgWork.Controls.Add(this.btCheck);
            this.tbpgWork.Controls.Add(this.gbWorkLength);
            this.tbpgWork.Controls.Add(this.gbWorkTime);
            this.tbpgWork.Controls.Add(this.cbWorkDay);
            this.tbpgWork.Controls.Add(this.lblWorkDay);
            this.tbpgWork.Controls.Add(this.dgWork);
            this.tbpgWork.Location = new System.Drawing.Point(4, 30);
            this.tbpgWork.Margin = new System.Windows.Forms.Padding(5);
            this.tbpgWork.Name = "tbpgWork";
            this.tbpgWork.Padding = new System.Windows.Forms.Padding(5);
            this.tbpgWork.Size = new System.Drawing.Size(619, 384);
            this.tbpgWork.TabIndex = 1;
            this.tbpgWork.Text = "Тренировки";
            this.tbpgWork.UseVisualStyleBackColor = true;
            // 
            // btWorkInsert
            // 
            this.btWorkInsert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btWorkInsert.Enabled = false;
            this.btWorkInsert.Location = new System.Drawing.Point(208, 327);
            this.btWorkInsert.Name = "btWorkInsert";
            this.btWorkInsert.Size = new System.Drawing.Size(203, 52);
            this.btWorkInsert.TabIndex = 13;
            this.btWorkInsert.Text = "Добавить";
            this.btWorkInsert.UseVisualStyleBackColor = true;
            this.btWorkInsert.Click += new System.EventHandler(this.BtWorkInsert_Click);
            // 
            // btWorkDelete
            // 
            this.btWorkDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btWorkDelete.Location = new System.Drawing.Point(411, 327);
            this.btWorkDelete.Name = "btWorkDelete";
            this.btWorkDelete.Size = new System.Drawing.Size(203, 52);
            this.btWorkDelete.TabIndex = 12;
            this.btWorkDelete.Text = "Удалить";
            this.btWorkDelete.UseVisualStyleBackColor = true;
            this.btWorkDelete.Click += new System.EventHandler(this.BtWorkDelete_Click);
            // 
            // btCheck
            // 
            this.btCheck.Dock = System.Windows.Forms.DockStyle.Left;
            this.btCheck.Location = new System.Drawing.Point(5, 327);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(203, 52);
            this.btCheck.TabIndex = 11;
            this.btCheck.Text = "Проверить";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.BtCheck_Click);
            // 
            // gbWorkLength
            // 
            this.gbWorkLength.Controls.Add(this.nudEndMinute);
            this.gbWorkLength.Controls.Add(this.lblEndMinute);
            this.gbWorkLength.Controls.Add(this.nudEndHour);
            this.gbWorkLength.Controls.Add(this.lblEndHour);
            this.gbWorkLength.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbWorkLength.Location = new System.Drawing.Point(5, 266);
            this.gbWorkLength.Name = "gbWorkLength";
            this.gbWorkLength.Size = new System.Drawing.Size(609, 61);
            this.gbWorkLength.TabIndex = 10;
            this.gbWorkLength.TabStop = false;
            this.gbWorkLength.Text = "Время окончания";
            // 
            // nudEndMinute
            // 
            this.nudEndMinute.Dock = System.Windows.Forms.DockStyle.Left;
            this.nudEndMinute.Location = new System.Drawing.Point(253, 25);
            this.nudEndMinute.Name = "nudEndMinute";
            this.nudEndMinute.ReadOnly = true;
            this.nudEndMinute.Size = new System.Drawing.Size(120, 29);
            this.nudEndMinute.TabIndex = 7;
            this.nudEndMinute.ValueChanged += new System.EventHandler(this.NudEndMinute_ValueChanged);
            // 
            // lblEndMinute
            // 
            this.lblEndMinute.AutoSize = true;
            this.lblEndMinute.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEndMinute.Location = new System.Drawing.Point(173, 25);
            this.lblEndMinute.Name = "lblEndMinute";
            this.lblEndMinute.Size = new System.Drawing.Size(80, 21);
            this.lblEndMinute.TabIndex = 6;
            this.lblEndMinute.Text = "Минуты:";
            // 
            // nudEndHour
            // 
            this.nudEndHour.Dock = System.Windows.Forms.DockStyle.Left;
            this.nudEndHour.Location = new System.Drawing.Point(59, 25);
            this.nudEndHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudEndHour.Name = "nudEndHour";
            this.nudEndHour.ReadOnly = true;
            this.nudEndHour.Size = new System.Drawing.Size(114, 29);
            this.nudEndHour.TabIndex = 5;
            this.nudEndHour.ValueChanged += new System.EventHandler(this.NudEndHour_ValueChanged);
            // 
            // lblEndHour
            // 
            this.lblEndHour.AutoSize = true;
            this.lblEndHour.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEndHour.Location = new System.Drawing.Point(3, 25);
            this.lblEndHour.Name = "lblEndHour";
            this.lblEndHour.Size = new System.Drawing.Size(56, 21);
            this.lblEndHour.TabIndex = 4;
            this.lblEndHour.Text = "Часы:";
            // 
            // gbWorkTime
            // 
            this.gbWorkTime.Controls.Add(this.nudStartMinute);
            this.gbWorkTime.Controls.Add(this.lblStartMinute);
            this.gbWorkTime.Controls.Add(this.nudStartHour);
            this.gbWorkTime.Controls.Add(this.lblStartHour);
            this.gbWorkTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbWorkTime.Location = new System.Drawing.Point(5, 205);
            this.gbWorkTime.Name = "gbWorkTime";
            this.gbWorkTime.Size = new System.Drawing.Size(609, 61);
            this.gbWorkTime.TabIndex = 9;
            this.gbWorkTime.TabStop = false;
            this.gbWorkTime.Text = "Время начала";
            // 
            // nudStartMinute
            // 
            this.nudStartMinute.Dock = System.Windows.Forms.DockStyle.Left;
            this.nudStartMinute.Location = new System.Drawing.Point(253, 25);
            this.nudStartMinute.Name = "nudStartMinute";
            this.nudStartMinute.ReadOnly = true;
            this.nudStartMinute.Size = new System.Drawing.Size(120, 29);
            this.nudStartMinute.TabIndex = 3;
            this.nudStartMinute.ValueChanged += new System.EventHandler(this.NudStartMinute_ValueChanged);
            // 
            // lblStartMinute
            // 
            this.lblStartMinute.AutoSize = true;
            this.lblStartMinute.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStartMinute.Location = new System.Drawing.Point(173, 25);
            this.lblStartMinute.Name = "lblStartMinute";
            this.lblStartMinute.Size = new System.Drawing.Size(80, 21);
            this.lblStartMinute.TabIndex = 2;
            this.lblStartMinute.Text = "Минуты:";
            // 
            // nudStartHour
            // 
            this.nudStartHour.Dock = System.Windows.Forms.DockStyle.Left;
            this.nudStartHour.Location = new System.Drawing.Point(59, 25);
            this.nudStartHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudStartHour.Name = "nudStartHour";
            this.nudStartHour.ReadOnly = true;
            this.nudStartHour.Size = new System.Drawing.Size(114, 29);
            this.nudStartHour.TabIndex = 1;
            this.nudStartHour.ValueChanged += new System.EventHandler(this.NudStartHour_ValueChanged);
            // 
            // lblStartHour
            // 
            this.lblStartHour.AutoSize = true;
            this.lblStartHour.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStartHour.Location = new System.Drawing.Point(3, 25);
            this.lblStartHour.Name = "lblStartHour";
            this.lblStartHour.Size = new System.Drawing.Size(56, 21);
            this.lblStartHour.TabIndex = 0;
            this.lblStartHour.Text = "Часы:";
            // 
            // cbWorkDay
            // 
            this.cbWorkDay.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbWorkDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorkDay.FormattingEnabled = true;
            this.cbWorkDay.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота",
            "Воскресенье"});
            this.cbWorkDay.Location = new System.Drawing.Point(5, 176);
            this.cbWorkDay.Name = "cbWorkDay";
            this.cbWorkDay.Size = new System.Drawing.Size(609, 29);
            this.cbWorkDay.TabIndex = 8;
            this.cbWorkDay.SelectedIndexChanged += new System.EventHandler(this.CbWorkDay_SelectedIndexChanged);
            // 
            // lblWorkDay
            // 
            this.lblWorkDay.AutoSize = true;
            this.lblWorkDay.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWorkDay.Location = new System.Drawing.Point(5, 155);
            this.lblWorkDay.Name = "lblWorkDay";
            this.lblWorkDay.Size = new System.Drawing.Size(110, 21);
            this.lblWorkDay.TabIndex = 7;
            this.lblWorkDay.Text = "День недели";
            // 
            // dgWork
            // 
            this.dgWork.AllowUserToAddRows = false;
            this.dgWork.AllowUserToDeleteRows = false;
            this.dgWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWork.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgWork.Location = new System.Drawing.Point(5, 5);
            this.dgWork.Name = "dgWork";
            this.dgWork.ReadOnly = true;
            this.dgWork.Size = new System.Drawing.Size(609, 150);
            this.dgWork.TabIndex = 0;
            this.dgWork.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgWork_CellClick);
            this.dgWork.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgWork_CellClick);
            // 
            // tbpgTheme
            // 
            this.tbpgTheme.Controls.Add(this.btTmUpdate);
            this.tbpgTheme.Controls.Add(this.btTmDelete);
            this.tbpgTheme.Controls.Add(this.btTmInsert);
            this.tbpgTheme.Controls.Add(this.gbThemeSearch);
            this.tbpgTheme.Controls.Add(this.dgTheme);
            this.tbpgTheme.Location = new System.Drawing.Point(4, 30);
            this.tbpgTheme.Name = "tbpgTheme";
            this.tbpgTheme.Size = new System.Drawing.Size(619, 384);
            this.tbpgTheme.TabIndex = 2;
            this.tbpgTheme.Text = "Тематики";
            this.tbpgTheme.UseVisualStyleBackColor = true;
            // 
            // btTmUpdate
            // 
            this.btTmUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btTmUpdate.Location = new System.Drawing.Point(206, 273);
            this.btTmUpdate.Name = "btTmUpdate";
            this.btTmUpdate.Size = new System.Drawing.Size(207, 111);
            this.btTmUpdate.TabIndex = 8;
            this.btTmUpdate.Text = "Изменить";
            this.btTmUpdate.UseVisualStyleBackColor = true;
            this.btTmUpdate.Click += new System.EventHandler(this.BtTmUpdate_Click);
            // 
            // btTmDelete
            // 
            this.btTmDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btTmDelete.Location = new System.Drawing.Point(413, 273);
            this.btTmDelete.Name = "btTmDelete";
            this.btTmDelete.Size = new System.Drawing.Size(206, 111);
            this.btTmDelete.TabIndex = 7;
            this.btTmDelete.Text = "Удалить";
            this.btTmDelete.UseVisualStyleBackColor = true;
            this.btTmDelete.Click += new System.EventHandler(this.BtTmDelete_Click);
            // 
            // btTmInsert
            // 
            this.btTmInsert.Dock = System.Windows.Forms.DockStyle.Left;
            this.btTmInsert.Location = new System.Drawing.Point(0, 273);
            this.btTmInsert.Name = "btTmInsert";
            this.btTmInsert.Size = new System.Drawing.Size(206, 111);
            this.btTmInsert.TabIndex = 6;
            this.btTmInsert.Text = "Добавить";
            this.btTmInsert.UseVisualStyleBackColor = true;
            this.btTmInsert.Click += new System.EventHandler(this.BtTmInsert_Click);
            // 
            // gbThemeSearch
            // 
            this.gbThemeSearch.Controls.Add(this.tbThemeSearch);
            this.gbThemeSearch.Controls.Add(this.btThemeSearch);
            this.gbThemeSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbThemeSearch.Location = new System.Drawing.Point(0, 213);
            this.gbThemeSearch.Margin = new System.Windows.Forms.Padding(5);
            this.gbThemeSearch.Name = "gbThemeSearch";
            this.gbThemeSearch.Padding = new System.Windows.Forms.Padding(5);
            this.gbThemeSearch.Size = new System.Drawing.Size(619, 60);
            this.gbThemeSearch.TabIndex = 5;
            this.gbThemeSearch.TabStop = false;
            this.gbThemeSearch.Text = "Поиск";
            // 
            // tbThemeSearch
            // 
            this.tbThemeSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbThemeSearch.Location = new System.Drawing.Point(5, 27);
            this.tbThemeSearch.Name = "tbThemeSearch";
            this.tbThemeSearch.Size = new System.Drawing.Size(514, 29);
            this.tbThemeSearch.TabIndex = 2;
            // 
            // btThemeSearch
            // 
            this.btThemeSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btThemeSearch.Location = new System.Drawing.Point(519, 27);
            this.btThemeSearch.Name = "btThemeSearch";
            this.btThemeSearch.Size = new System.Drawing.Size(95, 28);
            this.btThemeSearch.TabIndex = 1;
            this.btThemeSearch.Text = "Искать";
            this.btThemeSearch.UseVisualStyleBackColor = true;
            this.btThemeSearch.Click += new System.EventHandler(this.BtThemeSearch_Click);
            // 
            // dgTheme
            // 
            this.dgTheme.AllowUserToAddRows = false;
            this.dgTheme.AllowUserToDeleteRows = false;
            this.dgTheme.AllowUserToOrderColumns = true;
            this.dgTheme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTheme.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgTheme.Location = new System.Drawing.Point(0, 0);
            this.dgTheme.Name = "dgTheme";
            this.dgTheme.ReadOnly = true;
            this.dgTheme.Size = new System.Drawing.Size(619, 213);
            this.dgTheme.TabIndex = 0;
            this.dgTheme.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgTheme_CellClick);
            // 
            // tbpgTimetable
            // 
            this.tbpgTimetable.Controls.Add(this.btTimetable);
            this.tbpgTimetable.Controls.Add(this.dgTimetable);
            this.tbpgTimetable.Location = new System.Drawing.Point(4, 30);
            this.tbpgTimetable.Name = "tbpgTimetable";
            this.tbpgTimetable.Size = new System.Drawing.Size(619, 384);
            this.tbpgTimetable.TabIndex = 4;
            this.tbpgTimetable.Text = "Расписание";
            this.tbpgTimetable.UseVisualStyleBackColor = true;
            // 
            // btTimetable
            // 
            this.btTimetable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btTimetable.Location = new System.Drawing.Point(0, 322);
            this.btTimetable.Name = "btTimetable";
            this.btTimetable.Size = new System.Drawing.Size(619, 62);
            this.btTimetable.TabIndex = 1;
            this.btTimetable.Text = "Вывести расписание";
            this.btTimetable.UseVisualStyleBackColor = true;
            // 
            // dgTimetable
            // 
            this.dgTimetable.AllowUserToAddRows = false;
            this.dgTimetable.AllowUserToDeleteRows = false;
            this.dgTimetable.AllowUserToOrderColumns = true;
            this.dgTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTimetable.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgTimetable.Location = new System.Drawing.Point(0, 0);
            this.dgTimetable.Name = "dgTimetable";
            this.dgTimetable.ReadOnly = true;
            this.dgTimetable.Size = new System.Drawing.Size(619, 322);
            this.dgTimetable.TabIndex = 0;
            // 
            // tbpgPersonal
            // 
            this.tbpgPersonal.Controls.Add(this.btRevoke);
            this.tbpgPersonal.Controls.Add(this.btTrainerDarwback);
            this.tbpgPersonal.Controls.Add(this.btTrainerConfirm);
            this.tbpgPersonal.Controls.Add(this.tbTrainerConfirm);
            this.tbpgPersonal.Controls.Add(this.lblTrainerConfirm);
            this.tbpgPersonal.Controls.Add(this.tbTrainerPassword);
            this.tbpgPersonal.Controls.Add(this.lblTrainerPassword);
            this.tbpgPersonal.Controls.Add(this.tbTrainerLogin);
            this.tbpgPersonal.Controls.Add(this.lblTrainerLogin);
            this.tbpgPersonal.Controls.Add(this.tbCat);
            this.tbpgPersonal.Controls.Add(this.lblCategory);
            this.tbpgPersonal.Controls.Add(this.tbTrainerPatronymic);
            this.tbpgPersonal.Controls.Add(this.lblTrainerPatronymic);
            this.tbpgPersonal.Controls.Add(this.tbTrainerName);
            this.tbpgPersonal.Controls.Add(this.lblTrainerName);
            this.tbpgPersonal.Controls.Add(this.tbTrainerFirstname);
            this.tbpgPersonal.Controls.Add(this.lblTrainerFirstname);
            this.tbpgPersonal.Location = new System.Drawing.Point(4, 30);
            this.tbpgPersonal.Name = "tbpgPersonal";
            this.tbpgPersonal.Size = new System.Drawing.Size(619, 384);
            this.tbpgPersonal.TabIndex = 3;
            this.tbpgPersonal.Text = "Личные данные";
            this.tbpgPersonal.UseVisualStyleBackColor = true;
            // 
            // btRevoke
            // 
            this.btRevoke.Dock = System.Windows.Forms.DockStyle.Top;
            this.btRevoke.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btRevoke.Location = new System.Drawing.Point(0, 359);
            this.btRevoke.Name = "btRevoke";
            this.btRevoke.Size = new System.Drawing.Size(619, 25);
            this.btRevoke.TabIndex = 36;
            this.btRevoke.Text = "Восстановить";
            this.btRevoke.UseVisualStyleBackColor = true;
            this.btRevoke.Click += new System.EventHandler(this.BtRevoke_Click);
            // 
            // btTrainerDarwback
            // 
            this.btTrainerDarwback.Dock = System.Windows.Forms.DockStyle.Top;
            this.btTrainerDarwback.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btTrainerDarwback.Location = new System.Drawing.Point(0, 334);
            this.btTrainerDarwback.Name = "btTrainerDarwback";
            this.btTrainerDarwback.Size = new System.Drawing.Size(619, 25);
            this.btTrainerDarwback.TabIndex = 35;
            this.btTrainerDarwback.Text = "Вернуть к сохранённым";
            this.btTrainerDarwback.UseVisualStyleBackColor = true;
            this.btTrainerDarwback.Click += new System.EventHandler(this.BtTrainerDarwback_Click);
            // 
            // btTrainerConfirm
            // 
            this.btTrainerConfirm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btTrainerConfirm.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btTrainerConfirm.Location = new System.Drawing.Point(0, 308);
            this.btTrainerConfirm.Name = "btTrainerConfirm";
            this.btTrainerConfirm.Size = new System.Drawing.Size(619, 26);
            this.btTrainerConfirm.TabIndex = 34;
            this.btTrainerConfirm.Text = "Подтвердить";
            this.btTrainerConfirm.UseVisualStyleBackColor = true;
            this.btTrainerConfirm.Click += new System.EventHandler(this.BtTrainerConfirm_Click);
            // 
            // tbTrainerConfirm
            // 
            this.tbTrainerConfirm.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTrainerConfirm.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.tbTrainerConfirm.Location = new System.Drawing.Point(0, 284);
            this.tbTrainerConfirm.Name = "tbTrainerConfirm";
            this.tbTrainerConfirm.Size = new System.Drawing.Size(619, 24);
            this.tbTrainerConfirm.TabIndex = 33;
            // 
            // lblTrainerConfirm
            // 
            this.lblTrainerConfirm.AutoSize = true;
            this.lblTrainerConfirm.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTrainerConfirm.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lblTrainerConfirm.Location = new System.Drawing.Point(0, 264);
            this.lblTrainerConfirm.Name = "lblTrainerConfirm";
            this.lblTrainerConfirm.Size = new System.Drawing.Size(166, 20);
            this.lblTrainerConfirm.TabIndex = 32;
            this.lblTrainerConfirm.Text = "Подтвердить пароль";
            // 
            // tbTrainerPassword
            // 
            this.tbTrainerPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTrainerPassword.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.tbTrainerPassword.Location = new System.Drawing.Point(0, 240);
            this.tbTrainerPassword.Name = "tbTrainerPassword";
            this.tbTrainerPassword.Size = new System.Drawing.Size(619, 24);
            this.tbTrainerPassword.TabIndex = 31;
            // 
            // lblTrainerPassword
            // 
            this.lblTrainerPassword.AutoSize = true;
            this.lblTrainerPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTrainerPassword.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lblTrainerPassword.Location = new System.Drawing.Point(0, 220);
            this.lblTrainerPassword.Name = "lblTrainerPassword";
            this.lblTrainerPassword.Size = new System.Drawing.Size(65, 20);
            this.lblTrainerPassword.TabIndex = 30;
            this.lblTrainerPassword.Text = "Пароль";
            // 
            // tbTrainerLogin
            // 
            this.tbTrainerLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTrainerLogin.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.tbTrainerLogin.Location = new System.Drawing.Point(0, 196);
            this.tbTrainerLogin.Name = "tbTrainerLogin";
            this.tbTrainerLogin.Size = new System.Drawing.Size(619, 24);
            this.tbTrainerLogin.TabIndex = 29;
            // 
            // lblTrainerLogin
            // 
            this.lblTrainerLogin.AutoSize = true;
            this.lblTrainerLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTrainerLogin.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lblTrainerLogin.Location = new System.Drawing.Point(0, 176);
            this.lblTrainerLogin.Name = "lblTrainerLogin";
            this.lblTrainerLogin.Size = new System.Drawing.Size(57, 20);
            this.lblTrainerLogin.TabIndex = 28;
            this.lblTrainerLogin.Text = "Логин";
            // 
            // tbCat
            // 
            this.tbCat.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbCat.Enabled = false;
            this.tbCat.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.tbCat.Location = new System.Drawing.Point(0, 152);
            this.tbCat.Name = "tbCat";
            this.tbCat.ReadOnly = true;
            this.tbCat.Size = new System.Drawing.Size(619, 24);
            this.tbCat.TabIndex = 21;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCategory.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lblCategory.Location = new System.Drawing.Point(0, 132);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(93, 20);
            this.lblCategory.TabIndex = 20;
            this.lblCategory.Text = "Категория.";
            // 
            // tbTrainerPatronymic
            // 
            this.tbTrainerPatronymic.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTrainerPatronymic.Enabled = false;
            this.tbTrainerPatronymic.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.tbTrainerPatronymic.Location = new System.Drawing.Point(0, 108);
            this.tbTrainerPatronymic.Name = "tbTrainerPatronymic";
            this.tbTrainerPatronymic.ReadOnly = true;
            this.tbTrainerPatronymic.Size = new System.Drawing.Size(619, 24);
            this.tbTrainerPatronymic.TabIndex = 19;
            // 
            // lblTrainerPatronymic
            // 
            this.lblTrainerPatronymic.AutoSize = true;
            this.lblTrainerPatronymic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTrainerPatronymic.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lblTrainerPatronymic.Location = new System.Drawing.Point(0, 88);
            this.lblTrainerPatronymic.Name = "lblTrainerPatronymic";
            this.lblTrainerPatronymic.Size = new System.Drawing.Size(81, 20);
            this.lblTrainerPatronymic.TabIndex = 18;
            this.lblTrainerPatronymic.Text = "Отчество";
            // 
            // tbTrainerName
            // 
            this.tbTrainerName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTrainerName.Enabled = false;
            this.tbTrainerName.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.tbTrainerName.Location = new System.Drawing.Point(0, 64);
            this.tbTrainerName.Name = "tbTrainerName";
            this.tbTrainerName.ReadOnly = true;
            this.tbTrainerName.Size = new System.Drawing.Size(619, 24);
            this.tbTrainerName.TabIndex = 17;
            // 
            // lblTrainerName
            // 
            this.lblTrainerName.AutoSize = true;
            this.lblTrainerName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTrainerName.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lblTrainerName.Location = new System.Drawing.Point(0, 44);
            this.lblTrainerName.Name = "lblTrainerName";
            this.lblTrainerName.Size = new System.Drawing.Size(41, 20);
            this.lblTrainerName.TabIndex = 16;
            this.lblTrainerName.Text = "Имя";
            // 
            // tbTrainerFirstname
            // 
            this.tbTrainerFirstname.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTrainerFirstname.Enabled = false;
            this.tbTrainerFirstname.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.tbTrainerFirstname.Location = new System.Drawing.Point(0, 20);
            this.tbTrainerFirstname.Name = "tbTrainerFirstname";
            this.tbTrainerFirstname.ReadOnly = true;
            this.tbTrainerFirstname.Size = new System.Drawing.Size(619, 24);
            this.tbTrainerFirstname.TabIndex = 15;
            // 
            // lblTrainerFirstname
            // 
            this.lblTrainerFirstname.AutoSize = true;
            this.lblTrainerFirstname.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTrainerFirstname.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lblTrainerFirstname.Location = new System.Drawing.Point(0, 0);
            this.lblTrainerFirstname.Name = "lblTrainerFirstname";
            this.lblTrainerFirstname.Size = new System.Drawing.Size(79, 20);
            this.lblTrainerFirstname.TabIndex = 14;
            this.lblTrainerFirstname.Text = "Фамилия";
            // 
            // TrainerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 664);
            this.Controls.Add(this.tgctrlTrainer);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.dgGroup);
            this.Controls.Add(this.lblGroup);
            this.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TrainerInterface";
            this.Text = "TrainerInterface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrainerInterface_FormClosing);
            this.Load += new System.EventHandler(this.TrainerInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgGroup)).EndInit();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.tgctrlTrainer.ResumeLayout(false);
            this.tbpgGroup.ResumeLayout(false);
            this.tbpgGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).EndInit();
            this.tbpgWork.ResumeLayout(false);
            this.tbpgWork.PerformLayout();
            this.gbWorkLength.ResumeLayout(false);
            this.gbWorkLength.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndHour)).EndInit();
            this.gbWorkTime.ResumeLayout(false);
            this.gbWorkTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgWork)).EndInit();
            this.tbpgTheme.ResumeLayout(false);
            this.gbThemeSearch.ResumeLayout(false);
            this.gbThemeSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTheme)).EndInit();
            this.tbpgTimetable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTimetable)).EndInit();
            this.tbpgPersonal.ResumeLayout(false);
            this.tbpgPersonal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.DataGridView dgGroup;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.TabControl tgctrlTrainer;
        private System.Windows.Forms.TabPage tbpgGroup;
        private System.Windows.Forms.TabPage tbpgWork;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TabPage tbpgTheme;
        private System.Windows.Forms.TabPage tbpgPersonal;
        private System.Windows.Forms.NumericUpDown nudCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.ComboBox cbTheme;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.ComboBox cbWorkPlace;
        private System.Windows.Forms.Label lblWorkplace;
        private System.Windows.Forms.TabPage tbpgTimetable;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.DataGridView dgTheme;
        private System.Windows.Forms.Button btTimetable;
        private System.Windows.Forms.DataGridView dgTimetable;
        private System.Windows.Forms.TextBox tbTrainerPatronymic;
        private System.Windows.Forms.Label lblTrainerPatronymic;
        private System.Windows.Forms.TextBox tbTrainerName;
        private System.Windows.Forms.Label lblTrainerName;
        private System.Windows.Forms.TextBox tbTrainerFirstname;
        private System.Windows.Forms.Label lblTrainerFirstname;
        private System.Windows.Forms.Button btTrainerDarwback;
        private System.Windows.Forms.Button btTrainerConfirm;
        private System.Windows.Forms.TextBox tbTrainerConfirm;
        private System.Windows.Forms.Label lblTrainerConfirm;
        private System.Windows.Forms.TextBox tbTrainerPassword;
        private System.Windows.Forms.Label lblTrainerPassword;
        private System.Windows.Forms.TextBox tbTrainerLogin;
        private System.Windows.Forms.Label lblTrainerLogin;
        private System.Windows.Forms.TextBox tbCat;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btWorkInsert;
        private System.Windows.Forms.Button btWorkDelete;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.GroupBox gbWorkLength;
        private System.Windows.Forms.NumericUpDown nudEndMinute;
        private System.Windows.Forms.Label lblEndMinute;
        private System.Windows.Forms.NumericUpDown nudEndHour;
        private System.Windows.Forms.Label lblEndHour;
        private System.Windows.Forms.GroupBox gbWorkTime;
        private System.Windows.Forms.NumericUpDown nudStartMinute;
        private System.Windows.Forms.Label lblStartMinute;
        private System.Windows.Forms.NumericUpDown nudStartHour;
        private System.Windows.Forms.Label lblStartHour;
        private System.Windows.Forms.ComboBox cbWorkDay;
        private System.Windows.Forms.Label lblWorkDay;
        private System.Windows.Forms.DataGridView dgWork;
        private System.Windows.Forms.Button btTmUpdate;
        private System.Windows.Forms.Button btTmDelete;
        private System.Windows.Forms.Button btTmInsert;
        private System.Windows.Forms.GroupBox gbThemeSearch;
        private System.Windows.Forms.TextBox tbThemeSearch;
        private System.Windows.Forms.Button btThemeSearch;
        private System.Windows.Forms.Button btRevoke;
    }
}