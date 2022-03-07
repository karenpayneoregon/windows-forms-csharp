using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BetweenCodeSample.Extensions
{

    public static class GenericExtensions
    {
        public static bool Between<T>(this T value, T lowerValue, T upperValue) 
            where T : struct, IComparable<T> 
            => Comparer<T>.Default.Compare(value, lowerValue) >= 0 && 
               Comparer<T>.Default.Compare(value, upperValue) <= 0;

        public static bool BetweenExclusive<T>(this IComparable<T> sender, T minimumValue, T maximumValue) 
            => sender.CompareTo(minimumValue) > 0 && sender.CompareTo(maximumValue) < 0;

        public static bool IsGreaterThan<T>(this T sender, T value) where T : IComparable
            => sender.CompareTo(value) > 0;

        public static bool IsLessThan<T>(this T sender, T value) where T : IComparable 
            => sender.CompareTo(value) < 0;

        public static bool IsChild(this int sender)
            => sender.Between(1, 12);

        public static bool IsOver30(this int sender) => sender.IsGreaterThan(30);
        public static string CaseWhen(this int sender)
        {
            return sender switch
            {
                { } value1 when (value1 >= 7) => $"I am 7 or above: {value1}",
                { } value2 when value2.Between(4, 6) => $"I am between 4 and 6: {value2}",
                { } value3 when (value3.IsLessThan(3)) => $"I am 3 or less: {value3}",
                _ => ""
            };
        }

    }
    
}
