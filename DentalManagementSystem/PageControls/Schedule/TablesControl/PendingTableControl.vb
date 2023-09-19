Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class PendingTableControl
    Private collection As IMongoCollection(Of BsonDocument)
    Private Sub ScheduledTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub ScheduledTable_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles PendingTable.CellContentClick

    End Sub

    Private Sub PendingTableControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        coldata("appointments", PendingTable)
        Connection.ConnectToMongoDB("appointments")
        Me.collection = Connection.GetMongoDBCollection()
    End Sub
    Private Sub LoadUpdatedData(sender As Object, e As EventArgs)
        ' Reload data into DataGridView with collection name "doctors"
        coldata("appointments", PendingTable)
    End Sub
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


        Return rowData
    End Function

    Private Sub PendingTable_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles PendingTable.CellContentDoubleClick
        Dim rowData As Dictionary(Of String, String) = GetSelectedRowData()
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Get the data from the selected row
            Dim selectedRow = PendingTable.Rows(e.RowIndex)

            ' Create and show the DetailForm
            Dim acceptrejectform As New AcceptReject(rowData, collection) ' Pass any necessary data to the DetailForm constructor
            acceptrejectform.ShowDialog()
        End If
    End Sub
End Class
