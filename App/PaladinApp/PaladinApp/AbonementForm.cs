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
    public partial class AbonementForm : Form
    {
        public string ClientID = "";

        public AbonementForm()
        {
            InitializeComponent();
        }

        private void ClientFill()
        {
            if (ImCLose)
            {
                this.Close();
            }
            else
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
        }

        private void ActionFill()
        {
            if (ImCLose)
            {
                this.Close();
            }
            else
            {
                Action action = () =>
            {
                Table_Class acttable = new Table_Class("SELECT [ID_Action],(Convert(varchar,[ActionProperties]) +' (' + Convert(varchar,[ActionProc]) + ')') as 'Descriptor' FROM [dbo].[Action] WHERE [LogicDelete] = 0");
                cbAction.DataSource = acttable.table;
                cbAction.DisplayMember = "Descriptor";
                cbAction.ValueMember = "ID_Action";
            };
                Invoke(action);
            }
        }
        bool ImCLose = false;
        private void GroupFill()
        {
            if (ImCLose)
            {
                this.Close();
            }
            else
            {
                Action action = () =>
                {
                    Table_Class group = new Table_Class("SELECT [ID_Group],((select (select [FilialName] from [dbo].[Filials] where [dbo].[WorkPlaces].[ID_Filial] = [dbo].[Filials].[ID_Filial]) from [dbo].[WorkPlaces] where [dbo].[Group].[WorkPlace_ID] = [dbo].[WorkPlaces].[ID_WorkPlace]) + ' ' + Substring((select [WorkPlaceLocation] from [dbo].[WorkPlaces] where [dbo].[Group].[WorkPlace_ID] = [dbo].[WorkPlaces].[ID_WorkPlace]),1,3) +'.; ' + (select [ThemeName] from [dbo].[Themes] where [dbo].[Group].[Theme_ID] = [dbo].[Themes].[ID_Theme]) +'; ' + (select [TrainerFirstname] from [dbo].[Trainers] where [dbo].[Group].[Trainer_ID] = [dbo].[Trainers].[ID_Trainer]) + ' (' + Convert(varchar,[ID_Group]) + ')') as 'Descriptor' FROM [dbo].[Group] where [LogicDelete] = 0 and [ID_Group] > 0");
                    cbGroup.DataSource = group.table;
                    if (group.table.Rows.Count == 0)
                    {
                        MessageBox.Show("Должна быть добавлена хоть одна группа!", "PaladinApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ImCLose = true;

                    }
                    cbGroup.DisplayMember = "Descriptor";
                    cbGroup.ValueMember = "ID_Group";
                };
                Invoke(action);
            }
        }

        private void AbonementForm_Load(object sender, EventArgs e)
        {
            if (ImCLose)
            {
                this.Close();
            }
            else
            {
                ClientFill();
                GroupFill();
                ActionFill();
                try
                {
                    cbGroup.SelectedIndex = 0;
                }
                catch
                {

                }
            }
        }

        private void AbonementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.ContainsFocus)
            switch (MessageBox.Show("Вы действительно хотите выйти на основную страницу без добавления абонемента?", "PaladinApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case (DialogResult.Yes):
                    (Owner as ManagerInterface).AbonementUpdate();
                    this.Owner.Focus();
                    this.Hide();
                    break;
            }
        }

        private void DtpStart_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStart.Value < DateTime.Now)
            {
                dtpStart.Value = DateTime.Now;
            }
            dtpEnd.Value = dtpStart.Value.AddDays(1);
            if (cbAction.SelectedValue.ToString() != "System.Data.DataRowView")
                AbonCheck();
            if (ActionPerf)
                dtpEnd.Enabled = true;
            else
                lblCurPrice.Text = "Ошибка!";
            AddButtonEnable();
        }

        private void DtpEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpEnd.Value < dtpStart.Value)
            {
                dtpEnd.Value = dtpStart.Value.AddDays(1);
            }
            AbonCost();
            AddButtonEnable();
        }

        bool ActionPerf = true;

        private void AbonCheck()
        {
            if (ImCLose)
            {
                this.Close();
            }
            else
            {
                Action action = () =>
            {
                ArrayList array = new ArrayList();
                array.Add(cbAction.SelectedValue.ToString());
                array.Add("\'" + dtpStart.Value.ToString() + "\'");
                Function_class function = new Function_class("AbonActCheck", Function_class.Function_Result.scalar, array);
                ActionPerf = function.Regtable.Rows[0][0].ToString() != "1";
            };
                Invoke(action);
            }
        }

        private void AbonCost()
        {
            if (ImCLose)
            {
                this.Close();
            }
            else
            {
                Action action = () =>
            {
                ArrayList array = new ArrayList();
                array.Add(cbGroup.SelectedValue.ToString());
                array.Add("\'" + dtpStart.Value.ToString() + "\'");
                array.Add("\'" + dtpEnd.Value.ToString() + "\'");
                array.Add(cbAction.SelectedValue.ToString());
                Function_class function = new Function_class("Abonement_Cost", Function_class.Function_Result.scalar, array);
                lblCurPrice.Text = Convert.ToString(Convert.ToInt32(function.Regtable.Rows[0][0].ToString()) / 100);
            };
                Invoke(action);
            }
        }

        private void CbAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAction.SelectedValue.ToString() != "System.Data.DataRowView")
                AbonCheck();
            if (ActionPerf)
            {
                if (dtpEnd.Enabled)
                    AbonCost();
            }
            else
                lblCurPrice.Text = "Ошибка!";
            AddButtonEnable();
        }

        private void AddButtonEnable()
        {
            if (ImCLose)
            {
                this.Close();
            }
            else
            {
                if ((ActionPerf) & (dtpEnd.Enabled) & (cbGroup.SelectedValue.ToString() != "System.Data.DataRowView"))
                    btAdd.Enabled = true;
                else
                    btAdd.Enabled = false;
            }
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            //Thread thread = new Thread(AbonAdd);
            //thread.Start();
            AbonAdd();
            (Owner as ManagerInterface).AbonementUpdate();
            this.Owner.Focus();
            this.Hide();
        }

        private void AbonAdd()
        {
            if (ImCLose)
            {
                this.Close();
            }
            else
            {
                Action action = () =>
            {
                Procedure_Class procedure = new Procedure_Class();
                ArrayList array = new ArrayList();
                array.Add(cbGroup.SelectedValue.ToString());
                array.Add(dtpStart.Value.Day.ToString() + "." + dtpStart.Value.Month.ToString() + "." + dtpStart.Value.Year.ToString());
                array.Add(dtpEnd.Value.Day.ToString() + "." + dtpEnd.Value.Month.ToString() + "." + dtpEnd.Value.Year.ToString());
                array.Add(cbAction.SelectedValue.ToString());
                array.Add(ClientID);
                procedure.procedure_Execution("Abonement_Insert", array);
            };
                Invoke(action);
            }
        }
    }
}
