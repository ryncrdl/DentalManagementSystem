Imports MongoDB.Driver
Imports MongoDB.Bson

Public Class IneligibleTableControl
    Private collection As IMongoCollection(Of BsonDocument)
    Private changeStream As IChangeStreamCursor(Of ChangeStreamDocument(Of BsonDocument))
    Private Sub ScheduledTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub IneligibleTableControl_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub IneligibleTableControl_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Load initial data into the DataGridView
            rejectdata("rejected", RejectedTable)

            ' Connect to MongoDB and get the collection
            Connection.ConnectToMongoDB("rejected")
            Me.collection = Connection.GetMongoDBCollection()

            ' Define the change stream pipeline and options
            Dim pipeline = New EmptyPipelineDefinition(Of ChangeStreamDocument(Of BsonDocument))()
            Dim options = New ChangeStreamOptions() With {
                .FullDocument = ChangeStreamFullDocumentOption.UpdateLookup
            }

            ' Start the change stream
            changeStream = collection.Watch(pipeline, options)

            ' Start monitoring for changes in a separate task
            Task.Run(AddressOf MonitorForChanges)
        Catch ex As Exception
            ' Handle the exception here, e.g., show an error message or log it
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Async Sub MonitorForChanges()
        Await changeStream.ForEachAsync(Sub(change)
                                            ' Handle the change here
                                            ' You can update your DataGridView or perform other actions
                                            ' Access UI controls using Me.Invoke if needed
                                            If Me.InvokeRequired Then
                                                Me.Invoke(Sub()
                                                              ' Update UI controls here
                                                              rejectdata(Nothing, Nothing)
                                                          End Sub)
                                            Else
                                                ' Update UI controls directly
                                                rejectdata(Nothing, Nothing)
                                            End If
                                        End Sub)
    End Sub
    Private Sub LoadUpdatedData(sender As Object, e As EventArgs)
        ' Reload data into DataGridView with collection name "doctors"
        rejectdata("rejected", RejectedTable)
    End Sub

    Private Sub RejectedTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles RejectedTable.CellContentClick

    End Sub
End Class
