Imports MongoDB.Bson
Imports MongoDB.Driver

Module RFIDINSERTCONTROLLERS
    Private ReadOnly connectionString As String = "mongodb+srv://capstone12023:caps2023tone@cluster0.vwa9od5.mongodb.net"
    Private ReadOnly dbName As String = "dentalManagementSystemDB"

    Public Function GetRfidMongoCollection() As IMongoCollection(Of BsonDocument)
        Dim client As New MongoClient(connectionString)
        Dim database As IMongoDatabase = client.GetDatabase(dbName)
        Return database.GetCollection(Of BsonDocument)("rfid")
    End Function

    Public Function Insertrfid1(Contact As String, Fullname As String, RFIDNUM As String, service As String) As Boolean
        Try
            ' Get the "rfid" collection
            Dim collection As IMongoCollection(Of BsonDocument) = GetRfidMongoCollection()

            ' Create a new document to insert into the "rfid" collection
            Dim rfid As BsonDocument = New BsonDocument()
            rfid.Add("Contact", Contact)
            rfid.Add("Fullname", Fullname)
            rfid.Add("RfidNumber", RFIDNUM)
            rfid.Add("Services", service)

            ' Insert the document into the "rfid" collection
            collection.InsertOne(rfid)

            ' Return true to indicate a successful insertion
            Return True
        Catch ex As Exception
            ' Handle any exceptions that occur during the insertion process
            Throw New Exception("Error inserting RFID NUMBER into MongoDB: " & ex.Message)
        End Try
    End Function
End Module
