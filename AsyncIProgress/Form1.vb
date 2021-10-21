Imports System.Threading

Public Class Form1
    Private _cts As New CancellationTokenSource()
    Public Sub New()
        InitializeComponent()

        StatusLabel.Text = ""

    End Sub
    Private Async Function AsyncMethod(progress As IProgress(Of Integer), ct As CancellationToken) As Task

        For index As Integer = 100 To 120
            'Simulate an async call that takes some time to complete
            Await Task.Delay(200)

            If ct.IsCancellationRequested Then
                ct.ThrowIfCancellationRequested()
            End If

            If progress IsNot Nothing Then
                progress.Report(index)
            End If

        Next

    End Function

    Private Async Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click

        Dim cancelled = False
        If _cts.IsCancellationRequested = True Then
            _cts.Dispose()
            _cts = New CancellationTokenSource()
        End If


        Dim progressIndicator = New Progress(Of Integer)(AddressOf ReportProgress)
        Try
            Await AsyncMethod(progressIndicator, _cts.Token)
        Catch ex As OperationCanceledException
            StatusLabel.Text = "Cancelled"
            cancelled = True
        End Try

        If cancelled Then
            Await Task.Delay(1000)
            StatusLabel.Text = "Go again!"
        End If

    End Sub
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancellButton.Click
        _cts.Cancel()
    End Sub
    Private Sub ReportProgress(value As Integer)
        StatusLabel.Text = value.ToString()
        TextBox1.Text = value.ToString()
    End Sub

End Class
