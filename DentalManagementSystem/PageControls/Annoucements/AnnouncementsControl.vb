Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class AnnouncementsControl
    Private collection As IMongoCollection(Of BsonDocument)
    Private Sub LoadUpdatedDataS(sender As Object, e As EventArgs)
        AnnouncementsControllers.loaddatas("announcements", AnnouncementsTable)
    End Sub
    Private Sub AnnouncementsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AnnouncementsControllers.loaddatas("announcements", AnnouncementsTable)
        Connection.ConnectToMongoDB("announcements")
        Me.collection = Connection.GetMongoDBCollection()
    End Sub

    Private Function GetSelectedRowData() As Dictionary(Of String, String)
        ' Check if a row is selected
        If AnnouncementsTable.CurrentRow Is Nothing Then
            Return Nothing
        End If

        ' Get the selected row index
        Dim selectedRowIndex As Integer = AnnouncementsTable.CurrentRow.Index

        ' Get the data from the selected row
        Dim rowData As New Dictionary(Of String, String)
        rowData("ID") = AnnouncementsTable.Rows(selectedRowIndex).Cells("ID").Value.ToString()
        rowData("Title") = AnnouncementsTable.Rows(selectedRowIndex).Cells("Title").Value.ToString()
        rowData("Context") = AnnouncementsTable.Rows(selectedRowIndex).Cells("Context").Value.ToString()
        Return rowData
    End Function

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim AddingAnnouncement As New AddingAnnouncements()
        AddHandler AddingAnnouncement.AnnouncementAdded, AddressOf LoadUpdatedDataS
        AddingAnnouncement.ShowDialog()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim rowData As Dictionary(Of String, String) = GetSelectedRowData()

        If rowData Is Nothing Then
            ErrorMessage.Show("Please select a row to edit.")
            Return
        End If

        ' Create a new instance of EditDoctorForm and pass the data to it
        Dim editAnnouncement As New EditAnnouncements(rowData, collection)
        AddHandler editAnnouncement.AnnouncementUpdated, AddressOf LoadUpdatedDataS
        editAnnouncement.ShowDialog()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If AnnouncementsTable.CurrentRow Is Nothing Then
            ErrorMessage.Show("Please select a row to delete.")
            Return
        End If

        Dim selectedRowIndex As Integer = AnnouncementsTable.CurrentRow.Index
        Dim announcementId As String = AnnouncementsTable.Rows(selectedRowIndex).Cells("ID").Value.ToString()

        Dim result = QuestionMessage.Show("Are you sure do you want to delete this record?")
        If result = DialogResult.Yes Then

            Try
                AnnouncementsControllers.DeleteAnnouncement(announcementId, AnnouncementsTable)
            Catch ex As Exception
                ErrorMessage.Show("Error deleting announcements: ")
            End Try
        End If
    End Sub
End Class
