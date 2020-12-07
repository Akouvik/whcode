Public Class WA_NP_Progress
    Implements IFormMethods
    Private formTables As New DataSet
    Private Results As DataTable
    Private Reader As SqlDataAdapter
    Private bs As BindingSource
    Private RowValueChanged As Integer = -1
    Private ListenForChanges As Boolean

    Private Sub WA_Neuropath_Progress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        ListenForChanges = False
        WarehouseShell.highlightSelectedNode("WA_NP_Progress")
        Results = New DataTable("Result")
        Reader = New SqlDataAdapter("Select * from viewNP_Progress order by NP_Dt desc, Ret_MSSM_Dt desc, Snt_MSSM_Dt desc, Lcl_Stnd_Dt desc, Sctd_Dt desc, Embd_Dt Desc, Dsct_Dt desc, PMCR_Dt desc, SIS_Dt desc, BB Desc", WarehouseShell.conn)
        Reader.Fill(Results)
        formatDGV()
        If User.CheckPermission("Admin") Then
            btnRevert.Visible = True
        Else
            btnRevert.Visible = False
        End If
        ListenForChanges = True
    End Sub
    Private Sub formatDGV()
        bs = New BindingSource
        bs.DataSource = Results
        dgvNP_Progress.DataSource = bs
        dgvNP_Progress.Columns("SubNum").Visible = False
        dgvNP_Progress.Columns("LiveOnConsented").Visible = False
        dgvNP_Progress.Columns("CurrentStep").Visible = False
        dgvNP_Progress.Columns("DaysAtStep").Visible = False
        dgvNP_Progress.Columns("TotalWeeks").Visible = False
        dgvNP_Progress.Columns("ADRCCohort").Visible = False
        dgvNP_Progress.Columns("BB").ReadOnly = True
        dgvNP_Progress.Columns("DoD").ReadOnly = True
        dgvNP_Progress.Columns("SIS_Dt").ReadOnly = True
        dgvNP_Progress.Columns("PMCR_Dt").ReadOnly = True
        dgvNP_Progress.Columns("Dsct_Dt").ReadOnly = True
        dgvNP_Progress.Columns("Embd_Dt").ReadOnly = True
        dgvNP_Progress.Columns("Sctd_Dt").ReadOnly = True
        dgvNP_Progress.Columns("Lcl_Stnd_Dt").ReadOnly = True
        dgvNP_Progress.Columns("Snt_MSSM_Dt").ReadOnly = True
        dgvNP_Progress.Columns("Ret_MSSM_Dt").ReadOnly = True
        dgvNP_Progress.Columns("NP_Prov_Dt").ReadOnly = True
        dgvNP_Progress.Columns("NP_Dt").ReadOnly = True
        dgvNP_Progress.Columns("Notes").ReadOnly = False
        dgvNP_Progress.Columns("SIS_Dt").HeaderText = "SIS" & vbNewLine & "Dt"
        dgvNP_Progress.Columns("PMCR_Dt").HeaderText = "PMCR" & vbNewLine & "Dt"
        dgvNP_Progress.Columns("MRI_Prepped").HeaderText = "MRI" & vbNewLine & "Prepped"
        dgvNP_Progress.Columns("MRI_DropOff").HeaderText = "MRI" & vbNewLine & "DropOff"
        dgvNP_Progress.Columns("MRI_Return").HeaderText = "MRI" & vbNewLine & "Return"
        dgvNP_Progress.Columns("Dissected").HeaderText = "Dissect"
        dgvNP_Progress.Columns("Dsct_Dt").HeaderText = "Dissect" & vbNewLine & "Dt"
        dgvNP_Progress.Columns("Embedded").HeaderText = "Embed"
        dgvNP_Progress.Columns("Embd_Dt").HeaderText = "Embed" & vbNewLine & "Dt"
        dgvNP_Progress.Columns("Sectioned").HeaderText = "Section"
        dgvNP_Progress.Columns("Sctd_Dt").HeaderText = "Section" & vbNewLine & "Dt"
        dgvNP_Progress.Columns("Local_Stained").HeaderText = "Local" & vbNewLine & "Stain"
        dgvNP_Progress.Columns("Lcl_Stnd_Dt").HeaderText = "Local" & vbNewLine & "Stain" & vbNewLine & "Dt"
        dgvNP_Progress.Columns("MSSM_Stn_NA").HeaderText = "MSSM" & vbNewLine & "Stain" & vbNewLine & "N/A"
        dgvNP_Progress.Columns("Snt_MSSM").HeaderText = "Sent" & vbNewLine & "MSSM"
        dgvNP_Progress.Columns("Snt_MSSM_Dt").HeaderText = "Sent" & vbNewLine & "MSSM" & vbNewLine & "Dt"
        dgvNP_Progress.Columns("Ret_MSSM").HeaderText = "Ret" & vbNewLine & "MSSM"
        dgvNP_Progress.Columns("Ret_MSSM_Dt").HeaderText = "Ret" & vbNewLine & "MSSM" & vbNewLine & "Dt"
        dgvNP_Progress.Columns("NP_Prov_Dt").HeaderText = "NP Prov" & vbNewLine & "Dt"
        dgvNP_Progress.Columns("NP_Dt").HeaderText = "NP" & vbNewLine & "Dt"
        dgvNP_Progress.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
        dgvNP_Progress.ColumnHeadersDefaultCellStyle.Padding = New Padding(0, 0, 0, 0)
        dgvNP_Progress.DefaultCellStyle.Padding = New Padding(0, 0, 0, 0)
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        updateRowCount()
        dgvNP_Progress.AutoResizeColumns()
        dgvNP_Progress.Columns("Notes").Width = 465
        dgvNP_Progress.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
        dgvNP_Progress.RowHeadersVisible = False
    End Sub
    Private Sub updateRowCount()
        lblNumRows.Text = "Row Count: " & dgvNP_Progress.Rows.Count
    End Sub
    Private Sub SaveRecord(dgvRow As DataGridViewRow)
        If RowValueChanged <> -1 Then
            Dim sqlCommand As New SqlCommand("", WarehouseShell.conn)
            Dim changedRow As DataRow() = Results.Select("SubNum = " & dgvRow.Cells("SubNum").Value)

            Dim cmdString = "Exec modNP_ProgressRecord "

            If Database.ExistingRecordCheck("NP_Progress", "Subnum = " & changedRow(0).Item("SubNum")) Then
                cmdString += "@Action = 2"
            Else
                cmdString += "@Action = 1"
            End If

            cmdString += ", @SubNum = " & changedRow(0).Item("SubNum") &
                ", @PreppedForShip = '" & changedRow(0).Item("MRI_Prepped").ToString & "'" &
                ", @DroppedOffDate = " & IIf(changedRow(0).IsNull("MRI_DropOff"), "null", "'" & changedRow(0).Item("MRI_DropOff") & "'") &
                ", @ReturnDate = " & IIf(changedRow(0).IsNull("MRI_Return"), "null", "'" & changedRow(0).Item("MRI_Return") & "'") &
                ", @Dissected = " & IIf(changedRow(0).IsNull("Dsct_Dt"), "null", "'" & changedRow(0).Item("Dsct_Dt") & "'") &
                ", @Embedded = " & IIf(changedRow(0).IsNull("Embd_Dt"), "null", "'" & changedRow(0).Item("Embd_Dt") & "'") &
                ", @Sectioned = " & IIf(changedRow(0).IsNull("Sctd_Dt"), "null", "'" & changedRow(0).Item("Sctd_Dt") & "'") &
                ", @LocalStaining = " & IIf(changedRow(0).IsNull("Lcl_Stnd_Dt"), "null", "'" & changedRow(0).Item("Lcl_Stnd_Dt") & "'") &
                ", @MSSMStainingNA = '" & changedRow(0).Item("MSSM_Stn_NA").ToString & "'" &
                ", @SentToMSSM = " & IIf(changedRow(0).IsNull("Snt_MSSM_Dt"), "null", "'" & changedRow(0).Item("Snt_MSSM_Dt") & "'") &
                ", @ReturnedFromMSSM = " & IIf(changedRow(0).IsNull("Ret_MSSM_Dt"), "null", "'" & changedRow(0).Item("Ret_MSSM_Dt") & "'") &
                ", @Notes = '" & changedRow(0).Item("Notes").ToString & "';"
            sqlCommand.CommandText = cmdString
                Try
                    sqlCommand.ExecuteNonQuery()
                    RowValueChanged = -1
                    dgvRow.DefaultCellStyle.BackColor = Color.Empty
                Catch ex As SqlException
                    ExceptionHandler.CatchSQLException(ex)
                    Exit Sub
                End Try
            Else
                dgvRow.ErrorText = "Invalid Values"
        End If
    End Sub
    Private Sub dgvNP_Progress_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNP_Progress.CellContentClick
        'check to make sure the column is a checkbox column
        If e.ColumnIndex = 5 Or e.ColumnIndex = 8 Or e.ColumnIndex = 10 Or e.ColumnIndex = 12 Or e.ColumnIndex = 14 Or e.ColumnIndex = 16 Or e.ColumnIndex = 17 Or e.ColumnIndex = 19 Then
            Dim row As Integer = e.RowIndex
            Dim column As Integer = e.ColumnIndex
            Dim SubNum As Integer = dgvNP_Progress.Rows(e.RowIndex).Cells("SubNum").Value
            If column <> 5 And column <> 6 And column <> 7 And column <> 23 Then
                Dim checked As Boolean = Convert.ToBoolean(dgvNP_Progress.Rows(e.RowIndex).Cells(e.ColumnIndex).EditedFormattedValue) 'user is attempting to change a checkbox
                CellChanged(row, column, SubNum, checked)
            Else 'user is updating MRI values or notes
                CellChanged(row, column, SubNum)
            End If
        End If
    End Sub
    Private Sub dgvNP_Progress_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvNP_Progress.RowValidating
        If RowValueChanged <> -1 Then
            Dim row As DataGridViewRow = dgvNP_Progress.Rows(e.RowIndex)
            Dim valid As Boolean = True

            'Run validations here
            If row.Cells("Embd_Dt").Value Is DBNull.Value Then
                'row.Cells("Embd_Dt").ErrorText = "Cannot be empty."
                'valid = False
            End If

            'proceed or cancel based on validation results
            If valid = False Then
                e.Cancel = True
            Else
                SaveRecord(row)
            End If
        End If
    End Sub
    Private Sub CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNP_Progress.CellValueChanged
        If ListenForChanges Then
            If e.ColumnIndex = 6 Or e.ColumnIndex = 7 Or e.ColumnIndex = 23 Then
                Dim row As Integer = e.RowIndex
                Dim column As Integer = e.ColumnIndex
                Dim SubNum As Integer = dgvNP_Progress.Rows(e.RowIndex).Cells("SubNum").Value
                CellChanged(row, column, SubNum)
            End If
        End If
    End Sub
    Private Sub CellChanged(ByVal row As Integer, ByVal column As Integer, ByVal SubNum As Integer, Optional ByVal checked As Boolean = True)
        Dim dataRow() As DataRow = Results.Select("SubNum = " & dgvNP_Progress.Rows(row).Cells("SubNum").Value.ToString)
        If column <> 5 And column <> 6 And column <> 7 And column <> 16 And column <> 23 Then
            If checked Then 'user is attempting to check the box
                If Not dataRow(0).Item(column) Then 'original value was unchecked
                    dgvNP_Progress.Rows(row).Cells(column + 1).Value = Today()
                End If
                dgvNP_Progress.Rows(row).Cells(column).Value = True
            Else 'user is attempting to uncheck the box
                dgvNP_Progress.Rows(row).Cells(column).Value = False
                dgvNP_Progress.Rows(row).Cells(column + 1).Value = DBNull.Value
            End If
        ElseIf column = 16 Then
            If checked Then 'user is attempting to set MSSM_Staining_NA to true, so clear Sent/Returned values
                dgvNP_Progress.Rows(row).Cells(column).Value = True
                dgvNP_Progress.Rows(row).Cells(column + 1).Value = False
                dgvNP_Progress.Rows(row).Cells(column + 2).Value = DBNull.Value
                dgvNP_Progress.Rows(row).Cells(column + 3).Value = False
                dgvNP_Progress.Rows(row).Cells(column + 4).Value = DBNull.Value
            Else
                dgvNP_Progress.Rows(row).Cells(column).Value = False
            End If
        End If
        RowValueChanged = row
    End Sub
    Private Sub dgvResults_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvNP_Progress.RowPostPaint
        If e.RowIndex < dgvNP_Progress.RowCount Then
            Dim dgvRow As DataGridViewRow = dgvNP_Progress.Rows(e.RowIndex)
            If e.RowIndex = RowValueChanged Then
                dgvRow.DefaultCellStyle.BackColor = Color.PaleVioletRed 'IndianRed
            ElseIf dgvRow.Cells("LiveOnConsented").Value.ToString = "1" And dgvRow.Cells("NP_Dt").Value.ToString = "" And dgvRow.Cells("NP_Prov_Dt").Value.ToString = "" Then
                dgvRow.DefaultCellStyle.BackColor = Color.Lime
            ElseIf dgvRow.Cells("ADRCCohort").Value.ToString = "1" Then
                dgvRow.DefaultCellStyle.BackColor = Color.LightSkyBlue
            Else
                dgvRow.DefaultCellStyle.BackColor = Nothing
            End If

            Dim SubNum As Integer = dgvRow.Cells("SubNum").Value
            If Database.ExistingRecordCheck("fileClinicalSummary", "SubNum = " & SubNum) Then
                dgvRow.DefaultCellStyle.ForeColor = Color.Blue
            End If

            If dgvRow.Cells("BB").Value >= 2137 Then
                    If dgvRow.Cells("MRI_Prepped").Value.ToString <> "True" Then
                        If DateAdd(DateInterval.Day, 42, dgvRow.Cells("DoD").Value) <= Today() Then
                            dgvRow.Cells("MRI_Prepped").Style.BackColor = Color.Yellow
                        End If
                    Else
                        If IsDBNull(dgvRow.Cells("MRI_DropOff").Value) Then
                            dgvRow.Cells("MRI_DropOff").Style.BackColor = Color.Yellow
                        Else
                            If IsDBNull(dgvRow.Cells("MRI_Return").Value) And DateAdd(DateInterval.Day, 7, dgvRow.Cells("MRI_DropOff").Value) <= Today() Then
                                dgvRow.Cells("MRI_Return").Style.BackColor = Color.Yellow
                            End If
                        End If
                    End If
                End If
            End If
    End Sub
    Private Sub btnRevert_Click(sender As Object, e As EventArgs) Handles btnRevert.Click
        Dim gridRow As DataGridViewRow = dgvNP_Progress.Rows(dgvNP_Progress.SelectedCells(0).RowIndex)
        Dim dataRows() As DataRow = Results.Select("SubNum = " & gridRow.Cells("SubNum").Value.ToString)
        Dim dataRow As DataRow = dataRows(0)

        dataRow.RejectChanges()

        For Each cell As DataGridViewCell In gridRow.Cells()
            Dim name As String = dgvNP_Progress.Columns(cell.ColumnIndex).Name
            gridRow.Cells(name).Value = dataRow(name)
        Next

        RowValueChanged = dgvNP_Progress.SelectedCells(0).RowIndex
        SaveRecord(gridRow)
    End Sub
    Private Sub chkExcludeADRC_CheckedChanged(sender As Object, e As EventArgs) Handles chkExcludeADRC.CheckedChanged
        If chkExcludeADRC.Checked Then
            Results.DefaultView.RowFilter = "ADRCCohort <> 1"
            chkExcludeADRC.Text = "Include ADRC Cases"
        Else
            Results.DefaultView.RowFilter = Nothing
            chkExcludeADRC.Text = "Exclude ADRC Cases"
        End If
        chkExcludeADRC.BackColor = Color.LightGray
        updateRowCount()
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