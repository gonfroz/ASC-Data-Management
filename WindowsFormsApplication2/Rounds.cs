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
            try
            {
                System.IO.FileStream srcFS;
                srcFS = new System.IO.FileStream("asc_data.csv", System.IO.FileMode.OpenOrCreate);
                System.IO.StreamReader srcSR = new System.IO.StreamReader(srcFS, System.Text.Encoding.Default);
                while (true)
                {
                    string ins = srcSR.ReadLine();
                    if (ins == null)
                    {
                        break;
                    }
                    string[] columns = ins.Split(',');

                    ListViewItem lvi = new ListViewItem(columns[0]);

                    for (int i = 1; i < columns.Count(); i++)
                    {
                        lvi.SubItems.Add(columns[i]);
                    }

                    //listView1.Items.Add(lvi);

                }
                srcSR.Close();

            }
            catch (Exception errorMsg)
            {
                MessageBox.Show(errorMsg.Message, "Error reading a file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void numericUpDown15_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var worker = Manager.MainInstance.workerName;
            if (MessageBox.Show("Are you sure you want to record this data?", "Confirm",MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)== DialogResult.OK)
            {
                //save data
                //var header ="Time,Worker Name,Commons,Commuter,Media,Hive,Breakout,Great Room,Mail,Hallways,Other,2nd Floor,Colab,Prayer,Activities,Game,Hallway,Other,Total\n";
                var time = DateTime.Now.Minute;
                var total = commonGrounds.Value+commuter.Value+mediaRoom.Value+hive.Value+breakout.Value+greatRoom.Value+mailCenter.Value+hallways1.Value+other1.Value+colabs.Value+prayer.Value+activities.Value+gameRoom.Value+hallways2.Value+other2.Value;
                var dataLine = $"{time},{worker},{commonGrounds.Value},{commuter.Value},{mediaRoom.Value},{hive.Value},{breakout.Value},{greatRoom.Value},{mailCenter.Value},{hallways1.Value},{other1.Value},0,{colabs.Value},{prayer.Value},{activities.Value},{gameRoom.Value},{hallways2.Value},{other2.Value},{total}\n";
                System.IO.File.AppendAllText("asc_data.csv", dataLine);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
