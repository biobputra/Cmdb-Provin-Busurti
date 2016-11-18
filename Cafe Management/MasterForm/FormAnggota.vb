Public Class FormAnggota
    Dim IsActive As Boolean
    Private Id As Integer
    Private Sub AnggotaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AnggotaBindingNavigatorSaveItem.Click

        GridView1.SetFocusedRowCellValue(colCreatedBy, MyLoggedInPengguna.IDPengguna)
        GridView1.SetFocusedRowCellValue(colModifiedBy, MyLoggedInPengguna.IDPengguna)
        Me.Validate()
        Me.AnggotaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetAnggota)

    End Sub

    Private Sub LoadData()
        Try
            Me.AnggotaTableAdapter.Fill(Me.DataSetAnggota.Anggota, New System.Nullable(Of Boolean)(CType(IsActive, Boolean)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Id = CInt(GridView1.GetFocusedRowCellValue(colIDAnggota))
        DeleteData("Anggota", Id, CInt(MyLoggedInPengguna.IDPengguna))
        LoadData()
    End Sub
    Private Sub RadioGroup1_EditValueChanged(sender As Object, e As EventArgs) Handles RadioGroup1.EditValueChanged
        IsActive = CBool(RadioGroup1.EditValue)
        LoadData()
    End Sub

    Private Sub FormAnggota_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DataSetAnggota.TitleGrid' table. You can move, or remove it, as needed.
        Me.TitleGridTableAdapter.Fill(Me.DataSetAnggota.TitleGrid)
        'TODO: This line of code loads data into the 'DataSetAnggota.JenisIdentitasGrid' table. You can move, or remove it, as needed.
        Me.JenisIdentitasGridTableAdapter.Fill(Me.DataSetAnggota.JenisIdentitasGrid)
        'TODO: This line of code loads data into the 'DataSetAnggota.Title' table. You can move, or remove it, as needed.
        Me.TitleTableAdapter.Fill(Me.DataSetAnggota.Title)
        'TODO: This line of code loads data into the 'DataSetAnggota.JenisIdentitas' table. You can move, or remove it, as needed.
        Me.JenisIdentitasTableAdapter.Fill(Me.DataSetAnggota.JenisIdentitas)
        RadioGroup1.SelectedIndex = 0
        IsActive = True
        LoadData()
        GridView1.BestFitColumns(True)
    End Sub
End Class