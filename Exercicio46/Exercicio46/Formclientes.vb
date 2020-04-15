Public Class Formclientes

    Dim msg, style, resposta

    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ContasbancariasDataSet)
        'Me.ClientesTableAdapter.Fill(Me.ContasbancariasDataSet.Clientes)
    End Sub

    Private Sub Formclientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ContasbancariasDataSet.Clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.ContasbancariasDataSet.Clientes)

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        msg = "de certeza que quer eliminar?"
        style = vbYesNo + vbCritical + vbDefaultButton2
        resposta = MsgBox(msg, style)
        If resposta = vbYes Then
            Me.ClientesBindingSource.EndEdit()
            ClientesTableAdapter.Delete(Val(Numero_B_I_TextBox.Text))
            Me.TableAdapterManager.UpdateAll(Me.ContasbancariasDataSet)
            Me.ClientesTableAdapter.Fill(Me.ContasbancariasDataSet.Clientes)
        End If
    End Sub
End Class