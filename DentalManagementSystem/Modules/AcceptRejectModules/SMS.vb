
Imports RJCP.IO.Ports
Module SMS
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
    Sub SendMessage(txtcontact As String, txtservice As String, txtdate As String)
        ' Check if the receiver's number and message content are not empty
        If String.IsNullOrEmpty(txtcontact) Then
            MessageBox.Show("Please enter a receiver's number .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Format the AT command to send the message
        Dim atCommand As String = "AT+CMGS=" & """" & txtcontact & """" & vbCr

        If serialport1.IsOpen = True Then
            serialport1.Write("AT" & vbCrLf)
            serialport1.Write("AT+CMGF=1" & vbCrLf)
            serialport1.Write(atCommand)
            Dim response As String = serialport1.ReadExisting()
            Do Until response.Contains(">")
                response &= serialport1.ReadExisting()
            Loop
            serialport1.Write("Your " & txtservice & " appointment is now successfully booked on " & txtdate & Chr(26))
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
    End Sub
    Sub SendMessage1(txtcontact As String, txtservice As String, txtdate As String)
        ' Check if the receiver's number and message content are not empty
        If String.IsNullOrEmpty(txtcontact) Then
            MessageBox.Show("Please enter a receiver's number .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Format the AT command to send the message
        Dim atCommand As String = "AT+CMGS=" & """" & txtcontact & """" & vbCr

        If serialport1.IsOpen = True Then
            serialport1.Write("AT" & vbCrLf)
            serialport1.Write("AT+CMGF=1" & vbCrLf)
            serialport1.Write(atCommand)
            Dim response As String = serialport1.ReadExisting()
            Do Until response.Contains(">")
                response &= serialport1.ReadExisting()
            Loop
            serialport1.Write("Sorry your " & txtservice & " appointment on " & txtdate & " is rejected due to invalid receipt " & Chr(26))
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

    End Sub
    Sub cancelport()
        serialport1.Close()
    End Sub
End Module
