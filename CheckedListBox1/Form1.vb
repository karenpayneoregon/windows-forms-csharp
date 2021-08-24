Imports System.Globalization

Public Class Form1
    Private Sub RemoveCheckedButton_Click(sender As Object, e As EventArgs) Handles RemoveCheckedButton.Click

        If MonthCheckedListBox.CheckedItems.Count > 0 Then

            MonthCheckedListBox.CheckedItems.Cast(Of String)().ToList().
                ForEach(Sub(item) MonthCheckedListBox.Items.Remove(item))

            SetActive()

        End If

    End Sub
    Private Sub RemoveCurrentButton_Click(sender As Object, e As EventArgs) Handles RemoveCurrentButton.Click

        If MonthCheckedListBox.Items.Count > 0 Then
            MonthCheckedListBox.Items.RemoveAt(MonthCheckedListBox.SelectedIndex)
            SetActive()
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MonthCheckedListBox.Items.AddRange(
            Enumerable.Range(1, 12).
                    Select(Function(index)
                               Return DateTimeFormatInfo.CurrentInfo.GetMonthName(index)
                           End Function).ToArray())

        SetActive()

    End Sub
    Private Sub SetActive()

        ActiveControl = MonthCheckedListBox

        If MonthCheckedListBox.Items.Count > 0 Then
            MonthCheckedListBox.SelectedIndex = 0
        End If

    End Sub
End Class
