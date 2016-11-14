Public Class ReturH

#Region "Properties"

    Private xIDReturH As Long
    Public Property IDReturH() As Long
        Get
            Return xIDReturH
        End Get
        Set(value As Long)
            xIDReturH = value
        End Set
    End Property

    Private xTanggalRetur As Date
    Public Property TanggalRetur() As Date
        Get
            Return xTanggalRetur
        End Get
        Set(value As Date)
            xTanggalRetur = value
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
    Public Sub New(ByVal MyIDReturH As Long, ByVal MyTanggalRetur As Date, ByVal MyCatatan As String, ByVal MyStatus As Int32, ByVal MyCreatedBy As Integer, ByVal MyCreatedDate As DateTime, ByVal MyModifiedBy As Integer, ByVal MyModifiedDate As DateTime)
        IDReturH = MyIDReturH : TanggalRetur = MyTanggalRetur : Catatan = MyCatatan : Status = MyStatus : CreatedBy = MyCreatedBy : CreatedDate = MyCreatedDate : ModifiedBy = MyModifiedBy : ModifiedDate = MyModifiedDate
    End Sub

    Shared Function GetReturHByIDReturH(ByVal MyIDReturH As String) As ReturH
        Dim MyReturH = New ReturH

        Using MyDataTable As DataTable = DataAccess.ExecuteQueryTable("EXEC Rtr_GetReturHByIDReturH " & MyIDReturH)
            If MyDataTable IsNot Nothing AndAlso MyDataTable.Rows.Count > 0 Then
                For Each MyRow As DataRow In MyDataTable.Rows

                    With MyRow
                        If Not IsDBNull(.Item("IDReturH")) Then MyReturH.IDReturH = Convert.ToInt64(.Item("IDReturH"))
                        If Not IsDBNull(.Item("TanggalRetur ")) Then MyReturH.TanggalRetur = Convert.ToDateTime(.Item("TanggalRetur "))
                        If Not IsDBNull(.Item("Catatan")) Then MyReturH.Catatan = .Item("Catatan").ToString
                        If Not IsDBNull(.Item("Status")) Then MyReturH.Status = Convert.ToInt32(.Item("Status"))
                        If Not IsDBNull(.Item("CreatdBy")) Then MyReturH.CreatedBy = Convert.ToInt32(.Item("CreatdBy"))
                        If Not IsDBNull(.Item("CreatedDate")) Then MyReturH.CreatedDate = Convert.ToDateTime(.Item("CreatedDate"))
                        If Not IsDBNull(.Item("ModifiedBy")) Then MyReturH.ModifiedBy = Convert.ToInt32(.Item("ModifiedBy"))
                        If Not IsDBNull(.Item("ModifiedDate")) Then MyReturH.ModifiedDate = Convert.ToDateTime(.Item("ModifiedDate"))
                    End With
                Next
            End If
        End Using

        Return MyReturH
    End Function

    Shared Function GetReturHBulanBerjalanAktif() As List(Of ReturH)
        Dim MyListReturH As New List(Of ReturH)

        Using MyDataTable As DataTable = DataAccess.ExecuteQueryTable("EXEC Rtr_GetReturHBulanBerjalanAktif")
            If MyDataTable IsNot Nothing AndAlso MyDataTable.Rows.Count > 0 Then
                For Each MyRow As DataRow In MyDataTable.Rows
                    Dim MyReturH As New ReturH
                    With MyRow
                        If Not IsDBNull(.Item("IDReturH")) Then MyReturH.IDReturH = Convert.ToInt64(.Item("IDReturH"))
                        If Not IsDBNull(.Item("TanggalRetur ")) Then MyReturH.TanggalRetur = Convert.ToDateTime(.Item("TanggalRetur "))
                        If Not IsDBNull(.Item("Catatan")) Then MyReturH.Catatan = .Item("Catatan").ToString
                        If Not IsDBNull(.Item("Status")) Then MyReturH.Status = Convert.ToInt32(.Item("Status"))
                        If Not IsDBNull(.Item("CreatdBy")) Then MyReturH.CreatedBy = Convert.ToInt32(.Item("CreatdBy"))
                        If Not IsDBNull(.Item("CreatedDate")) Then MyReturH.CreatedDate = Convert.ToDateTime(.Item("CreatedDate"))
                        If Not IsDBNull(.Item("ModifiedBy")) Then MyReturH.ModifiedBy = Convert.ToInt32(.Item("ModifiedBy"))
                        If Not IsDBNull(.Item("ModifiedDate")) Then MyReturH.ModifiedDate = Convert.ToDateTime(.Item("ModifiedDate"))
                        MyListReturH.Add(MyReturH)
                    End With
                Next
            End If
        End Using

        Return MyListReturH
    End Function
#End Region

End Class
