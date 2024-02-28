Imports MySql.Data.MySqlClient

Public Class admission
    Dim connectionString As String = "server=localhost;port=3306;database=salang_school;uid=root;password=yourpassword;"
    Dim connection As New MySqlConnection(connectionString)

    Public Sub YourMethodName()
        Try
            connection.Open()
            ' Perform database operations here
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub


End Class
