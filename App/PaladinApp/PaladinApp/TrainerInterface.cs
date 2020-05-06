using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections;

namespace PaladinApp
{
    public partial class TrainerInterface : Form
    {
        public TrainerInterface()
        {
            InitializeComponent();
        }

        private void TrainerInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (MessageBox.Show("Вы действительно хотите закрыть приложение?", "PaladinApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case (DialogResult.Yes):
                    Application.ExitThread();
                    break;
            }
        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Вы действительно хотите выйти на страницу авторизации?", "PaladinApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case (DialogResult.Yes):
                    this.Hide();
                    this.Owner.Show();
                    break;
            }
        }

        string GroupQuerry = "SELECT dbo.[Group].ID_Group as \'Кодовый номер\', dbo.Themes.ThemeName as \'Тематика\', dbo.Filials.FilialName as \'Филиал\', dbo.WorkPlaces.WorkPlaceLocation as \'Зал\', dbo.[Group].Abon_Cost as \'Стоимость занятия\' FROM dbo.[Group] INNER JOIN dbo.Themes ON dbo.[Group].Theme_ID = dbo.Themes.ID_Theme INNER JOIN dbo.WorkPlaces ON dbo.[Group].WorkPlace_ID = dbo.WorkPlaces.ID_WorkPlace INNER JOIN dbo.Filials ON dbo.WorkPlaces.ID_Filial = dbo.Filials.ID_Filial WHERE [ID_Group]>0 and dbo.[Group].[LogicDelete] = 0";
        string CurGroupQuerry = "";
        string ThemeQuerry = "SELECT [ID_Theme] as \'Код\',[ThemeName] as \'Название\',[ThemeAbout] as \'Описание\' FROM [dbo].[Themes] WHERE [LogicDelete] = 0 and [ID_Theme]>0";
        string CurThemeQuerry = "";

        private void TrainerInterface_Load(object sender, EventArgs e)
        {
            CurGroupQuerry = GroupQuerry;
            CurThemeQuerry = ThemeQuerry;
            Thread groupFill = new Thread(GroupFill);
            groupFill.Start();
            TrainerFill();
            GroupPagesFill();
            try
            {
                cbWorkPlace.SelectedIndex = 0;
            }
            catch
            {

            }
            try
            {
                cbTheme.SelectedIndex = 0;
            }
            catch
            {

            }
            cbWorkDay.SelectedIndex = 0;
        }

        private void GroupFill()
        {
            Action action = () =>
            {
                Table_Class tableGroup = new Table_Class(CurGroupQuerry + String.Format("and dbo.[Group].Trainer_ID = {0}", Program.intID));
                tableGroup.Dependency.OnChange += GroupDependency_OnChange;
                dgGroup.DataSource = tableGroup.table;
            };
            Invoke(action);
        }

        string GroupID = "";
               
        private void GroupPagesFill()
        {
            Action action = () =>
            {
                string CurWP = "";
                string CurTM = "";
                string CurAC = "";
                Table_Class groupPageWP = new Table_Class("SELECT dbo.WorkPlaces.ID_WorkPlace, dbo.Filials.FilialName + ' ' +dbo.WorkPlaces.WorkPlaceLocation as \'Descriptor\' FROM dbo.Filials INNER JOIN dbo.WorkPlaces ON dbo.Filials.ID_Filial = dbo.WorkPlaces.ID_Filial WHERE dbo.WorkPlaces.[ID_WorkPlace]>0 and dbo.WorkPlaces.[LogicDelete] = 0");
                groupPageWP.Dependency.OnChange += GroupPageDependency_OnChange;
                cbWorkPlace.DataSource = groupPageWP.table;
                cbWorkPlace.DisplayMember = "Descriptor";
                cbWorkPlace.ValueMember = "ID_WorkPlace";
                Table_Class groupPageTM = new Table_Class("SELECT [ID_Theme],[ThemeName] FROM [dbo].[Themes] WHERE [LogicDelete] = 0 and [ID_Theme]>0");
                groupPageTM.Dependency.OnChange += GroupPageDependency_OnChange;
                cbTheme.DataSource = groupPageTM.table;
                cbTheme.DisplayMember = "ThemeName";
                cbTheme.ValueMember = "ID_Theme";
                if (GroupID != "")
                {
                    Table_Class groupPages = new Table_Class(String.Format("SELECT [WorkPlace_ID],[Theme_ID],[Abon_Cost] FROM [dbo].[Group] WHERE [ID_Group] = {0}", GroupID));
                    CurWP = groupPages.table.Rows[0][0].ToString();
                    CurTM = groupPages.table.Rows[0][1].ToString();
                    CurAC = groupPages.table.Rows[0][2].ToString();
                }
                try
                {
                    cbWorkPlace.SelectedValue = CurWP;
                }
                catch
                {
                    cbWorkPlace.SelectedIndex = 0;
                }
                try
                {
                    cbTheme.SelectedValue = CurTM;
                }
                catch
                {
                    cbTheme.SelectedIndex = 0;
                }
                try
                {
                    nudCost.Value = Convert.ToInt32(CurAC);
                }
                catch
                {
                    nudCost.Value = 1;
                }
            };
            Invoke(action);
        }

