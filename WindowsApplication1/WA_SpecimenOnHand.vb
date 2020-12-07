Imports Korzh.EasyQuery.Db
Imports System.Reflection

Public Class WA_SpecimenOnHand
    Implements IFormMethods
    Private Results As DataTable
    Private cmd As SqlCommand
    Private Reader As SqlDataAdapter

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Dim _assembly As Assembly = Assembly.GetExecutingAssembly()
        eqModel.LoadFromStream(_assembly.GetManifestResourceStream("DataWarehouse.modelSpecimen_OnHand.xml"))
    End Sub
    Private Sub WA_SpecimenOnHand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_SpecimenOnHand")
        Results = New DataTable("Result")
        Reader = New SqlDataAdapter("Select * from viewSpecimen where Shipped <> 1", WarehouseShell.conn)
        Reader.Fill(Results)
        formatDGV()
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
    End Sub
    Private Sub dgvResults_RowPostPaint(sender As Object, e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvResults.RowPostPaint

        If e.RowIndex < dgvResults.RowCount - 1 Then
            Dim dgvRow As DataGridViewRow = dgvResults.Rows(e.RowIndex)
            If dgvRow.Cells("Infectious").Value.ToString <> "" Then
                dgvRow.DefaultCellStyle.BackColor = Color.LightPink
            End If

        End If

    End Sub
    Private Sub formatDGV()
        dgvResults.DataSource = Results
        dgvResults.Columns.Item("Barcode").Width = 55
        dgvResults.Columns.Item("BB").Width = 55
        dgvResults.Columns.Item("Infectious").Width = 60
        dgvResults.Columns.Item("StorageType").Width = 100
        dgvResults.Columns.Item("BrainRegion").Width = 100
        dgvResults.Columns.Item("UoM").Width = 50
        dgvResults.Columns.Item("Size").Width = 45
        dgvResults.Columns.Item("LocationType").Width = 80
        dgvResults.Columns.Item("LocationNum").Width = 80
        dgvResults.Columns.Item("Shelf").Width = 40
        dgvResults.Columns.Item("ShelfRow").Width = 65
        dgvResults.Columns.Item("BoxNum").Width = 55
        dgvResults.Columns.Item("BoxRow").Width = 55
        dgvResults.Columns.Item("ProjectID").Width = 65
        dgvResults.Columns.Item("SubNum").Width = 55
        lblTotalRows.Text = "Row Count: " & Results.Rows.Count
        'Hide irrelevant columns
        dgvResults.Columns.Item("StorageTypeValue").Visible = False
        dgvResults.Columns.Item("BrainRegionValue").Visible = False
        dgvResults.Columns.Item("UoMValue").Visible = False
        dgvResults.Columns.Item("LocationTypeValue").Visible = False
        dgvResults.Columns.Item("DateCreated").Visible = False
        dgvResults.Columns.Item("Shipped").Visible = False
        dgvResults.Columns.Item("Verified").Visible = False
    End Sub
    Private Sub btnQuery_Click(sender As Object, e As EventArgs) Handles btnQuery.Click
        Dim builder As New SqlQueryBuilder(eqQuery)
        If builder.CanBuild Then
            builder.BuildSQL()
            Dim sql As String = builder.Result.SQL & " and Shipped <> 1"
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
        Reader = New SqlDataAdapter("Select * from viewSpecimen where Shipped <> 1", WarehouseShell.conn)
        Reader.Fill(Results)
        formatDGV()
    End Sub

    'Button Click Events
    Private Sub btnMoveBox_Click(sender As Object, e As EventArgs) Handles btnMoveBox.Click
        If User.PermissionCheck("WA_SpecimenOnHand", "Modify") Then
            PU_Specimen_MoveBox.ShowDialog()
            PU_Specimen_MoveBox.Dispose()
            If chkLast100.Checked Then
                loadLast100Records()
                formatDGV()
            Else
                btnQuery.PerformClick()
            End If
        End If
    End Sub
    Private Sub btnAddNewSpecimen_Click(sender As Object, e As EventArgs) Handles btnAddNewSpecimen.Click
        If User.PermissionCheck("WA_SpecimenOnHand", "Modify") Then
            PU_Specimen_AddNewSpecimen.ShowDialog()
            PU_Specimen_AddNewSpecimen.Dispose()
            If chkLast100.Checked Then
                loadLast100Records()
                formatDGV()
            Else
                btnQuery.PerformClick()
            End If
        End If
    End Sub
    Private Sub btnEditRecord_Click(sender As Object, e As EventArgs) Handles btnEditRecord.Click
        If User.PermissionCheck("WA_SpecimenOnHand", "Modify") Then
            If dgvResults.SelectedCells.Count > 1 Then
                MsgBox("Please select ONE cell only to edit a record.", MsgBoxStyle.OkOnly, "Warning")
            Else
                Dim record As DataGridViewRow = dgvResults.Rows(dgvResults.SelectedCells(0).RowIndex)
                Dim popup As PU_Specimen_Edit = New PU_Specimen_Edit(record)
                popup.ShowDialog()
                popup.Dispose()
                If chkLast100.Checked Then
                    loadLast100Records()
                    formatDGV()
                Else
                    btnQuery.PerformClick()
                End If
            End If
        End If
    End Sub
    Private Sub btnConsumeRecord_Click(sender As Object, e As EventArgs) Handles btnConsumeRecord.Click
        If User.PermissionCheck("WA_SpecimenOnHand", "Modify") Then
            Dim pu As PU_Specimen_Consume = New PU_Specimen_Consume
            Dim reason As String
            pu.ShowDialog()
            If pu.txtNote.Text <> "" Then
                reason = pu.txtNote.Text
                For Each cell As DataGridViewCell In dgvResults.SelectedCells()
                    Dim record As DataGridViewRow = dgvResults.Rows(cell.RowIndex)
                    Dim barcode As String = record.Cells("Barcode").Value.ToString
                    Dim cmd As New SqlCommand("Update Specimen set Shipped = 1, Note = '" & reason & "' where Barcode = " & barcode & ";", WarehouseShell.conn)
                    Try
                        cmd.ExecuteNonQuery()
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Next

                MsgBox("Update successful!", MsgBoxStyle.OkOnly, "Success!")

                If chkLast100.Checked Then
                    loadLast100Records()
                    formatDGV()
                Else
                    btnQuery.PerformClick()
                End If
            End If
            pu.Dispose()
        End If
    End Sub
    Private Sub btnDeleteRecord_Click(sender As Object, e As EventArgs) Handles btnDeleteRecord.Click
        If User.PermissionCheck("WA_SpecimenOnHand", "Modify") Then
            For Each cell As DataGridViewCell In dgvResults.SelectedCells()
                Dim record As DataGridViewRow = dgvResults.Rows(cell.RowIndex)
                Dim barcode As String = record.Cells("Barcode").Value.ToString
                Dim cmd As New SqlCommand("delete from Specimen where Barcode = " & barcode & ";", WarehouseShell.conn)
                Try
                    cmd.ExecuteNonQuery()
                Catch ex As SqlException
                    ExceptionHandler.CatchSQLException(ex)
                End Try
            Next

            MsgBox("Update successful!", MsgBoxStyle.OkOnly, "Success!")

            If chkLast100.Checked Then
                loadLast100Records()
                formatDGV()
            Else
                btnQuery.PerformClick()
            End If
        End If
    End Sub

    'IFormMethods
    Public Sub Parent1(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
    End Sub
    Public Sub Show1() Implements IFormMethods.Show
        Show()
    End Sub
    Public Sub ShowPHI(val As Boolean) Implements IFormMethods.ShowPHI
    End Sub
    Public Sub TopLevel(val As Boolean) Implements IFormMethods.TopLevel
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub

    Private Sub chkLast100_CheckedChanged(sender As Object, e As EventArgs) Handles chkLast100.CheckedChanged
        If chkLast100.Checked Then
            Dim result As DialogResult = MsgBox("This will reset any query above. Continue?", MsgBoxStyle.YesNo, "Warning")
            If result = DialogResult.Yes Then
                pnlQuery.Query.Clear()
                loadLast100Records()
                chkLast100.Text = "Show All"
                formatDGV()
            End If
        Else
            loadAllRecords()
            chkLast100.Text = "Show My Last 100"
            formatDGV()
        End If
    End Sub

    Private Sub loadLast100Records()
        Results = New DataTable("Result")
        Reader = New SqlDataAdapter("Select top(100) * from viewSpecimen where Shipped <> 1 and LastModBy = '" & WarehouseShell.userName & "' order by LastModDate desc", WarehouseShell.conn)
        Reader.Fill(Results)
    End Sub
    Private Sub loadAllRecords()
        Results = New DataTable("Result")
        Reader = New SqlDataAdapter("Select * from viewSpecimen where Shipped <> 1", WarehouseShell.conn)
        Reader.Fill(Results)
    End Sub
End Class