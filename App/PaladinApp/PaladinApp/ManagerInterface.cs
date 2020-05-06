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
    public partial class ManagerInterface : Form
    {
        public ManagerInterface()
        {
            InitializeComponent();
        }

        private void ManagerInterface_FormClosing(object sender, FormClosingEventArgs e)
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

        string ActionQuerry = "SELECT [ID_Action] as \'Номер\',[ActionProc] as \'Скидка\',[ActionProperties] as \'Условия\',[Action_Start_Date] as \'С\',[Action_End_Date] as \'По\' FROM [dbo].[Action] WHERE [LogicDelete] = 0 and [ID_Action]>0";
        string CurActionQuerry = "";
        string ClientQuerry = "SELECT [ID_Client] as \'Номер клиента\',[CLFirstName] as \'Фамилия\',[CLName] as \'Имя\',[CLMiddleName] as \'Отчество\',[ClGen] as \'Пол\',[ClAge] as \'Возраст\',[ClExp] as \'Стаж\',[Phone] as \'Телефон\',[Agreement] as \'Согласие (для 18-)\',[CLComm] as \'Комментарий\' FROM [dbo].[Client] where [LogicDelete] = '0' and [ID_Client] > 0";
        string CurClientQuerry = "";
        string AbonQuerry = "SELECT dbo.[Abonement].ID_Abonement  as \'Номер\', dbo.Abonement.Abonement_Start_Date as \'С\', dbo.Abonement.Abonement_End_Date as \'По\', dbo.Abonement.Abonement_Cost/100 as \'Сумма\', dbo.[Action].ActionProperties as \'Акция\', dbo.Themes.ThemeName as \'Тематика\',dbo.Trainers.TrainerFirstName  as \'Тренер\',dbo.Filials.FilialName  as \'Филиал\', dbo.WorkPlaces.WorkPlaceLocation  as \'Зал\' FROM dbo.Abonement INNER JOIN dbo.[Action] ON dbo.Abonement.ID_Action = dbo.[Action].ID_Action INNER JOIN dbo.[Group] ON dbo.Abonement.ID_Group = dbo.[Group].ID_Group INNER JOIN dbo.Themes ON dbo.[Group].Theme_ID = dbo.Themes.ID_Theme INNER JOIN dbo.Trainers ON dbo.[Group].Trainer_ID = dbo.Trainers.ID_Trainer INNER JOIN dbo.WorkPlaces ON dbo.[Group].WorkPlace_ID = dbo.WorkPlaces.ID_WorkPlace INNER JOIN dbo.Filials ON dbo.WorkPlaces.ID_Filial = dbo.Filials.ID_Filial WHERE dbo.Abonement.LogicDelete = 0 and dbo.Abonement.ID_Abonement > 0";
        string CurAbonQuerry = "";
        string NCQuerry = "SELECT dbo.Newcoming.ID_Newcoming as \'Номер\', dbo.Newcoming.Newcoming_Date as \'Дата\', dbo.[Work].Work_Time as \'Время\', dbo.Themes.ThemeName as \'Тематика\', dbo.Trainers.TrainerFirstName as \'Тренер\', dbo.Filials.FilialName as \'Филиал\', dbo.WorkPlaces.WorkPlaceLocation as \'Зал\' FROM dbo.Abonement INNER JOIN dbo.Client ON dbo.Abonement.ID_Client = dbo.Client.ID_Client INNER JOIN dbo.[Group] ON dbo.Abonement.ID_Group = dbo.[Group].ID_Group INNER JOIN dbo.Newcoming ON dbo.Abonement.ID_Abonement = dbo.Newcoming.ID_Abonement INNER JOIN dbo.Themes ON dbo.[Group].Theme_ID = dbo.Themes.ID_Theme INNER JOIN dbo.Trainers ON dbo.[Group].Trainer_ID = dbo.Trainers.ID_Trainer INNER JOIN dbo.[Work] ON dbo.[Group].ID_Group = dbo.[Work].ID_Group AND dbo.Newcoming.ID_Work = dbo.[Work].ID_Work INNER JOIN dbo.WorkPlaces ON dbo.[Group].WorkPlace_ID = dbo.WorkPlaces.ID_WorkPlace INNER JOIN dbo.Filials ON dbo.WorkPlaces.ID_Filial = dbo.Filials.ID_Filial WHERE (dbo.Newcoming.ID_Newcoming > 0) AND (dbo.Newcoming.LogicDelete = 0) ";
        string CurNCQuerry = "";

        private void BtSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text.Length != 0)
                CurClientQuerry = ClientQuerry + String.Format("AND (Convert(varchar,[ID_Client]) like {0} or [CLFirstName] like {0} or [CLName] like {0} or [CLMiddleName] like {0} or [ClGen] like {0} or Convert(varchar,[ClAge]) like {0} or Convert(varchar,[ClExp]) like {0} or Convert(varchar,[Phone]) like {0} or [Agreement] like {0} or Convert(varchar,[CLComm]) like {0})", "\'%" + tbSearch.Text + "%\'");
            else
                CurClientQuerry = ClientQuerry;
            Thread client_Fill = new Thread(Client_Fill);
            client_Fill.Start();
        }

        private void BtNCSearch_Click(object sender, EventArgs e)
        {
            if (tbNCSearch.Text.Length != 0)
                CurNCQuerry = NCQuerry + String.Format("AND (Convert(varchar,dbo.Newcoming.ID_Newcoming) like {0} or Convert(varchar,dbo.Newcoming.Newcoming_Date) like {0} or Convert(varchar,dbo.[Work].Work_Time) like {0} or Convert(varchar,dbo.Themes.ThemeName) like {0} or Convert(varchar,dbo.Trainers.TrainerFirstName) like {0} or Convert(varchar,dbo.Filials.FilialName) like {0} or Convert(varchar,dbo.WorkPlaces.WorkPlaceLocation) like {0})", "\'%" + tbNCSearch.Text + "%\'");
            else
                CurNCQuerry = NCQuerry;
            Thread NC_Fill = new Thread(NCUpdate);
            NC_Fill.Start();
        }

        private void BtActionSearch_Click(object sender, EventArgs e)
        {
            if (tbActSearch.Text.Length != 0)
                CurActionQuerry = ActionQuerry + String.Format("AND (Convert(varchar,[ID_Action]) like {0} or (Convert(varchar,[ActionProc]) like {0} or (Convert(varchar,[ActionProperties]) like {0} or (Convert(varchar,[Action_Start_Date]) like {0} or (Convert(varchar,[Action_End_Date]) like {0})", "\'%" + tbActSearch.Text + "%\'");
            else
                CurActionQuerry = ActionQuerry;
            Thread act_Fill = new Thread(ActionFill);
            act_Fill.Start();
        }

        private void BtAbonSearch_Click(object sender, EventArgs e)
        {
            if (tbAbonementSearch.Text.Length != 0)
                CurAbonQuerry = AbonQuerry + String.Format("AND (Convert(varchar,dbo.[Abonement].ID_Abonement) like {0} or Convert(varchar,dbo.Abonement.Abonement_Start_Date) like {0} or Convert(varchar,dbo.Abonement.Abonement_End_Date) like {0} or Convert(varchar,dbo.Abonement.Abonement_Cost/100) like {0} or Convert(varchar,dbo.[Action].ActionProperties) like {0} or Convert(varchar,dbo.Themes.ThemeName) like {0} or Convert(varchar,dbo.Trainers.TrainerFirstName) like {0} or Convert(varchar,dbo.Filials.FilialName) like {0} or Convert(varchar,dbo.WorkPlaces.WorkPlaceLocation) like {0})", "\'%" + tbAbonementSearch.Text + "%\'");
            else
                CurAbonQuerry = AbonQuerry;
            Thread abon_Fill = new Thread(AbonementUpdate);
            abon_Fill.Start();
        }

        private void ManagerInterface_Load(object sender, EventArgs e)
        {
            Thread client_Fill = new Thread(Client_Fill);
            client_Fill.Start();
            CurActionQuerry = ActionQuerry;
            CurClientQuerry = ClientQuerry;
            CurAbonQuerry = AbonQuerry;
            CurNCQuerry = NCQuerry;
            Manager_Fill();
        }

        private void Client_Fill()
        {
            Action action = () =>
            {
                Table_Class table_Client = new Table_Class(CurClientQuerry);
                table_Client.Dependency.OnChange += DependencyClient_OnChange;
                //При переустановке базы необходимо заменить 3 на 0 (особенности сервера и автонумерации)
                dgClient.DataSource = table_Client.table;
                cbGender.SelectedIndex = 0;
                dtpBirthdate.Value = DateTime.Now.AddDays(-1);
                dtpWorkStart.Value = DateTime.Now;
                Table_Class table_Manager = new Table_Class(String.Format("SELECT [ManagerFirstName],[ManagerSecondName],[ManagerLastName],[ManagerLogin],[ManagerPassword] FROM [dbo].[Managers] where [ID_Manager] = {0}", Program.intID));
                tbManagerFirstname.Text = table_Manager.table.Rows[0][0].ToString();
                tbManagerName.Text = table_Manager.table.Rows[0][1].ToString();
                tbManagerPatronymic.Text = table_Manager.table.Rows[0][2].ToString();
                tbManagerLogin.Text = table_Manager.table.Rows[0][3].ToString();
            };
            Invoke(action);
        }
        string Password = "";
        private void Manager_Fill()
        {
            Action action = () =>
            {
                Table_Class table_Manager = new Table_Class(String.Format("SELECT [ManagerFirstName],[ManagerSecondName],[ManagerLastName],[ManagerLogin],[ManagerPassword] FROM [dbo].[Managers] where [ID_Manager] = {0}", Program.intID));
                table_Manager.Dependency.OnChange += DependencyManager_OnChange;
                tbManagerFirstname.Text = table_Manager.table.Rows[0][0].ToString();
                tbManagerName.Text = table_Manager.table.Rows[0][1].ToString();
                tbManagerPatronymic.Text = table_Manager.table.Rows[0][2].ToString();
                tbManagerLogin.Text = table_Manager.table.Rows[0][3].ToString();
                Password = table_Manager.table.Rows[0][4].ToString();
                this.Text = "Интерфейс менеджера: " + table_Manager.table.Rows[0][0].ToString() + " " + table_Manager.table.Rows[0][1].ToString().Substring(0, 1) + ". " + table_Manager.table.Rows[0][2].ToString().Substring(0, 1) + ".";
            };
            Invoke(action);
        }

        private void DependencyManager_OnChange(object sender, System.Data.SqlClient.SqlNotificationEventArgs e)
        {
            if (e.Info != System.Data.SqlClient.SqlNotificationInfo.Invalid)
                Manager_Fill();
        }

        private void DependencyClient_OnChange(object sender, System.Data.SqlClient.SqlNotificationEventArgs e)
        {
            if (e.Info != System.Data.SqlClient.SqlNotificationInfo.Invalid)
                Client_Fill();
        }

        private void BtManagerDarwback_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Manager_Fill);
            thread.Start();
        }

        private void BtManagerConfirm_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Manager_Update);
            thread.Start();
        }

        private void Manager_Update()
        {
            Action action = () =>
            {
                Procedure_Class procedure = new Procedure_Class();
                ArrayList array = new ArrayList();
                array.Add(Program.intID);
                array.Add(tbManagerFirstname.Text);
                array.Add(tbManagerName.Text);
                array.Add(tbManagerPatronymic.Text);
                switch (tbManagerLogin.Text == "")
                {
                    case true:
                        tbManagerLogin.BackColor = Color.Red;
                        break;
                    case false:
                        array.Add(tbManagerLogin.Text);
                        switch ((tbManagerPassword.Text == Password) || (tbManagerPassword.Text == "" & tbManagerConfirm.Text == ""))
                        {
                            case true:
                                array.Add(Password);
                                procedure.procedure_Execution("Manager_Update", array);
                                tbManagerPassword.BackColor = Color.White;
                                tbManagerConfirm.BackColor = Color.White;
                                break;
                            case false:
                                switch (tbManagerPassword.Text == tbManagerConfirm.Text)
                                {
                                    case false:
                                        tbManagerPassword.BackColor = Color.Red;
                                        tbManagerConfirm.BackColor = Color.Red;
                                        break;
                                    case true:
                                        array.Add(tbManagerPassword.Text);
                                        procedure.procedure_Execution("Manager_Update", array);
                                        tbManagerPassword.BackColor = Color.White;
                                        tbManagerConfirm.BackColor = Color.White;
                                        break;
                                }
                                break;
                        }
                        tbManagerPassword.Clear();
                        tbManagerConfirm.Clear();
                        break;
                }
                Manager_Fill();
            };
            Invoke(action);
        }

        private void DgClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Thread fill = new Thread(TableFill);
            fill.Start();
        }

        private void TableFill()
        {
            try
            {
                ClientPages_Fill(dgClient.Rows[dgClient.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
                TabSelect();
            }
            catch
            {
                ClientProcID = "";
            }
        }

        string ClientProcID = "";

        private void ClientPages_Fill(string ClientID)
        {
            Action action = () =>
            {
                Table_Class table_ClientPages = new Table_Class(string.Format("SELECT [CLFirstName],[CLName],[CLMiddleName],[ClGen],[CLBirthdate],[CLWorkStart],[Phone],[Agreement],[CLComm] FROM [dbo].[Client] where [ID_Client] = {0}", ClientID));
                ClientProcID = ClientID;
                tbFirstname.Text = table_ClientPages.table.Rows[0][0].ToString();
                tbName.Text = table_ClientPages.table.Rows[0][1].ToString();
                tbPatronymic.Text = table_ClientPages.table.Rows[0][2].ToString();
                switch (table_ClientPages.table.Rows[0][3].ToString())
                {
                    case ("муж"):
                        cbGender.SelectedIndex = 0;
                        break;
                    case ("жен"):
                        cbGender.SelectedIndex = 1;
                        break;
                }
                dtpBirthdate.Value = Convert.ToDateTime(table_ClientPages.table.Rows[0][4].ToString());
                dtpWorkStart.Value = Convert.ToDateTime(table_ClientPages.table.Rows[0][5].ToString());
                tbPhone.Text = table_ClientPages.table.Rows[0][6].ToString();
                tbAgreement.Text = table_ClientPages.table.Rows[0][7].ToString();
                tbComm.Text = table_ClientPages.table.Rows[0][8].ToString();
            };
            Invoke(action);
        }

        private void AbonFill(string ClientID)
        {
            Action action = () =>
            {
                Table_Class table_Abonement = new Table_Class(String.Format(CurAbonQuerry + "and dbo.Abonement.ID_Client = {0}", ClientID));
                table_Abonement.Dependency.OnChange += AbonDependency_OnChange;
                dgAbonement.DataSource = table_Abonement.table;

            };
            Invoke(action);
        }

        private void AbonDependency_OnChange(object sender, System.Data.SqlClient.SqlNotificationEventArgs e)
        {
            if (e.Info != System.Data.SqlClient.SqlNotificationInfo.Invalid)
                AbonFill(ClientProcID);
        }

        private void NCFill(string ClientID)
        {
            Action action = () =>
            {
                Table_Class table_NC = new Table_Class(String.Format(CurNCQuerry + "AND (dbo.Abonement.ID_Client = {0})", ClientID));
                table_NC.Dependency.OnChange += NCDependency_OnChange;
                dgNewcoming.DataSource = table_NC.table;
            };
            Invoke(action);
        }

        private void NCDependency_OnChange(object sender, System.Data.SqlClient.SqlNotificationEventArgs e)
        {
            //try
            //{
            //    if (e.Info != System.Data.SqlClient.SqlNotificationInfo.Invalid)
            //        if (ClientProcID != "")
            //            NCFill(ClientProcID);
            //}
            //catch (ObjectDisposedException ex)
            //{

            //}
        }

        private void TbCtrlManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thread tabSelect = new Thread(TabSelect);
            tabSelect.Start();
        }

        private void TabSelect()
        {
            Action action = () =>
            {
                    switch (tbCtrlManager.SelectedIndex)
                    {
                        case (0):
                        if (ClientProcID != "")
                            ClientPages_Fill(ClientProcID);
                            break;
                        case (1):
                        if (ClientProcID != "")
                            AbonFill(ClientProcID);
                            break;
                        case (2):
                            ActionFill();
                            break;
                        case (3):
                        if (ClientProcID != "")
                            NCFill(ClientProcID);
                            break;
                        case (4):
                            TimetableFill();
                            break;
                        case (5):
                            FilialFill();
                            break;
                        case (6):
                            Manager_Fill();
                            break;
                    }
            };
            Invoke(action);
        }

        public void ActionFill()
        {
            Action action = () =>
            {
                Table_Class table_Action = new Table_Class(CurActionQuerry);
                table_Action.Dependency.OnChange += ActionDependency_OnChange;
                dgAction.DataSource = table_Action.table;
            };
            Invoke(action);
        }

        public void FilialFill()
        {
            Action action = () =>
            {
                Table_Class table_Filial = new Table_Class("SELECT [ID_Filial] as \'Код\',[FilialName] as \'Название\',[FilialAdress] as \'Адрес\' FROM [dbo].[Filials] WHERE [LogicDelete] = 0 and [ID_Filial]>0");
                table_Filial.Dependency.OnChange += FilialDependency_OnChange;
                dgFilial.DataSource = table_Filial.table;
            };
            Invoke(action);
        }

        string FID = "";
        string WPID = "";

        public void WorkPlaceFill()
        {
            Action action = () =>
            {
                Table_Class table_WorkPlace = new Table_Class(String.Format("SELECT [ID_WorkPlace] as \'Номер\' ,[WorkPlaceLocation] as \'Расположение\' FROM [dbo].[WorkPlaces] WHERE [LogicDelete] = 0 and [ID_WorkPlace]>0 and [ID_Filial] = {0}", FID));
                table_WorkPlace.Dependency.OnChange += WorkPlaceDependency_OnChange; ;
                dgWorkPlaces.DataSource = table_WorkPlace.table;
            };
            Invoke(action);
        }

        private void WorkPlaceDependency_OnChange(object sender, System.Data.SqlClient.SqlNotificationEventArgs e)
        {
            if (e.Info != System.Data.SqlClient.SqlNotificationInfo.Invalid)
                FilialFill();
        }

        private void FilialDependency_OnChange(object sender, System.Data.SqlClient.SqlNotificationEventArgs e)
        {
            if (e.Info != System.Data.SqlClient.SqlNotificationInfo.Invalid)
                WorkPlaceFill();
        }

        private void ActionDependency_OnChange(object sender, System.Data.SqlClient.SqlNotificationEventArgs e)
        {
            if (e.Info != System.Data.SqlClient.SqlNotificationInfo.Invalid)
                ActionFill();
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

        private void TTDependency_OnChange(object sender, System.Data.SqlClient.SqlNotificationEventArgs e)
        {
            if (e.Info != System.Data.SqlClient.SqlNotificationInfo.Invalid)
                TimetableFill();
        }

        private void BtInsert_Click(object sender, EventArgs e)
        {
            Thread clInsert = new Thread(CLInsert);
            clInsert.Start();
        }

        private void CLInsert()
        {
            Action action = () =>
            {
                Procedure_Class procedure = new Procedure_Class();
                ArrayList array = new ArrayList();
                switch (tbFirstname.Text.Length == 0)
                {
                    case (true):
                        tbFirstname.BackColor = Color.Red;
                        break;
                    case (false):
                        tbFirstname.BackColor = Color.White;
                        array.Add(tbFirstname.Text.ToString());
                        switch (tbName.Text.Length == 0)
                        {
                            case (true):
                                tbName.BackColor = Color.Red;
                                break;
                            case (false):
                                tbName.BackColor = Color.White;
                                array.Add(tbFirstname.Text.ToString());
                                array.Add(tbPatronymic.Text.ToString());
                                switch (cbGender.SelectedIndex)
                                {
                                    case (0):
                                        array.Add("муж");
                                        break;
                                    case (1):
                                        array.Add("жен");
                                        break;
                                }
                                array.Add(dtpBirthdate.Value.Day.ToString() + "." + dtpBirthdate.Value.Month.ToString() + "." + dtpBirthdate.Value.Year.ToString());
                                array.Add(dtpWorkStart.Value.Day.ToString() + "." + dtpWorkStart.Value.Month.ToString() + "." + dtpWorkStart.Value.Year.ToString());
                                switch (tbPhone.Text.Length != 12)
                                {
                                    case (true):
                                        tbPhone.BackColor = Color.Red;
                                        break;
                                    case (false):
                                        tbPhone.BackColor = Color.White;
                                        array.Add(tbPhone.Text.ToString());
                                        switch (tbAgreement.Enabled)
                                        {
                                            case (false):
                                                array.Add(tbAgreement.Text.ToString());
                                                array.Add(tbComm.Text.ToString());
                                                procedure.procedure_Execution("Client_Insert", array);
                                                Client_Fill();
                                                break;
                                            case (true):
                                                switch (tbAgreement.Text.Length != 8)
                                                {
                                                    case (true):
                                                        tbAgreement.BackColor = Color.Red;
                                                        break;
                                                    case (false):
                                                        tbAgreement.BackColor = Color.White;
                                                        array.Add(tbAgreement.Text.ToString());
                                                        array.Add(tbComm.Text.ToString());
                                                        procedure.procedure_Execution("Client_Insert", array);
                                                        Client_Fill();
                                                        break;
                                                }
                                                break;
                                        }
                                        break;
                                }
                                break;
                        }
                        break;
                }
            };
            Invoke(action);
        }

        private void DtpBirthdate_ValueChanged(object sender, EventArgs e)
        {
            Action action = () =>
            {
                DtpWorkStart_ValueChanged(dtpWorkStart, e);
                switch (DateTime.Today.Subtract(dtpBirthdate.Value).Days < 6570)
                {
                    case (true):
                        tbAgreement.Enabled = true;
                        break;
                    case (false):
                        tbAgreement.Enabled = false;
                        tbAgreement.Clear();
                        break;
                }
            };
            Invoke(action);
        }

        private void DtpWorkStart_ValueChanged(object sender, EventArgs e)
        {
            Action action = () =>
            {
                switch (dtpWorkStart.Value < dtpBirthdate.Value)
                {
                    case (true):
                        dtpWorkStart.Value = dtpBirthdate.Value.AddDays(1);
                        break;
                }
            };
            Invoke(action);
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            Thread clDelete = new Thread(CLDelete);
            clDelete.Start();
        }

        private void CLDelete()
        {
            Action action = () =>
            {
                Procedure_Class procedure = new Procedure_Class();
                ArrayList array = new ArrayList();
                array.Add(ClientProcID);
                procedure.procedure_Execution("Client_LogDelete", array);
                Client_Fill();
            };
            Invoke(action);
        }

        private void CLUpdate()
        {
            Action action = () =>
            {
                Procedure_Class procedure = new Procedure_Class();
                ArrayList array = new ArrayList();
                array.Add(ClientProcID);
                switch (tbFirstname.Text.Length == 0)
                {
                    case (true):
                        tbFirstname.BackColor = Color.Red;
                        break;
                    case (false):
                        tbFirstname.BackColor = Color.White;
                        array.Add(tbFirstname.Text.ToString());
                        switch (tbName.Text.Length == 0)
                        {
                            case (true):
                                tbName.BackColor = Color.Red;
                                break;
                            case (false):
                                tbName.BackColor = Color.White;
                                array.Add(tbFirstname.Text.ToString());
                                array.Add(tbPatronymic.Text.ToString());
                                switch (cbGender.SelectedIndex)
                                {
                                    case (0):
                                        array.Add("муж");
                                        break;
                                    case (1):
                                        array.Add("жен");
                                        break;
                                }
                                array.Add(dtpBirthdate.Value.Day.ToString() + "." + dtpBirthdate.Value.Month.ToString() + "." + dtpBirthdate.Value.Year.ToString());
                                array.Add(dtpWorkStart.Value.Day.ToString() + "." + dtpWorkStart.Value.Month.ToString() + "." + dtpWorkStart.Value.Year.ToString());
                                switch (tbPhone.Text.Length != 12)
                                {
                                    case (true):
                                        tbPhone.BackColor = Color.Red;
                                        break;
                                    case (false):
                                        tbPhone.BackColor = Color.White;
                                        array.Add(tbPhone.Text.ToString());
                                        switch (tbAgreement.Enabled)
                                        {
                                            case (false):
                                                array.Add(tbAgreement.Text.ToString());
                                                array.Add(tbComm.Text.ToString());
                                                procedure.procedure_Execution("Client_Update", array);
                                                Client_Fill();
                                                break;
                                            case (true):
                                                switch (tbAgreement.Text.Length != 8)
                                                {
                                                    case (true):
                                                        tbAgreement.BackColor = Color.Red;
                                                        break;
                                                    case (false):
                                                        tbAgreement.BackColor = Color.White;
                                                        array.Add(tbAgreement.Text.ToString());
                                                        array.Add(tbComm.Text.ToString());
                                                        procedure.procedure_Execution("Client_Update", array);
                                                        Client_Fill();
                                                        break;
                                                }
                                                break;
                                        }
                                        break;
                                }
                                break;
                        }
                        break;
                }
            };
            Invoke(action);
        }

        private void BtUpdate_Click(object sender, EventArgs e)
        {
            Thread clUpdate = new Thread(CLUpdate);
            clUpdate.Start();
        }

        private void BtAbonementStop_Click(object sender, EventArgs e)
        {
            Action action = () =>
            {
                if (IDAbonement != "")
                {
                    switch (MessageBox.Show("Вы действительно хотите прекратить действие абонимента?", "PaladinApp", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        case (DialogResult.Yes):
                            Procedure_Class procedure = new Procedure_Class();
                            ArrayList array = new ArrayList();
                            array.Add(IDAbonement);
                            procedure.procedure_Execution("Abonement_Log_Delete", array);
                            AbonFill(ClientProcID);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Выберите абонимент", "PaladinApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        string IDAbonement = "";

        private void DgAbonement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IDAbonement = dgAbonement.Rows[dgAbonement.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
            }
            catch
            {
                IDAbonement = "";
            }
        }

        private void BtAbonementAdd_Click(object sender, EventArgs e)
        {
            if (ClientProcID != "")
            {
                Thread abonAdd = new Thread(AbonementShow);
                abonAdd.Start();
            }
            else
                MessageBox.Show("Выберите клиента", "PaladinApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AbonementShow()
        {
            Action action = () =>
            {
                AbonementForm abonementForm = new AbonementForm();
                abonementForm.ClientID = ClientProcID;
                abonementForm.Owner = this;
                abonementForm.Show();
            };
            Invoke(action);
        }

        public void AbonementUpdate()
        {
            AbonFill(ClientProcID);
        }

        public void NCUpdate()
        {
            NCFill(ClientProcID);
        }

        string IDAction = "";

        private void BtActStop_Click(object sender, EventArgs e)
        {
            Action action = () =>
            {
                if (IDAction != "")
                {
                    switch (MessageBox.Show("Вы действительно хотите прекратить действие акции?", "PaladinApp", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        case (DialogResult.Yes):
                            Procedure_Class procedure = new Procedure_Class();
                            ArrayList array = new ArrayList();
                            array.Add(IDAction);
                            procedure.procedure_Execution("Action_LogDelete", array);
                            ActionFill();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Выберите акцию", "PaladinApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        private void DgAction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IDAction = dgAction.Rows[dgAction.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
            }
            catch
            {
                IDAction = "";
            }
        }

        private void ActionShow()
        {
            Action action = () =>
            {
                WorkActionsForm actionsForm = new WorkActionsForm();
                actionsForm.Owner = this;
                actionsForm.Show();
            };
            Invoke(action);
        }

        private void BtActAdd_Click(object sender, EventArgs e)
        {
            Thread actAdd = new Thread(ActionShow);
            actAdd.Start();
        }

        private void BtTimetable_Click(object sender, EventArgs e)
        {
            TTSaveDialog.ShowDialog(this);
        }

        private void TimetableSave()
        {
            Action action = () =>
            {
                Table_Class table_TT = new Table_Class("SELECT [ID_Work] as \'Номер тренировки\',[WorkDay] as \'День недели\',[Work_Time] as \'Начало\',[Work_Length] as \'Окончание\',[ThemeName] as \'Темактика\',([TrainerFirstName] + ' ' + SUBSTRING([TrainerSecondName],1,1) + '. ' + SUBSTRING([TrainerLastName],1,1) +'.') as \'Тренер\',[FilialName] as \'Филиал\',[WorkPlaceLocation] as \'Зал\' FROM [dbo].[Timetable] where [LogicDelete] = 0 and [ID_Work] > 1");
                Document_class ttDoc = new Document_class();
                ttDoc.Document_Create(Document_class.Document_Type.Timetable, Document_class.Document_Format.Excel, TTSaveDialog.FileName, table_TT.table);
            };
            Invoke(action);
        }

        private void TTSaveDialog_FileOk(object sender, CancelEventArgs e)
        {
            Thread ttSave = new Thread(TimetableSave);
            ttSave.Start();
        }

        private void BtNCAdd_Click(object sender, EventArgs e)
        {
            if (ClientProcID != "")
            {
                Thread NCAdd = new Thread(NCInsert);
                NCAdd.Start();
            }
            else
                MessageBox.Show("Выберите клиента", "PaladinApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NCInsert()
        {
            Action action = () =>
            {
                NewcomingForm newcomingForm = new NewcomingForm();
                newcomingForm.ClientID = ClientProcID;
                newcomingForm.Owner = this;
                newcomingForm.Show();
            };
            Invoke(action);
        }

        private void DgFilial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Action action = () =>
            {
                try
                {
                    Table_Class FTest = new Table_Class(String.Format("SELECT [ID_Filial] FROM [dbo].[Filials] WHERE [ID_Filial] = {0}", dgFilial.Rows[dgFilial.SelectedCells[0].RowIndex].Cells[0].Value.ToString()));
                }
                catch
                {
                    FID = "";
                }
                finally
                {
                    FID = dgFilial.Rows[dgFilial.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                    WorkPlaceFill();
                }
            };
            Invoke(action);
        }

        private void DgWorkPlace_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Action action = () =>
            {
                try
                {
                    Table_Class WPTest = new Table_Class(String.Format("SELECT [ID_WorkPlace] FROM [dbo].[WorkPlaces] WHERE [ID_WorkPlace]={0}", dgWorkPlaces.Rows[dgWorkPlaces.SelectedCells[0].RowIndex].Cells[0].Value.ToString()));
                }
                catch
                {
                    WPID = "";
                }
                finally
                {
                    WPID = dgWorkPlaces.Rows[dgWorkPlaces.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                }
            };
            Invoke(action);
        }

        private void BtFInsert_Click(object sender, EventArgs e)
        {
            Thread FInsert = new Thread(InsertFilial);
            FInsert.Start();
        }

        private void InsertFilial()
        {
            Action action = () =>
            {
                if (tbFilialName.Text.Length == 0)
                    tbFilialName.BackColor = Color.Red;
                else
                {
                    tbFilialName.BackColor = Color.White;
                    if (tbFilialAdress.Text.Length == 0)
                        tbFilialAdress.BackColor = Color.Red;
                    else
                    {
                        tbFilialAdress.BackColor = Color.White;
                        ArrayList array = new ArrayList();
                        array.Add(tbFilialName.Text);
                        array.Add(tbFilialAdress.Text);
                        Procedure_Class fInsert = new Procedure_Class();
                        fInsert.procedure_Execution("Filial_Insert", array);
                        FilialFill();
                    }
                }
            };
            Invoke(action);
        }

        private void UpdateFilial()
        {
            Action action = () =>
            {
                if (FID == "")
                    MessageBox.Show("Выберите филиал!", "Paladin App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (tbFilialName.Text.Length == 0)
                        tbFilialName.BackColor = Color.Red;
                    else
                    {
                        tbFilialName.BackColor = Color.White;
                        if (tbFilialAdress.Text.Length == 0)
                            tbFilialAdress.BackColor = Color.Red;
                        else
                        {
                            tbFilialAdress.BackColor = Color.White;
                            ArrayList array = new ArrayList();
                            array.Add(FID);
                            array.Add(tbFilialName.Text);
                            array.Add(tbFilialAdress.Text);
                            Procedure_Class fUpdate = new Procedure_Class();
                            fUpdate.procedure_Execution("Filial_Update", array);
                            FilialFill();
                        }
                    }
                }
            };
            Invoke(action);
        }

        private void DeleteFilial()
        {
            Action action = () =>
            {
                if (FID == "")
                    MessageBox.Show("Выберите филиал!", "Paladin App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (MessageBox.Show("Вы действительно хотите удалить филиал", "Paladin App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ArrayList array = new ArrayList();
                        array.Add(FID);
                        Procedure_Class fDelete = new Procedure_Class();
                        fDelete.procedure_Execution("Filial_LogicDelete", array);
                        FilialFill();
                    }
                }
            };
            Invoke(action);
        }

        private void BtFUpdate_Click(object sender, EventArgs e)
        {
            Thread FUpdate = new Thread(UpdateFilial);
            FUpdate.Start();
        }

        private void BtFDelete_Click(object sender, EventArgs e)
        {
            Thread FDelete = new Thread(DeleteFilial);
            FDelete.Start();
        }

        private void InsertWorkPlace()
        {
            Action action = () =>
            {
                if (FID == "")
                    MessageBox.Show("Выберите филиал!", "Paladin App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (tbWPLocation.Text.Length == 0)
                        tbWPLocation.BackColor = Color.Red;
                    else
                    {
                        tbWPLocation.BackColor = Color.White;
                        ArrayList array = new ArrayList();
                        array.Add(FID);
                        array.Add(tbWPLocation.Text);
                        Procedure_Class fDelete = new Procedure_Class();
                        fDelete.procedure_Execution("WorkPlace_Insert", array);
                        WorkPlaceFill();
                    }
                }
            };
            Invoke(action);
        }

        private void UpdateWorkPlace()
        {
            Action action = () =>
            {
                if (FID == "")
                    MessageBox.Show("Выберите филиал!", "Paladin App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (WPID == "")
                        MessageBox.Show("Выберите рабочую площадку!", "Paladin App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (tbWPLocation.Text.Length == 0)
                            tbWPLocation.BackColor = Color.Red;
                        else
                        {
                            tbWPLocation.BackColor = Color.White;
                            ArrayList array = new ArrayList();
                            array.Add(WPID);
                            array.Add(FID);
                            array.Add(tbWPLocation.Text);
                            Procedure_Class fDelete = new Procedure_Class();
                            fDelete.procedure_Execution("WorkPlace_Update", array);
                            WorkPlaceFill();
                        }
                    }
                }
            };
            Invoke(action);
        }

        private void DeleteWorkPlace()
        {
            Action action = () =>
            {
                if (WPID == "")
                    MessageBox.Show("Выберите рабочую площадку!", "Paladin App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (MessageBox.Show("Вы действительно хотите удалить рабочую площадку", "Paladin App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ArrayList array = new ArrayList();
                        array.Add(WPID);
                        Procedure_Class fDelete = new Procedure_Class();
                        fDelete.procedure_Execution("WorkPlace_LogicDelete", array);
                        WorkPlaceFill();
                    }
                }
            };
            Invoke(action);
        }

        private void BtWPInsert_Click(object sender, EventArgs e)
        {
            Thread WPInsert = new Thread(InsertWorkPlace);
            WPInsert.Start();
        }

        private void BtWPUpdate_Click(object sender, EventArgs e)
        {
            Thread WPUpdate= new Thread(UpdateWorkPlace);
            WPUpdate.Start();
        }

        private void BtWPDelete_Click(object sender, EventArgs e)
        {
            Thread WPDelete= new Thread(DeleteWorkPlace);
            WPDelete.Start();
        }

        private void BtDBCLear_Click(object sender, EventArgs e)
        {
            Thread dbClear= new Thread(DBClear);
            dbClear.Start();
        }

        private void DBClear()
        {
            Action action = () =>
            {
               if (MessageBox.Show("Вы действительно хотите удалить все помеченные на удаление данные в базе? Это действие невозможно отменить!", "Paladin App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                    if (Program.intID != "0")
                        MessageBox.Show("Ваших полномочий недостаточно для этого действия", "Paladin App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        ArrayList array = new ArrayList();
                        Procedure_Class DBclearProc = new Procedure_Class();
                        DBclearProc.procedure_Execution("Clear", array);
                    }
                    }
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
                if (MessageBox.Show("Вы действительно хотите восстановить все удалённые данные в базе? Это действие невозможно отменить!", "Paladin App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ArrayList array = new ArrayList();
                    Procedure_Class DBclearProc = new Procedure_Class();
                    DBclearProc.procedure_Execution("RevokeManager", array);
                    Client_Fill();
                }
            };
            Invoke(action);
        }

        private void BtTrainers_Click(object sender, EventArgs e)
        {
            Thread trainersWork = new Thread(TrainersWork);
            trainersWork.Start();
        }

        private void TrainersWork()
        {
            Action action = () =>
            {
                TrainerForm trainerForm = new TrainerForm();
                trainerForm.Owner = this;
                trainerForm.Show();
            };
            Invoke(action);
        }
    }
}
