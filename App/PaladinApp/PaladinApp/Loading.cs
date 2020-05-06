using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaladinApp
{
    public partial class Loading : Form
    {
        int Loader = new int();
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            LoadTimer.Enabled = true;
            Loader = 0;
        }

        private void LoadTimer_Tick(object sender, EventArgs e)
        {
            switch (Loader == 200)
            {
                case (true):
                    LoadTimer.Stop();
                    Autorization_Form autorization_Form = new Autorization_Form();
                    autorization_Form.Show();
                    this.Hide();
                    break;
                case (false):
                    Loader += 1;
                    break;
            }
                
        }
    }
}