        private void WorkFill()
        {
            Action action = () =>
            {
                if (GroupID != "")
                {
                    Table_Class tableWork = new Table_Class(String.Format("SELECT [ID_Work] as \'Код\',[WorkDay] as \'День недели\',[Work_Time] as \'Начало\',[Work_Length] as \'Окончание\' FROM [dbo].[Work] WHERE [LogicDelete] = 0 and [ID_Work]>0 and [ID_Group] = {0}", GroupID));
                    tableWork.Dependency.OnChange += WorkDependency_OnChange;
                    dgWork.DataSource = tableWork.table;
                }
            };
            Invoke(action);
        }

        private void ThemeFill()
        {
            Action action = () =>
            {
                Table_Class themeTable = new Table_Class(CurThemeQuerry);
                themeTable.Dependency.OnChange += ThemeDependency_OnChange;
                dgTheme.DataSource = themeTable.table;
            };
            Invoke(action);
        }

        public void ThemeUpdate()
        {
            ThemeFill();
        }

        private void TimetableFill()
        {
            Action action = () =>
            {
                Table_Class table_TT = new Table_Class("SELECT [ID_Work] as \'Номер тренировки\',[WorkDay] as \'День недели\',[Work_Time] as \'Начало\',[Work_Length] as \'Окончание\',[ThemeName] as \'Темактика\',([TrainerFirstName] + ' ' + SUBSTRING([TrainerSecondName],1,1) + '. ' + SUBSTRING([TrainerLastName],1,1) +'.') as \'Тренер\',[FilialName] as \'Филиал\',[WorkPlaceLocation] as \'Зал\' FROM [dbo].[Timetable] where [LogicDelete] = 0 and [ID_Work] > 0");
                table_TT.Dependency.OnChange += TTDependency_OnChange;
                dgTimetable.DataSource = table_TT.table;
            };
            Invoke(action);
        }

        string Password = "";

        private void TrainerFill()
        {
            Action action = () =>
            {
                Table_Class tableTrainer = new Table_Class(String.Format("SELECT [TrainerFirstName],[TrainerSecondName],[TrainerLastName],[TrainerCategory],[TrainerLogin],[TrainerPassword] FROM [dbo].[Trainers] WHERE [ID_Trainer] = {0}", Program.intID));
                tbTrainerFirstname.Text = tableTrainer.table.Rows[0][0].ToString();
                tbTrainerName.Text = tableTrainer.table.Rows[0][1].ToString();
                tbTrainerPatronymic.Text = tableTrainer.table.Rows[0][2].ToString();
                tbCat.Text = tableTrainer.table.Rows[0][3].ToString();
                tbTrainerLogin.Text = tableTrainer.table.Rows[0][4].ToString();
                this.Text = "Интерфейс тренера: " + tableTrainer.table.Rows[0][0].ToString() + " " + tableTrainer.table.Rows[0][1].ToString().Substring(0, 1) + ". " + tableTrainer.table.Rows[0][2].ToString().Substring(0, 1) + ".";
                Password = tableTrainer.table.Rows[0][5].ToString();
                tbTrainerPassword.Clear();
                tbTrainerConfirm.Clear();
            };
            Invoke(action);
        }

