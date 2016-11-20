Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class FormPenerimaan
    Private IDPembelianH As Long?

    Private Sub PenerimaanHBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PenerimaanHBindingNavigatorSaveItem.Click
        GridView1.SetFocusedRowCellValue(colCreatedBy, MyLoggedInPengguna.IDPengguna)
        GridView1.SetFocusedRowCellValue(colModifiedBy, MyLoggedInPengguna.IDPengguna)

        Me.Validate()
        Me.PenerimaanHBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetPenerimaan)
        IDPembelianH = CLng(GridView1.GetFocusedRowCellValue(colIDPembelianH))
        LoadSisaBarang()

    End Sub

    Private Sub FormPenerimaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetPenerimaan.Barang' table. You can move, or remove it, as needed.
        Me.BarangTableAdapter.Fill(Me.DataSetPenerimaan.Barang)
        Me.PenerimaanHTableAdapter.Fill(Me.DataSetPenerimaan.PenerimaanH)
        'TODO: This line of code loads data into the 'DataSetPenerimaan.PenerimaanD' table. You can move, or remove it, as needed.
        Me.Pnr_GetAktifPOTableAdapter.Fill(Me.DataSetPenerimaan.Pnr_GetAktifPO)
        'TODO: This line of code loads data into the 'DataSetPenerimaan.PenerimaanH' table. You can move, or remove it, as needed.
        Me.PenerimaanDTableAdapter.Fill(Me.DataSetPenerimaan.PenerimaanD)
        'TODO: This line of code loads data into the 'DataSetPenerimaan.Pnr_GetAktifPO' table. You can move, or remove it, as needed.



    End Sub
    Sub LoadSisaBarang()
        Me.GetBarangSisaByIDPembelianHTableAdapter.Fill(Me.DataSetPenerimaan.GetBarangSisaByIDPembelianH, IDPembelianH)
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If IsDBNull(GridView1.GetFocusedRowCellValue(colIDPembelianH)) Then
            IDPembelianH = 0
        Else
            IDPembelianH = CLng(GridView1.GetFocusedRowCellValue(colIDPembelianH))
        End If


    End Sub

    Private Sub BindingNavigatorAddNewItem1_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem1.Click
        LoadSisaBarang()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        Me.Validate()
        Me.PenerimaanHBindingSource.EndEdit()
        Me.FKPenerimaanHPenerimaanDBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetPenerimaan)
    End Sub

    Private Sub GridView2_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView2.InitNewRow
        GridView2.SetFocusedRowCellValue(colIDPenerimaanD, 0)
        GridView2.SetFocusedRowCellValue(colIDPenerimaanH1, GridView1.GetFocusedRowCellValue(colIDPenerimaanH))
    End Sub
End Class