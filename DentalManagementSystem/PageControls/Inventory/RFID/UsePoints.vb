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

        If getRFID.Length = 10 Then
            ' Assuming FindAllRfidnumberByrfid returns a list of RFID numbers
            Dim fullNames As List(Of String) = FindAllRfidnumberByrfid(getRFID)
            Dim name As List(Of String) = FindAllfullnameByrfid(getRFID)
            Dim points As List(Of Integer) = FindAllpointsByrfid(getRFID)
            Dim rfidNumbers As List(Of String) = FindAllrfidByrfid(getRFID)
            ' Check if the list is not empty
            If fullNames.Count > 0 Then
                ' Display the RFID number from the list
                panel1.BringToFront()
                txt2.Text = String.Join(Environment.NewLine, name)
                txt1.Text = String.Join(Environment.NewLine, rfidNumbers)
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

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ' Get the RFID number from a TextBox
        Dim rfidNumber As String = txt1.Text.Trim()

        ' Call a function to clear or reset the "points" for the RFID number
        Dim success As Boolean = ClearPointsByRfid(rfidNumber)

        If success Then
            ' Successful update
            MessageBox.Show("Points cleared successfully.")
            Dim updatedPoints As Integer = GetPointsByRfid(rfidNumber)
            txt3.Text = updatedPoints.ToString()
        Else
            ' Handle the case where clearing the points failed
            MessageBox.Show("Failed to clear points.")
        End If
    End Sub

    Private Function ClearPointsByRfid(rfidNumber As String) As Boolean
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = GetClientCollection1()

            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("rfidNumber", rfidNumber)

            ' Set the "points" field to 0 to clear it
            Dim update As UpdateDefinition(Of BsonDocument) = Builders(Of BsonDocument).Update.Set(Of Double)("points", 0)

            Dim result As UpdateResult = collection.UpdateOne(filter, update)

            If result.ModifiedCount > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function GetPointsByRfid(rfidNumber As String) As Integer
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = GetClientCollection1()

            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("rfidNumber", rfidNumber)

            ' Projection to only get the "points" field
            Dim projection As ProjectionDefinition(Of BsonDocument) = Builders(Of BsonDocument).Projection.Include("points")

            ' Find and project the "points" field for the RFID number
            Dim document = collection.Find(filter).Project(projection).FirstOrDefault()

            If document IsNot Nothing AndAlso document.Contains("points") Then
                ' Retrieve the "points" field value
                Return document("points").AsInt32
            Else
                ' Return 0 or another default value if "points" is not found
                Return 0
            End If
        Catch ex As Exception
            ' Handle any potential errors
            Return 0
        End Try
    End Function
End Class