Public Class WA_PMCR_AD8
    Implements IFormMethods
    Private formTables As New DataSet

    Private Sub WA_PMCR_AD8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_PMCR_tabAD8")
        enableInputFields(False)
        If Database.ExistingRecordCheck("PMCR_AD8", "SubNum = " & WarehouseShell.SubNum) Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            loadBase()
            loadExistingData()
            btnAD8Bottom.Text = "Edit Record"
            btnAD8Top.Text = btnAD8Bottom.Text
        Else
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            btnAD8Bottom.Text = "Add New Record"
            btnAD8Top.Text = btnAD8Bottom.Text
            lblNoRecord.Visible = True
        End If
    End Sub
    Private Sub loadBase()
        WarehouseShell.highlightSelectedNode("WA_PMCR_tabAD8")
        formTables.Tables.Add(Database.ReturnTable("lkpPMCR_AD8", , , "Value"))
        cmbAD81.assignLookup(formTables, "lkpPMCR_AD8")
        cmbAD82.assignLookup(formTables, "lkpPMCR_AD8")
        cmbAD83.assignLookup(formTables, "lkpPMCR_AD8")
        cmbAD84.assignLookup(formTables, "lkpPMCR_AD8")
        cmbAD85.assignLookup(formTables, "lkpPMCR_AD8")
        cmbAD86.assignLookup(formTables, "lkpPMCR_AD8")
        cmbAD87.assignLookup(formTables, "lkpPMCR_AD8")
        cmbAD88.assignLookup(formTables, "lkpPMCR_AD8")
    End Sub
    Private Sub setDefaultValues()
        cmbAD81.SelectedValue = 0
        cmbAD82.SelectedValue = 0
        cmbAD83.SelectedValue = 0
        cmbAD84.SelectedValue = 0
        cmbAD85.SelectedValue = 0
        cmbAD86.SelectedValue = 0
        cmbAD87.SelectedValue = 0
        cmbAD88.SelectedValue = 0
    End Sub
    Private Sub loadExistingData() 'load all non-DGV values (handle DGV loads with separate subs)
        'Grab the individual record, based on RecordID, and assign values to their appropriate fields
        formTables.Tables.Add(Database.ReturnTable("PMCR_AD8", , "SubNum = " & WarehouseShell.SubNum))
        cmbAD81.SelectedValue = formTables.Tables("PMCR_AD8").Rows(0).Item("Q1")
        cmbAD82.SelectedValue = formTables.Tables("PMCR_AD8").Rows(0).Item("Q2")
        cmbAD83.SelectedValue = formTables.Tables("PMCR_AD8").Rows(0).Item("Q3")
        cmbAD84.SelectedValue = formTables.Tables("PMCR_AD8").Rows(0).Item("Q4")
        cmbAD85.SelectedValue = formTables.Tables("PMCR_AD8").Rows(0).Item("Q5")
        cmbAD86.SelectedValue = formTables.Tables("PMCR_AD8").Rows(0).Item("Q6")
        cmbAD87.SelectedValue = formTables.Tables("PMCR_AD8").Rows(0).Item("Q7")
        cmbAD88.SelectedValue = formTables.Tables("PMCR_AD8").Rows(0).Item("Q8")
        txtAD8Total.Text = formTables.Tables("PMCR_AD8").Rows(0).Item("Score").ToString
    End Sub
    Private Sub enableInputFields(ByVal bool As Boolean)
        If bool = True Then
            cmbAD81.Enabled = True
            cmbAD82.Enabled = True
            cmbAD83.Enabled = True
            cmbAD84.Enabled = True
            cmbAD85.Enabled = True
            cmbAD86.Enabled = True
            cmbAD87.Enabled = True
            cmbAD88.Enabled = True
        Else
            cmbAD81.Enabled = False
            cmbAD82.Enabled = False
            cmbAD83.Enabled = False
            cmbAD84.Enabled = False
            cmbAD85.Enabled = False
            cmbAD86.Enabled = False
            cmbAD87.Enabled = False
            cmbAD88.Enabled = False
        End If
    End Sub

    Private Sub btnAD8Bottom_Click(sender As Object, e As EventArgs) Handles btnAD8Bottom.Click, btnAD8Top.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_PMCR_AD8", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                btnAD8Bottom.Text = "Save Changes"
                btnAD8Top.Text = btnAD8Bottom.Text
                enableInputFields(True)
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If User.PermissionCheck("WA_PMCR_AD8", "Modify") Then
                lblNoRecord.Visible = False
                loadBase()
                btnAD8Top.Text = "Save Record"
                btnAD8Bottom.Text = btnAD8Top.Text
                enableInputFields(True)
                ActiveControl = cmbAD81
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
            End If
        Else 'By default, user is attempting to Insert or Edit a record. Run preSaveValidation.
            If preSaveValidation() Then 'If preSaveValidation returns true, take Insert or Update actions (based on dataMode).

                'Same parameters for Insert or Update SP's, so define here
                Dim cmd As New SqlCommand("", WarehouseShell.conn)
                Dim parameters = " @SubNum = " & WarehouseShell.SubNum &
                    ", @Q1 = " & cmbAD81.getSQLValue() &
                    ", @Q2 = " & cmbAD82.getSQLValue() &
                    ", @Q3 = " & cmbAD83.getSQLValue() &
                    ", @Q4 = " & cmbAD84.getSQLValue() &
                    ", @Q5 = " & cmbAD85.getSQLValue() &
                    ", @Q6 = " & cmbAD86.getSQLValue() &
                    ", @Q7 = " & cmbAD87.getSQLValue() &
                    ", @Q8 = " & cmbAD88.getSQLValue() &
                    ", @Score = " & txtAD8Total.getSQLValue() &
                    ", @LastModBy = '" & WarehouseShell.userName & "';"

                'Prepend Exec & @Action based on Insert/Edit
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    parameters = "Exec modPMCR_AD8Record @Action = 1, " & parameters
                Else 'If this clause is invoked, datamode must be Edit
                    parameters = "Exec modPMCR_AD8Record @Action = 2, " & parameters
                End If

                'Execute statement and set/return form state to View
                Try
                    cmd.CommandText = parameters
                    cmd.ExecuteNonQuery()
                    MsgBox("Record saved.", MsgBoxStyle.OkOnly)
                    enableInputFields(False)
                    WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                Catch ex As SqlException
                    ExceptionHandler.CatchSQLException(ex)
                End Try
            End If
        End If
    End Sub
    Private Function preSaveValidation() As Boolean
        Return True
    End Function

    'Score autocalc sub
    Private Sub cmbAD8_LostFocus(sender As Object, e As EventArgs) Handles cmbAD81.LostFocus, cmbAD82.LostFocus, cmbAD83.LostFocus, cmbAD84.LostFocus, cmbAD85.LostFocus, cmbAD86.LostFocus, cmbAD87.LostFocus, cmbAD88.LostFocus
        Dim score As Integer =
            IIf(cmbAD81.SelectedValue = 1, 1, 0) +
            IIf(cmbAD82.SelectedValue = 1, 1, 0) +
            IIf(cmbAD83.SelectedValue = 1, 1, 0) +
            IIf(cmbAD84.SelectedValue = 1, 1, 0) +
            IIf(cmbAD85.SelectedValue = 1, 1, 0) +
            IIf(cmbAD86.SelectedValue = 1, 1, 0) +
            IIf(cmbAD87.SelectedValue = 1, 1, 0) +
            IIf(cmbAD88.SelectedValue = 1, 1, 0)
        txtAD8Total.Text = score.ToString
    End Sub

    'Imported IForm Methods
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
    Public Sub Parent1(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        btnAD8Bottom.PerformClick()
    End Sub
    Public Sub Show1() Implements IFormMethods.Show
        Show()
    End Sub
    Public Sub ShowPHI(val As Boolean) Implements IFormMethods.ShowPHI
    End Sub
    Public Sub TopLevel(val As Boolean) Implements IFormMethods.TopLevel
        TopLevel(val)
    End Sub
End Class