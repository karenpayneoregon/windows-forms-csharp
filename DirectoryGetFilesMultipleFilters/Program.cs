using System;
using System.Collections.Generic;
using System.Diagnostics;

using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DirectoryGetFilesMultipleFilters.Classes;

namespace DirectoryGetFilesMultipleFilters
{

    /// <summary>
    /// Can you call Directory.GetFiles() with multiple filters?
    /// 
    /// https://beansoftware.com/ASP.NET-FAQ/Multiple-Filters-Directory.GetFiles-Method.aspx
    ///
    /// </summary>
    partial class Program
    {

        static async Task Main(string[] args)
        {

            await Task.Delay(5);


            //Examples1();




            Console.ReadLine();
        }

        /// <summary>
        /// What a novice might try where they got <see cref="Extensions.UpTo"/> from searching
        /// on the web or a forum post
        /// </summary>
        private static void HalfBakedNoviceAttempt()
        {
            var directoryName = AppDomain.CurrentDomain.BaseDirectory;
            var files = Directory.GetFiles(directoryName);

            string[] extensions = new[] {".md", ".json"};

            foreach (var file in files)
            {
                if (!extensions.Contains(Path.GetExtension(file))) continue;
                if (Path.GetFileName(file).UpTo() != nameof(DirectoryGetFilesMultipleFilters))
                {
                    Console.WriteLine(Path.GetFileName(file));
                }
            }
        }

        /// <summary>
        /// A smart developer will try multiple methods then make an informed choice which
        /// one to use.
        /// </summary>
        private static void Examples1()
        {
            var directoryName = AppDomain.CurrentDomain.BaseDirectory;
            var filters = new[] {"md", "json"};
            var files = FilterFiles(directoryName, filters)
                .OrderBy(Path.GetFileName);

            foreach (var file in files)
            {
                if (Path.GetFileName(file).UpTo() != nameof(DirectoryGetFilesMultipleFilters))
                {
                    Console.WriteLine(Path.GetFileName(file));
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Next");
            Console.ResetColor();



            

            var files1 = Directory
                .GetFiles(directoryName)
                .Where(file => Regex.IsMatch(file.ToLower(), @"^.+\.(md|json)$"));

            foreach (var file in files1)
            {
                if (!Path.GetFileName(file).Contains(nameof(DirectoryGetFilesMultipleFilters)))
                {
                    Console.WriteLine(Path.GetFileName(file));
                }
            }
        }
    }
}
