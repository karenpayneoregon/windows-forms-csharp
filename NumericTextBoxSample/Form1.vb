Imports System.ComponentModel
Imports System.Globalization
Imports Telerik.WinControls

Public Class Form1

End Class

Public Class RadNumericTextBox
    Inherits UI.RadTextBox

    Protected Overrides Sub OnTextChanging(e As TextChangingEventArgs)
        e.Cancel = Not IsNumber(e.NewValue)
        MyBase.OnTextChanging(e)
    End Sub

    Private Function IsNumber(value As String) As Boolean
        Dim res As Boolean = True

        Try
            If Not String.IsNullOrEmpty(value) AndAlso ((value.Length <> 1) OrElse (value <> "-")) Then
                Dim d As Decimal = Decimal.Parse(value, CultureInfo.CurrentCulture)
            End If
        Catch
            res = False
        End Try

        Return res
    End Function
End Class
Public Class NumericTextBox
    Inherits TextBox

    Private ReadOnly _decimalSeparator As Char = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

    Public Sub New()
        TextAlign = HorizontalAlignment.Right
    End Sub

    Protected Overrides Sub OnKeyPress(ByVal e As KeyPressEventArgs)

        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> _decimalSeparator Then
            e.Handled = True
        End If

        If e.KeyChar = _decimalSeparator AndAlso Text.IndexOf(_decimalSeparator) > -1 Then
            e.Handled = True
        End If

        MyBase.OnKeyPress(e)

    End Sub


    Public Function HasValue() As Boolean
        Return Not String.IsNullOrWhiteSpace(Text)
    End Function
    Public Function AsDecimal() As Decimal
        Dim value As Decimal
        Return If(Decimal.TryParse(Text, value), value, 0)
    End Function

    Public Function AsInteger() As Integer
        Dim value As Integer
        Return If(Integer.TryParse(Text, value), value, 0)
    End Function

    Private WM_PASTE As Integer = &H302
    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = WM_PASTE Then
            Dim clipboardData = Clipboard.GetDataObject()
            Dim input = CStr(clipboardData?.GetData(GetType(String)))
            Dim count As Integer = 0

            For Each c As Char In input
                If c = _decimalSeparator Then
                    count += 1
                    If count > 1 Then
                        Return
                    End If
                End If
            Next

            For Each character In input

                If Not Char.IsControl(character) AndAlso Not Char.IsDigit(character) AndAlso character <> _decimalSeparator Then
                    m.Result = New IntPtr(0)
                    Return
                End If

            Next
        End If

        MyBase.WndProc(m)

    End Sub

    <Description("Min range value"), Category("Behavior")>
    Public Property MinNumber() As Integer
    <Description("Max range value"), Category("Behavior")>
    Public Property MaxNumber() As Integer

    Protected Overrides Sub OnTextChanged(e As EventArgs)

        If AsInteger().Between(MinNumber, MaxNumber) Then
            MyBase.OnTextChanged(e)
        Else
            Text = ""
        End If

    End Sub

End Class
Public Module GenericExtensions
    <Runtime.CompilerServices.Extension>
    Public Function Between(Of T)(sender As IComparable(Of T), minimumValue As T, maximumValue As T) As Boolean
        Return sender.CompareTo(minimumValue) >= 0 AndAlso sender.CompareTo(maximumValue) <= 0
    End Function

End Module