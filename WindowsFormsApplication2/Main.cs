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

        private void StatsButton_Click(object sender, EventArgs e)
        {
            Statistics frm = new Statistics();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        
        public void setName(string e)
        {
            NameBox.Text = e;
        }

        private void RoundsButton_Click(object sender, EventArgs e)
        {
            Rounds frm = new Rounds();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            Inventory frm = new Inventory();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            Checkout frm = new Checkout();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
