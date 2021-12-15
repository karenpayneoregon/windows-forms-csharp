using System.Diagnostics;
using System.IO;

namespace RemoveMarkOfWeb.Classes
{
    class Utilities
    {
        public static void UnblockFiles(string folderName)
        {
            if (!Directory.Exists(folderName))
            {
                return;
            }

            var startProcess = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"Get-ChildItem -Path '{folderName}' -Recurse | Unblock-File",
                CreateNoWindow = true
            };


            using (var process = Process.Start(startProcess))
            {
                
            }

        }
    }
}