using System;
using SpreadsheetLight;

namespace ConvertColumnToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ConvertCasing(args[0], args[1], Convert.ToInt32(args[2]));
                Console.WriteLine("Done");
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(e);
                Console.ResetColor();
        
            }

            Console.WriteLine("Press any key to close");
            Console.ReadLine();
        }

        /// <summary>
        /// Convert cell values in specific column to uppercase
        /// </summary>
        /// <param name="fileName">file name to work on</param>
        /// <param name="sheetName">Sheet name to work on</param>
        /// <param name="columnIndex">Column index in sheet to convert to upper case</param>
        public static void ConvertCasing(string fileName, string sheetName, int columnIndex)
        {
            using (var document = new SLDocument(fileName, sheetName))
            {

                var stats = document.GetWorksheetStatistics();

                for (int rowIndex = 1; rowIndex < stats.EndRowIndex; rowIndex++)
                {

                    document.SetCellValue(
                        SLConvert.ToCellReference(rowIndex, columnIndex), 
                        document.GetCellValueAsString(rowIndex, columnIndex).ToUpper());

                }

                document.Save();

            }
        }
    }
}
