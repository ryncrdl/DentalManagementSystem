Imports MongoDB.Bson
Imports MongoDB.Driver
Imports System.IO
Imports System.Windows.Forms

Module AnnouncementsControllers

    Public Sub loaddatas(collectionName As String, dataGridViews As Guna.UI2.WinForms.Guna2DataGridView)
        Try
            ' Connect to MongoDB and get the collection
            Connection.ConnectToMongoDB(collectionName)
            Dim collection As IMongoCollection(Of BsonDocument) = Connection.GetMongoDBCollection()

            ' Fetch data from MongoDB
            Dim filter = Builders(Of BsonDocument).Filter.Empty
            Dim data = collection.Find(filter).ToList()

            ' Clear existing data in DataGridView
            dataGridViews.Rows.Clear()

            ' Populate the Guna2DataGridView with the fetched data
            For Each doc As BsonDocument In data
                Dim rowData As New List(Of String)()
                Dim rdata As New List(Of Object)()

                ' Retrieve the image data from MongoDB (replace "image" with the actual field name)
                If doc.Contains("image") AndAlso Not doc("image").IsBsonNull Then
                    Dim imageBytes As Byte() = doc("image").AsByteArray
                    Dim Image As Image = ByteArrayToImage(imageBytes)
                    rdata.Add(Image)
                Else
                    rowData.Add("No Image") ' Add a placeholder for missing images
                End If

                For Each element In doc.Elements
                    rowData.Add(element.Value.ToString())
                Next
                dataGridViews.Rows.Add(rowData.ToArray())
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Convert byte array to Image
    Private Function ByteArrayToImage(byteArray As Byte()) As Image
        Using ms As New MemoryStream(byteArray)
            Return Image.FromStream(ms)
        End Using
    End Function

    'Insert
    Public Function InsertAnnouncement(imagePath As String, title As String, context As String) As Boolean
        Try
            Dim imageBytes As Byte() = File.ReadAllBytes(imagePath)
            Dim collection As IMongoCollection(Of BsonDocument) = GetMongoDBCollections()

            Dim announcement As BsonDocument = New BsonDocument()
            announcement.Add("image", imageBytes)
            announcement.Add("Title", title)
            announcement.Add("Context", context)

            collection.InsertOne(announcement)

            'Load data
            Return True ' Insertion successful
        Catch ex As Exception
            Throw New Exception("Error inserting announcement  into MongoDB: " & ex.Message)
        End Try

    End Function
    Public Function GetMongoDBCollections() As IMongoCollection(Of BsonDocument)
        If Connection.collection Is Nothing Then
            Connection.ConnectToMongoDB("announcements")
        End If
        Return Connection.collection
    End Function
    Public Sub DeleteAnnouncement(announcementId As String, table As Guna.UI2.WinForms.Guna2DataGridView)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = GetMongoDBCollections()
            If ObjectId.TryParse(announcementId, Nothing) Then

                Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", ObjectId.Parse(announcementId))
                Dim data = collection.Find(filter).ToList()

                ' Delete the document matching the filter
                Dim deleteresult = collection.DeleteOne(filter)

                If deleteresult.DeletedCount > 0 Then
                    Dim announcementsControl As New AnnouncementsControl()
                    announcementsControl.SuccessfulMessage.Show("Announcement deleted successfully!")
                    loaddatas("announcements", table)
                Else
                    MessageBox.Show("Announcement not found or could not be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else
                MessageBox.Show("Invalid announcementId format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error deleting announcement: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


End Module
