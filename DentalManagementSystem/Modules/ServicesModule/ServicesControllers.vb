Imports MongoDB.Bson
Imports MongoDB.Driver
Module ServicesControllers
    'Load Data
    Public Sub LoadDataInDataGridView(collectionName As String, dataGridViews As Guna.UI2.WinForms.Guna2DataGridView)
        Try
            ' Connect to MongoDB and get the collection
            Connection.ConnectToMongoDB(collectionName)
            Dim collection As IMongoCollection(Of BsonDocument) = Connection.GetMongoDBCollection()

            ' Fetch data from MongoDB
            Dim filter = Builders(Of BsonDocument).Filter.Empty
            Dim data = collection.Find(filter).ToList()

            ' Clear existing data in DataGridView
            dataGridViews.Rows.Clear()

            ' Populate the Guna2DataGridView with the fetched data
            For Each doc As BsonDocument In data
                Dim rowData As New List(Of String)()
                For Each element In doc.Elements
                    rowData.Add(element.Value.ToString())
                Next
                dataGridViews.Rows.Add(rowData.ToArray())
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Insert
    Public Function InsertServices(title As String, description As String, price As String) As Boolean

        Try
            Dim collection As IMongoCollection(Of BsonDocument) = GetMongoDBCollections()

            Dim services As BsonDocument = New BsonDocument()
            services.Add("Title", title)
            services.Add("Description", description)
            services.Add("Price", price)


            collection.InsertOne(services)

            'Load data
            Return True ' Insertion successful
        Catch ex As Exception
            Throw New Exception("Error inserting services  into MongoDB: " & ex.Message)
        End Try

    End Function
    Public Function GetMongoDBCollections() As IMongoCollection(Of BsonDocument)
        If Connection.collection Is Nothing Then
            Connection.ConnectToMongoDB("services")
        End If
        Return Connection.collection
    End Function

End Module
