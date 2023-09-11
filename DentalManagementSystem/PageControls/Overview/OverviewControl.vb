Public Class OverviewControl
    Private Sub DashboardControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnPending_Click(sender As Object, e As EventArgs) Handles BtnPending.Click
        If DashboardForm IsNot Nothing Then
            DashboardForm.BtnClients.PerformClick()
        End If
    End Sub

    Private Sub Guna2Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel6.Paint

    End Sub
End Class
