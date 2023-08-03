Imports Guna.UI2.WinForms

Module IconsPassword
    Private isPasswordVisible As Boolean = False
    Private showPasswordIcon As Image
    Private hidePasswordIcon As Image
    Public password As List(Of Guna.UI2.WinForms.Guna2TextBox)

    Public Sub LoadIcons(password As List(Of Guna.UI2.WinForms.Guna2TextBox))
        showPasswordIcon = Image.FromFile(Application.StartupPath & "Assets/icons8-eye-90.png")
        hidePasswordIcon = Image.FromFile(Application.StartupPath & "Assets/icons8-hide-90.png")

        For index = 0 To password.Count - 1
            password(index).IconRight = hidePasswordIcon
            password(index).PasswordChar = "●"
        Next

    End Sub
    Public Sub ShowHidePasswordLogin(password As Guna.UI2.WinForms.Guna2TextBox)
        ' Toggle password visibility
        isPasswordVisible = Not isPasswordVisible

        If isPasswordVisible Then
            password.PasswordChar = ControlChars.NullChar
            password.IconRight = showPasswordIcon
        Else
            password.PasswordChar = "●"
            password.IconRight = hidePasswordIcon
        End If
    End Sub

    Public Sub ShowHidePasswordRegister(password As Guna.UI2.WinForms.Guna2TextBox, confirmPassword As Guna.UI2.WinForms.Guna2TextBox)
        ' Toggle password visibility
        isPasswordVisible = Not isPasswordVisible

        If isPasswordVisible Then
            password.PasswordChar = ControlChars.NullChar
            password.IconRight = showPasswordIcon

            confirmPassword.PasswordChar = ControlChars.NullChar
            confirmPassword.IconRight = showPasswordIcon
        Else
            password.PasswordChar = "●"
            password.IconRight = hidePasswordIcon

            confirmPassword.PasswordChar = "●"
            confirmPassword.IconRight = hidePasswordIcon
        End If
    End Sub



End Module
