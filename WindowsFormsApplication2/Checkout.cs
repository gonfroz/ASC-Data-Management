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
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var game = games.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            var cons = console.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            var other = ControllersNum.Value;
            if (checkBox1.Checked) { other++; }

            listView1.Items.Add(new ListViewItem(new[] {NameBox.Text, IDBox.Text, cons.Text, game.Text, other.ToString()}));
            NameBox.Clear();
            IDBox.Clear();

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
