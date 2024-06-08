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
    public partial class FormTrackingReports : Form
    {
        public FormTrackingReports()
        {
            InitializeComponent();
            dataGridView1.DataSource = MyDb.TrafficReports.GetList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "ת.ז שוטר";
            dataGridView1.Columns[2].HeaderText = "תאריך הדוח";
            dataGridView1.Columns[3].HeaderText = "סוג הדוח";
            dataGridView1.Columns[4].HeaderText = "עיר";
            dataGridView1.Columns[5].HeaderText = "רחוב";
            dataGridView1.Columns[6].HeaderText = "ת.ז מקבל הדוח";
            dataGridView1.Columns[7].HeaderText = "מחיר דוח";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormTrackingReports_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrafficReports tr = new TrafficReports();
            foreach (var item in MyDb.TrafficReports.GetList())
            {
                if (item.Code == Convert.ToInt32(dataGridView1.CurrentRow.Cells["Code"].Value))
                    tr = item;
            }
            FormAddReport f = new FormAddReport(tr);
            f.ShowDialog();

            dataGridView1.DataSource = MyDb.TrafficReports.GetList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            TrafficReports tr = new TrafficReports();
            foreach (var item in MyDb.TrafficReports.GetList())
            {
                if (item.Code == Convert.ToInt32(dataGridView1.CurrentRow.Cells["Code"].Value))
                    tr = item;
            }
            TrackingReport fp = new TrackingReport(tr);
            fp.Show();

            dataGridView1.DataSource = MyDb.TrafficReports.GetList();
        }
    }
}
