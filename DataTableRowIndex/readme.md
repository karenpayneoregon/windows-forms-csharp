Example to get hidden row id for a DataRow

```basic
Public Module ExtensionMethods
    <Runtime.CompilerServices.Extension()>
    Public Function RowId(row As DataRow) As Integer
        Return CInt(row.GetType().GetField("_rowID",
        Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance).
            GetValue(row))
    End Function
End Module
```