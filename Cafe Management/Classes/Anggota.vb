Public Class Anggota

#Region "Properties"

  Private xIDAnggota As Integer
  Public Property IDAnggota() As Integer
    Get
      Return xIDAnggota
    End Get
    Set(value As Integer)
      xIDAnggota = value
    End Set
  End Property

  Private xKode As String
  Public Property Kode() As String
    Get
      Return xKode
    End Get
    Set(value As String)
      xKode = value
    End Set
  End Property

  Private xJenisIdentitas As Integer
  Public Property JenisIdentitas() As Integer
    Get
      Return xJenisIdentitas
    End Get
    Set(value As Integer)
      xJenisIdentitas = value
    End Set
  End Property

  Private xNomorIdentitas As String
  Public Property NomorIdentitas() As String
    Get
      Return xNomorIdentitas
    End Get
    Set(value As String)
      xNomorIdentitas = value
    End Set
  End Property

  Private xidTitle As Integer
  Public Property idTitle() As Integer
    Get
      Return xidTitle
    End Get
    Set(value As Integer)
      xidTitle = value
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

  Private xTanggalBergabung As Date
  Public Property TanggalBergabung() As Date
    Get
      Return xTanggalBergabung
    End Get
    Set(value As Date)
      xTanggalBergabung = value
    End Set
  End Property

  Private xAlamat As String
  Public Property Alamat() As String
    Get
      Return xAlamat
    End Get
    Set(value As String)
      xAlamat = value
    End Set
  End Property

  Private xNomorHandphone As String
  Public Property NomorHandphone() As String
    Get
      Return xNomorHandphone
    End Get
    Set(value As String)
      xNomorHandphone = value
    End Set
  End Property

  Private xPhoto As Image
  Public Property Photo() As Image
    Get
      Return xPhoto
    End Get
    Set(value As Image)
      xPhoto = value
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

  Public Sub New(ByVal MyIDAnggota As Integer, ByVal MyKode As String, ByVal MyJenisIdentitas As Integer, ByVal MyNomorIdentitas As String, ByVal MyidTitle As Integer, ByVal MyNama As String, ByVal MyTanggalBergabung As Date, ByVal MyAlamat As String, ByVal MyNomorHandphone As String, ByVal MyPhoto As Image, ByVal MyCreatedBy As Integer, ByVal MyCreatedDate As DateTime, ByVal MyModifiedBy As Integer, ByVal MyModifiedDate As DateTime, ByVal MyisActive As Boolean)
    IDAnggota = MyIDAnggota : Kode = MyKode : JenisIdentitas = MyJenisIdentitas : NomorIdentitas = MyNomorIdentitas : idTitle = MyidTitle : Nama = MyNama : TanggalBergabung = MyTanggalBergabung : Alamat = MyAlamat : NomorHandphone = MyNomorHandphone : Photo = MyPhoto : CreatedBy = MyCreatedBy : CreatedDate = MyCreatedDate : ModifiedBy = MyModifiedBy : ModifiedDate = MyModifiedDate : isActive = MyisActive
  End Sub

  Shared Function GetListAnggotaCombo() As List(Of Anggota)
    Dim MyListAnggota As New List(Of Anggota)
    Using MyDataTable As DataTable = DataAccess.ExecuteQueryTable("exec Ang_GetListAnggotaCombo")

      If MyDataTable IsNot Nothing AndAlso MyDataTable.Rows.Count > 0 Then
        For Each MyRow As DataRow In MyDataTable.Rows
          Dim MyAnggota = New Anggota()
          With MyRow
            If Not IsDBNull(.Item("IDAnggota")) Then MyAnggota.IDAnggota = Convert.ToInt32(.Item("IDAnggota"))
            If Not IsDBNull(.Item("Nama")) Then MyAnggota.Nama = .Item("Nama").ToString()
            MyListAnggota.Add(MyAnggota)
          End With
        Next
      End If
    End Using

    Return MyListAnggota
  End Function


#End Region

End Class
