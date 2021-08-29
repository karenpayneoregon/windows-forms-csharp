using System;
using System.Collections.Generic;
using System.Linq;
using AccountsToDictionaryEfCore.Data;

namespace AccountsToDictionaryEfCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ToDictionary";
            
            Version1();
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
    }
}
