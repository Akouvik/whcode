Public Class WA_PMCR_MCIRS
    Implements IFormMethods
    Private formTables As New DataSet

    Private Sub WA_PMCR_MCIRS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_PMCR_tabMCIRS")
        If Database.ExistingRecordCheck("PMCR_MCIRS", "SubNum = " & WarehouseShell.SubNum) Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            loadBaseForm()
            loadExistingData()
            enableInputFields(False)
            btnMCIRSBottom.Text = "Edit Record"
            btnMCIRSTop.Text = btnMCIRSBottom.Text
        Else
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            enableInputFields(False)
            lblNoRecord.Visible = True
            btnMCIRSBottom.Text = "Add New Record"
            btnMCIRSTop.Text = btnMCIRSBottom.Text
        End If
    End Sub
    Private Sub loadBaseForm()
        WarehouseShell.highlightSelectedNode("WA_PMCR_tabMCIRS")
        'Grab any required comboLookUp tables and assign them to their appropriate boxes
        formTables.Tables.Add(Database.ReturnTable("lkpPMCR_MCIRSSeverity"))

        'Assign combobox lookups
        For Each cmb As Control In grpMCIRS.Controls
            If TypeOf cmb Is ComboBox_ Then
                CType(cmb, ComboBox_).assignLookup(formTables, "lkpPMCR_MCIRSSeverity")
            End If
        Next
    End Sub
    Private Sub setDefaultValues()
        For Each cmb As Control In grpMCIRS.Controls
            If TypeOf cmb Is ComboBox_ Then
                CType(cmb, ComboBox_).SelectedValue = 1
            End If
        Next
        txtMCIRSScore.Text = "14"
    End Sub
    Private Sub loadExistingData()
        'Grab the individual record, based on RecordID, and assign values to their appropriate fields
        formTables.Tables.Add(Database.ReturnTable("PMCR_MCIRS", , "SubNum = " & WarehouseShell.SubNum))
        comboCardiac.setValue(formTables, "PMCR_MCIRS", "Cardiac")
        comboHypertension.setValue(formTables, "PMCR_MCIRS", "Hypertension")
        comboVasc.setValue(formTables, "PMCR_MCIRS", "Vascular")
        comboResp.setValue(formTables, "PMCR_MCIRS", "Respiratory")
        comboEENT.setValue(formTables, "PMCR_MCIRS", "EENT")
        comboUpperGI.setValue(formTables, "PMCR_MCIRS", "UpperGI")
        comboLowerGI.setValue(formTables, "PMCR_MCIRS", "LowerGI")
        comboHepatic.setValue(formTables, "PMCR_MCIRS", "Hepatic")
        comboRenal.setValue(formTables, "PMCR_MCIRS", "Renal")
        comboOtherGU.setValue(formTables, "PMCR_MCIRS", "OtherGU")
        comboMusculo.setValue(formTables, "PMCR_MCIRS", "MusculoSkeletal")
        comboNeurological.setValue(formTables, "PMCR_MCIRS", "Neurological")
        comboEndocrine.setValue(formTables, "PMCR_MCIRS", "EndocrineMetabolic")
        comboPsychiatric.setValue(formTables, "PMCR_MCIRS", "PsychBehavioral")
        txtMCIRSScore.setValue(formTables, "PMCR_MCIRS", "TotalScore")
    End Sub
    Private Sub enableInputFields(ByVal bool As Boolean)
        If bool = True Then
            For Each cmb As Control In grpMCIRS.Controls
                If TypeOf cmb Is ComboBox_ Then
                    CType(cmb, ComboBox_).Enabled = True
                End If
            Next
        Else
            For Each cmb As Control In grpMCIRS.Controls
                If TypeOf cmb Is ComboBox_ Then
                    CType(cmb, ComboBox_).Enabled = False
                End If
            Next
        End If
    End Sub

    Private Sub MCIRS_ComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboCardiac.SelectedValueChanged, comboVasc.SelectedValueChanged, comboResp.SelectedValueChanged, comboEENT.SelectedValueChanged, comboUpperGI.SelectedValueChanged, comboLowerGI.SelectedValueChanged, comboHepatic.SelectedValueChanged, comboRenal.SelectedValueChanged, comboOtherGU.SelectedValueChanged, comboMusculo.SelectedValueChanged, comboNeurological.SelectedValueChanged, comboEndocrine.SelectedValueChanged, comboPsychiatric.SelectedValueChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View And WarehouseShell.DataMode <> WarehouseShell.userDataMode.Undefined Then
            txtMCIRSScore.Text = (IIf(comboCardiac.SelectedValue = 9, 0, comboCardiac.SelectedValue) +
                              IIf(comboHypertension.SelectedValue = 9, 0, comboHypertension.SelectedValue) +
                              IIf(comboVasc.SelectedValue = 9, 0, comboVasc.SelectedValue) +
                              IIf(comboResp.SelectedValue = 9, 0, comboResp.SelectedValue) +
                              IIf(comboEENT.SelectedValue = 9, 0, comboEENT.SelectedValue) +
                              IIf(comboUpperGI.SelectedValue = 9, 0, comboUpperGI.SelectedValue) +
                              IIf(comboLowerGI.SelectedValue = 9, 0, comboLowerGI.SelectedValue) +
                              IIf(comboHepatic.SelectedValue = 9, 0, comboHepatic.SelectedValue) +
                              IIf(comboRenal.SelectedValue = 9, 0, comboRenal.SelectedValue) +
                              IIf(comboOtherGU.SelectedValue = 9, 0, comboOtherGU.SelectedValue) +
                              IIf(comboMusculo.SelectedValue = 9, 0, comboMusculo.SelectedValue) +
                              IIf(comboNeurological.SelectedValue = 9, 0, comboNeurological.SelectedValue) +
                              IIf(comboEndocrine.SelectedValue = 9, 0, comboEndocrine.SelectedValue) +
                              IIf(comboPsychiatric.SelectedValue = 9, 0, comboPsychiatric.SelectedValue)).ToString
        End If
    End Sub

    Private Sub btnMCIRSBottom_Click(sender As Object, e As EventArgs) Handles btnMCIRSBottom.Click, btnMCIRSTop.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_PMCR_MCIRS", "Modify") Then
                btnMCIRSBottom.Text = "Save Changes"
                btnMCIRSTop.Text = btnMCIRSBottom.Text
                enableInputFields(True)
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If User.PermissionCheck("WA_PMCR_MCIRS", "Modify") Then
                loadBaseForm()
                setDefaultValues()
                lblNoRecord.Visible = False
                btnMCIRSBottom.Text = "Save Record"
                btnMCIRSTop.Text = btnMCIRSBottom.Text
                enableInputFields(True)
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
            End If
        Else 'By default, user is attempting to Insert or Edit a record. Run preSaveValidation.
            If preSaveValidation() Then 'If preSaveValidation returns true, take Insert or Update actions.
                'Same parameters for Insert or Update SP's, so define here
                Dim parameters = "@SubNum = " & WarehouseShell.SubNum &
                        ", @Cardiac = " & comboCardiac.getSQLValue() &
                        ", @Hypertension = " & comboHypertension.getSQLValue() &
                        ", @Vascular = " & comboVasc.getSQLValue() &
                        ", @Respiratory = " & comboResp.getSQLValue() &
                        ", @EENT = " & comboEENT.getSQLValue() &
                        ", @UpperGI = " & comboUpperGI.getSQLValue() &
                        ", @LowerGI = " & comboLowerGI.getSQLValue() &
                        ", @Hepatic = " & comboHepatic.getSQLValue() &
                        ", @Renal = " & comboRenal.getSQLValue() &
                        ", @OtherGU = " & comboOtherGU.getSQLValue() &
                        ", @MusculoSkeletal = " & comboMusculo.getSQLValue() &
                        ", @Neurological = " & comboNeurological.getSQLValue() &
                        ", @EndocrineMetabolic = " & comboEndocrine.getSQLValue() &
                        ", @PsychBehavioral = " & comboPsychiatric.getSQLValue() &
                        ", @TotalScore = " & txtMCIRSScore.getSQLValue() &
                        ", @LastModBy = '" & WarehouseShell.userName & "';"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    Dim cmdString = "Exec modPMCR_MCIRSRecord @Action = 1, " & parameters
                    Dim cmd As New SqlCommand(cmdString, WarehouseShell.conn)
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Record Saved", MsgBoxStyle.OkOnly)
                        enableInputFields(False)
                        btnMCIRSBottom.Text = "Edit Record"
                        btnMCIRSTop.Text = btnMCIRSBottom.Text
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else 'If this clause is invoked, datamode must be Edit
                    Dim cmdString = "Exec modPMCR_MCIRSRecord @Action = 2, " & parameters
                    Dim cmd As New SqlCommand(cmdString, WarehouseShell.conn)
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Record Saved", MsgBoxStyle.OkOnly)
                        enableInputFields(False)
                        btnMCIRSBottom.Text = "Edit Record"
                        btnMCIRSTop.Text = btnMCIRSBottom.Text
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
        btnMCIRSBottom.PerformClick()
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