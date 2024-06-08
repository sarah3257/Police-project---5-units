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
    public partial class FormAddReport : Form
    {
        TrafficReports trf;
        FormStatus f;
        public FormAddReport()
        {
            InitializeComponent();
            trf = new TrafficReports();
            f = FormStatus.add;
        }
        public FormAddReport(TrafficReports t)
        {
            InitializeComponent();
            f = FormStatus.update;
            button1.Text = "עדכון פרטי לקוח";
            trf = t;
           
            
            FillTxt();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormAddReport_Load(object sender, EventArgs e)
        {

        }
        public void FillTxt()
        {
            ChangeReportStatus ch = new ChangeReportStatus();
            textBox1.Text = trf.Code.ToString();
            textBox2.Text= trf.PoliceCode.ToString();
            dateTimePicker1.Value = trf.dateReport;
            textBox3.Text = trf.ReportTypesCode.ToString();
            textBox4.Text = trf.Street;
            comboBox1.Text = MyDb.City.GetList().First(x => x.CodeCity == trf.City).NameCity;
            textBox5.Text = trf.Price.ToString();
            textBox6.Text = trf.IdMen.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (f == FormStatus.add)
            {

                FillReport();

                MyDb.TrafficReports.AddItem(trf);
                MyDb.TrafficReports.SaveChanges();

                MessageBox.Show("הדוח התוסף בהצלחה!");
                this.Close();

            }
        }
        public void FillReport()
        {

            trf.Code = Convert.ToInt32(textBox1.Text);
            trf.PoliceCode = Convert.ToInt32(textBox2.Text);
            trf.dateReport = dateTimePicker1.Value;
            trf.ReportTypesCode = Convert.ToInt32(textBox3.Text);
            trf.Street = textBox4.Text;
            trf.City = MyDb.City.GetList().First(x => x.NameCity == comboBox1.SelectedItem.ToString()).CodeCity;
            trf.Price = Convert.ToInt32(textBox5.Text);
            trf.IdMen = Convert.ToInt32(textBox6.Text);
        }
    }
}
