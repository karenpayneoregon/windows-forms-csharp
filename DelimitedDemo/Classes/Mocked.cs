﻿using System;
using System.IO;
using System.Linq;

namespace DelimitedDemo.Classes
{
    public class Mocked
    {
        public static void ReadWrite(char delimitBy = ';')
        {
            string[] LineArrayMethod(string lineData)
            {
                var lineArray = lineData.Split(delimitBy);
                return lineArray.Length == 6 ? lineArray : new[] { "", "", "", "", "", "","" };
            }

            var list = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TextFile1.txt"))
                .Select((lineData) =>
                {
                    Item item = new Item();
                    if (string.IsNullOrWhiteSpace(lineData)) return item;
                    var lineArray = LineArrayMethod(lineData);
                    item = new Item
                    {
                        Column1 = lineArray[0],
                        Column2 = lineArray[1],
                        Column3 = lineArray[2],
                        Column4 = lineArray[3],
                        Column5 = lineArray[4],
                        Column6 = lineArray[5],
                        Column7 = lineArray[6]
                    };

                    return item;

                })
                // skip header
                .Skip(1)
                .ToList();


            File.WriteAllLines("File1.txt", list.Select(x => x.Part1).ToArray());
            File.WriteAllLines("File2.txt", list.Select(x => x.Part2).ToArray());
            File.WriteAllLines("File3.txt", list.Select(x => x.Part3).ToArray());
        }
    }
}