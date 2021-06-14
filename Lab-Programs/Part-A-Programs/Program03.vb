Public Class Program03

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        Dim input As String = InputBox("Enter an Integer", "Multiplication Input").Trim

        If Not input = String.Empty And IsNumeric(input) Then
            Dim outputText As String
            For index As Integer = 1 To 10
                outputText = input & " x " & index & " = " & Val(input * index)
                ListBox1.Items.Add(outputText)
            Next
        Else
            MessageBox.Show("Please enter an integer", "ERROR!!")
            Button1.PerformClick()
        End If
    End Sub
End Class