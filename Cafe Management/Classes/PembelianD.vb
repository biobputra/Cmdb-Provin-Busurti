Public Class PembelianD

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

    Private xIDPembelianD As Long
    Public Property IDPembeliaD() As Long
        Get
            Return xIDPembelianD
        End Get
        Set(ByVal value As Long)
            xIDPembelianD = value
        End Set
    End Property

    Private xIDBarang As Integer
    Public Property IDBarang() As Integer
        Get
            Return xIDBarang
        End Get
        Set(ByVal value As Integer)
            xIDBarang = value
        End Set
    End Property

    Private xJumlah As Decimal
    Public Property Jumlah() As Decimal
        Get
            Return xJumlah
        End Get
        Set(ByVal value As Decimal)
            xJumlah = value
        End Set
    End Property

    Private xHargaBeli As Decimal
    Public Property HargaBeli() As Decimal
        Get
            Return xHargaBeli
        End Get
        Set(ByVal value As Decimal)
            xHargaBeli = value
        End Set
    End Property

    Private xDiscountPembelian As Decimal
    Public Property DiscountPembelian() As Decimal
        Get
            Return xDiscountPembelian
        End Get
        Set(ByVal value As Decimal)
            xDiscountPembelian = value
        End Set
    End Property
#End Region

#Region "methods"

    Sub New()

    End Sub

    Sub New(ByVal MyIDPembelianH As Long, ByVal MyIDPembelianD As Long, ByVal MyIDBarang As Integer, ByVal MyJumlah As Decimal, ByVal MyHargaBeli As Decimal, ByVal MyDiscountPembelian As Decimal)
        IDPembelianH = MyIDPembelianH : IDPembeliaD = MyIDPembelianD : IDBarang = MyIDBarang : Jumlah = MyJumlah : HargaBeli = MyHargaBeli : DiscountPembelian = MyDiscountPembelian
    End Sub

    Shared Function GetPembelianDByIDPembelianH(MyIDPembelianH As Long) As List(Of PembelianD)
        Dim MyListPembelianD As New List(Of PembelianD)

        Using MyDataTable As DataTable = DataAccess.ExecuteQueryTable("EXEC Pbl_GetPembelianDByIDPembelianH" & MyIDPembelianH)
            If MyDataTable IsNot Nothing AndAlso MyDataTable.Rows.Count > 0 Then
                For Each MyRow As DataRow In MyDataTable.Rows

                    With MyRow
                        Dim MyPembelianD As New PembelianD
                        If Not IsDBNull(.Item("IDPembelianH")) Then MyPembelianD.IDPembelianH = Convert.ToInt64(.Item("IDPembelianH"))
                        If Not IsDBNull(.Item("IDPembeliaD")) Then MyPembelianD.IDPembeliaD = Convert.ToInt64(.Item("IDPembeliaD"))
                        If Not IsDBNull(.Item("IDBarang")) Then MyPembelianD.IDBarang = Convert.ToInt32(.Item("IDBarang"))
                        If Not IsDBNull(.Item("Jumlah")) Then MyPembelianD.Jumlah = Convert.ToDecimal(.Item("Jumlah"))
                        If Not IsDBNull(.Item("Posisi")) Then MyPembelianD.HargaBeli = Convert.ToDecimal(.Item("HargaBeli"))
                        If Not IsDBNull(.Item("DiscountPembelian")) Then MyPembelianD.DiscountPembelian = Convert.ToDecimal(.Item("DiscountPembelian"))
                        MyListPembelianD.Add(MyPembelianD)
                    End With

                Next
            End If
        End Using

        Return MyListPembelianD
    End Function

#End Region
End Class
