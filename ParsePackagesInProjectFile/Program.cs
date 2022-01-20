using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;
using ParsePackagesInProjectFile.Classes;

namespace ParsePackagesInProjectFile
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string path = "\"\\Company\\Stores\\Sales & Revenue\\\"";
            Debug.WriteLine(path);
            await FolderOperations.Example1Async();
            Console.WriteLine("Done");
            Console.ReadLine();
        }

        private static void FromMain()
        {
            var projFile = "C:\\OED\\Dotnetland\\VS2019\\LearningVisualStudio\\WindowsFormsSolution\\FileHelpersFrontEnd\\FileHelpersFrontEnd.csproj";
            var results = SolutionHelper.ProjectReferences(projFile);
            GetPackages();
        }

        private static void GetPackages()
        {
            Dictionary<string, List<PackageReference>> results = new();
            string solutionName = @"C:\OED\Dotnetland\VS2019\LearningVisualStudio\WindowsFormsSolution\WindowsFormsSolution.sln";

            var (names, exception) = SolutionHelper.ProjectNames(solutionName);
            if (names is not null)
            {
                foreach (var project in names)
                {
                    var packages = SolutionHelper.PackageReferences(project);
                    if (packages.Count > 0)
                    {
                        results.Add(project, SolutionHelper.PackageReferences(project));
                    }
                }
            }

            foreach (var kvp in results)
            {
                Console.WriteLine(kvp.Key);
                foreach (var reference in kvp.Value)
                {
                    Console.WriteLine($"\t{reference.Version,-10}{reference.Include}");
                }

                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
