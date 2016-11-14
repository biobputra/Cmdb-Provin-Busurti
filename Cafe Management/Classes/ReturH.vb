Public Class ReturH

#Region "Properties"

    Private xTanggalRetur As Date
    Public Property TanggalRetur() As Date
        Get
            Return xTanggalRetur
        End Get
        Set(value As Date)
            xTanggalRetur = value
        End Set
    End Property

    Private xStatus As Int32
    Public Property Status() As Int32
        Get
            Return xStatus
        End Get
        Set(value As Int32)
            xStatus = value
        End Set
    End Property

    Private xCreatedBy As Integer
    Public Property CreatedBy() As Integer
        Get
            Return xCreatedBy
        End Get
        Set(value As Integer)
            xCreatedBy = value
        End Set
    End Property

    Private xModifiedBy As Integer
    Public Property ModifiedBy() As Integer
        Get
            Return xModifiedBy
        End Get
        Set(value As Integer)
            xModifiedBy = value
        End Set
    End Property

    Private xCreatedDate As DateTime
    Public Property CreatedDate() As DateTime
        Get
            Return xCreatedDate
        End Get
        Set(value As DateTime)
            xCreatedDate = value
        End Set
    End Property

    Private xModifiedDate As DateTime
    Public Property ModifiedDate() As DateTime
        Get
            Return xModifiedDate
        End Get
        Set(value As DateTime)
            xModifiedDate = value
        End Set
    End Property

    Private xIDReturH As Long
    Public Property IDReturH() As Long
        Get
            Return xIDReturH
        End Get
        Set(value As Long)
            xIDReturH = value
        End Set
    End Property

    Private xIDPenerimaanH As Long
    Public Property IDPenerimaanH() As Long
        Get
            Return xIDPenerimaanH
        End Get
        Set(value As Long)
            xIDPenerimaanH = value
        End Set
    End Property

    Private xCatatan As String
    Public Property Catatan() As String
        Get
            Return xCatatan
        End Get
        Set(value As String)
            xCatatan = value
        End Set
    End Property

#End Region

End Class
