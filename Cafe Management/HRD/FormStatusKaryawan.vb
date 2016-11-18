Public Class FormStatusKaryawan 

  Private Sub StatusKaryawanBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StatusKaryawanBindingNavigatorSaveItem.Click
    Me.Validate()
    Me.StatusKaryawanBindingSource.EndEdit()
    Me.TableAdapterManager.UpdateAll(Me.DataSetHRD)

  End Sub

  Private Sub FormStatusKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'TODO: This line of code loads data into the 'DataSetHRD.StatusKaryawan' table. You can move, or remove it, as needed.
    Me.StatusKaryawanTableAdapter.Fill(Me.DataSetHRD.StatusKaryawan)

  End Sub
End Class