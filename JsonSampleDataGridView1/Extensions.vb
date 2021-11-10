Imports System.ComponentModel

Public Module Extensions
    ''' <summary>
    ''' Convert a list to a DataTable
    ''' </summary>
    ''' <typeparam name="TSource">Type to convert from</typeparam>
    ''' <param name="data"><see cref="TSource"/></param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension>
    Public Function ToDataTable(Of TSource)(data As IList(Of TSource)) As DataTable
        Dim props As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(TSource))
        Dim table As New DataTable()

        For index As Integer = 0 To props.Count - 1
            Dim prop As PropertyDescriptor = props(index)
            table.Columns.Add(prop.Name, prop.PropertyType)
        Next index
        Dim values(props.Count - 1) As Object

        For Each item As TSource In data
            For index As Integer = 0 To values.Length - 1
                values(index) = props(index).GetValue(item)
            Next index
            table.Rows.Add(values)
        Next item
        Return table
    End Function

    ''' <summary>
    ''' Convert DataTable to List of T
    ''' </summary>
    ''' <typeparam name="TSource">Type to return from DataTable</typeparam>
    ''' <param name="table">DataTable</param>
    ''' <returns>List of <see cref="TSource"/>Expected type list</returns>
    <Runtime.CompilerServices.Extension>
    Public Function DataTableToList(Of TSource As New)(table As DataTable) As List(Of TSource)
        Dim list As New List(Of TSource)()

        Dim typeProperties = GetType(TSource).GetProperties().Select(
            Function(propertyInfo) New With {Key .PropertyInfo = propertyInfo, Key .Type =
                If(Nullable.GetUnderlyingType(propertyInfo.PropertyType), propertyInfo.PropertyType)}).ToList()

        For Each row In table.Rows.Cast(Of DataRow)()

            Dim current As New TSource()

            For Each typeProperty In typeProperties
                Dim value As Object = row(typeProperty.PropertyInfo.Name)
                Dim safeValue As Object = If(value Is Nothing OrElse DBNull.Value.Equals(value), Nothing, Convert.ChangeType(value, typeProperty.Type))
                typeProperty.PropertyInfo.SetValue(current, safeValue, Nothing)
            Next typeProperty

            list.Add(current)
        Next row

        Return list
    End Function
End Module