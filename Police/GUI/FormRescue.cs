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
    public partial class FormRescue : Form
    {
        ActualRescue rescue;
        public FormRescue()
        {
            InitializeComponent();
            dataGridView1.DataSource = MyDb.ActualRescue.GetList().ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "קוד תלונה";
            dataGridView1.Columns[2].HeaderText = "התחלת ביצוע";
            dataGridView1.Columns[3].HeaderText = "סוף ביצוע";
            dataGridView1.Columns[4].HeaderText = "סוג החילוץ";
            dataGridView1.Columns[5].HeaderText = "הערות";
            dataGridView1.Columns[6].HeaderText = "?האם הסתיים";
            dataGridView2.DataSource = MyDb.OpeningComplaints.GetList().Where(x => x.IsRescue == true).ToList();
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].HeaderText = "ת.ז מזכירה";
            dataGridView2.Columns[2].HeaderText = " תאריך פתיחת תלונה ";
            dataGridView2.Columns[3].HeaderText = " שעת המקרה ";
            dataGridView2.Columns[4].HeaderText = " רחוב ";
            dataGridView2.Columns[5].HeaderText = " עיר ";
            dataGridView2.Columns[6].HeaderText = " מספר בית ";
            dataGridView2.Columns[7].HeaderText = " אירוע בטחוני ";
            dataGridView2.Columns[8].HeaderText = " אירוע חילוץ ";
            dataGridView2.Columns[9].HeaderText = " ת.ז פותח תלונה ";
            dataGridView3.DataSource=MyDb.ActualRescue.GetList().Where(x => x.IsTheOperationComplete == false).ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "קוד תלונה";
            dataGridView1.Columns[2].HeaderText = "התחלת ביצוע";
            dataGridView1.Columns[3].HeaderText = "סוף ביצוע";
            dataGridView1.Columns[4].HeaderText = "סוג החילוץ";
            dataGridView1.Columns[5].HeaderText = "הערות";
            dataGridView1.Columns[6].HeaderText = "?האם הסתיים";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormRescue_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpeningComplaints OP = new OpeningComplaints();
            foreach (var item in MyDb.OpeningComplaints.GetList())
            {
                if (item.Code == Convert.ToInt32(dataGridView2.CurrentRow.Cells["Code"].Value))
                    OP = item;
            }
            FormActualRescue fp = new FormActualRescue(OP);
            fp.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = true;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rescue = MyDb.ActualRescue.GetList().First(x => x.Code == Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value));
            rescue.IsTheOperationComplete = true;
            MyDb.ActualRescue.UpdateItem(rescue);
            MyDb.ActualRescue.SaveChanges();
            MessageBox.Show("התיק נסגר!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormEntry FE = new FormEntry();
            FE.Show();
        }
    }
}
