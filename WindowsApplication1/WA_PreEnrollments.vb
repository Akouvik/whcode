Imports System.Reflection
Imports Microsoft.Office.Interop

Public Class WA_PreEnrollments
    Implements IFormMethods

    'Private formTables As New DataSet
    Private Results As DataTable
    Private Reader As SqlDataAdapter

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Dim _assembly As Assembly = Assembly.GetExecutingAssembly()
        eqModel.LoadFromStream(_assembly.GetManifestResourceStream("DataWarehouse.modelViewPreEnrollmentsReport.xml"))
    End Sub
    Private Sub WA_PreEnrollments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        Results = New DataTable("Result")
        Reader = New SqlDataAdapter("Select * from viewPreEnrollmentsReport", WarehouseShell.conn)
        Reader.Fill(Results)
        formatDGV()
    End Sub
    Private Sub dgvEnrollments_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEnrollments.CellDoubleClick
        Dim SubNum As Integer = dgvEnrollments.SelectedRows(0).Cells("SubNum").Value
        Dim pu As New PU_PreEnrollmentDetail(SubNum)
        pu.ShowDialog()
        pu.Dispose()
        btnQuery.PerformClick() 'cheap way to get updated data set so user can see changes from popup
        formatDGV()
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
    End Sub

    Private Sub formatDGV()
        dgvEnrollments.DataSource = Results


        dgvEnrollments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        'change selected row color
        dgvEnrollments.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue

        ShowPHI(WarehouseShell.ShowingPHI)
        Label2.Text = "Row Count: " & dgvEnrollments.Rows.Count
    End Sub

    Private Sub btnQuery_Click(sender As Object, e As EventArgs) Handles btnQuery.Click
        Dim builder As New Korzh.EasyQuery.Db.SqlQueryBuilder(eqQuery)
        If builder.CanBuild Then
            builder.BuildSQL()
            Dim sql As String = builder.Result.SQL
            Results = New DataTable("Result")
            Try
                Reader = New SqlDataAdapter(sql, WarehouseShell.conn)
                Reader.Fill(Results)
                'code here to generate rownums
                formatDGV()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        pnlQuery.Query.Clear()
        Results = New DataTable("Result")
        Reader = New SqlDataAdapter("Select * from viewPreEnrollmentsReport", WarehouseShell.conn)
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
            shXL.Range("A1").Value = "SubNum"
            shXL.Range("B1").Value = "BB"
            shXL.Range("C1").Value = "First Name"
            shXL.Range("D1").Value = "Last Name"
            shXL.Range("E1").Value = "Date Interested"
            shXL.Range("F1").Value = "Welcome Sent Dt"
            shXL.Range("G1").Value = "Welcome Rec Dt"
            shXL.Range("H1").Value = "Enrolled By"
            shXL.Range("I1").Value = "Referral Source"
            shXL.Range("J1").Value = "Referral Source Spec"
            shXL.Range("K1").Value = "Date of Death"
            Dim i As Integer = 1
            Dim resultsRow As DataGridViewRow
            For Each resultsRow In dgvEnrollments.Rows()
                shXL.Range("A" & i + 1).Value = resultsRow.Cells("SubNum").Value.ToString
                shXL.Range("B" & i + 1).Value = resultsRow.Cells("BB").Value.ToString
                shXL.Range("C" & i + 1).Value = IIf(WarehouseShell.ShowingPHI, resultsRow.Cells("First Name").Value.ToString, "*****")
                shXL.Range("D" & i + 1).Value = IIf(WarehouseShell.ShowingPHI, resultsRow.Cells("Last Name").Value.ToString, "*****")
                shXL.Range("E" & i + 1).Value = resultsRow.Cells("Date Interested").Value.ToString
                shXL.Range("F" & i + 1).Value = resultsRow.Cells("Welcome Sent Dt").Value.ToString
                shXL.Range("G" & i + 1).Value = resultsRow.Cells("Welcome Rec Dt").Value.ToString
                shXL.Range("H" & i + 1).Value = resultsRow.Cells("Enrolled By").Value.ToString
                shXL.Range("I" & i + 1).Value = resultsRow.Cells("Referral Source").Value.ToString
                shXL.Range("J" & i + 1).Value = resultsRow.Cells("Referral Source Spec").Value.ToString
                shXL.Range("K" & i + 1).Value = IIf(WarehouseShell.ShowingPHI, resultsRow.Cells("Date of Death").Value.ToString, "*****")

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

    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
    End Sub
    Public Sub ShowPHI(val As Boolean) Implements IFormMethods.ShowPHI
        dgvEnrollments.Columns("First Name").Visible = val
        dgvEnrollments.Columns(" First Name").Visible = Not val
        dgvEnrollments.Columns("Last Name").Visible = val
        dgvEnrollments.Columns(" Last Name").Visible = Not val
        dgvEnrollments.Columns("Date of Death").Visible = val
        dgvEnrollments.Columns(" Date of Death").Visible = Not val
    End Sub
    Public Sub TopLevel(val As Boolean) Implements IFormMethods.TopLevel
    End Sub
    Private Sub IFormMethods_Parent(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Private Sub IFormMethods_Show() Implements IFormMethods.Show
        Show()
    End Sub
End Class