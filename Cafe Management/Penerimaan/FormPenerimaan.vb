Public Class FormPenerimaan
    Private Sub PenerimaanHBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PenerimaanHBindingNavigatorSaveItem.Click
        GridView1.SetFocusedRowCellValue(colCreatedBy, MyLoggedInPengguna.IDPengguna)
        GridView1.SetFocusedRowCellValue(colModifiedBy, MyLoggedInPengguna.IDPengguna)

        Me.Validate()
        Me.PenerimaanHBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetPenerimaan)

    End Sub

    Private Sub FormPenerimaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetPenerimaan.PenerimaanD' table. You can move, or remove it, as needed.
        Me.PenerimaanDTableAdapter.Fill(Me.DataSetPenerimaan.PenerimaanD)
        'TODO: This line of code loads data into the 'DataSetPenerimaan.PenerimaanH' table. You can move, or remove it, as needed.
        Me.PenerimaanHTableAdapter.Fill(Me.DataSetPenerimaan.PenerimaanH)

    End Sub
End Class