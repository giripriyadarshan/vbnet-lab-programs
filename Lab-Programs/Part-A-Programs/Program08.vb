Public Class Program08

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        TextBox1.Text = DateTimePicker1.Value.Day
        TextBox2.Text = DateTimePicker1.Value.Month
        TextBox3.Text = DateTimePicker1.Value.Year
    End Sub
End Class