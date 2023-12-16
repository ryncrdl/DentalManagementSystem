Imports MongoDB.Bson
Imports MongoDB.Driver
Imports System.Reflection

Public Class AdminRegistration
    Dim collection As IMongoCollection(Of BsonDocument)
    Dim password As List(Of Guna.UI2.WinForms.Guna2TextBox)

    Private Sub AdminRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        password = New List(Of Guna.UI2.WinForms.Guna2TextBox) From {txtpassword, txtconfirmpassword}
        IconsPassword.LoadIcons(password)
        Connection.ConnectToMongoDB("admins")
    End Sub

    Private Sub txtpassword_IconRightClick(sender As Object, e As EventArgs) Handles txtpassword.IconRightClick
        IconsPassword.ShowHidePasswordRegister(txtpassword, txtconfirmpassword)
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Me.Close()
    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Dim username As String = txtusername.Text
        Dim password As String = txtpassword.Text
        Dim confirmPassword As String = txtconfirmpassword.Text

        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            ErrorMessage.Show("All fields are required.", "Registation Error")
        Else
            If confirmPassword = password Then
                verifyRegistration()
                Dim getOTP As String = GMAIL_OTP_CODE()

                txtusername.Clear()
                txtpassword.Clear()
                txtconfirmpassword.Clear()
                Dim verification As New Verification(username, password, getOTP)
                verification.ShowDialog()
                Me.Close()
            Else
                ErrorMessage.Show("Passwords do not match. Please re-enter your password.", "Registation Error")
            End If
        End If
    End Sub

    Private Sub txtconfirmpassword_IconRightClick(sender As Object, e As EventArgs) Handles txtconfirmpassword.IconRightClick
        IconsPassword.ShowHidePasswordRegister(txtpassword, txtconfirmpassword)
    End Sub
End Class