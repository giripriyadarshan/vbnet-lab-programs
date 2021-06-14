Public Class Program02

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        PictureBox1.Visible = Not PictureBox1.Visible
    End Sub
End Class