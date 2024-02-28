Public Class SplashScreen
    Private WithEvents ProgressBar1 As ProgressBar ' Declare ProgressBar1 control without initialization
    Private WithEvents Timer1 As Timer

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize progress bar and timer
        ProgressBar1 = New ProgressBar() ' Initialize ProgressBar1 control
        Timer1 = New Timer() ' Initialize Timer1 control

        ' Set up progress bar
        With ProgressBar1
            .Minimum = 0
            .Maximum = 100
            .Size = New Size(200, 20) ' Adjust size as needed
            .Location = New Point((Me.Width - .Width) \ 2, (Me.Height - .Height) \ 2)
            .Visible = True
        End With
        Me.Controls.Add(ProgressBar1)

        ' Start the timer to control the duration of the splash screen
        Timer1.Interval = 50 ' Adjust interval as needed
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Increment the progress bar value slowly
        ProgressBar1.Increment(1)

        ' Check if the progress bar reaches its maximum value
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            ' Stop the timer when the progress bar reaches its maximum value
            Timer1.Stop()

            ' Create an instance of the main form
            Dim mainForm As New main()

            ' Show the main form
            mainForm.Show()

            ' Hide the splash screen
            Me.Hide()
        End If
    End Sub
End Class
