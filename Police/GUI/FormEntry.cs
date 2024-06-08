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
    public partial class FormEntry : Form
    {
         policeman pm;
        Man m;
       
        PoliceSecretary ps;
        public FormEntry()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnOK1.Visible = true;
            btnOK2.Visible = false;
            btnOK3.Visible = false;
            btnOK4.Visible = false;
            txtId1.Visible = true;
            txtId2.Visible = false;
            txtId3.Visible = false;
            txtId4.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            pm = MyDb.Policeman.GetList().FirstOrDefault(x => x.IDPolice.ToString() == txtId1.Text);
            if (pm != null)
            {
                FormPolice fp = new FormPolice(pm);

                fp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("תעודת הזהות אינה מופיעה במערכת, נא הקש שוב");
                txtId1.Text = "";
            }
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnOK2.Visible = true;
            btnOK1.Visible = false;
            btnOK3.Visible = false;
            btnOK4.Visible = false;
            txtId2.Visible = true;
            txtId1.Visible = false;
            txtId3.Visible = false;
            txtId4.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btnOK3.Visible = true;
            btnOK1.Visible = false;
            btnOK2.Visible = false;
            btnOK4.Visible = false;
            txtId3.Visible = true;
            txtId1.Visible = false;
            txtId2.Visible = false;
            txtId4.Visible = false;
        }

        private void btnOK2_Click(object sender, EventArgs e)
        {
            pm = MyDb.Policeman.GetList().FirstOrDefault(x => x.IDPolice.ToString() == txtId2.Text);
            if (pm != null)
            {
                FormCommandant fc = new FormCommandant();
                fc.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("תעודת הזהות אינה מופיעה במערכת, נא הקש שוב");
                txtId2.Text = "";
            }
        }

        private void txtId1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK3_Click(object sender, EventArgs e)
        {
            m = MyDb.Man.GetList().FirstOrDefault(x => x.Id.ToString() == txtId3.Text);
            if (m != null)
            {
                FormPerson fp = new FormPerson(m);
                fp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("תעודת הזהות אינה מופיעה במערכת, נא הקש שוב");
                txtId3.Text = "";
            }
        }

        private void txtId2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ps = MyDb.PoliceSecretary.GetList().FirstOrDefault(x => x.IDPolice.ToString() == txtId4.Text);
            if (ps != null)
            {
                FormOpeningComplaint fc = new FormOpeningComplaint(ps);
                fc.Show();
                
            }
            else
            {
                MessageBox.Show("תעודת הזהות אינה מופיעה במערכת, נא הקש שוב");
                txtId4.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnOK4.Visible = true;
            btnOK3.Visible = false;
            btnOK2.Visible = false;
            btnOK1.Visible = false;
            txtId4.Visible = true;
            txtId3.Visible = false;
            txtId2.Visible = false;
            txtId1.Visible = false;
        }
    }
}
