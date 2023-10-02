Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class AvailRfid
    Private data As List(Of Guna.UI2.WinForms.Guna2TextBox)
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim Contact As String = txtContact.Text
        Dim Fullname As String = txtFullname.Text
        Dim RFIDNUM As String = txtRfid.Text

        If AddRfidNumberToClients(RFIDNUM, Contact, Fullname) Then
            MessageSuccessfully.Show()
            txtContact.Clear()
            txtFullname.Clear()
            txtRfid.Clear()
            Me.Close()
        Else
            CustomMessageError.Show()
            txtRfid.Clear()
        End If

    End Sub

    Private Sub AvailRfid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection.ConnectToMongoDB("clients")
    End Sub
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Try
            Dim contactNumber As String = txtContact.Text.Trim()
            Dim fullNames As List(Of String) = FindAllFullNamesByContactNumber(contactNumber)
            If fullNames.Count > 0 Then
                txtFullname.Text = String.Join(Environment.NewLine, fullNames)
                txtFullname.Visible = True
                txtrfidnumber.Visible = True
                txtRfid.Visible = True
                txtname.Visible = True
                Guna2CustomGradientPanel1.Visible = False
            Else
                txtFullname.Text = ""
                txterror.Text = "No client found for the given contact number."
                txterror.Visible = True
            End If
        Catch ex As Exception
            ' Handle any exceptions that occur during MongoDB operations
            txtFullname.Text = "An error occurred: " & ex.Message
        End Try
    End Sub

    Private Sub txtContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContact.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            CreateMessageDialog.Show("Numbers Only!", "Input")
        End If
    End Sub
End Class