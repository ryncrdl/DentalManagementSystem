Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class AddPoints
    ' Define your MongoDB collection

    Private Sub AddPoints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2TextBox1.Focus()
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        Try
            Dim RfidNumber As String = Guna2TextBox1.Text.Trim()

            ' Call the function to find the full name associated with the RFID number
            Dim fullName As String = RFIDADDPOINTS.FindFullNameByContactNumber(RfidNumber)

            If Not String.IsNullOrEmpty(fullName) Then
                ' Display the full name in a label or another TextBox, e.g., lblFullName
                TXTFULLNAME.Text = fullName
            Else
                ' Handle the case where no data is found
                TXTFULLNAME.Text = "No full name found for the given RFID number."
            End If

            ' Call the function to find all full names associated with the RFID number
            Dim fullNames As List(Of String) = RFIDADDPOINTS.FindAllFullNamesByContactNumber(RfidNumber)

            If fullNames.Count > 0 Then
                ' Display the list of full names, e.g., in a TextBox or ListBox
                ' Assuming you have a TextBox named txtAllFullNames
                TXTFULLNAME.Text = String.Join(Environment.NewLine, fullNames)
                Guna2CustomGradientPanel1.Visible = True
            Else
                ' Handle the case where no data is found
                TXTFULLNAME.Text = "No full names found for the given RFID number."
            End If
        Catch ex As Exception
            ' Handle any exceptions that occur during MongoDB operations
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
