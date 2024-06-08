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
    public partial class TrackingReport : Form
    {
        TrafficReports trf;
        FormStatus f;
        public TrackingReport(TrafficReports t)
        {

            InitializeComponent();
            f = FormStatus.update;
            label1.Text = "עדכון";
            trf = t;
            FillTxt();
            dataGridView1.DataSource = MyDb.ChangeReportStatus.GetList().Where(x => x.ReportCode == trf.Code).ToList();
        }
        public void FillTxt()
        {
            ChangeReportStatus ch = new ChangeReportStatus();
            textBox1.Text = trf.Code.ToString();
            textBox2.Text = trf.PoliceCode.ToString();
            dateTimePicker1.Value = trf.dateReport;
            textBox3.Text = trf.ReportTypesCode.ToString();
            textBox4.Text = trf.Street.ToString();
            comboBox1.Text = MyDb.City.GetList().First(x => x.CodeCity == trf.City).NameCity;
            textBox5.Text = trf.Price.ToString();
            textBox6.Text = trf.IdMen.ToString();
        }

        private void TrackingReport_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox7.Visible = true;
            dateTimePicker2.Visible = true;
            textBox9.Visible = true;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeReportStatus p11 = new ChangeReportStatus();
            p11.Code = MyDb.PolicemanInSafety.GetList().Max(x => x.SecurityCode) + 1;
            p11.ReportCode = Convert.ToInt32(textBox9.Text);
            p11.ChDate = dateTimePicker2.Value;
            p11.StatusCode = Convert.ToInt32(textBox7.Text);


            MyDb.ChangeReportStatus.AddItem(p11);
            MyDb.ChangeReportStatus.SaveChanges();
            MessageBox.Show("הוספת לו סטטוס!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillTrafficReport();

            MyDb.TrafficReports.UpdateItem(trf);
            MyDb.TrafficReports.SaveChanges();
            MessageBox.Show("השינויים נשמרו בהצלחה!");
            this.Close();
        }
        public void FillTrafficReport()
        {


            trf.Code = Convert.ToInt32(textBox1.Text);
            trf.PoliceCode = Convert.ToInt32(textBox2.Text);
            trf.dateReport = dateTimePicker1.Value;
            trf.ReportTypesCode = Convert.ToInt32(textBox3.Text);
            trf.City=MyDb.City.GetList().First(x => x.NameCity == comboBox1.SelectedItem.ToString()).CodeCity;
            trf.Street =textBox4.Text;
            trf.IdMen = Convert.ToInt32(textBox6.Text);
            trf.Price = Convert.ToInt32(textBox5.Text);



        }
    }
}
