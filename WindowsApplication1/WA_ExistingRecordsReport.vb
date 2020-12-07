Imports Korzh.EasyQuery.Db
Imports System.Reflection
Imports Microsoft.Office.Interop

Public Class WA_ExistingRecordsReport
    Implements IFormMethods
    Private Results As DataTable
    Private Reader As SqlDataAdapter

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Dim _assembly As Assembly = Assembly.GetExecutingAssembly()
        eqModel.LoadFromStream(_assembly.GetManifestResourceStream("DataWarehouse.modelExistingRecordsReport.xml"))
    End Sub
    Private Sub WA_ExistingRecordsReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Results = New DataTable("Result")
        Reader = New SqlDataAdapter("Select * from viewExistingRecordsReport", WarehouseShell.conn)
        Reader.Fill(Results)
        formatDGVHeader()
        updateRowCount()
    End Sub
    Private Sub dgvExistingRecordsReport_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs) Handles dgvExistingRecordsReport.CellPainting
        If e.RowIndex = -1 Then
            e.PaintBackground(e.CellBounds, True)
            e.Graphics.TranslateTransform(e.CellBounds.Left, e.CellBounds.Bottom)
            e.Graphics.RotateTransform(270)
            e.Graphics.DrawString(e.FormattedValue, e.CellStyle.Font, Brushes.Black, 5, 5)
            e.Graphics.ResetTransform()
            e.Handled = True
        End If
    End Sub
    Private Sub formatDGVHeader()
        dgvExistingRecordsReport.DataSource = Results
        dgvExistingRecordsReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvExistingRecordsReport.ColumnHeadersHeight = 125
        For Each column As DataGridViewColumn In dgvExistingRecordsReport.Columns()
            column.Width = 22
        Next
        dgvExistingRecordsReport.Columns("BB").Width = 45
        dgvExistingRecordsReport.Columns("XENum").Width = 60
        dgvExistingRecordsReport.Columns("CERAD_IJ").Width = 30
        dgvExistingRecordsReport.Columns("PMCR_Date").Width = 75
        dgvExistingRecordsReport.Columns("Diagnoses").Width = 30
        dgvExistingRecordsReport.Columns("Labs").Width = 30
        dgvExistingRecordsReport.Columns("Medications").Width = 30
        dgvExistingRecordsReport.Columns("Age").Width = 30
        dgvExistingRecordsReport.Columns("CDR").Width = 30
        dgvExistingRecordsReport.Columns("HarryNP1").Width = 40
        dgvExistingRecordsReport.Columns("MeanPlaques").Width = 40
        dgvExistingRecordsReport.Columns("pH").Width = 40
        dgvExistingRecordsReport.Columns("Braak").Width = 35
        dgvExistingRecordsReport.Columns("ApoE").Width = 30
        dgvExistingRecordsReport.Columns("Harry NP Text").Width = 75
        dgvExistingRecordsReport.Sort(dgvExistingRecordsReport.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub btnQuery_Click(sender As Object, e As EventArgs) Handles btnQuery.Click
        Dim builder As New SqlQueryBuilder(eqQuery)
        If builder.CanBuild Then
            builder.BuildSQL()
            Dim sql As String = builder.Result.SQL
            Results = New DataTable("Result")
            Try
                Reader = New SqlDataAdapter(sql, WarehouseShell.conn)
                Reader.Fill(Results)
                'code here to generate rownums
                formatDGVHeader()
                updateRowCount()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        pnlQuery.Query.Clear()
        Results = New DataTable("Result")
        Reader = New SqlDataAdapter("Select * from viewExistingRecordsReport", WarehouseShell.conn)
        Reader.Fill(Results)
        formatDGVHeader()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        generateExcel()
    End Sub
    Private Sub generateExcel()
        Dim resultsRowCount As Integer = Results.Rows.Count
        Try
            MsgBox("An Excel sheet will now be opened on your computer. Please allow 1 minute or more for the sheet to be generated. Check the taskbar at the bottom of your screen if you do not see the Excel form when you click OK below.", MsgBoxStyle.OkOnly)
            Dim appXL As Excel.Application
            Dim wbXl As Excel.Workbook
            Dim shXL As Excel.Worksheet
            ' Start Excel and get Application object.
            appXL = CreateObject("Excel.Application")
            'Add a workbook and fill it
            wbXl = appXL.Workbooks.Add
            shXL = wbXl.ActiveSheet
            shXL.Range("A1").Value = "BB"
            shXL.Range("B1").Value = "CERAD_IJ"
            shXL.Range("C1").Value = "CERAD_Addendum"
            shXL.Range("D1").Value = "PMCR_Date"
            shXL.Range("E1").Value = "Diagnoses"
            shXL.Range("F1").Value = "Labs"
            shXL.Range("G1").Value = "Medications"
            shXL.Range("H1").Value = "Age"
            shXL.Range("I1").Value = "NBTRCohort"
            shXL.Range("J1").Value = "ADRCCohort"
            shXL.Range("K1").Value = "PPGCohort"
            shXL.Range("L1").Value = "SchizoCohort"
            shXL.Range("M1").Value = "TBICohort"
            shXL.Range("N1").Value = "Race"
            shXL.Range("O1").Value = "Sex"
            shXL.Range("P1").Value = "HarryNP1"
            shXL.Range("Q1").Value = "MeanPlaques"
            shXL.Range("R1").Value = "pH"
            shXL.Range("S1").Value = "Braak"
            shXL.Range("T1").Value = "ApoE"
            shXL.Range("U1").Value = "NP_Report_Text"
            Dim i As Integer = 1
            Dim resultsRow As DataRow
            For Each resultsRow In Results.Rows()
                shXL.Range("A" & i + 1).Value = resultsRow("BB")
                shXL.Range("B" & i + 1).Value = resultsRow("CERAD_IJ")
                shXL.Range("C" & i + 1).Value = resultsRow("CERAD_Addendum")
                shXL.Range("D" & i + 1).Value = resultsRow("PMCR_Date")
                shXL.Range("E" & i + 1).Value = resultsRow("Diagnoses")
                shXL.Range("F" & i + 1).Value = resultsRow("Labs")
                shXL.Range("G" & i + 1).Value = resultsRow("Medications")
                shXL.Range("H" & i + 1).Value = resultsRow("Age")
                shXL.Range("I" & i + 1).Value = resultsRow("NBTRCohort")
                shXL.Range("J" & i + 1).Value = resultsRow("ADRCCohort")
                shXL.Range("K" & i + 1).Value = resultsRow("PPGCohort")
                shXL.Range("L" & i + 1).Value = resultsRow("SchizoCohort")
                shXL.Range("M" & i + 1).Value = resultsRow("TBICohort")
                shXL.Range("N" & i + 1).Value = resultsRow("Race")
                shXL.Range("O" & i + 1).Value = resultsRow("Sex")
                shXL.Range("P" & i + 1).Value = resultsRow("HarryNP1")
                shXL.Range("Q" & i + 1).Value = resultsRow("MeanPlaques")
                shXL.Range("R" & i + 1).Value = resultsRow("pH")
                shXL.Range("S" & i + 1).Value = resultsRow("Braak")
                shXL.Range("T" & i + 1).Value = resultsRow("ApoE")
                shXL.Range("U" & i + 1).Value = resultsRow("NP_Report_Text")
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

    Private Sub dgvExistingRecordsReport_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvExistingRecordsReport.CellDoubleClick
        If e.ColumnIndex = 22 Then
            Dim result As String = dgvExistingRecordsReport(e.ColumnIndex, e.RowIndex).Value.ToString()
            If result <> "" Then
                MsgBox(result, MsgBoxStyle.OkOnly, "Harry NP Full Text")
            End If
        End If
    End Sub

    Private Sub updateRowCount()
        lblNumRows.Text = "Row Count: " & Results.Rows.Count
    End Sub

    'Imported IFormMethods
    Public Sub ShowPHI(showPHI As Boolean) Implements IFormMethods.ShowPHI
    End Sub
    Public Sub Parent1(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Public Sub Show1() Implements IFormMethods.Show
        Show()
    End Sub
    Public Sub TopLevel1(val As Boolean) Implements IFormMethods.TopLevel
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class