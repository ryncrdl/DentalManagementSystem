Imports System
Imports System.Windows.Forms
Imports Guna.UI2.WinForms
Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class EditServices
    Private data As List(Of Guna.UI2.WinForms.Guna2TextBox)
    Private rowData As Dictionary(Of String, String)
    Private collection As IMongoCollection(Of BsonDocument)
    Private clientsId As String
    Public Event Servicesupdated As EventHandler
    Private imagePath As String
    Public Sub New(ByVal rowData As Dictionary(Of String, String), ByVal collection As IMongoCollection(Of BsonDocument))
        InitializeComponent()
        Me.rowData = rowData
        Me.collection = collection
    End Sub
    Private Sub FetchDoctorData(clientsId As String, collectionName As String)
        Dim database As IMongoDatabase = Connection.database
        Dim collection = Connection.GetMongoDBCollection()

        Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", ObjectId.Parse(clientsId))
        Dim services = collection.Find(filter).FirstOrDefault()

        ' Populate your form controls with the fetched data
        If services IsNot Nothing Then
            services("image") = imagePath
            services("Title") = txttitle.Text
            services("Description") = txtdescription.Text
            services("Price") = txtprice.Text
            services("Payment") = txtPayment.Text


        Else
            MessageBox.Show("Services not found.")
        End If
    End Sub
    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Dim isValidate As Boolean = False
        ServicesValidation.ValidateData(data, isValidate)
        If (isValidate) Then
            Try
                ' Create the equality filter for the doctor ID
                Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", ObjectId.Parse(clientsId))

                ' Fetch the doctor information using the filter
                Dim service = collection.Find(filter).FirstOrDefault()

                If service IsNot Nothing Then
                    ' Update the doctor's fields
                    service("Title") = txttitle.Text
                    service("Description") = txtdescription.Text
                    service("Price") = txtprice.Text
                    service("Payment") = txtPayment.Text

                    ' Replace the existing document with the updated one
                    collection.FindOneAndUpdate(filter, service)
                    messageOK.Show()
                    ServicesValidation.CreateDatas(data)
                    Me.Close()

                    RaiseEvent Servicesupdated(Me, EventArgs.Empty)
                Else
                    messageOK.Show("Services not found.", MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("BtnSave Errors:." & ex.Message)
            End Try
        End If


    End Sub

    Private Sub EditServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim txtPayment As Control = txtPayment


        data = New List(Of Guna.UI2.WinForms.Guna2TextBox) From {txttitle, txtdescription, txtprice}

        Connection.ConnectToMongoDB("services")

        ' Populate the form controls with the fetched data

        If rowData.ContainsKey("Title") Then
            txttitle.Text = rowData("Title")
        End If

        If rowData.ContainsKey("Description") Then
            txtdescription.Text = rowData("Description")
        End If

        If rowData.ContainsKey("Price") Then
            txtprice.Text = rowData("Price")
        End If

        If rowData.ContainsKey("Payment") AndAlso rowData("Payment") IsNot Nothing Then
            ' Check if txtPayment is a Guna2ComboBox
            If TypeOf txtPayment Is Guna.UI2.WinForms.Guna2ComboBox Then
                ' Cast txtPayment to Guna2ComboBox and set its selected item or text
                Dim comboBoxPayment As Guna.UI2.WinForms.Guna2ComboBox = DirectCast(txtPayment, Guna.UI2.WinForms.Guna2ComboBox)
                comboBoxPayment.Text = rowData("Payment").ToString()
            Else
                ' Handle the case where txtPayment is not a Guna2ComboBox
                ' You might want to display an error message or handle it accordingly
            End If
        Else
            ' Handle the case where "Payment" is null
            ' You might want to set a default value or handle it according to your logic
        End If


        If rowData.ContainsKey("ID") Then
            Me.clientsId = rowData("ID")
        End If
    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        Try
            With OpenFileDialog1
                .Filter = "Image Files |*.png; *.jpeg;*.jpg"
                .FilterIndex = 1
            End With

            OpenFileDialog1.FileName = ""

            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                ' Load the selected image into Guna2CirclePictureBox1
                image1.Image = Image.FromFile(OpenFileDialog1.FileName)

                ' Store the image file path
                imagePath = OpenFileDialog1.FileName
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class