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
                var time = DateTime.Now.Minute < 30 ? $"{DateTime.Now:H:00}" : $"{DateTime.Now:H:30}";
                var total = numericUpDown12.Value+numericUpDown11.Value+numericUpDown10.Value+numericUpDown6.Value+numericUpDown13.Value+numericUpDown14.Value+numericUpDown15.Value+numericUpDown5.Value+numericUpDown9.Value+numericUpDown1.Value+numericUpDown2.Value+numericUpDown3.Value+numericUpDown8.Value+numericUpDown7.Value+numericUpDown4.Value;
                var dataLine = $"{time},{worker},{numericUpDown12.Value},{numericUpDown11.Value},{numericUpDown10.Value},{numericUpDown6.Value},{numericUpDown13.Value},{numericUpDown14.Value},{numericUpDown15.Value},{numericUpDown5.Value},{numericUpDown9.Value},0,{numericUpDown1.Value},{numericUpDown2.Value},{numericUpDown3.Value},{numericUpDown8.Value},{numericUpDown7.Value},{numericUpDown4.Value},{total}\n";
                System.IO.File.AppendAllText("asc_data.csv", dataLine);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
