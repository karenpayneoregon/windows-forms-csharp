using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using AccountsToDictionaryEfCore.Data;
using MoreLinq;

namespace AccountsToDictionaryEfCore
{
    public class Item
    {
        public string Value { get; set; }
        public int Index { get; set; }
        public override string ToString() => $"{Index,2:D2} {Value}";

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ToDictionary";
            //Version1();
            //More();
            //Interesting();
            Console.ReadLine();
        }


        private static void Version1()
        {
            using var context = new Context();

            Dictionary<string, string> results = context
                .Account
                .OrderBy(account => account.AccountName)
                .ToDictionary(_ => _.AccountName, _ => _.Location);
            

            foreach (var result in results)
            {
                Console.WriteLine($"{result.Key}, {result.Value}");
            }
        }

        private static void More()
        {
            using var context = new Context();
            var accounts = context.Account.ToList();
            var dt = accounts.ToDataTable();

            foreach (DataRow row in dt.Rows)
            {
                Debug.WriteLine(string.Join(",", row.ItemArray));
            }
        }

        private static void Interesting()
        {

            var months = Enumerable.Range(1, 12)
                .Select((index) => DateTimeFormatInfo.CurrentInfo.GetMonthName(index))
                .ToList();

            months.Select((value, index) 
                => new Item { Value = value, Index = index })
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
