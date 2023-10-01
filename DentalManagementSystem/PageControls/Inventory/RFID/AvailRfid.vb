Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
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
        Dim services As String = cbservice.Text

        If services = "" And txtRfid.Text = "" Then
            ' Show a message if the "services" field is empty
            CreateMessageDialog.Show()
        ElseIf RFIDINSERTCONTROLLERS.Insertrfid1(Contact, Fullname, RFIDNUM, services) Then
            ' Show a success message if the insertion is successful
            MessageSuccessfully.Show()

            ' Clear the input fields after successful addition
            txtContact.Clear()
            txtFullname.Clear()
            txtRfid.Clear()
            cbservice.SelectedIndex = -1
            Me.Close()
        Else
            ' Show an error message if the RFID number is not unique
            CustomMessageError.Show()
            txtRfid.Clear()
        End If

    End Sub

    Private Sub AvailRfid_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Connection.ConnectToMongoDB("clients")
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtContact.TextChanged

    End Sub

    Private Sub txtFullname_TextChanged(sender As Object, e As EventArgs) Handles txtFullname.TextChanged

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
                txtser.Visible = True
                cbservice.Visible = True
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

    Private Sub Guna2CustomGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2CustomGradientPanel1.Paint

    End Sub

    Private Sub txtContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContact.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True

            CreateMessageDialog.Show("Numbers Only!", "Input")

        End If

    End Sub
End Class