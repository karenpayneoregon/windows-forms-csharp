Imports System.IO

Namespace Classes
    ''' <summary>
    ''' Code to remove specific file types from the bin\debug folder, quick-n-dirty
    ''' The class inherits <see cref="FileSystemWatcher"/>
    ''' </summary>
    Public Class FileHelpers
        Public Class FileHelpers
            Inherits FileSystemWatcher

            Private Shared ReadOnly _fileExtension() As String = {".txt", ".csv", ".json", ".html"}

            ''' <summary>
            ''' Remove result files from Debug folder
            ''' </summary>
            Public Shared Sub RemoveFiles()
                Dim files = New DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).
                        EnumerateFiles().Where(Function(fileInfo) _fileExtension.Contains(fileInfo.Extension.ToLower())).
                        ToArray()

                For Each fileInfo In files
                    File.Delete(fileInfo.Name)
                Next

            End Sub

            Public Shared Sub OpenExecutableFolder()
                Process.Start("explorer.exe", AppDomain.CurrentDomain.BaseDirectory)
            End Sub

            Public Sub New()

                AddHandler [Error], AddressOf OnError

                Path = AppDomain.CurrentDomain.BaseDirectory

                _fileExtension.ToList().ForEach(Function(ext) ext.PrependAsterisk())

                EnableRaisingEvents = True

                NotifyFilter =
                    NotifyFilters.Attributes Or
                    NotifyFilters.CreationTime Or
                    NotifyFilters.DirectoryName Or
                    NotifyFilters.FileName Or
                    NotifyFilters.LastAccess Or
                    NotifyFilters.LastWrite Or
                    NotifyFilters.Security Or
                    NotifyFilters.Size

            End Sub
            Public Shared Function ReadAllLines(fileName As String) As List(Of String)
                Return File.ReadAllLines(fileName).ToList()
            End Function
            Public Sub Start()
                EnableRaisingEvents = True
            End Sub
            Public Sub [Stop]()
                EnableRaisingEvents = False
            End Sub
            Private Overloads Shared Sub OnError(sender As Object, e As ErrorEventArgs)
                DisplayException(e.GetException())
            End Sub

            ''' <summary>
            ''' For debug purposes
            ''' For a production environment write to a log file
            ''' </summary>
            ''' <param name="ex">Exception</param>
            ''' <remarks>
            ''' Recursive method
            ''' </remarks>
            Private Shared Sub DisplayException(ex As Exception)

                If ex Is Nothing Then
                    Return
                End If

                Debug.WriteLine($"Message: {ex.Message}")
                Debug.WriteLine("Stacktrace:")
                Debug.WriteLine(ex.StackTrace)
                Debug.WriteLine("")

                DisplayException(ex.InnerException)

            End Sub
        End Class

    End Class
End Namespace