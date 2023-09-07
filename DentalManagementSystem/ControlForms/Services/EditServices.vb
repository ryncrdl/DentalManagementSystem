Imports System
Imports System.Windows.Forms
Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class EditServices
    Private data As List(Of Guna.UI2.WinForms.Guna2TextBox)
    Private rowData As Dictionary(Of String, String)
    Private collection As IMongoCollection(Of BsonDocument)
    Private ServicesId As String
    Public Event ServicesUpdated As EventHandler
    Public Sub New(ByVal rowData As Dictionary(Of String, String), ByVal collection As IMongoCollection(Of BsonDocument))
        InitializeComponent()
        Me.rowData = rowData
        Me.collection = collection
    End Sub
    Private Sub FetchDoctorData(doctorId As String, collectionName As String)
        Dim database As IMongoDatabase = Connection.database
        Dim collection = Connection.GetMongoDBCollection()

        Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", ObjectId.Parse(doctorId))
        Dim services = collection.Find(filter).FirstOrDefault()

        ' Populate your form controls with the fetched data
        If services IsNot Nothing Then
            services("Title") = txttitle.Text
            services("Description") = txtdescription.Text
            services("Price") = txtprice.Text

            MessageBox.Show("Services not found.")
        End If
    End Sub
    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Dim isValidate As Boolean = False
        ServicesValidation.ValidateData(data, isValidate)


        If (isValidate) Then
            Try
                ' Create the equality filter for the doctor ID
                Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", ObjectId.Parse(ServicesId))

                ' Fetch the doctor information using the filter
                Dim services = collection.Find(filter).FirstOrDefault()

                If services IsNot Nothing Then
                    ' Update the doctor's fields
                    services("Image") = txttitle.Text
                    services("Title") = txtdescription.Text
                    services("Description") = txtprice.Text



                    ' Replace the existing document with the updated one
                    collection.FindOneAndUpdate(filter, services)

                    messageOK.Show()
                    CreateData(data)
                    Me.Close()

                    RaiseEvent ServicesUpdated(Me, EventArgs.Empty)
                Else
                    ' MessageBox.Show("Doctor not found.")
                    messageERROR.Show("Doctor not found.", MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("BtnSave Errors:." & ex.Message)
            End Try
        End If


    End Sub

    Private Sub EditServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data = New List(Of Guna.UI2.WinForms.Guna2TextBox) From {txttitle, txtdescription, txtprice}
        Connection.ConnectToMongoDB("doctors")
        ' Populate the form controls with the fetched data
        If rowData.ContainsKey("Image") Then
            txttitle.Text = rowData("Image")
        End If

        If rowData.ContainsKey("Title") Then
            txtdescription.Text = rowData("Title")
        End If

        If rowData.ContainsKey("Description") Then
            txtprice.Text = rowData("Description")
        End If

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class