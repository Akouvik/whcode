Public Class PU_AddNewRole
    Private selectedName As String
    Private selectedUserName As String
    Private formTables As New DataSet
    Private bs As New BindingSource
    Private dgvForEditRoles As Action

    Public Sub New(ByVal name As String, ByVal userName As String, formRefresh As Action)
        InitializeComponent()
        selectedUserName = userName
        dgvForEditRoles = formRefresh
        selectedName = name
    End Sub
    Private Sub PU_AddNewRole_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Add New Role For " & selectedName
        formTables.Tables.Add(Database.ReturnTable("lkpUserRoles", , , "Label"))
        cmbAddNewRole.assignLookup(formTables, "lkpUserRoles")
        cmbAddNewRole.SelectedValue = -1
    End Sub

    Private Sub btnAddRole_Click(sender As Object, e As EventArgs) Handles btnAddRole.Click
        If String.IsNullOrEmpty(cmbAddNewRole.SelectedValue) Then
            MsgBox("Please select a role to add or press Cancel", MsgBoxStyle.OkOnly, "Warning")
        Else
            If PreSaveValidation() Then
                Dim cmd As New SqlCommand("", WarehouseShell.conn)
                Dim cmdText As String = "insert into UserRoles(UserName, RoleId) values (" & "'" &
                selectedUserName & "'" &
                            "," & cmbAddNewRole.getSQLValue & ");"
                MsgBox(cmbAddNewRole.getSQLLabel & " Role was added to " & selectedName, MsgBoxStyle.OkOnly, "Warning")

                cmd.CommandText = cmdText
                Try
                    cmd.ExecuteNonQuery()
                    Dispose()
                Catch ex As SqlException
                    ExceptionHandler.CatchSQLException(ex)
                End Try
                dgvForEditRoles()

            End If
        End If


    End Sub
    Private Function PreSaveValidation() As Boolean
        Dim result As Boolean = True
        'Make sure Role does not already exist
        If Database.ExistingRecordCheck("UserRoles", "UserName = " & "'" & selectedUserName & "'" & " AND RoleId = " & cmbAddNewRole.getSQLValue) Then
            result = False
        End If
        If result = False Then
            MsgBox(selectedName & " Already has this Role")
        End If
        Return result
    End Function
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub
End Class