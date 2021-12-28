Public Module ControlExtensions
    <Runtime.CompilerServices.Extension>
    Public Iterator Function Descendants(Of T As Class)(control As Control) As IEnumerable(Of T)
        For Each child As Control In control.Controls
            Dim thisControl As T = TryCast(child, T)
            If thisControl IsNot Nothing Then
                Yield thisControl
            End If

            If child.HasChildren Then
                For Each descendant As T In child.Descendants(Of T)()
                    Yield descendant
                Next
            End If
        Next
    End Function

End Module