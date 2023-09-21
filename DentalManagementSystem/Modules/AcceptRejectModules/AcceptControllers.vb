Imports MongoDB.Bson
Imports MongoDB.Driver

Module AcceptControllers
    Private client As MongoClient
    Private database As IMongoDatabase

    Sub New()
        ' Initialize the MongoDB client and database
        Try
            client = New MongoClient("mongodb+srv://capstone12023:caps2023tone@cluster0.vwa9od5.mongodb.net")
            database = client.GetDatabase("dentalManagementSystemDB")
        Catch ex As Exception
            ' Handle any exceptions related to MongoDB connection here
            MessageBox.Show("Failed to connect to MongoDB: " & ex.Message)
        End Try
    End Sub

    Sub TransferDataOneByOne(appointments As String, approved As String)
        ' Get references to the source and destination collections
        Dim sourceCollection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(appointments)
        Dim destCollection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(approved)

        ' Retrieve one document from the source collection at a time and transfer it
        Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Empty
        Dim dataToTransfer As BsonDocument

        Try

            dataToTransfer = sourceCollection.FindOneAndDelete(filter)
                If dataToTransfer IsNot Nothing Then
                    destCollection.InsertOne(dataToTransfer)

                End If

        Catch ex As Exception
            ' Handle any exceptions related to MongoDB operations here
            MessageBox.Show("Failed to transfer data: " & ex.Message)
        End Try
    End Sub
End Module
