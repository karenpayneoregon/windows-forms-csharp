Imports System.ComponentModel

Public Class Form1
    Private StartPauseButton As CustomButton
    Private CurrentCount As Integer = 0
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click

        CurrentCount += 1

        StartPauseButton = New CustomButton()
        StartPauseButton.Location = New Point(370, 10)
        StartPauseButton.Size() = New Size(30, 25)
        StartPauseButton.Text = "X"
        StartPauseButton.Identifier = CurrentCount
        StartPauseButton.Name = "StartPauseButton"
        Controls.Add(StartPauseButton)

        CustomLabel1.SetLabel("Current ", CurrentCount)

    End Sub

    Private Sub IncrementButton_Click(sender As Object, e As EventArgs) Handles IncrementButton.Click

        CurrentCount += 1
        StartPauseButton.Identifier = CurrentCount
        CustomLabel1.SetLabel("Current ", CurrentCount)

    End Sub

    Private Sub RemoveButtonButton_Click(sender As Object, e As EventArgs) Handles RemoveButtonButton.Click

        Dim button = Controls.OfType(Of CustomButton).FirstOrDefault(Function(x) x.Identifier = CurrentCount)

        If button IsNot Nothing Then
            Controls.Remove(button)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomLabel1.SetLabel("Current ", CurrentCount)
    End Sub
End Class

Public Class CustomButton
    Inherits Button

    <Category("Behavior"), Description("Constant identifier")>
    Public Property Identifier() As Integer
End Class

Public Class CustomPanel
    Inherits Panel

    <Category("Behavior"), Description("Constant identifier")>
    Public Property Identifier() As Integer
End Class

Public Class CustomLabel
    Inherits Label

    <Category("Behavior"), Description("Constant identifier")>
    Public Property Identifier() As Integer

    Public Sub SetLabel(content As String, value As Integer)
        Text = $"{content} {value}"
    End Sub
    <Browsable(False), EditorBrowsable(EditorBrowsableState.Never)>
    Public ReadOnly Property AsInteger() As Integer
        Get
            Return CInt(Text)
        End Get
    End Property
End Class
