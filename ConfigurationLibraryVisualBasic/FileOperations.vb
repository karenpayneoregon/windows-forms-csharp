Option Infer On
Imports System.IO



Public Class FileOperations
#Region "Events"

    ''' <summary>
    ''' Report progress passing file name
    ''' </summary>
    ''' <param name="fileName">Current file processed</param>
    Public Delegate Sub ProcessDelegate(ByVal fileName As String)
    ''' <summary>
    ''' Report progress passing current file name
    ''' </summary>
    Public Shared Event OnProcessEvent As ProcessDelegate

    ''' <summary>
    ''' Provides access to runtime exceptions while chunking 
    ''' </summary>
    ''' <param name="exception">Exception e.g. insufficient permissions</param>
    ''' <param name="index">File indexer</param>
    Public Delegate Sub ErrorChunkingDelegate(exception As Exception, index As Integer)
    ''' <summary>
    ''' Report runtime exception while chunking
    ''' </summary>
    Public Shared Event OnChunkingException As ErrorChunkingDelegate


#End Region

    ''' <summary>
    ''' Location to place chunked files
    ''' </summary>
    Public Shared ChunkFolderLocation As String

    ''' <summary>
    ''' Responsible for cleaning <see cref="ChunkFolderLocation"/>
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function CleanFolder() As (verified As Boolean, exception As Exception)
        If Directory.Exists(ChunkFolderLocation) Then
            Dim files = Directory.GetFiles(ChunkFolderLocation, "*.txt")

            Try
                For Each file In files
                    IO.File.Delete(file)
                Next file
            Catch exception As Exception
                Return (False, exception)
            End Try
        End If

        Return (True, Nothing)

    End Function

    ''' <summary>
    ''' Ensure that the chunk folder exists
    ''' </summary>
    ''' <param name="folder">Folder to verify existence</param>
    ''' <returns>ValueTuple, true if exists, false + exception if failure to create</returns>
    Public Shared Function EnsureChunkFolderExists(folder As String) As (verified As Boolean, exception As Exception)
        Try
            If Not Directory.Exists(folder) Then
                Directory.CreateDirectory(folder)
            End If

            Return (True, Nothing)

        Catch exception As Exception
            Return (False, exception)
        End Try

    End Function

    ''' <summary>
    ''' Chunk a file by <see cref="chunkSize"/> lines
    ''' </summary>
    ''' <param name="fileName">File to chunk</param>
    ''' <param name="chunkSize">Lines to split fileName by</param>
    ''' <param name="folder">Folder location for chunk files, can be empty</param>
    ''' <param name="baseFileName">Individual chunk file base name</param>
    Public Shared Sub ChunkFile(fileName As String, chunkSize As Integer, folder As String, baseFileName As String)

        Dim counter As Integer = 1

        Try

            For Each lineArray In ChunkLines(fileName, chunkSize)
                Dim currentFileName = Path.Combine(ChunkFolderLocation, $"{baseFileName}{counter}.txt")
                File.WriteAllLines(currentFileName, lineArray)
                OnProcessEventEvent?.Invoke(Path.GetFileName(currentFileName))

                counter += 1
            Next

        Catch exception As Exception
            OnChunkingExceptionEvent?.Invoke(exception, counter)
        End Try

    End Sub
    ''' <summary>
    ''' Chunk/split lines in a file
    ''' </summary>
    ''' <param name="fileName">Existing text file</param>
    ''' <param name="chunkByLines">Number of lines to chunk by</param>
    ''' <returns>IEnumerable&lt;string[]&gt;</returns>
    Public Shared Iterator Function ChunkLines(fileName As String, chunkByLines As Integer) As IEnumerable(Of String())
        If chunkByLines <= 0 Then
            Throw New ArgumentOutOfRangeException(NameOf(chunkByLines))
        End If

        Using reader = New StreamReader(fileName)

            '            
            ' Read from start to finish of file contents
            '             
            Do While Not reader.EndOfStream

                Dim lineList = New List(Of String)()

                '                
                ' Populate string list until chunkByLines value is hit
                ' then return the list to the caller
                '                 
                Dim index = 0
                Do While index < chunkByLines AndAlso Not reader.EndOfStream
                    lineList.Add(reader.ReadLine())
                    index += 1
                Loop

                Yield lineList.ToArray()

            Loop
        End Using

    End Function
End Class