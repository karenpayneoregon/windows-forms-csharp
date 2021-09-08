using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// ReSharper disable once CheckNamespace
namespace DirectoryGetFilesMultipleFilters
{
    partial class Program
    {
        /// <summary>
        /// Filter files in a folder on multiple extensions 
        /// </summary>
        /// <param name="path">Path to filter</param>
        /// <param name="extensions">One or more file extensions</param>
        /// <returns></returns>
        public static IEnumerable<string> FilterFiles(string path, params string[] extensions) 
            => extensions
                .Select(filter => $"*.{filter}")
                .SelectMany(item => Directory.EnumerateFiles(path, item));

        /// <summary>
        /// Yeah, hard code extensions
        /// </summary>
        /// <param name="path"></param>
        public static void Option1(string path)
        {
            var allowedExtensions = new[] { ".md", ".json" };
            var files = Directory
                .GetFiles(path)
                .Where(file => allowedExtensions.Any(file.ToLower().EndsWith))
                .ToList();
        }

        /// <summary>
        /// Yeah, hard code extensions, this time with regular expressions
        /// (we can store the pattern in say a Json file or database table too)
        /// </summary>
        /// <param name="path"></param>
        public static void Option2(string path)
        {
            var searchPattern = new Regex(@"$(?<=\.(md|json))", RegexOptions.IgnoreCase);
            var files = Directory.EnumerateFiles(path)
                .Where(f => searchPattern.IsMatch(f))
                .ToList();

        }
        
        /// <summary>
        /// Bad, bad choice, tell me why
        /// </summary>
        /// <param name="path"></param>
        public static void Option3(string path)
        {
            var filteredFiles = Directory
                .EnumerateFiles(path) //<--- .NET 4.5
                .Where(file => file.ToLower().EndsWith("md") || file.ToLower().EndsWith("json"))
                .ToList();

        }

        /// <summary>
        /// Create some random files in <see cref="Initialization"/> so we are sure there are some files to work on
        /// </summary>
        private static readonly List<string> _dummyFileNameList = new()
        {
            "fluid.html",
            "index.html",
            "dummy1.md",
            "iccTrans.json",
            "login.html",
            "anotherDummy.md",
            "messages.json"
        };


        /// <summary>
        /// Runs before we hit main method
        /// </summary>
        [ModuleInitializer]
        public static void Initialization()
        {
            try
            {
                foreach (var fileName in _dummyFileNameList.Where(fileName => !File.Exists(fileName)))
                {
                    using var _ = File.Create(fileName);
                }
            }
            catch (Exception exception)
            {
                /*
                 * For class we should never land here but let's be cautious 
                 */
                Debug.WriteLine(exception.Message);
            }
        }
    }
}
