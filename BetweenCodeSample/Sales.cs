using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetweenCodeSample
{
    public class Sales
    {
        public string TextBook { get; set; }
        public string Subject { get; set; }
        public string Seller { get; set; }
        public string Purchaser { get; set; }
        public float purchasedPrice { get; set; }
        public string SalePrice { get; set; }
        public string Rating { get; set; }
    }

    public class FileOperations
    {
        public static (List<Sales>, List<int>) LoadSalesFromFile()
        {
            List<Sales> sales = new List<Sales>();
            List<int> InvalidLine = new List<int>();

            string filePath = @"c:\Users\demo\Task3_shop_data.csv";
            List<string> lines = File.ReadAllLines(filePath).ToList();

            for (int index = 0; index < lines.Count; index++)
            {
                var parts = lines[0].Split(',');
                // validate purchase price
                if (float.TryParse(parts[4], out var purchasePrice))
                {
                    Sales s = new Sales();
                    s.TextBook = parts[0];
                    s.Subject = parts[1];
                    s.Seller = parts[2];
                    s.Purchaser = parts[3];
                    s.purchasedPrice = purchasePrice;
                    s.SalePrice = parts[6];
                    s.Rating = parts[7];
                    sales.Add(s);
                }
                else
                {
                    // failed to convert purchase price
                    InvalidLine.Add(index);
                }
            }

            return (sales, InvalidLine);
        }
    }
}
