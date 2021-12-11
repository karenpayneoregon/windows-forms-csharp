Imports StackOverFlowLibrary

Module Module1
    Private ReadOnly folderList As New List(Of String)()
    Private ReadOnly folderDictionary As New Dictionary(Of Integer, String)

    Sub Main()
        AddHandler DirectoryHelper.TraverseFolder, AddressOf DirectoryHelperOnTraverseFolder
        Dim path = "C:\Program Files (x86)\Microsoft SQL Server Management Studio 18\Common7\IDE\en"

        DirectoryHelper.TraversePath(path)

        For Each keyValuePair As KeyValuePair(Of Integer, String) In folderDictionary
            Debug.WriteLine($"{keyValuePair.Key,-3}{keyValuePair.Value}")
        Next



    End Sub
    Private Sub DirectoryHelperOnTraverseFolder(sender As String)

        If sender = DirectoryHelper.DoneMessage Then
            folderList.Reverse(0, folderList.Count)
            For index As Integer = 0 To folderList.Count - 1
                folderDictionary.Add(index, folderList(index))
            Next
        Else
            folderList.Add(sender)
        End If

    End Sub
End Module
