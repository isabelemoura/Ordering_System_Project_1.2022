Imports System.Net.Mail
Module Module1
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public banco = Application.StartupPath & "\banco_dados\confex.mdb"
    Public dataSist As System.DateTime
    Public diretorio, sql, resp As String
    Public ctrl_cpf_cliente As String
    Public ctrl_total As Double

    'variaveis tela controle
    Public aux_ctrl As Integer
    Public id_pedido, aux_item, aux_andam, ctrl_email As String

    'variaveis tela login
    Public aux_login, nova_senha As Integer
    Public cpf_atend As String

    'variaveis tela cadastro promo
    Public combo_prod, prod, id_prod As String

    'variavel tela notif promo
    Public id_prod_promo, desc_promo, soma As String

    'variaveis tela pedido
    Public aux, novoId, cont, id_prod_pedido As Integer
    Public unit, qtd, desc, aux_qtd, subtot, total As Double
    Public data, subtotData, totalData As String

    Sub Conectar_Banco_Access()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & banco)
            'MsgBox("Conexão com banco de dados OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao Conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")

        End Try
    End Sub

    'LOGIN
    Sub limpar_login()
        With frm_login
            .txt_login_cpf.Clear()
            .txt_login_senha.Clear()
            .txt_login_cpf.Focus()
        End With
    End Sub

    'NOVO PEDIDO
    Sub carregar_id_prod_pedido()
        Try
            sql = "select descricao from tb_produto"
            rs = db.Execute(sql)
            With frm_pedido.cmb_prod.Items
                Do While (Not rs.EOF)
                    .Add(rs.Fields(0).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao Processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Sub carregar_itens()
        sql = "select i.id_produto, p.descricao, i.qtd, p.unidade, p.valor_unit, p.desconto, i.subtotal, i.obs, i.id_pedido from tb_item_pedido i left join tb_produto p on i.id_produto=p.id_produto where i.id_pedido=" & novoId & ""
        rs = db.Execute(sql)
        cont = 1
        With frm_pedido.consulta_grid
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, Nothing)
                rs.MoveNext()
                cont = cont + 1
            Loop
        End With
    End Sub
    Sub limpar_item()
        With frm_pedido
            .cmb_prod.Text = ""
            .txt_qtd.Clear()
            .lbl_valor_unit.Text = ""
            .lbl_descont.Text = ""
            .txt_obs.Clear()
            .cmb_prod.Focus()
        End With
    End Sub
    Sub limpar_pedido()
        With frm_pedido.consulta_grid
            .Rows.Clear()
        End With

        limpar_item()

        With frm_pedido
            .txt_cpf.Clear()
            .txt_nome.Clear()
            .txt_celular.Clear()
            .txt_email.Clear()
            .lbl_valor_total.Text = ""
            .txt_cpf.Focus()
        End With
    End Sub

    'COMANDA
    Sub carregar_comanda()
        sql = "select i.id_produto, p.descricao, i.qtd, p.unidade, i.obs, i.id_pedido from tb_item_pedido i left join tb_produto p on i.id_produto=p.id_produto where i.id_pedido=" & novoId & ""
        rs = db.Execute(sql)
        cont = 1
        With frm_comanda.dgv_itens
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value)
                rs.MoveNext()
                cont = cont + 1
            Loop
        End With
    End Sub

    'CADASTRO PROMO
    Sub carregar_tipo()
        Try
            With frm_promo_cad.cmb_tipo.Items
                .Add("ID Produto")
                .Add("Nome")
            End With
            frm_promo_cad.cmb_tipo.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao Processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Sub carregar_produto()
        sql = "select * from tb_produto order by id_produto desc"
        rs = db.Execute(sql)
        With frm_promo_cad.consulta_grid
            cont = 1
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(4).Value)
                cont = cont + 1
                rs.MoveNext()
            Loop
        End With
    End Sub
    Sub limpar_cad_promo()
        With frm_promo_cad
            .prom_idprod.Clear()
            .txt_desconto.Clear()
            prod = ""
            .lbl_prod.Visible = False
            .prom_idprod.Focus()
        End With
    End Sub

    'NOTIFICACAO PROMO
    Sub carregar_id_prod_promo()
        Try
            sql = "select descricao from tb_produto"
            rs = db.Execute(sql)
            With frm_promo_notif.cmb_prod.Items
                Do While (Not rs.EOF)
                    .Add(rs.Fields(0).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao Processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Sub limpar_notif()
        With frm_promo_notif
            .cmb_prod.Text = ""
            .lbl_dest.Text = ""
            .TxtAssunto.Clear()
            .TxtMensagem.Clear()
            .LblAnexo.Text = ""
            .cmb_prod.Focus()
        End With
    End Sub
    Sub EnviarEmail(ByVal dest As String, ByVal assunt As String, ByVal msg As String, ByVal anexo As String)
        Try
            Using smtp As New SmtpClient
                Using email As New MailMessage()
                    'servidor smtp
                    smtp.Host = "smtp.gmail.com"
                    'smtp.Host = "smtp.outlook.com"
                    smtp.UseDefaultCredentials = False
                    smtp.Credentials = New Net.NetworkCredential("confexfatec@gmail.com", "gmrqtehwmqunijii")
                    'smtp.Credentials = New Net.NetworkCredential("confexfatec@outlook.com", "confex2022")
                    smtp.Port = 587
                    smtp.EnableSsl = True

                    'enviar mensagem

                    email.From = New MailAddress("confexfatec@gmail.com")
                    'email.From = New MailAddress("confexfatec@outlook.com")
                    email.To.Add(dest)
                    email.Subject = assunt
                    email.IsBodyHtml = False
                    email.Body = msg

                    'anexo email
                    If anexo <> "" Then
                        email.Attachments.Add(New Attachment(anexo))
                    End If

                    'enviar email
                    smtp.Send(email)
                End Using
            End Using
            'MsgBox("E-mail enviado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub

    'CONSULTA
    Sub limpar_consulta()
        With frm_consulta.dgv_cliente
            .Rows.Clear()
        End With
        With frm_consulta.dgv_pedido
            .Rows.Clear()
        End With
        With frm_consulta
            .txt_cpf.Clear()
            .txt_cpf.Focus()
        End With
    End Sub
    Sub carregar_consul_cliente()
        sql = "select * from tb_cliente where cpf_cliente='" & frm_consulta.txt_cpf.Text & "'"
        rs = db.Execute(sql)
        With frm_consulta.dgv_cliente
            .Rows.Clear()
            .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(2).Value)
        End With
    End Sub
    Sub carregar_consul_pedido()
        sql = "select * from tb_pedido where cpf_cliente='" & frm_consulta.txt_cpf.Text & "' order by id_pedido desc"
        rs = db.Execute(sql)
        With frm_consulta.dgv_pedido
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(1).Value, rs.Fields(0).Value, rs.Fields(4).Value, rs.Fields(5).Value)
                rs.MoveNext()
            Loop
        End With
    End Sub

    'CONTROLE
    Sub limpar_controle()
        With frm_controle
            .ctrle_idpedido.Clear()
            .dgv_cliente.Rows.Clear()
            .dgv_pedido.Rows.Clear()
            .dgv_itens.Rows.Clear()
        End With
    End Sub
    Sub carregar_ctrl_pedido()
        With frm_controle
            sql = "select * from tb_pedido where id_pedido = " & id_pedido & ""
            rs = db.Execute(sql)

            If rs.EOF = True Then
                MsgBox("Pedido não encontrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                ctrl_cpf_cliente = rs.Fields(3).Value
                With .dgv_pedido
                    .Rows.Clear()
                    If rs.EOF = False Then
                        .Rows.Add(rs.Fields(1).Value, rs.Fields(0).Value, rs.Fields(4).Value, rs.Fields(5).Value)
                        rs.MoveNext()
                    End If
                End With
                carregar_ctrl_cliente()
                carregar_ctrl_itens()
            End If
        End With
    End Sub
    Sub carregar_ctrl_cliente()
        With frm_controle
            sql = "select  * from tb_cliente where cpf_cliente='" & ctrl_cpf_cliente & "'"
            rs = db.Execute(sql)
            ctrl_email = rs.Fields(3).Value
            With .dgv_cliente
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(2).Value)
                    rs.MoveNext()
                Loop
            End With

        End With

    End Sub
    Sub carregar_ctrl_itens()
        ctrl_total = 0
        sql = "select i.id_produto, p.descricao, i.qtd, p.unidade, p.valor_unit, p.desconto, i.subtotal, i.obs from tb_item_pedido i left join tb_produto p on i.id_produto=p.id_produto where i.id_pedido=" & id_pedido & ""
        rs = db.Execute(sql)
        With frm_controle
            cont = 1
            With .dgv_itens
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, Nothing)
                    ctrl_total = ctrl_total + rs.Fields(6).Value
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        End With

    End Sub

End Module
