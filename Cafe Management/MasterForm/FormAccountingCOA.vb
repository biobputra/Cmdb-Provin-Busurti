Public Class FormAccountingCOA 

  Private Sub COABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles COABindingNavigatorSaveItem.Click
    Me.Validate()
    Me.COABindingSource.EndEdit()
    Me.TableAdapterManager.UpdateAll(Me.DataSetAccounting)

  End Sub

  Private Sub FormAccountingCOA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'TODO: This line of code loads data into the 'DataSetAccounting.GroupAkun' table. You can move, or remove it, as needed.
    Me.GroupAkunTableAdapter.Fill(Me.DataSetAccounting.GroupAkun)
    'TODO: This line of code loads data into the 'DataSetAccounting.COA' table. You can move, or remove it, as needed.
    Me.COATableAdapter.Fill(Me.DataSetAccounting.COA)

  End Sub
End Class