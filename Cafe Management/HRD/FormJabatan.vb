Public Class FormJabatan 

  Private Sub JabatanBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles JabatanBindingNavigatorSaveItem.Click
    Me.Validate()
    Me.JabatanBindingSource.EndEdit()
    Me.TableAdapterManager.UpdateAll(Me.DataSetHRD)

  End Sub

  Private Sub FormJabatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'TODO: This line of code loads data into the 'DataSetHRD.Divisi' table. You can move, or remove it, as needed.
    Me.DivisiTableAdapter.Fill(Me.DataSetHRD.Divisi)
    'TODO: This line of code loads data into the 'DataSetHRD.Jabatan' table. You can move, or remove it, as needed.
    Me.JabatanTableAdapter.Fill(Me.DataSetHRD.Jabatan)

  End Sub
End Class