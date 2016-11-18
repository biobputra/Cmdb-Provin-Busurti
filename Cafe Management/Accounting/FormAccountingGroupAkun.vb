Public Class FormAccountingGroupAkun

  Private Sub GroupAkunBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles GroupAkunBindingNavigatorSaveItem.Click
    Me.Validate()
    Me.GroupAkunBindingSource.EndEdit()
    Me.TableAdapterManager.UpdateAll(Me.DataSetAccounting)

  End Sub

  Private Sub FormAccountingGroupAkun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'TODO: This line of code loads data into the 'DataSetAccounting.GroupTemplateTransaksi' table. You can move, or remove it, as needed.
    Me.GroupTemplateTransaksiTableAdapter.Fill(Me.DataSetAccounting.GroupTemplateTransaksi)
    'TODO: This line of code loads data into the 'DataSetAccounting.GroupAkun' table. You can move, or remove it, as needed.
    Me.GroupAkunTableAdapter.Fill(Me.DataSetAccounting.GroupAkun)

  End Sub
End Class