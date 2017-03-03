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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Statistics frm = new Statistics();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        
        public void setName(string e)
        {
            label1.Text = e;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rounds frm = new Rounds();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin frm = new Admin();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Statistics frm = new Statistics();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
