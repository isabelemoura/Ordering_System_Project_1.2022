Public Class frm_splash
    Private Sub frm_splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        With ProgressBar1
            Static x = 0
            If .Value + 10 < 100 Then
                .Value += 10
            Else
                .Value = 100
            End If

            If x >= 120 Then
                Timer1.Enabled = False
                Me.Close()
            End If
            x += 10
        End With
    End Sub
End Class