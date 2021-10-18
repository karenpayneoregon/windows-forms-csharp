Imports System.IO

Public Class Form1
    Private ReadOnly BindSource1 As New BindingSource
    Private ReadOnly BindSource2 As New BindingSource
    Private ReadOnly FileName as String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Questions.csv")
    Private Sub ReadButton_Click(sender As Object, e As EventArgs) Handles ReadButton.Click
        BindSource1.DataSource = FileOperations.Read(FileName)
        DataGridView1.DataSource = BindSource1
    End Sub

    Private Sub FilterButton_Click(sender As Object, e As EventArgs) Handles FilterButton.Click
        Dim records = CType(BindSource1.DataSource,List(Of Item)).
                Select(Function(item) New Item With{.Id = item.Id, .Question = item.Question}).ToList()

        BindSource2.DataSource = records
        DataGridView2.DataSource = BindSource2
        
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim records = CType(BindSource2.DataSource,List(Of Item)).
                Select(Function(item) New Item With{.Id = item.Id, .Question = item.Question}).ToList()

        FileOperations.Save(FileName,records)
    End Sub
End Class