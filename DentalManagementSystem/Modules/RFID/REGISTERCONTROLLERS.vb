Imports MongoDB.Bson
Imports MongoDB.Driver
Module REGISTERCONTROLLERS

    Public Function GetMongoDBCollection() As IMongoCollection(Of BsonDocument)
        If Connection.collection Is Nothing Then
            Connection.ConnectToMongoDB("clients")
        End If
        Return Connection.collection
    End Function

    Public Function FindDocumentsByContactNumber(contactNumber As String) As List(Of BsonDocument)
        Dim collection = GetMongoDBCollection()

        ' Create a filter directly without using the builder
        Dim filter As FilterDefinition(Of BsonDocument) = New BsonDocument("contactNumber", contactNumber)

        ' Use the filter to find all documents that match the contact number
        Dim result = collection.Find(filter).ToList()

        Return result
    End Function

End Module
