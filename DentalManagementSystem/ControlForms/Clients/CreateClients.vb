Public Class CreateClients
    Private data As List(Of Guna.UI2.WinForms.Guna2TextBox)
    Public Event ClientAdded As EventHandler
    Private Sub CreateClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data = New List(Of Guna.UI2.WinForms.Guna2TextBox) From {txtfullname, txtUsername, txtPassword, txtContact}
        Connection.ConnectToMongoDB("clients")
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim isValidate As Boolean = False
        ClientsValidation.ValidateData(data, isValidate)
        Dim Fullname As String = txtfullname.Text
        Dim Username As String = txtUsername.Text
        Dim Password As String = txtPassword.Text
        Dim Contact As String = txtContact.Text


        If (isValidate) Then
            Try
                If ClientsControllers.InsertClients(Fullname, Username, Password, Contact) Then
                    MessageSuccessfully.Show("Client added successfully!", "Client Success")

                    ' Clear the input fields after successful addition
                    Me.Close()
                    ClientsValidation.CreateDatas(data)

                    RaiseEvent ClientAdded(Me, EventArgs.Empty)
                End If
            Catch ex As Exception
                MessageBox.Show("Error adding doctor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class