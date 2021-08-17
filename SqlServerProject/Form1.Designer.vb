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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FirstNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HireDateColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddNewButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.RemoveCurrentButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstNameColumn, Me.LastColumn, Me.HireDateColumn})
        Me.DataGridView1.Location = New System.Drawing.Point(8, 1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(428, 316)
        Me.DataGridView1.TabIndex = 0
        '
        'FirstNameColumn
        '
        Me.FirstNameColumn.DataPropertyName = "FirstName"
        Me.FirstNameColumn.HeaderText = "First"
        Me.FirstNameColumn.Name = "FirstNameColumn"
        '
        'LastColumn
        '
        Me.LastColumn.DataPropertyName = "LastName"
        Me.LastColumn.HeaderText = "Last"
        Me.LastColumn.Name = "LastColumn"
        '
        'HireDateColumn
        '
        Me.HireDateColumn.DataPropertyName = "HireDate"
        Me.HireDateColumn.HeaderText = "Hired"
        Me.HireDateColumn.Name = "HireDateColumn"
        '
        'AddNewButton
        '
        Me.AddNewButton.Location = New System.Drawing.Point(166, 460)
        Me.AddNewButton.Name = "AddNewButton"
        Me.AddNewButton.Size = New System.Drawing.Size(117, 23)
        Me.AddNewButton.TabIndex = 1
        Me.AddNewButton.Text = "Add new"
        Me.AddNewButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 331)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "First"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(12, 354)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(148, 23)
        Me.FirstNameTextBox.TabIndex = 3
        Me.FirstNameTextBox.Text = "Karen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 390)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Last"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(12, 408)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(148, 23)
        Me.LastNameTextBox.TabIndex = 5
        Me.LastNameTextBox.Text = "Payne"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 440)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Hired"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 458)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(148, 23)
        Me.DateTimePicker1.TabIndex = 7
        '
        'RemoveCurrentButton
        '
        Me.RemoveCurrentButton.Location = New System.Drawing.Point(319, 458)
        Me.RemoveCurrentButton.Name = "RemoveCurrentButton"
        Me.RemoveCurrentButton.Size = New System.Drawing.Size(117, 23)
        Me.RemoveCurrentButton.TabIndex = 8
        Me.RemoveCurrentButton.Text = "Remove current"
        Me.RemoveCurrentButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 505)
        Me.Controls.Add(Me.RemoveCurrentButton)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AddNewButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Code sample"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FirstNameColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastColumn As DataGridViewTextBoxColumn
    Friend WithEvents HireDateColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddNewButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents RemoveCurrentButton As Button
End Class
