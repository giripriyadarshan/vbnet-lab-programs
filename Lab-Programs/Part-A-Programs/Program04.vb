Public Class Program04
    Dim c As Integer = 0

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Select Case c
            Case 0
                Button1.BackColor = Color.Red
            Case 1
                Button1.BackColor = Color.Green
            Case 2
                Button1.BackColor = Color.Aqua
                c = -1
        End Select
        c += 1
    End Sub

    Private Sub Button1_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = DefaultBackColor
    End Sub
End Class