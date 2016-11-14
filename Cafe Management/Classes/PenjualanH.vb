Public Class PenjualanH

#Region "Properties"

    Private xIDPenjualanH As Long
    Public Property IDPenjualanH() As Long
        Get
            Return xIDPenjualanH
        End Get
        Set(value As Long)
            xIDPenjualanH = value
        End Set
    End Property

    Private xTanggalPenjualan As Date
    Public Property TanggalPenjualan() As Date
        Get
            Return xTanggalPenjualan
        End Get
        Set(value As Date)
            xTanggalPenjualan = value
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

    Private xCreatedDate As DateTime
    Public Property CreatedDate() As DateTime
        Get
            Return xCreatedDate
        End Get
        Set(value As DateTime)
            xCreatedDate = value
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

    Private xModifiedDate As DateTime
    Public Property ModifiedDate() As DateTime
        Get
            Return xModifiedDate
        End Get
        Set(value As DateTime)
            xModifiedDate = value
        End Set
    End Property

#End Region

#Region "methods"

    Public Sub New()
    End Sub

    Public Sub New(ByVal MyIDPenjualanH As Long, ByVal MyTanggalPenjualan As Date, ByVal MyCatatan As String, ByVal MyStatus As Int32, ByVal MyCreatedBy As String, ByVal MyCreatedDate As DateTime, ByVal MyModifiedBy As String, ByVal MyModifiedDate As DateTime)
        IDPenjualanH = MyIDPenjualanH : TanggalPenjualan = MyTanggalPenjualan : Catatan = MyCatatan : Status = MyStatus : CreatedBy = MyCreatedBy : CreatedDate = MyCreatedDate : ModifiedBy = MyModifiedBy : ModifiedDate = MyModifiedDate
    End Sub

    Shared Function GetPenjualanHByIDPenjualanH(ByVal MyIDPenerimaanH As String) As PenjualanH
        Dim MyPenjualanH = New PenjualanH()

        Using MyDataTable As DataTable = DataAccess.ExecuteQueryTable("EXEC Pjl_GetPenjualanHByIDPenjualanH " & MyIDPenerimaanH)
            If MyDataTable IsNot Nothing AndAlso MyDataTable.Rows.Count > 0 Then
                For Each MyRow As DataRow In MyDataTable.Rows

                    With MyRow
                        If Not IsDBNull(.Item("IDPenjualanH")) Then MyPenjualanH.IDPenjualanH = Convert.ToInt64(.Item("IDPenjualanH"))
                        If Not IsDBNull(.Item("TanggalPenjualan")) Then MyPenjualanH.TanggalPenjualan = Convert.ToDateTime(.Item("TanggalPenjualan"))
                        If Not IsDBNull(.Item("Catatan")) Then MyPenjualanH.Catatan = .Item("Catatan").ToString
                        If Not IsDBNull(.Item("Status")) Then MyPenjualanH.Status = Convert.ToInt32(.Item("Status"))
                        If Not IsDBNull(.Item("CreatdBy")) Then MyPenjualanH.CreatedBy = Convert.ToInt32(.Item("CreatdBy"))
                        If Not IsDBNull(.Item("CreatedDate")) Then MyPenjualanH.CreatedDate = Convert.ToDateTime(.Item("CreatedDate"))
                        If Not IsDBNull(.Item("ModifiedBy")) Then MyPenjualanH.ModifiedBy = Convert.ToInt32(.Item("ModifiedBy"))
                        If Not IsDBNull(.Item("ModifiedDate")) Then MyPenjualanH.ModifiedDate = Convert.ToDateTime(.Item("ModifiedDate"))
                    End With
                Next
            End If
        End Using

        Return MyPenjualanH
    End Function

    Shared Function GetPenjualanHBulanBerjalanAktif() As List(Of PenjualanH)
        Dim MyListPenjualanH As New List(Of PenjualanH)

        Using MyDataTable As DataTable = DataAccess.ExecuteQueryTable("EXEC pjl_GetPenjualanHBulanBerjalanAktif")
            If MyDataTable IsNot Nothing AndAlso MyDataTable.Rows.Count > 0 Then
                For Each MyRow As DataRow In MyDataTable.Rows
                    Dim MyPenjualanH As New PenjualanH
                    With MyRow
                        If Not IsDBNull(.Item("IDPenjualanH")) Then MyPenjualanH.IDPenjualanH = Convert.ToInt64(.Item("IDPenjualanH"))
                        If Not IsDBNull(.Item("TanggalPenjualan")) Then MyPenjualanH.TanggalPenjualan = Convert.ToDateTime(.Item("TanggalPenjualan"))
                        If Not IsDBNull(.Item("Catatan")) Then MyPenjualanH.Catatan = .Item("Catatan").ToString
                        If Not IsDBNull(.Item("Status")) Then MyPenjualanH.Status = Convert.ToInt32(.Item("Status"))
                        If Not IsDBNull(.Item("CreatdBy")) Then MyPenjualanH.CreatedBy = Convert.ToInt32(.Item("CreatdBy"))
                        If Not IsDBNull(.Item("CreatedDate")) Then MyPenjualanH.CreatedDate = Convert.ToDateTime(.Item("CreatedDate"))
                        If Not IsDBNull(.Item("ModifiedBy")) Then MyPenjualanH.ModifiedBy = Convert.ToInt32(.Item("ModifiedBy"))
                        If Not IsDBNull(.Item("ModifiedDate")) Then MyPenjualanH.ModifiedDate = Convert.ToDateTime(.Item("ModifiedDate")))
                        MyListPenjualanH.Add(MyPenjualanH)
                    End With
                Next
            End If
        End Using

        Return MyListPenjualanH
    End Function

#End Region

End Class
