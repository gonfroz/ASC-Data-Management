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
        private string _workerName;
        public string workerName
        {
            get { return _workerName; }
            set
            {
                _workerName = value;
                updateWorker(_workerName);
            }
        }

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

        delegate void updateLabelText(string text);
        private void updateWorker(string e)
        {
            if (label1.InvokeRequired)
            {
                // this is worker thread
                updateLabelText del = updateWorker;
                label1.Invoke(del, e);
            }
            else
            {
                // this is UI thread
                label1.Text = e;
            }
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
            Inventory frm = new Inventory();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Checkout frm = new Checkout();
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
