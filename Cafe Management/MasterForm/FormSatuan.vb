Imports DevExpress.XtraGrid.Views.Base

Public Class FormSatuan
    Dim IsActive As Boolean
    Private Id As Integer


    Private Sub SatuanBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SatuanBindingNavigatorSaveItem.Click

        GridView1.SetFocusedRowCellValue(colIDSatuan, 0)
        GridView1.SetFocusedRowCellValue(colCreatedBy, MyLoggedInPengguna.IDPengguna)
        GridView1.SetFocusedRowCellValue(colModifiedBy, MyLoggedInPengguna.IDPengguna)

        Me.Validate()
        Me.SatuanBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetSatuan)

    End Sub

    Sub LoadData()
        Try
            Me.SatuanTableAdapter.Fill(Me.DataSetSatuan.Satuan, New System.Nullable(Of Boolean)(CType(IsActive, Boolean)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        Id = CInt(GridView1.GetFocusedRowCellValue(colIDSatuan))
        DeleteData("Satuan", Id, CInt(MyLoggedInPengguna.IDPengguna))
        LoadData()

    End Sub

    Private Sub RadioGroup1_EditValueChanged(sender As Object, e As EventArgs) Handles RadioGroup1.EditValueChanged
        IsActive = CBool(RadioGroup1.EditValue)
        LoadData()
    End Sub

    Private Sub FormSatuan_Load(sender As Object, e As EventArgs) Handles Me.Load
        RadioGroup1.SelectedIndex = 0
        IsActive = True
        LoadData()

    End Sub
End Class