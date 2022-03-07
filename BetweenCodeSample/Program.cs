using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using BetweenCodeSample.Extensions;
using BetweenCodeSample.Extensions.System.Linq;

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
            string input = "This,is,an,example,for,the,stackoverflow,community";

            var output = input.Split(",")
                .Chunk(2)
                .Select(chunk => string.Join(",", chunk));

            foreach (string s in output)
                Console.WriteLine(s);

            Console.Read();
        }

        private static void First()
        {
            string value = "This,is,an, example,for,the,stack-overflow,community";
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
}
