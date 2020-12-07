Public Class WA_PurchaseRequests
    Implements IFormMethods
    Private Results As DataTable
    Private Reader As SqlDataAdapter

    Private Sub WA_PurchaseRequests_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_PurchaseRequests")
        Results = New DataTable("Result")
        Reader = New SqlDataAdapter("Select * from viewPurchaseRequests order by RequestID desc", WarehouseShell.conn)
        Reader.Fill(Results)
        formatDGV()
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        dgvResults.MultiSelect = False
    End Sub

    Private Sub formatDGV()
        If chkHideComplete.Checked Then
            Results = New DataTable
            Reader = New SqlDataAdapter("Select * from viewPurchaseRequests where RequestID in (select RequestID from PurchaseRequestItems where Approved = 3) order by RequestID desc", WarehouseShell.conn)
            Reader.Fill(Results)
        Else
            Results = New DataTable
            Reader = New SqlDataAdapter("Select * from viewPurchaseRequests order by RequestID desc", WarehouseShell.conn)
            Reader.Fill(Results)
        End If
        dgvResults.DataSource = Results
        dgvResults.AutoResizeColumns()
    End Sub

    Private Sub chkHideComplete_CheckedChanged(sender As Object, e As EventArgs) Handles chkHideComplete.CheckedChanged
        formatDGV()
    End Sub

    Private Sub dgvResults_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResults.CellContentDoubleClick
        If dgvResults.RowCount > 0 Then
            btnEdit.PerformClick()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim pu As New PU_PurchaseRequest(0)
        pu.ShowDialog()
        formatDGV()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim row As DataGridViewRow = dgvResults.SelectedRows(0)
        Dim requestID As Integer = row.Cells("RequestID").Value
        Dim pu As New PU_PurchaseRequest(requestID)
        pu.ShowDialog()
        formatDGV()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As DialogResult = MsgBox("You are about to delete this item. Would you like to continue?", MsgBoxStyle.YesNo, "Warning")
        If result = DialogResult.Yes Then
            Try
                Dim cmd As New SqlCommand("delete from PurchaseRequests where RequestID = " & dgvResults.Rows(0).Cells("RequestID").Value.ToString & ";", WarehouseShell.conn)
                cmd.ExecuteNonQuery()
                formatDGV()
            Catch ex As SqlException
                ExceptionHandler.CatchSQLException(ex)
            End Try
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        MsgBox("This will be implemented at a later date.", MsgBoxStyle.OkOnly, "System Message")
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