Public Class frm_controle
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Close()
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub frm_controle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aux_ctrl = 0
        limpar_controle()
    End Sub

    Private Sub btn_busca_Click(sender As Object, e As EventArgs) Handles btn_busca.Click
        Try
            If ctrle_idpedido.Text = "" Then
                MsgBox("Preencha todos os campos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                aux_ctrl = 1
                id_pedido = ctrle_idpedido.Text
                carregar_ctrl_pedido()
                ctrle_idpedido.Clear()
                dgv_pedido.Columns(0).ReadOnly = True
                dgv_pedido.Columns(1).ReadOnly = True
                dgv_pedido.Columns(2).ReadOnly = True
                dgv_pedido.Columns(3).ReadOnly = False
            End If
        Catch ex As Exception
            MsgBox("Erro ao Processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub dgv_itens_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_itens.CellContentClick
        Try
            With dgv_itens
                If .CurrentRow.Cells(9).Selected = True Then
                    aux_item = .CurrentRow.Cells(2).Value
                    resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                                  "o item: '" & aux_item & "'?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete from tb_item_pedido where id_produto=" & .CurrentRow.Cells(1).Value & " and qtd=" & .CurrentRow.Cells(3).Value & " and id_pedido=" & id_pedido & ""
                        rs = db.Execute(sql)
                        carregar_ctrl_itens()
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao Processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_ctrl_salvar_Click(sender As Object, e As EventArgs) Handles btn_ctrl_salvar.Click
        Try
            If aux_ctrl = 0 Then
                MsgBox("Faça uma busca de pedido!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                aux_andam = dgv_pedido.CurrentRow.Cells(3).Value

                sql = "update tb_pedido set valor_total='" & CStr(ctrl_total) & "', andamento='" & aux_andam & "' where id_pedido=" & id_pedido & ""
                rs = db.Execute(sql)

                If aux_andam = "PRONTO" Then

                    EnviarEmail(ctrl_email, "Seu pedido está pronto!", "Seu pedido já está pronto para ser retirado!", Nothing)
                    MsgBox("Dados atualizados com sucesso!" + vbNewLine +
                           "E-mail de notificação enviado ao cliente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    MsgBox("Dados atualizados com sucesso!")
                End If
            End If
            limpar_controle()
            aux_ctrl = 0
        Catch ex As Exception
            MsgBox("Erro ao Processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class