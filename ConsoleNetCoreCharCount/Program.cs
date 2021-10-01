using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using static ConsoleNetCoreCharCount.CharacterOperations;

namespace ConsoleNetCoreCharCount
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Code sample";
            //CountOccurrences("AĄBCČDEĘĖFGHIĮYJKLMNOPRSŠTUŲŪVZŽ").ForEach(charItem => Debug.WriteLine(charItem));

            //foreach (string line in Reader(@"TextFile1.Txt"))
            //{
            //    Debug.WriteLine(line);
            //}

            //Debug.WriteLine("123".ParseAs(10));
            //Debug.WriteLine("abc".ParseAs(-1));
            //Debug.WriteLine("".ParseAs(-1));
            //Debug.WriteLine("123,78".ParseAs(10));
            //Debug.WriteLine("abc".ParseAs(107.4));


            string[] testValues = { "", "1", "A", "A1", "1.2", "123"};
            for (var index = 0; index < testValues.Length; index++)
            {
                if (testValues[index].IsInteger())
                {
                    Debug.WriteLine(Convert.ToInt32(testValues[index]));
                }
            }

            while (true)
            {
                
                Console.Write("Enter value ");
                
                string userInput = Console.ReadLine();

                if (userInput.IsInteger())
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(Convert.ToInt32(userInput));
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"'{userInput}' is not valid");
                }

                Console.ResetColor();

                ConsoleKeyInfo ch;
                Console.Write("Press the Escape (Esc) key to quit");
                ch = Console.ReadKey();
                if (ch.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                Console.Clear();
            }
        }

        /// <summary>
        /// You can implement Finite State Machine (FSM) with 2 state only: should you return current line or not:
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static IEnumerable<string> Reader(string fileName)
        {
            bool inRead = false;

            foreach (string line in File.ReadLines(fileName))
            {
                if (string.Equals(line, "(Marker)"))
                {
                    inRead = !inRead;
                }
                else if (inRead)
                {
                    yield return line;
                }
            }
        }
    }

    static class Extensions
    {
        

        public static TOutput ParseAs<TOutput>(this string value, TOutput defaultValue)
        {
            var type = typeof(TOutput);

            var tryParseMethod = type.GetMethod("TryParse", 
                BindingFlags.Static | 
                BindingFlags.Public, 
                Type.DefaultBinder, new[]
                {
                    typeof(string), type.MakeByRefType()
                }, null);

            if (tryParseMethod == null)
            {
                return defaultValue;
            }

            var arguments = new object[] { value, null };
            return ((bool)tryParseMethod.Invoke(null, arguments)) ? (TOutput)arguments[1] : defaultValue;
        }
    }

    internal static class StringExtensions
    {
        public static bool IsInteger(this string sender) 
            => !string.IsNullOrEmpty(sender) && sender.All(char.IsDigit);
    }
}
