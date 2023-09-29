Imports MongoDB.Bson
Imports MongoDB.Driver
Module REGISTERCONTROLLERS

    Public Function GetMongoDBCollection() As IMongoCollection(Of BsonDocument)
        If Connection.collection Is Nothing Then
            Connection.ConnectToMongoDB("clients")
        End If
        Return Connection.collection
    End Function

    Public Function FindFullNameByContactNumber(contactNumber As String) As String
        Dim collection = GetMongoDBCollection()

        ' Create a filter to find the document with the given contact number
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("contactNumber", contactNumber)
        Dim document = collection.Find(filter).FirstOrDefault()

        If document IsNot Nothing AndAlso document.Contains("fullName") Then
            Return document("fullName").AsString
        End If

        Return String.Empty ' Return empty string if not found
    End Function

    Public Function FindAllFullNamesByContactNumber(contactNumber As String) As List(Of String)

        Dim collection = GetMongoDBCollection()
        Dim fullNames As New List(Of String)()

        ' Create a filter to find all documents with the given contact number
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("contactNumber", contactNumber)

        ' Use the filter to find all documents that match the contact number
        Dim documents = collection.Find(filter).ToList()

        For Each doc As BsonDocument In documents
            If doc.Contains("fullName") Then
                Dim fullName As String = doc("fullName").AsString
                fullNames.Add(fullName)
            End If
        Next

        Return fullNames
    End Function


End Module
