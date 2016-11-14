Imports DevExpress.XtraGrid.Views.Grid

Public Class FormBarang
    Dim IsActive As Boolean
    Dim Id As Integer
    Private Sub BarangBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BarangBindingNavigatorSaveItem.Click


        GridView1.SetFocusedRowCellValue(colCreatedBy, MyLoggedInPengguna.IDPengguna)
        GridView1.SetFocusedRowCellValue(colModifiedBy, MyLoggedInPengguna.IDPengguna)

        Me.Validate()
        Me.BarangBindingSource.EndEdit()

        Me.TableAdapterManager.UpdateAll(Me.DataSetBarang)
        GridView1.FocusedRowHandle = 0
    End Sub

    Private Sub LoadData()
        Try
            Me.BarangTableAdapter.Fill(Me.DataSetBarang.Barang, New System.Nullable(Of Boolean)(CType(IsActive, Boolean)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FormBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetBarang.Satuan' table. You can move, or remove it, as needed.
        Me.SatuanTableAdapter.Fill(Me.DataSetBarang.Satuan)
        'TODO: This line of code loads data into the 'DataSetBarang.JenisBarang' table. You can move, or remove it, as needed.
        Me.JenisBarangTableAdapter.Fill(Me.DataSetBarang.JenisBarang)
        IsActive = True
        RadioGroup1.SelectedIndex = 0
        LoadData()
        'GridView1.BestFitColumns(True)
    End Sub
    Private Sub RadioGroup1_EditValueChanged(sender As Object, e As EventArgs) Handles RadioGroup1.EditValueChanged
        IsActive = CBool(RadioGroup1.EditValue)
        LoadData()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Id = CInt(GridView1.GetFocusedRowCellValue(colIDBarang))
        DeleteData("Barang", Id, CInt(MyLoggedInPengguna.IDPengguna))
        LoadData()
    End Sub

End Class