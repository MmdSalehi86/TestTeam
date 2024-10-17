using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Form1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// this is main method. project started from main
        /// </summary>
        [STAThread]
        static void Main()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage excel = new ExcelPackage())
            {
                excel.Workbook.Worksheets.Add("WorkSheet1");
                excel.SaveAs("TestEpplus1.xlsx");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Game_Form1());
            Console.WriteLine("hi msz");
            Console.WriteLine("by msz");

            Console.ReadLine();
        }
    }
}
