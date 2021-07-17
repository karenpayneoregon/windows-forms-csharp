using System;
using TimeLibrary.Classes;

namespace TimeLibraryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fromDateTime = new DateTime(1956, 9, 24);
            var toDateTime = DateTime.Now;

            fromDateTime.GetElapsedTime(toDateTime, 
                out var years, out var months, out var days,
                out var hours, out var minutes, out var seconds, 
                out _);

            Console.WriteLine($"Age is {years} years {months} months {days} days");
            Console.ReadLine();
        }
    }
}
