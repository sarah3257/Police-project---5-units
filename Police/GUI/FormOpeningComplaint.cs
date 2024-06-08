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

    public partial class FormOpeningComplaint : Form
    {
        OpeningComplaints p;
        PoliceSecretary ps2;

        public FormOpeningComplaint()
        {
            InitializeComponent();
            p = new OpeningComplaints();
        }
        public FormOpeningComplaint(PoliceSecretary ps)
        {
            InitializeComponent();
            this.ps2 = ps;
            label8.Text = "ברוכה הבאה למזכירה " + ps2.FirstName + ps2.LastName;
            p = new OpeningComplaints();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormOpeningComplaint_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            fillComplaints();
            MyDb.OpeningComplaints.AddItem(p);
            MyDb.OpeningComplaints.SaveChanges();

            MessageBox.Show("התלונה נכנסה למערכת");
            this.Close();
        }

        public void fillComplaints()
        {

            p.Secretarycode = ps2.IDPolice;
            p.dateComplaints = dateTimePicker1.Value;
            p.hourComplaints = dateTimePicker2.Value;
            p.Street = txtStreet.Text;
            p.City = MyDb.City.GetList().First(x => x.NameCity == cmbcity.SelectedItem.ToString()).CodeCity;
            p.HouseNumber = Convert.ToInt32(txtHouseName.Text);
            p.IdMen = Convert.ToInt32(txtId.Text);
            p.IsInSecurity = checkBox1.Checked;
            p.IsRescue = checkBox2.Checked;
            p.Code = MyDb.OpeningComplaints.GetList().Last().Code + 1;
            p.IsRescue = checkBox2.Checked;
            p.IsInSecurity = checkBox1.Checked;
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmbcity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
