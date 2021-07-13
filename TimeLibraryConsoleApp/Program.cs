using System;
using TimeLibrary.Classes;

namespace TimeLibraryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Helpers.GetElapsedTime(
                new DateTime(DateTime.Now.Year,
                    DateTime.Now.Month, DateTime.Now.AddDays(-12).Day, 2, 2, 0),
                DateTime.Now,
                out var years,
                out var months,
                out var days,
                out var hours,
                out var minutes,
                out var seconds,
                out _);

            string result = "";
            Console.WriteLine(Helpers.Elapsed(years, months, days, hours, minutes, seconds, result));

            Console.ReadLine();
        }
    }
}
