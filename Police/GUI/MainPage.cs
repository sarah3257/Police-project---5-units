﻿using System;
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
    public partial class MainPage : Form

    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FormEntry fc = new FormEntry();
            fc.Show();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
