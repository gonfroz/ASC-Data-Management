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


        private void button2_Click(object sender, EventArgs e)
        {


            var xlApp = new Excel.Application();
            try
            {
                var xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\E540\OneDrive\Documents\October Tally Sheet.xlsx");
                var xlSheet = xlWorkbook.Sheets[1];
                var xlRange = xlSheet.UsedRange;

                var topleft = xlRange.Cells[8, 3].Value2;
                // yout operation

            }
            catch (Exception ex) { MessageBox.Show("readExcel:" + ex.Message); }
            finally
            {
                KillExcel(xlApp);
                System.Threading.Thread.Sleep(100);
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }


        [DllImport("User32.dll")]
        public static extern int GetWindowThreadProcessId(IntPtr hWnd, out int ProcessId);
        private static void KillExcel(Excel.Application theApp)
        {
            int id = 0;
            IntPtr intptr = new IntPtr(theApp.Hwnd);
            System.Diagnostics.Process p = null;
            try
            {
                GetWindowThreadProcessId(intptr, out id);
                p = System.Diagnostics.Process.GetProcessById(id);
                if (p != null)
                {
                    p.Kill();
                    p.Dispose();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("KillExcel:" + ex.Message);
            }
        }



        private void Statistics_Load(object sender, EventArgs e)
        {

        }
    }
}