Public Class FormProductSupplier
    Dim IsActive As Boolean
    Private Id As Integer
    Private Sub ProdukSupplierBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProdukSupplierBindingNavigatorSaveItem.Click
        GridView1.SetFocusedRowCellValue(colCreatedBy, MyLoggedInPengguna.IDPengguna)
        GridView1.SetFocusedRowCellValue(colModifiedBy, MyLoggedInPengguna.IDPengguna)
        Me.Validate()
        Me.ProdukSupplierBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetProductSupplier)

    End Sub

    Private Sub LoadData()
        Try
            Me.ProdukSupplierTableAdapter.Fill(Me.DataSetProductSupplier.ProdukSupplier, New System.Nullable(Of Boolean)(CType(IsActive, Boolean)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FormProductSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetProductSupplier.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.DataSetProductSupplier.Supplier)
        'TODO: This line of code loads data into the 'DataSetProductSupplier.Barang' table. You can move, or remove it, as needed.
        Me.BarangTableAdapter.Fill(Me.DataSetProductSupplier.Barang)
        RadioGroup1.SelectedIndex = 0
        IsActive = True
        LoadData()

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Id = CInt(GridView1.GetFocusedRowCellValue(colIDProdukSupplier))
        DeleteData("ProdukSupplier", Id, CInt(MyLoggedInPengguna.IDPengguna))
        LoadData()
    End Sub
    Private Sub RadioGroup1_EditValueChanged(sender As Object, e As EventArgs) Handles RadioGroup1.EditValueChanged
        IsActive = CBool(RadioGroup1.EditValue)
        LoadData()
    End Sub
End Class