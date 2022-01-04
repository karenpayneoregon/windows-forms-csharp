using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Xml.XPath;

namespace ParsePackagesInProjectFile.Classes
{
    public class SolutionHelper
    {

        /// <summary>
        /// Get project names directly under the solution folder
        /// </summary>
        /// <param name="solutionName">Visual Studio solution name</param>
        /// <returns>List of project names with full path for .NET Core style projects</returns>
        /// <remarks>Ignores pre .NET Core projects</remarks>
        public static (List<string> names, Exception exception) ProjectNames(string solutionName)
        {
            var folderName = Path.GetDirectoryName(solutionName);
            var token = "<Project Sdk=\"Microsoft.NET.Sdk\">";
            var projectList = new List<string>();

            try
            {
                var content = File.ReadAllText(solutionName);
                var regex = new Regex("Project\\(\"\\{[\\w-]*\\}\"\\) = \"([\\w _]*.*)\", \"(.*\\.(cs|vb)proj)\"", RegexOptions.Compiled);
                var matches = regex.Matches(content).Cast<Match>();

                var projects = matches.Select(match => match.Groups[2].Value).ToList();

                for (var index = 0; index < projects.Count; ++index)
                {
   
                    var currentProjectFile = Path.Combine(folderName!,projects[index]);
                    var lines = File.ReadAllLines(currentProjectFile);

                    if (lines[0] == token)
                    {
                        projectList.Add(currentProjectFile);
                    }
                }

                return (projectList, null);

            }
            catch (Exception ex)
            {
                return (null, ex);
            }

        }

        /// <summary>
        /// Get package references for project
        /// </summary>
        /// <param name="fileName">path and filename to project file</param>
        /// <returns>List of PackageReference</returns>
        public static List<PackageReference> PackageReferences(string fileName)
        {
            var xml = File.ReadAllText(fileName);

            var doc = XDocument.Parse(xml);
            return doc.XPathSelectElements("//PackageReference")
                .Select(element => new PackageReference
                {
                    Include = element.Attribute("Include").Value,
                    Version = new Version(element.Attribute("Version").Value), 
                    FileName = fileName
                }).ToList();
        }
    }
}