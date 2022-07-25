Public Class frm_promo_cad
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Close()
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub frm_promo_cad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpar_cad_promo()
        carregar_produto()
        carregar_tipo()
    End Sub

    Private Sub prom_idprod_TextChanged(sender As Object, e As EventArgs) Handles prom_idprod.TextChanged
        Try
            If cmb_tipo.SelectedIndex = 0 Then
                combo_prod = "id_produto"
            Else
                combo_prod = "descricao"
            End If
            sql = "select * from tb_produto where " & combo_prod & " like '%" & prom_idprod.Text & "%'"
            rs = db.Execute(sql)
            With consulta_grid
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(4).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao gravar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Function prom_idprodext() As String
        Throw New NotImplementedException()
    End Function

    Private Sub consulta_grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles consulta_grid.CellContentClick
        Try
            With consulta_grid
                If .CurrentRow.Cells(4).Selected = True Then
                    id_prod = .CurrentRow.Cells(0).Value
                    prod = .CurrentRow.Cells(1).Value
                    lbl_prod.Text = prod
                    lbl_prod.Visible = True
                    txt_desconto.Focus()
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao gravar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_prom_salvar_Click(sender As Object, e As EventArgs) Handles btn_prom_salvar.Click
        Try
            If prod = "" Then
                MsgBox("Selecione um produto!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                If txt_desconto.Text = "" Then
                    MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Else
                    resp = MsgBox("Deseja realmente alterar desconto de '" & prod & "'?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "update tb_produto set desconto=" & txt_desconto.Text & " where id_produto=" & id_prod & ""
                        rs = db.Execute(sql)

                        MsgBox("Desconto atualizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    End If
                End If
            End If
            carregar_produto()
            limpar_cad_promo()
        Catch ex As Exception
            MsgBox("Erro ao gravar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class