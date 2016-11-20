Public Class FormUserProfile
    Dim IsActive As Boolean
    Private Id As Integer
    Private Sub UserProfileBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UserProfileBindingNavigatorSaveItem.Click
        GridView1.SetFocusedRowCellValue(colCreatedBy, MyLoggedInPengguna.IDPengguna)
        GridView1.SetFocusedRowCellValue(colModifiedBy, MyLoggedInPengguna.IDPengguna)
        Try
            Me.Validate()
            Me.UserProfileBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DataSetUserProfile)
        Catch ex As Exception
            If ex.Message.ToString.ToLower.Contains("unique") Then
                MyAlert.Show(Me, "Gagal Menyimpan Data", "User sudah terdaftar")
                Beep()
            End If
        End Try
    End Sub

    Private Sub LoadData()
        Try
            Me.UserProfileTableAdapter.Fill(Me.DataSetUserProfile.UserProfile, New System.Nullable(Of Boolean)(CType(IsActive, Boolean)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FormUserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetUserProfile.PenggunaGrid' table. You can move, or remove it, as needed.
        Me.PenggunaGridTableAdapter.Fill(Me.DataSetUserProfile.PenggunaGrid)
        'TODO: This line of code loads data into the 'DataSetUserProfile.ProfileGrid' table. You can move, or remove it, as needed.
        Me.ProfileGridTableAdapter.Fill(Me.DataSetUserProfile.ProfileGrid)
        'TODO: This line of code loads data into the 'DataSetUserProfile.Profile' table. You can move, or remove it, as needed.
        Me.ProfileTableAdapter.Fill(Me.DataSetUserProfile.Profile)
        'TODO: This line of code loads data into the 'DataSetUserProfile.Pengguna' table. You can move, or remove it, as needed.
        Me.PenggunaTableAdapter.Fill(Me.DataSetUserProfile.Pengguna)
        RadioGroup1.SelectedIndex = 0
        IsActive = True
        LoadData()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Id = CInt(GridView1.GetFocusedRowCellValue(colIDUser))
        DeleteData("UserProfile", Id, CInt(MyLoggedInPengguna.IDPengguna))
        LoadData()

    End Sub
    Private Sub RadioGroup1_EditValueChanged(sender As Object, e As EventArgs) Handles RadioGroup1.EditValueChanged
        IsActive = CBool(RadioGroup1.EditValue)
        LoadData()
    End Sub
End Class