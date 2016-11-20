Public Class PenerimaanH

#Region "properties"

    Private xIDPenerimaanH As Long
    Public Property IDPenerimaanH() As Long
        Get
            Return xIDPenerimaanH
        End Get
        Set(value As Long)
            xIDPenerimaanH = value
        End Set
    End Property

    Private xTanggalPenerimaan As Date
    Public Property TanggalPenerimaan() As Date
        Get
            Return xTanggalPenerimaan
        End Get
        Set(value As Date)
            xTanggalPenerimaan = value
        End Set
    End Property

    Private xSumberPenerimaan As Int32
    Public Property SumberPenerimaan() As Int32
        Get
            Return xSumberPenerimaan
        End Get
        Set(value As Int32)
            xSumberPenerimaan = value
        End Set
    End Property

    Private xNoPenerimaan As String
    Public Property NoPenerimaan() As String
        Get
            Return xNoPenerimaan
        End Get
        Set(value As String)
            xNoPenerimaan = value
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

    Public Sub New(ByVal MyIDPenerimaanH As Long, ByVal MyTanggalPenerimaan As Date, ByVal MyStatus As Int32, ByVal MyCreatedBy As Integer, ByVal MyModifiedBy As Integer, ByVal MyCreatedDate As DateTime, ByVal MyModifiedDate As DateTime, ByVal MyCatatan As String)
        IDPenerimaanH = MyIDPenerimaanH : TanggalPenerimaan = MyTanggalPenerimaan : Catatan = MyCatatan : Status = MyStatus : CreatedBy = MyCreatedBy : CreatedDate = MyCreatedDate : ModifiedBy = MyModifiedBy : ModifiedDate = MyModifiedDate
    End Sub


    Shared Function GetPenerimaanHByIDPenerimaanH(ByVal MyIDPenerimaanH As String) As PenerimaanH
        Dim MyPenerimaanH = New PenerimaanH()

        Using MyDataTable As DataTable = DataAccess.ExecuteQueryTable("EXEC Pnr_GetPenerimaanHByIDPenerimaanH " & MyIDPenerimaanH)
            If MyDataTable IsNot Nothing AndAlso MyDataTable.Rows.Count > 0 Then
                For Each MyRow As DataRow In MyDataTable.Rows

                    With MyRow
                        If Not IsDBNull(.Item("IDPenerimaanH")) Then MyPenerimaanH.IDPenerimaanH = Convert.ToInt64(.Item("IDPenerimaanH"))
                        If Not IsDBNull(.Item("TanggalPenerimaan")) Then MyPenerimaanH.TanggalPenerimaan = Convert.ToDateTime(.Item("TanggalPenerimaan"))
                        If Not IsDBNull(.Item("Catatan")) Then MyPenerimaanH.Catatan = .Item("Catatan").ToString
                        If Not IsDBNull(.Item("Status")) Then MyPenerimaanH.Status = Convert.ToInt32(.Item("Status"))
                        If Not IsDBNull(.Item("CreatdBy")) Then MyPenerimaanH.CreatedBy = Convert.ToInt32(.Item("CreatdBy"))
                        If Not IsDBNull(.Item("CreatedDate")) Then MyPenerimaanH.CreatedDate = Convert.ToDateTime(.Item("CreatedDate"))
                        If Not IsDBNull(.Item("ModifiedBy")) Then MyPenerimaanH.ModifiedBy = Convert.ToInt32(.Item("ModifiedBy"))
                        If Not IsDBNull(.Item("ModifiedDate")) Then MyPenerimaanH.ModifiedDate = Convert.ToDateTime(.Item("ModifiedDate"))
                    End With
                Next
            End If
        End Using

        Return MyPenerimaanH
    End Function

    Shared Function GetPenerimaanHAktif() As List(Of PenerimaanH)
        Dim MyListPenerimaanH As New List(Of PenerimaanH)

        Using MyDataTable As DataTable = DataAccess.ExecuteQueryTable("EXEC Pnr_GetPenerimaanHAktif")
            If MyDataTable IsNot Nothing AndAlso MyDataTable.Rows.Count > 0 Then
                For Each MyRow As DataRow In MyDataTable.Rows
                    Dim MyPenerimaanH As New PenerimaanH
                    With MyRow
                        If Not IsDBNull(.Item("IDPenerimaanH")) Then MyPenerimaanH.IDPenerimaanH = Convert.ToInt64(.Item("IDPenerimaanH"))
                        If Not IsDBNull(.Item("TanggalPenerimaan")) Then MyPenerimaanH.TanggalPenerimaan = Convert.ToDateTime(.Item("TanggalPenerimaan"))
                        If Not IsDBNull(.Item("Catatan")) Then MyPenerimaanH.Catatan = .Item("Catatan").ToString
                        If Not IsDBNull(.Item("Status")) Then MyPenerimaanH.Status = Convert.ToInt32(.Item("Status"))
                        If Not IsDBNull(.Item("CreatdBy")) Then MyPenerimaanH.CreatedBy = Convert.ToInt32(.Item("CreatdBy"))
                        If Not IsDBNull(.Item("CreatedDate")) Then MyPenerimaanH.CreatedDate = Convert.ToDateTime(.Item("CreatedDate"))
                        If Not IsDBNull(.Item("ModifiedBy")) Then MyPenerimaanH.ModifiedBy = Convert.ToInt32(.Item("ModifiedBy"))
                        If Not IsDBNull(.Item("ModifiedDate")) Then MyPenerimaanH.ModifiedDate = Convert.ToDateTime(.Item("ModifiedDate"))
                        MyListPenerimaanH.Add(MyPenerimaanH)
                    End With
                Next
            End If
        End Using

        Return MyListPenerimaanH
    End Function

    Shared Function GetPenerimaanHBulanBerjalanAktif() As List(Of PenerimaanH)
        Dim MyListPenerimaanH As New List(Of PenerimaanH)

        Using MyDataTable As DataTable = DataAccess.ExecuteQueryTable("EXEC Pnr_GetPenerimaanHBulanBerjalanAktif")
            If MyDataTable IsNot Nothing AndAlso MyDataTable.Rows.Count > 0 Then
                For Each MyRow As DataRow In MyDataTable.Rows
                    Dim MyPenerimaanH As New PenerimaanH
                    With MyRow
                        If Not IsDBNull(.Item("IDPenerimaanH")) Then MyPenerimaanH.IDPenerimaanH = Convert.ToInt64(.Item("IDPenerimaanH"))
                        If Not IsDBNull(.Item("TanggalPenerimaan")) Then MyPenerimaanH.TanggalPenerimaan = Convert.ToDateTime(.Item("TanggalPenerimaan"))
                        If Not IsDBNull(.Item("Catatan")) Then MyPenerimaanH.Catatan = .Item("Catatan").ToString
                        If Not IsDBNull(.Item("Status")) Then MyPenerimaanH.Status = Convert.ToInt32(.Item("Status"))
                        If Not IsDBNull(.Item("CreatdBy")) Then MyPenerimaanH.CreatedBy = Convert.ToInt32(.Item("CreatdBy"))
                        If Not IsDBNull(.Item("CreatedDate")) Then MyPenerimaanH.CreatedDate = Convert.ToDateTime(.Item("CreatedDate"))
                        If Not IsDBNull(.Item("ModifiedBy")) Then MyPenerimaanH.ModifiedBy = Convert.ToInt32(.Item("ModifiedBy"))
                        If Not IsDBNull(.Item("ModifiedDate")) Then MyPenerimaanH.ModifiedDate = Convert.ToDateTime(.Item("ModifiedDate"))
                        MyListPenerimaanH.Add(MyPenerimaanH)
                    End With
                Next
            End If
        End Using

        Return MyListPenerimaanH
    End Function


  Public Sub delete()
    Dim myid = Me.IDPenerimaanH
    MsgBox(myid)

  End Sub

#End Region


End Class
