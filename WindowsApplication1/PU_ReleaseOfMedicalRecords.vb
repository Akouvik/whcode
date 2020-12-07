
Public Class PU_ReleaseOfMedicalRecords
    Private formTables As New DataSet

    Private Sub PU_ReleaseOfMedicalRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formTables.Tables.Add(Database.ReturnTable("fileReleaseOfMedRecords", "'Release of Medical Records' as FileType, SubNum, SequenceNum, UploadDate", "SubNum = " & WarehouseShell.SubNum, "UploadDate desc"))
        dgvReleaseOfMedicalRecords.DataSource = formTables.Tables("fileReleaseOfMedRecords")
        dgvReleaseOfMedicalRecords.Columns("SubNum").Visible = False
        dgvReleaseOfMedicalRecords.Columns("SequenceNum").Visible = False
    End Sub

    Private Sub dgvReleaseOfMedicalRecords_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReleaseOfMedicalRecords.CellDoubleClick
        btnOpen.PerformClick()
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim SequenceNum As Integer = dgvReleaseOfMedicalRecords.SelectedRows(0).Cells("SequenceNum").Value
        Dim UploadDate As String = dgvReleaseOfMedicalRecords.SelectedRows(0).Cells("UploadDate").Value.ToString
        SubjectFiles1toMany.OpenFile("fileReleaseOfMedRecords", WarehouseShell.SubNum, "SubNum " & WarehouseShell.SubNum & " Release of Medical Records", SequenceNum)
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        SubjectFiles1toMany.SaveFile("fileReleaseofMedRecords", WarehouseShell.SubNum)
        ResetDGV()
    End Sub

    Private Sub ResetDGV()
        dgvReleaseOfMedicalRecords.DataSource = Nothing
        formTables.Tables.Remove("fileReleaseOfMedRecords")
        formTables.Tables.Add(Database.ReturnTable("fileReleaseOfMedRecords", "'Release of Medical Records' as FileType, SubNum, SequenceNum, UploadDate", "SubNum = " & WarehouseShell.SubNum, "UploadDate desc"))
        dgvReleaseOfMedicalRecords.DataSource = formTables.Tables("fileReleaseOfMedRecords")
        dgvReleaseOfMedicalRecords.Columns("SubNum").Visible = False
        dgvReleaseOfMedicalRecords.Columns("SequenceNum").Visible = False
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        SubjectFiles1toMany.DeleteFile("fileReleaseOfMedRecords", WarehouseShell.SubNum, dgvReleaseOfMedicalRecords.SelectedRows(0).Cells("SequenceNum").Value)
        ResetDGV()
    End Sub
End Class