Imports System.ComponentModel
Imports CheckedListBox1.Classes

Public Class JsonForm
    Private Sub JsonForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MonthCheckedListBox.LoadJson()
    End Sub
    Private Sub JsonForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MonthCheckedListBox.SaveToJson()
    End Sub
End Class