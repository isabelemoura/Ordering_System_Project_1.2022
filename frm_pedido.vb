Imports System.ComponentModel

Public Class frm_pedido

    'Private Const CS_DROPSHADOW As Integer = 131072
    'Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
    'Get
    'Dim cp As CreateParams = MyBase.CreateParams
    '       cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
    'Return cp
    'End Get
    'End Property

    Private Sub frm_pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpar_item()
        limpar_pedido()
        carregar_id_prod_pedido()

        'inicialização de variáveis
        total = 0
        aux = 1
        dataSist = System.DateTime.Now
        data = dataSist.ToString("dd/MM/yyyy")
    End Sub

    'abertura de janelas
    Private Sub CONSULTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem.Click
        Try
            frm_consulta.ShowDialog() 'Chamada de formulário
        Catch ex As Exception
            MsgBox("Erro ao Processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Private Sub CONTROLEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONTROLEToolStripMenuItem.Click
        Try
            frm_controle.ShowDialog() 'Chamada de formulário 
        Catch ex As Exception
            MsgBox("Erro ao Processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Private Sub CADASTROToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CADASTROToolStripMenuItem.Click
        Try
            frm_promo_cad.ShowDialog() 'Chamada de formulário 
        Catch ex As Exception
            MsgBox("Erro ao Processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Private Sub NOTIFICAÇÃOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NOTIFICAÇÃOToolStripMenuItem.Click
        Try
            frm_promo_notif.ShowDialog() 'Chamada de formulário 
        Catch ex As Exception
            MsgBox("Erro ao Processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Private Sub AJUDAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AJUDAToolStripMenuItem.Click
        Try
            frm_ajuda.ShowDialog() 'Chamada de formulário 
        Catch ex As Exception
            MsgBox("Erro ao Processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    'sair da conta
    Private Sub SAIRDACONTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAIRDACONTAToolStripMenuItem.Click
        Try
            If aux > 1 Then
                MsgBox("Salve o pedido antes de fechar!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                resp = MsgBox("Deseja realmente sair da conta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    cpf_atend = ""
                    limpar_pedido()
                    frm_login.Show() 'Chamada de formulário 
                    Me.Hide()
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao Processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    'fecha o programa
    Private Sub ENCERRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ENCERRARToolStripMenuItem.Click
        Try
            If aux > 1 Then
                MsgBox("Salve o pedido antes de fechar!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                resp = MsgBox("Deseja realmente encerrar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    cpf_atend = ""
                    limpar_pedido()
                    Application.Exit()
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao Processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        Try
            sql = "select * from tb_cliente where cpf_cliente = '" & txt_cpf.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = True Then
                'se nao exist cpf, vai para preenchimento do nome
                txt_nome.Focus()
            Else
                'se cpf existe, preenche campos com as informacoes
                txt_nome.Text = rs.Fields(1).Value
                txt_celular.Text = rs.Fields(2).Value
                txt_email.Text = rs.Fields(3).Value
                cmb_prod.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro ao Processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_cpf_DoubleClick(sender As Object, e As EventArgs) Handles txt_cpf.DoubleClick
        limpar_pedido()
    End Sub

    Private Sub cmb_prod_LostFocus(sender As Object, e As EventArgs) Handles cmb_prod.LostFocus
        Try
            If cmb_prod.Text <> "" Then
                sql = "select * from tb_produto where descricao = '" & cmb_prod.Text & "'"
                rs = db.Execute(sql)

                If rs.EOF = True Then
                    MsgBox("Produto não cadastrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Else
                    lbl_valor_unit.Text = String.Format("{0:N2}", rs.Fields(3).Value)
                    lbl_descont.Text = rs.Fields(4).Value
                    txt_qtd.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao Processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_qtd_LostFocus(sender As Object, e As EventArgs) Handles txt_qtd.LostFocus
        'ao perder foco, deixar com 2 casas decimais
        If txt_qtd.Text <> "" Then
            aux_qtd = Convert.ToDouble(txt_qtd.Text)
            txt_qtd.Text = String.Format("{0:N2}", aux_qtd)
        End If
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Try
            If cmb_prod.Text = "" Or txt_qtd.Text = "" Then
                'se algum campo de produto estiver vazio
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                'se for o primeiro item, criar pedido e obter id_pedido
                If aux = 1 Then
                    sql = "insert into tb_pedido (data, cpf_atendente) values (#" & data & "#, '" & cpf_atend & "')"
                    rs = db.Execute(sql)

                    sql = "select @@identity from tb_pedido"
                    rs = db.Execute(sql)
                    novoId = rs.Fields(0).Value
                End If

                qtd = txt_qtd.Text
                unit = lbl_valor_unit.Text
                desc = unit * (lbl_descont.Text / 100)
                subtot = qtd * (unit - desc)

                subtotData = CStr(subtot)

                sql = "select id_produto from tb_produto where descricao='" & cmb_prod.Text & "'"
                rs = db.Execute(sql)
                id_prod_pedido = rs.Fields(0).Value

                sql = "insert into tb_item_pedido (id_pedido, id_produto, qtd, subtotal, obs) " &
                     "values (" & novoId & ", " & id_prod_pedido & ", " & txt_qtd.Text.Replace(",", ".") & ", '" & subtotData & "', '" & txt_obs.Text & "')"
                rs = db.Execute(sql)

                carregar_itens()

                'calculo do valor total
                total = total + subtot
                lbl_valor_total.Text = FormatCurrency(total)

                aux = aux + 1

                limpar_item()

            End If
        Catch ex As Exception
            MsgBox("Erro ao Processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub consulta_grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles consulta_grid.CellContentClick
        Try
            With consulta_grid
                If .CurrentRow.Cells(9).Selected = True Then
                    aux_item = .CurrentRow.Cells(2).Value
                    resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                                  "o item: '" & aux_item & "'?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete from tb_item_pedido where id_produto=" & .CurrentRow.Cells(1).Value & " and qtd=" & .CurrentRow.Cells(3).Value & " and id_pedido=" & novoId & ""
                        rs = db.Execute(sql)
                        total = total - .CurrentRow.Cells(7).Value
                        lbl_valor_total.Text = FormatCurrency(total)
                        carregar_itens()
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao gravar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub Btn_Encom_Salvar_Click(sender As Object, e As EventArgs) Handles btn_encom_salvar.Click
        Try
            If txt_cpf.Text = "   .   .   -" Or txt_nome.Text = "" Or txt_email.Text = "" Or txt_celular.Text = "" Or aux = 1 Then
                'se algum campo do cliente estiver vazio
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else

                'verificar se cpf ja existe
                sql = "select * from tb_cliente where cpf_cliente='" & txt_cpf.Text & "'"
                rs = db.Execute(sql)

                'se nao existe salva
                If rs.EOF = True Then
                    sql = "insert into tb_cliente values ('" & txt_cpf.Text & "', '" & txt_nome.Text & "', " &
                                                        "'" & txt_celular.Text & "','" & txt_email.Text & "')"
                    rs = db.Execute(UCase(sql))
                Else

                    'se exite altera
                    sql = "update tb_cliente set celular='" & txt_celular.Text & "', " &
                             "email='" & txt_email.Text & "' where cpf_cliente='" & txt_cpf.Text & "'"
                    rs = db.Execute(UCase(sql))
                End If

                totalData = CStr(total)

                'salva dados do pedido na tabela pedido
                sql = "update tb_pedido set cpf_cliente='" & txt_cpf.Text & "', valor_total='" & totalData & "', andamento='em processo' where id_pedido=" & novoId & ""
                rs = db.Execute(UCase(sql))

                frm_comanda.ShowDialog()

                'reseta variáveis
                aux = 1
                total = 0

                'MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_pedido()
            End If

        Catch ex As Exception
            MsgBox("Erro ao gravar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class







