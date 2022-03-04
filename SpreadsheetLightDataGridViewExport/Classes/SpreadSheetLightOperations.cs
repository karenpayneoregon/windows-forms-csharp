using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;
using SpreadsheetLight;

namespace SpreadsheetLightDataGridViewExport.Classes
{
    public class SpreadSheetLightOperations
    {
        /// <summary>
        /// Find duplicate string values and return their row index
        /// </summary>
        /// <param name="fileName">Excel file to read</param>
        /// <param name="sheetName">WorkSheet to work with</param>
        /// <param name="search">Text to find</param>
        /// <param name="columnIndex">Column index to search</param>
        /// <returns>
        /// Named Value Tuple
        /// items      - list of indices
        /// exception  - reports run time exceptions, 99 percent of the time it's from open the file outside of the
        ///              application while working on it in code.
        /// </returns>
        public static (List<int> items, Exception exception) FindDuplicates(string fileName, string sheetName, string search, int columnIndex)
        {
            var indicesList = new List<int>();

            try
            {
                using (var document = new SLDocument(fileName, sheetName))
                {
                    
                    var stats = document.GetWorksheetStatistics();
                    var test = stats.EndRowIndex;
                    for (int index = 1; index < stats.EndRowIndex + 1; index++)
                    {
                        if (document.GetCellValueAsString(index, columnIndex).EqualsIgnoreCase(search))
                        {
                            indicesList.Add(index);
                        }
                    }
                }

                return (indicesList, null);
                
            }
            catch (Exception exception)
            {
                return (indicesList, exception);
            }
           
        }

        public static bool SheetExists(SLDocument document, string sheetName) =>
            document.GetSheetNames(false).Any((name) => name.ToLower() == sheetName.ToLower());

        public static void Example(string fileName, string sheetName)
        {
            using (var document = new SLDocument(fileName, sheetName))
            {
                var stats = document.GetWorksheetStatistics();
                for (int rowIndex = 1; rowIndex < stats.EndRowIndex + 1; rowIndex++)
                {
                    for (int columnIndex = 1; columnIndex < stats.EndColumnIndex +1; columnIndex++)
                    {
                        Console.WriteLine($"{SLConvert.ToCellReference(rowIndex, columnIndex)} = {document.GetCellValueAsString(rowIndex, columnIndex)}");
                    }
                }
            }
        }
        public static void ExampleDataTable(string fileName, string sheetName)
        {
            using (var doc = new SLDocument(fileName, sheetName))
            {
                var stats = doc.GetWorksheetStatistics();
                for (int rowIndex = 2; rowIndex < stats.EndRowIndex + 1; rowIndex++)
                {
                    Console.WriteLine($"{doc.GetCellValueAsString(rowIndex, 1)}, {doc.GetCellValueAsString(rowIndex, 2)}, {doc.GetCellValueAsDateTime(rowIndex, 9)}");

                }
            }
        }
        public static void Example1(string fileName, string sheetName)
        {
            using (var document = new SLDocument(fileName, sheetName))
            {

                Dictionary<int, Dictionary<int, SLCell>> cells = document.GetCells();
                var results= cells.Select(x => x.Value).ToList();

       

            }
        }


    }
}
