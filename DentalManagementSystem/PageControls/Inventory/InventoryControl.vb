Public Class InventoryControl
    Private Sub InventoryControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles BtnPoints.Click
        AddPoints.Show()
    End Sub

    Private Sub BtnAvail_Click(sender As Object, e As EventArgs) Handles BtnAvail.Click
        AvailRfid.Show()
    End Sub

    Private Sub BtnHistory_Click(sender As Object, e As EventArgs) Handles BtnHistory.Click
        History.Show()
    End Sub

    Private Sub Guna2CustomGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2CustomGradientPanel1.Paint

    End Sub
End Class
