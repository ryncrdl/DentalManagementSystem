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
            ' Get the "rfid" and "points" collections
            Dim rfidCollection As IMongoCollection(Of BsonDocument) = GetRfidMongoCollection()
            Dim pointsCollection As IMongoCollection(Of BsonDocument) = GetPointsMongoCollection()

            ' Create a filter to find all documents with the given RfidNumber
            Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("RfidNumber", RfidNumber)

            ' Find all documents that match the filter in the "rfid" collection
            Dim documents = rfidCollection.Find(filter).ToList()

            For Each doc As BsonDocument In documents
                ' Check if the document already exists in the "points" collection
                Dim existingDoc = pointsCollection.Find(filter).FirstOrDefault()

                If existingDoc Is Nothing Then
                    ' If the document doesn't exist in the "points" collection, add it
                    doc.Add("Points", 0)
                    pointsCollection.InsertOne(doc)
                Else
                    ' If the document already exists in the "points" collection, update the "Points" field to 0
                    existingDoc("Points") = 0
                    pointsCollection.ReplaceOne(filter, existingDoc)
                End If
            Next

            ' Display a message or perform any other actions as needed
            MessageBox.Show("Data copied to 'points' collection, and 'Points' field added successfully.")
        Catch ex As Exception
            ' Handle any exceptions that occur during the copying process
            MessageBox.Show("Error copying data and adding 'Points' field: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
