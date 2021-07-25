using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SelectRandomFile.Classes
{
    public class FileOperations
    {
        
        public static List<FileItem> GetFilesFromPath(string folderName, string extension = "*.*") =>
            Directory.GetFiles(folderName, extension).Select(file => new FileItem()
            {
                FileName = Path.GetFileName(file), 
                FolderName = folderName
            }).ToList();
    }
}