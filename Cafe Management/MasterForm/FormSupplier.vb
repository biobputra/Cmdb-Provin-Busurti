Imports DevExpress.XtraGrid.Views.Base

Public Class FormSupplier
    Dim IsActive As Boolean
    Private Id As Integer

    Private Sub SupplierBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SupplierBindingNavigatorSaveItem.Click

        GridView1.SetFocusedRowCellValue(colIDSupplier, 0)
        GridView1.SetFocusedRowCellValue(colCreatedBy, MyLoggedInPengguna.IDPengguna)
        GridView1.SetFocusedRowCellValue(colModifiedBy, MyLoggedInPengguna.IDPengguna)
        Me.Validate()
        Me.SupplierBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetSuppier)

    End Sub

    Private Sub LoadData()
        Try
            Me.SupplierTableAdapter.Fill(Me.DataSetSuppier.Supplier, New System.Nullable(Of Boolean)(CType(IsActive, Boolean)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FormSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetSuppier.Title' table. You can move, or remove it, as needed.
        Me.TitleTableAdapter.Fill(Me.DataSetSuppier.Title)
        RadioGroup1.SelectedIndex = 0
        IsActive = True
        LoadData()
    End Sub

    Private Sub GridView1_FocusedColumnChanged(sender As Object, e As FocusedColumnChangedEventArgs) Handles GridView1.FocusedColumnChanged
        GridView1.SetFocusedRowCellValue(colIDSupplier, 0)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Id = CInt(GridView1.GetFocusedRowCellValue(colIDSupplier))
        DeleteData("Supplier", Id, CInt(MyLoggedInPengguna.IDPengguna))
        LoadData()

    End Sub
    Private Sub RadioGroup1_EditValueChanged(sender As Object, e As EventArgs) Handles RadioGroup1.EditValueChanged
        IsActive = CBool(RadioGroup1.EditValue)
        LoadData()
    End Sub
End Class