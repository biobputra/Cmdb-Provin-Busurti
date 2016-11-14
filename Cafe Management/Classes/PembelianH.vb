Public Class PembelianH

#Region "Properties"

    Private xIDPembelianH As Long
    Public Property IDPembelianH() As Long
        Get
            Return xIDPembelianH
        End Get
        Set(ByVal value As Long)
            xIDPembelianH = value
        End Set
    End Property

    Private xTanggalPembelian As Date
    Public Property TanggalPembelian() As Date
        Get
            Return xTanggalPembelian
        End Get
        Set(ByVal value As Date)
            xTanggalPembelian = value
        End Set
    End Property

    Private xIDSupplier As Integer
    Public Property IDSupplier() As Integer
        Get
            Return xIDSupplier
        End Get
        Set(ByVal value As Integer)
            xIDSupplier = value
        End Set
    End Property

    Private xStatus As Integer
    Public Property Status() As Integer
        Get
            Return xStatus
        End Get
        Set(ByVal value As Integer)
            xStatus = value
        End Set
    End Property

    Private xCatatan As String
    Public Property Catatan() As String
        Get
            Return xCatatan
        End Get
        Set(ByVal value As String)
            xCatatan = value
        End Set
    End Property

    Private xCreatdBy As Integer
    Public Property CreatdBy() As Integer
        Get
            Return xCreatdBy
        End Get
        Set(ByVal value As Integer)
            xCreatdBy = value
        End Set
    End Property

    Private xCreatedDate As Date
    Public Property CreatedDate() As Date
        Get
            Return xCreatedDate
        End Get
        Set(ByVal value As Date)
            xCreatedDate = value
        End Set
    End Property

    Private xModifiedBy As Integer
    Public Property ModifiedBy() As Integer
        Get
            Return xModifiedBy
        End Get
        Set(ByVal value As Integer)
            xModifiedBy = value
        End Set
    End Property

    Private xModifiedDate As Date
    Public Property ModifiedDate() As Date
        Get
            Return xModifiedDate
        End Get
        Set(ByVal value As Date)
            xModifiedDate = value
        End Set
    End Property
#End Region


#Region "Methods"

    Sub New()

    End Sub

    Sub New(ByVal MyIDPembelianH As Long, ByVal MyTanggalPembelian As Date, ByVal MyIDSupplier As Integer, ByVal MyCatatan As String, ByVal MyCreatedBy As Long, ByVal MyCreatedDate As Date, ByVal MyModifiedBy As Long, ByVal MyModifiedDate As Date)
        IDPembelianH = MyIDPembelianH : TanggalPembelian = MyTanggalPembelian : IDSupplier = MyIDSupplier : Catatan = MyCatatan : CreatdBy = MyCreatedBy : CreatedDate = MyCreatedDate : ModifiedBy = MyModifiedBy : ModifiedDate = MyModifiedDate
    End Sub

    Shared Function GetPembelianHByIDPembelianH(ByVal MyIDPembelianH As String) As PembelianH
        Dim MyPembelianH = New PembelianH()

        Using MyDataTable As DataTable = DataAccess.ExecuteQueryTable("EXEC Pbl_GetPembelianHByIDPembelianH " & MyIDPembelianH)
            If MyDataTable IsNot Nothing AndAlso MyDataTable.Rows.Count > 0 Then
                For Each MyRow As DataRow In MyDataTable.Rows

                    With MyRow
                        If Not IsDBNull(.Item("IDPembelianH")) Then MyPembelianH.IDPembelianH = Convert.ToInt64(.Item("IDPembelianH"))
                        If Not IsDBNull(.Item("TanggalPembelian")) Then MyPembelianH.TanggalPembelian = Convert.ToDateTime(.Item("TanggalPembelian"))
                        If Not IsDBNull(.Item("IDSupplier")) Then MyPembelianH.IDSupplier = Convert.ToInt32(.Item("IDSupplier"))
                        If Not IsDBNull(.Item("Status")) Then MyPembelianH.Status = Convert.ToInt32(.Item("Status"))
                        If Not IsDBNull(.Item("Catatan")) Then MyPembelianH.Catatan = .Item("Catatan").ToString
                        If Not IsDBNull(.Item("CreatdBy")) Then MyPembelianH.CreatdBy = Convert.ToInt64(.Item("CreatdBy"))
                        If Not IsDBNull(.Item("CreatedDate")) Then MyPembelianH.CreatedDate = Convert.ToDateTime(.Item("CreatedDate"))
                        If Not IsDBNull(.Item("ModifiedBy")) Then MyPembelianH.ModifiedBy = Convert.ToInt64(.Item("ModifiedBy"))
                        If Not IsDBNull(.Item("ModifiedDate")) Then MyPembelianH.ModifiedDate = Convert.ToDateTime(.Item("ModifiedDate"))
                    End With
                Next
            End If
        End Using

        Return MyPembelianH
    End Function
#End Region

End Class
