using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace FiniteStateMachineConsole
{
    /// <summary>
    /// Finite-state machine (FSA) example
    /// 
    /// Scenario: Get a list
    ///    Given: with a list with value
    ///      and: has matching markers
    ///     When: marker is detected read data until matching marker
    ///     Then: continue until all data has been read
    /// 
    /// https://en.wikipedia.org/wiki/Finite-state_machine
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Works with a text file too
             */
            List<string> linesList = new()
            {
                "Line 1", 
                "Line 2", 
                "(Marker)", 
                "Inside 1", 
                "Inside 2",
                "Inside 3",
                "Inside 4",
                "(Marker)",
                "Line 7",
                "(Marker)",
                "Inside 1a",
                "",
                "Inside 2b",
                "(Marker)",
                "Line 12"
            };

            foreach (var line in Reader(linesList))
            {

                Debug.WriteLine($"'{line}'");

            }
        }

        private static IEnumerable<string> Reader(List<string> itemsList)
        {
            var reading = false;

            foreach (var line in itemsList)
            {
                if (string.Equals(line, "(Marker)", StringComparison.OrdinalIgnoreCase))
                {
                    reading = !reading;
                }
                else if (reading)
                {
                    yield return line;
                }
            }
        }
    }

    public static class LanguageExtensions
    {
        public static bool IsEven(this int sender) => sender % 2 == 0;
    }
}
