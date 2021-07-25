using System;
using System.Collections.Generic;

namespace SelectRandomFile.Classes
{
    public static class Extensions
    {
        private static readonly Random random = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int count = list.Count;
            
            while (count > 1)
            {
                count--;
                
                int rnd = random.Next(count + 1);
                
                T value = list[rnd];
                list[rnd] = list[count];
                list[count] = value;
            }
        }
    }
}