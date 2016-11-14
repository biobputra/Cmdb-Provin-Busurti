Imports System.Data

Public Class JurnalD


#Region "Properties"

    Private xIDJurnalH As Long
    Public Property IDJurnalH As Long
        Get
            Return xIDJurnalH
        End Get
        Set(value As Long)
            xIDJurnalH = value
        End Set
    End Property

    Private xIDJurnalD As Long
    Public Property IDJurnalD As Long
        Get
            Return xIDJurnalD
        End Get
        Set(value As Long)
            xIDJurnalD = value
        End Set
    End Property

    Private xIDAkun As Integer
    Public Property IDAkun As Integer
        Get
            Return xIDAkun
        End Get
        Set(value As Integer)
            xIDAkun = value
        End Set
    End Property

    Private xJumlah As Decimal
    Public Property Jumlah As Decimal
        Get
            Return xJumlah
        End Get
        Set(value As Decimal)
            xJumlah = value
        End Set
    End Property

    Private xPosisi As String
    Public Property Posisi As String
        Get
            Return xPosisi
        End Get
        Set(value As String)
            xPosisi = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal MyIDJurnalH As Long, MyIDJurnalD As Long, MyIDAkun As Integer, MyJumlah As Decimal, Myposisi As String)
        IDJurnalH = MyIDJurnalH : IDJurnalD = MyIDJurnalD : IDAkun = MyIDAkun : Jumlah = MyJumlah : Posisi = Myposisi
    End Sub

    Shared Function GetJurnalDByIDJurnalH(MyIDJurnalH As Long) As List(Of JurnalD)
        Dim MyListJurnalD As New List(Of JurnalD)


        Using MyDataTable As DataTable = DataAccess.ExecuteQueryTable("EXEC Acc_GetJurnalDByIDJurnalH " & MyIDJurnalH)
            If MyDataTable IsNot Nothing AndAlso MyDataTable.Rows.Count > 0 Then
                For Each MyRow As DataRow In MyDataTable.Rows

                    With MyRow
                        Dim MyJurnalD As New JurnalD()
                        If Not IsDBNull(.Item("IDJurnalH")) Then MyJurnalD.IDJurnalH = Convert.ToInt64(.Item("IDJurnalH"))
                        If Not IsDBNull(.Item("IDJurnalD")) Then MyJurnalD.IDJurnalD = Convert.ToInt64(.Item("IDJurnalD"))
                        If Not IsDBNull(.Item("IDAkun")) Then MyJurnalD.IDAkun = Convert.ToInt32(.Item("IDAkun"))
                        If Not IsDBNull(.Item("Jumlah")) Then MyJurnalD.Jumlah = Convert.ToDecimal(.Item("Jumlah"))
                        If Not IsDBNull(.Item("Posisi")) Then MyJurnalD.Posisi = .Item("Posisi").ToString
                        MyListJurnalD.Add(MyJurnalD)
                    End With
                Next
            End If
        End Using

        Return MyListJurnalD
    End Function
#End Region
End Class
