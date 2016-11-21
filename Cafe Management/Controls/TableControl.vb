Public Class TableControl

  Sub New()

    ' This call is required by the designer.
    InitializeComponent()
    Me.Width = 165

    ' Add any initialization after the InitializeComponent() call.

  End Sub


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
      NoMejaLbl.Text = value.ToString
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
          'free
          NoMejaLbl.BackColor = Color.LightGreen
          
          Extendbtn.Enabled = False
          OrderBtn.Enabled = False
        Case 1
          'reserved
          NoMejaLbl.BackColor = Color.LightBlue
          UnReserveBtn.Enabled = True
          Extendbtn.Enabled = False
          OrderBtn.Enabled = False
        Case 2
          'Checkedin
          NoMejaLbl.BackColor = Color.Gold
          
          Extendbtn.Enabled = True
          OrderBtn.Enabled = True
        Case 3
          'time out
          NoMejaLbl.BackColor = Color.Tomato
          
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


  Private Sub UnReserveBtn_Click(sender As Object, e As EventArgs) Handles UnReserveBtn.Click

  End Sub

  Private Sub ExtendBtn_Click(sender As Object, e As EventArgs) Handles ExtendBtn.Click

  End Sub

  Private Sub OrderBtn_Click(sender As Object, e As EventArgs) Handles OrderBtn.Click
    RaiseEvent MakeOrder(NomorMeja)
  End Sub

  Private Sub TableCheckTmr_Tick(sender As Object, e As EventArgs) Handles TableCheckTmr.Tick
    Select Case Status
      Case 0
        'periksa waktu reservasi
      Case 1
        'periksa checkin
      Case 2
        'periksa time out
    End Select

  End Sub
End Class
