Imports System.ComponentModel

Public Class Form1

	Private ReadOnly customersBindingSourceTop As New BindingSource()
	Private ReadOnly customersBindingSourceBottom As New BindingSource()
	Private gridConfiguration As GridConfiguration

	Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		DataOperations.Save(gridConfiguration)
	End Sub

	Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
		SelectionsComboBox.DataSource = FileOperations.GetJsonFile()
		DataGridView1.AutoGenerateColumns = False

		gridConfiguration = DataOperations.ReadConfiguration()

		For index As Integer = 0 To gridConfiguration.ColumnDefinitions.Count - 1

			If gridConfiguration.ColumnDefinitions(index).Visible Then

				DataGridView1.Columns.Add(New DataGridViewColumn() With {
												 .CellTemplate = New DataGridViewTextBoxCell(),
												 .DataPropertyName = gridConfiguration.ColumnDefinitions(index).DataPropertyName,
												 .HeaderText = gridConfiguration.ColumnDefinitions(index).HeaderText
											 })

			End If

		Next index

		customersBindingSourceTop.DataSource = gridConfiguration.Customers
		DataGridView1.DataSource = customersBindingSourceTop

		Dim table = gridConfiguration.Customers.ToDataTable()

		For columnIndex As Integer = 0 To gridConfiguration.ColumnDefinitions.Count - 1
			If Not gridConfiguration.ColumnDefinitions(columnIndex).Visible Then
				table.Columns(gridConfiguration.ColumnDefinitions(columnIndex).DataPropertyName).ColumnMapping = MappingType.Hidden
			End If
		Next

		customersBindingSourceBottom.DataSource = table
		DataGridView2.DataSource = customersBindingSourceBottom

		For Each column As DataGridViewColumn In DataGridView2.Columns

			Dim current = gridConfiguration.ColumnDefinitions.FirstOrDefault(Function(ColumnDefinition) ColumnDefinition.DataPropertyName = column.DataPropertyName)
			If current IsNot Nothing Then
				column.HeaderText = current.HeaderText
			End If

		Next

		Dim list = table.DataTableToList(Of Customer)()

	End Sub
End Class