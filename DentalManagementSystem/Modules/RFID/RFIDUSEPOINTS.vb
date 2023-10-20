Imports MongoDB.Bson
Imports MongoDB.Driver
Module RFIDUSEPOINTS
    Public Function GetMongoDBCollection12() As IMongoCollection(Of BsonDocument)
        If Connection.collection Is Nothing Then
            Connection.ConnectToMongoDB("clients")
        End If
        Return Connection.collection
    End Function
    Public Function findallByRfid(rfidNumber As String) As (String, String, Integer)
        Dim collection = GetMongoDBCollection12() ' Replace with the actual name of the "CLIENTs" collection

        ' Define a filter based on the rfidNumber
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("rfidNumber", rfidNumber)

        ' Project the fields you need
        Dim projection = Builders(Of BsonDocument).Projection.Include("rfidNumber").Include("fullName").Include("points")

        ' Find the document that matches the filter and project the fields
        Dim document = collection.Find(filter).Project(projection).FirstOrDefault()

        If document IsNot Nothing Then
            Dim RFID As String = document("rfidNumber").AsString
            Dim fullName As String = document("fullName").AsString
            Dim points As Integer = document("points").AsInt32
            Return (RFID, fullName, points)
        Else
            ' Return a default value or handle the case where no matching document is found
            Return ("", "", 0)
        End If
    End Function

    Public Function FindAllRfidnumberByrfid(rfidNumber As String) As List(Of String)

        Dim collection = GetMongoDBCollection12()
        Dim fullNames As New List(Of String)()

        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("rfidNumber", rfidNumber)

        Dim documents = collection.Find(filter).ToList()

        For Each doc As BsonDocument In documents
            If doc.Contains("fullName") Then
                Dim fullName As String = doc("fullName").AsString
                fullNames.Add(fullName)
            End If
        Next

        Return fullNames
    End Function
    Public Function FindAllfullnameByrfid(rfidNumber As String) As List(Of String)

        Dim collection = GetMongoDBCollection12()
        Dim fullNames As New List(Of String)()

        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("rfidNumber", rfidNumber)

        Dim documents = collection.Find(filter).ToList()

        For Each doc As BsonDocument In documents
            If doc.Contains("fullName") Then
                Dim fullName As String = doc("fullName").AsString
                fullNames.Add(fullName)
            End If
        Next

        Return fullNames
    End Function
    Public Function FindAllpointsByrfid(rfidNumber As String) As List(Of Integer)
        Dim collection = GetMongoDBCollection12()
        Dim pointsList As New List(Of Integer)()

        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("rfidNumber", rfidNumber)

        Dim projection = Builders(Of BsonDocument).Projection.Include("points")

        Dim documents = collection.Find(filter).Project(projection).ToList()

        For Each doc As BsonDocument In documents
            If doc.Contains("points") Then
                Dim points As Double = doc("points").AsDouble
                pointsList.Add(CInt(points))

            End If
        Next

        Return pointsList
    End Function

    Public Function FindAllrfidByrfid(rfidNumber As String) As List(Of String)

        Dim collection = GetMongoDBCollection12()
        Dim fullNames As New List(Of String)()

        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("rfidNumber", rfidNumber)

        Dim documents = collection.Find(filter).ToList()

        For Each doc As BsonDocument In documents
            If doc.Contains("rfidNumber") Then
                Dim fullName As String = doc("rfidNumber").AsString
                fullNames.Add(fullName)
            End If
        Next

        Return fullNames
    End Function
End Module
