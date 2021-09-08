using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DirectoryGetFilesMultipleFilters.Classes
{
    public static class Extensions
    {
        /// <summary>
        /// Get file name only, avoid multiple file extensions e.g. DirectoryGetFilesMultipleFilters.deps.json
        /// </summary>
        /// <param name="sender">Valid path and file name</param>
        /// <param name="stopper">Character to end at</param>
        /// <returns>File name without any extensions</returns>
        /// <remarks>
        /// Nada exception handling, mess it up, got an idea to improve it, go forth and do good things.
        /// </remarks>
        public static string UpTo(this string sender, string stopper = ".") 
            => sender.Substring(0, Math.Max(0, sender.IndexOf(stopper, StringComparison.Ordinal)));
    }
}