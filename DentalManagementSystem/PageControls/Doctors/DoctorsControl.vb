Imports Guna.UI2.WinForms
Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class DoctorsControl
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim createDoctorForm As New CreateDoctorForm()
        AddHandler createDoctorForm.DoctorAdded, AddressOf CreateDoctorForm_DoctorAdded
        createDoctorForm.ShowDialog()
    End Sub

    Private Sub CreateDoctorForm_DoctorAdded(sender As Object, e As EventArgs)
        ' Reload data into DataGridView with collection name "doctors"
        LoadDataIntoDataGridView("doctors", DoctorsTable)
    End Sub

    Private Sub DoctorsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoDataGridView("doctors", DoctorsTable)
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If DoctorsTable.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim selectedRowIndex As Integer = DoctorsTable.CurrentRow.Index
        Dim doctorId As String = DoctorsTable.Rows(selectedRowIndex).Cells("ID").Value.ToString()

        Dim result = MessageDelete.Show()
        If result = DialogResult.Yes Then
            Try
                ' Call the DeleteDoctor method from the DoctorsControllers module
                DoctorsControllers.DeleteDoctor(doctorId, DoctorsTable)
            Catch ex As Exception
                MessageBox.Show("Error deleting doctor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click

    End Sub



End Class
