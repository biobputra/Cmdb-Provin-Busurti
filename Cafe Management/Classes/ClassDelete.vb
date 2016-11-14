Public Class ClassDelete
    Private xNamaTabel As String
    Public Property NamaTabel() As String
        Get
            Return xNamaTabel
        End Get
        Set(ByVal value As String)
            xNamaTabel = value
        End Set
    End Property

    Private xIDPengguna As Integer
    Public Property IDPengguna() As Integer
        Get
            Return xIDPengguna
        End Get
        Set(ByVal value As Integer)
            xIDPengguna = value
        End Set
    End Property

    Private xIdJenisMeja As Int16
    Public Property IDJenisMeja() As Int16
        Get
            Return xIdJenisMeja
        End Get
        Set(ByVal value As Int16)
            xIdJenisMeja = value
        End Set
    End Property


End Class
