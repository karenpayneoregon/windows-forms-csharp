Namespace Classes
	Public Class MockedData
		Public Shared Function Boxes() As List(Of Box)
			Return New List(Of Box)() From {
				New Box() With {
					.Length = 25,
					.Unit = Unit.IM
				},
				New Box() With {
					.Length = 26,
					.Unit = Unit.IM
				},
				New Box() With {
					.Length = 27,
					.Unit = Unit.IM
				}
			}
		End Function
	End Class
End Namespace
