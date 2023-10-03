Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class AvailRfid
    Private data As List(Of Guna.UI2.WinForms.Guna2TextBox)
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        txtFullname.Visible = False
        txtrfidnumber.Visible = False
        txtRfid.Visible = False
        txtname.Visible = False
        txtContact.Clear()
        txtFullname.Clear()
        txtRfid.Clear()
        txterror.Visible = False
        Guna2CustomGradientPanel1.Visible = True
        BtnSave.Enabled = True
        txtRfid.Enabled = True
        Me.Close()

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim Contact As String = txtContact.Text
        Dim Fullname As String = txtFullname.Text
        Dim RFIDNUM As String = txtRfid.Text

        If (RFIDNUM.ToString.Length = 10) Then
            If AddRfidNumberToClients(RFIDNUM, Contact, Fullname) Then
                MessageSuccessfully.Show()
                txtContact.Clear()
                txtFullname.Clear()
                txtFullname.Visible = False
                txtrfidnumber.Visible = False
                txtRfid.Visible = False
                txtname.Visible = False
                Guna2CustomGradientPanel1.Visible = True
                txtRfid.Clear()
                Me.Close()
            Else
                CustomMessageError.Caption = "Invalid RFID!"
                CustomMessageError.Text = "RFID No. is already used."
                CustomMessageError.Show()
                txtRfid.Clear()
            End If
        Else
            CustomMessageError.Caption = "Invalid RFID!"
            CustomMessageError.Text = "RFID No. Should contain of" + Environment.NewLine + "10 numbers."
            CustomMessageError.Show()
            txtRfid.Clear()
        End If


    End Sub

    Private Sub AvailRfid_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Try
            Connection.ConnectToMongoDB("clients")
            Dim contactNumber As String = txtContact.Text.Trim()
            Dim fullNames As List(Of String) = FindAllFullNamesByContactNumber(contactNumber)
            Dim rfidNumbers As List(Of String) = FindAllRfidnumberByContactNumber(contactNumber)

            If fullNames.Count > 0 Then
                txtFullname.Text = String.Join(Environment.NewLine, fullNames)
                txtFullname.Visible = True
                txtrfidnumber.Visible = True
                txtRfid.Visible = True
                txtname.Visible = True
                Guna2CustomGradientPanel1.Visible = False
                txtRfid.Text = String.Join(Environment.NewLine, rfidNumbers)
                BtnClear.Visible = True

                If txtRfid.Enabled = Not String.IsNullOrEmpty(txtRfid.Text.Trim()) Then
                    BtnSave.Enabled = True
                    txtRfid.Enabled = False
                Else
                    BtnClear.Visible = False
                End If


            Else

                ' No clients found for the given contact number
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

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        txtFullname.Visible = False
        txtrfidnumber.Visible = False
        txtRfid.Visible = False
        txtname.Visible = False
        txtContact.Clear()
        txtFullname.Clear()
        txtRfid.Clear()
        txterror.Visible = False
        Guna2CustomGradientPanel1.Visible = True
        txtRfid.Enabled = True
    End Sub
End Class