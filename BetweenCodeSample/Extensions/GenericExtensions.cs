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
    namespace System.Linq
    {
        // Licensed to the .NET Foundation under one or more agreements.
        // The .NET Foundation licenses this file to you under the MIT license.
        public static partial class Enumerable
        {
            /// <summary>
            /// Split the elements of a sequence into chunks of size at most <paramref name="size"/>.
            /// </summary>
            /// <remarks>
            /// Every chunk except the last will be of size <paramref name="size"/>.
            /// The last chunk will contain the remaining elements and may be of a smaller size.
            ///
            ///
            /// ~~ This is native in .NET Core 6 ~~
            /// https://github.com/dotnet/runtime/blob/main/src/libraries/System.Linq/src/System/Linq/Chunk.cs
            ///
            ///  
            /// </remarks>
            /// <param name="source">
            /// An <see cref="IEnumerable{T}"/> whose elements to chunk.
            /// </param>
            /// <param name="size">
            /// Maximum size of each chunk.
            /// </param>
            /// <typeparam name="TSource">
            /// The type of the elements of source.
            /// </typeparam>
            /// <returns>
            /// An <see cref="IEnumerable{T}"/> that contains the elements the input sequence split into chunks of size <paramref name="size"/>.
            /// </returns>
            /// <exception cref="ArgumentNullException">
            /// <paramref name="source"/> is null.
            /// </exception>
            /// <exception cref="ArgumentOutOfRangeException">
            /// <paramref name="size"/> is below 1.
            /// </exception>
            public static IEnumerable<TSource[]> Chunk<TSource>(this IEnumerable<TSource> source, int size)
            {
                if (source == null)
                {
                    throw new ArgumentNullException(nameof(source));
                }

                if (size < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(size));
                }

                return ChunkIterator(source, size);
            }

            private static IEnumerable<TSource[]> ChunkIterator<TSource>(IEnumerable<TSource> source, int size)
            {
                using IEnumerator<TSource> e = source.GetEnumerator();
                while (e.MoveNext())
                {
                    TSource[] chunk = new TSource[size];
                    chunk[0] = e.Current;

                    int index = 1;
                    for (; index < chunk.Length && e.MoveNext(); index++)
                    {
                        chunk[index] = e.Current;
                    }

                    if (index == chunk.Length)
                    {
                        yield return chunk;
                    }
                    else
                    {
                        Array.Resize(ref chunk, index);
                        yield return chunk;
                        yield break;
                    }
                }
            }
        }
    }
}