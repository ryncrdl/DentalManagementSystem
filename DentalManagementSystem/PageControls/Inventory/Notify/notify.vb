Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class notify
    Private collection As IMongoCollection(Of BsonDocument)
    Private changeStream As IChangeStreamCursor(Of ChangeStreamDocument(Of BsonDocument))
    Private Sub notify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        coldata("approved", PendingTable)
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
                                                              LoadUpdatedData13(Nothing, Nothing)
                                                          End Sub)
                                            Else
                                                ' Update UI controls directly
                                                LoadUpdatedData13(Nothing, Nothing)
                                            End If
                                        End Sub)
    End Sub
    Private Sub LoadUpdatedData13(sender As Object, e As EventArgs)
        ' Reload data into DataGridView with collection name "doctors"
        coldata("approved", PendingTable)
    End Sub
    Private Function GetSelectedRowImage() As Dictionary(Of String, Image)
        If PendingTable.CurrentRow Is Nothing Then
            Return Nothing
        End If

        Dim selectedRowIndex As Integer = PendingTable.CurrentRow.Index
        Dim rowImage As New Dictionary(Of String, Image)()

        ' Check if the "Payment" cell contains an image
        If TypeOf PendingTable.Rows(selectedRowIndex).Cells("Payment").Value Is Image Then
            Dim paymentImage As Image = DirectCast(PendingTable.Rows(selectedRowIndex).Cells("Payment").Value, Image)
            rowImage("Payment") = paymentImage
        End If

        Return rowImage
    End Function
    Private Function GetSelectedRowData() As Dictionary(Of String, String)
        ' Check if a row is selected
        If PendingTable.CurrentRow Is Nothing Then
            Return Nothing
        End If

        ' Get the selected row index
        Dim selectedRowIndex As Integer = PendingTable.CurrentRow.Index

        ' Get the data from the selected row
        Dim rowData As New Dictionary(Of String, String)()
        rowData("ID") = PendingTable.Rows(selectedRowIndex).Cells("ID").Value.ToString()
        rowData("Clientsid") = PendingTable.Rows(selectedRowIndex).Cells("Clientsid").Value.ToString()
        rowData("Fullname") = PendingTable.Rows(selectedRowIndex).Cells("Fullname").Value.ToString()
        rowData("Contact") = PendingTable.Rows(selectedRowIndex).Cells("Contact").Value.ToString()
        rowData("Dates") = PendingTable.Rows(selectedRowIndex).Cells("Dates").Value.ToString()
        rowData("Service") = PendingTable.Rows(selectedRowIndex).Cells("Service").Value.ToString()
        rowData("Doctor") = PendingTable.Rows(selectedRowIndex).Cells("Doctor").Value.ToString()
        rowData("DocCon") = PendingTable.Rows(selectedRowIndex).Cells("DocCon").Value.ToString()

        Return rowData
    End Function

    Private Sub BtnIneligible_Click(sender As Object, e As EventArgs) Handles BtnIneligible.Click
        Me.Close()
    End Sub
End Class