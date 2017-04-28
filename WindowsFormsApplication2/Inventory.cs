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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            try
            {
                System.IO.FileStream srcFS;
                srcFS = new System.IO.FileStream("asc_inventory.csv", System.IO.FileMode.OpenOrCreate);
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

            for (var i=0;i<Items.Items.Count;i++) csv.AppendLine($"{Items.Items[i]},{Owned.Items[i]}");

            File.WriteAllText(sfdInventory.FileName, csv.ToString());

        }

        private void ofdInventory_FileOk(object sender, CancelEventArgs e)
        {
            Items.Items.Clear();
            Owned.Items.Clear();
            foreach (var lsplit in File.ReadAllLines(ofdInventory.FileName).Select(line => line.Trim()).Where(l => l != "item,owned,available").Select(l => l.Split(',')))
            {
                Items.Items.Add(lsplit[0]);
                Owned.Items.Add(lsplit[1]);
            }
        }
    }
}
