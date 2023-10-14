Imports System
Imports System.Windows.Forms
Imports Guna.UI2.WinForms
Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class EditAnnouncements
    Private data As List(Of Guna.UI2.WinForms.Guna2TextBox)
    Private rowData As Dictionary(Of String, String)
    Private collection As IMongoCollection(Of BsonDocument)
    Private announcementId As String
    Public Event AnnouncementUpdated As EventHandler
    Private imagePath As String
    Public Sub New(ByVal rowData As Dictionary(Of String, String), ByVal collection As IMongoCollection(Of BsonDocument))
        InitializeComponent()
        Me.rowData = rowData
        Me.collection = collection
    End Sub
    Private Sub FetchDoctorData(announcementId As String, collectionName As String)
        Dim collection = Connection.GetMongoDBCollection()

        Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", ObjectId.Parse(announcementId))
        Dim announcement = collection.Find(filter).FirstOrDefault()

        ' Populate your form controls with the fetched data
        If announcement IsNot Nothing Then
            announcement("image") = imagePath
            announcement("Title") = txttitle.Text
            announcement("Context") = txtcontext.Text
        Else
            MessageBox.Show("Announcement not found.")
        End If
    End Sub
    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Dim isValidate As Boolean = False
        AnnouncementsValidation.ValidateData(data, isValidate)
        If (isValidate) Then
            Try
                ' Create the equality filter for the doctor ID
                Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", ObjectId.Parse(announcementId))

                ' Fetch the doctor information using the filter
                Dim announcement = collection.Find(filter).FirstOrDefault()

                If announcement IsNot Nothing Then
                    ' Update the doctor's fields
                    announcement("Title") = txttitle.Text
                    announcement("Context") = txtcontext.Text

                    ' Replace the existing document with the updated one
                    collection.FindOneAndUpdate(filter, announcement)

                    messageOK.Show()
                    AnnouncementsValidation.ClearData(data)
                    Me.Close()

                    RaiseEvent AnnouncementUpdated(Me, EventArgs.Empty)
                Else
                    messageOK.Show("Announcement not found.", MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("BtnSave Errors:." & ex.Message)
            End Try
        End If
    End Sub

    Private Sub EditAnnouncements_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data = New List(Of Guna.UI2.WinForms.Guna2TextBox) From {txttitle, txtcontext}

        Connection.ConnectToMongoDB("announcements")

        ' Populate the form controls with the fetched data

        If rowData.ContainsKey("Title") Then
            txttitle.Text = rowData("Title")
        End If

        If rowData.ContainsKey("Context") Then
            txtcontext.Text = rowData("Context")
        End If

        If rowData.ContainsKey("ID") Then
            Me.announcementId = rowData("ID")
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