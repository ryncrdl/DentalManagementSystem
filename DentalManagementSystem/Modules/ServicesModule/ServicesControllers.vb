Imports MongoDB.Bson
Imports MongoDB.Driver
Imports System.IO
Imports System.Windows.Forms

Module ServicesControllers
    'Load Data
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
                Dim rowData As New List(Of Object)()

                ' Retrieve the image data from MongoDB (replace "Image" with the actual field name)
                Dim imageBytes As Byte() = doc("Image").AsByteArray ' Replace "YourImageFieldName"

                If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                    Dim image As Image = ByteArrayToImage(imageBytes)
                    rowData.Add(image)
                Else
                    rowData.Add(Nothing) ' Add a placeholder for missing images
                End If

                rowData.Add(doc("Title").AsString)
                rowData.Add(doc("Description").AsString)
                rowData.Add(doc("Price").AsDecimal)
                rowData.Add(doc("Payment").AsString)

                ' Add the row to the DataGridView
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
    Public Function InsertServices(imagePath As String, title As String, description As String, price As String, payment As String) As Boolean

        Try
            Dim imageBytes As Byte() = File.ReadAllBytes(imagePath)
            Dim collection As IMongoCollection(Of BsonDocument) = GetMongoDBCollections()

            Dim services As BsonDocument = New BsonDocument()
            services.Add("Image", imageBytes)
            services.Add("Title", title)
            services.Add("Description", description)
            services.Add("Price", price)
            services.Add("Payment", payment)


            collection.InsertOne(services)

            'Load data
            Return True ' Insertion successful
        Catch ex As Exception
            Throw New Exception("Error inserting services  into MongoDB: " & ex.Message)
        End Try

    End Function
    Public Function GetMongoDBCollections() As IMongoCollection(Of BsonDocument)
        If Connection.collection Is Nothing Then
            Connection.ConnectToMongoDB("services")
        End If
        Return Connection.collection
    End Function
    Public Sub DeleteServices(servicesId As String, table As Guna.UI2.WinForms.Guna2DataGridView)

        Try

            Dim collection As IMongoCollection(Of BsonDocument) = GetMongoDBCollections()

            ' Validate the ObjectId format of the doctorId
            If ObjectId.TryParse(servicesId, Nothing) Then
                ' Create the filter to match the document with the specified doctorId

                Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", ObjectId.Parse(servicesId))
                Dim data = collection.Find(filter).ToList()
                ' Delete the document matching the filter

                Dim deleteresult = collection.DeleteOne(filter)

                If deleteresult.DeletedCount > 0 Then
                    Dim servicesControl As New ServicesControl()
                    servicesControl.SuccessfulMessage.Show("Services deleted successfully!")
                    loaddatas("services", table)
                Else
                    MessageBox.Show("Services not found or could not be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else
                MessageBox.Show("Invalid servicesId format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error deleting doctor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


End Module
