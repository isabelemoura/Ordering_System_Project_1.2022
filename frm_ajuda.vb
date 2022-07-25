Public Class frm_ajuda
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Close()
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
End Class