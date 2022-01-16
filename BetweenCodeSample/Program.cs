using System;
using System.Collections.Generic;

namespace BetweenCodeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int age = 29;

            Console.WriteLine($"{age,-3} is over 30 {age.Between(30, 30).ToYesNo()}");

            age = 30;
            Console.WriteLine($"{age,-3} is over 30 {age.Between(30, 30).ToYesNo()}");

            age = 30;
            Console.WriteLine($"{age,-3} is between 19 and 30 {age.Between(19, 30).ToYesNo()}");

            age = 12;
            Console.WriteLine($"is child {age.IsChild().ToYesNo()}");

            DateTime lowDateTime = new DateTime(2022, 1, 1);
            DateTime someDateTime = new DateTime(2022, 1, 2);
            DateTime highDateTime = new DateTime(2022, 1, 8);

            Console.WriteLine($"{someDateTime:d} between {lowDateTime:d} and {highDateTime:d}? {someDateTime.Between(lowDateTime, highDateTime).ToYesNo()}");

            someDateTime = new DateTime(2022, 2, 2);
            Console.WriteLine($"{someDateTime:d} between {lowDateTime:d} and {highDateTime:d}? {someDateTime.Between(lowDateTime, highDateTime).ToYesNo()}");

            Console.Read();
        }
    }

    public static class GenericExtensions
    {
        public static bool Between<T>(this T value, T lowerValue, T upperValue) 
            where T : struct, IComparable<T> 
            => Comparer<T>.Default.Compare(value, lowerValue) >= 0 && 
               Comparer<T>.Default.Compare(value, upperValue) <= 0;

        public static bool IsChild(this int sender)
            => sender.Between(1, 12);

        public static bool IsOver30(this int sender)
            => sender.Between(30, 30);

        public static string ToYesNo(this bool value) 
            => value ? "Yes" : "No";

    }
}
