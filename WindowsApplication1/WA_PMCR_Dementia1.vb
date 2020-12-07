Public Class WA_PMCR_Dementia1
    Implements IFormMethods
    Private formTables As New DataSet

    'Load routines
    Private Sub WA_PMCR_Dementia1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Database.ExistingRecordCheck("PMCR_Dementia1", "SubNum = " & WarehouseShell.SubNum) Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            loadBaseForm()
            loadExistingData()
            btnDementia1Bottom.Text = "Edit Record"
            btnDementia1Top.Text = btnDementia1Bottom.Text
        Else 'If it doesn't exist, change mode to Undefined and show user banner
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            lblNoRecord.Visible = True
            btnDementia1Bottom.Text = "Add New Record"
            btnDementia1Top.Text = btnDementia1Bottom.Text
        End If
        enableInputFields(False)
    End Sub
    Private Sub loadBaseForm()
        WarehouseShell.highlightSelectedNode("WA_PMCR_tabDementia1")
        'Grab any required comboLookUp tables and assign them to their appropriate boxes
        formTables.Tables.Add(Database.ReturnTable("lkpYNUnk129NoBlank"))
        formTables.Tables.Add(Database.ReturnTable("lkpPMCR_DementiaOverall"))
        formTables.Tables.Add(Database.ReturnTable("lkpPMCR_DementiaNINCDSVasc"))
        formTables.Tables.Add(Database.ReturnTable("lkpPMCR_DementiaNINCDSAD"))
        comboVascDementia.assignLookup(formTables, "lkpYNUnk129NoBlank")
        comboEvi2MoreIschStrokes.assignLookup(formTables, "lkpYNUnk129NoBlank")
        comboEvi1Infarct.assignLookup(formTables, "lkpYNUnk129NoBlank")
        comboEviMultInf.assignLookup(formTables, "lkpYNUnk129NoBlank")
        comboHxMultTIA.assignLookup(formTables, "lkpYNUnk129NoBlank")
        comboHxVascRisk.assignLookup(formTables, "lkpYNUnk129NoBlank")
        comboElevHach.assignLookup(formTables, "lkpYNUnk129NoBlank")
        comboHxEviSglStroke.assignLookup(formTables, "lkpYNUnk129NoBlank")
        comboBinswangers.assignLookup(formTables, "lkpYNUnk129NoBlank")
        comboPresOthBrainDis.assignLookup(formTables, "lkpYNUnk129NoBlank")
        comboRelBetFocSign.assignLookup(formTables, "lkpYNUnk129NoBlank")
        comboVascDemOverall.assignLookup(formTables, "lkpPMCR_DementiaOverall")
        comboVascDemNINCDS.assignLookup(formTables, "lkpPMCR_DementiaNINCDSVasc")
        comboDemPark.assignLookup(formTables, "lkpYNUnk129NoBlank")
        comboDemAlc.assignLookup(formTables, "lkpYNUnk129NoBlank")
        comboClinDementia.assignLookup(formTables, "lkpYNUnk129NoBlank")
        comboOrgMentSynd.assignLookup(formTables, "lkpYNUnk129NoBlank")
        comboAlzheimers.assignLookup(formTables, "lkpYNUnk129NoBlank")
        comboEnceph.assignLookup(formTables, "lkpYNUnk129NoBlank")
        comboAbruptOnset.assignLookup(formTables, "lkpYNUnk129NoBlank")
        comboLewy.assignLookup(formTables, "lkpYNUnk129NoBlank")
        comboConfused.assignLookup(formTables, "lkpYNUnk129NoBlank")
        comboNoctConf.assignLookup(formTables, "lkpYNUnk129NoBlank")
        comboClinDemOth.assignLookup(formTables, "lkpYNUnk129NoBlank")
        comboImpShortMem.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbImpLongMemPers.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbImpLongMemComm.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbImpAbs.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbImpJudge.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbDistHighCortFunct.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbDSMIIIAphasia.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbDSMIIIApraxia.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbDSMIIIAgnosia.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbPersChg.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbImpMem.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbDSMIVAphasia.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbDSMIVApraxia.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbDSMIVAgnosia.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbDistExecFunct.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbMeetsDSMCrit.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbBlessed.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmb2Deficits.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbProgDetMemCog.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbOnset4090.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbNoOthEtiology.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbPres2ndBrainDis.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbPresSingProg.assignLookup(formTables, "lkpYNUnk129NoBlank")
        cmbMeetsNINCDS.assignLookup(formTables, "lkpPMCR_DementiaNINCDSAD")
    End Sub
    Private Sub setDefaultValues()
        comboVascDementia.SelectedValue = 2
        comboEvi2MoreIschStrokes.SelectedValue = 2
        comboEvi1Infarct.SelectedValue = 2
        comboEviMultInf.SelectedValue = 2
        comboHxMultTIA.SelectedValue = 2
        comboHxVascRisk.SelectedValue = 2
        comboElevHach.SelectedValue = 2
        comboHxEviSglStroke.SelectedValue = 2
        comboBinswangers.SelectedValue = 2
        comboPresOthBrainDis.SelectedValue = 2
        comboRelBetFocSign.SelectedValue = 2
        comboVascDemOverall.SelectedValue = 1
        comboVascDemNINCDS.SelectedValue = 1
        chkFocalSigns.Checked = False
        chkAbsentImageStudy.Checked = False
        comboDemPark.SelectedValue = 2
        comboDemAlc.SelectedValue = 2
        comboClinDementia.SelectedValue = 2
        comboOrgMentSynd.SelectedValue = 2
        comboAlzheimers.SelectedValue = 2
        comboEnceph.SelectedValue = 2
        comboAbruptOnset.SelectedValue = 2
        comboLewy.SelectedValue = 2
        comboConfused.SelectedValue = 2
        comboNoctConf.SelectedValue = 2
        comboClinDemOth.SelectedValue = 2
        comboImpShortMem.SelectedValue = 2
        cmbImpLongMemPers.SelectedValue = 2
        cmbImpLongMemComm.SelectedValue = 2
        cmbImpAbs.SelectedValue = 2
        cmbImpJudge.SelectedValue = 2
        cmbDistHighCortFunct.SelectedValue = 2
        cmbDSMIIIAphasia.SelectedValue = 2
        cmbDSMIIIApraxia.SelectedValue = 2
        cmbDSMIIIAgnosia.SelectedValue = 2
        cmbPersChg.SelectedValue = 2
        cmbImpMem.SelectedValue = 2
        cmbDSMIVAphasia.SelectedValue = 2
        cmbDSMIVApraxia.SelectedValue = 2
        cmbDSMIVAgnosia.SelectedValue = 2
        cmbDistExecFunct.SelectedValue = 2
        cmbMeetsDSMCrit.SelectedValue = 2
        cmbBlessed.SelectedValue = 2
        cmb2Deficits.SelectedValue = 2
        cmbProgDetMemCog.SelectedValue = 2
        cmbOnset4090.SelectedValue = 2
        cmbNoOthEtiology.SelectedValue = 2
        cmbPres2ndBrainDis.SelectedValue = 2
        cmbPresSingProg.SelectedValue = 2
        cmbMeetsNINCDS.SelectedValue = 4
    End Sub
    Private Sub loadExistingData()
        'see addiotnal load at the bottom of this sub!!!
        'Grab the individual record, based on RecordID, and assign values to their appropriate fields
        If formTables.Tables.Contains("viewPMCR_Dementia1") Then
            formTables.Tables.Remove("viewPMCR_Dementia1")
        End If
        formTables.Tables.Add(Database.ReturnTable("viewPMCR_Dementia1", , "SubNum = " & WarehouseShell.SubNum))
        comboVascDementia.setValue(formTables, "viewPMCR_Dementia1", "VascDementiaValue")
        txtVascDementia.setValue(formTables, "viewPMCR_Dementia1", "VascDementiaDate")
        comboEvi2MoreIschStrokes.setValue(formTables, "viewPMCR_Dementia1", "IschemicStrokesValue")
        txtEvi2MoreIschStrokes.setValue(formTables, "viewPMCR_Dementia1", "IschemicStrokesDate")
        comboEvi1Infarct.setValue(formTables, "viewPMCR_Dementia1", "OneInfarctValue")
        txtEvi1Infarct.setValue(formTables, "viewPMCR_Dementia1", "OneInfarctDate")
        comboEviMultInf.setValue(formTables, "viewPMCR_Dementia1", "MultInfarctsValue")
        txtEviMultInf.setValue(formTables, "viewPMCR_Dementia1", "MultInfarctsDate")
        comboHxMultTIA.setValue(formTables, "viewPMCR_Dementia1", "HxTIAsValue")
        txtHxMultTIA.setValue(formTables, "viewPMCR_Dementia1", "HxTIAsDate")
        comboHxVascRisk.setValue(formTables, "viewPMCR_Dementia1", "HxVascRiskValue")
        txtHxVascRisk.setValue(formTables, "viewPMCR_Dementia1", "HxVascRiskDate")
        comboElevHach.setValue(formTables, "viewPMCR_Dementia1", "ElevHachinskiValue")
        txtElevHach.setValue(formTables, "viewPMCR_Dementia1", "ElevHachinskiDate")
        comboHxEviSglStroke.setValue(formTables, "viewPMCR_Dementia1", "HxSingleStrokeValue")
        txtHxEviSglStroke.setValue(formTables, "viewPMCR_Dementia1", "HxSingleStrokeDate")
        comboBinswangers.setValue(formTables, "viewPMCR_Dementia1", "BinswangersValue")
        txtBinswangers.setValue(formTables, "viewPMCR_Dementia1", "BinswangersDate")
        comboPresOthBrainDis.setValue(formTables, "viewPMCR_Dementia1", "DisorderRelDementiaValue")
        txtPresOthBrainDis.setValue(formTables, "viewPMCR_Dementia1", "DisorderRelDementiaDate")
        comboRelBetFocSign.setValue(formTables, "viewPMCR_Dementia1", "RelFocalSignsValue")
        txtRelBetFocSign.setValue(formTables, "viewPMCR_Dementia1", "RelFocalSignsDate")
        txtVascDemNotes.setValue(formTables, "viewPMCR_Dementia1", "VascNotes")
        comboVascDemOverall.setValue(formTables, "viewPMCR_Dementia1", "OverallScoreValue")
        txtVascDemOverall.setValue(formTables, "viewPMCR_Dementia1", "OverallScoreDate")
        comboVascDemNINCDS.setValue(formTables, "viewPMCR_Dementia1", "NINCDSValue")
        txtVascDemNINCDS.setValue(formTables, "viewPMCR_Dementia1", "NINCDSDate")
        chkFocalSigns.setValue(formTables, "viewPMCR_Dementia1", "FocalSigns")
        chkAbsentImageStudy.setValue(formTables, "viewPMCR_Dementia1", "AbsentImageStudy")
        comboDemPark.setValue(formTables, "viewPMCR_Dementia1", "DemParkValue")
        txtDemPark.setValue(formTables, "viewPMCR_Dementia1", "DemParkDate")
        comboDemAlc.setValue(formTables, "viewPMCR_Dementia1", "DemAlcoholValue")
        txtDemAlc.setValue(formTables, "viewPMCR_Dementia1", "DemAlcoholDate")
        comboClinDementia.setValue(formTables, "viewPMCR_Dementia1", "ClinDementiaValue")
        txtClinDementia.setValue(formTables, "viewPMCR_Dementia1", "ClinDementiaDate")
        comboOrgMentSynd.setValue(formTables, "viewPMCR_Dementia1", "OrgMentalSyndValue")
        txtOrgMentSynd.setValue(formTables, "viewPMCR_Dementia1", "OrgMentalSyndDate")
        comboAlzheimers.setValue(formTables, "viewPMCR_Dementia1", "AlzheimersValue")
        txtAlzheimers.setValue(formTables, "viewPMCR_Dementia1", "AlzheimersDate")
        comboEnceph.setValue(formTables, "viewPMCR_Dementia1", "EncephValue")
        txtEnceph.setValue(formTables, "viewPMCR_Dementia1", "EncephDate")
        comboAbruptOnset.setValue(formTables, "viewPMCR_Dementia1", "AbruptOnsetValue")
        txtAbruptOnset.setValue(formTables, "viewPMCR_Dementia1", "AbruptOnsetDate")
        comboLewy.setValue(formTables, "viewPMCR_Dementia1", "LewyValue")
        txtLewy.setValue(formTables, "viewPMCR_Dementia1", "LewyDate")
        comboConfused.setValue(formTables, "viewPMCR_Dementia1", "ConfusedValue")
        txtConfused.setValue(formTables, "viewPMCR_Dementia1", "ConfusedDate")
        comboNoctConf.setValue(formTables, "viewPMCR_Dementia1", "NocturnalValue")
        txtNoctConf.setValue(formTables, "viewPMCR_Dementia1", "NocturnalDate")
        comboClinDemOth.setValue(formTables, "viewPMCR_Dementia1", "ClinOtherValue")
        txtClinDemOth.setValue(formTables, "viewPMCR_Dementia1", "ClinOtherDate")
        txtClinDemOthNote.setValue(formTables, "viewPMCR_Dementia1", "ClinOtherNote")
        txtClinDemFirstEntry.setValue(formTables, "viewPMCR_Dementia1", "DateFirstEntry")
        comboImpShortMem.setValue(formTables, "viewPMCR_Dementia1", "ShortTermMemValue")
        dtImpShortMem.setValue(formTables, "viewPMCR_Dementia1", "ShortTermMemDate")
        cmbImpLongMemPers.setValue(formTables, "viewPMCR_Dementia1", "LongTermPersValue")
        dtImpLongMemPers.setValue(formTables, "viewPMCR_Dementia1", "LongTermPersDate")
        cmbImpLongMemComm.setValue(formTables, "viewPMCR_Dementia1", "LongTermComKnowValue")
        dtImpLongMemComm.setValue(formTables, "viewPMCR_Dementia1", "LongTermComKnowDate")
        cmbImpAbs.setValue(formTables, "viewPMCR_Dementia1", "AbstractThinkingValue")
        dtImpAbs.setValue(formTables, "viewPMCR_Dementia1", "AbstractThinkingDate")
        cmbImpJudge.setValue(formTables, "viewPMCR_Dementia1", "JudgementValue")
        dtImpJudge.setValue(formTables, "viewPMCR_Dementia1", "JudgementDate")
        cmbDistHighCortFunct.setValue(formTables, "viewPMCR_Dementia1", "DistHighCortFunctValue")
        dtDistHighCortFunct.setValue(formTables, "viewPMCR_Dementia1", "DistHighCortFunctDate")
        cmbDSMIIIAphasia.setValue(formTables, "viewPMCR_Dementia1", "DSMIIIAphasiaValue")
        dtDSMIIIAphasia.setValue(formTables, "viewPMCR_Dementia1", "DSMIIIAphasiaDate")
        cmbDSMIIIApraxia.setValue(formTables, "viewPMCR_Dementia1", "DSMIIIApraxiaValue")
        dtDSMIIIApraxia.setValue(formTables, "viewPMCR_Dementia1", "DSMIIIApraxiaDate")
        cmbDSMIIIAgnosia.setValue(formTables, "viewPMCR_Dementia1", "DSMIIIAgnosiaValue")
        dtDSMIIIAgnosia.setValue(formTables, "viewPMCR_Dementia1", "DSMIIIAgnosiaDate")
        cmbPersChg.setValue(formTables, "viewPMCR_Dementia1", "PersonalityChgValue")
        dtPersChg.setValue(formTables, "viewPMCR_Dementia1", "PersonalityChgDate")
        cmbImpMem.setValue(formTables, "viewPMCR_Dementia1", "MemoryValue")
        dtImpMem.setValue(formTables, "viewPMCR_Dementia1", "MemoryDate")
        cmbDSMIVAphasia.setValue(formTables, "viewPMCR_Dementia1", "DSMIVAphasiaValue")
        dtDSMIVAphasia.setValue(formTables, "viewPMCR_Dementia1", "DSMIVAphasiaDate")
        cmbDSMIVApraxia.setValue(formTables, "viewPMCR_Dementia1", "DSMIVApraxiaValue")
        dtDSMIVApraxia.setValue(formTables, "viewPMCR_Dementia1", "DSMIVApraxiaDate")
        cmbDSMIVAgnosia.setValue(formTables, "viewPMCR_Dementia1", "DSMIVAgnosiaValue")
        dtDSMIVAgnosia.setValue(formTables, "viewPMCR_Dementia1", "DSMIVAgnosiaDate")
        cmbDistExecFunct.setValue(formTables, "viewPMCR_Dementia1", "ExecFunctValue")
        dtDistExecFunct.setValue(formTables, "viewPMCR_Dementia1", "ExecFunctDate")
        cmbMeetsDSMCrit.setValue(formTables, "viewPMCR_Dementia1", "MeetsDSMCriteriaValue")
        dtMeetsDSMCrit.setValue(formTables, "viewPMCR_Dementia1", "MeetsDSMCriteriaDate")
        cmbBlessed.setValue(formTables, "viewPMCR_Dementia1", "BlessedValue")
        dtBlessed.setValue(formTables, "viewPMCR_Dementia1", "BlessedDate")
        cmb2Deficits.setValue(formTables, "viewPMCR_Dementia1", "TwoDefecitsValue")
        dt2Deficits.setValue(formTables, "viewPMCR_Dementia1", "TwoDefecitsDate")
        cmbProgDetMemCog.setValue(formTables, "viewPMCR_Dementia1", "ProgDetMemCogValue")
        dtProgDetMemCog.setValue(formTables, "viewPMCR_Dementia1", "ProgDetMemCogDate")
        cmbOnset4090.setValue(formTables, "viewPMCR_Dementia1", "OnsetFourtyNinetyValue")
        txtOnset4090.setValue(formTables, "viewPMCR_Dementia1", "OnsetFourtyNinetyDate")
        cmbNoOthEtiology.setValue(formTables, "viewPMCR_Dementia1", "NoOtherEtiologyValue")
        dtNoOthEtiology.setValue(formTables, "viewPMCR_Dementia1", "NoOtherEtiologyDate")
        cmbPres2ndBrainDis.setValue(formTables, "viewPMCR_Dementia1", "SecondDisorderValue")
        dtPres2ndBrainDis.setValue(formTables, "viewPMCR_Dementia1", "SecondDisorderDate")
        cmbPresSingProg.setValue(formTables, "viewPMCR_Dementia1", "SingProgDefecitValue")
        dtPresSingProg.setValue(formTables, "viewPMCR_Dementia1", "SingProgDefecitDate")
        cmbMeetsNINCDS.setValue(formTables, "viewPMCR_Dementia1", "NINCDSADValue")
        dtMeetsNINCDS.setValue(formTables, "viewPMCR_Dementia1", "NINCDSADDate")
        txtAgeOfOnset.setValue(formTables, "viewPMCR_Dementia1", "AgeOfOnset")
        txtDSM_NINCDSNotes.setValue(formTables, "viewPMCR_Dementia1", "NINCDSNotes")
        setFocalSigns()
        setAbsentImageStudies()
        calcClinVascDemOverall()
        calcMeetsDSMCrit()
        calcMeetsNINCDSADCrit()
        calcMeetsNINCDSVDCrit()
    End Sub
    Private Sub enableInputFields(ByVal bool As Boolean)
        comboVascDementia.Enabled = bool
        txtVascDementia.Enabled = bool
        comboEvi2MoreIschStrokes.Enabled = bool
        txtEvi2MoreIschStrokes.Enabled = bool
        comboEvi1Infarct.Enabled = bool
        txtEvi1Infarct.Enabled = bool
        comboEviMultInf.Enabled = bool
        txtEviMultInf.Enabled = bool
        comboHxMultTIA.Enabled = bool
        txtHxMultTIA.Enabled = bool
        comboHxVascRisk.Enabled = bool
        txtHxVascRisk.Enabled = bool
        comboElevHach.Enabled = bool
        txtElevHach.Enabled = bool
        comboHxEviSglStroke.Enabled = bool
        txtHxEviSglStroke.Enabled = bool
        comboBinswangers.Enabled = bool
        txtBinswangers.Enabled = bool
        comboPresOthBrainDis.Enabled = bool
        txtPresOthBrainDis.Enabled = bool
        comboRelBetFocSign.Enabled = bool
        txtRelBetFocSign.Enabled = bool
        txtVascDemNotes.makeReadOnly(Not bool)
        txtVascDemOverall.Enabled = bool
        txtVascDemNINCDS.Enabled = bool
        comboDemPark.Enabled = bool
        txtDemPark.Enabled = bool
        comboDemAlc.Enabled = bool
        txtDemAlc.Enabled = bool
        comboClinDementia.Enabled = bool
        txtClinDementia.Enabled = bool
        comboOrgMentSynd.Enabled = bool
        txtOrgMentSynd.Enabled = bool
        comboAlzheimers.Enabled = bool
        txtAlzheimers.Enabled = bool
        comboEnceph.Enabled = bool
        txtEnceph.Enabled = bool
        comboAbruptOnset.Enabled = bool
        txtAbruptOnset.Enabled = bool
        comboLewy.Enabled = bool
        txtLewy.Enabled = bool
        comboConfused.Enabled = bool
        txtConfused.Enabled = bool
        comboNoctConf.Enabled = bool
        txtNoctConf.Enabled = bool
        comboClinDemOth.Enabled = bool
        txtClinDemOth.Enabled = bool
        txtClinDemOthNote.makeReadOnly(Not bool)
        txtClinDemFirstEntry.Enabled = bool
        comboImpShortMem.Enabled = bool
        dtImpShortMem.Enabled = bool
        cmbImpLongMemPers.Enabled = bool
        dtImpLongMemPers.Enabled = bool
        cmbImpLongMemComm.Enabled = bool
        dtImpLongMemComm.Enabled = bool
        cmbImpAbs.Enabled = bool
        dtImpAbs.Enabled = bool
        cmbImpJudge.Enabled = bool
        dtImpJudge.Enabled = bool
        cmbDistHighCortFunct.Enabled = bool
        dtDistHighCortFunct.Enabled = bool
        cmbDSMIIIAphasia.Enabled = bool
        dtDSMIIIAphasia.Enabled = bool
        cmbDSMIIIApraxia.Enabled = bool
        dtDSMIIIApraxia.Enabled = bool
        cmbDSMIIIAgnosia.Enabled = bool
        dtDSMIIIAgnosia.Enabled = bool
        cmbPersChg.Enabled = bool
        dtPersChg.Enabled = bool
        cmbImpMem.Enabled = bool
        dtImpMem.Enabled = bool
        cmbDSMIVAphasia.Enabled = bool
        dtDSMIVAphasia.Enabled = bool
        cmbDSMIVApraxia.Enabled = bool
        dtDSMIVApraxia.Enabled = bool
        cmbDSMIVAgnosia.Enabled = bool
        dtDSMIVAgnosia.Enabled = bool
        cmbDistExecFunct.Enabled = bool
        dtDistExecFunct.Enabled = bool
        dtMeetsDSMCrit.Enabled = bool
        cmbBlessed.Enabled = bool
        dtBlessed.Enabled = bool
        cmb2Deficits.Enabled = bool
        dt2Deficits.Enabled = bool
        cmbProgDetMemCog.Enabled = bool
        dtProgDetMemCog.Enabled = bool
        cmbOnset4090.Enabled = bool
        txtOnset4090.Enabled = bool
        cmbNoOthEtiology.Enabled = bool
        dtNoOthEtiology.Enabled = bool
        cmbPres2ndBrainDis.Enabled = bool
        dtPres2ndBrainDis.Enabled = bool
        cmbPresSingProg.Enabled = bool
        dtPresSingProg.Enabled = bool
        dtMeetsNINCDS.Enabled = bool
        txtAgeOfOnset.Enabled = bool
        txtDSM_NINCDSNotes.makeReadOnly(Not bool)
    End Sub

    'Autocalc field subs
    Private Sub calcClinVascDemOverall() Handles comboVascDementia.SelectedValueChanged, comboEvi2MoreIschStrokes.SelectedValueChanged, comboEvi1Infarct.SelectedValueChanged,
        comboEviMultInf.SelectedValueChanged, comboHxMultTIA.SelectedValueChanged, comboHxVascRisk.SelectedValueChanged, comboElevHach.SelectedValueChanged, comboHxEviSglStroke.SelectedValueChanged,
        comboBinswangers.SelectedValueChanged, comboPresOthBrainDis.SelectedValueChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View And WarehouseShell.DataMode <> WarehouseShell.userDataMode.Undefined Then

            'check for criteria 3 first
            If comboVascDementia.SelectedValue = 1 And comboEvi2MoreIschStrokes.SelectedValue = 1 And comboEvi1Infarct.SelectedValue = 1 And (comboEviMultInf.SelectedValue = 1 Or comboHxMultTIA.SelectedValue = 1 Or
                comboHxVascRisk.SelectedValue = 1 Or comboElevHach.SelectedValue = 1) Then
                comboVascDemOverall.SelectedValue = 3

                'check for criteria 2 next
            ElseIf comboVascDementia.SelectedValue = 1 And (comboHxEviSglStroke.SelectedValue = 1 Or comboBinswangers.SelectedValue = 1) Then
                comboVascDemOverall.SelectedValue = 2

                'check for criteria 4 next
            ElseIf comboVascDementia.SelectedValue = 1 And comboEvi2MoreIschStrokes.SelectedValue = 1 And comboEvi1Infarct.SelectedValue = 1 And comboPresOthBrainDis.SelectedValue = 1 Then
                comboVascDemOverall.SelectedValue = 4

                'check for criteria 1 (specifically excludes item 11 since it only applies to NINCDS Vasc Dem)
            ElseIf comboVascDementia.SelectedValue <> -1 AndAlso
                        comboVascDementia.SelectedValue <> 9 AndAlso
                        comboEvi2MoreIschStrokes.SelectedValue <> -1 AndAlso
                        comboEvi2MoreIschStrokes.SelectedValue <> 9 AndAlso
                        comboEvi1Infarct.SelectedValue <> -1 AndAlso
                        comboEvi1Infarct.SelectedValue <> 9 AndAlso
                        comboEviMultInf.SelectedValue <> -1 AndAlso
                        comboEviMultInf.SelectedValue <> 9 AndAlso
                        comboHxMultTIA.SelectedValue <> -1 AndAlso
                        comboHxMultTIA.SelectedValue <> 9 AndAlso
                        comboHxVascRisk.SelectedValue <> -1 AndAlso
                        comboHxVascRisk.SelectedValue <> 9 AndAlso
                        comboElevHach.SelectedValue <> -1 AndAlso
                        comboElevHach.SelectedValue <> 9 AndAlso
                        comboHxEviSglStroke.SelectedValue <> -1 AndAlso
                        comboHxEviSglStroke.SelectedValue <> 9 AndAlso
                        comboBinswangers.SelectedValue <> -1 AndAlso
                        comboBinswangers.SelectedValue <> 9 AndAlso
                        comboPresOthBrainDis.SelectedValue <> -1 AndAlso
                        comboPresOthBrainDis.SelectedValue <> 9 Then
                comboVascDemOverall.SelectedValue = 1
            Else

                'default to criteria 5 if all others failed
                comboVascDemOverall.SelectedValue = 5
            End If
        End If
    End Sub
    Private Sub calcMeetsNINCDSVDCrit() Handles comboVascDementia.SelectedValueChanged, comboEvi2MoreIschStrokes.SelectedValueChanged, comboEvi1Infarct.SelectedValueChanged,
        comboEviMultInf.SelectedValueChanged, comboHxMultTIA.SelectedValueChanged, comboHxVascRisk.SelectedValueChanged, comboElevHach.SelectedValueChanged, comboHxEviSglStroke.SelectedValueChanged,
        comboBinswangers.SelectedValueChanged, comboPresOthBrainDis.SelectedValueChanged, comboRelBetFocSign.SelectedValueChanged

        'interpretation of all criteria verified by Harry 2017-03-08
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View And WarehouseShell.DataMode <> WarehouseShell.userDataMode.Undefined Then
            'check for criteria 3 first
            If comboVascDementia.SelectedValue = 1 And comboEvi1Infarct.SelectedValue = 1 And comboRelBetFocSign.SelectedValue = 1 And chkFocalSigns.Checked Then
                comboVascDemNINCDS.SelectedValue = 3

                'check for criteria 2 next
            ElseIf comboVascDementia.SelectedValue = 1 And chkFocalSigns.Checked And (chkAbsentImageStudy.Checked Or comboRelBetFocSign.SelectedValue = 1) Then
                comboVascDemNINCDS.SelectedValue = 2

                'check for criteria 1 next
            ElseIf comboVascDementia.SelectedValue <> -1 AndAlso
                    comboVascDementia.SelectedValue <> 9 AndAlso
                    comboEvi1Infarct.SelectedValue <> -1 AndAlso
                    comboEvi1Infarct.SelectedValue <> 9 AndAlso
                    comboRelBetFocSign.SelectedValue <> -1 AndAlso
                    comboRelBetFocSign.SelectedValue <> 9 Then
                comboVascDemNINCDS.SelectedValue = 1
            Else

                'default to criteria 9 if all others failed
                comboVascDemNINCDS.SelectedValue = 9
            End If
        End If
    End Sub
    Private Sub calcMeetsDSMCrit() Handles comboImpShortMem.SelectedValueChanged, cmbImpLongMemPers.SelectedValueChanged, cmbImpLongMemComm.SelectedValueChanged, cmbImpAbs.SelectedValueChanged,
        cmbImpJudge.SelectedValueChanged, cmbDistHighCortFunct.SelectedValueChanged, cmbDSMIIIAphasia.SelectedValueChanged, cmbDSMIIIApraxia.SelectedValueChanged, cmbDSMIIIAgnosia.SelectedValueChanged,
        cmbPersChg.SelectedValueChanged, cmbImpMem.SelectedValueChanged, cmbDSMIVAphasia.SelectedValueChanged, cmbDSMIVApraxia.SelectedValueChanged, cmbDSMIVAgnosia.SelectedValueChanged, cmbDistExecFunct.SelectedValueChanged

        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View And WarehouseShell.DataMode <> WarehouseShell.userDataMode.Undefined Then
            'check if DMSIII criteria met
            If comboImpShortMem.SelectedValue = 1 And (cmbImpLongMemPers.SelectedValue = 1 Or cmbImpLongMemComm.SelectedValue = 1) And (cmbImpAbs.SelectedValue = 1 Or cmbImpJudge.SelectedValue = 1 Or cmbDistHighCortFunct.SelectedValue = 1 Or cmbPersChg.SelectedValue = 1) Then
                cmbMeetsDSMCrit.SelectedValue = 1

                'check if DSSMIV criteria met
            ElseIf cmbImpMem.SelectedValue = 1 And (cmbDSMIVAphasia.SelectedValue = 1 Or cmbDSMIVApraxia.SelectedValue = 1 Or cmbDSMIVAgnosia.SelectedValue = 1 Or cmbDistExecFunct.SelectedValue = 1) Then
                cmbMeetsDSMCrit.SelectedValue = 1

                'check if DSMIII-1 and DSMIV-1 are no (automatically sets MeetsDSM to no)
            ElseIf comboImpShortMem.SelectedValue = 2 And cmbImpMem.SelectedValue = 2 Then
                cmbMeetsDSMCrit.SelectedValue = 2

                'Check if all decision-criteria values are definitive (yes/no) and if so, set MeetsDSM to no
            ElseIf checkDSMDefinitiveValues() Then
                cmbMeetsDSMCrit.SelectedValue = 2

                'Default to unknown if all else fails
            Else
                cmbMeetsDSMCrit.SelectedValue = 9
            End If
        End If
    End Sub
    Private Sub calcMeetsNINCDSADCrit() Handles cmbBlessed.SelectedValueChanged, cmb2Deficits.SelectedValueChanged, cmbProgDetMemCog.SelectedValueChanged, cmbOnset4090.SelectedValueChanged, cmbNoOthEtiology.SelectedValueChanged, cmbPres2ndBrainDis.SelectedValueChanged, cmbPresSingProg.SelectedValueChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View And WarehouseShell.DataMode <> WarehouseShell.userDataMode.Undefined Then
            Dim int1 As Integer = 1
            'Check for NINCDS 3
            If cmbBlessed.SelectedValue = 1 And cmb2Deficits.SelectedValue = 1 And cmbProgDetMemCog.SelectedValue = 1 And cmbOnset4090.SelectedValue = 1 And cmbNoOthEtiology.SelectedValue = 1 And cmbPres2ndBrainDis.SelectedValue = 2 And cmbPresSingProg.SelectedValue = 2 Then
                int1 = 3
                'Check for NINCDS 2
            ElseIf (cmbBlessed.SelectedValue = 1 And cmb2Deficits.SelectedValue = 1 And cmbProgDetMemCog.SelectedValue = 1 And cmbPres2ndBrainDis.SelectedValue = 1) Or (cmbBlessed.SelectedValue = 1 And cmbProgDetMemCog.SelectedValue = 1 And cmbPresSingProg.SelectedValue = 1) Then
                int1 = 2
                'If Postmortem CDR exists, check for NINCDS 5-8
            ElseIf Database.ExistingRecordCheck("CDR", "SubNum = " & WarehouseShell.SubNum & " and Visit = 888") Then
                formTables.Tables.Add(Database.ReturnTable("CDR", , "SubNum = " & WarehouseShell.SubNum & " and Visit = 888"))
                'Check for NINCDS 5
                If formTables.Tables("CDR").Rows(0).Item("CDRScore") > 1 And formTables.Tables("CDR").Rows(0).Item("MemoryScore") = 0 Then
                    int1 = 5
                    'Check for NINCDS 6
                ElseIf formTables.Tables("CDR").Rows(0).Item("CDRScore") = 0.5 And formTables.Tables("CDR").Rows(0).Item("MemoryScore") = 0.5 And formTables.Tables("CDR").Rows(0).Item("OrientationScore") < 1 And formTables.Tables("CDR").Rows(0).Item("JudgeProbScore") < 1 And formTables.Tables("CDR").Rows(0).Item("CommAffairsScore") < 1 And formTables.Tables("CDR").Rows(0).Item("HomeHobbyScore") < 1 And formTables.Tables("CDR").Rows(0).Item("PersonalCareScore") < 1 Then
                    int1 = 6
                    'Check for NINCDS 8
                ElseIf (formTables.Tables("CDR").Rows(0).Item("OrientationScore") > 0 Or formTables.Tables("CDR").Rows(0).Item("JudgeProbScore") > 0 Or formTables.Tables("CDR").Rows(0).Item("CommAffairsScore") > 0 Or formTables.Tables("CDR").Rows(0).Item("HomeHobbyScore") > 0 Or formTables.Tables("CDR").Rows(0).Item("PersonalCareScore") > 0) And formTables.Tables("CDR").Rows(0).Item("MemoryScore") = 0 Then
                    int1 = 8
                End If
                formTables.Tables.Remove("CDR")
                'Check for NINCDS 4
            ElseIf (cmbBlessed.SelectedValue = 9 Or cmb2Deficits.SelectedValue = 9 Or cmbProgDetMemCog.SelectedValue = 9 Or cmbOnset4090.SelectedValue = 9 Or cmbNoOthEtiology.SelectedValue = 9 Or cmbPres2ndBrainDis.SelectedValue = 9 Or cmbPresSingProg.SelectedValue = 9) Then
                int1 = 4
            Else
                int1 = 1
            End If
            cmbMeetsNINCDS.SelectedValue = int1
        End If
    End Sub

    'Autocalc helpers
    Private Function checkDSMDefinitiveValues() As Boolean
        Dim result = True

        'check applicable DSMIII values
        If comboImpShortMem.SelectedValue <> 1 AndAlso comboImpShortMem.SelectedValue <> 2 Then
            result = False
        End If
        If cmbImpLongMemPers.SelectedValue <> 1 AndAlso cmbImpLongMemPers.SelectedValue <> 2 Then
            result = False
        End If
        If cmbImpLongMemComm.SelectedValue <> 1 AndAlso cmbImpLongMemComm.SelectedValue <> 2 Then
            result = False
        End If
        If cmbImpAbs.SelectedValue <> 1 AndAlso cmbImpAbs.SelectedValue <> 2 Then
            result = False
        End If
        If cmbImpJudge.SelectedValue <> 1 AndAlso cmbImpJudge.SelectedValue <> 2 Then
            result = False
        End If
        If cmbDistHighCortFunct.SelectedValue <> 1 AndAlso cmbDistHighCortFunct.SelectedValue <> 2 Then
            result = False
        End If
        If cmbPersChg.SelectedValue <> 1 AndAlso cmbPersChg.SelectedValue <> 2 Then
            result = False
        End If

        'check applicable DSMIV values
        If cmbImpMem.SelectedValue <> 1 AndAlso cmbImpMem.SelectedValue <> 2 Then
            result = False
        End If
        If cmbDSMIVAphasia.SelectedValue <> 1 AndAlso cmbDSMIVAphasia.SelectedValue <> 2 Then
            result = False
        End If
        If cmbDSMIVApraxia.SelectedValue <> 1 AndAlso cmbDSMIVApraxia.SelectedValue <> 2 Then
            result = False
        End If
        If cmbDSMIVAgnosia.SelectedValue <> 1 AndAlso cmbDSMIVAgnosia.SelectedValue <> 2 Then
            result = False
        End If
        If cmbDistExecFunct.SelectedValue <> 1 AndAlso cmbDistExecFunct.SelectedValue <> 2 Then
            result = False
        End If

        Return result
    End Function
    Private Sub setFocalSigns() 'sets chkFocalSigns based on PMCR_CVD values
        Dim result As Boolean = False

        If Database.ExistingRecordCheck("PMCR_CVD", "SubNum = " & WarehouseShell.SubNum) Then
            formTables.Tables.Add(Database.ReturnTable("PMCR_CVD", , "SubNum = " & WarehouseShell.SubNum))

            'Check for any Cerebrovascular Disease/Neurological Sx "Yes"
            If formTables.Tables("PMCR_CVD").Rows(0).Item("SyncopalEpi") = 1 Then
                result = True
            ElseIf formTables.Tables("PMCR_CVD").Rows(0).Item("BrainHemo") = 1 Then
                result = True
            ElseIf formTables.Tables("PMCR_CVD").Rows(0).Item("ClinHxCVA") = 1 Then
                result = True
            ElseIf formTables.Tables("PMCR_CVD").Rows(0).Item("ParalysisFace") = 1 Then
                result = True
            ElseIf formTables.Tables("PMCR_CVD").Rows(0).Item("VisFieldDefecit") = 1 Then
                result = True
            ElseIf formTables.Tables("PMCR_CVD").Rows(0).Item("ClinEviSensoryDefecit") = 1 Then
                result = True
            ElseIf formTables.Tables("PMCR_CVD").Rows(0).Item("ReceptiveAphasia") = 1 Then
                result = True
            ElseIf formTables.Tables("PMCR_CVD").Rows(0).Item("EmotionalLiability") = 1 Then
                result = True
            ElseIf formTables.Tables("PMCR_CVD").Rows(0).Item("FocalTIA") = 1 Then
                result = True
            ElseIf formTables.Tables("PMCR_CVD").Rows(0).Item("MajHypoxicEvent") = 1 Then
                result = True
            ElseIf formTables.Tables("PMCR_CVD").Rows(0).Item("ParalysisLimbTrunk") = 1 Then
                result = True
            ElseIf formTables.Tables("PMCR_CVD").Rows(0).Item("ExpressiveAphasia") = 1 Then
                result = True
            ElseIf formTables.Tables("PMCR_CVD").Rows(0).Item("AtaxiaLimbTrunk") = 1 Then
                result = True
            End If

            'Check for any Neurological Exam "Yes"
            If formTables.Tables("PMCR_CVD").Rows(0).Item("IncTone") = 1 Then
                result = True
            ElseIf formTables.Tables("PMCR_CVD").Rows(0).Item("Nasolabial") = 1 Then
                result = True
            ElseIf formTables.Tables("PMCR_CVD").Rows(0).Item("Babinski") = 1 Then
                result = True
            ElseIf formTables.Tables("PMCR_CVD").Rows(0).Item("Extrapyramidal") = 1 Then
                result = True
            ElseIf formTables.Tables("PMCR_CVD").Rows(0).Item("Tremor") = 1 Then
                result = True
            ElseIf formTables.Tables("PMCR_CVD").Rows(0).Item("MotorSpeechImp") = 1 Then
                result = True
            ElseIf formTables.Tables("PMCR_CVD").Rows(0).Item("NeuroSensoryDefecit") = 1 Then
                result = True
            ElseIf formTables.Tables("PMCR_CVD").Rows(0).Item("FrontReleaseRefl") = 1 Then
                result = True
            ElseIf formTables.Tables("PMCR_CVD").Rows(0).Item("SomaticComplaints") = 1 Then
                result = True
            ElseIf formTables.Tables("PMCR_CVD").Rows(0).Item("NeuroOther") = 1 Then
                result = True
            End If

            'Clean up the added table
            formTables.Tables.Remove("PMCR_CVD")
        End If

        'Set user feedback checkbox
        chkFocalSigns.Checked = result
    End Sub
    Private Sub setAbsentImageStudies() 'sets chkAbsentImageStudies based on PMCR_CVD values
        Dim Result As Boolean = True

        If Database.ExistingRecordCheck("PMCR_CVD", "SubNum = " & WarehouseShell.SubNum) Then
            formTables.Tables.Add(Database.ReturnTable("PMCR_CVD", , "SubNum = " & WarehouseShell.SubNum))

            'Check for CAT or MRI scans
            If formTables.Tables("PMCR_CVD").Rows(0).Item("Cat") <> 0 Then
                Result = False
            ElseIf formTables.Tables("PMCR_CVD").Rows(0).Item("MRI") <> 0 Then
                Result = False
            End If

            'Clean up added table
            formTables.Tables.Remove("PMCR_CVD")
        End If

        'Set user feedback checkbox
        chkAbsentImageStudy.Checked = Result
    End Sub

    'Save routines
    Private Sub btnDementiaSave_Click(sender As Object, e As EventArgs) Handles btnDementia1Top.Click, btnDementia1Bottom.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_PMCR_Dementia1", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                btnDementia1Bottom.Text = "Save Changes"
                btnDementia1Top.Text = btnDementia1Bottom.Text
                enableInputFields(True)
                calcClinVascDemOverall()
                calcMeetsDSMCrit()
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If User.PermissionCheck("WA_PMCR_Dementia1", "Modify") Then
                loadBaseForm()
                setDefaultValues()
                lblNoRecord.Visible = False
                btnDementia1Top.Text = "Save New Record"
                btnDementia1Bottom.Text = "Save New Record"
                enableInputFields(True)
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
            End If
        Else 'By default, user is attempting to Insert or Edit a record. Run preSaveValidation.
            If preSaveValidation() Then 'If preSaveValidation returns true, take Insert or Update actions.
                'Same parameters for Insert or Update SP's, so define here
                Dim parameters = " @SubNum = " & WarehouseShell.SubNum &
                    ", @VascDementia = " & comboVascDementia.getSQLValue() &
                    ", @VascDementiaDate = " & txtVascDementia.getSQLValue() &
                    ", @IschemicStrokes = " & comboEvi2MoreIschStrokes.getSQLValue() &
                    ", @IschemicStrokesDate = " & txtEvi2MoreIschStrokes.getSQLValue() &
                    ", @OneInfarct = " & comboEvi1Infarct.getSQLValue() &
                    ", @OneInfarctDate = " & txtEvi1Infarct.getSQLValue() &
                    ", @MultInfarcts = " & comboEviMultInf.getSQLValue() &
                    ", @MultInfarctsDate = " & txtEviMultInf.getSQLValue() &
                    ", @HxTIAs = " & comboHxMultTIA.getSQLValue() &
                    ", @HxTIAsDate = " & txtHxMultTIA.getSQLValue() &
                    ", @HxVascRisk = " & comboHxVascRisk.getSQLValue() &
                    ", @HxVascRiskDate = " & txtHxVascRisk.getSQLValue() &
                    ", @ElevHachinski = " & comboElevHach.getSQLValue() &
                    ", @ElevHachinskiDate = " & txtElevHach.getSQLValue() &
                    ", @HxSingleStroke = " & comboHxEviSglStroke.getSQLValue() &
                    ", @HxSingleStrokeDate = " & txtHxEviSglStroke.getSQLValue() &
                    ", @Binswangers = " & comboBinswangers.getSQLValue() &
                    ", @BinswangersDate = " & txtBinswangers.getSQLValue() &
                    ", @DisorderRelDementia = " & comboPresOthBrainDis.getSQLValue() &
                    ", @DisorderRelDementiaDate = " & txtPresOthBrainDis.getSQLValue() &
                    ", @RelFocalSigns = " & comboRelBetFocSign.getSQLValue() &
                    ", @RelFocalSignsDate = " & txtRelBetFocSign.getSQLValue() &
                    ", @VascNotes = " & txtVascDemNotes.getSQLValue() &
                    ", @OverallScore = " & comboVascDemOverall.getSQLValue() &
                    ", @OverallScoreDate = " & txtVascDemOverall.getSQLValue() &
                    ", @NINCDSDate = " & txtVascDemNINCDS.getSQLValue() &
                    ", @DemPark = " & comboDemPark.getSQLValue() &
                    ", @DemParkDate = " & txtDemPark.getSQLValue() &
                    ", @DemAlcohol = " & comboDemAlc.getSQLValue() &
                    ", @DemAlcoholDate = " & txtDemAlc.getSQLValue() &
                    ", @ClinDementia = " & comboClinDementia.getSQLValue() &
                    ", @ClinDementiaDate = " & txtClinDementia.getSQLValue() &
                    ", @OrgMentalSynd = " & comboOrgMentSynd.getSQLValue() &
                    ", @OrgMentalSyndDate = " & txtOrgMentSynd.getSQLValue() &
                    ", @Alzheimers = " & comboAlzheimers.getSQLValue() &
                    ", @AlzheimersDate = " & txtAlzheimers.getSQLValue() &
                    ", @Enceph = " & comboEnceph.getSQLValue() &
                    ", @EncephDate = " & txtEnceph.getSQLValue() &
                    ", @AbruptOnset = " & comboAbruptOnset.getSQLValue() &
                    ", @AbruptOnsetDate = " & txtAbruptOnset.getSQLValue() &
                    ", @Lewy = " & comboLewy.getSQLValue() &
                    ", @LewyDate = " & txtLewy.getSQLValue() &
                    ", @Confused = " & comboConfused.getSQLValue() &
                    ", @ConfusedDate = " & txtConfused.getSQLValue() &
                    ", @Nocturnal = " & comboNoctConf.getSQLValue() &
                    ", @NocturnalDate = " & txtNoctConf.getSQLValue() &
                    ", @ClinOther = " & comboClinDemOth.getSQLValue() &
                    ", @ClinOtherDate = " & txtClinDemOth.getSQLValue() &
                    ", @ClinOtherNote = " & txtClinDemOthNote.getSQLValue() &
                    ", @DateFirstEntry = " & txtClinDemFirstEntry.getSQLValue() &
                    ", @ShortTermMem = " & comboImpShortMem.getSQLValue() &
                    ", @ShortTermMemDate = " & dtImpShortMem.getSQLValue() &
                    ", @LongTermPers = " & cmbImpLongMemPers.getSQLValue() &
                    ", @LongTermPersDate = " & dtImpLongMemPers.getSQLValue() &
                    ", @LongTermComKnow = " & cmbImpLongMemComm.getSQLValue() &
                    ", @LongTermComKnowDate = " & dtImpLongMemComm.getSQLValue() &
                    ", @AbstractThinking = " & cmbImpAbs.getSQLValue() &
                    ", @AbstractThinkingDate = " & dtImpAbs.getSQLValue() &
                    ", @Judgement = " & cmbImpJudge.getSQLValue() &
                    ", @JudgementDate = " & dtImpJudge.getSQLValue() &
                    ", @DistHighCortFunct = " & cmbDistHighCortFunct.getSQLValue() &
                    ", @DistHighCortFunctDate = " & dtDistHighCortFunct.getSQLValue() &
                    ", @DSMIIIAphasia = " & cmbDSMIIIAphasia.getSQLValue() &
                    ", @DSMIIIAphasiaDate = " & dtDSMIIIAphasia.getSQLValue() &
                    ", @DSMIIIApraxia = " & cmbDSMIIIApraxia.getSQLValue() &
                    ", @DSMIIIApraxiaDate = " & dtDSMIIIApraxia.getSQLValue() &
                    ", @DSMIIIAgnosia = " & cmbDSMIIIAgnosia.getSQLValue() &
                    ", @DSMIIIAgnosiaDate = " & dtDSMIIIAgnosia.getSQLValue() &
                    ", @PersonalityChg = " & cmbPersChg.getSQLValue() &
                    ", @PersonalityChgDate = " & dtPersChg.getSQLValue() &
                    ", @Memory = " & cmbImpMem.getSQLValue() &
                    ", @MemoryDate = " & dtImpMem.getSQLValue() &
                    ", @DSMIVAphasia = " & cmbDSMIVAphasia.getSQLValue() &
                    ", @DSMIVAphasiaDate = " & dtDSMIVAphasia.getSQLValue() &
                    ", @DSMIVApraxia = " & cmbDSMIVApraxia.getSQLValue() &
                    ", @DSMIVApraxiaDate = " & dtDSMIVApraxia.getSQLValue() &
                    ", @DSMIVAgnosia = " & cmbDSMIVAgnosia.getSQLValue() &
                    ", @DSMIVAgnosiaDate = " & dtDSMIVAgnosia.getSQLValue() &
                    ", @ExecFunct = " & cmbDistExecFunct.getSQLValue() &
                    ", @ExecFunctDate = " & dtDistExecFunct.getSQLValue() &
                    ", @MeetsDSMCriteria = " & cmbMeetsDSMCrit.getSQLValue() &
                    ", @MeetsDSMCriteriaDate = " & dtMeetsDSMCrit.getSQLValue() &
                    ", @Blessed = " & cmbBlessed.getSQLValue() &
                    ", @BlessedDate = " & dtBlessed.getSQLValue() &
                    ", @TwoDefecits = " & cmb2Deficits.getSQLValue() &
                    ", @TwoDefecitsDate = " & dt2Deficits.getSQLValue() &
                    ", @ProgDetMemCog = " & cmbProgDetMemCog.getSQLValue() &
                    ", @ProgDetMemCogDate = " & dtProgDetMemCog.getSQLValue() &
                    ", @OnsetFourtyNinety = " & cmbOnset4090.getSQLValue() &
                    ", @OnsetFourtyNinetyDate = " & txtOnset4090.getSQLValue() &
                    ", @NoOtherEtiology = " & cmbNoOthEtiology.getSQLValue() &
                    ", @NoOtherEtiologyDate = " & dtNoOthEtiology.getSQLValue() &
                    ", @SecondDisorder = " & cmbPres2ndBrainDis.getSQLValue() &
                    ", @SecondDisorderDate = " & dtPres2ndBrainDis.getSQLValue() &
                    ", @SingProgDefecit = " & cmbPresSingProg.getSQLValue() &
                    ", @SingProgDefecitDate = " & dtPresSingProg.getSQLValue() &
                    ", @NINCDSADDate = " & dtMeetsNINCDS.getSQLValue() &
                    ", @AgeOfOnset = " & txtAgeOfOnset.getSQLValue() &
                    ", @NINCDSNotes = " & txtDSM_NINCDSNotes.getSQLValue() &
                    ", @LastModBy = '" & WarehouseShell.userName & "';"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    Dim cmd As New SqlCommand("Exec modPMCR_Dementia1Record @Action = 1, " & parameters, WarehouseShell.conn)
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Save successful", MsgBoxStyle.OkOnly)
                        loadExistingData()
                        enableInputFields(False)
                        btnDementia1Bottom.Text = "Edit Record"
                        btnDementia1Top.Text = "Edit Record"
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else 'If this clause is invoked, datamode must be Edit
                    Dim cmd As New SqlCommand("Exec modPMCR_Dementia1Record @Action = 2, " & parameters, WarehouseShell.conn)
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Save successful", MsgBoxStyle.OkOnly)
                        loadExistingData()
                        enableInputFields(False)
                        btnDementia1Bottom.Text = "Edit Record"
                        btnDementia1Top.Text = "Edit Record"
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                End If
            End If
        End If
    End Sub
    Private Function preSaveValidation() As Boolean
        Dim result As Boolean = True
        Dim errMsg As String = "Please correct the following errors before attempting to save this record:" & vbNewLine & vbNewLine

        'Check other - specify relationship
        If comboClinDemOth.SelectedValue = 1 And txtClinDemOthNote.Text = "" Then
            errMsg += "- You have selected Yes for Other in Section 3 Item 9 but not specified what other is. Please specify or change selection in the dropdown." & vbNewLine
            result = False
        End If
        If comboClinDemOth.SelectedValue <> 1 And txtClinDemOthNote.Text <> "" Then
            errMsg += "- You have entered a Specify for Section 3 Item 9, but have not selected Yes in the dropdown. Please select Yes or clear the specify." & vbNewLine
            result = False
        End If

        'Check DSMIII/DSMIV Aphasia, Apraxia, Agnosia matches
        If cmbDSMIIIAphasia.SelectedValue <> cmbDSMIVAphasia.SelectedValue Then
            errMsg += "- Your responses for Aphasia in DSMIII and DSMIV do not match." & vbNewLine
            result = False
        End If
        If cmbDSMIIIApraxia.SelectedValue <> cmbDSMIVApraxia.SelectedValue Then
            errMsg += "- Your responses for Apraxia in DSMIII and DSMIV do not match." & vbNewLine
            result = False
        End If
        If cmbDSMIIIAgnosia.SelectedValue <> cmbDSMIVAgnosia.SelectedValue Then
            errMsg += "- Your responses for Agnosia in DSMIII and DSMIV do not match." & vbNewLine
            result = False
        End If

        'make sure if DSMIII-6 is yes, at least one a,b,c is also yes
        If cmbDistHighCortFunct.SelectedValue = 1 Then
            If cmbDSMIIIAphasia.SelectedValue <> 1 And cmbDSMIIIApraxia.SelectedValue <> 1 And cmbDSMIIIAgnosia.SelectedValue <> 1 Then
                errMsg += "- You selected Yes for DSMIII item 6. At least one value in 6a, 6b, 6c must also be Yes or DSMIII item 6 must be No." & vbNewLine
                result = False
            End If
        End If

        'Handle false result
        If result = False Then
            MsgBox(errMsg, MsgBoxStyle.OkOnly, "Error")
        End If

        Return result
    End Function

    Public Sub TopLevel(val As Boolean) Implements IFormMethods.TopLevel
        SetTopLevel(val)
    End Sub
    Private Sub IFormMethods_Parent(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Private Sub IFormMethods_Show() Implements IFormMethods.Show
        Show()
    End Sub
    Public Sub ShowPHI(val As Boolean) Implements IFormMethods.ShowPHI
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        btnDementia1Top.PerformClick()
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class