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
    public partial class RegSend : Form
    {
        public RegSend()
        {
            InitializeComponent();
            cbCategory.SelectedIndex = 0;
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void RegSend_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (MessageBox.Show("Вы действительно хотите закрыть приложение?", "PaladinApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case (DialogResult.Yes):
                    Application.ExitThread();
                    break;
            }
        }

        private void Tb_TextChanged(object sender, EventArgs e)
        {
            if ((tbName.Text.Length > 0) & (tbFirstname.Text.Length > 0) & (tbPatronymic.Text.Length > 0) & (tbLogin.Text.Length > 0))
                btSend.Enabled = true;
            else
                btSend.Enabled = false;
        }

        private void BtSend_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(MailSend);
            thread.Start();
        }

        private void MailSend()
        {
            Action action = () =>
            {
                string text = string.Format("Заявка на регистрацию тренера по имени {0} {1} {2} с тренерской категорией \"{3}\". Адрес для ответа: {4}", tbFirstname.Text, tbName.Text, tbPatronymic.Text, cbCategory.Text, tbLogin.Text);
                Message_Class message = new Message_Class("smtp.yandex.ru", "PaladinWorkMail", "1qaz!QAZ", "PaladinWorkMail@yandex.ru", Program.strMail, "Заявка на регистрацию", text, "");
                MessageBox.Show(message.ex, "PaladinApp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            };
            Invoke(action);
        }
    }
}
