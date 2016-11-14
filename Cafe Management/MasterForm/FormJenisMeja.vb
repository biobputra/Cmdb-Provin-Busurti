Imports DevExpress.XtraGrid.Views.Base

Public Class FormJenisMeja
    Dim IsActive As Boolean
    Dim Id As Integer
    Private Sub Jnm_SelectBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Jnm_SelectBindingNavigatorSaveItem.Click

        GridView1.SetFocusedRowCellValue(colIDJenisMeJa, 0)
        GridView1.SetFocusedRowCellValue(colCreatedBy, MyLoggedInPengguna.IDPengguna)
        GridView1.SetFocusedRowCellValue(colModifiedBy, MyLoggedInPengguna.IDPengguna)
        Me.Validate()
        Me.Jnm_SelectBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetJenisMeja)

    End Sub

    Sub LoadData()
        Try
            Me.Jnm_SelectTableAdapter.Fill(Me.DataSetJenisMeja.Jnm_Select, New Boolean?(CType(IsActive, Boolean)))
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FormJenisMeja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsActive = True
        LoadData()

    End Sub

    Private Sub RadioGroup1_EditValueChanged(sender As Object, e As EventArgs) Handles RadioGroup1.EditValueChanged
        IsActive = CBool(RadioGroup1.EditValue)
        LoadData()
    End Sub


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Id = CInt(GridView1.GetFocusedRowCellValue(colIDJenisMeJa))
        DeleteData("JenisMeja", Id, CInt(MyLoggedInPengguna.IDPengguna))
        LoadData()

    End Sub

End Class