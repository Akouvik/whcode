Public Class WA_UserManagement
    Implements IFormMethods
    Dim formTables As New DataSet
    Dim bs As New BindingSource
    Dim row As DataGridViewRow
    Private Sub WA_UserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_UserManagement")
        FormatDGV()
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
    End Sub
    Private Sub FormatDGV()
        If formTables.Tables.Contains("viewUserManagement") Then
            formTables.Tables.Remove("viewUserManagement")
        End If
        formTables.Tables.Add(Database.ReturnTable("viewUserManagement", , , "Active desc, Name"))
        bs.DataSource = formTables.Tables("viewUserManagement")
        dgvUsers.DataSource = bs
        HideInactiveUsers()
        dgvUsers.AutoResizeColumns()
    End Sub
    Private Sub chkActive_CheckedChanged(sender As Object, e As EventArgs) Handles chkActive.CheckedChanged
        HideInactiveUsers()
    End Sub
    Private Sub HideInactiveUsers()
        If chkActive.Checked Then
            bs.Filter = "Active = 'Yes'"
        Else
            bs.Filter = ""
        End If
    End Sub
    Private Sub dgvUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        btnUserInfo_Click(sender, e)
    End Sub
    Private Sub bntAdd_Click(sender As Object, e As EventArgs) Handles bntAdd.Click
        Dim pu As New PU_EditUserInfo("")
        pu.ShowDialog()
        If pu.result = "Ok" Then
            FormatDGV()
        End If
        pu.Dispose()
    End Sub
    Private Sub btnUserInfo_Click(sender As Object, e As EventArgs) Handles btnUserInfo.Click
        row = dgvUsers.SelectedRows(0)
        If User.CheckPermission("Admin") Or WarehouseShell.userName = row.Cells("UserName").Value.ToString Then
            Dim pu As New PU_EditUserInfo(row.Cells("UserName").Value)
            pu.ShowDialog()
            If pu.result = "Ok" Then
                FormatDGV()
            End If
            pu.Dispose()
        Else
            MsgBox("Only Warehouse Admins may edit user records other than their own.", MsgBoxStyle.OkOnly, "Warning")
        End If
    End Sub
    Private Sub btnEditRoles_Click(sender As Object, e As EventArgs) Handles btnEditRoles.Click
        If User.CheckPermission("Admin") Then
            Dim name As String = dgvUsers.SelectedRows(0).Cells("Name").Value
            Dim userName As String = dgvUsers.SelectedRows(0).Cells("UserName").Value
            Dim pu As New PU_EditRoles(name, userName, AddressOf FormatDGV)
            pu.ShowDialog()
            If pu.changed Then
                FormatDGV()
            End If
            pu.Dispose()
        Else
            MsgBox("You do not have permission to perform this action. If you believe you should be able to, please contact your supervisor and request access.", MsgBoxStyle.OkOnly, "Warning")
        End If
    End Sub
    Public Sub TopLevel(val As Boolean) Implements IFormMethods.TopLevel
    End Sub
    Public Sub ShowPHI(val As Boolean) Implements IFormMethods.ShowPHI
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
    Private Sub IFormMethods_Parent(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Private Sub IFormMethods_Show() Implements IFormMethods.Show
        Show()
    End Sub
End Class