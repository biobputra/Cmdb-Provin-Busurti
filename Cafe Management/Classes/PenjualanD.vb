Public Class PenjualanD

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

    Private xIDPenjualanD As Long
    Public Property IDPenjualanD() As Long
        Get
            Return xIDPenjualanD
        End Get
        Set(value As Long)
            xIDPenjualanD = value
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

    Private xHargaJual As Decimal
    Public Property HargaJual() As Decimal
        Get
            Return xHargaJual
        End Get
        Set(value As Decimal)
            xHargaJual = value
        End Set
    End Property

    Private xDiscountPenjualan As Decimal
    Public Property DiscountPenjualan() As Decimal
        Get
            Return xDiscountPenjualan
        End Get
        Set(value As Decimal)
            xDiscountPenjualan = value
        End Set
    End Property

#End Region

#Region "Methods"

    Public Sub New()
    End Sub

    Public Sub New(ByVal MyIDPenjualanH As Long, ByVal MyIDPenjualanD As Long, ByVal MyIDBarang As Integer, ByVal MyJumlah As Decimal, ByVal MyHargaJual As Decimal, ByVal MyDiscountPenjualan As Decimal)
        IDPenjualanH = MyIDPenjualanH : IDPenjualanD = MyIDPenjualanD : IDBarang = MyIDBarang : Jumlah = MyJumlah : HargaJual = MyHargaJual : DiscountPenjualan = MyDiscountPenjualan
    End Sub

    Shared Function GetPejualanDByIDPenjualanH(ByVal MyIDPenjualanH As Long) As List(Of PenjualanD)
        Dim MyListPenjualanD As New List(Of PenjualanD)

        Using MyDataTable As DataTable = DataAccess.ExecuteQueryTable("EXEC pjl_GetPejualanDByIDPenjualanH " & MyIDPenjualanH)
            If MyDataTable IsNot Nothing AndAlso MyDataTable.Rows.Count > 0 Then
                For Each MyRow As DataRow In MyDataTable.Rows

                    With MyRow
                        Dim MyPenjualanD As New PenjualanD
                        If Not IsDBNull(.Item("IDPenjualanH")) Then MyPenjualanD.IDPenjualanH = Convert.ToInt64(.Item("IDPenjualanH"))
                        If Not IsDBNull(.Item("IDPenjualanD")) Then MyPenjualanD.IDPenjualanD = Convert.ToInt64(.Item("IDPenjualanD"))
                        If Not IsDBNull(.Item("IDBarang")) Then MyPenjualanD.IDBarang = Convert.ToInt32(.Item("IDBarang"))
                        If Not IsDBNull(.Item("Jumlah")) Then MyPenjualanD.Jumlah = Convert.ToDecimal(.Item("Jumlah"))
                        If Not IsDBNull(.Item("HargaJual")) Then MyPenjualanD.HargaJual = Convert.ToDecimal(.Item("HargaJual"))
                        If Not IsDBNull(.Item("DiscountPenjualan")) Then MyPenjualanD.DiscountPenjualan = Convert.ToDecimal(.Item("DiscountPenjualan"))
                        MyListPenjualanD.Add(MyPenjualanD)
                    End With

                Next
            End If
        End Using

        Return MyListPenjualanD
    End Function

#End Region

End Class
