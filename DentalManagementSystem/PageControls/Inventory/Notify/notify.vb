Imports MongoDB.Bson
Imports MongoDB.Driver
Imports RJCP.IO.Ports
Public Class notify
    Private collection As IMongoCollection(Of BsonDocument)
    Private changeStream As IChangeStreamCursor(Of ChangeStreamDocument(Of BsonDocument))
    Private serialport1 As SerialPortStream
    Sub InitializeSerialPort()
        serialport1 = New SerialPortStream()
        serialport1.PortName = "COM3"
        serialport1.BaudRate = 115200
        serialport1.Parity = Parity.None
        serialport1.StopBits = StopBits.One
        serialport1.DataBits = 8
        serialport1.Handshake = Handshake.None
        serialport1.DtrEnable = True
        serialport1.RtsEnable = True
        serialport1.NewLine = vbCrLf
        serialport1.Open()
    End Sub
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
        Try
            InitializeSerialPort()
            MessageBox.Show("GSM has been Activated")
        Catch ex As Exception
            MessageBox.Show("SMS Api Activated")
        End Try
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
        If IsGSMModuleAvailable() Then
            serialport1.Close()
        End If

    End Sub

    Private Async Sub BtnNotify_Click(sender As Object, e As EventArgs) Handles BtnNotify.Click

        If PendingTable.CurrentRow Is Nothing Then
            ErrorMessage.Show("Please select a row to notify.")
            Return
        End If

        Dim rowData As Dictionary(Of String, String) = GetSelectedRowData()

        ' Extract the contact information from the selected row data
        Dim receiverNumber As String = rowData("Contact")
        Dim messageContent As String = rowData("Dates")
        Dim service As String = rowData("Service")
        Dim fname As String = rowData("Fullname")


        If IsGSMModuleAvailable() Then
            Try
                Dim atCommands = "AT+CMGS=" & """" & receiverNumber & """" & vbCr

                If serialport1.IsOpen = True Then
                    serialport1.Write("AT" & vbCrLf)
                    serialport1.Write("AT+CMGF=1" & vbCrLf)
                    serialport1.Write(atCommands)
                    Dim response As String = serialport1.ReadExisting()
                    Do Until response.Contains(">")
                        response &= serialport1.ReadExisting()
                    Loop
                    serialport1.Write("Hi " & fname & ", this is a reminder for your " & service & " appointment that successfully booked on " & messageContent & "." & Chr(26))
                    System.Threading.Thread.Sleep(5000)
                    Dim newresponse = serialport1.ReadExisting()

                    If newresponse.Contains("OK") Then
                        messok.Show()
                    Else
                        er.Show()
                    End If


                Else
                    MessageBox.Show("Error: Invalid Port", "Port", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                ErrorMessage.Show("Error deleting doctor: ")
            End Try
        Else

            Dim message As String = $"Hi " & fname & ", this is a reminder for your " & service & " appointment that successfully booked on " & messageContent & "." & Chr(26)
            Dim result As String = Await SMSNotification.SendSMSNotification(receiverNumber, message)


            If Not String.IsNullOrEmpty(result) Then
                messok.Show()
                Me.Close()
            Else
                MessageBox.Show("Failed to send SMS using Semaphore API.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If



        End If




    End Sub

    Private Function IsGSMModuleAvailable() As Boolean
        Return serialport1 IsNot Nothing AndAlso serialport1.IsOpen
    End Function
End Class