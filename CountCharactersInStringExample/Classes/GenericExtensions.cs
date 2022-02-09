using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountExample.Classes
{
    public static class GenericExtensions
    {
        public static bool Between<T>(this IComparable<T> sender, T minimumValue, T maximumValue)
            => sender.CompareTo(minimumValue) >= 0 && sender.CompareTo(maximumValue) <= 0;
    }
}
