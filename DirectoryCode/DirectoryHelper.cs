using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryCode
{
    public static class DirectoryHelper
    {
        public delegate void OnTraverse(string sender);
        public static event Helpers.OnTraverse TraverseFolder;

        public static string DoneMessage => "Done";
        public static string TraversePath(string folderName, int level = 20)
        {

            var folderList = new List<string> { folderName };
            TraverseFolder?.Invoke(folderName);

            while (!string.IsNullOrWhiteSpace(folderName))
            {
 
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


    }
}
