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
    public partial class WorkActionsForm : Form
    {
        public WorkActionsForm()
        {
            InitializeComponent();
        }

        private void DtpStart_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStart.Value < DateTime.Now)
            {
                dtpStart.Value = DateTime.Now;
            }
            dtpEnd.Value = dtpStart.Value.AddDays(1);
            dtpEnd.Enabled = true;
        }

        private void BtEndless_Click(object sender, EventArgs e)
        {
            dtpEnd.Value = new DateTime(3000, 12, 31);
        }

        private void DtpEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpEnd.Value < dtpStart.Value)
            {
                dtpEnd.Value = dtpStart.Value.AddDays(1);
            }
            AddButtonEnable();
        }

        private void TbProperties_TextChanged(object sender, EventArgs e)
        {
            AddButtonEnable();
        }

        private void AddButtonEnable()
        {
            if ((tbProperties.Text.Length != 0) & (dtpEnd.Enabled))
                btAdd.Enabled = true;
            else
                btAdd.Enabled = false;
        }
               
        private void BtAdd_Click(object sender, EventArgs e)
        {
            ActAdd();
            (Owner as ManagerInterface).ActionFill();
            this.Owner.Focus();
            this.Hide();
        }

        private void WorkActionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.ContainsFocus)
                switch (MessageBox.Show("Вы действительно хотите выйти на основную страницу без добавления акции?", "PaladinApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case (DialogResult.Yes):
                        (Owner as ManagerInterface).ActionFill();
                        this.Owner.Focus();
                        this.Hide();
                        break;
                }
        }

        private void ActAdd()
        {
            Action action = () =>
            {
                Procedure_Class procedure = new Procedure_Class();
                ArrayList array = new ArrayList();
                array.Add(nudDiscont.Value.ToString());
                array.Add(tbProperties.Text);
                array.Add(dtpStart.Value.Day.ToString() + "." + dtpStart.Value.Month.ToString() + "." + dtpStart.Value.Year.ToString());
                array.Add(dtpEnd.Value.Day.ToString() + "." + dtpEnd.Value.Month.ToString() + "." + dtpEnd.Value.Year.ToString());
                procedure.procedure_Execution("Action_Insert", array);
            };
            Invoke(action);
        }
    }
}
