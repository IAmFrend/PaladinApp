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

namespace PaladinApp
{
    public partial class Autorization_Form : Form
    {
        public Autorization_Form()
        {
            InitializeComponent();
        }

        private void BtEnter_Click(object sender, EventArgs e)
        {
            //Проверка
            switch (tbUserLogin.Text == "")
            {
                case true:
                    tbUserLogin.BackColor = Color.Red;
                    break;
                case false:
                    switch (tbUserPassword.Text == "")
                    {
                        case true:
                            tbUserPassword.BackColor = Color.Red;
                            tbUserLogin.BackColor = Color.White;
                            break;
                        case false:
                            //Авторизация
                            tbUserPassword.BackColor = Color.White;
                            ArrayList AutorizData = new ArrayList();
                            AutorizData.Add("\'"+tbUserLogin.Text+"\'");
                            AutorizData.Add("\'"+tbUserPassword.Text+"\'");
                            tbUserLogin.Clear();
                            tbUserPassword.Clear();
                            switch (rbManager.Checked)
                            {
                                case true:
                                    Function_class AutorizManager = new Function_class("Autorization_Manager", Function_class.Function_Result.scalar, AutorizData);
                                    switch (AutorizManager.Regtable.Rows[0][0].ToString() == "")
                                    {
                                        case true:
                                            MessageBox.Show("Указанный пользователь не найден или является заблокированным");
                                            break;
                                        case false:
                                            Program.intID = AutorizManager.Regtable.Rows[0][0].ToString();
                                            ManagerInterface managerInterface = new ManagerInterface();
                                            managerInterface.Owner = this;
                                            managerInterface.Show();
                                            this.Hide();
                                            break;
                                    }
                                    break;
                                case false:
                                    Function_class AutorizTrainer = new Function_class("Autorization_Trainer", Function_class.Function_Result.scalar, AutorizData);
                                    switch (AutorizTrainer.Regtable.Rows[0][0].ToString() == "")
                                    {
                                        case true:
                                            MessageBox.Show("Указанный пользователь не найден или является заблокированным");
                                            break;
                                        case false:
                                            Program.intID = AutorizTrainer.Regtable.Rows[0][0].ToString();
                                            TrainerInterface trainerInterface = new TrainerInterface();
                                            trainerInterface.Owner = this;
                                            trainerInterface.Show();
                                            this.Hide();
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
            break;
            }
        }

        private void BtLeave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Back_Color(object sender, EventArgs e)
        {
            if (sender is TextBox) (sender as TextBox).BackColor = Color.White;
        }

        private void RbTrainer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTrainer.Checked) btReg.Enabled = true; else btReg.Enabled = false;
        }

        private void BtReg_Click(object sender, EventArgs e)
        {
            RegSend regSend = new RegSend();
            regSend.Owner = this;
            regSend.Show();
            this.Hide();
        }

        private void Autorization_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (MessageBox.Show("Вы действительно хотите закрыть приложение?", "PaladinApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case (DialogResult.Yes):
                    Application.ExitThread();
                    break;
            }
        }
    }
}
