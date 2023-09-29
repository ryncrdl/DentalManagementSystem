Imports System.Text
Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class AvailRfid
    Private data As List(Of Guna.UI2.WinForms.Guna2TextBox)
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs) Handles txtrfidnumber.Click

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim Contact As String = txtContact.Text
        Dim Fullname As String = txtFullname.Text
        Dim RFIDNUM As String = txtRfid.Text


        If RFIDINSERTCONTROLLERS.Insertrfid(Contact, Fullname, RFIDNUM) Then
            MessageSuccessfully.Show()

            ' Clear the input fields after successful addition
            Me.Close()
        End If

    End Sub

    Private Sub AvailRfid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data = New List(Of Guna.UI2.WinForms.Guna2TextBox) From {txtContact, txtFullname, txtRfid}
        Connection.ConnectToMongoDB("rfid")
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtContact.TextChanged

    End Sub





    Private Sub txtFullname_TextChanged(sender As Object, e As EventArgs) Handles txtFullname.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop() ' Stop the timer

        Try
            Dim contactNumber As String = txtContact.Text.Trim()
            Dim fullNames As String = REGISTERCONTROLLERS.FindFullNameByContactNumber(contactNumber)

            If fullNames.Count > 0 Then
                ' Join the list of full names into a single string with line breaks
                Dim fullNamesText As String = String.Join(Environment.NewLine, fullNames)
                txtFullname.Text = fullNamesText
            Else
                txtFullname.Text = "" ' Clear the textbox if no matching documents are found
                txterror.Visible = True
            End If
        Catch ex As Exception
            ' Handle any exceptions that occur during MongoDB operations
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Try
            Dim contactNumber As String = txtContact.Text.Trim()

            ' Call the function to find all full names by contact number
            Dim fullNames As List(Of String) = REGISTERCONTROLLERS.FindAllFullNamesByContactNumber(contactNumber)

            If fullNames.Count > 0 Then
                ' Display the full names, e.g., in a TextBox
                txtFullname.Text = String.Join(Environment.NewLine, fullNames)
                txtFullname.Visible = True
                txtrfidnumber.Visible = True
                txtRfid.Visible = True
                txtname.Visible = True
                Guna2CustomGradientPanel1.Visible = False
            Else
                ' Handle the case where no data is found
                txtFullname.Text = ""
                txterror.Text = "No full names found for the given contact number."
                txterror.Visible = True
            End If
        Catch ex As Exception
            ' Handle any exceptions that occur during MongoDB operations
            txtFullname.Text = "An error occurred: " & ex.Message
        End Try
    End Sub
End Class