Imports System
Imports System.Windows.Forms
Imports MongoDB.Bson
Imports MongoDB.Driver
Imports System.IO.Ports
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports RJCP.IO.Ports


Public Class AcceptReject
    Private data As List(Of Guna.UI2.WinForms.Guna2TextBox)
    Private rowData As Dictionary(Of String, String)
    Private rowImage As Dictionary(Of String, Image)
    Private collection As IMongoCollection(Of BsonDocument)
    Private AppointmentsId As String
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

    Public Sub New(ByVal rowData As Dictionary(Of String, String), ByVal rowImage As Dictionary(Of String, Image), ByVal collection As IMongoCollection(Of BsonDocument))
        InitializeComponent()
        Me.rowData = rowData
        Me.rowImage = rowImage
        Me.collection = collection
    End Sub
    Private Sub AcceptReject_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        data = New List(Of Guna.UI2.WinForms.Guna2TextBox) From {txtfullname, txtcontact, txtdate, txtservice, txtdoctor}
        Connection.ConnectToMongoDB("appointments")
        ' Populate the form controls with the fetched data

        If rowData.ContainsKey("Fullname") Then
            txtfullname.Text = rowData("Fullname")
        End If

        If rowData.ContainsKey("Contact") Then
            txtcontact.Text = rowData("Contact")
        End If
        If rowData.ContainsKey("Dates") Then
            txtdate.Text = rowData("Dates")
        End If

        If rowData.ContainsKey("Service") Then
            txtservice.Text = rowData("Service")
        End If
        If rowData.ContainsKey("Doctor") Then
            txtdoctor.Text = rowData("Doctor")
        End If

        If rowImage.ContainsKey("Payment") Then
            Guna2PictureBox1.Image = DirectCast(rowImage("Payment"), Image)
        End If

        If rowData.ContainsKey("ID") Then
            Me.AppointmentsId = rowData("ID")
        End If
        InitializeSerialPort()

    End Sub
    Private Sub FetchDoctorData(clientsId As String, collectionName As String)
        Dim database As IMongoDatabase = Connection.database
        Dim collection = Connection.GetMongoDBCollection()

        Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", ObjectId.Parse(AppointmentsId))
        Dim appointments = collection.Find(filter).FirstOrDefault()

        ' Populate your form controls with the fetched data
        If appointments IsNot Nothing Then
            appointments("Fullname") = txtfullname.Text
            appointments("Contact") = txtcontact.Text
            appointments("Date") = txtdate.Text
            appointments("Service") = txtservice.Text
            appointments("Doctor") = txtdoctor.Text

            If Guna2PictureBox1.Image IsNot Nothing Then
                ' Convert the image to a base64 string
                Dim imageConverter As New ImageConverter()
                Dim imageBytes As Byte() = DirectCast(imageConverter.ConvertTo(Guna2PictureBox1.Image, GetType(Byte())), Byte())
                Dim base64String As String = Convert.ToBase64String(imageBytes)

                ' Assign the base64 string to the "Payment" field in your MongoDB document
                appointments("Payment") = base64String
            Else
                appointments("Payment") = ""
            End If

            MessageBox.Show("Clients not found.")
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        serialport1.Close()
        Me.Close()
    End Sub


    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim receiverNumber As String = txtcontact.Text
        Dim messageContent As String = txtdate.Text
        Dim services As String = txtservice.Text

        ' Check if the receiver's number and message content are not empty


        Dim sourceCollectionName As String = "appointments"
        Dim destCollectionName As String = "approved"



        ' Format the AT command to send the message
        Dim atCommand As String = "AT+CMGS=" & """" & receiverNumber & """" & vbCr

        If serialport1.IsOpen = True Then
            serialport1.Write("AT" & vbCrLf)
            serialport1.Write("AT+CMGF=1" & vbCrLf)
            serialport1.Write(atCommand)
            Dim response As String = serialport1.ReadExisting()
            Do Until response.Contains(">")
                response &= serialport1.ReadExisting()
            Loop
            serialport1.Write("Your " & services & " appointment is successfully booked on " & messageContent & "." & Chr(26))
            System.Threading.Thread.Sleep(5000)
            Dim newresponse = serialport1.ReadExisting()

            If newresponse.Contains("OK") Then
                MessageBox.Show("Message sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                AcceptControllers.TransferDataOneByOne(sourceCollectionName, destCollectionName, AppointmentsId)
                MessageSuccessfully.Show()
            Else
                MessageBox.Show("Failed to send message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            serialport1.Close()

        Else
            MessageBox.Show("Error: Invalid Port", "Port", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Call the MoveCollectionData function from the MongoDBHelper module


        ' Display a success message or perform any other necessary actions

        Me.Close()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim receiverNumber As String = txtcontact.Text
        Dim messageContent As String = txtdate.Text
        Dim services As String = txtservice.Text


        Dim sourceCollectionName As String = "appointments"
        Dim destCollectionName As String = "rejected"


        ' Format the AT command to send the message
        Dim atCommand As String = "AT+CMGS=" & """" & receiverNumber & """" & vbCr

        If serialport1.IsOpen = True Then
            serialport1.Write("AT" & vbCrLf)
            serialport1.Write("AT+CMGF=1" & vbCrLf)
            serialport1.Write(atCommand)
            Dim response As String = serialport1.ReadExisting()
            Do Until response.Contains(">")
                response &= serialport1.ReadExisting()
            Loop
            serialport1.Write("Sorry your " & services & " appointment on " & messageContent & " is rejected due to invalid receipt or information. " & Chr(26))
            System.Threading.Thread.Sleep(5000)
            Dim newresponse = serialport1.ReadExisting()

            If newresponse.Contains("OK") Then
                MessageBox.Show("Message sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to send message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            serialport1.Close()

        Else
            MessageBox.Show("Error: Invalid Port", "Port", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Call the MoveCollectionData function from the MongoDBHelper module
        RejectControllers.TransferDataByOne(sourceCollectionName, destCollectionName, AppointmentsId)

        ' Display a success message or perform any other necessary actions
        rejectsuccessfully.Show()
        Me.Close()
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub

    Private Sub txtdoctor_TextChanged(sender As Object, e As EventArgs) Handles txtdoctor.TextChanged

    End Sub
End Class