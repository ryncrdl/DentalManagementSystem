Imports System
Imports System.Windows.Forms
Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class EditClients
    Private data As List(Of Guna.UI2.WinForms.Guna2TextBox)
    Private rowData As Dictionary(Of String, String)
    Private collection As IMongoCollection(Of BsonDocument)
    Private clientsId As String
    Public Event clientsupdated As EventHandler
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Public Sub New(ByVal rowData As Dictionary(Of String, String), ByVal collection As IMongoCollection(Of BsonDocument))
        InitializeComponent()
        Me.rowData = rowData
        Me.collection = collection
    End Sub
    Private Sub FetchDoctorData(clientsId As String, collectionName As String)
        Dim database As IMongoDatabase = Connection.database
        Dim collection = Connection.GetMongoDBCollection()

        Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", ObjectId.Parse(clientsId))
        Dim clients = collection.Find(filter).FirstOrDefault()

        ' Populate your form controls with the fetched data
        If clients IsNot Nothing Then
            clients("Fullname") = txtfullname.Text
            clients("Username") = txtUsername.Text
            clients("Password") = txtPassword.Text
            clients("Contact") = txtContact.Text


        Else
            MessageBox.Show("Clients not found.")
        End If
    End Sub

    Private Sub EditClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data = New List(Of Guna.UI2.WinForms.Guna2TextBox) From {txtfullname, txtUsername, txtPassword, txtContact}
        Connection.ConnectToMongoDB("clients")
        ' Populate the form controls with the fetched data

        If rowData.ContainsKey("Fullname") Then
            txtfullname.Text = rowData("Fullname")
        End If

        If rowData.ContainsKey("Username") Then
            txtUsername.Text = rowData("Username")
        End If
        If rowData.ContainsKey("Password") Then
            txtPassword.Text = rowData("Password")
        End If

        If rowData.ContainsKey("Contact") Then
            txtContact.Text = rowData("Contact")
        End If

        If rowData.ContainsKey("ID") Then
            Me.clientsId = rowData("ID")
        End If

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim isValidate As Boolean = False
        ClientsValidation.ValidateData(data, isValidate)


        If (isValidate) Then
            Try
                ' Create the equality filter for the doctor ID
                Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", ObjectId.Parse(clientsId))

                ' Fetch the doctor information using the filter
                Dim clients = collection.Find(filter).FirstOrDefault()

                If clients IsNot Nothing Then
                    ' Update the clients's fields
                    clients("fullName") = txtfullname.Text
                    clients("username") = txtUsername.Text
                    clients("password") = txtPassword.Text
                    clients("contactNumber") = txtContact.Text



                    ' Replace the existing document with the updated one
                    collection.FindOneAndUpdate(filter, clients)

                    MessageSuccessfully.Show()
                    CreateData(data)
                    Me.Close()

                    RaiseEvent clientsupdated(Me, EventArgs.Empty)
                Else
                    ' MessageBox.Show("clients not found.")
                    CustomMessageError.Show("Clients not found.", MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("BtnSave Errors:." & ex.Message)
            End Try
        End If
    End Sub
End Class