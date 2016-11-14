Public Class ReturD

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

    Private xIDReturD As Long
    Public Property IDReturD() As Long
        Get
            Return xIDReturD
        End Get
        Set(value As Long)
            xIDReturD = value
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


#Region "methods"

    Public Sub New()
    End Sub
    Public Sub New(ByVal MyIDReturH As Long, ByVal MyIDReturD As Long, ByVal MyIDBarang As Integer, ByVal MyJumlah As Decimal)
        IDReturH = MyIDReturH : IDReturD = MyIDReturD : IDBarang = MyIDBarang : Jumlah = MyJumlah
    End Sub

    Shared Function GetReturDByIDReturH(ByVal MyIDReturH As Long) As List(Of ReturD)
        Dim MyListReturD As New List(Of ReturD)

        Using MyDataTable As DataTable = DataAccess.ExecuteQueryTable("EXEC Rtr_GetReturDByIDReturH " & MyIDReturH)
            If MyDataTable IsNot Nothing AndAlso MyDataTable.Rows.Count > 0 Then
                For Each MyRow As DataRow In MyDataTable.Rows

                    With MyRow
                        Dim MyReturD As New ReturD

                        If Not IsDBNull(.Item("ReturH")) Then MyReturD.IDReturH = Convert.ToInt64(.Item("ReturH"))
                        If Not IsDBNull(.Item("IDReturD")) Then MyReturD.IDReturD = Convert.ToInt64(.Item("IDReturD"))
                        If Not IsDBNull(.Item("IDBarang")) Then MyReturD.IDBarang = Convert.ToInt32(.Item("IDBarang"))
                        If Not IsDBNull(.Item("Jumlah")) Then MyReturD.Jumlah = Convert.ToDecimal(.Item("Jumlah"))
                        MyListReturD.Add(MyReturD)
                    End With

                Next
            End If
        End Using

        Return MyListReturD
    End Function
#End Region
End Class
