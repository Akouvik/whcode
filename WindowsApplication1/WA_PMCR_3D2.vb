Public Class WA_PMCR_3D2
    Implements IFormMethods
    Private formTables As New DataSet

    Private Sub WA_PMCR_3D2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Database.ExistingRecordCheck("PMCR_3D2", "SubNum = " & WarehouseShell.SubNum) Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            loadBaseForm()
            loadExistingData()
            btn3D2Bottom.Text = "Edit Record"
            btn3D2Top.Text = btn3D2Bottom.Text
        Else 'If it doesn't exist, change mode to Undefined and show user banner
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            lblNoRecord.Visible = True
            btn3D2Bottom.Text = "Add New Record"
            btn3D2Top.Text = btn3D2Bottom.Text
        End If
        enableInputFields(False)
    End Sub
    Private Sub loadBaseForm()
        WarehouseShell.highlightSelectedNode("WA_PMCR_tab3D2")
        formTables.Tables.Add(Database.ReturnTable("lkpConfidence"))
        formTables.Tables.Add(Database.ReturnTable("lkpYN12"))
        formTables.Tables.Add(Database.ReturnTable("lkpPMCR_3D1_Source"))
        cmbCritC10.assignLookup(formTables, "lkpPMCR_3D1_Source")
        cmbCritC20.assignLookup(formTables, "lkpPMCR_3D1_Source")
        cmbCritC30.assignLookup(formTables, "lkpPMCR_3D1_Source")
        cmbCritC40.assignLookup(formTables, "lkpPMCR_3D1_Source")
        cmbCritC50.assignLookup(formTables, "lkpPMCR_3D1_Source")
        cmbCritC60.assignLookup(formTables, "lkpPMCR_3D1_Source")
        cmbCritC70.assignLookup(formTables, "lkpPMCR_3D1_Source")
        cmbCritC80.assignLookup(formTables, "lkpPMCR_3D1_Source")
        cmbCritC90.assignLookup(formTables, "lkpPMCR_3D1_Source")
        cmbCritD10.assignLookup(formTables, "lkpPMCR_3D1_Source")
        cmbCritD20.assignLookup(formTables, "lkpPMCR_3D1_Source")
        cmbCritD30.assignLookup(formTables, "lkpPMCR_3D1_Source")
        cmbCritD40.assignLookup(formTables, "lkpPMCR_3D1_Source")
        cmbCritD50.assignLookup(formTables, "lkpPMCR_3D1_Source")
        cmbCritD60.assignLookup(formTables, "lkpPMCR_3D1_Source")
        cmbCritD70.assignLookup(formTables, "lkpPMCR_3D1_Source")
        cmbCritD80.assignLookup(formTables, "lkpPMCR_3D1_Source")
        cmbCritD90.assignLookup(formTables, "lkpPMCR_3D1_Source")
        cmbCritFYesNo.assignLookup(formTables, "lkpYN12")
        cmbCritFSource.assignLookup(formTables, "lkpPMCR_3D1_Source")
        cmbCritFReliable.assignLookup(formTables, "lkpConfidence")
    End Sub
    Private Sub setDefaultValues()
        cmbCritC10.SelectedValue = -1
        cmbCritC20.SelectedValue = -1
        cmbCritC30.SelectedValue = -1
        cmbCritC40.SelectedValue = -1
        cmbCritC50.SelectedValue = -1
        cmbCritC60.SelectedValue = -1
        cmbCritC70.SelectedValue = -1
        cmbCritC80.SelectedValue = -1
        cmbCritC90.SelectedValue = -1
        cmbCritD10.SelectedValue = -1
        cmbCritD20.SelectedValue = -1
        cmbCritD30.SelectedValue = -1
        cmbCritD40.SelectedValue = -1
        cmbCritD50.SelectedValue = -1
        cmbCritD60.SelectedValue = -1
        cmbCritD70.SelectedValue = -1
        cmbCritD80.SelectedValue = -1
        cmbCritD90.SelectedValue = -1
        cmbCritFYesNo.SelectedValue = 2
        cmbCritFSource.SelectedValue = -1
        cmbCritFReliable.SelectedValue = -1
    End Sub
    Private Sub loadExistingData() 'load all non-DGV values (handle DGV loads with separate subs)
        'Grab the individual record, based on RecordID, and assign values to their appropriate fields
        formTables.Tables.Add(Database.ReturnTable("PMCR_3D2", , "SubNum = " & WarehouseShell.SubNum))
        cmbCritC10.SelectedValue = formTables.Tables("PMCR_3D2").Rows(0).Item("CritC1019")
        txtCritC10.Text = formTables.Tables("PMCR_3D2").Rows(0).Item("CritC1019Notes").ToString
        cmbCritC20.SelectedValue = formTables.Tables("PMCR_3D2").Rows(0).Item("CritC2029")
        txtCritC20.Text = formTables.Tables("PMCR_3D2").Rows(0).Item("CritC2029Notes").ToString
        cmbCritC30.SelectedValue = formTables.Tables("PMCR_3D2").Rows(0).Item("CritC3039")
        txtCritC30.Text = formTables.Tables("PMCR_3D2").Rows(0).Item("CritC3039Notes").ToString
        cmbCritC40.SelectedValue = formTables.Tables("PMCR_3D2").Rows(0).Item("CritC4049")
        txtCritC40.Text = formTables.Tables("PMCR_3D2").Rows(0).Item("CritC4049Notes").ToString
        cmbCritC50.SelectedValue = formTables.Tables("PMCR_3D2").Rows(0).Item("CritC5059")
        txtCritC50.Text = formTables.Tables("PMCR_3D2").Rows(0).Item("CritC5059Notes").ToString
        cmbCritC60.SelectedValue = formTables.Tables("PMCR_3D2").Rows(0).Item("CritC6069")
        txtCritC60.Text = formTables.Tables("PMCR_3D2").Rows(0).Item("CritC6069Notes").ToString
        cmbCritC70.SelectedValue = formTables.Tables("PMCR_3D2").Rows(0).Item("CritC7079")
        txtCritC70.Text = formTables.Tables("PMCR_3D2").Rows(0).Item("CritC7079Notes").ToString
        cmbCritC80.SelectedValue = formTables.Tables("PMCR_3D2").Rows(0).Item("CritC8089")
        txtCritC80.Text = formTables.Tables("PMCR_3D2").Rows(0).Item("CritC8089Notes").ToString
        cmbCritC90.SelectedValue = formTables.Tables("PMCR_3D2").Rows(0).Item("CritC9099")
        txtCritC90.Text = formTables.Tables("PMCR_3D2").Rows(0).Item("CritC9099Notes").ToString
        cmbCritD10.SelectedValue = formTables.Tables("PMCR_3D2").Rows(0).Item("CritD1019")
        txtCritD10.Text = formTables.Tables("PMCR_3D2").Rows(0).Item("CritD1019Notes").ToString
        cmbCritD20.SelectedValue = formTables.Tables("PMCR_3D2").Rows(0).Item("CritD2029")
        txtCritD20.Text = formTables.Tables("PMCR_3D2").Rows(0).Item("CritD2029Notes").ToString
        cmbCritD30.SelectedValue = formTables.Tables("PMCR_3D2").Rows(0).Item("CritD3039")
        txtCritD30.Text = formTables.Tables("PMCR_3D2").Rows(0).Item("CritD3039Notes").ToString
        cmbCritD40.SelectedValue = formTables.Tables("PMCR_3D2").Rows(0).Item("CritD4049")
        txtCritD40.Text = formTables.Tables("PMCR_3D2").Rows(0).Item("CritD4049Notes").ToString
        cmbCritD50.SelectedValue = formTables.Tables("PMCR_3D2").Rows(0).Item("CritD5059")
        txtCritD50.Text = formTables.Tables("PMCR_3D2").Rows(0).Item("CritD5059Notes").ToString
        cmbCritD60.SelectedValue = formTables.Tables("PMCR_3D2").Rows(0).Item("CritD6069")
        txtCritD60.Text = formTables.Tables("PMCR_3D2").Rows(0).Item("CritD6069Notes").ToString
        cmbCritD70.SelectedValue = formTables.Tables("PMCR_3D2").Rows(0).Item("CritD7079")
        txtCritD70.Text = formTables.Tables("PMCR_3D2").Rows(0).Item("CritD7079Notes").ToString
        cmbCritD80.SelectedValue = formTables.Tables("PMCR_3D2").Rows(0).Item("CritD8089")
        txtCritD80.Text = formTables.Tables("PMCR_3D2").Rows(0).Item("CritD8089Notes").ToString
        cmbCritD90.SelectedValue = formTables.Tables("PMCR_3D2").Rows(0).Item("CritD9099")
        txtCritD90.Text = formTables.Tables("PMCR_3D2").Rows(0).Item("CritD9099Notes").ToString
        txtCritENotes.Text = formTables.Tables("PMCR_3D2").Rows(0).Item("CritENotes").ToString
        cmbCritFYesNo.SelectedValue = formTables.Tables("PMCR_3D2").Rows(0).Item("CritFAutism")
        cmbCritFSource.SelectedValue = formTables.Tables("PMCR_3D2").Rows(0).Item("CritFAutismSource")
        cmbCritFReliable.SelectedValue = formTables.Tables("PMCR_3D2").Rows(0).Item("CritFAutismReliable")
        chkCritFPromDels.setValue(formTables, "PMCR_3D2", "CritFPromDelusions")
        chkCritFHallucinations.setValue(formTables, "PMCR_3D2", "CritFHallucinations")
    End Sub
    Private Sub enableInputFields(ByVal bool As Boolean)
        If bool = True Then
            grpCritC.Enabled = True
            grpCritD.Enabled = True
            grpCritE.Enabled = True
            grpCritF.Enabled = True
        Else
            grpCritC.Enabled = False
            grpCritD.Enabled = False
            grpCritE.Enabled = False
            grpCritF.Enabled = False
        End If
    End Sub
    Private Sub btn3D2_Click(sender As Object, e As EventArgs) Handles btn3D2Bottom.Click, btn3D2Top.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_PMCR_3D2", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                btn3D2Bottom.Text = "Save Changes"
                btn3D2Top.Text = btn3D2Bottom.Text
                enableInputFields(True)
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If User.PermissionCheck("WA_PMCR_3D2", "Modify") Then
                loadBaseForm()
                setDefaultValues()
                lblNoRecord.Visible = False
                btn3D2Bottom.Text = "Save New Record"
                btn3D2Top.Text = "Save New Record"
                enableInputFields(True)
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
            End If
        Else 'By default, user is attempting to Insert or Edit a record. Run preSaveValidation.
            If preSaveValidation() Then 'If preSaveValidation returns true, take Insert or Update actions.
                'Same parameters for Insert or Update SP's, so define here
                Dim parameters = " @SubNum = " & WarehouseShell.SubNum &
                    ", @CritC1019 = " & cmbCritC10.getSQLValue() &
                    ", @CritC1019Notes = " & txtCritC10.getSQLValue() &
                    ", @CritC2029 = " & cmbCritC20.getSQLValue() &
                    ", @CritC2029Notes = " & txtCritC20.getSQLValue() &
                    ", @CritC3039 = " & cmbCritC30.getSQLValue() &
                    ", @CritC3039Notes = " & txtCritC30.getSQLValue() &
                    ", @CritC4049 = " & cmbCritC40.getSQLValue() &
                    ", @CritC4049Notes = " & txtCritC40.getSQLValue() &
                    ", @CritC5059 = " & cmbCritC50.getSQLValue() &
                    ", @CritC5059Notes = " & txtCritC50.getSQLValue() &
                    ", @CritC6069 = " & cmbCritC60.getSQLValue() &
                    ", @CritC6069Notes = " & txtCritC60.getSQLValue() &
                    ", @CritC7079 = " & cmbCritC70.getSQLValue() &
                    ", @CritC7079Notes = " & txtCritC70.getSQLValue() &
                    ", @CritC8089 = " & cmbCritC80.getSQLValue() &
                    ", @CritC8089Notes = " & txtCritC80.getSQLValue() &
                    ", @CritC9099 = " & cmbCritC90.getSQLValue() &
                    ", @CritC9099Notes = " & txtCritC90.getSQLValue() &
                    ", @CritD1019 = " & cmbCritD10.getSQLValue() &
                    ", @CritD1019Notes = " & txtCritD10.getSQLValue() &
                    ", @CritD2029 = " & cmbCritD20.getSQLValue() &
                    ", @CritD2029Notes = " & txtCritD20.getSQLValue() &
                    ", @CritD3039 = " & cmbCritD30.getSQLValue() &
                    ", @CritD3039Notes = " & txtCritD30.getSQLValue() &
                    ", @CritD4049 = " & cmbCritD40.getSQLValue() &
                    ", @CritD4049Notes = " & txtCritD40.getSQLValue() &
                    ", @CritD5059 = " & cmbCritD50.getSQLValue() &
                    ", @CritD5059Notes = " & txtCritD50.getSQLValue() &
                    ", @CritD6069 = " & cmbCritD60.getSQLValue() &
                    ", @CritD6069Notes = " & txtCritD60.getSQLValue() &
                    ", @CritD7079 = " & cmbCritD70.getSQLValue() &
                    ", @CritD7079Notes = " & txtCritD70.getSQLValue() &
                    ", @CritD8089 = " & cmbCritD80.getSQLValue() &
                    ", @CritD8089Notes = " & txtCritD80.getSQLValue() &
                    ", @CritD9099 = " & cmbCritD90.getSQLValue() &
                    ", @CritD9099Notes = " & txtCritD90.getSQLValue() &
                    ", @CritENotes = " & txtCritENotes.getSQLValue() &
                    ", @CritFAutism = " & cmbCritFYesNo.getSQLValue() &
                    ", @CritFAutismSource = " & cmbCritFSource.getSQLValue() &
                    ", @CritFAutismReliable = " & cmbCritFReliable.getSQLValue() &
                    ", @CritFPromDelusions = " & chkCritFPromDels.getSQLValue() &
                    ", @CritFHallucinations = " & chkCritFHallucinations.getSQLValue() &
                    ", @LastModBy = '" & WarehouseShell.userName & "';"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    Dim cmd As New SqlCommand("Exec modPMCR_3D2Record @Action = 1, " & parameters, WarehouseShell.conn)
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Save successful", MsgBoxStyle.OkOnly)
                        enableInputFields(False)
                        btn3D2Bottom.Text = "Edit Record"
                        btn3D2Top.Text = "Edit Record"
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else 'If this clause is invoked, datamode must be Edit
                    Dim cmd As New SqlCommand("Exec modPMCR_3D2Record @Action = 2, " & parameters, WarehouseShell.conn)
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Save successful", MsgBoxStyle.OkOnly)
                        enableInputFields(False)
                        btn3D2Bottom.Text = "Edit Record"
                        btn3D2Top.Text = "Edit Record"
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                End If
            End If
        End If
    End Sub
    Private Function preSaveValidation() As Boolean
        Return True
    End Function

    'Imported IForm Methods
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
    Public Sub Parent1(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        btn3D2Bottom.PerformClick()
    End Sub
    Public Sub Show1() Implements IFormMethods.Show
        Show()
    End Sub
    Public Sub ShowPHI(val As Boolean) Implements IFormMethods.ShowPHI
    End Sub
    Public Sub TopLevel(val As Boolean) Implements IFormMethods.TopLevel
        TopLevel(val)
    End Sub
End Class