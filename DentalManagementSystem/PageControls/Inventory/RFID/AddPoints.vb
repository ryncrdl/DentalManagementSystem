﻿Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class AddPoints


    Private Sub AddPoints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection.ConnectToMongoDB("clients")

    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles rfidnumber.TextChanged
        Me.Focus()
        Dim getRFID As String = rfidnumber.Text

        If (getRFID.ToString.Length = 10) Then
            If RFIDADDPOINTS.AddPoints(getRFID) Then
                SuccessMessage.Show()
                rfidnumber.Clear()
                Me.Close()
                Me.Focus()
            Else
                MessageBox.Show("error")
                rfidnumber.Clear()
                Me.Focus()
            End If
        End If
    End Sub
End Class
