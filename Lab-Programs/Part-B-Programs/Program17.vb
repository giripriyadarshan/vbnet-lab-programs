Public Class Program17
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            TextBox1.Text = "Stop dont move.."
        End If
        If RadioButton2.Checked = True Then
            TextBox1.Text = "You are Ready to move.."
        End If
        If RadioButton3.Checked = True Then
            TextBox1.Text = "Go start moving.."
        End If
    End Sub
End Class