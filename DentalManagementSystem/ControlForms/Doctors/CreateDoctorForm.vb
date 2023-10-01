Public Class CreateDoctorForm
    Private data As List(Of Guna.UI2.WinForms.Guna2TextBox)
    Public Event DoctorAdded As EventHandler

    Private Sub CreateDoctorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data = New List(Of Guna.UI2.WinForms.Guna2TextBox) From {txtfirstname, txtlastname, txtcontact, txtemail, txtaddress}
        Connection.ConnectToMongoDB("doctors")

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        DoctorValidation.CreateData(data)
        Me.Close()
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Dim isValidate As Boolean = False
        DoctorValidation.ValidateData(data, isValidate)
        Dim firstname As String = txtfirstname.Text
        Dim lastname As String = txtlastname.Text
        Dim contact As String = txtcontact.Text
        Dim email As String = txtemail.Text
        Dim address As String = txtaddress.Text

        If (isValidate) Then
            Try
                If DoctorsControllers.InsertDoctor(firstname, lastname, contact, email, address) Then
                    MessageSuccessfully.Show("Doctor added successfully!", "Doctor Success")

                    ' Clear the input fields after successful addition
                    Me.Close()
                    DoctorValidation.CreateData(data)

                    RaiseEvent DoctorAdded(Me, EventArgs.Empty)
                End If
            Catch ex As Exception
                MessageBox.Show("Error adding doctor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub txtcontact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcontact.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True

            CreateMessageDialog.Show("Numbers Only!", "Input")

        End If
    End Sub

    Private Sub txtlastname_TextChanged(sender As Object, e As EventArgs) Handles txtlastname.TextChanged

    End Sub

    Private Sub txtcontact_TextChanged(sender As Object, e As EventArgs) Handles txtcontact.TextChanged

    End Sub
End Class