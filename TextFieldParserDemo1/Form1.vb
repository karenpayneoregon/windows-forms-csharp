Imports System.IO

Public Class Form1
    Private Sub ReadStudentsFileButton_Click(sender As Object, e As EventArgs) _
        Handles ReadStudentsFileButton.Click

        Dim students = FileOperations.Read(1)

        Dim EnglishList = students.Where(Function(student) student.Course = "English")

        Dim AverageList = EnglishList.Average(Function(student) student.Grade)

        Debug.WriteLine(AverageList)

    End Sub
End Class
Public Class Student
    Public Property Id() As Integer
    Public Property FirstName() As String
    Public Property LastName() As String
    Public Property Course() As String
    Public Property ClassName As String
    Public Property Grade() As Decimal

    Public Overrides Function ToString() As String
        Return $"{FirstName} {LastName}"
    End Function
End Class

Public Class FileOperations
    Public Shared Function Read(studentIdentifier As Integer) As List(Of Student)

        Return (From line In File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.txt"))
                Where line.Length > 0
                Let Items = line.Split(","c)
                Select New Student() With
                {
                    .Id = CInt(Items(0)),
                    .FirstName = Items(1),
                    .LastName = Items(2),
                    .Course = Items(3),
                    .ClassName = Items(4),
                    .Grade = CDec(Items(5))
                }).Where(Function(student) student.Id = studentIdentifier).ToList()


    End Function
End Class
