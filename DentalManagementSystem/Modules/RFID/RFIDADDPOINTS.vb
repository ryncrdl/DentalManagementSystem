Imports MongoDB.Bson
Imports MongoDB.Driver

Module RFIDADDPOINTS

    Private ReadOnly connectionString As String = "mongodb+srv://capstone12023:caps2023tone@cluster0.vwa9od5.mongodb.net"
    Private ReadOnly dbName As String = "dentalManagementSystemDB"

    Public Function GetRfidMongoCollection() As IMongoCollection(Of BsonDocument)
        Dim client As New MongoClient(connectionString)
        Dim database As IMongoDatabase = client.GetDatabase(dbName)
        Return database.GetCollection(Of BsonDocument)("rfid")
    End Function

    Public Function GetPointsMongoCollection() As IMongoCollection(Of BsonDocument)
        Dim client As New MongoClient(connectionString)
        Dim database As IMongoDatabase = client.GetDatabase(dbName)
        Return database.GetCollection(Of BsonDocument)("points")
    End Function

    Public Sub CopyDataAndAddPoints(RfidNumber As String)
        Try
            Dim rfidCollection As IMongoCollection(Of BsonDocument) = GetRfidMongoCollection()
            Dim pointsCollection As IMongoCollection(Of BsonDocument) = GetPointsMongoCollection()

            Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("RfidNumber", RfidNumber)
            Dim documents = rfidCollection.Find(filter).ToList()

            For Each doc As BsonDocument In documents
                Dim existingDoc = pointsCollection.Find(filter).FirstOrDefault()

                If existingDoc Is Nothing Then
                    doc.Add("Points", 0)
                    pointsCollection.InsertOne(doc)
                Else
                    existingDoc("Points") = 0
                    pointsCollection.ReplaceOne(filter, existingDoc)
                End If
            Next
            MessageBox.Show("Data copied to 'points' collection, and 'Points' field added successfully.")
        Catch ex As Exception
            ' Handle any exceptions that occur during the copying process
            MessageBox.Show("Error copying data and adding 'Points' field: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
