using System;
using System.Collections.Generic;
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
    }
}
