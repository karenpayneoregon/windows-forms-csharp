using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using SpreadsheetLight;
using static System.DateTime;

namespace SpreadsheetLightDataGridViewExport.Classes
{

    public class ExcelOperations
    {
        /// <summary>
        /// File name to write DataTable to
        /// </summary>
        public static string FileName { get; set; }
        public static string SheetName = $"Orders_{Now.Month}_{Now.Year}";

        public static string Find(string fileName ,string sheetName, string search)
        {
            using (var document = new SLDocument(fileName,sheetName))
            {
                var stats = document.GetWorksheetStatistics();
                var test = stats.EndRowIndex;
                for (int index = 1; index < stats.EndRowIndex +1; index++)
                {
                    if (document.GetCellValueAsString(index, 1).EqualsIgnoreCase(search))
                    {
                        var result = document.GetCellValueAsString(index, 2);
                        return result;
                    }
                }
            }

            return null;
            
        }
        public static List<int> FindDuplicates(string fileName, string sheetName, string search)
        {
            List<int> indicesList = new List<int>();
            
            using (var document = new SLDocument(fileName, sheetName))
            {
                var stats = document.GetWorksheetStatistics();
                var test = stats.EndRowIndex;
                for (int index = 1; index < stats.EndRowIndex + 1; index++)
                {
                    if (document.GetCellValueAsString(index, 1).EqualsIgnoreCase(search))
                    {
                        indicesList.Add(index);

                    }
                }
            }

            return indicesList;
        }

        /// <summary>
        /// Here we use create a new file although with minor modifications,
        /// an existing file/sheet can be used and append to the existing sheet
        /// or with an existing file add a new sheet.
        /// </summary>
        /// <param name="table">DataTable from DataGridView</param>
        /// <remarks>
        /// Common error is having <see cref="FileName"/> open when performing operations
        /// below
        /// </remarks>
        public static (bool success, Exception exception) Export(DataTable table)
        {
            try
            {
                if (File.Exists(FileName))
                {
                    File.Delete(FileName);
                }

                using (var document = new SLDocument())
                {
                    // style for date columns
                    SLStyle dateStyle = document.CreateStyle();
                    dateStyle.FormatCode = "mm-dd-yyyy";

                    /*
                     * import DataTable without column names,
                     * change last param to true for column names
                     */
                    document.ImportDataTable(1, SLConvert.ToColumnIndex("A"), table, true);

                    // apply date style to DateTime columns
                    document.SetColumnStyle(4, dateStyle);
                    document.SetColumnStyle(5, dateStyle);
                    document.SetColumnStyle(6, dateStyle);

                    // Auto format date columns
                    document.AutoFitColumn(4);
                    document.AutoFitColumn(5);
                    document.AutoFitColumn(6);

                    // rename default sheet, sheet1
                    document.RenameWorksheet(
                        SLDocument.DefaultFirstSheetName,
                        SheetName);

                    // save to file
                    document.SaveAs(FileName);

                    return (true, null);
                }
            }
            catch (Exception exception)
            {
                return (false, exception);
            }
        }

        /// <summary>
        /// https://stackoverflow.com/questions/70378875/best-way-to-export-large-datatable-into-excel-in-c/70379151#70379151
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static (bool success, Exception exception) ExportDataTable(DataTable table)
        {
            try
            {

                using (var document = new SLDocument())
                {
                    document.ImportDataTable(1, SLConvert.ToColumnIndex("A"), table, true);
                    document.SaveAs(FileName);

                    return (true, null);
                }
            }
            catch (Exception exception)
            {
                return (false, exception);
            }
        }
    }

    public class SpreadSheetLightDemos
    {
        public static (bool success, Exception exception) Export(DataTable table, string fileName, string sheetName)
        {
            try
            {
                using (var document = new SLDocument())
                {
                    document.ImportDataTable(1, SLConvert.ToColumnIndex("A"), table, true);
                    document.RenameWorksheet(SLDocument.DefaultFirstSheetName, sheetName);
                    document.SaveAs(fileName);

                    return (true, null);
                }
            }
            catch (Exception exception)
            {
                return (false, exception);
            }
        }

        /// <summary>
        /// Open file to specific sheet
        /// </summary>
        /// <param name="fileName">Existing Excel file name</param>
        /// <param name="sheetName">Existing Sheet name in file</param>
        public static void Work(string fileName, string sheetName)
        {
            using (var document = new SLDocument(fileName, sheetName))
            {
                // some code do write to the cells of selected sheet
            }
        }
    }
}
