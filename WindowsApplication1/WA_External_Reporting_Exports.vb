Imports Microsoft.Office.Interop
Public Class WA_External_Reporting_Exports
    Implements IFormMethods
    Private table As DataTable
    Private xlApp As Excel.Application
    Private xlBook As Excel.Workbook

    'when you click submit, call the presaveValidation to check the intYear and intQtr for valid entries
    'if the fn(Boolean)  returns a true then call the GenQtrlyAdminReport fn
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        If PreSaveValidation() Then
            GenQrtlyAdminReport()
        End If
    End Sub
    Private Sub distroSubmit_Click(sender As Object, e As EventArgs) Handles distroSubmit.Click
        If distroStartDate.Text <> "  /  /" And distroEndDate.Text <> "  /  /" Then
            TotalCount(distroStartDate.getSQLValue(), distroEndDate.getSQLValue())
            NBBCount(distroStartDate.getSQLValue(), distroEndDate.getSQLValue())
        Else
            MsgBox("Please provide both a start and end date.", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    'fn to check the entries
    Private Function PreSaveValidation() As Boolean
        Dim result = True
        Dim errMsg = "The following errors must be corrected:" & vbNewLine

        If start_Date.Text = "  /  /" Then
            result = False
            errMsg += "- Please provide a valid date in the form (00/00/0000)." & vbNewLine
        ElseIf start_Date.Text.Substring(6) < 1000 Or start_Date.Text.Substring(6) > 2100 Then
            result = False
            errMsg += "- Please provide a valid 4-digit year (YYYY)." & vbNewLine
        End If

        If end_Date.Text = "  /  /" Then
            result = False
            errMsg += "- Please provide a valid date in the form (00/00/0000)." & vbNewLine
        ElseIf end_Date.Text.Substring(6) < 1000 Or end_Date.Text.Substring(6) > 2100 Then
            result = False
            errMsg += "- Please provide a valid 4-digit year (YYYY)." & vbNewLine
        End If

        If result = False Then
            MsgBox(errMsg, MsgBoxStyle.OkOnly, "Error")
        End If

        Return result
    End Function

    Private Sub GenQrtlyAdminReport()
        'set date ranges
        Dim startDate As Date = Date.ParseExact(start_Date.Text, "MM/dd/yyyy",
            System.Globalization.DateTimeFormatInfo.InvariantInfo)

        Dim endDate As Date = Date.ParseExact(end_Date.Text, "MM/dd/yyyy",
            System.Globalization.DateTimeFormatInfo.InvariantInfo)

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
    Public Sub TotalCount(startDate As String, endDate As String)
        'Dim con As New SqlConnection
        Dim reader As SqlDataReader
        Try
            Dim query As String = "with Distros (ProjectID, NBBNum, NumSamples, DateShipped) as (
	select ProjectID, NBTRRequestNum, NumSamples, DateShipped from TissueRequests)
select 
	count(*) as NumDistros, 
	sum(NumSamples) as NumSamples 
from 
	Distros 
where 
	DateShipped between " & startDate & " and " & endDate & ";"
            Dim cmd As New SqlCommand(query, WarehouseShell.conn)
            reader = cmd.ExecuteReader()
            While reader.Read()
                totaldist.Text = "Total Distribution: " & String.Format("{0}", reader(0))
                totalSamples.Text = "Total Samples: " & String.Format("{0}", reader(1))
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server." & ex.Message)
        End Try
    End Sub
    Public Sub NBBCount(startDate As String, endDate As String)
        'Dim con As New SqlConnection
        Dim reader As SqlDataReader
        Try
            Dim query As String = "with Distros (ProjectID, NBBNum, NumSamples, DateShipped) as (
	select ProjectID, NBTRRequestNum, NumSamples, DateShipped from TissueRequests)
select 
	count(*) as NumDistros, 
	sum(NumSamples) as NumSamples 
from 
	Distros 
where 
	DateShipped between " & distroStartDate.getSQLValue() & " and " & distroEndDate.getSQLValue() & " and NBBNum is not null;"
            Dim cmd As New SqlCommand(query, WarehouseShell.conn)
            reader = cmd.ExecuteReader()
            While reader.Read()
                nbbDist.Text = "NBB Distribution: " & String.Format("{0}", reader(0))
                nbbSamp.Text = "NBB Samples: " & String.Format("{0}", reader(1))
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error while connecting to SQL Server." & ex.Message)
        End Try
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

    Private Sub WA_External_Reporting_Exports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_External_Reporting_Exports")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Qtrly_Upload.Click
        'Quarterly NBB IMS Reporting
        Exports.ExportNBBReports()
    End Sub

    Private Sub Btn_BDP_Report_Click(sender As Object, e As EventArgs) Handles Btn_BDP_Report.Click
        Dim deskTopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim table As New DataTable
        table = Exports.ViewBDPReporting()


        'Build the CSV file data as a Comma separated string.
        Dim csv As String = ""

        'Add the Header row for CSV file.
        For Each column As DataColumn In table.Columns
            csv += """" & column.ColumnName & ""","
        Next

        'Add new line.
        csv += vbCr & vbLf

        'Adding the Rows
        For Each row As DataRow In table.Rows
            Dim i As Integer = 0
            While i < row.ItemArray.Length
                If TypeOf row.Item(i) Is Date Then
                    csv += """" & Format(row.Item(i), "MM'/'dd'/'yyyy").ToString & ""","
                ElseIf TypeOf row.Item(i) Is String Then
                    csv += """" & row.Item(i).ToString().Replace("""", """""""") & ""","
                Else
                    csv += row.Item(i).ToString & ","
                End If
                i += 1
            End While

            'Add new line.
            csv += vbCr & vbLf
        Next

        'Export data to CSV file
        File.WriteAllText(deskTopPath & "\BDP_Reporting.csv", csv)

        MsgBox("A file name ""BDP_Reporting.csv"" has been saved to your desktop.", MsgBoxStyle.OkOnly)
    End Sub
End Class