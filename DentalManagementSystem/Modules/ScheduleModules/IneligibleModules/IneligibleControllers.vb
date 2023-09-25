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

            For Each doc As BsonDocument In data
                Dim rowData As New List(Of Object)() ' Use Object instead of String

                For Each element In doc.Elements
                    If element.Name = "Proof of Payment" Then
                        If Not String.IsNullOrEmpty(element.Value) Then
                            Dim imageBase64 As String = element.Value.ToString()
                            Try
                                Dim imageBytes As Byte() = Convert.FromBase64String(imageBase64)
                                Using stream As New System.IO.MemoryStream(imageBytes)
                                    Dim image As Image = Image.FromStream(stream)
                                    rowData.Add(image)
                                End Using
                            Catch ex As Exception
                                MessageBox.Show("Error decoding base64 string: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        Else
                            ' If the base64 string is empty, add a placeholder or leave it empty
                            rowData.Add(Nothing)
                        End If
                    Else
                        rowData.Add(element.Value.ToString())
                    End If
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
