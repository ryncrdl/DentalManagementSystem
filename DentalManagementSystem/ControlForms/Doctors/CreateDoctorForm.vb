Imports System.Buffers
Imports System.Net
Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class CreateDoctorForm
    Private data As List(Of Guna.UI2.WinForms.Guna2TextBox)
    Public DoctorsTable As New Guna.UI2.WinForms.Guna2DataGridView
    Public Sub GetTable(table As Guna.UI2.WinForms.Guna2DataGridView)
        DoctorsTable = table
    End Sub


    Private Sub CreateDoctorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data = New List(Of Guna.UI2.WinForms.Guna2TextBox) From {txtfirstname, txtlastname, txtcontact, txtemail, txtaddress}
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

            ' LoadingForm.ShowDialog()
            Try
                If DoctorsControllers.InsertDoctor(firstname, lastname, contact, email, address) Then
                    MessageBox.Show("Doctor added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Clear the input fields after successful addition
                    Me.Close()
                    DoctorValidation.CreateData(data)

                    'Fix to load data after adding new data
                    LoadDataIntoDataGridView("doctors", DoctorsTable) 'fixed
                End If
            Catch ex As Exception
                MessageBox.Show("Error adding doctor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '  Finally
                '    LoadingForm.Close()
            End Try
        End If

    End Sub


End Class