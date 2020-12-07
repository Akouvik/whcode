Imports Microsoft.Office.Interop

Public Class WA_NBB_QTR_Admin
    Implements IFormMethods
    Private table As DataTable
    Private xlApp As Excel.Application
    Private xlBook As Excel.Workbook

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        If PreSaveValidation() Then
            GenQrtlyAdminReport(Integer.Parse(intYear.Text), Integer.Parse(intQTR.Text))
        End If
    End Sub

    Private Function PreSaveValidation() As Boolean
        Dim result = True
        Dim errMsg = "The following errors must be corrected:" & vbNewLine

        If intYear.Text = "" Then
            result = False
            errMsg += "- Please provide a valid 4-digit year (YYYY)." & vbNewLine
        ElseIf Integer.Parse(intYear.Text) < 1000 Or Integer.Parse(intYear.Text) > 2100 Then
            result = False
            errMsg += "- Please provide a valid 4-digit year (YYYY)." & vbNewLine
        End If

        If intQTR.Text = "" Then
            result = False
            errMsg += "- Please provide a valid quarter (1-4)." & vbNewLine
        ElseIf Integer.Parse(intQTR.Text) < 1 Or Integer.Parse(intQTR.Text) > 4 Then
            result = False
            errMsg += "- Please provide a valid quarter (1-4)." & vbNewLine
        End If

        If result = False Then
            MsgBox(errMsg, MsgBoxStyle.OkOnly, "Error")
        End If

        Return result
    End Function

    Private Sub GenQrtlyAdminReport(ByVal year As Integer, ByVal qtr As Integer)
        'set date ranges
        Dim startDate As Date
        Dim endDate As Date
        If qtr = 1 Then
            startDate = Date.Parse(year - 1 & "-09-01")
            endDate = Date.Parse(year - 1 & "-11-30")
        ElseIf qtr = 2 Then
            startDate = Date.Parse(year - 1 & "-12-01")
            endDate = Date.Parse(year & "-02-28")
        ElseIf qtr = 3 Then
            startDate = Date.Parse(year & "-03-01")
            endDate = Date.Parse(year & "-05-31")
        ElseIf qtr = 4 Then
            startDate = Date.Parse(year & "-06-01")
            endDate = Date.Parse(year & "-08-31")
        End If

        'create Excel object to fill
        xlApp = New Excel.Application()
        xlBook = xlApp.Workbooks.Add
        xlBook.Sheets.Add(Count:=4)

        GenAdminDemo(startDate, endDate)
        GenAdminQC(startDate, endDate)
        GenAdminTissueDistro(startDate, endDate)
        GenAdminPreEnrollment(startDate, endDate)
        GenAdminGTEx()
        xlApp.Visible = True
        xlApp.UserControl = True
    End Sub
    Private Sub GenAdminDemo(ByVal startDate As Date, ByVal endDate As Date)
        Dim sheet As Excel.Worksheet = xlBook.Worksheets("Sheet5")
        sheet.Name = "1. Demographics- Donor info"
        table = Database.ReturnTable("viewNBB_QtrlyAdminDemo",, "[Date of Death] between '" & startDate & "' and '" & endDate & "'")
        Dim dc As DataColumn
        Dim dr As DataRow
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 0

        For Each dc In table.Columns
            colIndex += 1
            sheet.Cells(1, colIndex) = dc.ColumnName
        Next
        For Each dr In table.Rows
            rowIndex += 1
            colIndex = 0
            For Each dc In table.Columns
                colIndex += 1
                sheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
            Next
        Next
        sheet.Columns.AutoFit()
        sheet.Rows.AutoFit()
    End Sub
    Private Sub GenAdminQC(ByVal startDate As Date, ByVal endDate As Date)
        Dim sheet As Excel.Worksheet = xlBook.Worksheets("Sheet4")
        sheet.Name = "2. Quality Control Metrics"
        table = Database.ReturnTable("viewNBB_QtrlyAdminQC",, "DateOfDeath between '" & startDate & "' and '" & endDate & "'")
        Dim dc As DataColumn
        Dim dr As DataRow
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 1

        sheet.Range("A1:J2").HorizontalAlignment = Excel.Constants.xlCenter

        sheet.Range(sheet.Cells(1, 1), sheet.Cells(2, 1)).Merge()
        sheet.Range(sheet.Cells(1, 2), sheet.Cells(2, 2)).Merge()
        sheet.Range(sheet.Cells(1, 3), sheet.Cells(2, 3)).Merge()
        sheet.Range(sheet.Cells(1, 4), sheet.Cells(2, 4)).Merge()
        sheet.Range(sheet.Cells(1, 5), sheet.Cells(2, 5)).Merge()
        sheet.Range(sheet.Cells(1, 6), sheet.Cells(1, 8)).Merge()
        sheet.Range(sheet.Cells(1, 9), sheet.Cells(1, 10)).Merge()

        sheet.Cells(1, 1) = "ID Number"
        sheet.Cells(1, 2) = "pH"
        sheet.Cells(1, 3) = "PMI (hours)"
        sheet.Cells(1, 4) = "AFS"
        sheet.Cells(1, 5) = "28s:18s"
        sheet.Cells(1, 6) = "RNA"
        sheet.Cells(2, 6) = "RIN"
        sheet.Cells(2, 7) = "260/280"
        sheet.Cells(2, 8) = "concentration (ng/µl)"
        sheet.Cells(1, 9) = "gDNA"
        sheet.Cells(2, 9) = "Quality"
        sheet.Cells(2, 10) = "Concentration (ng/µl)"

        For Each dr In table.Rows
            rowIndex += 1
            colIndex = 0
            For Each dc In table.Columns
                colIndex += 1
                sheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
            Next
        Next
        sheet.Columns(11).delete
        sheet.Columns.AutoFit()
        sheet.Rows.AutoFit()
    End Sub
    Private Sub GenAdminTissueDistro(ByVal startDate As Date, ByVal endDate As Date)
        Dim sheet As Excel.Worksheet = xlBook.Worksheets("Sheet3")
        sheet.Name = "3. Tissues Distributed"
        table = Database.ReturnTable("viewNBB_QtrlyAdminTissueDistro",, "[Date of Shipment] between '" & startDate & "' and '" & endDate & "'")
        Dim dc As DataColumn
        Dim dr As DataRow
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 0

        For Each dc In table.Columns
            colIndex += 1
            sheet.Cells(1, colIndex) = dc.ColumnName
        Next
        For Each dr In table.Rows
            rowIndex += 1
            colIndex = 0
            For Each dc In table.Columns
                colIndex += 1
                sheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
            Next
        Next
        sheet.Columns.AutoFit()
        sheet.Rows.AutoFit()
    End Sub
    Private Sub GenAdminPreEnrollment(ByVal startDate As Date, ByVal endDate As Date)
        Dim sheet As Excel.Worksheet = xlBook.Worksheets("Sheet2")
        sheet.Name = "4. New Registered Donors"
        table = Database.ReturnTable("viewNBB_QtrlyAdminPreEnrollment",, "[Registration Date] between '" & startDate & "' and '" & endDate & "'")
        Dim dc As DataColumn
        Dim dr As DataRow
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 0

        For Each dc In table.Columns
            colIndex += 1
            sheet.Cells(1, colIndex) = dc.ColumnName
        Next
        For Each dr In table.Rows
            rowIndex += 1
            colIndex = 0
            For Each dc In table.Columns
                colIndex += 1
                sheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
            Next
        Next
        sheet.Columns.AutoFit()
        sheet.Rows.AutoFit()
    End Sub
    Private Sub GenAdminGTEx()
        Dim sheet As Excel.Worksheet = xlBook.Worksheets("Sheet1")
        sheet.Name = "5. GTEx Cases"
        sheet.Cells(1, 1) = "#"
        sheet.Cells(1, 2) = "GTEx Code"
        sheet.Cells(1, 3) = "Recovery Site"
        sheet.Cells(1, 4) = "Date Received"
        sheet.Cells(1, 5) = "Date Processed"
        sheet.Cells(1, 6) = "Samples Received"
        sheet.Cells(1, 7) = "Brain Weight"
        sheet.Cells(1, 8) = "pH"
        sheet.Cells(1, 9) = "Date Specimens Shipped to Broad"
        sheet.Columns.AutoFit()
        sheet.Rows.AutoFit()
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

    Private Sub WA_NBB_QTR_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_NBB_QTR_Admin")
    End Sub

End Class
