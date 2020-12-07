Public Class User

    Public Shared Function CheckPermission(ByVal permissions As String) As Boolean
        Dim result = False
        Dim permission As String() = permissions.Split(New Char() {","c})
        For Each item As String In permission
            If Database.ExistingRecordCheck("refUser", "UserName = '" & WarehouseShell.userName & "' and Active = 1 and (UserName in (select UserName from viewUserRoles where Role = '" & item.Trim() & "' or Role = 'Admin'))") Then
                result = True
                Exit For
            End If
        Next
        Return result
    End Function

    Public Shared Function PermissionCheck(ByVal formName As String, ByVal permissionType As String) As Boolean
        Dim result = False
        Dim formId As Integer = Database.ReturnString("refWH_Forms", "Value", "VB_Name = '" & formName & "'")
        Dim permType As Integer = If(permissionType = "View", 1, 2)

        'Check if current user is either Admin or has access to the referenced form
        If Database.ExistingRecordCheck("UserRoles", "UserName = '" & WarehouseShell.userName & "' and RoleID = 1") Then
            result = True
        ElseIf Database.ExistingRecordCheck("refFormPermissions", "FormID = " & formId & " and PermissionType = " & permType & " and RoleID in (select RoleID from UserRoles where UserName = '" & WarehouseShell.userName & "')") Then
            result = True
        End If

        If result = False Then
            If permType = 1 Then
                MsgBox("You do not have permission to view this form. If you believe you should have this permission, please request it through your supervisor.", MsgBoxStyle.OkOnly, "Warning")
            Else
                MsgBox("You do not have permission to Add/Modify/Delete records on this form. If you believe you should have this permission, please request it through your supervisor.", MsgBoxStyle.OkOnly, "Warning")
            End If
        End If

        Return result
    End Function
End Class