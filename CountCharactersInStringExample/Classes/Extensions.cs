using System;
using System.Linq;

namespace CountExample.Classes
{
    public static class Extensions
    {
        /// <summary>
        /// Determine if all values can represent an int
        /// </summary>
        /// <param name="sender">array to validate</param>
        /// <returns>true for all elements can represent int, false otherwise</returns>
        public static bool AllInt(this string[] sender) =>
            sender.SelectMany(item => item.ToCharArray()).All(char.IsNumber);

        /// <summary>
        /// Convert string array to int array dropping elements which
        /// can not represent an int.
        /// </summary>
        /// <param name="sender">array to convert</param>
        /// <returns>int array</returns>
        public static int[] ToIntegerArray(this string[] sender) =>
            Array
                .ConvertAll(sender,
                    (input) => new
                    {
                        IsInteger = int.TryParse(input, out var integer),
                        Value = integer
                    })
                .Where(result => result.IsInteger)
                .Select(result => result.Value)
                .ToArray();

        /// <summary>
        /// Get all non-integer values
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static int[] GetNonIntegerIndexes(this string[] sender) =>
            sender.Select((item, index) => int.TryParse(item, out _)
                    ? new { IsInteger = true, Index = index }
                    : new { IsInteger = false, Index = index }
                )
                .ToArray()
                .Where(item => item.IsInteger == false)
                .Select(item => item.Index)
                .ToArray();

        /// <summary>
        /// Convert all values in array to int array where non int
        /// values will be set to the default value.
        /// </summary>
        /// <param name="sender">string array</param>
        /// <returns>All elements in array as int</returns>
        public static int[] ToIntegerPreserveArray(this string[] sender) =>
            Array.ConvertAll(sender, (input) =>
            {
                int.TryParse(input, out var integer);
                return integer;
            });


    }
}