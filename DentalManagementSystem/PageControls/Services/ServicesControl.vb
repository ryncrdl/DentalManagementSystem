Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class ServicesControl
    Private collection As IMongoCollection(Of BsonDocument)
    Private Sub LoadUpdatedDataS(sender As Object, e As EventArgs)
        ' Reload data into DataGridView with collection name "services"
        loaddatas("services", ServicesTable)
    End Sub
    Private Sub ServicesControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddatas("services", ServicesTable)
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
        Dim rowData As New Dictionary(Of String, String)
        rowData("Id") = ServicesTable.Rows(selectedRowIndex).Cells("Id").Value.ToString()
        rowData("Title") = ServicesTable.Rows(selectedRowIndex).Cells("Title").Value.ToString()
        rowData("Description") = ServicesTable.Rows(selectedRowIndex).Cells("Description").Value.ToString()
        rowData("Price") = ServicesTable.Rows(selectedRowIndex).Cells("Price").Value.ToString()
        rowData("Payment") = ServicesTable.Rows(selectedRowIndex).Cells("Payment").Value.ToString()








        Return rowData
    End Function




    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim AddingServices As New AddingServices()
        AddHandler AddingServices.ServicesAdded, AddressOf LoadUpdatedDataS
        AddingServices.ShowDialog()
    End Sub

    Private Sub ServicesTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ServicesTable.CellContentClick

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim rowData As Dictionary(Of String, String) = GetSelectedRowData()

        If rowData Is Nothing Then
            ErrorMessage.Show("Please select a row to edit.")
            Return
        End If

        ' Create a new instance of EditDoctorForm and pass the data to it
        Dim editServices As New EditServices(rowData, collection)
        AddHandler editServices.ServicesUpdated, AddressOf LoadUpdatedDataS
        editServices.ShowDialog()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If ServicesTable.CurrentRow Is Nothing Then
            ErrorMessage.Show("Please select a row to delete.")
            Return
        End If

        Dim selectedRowIndex As Integer = ServicesTable.CurrentRow.Index
        Dim servicesId As String = ServicesTable.Rows(selectedRowIndex).Cells("ID").Value.ToString()



        Dim result = QuestionMessage.Show("Are you sure do you want to delete this record?")
        If result = DialogResult.Yes Then

            Try
                ' Call the DeleteDoctor method from the DoctorsControllers module
                ServicesControllers.DeleteServices(servicesId, ServicesTable)
            Catch ex As Exception
                ErrorMessage.Show("Error deleting doctor: ")
            End Try
        End If
    End Sub
End Class
