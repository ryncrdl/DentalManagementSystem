Imports System
Imports System.Windows.Forms
Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class CompleteReject
    Private data As List(Of Guna.UI2.WinForms.Guna2TextBox)
    Private rowData As Dictionary(Of String, String)
    Private rowImage As Dictionary(Of String, Image)
    Private collection As IMongoCollection(Of BsonDocument)
    Private CompleteId As String
    Public Sub New(ByVal rowData As Dictionary(Of String, String), rowImage As Dictionary(Of String, Image), ByVal collection As IMongoCollection(Of BsonDocument))
        InitializeComponent()
        Me.rowData = rowData
        Me.rowImage = rowImage
        Me.collection = collection
    End Sub
    Private Sub CompleteReject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data = New List(Of Guna.UI2.WinForms.Guna2TextBox) From {txtfullname, txtcontact, txtdate, txtservice, txtdoctor}
        Connection.ConnectToMongoDB("approved")
        ' Populate the form controls with the fetched data

        If rowData.ContainsKey("Fullname") Then
            txtfullname.Text = rowData("Fullname")
        End If

        If rowData.ContainsKey("Contact") Then
            txtcontact.Text = rowData("Contact")
        End If
        If rowData.ContainsKey("Dates") Then
            txtdate.Text = rowData("Dates")
        End If

        If rowData.ContainsKey("Service") Then
            txtservice.Text = rowData("Service")
        End If
        If rowData.ContainsKey("Doctor") Then
            txtdoctor.Text = rowData("Doctor")
        End If

        If rowImage.ContainsKey("Payment") Then
            Guna2PictureBox1.Image = rowImage("Payment")
        End If

        If rowData.ContainsKey("ID") Then
            Me.CompleteId = rowData("ID")
        End If
    End Sub
    Private Sub FetchDoctorData(clientsId As String, collectionName As String)
        Dim database As IMongoDatabase = Connection.database
        Dim collection = Connection.GetMongoDBCollection()

        Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", ObjectId.Parse(CompleteId))
        Dim appointments = collection.Find(filter).FirstOrDefault()

        ' Populate your form controls with the fetched data
        If appointments IsNot Nothing Then
            appointments("Fullname") = txtfullname.Text
            appointments("Contact") = txtcontact.Text
            appointments("Date") = txtdate.Text
            appointments("Service") = txtservice.Text
            appointments("Doctor") = txtdoctor.Text

            If Guna2PictureBox1.Image IsNot Nothing Then
                ' Convert the image to a base64 string
                Dim imageConverter As New ImageConverter()
                Dim imageBytes As Byte() = DirectCast(imageConverter.ConvertTo(Guna2PictureBox1.Image, GetType(Byte())), Byte())
                Dim base64String As String = Convert.ToBase64String(imageBytes)

                ' Assign the base64 string to the "Payment" field in your MongoDB document
                appointments("Payment") = base64String
            Else
                appointments("Payment") = ""
            End If


        Else
            MessageBox.Show("Clients not found.")
        End If

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click


        ' Check if the receiver's number and message content are not empty


        Dim sourceCollectionName As String = "approved"
        Dim destCollectionName As String = "completed"


        ' Call the MoveCollectionData function from the MongoDBHelper module
        Completed.completed(sourceCollectionName, destCollectionName, CompleteId)

        ' Display a success message or perform any other necessary actions
        MessageSuccessfully.Show()
        Me.Close()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click

        Dim sourceCollectionName As String = "approved"
        Dim destCollectionName As String = "canceled"


        ' Call the MoveCollectionData function from the MongoDBHelper module
        Completed.completed(sourceCollectionName, destCollectionName, CompleteId)

        ' Display a success message or perform any other necessary actions
        rejectsuccessfully.Show()
        Me.Close()
    End Sub
End Class