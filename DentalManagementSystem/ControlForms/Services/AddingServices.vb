Public Class AddingServices
    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox1.Click

    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        Try
            With OpenFileDialog1
                .Filter = "Image Files |*.png; *.jpeg;*.jpg"
                .FilterIndex = 1

            End With
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Guna2CirclePictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class