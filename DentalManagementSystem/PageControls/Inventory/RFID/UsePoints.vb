Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class UsePoints
    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Me.Close()
    End Sub

    Private Sub rfidnumber_TextChanged(sender As Object, e As EventArgs) Handles rfidnumber.TextChanged
        Timer1.Stop()
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop() ' Stop the timer
        rfidnumber.Focus()
        Dim getRFID As String = rfidnumber.Text.Trim()

        ' Assuming FindAllrfidByrfid returns a list of RFID number
        Dim rfid As List(Of String) = FindAllrfidByrfid(getRFID)

        ' Check if the length of the RFID number is equal to 10
        If getRFID.Length = 10 Then
            ' Check if the list of RFID numbers is not empty
            If rfid.Count > 0 Then
                ' Assuming FindAllpointsByrfid returns a list of points
                Dim points As List(Of Integer) = FindAllpointsByrfid(getRFID)

                ' Display the RFID number from the list
                panel1.BringToFront()
                txt3.Text = String.Join(Environment.NewLine, points)
                Guna2PictureBox1.Visible = False
                rfidnumber.Visible = False
            Else
                ' Handle the case where no matching RFID numbers were found
                ErrorMessage.Show()
                rfidnumber.Clear()
            End If
        End If





    End Sub

    Private Sub UsePoints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection.ConnectToMongoDB("clients")
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        txt3.Text = "0"
        If RFIDADDPOINTS.ClearPointsBypoints(txt3.Text) Then
            MessageBox.Show("ok")
        Else
            MessageBox.Show("error")
        End If


    End Sub


    Private Function GetTotalPrice(rfidNumber As String) As Double
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = GetClientCollection1()
            Dim serviceCollection As IMongoCollection(Of BsonDocument) = ServicesControllers.GetMongoDBCollections()

            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("rfidNumber", rfidNumber)

            ' Projection to only get the "points" field
            Dim projection As ProjectionDefinition(Of BsonDocument) = Builders(Of BsonDocument).Projection.Include("points")

            ' Find and project the "points" field for the RFID number
            Dim document = collection.Find(filter).Project(projection).FirstOrDefault()

            If document IsNot Nothing AndAlso document.Contains("points") Then
                Dim points As Integer = document("points").ToInt32()

                ' Projection to only get the "Price" field
                Dim serviceProjection As ProjectionDefinition(Of BsonDocument) = Builders(Of BsonDocument).Projection.Include("Price").Include("Title")
                Dim serviceDocument = serviceCollection.Find(filter).Project(serviceProjection).FirstOrDefault()

                If serviceDocument IsNot Nothing AndAlso serviceDocument.Contains("Price") Then
                    Dim price As Double = serviceDocument("Price").ToDouble()

                    ' Calculate the total price by subtracting points
                    Dim totalPrice As Double = price - points

                    Return totalPrice
                End If
            End If

            ' Return 0 or another default value if data is not found
            Return 0
        Catch ex As Exception
            ' Handle any potential errors
            Return 0
        End Try
    End Function


End Class