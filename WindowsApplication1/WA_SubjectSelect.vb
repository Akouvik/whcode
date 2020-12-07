Imports System.Reflection
Imports Microsoft.Office.Interop

Public Class WA_SubjectSelect
    Implements IFormMethods

    Public bs As New BindingSource
    Private Results As DataTable
    Private Reader As SqlDataAdapter

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Dim _assembly As Assembly = Assembly.GetExecutingAssembly()

        eqModel.LoadFromStream(_assembly.GetManifestResourceStream("DataWarehouse.modelViewSubjectSelect.xml"))
    End Sub

    Private Sub WA_SubjectSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Results = New DataTable("Result")
        Reader = New SqlDataAdapter("Select * from viewSubjectSelect" & IIf(WarehouseShell.Group = "ADRC", " where ADRCCohort = 1", ""), WarehouseShell.conn)
        Reader.Fill(Results)
        formatDGV()
        WarehouseShell.tvFormMenu.Nodes.Clear()
    End Sub

    Private Sub formatDGV()
        bs.RemoveFilter()
        bs.DataSource = Results
        dgvSubject.DataSource = bs
        ShowPHI(WarehouseShell.ShowingPHI)
        Head_SubjectSelect.assignHeaderBindingSource(bs)
        dgvSubject.Columns("BB").Width = 50
        dgvSubject.Columns(" BB").Width = 50
        dgvSubject.Columns("SubNum").Width = 55
        dgvSubject.Columns("DoD").Width = 75
        dgvSubject.Columns(" DoD").Width = 75
        dgvSubject.Columns("DoB").Width = 75
        dgvSubject.Columns(" DoB").Width = 75
        dgvSubject.Columns("Age").Width = 40
        dgvSubject.Columns(" Age").Width = 40
        dgvSubject.Columns("NACCID").Width = 60
        dgvSubject.Columns("XE #").Width = 60
        dgvSubject.Columns(" XE #").Width = 60
        dgvSubject.Columns("ExternalID").Width = 80
        dgvSubject.Columns("PMCR Date").Width = 88
        dgvSubject.Columns("SIS Date").Width = 72
        dgvSubject.Columns("DateEnrolled").Width = 75
        dgvSubject.Sort(dgvSubject.Columns("BB"), ComponentModel.ListSortDirection.Descending)
        lblRowCount.Text = "Row Count: " & Results.Rows.Count
        lblBBCount.Text = "BB Count: " & CalcBBCount()
        lblADRCCount.Text = "ADRC Count: " & CalcADRCCount()
        dgvSubject.Columns("ADRCCohort").Visible = False
        dgvSubject.Columns("IsraelCohort").Visible = False
        dgvSubject.Columns("NBTRCohort").Visible = False
        dgvSubject.Columns("SSN").Visible = False
    End Sub

    Private Function CalcBBCount() As String
        Dim count As Integer = 0
        For Each row As DataGridViewRow In dgvSubject.Rows
            If row.Cells("BB").Value.ToString <> "" Then
                count += 1
            End If
        Next
        Return count.ToString
    End Function
    Private Function CalcADRCCount() As String
        Dim count As Integer = 0
        For Each row As DataGridViewRow In dgvSubject.Rows
            If row.Cells("ADRCCohort").Value.ToString = 1 Then
                count += 1
            End If
        Next
        Return count.ToString
    End Function
    'Define button click events
    Private Sub btnQuery_Click(sender As Object, e As EventArgs) Handles btnQuery.Click
        If WarehouseShell.ShowingPHI Then
            Dim builder As New Korzh.EasyQuery.Db.SqlQueryBuilder(eqQuery)
            If builder.CanBuild Then
                builder.BuildSQL()
                Dim sql As String = builder.Result.SQL
                'Restrict records to ADRC only if needed
                If WarehouseShell.Group = "ADRC" Then
                    sql += " and ADRCCohort = 1"
                End If
                Results = New DataTable("Result")
                Try
                    Reader = New SqlDataAdapter(sql, WarehouseShell.conn)
                    Reader.Fill(Results)
                    'code here to generate rownums
                    formatDGV()
                    Head_SubjectSelect.clearInputs()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        Else
            MsgBox("Please enable PHI before attempting to query.", MsgBoxStyle.OkOnly, "Warning")
        End If
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        pnlQuery.Query.Clear()
        Results = New DataTable("Result")
        Reader = New SqlDataAdapter("Select * from viewSubjectSelect" & IIf(WarehouseShell.Group = "ADRC", " where ADRCCohort = 1", ""), WarehouseShell.conn)
        Reader.Fill(Results)
        formatDGV()
        Head_SubjectSelect.clearInputs()
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
                shXL.Range("A1").Value = "BB"
                shXL.Range("B1").Value = "SubNum"
                shXL.Range("C1").Value = "First Name"
                shXL.Range("D1").Value = "Last Name"
                shXL.Range("E1").Value = "DoB"
                shXL.Range("F1").Value = "DoD"
                shXL.Range("G1").Value = "Age"
                shXL.Range("H1").Value = "SSN"
                shXL.Range("I1").Value = "NACC ID"
                shXL.Range("J1").Value = "XE #"
                Dim i As Integer = 1
                Dim resultsRow As DataRow
                For Each resultsRow In Results.Rows()
                    shXL.Range("A" & i + 1).Value = resultsRow("BB")
                    shXL.Range("B" & i + 1).Value = resultsRow("SubNum")
                    shXL.Range("C" & i + 1).Value = resultsRow("First Name")
                    shXL.Range("D" & i + 1).Value = resultsRow("Last Name")
                    shXL.Range("E" & i + 1).Value = resultsRow("DoB")
                    shXL.Range("F" & i + 1).Value = resultsRow("DoD")
                    shXL.Range("G" & i + 1).Value = resultsRow("Age")
                    shXL.Range("H" & i + 1).Value = resultsRow("SSN")
                    shXL.Range("I" & i + 1).Value = resultsRow("NACCID")
                    shXL.Range("J" & i + 1).Value = resultsRow("XE #")
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
    Private Sub btnSelectSubject_Click(sender As Object, e As EventArgs) Handles btnSelectSubject.Click
        If dgvSubject.RowCount > 0 Then
            WarehouseShell.SubNum = dgvSubject.SelectedRows(0).Cells("SubNum").Value
            DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).UpdateHeaderData(WarehouseShell.SubNum)
            DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).enableInputFields(False)
            DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).btnFilter.Visible = False
            WarehouseShell.tvFormMenu.Visible = True
            WarehouseShell.tvReportMenu.Visible = False
            WarehouseShell.tvFormMenu.Dock = DockStyle.Fill
            WarehouseShell.LoadSubjectTreeView()
            WarehouseShell.LoadWorkingAreaForm(WarehouseShell.formType.WA_ExistingSubjectRecords)
        Else
            MsgBox("No subject selected!", MsgBoxStyle.OkOnly)
        End If
    End Sub
    Private Sub btnAddSubject_Click(sender As Object, e As EventArgs) Handles btnAddSubject.Click
        Dim value As DialogResult = MessageBox.Show("Please verify that the values you entered into the filters in the header are correct before adding a new subject!" &
                        vbNewLine & vbNewLine & "Click OK to continue to the Add New Subject module." &
                        vbNewLine & "Click Cancel to adjust the filter values and generate new list of subjects to select from.", "Caution!",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Hand)
        'Code here to continue to add subject form if OK is clicked, and return to subject select if cancel is clicked
        If value = Windows.Forms.DialogResult.OK Then
            'WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
            WarehouseShell.SubNum = Nothing
            DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).enableInputFields(False)
            WarehouseShell.LoadWorkingAreaForm(WarehouseShell.formType.WA_Demographics)
        ElseIf value = Windows.Forms.DialogResult.Cancel Then
            Head_SubjectSelect.txtFirstName.Focus()
        End If
    End Sub

    'Allow user to double click record in DGV (emulates btnSelectSubject.Click)
    Private Sub dgvSubject_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubject.CellDoubleClick
        btnSelectSubject.PerformClick()
    End Sub

    'Try/Catch to clear Subject DataTable from memory when WA_SubjectSelect closes (if there's one in memory). If try fails, no Subejct table in memory and catch can do nothing.
    Protected Overrides Sub Finalize()
        Try
            DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).assignHeaderBindingSource(bs, True)
            MyBase.Finalize()
        Catch ex As Exception
        End Try
    End Sub

    'Imported IFormMethods interface methods (some used, some not, based on which form is using the interface)
    Public Sub ShowPHI(showPHI As Boolean) Implements IFormMethods.ShowPHI
        dgvSubject.Columns("BB").Visible = showPHI
        dgvSubject.Columns(" BB").Visible = Not showPHI
        dgvSubject.Columns("First Name").Visible = showPHI
        dgvSubject.Columns(" First Name").Visible = Not showPHI
        dgvSubject.Columns("Last Name").Visible = showPHI
        dgvSubject.Columns(" Last Name").Visible = Not showPHI
        dgvSubject.Columns("DoD").Visible = showPHI
        dgvSubject.Columns(" DoD").Visible = Not showPHI
        dgvSubject.Columns("DoB").Visible = showPHI
        dgvSubject.Columns(" DoB").Visible = Not showPHI
        dgvSubject.Columns("Age").Visible = showPHI
        dgvSubject.Columns(" Age").Visible = Not showPHI
        dgvSubject.Columns("XE #").Visible = showPHI
        dgvSubject.Columns(" XE #").Visible = Not showPHI
    End Sub
    Public Sub Parent1(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Public Sub Show1() Implements IFormMethods.Show
        Show()
    End Sub
    Public Sub TopLevel1(val As Boolean) Implements IFormMethods.TopLevel
        TopLevel = val
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class