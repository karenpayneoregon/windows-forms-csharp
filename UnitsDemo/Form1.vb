Imports System.ComponentModel
Imports System.Windows.Forms
Imports Classes

Partial Public Class Form1
    Inherits Form

    Private ReadOnly _dataSource As New BindingList(Of Box)()
    Public Sub New()
        InitializeComponent()

        _dataSource = New BindingList(Of Box)(MockedData.Boxes())

        listBox1.DataSource = _dataSource

        AdjustUnits()

        AddHandler radioButtonIM.CheckedChanged, AddressOf RadioButtonOnCheckedChanged
        AddHandler radioButtonSI.CheckedChanged, AddressOf RadioButtonOnCheckedChanged

    End Sub

    Private Sub RadioButtonOnCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim rb = DirectCast(sender, RadioButton)

        If rb IsNot Nothing Then
            If rb.Checked Then
                AdjustUnits()
            End If
        End If

    End Sub

    Private Sub AdjustUnits()
        Dim unitType As String = Controls.OfType(Of RadioButton)().FirstOrDefault(Function(r) r.Checked).Tag.ToString()

        Dim unit As Unit

        [Enum].TryParse(unitType, unit)

        For index As Integer = 0 To listBox1.Items.Count - 1
            Dim item As Box = _dataSource(index)
            item.Unit = unit
        Next

    End Sub
End Class