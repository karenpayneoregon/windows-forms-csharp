using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConvertingUnitTest.Classes
{
    public static class Extensions
    {
        /// <summary>
        /// Convert string to decimal
        /// </summary>
        /// <param name="sender">assumed value has one or more digest</param>
        /// <returns>decimal value or will throw an exception if can not convert e.g. an empty string</returns>
        public static decimal ToDecimal(this string sender) =>
            decimal.Parse(Regex.Replace(sender, @"[^\d.]", ""));

        /// <summary>
        /// Any value in array greater than checkValue
        /// </summary>
        /// <param name="sender">valid decimal array</param>
        /// <param name="checkValue">check if an element in sender is greater than this value</param>
        /// <returns>true if condition is met, false if not met</returns>
        public static bool GreaterThan(this decimal[] sender, decimal checkValue) =>
            sender.Any(value => value > checkValue);

        /// <summary>
        /// Is sender greater than checkValue
        /// </summary>
        /// <param name="sender">valid decimal value</param>
        /// <param name="checkValue">is sender greater than this value</param>
        /// <returns>true if condition is met, false if not met</returns>
        public static bool GreaterThan(this decimal sender, decimal checkValue) =>
            sender > checkValue;

        public static decimal[] ToDecimalArray(this string[] sender)
        {

            var decimalArray = Array
                .ConvertAll(sender,
                    (input) => new
                    {
                        IsDecimal = decimal.TryParse(Regex.Replace(input, @"[^\d.]", ""), out var doubleValue),
                        Value = doubleValue
                    })
                .Where(result => result.IsDecimal)
                .Select(result => result.Value)
                .ToArray();

            return decimalArray;

        }
    }
}
