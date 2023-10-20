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



End Module