        private void TabChange()
        {
            Action action = () =>
            {
                switch (tgctrlTrainer.SelectedIndex)
                {
                    case (0):
                        GroupPagesFill();
                        break;
                    case (1):
                        WorkFill();
                        break;
                    case (2):
                        ThemeFill();
                        break;
                    case (3):
                        TimetableFill();
                        break;
                    case (4):
                        TrainerFill();
                        break;
                }
            };
            Invoke(action);
        }
        private void TTDependency_OnChange(object sender, System.Data.SqlClient.SqlNotificationEventArgs e)
        {
            if (e.Info != System.Data.SqlClient.SqlNotificationInfo.Invalid)
                TimetableFill();
        }

        private void ThemeDependency_OnChange(object sender, System.Data.SqlClient.SqlNotificationEventArgs e)
        {
            if (e.Info != System.Data.SqlClient.SqlNotificationInfo.Invalid)
                ThemeFill();
        }

        private void WorkDependency_OnChange(object sender, System.Data.SqlClient.SqlNotificationEventArgs e)
        {
            if (e.Info != System.Data.SqlClient.SqlNotificationInfo.Invalid)
                WorkFill();
        }

        private void GroupDependency_OnChange(object sender, System.Data.SqlClient.SqlNotificationEventArgs e)
        {
            if (e.Info != System.Data.SqlClient.SqlNotificationInfo.Invalid)
                GroupFill();
        }

        private void GroupPageDependency_OnChange(object sender, System.Data.SqlClient.SqlNotificationEventArgs e)
        {
            if (e.Info != System.Data.SqlClient.SqlNotificationInfo.Invalid)
                GroupPagesFill();
        }

