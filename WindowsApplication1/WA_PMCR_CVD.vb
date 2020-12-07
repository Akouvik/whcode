Public Class WA_PMCR_CVD
    Implements IFormMethods
    Private formTables As New DataSet

    Private Sub WA_PMCR_CVD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_PMCR_tabCVD")
        loadBase()
        If Database.ExistingRecordCheck("PMCR_CVD", "SubNum = " & WarehouseShell.SubNum) Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            loadExistingData()
            enableInputFields(False)
            btnCVDBottom.Text = "Edit Record"
            btnCVDTop.Text = btnCVDBottom.Text
            lblNoRecord.Visible = False
        Else 'If it doesn't exist, let user know
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            enableInputFields(False)
            btnCVDBottom.Text = "Add New Record"
            btnCVDTop.Text = btnCVDBottom.Text
            lblNoRecord.Visible = True
            btnCVDTop.Focus()
        End If
    End Sub
    Private Sub loadBase()
        WarehouseShell.highlightSelectedNode("WA_PMCR_tabCVD")
        'Grab any required lookup tables
        formTables.Tables.Add(Database.ReturnTable("lkpYNNAUnk1239", , , "Value asc"))
        formTables.Tables.Add(Database.ReturnTable("lkpPMCR_CAT_MRI"))

        'assign the lookups to their associated combo boxes
        For Each grp As Control In Controls
            If TypeOf grp Is GroupBox Then
                For Each cmb As Control In grp.Controls
                    If TypeOf cmb Is ComboBox_ Then
                        CType(cmb, ComboBox_).assignLookup(formTables, "lkpYNNAUnk1239")
                    End If
                Next
            End If
        Next
        'Overwrite the loop for CAT and MRI (they use a different lookup table)
        comboCatScan.assignLookup(formTables, "lkpPMCR_CAT_MRI")
        comboMriScan.assignLookup(formTables, "lkpPMCR_CAT_MRI")
    End Sub
    Private Sub setDefaultValues()
        'Set default values
        For Each grp As Control In Controls
            If TypeOf grp Is GroupBox Then
                For Each cmb As Control In grp.Controls
                    If TypeOf cmb Is ComboBox_ Then
                        CType(cmb, ComboBox_).SelectedValue = 2
                    End If
                Next
            End If
        Next
        'Overwrite the loop for CAT and MRI (their default is 0, not 2)
        comboCatScan.SelectedValue = 0
        comboMriScan.SelectedValue = 0
    End Sub
    Private Sub loadExistingData()
        'Grab the individual record, based on RecordID, and assign values to their appropriate fields
        formTables.Tables.Add(Database.ReturnTable("PMCR_CVD", , "SubNum = " & WarehouseShell.SubNum))
        comboHypertension.setValue(formTables, "PMCR_CVD", "Hypertension")
        txtHypertensionDate.setValue(formTables, "PMCR_CVD", "HypertensionDate")
        comboMyocardialInfarction.setValue(formTables, "PMCR_CVD", "MyocardInfarct")
        txtMyocardialInfarctionDate.setValue(formTables, "PMCR_CVD", "MyocardInfarctDate")
        comboAtrialFibrilation.setValue(formTables, "PMCR_CVD", "AtrialFibrillation")
        txtAtrialFibrilationDate.setValue(formTables, "PMCR_CVD", "AtrialFibrillationDate")
        comboAngina.setValue(formTables, "PMCR_CVD", "Angina")
        txtAnginaDate.setValue(formTables, "PMCR_CVD", "AnginaDate")
        comboCardiomegaly.setValue(formTables, "PMCR_CVD", "Cardiomegaly")
        txtCardiomegalyDate.setValue(formTables, "PMCR_CVD", "CardiomegalyDate")
        comboCoagulopathy.setValue(formTables, "PMCR_CVD", "Coagulopathy")
        txtCoagulopathyDate.setValue(formTables, "PMCR_CVD", "CoagulopathyDate")
        comboPeriphVascDisease.setValue(formTables, "PMCR_CVD", "PVD")
        txtPeriphVascDiseaseDate.setValue(formTables, "PMCR_CVD", "PVDDate")
        comboASHD.setValue(formTables, "PMCR_CVD", "ASHD")
        txtASHDDate.setValue(formTables, "PMCR_CVD", "ASHDDate")
        comboCongHeartFail.setValue(formTables, "PMCR_CVD", "CongHeartFail")
        txtCongHeartFailDate.setValue(formTables, "PMCR_CVD", "CongHeartFailDate")
        comboOtherArrhythmia.setValue(formTables, "PMCR_CVD", "OtherArrhythmia")
        txtOtherArrhythmiaDate.setValue(formTables, "PMCR_CVD", "OtherArrhythmiaDate")
        comboValvularDisease.setValue(formTables, "PMCR_CVD", "Valvular")
        txtValvularDiseaseDate.setValue(formTables, "PMCR_CVD", "ValvularDate")
        comboDiabetes.setValue(formTables, "PMCR_CVD", "Diabetes")
        txtDiabetesDate.setValue(formTables, "PMCR_CVD", "DiabetesDate")
        comboCOPDAsthma.setValue(formTables, "PMCR_CVD", "COPDAsthma")
        txtCOPDAsthmaDate.setValue(formTables, "PMCR_CVD", "COPDAsthmaDate")
        comboCarotidBruit.setValue(formTables, "PMCR_CVD", "CarotidBruit")
        txtCarotidBruitDate.setValue(formTables, "PMCR_CVD", "CarotidBruitDate")
        comboSyncopalEpisode.setValue(formTables, "PMCR_CVD", "SyncopalEpi")
        txtSyncopalEpisodeDate.setValue(formTables, "PMCR_CVD", "SyncopalEpiDate")
        comboBrainHemorrhage.setValue(formTables, "PMCR_CVD", "BrainHemo")
        txtBrainHemorrhageDate.setValue(formTables, "PMCR_CVD", "BrainHemoDate")
        comboClinCVA.setValue(formTables, "PMCR_CVD", "ClinHxCVA")
        txtClinCVADate.setValue(formTables, "PMCR_CVD", "ClinHxCVADate")
        txtClinCVANote.setValue(formTables, "PMCR_CVD", "ClinHxCVANote")
        comboParalysisOfFace.setValue(formTables, "PMCR_CVD", "ParalysisFace")
        txtParalysisOfFaceDate.setValue(formTables, "PMCR_CVD", "ParalysisFaceDate")
        comboVisualField.setValue(formTables, "PMCR_CVD", "VisFieldDefecit")
        txtVisualFieldDate.setValue(formTables, "PMCR_CVD", "VisFieldDefecitDate")
        comboSensoryDefecits.setValue(formTables, "PMCR_CVD", "ClinEviSensoryDefecit")
        txtSensoryDefecitsDate.setValue(formTables, "PMCR_CVD", "ClinEviSensoryDefecitDate")
        comboReceptiveAphasia.setValue(formTables, "PMCR_CVD", "ReceptiveAphasia")
        txtReceptiveAphasiaDate.setValue(formTables, "PMCR_CVD", "ReceptiveAphasiaDate")
        comboEmotionalLiability.setValue(formTables, "PMCR_CVD", "EmotionalLiability")
        txtEmotionalLiabilityDate.setValue(formTables, "PMCR_CVD", "EmotionalLiabilityDate")
        comboFocalTIA.setValue(formTables, "PMCR_CVD", "FocalTIA")
        txtFocalTIADate.setValue(formTables, "PMCR_CVD", "FocalTIADate")
        comboMajorHypoxicEvent.setValue(formTables, "PMCR_CVD", "MajHypoxicEvent")
        txtMajorHypoxicEventDate.setValue(formTables, "PMCR_CVD", "MajHypoxicEventDate")
        comboParesis.setValue(formTables, "PMCR_CVD", "ParalysisLimbTrunk")
        txtParesisDate.setValue(formTables, "PMCR_CVD", "ParalysisLimbTrunkDate")
        comboExpressiveAphasia.setValue(formTables, "PMCR_CVD", "ExpressiveAphasia")
        txtExpressiveAphasiaDate.setValue(formTables, "PMCR_CVD", "ExpressiveAphasiaDate")
        comboAtaxiaOfLimb.setValue(formTables, "PMCR_CVD", "AtaxiaLimbTrunk")
        txtAtaxiaOfLimbDate.setValue(formTables, "PMCR_CVD", "AtaxiaLimbTrunkDate")
        comboGaitDisorder.setValue(formTables, "PMCR_CVD", "GaitDisorder")
        txtGaitDisorderDate.setValue(formTables, "PMCR_CVD", "GaitDisorderDate")
        txtGaitDisorderNote.setValue(formTables, "PMCR_CVD", "GaitDisorderNote")
        comboDysarthria.setValue(formTables, "PMCR_CVD", "Dysarthia")
        txtDysarthriaDate.setValue(formTables, "PMCR_CVD", "DysarthiaDate")
        comboIschemicRigidity.setValue(formTables, "PMCR_CVD", "IschemicRigidity")
        txtIschemicRigidityDate.setValue(formTables, "PMCR_CVD", "IschemicRigidityDate")
        comboPsychomotor.setValue(formTables, "PMCR_CVD", "PsychoRetard")
        txtPsychomotorDate.setValue(formTables, "PMCR_CVD", "PsychoRetardDate")
        comboDifficultySwallowing.setValue(formTables, "PMCR_CVD", "DiffSwallowing")
        txtDifficultySwallowingDate.setValue(formTables, "PMCR_CVD", "DiffSwallowingDate")
        comboNonFocIschemicOther.setValue(formTables, "PMCR_CVD", "IschemicOther")
        txtNonFocIschemicOtherDate.setValue(formTables, "PMCR_CVD", "IschemicOtherDate")
        txtNonFocIschemicOtherNote.setValue(formTables, "PMCR_CVD", "IschemicOtherNote")
        comboNeuroNormal.setValue(formTables, "PMCR_CVD", "NeuroNormal")
        txtNeuroNormalDate.setValue(formTables, "PMCR_CVD", "NeuroNormalDate")
        comboIncreasedTone.setValue(formTables, "PMCR_CVD", "IncTone")
        txtIncreasedToneDate.setValue(formTables, "PMCR_CVD", "IncToneDate")
        comboNasolabial.setValue(formTables, "PMCR_CVD", "Nasolabial")
        txtNasolabialDate.setValue(formTables, "PMCR_CVD", "NasolabialDate")
        cmbParaCentral.setValue(formTables, "PMCR_CVD", "ParaCentral")
        dtParaCentral.setValue(formTables, "PMCR_CVD", "ParaCentralDate")
        cmbBabinski.setValue(formTables, "PMCR_CVD", "Babinski")
        dtBabinski.setValue(formTables, "PMCR_CVD", "BabinskiDate")
        comboExtrapyramidal.setValue(formTables, "PMCR_CVD", "Extrapyramidal")
        txtExtrapyramidalDate.setValue(formTables, "PMCR_CVD", "ExtrapyramidalDate")
        comboTremor.setValue(formTables, "PMCR_CVD", "Tremor")
        txtTremorDate.setValue(formTables, "PMCR_CVD", "TremorDate")
        comboMotorSpeechImpairment.setValue(formTables, "PMCR_CVD", "MotorSpeechImp")
        txtMotorSpeechImpairment.setValue(formTables, "PMCR_CVD", "MotorSpeechImpDate")
        comboSensoryDefecit.setValue(formTables, "PMCR_CVD", "NeuroSensoryDefecit")
        txtSensoryDefecitDate.setValue(formTables, "PMCR_CVD", "NeuroSensoryDefecitDate")
        comboFrontalReleaseReflex.setValue(formTables, "PMCR_CVD", "FrontReleaseRefl")
        txtFrontalReleaseReflexDate.setValue(formTables, "PMCR_CVD", "FrontReleaseReflDate")
        comboSomaticComplaints.setValue(formTables, "PMCR_CVD", "SomaticComplaints")
        txtSomaticComplaintsDate.setValue(formTables, "PMCR_CVD", "SomaticComplaintsDate")
        txtSomaticComplaintsNote.setValue(formTables, "PMCR_CVD", "SomaticComplaintsNote")
        comboNeuroOther.setValue(formTables, "PMCR_CVD", "NeuroOther")
        txtNeuroOtherDate.setValue(formTables, "PMCR_CVD", "NeuroOtherDate")
        txtNeuroOtherNote.setValue(formTables, "PMCR_CVD", "NeuroOtherNote")
        comboInfarct.setValue(formTables, "PMCR_CVD", "Infarct")
        txtInfarctDate.setValue(formTables, "PMCR_CVD", "InfarctDate")
        comboParkinsonsDisease.setValue(formTables, "PMCR_CVD", "Parkinsons")
        txtParkinsonsDiseaseDate.setValue(formTables, "PMCR_CVD", "ParkinsonsDate")
        comboAlcoholism.setValue(formTables, "PMCR_CVD", "Alcoholism")
        txtAlcoholismDate.setValue(formTables, "PMCR_CVD", "AlcoholismDate")
        comboCJD.setValue(formTables, "PMCR_CVD", "CJD")
        txtCJDDate.setValue(formTables, "PMCR_CVD", "CJDDate")
        comboHypoxicEpisode.setValue(formTables, "PMCR_CVD", "HypoxicEpisode")
        txtHypoxicEpisodeDate.setValue(formTables, "PMCR_CVD", "HypoxicEpisodeDate")
        comboNPH.setValue(formTables, "PMCR_CVD", "NPH")
        txtNPHDate.setValue(formTables, "PMCR_CVD", "NPHDate")
        comboPicks.setValue(formTables, "PMCR_CVD", "Picks")
        txtPicksDate.setValue(formTables, "PMCR_CVD", "PicksDate")
        comboHuntingtons.setValue(formTables, "PMCR_CVD", "Huntingtons")
        txtHuntingtonsDate.setValue(formTables, "PMCR_CVD", "HuntingtonsDate")
        comboMajorAffective.setValue(formTables, "PMCR_CVD", "MajAffDisorder")
        txtMajorAffectiveDate.setValue(formTables, "PMCR_CVD", "MajAffDisorderDate")
        comboHeadTrauma.setValue(formTables, "PMCR_CVD", "HeadTrauma")
        txtHeadTraumaDate.setValue(formTables, "PMCR_CVD", "HeadTraumaDate")
        comboSeizures.setValue(formTables, "PMCR_CVD", "Seizures")
        txtSeizuresDate.setValue(formTables, "PMCR_CVD", "SeizuresDate")
        comboBrainTumor.setValue(formTables, "PMCR_CVD", "BrainTumor")
        txtBrainTumorDate.setValue(formTables, "PMCR_CVD", "BrainTumorDate")
        comboSchizo.setValue(formTables, "PMCR_CVD", "Schizo")
        txtSchizoDate.setValue(formTables, "PMCR_CVD", "SchizoDate")
        comboThyroidDisorder.setValue(formTables, "PMCR_CVD", "ThyroidDisorder")
        txtThyroidDisorderDate.setValue(formTables, "PMCR_CVD", "ThyroidDisorderDate")
        txtThyroidDisorderNote.setValue(formTables, "PMCR_CVD", "ThyroidDisorderNote")
        comboCancer.setValue(formTables, "PMCR_CVD", "Cancer")
        txtCancerDate.setValue(formTables, "PMCR_CVD", "CancerDate")
        txtCancerNote.setValue(formTables, "PMCR_CVD", "CancerNote")
        comboB12.setValue(formTables, "PMCR_CVD", "B12")
        txtB12Date.setValue(formTables, "PMCR_CVD", "B12Date")
        txtB12Note.setValue(formTables, "PMCR_CVD", "B12Note")
        comboOtherCondOther.setValue(formTables, "PMCR_CVD", "OtherOther")
        txtOtherCondOtherDate.setValue(formTables, "PMCR_CVD", "OtherOtherDate")
        txtOtherCondOtherNote.setValue(formTables, "PMCR_CVD", "OtherOtherNote")
        comboCatScan.setValue(formTables, "PMCR_CVD", "CAT")
        txtCatScanDate.setValue(formTables, "PMCR_CVD", "CatDate")
        txtCatScanNote.setValue(formTables, "PMCR_CVD", "CatNote")
        comboMriScan.setValue(formTables, "PMCR_CVD", "MRI")
        txtMriScanDate.setValue(formTables, "PMCR_CVD", "MRIDate")
        txtMriScanNote.setValue(formTables, "PMCR_CVD", "MRINote")
    End Sub
    Private Sub enableInputFields(ByVal bool As Boolean)
        'Enable/disable all of the input fields
        For Each grp As Control In Controls
            If TypeOf grp Is GroupBox Then
                For Each cmb As Control In grp.Controls
                    If TypeOf cmb Is ComboBox_ Then
                        cmb.Enabled = bool
                    End If
                Next
                For Each dt As Control In grp.Controls
                    If TypeOf dt Is TextBoxDatePast Then
                        dt.Enabled = bool
                    End If
                Next
                For Each txt As Control In grp.Controls
                    If TypeOf txt Is TextBox_ Then
                        CType(txt, TextBox_).makeReadOnly(Not bool)
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub btnCVD_Click(sender As Object, e As EventArgs) Handles btnCVDBottom.Click, btnCVDTop.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If User.PermissionCheck("WA_PMCR_CVD", "Modify") Then
                lblNoRecord.Visible = False
                btnCVDBottom.Text = "Save Record"
                btnCVDTop.Text = "Save Record"
                enableInputFields(True)
                setDefaultValues()
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_PMCR_CVD", "Modify") Then
                btnCVDBottom.Text = "Save Changes"
                btnCVDTop.Text = "Save Changes"
                enableInputFields(True)
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
            End If
        Else 'By default, user is attempting to Insert or Edit a record. Run preSaveValidation.
            If preSaveValidation() Then 'If preSaveValidation returns true, take Insert or Update actions.
                'Same parameters for Insert or Update SP's, so define here
                Dim parameters = " @SubNum = " & WarehouseShell.SubNum &
                        ", @Hypertension = " & comboHypertension.getSQLValue() &
                        ", @HypertensionDate = " & txtHypertensionDate.getSQLValue() &
                        ", @MyocardInfarct = " & comboMyocardialInfarction.getSQLValue() &
                        ", @MyocardInfarctDate = " & txtMyocardialInfarctionDate.getSQLValue() &
                        ", @AtrialFibrillation = " & comboAtrialFibrilation.getSQLValue() &
                        ", @AtrialFibrillationDate = " & txtAtrialFibrilationDate.getSQLValue() &
                        ", @Angina = " & comboAngina.getSQLValue() &
                        ", @AnginaDate = " & txtAnginaDate.getSQLValue() &
                        ", @Cardiomegaly = " & comboCardiomegaly.getSQLValue() &
                        ", @CardiomegalyDate = " & txtCardiomegalyDate.getSQLValue() &
                        ", @Coagulopathy = " & comboCoagulopathy.getSQLValue() &
                        ", @CoagulopathyDate = " & txtCoagulopathyDate.getSQLValue() &
                        ", @PVD = " & comboPeriphVascDisease.getSQLValue() &
                        ", @PVDDate = " & txtPeriphVascDiseaseDate.getSQLValue() &
                        ", @ASHD = " & comboASHD.getSQLValue() &
                        ", @ASHDDate = " & txtASHDDate.getSQLValue() &
                        ", @CongHeartFail = " & comboCongHeartFail.getSQLValue() &
                        ", @CongHeartFailDate = " & txtCongHeartFailDate.getSQLValue() &
                        ", @OtherArrhythmia = " & comboOtherArrhythmia.getSQLValue() &
                        ", @OtherArrhythmiaDate = " & txtOtherArrhythmiaDate.getSQLValue() &
                        ", @Valvular = " & comboValvularDisease.getSQLValue() &
                        ", @ValvularDate = " & txtValvularDiseaseDate.getSQLValue() &
                        ", @Diabetes = " & comboDiabetes.getSQLValue() &
                        ", @DiabetesDate = " & txtDiabetesDate.getSQLValue() &
                        ", @COPDAsthma = " & comboCOPDAsthma.getSQLValue() &
                        ", @COPDAsthmaDate = " & txtCOPDAsthmaDate.getSQLValue() &
                        ", @CarotidBruit = " & comboCarotidBruit.getSQLValue() &
                        ", @CarotidBruitDate = " & txtCarotidBruitDate.getSQLValue() &
                        ", @SyncopalEpi = " & comboSyncopalEpisode.getSQLValue() &
                        ", @SyncopalEpiDate = " & txtSyncopalEpisodeDate.getSQLValue() &
                        ", @BrainHemo = " & comboBrainHemorrhage.getSQLValue() &
                        ", @BrainHemoDate = " & txtBrainHemorrhageDate.getSQLValue() &
                        ", @ClinHxCVA = " & comboClinCVA.getSQLValue() &
                        ", @ClinHxCVADate = " & txtClinCVADate.getSQLValue() &
                        ", @ClinHxCVANote = " & txtClinCVANote.getSQLValue() &
                        ", @ParalysisFace = " & comboParalysisOfFace.getSQLValue() &
                        ", @ParalysisFaceDate = " & txtParalysisOfFaceDate.getSQLValue() &
                        ", @VisFieldDefecit = " & comboVisualField.getSQLValue() &
                        ", @VisFieldDefecitDate = " & txtVisualFieldDate.getSQLValue() &
                        ", @ClinEviSensoryDefecit = " & comboSensoryDefecits.getSQLValue() &
                        ", @ClinEviSensoryDefecitDate = " & txtSensoryDefecitsDate.getSQLValue() &
                        ", @ReceptiveAphasia = " & comboReceptiveAphasia.getSQLValue() &
                        ", @ReceptiveAphasiaDate = " & txtReceptiveAphasiaDate.getSQLValue() &
                        ", @EmotionalLiability = " & comboEmotionalLiability.getSQLValue() &
                        ", @EmotionalLiabilityDate = " & txtEmotionalLiabilityDate.getSQLValue() &
                        ", @FocalTIA = " & comboFocalTIA.getSQLValue() &
                        ", @FocalTIADate = " & txtFocalTIADate.getSQLValue() &
                        ", @MajHypoxicEvent = " & comboMajorHypoxicEvent.getSQLValue() &
                        ", @MajHypoxicEventDate = " & txtMajorHypoxicEventDate.getSQLValue() &
                        ", @ParalysisLimbTrunk = " & comboParesis.getSQLValue() &
                        ", @ParalysisLimbTrunkDate = " & txtParesisDate.getSQLValue() &
                        ", @ExpressiveAphasia = " & comboExpressiveAphasia.getSQLValue() &
                        ", @ExpressiveAphasiaDate = " & txtExpressiveAphasiaDate.getSQLValue() &
                        ", @AtaxiaLimbTrunk = " & comboAtaxiaOfLimb.getSQLValue() &
                        ", @AtaxiaLimbTrunkDate = " & txtAtaxiaOfLimbDate.getSQLValue() &
                        ", @GaitDisorder = " & comboGaitDisorder.getSQLValue() &
                        ", @GaitDisorderDate = " & txtGaitDisorderDate.getSQLValue() &
                        ", @GaitDisorderNote = " & txtGaitDisorderNote.getSQLValue() &
                        ", @Dysarthia = " & comboDysarthria.getSQLValue() &
                        ", @DysarthiaDate = " & txtDysarthriaDate.getSQLValue() &
                        ", @IschemicRigidity = " & comboIschemicRigidity.getSQLValue() &
                        ", @IschemicRigidityDate = " & txtIschemicRigidityDate.getSQLValue() &
                        ", @PsychoRetard = " & comboPsychomotor.getSQLValue() &
                        ", @PsychoRetardDate = " & txtPsychomotorDate.getSQLValue() &
                        ", @DiffSwallowing = " & comboDifficultySwallowing.getSQLValue() &
                        ", @DiffSwallowingDate = " & txtDifficultySwallowingDate.getSQLValue() &
                        ", @IschemicOther = " & comboNonFocIschemicOther.getSQLValue() &
                        ", @IschemicOtherDate = " & txtNonFocIschemicOtherDate.getSQLValue() &
                        ", @IschemicOtherNote = " & txtNonFocIschemicOtherNote.getSQLValue() &
                        ", @NeuroNormal = " & comboNeuroNormal.getSQLValue() &
                        ", @NeuroNormalDate = " & txtNeuroNormalDate.getSQLValue() &
                        ", @IncTone = " & comboIncreasedTone.getSQLValue() &
                        ", @IncToneDate = " & txtIncreasedToneDate.getSQLValue() &
                        ", @Nasolabial = " & comboNasolabial.getSQLValue() &
                        ", @NasolabialDate = " & txtNasolabialDate.getSQLValue() &
                        ", @ParaCentral = " & cmbParaCentral.getSQLValue() &
                        ", @ParaCentralDate = " & dtParaCentral.getSQLValue() &
                        ", @Babinski = " & cmbBabinski.getSQLValue() &
                        ", @BabinskiDate = " & dtBabinski.getSQLValue() &
                        ", @Extrapyramidal = " & comboExtrapyramidal.getSQLValue() &
                        ", @ExtrapyramidalDate = " & txtExtrapyramidalDate.getSQLValue() &
                        ", @Tremor = " & comboTremor.getSQLValue() &
                        ", @TremorDate = " & txtTremorDate.getSQLValue() &
                        ", @MotorSpeechImp = " & comboMotorSpeechImpairment.getSQLValue() &
                        ", @MotorSpeechImpDate = " & txtMotorSpeechImpairment.getSQLValue() &
                        ", @NeuroSensoryDefecit = " & comboSensoryDefecit.getSQLValue() &
                        ", @NeuroSensoryDefecitDate = " & txtSensoryDefecitDate.getSQLValue() &
                        ", @FrontReleaseRefl = " & comboFrontalReleaseReflex.getSQLValue() &
                        ", @FrontReleaseReflDate = " & txtFrontalReleaseReflexDate.getSQLValue() &
                        ", @SomaticComplaints = " & comboSomaticComplaints.getSQLValue() &
                        ", @SomaticComplaintsDate = " & txtSomaticComplaintsDate.getSQLValue() &
                        ", @SomaticComplaintsNote = " & txtSomaticComplaintsNote.getSQLValue() &
                        ", @NeuroOther = " & comboNeuroOther.getSQLValue() &
                        ", @NeuroOtherDate = " & txtNeuroOtherDate.getSQLValue() &
                        ", @NeuroOtherNote = " & txtNeuroOtherNote.getSQLValue() &
                        ", @Infarct = " & comboInfarct.getSQLValue() &
                        ", @InfarctDate = " & txtInfarctDate.getSQLValue() &
                        ", @Parkinsons = " & comboParkinsonsDisease.getSQLValue() &
                        ", @ParkinsonsDate = " & txtParkinsonsDiseaseDate.getSQLValue() &
                        ", @Alcoholism = " & comboAlcoholism.getSQLValue() &
                        ", @AlcoholismDate = " & txtAlcoholismDate.getSQLValue() &
                        ", @CJD = " & comboCJD.getSQLValue() &
                        ", @CJDDate = " & txtCJDDate.getSQLValue() &
                        ", @HypoxicEpisode = " & comboHypoxicEpisode.getSQLValue() &
                        ", @HypoxicEpisodeDate = " & txtHypoxicEpisodeDate.getSQLValue() &
                        ", @NPH = " & comboNPH.getSQLValue() &
                        ", @NPHDate = " & txtNPHDate.getSQLValue() &
                        ", @Picks = " & comboPicks.getSQLValue() &
                        ", @PicksDate = " & txtPicksDate.getSQLValue() &
                        ", @Huntingtons = " & comboHuntingtons.getSQLValue() &
                        ", @HuntingtonsDate = " & txtHuntingtonsDate.getSQLValue() &
                        ", @MajAffDisorder = " & comboMajorAffective.getSQLValue() &
                        ", @MajAffDisorderDate = " & txtMajorAffectiveDate.getSQLValue() &
                        ", @HeadTrauma = " & comboHeadTrauma.getSQLValue() &
                        ", @HeadTraumaDate = " & txtHeadTraumaDate.getSQLValue() &
                        ", @Seizures = " & comboSeizures.getSQLValue() &
                        ", @SeizuresDate = " & txtSeizuresDate.getSQLValue() &
                        ", @BrainTumor = " & comboBrainTumor.getSQLValue() &
                        ", @BrainTumorDate = " & txtBrainTumorDate.getSQLValue() &
                        ", @Schizo = " & comboSchizo.getSQLValue() &
                        ", @SchizoDate = " & txtSchizoDate.getSQLValue() &
                        ", @ThyroidDisorder = " & comboThyroidDisorder.getSQLValue() &
                        ", @ThyroidDisorderDate = " & txtThyroidDisorderDate.getSQLValue() &
                        ", @ThyroidDisorderNote = " & txtThyroidDisorderNote.getSQLValue() &
                        ", @Cancer = " & comboCancer.getSQLValue() &
                        ", @CancerDate = " & txtCancerDate.getSQLValue() &
                        ", @CancerNote = " & txtCancerNote.getSQLValue() &
                        ", @B12 = " & comboB12.getSQLValue() &
                        ", @B12Date = " & txtB12Date.getSQLValue() &
                        ", @B12Note = " & txtB12Note.getSQLValue() &
                        ", @OtherOther = " & comboOtherCondOther.getSQLValue() &
                        ", @OtherOtherDate = " & txtOtherCondOtherDate.getSQLValue() &
                        ", @OtherOtherNote = " & txtOtherCondOtherNote.getSQLValue() &
                        ", @CAT = " & comboCatScan.getSQLValue() &
                        ", @CATDate = " & txtCatScanDate.getSQLValue() &
                        ", @CATNote = " & txtCatScanNote.getSQLValue() &
                        ", @MRI = " & comboMriScan.getSQLValue() &
                        ", @MRIDate = " & txtMriScanDate.getSQLValue() &
                        ", @MRINote = " & txtMriScanNote.getSQLValue() &
                        ", @LastModBy = '" & WarehouseShell.userName & "';"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    Dim cmd As New SqlCommand("", WarehouseShell.conn)
                    Dim cmdString = "Exec modPMCR_CVDRecord @Action = 1, " & parameters
                    cmd.CommandText = cmdString
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Record successfully added", MsgBoxStyle.OkOnly, "Success")
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        btnCVDBottom.Text = "Edit Record"
                        btnCVDTop.Text = "Edit Record"
                        enableInputFields(False)
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else 'If this clause is invoked, datamode must be Edit
                    Dim cmd As New SqlCommand("", WarehouseShell.conn)
                    Dim cmdString = "Exec modPMCR_CVDRecord @Action = 2, " & parameters
                    cmd.CommandText = cmdString
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Record successfully updated", MsgBoxStyle.OkOnly, "Success")
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        btnCVDBottom.Text = "Edit Record"
                        btnCVDTop.Text = "Edit Record"
                        enableInputFields(False)
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
        btnCVDBottom.PerformClick()
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