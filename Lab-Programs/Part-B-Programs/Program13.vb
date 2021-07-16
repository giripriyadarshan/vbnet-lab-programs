Public Class Program13

    
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim user As String, pass As String
        user = TextBox1.Text.Trim
        pass = TextBox2.Text.Trim

        If user = "abc" And pass = "xyz" Then
            MessageBox.Show("Login Success")
        Else
            MessageBox.Show("Login Failed")
        End If
    End Sub
End Class