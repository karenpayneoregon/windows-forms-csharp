using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DirectoryGetFilesMultipleFilters.Classes
{
    public static class FileHelpers
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="extensions"></param>
        /// <returns></returns>
        /// <remarks>
        /// List&lt;FileInfo> files = GetFiles("SomePath", ".md", ".json");
        /// </remarks>
        public static List<FileInfo> GetFiles(string path, params string[] extensions)
        {
            List<FileInfo> list = new ();
            
            foreach (var extension in extensions)
            {
                list.AddRange(new DirectoryInfo(path).GetFiles($"*{extension}")
                    .Where(fileInfo => fileInfo.Extension.Equals(extension, StringComparison.CurrentCultureIgnoreCase))
                    .ToArray());
            }

            return list;
        }
    }
}