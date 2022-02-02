using System;
using System.Linq;

namespace CountExample.Classes
{
    public static class Extensions
    {
        public static int[] ToIntegerArray(this string[] sender)
        {

            var intArray = Array
                .ConvertAll(sender,
                    (input) => new
                    {
                        IsInteger = int.TryParse(input, out var integerValue),
                        Value = integerValue
                    })
                .Where(result => result.IsInteger)
                .Select(result => result.Value)
                .ToArray();

            return intArray;

        }
        public static bool Between<T>(this IComparable<T> sender, T minimumValue, T maximumValue) 
            => sender.CompareTo(minimumValue) >= 0 && sender.CompareTo(maximumValue) <= 0;
    }
}