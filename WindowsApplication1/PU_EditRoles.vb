Public Class PU_EditRoles
    Private currentName As String
    Private currentUserName As String
    Private formTables As New DataSet
    Private bs As New BindingSource
    Public changed As Boolean
    Private dgvForUserManagement As Action

    Public Sub New(ByVal name As String, ByVal userName As String, userManagementForm As Action)
        InitializeComponent()
        currentUserName = userName
        dgvForUserManagement = userManagementForm
        currentName = name
    End Sub
    Private Sub PU_EditRole_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Edit User Roles For " & currentName
        changed = False
        FormatDGV()
    End Sub

    Private Sub FormatDGV()
        If formTables.Tables.Contains("viewUserRoles") Then
            formTables.Tables.Remove("viewUserRoles")
        End If

        formTables.Tables.Add(Database.ReturnTable("viewUserRoles", , "UserName = '" & currentUserName & "'"))
        bs.DataSource = formTables.Tables("viewUserRoles")
        dgvEditUserRoles.DataSource = bs
        dgvEditUserRoles.Columns("RoleValue").Visible = False
        dgvEditUserRoles.AutoResizeColumns()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        dgvForUserManagement()
        Me.Hide()
    End Sub

    Private Sub btnAddRole_Click(sender As Object, e As EventArgs) Handles btnAddRole.Click
        Dim pu As New PU_AddNewRole(currentName, currentUserName, AddressOf FormatDGV)
        pu.ShowDialog()
    End Sub

    Private Sub btnRemoveRole_Click(sender As Object, e As EventArgs) Handles btnRemoveRole.Click
        Try
            Dim UserName As String = dgvEditUserRoles.SelectedRows(0).Cells("UserName").Value
            Dim Role As String = dgvEditUserRoles.SelectedRows(0).Cells("RoleValue").Value
            Dim cmd As New SqlCommand("delete from UserRoles where UserName = " & "'" & UserName & "'" & " And RoleId = " & Role & ";", WarehouseShell.conn)
            cmd.ExecuteNonQuery()

            FormatDGV()
            'Catch ex As SqlException
        Catch ex As Exception When TypeOf ex Is SqlException OrElse TypeOf ex Is ArgumentOutOfRangeException
            If TypeOf ex Is SqlException Then
                ExceptionHandler.CatchSQLException(ex)
            ElseIf TypeOf ex Is ArgumentOutOfRangeException Then
                MsgBox("This User has no Roles to Remove")
            End If
        End Try
        Me.Refresh()
    End Sub
End Class