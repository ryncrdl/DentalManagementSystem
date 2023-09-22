Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class ScheduledTableControl
    Private collection As IMongoCollection(Of BsonDocument)
    Private changeStream As IChangeStreamCursor(Of ChangeStreamDocument(Of BsonDocument))



    Private Sub ScheduledTableControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        colldata("approved", ScheduledTable)
        Connection.ConnectToMongoDB("approved")

        Me.collection = Connection.GetMongoDBCollection()
        Dim pipeline = New EmptyPipelineDefinition(Of ChangeStreamDocument(Of BsonDocument))()
        Dim options = New ChangeStreamOptions() With {
            .FullDocument = ChangeStreamFullDocumentOption.UpdateLookup
        }
        changeStream = collection.Watch(pipeline, options)

        ' Start monitoring for changes in a separate task
        Task.Run(AddressOf MonitorForChanges)
    End Sub
    Private Async Sub MonitorForChanges()
        Await changeStream.ForEachAsync(Sub(change)
                                            ' Handle the change here
                                            ' You can update your DataGridView or perform other actions
                                            ' Access UI controls using Me.Invoke if needed
                                            If Me.InvokeRequired Then
                                                Me.Invoke(Sub()
                                                              ' Update UI controls here
                                                              LoadUpdatedData(Nothing, Nothing)
                                                          End Sub)
                                            Else
                                                ' Update UI controls directly
                                                LoadUpdatedData(Nothing, Nothing)
                                            End If
                                        End Sub)
    End Sub
    Private Sub LoadUpdatedData(sender As Object, e As EventArgs)
        ' Reload data into DataGridView with collection name "doctors"
        colldata("approved", ScheduledTable)
    End Sub
    Private Sub ScheduledTable_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Function GetSelectedRowImage() As Dictionary(Of String, Image)
        If ScheduledTable.CurrentRow Is Nothing Then
            Return Nothing
        End If

        Dim selectedRowIndex As Integer = ScheduledTable.CurrentRow.Index
        Dim rowImage As New Dictionary(Of String, Image)()

        ' Check if the "Payment" cell contains an image
        If TypeOf ScheduledTable.Rows(selectedRowIndex).Cells("Payment").Value Is Image Then
            Dim paymentImage As Image = DirectCast(ScheduledTable.Rows(selectedRowIndex).Cells("Payment").Value, Image)
            rowImage("Payment") = paymentImage
        End If

        Return rowImage
    End Function

    Private Function GetSelectedRowData() As Dictionary(Of String, String)
        ' Check if a row is selected
        If ScheduledTable.CurrentRow Is Nothing Then
            Return Nothing
        End If

        ' Get the selected row index
        Dim selectedRowIndex As Integer = ScheduledTable.CurrentRow.Index

        ' Get the data from the selected row
        Dim rowData As New Dictionary(Of String, String)()
        rowData("ID") = ScheduledTable.Rows(selectedRowIndex).Cells("ID").Value.ToString()
        rowData("Clientsid") = ScheduledTable.Rows(selectedRowIndex).Cells("Clientsid").Value.ToString()
        rowData("Fullname") = ScheduledTable.Rows(selectedRowIndex).Cells("Fullname").Value.ToString()
        rowData("Contact") = ScheduledTable.Rows(selectedRowIndex).Cells("Contact").Value.ToString()
        rowData("Dates") = ScheduledTable.Rows(selectedRowIndex).Cells("Dates").Value.ToString()
        rowData("Service") = ScheduledTable.Rows(selectedRowIndex).Cells("Service").Value.ToString()
        rowData("Doctor") = ScheduledTable.Rows(selectedRowIndex).Cells("Doctor").Value.ToString()


        Return rowData
    End Function
    Private Sub PendingTable_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub PendingTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ScheduledTable.CellContentClick

    End Sub

    Private Sub ScheduledTable_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ScheduledTable.CellContentDoubleClick
        Dim rowData As Dictionary(Of String, String) = GetSelectedRowData()
        Dim rowImage As Dictionary(Of String, Image) = GetSelectedRowImage()
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Get the data from the selected row
            Dim selectedRow = ScheduledTable.Rows(e.RowIndex)

            ' Create and show the DetailForm
            Dim completerejectform As New CompleteReject(rowData, rowImage, collection) ' Pass any necessary data to the DetailForm constructor
            completerejectform.ShowDialog()
        End If
    End Sub
End Class
