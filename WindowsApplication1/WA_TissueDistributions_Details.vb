Imports System
Imports System.Reflection
Imports Korzh.EasyQuery.Db
Imports Microsoft.Office.Interop

Public Class WA_TissueDistributions_Details
    Implements IFormMethods

    Private Results As Data.DataTable
    Private Reader As SqlDataAdapter

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Dim _assembly As Assembly = Assembly.GetExecutingAssembly()
        eqModel.LoadFromStream(_assembly.GetManifestResourceStream("DataWarehouse.modelView_Specimen_Shipped_Detailed.xml"))
    End Sub

    Private Sub WA_TissueDistributions_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_TissueDistributions_Details")
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        Results = New DataTable("Result")
        Reader = New SqlDataAdapter("select * from viewSpecimen_Shipped_Detailed", WarehouseShell.conn)
        Reader.Fill(Results)
        formatDGV()
    End Sub
    Private Sub formatDGV()
        'Attach data source
        dgvSpecimen_Details.DataSource = Results
        'Set up some DGV behaviors
        dgvSpecimen_Details.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        dgvSpecimen_Details.MultiSelect = True
        dgvSpecimen_Details.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue
        dgvSpecimen_Details.DefaultCellStyle.SelectionForeColor = Color.Black
        dgvSpecimen_Details.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
        'Manually set column sizes (AutoSize is recursive and takes a really long time for large data sets)
        dgvSpecimen_Details.Columns("Barcode").Width = 55
        dgvSpecimen_Details.Columns("BB").Width = 55
        dgvSpecimen_Details.Columns("StorageType").Width = 110
        dgvSpecimen_Details.Columns("BrainRegion").Width = 80
        dgvSpecimen_Details.Columns("UoM").Width = 60
        dgvSpecimen_Details.Columns("Size").Width = 60
        dgvSpecimen_Details.Columns("Note").Width = 110
        dgvSpecimen_Details.Columns("BoxNum").Width = 65
        dgvSpecimen_Details.Columns("ProjectID").Width = 65
        dgvSpecimen_Details.Columns("Project").Width = 110
        dgvSpecimen_Details.Columns("SubProject").Width = 70
        dgvSpecimen_Details.Columns("RequestingPI").Width = 100
        dgvSpecimen_Details.Columns("PIEmail").Width = 140
        dgvSpecimen_Details.Columns("NBTRRequestNum").Width = 65
        dgvSpecimen_Details.Columns("POCName").Width = 100
        dgvSpecimen_Details.Columns("POCEmail").Width = 140
        dgvSpecimen_Details.Columns("POCPhone").Width = 65
        dgvSpecimen_Details.Columns("InstituteName").Width = 80
        dgvSpecimen_Details.Columns("Address1").Width = 250
        dgvSpecimen_Details.Columns("Address2").Width = 150
        dgvSpecimen_Details.Columns("Address3").Width = 180
        dgvSpecimen_Details.Columns("Address4").Width = 180
        dgvSpecimen_Details.Columns("City").Width = 100
        dgvSpecimen_Details.Columns("State").Width = 65
        dgvSpecimen_Details.Columns("Zip").Width = 65
        dgvSpecimen_Details.Columns("DateShipped").Width = 70
        dgvSpecimen_Details.Columns("ShippingMethod").Width = 80
        dgvSpecimen_Details.Columns("TrackingNum").Width = 80
        'Set RowCount label value
        Label2.Text = "Row Count: " & dgvSpecimen_Details.Rows.Count
    End Sub

    Private Sub btnCopyResults_Click(sender As Object, e As EventArgs) Handles btnCopyResults.Click
        Try
            Clipboard.SetDataObject(dgvSpecimen_Details.GetClipboardContent())
        Catch ex As Exception
            ExceptionHandler.CatchWindowsException(ex)
        End Try
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
        Reader = New SqlDataAdapter("Select * from viewSpecimen_Shipped_Detailed", WarehouseShell.conn)
        Reader.Fill(Results)
        formatDGV()
    End Sub
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim resultsRowCount As Integer = Results.Rows.Count
        Dim x As DialogResult = MsgBox("WARNING: Depending on the number of records you are trying to export, this may result in a VERY long running process (5 minutes or more). During this time, you will not be able to perform other actions in the Data Warehouse. Are you SURE that you would like to continue?", MsgBoxStyle.OkCancel, "WARNING!")
        If x = DialogResult.OK Then
            Try
                Dim appXL As Excel.Application
                Dim wbXl As Excel.Workbook
                Dim shXL As Excel.Worksheet
                ' Start Excel and get Application object.
                appXL = CreateObject("Excel.Application")
                'Add a workbook and fill it
                wbXl = appXL.Workbooks.Add
                shXL = wbXl.ActiveSheet
                shXL.Range("A1").Value = "Barcode"
                shXL.Range("B1").Value = "BB"
                shXL.Range("C1").Value = "SubNum"
                shXL.Range("D1").Value = "BrainRegion"
                shXL.Range("E1").Value = "StorageType"
                shXL.Range("F1").Value = "UoM"
                shXL.Range("G1").Value = "Size"
                shXL.Range("H1").Value = "Note"
                shXL.Range("I1").Value = "ProjectID"
                shXL.Range("J1").Value = "Project"
                shXL.Range("K1").Value = "SubProject"
                shXL.Range("L1").Value = "NBTRRequestNum"
                shXL.Range("M1").Value = "DateShipped"
                shXL.Range("N1").Value = "BoxNum"
                shXL.Range("O1").Value = "RequestingPI"
                shXL.Range("P1").Value = "PIEmail"
                shXL.Range("Q1").Value = "POCName"
                shXL.Range("R1").Value = "POCPhone"
                shXL.Range("S1").Value = "POCEmail"
                shXL.Range("T1").Value = "InstituteName"
                shXL.Range("U1").Value = "Address1"
                shXL.Range("V1").Value = "Address2"
                shXL.Range("W1").Value = "Address3"
                shXL.Range("X1").Value = "Address4"
                shXL.Range("Y1").Value = "City"
                shXL.Range("Z1").Value = "State"
                shXL.Range("AA1").Value = "Zip"
                shXL.Range("AB1").Value = "ShippingMethod"
                shXL.Range("AC1").Value = "TrackingNum"
                Dim i As Integer = 1
                Dim resultsRow As DataGridViewRow
                For Each resultsRow In dgvSpecimen_Details.Rows()
                    shXL.Range("A" & i + 1).Value = resultsRow.Cells("Barcode").Value.ToString
                    shXL.Range("B" & i + 1).Value = resultsRow.Cells("BB").Value.ToString
                    shXL.Range("C" & i + 1).Value = resultsRow.Cells("SubNum").Value.ToString
                    shXL.Range("D" & i + 1).Value = resultsRow.Cells("BrainRegion").Value.ToString
                    shXL.Range("E" & i + 1).Value = resultsRow.Cells("StorageType").Value.ToString
                    shXL.Range("F" & i + 1).Value = resultsRow.Cells("UoM").Value.ToString
                    shXL.Range("G" & i + 1).Value = resultsRow.Cells("Size").Value.ToString
                    shXL.Range("H" & i + 1).Value = resultsRow.Cells("Note").Value.ToString
                    shXL.Range("I" & i + 1).Value = resultsRow.Cells("ProjectID").Value.ToString
                    shXL.Range("J" & i + 1).Value = resultsRow.Cells("Project").Value.ToString
                    shXL.Range("K" & i + 1).Value = resultsRow.Cells("SubProject").Value.ToString
                    shXL.Range("L" & i + 1).Value = resultsRow.Cells("NBTRRequestNum").Value.ToString
                    shXL.Range("M" & i + 1).Value = resultsRow.Cells("DateShipped").Value.ToString
                    shXL.Range("N" & i + 1).Value = resultsRow.Cells("BoxNum").Value.ToString
                    shXL.Range("O" & i + 1).Value = resultsRow.Cells("RequestingPI").Value.ToString
                    shXL.Range("P" & i + 1).Value = resultsRow.Cells("PIEmail").Value.ToString
                    shXL.Range("Q" & i + 1).Value = resultsRow.Cells("POCName").Value.ToString
                    shXL.Range("R" & i + 1).Value = resultsRow.Cells("POCPhone").Value.ToString
                    shXL.Range("S" & i + 1).Value = resultsRow.Cells("POCEmail").Value.ToString
                    shXL.Range("T" & i + 1).Value = resultsRow.Cells("InstituteName").Value.ToString
                    shXL.Range("U" & i + 1).Value = resultsRow.Cells("Address1").Value.ToString
                    shXL.Range("V" & i + 1).Value = resultsRow.Cells("Address2").Value.ToString
                    shXL.Range("W" & i + 1).Value = resultsRow.Cells("Address3").Value.ToString
                    shXL.Range("X" & i + 1).Value = resultsRow.Cells("Address4").Value.ToString
                    shXL.Range("Y" & i + 1).Value = resultsRow.Cells("City").Value.ToString
                    shXL.Range("Z" & i + 1).Value = resultsRow.Cells("State").Value.ToString
                    shXL.Range("AA" & i + 1).Value = resultsRow.Cells("Zip").Value.ToString
                    shXL.Range("AB" & i + 1).Value = resultsRow.Cells("ShippingMethod").Value.ToString
                    shXL.Range("AC" & i + 1).Value = resultsRow.Cells("TrackingNum").Value.ToString
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
        End If
    End Sub

    'IForm Methods
    Public Sub TopLevel(val As Boolean) Implements IFormMethods.TopLevel
    End Sub
    Private Sub IFormMethods_Parent(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Private Sub IFormMethods_Show() Implements IFormMethods.Show
    End Sub
    Public Sub ShowPHI(val As Boolean) Implements IFormMethods.ShowPHI
        Show()
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class