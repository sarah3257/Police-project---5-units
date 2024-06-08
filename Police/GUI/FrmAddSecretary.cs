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
    public partial class FrmAddSecretary : Form
    {
        PoliceSecretary pos;
        FormStatus f;
        public FrmAddSecretary(PoliceSecretary pss)
        {
            InitializeComponent();
            f = FormStatus.update;
            button1.Text = "עדכון פרטי לקוח";
            pos = pss;
            FillTxt();
        }
        public FrmAddSecretary()
        {
            InitializeComponent();
            pos = new PoliceSecretary();
            f = FormStatus.add;
        }

        private void FrmAddSecretary_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (f == FormStatus.add)
            {

                FillPolicman();

                MyDb.PoliceSecretary.AddItem(pos);
                MyDb.PoliceSecretary.SaveChanges();

                MessageBox.Show("המזכירה נכנסה בהצלחה!");
                this.Close();

            }
            if (f == FormStatus.update)
            {

                FillPolicman();

                MyDb.PoliceSecretary.UpdateItem(pos);
                MyDb.PoliceSecretary.SaveChanges();
                MessageBox.Show("השינויים נשמרו בהצלחה!");
                this.Close();
            }
        }
        public void FillPolicman()
        {

            pos.IDPolice = Convert.ToInt32(txtID.Text);
            pos.FirstName = txtFName.Text;
            pos.LastName = txtLName.Text;
            pos.Phon = txtPhon.Text;
            pos.DateOfBirth = dateTimePicker1.Value;
            pos.DateStartOfWork = dateTimePicker1.Value;
           
        }
        public void FillTxt()
        {

            txtID.Text = pos.IDPolice.ToString();
            txtFName.Text = pos.FirstName;
            txtLName.Text = pos.LastName;
            txtPhon.Text = pos.Phon;
            dateTimePicker1.Value = pos.DateOfBirth; 
            dateTimePicker2.Value = pos.DateStartOfWork;
           
        }


    }
}
