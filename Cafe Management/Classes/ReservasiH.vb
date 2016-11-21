Public Class ReservasiH

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

  Private xIDAnggota As Long
  Public Property IDAnggota() As Long
    Get
      Return xIDAnggota
    End Get
    Set(value As Long)
      xIDAnggota = value
    End Set
  End Property

  Private xNama As String
  Public Property Nama() As String
    Get
      Return xNama
    End Get
    Set(value As String)
      xNama = value
    End Set
  End Property

  Private xTanggalReservasi As Date
  Public Property TanggalReservasi() As Date
    Get
      Return xTanggalReservasi
    End Get
    Set(value As Date)
      xTanggalReservasi = value
    End Set
  End Property

  Private xUntukTanggal As Date
  Public Property UntukTanggal() As Date
    Get
      Return xUntukTanggal
    End Get
    Set(value As Date)
      xUntukTanggal = value
    End Set
  End Property
  Private xStatusAktif As Boolean
  Public Property StatusAktif() As Boolean
    Get
      Return xStatusAktif
    End Get
    Set(value As Boolean)
      xStatusAktif = value
    End Set
  End Property

#End Region


#Region "Methods"

  Public Sub New()
  End Sub

  Public Sub New(ByVal MyIDReservasiH AS Long, ByVal MyIDAnggota AS Long, ByVal MyNama AS String, ByVal MyTanggalReservasi AS date, ByVal MyUntukTanggal AS date, ByVal MyStatusAktif AS Boolean)
    IDReservasiH = MyIDReservasiH : IDAnggota = MyIDAnggota : Nama = MyNama : TanggalReservasi = MyTanggalReservasi : UntukTanggal = MyUntukTanggal : StatusAktif = MyStatusAktif
  End Sub

  Shared Function GetReservasiHHariIni() As List(Of ReservasiH)
    Dim MyListReservasiH As New List(Of ReservasiH)
    Using MyDataTable As DataTable = DataAccess.ExecuteQueryTable("exec Rsv_GetReservasiHHariIni")

      If MyDataTable IsNot Nothing AndAlso MyDataTable.Rows.Count > 0 Then
        For Each MyRow As DataRow In MyDataTable.Rows
          Dim MyReservasiH = New ReservasiH()
          With MyRow
            If Not IsDBNull(.Item("IDReservasiH")) Then MyReservasiH.IDReservasiH = Convert.ToInt64(.Item("IDReservasiH"))
            If Not IsDBNull(.Item("IDAnggota")) Then MyReservasiH.IDAnggota = Convert.ToInt32(.Item("IDAnggota"))
            If Not IsDBNull(.Item("Nama")) Then MyReservasiH.Nama = .Item("Nama").ToString()
            If Not IsDBNull(.Item("TanggalReservasi")) Then MyReservasiH.TanggalReservasi = Convert.ToDateTime(.Item("TanggalReservasi"))
            If Not IsDBNull(.Item("UntukTanggal")) Then MyReservasiH.UntukTanggal = Convert.ToDateTime(.Item("UntukTanggal"))
            If Not IsDBNull(.Item("StatusAktif")) Then MyReservasiH.StatusAktif = Convert.ToBoolean(.Item("StatusAktif"))
            MyListReservasiH.Add(MyReservasiH)
          End With
        Next
      End If
    End Using

    Return MyListReservasiH
  End Function

  Shared Function GetIDReservasiHByNama(MyNama As String) As Long
    Return Convert.ToInt64(DataAccess.GetSingleValue("Rsv_GetIDReservasiHByNama " & "'" & MyNama & "'"))

    
  End Function

  Public Sub AddNew(MyListReservasiD As List(Of ReservasiD))
    Dim MyQuery As New List(Of String)
    Dim MyIDHeader As Long = Convert.ToInt64(DataAccess.GetSingleValue("DECLARE @ID INT;EXEC dbo.App_GetNewID @NamaTabel = 'ReservasiH', @MyOutput = @ID OUTPUT;SELECT @ID"))
    With Me

      MyQuery.Add("Exec Rsv_ReservasiHInsert " & _
                             .IDAnggota & ", " & _
                             "'" & .Nama & "', " & _
                             "'" & .UntukTanggal & "'")

      For Each MyReservasiD As ReservasiD In MyListReservasiD
        MyQuery.Add("Exec Rsv_ReservasiDInsert " & _
                    MyIDHeader & ", " & _
                    MyReservasiD.IDDaftarMeja & ", " & _
                    "'" & MyReservasiD.JamMulai & "', " & _
                    "'" & MyReservasiD.JamSelesai & "'")
      Next

      DataAccess.SQLNonQuery(MyQuery)
    End With
  End Sub

  Shared Sub CheckIn(ByVal MyIDReservasiH As Long, ByVal MyIDUser As Integer)
    DataAccess.SQLNonQuery("exec Rsv_CheckIn " & MyIDReservasiH & ", " & MyIDUser)


  End Sub

#End Region

End Class
