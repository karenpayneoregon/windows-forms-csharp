using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DirectoryGetFilesMultipleFilters
{
    /// <summary>
    /// Can you call Directory.GetFiles() with multiple filters?
    /// 
    /// https://beansoftware.com/ASP.NET-FAQ/Multiple-Filters-Directory.GetFiles-Method.aspx
    ///
    /// new DirectoryInfo(path).GetFiles().Where(Current => Regex.IsMatch(Current.Extension, "\\.(aspx|ascx)", RegexOptions.IgnoreCase)
    /// </summary>
    class Program
    {
        static async Task Main(string[] args)
        {
            await Task.Delay(500);
            
            var directoryName = "C:\\webprojects\\bootbox-samples";
            var filters = new[] {"md", "json"};
            var files = FilterFiles(directoryName, filters).OrderBy(Path.GetFileName);

            foreach (var file in files)
            {
                Console.WriteLine(Path.GetFileName(file));
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Next");
            Console.ResetColor();
            
            var files1 = Directory
                .GetFiles(directoryName)
                .Where(file => Regex.IsMatch(file.ToLower(), @"^.+\.(md|json)$"));

            foreach (var file in files1)
            {
                Console.WriteLine(Path.GetFileName(file));
            }
            Console.ReadLine();
        }
        
        public static IEnumerable<string> FilterFiles(string path, params string[] extensions) 
            => extensions
                .Select(filter => $"*.{filter}") 
                .SelectMany(x => Directory.EnumerateFiles(path, x));

        public static void Option1(string path)
        {
            var allowedExtensions = new[] { ".md", ".json" };
            var files = Directory
                .GetFiles(path)
                .Where(file => allowedExtensions.Any(file.ToLower().EndsWith))
                .ToList();
        }

        public static void Option2(string path)
        {
            var searchPattern = new Regex(@"$(?<=\.(md|json))", RegexOptions.IgnoreCase);
            var files = Directory.EnumerateFiles(path)
                .Where(f => searchPattern.IsMatch(f))
                .ToList();

        }
        public static void Option3(string path)
        {
            var filteredFiles = Directory
                .EnumerateFiles(path) //<--- .NET 4.5
                .Where(file => file.ToLower().EndsWith("md") || file.ToLower().EndsWith("json"))
                .ToList();

        }

        private static readonly List<string> _dummyFileNameList = new()
        {
            "fluid.html", 
            "index.html", 
            "readme.md", 
            "iccTrans.json",
            "login.html",
            "messages.json"
        };


        [ModuleInitializer]
        public static void Initialization()
        {
            try
            {
                foreach (var fileName in _dummyFileNameList.Where(fileName => !File.Exists(fileName)))
                {
                    using (File.Create(fileName)) ;
                }
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
            }
        }

    }
}
