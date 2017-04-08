using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Main frm in Application.OpenForms.OfType<Main>()) frm.Show();
            this.Close();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sfdInventory.ShowDialog();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ofdInventory.ShowDialog();
        }

        private void sfdInventory_FileOk(object sender, CancelEventArgs e)
        {
            var csv = new StringBuilder();
            csv.AppendLine("item,owned,available");

            for (var i=0;i<Items.Items.Count;i++) csv.AppendLine($"{Items.Items[i]},{Owned.Items[i]},{Available.Items[i]}");

            File.WriteAllText(sfdInventory.FileName, csv.ToString());

        }

        private void ofdInventory_FileOk(object sender, CancelEventArgs e)
        {
            Items.Items.Clear();
            Owned.Items.Clear();
            Available.Items.Clear();
            foreach (var lsplit in File.ReadAllLines(ofdInventory.FileName).Select(line => line.Trim()).Where(l => l != "item,owned,available").Select(l => l.Split(',')))
            {
                Items.Items.Add(lsplit[0]);
                Owned.Items.Add(lsplit[1]);
                Available.Items.Add(lsplit[2]);
            }
        }
    }
}
