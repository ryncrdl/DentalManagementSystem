Imports MongoDB.Bson
Imports MongoDB.Driver

Module RFIDADDPOINTS

    Private ReadOnly connectionString As String = "mongodb+srv://capstone12023:caps2023tone@cluster0.vwa9od5.mongodb.net"
    Private ReadOnly dbName As String = "dentalManagementSystemDB"

    Public Function GetClientCollection1() As IMongoCollection(Of BsonDocument)
        Dim client As New MongoClient(connectionString)
        Dim database As IMongoDatabase = client.GetDatabase(dbName)
        Return database.GetCollection(Of BsonDocument)("clients")
    End Function

    Public Function AddPoints(RfidNumber As String) As Boolean
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = GetClientCollection1()

            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.And(
            Builders(Of BsonDocument).Filter.Eq(Of String)("rfidNumber", RfidNumber)
        )
            Dim points As Double = 1.5
            Dim update As UpdateDefinition(Of BsonDocument) = Builders(Of BsonDocument).Update.Inc(Of Double)("points", points)
            Dim result As UpdateResult = collection.UpdateOne(filter, update)

            If (result.ModifiedCount > 0) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function ClearPoints(rfidNumber As String, points As String) As Boolean
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = GetClientCollection1()

            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.And(
            Builders(Of BsonDocument).Filter.Eq(Of String)("rfidNumber", rfidNumber)
            )
            Dim update As UpdateDefinition(Of BsonDocument) = Builders(Of BsonDocument).Update.Set(Of String)("points", points)
            Dim result As UpdateResult = collection.UpdateOne(filter, update)

            If result.ModifiedCount > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
End Module
