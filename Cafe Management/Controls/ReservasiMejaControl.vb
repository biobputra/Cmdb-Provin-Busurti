Public Class ReservasiMejaControl

  Public Shared Event CheckedTable(ByVal IsChecked As Boolean, ByVal MyTableID As Integer, ByVal MyJamMulai As DateTime, MyJamSelesai As DateTime)

#Region "properties"


  Private xIDDaftarMeja As Integer
  Public Property IDDaftarMeja() As Integer
    Get
      Return xIDDaftarMeja
    End Get
    Set(value As Integer)
      xIDDaftarMeja = value
    End Set
  End Property

  Private xNomorMeja As Integer
  Public Property NomorMeja() As Integer
    Get
      Return xNomorMeja
    End Get
    Set(value As Integer)
      xNomorMeja = value
    End Set
  End Property

  Private xKeterangan As String
  Public Property Keterangan() As String
    Get
      Return xKeterangan
    End Get
    Set(value As String)
      xKeterangan = value
      NamaMejaLbl.Text = value
    End Set
  End Property
#End Region


#Region "Methods"


  Private Sub ChkMeja_CheckedChanged(sender As Object, e As EventArgs) Handles ChkMeja.CheckedChanged
    RaiseEvent CheckedTable(ChkMeja.Checked, IDDaftarMeja, Convert.ToDateTime(JamMulaiEdit.EditValue), Convert.ToDateTime(JamSelesaiEdit.EditValue))
  End Sub

#End Region


End Class
