Public Class pu_FormPermissions
    Private formID As Integer
    Private formTables As New DataSet
    Private bs As New BindingSource
    Private row As DataGridViewRow
    Public changed As Boolean
    Private parentDGV As Action

    Public Sub New(ByVal myFormID As Integer, f As Action)
        InitializeComponent()
        formID = myFormID
        parentDGV = f
    End Sub

    Private Sub pu_FormPermissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        changed = False
        FormatDGV()
    End Sub

    Private Sub FormatDGV()
        If formTables.Tables.Contains("viewFormPermissions") Then
            formTables.Tables.Remove("viewFormPermissions")
        End If
        formTables.Tables.Add(Database.ReturnTable("viewFormPermissions", , "FormID = " & formID, "[Permission Type], Role"))
        bs.DataSource = formTables.Tables("viewFormPermissions")
        dgvFormPermissions.DataSource = bs
        dgvFormPermissions.Columns("RecordID").Visible = False
        dgvFormPermissions.Columns("FormID").Visible = False
        dgvFormPermissions.AutoResizeColumns()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        parentDGV()
        Me.Hide()
    End Sub
    Private Sub dgvFormPermissions_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFormPermissions.CellContentDoubleClick
        btnRemove.PerformClick()
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim recordID As Integer = dgvFormPermissions.SelectedRows(0).Cells("RecordID").Value
        Dim form As String = dgvFormPermissions.SelectedRows(0).Cells("Form").Value
        Dim role As String = dgvFormPermissions.SelectedRows(0).Cells("Role").Value
        Dim confirmRemovemsg As String = "Are you sure you would like to remove " & role & "s from Modifying the " & form & " form?"

        Dim result As DialogResult = MessageBox.Show(confirmRemovemsg, "Remove Permission", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                Dim cmd As New SqlCommand("delete from refFormPermissions where RecordID = " & recordID & ";", WarehouseShell.conn)
                cmd.ExecuteNonQuery()
                MsgBox("Role removed")

                FormatDGV()
            Catch ex As SqlException
                ExceptionHandler.CatchSQLException(ex)
            End Try
        ElseIf result = DialogResult.No Then
            Me.Refresh()
        End If

    End Sub
    Private Sub btnAddPermissions_Click(sender As Object, e As EventArgs) Handles btnAddPermissions.Click
        Dim pu As New PU_AddPermissions(formID)
        pu.ShowDialog()
        FormatDGV()
    End Sub
End Class