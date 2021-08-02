using System;
using System.Diagnostics;
using System.IO;
using static System.IO.Path;

namespace FileWatcherExample
{
    public class FileOperations : FileSystemWatcher
    {
        /// <summary>
        /// Path to check for new files
        /// </summary>
        public string MonitorPath { get; set; }
        /// <summary>
        /// Path to move file(s) too
        /// </summary>
        public string TargetPath { get; set; }
        
        /// <summary>
        /// Responsible for watching a folder, move new files to a
        /// designated folder.
        /// </summary>
        /// <param name="monitorPath">Folder to monitor</param>
        /// <param name="targetPath">Folder to move files to</param>
        /// <param name="extension">Extension to watch for</param>
        /// <remarks>
        /// Might want to determine if the monitorPath and targetPath exits in
        /// the constructor or prior to using this code.
        /// </remarks>
        public FileOperations(string monitorPath, string targetPath, string extension)
        {


            if (!Directory.Exists(monitorPath))
            {
                throw new Exception($"Missing {monitorPath}");
            }
            if (!Directory.Exists(targetPath))
            {
                throw new Exception($"Missing {targetPath}");
            }

            MonitorPath = monitorPath;
            TargetPath = targetPath;
            
            Created += OnCreated;
            Error += OnError;

            Path = MonitorPath;
            Filter = extension;
            
            EnableRaisingEvents = true;

            IncludeSubdirectories = true;

            NotifyFilter = NotifyFilters.Attributes
                           | NotifyFilters.CreationTime
                           | NotifyFilters.DirectoryName
                           | NotifyFilters.FileName
                           | NotifyFilters.LastAccess
                           | NotifyFilters.LastWrite
                           | NotifyFilters.Security
                           | NotifyFilters.Size;
        }

        private void OnCreated(object sender, FileSystemEventArgs fileSystemEventArgs)
        {
            
            try
            {

                var targetFile = Combine(TargetPath, GetFileName(fileSystemEventArgs.FullPath));
                if (File.Exists(targetFile))
                {
                    File.Delete(targetFile);
                }
                
                File.Move(fileSystemEventArgs.FullPath,targetFile);
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
            }
        }

        public void Start()
        {
            EnableRaisingEvents = true;
        }

        public void Stop()
        {
            EnableRaisingEvents = false;
        }

        private static void OnError(object sender, ErrorEventArgs e) => DisplayException(e.GetException());
        /// <summary>
        /// For debug purposes
        /// For a production environment write to a log file
        /// </summary>
        /// <param name="ex"></param>
        private static void DisplayException(Exception ex)
        {
            if (ex == null) return;
            Debug.WriteLine($"Message: {ex.Message}");
            Debug.WriteLine("Stacktrace:");
            Debug.WriteLine(ex.StackTrace);
            Debug.WriteLine("");
                
            DisplayException(ex.InnerException);
        }
    }
}