Imports DevExpress.XtraGrid.Views.Base

Public Class FormPengguna
    Dim IsActive As Boolean
    Private Id As Integer
    Dim IsEdit As Boolean = True
    Private Sub PenggunaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PenggunaBindingNavigatorSaveItem.Click

        If IsEdit = False Then
            If PasswordTextEdit.Text <> TextEdit1.Text Then
                MyAlert.Show(Me, "Gagal", "Password tidak cocok")
                Beep()
                Exit Sub
            Else
                Dim EncryptedPassword As String = MyCrypt.EncryptData(PasswordTextEdit.Text)
                PasswordTextEdit.Text = EncryptedPassword
                GridView1.SetFocusedRowCellValue(colCreatedBy, MyLoggedInPengguna.IDPengguna)
                GridView1.SetFocusedRowCellValue(colModifiedBy, MyLoggedInPengguna.IDPengguna)

                Me.Validate()
                Me.PenggunaBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.DataSetUser)

            End If
        Else
            Me.Validate()
            Me.PenggunaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DataSetUser)
        End If

        IsEdit = True
        TextEdit1.Text = PasswordTextEdit.Text
    End Sub

    Private Sub LoadData()
        Try
            Me.PenggunaTableAdapter.Fill(Me.DataSetUser.Pengguna, New System.Nullable(Of Boolean)(CType(IsActive, Boolean)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        TextEdit1.Text = PasswordTextEdit.Text
    End Sub

    Private Sub FormPengguna_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'DataSetUser.KaryawanGrid' table. You can move, or remove it, as needed.
        Me.KaryawanGridTableAdapter.Fill(Me.DataSetUser.KaryawanGrid)
        'TODO: This line of code loads data into the 'DataSetUser.Karyawan' table. You can move, or remove it, as needed.
        Me.KaryawanTableAdapter.Fill(Me.DataSetUser.Karyawan)
        RadioGroup1.SelectedIndex = 0
        IsActive = True
        LoadData()
        IsEdit = True
        PasswordTextEdit.Visible = False
        TextEdit1.Visible = False
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Id = CInt(GridView1.GetFocusedRowCellValue(colIDPengguna))
        DeleteData("Pengguna", Id, CInt(MyLoggedInPengguna.IDPengguna))
        LoadData()

    End Sub
    Private Sub RadioGroup1_EditValueChanged(sender As Object, e As EventArgs) Handles RadioGroup1.EditValueChanged
        IsActive = CBool(RadioGroup1.EditValue)
        LoadData()
    End Sub
    Sub ValidateUserData()
        If PasswordTextEdit.Text <> TextEdit1.Text Then
            MyAlert.Show(Me, "Gagal", "Passwort tidak cocok")
            Exit Sub
        Else
            Dim EncryptedPassword As String = MyCrypt.EncryptData(PasswordTextEdit.Text)
            PasswordTextEdit.Text = EncryptedPassword
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        IsEdit = False

    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        TextEdit1.Text = PasswordTextEdit.Text
    End Sub
End Class