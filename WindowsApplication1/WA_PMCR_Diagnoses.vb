Imports System.Reflection
Imports Microsoft.Office.Interop

Public Class WA_PMCR_Diagnoses
    Implements IFormMethods
    Private formTables As New DataSet
    Private Results As DataTable
    Private Reader As SqlDataAdapter
    Private bs As BindingSource
    Private bsFilter As String = ""
    Public recordID As String = Nothing 'general use text string

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Dim _assembly As Assembly = Assembly.GetExecutingAssembly()
        eqModel.LoadFromStream(_assembly.GetManifestResourceStream("DataWarehouse.modelViewDiagnoses.xml"))
    End Sub

    Private Sub WA_PMCR_Diagnoses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        loadBaseForm()
        Results = New DataTable("Result")
        Reader = New SqlDataAdapter("Select * from viewDiagnoses where SubNum = " & WarehouseShell.SubNum, WarehouseShell.conn)
        Reader.Fill(Results)
        formatDGV()
        'Special case- Always loads in view (button calls within tab control view mode)
        btnDxChange.Visible = False
        btnDxSave.Visible = False
        txtDxTextSearch.Focus()
    End Sub
    Private Function saveRecord(ByVal sqlCmdString As String, saveType As String) As Boolean
        Try
            Dim sqlCommand As New SqlCommand
            Dim returnedValue As Object
            sqlCommand.CommandText = sqlCmdString
            sqlCommand.Connection = WarehouseShell.conn
            returnedValue = sqlCommand.ExecuteScalar()
            'return an appropriate response for the type of action completed
            If saveType = "Insert" Then
                MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ElseIf saveType = "Update" Then
                MessageBox.Show("Record was successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
            'set the datamode back to view
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            Return True
        Catch ex As SqlException
            ExceptionHandler.CatchSQLException(ex)
            Return False
        End Try
    End Function
    Private Sub loadBaseForm()
        If formTables.Tables.Contains("lkpDiagnosesDxMethod") Then
            formTables.Tables.Remove("lkpDiagnosesDxMethod")
        End If
        'Grab any required comboLookUp tables and assign them to their appropriate boxes
        formTables.Tables.Add(Database.ReturnTable("lkpDiagnosesDxMethod"))
        cmbDxMethod.assignLookup(formTables, "lkpDiagnosesDxMethod")
        'Set defaults for ALL controls
        txtDx.Clear()
        txtDxDate.Clear()
        txtDxCode.Clear()
        cmbDxMethod.SelectedValue = -1
        txtDxTextSearch.Clear()
        txtDxCodeSearch.Clear()
        chkBrainClin.Checked = False
        txtBrainRelatedRank.Clear()
    End Sub
    Private Sub formatDGV()
        'dgvDx.DataSource = Nothing
        bs = New BindingSource
        bs.DataSource = Results
        dgvDx.DataSource = bs
        dgvDx.Columns("DxMethodValue").Visible = False
        dgvDx.Columns("RecordID").Visible = False
        bs.Filter = bsFilter
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        txtDxDate.Enabled = False
        cmbDxMethod.Enabled = False
        chkBrainClin.Enabled = False
        txtBrainRelatedRank.Enabled = False
        btnDxChange.Visible = False
        btnRemoveDx.Visible = False
        btnDxSave.Visible = False
        lblDxTextSearch.Text = "Search New Diagnosis"
        lblDxCodeSearch.Text = "Add By Code"
        txtDxTextSearch.Focus()
        updateRowCount()
    End Sub
    Private Sub btnShowBrainOnly_Click(sender As Object, e As EventArgs) Handles btnShowBrainOnly.Click
        If btnShowBrainOnly.Text = "Show Only Brain Related Dx's" Then
            bsFilter = "[Brain Related] = 1"
            btnShowBrainOnly.Text = "Show All Dx's"
        Else
            bsFilter = ""
            btnShowBrainOnly.Text = "Show Only Brain Related Dx's"
        End If
        formatDGV()
    End Sub
    Private Sub dgvDx_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDx.CellDoubleClick
        'Handle unsaved work if exists
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
            Dim checkform As New PU_SaveWork
            Dim myResult As DialogResult = checkform.ShowDialog
            checkform.Dispose()
            If myResult = Windows.Forms.DialogResult.OK Then
                btnDxSave.PerformClick()
            ElseIf myResult = DialogResult.Cancel Then
                Exit Sub
            End If
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            btnDxChange.Visible = True
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit Then
            Dim checkform As New PU_SaveWork
            Dim myResult As DialogResult = checkform.ShowDialog
            checkform.Dispose()
            If myResult = Windows.Forms.DialogResult.OK Then
                btnDxSave.PerformClick()
            ElseIf myResult = DialogResult.Cancel Then
                Exit Sub
            End If
        End If
        recordID = dgvDx.SelectedRows(0).Cells("RecordID").Value.ToString
        'Set the text boxes to the selected values
        txtDx.Text = dgvDx.SelectedRows(0).Cells("Dx").Value.ToString
        If IsDate(dgvDx.SelectedRows(0).Cells("DxDate").Value) Then
            txtDxDate.Text = Format(dgvDx.SelectedRows(0).Cells("DxDate").Value, "MMddyyyy").ToString
        Else
            txtDxDate.Clear()
        End If
        txtDxCodeType.Text = dgvDx.SelectedRows(0).Cells("DxCodeType").Value.ToString
        txtDxCode.Text = dgvDx.SelectedRows(0).Cells("DxCode").Value.ToString
        cmbDxMethod.SelectedValue = dgvDx.SelectedRows(0).Cells("DxMethodValue").Value
        chkBrainClin.Checked = dgvDx.SelectedRows(0).Cells("Brain Related").Value
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        btnDxChange.Visible = True
        btnRemoveDx.Visible = True
        txtDxDate.Enabled = False
        cmbDxMethod.Enabled = False
    End Sub
    Private Sub txtDxTextSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDxTextSearch.KeyDown, txtDxCodeSearch.KeyDown, txtDxDate.KeyDown, cmbDxMethod.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnDxSearch.PerformClick()
        End If
    End Sub
    Private Sub btnDxSearch_Click(sender As Object, e As EventArgs) Handles btnDxSearch.Click
        If User.PermissionCheck("WA_PMCR_Diagnoses", "Modify") Then
            Dim PU As New PU_AddDx("Clin", txtDxTextSearch.Text)
            PU.ShowDialog()
            If PU.DxAdded = True Then
                btnQuery.PerformClick()
            End If
            PU.Dispose()
        End If
    End Sub
    Private Sub btnDxChange_Click(sender As Object, e As EventArgs) Handles btnDxChange.Click
        If User.PermissionCheck("WA_PMCR_Diagnoses", "Modify") Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
            txtDxDate.Enabled = True
            cmbDxMethod.Enabled = True
            chkBrainClin.Enabled = True
            txtBrainRelatedRank.Enabled = True
            btnDxSave.Visible = True
            lblDxTextSearch.Text = "Search Modified Diagnosis"
            lblDxCodeSearch.Text = "Change Diagnosis By Code"
        End If
    End Sub
    Private Sub btnRemoveDx_Click(sender As Object, e As EventArgs) Handles btnRemoveDx.Click
        If User.PermissionCheck("WA_PMCR_Diagnoses", "Modify") Then
            Dim checkDelete As DialogResult = MsgBox("Are you sure you want to delete this diagnosis?", MsgBoxStyle.OkCancel)
            If checkDelete = DialogResult.OK Then
                Dim sqlCmd As New SqlCommand("delete from Diagnoses where SubNum = " & WarehouseShell.SubNum & " and RecordID = " & recordID & ";", WarehouseShell.conn)
                Try
                    sqlCmd.ExecuteNonQuery()
                    MsgBox("Record successfully removed.", MsgBoxStyle.OkOnly)
                    loadBaseForm()
                    formatDGV()
                Catch ex As SqlException
                    ExceptionHandler.CatchSQLException(ex)
                End Try
            End If
        End If
    End Sub
    Private Sub btnDxSave_Click(sender As Object, e As EventArgs) Handles btnDxSave.Click
        If preSaveValidation() Then 'If preSaveValidation returns true, take Insert or Update actions.
            Dim parameters = "@RecordID = " & recordID &
                ", @SubNum = " & WarehouseShell.SubNum &
                ", @Dx = " & txtDx.getSQLValue() &
                ", @DXDate = " & txtDxDate.getSQLValue() &
                ", @DxCodeType = " & txtDxCodeType.getSQLValue() &
                ", @DxCode = " & txtDxCode.getSQLValue() &
                ", @DxMethod = " & cmbDxMethod.getSQLValue() &
                ", @BrainClin = " & chkBrainClin.getSQLValue() &
                ", @BrainClinRank = " & txtBrainRelatedRank.getSQLValue() &
                ";"
            If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                Dim cmdString = "Exec modDiagnosesRecord @Action = 1, " & parameters
                saveRecord(cmdString, "Insert")
            ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit Then
                Dim cmdString = "Exec modDiagnosesRecord @Action = 2, " & parameters
                saveRecord(cmdString, "Update")
            End If
            loadBaseForm()
            btnQuery.PerformClick()
        End If
    End Sub
    Private Function preSaveValidation() As Boolean
        Return True
    End Function
    Private Sub updateRowCount()
        lblNumRows.Text = "Row Count: " & dgvDx.Rows.Count
    End Sub
    Private Sub btnQuery_Click(sender As Object, e As EventArgs) Handles btnQuery.Click
        Dim builder As New Korzh.EasyQuery.Db.SqlQueryBuilder(eqQuery)
        If builder.CanBuild Then
            builder.BuildSQL()
            Dim sql As String = builder.Result.SQL & " and SubNum = " & WarehouseShell.SubNum 'limit query to current subject
            Results = New DataTable("Result")
            Try
                Reader = New SqlDataAdapter(sql, WarehouseShell.conn)
                Reader.Fill(Results)
                formatDGV()
                updateRowCount()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            btnReset.PerformClick()
        End If
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        pnlQuery.Query.Clear()
        Results = New DataTable("Result")
        Reader = New SqlDataAdapter("Select * from viewDiagnoses where SubNum = " & WarehouseShell.SubNum, WarehouseShell.conn)
        Reader.Fill(Results)
        formatDGV()
        updateRowCount()
    End Sub
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim resultsRowCount As Integer = Results.Rows.Count
        Try
            MsgBox("An Excel sheet will now be opened on your computer. Check the taskbar at the bottom of your screen if you do not see the Excel form when you click OK below.", MsgBoxStyle.OkOnly)
            Dim appXL As Excel.Application
            Dim wbXl As Excel.Workbook
            Dim shXL As Excel.Worksheet
            'Start Excel And get Application object.
            appXL = CreateObject("Excel.Application")
            'Add a workbook And fill it
            wbXl = appXL.Workbooks.Add
            shXL = wbXl.ActiveSheet
            shXL.Range("A1").Value = "SubNum"
            shXL.Range("B1").Value = "Dx"
            shXL.Range("C1").Value = "DX Date"
            shXL.Range("D1").Value = "Dx Code Type"
            shXL.Range("E1").Value = "Dx Code"
            shXL.Range("F1").Value = "Dx Method"
            shXL.Range("G1").Value = "Brain Related"
            shXL.Range("H1").Value = "Brain Related Rank"
            Dim i As Integer = 2
            Dim resultsRow As DataRow
            For Each resultsRow In Results.Rows()
                shXL.Range("A" & i).Value = resultsRow("SubNum")
                shXL.Range("B" & i).Value = resultsRow("Dx")
                shXL.Range("C" & i).Value = resultsRow("DxDate")
                shXL.Range("D" & i).Value = resultsRow("DxCodeType")
                shXL.Range("E" & i).Value = resultsRow("DxCode")
                shXL.Range("F" & i).Value = resultsRow("DxMethod")
                shXL.Range("G" & i).Value = resultsRow("Brain Related")
                shXL.Range("H" & i).Value = resultsRow("BrainClinRank")
                i += 1
            Next

            'Hand off the filled Excel file to the user
            appXL.Visible = True
            appXL.UserControl = True
            'Release the resources
            shXL = Nothing
            wbXl = Nothing
        Catch ex As Exception
            ExceptionHandler.CatchWindowsException(ex)
        End Try
    End Sub

    'Imported IForm Methods
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
    Public Sub Parent1(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        btnDxSave.PerformClick()
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