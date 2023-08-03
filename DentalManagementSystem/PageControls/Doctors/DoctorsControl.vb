Imports Guna.UI2.WinForms
Imports MongoDB.Bson
Imports MongoDB.Driver


Public Class DoctorsControl

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        CreateDoctorForm.ShowDialog()
        CreateDoctorForm.GetTable(DoctorsTable)
    End Sub

    Private Sub DoctorsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoDataGridView("doctors", DoctorsTable)
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim selectedRowIndex As Integer = DoctorsTable.CurrentRow.Index
        Dim doctorId As String = DoctorsTable.Rows(selectedRowIndex).Cells("ID").Value.ToString()

        Dim result = MessageBox.Show("Are you sure you want to delete this doctor?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                ' Call the DeleteDoctor method from the DoctorsControllers module
                DoctorsControllers.DeleteDoctor(doctorId, DoctorsTable)
            Catch ex As Exception
                MessageBox.Show("Error deleting doctor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
