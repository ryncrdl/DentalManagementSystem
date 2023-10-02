Imports MongoDB.Bson
Imports MongoDB.Driver

Module RFIDINSERTCONTROLLERS
    Private ReadOnly connectionString As String = "mongodb+srv://capstone12023:caps2023tone@cluster0.vwa9od5.mongodb.net"
    Private ReadOnly dbName As String = "dentalManagementSystemDB"

    Public Function GetClientsMongoCollection() As IMongoCollection(Of BsonDocument)
        Dim client As New MongoClient(connectionString)
        Dim database As IMongoDatabase = client.GetDatabase(dbName)
        Return database.GetCollection(Of BsonDocument)("clients")
    End Function

    Public Function IsRfidNumberUnique(RFIDNUM As String) As Boolean
        Dim collection As IMongoCollection(Of BsonDocument) = GetClientsMongoCollection()

        Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("rfidnumber", RFIDNUM)

        Return Not collection.Find(filter).Any()
    End Function

    Public Function AddRfidNumberToClients(RFIDNUM As String, contactNumber As String, fullName As String) As Boolean
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = GetClientsMongoCollection()

            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.And(
            Builders(Of BsonDocument).Filter.Eq(Of String)("contactNumber", contactNumber),
            Builders(Of BsonDocument).Filter.Eq(Of String)("fullName", fullName)
        )
            Dim update As UpdateDefinition(Of BsonDocument) = Builders(Of BsonDocument).Update.Set(Of String)("rfidNumber", RFIDNUM)
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
