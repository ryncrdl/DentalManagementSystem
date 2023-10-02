Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class AddPoints

    Private Sub AddPoints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection.ConnectToMongoDB("clients")
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles rfidnumber.TextChanged



        RFIDADDPOINTS.CopyDataAndAddPoints(Me.Text.Trim)
    End Sub
End Class
