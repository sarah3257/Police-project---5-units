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
    public partial class FormSecretaryManagement : Form
    {
        public FormSecretaryManagement()
        {
            InitializeComponent();
            dataGridView1.DataSource = MyDb.PoliceSecretary.GetList();
            dataGridView1.Columns[0].HeaderText = "תץז שוטר";
            dataGridView1.Columns[1].HeaderText = "שם פרטי";
            dataGridView1.Columns[2].HeaderText = "שם משפחה";
            dataGridView1.Columns[3].HeaderText = "טלפון";
            dataGridView1.Columns[4].HeaderText = "תאריך לידה";
            dataGridView1.Columns[5].HeaderText = "תאריך תחילת עבודה";
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormSecretaryManagement_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PoliceSecretary pss = new PoliceSecretary();
            foreach (var item in MyDb.PoliceSecretary.GetList())
            {
                if (item.IDPolice == Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDPolice"].Value))
                    pss = item;
            }
            FrmAddSecretary f = new FrmAddSecretary(pss);
            f.ShowDialog();

            dataGridView1.DataSource = MyDb.PoliceSecretary.GetList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAddSecretary Add = new FrmAddSecretary();
            Add.ShowDialog();
            dataGridView1.DataSource = MyDb.PoliceSecretary.GetList();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            PoliceSecretary pps = MyDb.PoliceSecretary.GetList().FirstOrDefault(x => x.IDPolice == Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDPolice"].Value));

            DialogResult r = MessageBox.Show("הלקוח שנבחר הוא:" + pps.FirstName + " " + pps.LastName + " האם אתה בטוח שברצונך למוחקו", "מחיקת לקוח", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                MyDb.PoliceSecretary.DeleteItem(pps);
                MyDb.PoliceSecretary.SaveChanges();
                dataGridView1.DataSource = MyDb.PoliceSecretary.GetList().OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormEntry FE = new FormEntry();
            FE.Show();
            this.Hide();
        }
    }
}
