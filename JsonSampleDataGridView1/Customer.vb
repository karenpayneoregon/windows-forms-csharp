Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class Customer
    Implements INotifyPropertyChanged

    Private _identifier As Integer
    Private _companyName As String
    Private _contactType As String
    Private _contactName As String
    Private _genderType As String
    Private _contactTypeIdentifier As Integer
    Private _genderIdentifier As Integer

    Public Property Identifier() As Integer
        Get
            Return _identifier
        End Get
        Set(ByVal value As Integer)
            _identifier = value
            OnPropertyChanged()
        End Set
    End Property

    Public Property CompanyName() As String
        Get
            Return _companyName
        End Get
        Set(ByVal value As String)
            _companyName = value
            OnPropertyChanged()
        End Set
    End Property

    Public Property ContactType() As String
        Get
            Return _contactType
        End Get
        Set(ByVal value As String)
            _contactType = value
            OnPropertyChanged()
        End Set
    End Property

    Public Property ContactName() As String
        Get
            Return _contactName
        End Get
        Set(ByVal value As String)
            _contactName = value
            OnPropertyChanged()
        End Set
    End Property

    Public Property GenderType() As String
        Get
            Return _genderType
        End Get
        Set(ByVal value As String)
            _genderType = value
            OnPropertyChanged()
        End Set
    End Property

    Public Property ContactTypeIdentifier() As Integer
        Get
            Return _contactTypeIdentifier
        End Get
        Set(ByVal value As Integer)
            _contactTypeIdentifier = value
            OnPropertyChanged()
        End Set
    End Property

    Public Property GenderIdentifier() As Integer
        Get
            Return _genderIdentifier
        End Get
        Set(ByVal value As Integer)
            _genderIdentifier = value
            OnPropertyChanged()
        End Set
    End Property


    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Protected Overridable Sub OnPropertyChanged(<CallerMemberName> Optional ByVal propertyName As String = Nothing)
        PropertyChangedEvent?.Invoke(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
End Class