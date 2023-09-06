Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class ServicesControl
    Private collection As IMongoCollection(Of BsonDocument)
    Private Sub LoadUpdatedData(sender As Object, e As EventArgs)
        ' Reload data into DataGridView with collection name "services"
        LoadDataInDataGridView("services", ServicesTable)
    End Sub
    Private Sub ServicesControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataInDataGridView("services", ServicesTable)

        Connection.ConnectToMongoDB("services")
        Me.collection = Connection.GetMongoDBCollection()
    End Sub

    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel2.Click

    End Sub
    Private Function GetSelectedRowData() As Dictionary(Of String, String)
        ' Check if a row is selected
        If ServicesTable.CurrentRow Is Nothing Then
            Return Nothing
        End If

        ' Get the selected row index
        Dim selectedRowIndex As Integer = ServicesTable.CurrentRow.Index

        ' Get the data from the selected row
        Dim rowData As New Dictionary(Of String, String)()
        rowData("ID") = ServicesTable.Rows(selectedRowIndex).Cells("ID").Value.ToString()
        rowData("Title") = ServicesTable.Rows(selectedRowIndex).Cells("Title").Value.ToString()
        rowData("Description") = ServicesTable.Rows(selectedRowIndex).Cells("Description").Value.ToString()
        rowData("Price") = ServicesTable.Rows(selectedRowIndex).Cells("Price").Value.ToString()


        Return rowData
    End Function




    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim AddingServicesForm As New AddingServices()
        AddHandler AddingServicesForm.ServicesAdded, AddressOf LoadUpdatedData
        AddingServices.ShowDialog()
    End Sub

    Private Sub ServicesTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ServicesTable.CellContentClick

    End Sub
End Class
