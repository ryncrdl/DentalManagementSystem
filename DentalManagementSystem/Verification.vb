Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class Verification

    Private name As String
    Private password As String
    Private OTP As String

    Public Sub New(ByVal username As String, ByVal password As String, ByVal OTP As String)
        InitializeComponent()
        Me.name = username
        Me.password = password
        Me.OTP = OTP
    End Sub

    Private Sub Verification_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnVerify_Click(sender As Object, e As EventArgs) Handles BtnVerify.Click
        Dim enteredOTP As String = txtCode.Text
        If String.IsNullOrEmpty(enteredOTP) Then
            MessageBox.Show("Enter OTP Code")

        Else
            If enteredOTP = OTP Then
                SuccessMessage.Show("Registration successful!", "Registration Success")
                Try
                    Dim admin As BsonDocument = New BsonDocument()
                    admin.Add("name", name)
                    admin.Add("password", password)

                    AdminControllers.InsertDataIntoMongoDB(admin)
                    LoginForm.Show()
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Registration Error")
                End Try
            Else
                ErrorMessage.Show("OTP do not match. Please re-enter your OTP.", "Registation Error")
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Hide()
    End Sub
End Class