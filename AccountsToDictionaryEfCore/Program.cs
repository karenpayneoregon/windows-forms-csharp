using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using AccountsToDictionaryEfCore.Data;
using MoreLinq;

namespace AccountsToDictionaryEfCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ToDictionary";
            //Version1();
            More();
            //Console.ReadLine();
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
    }
}
