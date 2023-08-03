Imports MongoDB.Bson
Imports MongoDB.Driver
Module Connection
    Public client As MongoClient
    Public database As IMongoDatabase
    Public collection As IMongoCollection(Of BsonDocument)

    Public Sub ConnectToMongoDB(collectionName As String)
        Try
            Dim connectionString As String = "mongodb+srv://capstone12023:caps2023tone@cluster0.vwa9od5.mongodb.net"
            client = New MongoClient(connectionString)
            database = client.GetDatabase("dentalManagementSystemDB")
            collection = database.GetCollection(Of BsonDocument)(collectionName)

        Catch ex As Exception
            Throw New Exception("Error connecting to MongoDB: " & ex.Message)
        End Try
    End Sub

    Public Function GetMongoDBCollection() As IMongoCollection(Of BsonDocument)
        If collection Is Nothing Then
            Throw New InvalidOperationException("MongoDB collection is not initialized.")
        End If
        Return collection
    End Function


End Module
