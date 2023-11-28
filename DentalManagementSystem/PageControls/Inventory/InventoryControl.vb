Public Class InventoryControl
    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles BtnPoints.Click
        AddPoints.ShowDialog()
    End Sub

    Private Sub BtnAvail_Click(sender As Object, e As EventArgs) Handles BtnAvail.Click
        AvailRfid.ShowDialog()
    End Sub

    Private Sub BtnHistory_Click(sender As Object, e As EventArgs) Handles BtnHistory.Click
        History.ShowDialog()
    End Sub

    Private Sub BtnDeleted_Click(sender As Object, e As EventArgs) Handles BtnDeleted.Click
        deletedrejected.ShowDialog()
    End Sub
End Class
