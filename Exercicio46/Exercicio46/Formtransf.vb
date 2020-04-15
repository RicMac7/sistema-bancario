Public Class Formtransf
    Private Sub MovimentosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MovimentosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MovimentosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ContasbancariasDataSet)
    End Sub

    Private Sub Formtransf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ContasbancariasDataSet.contas' table. You can move, or remove it, as needed.

        Me.ContasTableAdapter.Fill(Me.ContasbancariasDataSet.contas)
        'TODO: This line of code loads data into the 'ContasbancariasDataSet.movimentos' table. You can move, or remove it, as needed.
        Me.MovimentosTableAdapter.Fill(Me.ContasbancariasDataSet.movimentos)
        'ContasbancariasDataSet.movimentos.NewRow() 
        MovimentosBindingNavigator.AddNewItem.PerformClick()
        'Dim saldo As Double = MovimentosTableAdapter.SaldoQuery()
        'Label1.Text = saldo

    End Sub

    Private Sub bttres_Click(sender As Object, e As EventArgs) Handles bttres.Click
        Dim valor1 As Double = Val(txtvalor.Text)
        Dim valor2 As Double = Val(lbsaldo2.Text)
        Dim res As Double = (valor1 + valor2)
        txtres.Text = res
    End Sub

    Private Sub btsaldo1_Click(sender As Object, e As EventArgs) Handles btsaldo1.Click
        Dim sql2 As String
        'MovimentosTableAdapter.Fill(Me.ContasbancariasDataSet.movimentos)
        sql2 = "Select * from Movimentos where CodigoConta=" + txtcodigo1.Text
        MovimentosTableAdapter.Adapter.SelectCommand.CommandText = sql2
        MovimentosTableAdapter.Fill(Me.ContasbancariasDataSet.movimentos)
        Dim summov1 As Double = 0
        For i As Integer = 0 To grelhatransf.RowCount - 1
            summov1 += Val(grelhatransf.Rows(i).Cells(4).Value)
        Next
        lbsaldo2.Text = summov1
    End Sub
End Class