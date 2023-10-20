Public Class UsePoints
    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Me.Close()
    End Sub

    Private Sub rfidnumber_TextChanged(sender As Object, e As EventArgs) Handles rfidnumber.TextChanged
        Timer1.Stop()
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop() ' Stop the timer
        rfidnumber.Focus()
        Dim getRFID As String = rfidnumber.Text.Trim()

        If getRFID.Length = 10 Then
            ' Call the function to check RFID and retrieve data
            Dim rfidData = findallByRfid(getRFID)

            ' Check if the returned RFID data is valid
            If rfidData.Item1 <> "" Then
                ' Show success message and clear input
                panel1.BringToFront()
                rfidnumber.Clear()
                Me.Close()
            Else
                ' Handle the case where RFID is not found
                ErrorMessage.Show()
                rfidnumber.Clear()
            End If
        Else
            ' Handle the case where the RFID number doesn't have the expected length
            ErrorMessage.Show()
            rfidnumber.Focus()
            rfidnumber.Clear()
        End If


    End Sub
End Class