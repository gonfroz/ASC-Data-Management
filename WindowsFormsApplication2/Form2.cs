using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter your name.", "Enter Name",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                Form4 frm = new Form4();
                frm.Show();
                this.Hide();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter your name.", "Enter Name",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter your name.", "Enter Name",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                Form3 frm = new Form3();
                frm.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter your name.", "Enter Name",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                Form4 frm = new Form4();
                frm.Show();
                this.Hide();
            }
        }

    }
}
