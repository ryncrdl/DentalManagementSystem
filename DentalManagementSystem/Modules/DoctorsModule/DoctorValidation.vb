Module DoctorValidation


    Public Function ValidateData(data As List(Of Guna.UI2.WinForms.Guna2TextBox), ByRef isValidate As Boolean)
        For i As Integer = 0 To data.Count - 1
            If (String.IsNullOrEmpty(data(i).Text)) Then
                CreateDoctorForm.CreateMessageDialog.Show("All fields are required.", "Create Doctor Error")
                CreateDoctorForm.Parent = CreateDoctorForm
                isValidate = False
                Return False

            Else
                isValidate = True
            End If
        Next

    End Function

    Public Function CreateData(data As List(Of Guna.UI2.WinForms.Guna2TextBox))
        For i As Integer = 0 To data.Count - 1
            data(i).Clear()
        Next
    End Function

End Module
