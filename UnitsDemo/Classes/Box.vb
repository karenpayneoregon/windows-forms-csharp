Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace Classes
	Public Class Box
		Implements INotifyPropertyChanged

		Private _unit As Unit
		Private _length As Double

		Public Property Length() As Double
			Get
				Return _length
			End Get
			Set
				_length = Value
			End Set
		End Property

		Public Property Width() As Integer

		Public Property Unit() As Unit
			Get
				Return _unit
			End Get
			Set
				_unit = Value
				OnPropertyChanged()

				If Unit = Unit.SI Then
					Length *= 25.400013716
				Else
					Length *= 0.0393701
				End If

			End Set
		End Property

		Public Overrides Function ToString() As String
			Return Length.ToString()
		End Function

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
		Protected Overridable Sub OnPropertyChanged(<CallerMemberName> Optional ByVal propertyName As String = Nothing)
			PropertyChangedEvent?.Invoke(Me, New PropertyChangedEventArgs(propertyName))
		End Sub

	End Class
End Namespace
