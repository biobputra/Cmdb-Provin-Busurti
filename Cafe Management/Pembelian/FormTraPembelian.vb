Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class FormTraPembelian
    Private IDSupplier As Integer
    Private Property IDPembelianH As Long
    Private Sub PembelianHBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PembelianHBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PembelianHBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetPembelian)
    End Sub
    Sub LoadBarang()
        Me.BarangTableAdapter.Fill(Me.DataSetPembelian.Barang, IDSupplier)
    End Sub
    Private Sub FormTraPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetPembelian.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.DataSetPembelian.Supplier)
        'TODO: This line of code loads data into the 'DataSetPembelian.PembelianDetailSelect' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DataSetPembelian.PembelianH' table. You can move, or remove it, as needed.
        Me.PembelianHTableAdapter.Fill(Me.DataSetPembelian.PembelianH)
        Me.c.Fill(Me.DataSetPembelian.PembelianDetailSelect)
        GridView1.BestFitColumns(True)
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Validate()
        Me.PembelianDetailSelectBindingSource.EndEdit()
        Me.PembelianHBindingSource.EndEdit()
        Me.PembelianDetailSelectBindingSource.EndEdit()
        ' Me.FKPembelianHPembelianDetailSelectBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetPembelian)
    End Sub
    Private Sub GridView1_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        IDPembelianH = CLng(GridView1.GetFocusedRowCellValue(colIDPembelianH))
    End Sub

    Private Sub GridView2_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView2.InitNewRow
        GridView2.SetFocusedRowCellValue(colIDPembelianH1, IDPembelianH)
        GridView2.SetFocusedRowCellValue(colIDPembelianD, 0)
    End Sub

    Private Sub IDSupplierLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles IDSupplierLookUpEdit.EditValueChanged

        If IsDBNull(IDSupplierLookUpEdit.EditValue) Then
            IDSupplier = 0
        Else
            IDSupplier = CInt(IDSupplierLookUpEdit.EditValue)
        End If

        LoadBarang()

    End Sub


End Class