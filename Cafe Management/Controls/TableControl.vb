Public Class TableControl

#Region "Properties"

  Private xIDDaftarMeja As Integer
  Public Property IDDaftarMeja() As Integer
    Get
      Return xIDDaftarMeja
    End Get
    Set(value As Integer)
      xIDDaftarMeja = value
    End Set
  End Property

  Private xIDJenisMeja As Integer
  Public Property IDJenisMeja() As Integer
    Get
      Return xIDJenisMeja
    End Get
    Set(value As Integer)
      xIDJenisMeja = value
      If value = 1 Then
        Pic.Image = Image.FromFile(Application.StartupPath & "\Image\PoolTable.jpg")

      Else
        Pic.Image = Image.FromFile(Application.StartupPath & "\Image\RestoTable.jpg")
      End If
    End Set
  End Property

  Private xNomorMeja As Integer
  Public Property NomorMeja() As Integer
    Get
      Return xNomorMeja
    End Get
    Set(value As Integer)
      xNomorMeja = value
      NoMejaLbl.Text = value
    End Set
  End Property

  Private xKeterangan As String
  Public Property Keterangan() As String
    Get
      Return xKeterangan
    End Get
    Set(value As String)
      xKeterangan = value
    End Set
  End Property

  Private xStatus As Int32
  Public Property Status() As Int32
    Get
      Return xStatus
    End Get
    Set(value As Int32)
      xStatus = value
      Select Case value
        Case 0
          NoMejaLbl.BackColor = Color.LightGreen
          ReserveBtn.Enabled = True
          CheckInBtn.Enabled = False
          Extendbtn.Enabled = False
          OrderBtn.Enabled = False
        Case 1
          NoMejaLbl.BackColor = Color.LightBlue
          ReserveBtn.Enabled = True
          CheckInBtn.Enabled = True
          Extendbtn.Enabled = False
          OrderBtn.Enabled = False
        Case 2
          NoMejaLbl.BackColor = Color.Gold
          ReserveBtn.Enabled = False
          CheckInBtn.Enabled = False
          Extendbtn.Enabled = True
          OrderBtn.Enabled = True
        Case 3
          NoMejaLbl.BackColor = Color.Tomato
          NoMejaLbl.BackColor = Color.Gold
          ReserveBtn.Enabled = False
          CheckInBtn.Enabled = False
          Extendbtn.Enabled = True
          OrderBtn.Enabled = True
          OrderBtn.Text = "Check Out"
      End Select

    End Set
  End Property

  Private xTanggalbook As Date
  Public Property Tanggalbook() As Date
    Get
      Return xTanggalbook
    End Get
    Set(value As Date)
      xTanggalbook = value
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


  Public Shared Event MakeOrder(MyNoMeja As Integer)



  Private Sub TableControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  End Sub

  Private Sub CollapseBtn_Click(sender As Object, e As EventArgs) Handles CollapseBtn.Click
    If Me.Width = 335 Then
      Me.Width = 165
      CollapseBtn.ImageIndex = 0
    Else
      Me.Width = 335
      CollapseBtn.ImageIndex = 1
    End If
  End Sub

  Private Sub ReserveBtn_Click(sender As Object, e As EventArgs) Handles ReserveBtn.Click
    If Me.Status = 0 Then
      Me.Status = 1
    Else
      Me.Status = 0
    End If
  End Sub

  Private Sub CheckInBtn_Click(sender As Object, e As EventArgs) Handles CheckInBtn.Click
    Me.Status = 2
  End Sub

  Private Sub OrderBtn_Click(sender As Object, e As EventArgs) Handles OrderBtn.Click
    RaiseEvent MakeOrder(Me.NomorMeja)
  End Sub
End Class
