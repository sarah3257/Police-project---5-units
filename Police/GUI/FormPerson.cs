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
    public partial class FormPerson : Form
    {
        Man m1;
        
    
        public FormPerson(Man m)
        {
           
            InitializeComponent();
            this.m1 = m;
            label1.Text= "שלום ל" + m1.FirstName + " " + m1.LastName;
          
        }

        private void FormPerson_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            request r = new request(m1);
            r.Show();
           ;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView1.DataSource = MyDb.TrafficReports.GetList().Where(x => x.IdMen == m1.Id).ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "קוד שוטר";
            dataGridView1.Columns[2].HeaderText = "תאריך דוח";
            dataGridView1.Columns[3].HeaderText = "סוג הדוח";
            dataGridView1.Columns[4].HeaderText = "עיר";
            dataGridView1.Columns[5].HeaderText = "רחוב";
            dataGridView1.Columns[6].HeaderText = "ת.ז מקבל דוח";
            dataGridView1.Columns[7].HeaderText = "מחיר";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            FrmReportPayment fr = new FrmReportPayment( m1);
            fr.Show();
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormEntry FE = new FormEntry();
            FE.Show();
            this.Hide();
        }
    }
}
