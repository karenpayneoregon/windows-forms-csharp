using System;
using System.Diagnostics;
using System.Linq;
using System.IO;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelInteropApp.Classes
{
    public class ExcelOperations
    {
        public delegate void OnAction(string sender);
        public static event OnAction ActionHandler;

        public static string ExcelVersion()
        {
            Excel.Application application = new Excel.Application();
            return application.Version;
        }
        /// <summary>
        /// create an excel file, rename sheet1 (default sheet),
        /// create another worksheet, rename it and re-order to end.
        /// </summary>
        /// <param name="fileName">path and file name for excel file</param>
        /// <param name="firstWorkSheetName">name for default sheet</param>
        /// <param name="secondWorkSheetName">name for newly added sheet</param>
        public static (bool success, Exception exception) CreateExcelFile(string fileName, string firstWorkSheetName, string secondWorkSheetName, bool open)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                Excel.Application xlApp;
                Excel.Workbooks xlWorkBooks;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                Excel.Sheets xlWorkSheets;
                
                
                xlApp = new Excel.Application { DisplayAlerts = false };

                xlWorkBooks = xlApp.Workbooks;
                xlWorkBook = xlWorkBooks.Add();

                xlWorkSheets = xlWorkBook.Sheets;


                xlWorkSheet = (Excel.Worksheet)xlWorkSheets[1];
                xlWorkSheet.Name = firstWorkSheetName;

                ActionHandler?.Invoke("renamed first sheet");
                
                Excel.Worksheet xlNewSheet = (Excel.Worksheet)xlWorkSheets
                    .Add(xlWorkSheets[1], 
                        Type.Missing, 
                        Type.Missing, 
                        Type.Missing);

                xlNewSheet.Move(System.Reflection.Missing.Value, xlWorkSheets[xlWorkSheets.Count]);

                xlNewSheet.Name = secondWorkSheetName;

                Excel.Range xlRange1 = null;
                xlRange1 = xlWorkSheet.Range["A1"];
                xlRange1.Value = "Hello Excel";
                Marshal.FinalReleaseComObject(xlRange1);
                xlRange1 = null;

                ActionHandler?.Invoke("Done with add sheet");

                Marshal.FinalReleaseComObject(xlNewSheet);
                xlNewSheet = null;
                xlWorkBook.SaveAs(fileName);

                ActionHandler?.Invoke("Saved file");

                xlWorkBook.Close();
                xlApp.UserControl = true;
                xlApp.Quit();

                Marshal.FinalReleaseComObject(xlWorkSheets);
                xlWorkSheets = null;

                Marshal.FinalReleaseComObject(xlWorkSheet);
                xlWorkSheet = null;

                Marshal.FinalReleaseComObject(xlWorkBook);
                xlWorkBook = null;

                Marshal.FinalReleaseComObject(xlWorkBooks);
                xlWorkBooks = null;

                Marshal.FinalReleaseComObject(xlApp);
                xlApp = null;

                ActionHandler?.Invoke($"Clean-up: {(Process.GetProcesses().Any((p) => p.ProcessName.Contains("EXCEL")) ? "Released" : "Not released")}");

                if (open)
                {
                    ActionHandler?.Invoke("Opening");
                    Process.Start(fileName);
                }
                else
                {
                    ActionHandler?.Invoke("Not opening");
                }
                
                return (true, null);
            }
            catch (Exception exception)
            {
                return (false, exception);
            }
        }


    }
}

