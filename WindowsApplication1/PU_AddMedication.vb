Public Class PU_AddMedication
    Private formTables As New DataSet
    Public bs As BindingSource = New BindingSource
    Private drugID As String = ""
    Private bsFilter As String = ""

    Private Sub PU_AddMedication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formTables.Tables.Add(Database.ReturnTable("lkpDrugs", "DrugID, BrandName as 'Brand Name', GenericName as 'Generic Name'"))
        formTables.Tables.Add(Database.ReturnTable("lkpMedicationRoutes"))
        bs.DataSource = formTables.Tables("lkpDrugs")
        dgvMedLookup.DataSource = bs
        dgvMedLookup.Columns("DrugID").Visible = False
        cmbRoute.assignLookup(formTables, "lkpMedicationRoutes")
        cmbRoute.SelectedValue = -1
    End Sub

    'load from DGV subs
    Private Sub dgvMedLookup_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMedLookup.CellDoubleClick
        loadSelected()
    End Sub
    Private Sub dgvMedLookup_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvMedLookup.KeyDown
        If e.KeyCode = Keys.Enter Then
            loadSelected()
            e.Handled = True
        End If
    End Sub
    Private Sub loadSelected()
        'load selected data from DGV into textboxes, and enable the others
        drugID = dgvMedLookup.SelectedRows(0).Cells("DrugID").Value.ToString()
        txtBrandName.Text = dgvMedLookup.SelectedRows(0).Cells("Brand Name").Value.ToString()
        txtGenericName.Text = dgvMedLookup.SelectedRows(0).Cells("Generic Name").Value.ToString()
        txtDosage.Enabled = True
        txtDosageUnits.Enabled = True
        cmbRoute.Enabled = True
        dtStarted.Enabled = True
        dtEnded.Enabled = True
        txtDosage.Focus()
    End Sub

    'helper subs
    Private Sub resetForm()
        drugID = ""
        txtBrandName.Clear()
        txtGenericName.Clear()
        cmbRoute.SelectedValue = -1
        txtDosage.Clear()
        txtDosageUnits.Clear()
        dtStarted.Clear()
        dtEnded.Clear()
        txtTerm1.Clear()
        txtTerm1.Focus()
    End Sub
    Private Sub filterTerm_TextChanged(sender As Object, e As EventArgs) Handles txtTerm1.TextChanged
        If txtTerm1.Text <> "" Then
            txtTerm2.Enabled = True
            txtTerm3.Enabled = True
            txtTerm4.Enabled = True
        Else
            txtTerm2.Enabled = False
            txtTerm3.Enabled = False
            txtTerm4.Enabled = False
            txtTerm2.Clear()
            txtTerm3.Clear()
            txtTerm4.Clear()
            bs.Filter = ""
        End If
    End Sub

    'filter subs
    Private Sub btnApplyFilter_Click(sender As Object, e As EventArgs) Handles btnApplyFilter.Click
        If txtTerm1.Text <> "" Then
            Dim Term1 As String = "([Brand Name] like '%" & txtTerm1.Text & "%' or [Generic Name] like '%" & txtTerm1.Text & "%')"
            Dim Term2 As String = IIf(txtTerm2.Text <> "", " and ([Brand Name] like '%" & txtTerm2.Text & "%' or [Generic Name] like '%" & txtTerm2.Text & "%')", "")
            Dim Term3 As String = IIf(txtTerm3.Text <> "", " and ([Brand Name] like '%" & txtTerm3.Text & "%' or [Generic Name] like '%" & txtTerm3.Text & "%')", "")
            Dim Term4 As String = IIf(txtTerm4.Text <> "", " and ([Brand Name] like '%" & txtTerm4.Text & "%' or [Generic Name] like '%" & txtTerm4.Text & "%')", "")
            bs.Filter = Term1 & Term2 & Term3 & Term4
        Else
            bs.Filter = ""
        End If
    End Sub
    Private Sub filter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTerm1.KeyDown, txtTerm2.KeyDown, txtTerm3.KeyDown, txtTerm4.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnApplyFilter.PerformClick()
            dgvMedLookup.Focus()
        End If
    End Sub
    Private Sub btnClearFilter_Click(sender As Object, e As EventArgs) Handles btnClearFilter.Click
        txtTerm1.Clear() 'rest handled by filterTerm_TextChanged
    End Sub

    'save subs
    Private Function insertRecord() As Boolean
        Dim result As Boolean
        If preSaveValidation() Then
            Dim cmd As New SqlCommand
            cmd.Connection = WarehouseShell.conn
            cmd.CommandText = "Exec modMedicationsRecord @Action = 1" &
                ", @RecordID = null" &
                ", @SubNum = " & WarehouseShell.SubNum &
                ", @DrugID = " & drugID &
                ", @TotalDailyDosage = " & txtDosage.getSQLValue() &
                ", @DosageUnits = " & txtDosageUnits.getSQLValue() &
                ", @Route = " & cmbRoute.getSQLValue() &
                ", @DateStarted = " & dtStarted.getSQLValue() &
                ", @DateEnded = " & dtEnded.getSQLValue() & ";"
            Try
                cmd.ExecuteNonQuery()
                'nothing else here (handled by btnSaveClose or btnSaveAddAnother)
                result = True
            Catch ex As SqlException
                ExceptionHandler.CatchSQLException(ex)
                result = False
            End Try
        Else
            result = False
        End If
        Return result
    End Function

    Private Function preSaveValidation() As Boolean
        Dim result As Boolean = True
        Dim errMsg As String = "The following errors must be corrected before this record can be saved:" & vbNewLine & vbNewLine

        'Define and grab applicable date values if they exist
        Dim DoB As Date = Nothing
        Dim DoD As Date = Nothing
        Dim dateStarted As Date = Nothing
        Dim dateEnded As Date = Nothing
        If Database.ExistingRecordCheck("Subject", "SubNum = " & WarehouseShell.SubNum & " and DoB is not null") Then
            Dim cmd As New SqlCommand("select DoB from Subject where SubNum = " & WarehouseShell.SubNum, WarehouseShell.conn)
            DoB = cmd.ExecuteScalar()
        End If
        If Database.ExistingRecordCheck("AutopsyFaceSheet", "SubNum = " & WarehouseShell.SubNum & " and DateOfDeath is not null") Then
            Dim cmd As New SqlCommand("select DateOfDeath from AutopsyFaceSheet where SubNum = " & WarehouseShell.SubNum, WarehouseShell.conn)
            DoD = cmd.ExecuteScalar()
        End If
        If dtStarted.Text <> "  /  /" Then
            dateStarted = Date.Parse(dtStarted.Text)
        End If
        If dtEnded.Text <> "  /  /" Then
            dateEnded = Date.Parse(dtEnded.Text)
        End If

        'Make sure user has selected a medication
        If txtBrandName.Text = "" And txtGenericName.Text = "" Then
            errMsg += "- No medication selected."
        End If

        'Logically compare dates
        If dateStarted <> Nothing Then 'If there is a start date, perform logical comparisons
            If DoB <> Nothing Then
                If dateStarted < DoB Then
                    result = False
                    errMsg += "- Med start date cannot be before date of birth." & vbNewLine
                End If
            End If
            If DoD <> Nothing Then
                If dateStarted > DoD Then
                    result = False
                    errMsg += "- Med start date cannot be after date of death." & vbNewLine
                End If
            End If
        End If

        If dateEnded <> Nothing Then 'If there is an end date, perform logical comparisons
            If DoD <> Nothing Then
                If dateEnded > DoD Then
                    result = False
                    errMsg += "- Med end date cannot be after date of death." & vbNewLine
                End If
            End If
            If DoB <> Nothing Then
                If dateEnded < DoB Then
                    result = False
                    errMsg += "- Med end date cannot be before date of birth." & vbNewLine
                End If
            End If
        End If

        If dateStarted <> Nothing And dateEnded <> Nothing Then 'Compare start date to end date (if both exist)
            If dateStarted > dateEnded Then
                result = False
                errMsg += "- Med start date cannot be greater than med end date." & vbNewLine
            End If
        End If


        'Handle result
        If result = False Then
            MsgBox(errMsg, MsgBoxStyle.OkOnly, "Error")
        End If
        Return result

    End Function
    'save and close
    Private Sub btnSaveClose_Click(sender As Object, e As EventArgs) Handles btnSaveClose.Click
        If insertRecord() Then
            Dispose()
        End If
    End Sub
    'save and add another
    Private Sub btnSaveAddAnother_Click(sender As Object, e As EventArgs) Handles btnSaveAddAnother.Click
        If insertRecord() Then
            resetForm()
        End If
    End Sub
    Private Sub medication_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBrandName.KeyDown, txtGenericName.KeyDown, txtDosageUnits.KeyDown, dtStarted.KeyDown, dtEnded.KeyDown
        If e.KeyCode = Keys.Enter Then
            insertRecord()
            resetForm()
        End If
    End Sub

    'user suggestions
    Private Sub btnSuggestNewMedication_Click(sender As Object, e As EventArgs) Handles btnSuggestNewMedication.Click
        Dim pu As New PU_MedicationSuggestNew
        pu.StartPosition = FormStartPosition.CenterScreen
        pu.ShowDialog()
        pu.Dispose()
        resetForm()
    End Sub

    'btnCancel
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class