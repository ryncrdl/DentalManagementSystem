﻿Imports System.Reflection
Imports System.Windows.Forms
Imports MongoDB.Driver
Imports MongoDB.Bson

Public Class LoginForm
    Dim collection As IMongoCollection(Of BsonDocument)
    Dim password As List(Of Guna.UI2.WinForms.Guna2TextBox)
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        password = New List(Of Guna.UI2.WinForms.Guna2TextBox) From {txtpassword}
        IconsPassword.LoadIcons(password)
        Connection.ConnectToMongoDB("admins")
    End Sub

    Private Sub txtpassword_IconRightClick(sender As Object, e As EventArgs) Handles txtpassword.IconRightClick
        IconsPassword.ShowHidePasswordLogin(txtpassword)
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        ' Display a confirmation dialog for exiting the application  
        Dim result As DialogResult = QuestionMessage.Show("Are you sure you want to exit the application?", "Login Question")

        ' Check the user's response
        If result = DialogResult.Yes Then
            ' User chose "Yes," so close the applications
            Application.Exit()
        End If
    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        ' Minimize the form
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click
        Dim username As String = txtusername.Text
        Dim password As String = txtpassword.Text
        Try
            Dim userDocument As BsonDocument = Authentication.GetUserFromDatabase(username)

            If userDocument IsNot Nothing Then
                Dim storedPassword As String = userDocument.GetValue("password").ToString()

                If password = storedPassword Then
                    Dim result As DialogResult = QuestionMessage.Show("Are you sure to Log In?", "Login Question")
                    ' Password matches; login successful.
                    If result = DialogResult.Yes Then
                        SuccessMessage.Show("Login successful!", "Login Success")
                        DashboardForm.Show()
                        Me.Hide()
                    End If
                    txtusername.Clear()
                    txtpassword.Clear()


                Else
                    ' Password doesn't match.
                    ErrorMessage.Show("Invalid username or password.", "Login Error")
                End If
            Else
                ' User not found (username doesn't exist in the database).
                ErrorMessage.Show("Invalid username or password.", "Login Error")
            End If
        Catch ex As Exception
            ErrorMessage.Show(ex.Message, "Login Error")
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        AdminRegistration.ShowDialog()
    End Sub
End Class
