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
    public partial class FrmFollowReport : Form
    {
        TrafficReports trf;
        FormStatus f;

     
        public FrmFollowReport(TrafficReports t)
        {
           
            InitializeComponent();
            f = FormStatus.update;
            label1.Text = "עדכון";
            trf = t;
            FillTxt();
            dgvStatus.DataSource = MyDb.ChangeReportStatus.GetList().Where(x => x.ReportCode == trf.Code).ToList();

        }
        public FrmFollowReport()
        {

        }

        private void FrmFollowReport_Load(object sender, EventArgs e)
        {

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
