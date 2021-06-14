Public Class Program01

    Private Sub mover_Tick(sender As System.Object, e As System.EventArgs) Handles mover.Tick
        If moving_label.Left >= Me.Width Then
            moving_label.Left = -100
        Else
            moving_label.Left += 10
        End If

        '        moving_label.Text = moving_label.Text.Substring(1) & moving_label.Text.Substring(0, 1)

        '        Static count As Integer = 0
        '        Label1.Text = scrollingTextSelector.Substring(count, numberOfCharactersToDisplay)
        '        ' Label if you want to use label like the
        '        ' code or TextBox if you want to use TextBox
        '        ' like below
        '        TextBox1.Text = scrollingTextSelector.Substring(count, numberOfCharactersToDisplay)
        '        count += 1
        '        If count > someTextIWantToScroll.Length Then
        '        count = 0
        '        End If


    End Sub

End Class
