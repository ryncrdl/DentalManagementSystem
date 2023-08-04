Imports MongoDB.Bson
Imports MongoDB.Driver


Public Class DoctorsControl
    Private collection As IMongoCollection(Of BsonDocument)


    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim createDoctorForm As New CreateDoctorForm()
        AddHandler createDoctorForm.DoctorAdded, AddressOf LoadUpdatedData
        createDoctorForm.ShowDialog()
    End Sub

    Private Sub LoadUpdatedData(sender As Object, e As EventArgs)
        ' Reload data into DataGridView with collection name "doctors"
        LoadDataIntoDataGridView("doctors", DoctorsTable)
    End Sub

    Private Sub DoctorsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoDataGridView("doctors", DoctorsTable)
        Connection.ConnectToMongoDB("doctors")
        Me.collection = Connection.GetMongoDBCollection()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If DoctorsTable.CurrentRow Is Nothing Then
            ErrorMessage.Show("Please select a row to delete.")
            Return
        End If

        Dim selectedRowIndex As Integer = DoctorsTable.CurrentRow.Index
        Dim doctorId As String = DoctorsTable.Rows(selectedRowIndex).Cells("ID").Value.ToString()

        Dim result = QuestionMessage.Show("Are you sure do you want to delete this record?")
        If result = DialogResult.Yes Then
            Try
                ' Call the DeleteDoctor method from the DoctorsControllers module
                DoctorsControllers.DeleteDoctor(doctorId, DoctorsTable)
            Catch ex As Exception
                ErrorMessage.Show("Error deleting doctor: ")
            End Try
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        ' Get the selected row data
        Dim rowData As Dictionary(Of String, String) = GetSelectedRowData()

        If rowData Is Nothing Then
            ErrorMessage.Show("Please select a row to edit.")
            Return
        End If

        ' Create a new instance of EditDoctorForm and pass the data to it
        Dim editDoctorForm As New EditDoctorForm(rowData, collection)
        AddHandler editDoctorForm.DoctorUpdated, AddressOf LoadUpdatedData
        editDoctorForm.ShowDialog()
    End Sub

    Private Function GetSelectedRowData() As Dictionary(Of String, String)
        ' Check if a row is selected
        If DoctorsTable.CurrentRow Is Nothing Then
            Return Nothing
        End If

        ' Get the selected row index
        Dim selectedRowIndex As Integer = DoctorsTable.CurrentRow.Index

        ' Get the data from the selected row
        Dim rowData As New Dictionary(Of String, String)()
        rowData("ID") = DoctorsTable.Rows(selectedRowIndex).Cells("ID").Value.ToString()
        rowData("FirstName") = DoctorsTable.Rows(selectedRowIndex).Cells("FirstName").Value.ToString()
        rowData("LastName") = DoctorsTable.Rows(selectedRowIndex).Cells("LastName").Value.ToString()
        rowData("Contact") = DoctorsTable.Rows(selectedRowIndex).Cells("Contact").Value.ToString()
        rowData("Email") = DoctorsTable.Rows(selectedRowIndex).Cells("Email").Value.ToString()
        rowData("Address") = DoctorsTable.Rows(selectedRowIndex).Cells("Address").Value.ToString()

        Return rowData
    End Function


End Class
