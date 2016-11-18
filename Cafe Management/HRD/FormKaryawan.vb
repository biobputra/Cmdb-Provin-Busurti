Public Class FormKaryawan 

  Private Sub KaryawanBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles KaryawanBindingNavigatorSaveItem.Click
    Me.Validate()
    Me.KaryawanBindingSource.EndEdit()
    Me.TableAdapterManager.UpdateAll(Me.DataSetHRD)

  End Sub

  Private Sub FormKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'TODO: This line of code loads data into the 'DataSetHRD.Karyawan' table. You can move, or remove it, as needed.
    Me.KaryawanTableAdapter.Fill(Me.DataSetHRD.Karyawan)

  End Sub
End Class