Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class FormProdukLayanan
    Dim IsActive As Boolean
    Private Id As Integer
    Private IDProdukLayananH As Integer

    Private Sub ProdukLayananHBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProdukLayananHBindingNavigatorSaveItem.Click
        GridView1.SetFocusedRowCellValue(colCreatedBy, MyLoggedInPengguna.IDPengguna)
        GridView1.SetFocusedRowCellValue(colModifiedBy, MyLoggedInPengguna.IDPengguna)

        Me.Validate()
        Me.ProdukLayananHBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetProdukDanLayanan)

    End Sub

    Private Sub LoadHeader()
        Try
            Me.ProdukLayananHTableAdapter.Fill(Me.DataSetProdukDanLayanan.ProdukLayananH, New System.Nullable(Of Boolean)(CType(IsActive, Boolean)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FormProdukLayanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetProdukDanLayanan.ProdukLayananD' table. You can move, or remove it, as needed.
        DataSetProdukDanLayanan.EnforceConstraints = False
        IsActive = True
        LoadHeader()
        Me.ProdukLayananDTableAdapter.Fill(Me.DataSetProdukDanLayanan.ProdukLayananD)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Id = CInt(GridView1.GetFocusedRowCellValue(colIDProdukLayananH))
        DeleteData("ProdukLayananH", Id, CInt(MyLoggedInPengguna.IDPengguna))
        LoadHeader()
    End Sub
    Private Sub RadioGroup1_EditValueChanged(sender As Object, e As EventArgs) Handles RadioGroup1.EditValueChanged
        IsActive = CBool(RadioGroup1.EditValue)
        'GridView2.Columns.Clear()

        LoadHeader()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        GridView2.SetFocusedRowCellValue(colCreatedBy, MyLoggedInPengguna.IDPengguna)
        GridView2.SetFocusedRowCellValue(colModifiedBy, MyLoggedInPengguna.IDPengguna)

        Me.Validate()
        Me.ProdukLayananHBindingSource.EndEdit()
        FKProdukLayananHProdukLayananDBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetProdukDanLayanan)

    End Sub

    Private Sub GridView2_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView2.InitNewRow
        GridView2.SetFocusedRowCellValue(colIDProdukLayananH1, IDProdukLayananH)
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If IsDBNull(GridView1.GetFocusedRowCellValue(colIDProdukLayananH)) Then
            IDProdukLayananH = 0
        Else
            IDProdukLayananH = CInt(GridView1.GetFocusedRowCellValue(colIDProdukLayananH))
        End If
    End Sub
End Class