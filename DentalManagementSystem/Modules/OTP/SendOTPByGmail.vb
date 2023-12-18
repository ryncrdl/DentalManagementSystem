Imports System.Net
Imports System.Net.Mail
Imports System.Text

Module SendOTPByGmail
    Private OTP_CODE_EMAIL As String
    Private ReadOnly random As New Random()

    Public Function GenerateCode(length As Integer) As String
        Const chars As String = "0123456789"
        Dim code As New StringBuilder()

        For i As Integer = 0 To length - 1
            Dim index As Integer = random.Next(chars.Length)
            code.Append(chars(index))
        Next

        Return code.ToString()
    End Function

    Sub verifyRegistration()
        Dim email As String = "ryancordial2k22@gmail.com"
        Dim verificationCode As String = GenerateCode(6)

        SendVerificationCode(email, verificationCode)
        Dim email1 As String = "rojamescarlquicoy@gmail.com"
        Dim verificationCode1 As String = GenerateCode(6)

        SendVerificationCode(email1, verificationCode)


    End Sub

    Public Sub SendVerificationCode(email As String, verificationCode As String)
        Try
            Dim senderEmail As String = "capstone12023@gmail.com"
            Dim senderPassword As String = "ljaeglfybyewxfsw"
            Dim smtpHost As String = "smtp.gmail.com"
            Dim smtpPort As Integer = 587 ' or 465 for SSL

            Dim mail As New MailMessage()
            mail.From = New MailAddress(senderEmail)
            mail.[To].Add(email)
            mail.Subject = "Email Verification Code"
            mail.Body = "This security allow to use only for admin registration" & vbNewLine &
                        "Please don't share to other unauthorize personel
                         " & vbNewLine & "Your verification code is: " & verificationCode

            OTP_CODE_EMAIL = verificationCode

            Dim smtpClient As New SmtpClient(smtpHost)
            smtpClient.Port = smtpPort
            smtpClient.Credentials = New NetworkCredential(senderEmail, senderPassword)
            smtpClient.EnableSsl = True ' Set to True if using SSL

            smtpClient.Send(mail)
        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Public Function GMAIL_OTP_CODE() As String
        Return OTP_CODE_EMAIL
    End Function
End Module
