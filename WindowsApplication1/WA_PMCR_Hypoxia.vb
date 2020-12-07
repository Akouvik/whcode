Public Class WA_PMCR_Hypoxia
    Implements IFormMethods
    Private formTables As New DataSet

    Private Sub WA_PMCR_Hypoxia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
        loadBaseForm()
        If Database.ExistingRecordCheck("PMCR_Hypoxia", "SubNum = " & WarehouseShell.SubNum) Then
            loadExistingData()
            btnHypoxiaTop.Text = "Edit this record"
            btnHypoxiaBottom.Text = "Edit this record"
            lblNoRecord.Visible = False
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        Else
            btnHypoxiaTop.Text = "Add new record"
            btnHypoxiaBottom.Text = "Add new record"
            lblNoRecord.Visible = True
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
        End If
        enableInputFields(False)
    End Sub
    Private Sub loadBaseForm()
        WarehouseShell.highlightSelectedNode("WA_PMCR_tabHypoxia")
        'Grab any required comboLookUp tables and assign them to their appropriate boxes
        formTables.Tables.Add(Database.ReturnTable("lkpYNNAUnk1239",,, "Value asc"))
        formTables.Tables.Add(Database.ReturnTable("lkpPMCR_HypoxCGI"))
        formTables.Tables.Add(Database.ReturnTable("lkpGlasgowMotor"))
        formTables.Tables.Add(Database.ReturnTable("lkpGlasgowVerbal"))
        formTables.Tables.Add(Database.ReturnTable("lkpGlasgowEye"))
        comboIntubation.assignLookup(formTables, "lkpYNNAUnk1239")
        comboNasalO2.assignLookup(formTables, "lkpYNNAUnk1239")
        comboPeriagonalOther.assignLookup(formTables, "lkpYNNAUnk1239")
        comboAlert.assignLookup(formTables, "lkpYNNAUnk1239")
        comboDelirium.assignLookup(formTables, "lkpYNNAUnk1239")
        comboComa.assignLookup(formTables, "lkpYNNAUnk1239")
        comboCGIHypoxia.assignLookup(formTables, "lkpPMCR_HypoxCGI")
        comboHallucinations.assignLookup(formTables, "lkpYNNAUnk1239")
        comboDelusion.assignLookup(formTables, "lkpYNNAUnk1239")
        comboProblemBehavior.assignLookup(formTables, "lkpYNNAUnk1239")
        comboParkinsonism.assignLookup(formTables, "lkpYNNAUnk1239")
        comboTardiveDyskinesia.assignLookup(formTables, "lkpYNNAUnk1239")
        comboNonParkinsonianTremor.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbMotor.assignLookup(formTables, "lkpGlasgowMotor",,,, "Value asc")
        cmbVerbal.assignLookup(formTables, "lkpGlasgowVerbal",,,, "Value asc")
        cmbEye.assignLookup(formTables, "lkpGlasgowEye",,,, "Value asc")
    End Sub
    Private Sub setDefaultValues()
        comboIntubation.SelectedValue = 2
        comboNasalO2.SelectedValue = 2
        comboPeriagonalOther.SelectedValue = 2
        comboAlert.SelectedValue = 2
        comboDelirium.SelectedValue = 2
        comboComa.SelectedValue = 2
        comboCGIHypoxia.SelectedValue = 0
        comboHallucinations.SelectedValue = 2
        comboDelusion.SelectedValue = 2
        comboProblemBehavior.SelectedValue = 2
        comboParkinsonism.SelectedValue = 2
        comboTardiveDyskinesia.SelectedValue = 2
        comboNonParkinsonianTremor.SelectedValue = 2
        cmbMotor.SelectedValue = -1
        cmbVerbal.SelectedValue = -1
        cmbEye.SelectedValue = -1
    End Sub
    Private Sub loadExistingData()
        'Grab the individual record, based on RecordID, and assign values to their appropriate fields
        formTables.Tables.Add(Database.ReturnTable("PMCR_Hypoxia", , "SubNum = " & WarehouseShell.SubNum))
        comboIntubation.setValue(formTables, "PMCR_Hypoxia", "Intubation")
        txtIntubationDate.setValue(formTables, "PMCR_Hypoxia", "IntubationDate")
        intIntubationHours.setValue(formTables, "PMCR_Hypoxia", "IntubationHours")
        comboNasalO2.setValue(formTables, "PMCR_Hypoxia", "NasalO2")
        txtNasalO2Date.setValue(formTables, "PMCR_Hypoxia", "NasalO2Date")
        intNasalO2Hours.setValue(formTables, "PMCR_Hypoxia", "NasalO2Hours")
        comboPeriagonalOther.setValue(formTables, "PMCR_Hypoxia", "Other")
        txtPeriagonalOtherDate.setValue(formTables, "PMCR_Hypoxia", "OtherDate")
        intPeriagonalOtherHours.setValue(formTables, "PMCR_Hypoxia", "OtherHours")
        txtPeriagonalOther.setValue(formTables, "PMCR_Hypoxia", "OtherNote")
        comboAlert.setValue(formTables, "PMCR_Hypoxia", "Alert")
        txtAlert.setValue(formTables, "PMCR_Hypoxia", "AlertNote")
        comboDelirium.setValue(formTables, "PMCR_Hypoxia", "Delirium")
        txtDelirium.setValue(formTables, "PMCR_Hypoxia", "DeliriumNote")
        comboComa.setValue(formTables, "PMCR_Hypoxia", "Coma")
        txtComa.setValue(formTables, "PMCR_Hypoxia", "ComaNote")
        txtPremorbidWeeks.setValue(formTables, "PMCR_Hypoxia", "Weeks")
        txtPremorbidDays.setValue(formTables, "PMCR_Hypoxia", "Days")
        txtPremorbidHours.setValue(formTables, "PMCR_Hypoxia", "Hours")
        txtPremorbidMinutes.setValue(formTables, "PMCR_Hypoxia", "Minutes")
        comboCGIHypoxia.setValue(formTables, "PMCR_Hypoxia", "CGIHypoxia")
        comboHallucinations.setValue(formTables, "PMCR_Hypoxia", "Hallucinations")
        txtHallucinationsDate.setValue(formTables, "PMCR_Hypoxia", "HallucinationsDate")
        txtHallucinations.setValue(formTables, "PMCR_Hypoxia", "HallucinationsNote")
        comboDelusion.setValue(formTables, "PMCR_Hypoxia", "Delusion")
        txtDelusionDate.setValue(formTables, "PMCR_Hypoxia", "DelusionDate")
        txtDelusion.setValue(formTables, "PMCR_Hypoxia", "DelusionNote")
        comboProblemBehavior.setValue(formTables, "PMCR_Hypoxia", "ProblemBehavior")
        txtProblemBehaviorDate.setValue(formTables, "PMCR_Hypoxia", "ProblemBehaviorDate")
        txtProblemBehavior.setValue(formTables, "PMCR_Hypoxia", "ProblemBehaviorNote")
        comboParkinsonism.setValue(formTables, "PMCR_Hypoxia", "Parkinsonism")
        txtParkinsonismDate.setValue(formTables, "PMCR_Hypoxia", "ParkinsonismDate")
        txtParkinsonism.setValue(formTables, "PMCR_Hypoxia", "ParkinsonismNote")
        comboTardiveDyskinesia.setValue(formTables, "PMCR_Hypoxia", "TardiveDysk")
        txtTardiveDyskinesiaDate.setValue(formTables, "PMCR_Hypoxia", "TardiveDyskDate")
        txtTardiveDyskinesia.setValue(formTables, "PMCR_Hypoxia", "TardiveDyskNote")
        comboNonParkinsonianTremor.setValue(formTables, "PMCR_Hypoxia", "Tremor")
        txtNonParkinsonianTremorDate.setValue(formTables, "PMCR_Hypoxia", "TremorDate")
        txtNonParkinsonianTremor.setValue(formTables, "PMCR_Hypoxia", "TremorNote")
        cmbMotor.setValue(formTables, "PMCR_Hypoxia", "GlasgowMotor")
        cmbVerbal.setValue(formTables, "PMCR_Hypoxia", "GlasgowVerbal")
        cmbEye.setValue(formTables, "PMCR_Hypoxia", "GlasgowEye")
        intGCSTotal.setValue(formTables, "PMCR_Hypoxia", "GlasgowScore")
        txtHypoxiaNotes.setValue(formTables, "PMCR_Hypoxia", "HypoxiaNotes")
    End Sub
    Private Sub enableInputFields(ByVal bool As Boolean)
        comboIntubation.Enabled = bool
        txtIntubationDate.Enabled = bool
        intIntubationHours.Enabled = bool
        comboNasalO2.Enabled = bool
        txtNasalO2Date.Enabled = bool
        intNasalO2Hours.Enabled = bool
        comboPeriagonalOther.Enabled = bool
        txtPeriagonalOtherDate.Enabled = bool
        intPeriagonalOtherHours.Enabled = bool
        txtPeriagonalOther.makeReadOnly(Not bool)
        comboAlert.Enabled = bool
        txtAlert.makeReadOnly(Not bool)
        comboDelirium.Enabled = bool
        txtDelirium.makeReadOnly(Not bool)
        comboComa.Enabled = bool
        txtComa.Enabled = bool
        txtPremorbidWeeks.Enabled = bool
        txtPremorbidDays.Enabled = bool
        txtPremorbidHours.Enabled = bool
        txtPremorbidMinutes.Enabled = bool
        comboCGIHypoxia.Enabled = bool
        comboHallucinations.Enabled = bool
        txtHallucinationsDate.Enabled = bool
        txtHallucinations.makeReadOnly(Not bool)
        comboDelusion.Enabled = bool
        txtDelusionDate.Enabled = bool
        txtDelusion.makeReadOnly(Not bool)
        comboProblemBehavior.Enabled = bool
        txtProblemBehaviorDate.Enabled = bool
        txtProblemBehavior.makeReadOnly(Not bool)
        comboParkinsonism.Enabled = bool
        txtParkinsonismDate.Enabled = bool
        txtParkinsonism.makeReadOnly(Not bool)
        comboTardiveDyskinesia.Enabled = bool
        txtTardiveDyskinesiaDate.Enabled = bool
        txtTardiveDyskinesia.makeReadOnly(Not bool)
        comboNonParkinsonianTremor.Enabled = bool
        txtNonParkinsonianTremorDate.Enabled = bool
        txtNonParkinsonianTremor.makeReadOnly(Not bool)
        cmbMotor.Enabled = bool
        cmbVerbal.Enabled = bool
        cmbEye.Enabled = bool
        txtHypoxiaNotes.makeReadOnly(Not bool)
    End Sub

    Private Sub calcGlasgowScore(sender As Object, e As EventArgs) Handles cmbMotor.SelectedValueChanged, cmbVerbal.SelectedValueChanged, cmbEye.SelectedValueChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View And WarehouseShell.DataMode <> WarehouseShell.userDataMode.Undefined Then
            If cmbMotor.SelectedValue <> -1 And cmbVerbal.SelectedValue <> -1 And cmbEye.SelectedValue <> -1 Then
                intGCSTotal.Text = (cmbMotor.SelectedValue + cmbVerbal.SelectedValue + cmbEye.SelectedValue).ToString
            Else
                intGCSTotal.Text = ""
            End If
        End If
    End Sub

    Private Sub btnHypoxia_Click(sender As Object, e As EventArgs) Handles btnHypoxiaBottom.Click, btnHypoxiaTop.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_PMCR_Hypoxia", "Modify") Then
                btnHypoxiaBottom.Text = "Save Changes"
                btnHypoxiaTop.Text = btnHypoxiaBottom.Text
                enableInputFields(True)
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If User.PermissionCheck("WA_PMCR_Hypoxia", "Modify") Then
                lblNoRecord.Visible = False
                btnHypoxiaBottom.Text = "Save New Record"
                btnHypoxiaTop.Text = "Save New Record"
                enableInputFields(True)
                setDefaultValues()
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
            End If
        Else 'By default, user is attempting to Insert or Edit a record. Run preSaveValidation.
            If preSaveValidation() Then 'If preSaveValidation returns true, take Insert or Update actions.
                'Same parameters for Insert or Update SP's, so define here
                Dim cmd As New SqlCommand("", WarehouseShell.conn)
                Dim parameters = " @SubNum = " & WarehouseShell.SubNum &
                        ", @Intubation = " & comboIntubation.getSQLValue() &
                        ", @IntubationDate = " & txtIntubationDate.getSQLValue() &
                        ", @IntubationHours = " & intIntubationHours.getSQLValue() &
                        ", @NasalO2 = " & comboNasalO2.getSQLValue() &
                        ", @NasalO2Date = " & txtNasalO2Date.getSQLValue() &
                        ", @NasalO2Hours = " & intNasalO2Hours.getSQLValue() &
                        ", @Other = " & comboPeriagonalOther.getSQLValue() &
                        ", @OtherDate = " & txtPeriagonalOtherDate.getSQLValue() &
                        ", @OtherHours = " & intPeriagonalOtherHours.getSQLValue() &
                        ", @OtherNote = " & txtPeriagonalOther.getSQLValue() &
                        ", @Alert = " & comboAlert.getSQLValue() &
                        ", @AlertNote = " & txtAlert.getSQLValue() &
                        ", @Delirium = " & comboDelirium.getSQLValue() &
                        ", @DeliriumNote = " & txtDelirium.getSQLValue() &
                        ", @Coma = " & comboComa.getSQLValue() &
                        ", @ComaNote = " & txtComa.getSQLValue() &
                        ", @Weeks = " & txtPremorbidWeeks.getSQLValue() &
                        ", @Days = " & txtPremorbidDays.getSQLValue() &
                        ", @Hours = " & txtPremorbidHours.getSQLValue() &
                        ", @Minutes = " & txtPremorbidMinutes.getSQLValue() &
                        ", @CGIHypoxia = " & comboCGIHypoxia.getSQLValue() &
                        ", @Hallucinations = " & comboHallucinations.getSQLValue() &
                        ", @HallucinationsDate = " & txtHallucinationsDate.getSQLValue() &
                        ", @HallucinationsNote = " & txtHallucinations.getSQLValue() &
                        ", @Delusion = " & comboDelusion.getSQLValue() &
                        ", @DelusionDate = " & txtDelusionDate.getSQLValue() &
                        ", @DelusionNote = " & txtDelusion.getSQLValue() &
                        ", @ProblemBehavior = " & comboProblemBehavior.getSQLValue() &
                        ", @ProblemBehaviorDate = " & txtProblemBehaviorDate.getSQLValue() &
                        ", @ProblemBehaviorNote = " & txtProblemBehavior.getSQLValue() &
                        ", @Parkinsonism = " & comboParkinsonism.getSQLValue() &
                        ", @ParkinsonismDate = " & txtParkinsonismDate.getSQLValue() &
                        ", @ParkinsonismNote = " & txtParkinsonism.getSQLValue() &
                        ", @TardiveDysk = " & comboTardiveDyskinesia.getSQLValue() &
                        ", @TardiveDyskDate = " & txtTardiveDyskinesiaDate.getSQLValue() &
                        ", @TardiveDyskNote = " & txtTardiveDyskinesia.getSQLValue() &
                        ", @Tremor = " & comboNonParkinsonianTremor.getSQLValue() &
                        ", @TremorDate = " & txtNonParkinsonianTremorDate.getSQLValue() &
                        ", @TremorNote = " & txtNonParkinsonianTremor.getSQLValue() &
                        ", @GlasgowMotor = " & cmbMotor.getSQLValue() &
                        ", @GlasgowVerbal = " & cmbVerbal.getSQLValue() &
                        ", @GlasgowEye = " & cmbEye.getSQLValue() &
                        ", @GlasgowScore = " & intGCSTotal.getSQLValue() &
                        ", @HypoxiaNotes = " & txtHypoxiaNotes.getSQLValue() &
                        ", @LastModBy = '" & WarehouseShell.userName & "';"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    Dim cmdString = "Exec modPMCR_HypoxiaRecord @Action = 1, " & parameters
                    cmd.CommandText = cmdString
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Record successfully added.", MsgBoxStyle.OkOnly, "Success")
                        enableInputFields(False)
                        btnHypoxiaBottom.Text = "Edit Record"
                        btnHypoxiaTop.Text = btnHypoxiaBottom.Text
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else 'If this clause is invoked, datamode must be Edit
                    Dim cmdString = "Exec modPMCR_HypoxiaRecord @Action = 2, " & parameters
                    cmd.CommandText = cmdString
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Record successfully updated.", MsgBoxStyle.OkOnly, "Success")
                        enableInputFields(False)
                        btnHypoxiaBottom.Text = "Edit Record"
                        btnHypoxiaTop.Text = btnHypoxiaBottom.Text
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
        btnHypoxiaTop.PerformClick()
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