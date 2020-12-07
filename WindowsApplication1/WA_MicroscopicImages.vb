Imports System.Reflection
Imports Microsoft.Office.Interop

Public Class WA_MicroscopicImages
    Implements IFormMethods
    Private Results As DataTable
    Private Reader As SqlDataAdapter

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Dim _assembly As Assembly = Assembly.GetExecutingAssembly()
        eqModel.LoadFromStream(_assembly.GetManifestResourceStream("DataWarehouse.modelViewMicroscopicImages.xml"))
    End Sub

    Private Sub WA_MicroscopicImages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        Results = New DataTable("Result")
        Reader = New SqlDataAdapter("Select * from viewMicroscopicImages", WarehouseShell.conn)
        Reader.Fill(Results)
        formatDGV()
        'WarehouseShell.highlightSelectedNode("WA_MicroscopicImages")
    End Sub

    Private Sub formatDGV()
        'sort the records and bind them to the dvg
        Dim view As DataView = Results.DefaultView
        view.Sort = "BB ASC, RegionName ASC, Stain ASC, SeqNum ASC"
        dgvSlideScans.DataSource = view
        dgvSlideScans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        'change selected row color
        dgvSlideScans.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue



        Label2.Text = "Row Count: " & dgvSlideScans.Rows.Count & vbNewLine
        Label2.Text += "Distinct BB Count:" & Results.AsDataView.ToTable(True, "BB").Rows.Count
    End Sub

    Private Sub dgvSlideScans_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSlideScans.CellDoubleClick
        If Directory.Exists("I:/") Then
            Dim myFile As String = dgvSlideScans.SelectedRows(0).Cells("FileName").Value.ToString
            'CHECK FOR EXISTENCE OF FILE
            If File.Exists("I:/ProductionImages/" & myFile.Substring(0, myFile.Length - 5) & "/" & myFile) Then
                'LAUNCH FILE DIRECTLY FROM SHARE DRIVE
                Dim P As New Process
                Dim s As New ProcessStartInfo("I:/ProductionImages/" & myFile.Substring(0, myFile.Length - 5) & "/" & myFile)
                s.UseShellExecute = True
                s.WindowStyle = ProcessWindowStyle.Normal
                P.StartInfo = s
                P.Start()
            Else
                MsgBox("File not found. Please contact the Data Manager at joshua.arneson@mssm.edu and include the FILE NAME of the missing file you are attempting to access.", MsgBoxStyle.OkOnly)
            End If
        Else
            MsgBox("You do not have access to the remote share containing this file. Please contact the Data Manager at joshua.arneson@mssm.edu to request access.")
        End If
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
        Reader = New SqlDataAdapter("Select * from viewMicroscopicImages", WarehouseShell.conn)
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
            'Start Excel and get Application object.
            appXL = CreateObject("Excel.Application")
            'Add a workbook and fill it
            wbXl = appXL.Workbooks.Add
            shXL = wbXl.ActiveSheet
            shXL.Range("A1").Value = "BB"
            shXL.Range("B1").Value = "XENum"
            shXL.Range("C1").Value = "RegionName"
            shXL.Range("D1").Value = "Stain"
            shXL.Range("E1").Value = "SeqNum"
            shXL.Range("F1").Value = "FileName"
            shXL.Range("G1").Value = "UploadDate"
            shXL.Range("H1").Value = "SubNum"

            Dim i As Integer = 1
            Dim resultsRow As DataGridViewRow
            For Each resultsRow In dgvSlideScans.Rows()
                shXL.Range("A" & i + 1).Value = resultsRow.Cells("BB").Value.ToString
                shXL.Range("B" & i + 1).Value = resultsRow.Cells("XENum").Value.ToString
                shXL.Range("C" & i + 1).Value = resultsRow.Cells("RegionName").Value.ToString
                shXL.Range("D" & i + 1).Value = resultsRow.Cells("Stain").Value.ToString
                shXL.Range("E" & i + 1).Value = resultsRow.Cells("SeqNum").Value.ToString
                shXL.Range("F" & i + 1).Value = resultsRow.Cells("FileName").Value.ToString
                shXL.Range("G" & i + 1).Value = resultsRow.Cells("UploadDate").Value.ToString
                shXL.Range("H" & i + 1).Value = resultsRow.Cells("SubNum").Value.ToString

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
    Private Sub btnGetViewer_Click(sender As Object, e As EventArgs) Handles btnGetViewer.Click
        Dim response As DialogResult = MsgBox("Clicking 'Yes' below will download the CaseViewer installation file to your desktop. WARNING- CaseViewer is a large program (230MB), so if your connection is slow this may freeze your Warehouse application for a couple of minutes until the download completes. Once it is complete, you will need to install the application using the file on your desktop. Would you like to continue?", MsgBoxStyle.YesNo)
        If response = DialogResult.Yes Then
            Dim desktop As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            File.Copy("Q:\Program Install Files\CaseViewer (Pannoramic Slide Scans)\CaseViewer_2.1.exe", desktop & "\CaseViewer.exe", True)
        End If
    End Sub

    'Imported IFormMethods interface methods (some used, some not, based on which form is using the interface)
    Public Sub TopLevel(val As Boolean) Implements IFormMethods.TopLevel
    End Sub
    Private Sub IFormMethods_Parent(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Private Sub IFormMethods_Show() Implements IFormMethods.Show
        Show()
    End Sub
    Public Sub ShowPHI(val As Boolean) Implements IFormMethods.ShowPHI
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class