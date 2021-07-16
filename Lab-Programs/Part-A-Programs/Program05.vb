Public Class Program05

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Label3.Text = Val(TextBox1.Text.Trim) \ Val(TextBox2.Text.Trim)
        Catch ex As DivideByZeroException
            MessageBox.Show("Dividing by Zero is not possible")
        End Try
    End Sub

End Class