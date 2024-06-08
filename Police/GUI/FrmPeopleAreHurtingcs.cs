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
    public partial class FrmPeopleAreHurtingcs : Form
    {
        
        
        FormStatus f;
        ActualSecuritry ss2;
        PeopleAreHurting ph;

        public FrmPeopleAreHurtingcs(ActualSecuritry ss)
        {
            f = FormStatus.update;
            ss2 = ss;
            InitializeComponent();
            dataGridView1.DataSource = MyDb.PeopleAreHurting.GetList().Where(x => x.ActualSecurityCode == ss2.Code).ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "קוד מצב בטחון";
            dataGridView1.Columns[2].HeaderText = "ת.ז פושע"; 
            dataGridView1.Columns[0].Visible = false;
            ph = MyDb.PeopleAreHurting.GetList().First(x => x.ActualSecurityCode == ss2.Code);
            dataGridView3.DataSource = MyDb.PolicemanInSafety.GetList().Where(x => x.SecurityCode == ss2.Code).ToList();
            dataGridView3.Columns[0].Visible = false;
            dataGridView3.Columns[1].HeaderText = "קוד מצב בטחון";
            dataGridView3.Columns[2].HeaderText = "ת.ז שוטר";
            dataGridView2.DataSource = MyDb.SecurityPortfolioStatus.GetList().Where(x => x.Code == ph.PortfolioStatus).ToList();
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].HeaderText = "מצב סטטוס הפוגע";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = MyDb.SecurityPortfolioStatus.GetList().Where(x => x.Code == Convert.ToInt32(dataGridView1.CurrentRow.Cells["PortfolioStatus"].Value)).ToList();
            dataGridView2.Visible = true;
            label2.Visible = true;
        }

        private void FrmPeopleAreHurtingcs_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            button5.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            textBox1.Visible = true;
            textBox1.Text = (MyDb.PolicemanInSafety.GetList().OrderBy(x => x.SecurityCode).Last().SecurityCode + 1).ToString();
            textBox2.Visible = true;
            textBox3.Visible = true;
            button2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PeopleAreHurting p=new PeopleAreHurting();
            p.Code = Convert.ToInt32(textBox4.Text);
            p.ActualSecurityCode = Convert.ToInt32(textBox5.Text);
            p.IDMen = textBox6.Text;
            p.PortfolioStatus = Convert.ToInt32(textBox7.Text);

            MyDb.PeopleAreHurting.AddItem(p);
            MyDb.PeopleAreHurting.SaveChanges();
            MessageBox.Show("הפושע הצטרף!");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PolicemanInSafety p11 = new PolicemanInSafety();
            p11.Code = Convert.ToInt32(textBox1.Text);
            p11.SecurityCode = Convert.ToInt32(textBox2.Text);
            p11.PoliceCode = Convert.ToInt32(textBox3.Text);
            

            MyDb.PolicemanInSafety.AddItem(p11);
            MyDb.PolicemanInSafety.SaveChanges();
            MessageBox.Show("תודה רבה לך שוטר יקר!");
            this.Close();
        }
    }
}
