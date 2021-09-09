<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class JsonForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MonthCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'MonthCheckedListBox
        '
        Me.MonthCheckedListBox.FormattingEnabled = True
        Me.MonthCheckedListBox.Location = New System.Drawing.Point(23, 19)
        Me.MonthCheckedListBox.Name = "MonthCheckedListBox"
        Me.MonthCheckedListBox.Size = New System.Drawing.Size(167, 184)
        Me.MonthCheckedListBox.TabIndex = 0
        '
        'JsonForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(212, 232)
        Me.Controls.Add(Me.MonthCheckedListBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "JsonForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Code sample"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MonthCheckedListBox As CheckedListBox
End Class
