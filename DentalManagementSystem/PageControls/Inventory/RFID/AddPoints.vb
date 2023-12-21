Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class AddPoints


    Private Sub AddPoints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection.ConnectToMongoDB("clients")
        rfidnumber.Focus()
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles rfidnumber.TextChanged

        Timer1.Stop()
        Timer1.Start()




    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop() ' Stop the timer
        rfidnumber.Focus()
        Dim getRFID As String = rfidnumber.Text.Trim()

        If getRFID.Length = 10 Then
            If RFIDADDPOINTS.AddPoints(getRFID) Then
                messok.Show()
                rfidnumber.Clear()
                Me.Close()
            Else
                ErrorMessage.Show()
                rfidnumber.Focus()
                rfidnumber.Clear()
            End If
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub
End Class
