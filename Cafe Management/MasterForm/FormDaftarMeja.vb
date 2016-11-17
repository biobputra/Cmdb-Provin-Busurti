Imports DevExpress.XtraGrid.Views.Grid

Public Class FormDaftarMeja
    Dim IsActive As Boolean
    Private Id As Integer
    Private Sub DaftarMejaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DaftarMejaBindingNavigatorSaveItem.Click

        GridView1.SetFocusedRowCellValue(colCreatedBy, MyLoggedInPengguna.IDPengguna)
        GridView1.SetFocusedRowCellValue(colModifiedBy, MyLoggedInPengguna.IDPengguna)


        Me.Validate()
        Me.DaftarMejaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetDaftarMeja)

    End Sub

    Private Sub LoadData()
        Try
            Me.DaftarMejaTableAdapter.Fill(Me.DataSetDaftarMeja.DaftarMeja, New System.Nullable(Of Boolean)(CType(IsActive, Boolean)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FormDaftarMeja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetDaftarMeja.JenisMeja' table. You can move, or remove it, as needed.
        Me.JenisMejaTableAdapter.Fill(Me.DataSetDaftarMeja.JenisMeja)
        RadioGroup1.SelectedIndex = 0
        IsActive = True
        LoadData()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Id = CInt(GridView1.GetFocusedRowCellValue(colIDDaftarMeja))
        DeleteData("DaftarMeja", Id, CInt(MyLoggedInPengguna.IDPengguna))
        LoadData()
    End Sub
    Private Sub RadioGroup1_EditValueChanged(sender As Object, e As EventArgs) Handles RadioGroup1.EditValueChanged
        IsActive = CBool(RadioGroup1.EditValue)
        LoadData()
    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetFocusedRowCellValue(colIDDaftarMeja, 0)
    End Sub
End Class