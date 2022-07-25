Public Class frm_consulta
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Close()
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub frm_consulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpar_consulta()
    End Sub

    Private Sub btn_busca_Click(sender As Object, e As EventArgs) Handles btn_busca.Click
        Try
            If txt_cpf.Text = "   .   .   -" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                sql = "select * from tb_cliente where cpf_cliente='" & txt_cpf.Text & "'"
                rs = db.Execute(sql)

                If rs.EOF = True Then
                    MsgBox("CPF não cadastrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    txt_cpf.Clear()
                    txt_cpf.Focus()
                Else
                    carregar_consul_cliente()
                    carregar_consul_pedido()
                    txt_cpf.Clear()
                    txt_cpf.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao Processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class