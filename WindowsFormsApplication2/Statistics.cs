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
            var id = 0;
            var intptr = new IntPtr(theApp.Hwnd);
            try
            {
                GetWindowThreadProcessId(intptr, out id);
                System.Diagnostics.Process p = System.Diagnostics.Process.GetProcessById(id);
                p.Kill();
                p.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("KillExcel:" + ex.Message);
            }
        }

        // This function computes the average and finds the max and min
        static double ColumnStats(IEnumerable<string> strs, int column, string mode)  
        {  
 
            // Variable columnQuery is an IEnumerable<int>.  
            // The following query performs two steps:  
            // 1) use Split to break each row (a string) into an array of strings,   
            // 2) convert the element to an int and select it.  
            var columnQuery =  
                from line in strs  
                let elements = line.Split(',')  
                select Convert.ToInt32(elements[column]);  
  
            // Execute the query and cache the results to improve  
            // performance. This is helpful only with very large files.  
            var results = columnQuery.ToList();  
  
            // Perform calculations Average, Max, and Min on column.  
            if (mode == "min")
                return results.Min();
            if (mode == "max")
                return results.Max();
            else
                return results.Average();
 
        } 

        private void Statistics_Load(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"asc_data.csv");

            // Compute Averages  
            CommonGroundsNum.Text = ColumnStats(lines, 2, "average").ToString();
            CommuterLoungeNum.Text = ColumnStats(lines, 3, "average").ToString();
            MediaRoomNum.Text = ColumnStats(lines, 4, "average").ToString();
            HiveNum.Text = ColumnStats(lines, 5, "average").ToString();
            BreakoutNum.Text = ColumnStats(lines, 6, "average").ToString();
            GreatRoomNum.Text = ColumnStats(lines, 7, "average").ToString();
            MailNum.Text = ColumnStats(lines, 8, "average").ToString();
            Halls1Num.Text = ColumnStats(lines, 9, "average").ToString();
            Other1Num.Text = ColumnStats(lines, 10, "average").ToString();
            CollabNum.Text = ColumnStats(lines, 12, "average").ToString();
            PrayerNum.Text = ColumnStats(lines, 13, "average").ToString();
            ActivitiesNum.Text = ColumnStats(lines, 14, "average").ToString();
            GameRoomNum.Text = ColumnStats(lines, 15, "average").ToString();
            Halls2Num.Text = ColumnStats(lines, 16, "average").ToString();
            Other2Num.Text = ColumnStats(lines, 17, "average").ToString();


            foreach (string line in lines)
            {
                if(ColumnStats(lines, 17, "max").ToString() == line)
                {

                }
            }
            

        }

        private void duration_Click(object sender, EventArgs e)
        {
            if (duration.Text == "Daily")
            {
                duration.Text = "Weekly";
            }
            else
            {
                duration.Text = "Daily";
            }
        }
    }
}