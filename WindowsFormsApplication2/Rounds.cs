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

        //read time and name from last round 
        private void Form1_Load(object sender, EventArgs e)
        {
            // get info about last round
            try
            {
                string[] lines = System.IO.File.ReadAllLines(@"asc_data.csv");

                var columnQuery =
                from line in lines
                let elements = line.Split(',')
                select Convert.ToString(elements[1]);  
                var results = columnQuery.ToList();

                worker.Text = results.Last().ToString();

                columnQuery =
                from line in lines
                let elements = line.Split(',')
                select Convert.ToString(elements[0]);
                results = columnQuery.ToList();

                roundTime.Text = results.Last().ToString();
            }
            catch (Exception errorMsg)
            {
                MessageBox.Show(errorMsg.Message, "Error reading a file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //double check
        private void button1_Click(object sender, EventArgs e)
        {
            var worker = Manager.MainInstance.workerName;
            if (MessageBox.Show("Are you sure you want to record this data?", "Confirm",MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)== DialogResult.OK)
            {
                //save data
                //var header ="Time,Worker Name,Commons,Commuter,Media,Hive,Breakout,Great Room,Mail,Hallways,Other,2nd Floor,Colab,Prayer,Activities,Game,Hallway,Other,Total\n";
                var time = DateTime.Now.ToShortTimeString();
                var total = commonGrounds.Value+commuter.Value+mediaRoom.Value+hive.Value+breakout.Value+greatRoom.Value+mailCenter.Value+hallways1.Value+other1.Value+colabs.Value+prayer.Value+activities.Value+gameRoom.Value+hallways2.Value+other2.Value;
                var dataLine = $"{time},{worker},{commonGrounds.Value},{commuter.Value},{mediaRoom.Value},{hive.Value},{breakout.Value},{greatRoom.Value},{mailCenter.Value},{hallways1.Value},{other1.Value},0,{colabs.Value},{prayer.Value},{activities.Value},{gameRoom.Value},{hallways2.Value},{other2.Value},{total}\n";
                System.IO.File.AppendAllText("asc_data.csv", dataLine);
            }
        }

        //exit
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
