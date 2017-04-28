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
            var game = gamescheck.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            var cons = console.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);

            //names of buttons
            var gameName ="";
            var consoleName = "";

            //in case no button was selected (button is null)
            try
            {
                gameName = game.Text;
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
                    
            var controllerNum = ControllersNum.Value;
            var hdmiNum = 0;
            if(hdmi.Checked) { hdmiNum++; }
            var chargerNum = 0;
            if (chargers.Checked) { chargerNum++; }

            //add checkout info to list view
            listView1.Items.Add(new ListViewItem(new[] { NameBox.Text, IDBox.Text, gameName, controllerNum.ToString(), hdmiNum.ToString(), chargerNum.ToString(), Manager.MainInstance.workerName}));
            
            //append to csv
            System.IO.File.AppendAllText("asc_checkout_list.csv", $"{NameBox.Text}, {IDBox.Text}, {gameName}, {controllerNum.ToString()}, {hdmiNum.ToString()}, {chargerNum.ToString()}, {Manager.MainInstance.workerName}\n");
       
            //reset stuff
            NameBox.Clear();
            IDBox.Clear();
            ControllersNum.Value = 0;
            hdmi.Checked = false;
            chargers.Checked = false;

            foreach (Control ctrl in gamescheck.Controls)
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

            if (MessageBox.Show("Are you sure you want to return these items?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {

                try
                {

                    var lines = new List<string>();
                    var file = new System.IO.StreamReader("asc_checkout_list.csv");
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                    file.Close();

                    lines.RemoveAt(listView1.SelectedIndices[0]);

                    System.IO.File.WriteAllLines("asc_checkout_list.csv", lines);

                    //remove from listView1
                    listView1.SelectedItems[0].Remove();

                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("No item selected to remove.", "Select an Item",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            try
            {
                System.IO.FileStream srcFS;
                srcFS = new System.IO.FileStream("asc_checkout_list.csv", System.IO.FileMode.OpenOrCreate);
                System.IO.StreamReader srcSR = new System.IO.StreamReader(srcFS, System.Text.Encoding.Default);
                while (true)
                {
                    string ins = srcSR.ReadLine();
                    if (ins == null){
                        break;
                    }
                    string[] columns = ins.Split(',');

                    ListViewItem lvi = new ListViewItem(columns[0]);

                    for (int i = 1; i < columns.Count(); i++)
                    {
                        lvi.SubItems.Add(columns[i]);
                    }

                    listView1.Items.Add(lvi);

                }
                srcSR.Close();
                    
            }
            catch (Exception errorMsg)
            {
                MessageBox.Show(errorMsg.Message, "Error reading a file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
