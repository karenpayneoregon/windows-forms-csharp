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
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.GetCurrentCategoryButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(24, 36)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(171, 21)
        Me.CategoryComboBox.TabIndex = 3
        '
        'GetCurrentCategoryButton
        '
        Me.GetCurrentCategoryButton.Location = New System.Drawing.Point(201, 34)
        Me.GetCurrentCategoryButton.Name = "GetCurrentCategoryButton"
        Me.GetCurrentCategoryButton.Size = New System.Drawing.Size(75, 23)
        Me.GetCurrentCategoryButton.TabIndex = 4
        Me.GetCurrentCategoryButton.Text = "Button1"
        Me.GetCurrentCategoryButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 202)
        Me.Controls.Add(Me.GetCurrentCategoryButton)
        Me.Controls.Add(Me.CategoryComboBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents CategoryComboBox As ComboBox
    Friend WithEvents GetCurrentCategoryButton As Button
End Class
