Public Class OverviewControl
    Private Sub DashboardControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NoOfAppointments.Text = GetOverviewCount("appointments")
        DoctorsAvailable.Text = GetOverviewCount("doctors")
        NoOfScheduled.Text = GetOverviewCount("approved")
    End Sub

    Private Sub BtnPending_Click(sender As Object, e As EventArgs) Handles BtnPending.Click
        If DashboardForm IsNot Nothing Then
            DashboardForm.BtnClients.PerformClick()
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DisplayDate.Text = "Date: " + DateTime.Now.ToString("MMMM dd, yyyy")
        Dim currentTime As DateTime = DateTime.Now
        If currentTime.Hour = 12 Then
            currentTime = currentTime.Date.AddHours(1)
        End If
        DisplayTime.Text = "Time: " + currentTime.ToString("hh:mm:ss tt")
    End Sub

    Private Sub Guna2Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel5.Paint

    End Sub
End Class
