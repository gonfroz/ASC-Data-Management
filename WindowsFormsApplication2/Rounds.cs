﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Rounds : Form
    {
        public Rounds()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void numericUpDown15_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mainForm = new Main();
            var worker = mainForm.workerName;
            if (MessageBox.Show("Are you sure you want to record this data?", "Confirm",MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)== DialogResult.OK)
            {
                //save data

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
