Imports MongoDB.Bson
Imports MongoDB.Driver

Module IneligibleControllers
    Public Sub rejectdata(collectionName As String, dataGridView As Guna.UI2.WinForms.Guna2DataGridView)
        Try
            ' Connect to MongoDB and get the collection
            Connection.ConnectToMongoDB(collectionName)
            Dim collection As IMongoCollection(Of BsonDocument) = Connection.GetMongoDBCollection()

            ' Fetch data from MongoDB
            Dim filter = Builders(Of BsonDocument).Filter.Empty
            Dim data = collection.Find(filter).ToList()

            ' Clear existing data in DataGridView
            dataGridView.Rows.Clear()

            ' Populate the Guna2DataGridView with the fetched data
            For Each doc As BsonDocument In data
                Dim rowData As New List(Of String)()
                For Each element In doc.Elements
                    rowData.Add(element.Value.ToString())
                Next
                dataGridView.Rows.Add(rowData.ToArray())
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function GetMongoDBCollection() As IMongoCollection(Of BsonDocument)
        If Connection.collection Is Nothing Then
            Connection.ConnectToMongoDB("rejected")
        End If
        Return Connection.collection
    End Function
End Module
