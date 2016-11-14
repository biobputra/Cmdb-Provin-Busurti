

Public Class PenerimaanD

#Region "Properties"
    Private xIDPenerimaanH As Long
    Public Property IDPenerimaanH() As Long
        Get
            Return xIDPenerimaanH
        End Get
        Set(value As Long)
            xIDPenerimaanH = value
        End Set
    End Property

    Private xIDPenerimaanD As Long
    Public Property IDPenerimaanD() As Long
        Get
            Return xIDPenerimaanD
        End Get
        Set(value As Long)
            xIDPenerimaanD = value
        End Set
    End Property

    Private xIDBarang As Integer
    Public Property IDBarang() As Integer
        Get
            Return xIDBarang
        End Get
        Set(value As Integer)
            xIDBarang = value
        End Set
    End Property

    Private xJumlah As Decimal
    Public Property Jumlah() As Decimal
        Get
            Return xJumlah
        End Get
        Set(value As Decimal)
            xJumlah = value
        End Set
    End Property

    Private xBatchStok As Decimal
    Public Property BatchStok() As Decimal
        Get
            Return xBatchStok
        End Get
        Set(value As Decimal)
            xBatchStok = value
        End Set
    End Property

    Private xHarga As Decimal
    Public Property Harga() As Decimal
        Get
            Return xHarga
        End Get
        Set(value As Decimal)
            xHarga = value
        End Set
    End Property

#End Region


#Region "methods"

    Public Sub New()
    End Sub

    Public Sub New(ByVal MyIDPenerimaanH As Long, ByVal MyIDPenerimaanD As Long, ByVal MyIDBarang As Integer,
                   ByVal MyJumlah As Decimal, ByVal MyBatchStok As Decimal, ByVal MyHarga As Decimal)
        IDPenerimaanH = MyIDPenerimaanH : IDPenerimaanD = MyIDPenerimaanD : IDBarang = MyIDBarang : Jumlah = MyJumlah : BatchStok = MyBatchStok : Harga = MyHarga

    End Sub

    Shared Function GetPenerimaanDByIDPenerimaanH(ByVal MyIDPenerimaanH As Long) As List(Of PenerimaanD)
        Dim MyListPenerimaanD As New List(Of PenerimaanD)

        Using MyDataTable As DataTable = DataAccess.ExecuteQueryTable("EXEC Pnr_GetPenerimaanDByIDPenerimaanH " & MyIDPenerimaanH)
            If MyDataTable IsNot Nothing AndAlso MyDataTable.Rows.Count > 0 Then
                For Each MyRow As DataRow In MyDataTable.Rows

                    With MyRow
                        Dim MyPenerimaanD As New PenerimaanD
                        If Not IsDBNull(.Item("IDPenerimaanH")) Then MyPenerimaanD.IDPenerimaanH = Convert.ToInt64(.Item("IDPenerimaanH"))
                        If Not IsDBNull(.Item("IDPenerimaanD")) Then MyPenerimaanD.IDPenerimaanD = Convert.ToInt64(.Item("IDPenerimaanD"))
                        If Not IsDBNull(.Item("IDBarang")) Then MyPenerimaanD.IDBarang = Convert.ToInt32(.Item("IDBarang"))
                        If Not IsDBNull(.Item("Jumlah")) Then MyPenerimaanD.Jumlah = Convert.ToDecimal(.Item("Jumlah"))
                        If Not IsDBNull(.Item("BatchStok")) Then MyPenerimaanD.BatchStok = Convert.ToDecimal(.Item("BatchStok"))
                        If Not IsDBNull(.Item("Harga")) Then MyPenerimaanD.Harga = Convert.ToDecimal(.Item("Harga"))
                        MyListPenerimaanD.Add(MyPenerimaanD)
                    End With

                Next
            End If
        End Using

        Return MyListPenerimaanD
    End Function

#End Region
End Class
