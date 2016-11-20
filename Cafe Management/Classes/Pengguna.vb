Public Class Pengguna

#Region "Properties"


    Private xIDPengguna As String
    Public Property IDPengguna() As String
        Get
            Return xIDPengguna
        End Get
        Set(ByVal value As String)
            xIDPengguna = value
        End Set
    End Property


    Private xIDKaryawan As Long
    Public Property IDKaryawan() As Long
        Get
            Return xIDKaryawan
        End Get
        Set(ByVal value As Long)
            xIDKaryawan = value
        End Set
    End Property

    Private xUserName As String
    Public Property UserName() As String
        Get
            Return xUserName
        End Get
        Set(ByVal value As String)
            xUserName = value
        End Set
    End Property

    Private xPassword As String
    Public Property Password() As String
        Get
            Return xPassword
        End Get
        Set(ByVal value As String)
            xPassword = value
        End Set
    End Property

    Private xUserPicture As String
    Public Property UserPicture() As String
        Get
            Return xUserPicture
        End Get
        Set(ByVal value As String)
            xUserPicture = value
        End Set
    End Property

    Private xDigitalSignature As Image
    Public Property DigitalSignature() As Image

        Get
            Return xDigitalSignature
        End Get
        Set(ByVal value As Image
)
            xDigitalSignature = value
        End Set
    End Property

    Private xCreatedBy As Integer
    Public Property CreatedBy() As Integer
        Get
            Return xCreatedBy
        End Get
        Set(ByVal value As Integer)
            xCreatedBy = value
        End Set
    End Property

    Private xCreatedDate As Date
    Public Property CreatedDate() As Date
        Get
            Return xCreatedDate
        End Get
        Set(ByVal value As Date)
            xCreatedDate = value
        End Set
    End Property

    Private xModifiedBy As Integer
    Public Property ModifiedBy() As Integer
        Get
            Return xModifiedBy
        End Get
        Set(ByVal value As Integer)
            xModifiedBy = value
        End Set
    End Property

    Private xModifiedDate As Date
    Public Property ModifiedDate() As Date
        Get
            Return xModifiedDate
        End Get
        Set(ByVal value As Date)
            xModifiedDate = value
        End Set
    End Property

    Private xIsActive As Boolean
    Public Property IsActive() As Boolean

        Get
            Return xIsActive
        End Get
        Set(ByVal value As Boolean
)
            xIsActive = value
        End Set
    End Property
#End Region


#Region "Methods"

    Shared Function ValidateLogin(MyUserName As String, MyPassword As String) As Boolean
        Dim MyResult As Boolean = False
        Try
            If CInt(DataAccess.GetSingleValue("Select Count(IDPengguna) from Pengguna where UserName='" & MyUserName & "' and Password= '" & MyPassword & "'")) > 0 Then
                MyResult = True
            Else
                MyResult = False
            End If
        Catch ex As Exception

        End Try
        Return MyResult
    End Function

    Shared Function GetUserByUserNamePassword(MyUserName As String, MyPassword As String) As Pengguna
        Dim MyPengguna As New Pengguna

        Using MyDataTable As DataTable = DataAccess.ExecuteQueryTable("select IDPengguna, IDKaryawan, UserName, Password, UserPicture, DigitalSignature, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, isActive From Pengguna Where UserName = '" & MyUserName & "'")
            If MyDataTable IsNot Nothing AndAlso MyDataTable.Rows.Count > 0 Then
                For Each MyRow As DataRow In MyDataTable.Rows

                    With MyRow
                        If Not IsDBNull(.Item("IDPengguna")) Then MyPengguna.IDPengguna = Convert.ToInt64(.Item("IDPengguna"))
                        If Not IsDBNull(.Item("IDKaryawan")) Then MyPengguna.IDKaryawan = Convert.ToInt64(.Item("IDKaryawan"))
                        If Not IsDBNull(.Item("UserName")) Then MyPengguna.UserName = .Item("UserName").ToString
                        If Not IsDBNull(.Item("Password")) Then MyPengguna.Password = .Item("Password").ToString
                        'If Not IsDBNull(.Item("UserPicture")) Then MyPengguna.UserPicture = .Item("UserPicture")
                        'If Not IsDBNull(.Item("DigitalSignature")) Then MyPengguna.DigitalSignature = .Item("DigitalSignature")
                        If Not IsDBNull(.Item("CreatedBy")) Then MyPengguna.CreatedBy = .Item("CreatedBy")
                        If Not IsDBNull(.Item("CreatedDate")) Then MyPengguna.CreatedDate = .Item("CreatedDate")
                        If Not IsDBNull(.Item("ModifiedBy")) Then MyPengguna.ModifiedBy = .Item("ModifiedBy")
                        If Not IsDBNull(.Item("ModifiedDate")) Then MyPengguna.ModifiedDate = .Item("ModifiedDate")
                        If Not IsDBNull(.Item("IsActive")) Then MyPengguna.IsActive = .Item("IsActive")
                    End With
                Next
            End If
        End Using

        Return MyPengguna
    End Function

#End Region
End Class
