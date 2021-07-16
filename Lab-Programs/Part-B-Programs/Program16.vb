Public Class Program16
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 10
            Label3.Text = ProgressBar1.Value & "%"
        Else
            Me.Hide()
            Program13.Show()
            Close()
        End If
    End Sub
End Class