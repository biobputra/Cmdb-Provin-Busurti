Imports DevExpress.XtraGrid.Views.Grid

Public Class FormTermOfPayment
    Dim IsActive As Boolean
    Private Id As Integer

    Private Sub TermOfPaymentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TermOfPaymentBindingNavigatorSaveItem.Click
        GridView1.SetFocusedRowCellValue(colCreatedBy, MyLoggedInPengguna.IDPengguna)
        GridView1.SetFocusedRowCellValue(colModifiedBy, MyLoggedInPengguna.IDPengguna)

        Me.Validate()
        Me.TermOfPaymentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetTermOfPayment)

    End Sub

    Private Sub LoadData()

        Try
            Me.TermOfPaymentTableAdapter.Fill(Me.DataSetTermOfPayment.TermOfPayment, New System.Nullable(Of Boolean)(CType(IsActive, Boolean)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Id = CInt(GridView1.GetFocusedRowCellValue(colIDTermOfPayment))
        DeleteData("TermOfPayment", Id, CInt(MyLoggedInPengguna.IDPengguna))
        LoadData()
    End Sub
    Private Sub RadioGroup1_EditValueChanged(sender As Object, e As EventArgs) Handles RadioGroup1.EditValueChanged
        IsActive = CBool(RadioGroup1.EditValue)
        LoadData()
    End Sub

    Private Sub FormTermOfPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RadioGroup1.SelectedIndex = 0
        IsActive = True
        LoadData()

    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetFocusedRowCellValue(colIDTermOfPayment, 0)
    End Sub
End Class