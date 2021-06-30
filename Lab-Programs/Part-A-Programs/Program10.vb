Public Class Program10

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            TextBox1.Text = "Where is pandit near presidency?"
            RadioButton1.Text = "Near Joy's"
            RadioButton2.Text = "Next to dominoes"
            RadioButton3.Text = "in front of Srinidhi"
            RadioButton4.Text = "I dont know"
        ElseIf ComboBox1.SelectedIndex = 1 Then
            TextBox1.Text = "Who is checking your observation book?"
            RadioButton1.Text = "Harish Sir"
            RadioButton2.Text = "Pachiyappan Sir"
            RadioButton3.Text = "Sheetal Ma'am"
            RadioButton4.Text = "Anitha Ma'am"
        ElseIf ComboBox1.SelectedIndex = 2 Then
            TextBox1.Text = "How many lab programs do we have in VB .NET?"
            RadioButton1.Text = "20"
            RadioButton2.Text = "10"
            RadioButton3.Text = "22"
            RadioButton4.Text = "None of the above"
        ElseIf ComboBox1.SelectedIndex = 3 Then
            TextBox1.Text = "When are 4th sem exams conducted?"
            RadioButton1.Text = "August 15th 2021"
            RadioButton2.Text = "July 22nd 2022"
            RadioButton3.Text = "immediately after weekly test 21"
            RadioButton4.Text = "None of the above"
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim correct As String = "Correct Answer !!"
        Dim wrong As String = "Your answer is not valid"
        If ComboBox1.SelectedIndex = 0 And RadioButton3.Checked Then
            TextBox2.Text = correct
        ElseIf ComboBox1.SelectedIndex = 1 And RadioButton2.Checked Then
            TextBox2.Text = correct
        ElseIf ComboBox1.SelectedIndex = 2 And RadioButton3.Checked Then
            TextBox2.Text = correct
        ElseIf ComboBox1.SelectedIndex = 3 And RadioButton4.Checked Then
            TextBox2.Text = correct
        Else
            TextBox2.Text = wrong
        End If
    End Sub
End Class