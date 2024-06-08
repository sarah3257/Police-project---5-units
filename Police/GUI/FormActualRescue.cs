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
    public partial class FormActualRescue : Form
    {
        OpeningComplaints op2;
        ActualRescue AR;
        

        public FormActualRescue(OpeningComplaints OP)
        {
            op2 = OP;
            InitializeComponent();
            textBox2.Text = op2.Code.ToString();
          AR= new ActualRescue();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormActualRescue_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillActual();

            MyDb.ActualRescue.AddItem(AR);
            MyDb.ActualRescue.SaveChanges();

            MessageBox.Show("התלונה התוספה למערכת החילוצים בהצלחה!");
            this.Close();
        }
        public void FillActual()
        {

            AR.Code = Convert.ToInt32(textBox1.Text);
            AR.BeginningTime = Convert.ToDateTime(textBox3.Text);
            AR.RescuersTypeCode = Convert.ToInt32(textBox4.Text);
            AR.Remarks = textBox5.Text;
          
        }
    }
}
