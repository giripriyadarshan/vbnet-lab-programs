Public Class Program03
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim c As Color
        If ColorDialog1.ShowDialog Then
            c = ColorDialog1.Color
        End If

        Me.BackColor = c
        Button1.BackColor = c
    End Sub
End Class