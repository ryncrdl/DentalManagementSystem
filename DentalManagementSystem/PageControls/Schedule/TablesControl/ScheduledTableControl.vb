Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class ScheduledTableControl
    Private collection As IMongoCollection(Of BsonDocument)
    Private Sub ScheduledTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub ScheduledTableControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        colldata("approved", ScheduledTable)
        Connection.ConnectToMongoDB("approved")
        Me.collection = Connection.GetMongoDBCollection()
    End Sub

    Private Sub ScheduledTable_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles ScheduledTable.CellContentClick

    End Sub
End Class
