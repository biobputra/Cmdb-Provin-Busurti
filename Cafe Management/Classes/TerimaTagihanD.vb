Public Class TerimaTagihanD

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

    Private xIDTerimaTagihanD As Long
    Public Property IDTerimaTagihanD() As Long
        Get
            Return xIDTerimaTagihanD
        End Get
        Set(value As Long)
            xIDTerimaTagihanD = value
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
    Public Sub New(ByVal MyIDTerimaTagihanH As Long, ByVal MyIDTerimaTagihanD As Long, ByVal MyIDBarang As Integer, ByVal MyJumlah As Decimal)
        IDTerimaTagihanH = MyIDTerimaTagihanH : IDTerimaTagihanD = MyIDTerimaTagihanD : IDBarang = MyIDBarang : Jumlah = MyJumlah
    End Sub

    Shared Function GetTerimaTagihanDByIDTerimaTagihanH(ByVal MyIDTerimatagihanH As Long) As List(Of TerimaTagihanD)
        Dim MyListTerimaTagihanD As New List(Of TerimaTagihanD)

        Using MyDataTable As DataTable = DataAccess.ExecuteQueryTable("EXEC Tgh_GetTerimaTagihanDByIDTerimaTagihanH " & MyIDTerimatagihanH)
            If MyDataTable IsNot Nothing AndAlso MyDataTable.Rows.Count > 0 Then
                For Each MyRow As DataRow In MyDataTable.Rows

                    With MyRow

                        Dim MyTerimaTagihanD As New TerimaTagihanD
                        If Not IsDBNull(.Item("IDTerimaTagihanH")) Then MyTerimaTagihanD.IDTerimaTagihanH = Convert.ToInt64(.Item("IDTerimaTagihanH"))
                        If Not IsDBNull(.Item("IDTerimaTagihanD")) Then MyTerimaTagihanD.IDTerimaTagihanD = Convert.ToInt64(.Item("IDTerimaTagihanD"))
                        If Not IsDBNull(.Item("IDBarang")) Then MyTerimaTagihanD.IDBarang = Convert.ToInt32(.Item("IDBarang"))
                        If Not IsDBNull(.Item("Jumlah")) Then MyTerimaTagihanD.Jumlah = Convert.ToDecimal(.Item("Jumlah"))
                        MyListTerimaTagihanD.Add(MyTerimaTagihanD)
                    End With

                Next
            End If
        End Using

        Return MyListTerimaTagihanD
    End Function

#End Region
End Class
