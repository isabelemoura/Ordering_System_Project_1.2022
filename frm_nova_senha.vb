Public Class frm_nova_senha
    Private Sub frm_nova_senha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_cpf.Clear()
        txt_cpf.Focus()
    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        Try
            If txt_cpf.Text = "   .   .   -" Then
                MsgBox("Informe o CPF!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                sql = "select * from tb_login where cpf_atendente='" & txt_cpf.Text & "'"
                rs = db.Execute(sql)

                If rs.EOF = True Then
                    MsgBox("CPF não cadastrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    txt_cpf.Clear()
                    txt_cpf.Focus()
                Else
                    Dim random As New Random
                    nova_senha = random.Next(1000, 9999)

                    sql = "update tb_login set senha=" & nova_senha & " where cpf_atendente='" & txt_cpf.Text & "'"
                    rs = db.Execute(sql)

                    sql = "select email from tb_login where cpf_atendente='" & txt_cpf.Text & "'"
                    rs = db.Execute(sql)
                    EnviarEmail(rs.Fields(0).Value, "Nova senha!", "Sua nova senha é " & nova_senha & "", Nothing)

                    MsgBox("Uma nova senha foi enviada ao seu e-mail!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    txt_cpf.Clear()
                    txt_cpf.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao Processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class