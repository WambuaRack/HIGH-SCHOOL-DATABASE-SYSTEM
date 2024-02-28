Public Class main
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        admission.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        timetables.Show()
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        teachingstaff.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        nonteachingstaff.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Forms.Show()
    End Sub
End Class
