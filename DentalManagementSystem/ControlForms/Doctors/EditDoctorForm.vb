Imports System
Imports System.Windows.Forms
Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class EditDoctorForm
    Private data As List(Of Guna.UI2.WinForms.Guna2TextBox)
    Private rowData As Dictionary(Of String, String)
    Private collection As IMongoCollection(Of BsonDocument)
    Private doctorId As String
    Public Event DoctorUpdated As EventHandler

    Public Sub New(ByVal rowData As Dictionary(Of String, String), ByVal collection As IMongoCollection(Of BsonDocument))
        InitializeComponent()
        Me.rowData = rowData
        Me.collection = collection
    End Sub

    Private Sub FetchDoctorData(doctorId As String, collectionName As String)
        Dim database As IMongoDatabase = Connection.database
        Dim collection = Connection.GetMongoDBCollection()

        Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", ObjectId.Parse(doctorId))
        Dim doctor = collection.Find(filter).FirstOrDefault()

        ' Populate your form controls with the fetched data
        If doctor IsNot Nothing Then
            doctor("FirstName") = txtfirstname.Text
            doctor("LastName") = txtlastname.Text
            doctor("Contact") = txtcontact.Text
            doctor("Email") = txtemail.Text
            doctor("Address") = txtaddress.Text
        Else
            MessageBox.Show("Doctor not found.")
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        DoctorValidation.CreateData(data)
        Me.Close()
    End Sub

    Private Sub EditDoctorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data = New List(Of Guna.UI2.WinForms.Guna2TextBox) From {txtfirstname, txtlastname, txtcontact, txtemail, txtaddress}
        Connection.ConnectToMongoDB("doctors")
        ' Populate the form controls with the fetched data
        If rowData.ContainsKey("FirstName") Then
            txtfirstname.Text = rowData("FirstName")
        End If

        If rowData.ContainsKey("LastName") Then
            txtlastname.Text = rowData("LastName")
        End If

        If rowData.ContainsKey("Contact") Then
            txtcontact.Text = rowData("Contact")
        End If

        If rowData.ContainsKey("Email") Then
            txtemail.Text = rowData("Email")
        End If

        If rowData.ContainsKey("Address") Then
            txtaddress.Text = rowData("Address")
        End If

        If rowData.ContainsKey("ID") Then
            Me.doctorId = rowData("ID")
        End If
    End Sub


    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim isValidate As Boolean = False
        DoctorValidation.ValidateData(data, isValidate)


        If (isValidate) Then
            Try
                ' Create the equality filter for the doctor ID
                Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", ObjectId.Parse(doctorId))

                ' Fetch the doctor information using the filter
                Dim doctor = collection.Find(filter).FirstOrDefault()

                If doctor IsNot Nothing Then
                    ' Update the doctor's fields
                    doctor("FirstName") = txtfirstname.Text
                    doctor("LastName") = txtlastname.Text
                    doctor("Contact") = txtcontact.Text
                    doctor("Email") = txtemail.Text
                    doctor("Address") = txtaddress.Text


                    ' Replace the existing document with the updated one
                    collection.FindOneAndUpdate(filter, doctor)

                    MessageSuccessfully.Show()
                    CreateData(data)
                    Me.Close()

                    RaiseEvent DoctorUpdated(Me, EventArgs.Empty)
                Else
                    ' MessageBox.Show("Doctor not found.")
                    CustomMessageError.Show("Doctor not found.", MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("BtnSave Errors:." & ex.Message)
            End Try
        End If



    End Sub



End Class