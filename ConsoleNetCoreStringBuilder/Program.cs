using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Globalization.DateTimeFormatInfo;

namespace ConsoleNetCoreStringBuilder
{
    class Program
    {
        public static List<string> MonthNames() => 
            Enumerable.Range(1, 12).Select((index) => CurrentInfo.GetMonthName(index)).ToList();
        static void Main(string[] args)
        {
            StringBuilder builder = new ();
            
            MonthNames().ForEach(month => builder.AppendLine(month));

            Console.WriteLine(builder.Contains("April")); // yes

            Console.ReadLine();
        }
        
        
        
    }

    public static class Extensions
    {
        public static bool Contains(this StringBuilder sender, string text) => 
            sender.ToString().Contains(text, StringComparison.OrdinalIgnoreCase);
    }


}
