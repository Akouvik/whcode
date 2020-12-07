Public Class PU_AddPermissions
    Private data As New DataSet
    Private formTables As New DataSet
    Private bs As New BindingSource
    Private formID As Integer

    Public Sub New(ByVal id As Integer)
        InitializeComponent()
        formID = id
    End Sub
    Private Sub PU_AddPermissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formTables.Tables.Add(Database.ReturnTable("lkpUserRoles", , , "Label"))
        formTables.Tables.Add(Database.ReturnTable("lkpFormPermissionTypes"))
        cmbPermission.assignLookup(formTables, "lkpUserRoles")
        cmbPermissionType.assignLookup(formTables, "lkpFormPermissionTypes")
        cmbPermission.SelectedValue = 14
        cmbPermissionType.SelectedValue = -1
    End Sub

    Private Sub Button_1_Click(sender As Object, e As EventArgs) Handles Button_1.Click
        Me.Dispose()
    End Sub

    Private Sub Button_2_Click(sender As Object, e As EventArgs) Handles Button_2.Click
        If PreSaveValidation() Then
            Dim cmd As New SqlCommand("", WarehouseShell.conn)
            Dim cmdText As String = "insert into refFormPermissions(FormID, RoleID, PermissionType) values (" &
                    formID &
                    ", " & cmbPermission.getSQLValue &
                    ", " & cmbPermissionType.getSQLValue & ");"
            MsgBox(cmdText)
            cmd.CommandText = cmdText
            Try
                cmd.ExecuteNonQuery()
                Dispose()
            Catch ex As SqlException
                ExceptionHandler.CatchSQLException(ex)
            End Try
        End If
    End Sub

    Private Function PreSaveValidation() As Boolean
        Dim result As Boolean = True
        Dim errMsg As String = "The following errors exist and need to be corrected before record can be saved:" & vbNewLine & vbNewLine

        'Make sure permission does not already exist
        If cmbPermissionType.SelectedValue = -1 Then
            result = False
            errMsg += "- Please select a Permission type (View or Modify)."
        ElseIf Database.ExistingRecordCheck("refFormPermissions", "FormID = " & formID & " and RoleID = " & cmbPermission.SelectedValue & " and PermissionType = " & cmbPermissionType.SelectedValue) Then

            result = False
            errMsg += "- This permission already exists for this form." & vbNewLine
        End If

        If result = False Then
            MsgBox(errMsg, , "Errors Exist!")
        End If

        Return result
    End Function
End Class