using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace DirectoryCode
{
    public class DirectoryOperations
    {
        public delegate void OnDelete(string status);
        /// <summary>
        /// Callback for subscribers to see what is being worked on
        /// </summary>
        public static event OnDelete OnDeleteEvent;

        public delegate void OnException(Exception exception);
        /// <summary>
        /// Callback for subscribers to know about a problem
        /// </summary>
        public static event OnException OnExceptionEvent;

        public delegate void OnUnauthorizedAccessException(string message);
        /// <summary>
        /// Raised when attempting to access a folder the user does not have permissions too
        /// </summary>
        public static event OnUnauthorizedAccessException UnauthorizedAccessEvent;

        public delegate void OnTraverseExcludeFolder(string sender);
        /// <summary>
        /// Called each time a folder is being traversed
        /// </summary>
        public static event OnTraverseExcludeFolder OnTraverseIncludeFolderEvent;

        public static bool Cancelled = false;

        /// <summary>
        /// Recursively remove an entire folder structure and files with events for monitoring and basic
        /// exception handling. USE WITH CARE
        /// </summary>
        /// <param name="directoryInfo"></param>
        public static async Task RecursiveDelete(DirectoryInfo directoryInfo, CancellationToken cancellationToken)
        {
            if (!directoryInfo.Exists)
            {
                OnDeleteEvent?.Invoke("Nothing to process");
                return;
            }

            OnDeleteEvent?.Invoke(directoryInfo.Name);

            DirectoryInfo folder = null;

            try
            {
                await Task.Run(async () =>
                {
                    foreach (DirectoryInfo dir in directoryInfo.EnumerateDirectories())
                    {

                        folder = dir;

                        if ((folder.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden || (folder.Attributes & FileAttributes.System) == FileAttributes.System || (folder.Attributes & FileAttributes.ReparsePoint) == FileAttributes.ReparsePoint) {

                            OnTraverseIncludeFolderEvent?.Invoke($"* {folder.FullName}");

                            continue;

                        }

                        OnTraverseIncludeFolderEvent?.Invoke($"Delete: {folder.FullName}");

                        if (!Cancelled)
                        {
                            await Task.Delay(1, cancellationToken);
                            await RecursiveDelete(folder, cancellationToken);
                        }
                        else
                        {
                            return;
                        }

                        if (cancellationToken.IsCancellationRequested)
                        {
                            cancellationToken.ThrowIfCancellationRequested();
                        }

                    }

                    /*
                     * assert if folder should be deleted, yes then
                     * directoryInfo.Delete(true);
                     */


                }, cancellationToken);

            }
            catch (Exception exception)
            {
                switch (exception)
                {
                    case OperationCanceledException _:
                        Cancelled = true;
                        break;
                    case UnauthorizedAccessException _:
                        UnauthorizedAccessEvent?.Invoke($"Access denied '{exception.Message}'");
                        break;
                    default:
                        OnExceptionEvent?.Invoke(exception);
                        break;
                }
            }
        }
    }
}
