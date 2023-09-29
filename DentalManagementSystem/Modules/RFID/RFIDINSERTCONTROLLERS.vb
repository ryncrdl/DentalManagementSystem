Imports MongoDB.Bson
Imports MongoDB.Driver

Module RFIDINSERTCONTROLLERS
    Public Function GetMongoDBCollection() As IMongoCollection(Of BsonDocument)
        If Connection.collection Is Nothing Then
            Connection.ConnectToMongoDB("rfid")
        End If
        Return Connection.collection
    End Function
    Public Function Insertrfid(Contact As String, Fullname As String, RFIDNUM As String) As Boolean

        Try
            Dim collection As IMongoCollection(Of BsonDocument) = GetMongoDBCollection()

            Dim rfid As BsonDocument = New BsonDocument()
            rfid.Add("Contact", Contact)
            rfid.Add("Fullname", Fullname)
            rfid.Add("RfidNumber", RFIDNUM)


            collection.InsertOne(rfid)

            'Load data
            Return True ' Insertion successful
        Catch ex As Exception
            Throw New Exception("Error inserting RFID NUMBER into MongoDB: " & ex.Message)
        End Try

    End Function
End Module
