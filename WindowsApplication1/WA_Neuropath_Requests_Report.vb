Imports System.Reflection
Imports Korzh.EasyQuery.Db
Imports Microsoft.Office.Interop

Public Class WA_Neuropath_Requests_Report
    Implements IFormMethods

    'Private formTables As New DataSet
    Private bs As BindingSource
    Private filterString As String = ""
    Private Results As DataTable
    Private Reader As SqlDataAdapter

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Dim _assembly As Assembly = Assembly.GetExecutingAssembly()
        eqModel.LoadFromStream(_assembly.GetManifestResourceStream("DataWarehouse.modelNeuropathRequestsReport.xml"))
    End Sub
    Private Sub WA_Neuropath_Requests_Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_Neuropath_Requests_Report")
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        Results = New DataTable("Result")
        Reader = New SqlDataAdapter("Select * from viewNeuropathRequestsReport", WarehouseShell.conn)
        Reader.Fill(Results)
        formatDGV()
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
                formatDGV()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        pnlQuery.Query.Clear()
        Results = New DataTable("Result")
        Reader = New SqlDataAdapter("Select * from viewNeuropathRequestsReport", WarehouseShell.conn)
        Reader.Fill(Results)
        formatDGV()
    End Sub
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
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
            shXL.Range("A1").Value = "ID"
            shXL.Range("B1").Value = "SubNum"
            shXL.Range("C1").Value = "BB"
            shXL.Range("D1").Value = "Request Type"
            shXL.Range("E1").Value = "Delivery Method"
            shXL.Range("F1").Value = "NP Report Exists"
            shXL.Range("G1").Value = "Mailer Ready"
            shXL.Range("H1").Value = "Date Sent"
            shXL.Range("I1").Value = "Sent By"
            Dim i As Integer = 1
            Dim resultsRow As DataGridViewRow 'DataRow
            For Each resultsRow In dgvRequests.Rows()
                shXL.Range("A" & i + 1).Value = resultsRow.Cells("ID").Value.ToString
                shXL.Range("B" & i + 1).Value = resultsRow.Cells("SubNum").Value.ToString
                shXL.Range("C" & i + 1).Value = resultsRow.Cells("BB").Value.ToString
                shXL.Range("D" & i + 1).Value = resultsRow.Cells("Request Type").Value.ToString
                shXL.Range("E" & i + 1).Value = resultsRow.Cells("Delivery Method").Value.ToString
                shXL.Range("F" & i + 1).Value = resultsRow.Cells("NP Report Exists").Value.ToString
                shXL.Range("G" & i + 1).Value = resultsRow.Cells("Mailer Ready").Value.ToString
                shXL.Range("H" & i + 1).Value = resultsRow.Cells("Date Sent").Value.ToString
                shXL.Range("I" & i + 1).Value = resultsRow.Cells("Sent By").Value.ToString
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

    Private Sub dgvRequests_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRequests.CellContentDoubleClick
        If WarehouseShell.ShowingPHI Then
            WarehouseShell.SubNum = dgvRequests.SelectedRows(0).Cells("SubNum").Value
            Dim myBB As Decimal = dgvRequests.SelectedRows(0).Cells("BB").Value
            Dim myRecordID As Integer = dgvRequests.SelectedRows(0).Cells("ID").Value
            Dim pu As New PU_NeuropathRequest(myBB, myRecordID)
            pu.ShowDialog()
            pu.Dispose()
            formatDGV()
        Else
            MsgBox("Please enable PHI before attempting to view details.", MsgBoxStyle.OkOnly, "Warning")
        End If

    End Sub
    Private Sub formatDGV()
        bs = New BindingSource
        bs.DataSource = Results
        bs.Filter = filterString
        dgvRequests.DataSource = bs
        dgvRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Label2.Text = "Row Count: " & dgvRequests.Rows.Count 'Results.Rows.Count
    End Sub

    Private Sub btnHideCompleted_Click(sender As Object, e As EventArgs) Handles btnHideCompleted.Click
        If btnHideCompleted.Text = "Hide Completed Requests" Then
            filterString = "[Date Sent] is null"
            btnHideCompleted.Text = "Show Completed Requests"
            formatDGV()
        Else
            filterString = ""
            btnHideCompleted.Text = "Hide Completed Requests"
            formatDGV()
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