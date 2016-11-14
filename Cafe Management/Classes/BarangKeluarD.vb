Public Class BarangKeluarD

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

    Private xIDBarangKeluarD As Long
    Public Property IDBarangKeluarD() As Long
        Get
            Return xIDBarangKeluarD
        End Get
        Set(value As Long)
            xIDBarangKeluarD = value
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

#End Region

#Region "Methods"

    Public Sub New()
    End Sub

    Public Sub New(ByVal MyIDBarangKeluarH As Long, ByVal MyIDBarangKeluarD As Long, ByVal MyIDBarang As Integer, ByVal MyJumlah As Decimal)
        IDBarangKeluarH = MyIDBarangKeluarH : IDBarangKeluarD = MyIDBarangKeluarD : IDBarang = MyIDBarang : Jumlah = MyJumlah
    End Sub

    Shared Function GetBarangKeluarDByIDBarangKeluarH(ByVal MyIDBarangKeluarH As Long) As List(Of BarangKeluarD)
        Dim MyListBarangKeluarD As New List(Of BarangKeluarD)

        Using MyDataTable As DataTable = DataAccess.ExecuteQueryTable("EXEC Brk_GetBarangKeluarDByIDBarangKeluarH " & MyIDBarangKeluarH)
            If MyDataTable IsNot Nothing AndAlso MyDataTable.Rows.Count > 0 Then
                For Each MyRow As DataRow In MyDataTable.Rows

                    With MyRow
                        Dim MyBarangKeluarD As New BarangKeluarD
                        If Not IsDBNull(.Item("IDBarangKeluarH")) Then MyBarangKeluarD.IDBarangKeluarH = Convert.ToInt64(.Item("IDBarangKeluarH"))
                        If Not IsDBNull(.Item("IDBarangKeluarD")) Then MyBarangKeluarD.IDBarangKeluarD = Convert.ToInt64(.Item("IDBarangKeluarD"))
                        If Not IsDBNull(.Item("IDBarang")) Then MyBarangKeluarD.IDBarang = Convert.ToInt32(.Item("IDBarang"))
                        If Not IsDBNull(.Item("Jumlah")) Then MyBarangKeluarD.Jumlah = Convert.ToDecimal(.Item("Jumlah"))
                        MyListBarangKeluarD.Add(MyBarangKeluarD)
                    End With

                Next
            End If
        End Using

        Return MyListBarangKeluarD
    End Function

#End Region


End Class
