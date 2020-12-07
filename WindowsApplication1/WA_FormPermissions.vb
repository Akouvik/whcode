Public Class WA_FormPermissions
    Implements IFormMethods
    Dim formTables As New DataSet
    Dim bs As New BindingSource
    Dim row As DataGridViewRow
    Private Sub WA_FormPermissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_FormPermissions")
        FormatDGV()
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
    End Sub
    Public Sub FormatDGV()
        If formTables.Tables.Contains("viewFormPermissions_Consolidated") Then
            formTables.Tables.Remove("viewFormPermissions_Consolidated")
        End If
        formTables.Tables.Add(Database.ReturnTable("viewFormPermissions_Consolidated", , , "Form"))
        bs.DataSource = formTables.Tables("viewFormPermissions_Consolidated")
        dgvFormPermissions.DataSource = bs
        dgvFormPermissions.Columns("FormID").Visible = False
        dgvFormPermissions.AutoResizeColumns()
    End Sub
    Private Sub dgvFormPermissions_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFormPermissions.CellContentDoubleClick
        btnEdit.PerformClick()
    End Sub
    Private Sub bntEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If User.CheckPermission("Admin") Then
            Dim formID As Integer = dgvFormPermissions.SelectedRows(0).Cells("FormID").Value
            Dim pu As New pu_FormPermissions(formID, AddressOf FormatDGV)
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
