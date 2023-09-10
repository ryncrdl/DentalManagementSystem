Imports MongoDB.Bson
Imports MongoDB.Driver
Module ClientsControllers

    Public Sub loaddata(collectionName As String, dataGridView As Guna.UI2.WinForms.Guna2DataGridView)
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
            Connection.ConnectToMongoDB("clients")
        End If
        Return Connection.collection
    End Function
    Public Function InsertClients(Fullname As String, Username As String, Password As String, Contact As String) As Boolean

        Try
            Dim collection As IMongoCollection(Of BsonDocument) = GetMongoDBCollection()

            Dim clients As BsonDocument = New BsonDocument()
            clients.Add("fullName", Fullname)
            clients.Add("username", Username)
            clients.Add("password", Password)
            clients.Add("contactNumber", Contact)

            collection.InsertOne(clients)

            'Load data
            Return True ' Insertion successful
        Catch ex As Exception
            Throw New Exception("Error inserting clients account into MongoDB: " & ex.Message)
        End Try

    End Function
    Public Sub DELETECLIENT(clientsId As String, table As Guna.UI2.WinForms.Guna2DataGridView)

        Try
            ' Connect to MongoDB and get the collection
            Dim collection As IMongoCollection(Of BsonDocument) = GetMongoDBCollection()

            ' Validate the ObjectId format of the doctorId
            If ObjectId.TryParse(clientsId, Nothing) Then
                ' Create the filter to match the document with the specified doctorId

                Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", ObjectId.Parse(clientsId))
                Dim data = collection.Find(filter).ToList()
                ' Delete the document matching the filter

                Dim deleteresult = collection.DeleteOne(filter)

                If deleteresult.DeletedCount > 0 Then
                    Dim clientsControl As New ClientsControl()
                    clientsControl.SuccessfulMessage.Show("Clients deleted successfully!")
                    loaddata("clients", table)
                Else
                    MessageBox.Show("Clients not found or could not be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else
                MessageBox.Show("Invalid clientId format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error deleting client: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Module
