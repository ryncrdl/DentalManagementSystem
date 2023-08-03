
Public Class CustomMessageDialogForm

    Private Sub CustomMessageDialogForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Property MessageText As String
        Get
            Return Guna2HtmlLabel1.Text
        End Get
        Set(value As String)
            Guna2HtmlLabel1.Text = value
        End Set
    End Property

    Public Sub New(message As String)
        InitializeComponent()
        MessageText = message
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        DialogResult = DialogResult.Cancel
    End Sub
End Class