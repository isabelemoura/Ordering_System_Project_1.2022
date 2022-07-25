Public Class encomenda
    Private Sub frm_pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar_Banco_Access()
        carregar_dados()

        'consulta_grid.Columns(0).Width = 50
        'consulta_grid.Columns(1).Width = 50
        'consulta_grid.Columns(2).Width = 100
        'consulta_grid.Columns(3).Width = 50
        'consulta_grid.Columns(4).Width = 50
        'consulta_grid.Columns(5).Width = 50
    End Sub


    Private Sub Btn_Encom_Salvar_Click(sender As Object, e As EventArgs) Handles btn_encom_salvar.Click
        Try
            sql = "insert into cadastro values ('" & txt_cpf.Text & "', '" & txt_nome.Text & "', " &
                                                "'" & txt_celular.Text & "','" & txt_email.Text & "')"
            rs = db.Execute(UCase(sql))
            MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            limpar_cadastro()
        Catch ex As Exception
            MsgBox("Erro ao gravar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Private Sub CONSULTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem.Click
        Try
            Consulta.ShowDialog() 'Chamada de formulário 
        Catch ex As Exception
            MsgBox("Erro ao Processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Private Sub CONTROLEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONTROLEToolStripMenuItem.Click
        Try
            controle.ShowDialog() 'Chamada de formulário 
        Catch ex As Exception
            MsgBox("Erro ao Processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

End Class
