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
    public partial class request : Form
    {
        Man m2;
        ChangeReportStatus change;
        TrafficReports t;
       
        public request(Man m1)
        {
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

            this.m2 = m1;
            labelName.Text= "הגשת בקשה של " + m2.FirstName + " " + m2.LastName;
            change = new ChangeReportStatus();
            t = new TrafficReports();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            change.Code = MyDb.ChangeReportStatus.GetList().Last().Code + 1;
            change.ReportCode = MyDb.TrafficReports.GetList().First(x => x.Code == Convert.ToInt32(dataGridView1.CurrentRow.Cells["Code"].Value)).Code;
            change.ChDate = DateTime.Now.Date;
            change.StatusCode = 333;
            MyDb.ChangeReportStatus.AddItem(change);
            MyDb.ChangeReportStatus.SaveChanges();
            MessageBox.Show("בקשת שיפוט נכנסה בהצלחה נא לאתם תקבלו פניה לטלפון האישי !");
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            change.Code = MyDb.ChangeReportStatus.GetList().Last().Code + 1;
            change.ReportCode = MyDb.TrafficReports.GetList().First(x => x.Code == Convert.ToInt32(dataGridView1.CurrentRow.Cells["Code"].Value)).Code;
            change.ChDate = DateTime.Now.Date;
            change.StatusCode = 222;
            MyDb.ChangeReportStatus.AddItem(change);
            MyDb.ChangeReportStatus.SaveChanges();
            MessageBox.Show("בקשת ביטול נכנסה בהצלחה ,אתם תקבלו פניה לטלפון האישי !");
            this.Close();
        }

        private void request_Load(object sender, EventArgs e)
        {

        }
    }
}
