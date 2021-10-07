using ExampleLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace ContainsAny
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int> { { "", 1 } };

            DateTime birthdate = new DateTime(1956, 9, 24);
            // Save today's date.
            var today = DateTime.Today;

            // Calculate the age.
            var age = today.Year - birthdate.Year;

            // Go back to the year in which the person was born in case of a leap year
            if (birthdate.Date > today.AddYears(-age)) age--;
        }

        private static void MainRun()
        {
            Customer customer = new() { Id = 1, Name = "Adams" };
            Debug.WriteLine(Operations.Common(customer));

            Order order = new() { Id = 12, Product = "Phone" };
            Debug.WriteLine(Operations.Common(order));

            try
            {
                Contact contact = new() { Id = 45, FirstName = "Jim", LastName = "Smith" };
                Debug.WriteLine(Operations.Common(contact));
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
            }
        }

        private static void Example()
        {
            string loggerfilepath = "c://abc.txt";

            string fileContents = File.ReadAllText(loggerfilepath);
            if (fileContents.ContainsAny("error", "bcp copy out failed"))
            {
            }
        }
    }

    public static class Extensions
    {
        public static bool ContainsAny(this string sender, params string[] tokens)
        {
            foreach (string token in tokens)
            {
                if (sender.Contains(token, StringComparison.CurrentCultureIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
