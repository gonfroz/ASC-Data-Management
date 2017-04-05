using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApplication2
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Main)
                {
                    frm.Show();
                }
            }
            this.Close();
        }

        private void MostPopVal_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var xlApp = new Excel.Application();
            var xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\sceleris\Source\Repos\ASC-Data-Management\WindowsFormsApplication2\bin\Debug\asc_data.xlsx");
            var xlSheet = xlWorkbook.Sheets[1];
            var xlRange = xlSheet.UsedRange;

            var topleft = xlRange.Cells[8, 3].Value2;
            


            GC.Collect();
            GC.WaitForPendingFinalizers();
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlSheet);

            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }
    }
}
