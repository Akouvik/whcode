Imports System

Public Class WA_TissueTaskerReport
    Implements IFormMethods

    Private table As New DataSet
    Private taskbs As BindingSource

    'Take on-load actions
    Private Sub WA_TissueTaskerReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_TissueTasker")
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        table.Tables.Add(Database.ReturnTable("viewTissueTasker", "ProjectID as 'TaskID', Project, SubProject, NumSamples as '# Samples Req', TotalComplete as '# Samples Comp', AssignedTo1Label as 'Assigned To 1', AssignedTo2Label as 'Assigned To 2', CompDate as 'Date Completed', RequestDate as 'Request Date', EstCompDt as 'Est Comp Dt'", , "ProjectID desc"))
        taskbs = New BindingSource
        taskbs.DataSource = table.Tables("viewTissueTasker")
        dgvTissueTaskers.DataSource = taskbs
        dgvTissueTaskers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        If Database.ExistingRecordCheck("refUser", "UserName = '" & WarehouseShell.userName & "' and TissueProjectOverride = 1") = True Then
            btnAddTissueTasker.Visible = True
        End If
    End Sub

    'Open corresponding form when user double-clicks a record in the DGV
    Private Sub dgvTissueTaskers_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTissueTaskers.CellDoubleClick
        WarehouseShell.RecordID = dgvTissueTaskers.SelectedRows(0).Cells("TaskID").Value
        WarehouseShell.LoadWorkingAreaForm(WarehouseShell.formType.WA_TissueTasker)
    End Sub

    'Define button click events
    'Filter events
    Private Sub chkFilterTasks_CheckedChanged(sender As Object, e As EventArgs) Handles chkFilterTasks.CheckedChanged
        If chkFilterTasks.Checked = True Then
            taskbs.Filter = "[Date Completed] is null"
            chkFilterTasks.Text = "Show Completed Tasks"
        Else
            taskbs.Filter = ""
            chkFilterTasks.Text = "Hide Completed Tasks"
        End If
    End Sub
    Private Sub chkShowMyTasks_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowMyTasks.CheckedChanged
        Dim cmd As New SqlCommand("select Name from refUser where UserName = '" & WarehouseShell.userName & "';", WarehouseShell.conn)
        Dim AssignedTo As String = cmd.ExecuteScalar.ToString
        If chkShowMyTasks.Checked = True Then
            taskbs.Filter = "([Assigned To 1] = '" & AssignedTo & "' or [Assigned To 2] = '" & AssignedTo & "') and [Date Completed] is null"
            chkShowMyTasks.Text = "Show All Tasks"
        Else
            taskbs.Filter = ""
            chkShowMyTasks.Text = "Show My Open Tasks"
        End If
    End Sub
    Private Sub btnFilterDGV_Click(sender As Object, e As EventArgs) Handles btnFilterDGV.Click
        'Check to see if the filter box has a value
        If txtFilterString.Text = "" Then
            taskbs.Filter = "" 'empty string filter returns all records from the binding source
        Else
            'Return all the records that contain the provided string in ANY of the following fields: Project, SubProject, RequestingPI, POCName, ProjectTitle
            taskbs.Filter = "Project like '%" & txtFilterString.Text & "%' or SubProject like '%" & txtFilterString.Text & "%'" & IIf(IsNumeric(txtFilterString.Text), " or TaskID = " & txtFilterString.Text, "")
        End If
    End Sub
    Private Sub txtFilterString_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilterString.KeyDown
        'If the user presses the Enter key while in the filter text box, apply filter
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnFilterDGV.PerformClick()
        End If
    End Sub
    Private Sub btnResetDGV_Click(sender As Object, e As EventArgs) Handles btnResetDGV.Click
        'Clear the filter text box and apply the empty filter (returning all records)
        txtFilterString.Text = ""
        btnFilterDGV.PerformClick()
    End Sub
    Private Sub btnAddTissueTasker_Click(sender As Object, e As EventArgs) Handles btnAddTissueTasker.Click
        If User.PermissionCheck("WA_TissueTaskerReport", "Modify") Then
            PU_TissueProjectsWOTaskers.Show()
        End If
    End Sub

    'Imported IFormMethods interface methods (some used, some not, based on which form is using the interface)
    Public Sub ShowPHI(showPHI As Boolean) Implements IFormMethods.ShowPHI
    End Sub
    Public Sub Parent1(ByRef val As Object) Implements IFormMethods.Parent
        Me.Parent = val
    End Sub
    Public Sub Show1() Implements IFormMethods.Show
        Me.Show()
    End Sub
    Public Sub TopLevel1(val As Boolean) Implements IFormMethods.TopLevel
        Me.TopLevel = val
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Me.Dispose()
    End Sub
End Class