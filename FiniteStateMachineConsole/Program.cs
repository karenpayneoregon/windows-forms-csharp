using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace FiniteStateMachineConsole
{
    /// <summary>
    /// Finite-state machine (FSA) example
    /// 
    /// Scenario: Get a list
    ///    Given: with a list with value
    ///      and: has matching Records
    ///     When: Record is detected read data until matching Record
    ///     Then: continue until all data has been read
    /// 
    /// https://en.wikipedia.org/wiki/Finite-state_machine
    /// </summary>
    class Program
    {
        static async Task Main(string[] args)
        {
            await Task.Delay(0);
        }

        private static void Secrets()
        {
            //https://makolyte.com/how-to-add-user-secrets-in-a-dotnetcore-console-app/
            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .AddUserSecrets<Program>()
                .Build();

            var conString = config.GetConnectionString("DefaultDB");

            Debug.WriteLine(conString);
        }

        private static void Dump()
        {
            /*
             * Works with a text file too
             */
            List<string> linesList = new()
            {
                "(Record)",
                "John",
                "111",
                "John's address",
                "(Record)",

                "(Record)",
                "Mary",
                "222",
                "Mary's address",
                "(Record)",

                "(Record)",
                "Bill",
                "333",
                "Bill's address",
            };

            foreach (var line in Reader(linesList))
            {
                Debug.WriteLine($"'{line}'");
            }


            List<string> linesList1 = new()
            {
                "John",
                "111",
                "John's address",

                "Mary",
                "222",
                "Mary's address",

                "Bill",
                "333",
                "Bill's address",
            };


            ViewAllContacts();
        }

        private static void ViewLong()
        {
            var fileName = "LongView.txt";

            var linesList = File.ReadAllLines(fileName).ToList();
            foreach (var line in ViewReader(linesList))
            {

                Debug.WriteLine($"'{line}'");

            }
        }

        private static void ViewAllContacts()
        {
            var fileName = "TextFile1.txt";
            if (File.Exists(fileName))
            {
                var contents = File.ReadAllLines(fileName);
                if (contents.Length % 3 == 0)
                {
                    var results = contents.ToList().ChunkBy(3);

                    foreach (var list in results)
                    {
                        Debug.WriteLine($"   Name: {list[0]}");
                        Debug.WriteLine($" Number: {list[1]}");
                        Debug.WriteLine($"Address: {list[2]}");
                    }
                }
                else
                {
                    Debug.WriteLine("Malformed");
                }
            }
            else
            {
                Debug.WriteLine($"{fileName} not found");
            }
        }

        private static IEnumerable<string> Reader(List<string> itemsList)
        {
            var reading = false;

            foreach (var line in itemsList)
            {
                if (string.Equals(line, "(Record)", StringComparison.OrdinalIgnoreCase))
                {
                    reading = !reading;
                }
                else if (reading)
                {
                    yield return line;
                }
            }
        }
        private static IEnumerable<string> ViewReader(List<string> itemsList)
        {
            var reading = false;

            foreach (var line in itemsList)
            {
                if (line.Contains("Order {", StringComparison.OrdinalIgnoreCase))
                {
                    reading = !reading;
                    yield return "";
                }
                else if (reading)
                {
                    yield return line;
                }
            }
        }
    }

    public static class LanguageExtensions
    {
        public static bool IsEven(this int sender) => sender % 2 == 0;
    }
    public static class ListExtensions
    {
        public static List<List<T>> ChunkBy<T>(this List<T> source, int chunkSize) 
            => source
                .Select((value, index) => new { Index = index, Value = value })
                .GroupBy(x => x.Index / chunkSize)
                .Select(grp => grp.Select(v => v.Value).ToList())
                .ToList();
    }

}
