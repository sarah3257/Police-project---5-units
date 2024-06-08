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
    public partial class FormPoliceManagement : Form
    {
        public FormPoliceManagement()
        {
            InitializeComponent();
            dgvpolice.DataSource = MyDb.Policeman.GetList();
            dgvpolice.Columns[0].Visible = false;
            dgvpolice.Columns[1].HeaderText = "שם פרטי";
            dgvpolice.Columns[2].HeaderText = "שם משפחה";
            dgvpolice.Columns[3].HeaderText = "מספר טלפון";
            dgvpolice.Columns[4].HeaderText = "תאריך לידה";
            dgvpolice.Columns[5].HeaderText = "סוג שוטר";
            dgvpolice.Columns[6].HeaderText = "תאריך ת.עבודה";
            dgvpolice.Columns[7].HeaderText = "נקודות ";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvpolice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAddPolice Add = new FrmAddPolice();
            Add.ShowDialog();
            dgvpolice.DataSource = MyDb.Policeman.GetList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            policeman p = new policeman();
            foreach (var item in MyDb.Policeman.GetList())
            {
                if (item.IDPolice == Convert.ToInt32(dgvpolice.CurrentRow.Cells["IDPolice"].Value))
                    p = item;
            }
            FrmAddPolice f = new FrmAddPolice(p);
            f.ShowDialog();

            dgvpolice.DataSource = MyDb.Policeman.GetList();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            policeman p1 = MyDb.Policeman.GetList().FirstOrDefault(x => x.IDPolice == Convert.ToInt32(dgvpolice.CurrentRow.Cells["IDPolice"].Value));

            DialogResult r = MessageBox.Show("השוטר שנבחר הוא:" + p1.FirsName + " " + p1.FamilyName + " האם אתה בטוח שברצונך למוחקו", "מחיקת שוטר", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                MyDb.Policeman.DeleteItem(p1);
                MyDb.Policeman.SaveChanges();
                dgvpolice.DataSource = MyDb.Policeman.GetList().OrderBy(x => x.FamilyName).ThenBy(x => x.FirsName).ToList();

            }
        }

        private void FormPoliceManagement_Load(object sender, EventArgs e)
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
