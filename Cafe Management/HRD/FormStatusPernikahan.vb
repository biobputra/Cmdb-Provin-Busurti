Public Class FormStatusPernikahan 

  Private Sub StatusPernikahanBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StatusPernikahanBindingNavigatorSaveItem.Click
    Me.Validate()
    Me.StatusPernikahanBindingSource.EndEdit()
    Me.TableAdapterManager.UpdateAll(Me.DataSetHRD)

  End Sub

  Private Sub FormStatusPernikahan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'TODO: This line of code loads data into the 'DataSetHRD.StatusPernikahan' table. You can move, or remove it, as needed.
    Me.StatusPernikahanTableAdapter.Fill(Me.DataSetHRD.StatusPernikahan)

  End Sub
End Class