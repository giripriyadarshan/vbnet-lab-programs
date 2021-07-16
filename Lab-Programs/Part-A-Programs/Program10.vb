Imports System.Data.OleDb
Public Class Program10
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\dotnet-practice\vbnet-lab-programs\labprogramsDB.accdb")
        Dim command As New OleDbCommand With {
            .Connection = connection,
            .CommandText = "INSERT INTO PatientDetails ([PID], [PName], [ContactNo], [Disease]) " &
            "VALUES (@PID, @PName, @ContactNo, @Disease)"
        }
        command.Parameters.AddWithValue("@PID", TextBox1.Text.Trim)
        command.Parameters.AddWithValue("@PName", TextBox2.Text.Trim)
        command.Parameters.AddWithValue("@ContactNo", TextBox3.Text.Trim)
        command.Parameters.AddWithValue("@Disease", TextBox4.Text.Trim)

        connection.Open()
        command.ExecuteNonQuery()
        MessageBox.Show("Registered Successfully", "Registration")
        connection.Close()
    End Sub
End Class