        private void TgctrlTrainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thread tabSelect = new Thread(TabChange);
            tabSelect.Start();
        }

        private void DgGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Thread groupChange = new Thread(GroupChange);
            groupChange.Start();
        }

        private void GroupChange()
        {
            Action action = () =>
            {
                try
                {
                    Table_Class groupTest = new Table_Class(String.Format("SELECT [ID_Group] from [dbo].[Group] where [ID_Group] = {0}", dgGroup.Rows[dgGroup.SelectedCells[0].RowIndex].Cells[0].Value.ToString()));
                }
                catch
                {
                    GroupID = "";
                }
                finally
                {
                    GroupID = dgGroup.Rows[dgGroup.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                }
                TabChange();
                btWorkInsert.Enabled = false;
            };
            Invoke(action);
        }

        private void BtTrainerDarwback_Click(object sender, EventArgs e)
        {
            Thread trainerDrawbachk = new Thread(TrainerFill);
            trainerDrawbachk.Start();
        }

        private void BtInsert_Click(object sender, EventArgs e)
        {
            Thread gpInsert = new Thread(GroupInsert);
            gpInsert.Start();
        }

        private void GroupInsert()
        {
            Action action = () =>
            {
                Procedure_Class GroupInsert = new Procedure_Class();
                ArrayList array = new ArrayList();
                array.Add(cbWorkPlace.SelectedValue.ToString());
                array.Add(cbTheme.SelectedValue.ToString());
                array.Add(Program.intID);
                array.Add(nudCost.Value.ToString());
                GroupInsert.procedure_Execution("Group_Insert", array);
                GroupFill();
            };
            Invoke(action);
        }

        private void BtUpdate_Click(object sender, EventArgs e)
        {
            Thread gpUpdate = new Thread(GroupUpdate);
            gpUpdate.Start();
        }

        private void GroupUpdate()
        {
            Action action = () =>
            {
                if (GroupID != "")
                {
                    Procedure_Class GroupUpdate = new Procedure_Class();
                    ArrayList array = new ArrayList();
                    array.Add(GroupID);
                    array.Add(cbWorkPlace.SelectedValue.ToString());
                    array.Add(cbTheme.SelectedValue.ToString());
                    array.Add(Program.intID);
                    array.Add(nudCost.Value.ToString());
                    GroupUpdate.procedure_Execution("Group_Update", array);
                }
                else
                {
                    MessageBox.Show("Выберите группу", "PaladinApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GroupFill();
            };
            Invoke(action);
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            Thread gpDelete = new Thread(GroupDelete);
            gpDelete.Start();
        }

        private void GroupDelete()
        {
            Action action = () =>
            {
                if (GroupID != "")
                {
                    switch (MessageBox.Show("Вы действительно хотите удалить группу?", "PaladinApp", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        case (DialogResult.Yes):
                        Procedure_Class GroupDelete = new Procedure_Class();
                        ArrayList array = new ArrayList();
                        array.Add(GroupID);
                        GroupDelete.procedure_Execution("Group_LogicDelete", array);
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("Выберите группу", "PaladinApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GroupFill();
            };
            Invoke(action);
        }

        private void DgWork_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Thread workChange = new Thread(WorkChange);
            workChange.Start();
        }

        string IDWork = "";

        private void WorkChange()
        {
            Action action = () =>
            {
                try
                {
                    Table_Class workTest = new Table_Class(String.Format("SELECT [ID_Work] from [dbo].[Work] where [ID_Work] = {0}", dgWork.Rows[dgWork.SelectedCells[0].RowIndex].Cells[0].Value.ToString()));
                }
                catch
                {
                    IDWork = "";
                }
                finally
                {
                    IDWork = dgWork.Rows[dgWork.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                }
                if (IDWork != "")
                {
                    Table_Class workFill = new Table_Class(String.Format("SELECT [WorkDay],[Work_Time],[Work_Length] FROM [dbo].[Work] WHERE [LogicDelete] = 0 and [ID_Work] = {0}", IDWork));
                    nudStartHour.Value = Convert.ToInt32(workFill.table.Rows[0][1].ToString().Substring(0, 2));
                    nudStartMinute.Value = Convert.ToInt32(workFill.table.Rows[0][1].ToString().Substring(3, 2));
                    nudEndHour.Value = Convert.ToInt32(workFill.table.Rows[0][2].ToString().Substring(0, 2));
                    nudEndMinute.Value = Convert.ToInt32(workFill.table.Rows[0][2].ToString().Substring(3, 2));
                    switch (workFill.table.Rows[0][0].ToString())
                    {
                        case ("ПН"):
                            cbWorkDay.SelectedIndex = 0;
                            break;
                        case ("ВТ"):
                            cbWorkDay.SelectedIndex = 1;
                            break;
                        case ("СР"):
                            cbWorkDay.SelectedIndex = 2;
                            break;
                        case ("ЧТ"):
                            cbWorkDay.SelectedIndex = 3;
                            break;
                        case ("ПТ"):
                            cbWorkDay.SelectedIndex = 4;
                            break;
                        case ("СБ"):
                            cbWorkDay.SelectedIndex = 5;
                            break;
                        case ("ВС"):
                            cbWorkDay.SelectedIndex = 6;
                            break;
                    }
                }
                btWorkInsert.Enabled = false;
            };
            Invoke(action);
        }

        private void CbWorkDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            btWorkInsert.Enabled = false;
        }

        private void NudStartHour_ValueChanged(object sender, EventArgs e)
        {
            btWorkInsert.Enabled = false;
        }

        private void NudStartMinute_ValueChanged(object sender, EventArgs e)
        {
            btWorkInsert.Enabled = false;
        }

        private void NudEndHour_ValueChanged(object sender, EventArgs e)
        {
            btWorkInsert.Enabled = false;
        }

        private void NudEndMinute_ValueChanged(object sender, EventArgs e)
        {
            btWorkInsert.Enabled = false;
        }

        private void BtCheck_Click(object sender, EventArgs e)
        {
            WorkCheck();
        }
        string day = "";
        private void WorkCheck()
        {
            Action action = () =>
            {
            if (cbWorkPlace.SelectedValue.ToString() == "System.Data.DataRowView")
                {
                    MessageBox.Show("Проверьте правильность введённых значений", "PaladinApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btWorkInsert.Enabled = false;
                }
            else
                {
                    if (nudStartHour.Value>nudEndHour.Value)
                    {
                        MessageBox.Show("Проверьте правильность введённых значений", "PaladinApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btWorkInsert.Enabled = false;
                    }
                    else
                    {
                        if ((nudStartHour.Value == nudEndHour.Value) & (nudStartMinute.Value>=nudEndMinute.Value))
                        {
                            MessageBox.Show("Проверьте правильность введённых значений", "PaladinApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            btWorkInsert.Enabled = false;
                        }
                        else
                        {
                            if (GroupID == "")
                            {
                                MessageBox.Show("Выберите группу", "PaladinApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                btWorkInsert.Enabled = false;
                            }
                            else
                            {
                                ArrayList array = new ArrayList();
                                array.Add(GroupID);
                                switch (cbWorkDay.SelectedIndex)
                                {
                                    case (0):
                                        day = "ПН";
                                        break;
                                    case (1):
                                        day = "ВТ";
                                        break;
                                    case (2):
                                        day = "СР";
                                        break;
                                    case (3):
                                        day = "ЧТ";
                                        break;
                                    case (4):
                                        day = "ПТ";
                                        break;
                                    case (5):
                                        day = "СБ";
                                        break;
                                    case (6):
                                        day = "ВС";
                                        break;
                                }
                                array.Add("\'"+day+"\'");
                                switch (nudStartHour.Value.ToString().Length > 1)
                                {
                                    case (true):
                                        switch (nudStartMinute.Value.ToString().Length > 1)
                                        {
                                            case (true):
                                                array.Add("\'" + nudStartHour.Value.ToString() + ":" + nudStartMinute.Value.ToString() + "\'");
                                                break;
                                            case (false):
                                                array.Add("\'" + nudStartHour.Value.ToString() + ":0" + nudStartMinute.Value.ToString() + "\'");
                                                break;
                                        }
                                        break;
                                    case (false):
                                        switch (nudStartMinute.Value.ToString().Length > 1)
                                        {
                                            case (true):
                                                array.Add("\'0" + nudStartHour.Value.ToString() + ":" + nudStartMinute.Value.ToString() + "\'");
                                                break;
                                            case (false):
                                                array.Add("\'0" + nudStartHour.Value.ToString() + ":0" + nudStartMinute.Value.ToString() + "\'");
                                                break;
                                        }
                                        break;
                                }
                                switch (nudEndHour.Value.ToString().Length > 1)
                                {
                                    case (true):
                                        switch (nudEndMinute.Value.ToString().Length > 1)
                                        {
                                            case (true):
                                                array.Add("\'" + nudEndHour.Value.ToString() + ":" + nudEndMinute.Value.ToString() + "\'");
                                                break;
                                            case (false):
                                                array.Add("\'" + nudEndHour.Value.ToString() + ":0" + nudEndMinute.Value.ToString() + "\'");
                                                break;
                                        }
                                        break;
                                    case (false):
                                        switch (nudEndMinute.Value.ToString().Length > 1)
                                        {
                                            case (true):
                                                array.Add("\'0" + nudEndHour.Value.ToString() + ":" + nudEndMinute.Value.ToString() + "\'");
                                                break;
                                            case (false):
                                                array.Add("\'0" + nudEndHour.Value.ToString() + ":0" + nudEndMinute.Value.ToString() + "\'");
                                                break;
                                        }
                                        break;
                                }
                                //array.Add("\'" + nudStartHour.Value.ToString() + ":" + nudStartMinute.Value.ToString() + "\'");
                                //array.Add("\'" + nudEndHour.Value.ToString() + ":" + nudEndMinute.Value.ToString() + "\'");
                                Function_class workTest = new Function_class("Test_Work", Function_class.Function_Result.scalar, array);
                                if (workTest.Regtable.Rows[0][0].ToString() != "True")
                                {
                                    MessageBox.Show("Тренировка не может быть добавлена с такими параметрами", "PaladinApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    btWorkInsert.Enabled = false;
                                }
                                else
                                {
                                    btWorkInsert.Enabled = true;
                                }
                            }
                        }
                    }
                }
            };
            action.Invoke();
        }

        private void BtWorkDelete_Click(object sender, EventArgs e)
        {
            Thread workDelete = new Thread(WorkDelete);
            workDelete.Start();
        }

        private void WorkDelete()
        {
            Action action = () =>
            {
                if (IDWork != "")
                {
                    switch (MessageBox.Show("Вы действительно хотите удалить тренировку?", "PaladinApp", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        case (DialogResult.Yes):
                            ArrayList array = new ArrayList();
                            array.Add(IDWork);
                            Procedure_Class workDelete = new Procedure_Class();
                            workDelete.procedure_Execution("Work_LogDelete", array);
                            WorkFill();
                            break;
                    }
                }
                else
                    MessageBox.Show("Выберите тренировку", "PaladinApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            Invoke(action);
        }

        private void BtWorkInsert_Click(object sender, EventArgs e)
        {
            Thread workInsert = new Thread(WorkInsert);
            workInsert.Start();
        }

        private void WorkInsert()
        {
            Action action = () =>
            {
                ArrayList array = new ArrayList();
                array.Add(GroupID);
                array.Add(day);
                switch (nudStartHour.Value.ToString().Length > 1)
                {
                    case (true):
                        switch (nudStartMinute.Value.ToString().Length > 1)
                        {
                            case (true):
                                array.Add(nudStartHour.Value.ToString() + ":" + nudStartMinute.Value.ToString());
                                break;
                            case (false):
                                array.Add(nudStartHour.Value.ToString() + ":0" + nudStartMinute.Value.ToString());
                                break;
                        }
                        break;
                    case (false):
                        switch (nudStartMinute.Value.ToString().Length > 1)
                        {
                            case (true):
                                array.Add("0" + nudStartHour.Value.ToString() + ":" + nudStartMinute.Value.ToString());
                                break;
                            case (false):
                                array.Add("0" + nudStartHour.Value.ToString() + ":0" + nudStartMinute.Value.ToString());
                                break;
                        }
                        break;
                }
                switch (nudEndHour.Value.ToString().Length > 1)
                {
                    case (true):
                        switch (nudEndMinute.Value.ToString().Length > 1)
                        {
                            case (true):
                                array.Add(nudEndHour.Value.ToString() + ":" + nudEndMinute.Value.ToString());
                                break;
                            case (false):
                                array.Add(nudEndHour.Value.ToString() + ":0" + nudEndMinute.Value.ToString());
                                break;
                        }
                        break;
                    case (false):
                        switch (nudEndMinute.Value.ToString().Length > 1)
                        {
                            case (true):
                                array.Add("0" + nudEndHour.Value.ToString() + ":" + nudEndMinute.Value.ToString());
                                break;
                            case (false):
                                array.Add("0" + nudEndHour.Value.ToString() + ":0" + nudEndMinute.Value.ToString());
                                break;
                        }
                        break;
                }
                Procedure_Class workInsert = new Procedure_Class();
                workInsert.procedure_Execution("Work_Insert", array);
                WorkFill();
            };
            Invoke(action);
        }

        private bool TmMode = false;
        private void BtTmInsert_Click(object sender, EventArgs e)
        {
            TmMode = false;
            Thread tmInsert = new Thread(TmShow);
            tmInsert.Start();
        }

        private void BtTmUpdate_Click(object sender, EventArgs e)
        {
            TmMode = true;
            Thread tmInsert = new Thread(TmShow);
            tmInsert.Start();
        }

        private void TmShow()
        {
            Action action = () =>
            {
                if ((!TmMode)|(IDTheme != ""))
                {
                    ThemeForm themeForm = new ThemeForm();
                    themeForm.Owner = this;
                    themeForm.Mode = TmMode;
                    themeForm.Show();
                }
                else
                    MessageBox.Show("Выберите тематику", "PaladinApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            Invoke(action);
        }

        public string IDTheme = "";

        private void DgTheme_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Thread themeChange = new Thread(ThemeChange);
            themeChange.Start();
        }

        private void ThemeChange()
        {
            Action action = () =>
            {
                try
                {
                    Table_Class themeTest = new Table_Class(String.Format("SELECT [ThemeName],[ThemeAbout] FROM [dbo].[Themes] WHERE [LogicDelete]=0 and [ID_Theme] = {0}", dgTheme.Rows[dgTheme.SelectedCells[0].RowIndex].Cells[0].Value.ToString()));
                }
                catch
                {
                    IDTheme = "";
                }
                finally
                {
                    IDTheme = dgTheme.Rows[dgTheme.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                }
            };
            Invoke(action);
        }

        private void BtTmDelete_Click(object sender, EventArgs e)
        {
            Thread themeDelete = new Thread(ThemeDelete);
            themeDelete.Start();
        }

        private void ThemeDelete()
        {
            Action action = () =>
            {
                if (IDTheme != "")
                {
                    switch (MessageBox.Show("Вы действительно хотите удалить тематику?", "PaladinApp", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        case (DialogResult.Yes):
                            ArrayList array = new ArrayList();
                            array.Add(IDTheme);
                            Procedure_Class themeDelete = new Procedure_Class();
                            themeDelete.procedure_Execution("Theme_LogDelete", array);
                            ThemeFill();
                            break;
                    }
                }
                else
                    MessageBox.Show("Выберите тематику", "PaladinApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            Invoke(action);
        }

        private void BtTrainerConfirm_Click(object sender, EventArgs e)
        {
            Thread trainerDrawbachk = new Thread(TrainerUpdate);
            trainerDrawbachk.Start();
        }

        private void TrainerUpdate()
        {
            Action action = () =>
            {
                Procedure_Class procedure = new Procedure_Class();
                ArrayList array = new ArrayList();
                array.Add(Program.intID);
                array.Add(tbTrainerFirstname.Text);
                array.Add(tbTrainerName.Text);
                array.Add(tbTrainerPatronymic.Text);
                array.Add(tbCat.Text);
                switch (tbTrainerLogin.Text == "")
                {
                    case true:
                        tbTrainerLogin.BackColor = Color.Red;
                        break;
                    case false:
                        array.Add(tbTrainerLogin.Text);
                        switch ((tbTrainerPassword.Text == Password) || (tbTrainerPassword.Text == "" & tbTrainerConfirm.Text == ""))
                        {
                            case true:
                                array.Add(Password);
                                procedure.procedure_Execution("Trainer_Update", array);
                                tbTrainerPassword.BackColor = Color.White;
                                tbTrainerConfirm.BackColor = Color.White;
                                break;
                            case false:
                                switch (tbTrainerPassword.Text == tbTrainerConfirm.Text)
                                {
                                    case false:
                                        tbTrainerPassword.BackColor = Color.Red;
                                        tbTrainerConfirm.BackColor = Color.Red;
                                        break;
                                    case true:
                                        array.Add(tbTrainerPassword.Text);
                                        procedure.procedure_Execution("Trainer_Update", array);
                                        tbTrainerPassword.BackColor = Color.White;
                                        tbTrainerConfirm.BackColor = Color.White;
                                        break;
                                }
                                break;
                        }
                        tbTrainerPassword.Clear();
                        tbTrainerConfirm.Clear();
                        break;
                }
                TrainerFill();
            };
            Invoke(action);
        }

        private void BtRevoke_Click(object sender, EventArgs e)
        {
            Thread dbRevoke = new Thread(DBRevoke);
            dbRevoke.Start();
        }

        private void DBRevoke()
        {
            Action action = () =>
            {
                if (MessageBox.Show("Вы действительно хотите восстановить все удалённые данные в базе? Это действие невозможно отменить! Восстановление затронет только ваши аспекты базы.", "Paladin App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ArrayList array = new ArrayList();
                    Procedure_Class DBclearProc = new Procedure_Class();
                    DBclearProc.procedure_Execution("RewokeTrainer", array);
                    GroupFill();
                }
            };
            Invoke(action);
        }

        private void BtSearch_Click(object sender, EventArgs e)
        {
            Action action = () =>
            {
               if (tbSearch.Text.Length != 0)
                {
                    CurGroupQuerry = GroupQuerry + String.Format("AND ((Convert(varchar,dbo.[Group].ID_Group)) like {0} or (Convert(varchar,dbo.Themes.ThemeName)) like {0} or (Convert(varchar,dbo.Filials.FilialName)) like {0} or (Convert(varchar,dbo.WorkPlaces.WorkPlaceLocation)) like {0} or (Convert(varchar,dbo.[Group].Abon_Cost)) like {0})", "\'"+tbSearch.Text+"\'");
                }
               else
                {
                    CurGroupQuerry = GroupQuerry;
                }
                GroupFill();
            };
            Invoke(action);
        }

        private void BtThemeSearch_Click(object sender, EventArgs e)
        {
            Action action = () =>
            {
                if (tbThemeSearch.Text.Length != 0)
                {
                    CurThemeQuerry = ThemeQuerry + String.Format("AND ((Convert(varchar,[ID_Theme])) like {0} or (Convert(varchar,[ThemeName])) like {0} or (Convert(varchar,[ThemeAbout])) like {0})", "\'" + tbThemeSearch.Text+"\'");
                }
                else
                {
                    CurThemeQuerry = ThemeQuerry;
                }
                ThemeFill();
            };
            Invoke(action);
        }
    }
}
