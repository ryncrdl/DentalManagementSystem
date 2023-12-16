Imports MongoDB.Driver
Imports MongoDB.Bson
Imports System.Threading.Tasks
Public Class OverviewControl
    Private Sub DashboardControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateCounts()
        StartChangeStreamListeners()
        'NoOfAppointments.Text = GetOverviewCount("appointments")
        'DoctorsAvailable.Text = GetOverviewCount("doctors")
        'NoOfScheduled.Text = GetOverviewCount("approved")
    End Sub
    Private Sub StartChangeStreamListeners()
        ' Start listening for changes in "appointments" collection
        StartChangeStreamListener("appointments")

        ' Start listening for changes in "doctors" collection
        StartChangeStreamListener("doctors")

        ' Start listening for changes in "approved" collection
        StartChangeStreamListener("approved")

        StartChangeStreamListener("completed")
        StartChangeStreamListener("canceled")
    End Sub
    Private Sub StartChangeStreamListener(collectionName As String)
        Task.Run(Sub()
                     Try
                         Connection.ConnectToMongoDB(collectionName)
                         Dim collection As IMongoCollection(Of BsonDocument) = Connection.GetMongoDBCollection()

                         ' Define a pipeline for the change stream (filtering for insert and delete operations)
                         Dim pipeline = New EmptyPipelineDefinition(Of ChangeStreamDocument(Of BsonDocument))()

                         Dim options = New ChangeStreamOptions() With {
                             .FullDocument = ChangeStreamFullDocumentOption.UpdateLookup
                         }

                         Dim cursor As IChangeStreamCursor(Of ChangeStreamDocument(Of BsonDocument)) = collection.Watch(options)

                         ' Start listening for changes
                         While cursor.MoveNext()
                             For Each change As ChangeStreamDocument(Of BsonDocument) In cursor.Current
                                 ' Handle the change document here
                                 ' You can update the counts when insert or delete operations occur
                                 UpdateCounts()
                             Next
                         End While
                     Catch ex As Exception
                         Console.WriteLine("Error in change stream listener: " & ex.Message)
                     End Try
                 End Sub)
    End Sub

    Private Sub UpdateCounts()
        NoOfAppointments.Text = GetOverviewCount("appointments")
        DoctorsAvailable.Text = GetOverviewCount("doctors")
        NoOfScheduled.Text = GetOverviewCount("approved")
        noOfCompleted.Text = GetOverviewCount("completed")
        noOfCancelled.Text = GetOverviewCount("canceled")



    End Sub

    Private Sub BtnPending_Click(sender As Object, e As EventArgs) Handles BtnPending.Click
        If DashboardForm IsNot Nothing Then
            DashboardForm.BtnClients.PerformClick()
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DisplayDate.Text = "Date: " + DateTime.Now.ToString("MMMM dd, yyyy")
        Dim currentTime As DateTime = DateTime.Now
        If currentTime.Hour = 12 Then
            currentTime = currentTime.Date.AddHours(1)
        End If
        DisplayTime.Text = "Time: " + currentTime.ToString("hh:mm:ss tt")
    End Sub


End Class
