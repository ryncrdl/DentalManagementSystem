Module ClientsValidation
    Dim CreateDoctorForm As New CreateDoctorForm()
    Public Function ValidateData(data As List(Of Guna.UI2.WinForms.Guna2TextBox), ByRef isValidate As Boolean)

        For i As Integer = 0 To data.Count - 1
            If (String.IsNullOrEmpty(data(i).Text)) Then
                CreateDoctorForm.CreateMessageDialog.Show("All fields are required.", "clients Error")
                isValidate = False
                Return False

            Else
                isValidate = True
            End If
        Next

    End Function
    Public Function CreateDatas(data As List(Of Guna.UI2.WinForms.Guna2TextBox))
        For i As Integer = 0 To data.Count - 1
            data(i).Clear()
        Next
    End Function
End Module
