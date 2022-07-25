Public Class frm_comanda
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Close()
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub frm_comanda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            lbl_data.Text = data
            lbl_pedido.Text = novoId
            lbl_total.Text = FormatCurrency(total)
            carregar_comanda()
        Catch ex As Exception
            MsgBox("Erro ao Processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class