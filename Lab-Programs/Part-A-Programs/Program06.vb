Public Class Program06

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        TextBox4.Text = netSalary(TextBox3.Text.Trim)
        MessageBox.Show("Net salary of " & TextBox1.Text.Trim & " = " & TextBox4.Text)
    End Sub

    Private Function netSalary(basic As Integer) As Integer
        Dim da, ta, hra, gross, tax, net
        da = basic * 0.2
        ta = basic * 0.1
        hra = basic * 0.3
        tax = basic * 0.05
        gross = basic + da + ta + hra
        net = gross - tax
        Return net
    End Function
End Class