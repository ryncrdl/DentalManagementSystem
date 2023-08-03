Imports MongoDB.Bson
Imports MongoDB.Driver

Module DoctorsControllers


    'Load Data
    Public Sub LoadDataIntoDataGridView(collectionName As String, dataGridView As Guna.UI2.WinForms.Guna2DataGridView)
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

    'Insert
    Public Function InsertDoctor(firstName As String, lastName As String, contact As String, email As String, address As String) As Boolean
        Try
            'LoadingForm.ShowDialog()

            Dim collection As IMongoCollection(Of BsonDocument) = GetMongoDBCollection()

            Dim doctor As BsonDocument = New BsonDocument()
            doctor.Add("FirstName", firstName)
            doctor.Add("LastName", lastName)
            doctor.Add("Contact", contact)
            doctor.Add("Email", email)
            doctor.Add("Address", address)

            collection.InsertOne(doctor)
            Return True ' Insertion successful
        Catch ex As Exception
            Throw New Exception("Error inserting doctor data into MongoDB: " & ex.Message)
            '  Finally
            ' LoadingForm.Close()
        End Try
    End Function

    'Delete 
    Public Sub DeleteDoctor(doctorId As String, DoctorsTable As Guna.UI2.WinForms.Guna2DataGridView)
        Try
            ' Connect to MongoDB and get the collection
            Dim collection As IMongoCollection(Of BsonDocument) = GetMongoDBCollection()

            ' Validate the ObjectId format of the doctorId
            If ObjectId.TryParse(doctorId, Nothing) Then
                ' Create the filter to match the document with the specified doctorId
                'Dim filter = Builders(Of BsonDocument).Filter.Eq("_id", ObjectId.Parse(doctorId))
                Dim filter = Builders(Of BsonDocument).Filter.Empty
                Dim data = collection.Find(filter).ToList()
                LoadDataIntoDataGridView("doctors", DoctorsTable)

                ' Delete the document matching the filter
                Dim deleteResult = collection.DeleteOne(filter)
                If deleteResult.DeletedCount > 0 Then
                    MessageBox.Show("Doctor deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Doctor not found or could not be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Invalid doctorId format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting doctor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadDataIntoDataGridView(v As String)
        Throw New NotImplementedException()
    End Sub

    Public Function GetMongoDBCollection() As IMongoCollection(Of BsonDocument)
        If Connection.collection Is Nothing Then
            Connection.ConnectToMongoDB("doctors")
        End If
        Return Connection.collection
    End Function





End Module
