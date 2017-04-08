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

    static double ColumnAverage(IEnumerable<string> strs, int column)  
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
  
        // Perform aggregate calculations Average, Max, and  
        // Min on the column specified by column.  
        double average = results.Average();

        return average;

            //int max = results.Max();  

            //int min = results.Min();  
  
          //Console.WriteLine("Exam #{0}: Average:{1:##.##} High Score:{2} Low Score:{3}",  
          //       column, average, max, min);  
    } 

        private void Statistics_Load(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"asc_data.csv");

            // Compute Averages  
            CommonGroundsNum.Text = ColumnAverage(lines, 2).ToString();
            CommuterLoungeNum.Text = ColumnAverage(lines, 3).ToString();
            MediaRoomNum.Text = ColumnAverage(lines, 4).ToString();
            HiveNum.Text = ColumnAverage(lines, 5).ToString();
            BreakoutNum.Text = ColumnAverage(lines, 6).ToString();
            GreatRoomNum.Text = ColumnAverage(lines, 7).ToString();
            MailNum.Text = ColumnAverage(lines, 8).ToString();
            Halls1Num.Text = ColumnAverage(lines, 9).ToString();
            Other1Num.Text = ColumnAverage(lines, 10).ToString();
            CollabNum.Text = ColumnAverage(lines, 12).ToString();
            PrayerNum.Text = ColumnAverage(lines, 13).ToString();
            ActivitiesNum.Text = ColumnAverage(lines, 14).ToString();
            GameRoomNum.Text = ColumnAverage(lines, 15).ToString();
            Halls2Num.Text = ColumnAverage(lines, 16).ToString();
            Other2Num.Text = ColumnAverage(lines, 17).ToString();
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