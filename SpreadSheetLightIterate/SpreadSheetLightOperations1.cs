using System;
using System.Collections.Generic;
using SpreadsheetLight;

namespace SpreadSheetLightIterate
{
    public class SpreadSheetLightOperations1
    {
        public static void Test()
        {
            int i, j, index;
            double fValue;
            Random rand = new Random();
            string[] stringdata = new string[] { "Apple", "Banana", "Cherry", "Durian", "Elderberry" };

            using (SLDocument sl = new SLDocument("Customers.xlsx"))
            {
                //sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, "LINQ");


                Dictionary<int, SLCell> cell;
                Dictionary<int, Dictionary<int, SLCell>> cells = sl.GetCells();
               

                List<SLRstType> richtextlist = sl.GetSharedStrings();
                index = -1;
                for (i = 0; i < richtextlist.Count; ++i)
                {
                    // You'd use richtextlist[i].ToPlainString() to get the whole thing
                    // but we "know" the rich text is just plain text.

                    var item = richtextlist[i];
                    var localItem = richtextlist[i].GetText();
                    if (localItem.Equals("Frankenversand"))
                    {
                        index = i;
                        break;
                    }
                }

                if (index > -1)
                {
                    //sl.SetCellValue("L4", "Apples at:");
                    //i = 5; // start at row 5
                    //foreach (var kvp in cells.Where(apple => apple.Value.DataType == CellValues.SharedString && Convert.ToInt32(apple.Value.NumericValue) == index))
                    //{
                    //    sl.SetCellValue(i, 12, SLConvert.ToCellReference(kvp.Key.RowIndex, kvp.Key.ColumnIndex));
                    //    ++i;
                    //}
                }
                else
                {
                    //sl.SetCellValue("L4", "There are no apples :(");
                }


            }

            Console.WriteLine("End of program");
            Console.ReadLine();
        }
    }
}

