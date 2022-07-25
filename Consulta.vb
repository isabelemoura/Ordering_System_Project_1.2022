Public Class Consulta
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        sql = "select * from cadastro where nome like '" & consul_cpf.Text & "%'"
        rs = db.Execute(sql)
        With dgv_dados
            cont = 1
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, Nothing)
                cont = cont + 1
                rs.MoveNext()
            Loop
        End With
    End Sub
End Class