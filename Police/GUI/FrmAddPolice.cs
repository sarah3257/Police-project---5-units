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
    public partial class FrmAddPolice : Form
    {
        policeman p1;
        FormStatus f;
        bool flag = true;

        public FrmAddPolice()
        {
            InitializeComponent();
            p1 = new policeman();
            f = FormStatus.add;
        }
        public FrmAddPolice(policeman currentPolicman)
        {
            InitializeComponent();
            f = FormStatus.update;
            button1.Text = "עדכון פרטי שוטר";
            p1 = currentPolicman;
            FillTxt();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmAddPolice_Load(object sender, EventArgs e)
        {

        }
        public void FillTxt()
        {
          
            txID.Text = p1.IDPolice.ToString();
            txtFName.Text = p1.FirsName;
            txtLName.Text = p1.FamilyName;
            txtPhon.Text = p1.PhoneNumber;
            dateTimePicker1.Value = p1.DateOfBirth;
            txtType.Text = p1.TypeOfPolice.ToString();
            dateTimePicker2.Value = p1.StartDate;
            txtPoint.Text = p1.AccumulationPoints.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (f == FormStatus.add)
            {
               
                FillPolicman();
                if (flag)

                    MyDb.Policeman.AddItem(p1);
                    MyDb.Policeman.SaveChanges();

                    MessageBox.Show("השוטר התוסף בהצלחה!");
                    this.Close();
                
            }
            if (f == FormStatus.update)
            {
               
                FillPolicman();

                MyDb.Policeman.UpdateItem(p1);
                MyDb.Policeman.SaveChanges();
                MessageBox.Show("השינויים נשמרו בהצלחה!");
                this.Close();
            }

        }
        public void FillPolicman()
        {
           
          
            p1.IDPolice = Convert.ToInt32(txID.Text);
            

            p1.FirsName = txtFName.Text;
            p1.FamilyName = txtLName.Text;
            p1.PhoneNumber = txtPhon.Text;
            p1.DateOfBirth = dateTimePicker1.Value;
            p1.TypeOfPolice = Convert.ToInt32(txtType.Text);
            p1.StartDate = dateTimePicker2.Value;
            p1.AccumulationPoints = Convert.ToInt32(txtPoint.Text);
        }

    }
}
