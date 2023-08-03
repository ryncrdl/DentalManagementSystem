Imports MongoDB.Bson
Imports MongoDB.Driver
Imports System.Reflection

Public Class AdminRegistration
    Dim collection As IMongoCollection(Of BsonDocument)
    Dim password As List(Of Guna.UI2.WinForms.Guna2TextBox)

    Private Sub AdminRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        password = New List(Of Guna.UI2.WinForms.Guna2TextBox) From {txtpassword, txtconfirmpassword}
        IconsPassword.LoadIcons(password)
        Connection.ConnectToMongoDB("admin")
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
            MessageBox.Show("ALL FIELDS REQUIRED!")
        Else
            Try
                Dim admin As BsonDocument = New BsonDocument()
                admin.Add("name", username)
                admin.Add("password", password)

                If confirmPassword = password Then
                    AdminControllers.InsertDataIntoMongoDB(admin)
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtusername.Text = ""
                    txtpassword.Text = ""
                    txtconfirmpassword.Text = ""
                    Me.Hide()
                Else
                    MessageBox.Show("Passwords do not match. Please re-enter your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub txtconfirmpassword_IconRightClick(sender As Object, e As EventArgs) Handles txtconfirmpassword.IconRightClick
        IconsPassword.ShowHidePasswordRegister(txtpassword, txtconfirmpassword)
    End Sub
End Class