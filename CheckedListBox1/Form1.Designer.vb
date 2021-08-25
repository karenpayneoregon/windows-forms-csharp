<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MonthCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.RemoveCheckedButton = New System.Windows.Forms.Button()
        Me.RemoveCurrentButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MonthCheckedListBox
        '
        Me.MonthCheckedListBox.FormattingEnabled = True
        Me.MonthCheckedListBox.Location = New System.Drawing.Point(12, 12)
        Me.MonthCheckedListBox.Name = "MonthCheckedListBox"
        Me.MonthCheckedListBox.Size = New System.Drawing.Size(120, 184)
        Me.MonthCheckedListBox.TabIndex = 0
        '
        'RemoveCheckedButton
        '
        Me.RemoveCheckedButton.Location = New System.Drawing.Point(138, 12)
        Me.RemoveCheckedButton.Name = "RemoveCheckedButton"
        Me.RemoveCheckedButton.Size = New System.Drawing.Size(116, 23)
        Me.RemoveCheckedButton.TabIndex = 1
        Me.RemoveCheckedButton.Text = "Remove selected"
        Me.RemoveCheckedButton.UseVisualStyleBackColor = True
        '
        'RemoveCurrentButton
        '
        Me.RemoveCurrentButton.Location = New System.Drawing.Point(138, 41)
        Me.RemoveCurrentButton.Name = "RemoveCurrentButton"
        Me.RemoveCurrentButton.Size = New System.Drawing.Size(116, 23)
        Me.RemoveCurrentButton.TabIndex = 2
        Me.RemoveCurrentButton.Text = "Remove current"
        Me.RemoveCurrentButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 205)
        Me.Controls.Add(Me.RemoveCurrentButton)
        Me.Controls.Add(Me.RemoveCheckedButton)
        Me.Controls.Add(Me.MonthCheckedListBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Code sample"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MonthCheckedListBox As CheckedListBox
    Friend WithEvents RemoveCheckedButton As Button
    Friend WithEvents RemoveCurrentButton As Button
End Class
