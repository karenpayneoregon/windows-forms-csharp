
Partial Public Class Form1
    ''' <summary>
    '''  Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    '''  Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    '''  Required method for Designer support - do not modify
    '''  the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.radioButtonSI = New System.Windows.Forms.RadioButton()
        Me.radioButtonIM = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        ' 
        ' listBox1
        ' 
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.ItemHeight = 15
        Me.listBox1.Location = New System.Drawing.Point(22, 14)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(147, 139)
        Me.listBox1.TabIndex = 1
        ' 
        ' radioButtonSI
        ' 
        Me.radioButtonSI.AutoSize = True
        Me.radioButtonSI.Location = New System.Drawing.Point(175, 14)
        Me.radioButtonSI.Name = "radioButtonSI"
        Me.radioButtonSI.Size = New System.Drawing.Size(34, 19)
        Me.radioButtonSI.TabIndex = 2
        Me.radioButtonSI.TabStop = True
        Me.radioButtonSI.Tag = "SI"
        Me.radioButtonSI.Text = "SI"
        Me.radioButtonSI.UseVisualStyleBackColor = True
        ' 
        ' radioButtonIM
        ' 
        Me.radioButtonIM.AutoSize = True
        Me.radioButtonIM.Checked = True
        Me.radioButtonIM.Location = New System.Drawing.Point(175, 39)
        Me.radioButtonIM.Name = "radioButtonIM"
        Me.radioButtonIM.Size = New System.Drawing.Size(39, 19)
        Me.radioButtonIM.TabIndex = 3
        Me.radioButtonIM.TabStop = True
        Me.radioButtonIM.Tag = "IM"
        Me.radioButtonIM.Text = "IM"
        Me.radioButtonIM.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 178)
        Me.Controls.Add(Me.radioButtonIM)
        Me.Controls.Add(Me.radioButtonSI)
        Me.Controls.Add(Me.listBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Code sample"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private listBox1 As System.Windows.Forms.ListBox
    Private radioButtonSI As System.Windows.Forms.RadioButton
    Private radioButtonIM As System.Windows.Forms.RadioButton
End Class