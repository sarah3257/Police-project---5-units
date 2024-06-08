using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Police.GUI
{
    public partial class FormCommandant : Form
    {
        public FormCommandant()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPoliceManagement fc = new FormPoliceManagement();
            fc.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSecretaryManagement fc = new FormSecretaryManagement();
            fc.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormEntry FE = new FormEntry();
            FE.Show();
            this.Hide();
        }
    }
}
