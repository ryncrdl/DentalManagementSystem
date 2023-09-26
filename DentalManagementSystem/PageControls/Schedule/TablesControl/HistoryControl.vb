Public Class HistoryControl
    Private CompletedTableControl As New CompletedTableControl()
    Private CanceledTableControl As New CanceledTableControl()


    Private Sub SwitchTable1(title As String, table As UserControl)
        'Form.Size = New Size(945, 640)
        table.Dock = DockStyle.Fill
        table.BackColor = Color.White
        PanelTable.Controls.Clear()
        PanelTable.Controls.Add(table)
        label1.Text = title
    End Sub

    Private Sub HistoryControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwitchTable1("Completed", CompletedTableControl)
    End Sub

    Private Sub BtnScheduled_Click(sender As Object, e As EventArgs) Handles BtnScheduled.Click
        SwitchTable1("Canceled", CanceledTableControl)
    End Sub

    Private Sub BtnIneligible_Click(sender As Object, e As EventArgs) Handles BtnIneligible.Click
        Dim scheduleControl As New ScheduleControl
        Panel1.BringToFront()
        addform(scheduleControl)


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Private Sub addform(Form As UserControl)
        Dim scheduleControl As New ScheduleControl
        Form.Size = New Size(945, 640)
        Form.Dock = DockStyle.Fill
        Form.BackColor = Color.White
        Panel1.Controls.Clear()
        Panel1.Controls.Add(ScheduleControl)

    End Sub

    Private Sub BtnPending_Click(sender As Object, e As EventArgs) Handles BtnPending.Click
        SwitchTable1("Completed", CompletedTableControl)
    End Sub
End Class
