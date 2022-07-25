
Public Class frm_login
    Private Sub XxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XxToolStripMenuItem.Click
        Try
            Application.Exit()
        Catch ex As Exception
            MsgBox("Erro ao Processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Conectar_Banco_Access()
        aux_login = 0
        frm_splash.ShowDialog()
    End Sub

    Private Sub btn_login_acessar_Click(sender As Object, e As EventArgs) Handles btn_login_acessar.Click
        Try
            If txt_login_cpf.Text = "" Or
                txt_login_senha.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                limpar_login()

            Else
                cpf_atend = txt_login_cpf.Text
                sql = "select * from tb_login where cpf_atendente='" & cpf_atend & "'"
                rs = db.Execute(sql)

                If rs.EOF = True Then
                    MsgBox("Usuario ou senha invalidos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    limpar_login()
                Else
                    If rs.Fields(3).Value = True Then
                        If aux_login < 2 Then
                            sql = "select * from tb_login where cpf_atendente='" & txt_login_cpf.Text & "' and senha='" & txt_login_senha.Text & "'"
                            rs = db.Execute(sql)

                            If rs.EOF = False Then
                                MsgBox("Bem-vindo!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "CONFEX")
                                frm_pedido.Show()
                                Me.Hide()
                                limpar_login()
                            Else
                                aux_login = aux_login + 1
                                MsgBox("Usuario ou senha invalidos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                                limpar_login()
                            End If
                        Else
                            sql = "update tb_login set status=false where cpf_atendente='" & cpf_atend & "'"
                            rs = db.Execute(sql)

                            MsgBox("Limite de tentativas excedido!" + vbNewLine +
                                     "Entre em contato com o suporte técnico.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                            cpf_atend = ""
                            limpar_login()
                        End If
                    Else
                        MsgBox("Conta bloqueada!" + vbNewLine +
                               "Entre em contato com o suporte técnico.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        limpar_login()
                    End If
                End If

            End If
        Catch ex As Exception
            MsgBox("Erro ao Processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Try
            frm_nova_senha.ShowDialog() 'Chamada de formulário
        Catch ex As Exception
            MsgBox("Erro ao Processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class