Imports DevExpress.XtraGrid.Views.Grid

Public Class FormJenisIdentitas
    Dim IsActive As Boolean
    Private Id As Integer
    Private Sub JenisIdentitasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles JenisIdentitasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.JenisIdentitasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetJenisIdentitas)

    End Sub

    Private Sub LoadData()
        Try
            Me.JenisIdentitasTableAdapter.Fill(Me.DataSetJenisIdentitas.JenisIdentitas, New System.Nullable(Of Boolean)(CType(IsActive, Boolean)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Id = CInt(GridView1.GetFocusedRowCellValue(colIDJenisIdentitas))
        DeleteData("JenisIdentitas", Id, CInt(MyLoggedInPengguna.IDPengguna))
        LoadData()
    End Sub
    Private Sub RadioGroup1_EditValueChanged(sender As Object, e As EventArgs) Handles RadioGroup1.EditValueChanged
        IsActive = CBool(RadioGroup1.EditValue)
        LoadData()
    End Sub

    Private Sub FormJenisIdentitas_Load(sender As Object, e As EventArgs) Handles Me.Load
        RadioGroup1.SelectedIndex = 0
        IsActive = True
        LoadData()
    End Sub
    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetFocusedRowCellValue(colIDJenisIdentitas, 0)
    End Sub
End Class