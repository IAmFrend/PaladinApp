using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Data.Sql;
using System.Data.SqlClient;
using PaladinApp;
using System.Collections;
using System.Threading;

namespace PaladinApp
{
    public partial class TrainerForm : Form
    {
        string TrainerID = "";
        public TrainerForm()
        {
            InitializeComponent();
        }

        private void TrainerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.ContainsFocus)
                switch (MessageBox.Show("Вы действительно хотите выйти на основную страницу?", "PaladinApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case (DialogResult.Yes):
                        this.Owner.Focus();
                        this.Hide();
                        break;
                }
        }

        private void TrainerForm_Load(object sender, EventArgs e)
        {
            Thread TrLoad = new Thread(TrainerLoad);
            TrLoad.Start();
            cbCategory.SelectedIndex = 0;
        }

        private void TrainerLoad()
        {
            Action action = () =>
            {
                Table_Class tableTrainer = new Table_Class("SELECT [ID_Trainer] as \'Табельный номер\',[TrainerFirstName] as \'Имя\',[TrainerSecondName] as \'Фамилия\',[TrainerLastName] as \'Отчество\',[TrainerCategory] as \'Категория\',[TrainerLogin] as \'Логин\' FROM [dbo].[Trainers] WHERE [LogicDelete] = 0 AND [ID_Trainer]>0");
                dgTrainers.DataSource = tableTrainer.table;
            };
            Invoke(action);
        }
        string Password = "";
        private void TrainerFill()
        {
            Action action = () =>
            {
                if (TrainerID != "")
                {
                    Table_Class tableTrainer = new Table_Class(String.Format("SELECT [TrainerFirstName],[TrainerSecondName],[TrainerLastName],[TrainerCategory],[TrainerLogin], [TrainerPassword] FROM [dbo].[Trainers] WHERE [LogicDelete] = 0 AND [ID_Trainer]={0}", TrainerID));
                    tbTrainerFirstname.Text = tableTrainer.table.Rows[0][0].ToString();
                    tbTrainerName.Text = tableTrainer.table.Rows[0][1].ToString();
                    tbTrainerPatronymic.Text = tableTrainer.table.Rows[0][2].ToString();
                    switch (tableTrainer.table.Rows[0][3].ToString())
                    {
                        case ("старший"):
                            cbCategory.SelectedIndex = 0;
                            break;
                        case ("1"):
                            cbCategory.SelectedIndex = 1;
                            break;
                        case ("2"):
                            cbCategory.SelectedIndex = 2;
                            break;
                        case ("3"):
                            cbCategory.SelectedIndex = 3;
                            break;
                        case ("помощник"):
                            cbCategory.SelectedIndex = 4;
                            break;
                    }
                    tbTrainerLogin.Text = tableTrainer.table.Rows[0][4].ToString();
                    Password = tableTrainer.table.Rows[0][5].ToString();
                }
            };
            Invoke(action);
        }

        private void DgTrainers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Action action = () =>
            {
                try
                {
                    Table_Class FTest = new Table_Class(String.Format("SELECT [ID_Filial] FROM [dbo].[Filials] WHERE [ID_Filial] = {0}", dgTrainers.Rows[dgTrainers.SelectedCells[0].RowIndex].Cells[0].Value.ToString()));
                }
                catch
                {
                    TrainerID  = "";
                }
                finally
                {
                    TrainerID = dgTrainers.Rows[dgTrainers.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                    TrainerFill();
                }
            };
            Invoke(action);
        }

        private void BtInsert_Click(object sender, EventArgs e)
        {
            Thread trInsert = new Thread(TRInsert);
            trInsert.Start();
        }

        private void TRInsert()
        {
            Action action = () =>
            {
                if (tbTrainerFirstname.Text.Length == 0)
                    tbTrainerFirstname.BackColor = Color.Red;
                else
                {
                    tbTrainerFirstname.BackColor = Color.White;
                    if (tbTrainerName.Text.Length == 0)
                        tbTrainerName.BackColor = Color.Red;
                    else
                    {
                        tbTrainerName.BackColor = Color.White;
                        if (tbTrainerPatronymic.Text.Length == 0)
                            tbTrainerPatronymic.BackColor = Color.Red;
                        else
                        {
                            tbTrainerPatronymic.BackColor = Color.White;
                            if (tbTrainerLogin.Text.Length == 0)
                                tbTrainerLogin.BackColor = Color.Red;
                            else
                            {
                                tbTrainerLogin.BackColor = Color.White;
                                if (tbTrainerPassword.Text.Length == 0)
                                    tbTrainerPassword.BackColor = Color.Red;
                                else
                                {
                                    tbTrainerPassword.BackColor = Color.White;
                                    if (tbTrainerPassword.Text != tbTrainerConfirm.Text)
                                    {
                                        tbTrainerPassword.BackColor = Color.Red;
                                        tbTrainerConfirm.BackColor = Color.Red;
                                    }
                                    else
                                    {
                                        tbTrainerPassword.BackColor = Color.White;
                                        tbTrainerConfirm.BackColor = Color.White;
                                        ArrayList array = new ArrayList();
                                        array.Add(tbTrainerFirstname.Text);
                                        array.Add(tbTrainerName.Text);
                                        array.Add(tbTrainerPatronymic.Text);
                                        switch (cbCategory.SelectedIndex)
                                        {
                                            case (0):
                                                array.Add("старший");
                                                break;
                                            case (1):
                                                array.Add("1");
                                                break;
                                            case (2):
                                                array.Add("2");
                                                break;
                                            case (3):
                                                array.Add("3");
                                                break;
                                            case (4):
                                                array.Add("помощник");
                                                break;
                                        }
                                        array.Add(tbTrainerLogin.Text);
                                        array.Add(tbTrainerPassword.Text);
                                        Procedure_Class trInsertproc = new Procedure_Class();
                                        trInsertproc.procedure_Execution("Trainer_Insert", array);
                                        TrainerLoad();
                                    }
                                }
                            }
                        }
                    }
                }
            };
            Invoke(action);
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            Thread trDelete = new Thread(TRDelete);
            trDelete.Start();
        }

       private void TRDelete()
        {
            Action action = () =>
            {
                if (TrainerID != "")
                {
                    switch (MessageBox.Show("Вы действительно хотите удалить учётную запись этого тренера?", "PaladinApp", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        case (DialogResult.Yes):
                            ArrayList array = new ArrayList();
                            array.Add(TrainerID);
                            Procedure_Class themeDelete = new Procedure_Class();
                            themeDelete.procedure_Execution("WorkPlace_LogicDelete", array);
                            TrainerLoad();
                            break;
                    }
                }
                else
                    MessageBox.Show("Выберите тренера", "PaladinApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            Invoke(action);

        }
    }
}
