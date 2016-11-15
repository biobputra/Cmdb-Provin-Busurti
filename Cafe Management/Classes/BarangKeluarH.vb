Public Class BarangKeluarH

#Region "Properties"

    Private xIDBarangKeluarH As Long
    Public Property IDBarangKeluarH() As Long
        Get
            Return xIDBarangKeluarH
        End Get
        Set(value As Long)
            xIDBarangKeluarH = value
        End Set
    End Property

    Private xTanggalBarangKeluar As Date
    Public Property TanggalBarangKeluar() As Date
        Get
            Return xTanggalBarangKeluar
        End Get
        Set(value As Date)
            xTanggalBarangKeluar = value
        End Set
    End Property

    Private xNoBarangKeluar As String
    Public Property NoBarangKeluar() As String
        Get
            Return xNoBarangKeluar
        End Get
        Set(value As String)
            xNoBarangKeluar = value
        End Set
    End Property

    Private xSumberBarangKeluar As Int32
    Public Property SumberBarangKeluar() As Int32
        Get
            Return xSumberBarangKeluar
        End Get
        Set(value As Int32)
            xSumberBarangKeluar = value
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

#Region "Methods"

    Public Sub New()
    End Sub

    Public Sub New(ByVal MyIDBarangKeluarH As Long, ByVal MyTanggalBarangKeluar As Date, ByVal MyNoBarangKeluar As String, ByVal MySumberBarangKeluar As Int32, ByVal MyCatatan As String, ByVal MyStatus As Int32, ByVal MyCreatedBy As Integer, ByVal MyCreatedDate As DateTime, ByVal MyModifiedBy As Integer, ByVal MyModifiedDate As DateTime)
        IDBarangKeluarH = MyIDBarangKeluarH : TanggalBarangKeluar = MyTanggalBarangKeluar : NoBarangKeluar = MyNoBarangKeluar : SumberBarangKeluar = MySumberBarangKeluar : Catatan = MyCatatan : Status = MyStatus : CreatedBy = MyCreatedBy : CreatedDate = MyCreatedDate : ModifiedBy = MyModifiedBy : ModifiedDate = MyModifiedDate
    End Sub

    Shared Function GetBarangKeluarHByIDBarangKeluarH(ByVal MyIDBarangKeluarH As String) As BarangKeluarH
        Dim MyBarangKeluarH = New BarangKeluarH()

        Using MyDataTable As DataTable = DataAccess.ExecuteQueryTable("EXEC Brk_GetBarangKeluarHByIDBarangKeluarH " & MyIDBarangKeluarH)
            If MyDataTable IsNot Nothing AndAlso MyDataTable.Rows.Count > 0 Then
                For Each MyRow As DataRow In MyDataTable.Rows

                    With MyRow
                        If Not IsDBNull(.Item("IDBarangKeluarH")) Then MyBarangKeluarH.IDBarangKeluarH = Convert.ToInt64(.Item("IDBarangKeluarH"))
                        If Not IsDBNull(.Item("TanggalBarangKeluar")) Then MyBarangKeluarH.TanggalBarangKeluar = Convert.ToDateTime(.Item("TanggalBarangKeluar"))
                        If Not IsDBNull(.Item("NoBarangKeluar")) Then MyBarangKeluarH.NoBarangKeluar = .Item("NoBarangKeluar").ToString()
                        If Not IsDBNull(.Item("SumberBarangKeluar")) Then MyBarangKeluarH.SumberBarangKeluar = Convert.ToInt32(.Item("SumberBarangKeluar"))
                        If Not IsDBNull(.Item("Catatan")) Then MyBarangKeluarH.Catatan = .Item("Catatan").ToString
                        If Not IsDBNull(.Item("Status")) Then MyBarangKeluarH.Status = Convert.ToInt32(.Item("Status"))
                        If Not IsDBNull(.Item("CreatedBy")) Then MyBarangKeluarH.CreatedBy = Convert.ToInt32(.Item("CreatedBy"))
                        If Not IsDBNull(.Item("CreatedDate")) Then MyBarangKeluarH.CreatedDate = Convert.ToDateTime(.Item("CreatedDate"))
                        If Not IsDBNull(.Item("ModifiedBy")) Then MyBarangKeluarH.ModifiedBy = Convert.ToInt32(.Item("ModifiedBy"))
                        If Not IsDBNull(.Item("ModifiedDate")) Then MyBarangKeluarH.ModifiedDate = Convert.ToDateTime(.Item("ModifiedDate"))
                    End With
                Next
            End If
        End Using

        Return MyBarangKeluarH
    End Function

    Shared Function GetBarangKeluarHBulanBerjalanAktif() As List(Of BarangKeluarH)
        Dim MyListBarangKeluarH As New List(Of BarangKeluarH)

        Using MyDataTable As DataTable = DataAccess.ExecuteQueryTable("EXEC Brk_GetBarangKeluarHBulanBerjalanAktif")
            If MyDataTable IsNot Nothing AndAlso MyDataTable.Rows.Count > 0 Then
                For Each MyRow As DataRow In MyDataTable.Rows
                    Dim MyBarangKeluarH As New BarangKeluarH
                    With MyRow
                        If Not IsDBNull(.Item("IDBarangKeluarH")) Then MyBarangKeluarH.IDBarangKeluarH = Convert.ToInt64(.Item("IDBarangKeluarH"))
                        If Not IsDBNull(.Item("TanggalBarangKeluar")) Then MyBarangKeluarH.TanggalBarangKeluar = Convert.ToDateTime(.Item("TanggalBarangKeluar"))
                        If Not IsDBNull(.Item("NoBarangKeluar")) Then MyBarangKeluarH.NoBarangKeluar = .Item("NoBarangKeluar").ToString()
                        If Not IsDBNull(.Item("SumberBarangKeluar")) Then MyBarangKeluarH.SumberBarangKeluar = Convert.ToInt32(.Item("SumberBarangKeluar"))
                        If Not IsDBNull(.Item("Catatan")) Then MyBarangKeluarH.Catatan = .Item("Catatan").ToString
                        If Not IsDBNull(.Item("Status")) Then MyBarangKeluarH.Status = Convert.ToInt32(.Item("Status"))
                        If Not IsDBNull(.Item("CreatedBy")) Then MyBarangKeluarH.CreatedBy = Convert.ToInt32(.Item("CreatedBy"))
                        If Not IsDBNull(.Item("CreatedDate")) Then MyBarangKeluarH.CreatedDate = Convert.ToDateTime(.Item("CreatedDate"))
                        If Not IsDBNull(.Item("ModifiedBy")) Then MyBarangKeluarH.ModifiedBy = Convert.ToInt32(.Item("ModifiedBy"))
                        If Not IsDBNull(.Item("ModifiedDate")) Then MyBarangKeluarH.ModifiedDate = Convert.ToDateTime(.Item("ModifiedDate"))
                        MyListBarangKeluarH.Add(MyBarangKeluarH)
                    End With
                Next
            End If
        End Using

        Return MyListBarangKeluarH
    End Function

#End Region
End Class
