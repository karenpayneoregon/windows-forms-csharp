using System.Collections.Generic;
using System.IO;

namespace DirectoryCode
{
    public static class Helpers
    {
        public delegate void OnTraverse(string sender);
        public static event OnTraverse TraverseFolder;

        public static bool Continue { get; set; }
        public static string DoneMessage => "Done";

        /// <summary>
        /// Traverse folders default to 20 levels deep
        /// </summary>
        /// <param name="folderName"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        public static string LoopFolder(this string folderName, int level = 20)
        {
            Continue = true;

            var folderList = new List<string>();

            

            while (!string.IsNullOrWhiteSpace(folderName))
            {
                if (Continue == false)
                {
                    break;
                }

                var parentFolder = Directory.GetParent(folderName);

                if (parentFolder == null)
                {
                    break;
                }

                folderName = Directory.GetParent(folderName)?.FullName;
                folderList.Add(folderName);
                TraverseFolder?.Invoke(folderName);
                
            }

            if (folderList.Count > 0 && level > 0)
            {
                if (level - 1 <= folderList.Count - 1)
                {
                    return folderList[level - 1];
                }
                else
                {
                    TraverseFolder?.Invoke(DoneMessage);
                    return folderName;
                }
            }
            else
            {
                return folderName;
            }
        }

        public static void Traverse(string folder)
        {
            folder.LoopFolder();
        }
    }
}