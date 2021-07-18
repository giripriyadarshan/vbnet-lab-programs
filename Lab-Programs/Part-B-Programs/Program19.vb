Imports System.Data.OleDb

Public Class Program19
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\dotnet-practice\vbnet-lab-programs\labprogramsDB.accdb")
        Dim command As New OleDbCommand With {
            .Connection = connection,
            .CommandText = "SELECT * FROM LoginForm where Username=@username AND Password=@password"
            }
        Dim adapter As New OleDbDataAdapter(command)
        Dim dataset As New DataSet

        command.Parameters.AddWithValue("@username", TextBox1.Text.Trim)
        command.Parameters.AddWithValue("@password", TextBox2.Text)

        connection.Open()

        adapter.Fill(dataset)

        If dataset.Tables.Count > 0 Then
            MessageBox.Show("Login Success!!", "Welcome")
        Else
            MessageBox.Show("Login Failed!!", "ERROR!!!")
        End If

        connection.Close()
    End Sub
End Class