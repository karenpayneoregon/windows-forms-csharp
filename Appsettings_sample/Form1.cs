using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Appsettings_sample.Classes;

namespace Appsettings_sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Show connection string stored in appsettings.json
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetConnectionStringButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Helper.ConnectionString());
        }

        /// <summary>
        /// Test connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TestConnectionButton_Click(object sender, EventArgs e)
        {
            var (success, exception) = SqlOperations.TestConnection();
            MessageBox.Show(success ? @"Open connection successful" : $"Failed to open connection\n{exception.Message}");
        }

        private void BuildDateButton_Click(object sender, EventArgs e)
        {
            DateTime buildDate = GetBuildDate(Assembly.GetExecutingAssembly());

        }
        private static DateTime GetBuildDate(Assembly assembly)
        {
            var attribute = assembly.GetCustomAttribute<BuildDateAttribute>();
            return attribute?.DateTime ?? default(DateTime);
        }

        public static async Task<bool> FirstTask()
        {
            return await Task.Run(async () =>
            {
                
                await Task.Delay(1000);
                
                return Environment.UserName == "PayneK";
            });

        }

        public static async Task<List<string>> SecondTask()
        {
            return await Task.Run(async () =>
            {
                
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
                await Task.Delay(1);
                var results = Data.Mocked().GroupBy(person => person.Customer)
                    .OrderByDescending(group => group.Max(person => person.Total))
                    .Select(group => group.OrderBy(person => person.Total))
                    .Select((people, index) => new { RowIndex = index + 1, item = people }).ToList();

                List<PersonItem> list = new();
                list.AddRange(from result in results select new PersonItem()
                {
                    Index = result.RowIndex,
                    Person = result.item.LastOrDefault()
                });
                return list;
            });

        }

        private async void WhenAllButton_Click(object sender, EventArgs e)
        {
            
            Task<List<string>> monthNames = SecondTask();
            Task<bool> nameChange = FirstTask();
            Task<List<PersonItem>> groupedTask = ThirdTask();

            await Task.WhenAll(nameChange, monthNames, groupedTask);
            
            Debug.WriteLine(nameChange.Result);
            Debug.WriteLine($"{string.Join(",", monthNames.Result.ToArray())}");
            
            groupedTask.Result.ForEach(x => Debug.WriteLine(x));
          
        }

        private void RunSomeTaskButton_Click(object sender, EventArgs e)
        {
            List<Func<Task>> list = new List<Func<Task>>
            {
                ExampleTask.FirstAsync,
                ExampleTask.SecondAsync,
                ExampleTask.ThirdAsync
            };

            Task taskingAsync = TaskHelpers.ForEachAsync(list);

            taskingAsync.ContinueWith(task => 
                Debug.WriteLine(task.Exception.ToString()), 
                TaskContinuationOptions.OnlyOnFaulted);
            
            taskingAsync.ContinueWith(task => 
                Debug.WriteLine("Done!"), 
                TaskContinuationOptions.OnlyOnRanToCompletion);
        }

        private void ReadFileButton_Click(object sender, EventArgs e)
        {
            //List<string> contents = File.ReadAllLines(Path.Combine(
            //    AppDomain.CurrentDomain.BaseDirectory, "WordList.txt")).ToList();
            
            //contents.Add("Karen");
            //contents.ForEach(x => Debug.WriteLine(x));

            var someData = Enumerable.Range(1, 12)
                .Select((index) => DateTimeFormatInfo.CurrentInfo.GetMonthName(index)).ToList();
            
            someData.Add("May");
            someData.Add("November");

            List<string> noDuplicates = new HashSet<string>(someData).ToList();

            foreach (var item in noDuplicates)
            {
                Debug.WriteLine(item);
            }


        }
    }

    public class Data
    {
        public static List<Person> Mocked() => new()
        {
            new() {Id = 1, Customer = "Sally", Total = 1},
            new() {Id = 2, Customer = "Joe", Total = 2},
            new() {Id = 3, Customer = "Bill", Total = 5},
            new() {Id = 4, Customer = "Sally", Total = 3},
            new() {Id = 5, Customer = "Joe", Total = 6}
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
