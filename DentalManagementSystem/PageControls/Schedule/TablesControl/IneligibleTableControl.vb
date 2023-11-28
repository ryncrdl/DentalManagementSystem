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
        rejectdata("rejected", RejectedTable)
        Connection.ConnectToMongoDB("rejected")

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
                                                              LoadUpdatedData1(Nothing, Nothing)
                                                          End Sub)
                                            Else
                                                ' Update UI controls directly
                                                LoadUpdatedData1(Nothing, Nothing)
                                            End If
                                        End Sub)
    End Sub
    Private Sub LoadUpdatedData1(sender As Object, e As EventArgs)
        ' Reload data into DataGridView with collection name "doctors"
        rejectdata("rejected", RejectedTable)
    End Sub

    Private Sub RejectedTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles RejectedTable.CellContentClick

    End Sub

    Private Sub RejectedTable_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles RejectedTable.CellDoubleClick

    End Sub

    Private Sub RejectedTable_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles RejectedTable.CellContentDoubleClick
        Dim rowData As Dictionary(Of String, String) = GetSelectedRowData()
        Dim rowImage As Dictionary(Of String, Image) = GetSelectedRowImage()
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Get the data from the selected row
            Dim selectedRow = RejectedTable.Rows(e.RowIndex)

            ' Create and show the DetailForm
            Dim delete As New delete(rowData, rowImage, collection)
            delete.ShowDialog()
        End If
    End Sub
    Private Function GetSelectedRowData() As Dictionary(Of String, String)
        ' Check if a row is selected
        If RejectedTable.CurrentRow Is Nothing Then
            Return Nothing
        End If

        ' Get the selected row index
        Dim selectedRowIndex As Integer = RejectedTable.CurrentRow.Index

        ' Get the data from the selected row
        Dim rowData As New Dictionary(Of String, String)()
        rowData("ID") = RejectedTable.Rows(selectedRowIndex).Cells("ID").Value.ToString()
        rowData("Clientsid") = RejectedTable.Rows(selectedRowIndex).Cells("Clientsid").Value.ToString()
        rowData("Fullname") = RejectedTable.Rows(selectedRowIndex).Cells("Fullname").Value.ToString()
        rowData("Contact") = RejectedTable.Rows(selectedRowIndex).Cells("Contact").Value.ToString()
        rowData("Dates") = RejectedTable.Rows(selectedRowIndex).Cells("Dates").Value.ToString()
        rowData("Service") = RejectedTable.Rows(selectedRowIndex).Cells("Service").Value.ToString()
        rowData("Doctor") = RejectedTable.Rows(selectedRowIndex).Cells("Doctor").Value.ToString()

        Return rowData
    End Function
    Private Function GetSelectedRowImage() As Dictionary(Of String, Image)
        If RejectedTable.CurrentRow Is Nothing Then
            Return Nothing
        End If

        Dim selectedRowIndex As Integer = RejectedTable.CurrentRow.Index
        Dim rowImage As New Dictionary(Of String, Image)()

        ' Check if the "Payment" cell contains an image
        If TypeOf RejectedTable.Rows(selectedRowIndex).Cells("Payment").Value Is Image Then
            Dim paymentImage As Image = DirectCast(RejectedTable.Rows(selectedRowIndex).Cells("Payment").Value, Image)
            rowImage("Payment") = paymentImage
        End If

        Return rowImage
    End Function
End Class
