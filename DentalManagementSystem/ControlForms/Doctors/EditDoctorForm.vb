Imports MongoDB.Bson
Imports MongoDB.Driver
Imports DoctorsControllers

Public Class EditDoctorForm
    Public Event DoctorUpdated As EventHandler

    Private data As List(Of Guna.UI2.WinForms.Guna2TextBox)

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        DoctorValidation.CreateData(data)
        Me.Close()
    End Sub

    Private Sub EditDoctorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data = New List(Of Guna.UI2.WinForms.Guna2TextBox) From {txtfirstname, txtlastname, txtcontact, txtemail, txtaddress}
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

    End Sub
End Class