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

        If String.IsNullOrWhiteSpace(username) Or String.IsNullOrWhiteSpace(password) Or String.IsNullOrWhiteSpace(confirmPassword) Then
            ErrorMessage.Show("All fields are required.", "Registration Error")
        Else
            Try
                Dim admin As BsonDocument = New BsonDocument()
                admin.Add("name", username)
                admin.Add("password", password)

                If confirmPassword = password Then
                    AdminControllers.InsertDataIntoMongoDB(admin)
                    SuccessMessage.Show("Registration successful!", "Registration Success")
                    txtusername.Clear()
                    txtpassword.Clear()
                    txtconfirmpassword.Clear()
                    Me.Hide()
                Else
                    ErrorMessage.Show("Passwords do not match. Please re-enter your password.", "Registation Error")
                End If
            Catch ex As Exception
                ErrorMessage.Show(ex.Message, "Registration Error")
            End Try
        End If
    End Sub

    Private Sub txtconfirmpassword_IconRightClick(sender As Object, e As EventArgs) Handles txtconfirmpassword.IconRightClick
        IconsPassword.ShowHidePasswordRegister(txtpassword, txtconfirmpassword)
    End Sub

    Private Sub txtconfirmpassword_TextChanged(sender As Object, e As EventArgs) Handles txtconfirmpassword.TextChanged

    End Sub
End Class