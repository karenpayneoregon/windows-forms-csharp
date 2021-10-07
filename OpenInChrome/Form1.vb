Imports Microsoft.Win32

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        if Not IsChromeAvailable
            OpenPageButton.Enabled = False
        End If
    End Sub

    Private Sub OpenPageButton_Click(sender As Object, e As EventArgs) Handles OpenPageButton.Click

        if Not string.IsNullOrWhiteSpace(PageTextBox.Text)
            OpenLink(PageTextBox.Text)
        End If

    End Sub
End Class
''' <summary>
''' For opening a page in Chrome browser
''' </summary>
''' <remarks>
''' * If Chrome.exe was in the path this class is not needed.
''' * If the user running the app does not have read permissions to the registry
'''   a runtime exception will be thrown.
''' </remarks>
Public Module ChromeLauncher

    Private Const ChromeAppKey As String = 
        "\Software\Microsoft\Windows\CurrentVersion\App Paths\chrome.exe"

    Public ReadOnly Property ChromeAppFileName() As String
        Get
            Return DirectCast(
                If(Registry.GetValue($"HKEY_LOCAL_MACHINE{ChromeAppKey}", 
                                     "", 
                                     Nothing), 
                   Registry.GetValue($"HKEY_CURRENT_USER{ChromeAppKey}", "", Nothing)), 
                String)
        End Get
    End Property
    Public ReadOnly Property IsChromeAvailable() As Boolean
    get
        Return Not String.IsNullOrWhiteSpace(ChromeAppFileName)
    End Get
    End Property
    Public Sub OpenLink( url As String)

        Dim FileName As String = ChromeAppFileName

        If String.IsNullOrWhiteSpace(FileName) Then
            Throw New Exception("Could not find chrome.exe!!!")
        End If

        Process.Start(FileName, url)

    End Sub
End Module
