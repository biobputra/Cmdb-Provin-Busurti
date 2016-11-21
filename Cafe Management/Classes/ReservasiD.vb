Public Class ReservasiD

#Region "Properties"
  Private xIDReservasiH As Long
  Public Property IDReservasiH() As Long
    Get
      Return xIDReservasiH
    End Get
    Set(value As Long)
      xIDReservasiH = value
    End Set
  End Property

  Private xIDReservasiD As Long
  Public Property IDReservasiD() As Long
    Get
      Return xIDReservasiD
    End Get
    Set(value As Long)
      xIDReservasiD = value
    End Set
  End Property

  Private xIDDaftarMeja As Integer
  Public Property IDDaftarMeja() As Integer
    Get
      Return xIDDaftarMeja
    End Get
    Set(value As Integer)
      xIDDaftarMeja = value
    End Set
  End Property

  Private xJamMulai As DateTime
  Public Property JamMulai() As DateTime
    Get
      Return xJamMulai
    End Get
    Set(value As DateTime)
      xJamMulai = value
    End Set
  End Property

  Private xJamSelesai As DateTime
  Public Property JamSelesai() As DateTime
    Get
      Return xJamSelesai
    End Get
    Set(value As DateTime)
      xJamSelesai = value
    End Set
  End Property
#End Region

#Region "Methods"


  Public Sub New()
  End Sub

  Public Sub New(ByVal MyIDReservasiH As Long, ByVal MyIDReservasiD As Long, ByVal MyIDDaftarMeja As Integer, ByVal MyJamMulai As DateTime, ByVal MyJamSelesai As DateTime)
    IDReservasiH = MyIDReservasiH : IDReservasiD = MyIDReservasiD : IDDaftarMeja = MyIDDaftarMeja : JamMulai = MyJamMulai : JamSelesai = MyJamSelesai
  End Sub

  'Shared Function GetListReservasiDByNamaReservasiH(MyNama As String) As List(Of ReservasiD)

  '  Dim MyListReservasiD As New List(Of ReservasiD)
  '  Using MyDataTable As DataTable = DataAccess.ExecuteQueryTable("exec Rsv_GetListReservasiDByNamaReservasiH " & "'" & MyNama & "'")

  '    If MyDataTable IsNot Nothing AndAlso MyDataTable.Rows.Count > 0 Then
  '      For Each MyRow As DataRow In MyDataTable.Rows
  '        Dim MyReservasiD = New ReservasiD()
  '        With MyRow
  '          If Not IsDBNull(.Item("IDReservasiH")) Then MyReservasiD.IDReservasiH = Convert.ToInt64(.Item("IDReservasiH"))
  '          If Not IsDBNull(.Item("IDReservasiD")) Then MyReservasiD.IDReservasiD = Convert.ToInt64(.Item("IDReservasiD"))
  '          If Not IsDBNull(.Item("IDDaftarMeja")) Then MyReservasiD.IDDaftarMeja = Convert.ToInt32(.Item("IDDaftarMeja"))
  '          If Not IsDBNull(.Item("JamMulai")) Then MyReservasiD.JamMulai = Convert.ToDateTime(.Item("JamMulai"))
  '          If Not IsDBNull(.Item("JamSelesai")) Then MyReservasiD.JamSelesai = Convert.ToDateTime(.Item("JamSelesai"))
  '          MyListReservasiD.Add(MyReservasiD)
  '        End With
  '      Next
  '    End If
  '  End Using

  '  Return MyListReservasiD

  'End Function


#End Region

End Class


