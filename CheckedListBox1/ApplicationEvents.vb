Imports System.Reflection
Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    Partial Friend Class MyApplication
        Public backColorDictionary As Dictionary(Of Integer, Color) = CreateColorsDictionary()

        Public Shared Function ColorStructToList() As List(Of Color)
            Return GetType(Color).GetProperties(
                BindingFlags.Static Or
                BindingFlags.DeclaredOnly Or
                BindingFlags.Public).Select(
                    Function(c)
                        Return CType(c.GetValue(Nothing, Nothing), Color)
                    End Function).ToList()
        End Function
        Private Function CreateColorsDictionary() As Dictionary(Of Integer, Color)
            Dim colors = ColorStructToList()

            Dim results = colors.Select(Function(item, index) New With
                                           {
                                                .Index = index + 1,
                                                .Color = item
                                           })
            Dim Dictionary = New Dictionary(Of Integer, Color)


            For Each anonymous In results

                If anonymous.Color = Color.Transparent Then
                    Dictionary.Add(anonymous.Index, Color.White)
                Else
                    Dictionary.Add(anonymous.Index, anonymous.Color)
                End If

            Next

            Return Dictionary

        End Function

        Private _color As Color
        ''' <summary>
        ''' Form background color
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property BackColor() As Color
            Get
                Return _color
            End Get
        End Property

        ''' <summary>
        ''' Logic to determine background color to use or a default if more instance
        ''' of the application open than colors in <see cref="backColorDictionary"/>
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup

            Dim currentProcess = Process.GetCurrentProcess().ProcessName
            Dim counter = Process.GetProcessesByName(currentProcess).Length
            If counter <= backColorDictionary.Count Then
                _color = backColorDictionary(counter)               '
            Else
                _color = Color.White
            End If



        End Sub
    End Class
End Namespace
