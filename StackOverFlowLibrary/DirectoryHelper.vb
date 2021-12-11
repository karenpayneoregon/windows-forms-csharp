Option Infer On
Imports System.IO

Public Module DirectoryHelper

    Public Delegate Sub OnTraverse(sender As String)
    Public Event TraverseFolder As OnTraverse
    Public ReadOnly Property DoneMessage() As String
        Get
            Return "Done"
        End Get
    End Property

    Public Function TraversePath(folderName As String, Optional level As Integer = 20) As String

        Dim folderList = New List(Of String) From {folderName}

        TraverseFolderEvent?.Invoke(folderName)

        Do While Not String.IsNullOrWhiteSpace(folderName)

            Dim parentFolder = Directory.GetParent(folderName)

            If parentFolder Is Nothing Then
                Exit Do
            End If

            folderName = Directory.GetParent(folderName)?.FullName
            folderList.Add(folderName)
            TraverseFolderEvent?.Invoke(folderName)

        Loop

        If folderList.Count > 0 AndAlso level > 0 Then
            If level - 1 <= folderList.Count - 1 Then
                Return folderList(level - 1)
            Else
                TraverseFolderEvent?.Invoke(DoneMessage)
                Return folderName
            End If
        Else
            Return folderName
        End If

    End Function
End Module
