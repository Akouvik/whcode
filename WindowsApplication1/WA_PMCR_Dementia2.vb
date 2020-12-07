Public Class WA_PMCR_Dementia2
    Implements IFormMethods
    Private formTables As New DataSet

    Private Sub WA_PMCR_Dementia2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Database.ExistingRecordCheck("PMCR_Dementia2", "SubNum = " & WarehouseShell.SubNum) Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            loadBase()
            loadExistingData()
            btnDementia2Bottom.Text = "Edit Record"
            btnDementia2Top.Text = btnDementia2Bottom.Text
        Else 'If it doesn't exist, change mode to Undefined and show user banner
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            lblNoRecord.Visible = True
            btnDementia2Top.Text = "Add New Record"
            btnDementia2Bottom.Text = "Add New Record"
        End If
        enableInputFields(False)
    End Sub

    Private Sub loadBase()
        WarehouseShell.highlightSelectedNode("WA_PMCR_tabDementia2")
        'Grab any required comboLookUp tables and assign them to their appropriate boxes
        formTables.Tables.Add(Database.ReturnTable("lkpYNUnk129NoBlank"))
        formTables.Tables.Add(Database.ReturnTable("lkpPMCR_DementiaMeetsDLB"))
        cmbConsDxDLB.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbFluctCog.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbRecVisHall.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbMotFeatPark.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbRepFalls.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbSyncope.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbTransLossCon.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbNeuroleptic.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbSysDel.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbHallOthMod.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbStrokeDisease.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbEviPhyIll.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbConMeetsCritDLB.assignLookup(formTables, "lkpPMCR_DementiaMeetsDLB")
        cmbProbADUncomp.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbProbADComp.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbPossADAtyp.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbPossADTyp.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbProbVascDem.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbPossVascDem.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbUnusVascDem.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbDemSynDep.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbDelirium.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbProbConfDrugs.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbPossConfDrugs.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbProbDemPark.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbPossDemPark.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbOthDemDis.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbBehCogDef.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbDefSigImp.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbGradOnset.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbDefNotNerv.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbDefNotDel.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbNotPsychDx.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbFTDMeetsCriteria.assignLookup(formTables, "lkpYNUnk129NoBlank")
    End Sub
    Private Sub setDefaultValues()
        cmbConsDxDLB.SelectedValue = 2
        cmbFluctCog.SelectedValue = 2
        cmbRecVisHall.SelectedValue = 2
        cmbMotFeatPark.SelectedValue = 2
        cmbRepFalls.SelectedValue = 2
        cmbSyncope.SelectedValue = 2
        cmbTransLossCon.SelectedValue = 2
        cmbNeuroleptic.SelectedValue = 2
        cmbSysDel.SelectedValue = 2
        cmbHallOthMod.SelectedValue = 2
        cmbStrokeDisease.SelectedValue = 2
        cmbEviPhyIll.SelectedValue = 2
        cmbConMeetsCritDLB.SelectedValue = 1
        cmbProbADUncomp.SelectedValue = 2
        cmbProbADComp.SelectedValue = 2
        cmbPossADAtyp.SelectedValue = 2
        cmbPossADTyp.SelectedValue = 2
        cmbProbVascDem.SelectedValue = 2
        cmbPossVascDem.SelectedValue = 2
        cmbUnusVascDem.SelectedValue = 2
        cmbDemSynDep.SelectedValue = 2
        cmbDelirium.SelectedValue = 2
        cmbProbConfDrugs.SelectedValue = 2
        cmbPossConfDrugs.SelectedValue = 2
        cmbProbDemPark.SelectedValue = 2
        cmbPossDemPark.SelectedValue = 2
        cmbOthDemDis.SelectedValue = 2
        cmbBehCogDef.SelectedValue = 2
        cmbDefSigImp.SelectedValue = 2
        cmbGradOnset.SelectedValue = 2
        cmbDefNotNerv.SelectedValue = 2
        cmbDefNotDel.SelectedValue = 2
        cmbNotPsychDx.SelectedValue = 2
        cmbFTDMeetsCriteria.SelectedValue = 2
    End Sub
    Private Sub loadExistingData()
        'Grab the individual record, based on RecordID, and assign values to their appropriate fields
        formTables.Tables.Add(Database.ReturnTable("PMCR_Dementia2", , "SubNum = " & WarehouseShell.SubNum))
        cmbConsDxDLB.setValue(formTables, "PMCR_Dementia2", "CentralFeature")
        cmbFluctCog.setValue(formTables, "PMCR_Dementia2", "FluctCognition")
        cmbRecVisHall.setValue(formTables, "PMCR_Dementia2", "RecurrentVisual")
        cmbMotFeatPark.setValue(formTables, "PMCR_Dementia2", "SpontMotor")
        cmbRepFalls.setValue(formTables, "PMCR_Dementia2", "RepeatedFalls")
        cmbSyncope.setValue(formTables, "PMCR_Dementia2", "Syncope")
        cmbTransLossCon.setValue(formTables, "PMCR_Dementia2", "LossConscious")
        cmbNeuroleptic.setValue(formTables, "PMCR_Dementia2", "Neuroleptic")
        cmbSysDel.setValue(formTables, "PMCR_Dementia2", "SystDelusions")
        cmbHallOthMod.setValue(formTables, "PMCR_Dementia2", "Hallucinations")
        cmbStrokeDisease.setValue(formTables, "PMCR_Dementia2", "StrokeDisease")
        cmbEviPhyIll.setValue(formTables, "PMCR_Dementia2", "PysIllDisorder")
        cmbConMeetsCritDLB.setValue(formTables, "PMCR_Dementia2", "MeetsDLBCriteria")
        cmbProbADUncomp.setValue(formTables, "PMCR_Dementia2", "ProbADUncomp")
        cmbProbADComp.setValue(formTables, "PMCR_Dementia2", "ProbADComp")
        cmbPossADAtyp.setValue(formTables, "PMCR_Dementia2", "PossADAtyp")
        cmbPossADTyp.setValue(formTables, "PMCR_Dementia2", "PossADTyp")
        cmbProbVascDem.setValue(formTables, "PMCR_Dementia2", "ProbVascDem")
        cmbPossVascDem.setValue(formTables, "PMCR_Dementia2", "PossVascDem")
        cmbUnusVascDem.setValue(formTables, "PMCR_Dementia2", "UnusVascDem")
        cmbDemSynDep.setValue(formTables, "PMCR_Dementia2", "DemSyndDep")
        cmbDelirium.setValue(formTables, "PMCR_Dementia2", "Delirium")
        cmbProbConfDrugs.setValue(formTables, "PMCR_Dementia2", "ProbConfDrugs")
        cmbPossConfDrugs.setValue(formTables, "PMCR_Dementia2", "PossConfDrugs")
        cmbProbDemPark.setValue(formTables, "PMCR_Dementia2", "ProbDemPark")
        cmbPossDemPark.setValue(formTables, "PMCR_Dementia2", "PossDemPark")
        cmbOthDemDis.setValue(formTables, "PMCR_Dementia2", "OtherDemDis")
        txtDemCERADNotes.setValue(formTables, "PMCR_Dementia2", "CERADNotes")
        cmbBehCogDef.setValue(formTables, "PMCR_Dementia2", "BehCogDeficits")
        cmbDefSigImp.setValue(formTables, "PMCR_Dementia2", "DeficitsSigImp")
        cmbGradOnset.setValue(formTables, "PMCR_Dementia2", "GradOnset")
        cmbDefNotNerv.setValue(formTables, "PMCR_Dementia2", "NotDueNervous")
        cmbDefNotDel.setValue(formTables, "PMCR_Dementia2", "NotDelirium")
        cmbNotPsychDx.setValue(formTables, "PMCR_Dementia2", "NotPsychDiag")
        cmbFTDMeetsCriteria.setValue(formTables, "PMCR_Dementia2", "MeetsFTDCriteria")
    End Sub
    Private Sub enableInputFields(ByVal bool As Boolean)
        cmbConsDxDLB.Enabled = bool
        cmbFluctCog.Enabled = bool
        cmbRecVisHall.Enabled = bool
        cmbMotFeatPark.Enabled = bool
        cmbRepFalls.Enabled = bool
        cmbSyncope.Enabled = bool
        cmbTransLossCon.Enabled = bool
        cmbNeuroleptic.Enabled = bool
        cmbSysDel.Enabled = bool
        cmbHallOthMod.Enabled = bool
        cmbStrokeDisease.Enabled = bool
        cmbEviPhyIll.Enabled = bool
        cmbProbADUncomp.Enabled = bool
        cmbProbADComp.Enabled = bool
        cmbPossADAtyp.Enabled = bool
        cmbPossADTyp.Enabled = bool
        cmbProbVascDem.Enabled = bool
        cmbPossVascDem.Enabled = bool
        cmbUnusVascDem.Enabled = bool
        cmbDemSynDep.Enabled = bool
        cmbDelirium.Enabled = bool
        cmbProbConfDrugs.Enabled = bool
        cmbPossConfDrugs.Enabled = bool
        cmbProbDemPark.Enabled = bool
        cmbPossDemPark.Enabled = bool
        cmbOthDemDis.Enabled = bool
        txtDemCERADNotes.makeReadOnly(Not bool)
        cmbBehCogDef.Enabled = bool
        cmbDefSigImp.Enabled = bool
        cmbGradOnset.Enabled = bool
        cmbDefNotNerv.Enabled = bool
        cmbDefNotDel.Enabled = bool
        cmbNotPsychDx.Enabled = bool
    End Sub

    Private Sub calcDLBCriteria(sender As Object, e As EventArgs) Handles cmbConsDxDLB.SelectedValueChanged, cmbFluctCog.SelectedValueChanged, cmbRecVisHall.SelectedValueChanged, cmbMotFeatPark.SelectedValueChanged, cmbRepFalls.SelectedValueChanged, cmbSyncope.SelectedValueChanged, cmbTransLossCon.SelectedValueChanged, cmbNeuroleptic.SelectedValueChanged, cmbSysDel.SelectedValueChanged, cmbHallOthMod.SelectedValueChanged, cmbStrokeDisease.SelectedValueChanged, cmbEviPhyIll.SelectedValueChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View And WarehouseShell.DataMode <> WarehouseShell.userDataMode.Undefined Then
            If cmbConsDxDLB.SelectedValue = 1 Then
                Dim Item2Count As Integer = 0
                If cmbFluctCog.SelectedValue = 1 Then
                    Item2Count += 1
                End If
                If cmbRecVisHall.SelectedValue = 1 Then
                    Item2Count += 1
                End If
                If cmbMotFeatPark.SelectedValue = 1 Then
                    Item2Count += 1
                End If
                If Item2Count >= 2 Then
                    cmbConMeetsCritDLB.SelectedValue = 3
                ElseIf Item2Count = 1 Then
                    cmbConMeetsCritDLB.SelectedValue = 2
                End If
            Else
                If cmbConsDxDLB.SelectedValue <> 9 Then
                    If cmbFluctCog.SelectedValue <> 9 Or cmbRecVisHall.SelectedValue <> 9 Or cmbMotFeatPark.SelectedValue <> 9 Then
                        cmbConMeetsCritDLB.SelectedValue = 1
                    Else
                        cmbConMeetsCritDLB.SelectedValue = 4
                    End If
                Else
                    cmbConMeetsCritDLB.SelectedValue = 4
                End If
            End If
        End If
    End Sub
    Private Sub calcFTDCriteria(sender As Object, e As EventArgs) Handles cmbBehCogDef.SelectedValueChanged, cmbDefSigImp.SelectedValueChanged, cmbGradOnset.SelectedValueChanged, cmbDefNotNerv.SelectedValueChanged, cmbDefNotDel.SelectedValueChanged, cmbNotPsychDx.SelectedValueChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View And WarehouseShell.DataMode <> WarehouseShell.userDataMode.Undefined Then
            If cmbBehCogDef.SelectedValue = 1 And cmbDefSigImp.SelectedValue = 1 And cmbGradOnset.SelectedValue = 1 And cmbDefNotNerv.SelectedValue = 1 And cmbDefNotDel.SelectedValue = 1 And cmbNotPsychDx.SelectedValue = 1 Then
                cmbFTDMeetsCriteria.SelectedValue = 1
            End If
        End If
    End Sub

    Private Sub btnDementia2_Click(sender As Object, e As EventArgs) Handles btnDementia2Bottom.Click, btnDementia2Top.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_PMCR_Dementia2", "Modify") Then
                btnDementia2Bottom.Text = "Save Changes"
                btnDementia2Top.Text = "Save Changes"
                enableInputFields(True)
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If User.PermissionCheck("WA_PMCR_Dementia2", "Modify") Then
                loadBase()
                setDefaultValues()
                lblNoRecord.Visible = False
                btnDementia2Top.Text = "Save New Record"
                btnDementia2Bottom.Text = "Save New Record"
                enableInputFields(True)
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
            End If
        Else 'By default, user is attempting to Insert or Edit a record.
            If preSaveValidation() Then 'If preSaveValidation returns true, take Insert or Update actions.
                'Same parameters for Insert or Update SP's, so define here
                Dim parameters = " @SubNum = " & WarehouseShell.SubNum &
                    ", @CentralFeature = " & cmbConsDxDLB.getSQLValue() &
                    ", @FluctCognition = " & cmbFluctCog.getSQLValue() &
                    ", @RecurrentVisual = " & cmbRecVisHall.getSQLValue() &
                    ", @SpontMotor = " & cmbMotFeatPark.getSQLValue() &
                    ", @RepeatedFalls = " & cmbRepFalls.getSQLValue() &
                    ", @Syncope = " & cmbSyncope.getSQLValue() &
                    ", @LossConscious = " & cmbTransLossCon.getSQLValue() &
                    ", @Neuroleptic = " & cmbNeuroleptic.getSQLValue() &
                    ", @SystDelusions = " & cmbSysDel.getSQLValue() &
                    ", @Hallucinations = " & cmbHallOthMod.getSQLValue() &
                    ", @StrokeDisease = " & cmbStrokeDisease.getSQLValue() &
                    ", @PysIllDisorder = " & cmbEviPhyIll.getSQLValue() &
                    ", @MeetsDLBCriteria = " & cmbConMeetsCritDLB.getSQLValue() &
                    ", @ProbADUncomp = " & cmbProbADUncomp.getSQLValue() &
                    ", @ProbADComp = " & cmbProbADComp.getSQLValue() &
                    ", @PossADAtyp = " & cmbPossADAtyp.getSQLValue() &
                    ", @PossADTyp = " & cmbPossADTyp.getSQLValue() &
                    ", @ProbVascDem = " & cmbProbVascDem.getSQLValue() &
                    ", @PossVascDem = " & cmbPossVascDem.getSQLValue() &
                    ", @UnusVascDem = " & cmbUnusVascDem.getSQLValue() &
                    ", @DemSyndDep = " & cmbDemSynDep.getSQLValue() &
                    ", @Delirium = " & cmbDelirium.getSQLValue() &
                    ", @ProbConfDrugs = " & cmbProbConfDrugs.getSQLValue() &
                    ", @PossConfDrugs = " & cmbPossConfDrugs.getSQLValue() &
                    ", @ProbDemPark = " & cmbProbDemPark.getSQLValue() &
                    ", @PossDemPark = " & cmbPossDemPark.getSQLValue() &
                    ", @OtherDemDis = " & cmbOthDemDis.getSQLValue() &
                    ", @CERADNotes = " & txtDemCERADNotes.getSQLValue() &
                    ", @BehCogDeficits = " & cmbBehCogDef.getSQLValue() &
                    ", @DeficitsSigImp = " & cmbDefSigImp.getSQLValue() &
                    ", @GradOnset = " & cmbGradOnset.getSQLValue() &
                    ", @NotDueNervous = " & cmbDefNotNerv.getSQLValue() &
                    ", @NotDelirium = " & cmbDefNotDel.getSQLValue() &
                    ", @NotPsychDiag = " & cmbNotPsychDx.getSQLValue() &
                    ", @MeetsFTDCriteria = " & cmbFTDMeetsCriteria.getSQLValue() &
                    ", @LastModBy = '" & WarehouseShell.userName & "';"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    Dim cmd As New SqlCommand("Exec modPMCR_Dementia2Record @Action = 1, " & parameters, WarehouseShell.conn)
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Save Successful", MsgBoxStyle.OkOnly)
                        enableInputFields(False)
                        btnDementia2Top.Text = "Edit Record"
                        btnDementia2Bottom.Text = "Edit Record"
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    Catch ex As Exception
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else 'If this clause is invoked, datamode must be Edit
                    Dim cmd As New SqlCommand("Exec modPMCR_Dementia2Record @Action = 2, " & parameters, WarehouseShell.conn)
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Save Successful", MsgBoxStyle.OkOnly)
                        enableInputFields(False)
                        btnDementia2Top.Text = "Edit Record"
                        btnDementia2Bottom.Text = "Edit Record"
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    Catch ex As Exception
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
        btnDementia2Bottom.PerformClick()
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