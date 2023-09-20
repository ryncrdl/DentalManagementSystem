Imports MongoDB.Driver
Imports MongoDB.Bson

Public Class IneligibleTableControl
    Private collection As IMongoCollection(Of BsonDocument)
    Private Sub ScheduledTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles RejectedTable.CellContentClick

    End Sub

    Private Sub IneligibleTableControl_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub IneligibleTableControl_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        rejectdata("rejected", RejectedTable)
        Connection.ConnectToMongoDB("rejected")
        Me.collection = Connection.GetMongoDBCollection()
    End Sub
End Class
