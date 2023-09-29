Public Class History
    Private CompletedTableControl As New CompletedTableControl()
    Private CanceledTableControl As New CanceledTableControl()
    Private Sub BtnIneligible_Click(sender As Object, e As EventArgs) Handles BtnIneligible.Click
        Me.Close()
    End Sub
    Private Sub SwitchTable1(title As String, table As UserControl)
        'Form.Size = New Size(945, 640)
        table.Dock = DockStyle.Fill
        table.BackColor = Color.White
        PanelTable.Controls.Clear()
        PanelTable.Controls.Add(table)
        label1.Text = title
    End Sub

    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwitchTable1("Completed", CompletedTableControl)
    End Sub

    Private Sub BtnPending_Click(sender As Object, e As EventArgs) Handles BtnPending.Click
        SwitchTable1("Completed", CompletedTableControl)
    End Sub

    Private Sub BtnScheduled_Click(sender As Object, e As EventArgs) Handles BtnScheduled.Click
        SwitchTable1("Canceled", CanceledTableControl)
    End Sub
End Class