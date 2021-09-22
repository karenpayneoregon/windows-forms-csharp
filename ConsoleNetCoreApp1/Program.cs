using System;
using System.IO;
using System.Linq;

namespace ConsoleNetCoreApp1
{
    class Program
    {
        static void Main(string[] args)
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
