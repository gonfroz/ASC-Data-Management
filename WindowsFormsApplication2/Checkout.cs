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
            //find checked buttons
            var game = games.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            var cons = console.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);

            //names of buttons
            var gameName ="";
            var consoleName = "";

            //in case no button was selected (button is null)
            try
            {
                gameName = cons.Text;
            }
            catch (NullReferenceException)
            {
            }

            try
            {
                consoleName = cons.Text;
            }
            catch (NullReferenceException)
            {
            }
                    
            var other = ControllersNum.Value;
            if (hdmi.Checked) { other++; }

            listView1.Items.Add(new ListViewItem(new[] { NameBox.Text, IDBox.Text, consoleName, gameName, other.ToString(), Manager.MainInstance.workerName }));

            //reset stuff
            NameBox.Clear();
            IDBox.Clear();
            ControllersNum.Value = 0;
            hdmi.Checked = false;

            foreach (Control ctrl in games.Controls)
            {
                (ctrl as RadioButton).Checked = false;
            }

            foreach (Control ctrl in console.Controls)
            {
                (ctrl as RadioButton).Checked = false;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].Remove();
        }
    }
}
