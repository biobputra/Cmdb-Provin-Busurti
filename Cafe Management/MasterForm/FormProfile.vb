Imports DevExpress.XtraGrid.Views.Grid

Public Class FormProfile
    Dim IsActive As Boolean
    Private Id As Integer
    Private Sub ProfileBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProfileBindingNavigatorSaveItem.Click
        GridView1.SetFocusedRowCellValue(colCreatedBy, MyLoggedInPengguna.IDPengguna)
        GridView1.SetFocusedRowCellValue(colModifiedBy, MyLoggedInPengguna.IDPengguna)


        Me.Validate()
        Me.ProfileBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetProfile)

    End Sub

    Private Sub LoadData()

        Try
            Me.ProfileTableAdapter.Fill(Me.DataSetProfile.Profile, New System.Nullable(Of Boolean)(CType(IsActive, Boolean)))
        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub RadioGroup1_EditValueChanged(sender As Object, e As EventArgs) Handles RadioGroup1.EditValueChanged
        IsActive = CBool(RadioGroup1.EditValue)
        LoadData()
    End Sub

    Private Sub FormProfile_Load(sender As Object, e As EventArgs) Handles Me.Load
        RadioGroup1.SelectedIndex = 0
        IsActive = True
        LoadData()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Id = CInt(GridView1.GetFocusedRowCellValue(colIDProfile))
        DeleteData("Profile", Id, CInt(MyLoggedInPengguna.IDPengguna))
        LoadData()
    End Sub
End Class