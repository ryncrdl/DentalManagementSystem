Imports MongoDB.Bson
Imports MongoDB.Driver

Module AdminControllers
    Dim collection As IMongoCollection(Of BsonDocument)
    Public Sub InsertDataIntoMongoDB(admin As BsonDocument)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = Connection.GetMongoDBCollection()

            If collection IsNot Nothing Then
                collection.InsertOne(admin)
            Else
                Throw New Exception("MongoDB collection is not initialized.")
            End If
        Catch ex As Exception
            Throw New Exception("Error inserting data into MongoDB: " & ex.Message)
        End Try
    End Sub
End Module
