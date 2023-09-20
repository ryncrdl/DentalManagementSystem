Imports MongoDB.Bson
Imports MongoDB.Driver

Module OverviewReports

    Public Function GetOverviewCount(collectionName As String)
        Try
            Connection.ConnectToMongoDB(collectionName)
            Dim collection As IMongoCollection(Of BsonDocument) = Connection.GetMongoDBCollection()

            Dim filter = Builders(Of BsonDocument).Filter.Empty
            Dim dataLength As Long = collection.CountDocuments(filter)

            Return dataLength
        Catch ex As Exception
            MessageBox.Show("Error getting data length: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function

End Module
