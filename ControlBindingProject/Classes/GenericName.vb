Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace Classes
    Public Class GenericName
        Implements INotifyPropertyChanged

        Private _name As String

        Public Property Name() As String
            Get
                Return _name
            End Get
            Set
                _name = Value
                OnPropertyChanged()
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return Name
        End Function

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
        Protected Overridable Sub OnPropertyChanged(<CallerMemberName> Optional ByVal propertyName As String = Nothing)
            PropertyChangedEvent?.Invoke(Me, New PropertyChangedEventArgs(propertyName))
        End Sub
    End Class
End NameSpace