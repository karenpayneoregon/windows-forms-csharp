Option Infer On
Imports System.IO


''' <summary>
''' Provides verification that a input file was chunked properly.
''' </summary>
Public Class ValidationOperations
    ''' <summary>
    ''' Location of chunk files chunked from a larger file
    ''' </summary>
    Public Shared Property ChunkFolderLocation() As String
    ''' <summary>
    ''' Verify chunking process worked
    ''' </summary>
    ''' <param name="incomingFileName">File that was chunked</param>
    ''' <returns>Named Value Tuple</returns>
    ''' <remarks>
    ''' As is, the <see cref="Verify"/> list is not truly used although
    ''' with different requirements like displaying in a visual control would
    ''' be helpful in some apps like SIDES MPC which uses the list.
    ''' </remarks>
    Public Shared Function VerifyLineCounts(incomingFileName As String) As (chunks As Verify, baseVerify As Verify)

        Dim verificationList = New List(Of Verify)()

        Dim directory = New DirectoryInfo(ChunkFolderLocation)
        Dim files = directory.GetFiles("*.*", SearchOption.AllDirectories)

        Dim lineCount = 0
        Dim totalLines = 0

        '            
        ' Loop through each chunk file, get line count
        '             
        For Each fileInfo In files
            Using reader = File.OpenText(Path.Combine(ChunkFolderLocation, fileInfo.Name))
                Do While reader.ReadLine() IsNot Nothing
                    lineCount += 1
                Loop
            End Using

            verificationList.Add(New Verify() With {.FileName = fileInfo.Name, .Count = lineCount})

            totalLines += lineCount
            lineCount = 0

        Next fileInfo

        '            
        '             * Total line count for all chunked files
        '             
        Dim totalChunkVerify = New Verify() With {
                .FileName = "Total",
                .Count = totalLines
                }

        verificationList.Add(totalChunkVerify)

        lineCount = 0

        '            
        ' Get line count of file that was chunked
        ' (There are many ways to do a line count)
        '             
        Using reader = File.OpenText(incomingFileName)
            Do While reader.ReadLine() IsNot Nothing
                lineCount += 1
            Loop
        End Using

        '            
        ' File which was chunked
        '             
        Dim baseFileVerify = New Verify() With {.FileName = Path.GetFileName(incomingFileName), .Count = lineCount}

        verificationList.Add(baseFileVerify)

        Return (totalChunkVerify, baseFileVerify)

    End Function

End Class