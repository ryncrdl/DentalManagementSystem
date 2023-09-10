﻿Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class ClientsControl
    Private collection As IMongoCollection(Of BsonDocument)
    Private Sub ClientsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata("clients", ClientsTable)
        Connection.ConnectToMongoDB("clients")
        Me.collection = Connection.GetMongoDBCollection()
    End Sub
    Private Sub LoadUpdatedData(sender As Object, e As EventArgs)
        ' Reload data into DataGridView with collection name "doctors"
        loaddata("clients", ClientsTable)
    End Sub

    Private Sub ClientsTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ClientsTable.CellContentClick

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim rowData As Dictionary(Of String, String) = GetSelectedRowData()

        If rowData Is Nothing Then
            ErrorMessage.Show("Please select a row to edit.")
            Return
        End If

        ' Create a new instance of EditDoctorForm and pass the data to 
        Dim editclients As New EditClients(rowData, collection)
        AddHandler editclients.clientsupdated, AddressOf LoadUpdatedData
        editclients.ShowDialog()
    End Sub
    Private Function GetSelectedRowData() As Dictionary(Of String, String)
        ' Check if a row is selected
        If ClientsTable.CurrentRow Is Nothing Then
            Return Nothing
        End If

        ' Get the selected row index
        Dim selectedRowIndex As Integer = ClientsTable.CurrentRow.Index

        ' Get the data from the selected row
        Dim rowData As New Dictionary(Of String, String)()
        rowData("ID") = ClientsTable.Rows(selectedRowIndex).Cells("ID").Value.ToString()
        rowData("Fullname") = ClientsTable.Rows(selectedRowIndex).Cells("Fullname").Value.ToString()
        rowData("Username") = ClientsTable.Rows(selectedRowIndex).Cells("Username").Value.ToString()
        rowData("Password") = ClientsTable.Rows(selectedRowIndex).Cells("Password").Value.ToString()
        rowData("Contact") = ClientsTable.Rows(selectedRowIndex).Cells("Contact").Value.ToString()


        Return rowData
    End Function

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If ClientsTable.CurrentRow Is Nothing Then
            ErrorMessage.Show("Please select a row to delete.")
            Return
        End If

        Dim selectedRowIndex As Integer = ClientsTable.CurrentRow.Index
        Dim clientsId As String = ClientsTable.Rows(selectedRowIndex).Cells("ID").Value.ToString()

        Dim result = QuestionMessage.Show("Are you sure do you want to delete this record?")
        If result = DialogResult.Yes Then

            Try
                ' Call the DeleteDoctor method from the DoctorsControllers module
                ClientsControllers.DELETECLIENT(clientsId, ClientsTable)
            Catch ex As Exception
                ErrorMessage.Show("Error deleting doctor: ")
            End Try
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim CreateClients As New CreateClients()
        AddHandler CreateClients.ClientAdded, AddressOf LoadUpdatedData
        CreateClients.ShowDialog()
    End Sub
End Class
