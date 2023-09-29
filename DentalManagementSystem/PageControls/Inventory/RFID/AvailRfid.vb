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

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim contactNumber As String = txtContact.Text.Trim()
        Dim clientDocuments As List(Of BsonDocument) = REGISTERCONTROLLERS.FindDocumentsByContactNumber(contactNumber)

        If clientDocuments IsNot Nothing AndAlso clientDocuments.Count > 0 Then
            ' Create a StringBuilder to store full names
            Dim fullNameBuilder As New StringBuilder()

            ' Iterate through the list of documents and concatenate full names
            For Each clientDocument As BsonDocument In clientDocuments
                If clientDocument.Contains("fullName") Then
                    Dim fullName As String = clientDocument("fullName").AsString
                    fullNameBuilder.Append(fullName).Append(Environment.NewLine)
                End If
            Next

            ' Set the textbox text to the concatenated full names
            txtFullname.Text = fullNameBuilder.ToString()

            ' Optionally, hide or show controls, clear error messages, etc.
            txtname.Visible = True
            txtrfidnumber.Visible = True
            txtFullname.Visible = True
            txtRfid.Visible = True
            BtnSearch.Visible = False
            Guna2CustomGradientPanel1.Visible = False
            txterror.Visible = False
        Else
            txtFullname.Text = "" ' Clear the textbox if no matching documents are found
            txterror.Visible = True
        End If
    End Sub

    Private Sub txtFullname_TextChanged(sender As Object, e As EventArgs) Handles txtFullname.TextChanged

    End Sub
End Class