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
    public partial class FrmReportPayment : Form
    {
        Man m1;
        ChangeReportStatus change1;
        TrafficReports t;
        public FrmReportPayment(Man m)
        {
            this.m1 = m;
            InitializeComponent();
            dataGridView1.DataSource = MyDb.TrafficReports.GetList().Where(x => x.IdMen == m1.Id).ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "ת.ז שוטר";
            dataGridView1.Columns[2].HeaderText = "תאריך קבלת דוח";
            dataGridView1.Columns[3].HeaderText = "סוג הדוח";
            dataGridView1.Columns[4].HeaderText = "עיר";
            dataGridView1.Columns[5].HeaderText = "רחוב";
            dataGridView1.Columns[6].HeaderText = "ת.ז מקבל בדוח";
            dataGridView1.Columns[7].HeaderText = "מחיר";
            change1 = new ChangeReportStatus();
            t = new TrafficReports();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            change1.Code = MyDb.ChangeReportStatus.GetList().OrderBy(x=>x.Code).Last().Code + 1;
            change1.ReportCode = MyDb.TrafficReports.GetList().First(x => x.Code == Convert.ToInt32(dataGridView1.CurrentRow.Cells["Code"].Value)).Code;
            change1.ChDate = DateTime.Now.Date;
            change1.StatusCode = 111;
            MyDb.ChangeReportStatus.AddItem(change1);
            MyDb.ChangeReportStatus.SaveChanges();
           
           
            MessageBox.Show("התשלום התקבל בהצלחה !");
            this.Close();
        }

        private void FrmReportPayment_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
