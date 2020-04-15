Public Class Formcontas

    Dim resposta, style, msg

    Private Sub ContasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ContasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ContasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ContasbancariasDataSet)
        'Me.ContasTableAdapter.Fill(Me.ContasbancariasDataSet.contas)
    End Sub

    Private Sub Formcontas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ContasbancariasDataSet.Clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.ContasbancariasDataSet.Clientes)
        'TODO: This line of code loads data into the 'ContasbancariasDataSet.bancos' table. You can move, or remove it, as needed.
        Me.BancosTableAdapter.Fill(Me.ContasbancariasDataSet.bancos)
        'TODO: This line of code loads data into the 'ContasbancariasDataSet.movimentos' table. You can move, or remove it, as needed.
        'Me.MovimentosTableAdapter.Fill(Me.ContasbancariasDataSet.movimentos)
        'TODO: This line of code loads data into the 'ContasbancariasDataSet.contas' table. You can move, or remove it, as needed.
        Me.ContasTableAdapter.Fill(Me.ContasbancariasDataSet.contas)
        ContasBindingNavigator.AddNewItem.PerformClick()
    End Sub

    Private Sub mnubancos_Click(sender As Object, e As EventArgs) Handles mnubancos.Click
        Formbancos.Show()
    End Sub

    'Private Sub mnusaldo_Click(sender As Object, e As EventArgs)
    'Dim numero As Decimal = CDec(txtsaldo.Text)
    'Dim soma As Decimal = Val(Formclientes.SaldoTextBox.Text) + Val(Formtransf.ValorTextBox.Text)
    'Dim valor As Decimal = MovimentosTableAdapter.SaldoQuery()
    'msg = "O saldo da conta = " & valor & " €"
    'MsgBox(msg)
    'End Sub

    Private Sub mnutransf_Click(sender As Object, e As EventArgs) Handles mnutransf.Click
        'ContasBindingSource.EndEdit()
        'MovimentosBindingSource.Dispose()
        'MovimentosTableAdapter.Dispose()
        Formtransf.Show()



    End Sub

    Private Sub mnuclientes_Click(sender As Object, e As EventArgs) Handles mnuclientes.Click
        Formclientes.Show()
    End Sub

    'Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btlistas.Click
    'Me.ContasTableAdapter.Fill(Me.ContasbancariasDataSet.contas)
    'Me.ClientesTableAdapter.Fill(Me.ContasbancariasDataSet.Clientes)
    'Me.BancosTableAdapter.Fill(Me.ContasbancariasDataSet.bancos)
    'Me.MovimentosTableAdapter.Fill(Me.ContasbancariasDataSet.movimentos)
    'End Sub

    Private Sub btsaldo_Click(sender As Object, e As EventArgs) Handles btsaldo.Click
        Dim sql1 As String
        MovimentosTableAdapter.Fill(Me.ContasbancariasDataSet.movimentos)
        sql1 = "Select * from Movimentos where CodigoConta=" + txtcodigo.Text
        MovimentosTableAdapter.Adapter.SelectCommand.CommandText = sql1
        MovimentosTableAdapter.Fill(Me.ContasbancariasDataSet.movimentos)
        Dim summov As Double = 0
        For i As Integer = 0 To grelha.RowCount - 1
            summov += Val(grelha.Rows(i).Cells(4).Value)
        Next
        txtsaldo.Text = summov
    End Sub

    Private Sub mnuirpara_Click(sender As Object, e As EventArgs) Handles mnuirpara.Click

        Dim numero As Double
        numero = Val(InputBox("Indique o codigo da conta"))
        If numero >= 1 Then
            ContasTableAdapter.FillBycodigo(ContasbancariasDataSet.contas, numero)
        End If
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        msg = "de certeza que quer eliminar?"
        style = vbYesNo + vbCritical + vbDefaultButton2
        resposta = MsgBox(msg, style)
        If resposta = vbYes Then
            Me.ContasBindingSource.EndEdit()
            ContasTableAdapter.Delete(Val(txtcodigo.Text))
            Me.TableAdapterManager.UpdateAll(Me.ContasbancariasDataSet)
            Me.ContasTableAdapter.Fill(Me.ContasbancariasDataSet.contas)
        End If
    End Sub
End Class
