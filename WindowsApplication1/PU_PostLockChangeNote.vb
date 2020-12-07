Public Class PU_PostLockChangeNote
    Private TableName As String
    Private RecordID As Integer

    Public Sub New(ByVal myTableName As String, Optional ByVal myRecordID As Integer = 0)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TableName = myTableName
        RecordID = myRecordID
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtChanges.Text <> "" Then
            Dim cmdText As String = "Insert into LockedRecordChangeHx(TableName, SubNum, ChangedRecordID, UserName, ChageText) values ('" &
                TableName & "', " &
                WarehouseShell.SubNum & ", " &
                RecordID & ", '" &
                WarehouseShell.userName & "', " &
                txtChanges.getSQLValue() & ");"
            Dim cmd As New SqlCommand(cmdText, WarehouseShell.conn)
            cmd.ExecuteNonQuery()

            DialogResult = DialogResult.OK
        Else
            MsgBox("Please describe changes or click cancel button.", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
    End Sub
End Class