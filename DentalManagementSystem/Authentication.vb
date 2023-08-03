Imports MongoDB.Bson
Imports MongoDB.Driver

Module Authentication
    Dim collection As IMongoCollection(Of BsonDocument)
    Public Function GetUserFromDatabase(username As String) As BsonDocument
        Try
            ' Create the filter directly without using Eq.
            Dim filter As FilterDefinition(Of BsonDocument) = New BsonDocument("name", username)
            Dim userDocument As BsonDocument = Connection.collection.Find(filter).FirstOrDefault()

            Return userDocument
        Catch ex As Exception
            ' Handle any exceptions here (e.g., connection issues).
            Throw New Exception("Error retrieving user data from the database: " & ex.Message)
        End Try
    End Function
End Module
