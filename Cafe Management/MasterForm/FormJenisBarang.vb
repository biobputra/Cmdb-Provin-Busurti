Imports DevExpress.XtraGrid.Views.Grid

Public Class FormJenisBarang
    Dim IsActive As Boolean
    Private Id As Integer
    Private Sub JenisBarangBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles JenisBarangBindingNavigatorSaveItem.Click
        GridView1.SetFocusedRowCellValue(colIdJenisBarang, 0)
        GridView1.SetFocusedRowCellValue(colCreatedBy, MyLoggedInPengguna.IDPengguna)
        GridView1.SetFocusedRowCellValue(colModifiedBy, MyLoggedInPengguna.IDPengguna)

        Me.Validate()
        Me.JenisBarangBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetJenisBarang)

    End Sub

    Private Sub RadioGroup1_EditValueChanged(sender As Object, e As EventArgs) Handles RadioGroup1.EditValueChanged
        IsActive = CBool(RadioGroup1.EditValue)
        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            Me.JenisBarangTableAdapter.Fill(Me.DataSetJenisBarang.JenisBarang, New System.Nullable(Of Boolean)(CType(IsActive, Boolean)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FormJenisBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioGroup1.SelectedIndex = 0
        IsActive = True
        LoadData()

    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetFocusedRowCellValue(colIdJenisBarang, 0)
    End Sub
End Class