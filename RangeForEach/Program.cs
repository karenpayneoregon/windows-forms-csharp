using static System.Globalization.DateTimeFormatInfo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using RangeForEach.Extensions;

namespace RangeForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForEachIndexingDoesNotCompile();
            //ForEachConventional();
            //ForEachIndexing();

            ForZip();
        }


        private static void ForEachIndexing()
        {
            Debug.WriteLine(nameof(ForEachIndexing));

            var owners = new[] { "Karen", "Bob", "John" };
            var pets   = new[] { "Dog",   "Cat", "Bird" };
            
            Debug.WriteLine("Using Range extension");

            foreach (var index in 1..3)
            {
                Debug.WriteLine($"{owners[index], -4} owns a {pets[index]}");
            }

            Debug.WriteLine("");

            Range range = new Range(1, 3);

            Debug.WriteLine("Using a Range");
            foreach (var index in range)
            {
                Debug.WriteLine($"{owners[index],-4} owns a {pets[index]}");
            }

        }

        private static void ForZip()
        {
            var owners = new[] { "Karen", "Bob", "John" };
            var animals = new[] { "Dog", "Cat", "Bird" };

            var zippedItems = owners
                .Zip(animals, (owner, pet) => new Pet { Owner = owner, Type = pet });

            foreach (Pet pet in zippedItems)
            {
                Debug.WriteLine($"{pet.Owner, -6}{pet.Type}");
            }

        }

        private static void ForEachIndexingDoesNotCompile()
        {
            var owners = new[] { "Karen", "Bob", "John" };
            var pets = new[] { "Dog", "Cat", "Bird" };

            foreach (var index in owners[1..3])
            {
                //Debug.WriteLine($"{owners[index],-4} owns a {pets[index]}");
            }

            for (int index = 1; index < owners.Length; index++)
            {
                Debug.WriteLine($"{owners[index],-4} owns a {pets[index]}");
            }

            Debug.WriteLine("");

            int[] indices = Enumerable.Range(0, pets.Length).ToArray();
            foreach (var index in indices[1..3])
            {
                Debug.WriteLine($"{owners[index],-4} owns a {pets[index]}");
            }
        }

        private static void ForEachConventional()
        {
            Debug.WriteLine(nameof(ForEachConventional));
            var owners = new[] { "Karen", "Bob", "John" };
            var pets = new[] { "Dog", "Cat", "Bird" };

            for (int index = 0; index < owners.Length; index++)
            {
                Debug.WriteLine($"{owners[index],-4} owns a {pets[index]}");
            }

            Debug.WriteLine("");
        }



        // static readonly string[] dayNames = CurrentInfo?.DayNames;
        static readonly string[] dayNames = {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };
        private static void ExecuteUnboundedRange()
        {
            var midWeeks = dayNames[..3]; // Start from 0th and goes before 3rd index means index 0, 1 and 2  
            Debug.WriteLine("First three elements of midWeeks array are:");
            foreach (var week in midWeeks)
            {
                Debug.WriteLine(week);
            }
            Debug.WriteLine("last two elements of endofWeeks array are:");
            var endofWeeks = dayNames[^2..];
            foreach (var week in endofWeeks)
            {
                Debug.WriteLine(week);
            }
        }
    }
}
