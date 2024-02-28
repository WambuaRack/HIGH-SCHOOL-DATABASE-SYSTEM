Imports MySql.Data.MySqlClient

Public Class admission
    Dim connectionString As String = "server=localhost;port=3306;database=salang_school;uid=root;password=;"
    Dim connection As New MySqlConnection(connectionString)
    Dim i As Integer
    Dim dr As MySqlDataReader ' Changed MySqlCommand to MySqlDataReader


    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub admission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
    End Sub

    Public Sub DGV_load()
        DataGridView1.Rows.Clear() ' Clear existing rows before loading new data
        Try
            connection.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM admission", connection)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("ADM_NO"), dr.Item("FIRST_NAME"), dr.Item("SURNAME"), dr.Item("PARENT_PHONE"), dr.Item("FORM"), dr.Item("STREAM"), dr.Item("DORMITORY"), dr.Item("DATE"))
            End While
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If Not dr Is Nothing Then
                dr.Close()
            End If
            If connection.State = ConnectionState.Open Then
                connection.Close() ' Close the connection
            End If
        End Try
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        save()
        DGV_load()
        ClearInputs()
    End Sub

    Public Sub save()
        Try
            connection.Open()
            Dim cmd As New MySqlCommand("INSERT INTO admission (ADM_NO, FIRST_NAME, SURNAME, FORM, STREAM, PARENT_PHONE, DORMITORY, Date) VALUES (@ADM_NO, @FIRST_NAME, @SURNAME, @FORM, @STREAM, @PARENT_PHONE, @DORMITORY, @Date)", connection)
            cmd.Parameters.AddWithValue("@ADM_NO", txt_adm.Text)
            cmd.Parameters.AddWithValue("@FIRST_NAME", text_firstsname.Text)
            cmd.Parameters.AddWithValue("@SURNAME", txt_sur.Text)
            cmd.Parameters.AddWithValue("@FORM", text_form.Text)
            cmd.Parameters.AddWithValue("@STREAM", text_stream.Text)
            cmd.Parameters.AddWithValue("@PARENT_PHONE", text_phonenumber.Text)
            cmd.Parameters.AddWithValue("@DORMITORY", combo_dorm.Text)
            cmd.Parameters.AddWithValue("@DATE", exp_datepicker.Value.ToString("yyyy-MM-dd"))

            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Record saved successfully", "admission", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Save failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txt_adm.Text = DataGridView1.CurrentRow.Cells(0).Value
        text_firstsname.Text = DataGridView1.CurrentRow.Cells(1).Value
        txt_sur.Text = DataGridView1.CurrentRow.Cells(2).Value
        text_form.Text = DataGridView1.CurrentRow.Cells(3).Value
        text_stream.Text = DataGridView1.CurrentRow.Cells(4).Value
        text_phonenumber.Text = DataGridView1.CurrentRow.Cells(5).Value
        combo_dorm.Text = DataGridView1.CurrentRow.Cells(6).Value
        exp_datepicker.Text = DataGridView1.CurrentRow.Cells(0).Value
    End Sub

    Private Sub ClearInputs()
        txt_adm.Clear()
        text_firstsname.Clear()
        txt_sur.Clear()
        text_form.Clear()
        text_stream.Clear()
        text_phonenumber.Clear()
        combo_dorm.SelectedIndex = -1
        exp_datepicker.Value = DateTime.Now
    End Sub
End Class
