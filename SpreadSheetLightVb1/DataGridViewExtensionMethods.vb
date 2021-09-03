Imports System.IO

Public Module DataGridViewExtensionMethods
	''' <summary>
	''' Given a DataGridView populates without a data source,
	''' create a DataTable, populate from rows/cells from the
	''' DataGridView with an option to include/exclude column names.
	''' </summary>
	''' <param name="pDataGridView"></param>
	''' <param name="pColumnNames"></param>
	''' <returns></returns>
	''' <remarks>
	''' There is no attempt made to figure out data types coming
	''' from data in the DataGridView
	''' </remarks>
	<Runtime.CompilerServices.Extension>
	Public Function GetDataTable(pDataGridView As DataGridView, Optional pColumnNames As Boolean = True) As DataTable

		Dim dt As New DataTable()

		For Each column As DataGridViewColumn In pDataGridView.Columns

			If column.Visible Then
				If pColumnNames Then
					dt.Columns.Add(New DataColumn() With {.ColumnName = column.Name.Replace("Column", "")})
				Else
					dt.Columns.Add()
				End If
			End If

		Next column

		Dim cellValues(pDataGridView.Columns.Count - 1) As Object

		For Each row As DataGridViewRow In pDataGridView.Rows

			If Not row.IsNewRow Then
				For i As Integer = 0 To row.Cells.Count - 1
					cellValues(i) = row.Cells(i).Value
				Next i
				dt.Rows.Add(cellValues)
			End If

		Next row

		Return dt

	End Function
	''' <summary>
	''' Generates comma delimited rows into a string array.
	''' </summary>
	''' <param name="sender"></param>
	''' <returns></returns>
	''' <remarks></remarks>
	<Runtime.CompilerServices.Extension>
	Public Function CommaDelimitedRows(sender As DataGridView) As String()
		Return (
			From row In sender.Rows.Cast(Of DataGridViewRow)()
			Where Not CType(row, DataGridViewRow).IsNewRow
			Let RowItem = String.Join(",", Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell)().ToArray(), Function(c As DataGridViewCell) (If(c.Value Is Nothing, "", c.Value.ToString()))))
			Select RowItem).ToArray()
	End Function
	<Runtime.CompilerServices.Extension>
	Public Sub ExportToCommandDelimitedFile(pSender As DataGridView, pFileName As String)
		File.WriteAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, pFileName), pSender.CommaDelimitedRows())
	End Sub

End Module
