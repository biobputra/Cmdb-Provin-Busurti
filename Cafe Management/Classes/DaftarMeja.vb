Public Class DaftarMeja

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

  Private xIDJenisMeja As Integer
  Public Property IDJenisMeja() As Integer
    Get
      Return xIDJenisMeja
    End Get
    Set(value As Integer)
      xIDJenisMeja = value
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
    End Set
  End Property

  Private xStatus As Int32
  Public Property Status() As Int32
    Get
      Return xStatus
    End Get
    Set(value As Int32)
      xStatus = value
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

  Private xCreatedBy As Integer
  Public Property CreatedBy() As Integer
    Get
      Return xCreatedBy
    End Get
    Set(value As Integer)
      xCreatedBy = value
    End Set
  End Property

  Private xCreatedDate As DateTime
  Public Property CreatedDate() As DateTime
    Get
      Return xCreatedDate
    End Get
    Set(value As DateTime)
      xCreatedDate = value
    End Set
  End Property

  Private xModifiedBy As Integer
  Public Property ModifiedBy() As Integer
    Get
      Return xModifiedBy
    End Get
    Set(value As Integer)
      xModifiedBy = value
    End Set
  End Property

  Private xModifiedDate As DateTime
  Public Property ModifiedDate() As DateTime
    Get
      Return xModifiedDate
    End Get
    Set(value As DateTime)
      xModifiedDate = value
    End Set
  End Property

  Private xisActive As Boolean
  Public Property isActive() As Boolean
    Get
      Return xisActive
    End Get
    Set(value As Boolean)
      xisActive = value
    End Set
  End Property

#End Region


#Region "Methods"

  Public Sub New()
  End Sub

  Public Sub New(ByVal MyIDDaftarMeja As Integer, ByVal MyIDJenisMeja As Integer, ByVal MyNomorMeja As Integer, ByVal MyKeterangan As String, ByVal MyStatus As Int32, ByVal MyTanggalbook As Date, ByVal MyJamMulai As DateTime, ByVal MyJamSelesai As DateTime, ByVal MyCreatedBy As Integer, ByVal MyCreatedDate As DateTime, ByVal MyModifiedBy As Integer, ByVal MyModifiedDate As DateTime, ByVal MyisActive As Boolean)
    IDDaftarMeja = MyIDDaftarMeja : IDJenisMeja = MyIDJenisMeja : NomorMeja = MyNomorMeja : Keterangan = MyKeterangan : Status = MyStatus : Tanggalbook = MyTanggalbook : JamMulai = MyJamMulai : JamSelesai = MyJamSelesai : CreatedBy = MyCreatedBy : CreatedDate = MyCreatedDate : ModifiedBy = MyModifiedBy : ModifiedDate = MyModifiedDate : isActive = MyisActive
  End Sub

  Shared Function GetListMejaByIDJenisMeja(ByVal MyIDJenisMeja As Integer) As List(Of DaftarMeja)
    Dim MyListDaftarMeja As New List(Of DaftarMeja)

    Using MyDataTable As DataTable = DataAccess.ExecuteQueryTable("Exec Dtm_SelectByJenisMeja " & MyIDJenisMeja)
      If MyDataTable IsNot Nothing AndAlso MyDataTable.Rows.Count > 0 Then
        For Each MyRow As DataRow In MyDataTable.Rows
          Dim MyDaftarMeja = New DaftarMeja()

          With MyRow
            If Not IsDBNull(.Item("IDDaftarMeja")) Then MyDaftarMeja.IDDaftarMeja = Convert.ToInt32(.Item("IDDaftarMeja"))
            If Not IsDBNull(.Item("IDJenisMeja")) Then MyDaftarMeja.IDJenisMeja = Convert.ToInt32(.Item("IDJenisMeja"))
            If Not IsDBNull(.Item("NomorMeja")) Then MyDaftarMeja.NomorMeja = Convert.ToInt32(.Item("NomorMeja"))
            If Not IsDBNull(.Item("Keterangan")) Then MyDaftarMeja.Keterangan = .Item("Keterangan").ToString
            If Not IsDBNull(.Item("Status")) Then MyDaftarMeja.Status = Convert.ToInt16(.Item("Status"))
            If Not IsDBNull(.Item("Tanggalbook")) Then MyDaftarMeja.Tanggalbook = Convert.ToDateTime(.Item("Tanggalbook"))
            If Not IsDBNull(.Item("JamMulai")) Then MyDaftarMeja.JamMulai = Convert.ToDateTime(.Item("JamMulai"))
            If Not IsDBNull(.Item("JamSelesai")) Then MyDaftarMeja.JamSelesai = Convert.ToDateTime(.Item("JamSelesai"))
            If Not IsDBNull(.Item("CreatedBy")) Then MyDaftarMeja.CreatedBy = Convert.ToInt32(.Item("CreatedBy"))
            If Not IsDBNull(.Item("CreatedDate")) Then MyDaftarMeja.CreatedDate = Convert.ToDateTime(.Item("CreatedDate"))
            If Not IsDBNull(.Item("ModifiedBy")) Then MyDaftarMeja.ModifiedBy = Convert.ToInt32(.Item("ModifiedBy"))
            If Not IsDBNull(.Item("ModifiedDate")) Then MyDaftarMeja.ModifiedDate = Convert.ToDateTime(.Item("ModifiedDate"))
          End With
          MyListDaftarMeja.Add(MyDaftarMeja)
        Next
      End If
    End Using

    Return MyListDaftarMeja
  End Function

  Shared Sub ReserveTable(MyIDDaftarMeja As Integer, ByVal MyJamMulai As DateTime, ByVal MyJamSelesai As DateTime)
    DataAccess.SQLNonQuery("Exec Dtm_ReserveTable " & MyIDDaftarMeja & ", " & MyJamMulai & ", " & MyJamSelesai)

  End Sub

#End Region


End Class
