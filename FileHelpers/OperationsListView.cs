using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

using System.IO;
using System.Threading;

namespace FileHelpers
{
    public class OperationsListView
    {
        /// <summary>
        /// Container for files containing SearchText
        /// </summary>
        public static List<FoundFile> FoundFileList = new List<FoundFile>();

        public delegate void OnTraverseFolder(DirectoryItem information);
        /// <summary>
        /// Callback for when a folder is being processed
        /// </summary>
        public static event OnTraverseFolder OnTraverseEvent;

        /// <summary>
        /// For traversing folders, if a cancellation is requested stop processing folders.
        /// </summary>
        public static bool Cancelled = false;

        /// <summary>
        /// Text to search for in files
        /// </summary>
        public static string SearchText;

        public static async Task RecursiveFolders(DirectoryInfo directoryInfo, CancellationToken ct, string fileType = "*.txt")
        {

            if (!directoryInfo.Exists)
            {
                return;
            }

            //
            // Let's say you are traversing folders with Git repositories, we don't
            // want to include their folders.
            //
            if (!directoryInfo.FullName.ContainsAny(".git", "\\obj"))
            {

                DirectoryItem di = new DirectoryItem
                {
                    Location = Path.GetDirectoryName(directoryInfo.FullName),
                    Name = directoryInfo.Name,
                    Modified = directoryInfo.CreationTime
                };

                IterateFilesMultipleExtensions(di.Location);

                if (OnTraverseEvent != null)
                    OnTraverseEvent(di);

            }

            await Task.Delay(1);

            DirectoryInfo folder = null;

            try
            {

                await Task.Run(async () =>
                {
                    foreach (DirectoryInfo dir in directoryInfo.EnumerateDirectories())
                    {

                        folder = dir;

                        if (!Cancelled)
                        {

                            IterateFilesMultipleExtensions(dir.FullName);
                            await Task.Delay(1);
                            await RecursiveFolders(folder, ct);

                        }
                        else
                        {
                            return;
                        }

                        if (ct.IsCancellationRequested)
                        {
                            ct.ThrowIfCancellationRequested();
                        }

                    }
                });

            }
            catch (Exception ex)
            {
                //
                // Operations.RecursiveFolders showed how to recognize
                // folders that access has been denied, here these exceptions
                // are ignored. A developer can integrate those exceptions here
                // if so desired.
                //
                if (ex is OperationCanceledException)
                {

                    Cancelled = true;

                }
            }

        }
        //public static void IterateFiles(string folderName, string fileType)
        //{

        //	if (string.IsNullOrWhiteSpace(SearchText))
        //	{
        //		return;
        //	}

        //	var files = Directory.GetFiles(folderName, fileType);

        //	if (files.Length > 0)
        //	{
        //		foreach (string fileName in files)
        //		{
        //			var current = fileName;

        //			var result = File.ReadLines(fileName).Select((text, index) => new {text, LineNumber = index + 1}).Where((anonymous) => anonymous.text.Contains(SearchText)).ToList();

        //			if (result.Count > 0)
        //			{

        //				foreach (System.Collections.Generic.IEnumerable<object> foundFileItem in
        //					from anonymous in result
        //					select new FoundFile()
        //					{
        //						Text = anonymous.text,
        //						LineNumber = anonymous.LineNumber,
        //						FileName = current
        //					} where !FoundFileList.Contains(item) into item select item)
        //				{

        //					FoundFileList.Add(foundFileItem);

        //				}

        //			}

        //		}
        //	}

        //}
        public static void IterateFilesMultipleExtensions(string folderName)
        {

            if (string.IsNullOrWhiteSpace(SearchText))
            {
                return;
            }


            var dInfo = new DirectoryInfo(folderName);
            var files = dInfo.GetFilesByExtensions(".png", ".exe").Select((item) => item.Name).ToArray();

            if (files.Length > 0)
            {
                foreach (string fileName in files)
                {
                    FoundFileList.Add(new FoundFile() { FileName = fileName });
                }
            }

        }
    }
}