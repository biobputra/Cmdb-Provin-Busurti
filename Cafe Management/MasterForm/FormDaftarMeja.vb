Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class FormDaftarMeja
    Dim IsActive As Boolean
    Private Id As Integer

    Private Sub DaftarMejaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DaftarMejaBindingNavigatorSaveItem.Click
        GridView1.SetFocusedRowCellValue(colid, 0)
        GridView1.SetFocusedRowCellValue(colCreatedBy, MyLoggedInPengguna.IDPengguna)
        GridView1.SetFocusedRowCellValue(colisActive, 1)
        GridView1.SetFocusedRowCellValue(colModifiedBy, MyLoggedInPengguna.IDPengguna)
        Me.Validate()
        Me.DaftarMejaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetDaftarMeja)

    End Sub

    Private Sub FormDaftarMeja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetDaftarMeja.JenisMeja' table. You can move, or remove it, as needed.
        IsActive = True
        RadioGroup1.SelectedIndex = 0
        Me.JenisMejaTableAdapter.Fill(Me.DataSetDaftarMeja.JenisMeja)
        LoadData()

    End Sub
    Sub LoadData()
        Try
            Me.DaftarMejaTableAdapter.Fill(Me.DataSetDaftarMeja.DaftarMeja, New System.Nullable(Of Boolean)(CType(IsActive, Boolean)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RadioGroup1_EditValueChanged(sender As Object, e As EventArgs) Handles RadioGroup1.EditValueChanged
        IsActive = CBool(RadioGroup1.EditValue)
        LoadData()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs)

    End Sub




    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetFocusedRowCellValue(colid, 1)
        idJenisMejaTextEdit.Focus()

        'GridView1.SetFocusedRowCellValue(colidJenisMeja, 0)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        DeleteData("DaftarMeja", Id, CInt(MyLoggedInPengguna.IDPengguna))
        LoadData()

    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Id = CInt(GridView1.GetFocusedRowCellValue(colid))
    End Sub
End Class