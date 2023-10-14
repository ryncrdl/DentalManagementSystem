Module AnnouncementsValidation

    Dim AddingServices As New AddingAnnouncements()
    Public Function ValidateData(data As List(Of Guna.UI2.WinForms.Guna2TextBox), ByRef isValidate As Boolean)

        For i As Integer = 0 To data.Count - 1
            If (String.IsNullOrEmpty(data(i).Text)) Then
                isValidate = False
                Return False

            Else
                isValidate = True
            End If
        Next

    End Function
    Public Function ClearData(data As List(Of Guna.UI2.WinForms.Guna2TextBox))
        For i As Integer = 0 To data.Count - 1
            data(i).Clear()
        Next
    End Function


End Module


