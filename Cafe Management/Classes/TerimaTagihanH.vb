Public Class TerimaTagihanH

#Region "Properties"

    Private xIDTerimaTagihanH As Long
    Public Property IDTerimaTagihanH() As Long
        Get
            Return xIDTerimaTagihanH
        End Get
        Set(value As Long)
            xIDTerimaTagihanH = value
        End Set
    End Property

    Private xTanggalTerimaTagihan As Date
    Public Property TanggalTerimaTagihan() As Date
        Get
            Return xTanggalTerimaTagihan
        End Get
        Set(value As Date)
            xTanggalTerimaTagihan = value
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

    Private xNoTerimaTagihan As String
    Public Property NoTerimaTagihan() As String
        Get
            Return xNoTerimaTagihan
        End Get
        Set(value As String)
            xNoTerimaTagihan = value
        End Set
    End Property

    Private xIDTermOfPayment As Integer
    Public Property IDTermOfPayment() As Integer
        Get
            Return xIDTermOfPayment
        End Get
        Set(value As Integer)
            xIDTermOfPayment = value
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
    Public Sub New(ByVal MyIDTerimaTagihanH As Long, ByVal MyTanggalTerimaTagihan As Date, ByVal MyIDPenerimaanH As Long, ByVal MyNoTerimaTagihan As String, ByVal MyIDTermOfPayment As Integer, ByVal MyCatatan As String, ByVal MyStatus As Int32, ByVal MyCreatedBy As Integer, ByVal MyCreatedDate As DateTime, ByVal MyModifiedBy As Integer, ByVal MyModifiedDate As DateTime)
        IDTerimaTagihanH = MyIDTerimaTagihanH : TanggalTerimaTagihan = MyTanggalTerimaTagihan : IDPenerimaanH = MyIDPenerimaanH : NoTerimaTagihan = MyNoTerimaTagihan : IDTermOfPayment = MyIDTermOfPayment : Catatan = MyCatatan : Status = MyStatus : CreatedBy = MyCreatedBy : CreatedDate = MyCreatedDate : ModifiedBy = MyModifiedBy : ModifiedDate = MyModifiedDate
    End Sub

    Shared Function GetTerimaTagihanHByIDTerimaTagihanH(ByVal MyIDTerimaTagihanH As String) As TerimaTagihanH
        Dim MyTerimaTagihanH = New TerimaTagihanH()

        Using MyDataTable As DataTable = DataAccess.ExecuteQueryTable("EXEC Tgh_GetTerimaTagihanHByIDTerimaTagihanH " & MyIDTerimaTagihanH)
            If MyDataTable IsNot Nothing AndAlso MyDataTable.Rows.Count > 0 Then
                For Each MyRow As DataRow In MyDataTable.Rows

                    With MyRow
                        If Not IsDBNull(.Item("IDTerimaTagihanH")) Then MyTerimaTagihanH.IDTerimaTagihanH = Convert.ToInt64(.Item("IDTerimaTagihanH"))
                        If Not IsDBNull(.Item("TanggalTerimaTagihan")) Then MyTerimaTagihanH.TanggalTerimaTagihan = Convert.ToDateTime(.Item("TanggalTerimaTagihan"))
                        If Not IsDBNull(.Item("IDPenerimaanH")) Then MyTerimaTagihanH.IDPenerimaanH = Convert.ToInt64(.Item("IDPenerimaanH"))
                        If Not IsDBNull(.Item("IDTermOfPayment")) Then MyTerimaTagihanH.IDTermOfPayment = Convert.ToInt32(.Item("IDTermOfPayment"))
                        If Not IsDBNull(.Item("Catatan")) Then MyTerimaTagihanH.Catatan = .Item("Catatan").ToString
                        If Not IsDBNull(.Item("Status")) Then MyTerimaTagihanH.Status = Convert.ToInt32(.Item("Status"))
                        If Not IsDBNull(.Item("CreatedBy")) Then MyTerimaTagihanH.CreatedBy = Convert.ToInt32(.Item("CreatedBy"))
                        If Not IsDBNull(.Item("CreatedDate")) Then MyTerimaTagihanH.CreatedDate = Convert.ToDateTime(.Item("CreatedDate"))
                        If Not IsDBNull(.Item("ModifiedBy")) Then MyTerimaTagihanH.ModifiedBy = Convert.ToInt32(.Item("ModifiedBy"))
                        If Not IsDBNull(.Item("ModifiedDate")) Then MyTerimaTagihanH.ModifiedDate = Convert.ToDateTime(.Item("ModifiedDate"))
                    End With
                Next
            End If
        End Using

        Return MyTerimaTagihanH
    End Function

    Shared Function GetTerimaTagihanHBulanBerjalanAktif() As List(Of TerimaTagihanH)
        Dim MyListTerimaTagihanH As New List(Of TerimaTagihanH)

        Using MyDataTable As DataTable = DataAccess.ExecuteQueryTable("EXEC Tgh_GetTerimaTagihanHBulanBerjalanAktif")
            If MyDataTable IsNot Nothing AndAlso MyDataTable.Rows.Count > 0 Then
                For Each MyRow As DataRow In MyDataTable.Rows
                    Dim MyTerimaTagihanH As New TerimaTagihanH
                    With MyRow
                        If Not IsDBNull(.Item("IDTerimaTagihanH")) Then MyTerimaTagihanH.IDTerimaTagihanH = Convert.ToInt64(.Item("IDTerimaTagihanH"))
                        If Not IsDBNull(.Item("TanggalTerimaTagihan")) Then MyTerimaTagihanH.TanggalTerimaTagihan = Convert.ToDateTime(.Item("TanggalTerimaTagihan"))
                        If Not IsDBNull(.Item("IDPenerimaanH")) Then MyTerimaTagihanH.IDPenerimaanH = Convert.ToInt64(.Item("IDPenerimaanH"))
                        If Not IsDBNull(.Item("IDTermOfPayment")) Then MyTerimaTagihanH.IDTermOfPayment = Convert.ToInt32(.Item("IDTermOfPayment"))
                        If Not IsDBNull(.Item("Catatan")) Then MyTerimaTagihanH.Catatan = .Item("Catatan").ToString
                        If Not IsDBNull(.Item("Status")) Then MyTerimaTagihanH.Status = Convert.ToInt32(.Item("Status"))
                        If Not IsDBNull(.Item("CreatedBy")) Then MyTerimaTagihanH.CreatedBy = Convert.ToInt32(.Item("CreatedBy"))
                        If Not IsDBNull(.Item("CreatedDate")) Then MyTerimaTagihanH.CreatedDate = Convert.ToDateTime(.Item("CreatedDate"))
                        If Not IsDBNull(.Item("ModifiedBy")) Then MyTerimaTagihanH.ModifiedBy = Convert.ToInt32(.Item("ModifiedBy"))
                        If Not IsDBNull(.Item("ModifiedDate")) Then MyTerimaTagihanH.ModifiedDate = Convert.ToDateTime(.Item("ModifiedDate"))
                        MyListTerimaTagihanH.Add(MyTerimaTagihanH)
                    End With
                Next
            End If
        End Using

        Return MyListTerimaTagihanH
    End Function

#End Region


End Class
