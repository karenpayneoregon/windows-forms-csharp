<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.NumericTextBox1 = New NumericTextBoxSample.NumericTextBox()
        Me.RadNumericTextBox1 = New NumericTextBoxSample.RadNumericTextBox()
        CType(Me.RadNumericTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(38, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'NumericTextBox1
        '
        Me.NumericTextBox1.Location = New System.Drawing.Point(37, 12)
        Me.NumericTextBox1.MaxNumber = 3
        Me.NumericTextBox1.MinNumber = 1
        Me.NumericTextBox1.Name = "NumericTextBox1"
        Me.NumericTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.NumericTextBox1.TabIndex = 0
        Me.NumericTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadNumericTextBox1
        '
        Me.RadNumericTextBox1.Location = New System.Drawing.Point(37, 101)
        Me.RadNumericTextBox1.Name = "RadNumericTextBox1"
        Me.RadNumericTextBox1.Size = New System.Drawing.Size(100, 18)
        Me.RadNumericTextBox1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 168)
        Me.Controls.Add(Me.RadNumericTextBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.NumericTextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.RadNumericTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NumericTextBox1 As NumericTextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RadNumericTextBox1 As RadNumericTextBox
End Class
