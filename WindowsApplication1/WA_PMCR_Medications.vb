Imports System.Reflection
Imports Microsoft.Office.Interop

Public Class WA_PMCR_Medications
    Implements IFormMethods
    Private formTables As New DataSet
    Public RecordID As String = ""
    Public DrugID As String = ""

    Private Results As DataTable
    Private Reader As SqlDataAdapter

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Dim _assembly As Assembly = Assembly.GetExecutingAssembly()
        eqModel.LoadFromStream(_assembly.GetManifestResourceStream("DataWarehouse.modelViewMedications.xml"))
    End Sub

    Private Sub WA_PMCR_Medication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        loadBase()
        setDefaultValues()
        Results = New DataTable("Result")
        Reader = New SqlDataAdapter("Select * from viewMedications where SubNum = " & WarehouseShell.SubNum, WarehouseShell.conn)
        Reader.Fill(Results)
        formatDGV()
    End Sub
    Private Sub loadBase()
        'set or reset the form into pristine view condition
        formTables.Tables.Add(Database.ReturnTable("lkpMedicationRoutes"))
        cmbRoute.assignLookup(formTables, "lkpMedicationRoutes")
    End Sub
    Private Sub setDefaultValues()
        RecordID = ""
        DrugID = ""
        txtBrandName.Clear()
        txtGenericName.Clear()
        numDosage.Clear()
        txtDosageUnits.Clear()
        cmbRoute.SelectedValue = -1
        dtStarted.Clear()
        dtEnded.Clear()
        btnEditMed.Enabled = False
        btnNewMed.Enabled = True
        enableInputFields(False)
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
    End Sub
    Private Sub formatDGV()
        dgvMeds.DataSource = Results
        dgvMeds.Columns("RecordID").Visible = False
        dgvMeds.Columns("SubNum").Visible = False
        dgvMeds.Columns("DrugID").Visible = False
        dgvMeds.Columns("RouteValue").Visible = False
        dgvMeds.Sort(dgvMeds.Columns("DateStarted"), System.ComponentModel.ListSortDirection.Descending)
        'DO NOT CHANGE THE AUTOSIZECOLUMNMODE. THIS CAUSES CRASHES ON SORT FOR SOME REASON!!!
        dgvMeds.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        dgvMeds.Columns("BrandName").Width = 300
        dgvMeds.Columns("GenericName").Width = 300
        updateRowCount()
    End Sub
    Private Sub updateRowCount()
        lblNumRows.Text = "Row Count: " & dgvMeds.Rows.Count
    End Sub
    Private Sub enableInputFields(ByVal bool As Boolean)
        numDosage.Enabled = bool
        txtDosageUnits.Enabled = bool
        cmbRoute.Enabled = bool
        dtStarted.Enabled = bool
        dtEnded.Enabled = bool
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
        Reader = New SqlDataAdapter("Select * from viewMedications where SubNum = " & WarehouseShell.SubNum, WarehouseShell.conn)
        Reader.Fill(Results)
        formatDGV()
        updateRowCount()
    End Sub
    Private Sub dgvMeds_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMeds.CellDoubleClick
        'Handle unsaved work if exists
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit Then
            Dim checkform As New PU_SaveWork
            Dim myResult As DialogResult = checkform.ShowDialog
            checkform.Dispose()
            If myResult = Windows.Forms.DialogResult.OK Then
                btnEditMed.PerformClick()
            ElseIf myResult = DialogResult.Cancel Then
                Exit Sub
            End If
        End If

        'Make sure at least on record is in the DGV and load it into the bottom
        If dgvMeds.SelectedRows.Count > 0 Then
            RecordID = dgvMeds.SelectedRows(0).Cells("RecordID").Value.ToString
            DrugID = dgvMeds.SelectedRows(0).Cells("DrugID").Value.ToString
            'Set the text boxes to the selected values
            txtBrandName.Text = dgvMeds.SelectedRows(0).Cells("BrandName").Value.ToString
            txtGenericName.Text = dgvMeds.SelectedRows(0).Cells("GenericName").Value.ToString
            cmbRoute.SelectedValue = dgvMeds.SelectedRows(0).Cells("RouteValue").Value
            numDosage.Text = dgvMeds.SelectedRows(0).Cells("TotalDailyDosage").Value.ToString
            txtDosageUnits.Text = dgvMeds.SelectedRows(0).Cells("DosageUnits").Value.ToString
            If IsDate(dgvMeds.SelectedRows(0).Cells("DateStarted").Value) Then
                dtStarted.Text = Format(dgvMeds.SelectedRows(0).Cells("DateStarted").Value, "MMddyyyy").ToString
            Else
                dtStarted.Clear()
            End If
            If IsDate(dgvMeds.SelectedRows(0).Cells("DateEnded").Value) Then
                dtEnded.Text = Format(dgvMeds.SelectedRows(0).Cells("DateEnded").Value, "MMddyyyy").ToString
            Else
                dtEnded.Clear()
            End If
            btnEditMed.Text = "Edit Selected Medication"
            btnEditMed.Enabled = True
        End If
    End Sub
    Private Sub btnNewMed_Click(sender As Object, e As EventArgs) Handles btnNewMed.Click
        If User.PermissionCheck("WA_PMCR_Medications", "Modify") Then
            Dim PU As New PU_AddMedication
            PU.StartPosition = FormStartPosition.CenterScreen
            PU.ShowDialog()
            PU.Dispose()
            setDefaultValues()
            btnReset.PerformClick() 'reset query to make sure newly added result shows in DGV
        End If
    End Sub
    Private Sub btnEditMed_Click(sender As Object, e As EventArgs) Handles btnEditMed.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_PMCR_Medications", "Modify") Then
                If txtGenericName.Text <> "" Then
                    WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                    numDosage.Enabled = True
                    txtDosageUnits.Enabled = True
                    cmbRoute.Enabled = True
                    dtStarted.Enabled = True
                    dtEnded.Enabled = True
                    btnEditMed.Text = "Save Changes"
                    btnNewMed.Enabled = False
                Else
                    MsgBox("Please load a drug from above (Double-click) before attempting an edit.", MsgBoxStyle.OkOnly, "Error")
                End If
            End If
        Else
            If preSaveValidation() Then
                Dim cmdString = "Exec dbo.modMedicationsRecord @Action = 2" &
                    ", @RecordID = " & RecordID &
                    ", @SubNum = " & WarehouseShell.SubNum &
                    ", @DrugID = " & DrugID &
                    ", @TotalDailyDosage = " & numDosage.getSQLValue() &
                    ", @DosageUnits = " & txtDosageUnits.getSQLValue() &
                    ", @Route = " & cmbRoute.getSQLValue() &
                    ", @DateStarted = " & dtStarted.getSQLValue() &
                    ", @DateEnded = " & dtEnded.getSQLValue() & ";"
                Dim cmd As New SqlCommand(cmdString, WarehouseShell.conn)
                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Record was successfully updated.", MsgBoxStyle.OkOnly, "Success")
                    setDefaultValues()
                    btnQuery.PerformClick()
                Catch ex As SqlException
                    ExceptionHandler.CatchSQLException(ex)
                End Try
            End If
        End If
    End Sub
    Private Sub EditMed_KeyDown(sender As Object, e As KeyEventArgs) Handles numDosage.KeyDown, txtDosageUnits.KeyDown, dtStarted.KeyDown, dtEnded.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnEditMed.PerformClick()
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        generateExcel()
    End Sub
    Private Sub generateExcel()
        Dim resultsRowCount As Integer = Results.Rows.Count
        Try
            MsgBox("An Excel sheet will now be opened on your computer. Please allow 1 minute or more for the sheet ot be generated. Check the taskbar at the bottom of your screen if you do not see the Excel form when you click OK below.", MsgBoxStyle.OkOnly)
            Dim appXL As Excel.Application
            Dim wbXl As Excel.Workbook
            Dim shXL As Excel.Worksheet
            ' Start Excel and get Application object.
            appXL = CreateObject("Excel.Application")
            'Add a workbook and fill it
            wbXl = appXL.Workbooks.Add
            shXL = wbXl.ActiveSheet
            shXL.Range("A1").Value = "BrandName"
            shXL.Range("B1").Value = "GenericName"
            shXL.Range("C1").Value = "DrugTypes"
            shXL.Range("D1").Value = "TotalDailyDosage"
            shXL.Range("E1").Value = "DosageUnits"
            shXL.Range("F1").Value = "DateStarted"
            shXL.Range("G1").Value = "DateEnded"
            shXL.Range("H1").Value = "Route"
            Dim i As Integer = 2
            Dim resultsRow As DataRow
            For Each resultsRow In Results.Rows()
                shXL.Range("A" & i).Value = resultsRow("BrandName")
                shXL.Range("B" & i).Value = resultsRow("GenericName")
                shXL.Range("C" & i).Value = resultsRow("DrugTypes")
                shXL.Range("D" & i).Value = resultsRow("TotalDailyDosage")
                shXL.Range("E" & i).Value = resultsRow("DosageUnits")
                shXL.Range("F" & i).Value = resultsRow("DateStarted")
                shXL.Range("G" & i).Value = resultsRow("DateEnded")
                shXL.Range("H" & i).Value = resultsRow("Route")
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

    Private Function preSaveValidation() As Boolean
        Dim result As Boolean = True
        Dim errMsg As String = "The following errors must be corrected before this record can be saved:" & vbNewLine & vbNewLine

        'Grab applicable date values if they exist
        Dim DoB As Date = Nothing
        Dim DoD As Date = Nothing
        Dim dateStarted As Date = Nothing
        Dim dateEnded As Date = Nothing
        If Database.ExistingRecordCheck("Subject", "SubNum = " & WarehouseShell.SubNum & " and DoB is not null") Then
            Dim cmd As New SqlCommand("select DoB from Subject where SubNum = " & WarehouseShell.SubNum, WarehouseShell.conn)
            DoB = cmd.ExecuteScalar()
        End If
        If Database.ExistingRecordCheck("AutopsyFaceSheet", "SubNum = " & WarehouseShell.SubNum & " and DateOfDeath is not null") Then
            Dim cmd As New SqlCommand("select DateOfDeath from AutopsyFaceSheet where SubNum = " & WarehouseShell.SubNum, WarehouseShell.conn)
            DoD = cmd.ExecuteScalar()
        End If
        If dtStarted.Text <> "  /  /" Then
            dateStarted = Date.Parse(dtStarted.Text)
        End If
        If dtEnded.Text <> "  /  /" Then
            dateEnded = Date.Parse(dtEnded.Text)
        End If

        'Logically compare dates
        If dateStarted <> Nothing Then
            If DoB <> Nothing Then
                If dateStarted < DoB Then
                    result = False
                    errMsg += "- Med start date cannot be before date of birth." & vbNewLine
                End If
            End If
            If DoD <> Nothing Then
                If dateStarted > DoD Then
                    result = False
                    errMsg += "- Med start date cannot be after date of death." & vbNewLine
                End If
            End If
        End If

        If dateEnded <> Nothing Then
            If DoD <> Nothing Then
                If dateEnded > DoD Then
                    result = False
                    errMsg += "- Med end date cannot be after date of death." & vbNewLine
                End If
            End If
            If DoB <> Nothing Then
                If dateEnded < DoB Then
                    result = False
                    errMsg += "- Med end date cannot be before date of birth." & vbNewLine
                End If
            End If
        End If

        If dateStarted <> Nothing And dateEnded <> Nothing Then
            If dateStarted > dateEnded Then
                result = False
                errMsg += "- Med start date cannot be greater than med end date." & vbNewLine
            End If
        End If


        'Handle result
        If result = False Then
            MsgBox(errMsg, MsgBoxStyle.OkOnly, "Error")
        End If
        Return result
    End Function

    'Imported IForm Methods
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
    Public Sub Parent1(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        btnEditMed.PerformClick()
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