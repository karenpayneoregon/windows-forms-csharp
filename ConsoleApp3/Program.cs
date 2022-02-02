using System;
using System.Globalization;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //var abbreviatedMonthNames = 
            //    new CultureInfo("ko-KR")
            //        .DateTimeFormat
            //        .AbbreviatedMonthNames
            //        .Take(12)
            //        .ToArray();

            //foreach (var name in abbreviatedMonthNames)
            //{
            //    Console.WriteLine(name);
            //}


            //CultureInfo ci = CultureInfo.CreateSpecificCulture("ko-KR");
            //DateTimeFormatInfo dtfi = ci.DateTimeFormat;
            //dtfi.AbbreviatedMonthNames = new[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "" };
            //dtfi.AbbreviatedMonthGenitiveNames = dtfi.AbbreviatedMonthNames;
            //Console.WriteLine(DateTime.Now.ToString("dd MMM yyyy", dtfi));
            //Console.WriteLine();


            foreach (var name in Korean.AbbreviatedMonthNames())
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }

    public class Korean
    {
        private static readonly CultureInfo _cultureInfo = CultureInfo.CreateSpecificCulture("ko-KR");
        private static readonly DateTimeFormatInfo _dateTimeFormatInfo = _cultureInfo.DateTimeFormat;

        public static string[] AbbreviatedMonthNames()
        {
            _dateTimeFormatInfo.AbbreviatedMonthNames = new[] 
                { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "" };
            _dateTimeFormatInfo.AbbreviatedMonthGenitiveNames = _dateTimeFormatInfo.AbbreviatedMonthNames;
            return _dateTimeFormatInfo.AbbreviatedMonthGenitiveNames.Take(12).ToArray();
        }
    }
}
