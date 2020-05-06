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
    public partial class NewcomingForm : Form
    {
        public string ClientID = "";
        public NewcomingForm()
        {
            InitializeComponent();
        }

        private void ClientFill()
        {
            Action action = () =>
            {
                if (ClientID != "")
                {
                    Table_Class clientMain = new Table_Class(String.Format("SELECT [CLFirstName],[CLName],[CLMiddleName] FROM [dbo].[Client] WHERE [ID_Client] = {0}", ClientID));
                    lblCurClient.Text = clientMain.table.Rows[0][0].ToString() + ' ' + clientMain.table.Rows[0][1].ToString() + ' ' + clientMain.table.Rows[0][0].ToString();
                }
            };
            Invoke(action);
        }

        private void AbonFill()
        {
            Action action = () =>
            {
                if (ClientID != "")
                {
                    Table_Class tableAbonement = new Table_Class(String.Format("SELECT ID_Abonement ,(\'Группа №\' +Convert(varchar,ID_Group) +\' (С \' + Abonement_Start_Date + \' По \' + Abonement_End_Date +\')\') as \'Descriptor\' FROM [dbo].[Abonement] where LogicDelete = 0 and ID_Abonement > 0 and ID_Client = {0}", ClientID));
                    cbAbonement.DataSource = tableAbonement.table;
                    cbAbonement.ValueMember = "ID_Abonement";
                    cbAbonement.DisplayMember = "Descriptor";
                }
            };
            Invoke(action);
        }

        private void NCForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.ContainsFocus)
                switch (MessageBox.Show("Вы действительно хотите выйти на основную страницу без добавления посещения?", "PaladinApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case (DialogResult.Yes):
                        (Owner as ManagerInterface).AbonementUpdate();
                        this.Owner.Focus();
                        this.Hide();
                        break;
                }
        }

        private void NewcomingForm_Load(object sender, EventArgs e)
        {
            ClientFill();
            AbonFill();
        }

        string wDays = "";
        private void AbonAbout_Load()
        {
            Action action = () =>
            {
                lbAbonAbout.Items.Clear();
                if (cbAbonement.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    lbAbonAbout.Enabled = true;
                    Table_Class tableAbonement = new Table_Class(String.Format("SELECT dbo.Abonement.Abonement_Start_Date as \'С\', dbo.Abonement.Abonement_End_Date as \'По\', dbo.Abonement.Abonement_Cost/100 as \'Сумма\', dbo.[Action].ActionProperties as \'Акция\', dbo.Themes.ThemeName as \'Тематика\',dbo.Trainers.TrainerFirstName  as \'Тренер\',dbo.Filials.FilialName  as \'Филиал\', dbo.WorkPlaces.WorkPlaceLocation  as \'Зал\', dbo.Abonement.ID_Group as \'Группа\' FROM dbo.Abonement INNER JOIN dbo.[Action] ON dbo.Abonement.ID_Action = dbo.[Action].ID_Action INNER JOIN dbo.[Group] ON dbo.Abonement.ID_Group = dbo.[Group].ID_Group INNER JOIN dbo.Themes ON dbo.[Group].Theme_ID = dbo.Themes.ID_Theme INNER JOIN dbo.Trainers ON dbo.[Group].Trainer_ID = dbo.Trainers.ID_Trainer INNER JOIN dbo.WorkPlaces ON dbo.[Group].WorkPlace_ID = dbo.WorkPlaces.ID_WorkPlace INNER JOIN dbo.Filials ON dbo.WorkPlaces.ID_Filial = dbo.Filials.ID_Filial WHERE dbo.Abonement.LogicDelete = 0 and dbo.Abonement.ID_Abonement = {0}", cbAbonement.SelectedValue.ToString()));
                    lbAbonAbout.Items.Add("Дата начала " + tableAbonement.table.Rows[0][0].ToString());
                    lbAbonAbout.Items.Add("Дата окончания " + tableAbonement.table.Rows[0][1].ToString());
                    lbAbonAbout.Items.Add("Сумма " + tableAbonement.table.Rows[0][2].ToString());
                    lbAbonAbout.Items.Add("Акция " + tableAbonement.table.Rows[0][3].ToString());
                    lbAbonAbout.Items.Add("Тематика " + tableAbonement.table.Rows[0][4].ToString());
                    lbAbonAbout.Items.Add("Тренер " + tableAbonement.table.Rows[0][5].ToString());
                    lbAbonAbout.Items.Add("Филиал " + tableAbonement.table.Rows[0][6].ToString());
                    lbAbonAbout.Items.Add("Зал " + tableAbonement.table.Rows[0][7].ToString());
                    Table_Class wDay = new Table_Class(String.Format("select [WorkDay] from [dbo].[Work] where [ID_Group] = {0} and LogicDelete = 0", tableAbonement.table.Rows[0][8].ToString()));
                    wDays = "";
                    foreach (DataRow row in wDay.table.Rows)
                    {
                        wDays += row[0].ToString() + ", ";
                    }
                    wDays.Remove(wDays.Length - 3, 3);
                    lbAbonAbout.Items.Add("Дни тренировок: "+wDays);
                }
                else
                {
                    lbAbonAbout.Enabled = false;
                }
            };
            Invoke(action);
        }

        private void CbAbonement_SelectedIndexChanged(object sender, EventArgs e)
        {
            AbonAbout_Load();
            Work_Load();
        }

        private void Work_Load()
        {
            Action action = () =>
            {
                if (cbAbonement.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    string Today = "";
                    switch (DateTime.Now.DayOfWeek)
                    {
                        case (DayOfWeek.Monday):
                            Today = "ПН";
                            break;
                        case (DayOfWeek.Tuesday):
                            Today = "ВТ";
                            break;
                        case (DayOfWeek.Wednesday):
                            Today = "СР";
                            break;
                        case (DayOfWeek.Thursday):
                            Today = "ЧТ";
                            break;
                        case (DayOfWeek.Friday):
                            Today = "ПТ";
                            break;
                        case (DayOfWeek.Saturday):
                            Today = "СБ";
                            break;
                        case (DayOfWeek.Sunday):
                            Today = "ВС";
                            break;
                    }
                    Table_Class tableAbonement = new Table_Class(String.Format("select [ID_Work],[Work_Time] from [dbo].[Work] where [ID_Group] = (select [ID_Group] from [dbo].[Abonement] where [ID_Abonement] = {0}) and [WorkDay] = \'{1}\' and LogicDelete = 0", cbAbonement.SelectedValue.ToString(),Today));
                    if (tableAbonement.table.Rows.Count != 0)
                    {
                        cbWork.Enabled = true;
                        cbWork.DataSource = tableAbonement.table;
                        cbWork.ValueMember = "ID_Work";
                        cbWork.DisplayMember = "Work_Time";
                    }
                    else
                    {
                        cbWork.SelectedIndex = -1;
                        cbWork.Enabled = false;
                    }
                }
                else
                {
                    cbWork.Enabled = false;
                }
                BtAddEnable();
            };
            Invoke(action);
        }

        private void BtAddEnable()
        {
            try
            {
                if ((cbWork.SelectedValue.ToString() != "System.Data.DataRowView") & (cbWork.Enabled == true))
                    btAdd.Enabled = true;
                else
                    btAdd.Enabled = false;
            }
            catch
            {
                btAdd.Enabled = false;
            }
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            NCAdd();
            (Owner as ManagerInterface).NCUpdate();
            this.Owner.Focus();
            this.Hide();
        }

        private void NCAdd()
        {
            Action action = () =>
            {
                Procedure_Class procedure = new Procedure_Class();
                ArrayList array = new ArrayList();
                array.Add("\'" + DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString() + "." + "\'");
                array.Add(cbWork.SelectedValue.ToString());
                array.Add(cbAbonement.SelectedValue.ToString());
                procedure.procedure_Execution("Newcoming_Add", array);
            };
            Invoke(action);
        }
    }
}
