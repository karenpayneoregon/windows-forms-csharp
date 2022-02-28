using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace WhenAllConsole
{
    /// <summary>
    /// - Written with .NET Core 5
    /// - Debug.WriteLine is used rather than Console.WriteLine
    ///   so results are available after closing the app
    /// </summary>
    class Program
    {
        static async Task Main(string[] args)
        {
            Task<bool> nameChange = FirstTask();
            Task<List<string>> monthNames = SecondTask();
            Task<List<PersonItem>> groupedTask = ThirdTask();

            await Task.WhenAll(nameChange, monthNames, groupedTask);
            Debug.WriteLine("");
            Debug.WriteLine($"Task 1: {nameChange.Result}");
            Debug.WriteLine($"Task 2: {string.Join(",", monthNames.Result.ToArray())}");
            Debug.WriteLine("Task 3");
            groupedTask.Result.ForEach(personItem => Debug.WriteLine(personItem));
            
            Debug.WriteLine("");
        }

        public static async Task<bool> FirstTask()
        {
            return await Task.Run(async () =>
            {
                Debug.WriteLine($"In {nameof(FirstTask)}");
                await Task.Delay(1000);

                return Environment.UserName == "PayneK";
            });

        }
        public static async Task<List<string>> SecondTask()
        {
            return await Task.Run(async () =>
            {

                Debug.WriteLine($"In {nameof(SecondTask)}");
                await Task.Delay(3000);

                return Enumerable.Range(1, 12).Select((index)
                        => DateTimeFormatInfo.CurrentInfo.GetMonthName(index))
                    .ToList(); ;
            });

        }

        public static async Task<List<PersonItem>> ThirdTask()
        {
            return await Task.Run(async () =>
            {
                Debug.WriteLine($"In {nameof(ThirdTask)}");
                await Task.Delay(1);
                var results = Data.Mocked().GroupBy(person => person.Customer)
                    .OrderByDescending(group => group.Max(person => person.Total))
                    .Select(group => group.OrderBy(person => person.Total))
                    .Select((people, index) => new { RowIndex = index + 1, item = people }).ToList();

                List<PersonItem> list = new();
                list.AddRange(from result in results
                    select new PersonItem()
                    {
                        Index = result.RowIndex,
                        Person = result.item.LastOrDefault()
                    });
                return list;
            });

        }


    }
    public class Data
    {
        public static List<Person> Mocked() => new()
        {
            new() { Id = 1, Customer = "Sally", Total = 1 },
            new() { Id = 2, Customer = "Joe", Total = 2 },
            new() { Id = 3, Customer = "Bill", Total = 5 },
            new() { Id = 4, Customer = "Sally", Total = 3 },
            new() { Id = 5, Customer = "Joe", Total = 6 }
        };

    }

    public class PersonItem
    {
        public int Index { get; set; }
        public Person Person { get; set; }
        public override string ToString() => $"{Index} - {Person}";

    }
    public class Person
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public int Total { get; set; }
        public override string ToString()
        {
            return $"{Customer},{Total}";
        }
    }
}
