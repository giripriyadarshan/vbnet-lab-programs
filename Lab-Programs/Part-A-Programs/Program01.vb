Public Class Program01

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        '        If Label1.Left >= Me.Width Then
        '           Label1.Left = -100
        '        Else
        '           Label1.Left += 10
        '        End If

        '        Label1.Text = Label1.Text.Substring(1) & Label1.Text.Substring(0, 1)

        Label1.Left += 10
        While Label1.Left >= Width
            Label1.Left -= Width
        End While

    End Sub
End Class
