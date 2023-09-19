Imports System
Imports System.Windows.Forms
Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class AcceptReject
    Private data As List(Of Guna.UI2.WinForms.Guna2TextBox)
    Private rowData As Dictionary(Of String, String)
    Private collection As IMongoCollection(Of BsonDocument)
    Private AppointmentsId As String
    Public Sub New(ByVal rowData As Dictionary(Of String, String), ByVal collection As IMongoCollection(Of BsonDocument))
        InitializeComponent()
        Me.rowData = rowData
        Me.collection = collection
    End Sub
    Private Sub AcceptReject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data = New List(Of Guna.UI2.WinForms.Guna2TextBox) From {txtfullname, txtcontact, txtdate, txtservice, txtdoctor}
        Connection.ConnectToMongoDB("clients")
        ' Populate the form controls with the fetched data

        If rowData.ContainsKey("Fullname") Then
            txtfullname.Text = rowData("Fullname")
        End If

        If rowData.ContainsKey("Contact") Then
            txtcontact.Text = rowData("Contact")
        End If
        If rowData.ContainsKey("Dates") Then
            txtdate.Text = rowData("Dates")
        End If

        If rowData.ContainsKey("Service") Then
            txtservice.Text = rowData("Service")
        End If
        If rowData.ContainsKey("Doctor") Then
            txtdoctor.Text = rowData("Doctor")
        End If

        If rowData.ContainsKey("ID") Then
            Me.AppointmentsId = rowData("ID")
        End If

    End Sub
    Private Sub FetchDoctorData(clientsId As String, collectionName As String)
        Dim database As IMongoDatabase = Connection.database
        Dim collection = Connection.GetMongoDBCollection()

        Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", ObjectId.Parse(AppointmentsId))
        Dim appointments = collection.Find(filter).FirstOrDefault()

        ' Populate your form controls with the fetched data
        If appointments IsNot Nothing Then
            appointments("Fullname") = txtfullname.Text
            appointments("Contact") = txtcontact.Text
            appointments("Date") = txtdate.Text
            appointments("Service") = txtservice.Text
            appointments("Doctor") = txtdoctor.Text


        Else
            MessageBox.Show("Clients not found.")
        End If
    End Sub

    Private Sub txtdate_TextChanged(sender As Object, e As EventArgs) Handles txtdate.TextChanged

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtfullname_TextChanged(sender As Object, e As EventArgs) Handles txtfullname.TextChanged

    End Sub

    Private Sub txtdoctor_TextChanged(sender As Object, e As EventArgs) Handles txtdoctor.TextChanged

    End Sub
End Class