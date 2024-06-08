using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Police.BLL;

namespace Police.GUI
{
    public partial class FormPolice : Form
    {
        policeman p;
        public FormPolice(policeman pp)
        {
            InitializeComponent();
            this.p = pp;
            label1.Text = "שלום ל" + p.FirsName + " " + p.FamilyName;
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            FormRescue fr = new FormRescue();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSecurity fs = new FormSecurity();
            fs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormTraffic ft = new FormTraffic();
            ft.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormOpeningComplaint foc = new FormOpeningComplaint();
            foc.Show();
        }

        private void FormPolice_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormEntry FE = new FormEntry();
            FE.Show();
            this.Hide();
        }
    }
}
