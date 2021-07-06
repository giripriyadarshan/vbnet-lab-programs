Public Class Program18
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total As Integer = 0

        If CheckBox1.Checked Then
            total += Val(TextBox1.Text) * 10
        End If
        If CheckBox2.Checked Then
            total += Val(TextBox2.Text) * 15
        End If
        If CheckBox3.Checked Then
            total += Val(TextBox3.Text) * 10
        End If
        If CheckBox4.Checked Then
            total += Val(TextBox4.Text) * 40
        End If
        If RadioButton1.Checked Then
            total += Val(TextBox5.Text) * 0
        End If
        If RadioButton2.Checked Then
            total += Val(TextBox6.Text) * 10
        End If
        If RadioButton3.Checked Then
            total += Val(TextBox7.Text) * 10
        End If
        If RadioButton4.Checked Then
            total += Val(TextBox8.Text) * 15
        End If
        TextBox9.Text = total
    End Sub
End Class