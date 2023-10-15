
Public Class AddingAnnouncements
    Private datas As List(Of Guna.UI2.WinForms.Guna2TextBox)
    Public Event AnnouncementAdded As EventHandler
    Private imagePath As String

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        Try
            With OpenFileDialog1
                .Filter = "Image Files |*.png; *.jpeg;*.jpg"
                .FilterIndex = 1
            End With

            OpenFileDialog1.FileName = ""

            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                ' Load the selected image into Guna2CirclePictureBox1
                txtimage.Image = Image.FromFile(OpenFileDialog1.FileName)

                ' Store the image file path
                imagePath = OpenFileDialog1.FileName
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub AddingAnnouncements_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datas = New List(Of Guna.UI2.WinForms.Guna2TextBox) From {txttitle, txtcontext}
        Connection.ConnectToMongoDB("announcements")
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Dim isValidate As Boolean = False
        AnnouncementsValidation.ValidateData(datas, isValidate)
        Dim title As String = txttitle.Text
        Dim context As String = txtcontext.Text

        If (isValidate) Then
            Try
                ' Check if an image has been selected
                If String.IsNullOrEmpty(imagePath) Then
                    MessageBox.Show("Please select an image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                If InsertAnnouncement(imagePath, title, context) Then
                    messageOK.Show("Announcement added successfully!", "Announcement Success")

                    Me.Close()
                    AnnouncementsValidation.ClearData(datas)

                    RaiseEvent AnnouncementAdded(Me, EventArgs.Empty)
                End If
            Catch ex As Exception
                MessageBox.Show("Error adding announcement: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            messageOK.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error
            messageOK.Show("All fields are required.", "Adding Announcement Error")
        End If
    End Sub
End Class
