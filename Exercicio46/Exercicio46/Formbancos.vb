Public Class Formbancos
    Private Sub BancosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BancosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BancosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ContasbancariasDataSet)

    End Sub

    Private Sub Formbancos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ContasbancariasDataSet.bancos' table. You can move, or remove it, as needed.
        Me.BancosTableAdapter.Fill(Me.ContasbancariasDataSet.bancos)

    End Sub
End Class