Public Class ScheduleControl
    Private PendingTable As New PendingTableControl()
    Private ScheduledTable As New ScheduledTableControl()
    Private IneligibleTable As New IneligibleTableControl()

    Private Sub SwitchTable(title As String, table As UserControl)
        'Form.Size = New Size(945, 640)
        table.Dock = DockStyle.Fill
        table.BackColor = Color.White
        PanelTable.Controls.Clear()
        PanelTable.Controls.Add(table)
        label1.Text = title
    End Sub



    Private Sub BtnPending_Click(sender As Object, e As EventArgs) Handles BtnPending.Click
        SwitchTable("Pending", PendingTable)
    End Sub

    Private Sub BtnScheduled_Click(sender As Object, e As EventArgs) Handles BtnScheduled.Click
        SwitchTable("Scheduled", ScheduledTable)
    End Sub

    Private Sub BtnIneligible_Click(sender As Object, e As EventArgs) Handles BtnIneligible.Click
        SwitchTable("Ineligible", IneligibleTable)
    End Sub

    Private Sub ScheduleControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwitchTable("Pending", PendingTable)
    End Sub


    Private Sub PanelCompleted_Paint(sender As Object, e As PaintEventArgs) Handles PanelCompleted.Paint

    End Sub

End Class
