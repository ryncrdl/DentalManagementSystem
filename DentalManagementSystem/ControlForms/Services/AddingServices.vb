Public Class AddingServices
    Private datas As List(Of Guna.UI2.WinForms.Guna2TextBox)
    Public Event ServicesAdded As EventHandler
    Private imagePath As String ' Variable to store the image file path

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        Try
            With OpenFileDialog1
                .Filter = "Image Files |*.png; *.jpeg;*.jpg"
                .FilterIndex = 1
            End With

            OpenFileDialog1.FileName = ""

            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                ' Load the selected image into Guna2CirclePictureBox1
                Guna2CirclePictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)

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

    Private Sub AddingServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datas = New List(Of Guna.UI2.WinForms.Guna2TextBox) From {txttitle, txtdescription, txtprice}
        Connection.ConnectToMongoDB("services")
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Dim isValidate As Boolean = False
        ServicesValidation.ValidateData(datas, isValidate)
        Dim title As String = txttitle.Text
        Dim description As String = txtdescription.Text
        Dim price As String = txtprice.Text
        Dim payment As String = txtPayment.Text

        If (isValidate) Then
            Try
                ' Check if an image has been selected
                If String.IsNullOrEmpty(imagePath) Then
                    MessageBox.Show("Please select an image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                If ServicesControllers.InsertServices(imagePath, title, description, price, payment) Then
                    messageOK.Show("Services added successfully!", "Services Success")

                    ' Clear the input fields after successful addition
                    Me.Close()
                    ServicesValidation.CreateDatas(datas)

                    RaiseEvent ServicesAdded(Me, EventArgs.Empty)
                End If
            Catch ex As Exception
                MessageBox.Show("Error adding services: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel1.Paint

    End Sub
End Class
