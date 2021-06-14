Public Class Program14
    Private Sub output(button_number As Integer)

        Dim num1 As String = TextBox1.Text.Trim
        Dim num2 As String = TextBox2.Text.Trim

        Select Case button_number
            Case 1
                Label1.Text = Val(num1) + Val(num2)
            Case 2
                Label1.Text = Val(num1) - Val(num2)
            Case 3
                Label1.Text = Val(num1) * Val(num2)
            Case 4
                Label1.Text = Val(num1) / Val(num2)
        End Select
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        output(1)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        output(2)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        output(3)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        output(4)
    End Sub
End Class