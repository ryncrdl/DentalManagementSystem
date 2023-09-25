Imports System
Imports System.Windows.Forms
Imports MongoDB.Bson
Imports MongoDB.Driver
Imports System.IO.Ports
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class AcceptReject
    Private data As List(Of Guna.UI2.WinForms.Guna2TextBox)
    Private rowData As Dictionary(Of String, String)
    Private rowImage As Dictionary(Of String, Image)
    Private collection As IMongoCollection(Of BsonDocument)
    Private AppointmentsId As String
    Public Sub New(ByVal rowData As Dictionary(Of String, String), ByVal rowImage As Dictionary(Of String, Image), ByVal collection As IMongoCollection(Of BsonDocument))
        InitializeComponent()
        Me.rowData = rowData
        Me.rowImage = rowImage
        Me.collection = collection
    End Sub
    Private Sub AcceptReject_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        data = New List(Of Guna.UI2.WinForms.Guna2TextBox) From {txtfullname, txtcontact, txtdate, txtservice, txtdoctor}
        Connection.ConnectToMongoDB("appointments")
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
            Guna2PictureBox1.Image = DirectCast(rowImage("Payment"), Image)
        End If

        If rowData.ContainsKey("ID") Then
            Me.AppointmentsId = rowData("ID")
        End If
        InitializeSerialPort()

    End Sub
    Private Sub FetchDoctorData(clientsId As String, collectionName As String)
        Dim database As IMongoDatabase = Connection.database
        Dim collection = Connection.GetMongoDBCollection()

        Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", ObjectId.Parse(AppointmentsId))
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

            MessageBox.Show("Clients not found.")
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub


    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim receiverNumber As String = txtcontact.Text
        Dim messageContent As String = txtdate.Text
        Dim services As String = txtservice.Text

        ' Check if the receiver's number and message content are not empty
        SendMessage(receiverNumber, services, messageContent)

        Dim sourceCollectionName As String = "appointments"
        Dim destCollectionName As String = "approved"

        ' Call the MoveCollectionData function from the MongoDBHelper module
        AcceptControllers.TransferDataOneByOne(sourceCollectionName, destCollectionName)

        ' Display a success message or perform any other necessary actions
        MessageSuccessfully.Show()
        Me.Close()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim receiverNumber As String = txtcontact.Text
        Dim messageContent As String = txtdate.Text
        Dim services As String = txtservice.Text
        SendMessage1(receiverNumber, services, messageContent)

        Dim sourceCollectionName As String = "appointments"
        Dim destCollectionName As String = "rejected"

        ' Call the MoveCollectionData function from the MongoDBHelper module
        RejectControllers.TransferDataByOne(sourceCollectionName, destCollectionName)

        ' Display a success message or perform any other necessary actions
        rejectsuccessfully.Show()
        Me.Close()
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub
End Class