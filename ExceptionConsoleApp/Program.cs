using System;
using ExceptionConsoleApp.Classes;
using static ExceptionConsoleApp.Classes.ConsoleHelpers;

namespace ExceptionConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Colored("Example 1");
            Console.WriteLine(Demonstrations.Example1());
            Console.WriteLine();
            
            Colored("Example 2");
            Console.WriteLine(Demonstrations.Example2());
            Console.WriteLine();

            Colored("Example 3");
            Console.WriteLine(Demonstrations.Example3());
            Console.WriteLine();

            Colored("Example 4");
            Console.WriteLine(Demonstrations.Example4());
            
            ReadLineWithTimeout(4,"\nTimeout in 4 seconds");
        }


    }
}

