Imports System.Reflection
Imports System.Windows.Forms
Imports MongoDB.Driver
Imports MongoDB.Bson

Public Class LoginForm
    Dim collection As IMongoCollection(Of BsonDocument)
    Dim password As List(Of Guna.UI2.WinForms.Guna2TextBox)
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        password = New List(Of Guna.UI2.WinForms.Guna2TextBox) From {txtpassword}
        IconsPassword.LoadIcons(password)
        Connection.ConnectToMongoDB("admin")
    End Sub

    Private Sub txtpassword_IconRightClick(sender As Object, e As EventArgs) Handles txtpassword.IconRightClick
        IconsPassword.ShowHidePasswordLogin(txtpassword)
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        ' Display a confirmation dialog for exiting the application
        Dim customDialog As New CustomMessageDialogForm("Are you sure you want to exit the application?")
        Dim result As DialogResult = customDialog.ShowDialog()

        ' Check the user's response
        If result = DialogResult.OK Then
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
                    Dim r As Integer

                    r = MessageBox.Show("Are you sure to Log In?", "LOG IN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    ' Password matches; login successful.
                    If r = vbYes Then

                        DashboardForm.Show()
                        Me.Hide()
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Dim result = MessageBox.Show()
                    End If
                    txtusername.Text = ""
                    txtpassword.Text = ""


                Else
                        ' Password doesn't match.
                        MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                ' User not found (username doesn't exist in the database).
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        AdminRegistration.ShowDialog()
    End Sub
End Class
