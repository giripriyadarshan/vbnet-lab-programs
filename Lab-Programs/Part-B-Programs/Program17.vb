Public Class Program17
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            TextBox1.Text = "Stop dont move.."
        ElseIf RadioButton2.Checked Then
            TextBox1.Text = "You are Ready to move.."
        ElseIf RadioButton3.Checked Then
            TextBox1.Text = "Go start moving.."
        End If
    End Sub
End Class