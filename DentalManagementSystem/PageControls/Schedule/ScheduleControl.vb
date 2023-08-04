Public Class ScheduleControl
    Private Sub BtnPending_Click(sender As Object, e As EventArgs) Handles BtnPending.Click
        With Pending
            .TopLevel = False
            panel1.Controls.Add(Pending)
            .BringToFront()
            .Show()

        End With
        label1.Text = "Pending"
    End Sub

    Private Sub BtnScheduled_Click(sender As Object, e As EventArgs) Handles BtnScheduled.Click
        With Scheduled
            .TopLevel = False
            panel1.Controls.Add(Scheduled)
            .BringToFront()
            .Show()
        End With
        label1.Text = "Scheduled"
    End Sub

    Private Sub BtnIneligible_Click(sender As Object, e As EventArgs) Handles BtnIneligible.Click
        With ineligible
            .TopLevel = False
            panel1.Controls.Add(ineligible)
            .BringToFront()
            .Show()

        End With
        label1.Text = "Ineligible"
    End Sub

    Private Sub panel1_Paint(sender As Object, e As PaintEventArgs) Handles panel1.Paint
        With Pending
            .TopLevel = False
            panel1.Controls.Add(Pending)
            .BringToFront()
            .Show()

        End With
    End Sub
End Class
