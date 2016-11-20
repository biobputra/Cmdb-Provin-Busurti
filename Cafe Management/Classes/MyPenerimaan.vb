Public Class MyPenerimaan
#Region "Class Properties"
    Private XIdPembelianH As Long
    Public Property IDPembelianH() As Long
        Get
            Return XIdPembelianH
        End Get
        Set(ByVal value As Long)
            XIdPembelianH = value
        End Set
    End Property

    Private XNomorPembelian As Long
    Public Property NomorPembelian() As Long
        Get
            Return XNomorPembelian
        End Get
        Set(ByVal value As Long)
            XNomorPembelian = value
        End Set
    End Property

    Private xIDSupplier As Long
    Public Property IDSupplier() As Long
        Get
            Return xIDSupplier
        End Get
        Set(ByVal value As Long)
            xIDSupplier = value
        End Set
    End Property

    Private xCompany As String
    Public Property Company() As String
        Get
            Return xCompany
        End Get
        Set(ByVal value As String)
            xCompany = value
        End Set
    End Property

    Private xContactName As String
    Public Property ContactName() As String
        Get
            Return xContactName
        End Get
        Set(ByVal value As String)
            xContactName = value
        End Set
    End Property
#End Region

#Region "Class Methods"

#End Region
End Class
