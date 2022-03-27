using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using BetweenCodeSample.Extensions;
using CoreExtensions.LanguageExtensions;


namespace BetweenCodeSample
{
    /// <summary>
    /// Example for a generic language extension for <see cref="IComparable"/>
    /// In this case the extension is used for int and DateTime
    /// </summary>
    class Program
    {
        
        static void Main(string[] args)
        {

            string[] test = new[] { "A", "B", "C" };

            var data = test.ToList();

            for (int index = 0; index < data.Count; index++)
            {
                Debug.WriteLine(test[index]);
            }

            Console.Title = "Code sample";

            //DateTime expirationDate = new (2022, 3, 21);
            //var emailtext = $"License will expire on {expirationDate:MM/dd/yyyy} and only have {DateHelper.CalculateExpirationTime(expirationDate)} days left.";
            //Chunking();
            SwitchExpression();
            Console.ReadLine();
        }


        private static void MoveLineUp()
        {
            List<string> lines = File.ReadAllLines("TextFile1.txt").Where(data => !string.IsNullOrWhiteSpace(data)).ToList();
            int selectedIndex = lines.Count -1;

            lines.Insert(selectedIndex -1,lines[selectedIndex]);
            lines.RemoveAt(selectedIndex +1);

            foreach (var line in lines)
            {
                Debug.WriteLine(line);
            }

            File.WriteAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Results.txt"), lines.ToArray());

        }

        private static void ChunkingInNetCore5()
        {
            string input = "This,is,an,example,for,the,C#,community";

            var output = input.Split(",")
                .Chunk(2)
                .Select(chunk => string.Join(" ", chunk));

            foreach (string s in output)
                Console.WriteLine(s);
        }

        private static void Chunking()
        {
            int[] indexers = { 2, 3, 4, 6 };
            string input = "56822114567133355603";
            StringBuilder builder = new();

            foreach (var indexer in indexers[..4])
            {
                builder.AppendLine($"Chunk by: {indexer}");
                List<char[]> output = input.Chunk(indexer).Select(chunk => chunk).ToList();
                output.ForEach(x => builder.Append(new string(x.ToArray()) + " "));

                builder.AppendLine("");
            }
            Console.WriteLine(builder);
        }

        private static void ChunkingBy2()
        {
            string input = "56822114567133355603";

            List<char[]> output = input
                .Chunk(2)
                .Select(chunk => chunk).ToList();

            StringBuilder builder = new();
            foreach (var item in output)
            {
                builder.Append(new string(item.ToArray()) + " ");
            }

            Console.WriteLine(builder);
            Console.WriteLine();
        }
        private static void ChunkingBy3()
        {
            string input = "56822114567133355603";

            List<char[]> output = input
                .Chunk(3)
                .Select(chunk => chunk).ToList();

            StringBuilder builder = new();
            foreach (var item in output)
            {
                builder.Append(new string(item.ToArray()) + " ");
            }

            Console.WriteLine(builder);

        }
        private static void First()
        {
            string value = "This,is,an, example,for,the,C#,community";

            var output = Regex.Matches(value, "[^,]+,[^,]+,*");
            StringBuilder sb = new();
            foreach (Match item in output)
            {
                sb.AppendLine(item.Value.Trim(','));
            }

            Console.WriteLine(sb.ToString());
        }

        private static void SwitchExpression()
        {
            Console.WriteLine(7.CaseWhen());
            Console.WriteLine(5.CaseWhen());
            Console.WriteLine(1.CaseWhen());
            Console.WriteLine(16.CaseWhen());
        }

        private static void IComparableExtensionExamples()
        {
            int age = 29;

            Console.WriteLine($"{age,-3} is over 30 {age.Between(30, 30).ToYesNo()}");

            age = 30;
            Console.WriteLine($"{age,-3} is over 30 {age.Between(30, 30).ToYesNo()}");

            age = 30;
            Console.WriteLine($"{age,-3} is between 19 and 30 {age.Between(19, 30).ToYesNo()}");

            age = 12;
            Console.WriteLine($"is child {age.IsChild().ToYesNo()}");

            DateTime lowDateTime = new(2022, 1, 1);
            DateTime someDateTime = new(2022, 1, 2);
            DateTime highDateTime = new(2022, 1, 8);

            Console.WriteLine($"{someDateTime:d} between {lowDateTime:d} and {highDateTime:d}? {someDateTime.Between(lowDateTime, highDateTime).ToYesNo()}");

            someDateTime = new DateTime(2022, 2, 2);
            Console.WriteLine($"{someDateTime:d} between {lowDateTime:d} and {highDateTime:d}? {someDateTime.Between(lowDateTime, highDateTime).ToYesNo()}");

            Console.WriteLine($"30.IsOver30() {30.IsOver30()}");
            Console.WriteLine($"31.IsOver30() {31.IsOver30()}");
        }
    }

    internal class Person
    {
    }
}
