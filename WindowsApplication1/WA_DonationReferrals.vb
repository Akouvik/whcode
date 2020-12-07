Imports System.Reflection
Imports Korzh.EasyQuery.Db
Imports Microsoft.Office.Interop

Public Class WA_DonationReferrals
    Implements IFormMethods
    Private formTables As New DataSet
    Private bs As New BindingSource
    Private Results As DataTable
    Private Reader As SqlDataAdapter

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Dim _assembly As Assembly = Assembly.GetExecutingAssembly()
        eqModel.LoadFromStream(_assembly.GetManifestResourceStream("DataWarehouse.modelDonationReferrals.xml"))
    End Sub
    Private Sub WA_DonationReferrals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.RecordID = Nothing
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        Results = New DataTable("Result")
        Reader = New SqlDataAdapter("Select * from viewDonationReferralTrackerGrid", WarehouseShell.conn)
        Reader.Fill(Results)
        formatDGV()
    End Sub
    Private Sub formatDGV()
        dgvReferrals.DataSource = Results
        dgvReferrals.Columns("RecordID").Visible = True

        'set column widths
        dgvReferrals.Columns("Place of Death").Width = 200
        dgvReferrals.Columns("Referral Date").Width = 80
        dgvReferrals.Columns("Referral Time").Width = 80
        dgvReferrals.Columns("Ruled Out").Width = 80
        dgvReferrals.Columns("Rule Out Criteria").Width = 135
        dgvReferrals.Columns("Rule Out Specify").Width = 150
        dgvReferrals.Columns("Approached").Width = 75
        dgvReferrals.Columns("Consented").Width = 135
        dgvReferrals.Columns("Referral Source").Width = 125
        dgvReferrals.Columns("Referral ID").Width = 80

        'change selected row color
        dgvReferrals.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue

        'Order results
        Results.DefaultView.Sort = "[Referral Date] desc, [Referral Time] desc"

        'Update row count
        Label2.Text = "Row Count: " & Results.Rows.Count
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
                formatDGV()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        pnlQuery.Query.Clear()
        Results = New DataTable("Result")
        Reader = New SqlDataAdapter("Select * from viewDonationReferralTrackerGrid", WarehouseShell.conn)
        Reader.Fill(Results)
        formatDGV()
    End Sub
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If WarehouseShell.ShowingPHI Then
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
                shXL.Range("A1").Value = "RecordID"
                shXL.Range("B1").Value = "Place of Death"
                shXL.Range("C1").Value = "Referral Date"
                shXL.Range("D1").Value = "Referral Time"
                shXL.Range("E1").Value = "Rule Out Criteria"
                shXL.Range("F1").Value = "Rule Out Specify"
                shXL.Range("G1").Value = "Approached"
                shXL.Range("H1").Value = "Consented"
                shXL.Range("I1").Value = "Referral Source"
                shXL.Range("J1").Value = "Referral ID"
                shXL.Range("K1").Value = "Received By"
                shXL.Range("L1").Value = "First Name"
                shXL.Range("M1").Value = "Last Name"
                Dim i As Integer = 1
                Dim resultsRow As DataRow
                For Each resultsRow In Results.Rows()
                    shXL.Range("A" & i + 1).Value = resultsRow("RecordID")
                    shXL.Range("B" & i + 1).Value = resultsRow("Place of Death")
                    shXL.Range("C" & i + 1).Value = resultsRow("Referral Date").ToString
                    shXL.Range("D" & i + 1).Value = resultsRow("Referral Time").ToString
                    shXL.Range("E" & i + 1).Value = resultsRow("Rule Out Criteria")
                    shXL.Range("F" & i + 1).Value = resultsRow("Rule Out Specify")
                    shXL.Range("G" & i + 1).Value = resultsRow("Approached")
                    shXL.Range("H" & i + 1).Value = resultsRow("Consented")
                    shXL.Range("I" & i + 1).Value = resultsRow("Referral Source")
                    shXL.Range("J" & i + 1).Value = resultsRow("Referral ID")
                    shXL.Range("K" & i + 1).Value = resultsRow("Received By")
                    shXL.Range("L" & i + 1).Value = resultsRow("First Name")
                    shXL.Range("M" & i + 1).Value = resultsRow("Last Name")
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
        Else
            MsgBox("Please enable PHI before attempting to export data.", MsgBoxStyle.OkOnly, "Warning")
        End If
    End Sub

    Private Sub dgvReferrals_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReferrals.CellDoubleClick
        WarehouseShell.RecordID = dgvReferrals.SelectedRows(0).Cells("RecordID").Value
        WarehouseShell.LoadWorkingAreaForm(WarehouseShell.formType.WA_DonationReferralTracker)
    End Sub
    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs) Handles btnAddRecord.Click
        If User.PermissionCheck("WA_DonationReferrals", "Modify") Then
            WarehouseShell.RecordID = Nothing
            WarehouseShell.LoadWorkingAreaForm(WarehouseShell.formType.WA_DonationReferralTracker)
        End If
    End Sub

    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
    End Sub
    Public Sub ShowPHI(val As Boolean) Implements IFormMethods.ShowPHI
        'If val Then

        'Else
        '    For Each row As DataRow In Results.Rows
        '        row("Last Name") = "PHI Hidden"
        '        row("First Name") = "PHI Hidden"
        '    Next
        'End If
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