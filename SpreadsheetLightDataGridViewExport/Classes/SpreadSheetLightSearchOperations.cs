using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpreadsheetLight;

namespace SpreadsheetLightDataGridViewExport.Classes
{
    public class SpreadSheetLightSearchOperations
    {
        public static (List<FoundItem> items, Exception exception) Find(string fileName, string sheetName, string search)
        {
            var foundList = new List<FoundItem>();

            try
            {
                using (var document = new SLDocument(fileName, sheetName))
                {

                    var stats = document.GetWorksheetStatistics();

                    for (int columnIndex = 1; columnIndex < stats.EndColumnIndex +1; columnIndex++)
                    {

                        for (int rowIndex = 1; rowIndex < stats.EndRowIndex + 1; rowIndex++)
                        {
                            if (document.GetCellValueAsString(rowIndex, columnIndex).Equals(search, StringComparison.OrdinalIgnoreCase))
                            {
                                foundList.Add(new FoundItem() {RowIndex = rowIndex, ColumnIndex = columnIndex, Column = SLConvert.ToColumnName(columnIndex)});
                            }
                        }
                    }
                    
                }

                return (foundList, null);

            }
            catch (Exception exception)
            {
                return (foundList, exception);
            }

        }
    }

    public class FoundItem
    {
        public int RowIndex { get; set; }
        public string Column { get; set; }
        public int ColumnIndex { get; set; }
        public override string ToString()
        {
            return $"[{Column}:{RowIndex}]";
        }
    }
}
