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
                        document.ImportDataTable(1,
                            SLConvert.ToColumnIndex("A"), table, true);

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
        }
    }
