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
    public partial class FormSecurity : Form
    {
      
        public FormSecurity()
        {
            InitializeComponent();
            dataGridView1.DataSource = MyDb.ActualSecuritry.GetList().ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "קוד תלונה";
            dataGridView1.Columns[2].HeaderText = "קוד סוג בטחון";
            dataGridView1.Columns[3].HeaderText = "תחילת ביצוע";
            dataGridView1.Columns[4].HeaderText = "סוף ביצוע";
            dataGridView1.Columns[5].HeaderText = "הערות";
            dataGridView1.Columns[6].HeaderText = "?האם הסתיים";

            dataGridView2.DataSource = MyDb.OpeningComplaints.GetList().Where(x => x.IsInSecurity == true).ToList();
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].HeaderText = "קוד מזכירה";
            dataGridView2.Columns[2].HeaderText = "תאריך תלונה";
            dataGridView2.Columns[3].HeaderText = "שעת תלונה";
            dataGridView2.Columns[4].HeaderText = "רחוב";
            dataGridView2.Columns[5].HeaderText = "עיר";
            dataGridView2.Columns[6].HeaderText = "מספר בית";
            dataGridView2.Columns[7].HeaderText = "האם אירוע בטחוני";
            dataGridView2.Columns[8].HeaderText = "האם אירוע חילוץ";
            dataGridView2.Columns[9].HeaderText = "ת.ז מגיש תלונה";
            List<OpeningComplaints> lst = new List<OpeningComplaints>();
            foreach (var item in lst)
            {
               if(MyDb.ActualSecuritry.GetList().FirstOrDefault(x=>x.Code==item.Secretarycode)==null)
                {
                    //לחפש את השורה שוב בתוך הDG 
                    //ולצבוע את השורה הזאת
                }
            }
        }

        private void FormSecurity_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ActualSecuritry tr = new ActualSecuritry();
            foreach (var item in MyDb.ActualSecuritry.GetList())
            {
                if (item.Code == Convert.ToInt32(dataGridView1.CurrentRow.Cells["Code"].Value))
                    tr = item;
            }
            FrmPeopleAreHurtingcs fp = new FrmPeopleAreHurtingcs(tr);
            fp.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormEntry FE = new FormEntry();
            FE.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
