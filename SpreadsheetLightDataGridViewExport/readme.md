# About

Basic code sample to import a DataTable in a DataGridView to Excel using [SpreadsheetLight](https://www.nuget.org/packages/SpreadsheetLight/) free library via a NuGet package.

### See also

[Common operations](https://github.com/karenpayneoregon/ExcelUnleashed/blob/master/SpreadSheetLightLibrary/Examples.cs)

### Base code

```csharp
using System;
using System.Data;
using System.IO;
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

                using (var doc = new SLDocument())
                {
                    // style for date columns
                    SLStyle dateStyle = doc.CreateStyle();
                    dateStyle.FormatCode = "mm-dd-yyyy";

                    /*
                     * import DataTable without column names,
                     * change last param to true for column names
                     */
                    doc.ImportDataTable(1, 
                        SLConvert.ToColumnIndex("A"), table, true);

                    // apply date style to DateTime columns
                    doc.SetColumnStyle(4, dateStyle);
                    doc.SetColumnStyle(5, dateStyle);
                    doc.SetColumnStyle(6, dateStyle);

                    // Auto format date columns
                    doc.AutoFitColumn(4);
                    doc.AutoFitColumn(5);
                    doc.AutoFitColumn(6);

                    // rename default sheet, sheet1
                    doc.RenameWorksheet(
                        SLDocument.DefaultFirstSheetName, 
                        SheetName);

                    // save to file
                    doc.SaveAs(FileName);

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
```