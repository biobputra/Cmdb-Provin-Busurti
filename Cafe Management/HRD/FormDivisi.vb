Public Class FormDivisi 

  Private Sub DivisiBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DivisiBindingNavigatorSaveItem.Click
    Me.Validate()
    Me.DivisiBindingSource.EndEdit()
    Me.TableAdapterManager.UpdateAll(Me.DataSetHRD)

  End Sub

  Private Sub FormDivisi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'TODO: This line of code loads data into the 'DataSetHRD.Divisi' table. You can move, or remove it, as needed.
    Me.DivisiTableAdapter.Fill(Me.DataSetHRD.Divisi)

  End Sub
End Class