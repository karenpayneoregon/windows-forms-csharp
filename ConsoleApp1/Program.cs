using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static async Task Main(string[] args)
        {

            
            await Task.Delay(0);
            Console.WriteLine(Regex.IsMatch("abc123", "^.[pr]|[A-Za-z]$")); // False
            Console.WriteLine(Regex.IsMatch("abc12x", "^.[pr]|[A-Za-z]$")); // True
            Console.WriteLine(Regex.IsMatch("apc123", "^.[pr]|[A-Za-z]$")); // True
            Console.WriteLine(Regex.IsMatch("arc123", "^.[pr]|[A-Za-z]$")); // True
            Console.WriteLine(Regex.IsMatch("", "^.[pr]|[A-Za-z]$"));       // False

            Console.ReadLine();
        }

      
    }
}

