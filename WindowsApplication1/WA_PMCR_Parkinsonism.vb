Public Class WA_PMCR_Parkinsonism
    Implements IFormMethods
    Private formTables As New DataSet

    Private Sub WA_PMCR_Parkinsonism_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Database.ExistingRecordCheck("PMCR_Parkinsonism", "SubNum = " & WarehouseShell.SubNum) Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            loadBaseForm()
            loadExistingData()
            enableInputFields(False)
            btnParkinsonismBottom.Text = "Edit Record"
            btnParkinsonismTop.Text = btnParkinsonismBottom.Text
        Else 'If it doesn't exist, change mode to Undefined and show user banner
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            enableInputFields(False)
            lblNoRecord.Visible = True
            btnParkinsonismBottom.Text = "Add New Record"
            btnParkinsonismTop.Text = btnParkinsonismBottom.Text
        End If
    End Sub
    Private Sub loadBaseForm()
        WarehouseShell.highlightSelectedNode("WA_PMCR_tabParkinsonism")
        'Grab any required comboLookUp tables and assign them to their appropriate boxes
        formTables.Tables.Add(Database.ReturnTable("lkpYNUnk129NoBlank"))
        formTables.Tables.Add(Database.ReturnTable("lkpPMCR_ParkinsonsDx"))
        cmbTremorResting.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbTremorPostural.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbTremorAction.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbRigidActivation.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbRigidCog.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbRigidROM.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbBradyBody.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbBradyFace.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbAsymetricOnset.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbPsychHall.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbCurLastMo.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbPresLastYear.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbLifetime.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbPromPostInstab.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbFreezePhenom.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbDemPreMotorSx.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbSupranuclearGaze.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbSevSymptDysauto.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbDocCondPark.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbEnBlocTurning.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbParkGait.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbParkSpeech.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbDyskinesias.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbAntiParkMeds.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbClinEviImp.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbMedsExtrapyramidal.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbPDAnteDem.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbLegPsychoHall.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbLegCurLastMo.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbLegPresLastYear.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbLegLifetime.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbLegDelusions.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbDx3of4.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbDxNoGrpB.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbDxLevodopa.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbDxYesOnTremor.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbDxNoGrpBOrSxGrpA.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbDxNoAdequateDrugTrial.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbDxClinLeg.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbDxPDRelDem.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbParkDx.assignLookup(formTables, "lkpPMCR_ParkinsonsDx")
    End Sub
    Private Sub setDefaultValues()
        cmbTremorResting.SelectedValue = 2
        cmbTremorPostural.SelectedValue = 2
        cmbTremorAction.SelectedValue = 2
        cmbRigidActivation.SelectedValue = 2
        cmbRigidCog.SelectedValue = 2
        cmbRigidROM.SelectedValue = 2
        cmbBradyBody.SelectedValue = 2
        cmbBradyFace.SelectedValue = 2
        cmbAsymetricOnset.SelectedValue = 2
        cmbPsychHall.SelectedValue = 2
        cmbCurLastMo.SelectedValue = 2
        cmbPresLastYear.SelectedValue = 2
        cmbLifetime.SelectedValue = 2
        cmbPromPostInstab.SelectedValue = 2
        cmbFreezePhenom.SelectedValue = 2
        cmbDemPreMotorSx.SelectedValue = 2
        cmbSupranuclearGaze.SelectedValue = 2
        cmbSevSymptDysauto.SelectedValue = 2
        cmbDocCondPark.SelectedValue = 2
        cmbEnBlocTurning.SelectedValue = 2
        cmbParkGait.SelectedValue = 2
        cmbParkSpeech.SelectedValue = 2
        cmbDyskinesias.SelectedValue = 2
        cmbAntiParkMeds.SelectedValue = 2
        cmbClinEviImp.SelectedValue = 2
        cmbMedsExtrapyramidal.SelectedValue = 2
        cmbPDAnteDem.SelectedValue = 2
        cmbLegPsychoHall.SelectedValue = 2
        cmbLegCurLastMo.SelectedValue = 2
        cmbLegPresLastYear.SelectedValue = 2
        cmbLegLifetime.SelectedValue = 2
        cmbLegDelusions.SelectedValue = 2
        cmbDx3of4.SelectedValue = 2
        cmbDxNoGrpB.SelectedValue = 2
        cmbDxLevodopa.SelectedValue = 2
        cmbDxYesOnTremor.SelectedValue = 2
        cmbDxNoGrpBOrSxGrpA.SelectedValue = 2
        cmbDxNoAdequateDrugTrial.SelectedValue = 2
        cmbDxClinLeg.SelectedValue = 2
        cmbDxPDRelDem.SelectedValue = 2
        cmbParkDx.SelectedValue = 3
    End Sub
    Private Sub loadExistingData()
        'Grab the individual record, based on RecordID, and assign values to their appropriate fields
        formTables.Tables.Add(Database.ReturnTable("PMCR_Parkinsonism", , "SubNum = " & WarehouseShell.SubNum))
        cmbTremorResting.setValue(formTables, "PMCR_Parkinsonism", "TremorResting")
        cmbTremorPostural.setValue(formTables, "PMCR_Parkinsonism", "TremorPostural")
        cmbTremorAction.setValue(formTables, "PMCR_Parkinsonism", "TremorAction")
        cmbRigidActivation.setValue(formTables, "PMCR_Parkinsonism", "Rigidity")
        cmbRigidCog.setValue(formTables, "PMCR_Parkinsonism", "Cogwheeling")
        cmbRigidROM.setValue(formTables, "PMCR_Parkinsonism", "LimitationROM")
        cmbBradyBody.setValue(formTables, "PMCR_Parkinsonism", "BradyBody")
        cmbBradyFace.setValue(formTables, "PMCR_Parkinsonism", "BradyFace")
        cmbAsymetricOnset.setValue(formTables, "PMCR_Parkinsonism", "AsymetricOnset")
        cmbPsychHall.setValue(formTables, "PMCR_Parkinsonism", "PsychosisHall")
        cmbCurLastMo.setValue(formTables, "PMCR_Parkinsonism", "PsychosisHallMonth")
        cmbPresLastYear.setValue(formTables, "PMCR_Parkinsonism", "PsychosisHallYear")
        cmbLifetime.setValue(formTables, "PMCR_Parkinsonism", "PsychosisHallLife")
        cmbPromPostInstab.setValue(formTables, "PMCR_Parkinsonism", "PosturalInstab")
        cmbFreezePhenom.setValue(formTables, "PMCR_Parkinsonism", "FreezePhenom")
        cmbDemPreMotorSx.setValue(formTables, "PMCR_Parkinsonism", "DemPrecMotor")
        cmbSupranuclearGaze.setValue(formTables, "PMCR_Parkinsonism", "GazePalsy")
        cmbSevSymptDysauto.setValue(formTables, "PMCR_Parkinsonism", "Dysautonomia")
        cmbDocCondPark.setValue(formTables, "PMCR_Parkinsonism", "CondProdPark")
        cmbEnBlocTurning.setValue(formTables, "PMCR_Parkinsonism", "EnBlocTurning")
        cmbParkGait.setValue(formTables, "PMCR_Parkinsonism", "ParkGait")
        cmbParkSpeech.setValue(formTables, "PMCR_Parkinsonism", "ParkSpeech")
        cmbDyskinesias.setValue(formTables, "PMCR_Parkinsonism", "Dyskinesias")
        cmbAntiParkMeds.setValue(formTables, "PMCR_Parkinsonism", "AntiParkMeds")
        cmbClinEviImp.setValue(formTables, "PMCR_Parkinsonism", "ClinEvidImprov")
        cmbMedsExtrapyramidal.setValue(formTables, "PMCR_Parkinsonism", "ExtraPyramidalMeds")
        cmbPDAnteDem.setValue(formTables, "PMCR_Parkinsonism", "PDAntedateDem")
        cmbLegPsychoHall.setValue(formTables, "PMCR_Parkinsonism", "PsychoHall")
        cmbLegCurLastMo.setValue(formTables, "PMCR_Parkinsonism", "PsychoDeluMonth")
        cmbLegPresLastYear.setValue(formTables, "PMCR_Parkinsonism", "PsychoDeluYear")
        cmbLegLifetime.setValue(formTables, "PMCR_Parkinsonism", "PsychoDeluLife")
        cmbLegDelusions.setValue(formTables, "PMCR_Parkinsonism", "PsychoDelu")
        cmbDx3of4.setValue(formTables, "PMCR_Parkinsonism", "ThreeGrpA")
        cmbDxNoGrpB.setValue(formTables, "PMCR_Parkinsonism", "NoneGrpB")
        cmbDxLevodopa.setValue(formTables, "PMCR_Parkinsonism", "RespoLevodopa")
        cmbDxYesOnTremor.setValue(formTables, "PMCR_Parkinsonism", "GrpATremorBrady")
        cmbDxNoGrpBOrSxGrpA.setValue(formTables, "PMCR_Parkinsonism", "NoGrpBGrpA")
        cmbDxNoAdequateDrugTrial.setValue(formTables, "PMCR_Parkinsonism", "RespoLevoOrDrugTrial")
        cmbDxClinLeg.setValue(formTables, "PMCR_Parkinsonism", "ClinLegDiag")
        cmbDxPDRelDem.setValue(formTables, "PMCR_Parkinsonism", "PDRelatedDem")
        cmbParkDx.setValue(formTables, "PMCR_Parkinsonism", "ParkinsonsDx")
        txtPDNotes.setValue(formTables, "PMCR_Parkinsonism", "Notes")
    End Sub
    Private Sub enableInputFields(ByVal bool As Boolean)
        cmbTremorResting.Enabled = bool
        cmbTremorPostural.Enabled = bool
        cmbTremorAction.Enabled = bool
        cmbRigidActivation.Enabled = bool
        cmbRigidCog.Enabled = bool
        cmbRigidROM.Enabled = bool
        cmbDx3of4.Enabled = bool
        cmbBradyBody.Enabled = bool
        cmbBradyFace.Enabled = bool
        cmbAsymetricOnset.Enabled = bool
        cmbPsychHall.Enabled = bool
        cmbCurLastMo.Enabled = bool
        cmbPresLastYear.Enabled = bool
        cmbLifetime.Enabled = bool
        cmbPromPostInstab.Enabled = bool
        cmbFreezePhenom.Enabled = bool
        cmbDemPreMotorSx.Enabled = bool
        cmbSupranuclearGaze.Enabled = bool
        cmbSevSymptDysauto.Enabled = bool
        cmbDocCondPark.Enabled = bool
        cmbEnBlocTurning.Enabled = bool
        cmbParkGait.Enabled = bool
        cmbParkSpeech.Enabled = bool
        cmbDyskinesias.Enabled = bool
        cmbAntiParkMeds.Enabled = bool
        cmbClinEviImp.Enabled = bool
        cmbMedsExtrapyramidal.Enabled = bool
        cmbPDAnteDem.Enabled = bool
        cmbLegPsychoHall.Enabled = bool
        cmbLegCurLastMo.Enabled = bool
        cmbLegPresLastYear.Enabled = bool
        cmbLegLifetime.Enabled = bool
        cmbLegDelusions.Enabled = bool
        cmbDxNoGrpB.Enabled = bool
        cmbDxLevodopa.Enabled = bool
        cmbDxYesOnTremor.Enabled = bool
        cmbDxNoGrpBOrSxGrpA.Enabled = bool
        cmbDxNoAdequateDrugTrial.Enabled = bool
        cmbDxClinLeg.Enabled = bool
        cmbDxPDRelDem.Enabled = bool
        txtPDNotes.makeReadOnly(Not bool)
    End Sub
    Private Sub btnParkinsonismBottom_Click(sender As Object, e As EventArgs) Handles btnParkinsonismTop.Click, btnParkinsonismBottom.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_PMCR_Parkinsonism", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                btnParkinsonismBottom.Text = "Save Changes"
                btnParkinsonismTop.Text = btnParkinsonismBottom.Text
                enableInputFields(True)
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If User.PermissionCheck("WA_PMCR_Parkinsonism", "Modify") Then
                loadBaseForm()
                setDefaultValues()
                lblNoRecord.Visible = False
                btnParkinsonismBottom.Text = "Save Record"
                btnParkinsonismTop.Text = btnParkinsonismBottom.Text
                enableInputFields(True)
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
            End If
        Else 'By default, user is attempting to Insert or Edit a record. Run preSaveValidation.
            If preSaveValidation() Then 'If preSaveValidation returns true, take Insert or Update actions.
                'Same parameters for Insert or Update SP's, so define here
                Dim parameters = " @SubNum = " & WarehouseShell.SubNum &
                        ", @TremorResting = " & cmbTremorResting.getSQLValue() &
                        ", @TremorPostural = " & cmbTremorPostural.getSQLValue() &
                        ", @TremorAction = " & cmbTremorAction.getSQLValue() &
                        ", @Rigidity = " & cmbRigidActivation.getSQLValue() &
                        ", @Cogwheeling = " & cmbRigidCog.getSQLValue() &
                        ", @LimitationROM = " & cmbRigidROM.getSQLValue() &
                        ", @BradyBody = " & cmbBradyBody.getSQLValue() &
                        ", @BradyFace = " & cmbBradyFace.getSQLValue() &
                        ", @AsymetricOnset = " & cmbAsymetricOnset.getSQLValue() &
                        ", @PsychosisHall = " & cmbPsychHall.getSQLValue() &
                        ", @PsychosisHallMonth = " & cmbCurLastMo.getSQLValue() &
                        ", @PsychosisHallYear = " & cmbPresLastYear.getSQLValue() &
                        ", @PsychosisHallLife = " & cmbLifetime.getSQLValue() &
                        ", @PosturalInstab = " & cmbPromPostInstab.getSQLValue() &
                        ", @FreezePhenom = " & cmbFreezePhenom.getSQLValue() &
                        ", @DemPrecMotor = " & cmbDemPreMotorSx.getSQLValue() &
                        ", @GazePalsy = " & cmbSupranuclearGaze.getSQLValue() &
                        ", @Dysautonomia = " & cmbSevSymptDysauto.getSQLValue() &
                        ", @CondProdPark = " & cmbDocCondPark.getSQLValue() &
                        ", @EnBlocTurning = " & cmbEnBlocTurning.getSQLValue() &
                        ", @ParkGait = " & cmbParkGait.getSQLValue() &
                        ", @ParkSpeech = " & cmbParkSpeech.getSQLValue() &
                        ", @Dyskinesias = " & cmbDyskinesias.getSQLValue() &
                        ", @AntiParkMeds = " & cmbAntiParkMeds.getSQLValue() &
                        ", @ClinEvidImprov = " & cmbClinEviImp.getSQLValue() &
                        ", @ExtraPyramidalMeds = " & cmbMedsExtrapyramidal.getSQLValue() &
                        ", @PDAntedateDem = " & cmbPDAnteDem.getSQLValue() &
                        ", @PsychoHall = " & cmbLegPsychoHall.getSQLValue() &
                        ", @PsychoDeluMonth = " & cmbLegCurLastMo.getSQLValue() &
                        ", @PsychoDeluYear = " & cmbLegPresLastYear.getSQLValue() &
                        ", @PsychoDeluLife = " & cmbLegLifetime.getSQLValue() &
                        ", @PsychoDelu = " & cmbLegDelusions.getSQLValue() &
                        ", @ThreeGrpA = " & cmbDx3of4.getSQLValue() &
                        ", @NoneGrpB = " & cmbDxNoGrpB.getSQLValue() &
                        ", @RespoLevodopa = " & cmbDxLevodopa.getSQLValue() &
                        ", @GrpATremorBrady = " & cmbDxYesOnTremor.getSQLValue() &
                        ", @NoGrpBGrpA = " & cmbDxNoGrpBOrSxGrpA.getSQLValue() &
                        ", @RespoLevoOrDrugTrial = " & cmbDxNoAdequateDrugTrial.getSQLValue() &
                        ", @ClinLegDiag = " & cmbDxClinLeg.getSQLValue() &
                        ", @PDRelatedDem = " & cmbDxPDRelDem.getSQLValue() &
                        ", @ParkinsonsDx = " & cmbParkDx.getSQLValue() &
                        ", @Notes = " & txtPDNotes.getSQLValue() &
                        ", @LastModBy = '" & WarehouseShell.userName & "';"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    parameters = "Exec modPMCR_ParkinsonismRecord @Action = 1, " & parameters
                Else 'If this clause is invoked, datamode must be Edit
                    parameters = "Exec modPMCR_ParkinsonismRecord @Action = 2, " & parameters
                End If
                Try
                    Dim cmd As New SqlCommand(parameters, WarehouseShell.conn)
                    cmd.ExecuteNonQuery()
                    enableInputFields(False)
                    btnParkinsonismBottom.Text = "Edit Record"
                    btnParkinsonismTop.Text = btnParkinsonismBottom.Text
                    MsgBox("Record saved.", MsgBoxStyle.OkOnly)
                    WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                Catch ex As SqlException
                    ExceptionHandler.CatchSQLException(ex)
                End Try
            End If
        End If
    End Sub
    Private Function preSaveValidation() As Boolean
        Return True
    End Function

    'Autocalc Park Dx
    Private Sub calcParkDx(sender As Object, e As EventArgs) Handles cmbDx3of4.SelectedValueChanged, cmbDxNoGrpB.SelectedValueChanged, cmbDxLevodopa.SelectedValueChanged, cmbDxYesOnTremor.SelectedValueChanged, cmbDxNoGrpBOrSxGrpA.SelectedValueChanged, cmbDxNoAdequateDrugTrial.SelectedValueChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View And WarehouseShell.DataMode <> WarehouseShell.userDataMode.Undefined Then
            Dim ProbPark As Boolean = False
            Dim PossPark As Boolean = False
            If cmbDx3of4.SelectedValue = 1 And cmbDxNoGrpB.SelectedValue = 1 And cmbDxLevodopa.SelectedValue = 1 Then
                ProbPark = True
            End If
            If cmbDxYesOnTremor.SelectedValue = 1 And cmbDxNoGrpBOrSxGrpA.SelectedValue = 1 And cmbDxNoAdequateDrugTrial.SelectedValue = 1 Then
                PossPark = True
            End If

            If ProbPark Then
                cmbParkDx.SelectedValue = 1
            ElseIf PossPark Then
                cmbParkDx.SelectedValue = 2
            Else
                cmbParkDx.SelectedValue = 3
            End If
        End If
    End Sub

    'Imported IForm Methods
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
    Public Sub Parent1(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        btnParkinsonismBottom.PerformClick()
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