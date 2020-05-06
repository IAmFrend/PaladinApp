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
    public partial class ThemeForm : Form
    {
        //Добавить = false, изменить = true
        public bool Mode = false;
        private string ModeString = "";
        public ThemeForm()
        {
            InitializeComponent();
        }

        private void ThemeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Action action = () =>
            {
                if (Mode)
                    ModeString = "изменения";
                else
                    ModeString = "добавления";
                if (this.ContainsFocus)
                    switch (MessageBox.Show(String.Format("Вы действительно хотите выйти на основную страницу без {0} акции?", ModeString), "PaladinApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        case (DialogResult.Yes):
                            this.Owner.Focus();
                            this.Hide();
                            break;
                    }
            };
            Invoke(action);
        }

        private void ThemeForm_Load(object sender, EventArgs e)
        {
            Thread loading = new Thread(ThemeLoad);
            loading.Start();
        }

        private void ThemeLoad()
        {
            Action action = () =>
            {
                if (Mode)
                {
                    this.Text = "Изменение тематики";
                    lblTheme.Text = "Изменение тематики";
                    btInsertUpdate.Text = "Изменить";
                    Table_Class theme = new Table_Class(String.Format("SELECT [ThemeName],[ThemeAbout] FROM [dbo].[Themes] WHERE [LogicDelete]=0 and [ID_Theme] = {0}",(Owner as TrainerInterface).IDTheme));
                    tbThemeName.Text = theme.table.Rows[0][0].ToString();
                    tbThemeAbout.Text = theme.table.Rows[0][1].ToString();
                }
                else
                {
                    this.Text = "Добавление тематики";
                    lblTheme.Text = "Добавление тематики";
                    btInsertUpdate.Text = "Добавить";
                }
            };
            Invoke(action);
        }

        private void TbTheme_TextChanged(object sender, EventArgs e)
        {
            if ((tbThemeName.Text.Length > 0) & (tbThemeAbout.Text.Length > 0))
                btInsertUpdate.Enabled = true;
            else
                btInsertUpdate.Enabled = false;
        }

        private void BtInsertUpdate_Click(object sender, EventArgs e)
        {
            TmInsertUpdate();
            (this.Owner as TrainerInterface).ThemeUpdate();
            this.Owner.Focus();
            this.Hide();
        }
        
        private void TmInsertUpdate()
        {
            ArrayList array = new ArrayList();
            if (Mode)
                array.Add((Owner as TrainerInterface).IDTheme);
            array.Add(tbThemeName.Text);
            array.Add(tbThemeAbout.Text);
            Procedure_Class themeInUp = new Procedure_Class();
            string prName = "";
            if (Mode)
                prName = "Theme_Update";
            else
                prName = "Theme_Insert";
            themeInUp.procedure_Execution(prName, array);
        }
    }
}
