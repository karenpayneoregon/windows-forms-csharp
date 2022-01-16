using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsePackagesInProjectFile.Classes
{
    public class FolderOperations
    {
        public static async Task Example1Async()
        {
            using var e = await Task.Run(() => Directory.EnumerateFiles("C:\\OED\\Dotnetland\\VS2019\\LearningVisualStudio\\WindowsFormsSolution", "*.cs", System.IO.SearchOption.AllDirectories).GetEnumerator());
            while (await Task.Run(() => e.MoveNext()))
            {
                Debug.WriteLine(e.Current);
            }

            //var filePaths = Directory.EnumerateFiles(@"C:\my\files", "*.xml", new EnumerationOptions
            //{
            //    IgnoreInaccessible = true,
            //    RecurseSubdirectories = true
            //});
        }
    }
}
