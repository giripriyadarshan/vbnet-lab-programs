Public Class Program05

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim t1 As New TextBox(), t2 As New TextBox()
        Dim l1 As New Label(), l2 As New Label()
        Dim b1 As New Button()
        Dim distance As Integer = 100
        Controls.Add(t1)
        t1.Left = distance
        t1.Top = distance

        Controls.Add(t2)
        t2.Left = t1.Left + distance + 50
        t2.Top = t1.Top

        Controls.Add(l1)
        l1.Left = t2.Left + distance
        l1.Top = t2.Top
        l1.Text = "Label1"

        Controls.Add(l2)
        l2.Left = l1.Left + distance
        l2.Top = l1.Top
        l2.Text = "Label2"

        Controls.Add(b1)
        b1.Left = l2.Left + distance
        b1.Top = l2.Top
        b1.Text = "Button1"
    End Sub
End Class