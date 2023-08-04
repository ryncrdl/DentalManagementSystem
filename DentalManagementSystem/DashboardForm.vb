
Public Class DashboardForm
    'Controls
    Private DashboardControl As New DashboardControl()
    Private DoctorsControl As New DoctorsControl()
    Private ClientsControl As New ClientsControl()
    Private ScheduleControl As New ScheduleControl()
    Private InventoryControl As New InventoryControl()
    Private ServicesControl As New ServicesControl()
    Private BlogsControl As New BlogControl()


    Private Sub AddControlForm(form As UserControl)
        form.Size = New Size(945, 640)
        form.Dock = DockStyle.Fill
        form.BackColor = Color.White
        ControlPanel.Controls.Clear()
        ControlPanel.Controls.Add(form)
    End Sub

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddControlForm(DashboardControl)
    End Sub

    Private Sub BtnBlogs_CheckedChanged(sender As Object, e As EventArgs) Handles BtnBlogs.CheckedChanged, BtnServices.CheckedChanged, BtnInventory.CheckedChanged, BtnSchedule.CheckedChanged, BtnClients.CheckedChanged, BtnDoctors.CheckedChanged, BtnDashboard.CheckedChanged
        imageMove(sender)
    End Sub

    Private Sub imageMove(sender As Object)
        Dim b As Guna.UI2.WinForms.Guna2Button = DirectCast(sender, Guna.UI2.WinForms.Guna2Button)
        imgSlide.Location = New Point(b.Location.X + 182, b.Location.Y - 32)
        imgSlide.SendToBack()
    End Sub
    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click
        AddControlForm(DashboardControl)
    End Sub

    Private Sub BtnDoctors_Click(sender As Object, e As EventArgs) Handles BtnDoctors.Click
        AddControlForm(DoctorsControl)
    End Sub

    Private Sub BtnClients_Click(sender As Object, e As EventArgs) Handles BtnClients.Click
        AddControlForm(ClientsControl)
    End Sub

    Private Sub BtnSchedule_Click(sender As Object, e As EventArgs) Handles BtnSchedule.Click
        AddControlForm(ScheduleControl)
    End Sub

    Private Sub BtnInventory_Click(sender As Object, e As EventArgs) Handles BtnInventory.Click
        AddControlForm(InventoryControl)
    End Sub

    Private Sub BtnServices_Click(sender As Object, e As EventArgs) Handles BtnServices.Click
        AddControlForm(ServicesControl)
    End Sub

    Private Sub BtnBlogs_Click(sender As Object, e As EventArgs) Handles BtnBlogs.Click
        AddControlForm(BlogsControl)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            LoginForm.Show()
            Me.Hide()
        End If
    End Sub
End Class