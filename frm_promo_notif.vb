Imports System.Net.Mail

Public Class frm_promo_notif
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Close()
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub frm_promo_notif_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_id_prod_promo()
        limpar_notif()
        img_foto.Load(Application.StartupPath & "\produtos\img_inicial.png")
    End Sub

    Private Sub cmb_prod_LostFocus(sender As Object, e As EventArgs) Handles cmb_prod.LostFocus
        Try
            If cmb_prod.Text <> "" Then
                lbl_dest.Text = ""
                soma = ""
                sql = "select * from tb_produto where descricao='" & cmb_prod.Text & "'"
                rs = db.Execute(sql)

                If rs.EOF = True Then
                    MsgBox("Produto não cadastrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")

                Else
                    id_prod_promo = rs.Fields(0).Value
                    desc_promo = rs.Fields(4).Value
                    img_foto.Load(Application.StartupPath & "\produtos\" & cmb_prod.Text & ".png")

                    sql = "select c.email from tb_cliente c where c.cpf_cliente in (select pe.cpf_cliente from tb_pedido pe left join tb_item_pedido i on pe.id_pedido=i.id_pedido where i.id_produto=" & id_prod_promo & ")"
                    rs = db.Execute(sql)

                    If rs.EOF = True Then
                        MsgBox("Não há clientes que compraram esse produto!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        limpar_notif()
                        img_foto.Load(Application.StartupPath & "\produtos\img_inicial.png")
                    Else
                        With dgv_test
                            .Rows.Clear()
                            Do While rs.EOF = False
                                .Rows.Add(rs.Fields(0).Value)
                                soma = soma + rs.Fields(0).Value + ","
                                rs.MoveNext()
                            Loop
                        End With
                        soma = soma.TrimEnd(CChar(","))
                        lbl_dest.Text = soma
                        TxtAssunto.Text = "Promoção de " & cmb_prod.Text & " - " & desc_promo & "% de desconto!"
                        TxtMensagem.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao Processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub LblAnexo_DoubleClick(sender As Object, e As EventArgs) Handles LblAnexo.DoubleClick
        Try
            Dim anexo = New OpenFileDialog()

            anexo.Title = "Anexar arquivos"
            If anexo.ShowDialog() = DialogResult.OK Then
                LblAnexo.Text = anexo.FileName
            End If
        Catch ex As Exception
            MsgBox("Erro ao Processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        Try
            If lbl_dest.Text = "" Or TxtAssunto.Text = "" Or TxtMensagem.Text = "" Then
                'se algum campo estiver vazio
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                EnviarEmail(lbl_dest.Text, TxtAssunto.Text, TxtMensagem.Text, LblAnexo.Text)
                MsgBox("E-mail enviado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_notif()
                img_foto.Load(Application.StartupPath & "\produtos\img_inicial.png")
            End If
        Catch ex As Exception
            MsgBox("Erro ao Processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class