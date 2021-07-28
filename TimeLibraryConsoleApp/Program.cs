using System;
using TimeLibrary.Classes;

namespace TimeLibraryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SecondAttempt();
            FirstAttempt();

            Console.ReadLine();
        }

        /// <summary>
        /// Using a wrapper keeps code clean
        /// </summary>
        private static void SecondAttempt()
        {
            var fromDateTime = new DateTime(2008, 9, 24);
            var toDateTime = DateTime.Now;

            var age = fromDateTime.Age(toDateTime);
            Console.WriteLine($"Age is {age.YearsMonthsDays}");
        }

        /// <summary>
        /// Works fine although it's messy and harder to use in more than one place
        /// </summary>
        private static void FirstAttempt()
        {
            var fromDateTime = new DateTime(2008, 9, 24);
            var toDateTime = DateTime.Now;

            fromDateTime.GetElapsedTime(toDateTime,
                out var years, out var months, out var days,
                out var hours, out var minutes, out var seconds,
                out _);

            Console.WriteLine($"Age is {years} years {months} months {days} days");
        }
    }
}
