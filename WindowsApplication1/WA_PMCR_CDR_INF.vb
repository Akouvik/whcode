Public Class WA_PMCR_CDR_INF
    Implements IFormMethods
    Private formTables As New DataSet

    Private Sub WA_PMCR_CDR_INF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Database.ExistingRecordCheck("CDR_Inf_Interview", "SubNum = " & WarehouseShell.SubNum) Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            loadBaseForm()
            loadExistingData()
            btnCDRInfTop.Text = "Edit Record"
            btnCDRInfBottom.Text = btnCDRInfTop.Text
        Else 'If it doesn't exist, change mode to Undefined and show user banner
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            lblNoRecord.Visible = True
            btnCDRInfTop.Text = "Add New Record"
            btnCDRInfBottom.Text = btnCDRInfTop.Text
        End If
        enableInputFields(False)
    End Sub
    Private Sub loadBaseForm()
        formTables.Tables.Add(Database.ReturnTable("lkpCDR_Inf_Source"))
        formTables.Tables.Add(Database.ReturnTable("lkpRelation"))
        formTables.Tables.Add(Database.ReturnTable("lkpConfidence"))
        formTables.Tables.Add(Database.ReturnTable("lkpSex"))
        formTables.Tables.Add(Database.ReturnTable("lkpCDR_Inf_Comm_Prob_Sev"))
        formTables.Tables.Add(Database.ReturnTable("lkpRace"))
        formTables.Tables.Add(Database.ReturnTable("lkpCDR_Inf_Freq_Visit_Call"))
        formTables.Tables.Add(Database.ReturnTable("lkpYNNAUnk1239"))
        formTables.Tables.Add(Database.ReturnTable("lkpCDR_Inf_Freq"))
        formTables.Tables.Add(Database.ReturnTable("lkpCDR_Inf_Judge1"))
        formTables.Tables.Add(Database.ReturnTable("lkpCDR_Inf_Judge2"))
        formTables.Tables.Add(Database.ReturnTable("lkpCDR_Inf_Pers1"))
        formTables.Tables.Add(Database.ReturnTable("lkpCDR_Inf_Pers2"))
        formTables.Tables.Add(Database.ReturnTable("lkpCDR_Inf_Pers3"))
        formTables.Tables.Add(Database.ReturnTable("lkpCDR_Inf_Pers4"))
        cmbInfSource.assignLookup(formTables, "lkpCDR_Inf_Source")
        cmbRelation.assignLookup(formTables, "lkpRelation")
        cmbConfLevel.assignLookup(formTables, "lkpConfidence")
        cmbInfSex.assignLookup(formTables, "lkpSex")
        cmbInfCommProbs.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbInfComProbSev.assignLookup(formTables, "lkpCDR_Inf_Comm_Prob_Sev")
        cmbRace.assignLookup(formTables, "lkpRace")
        cmbInfLiveWithSub.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbFreqVisitsPerson.assignLookup(formTables, "lkpCDR_Inf_Freq_Visit_Call")
        cmbFreqVisitsPhone.assignLookup(formTables, "lkpCDR_Inf_Freq_Visit_Call")
        cmbReliability.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbRelWDem.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbVisNormWOLenses.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbWearCorrLenses.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbVisNormWLenses.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbHearNormWOAids.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbWearHearAids.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbMem1.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbMem1Freq.assignLookup(formTables, "lkpCDR_Inf_Freq")
        cmbMem1a.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbMem1aFreq.assignLookup(formTables, "lkpCDR_Inf_Freq")
        cmbMem2.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbMem2Freq.assignLookup(formTables, "lkpCDR_Inf_Freq")
        cmbMem3.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbMem3Freq.assignLookup(formTables, "lkpCDR_Inf_Freq")
        cmbMem4.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbMem4Freq.assignLookup(formTables, "lkpCDR_Inf_Freq")
        cmbMem4a.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbMem4aFreq.assignLookup(formTables, "lkpCDR_Inf_Freq")
        cmbMem5.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbMem5Freq.assignLookup(formTables, "lkpCDR_Inf_Freq")
        cmbMem6.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbMem6Freq.assignLookup(formTables, "lkpCDR_Inf_Freq")
        cmbMem7.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbMem7Freq.assignLookup(formTables, "lkpCDR_Inf_Freq")
        cmbOrient1.assignLookup(formTables, "lkpCDR_Inf_Freq")
        cmbOrient2.assignLookup(formTables, "lkpCDR_Inf_Freq")
        cmbOrient3.assignLookup(formTables, "lkpCDR_Inf_Freq")
        cmbOrient4.assignLookup(formTables, "lkpCDR_Inf_Freq")
        cmbOrient5.assignLookup(formTables, "lkpCDR_Inf_Freq")
        cmbOrient6.assignLookup(formTables, "lkpCDR_Inf_Freq")
        cmbOrient7.assignLookup(formTables, "lkpCDR_Inf_Freq")
        cmbOrient8.assignLookup(formTables, "lkpCDR_Inf_Freq")
        cmbJudge1.assignLookup(formTables, "lkpCDR_Inf_Judge1")
        cmbJudge2.assignLookup(formTables, "lkpCDR_Inf_Judge2")
        cmbJudge3.assignLookup(formTables, "lkpCDR_Inf_Freq")
        cmbJudge4.assignLookup(formTables, "lkpCDR_Inf_Freq")
        cmbJudge4a.assignLookup(formTables, "lkpCDR_Inf_Freq")
        cmbComm1.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbComm1a.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbComm2.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbComm3.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbHome1.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbHome1a.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbHome2.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbHome3.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbHome4.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbHome4a.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbHome5.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbHome6.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbHome7.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbHome7a.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbHome8.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbHome8a.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbPers1.assignLookup(formTables, "lkpCDR_Inf_Pers1")
        cmbPers1a.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbPers2.assignLookup(formTables, "lkpCDR_Inf_Pers2")
        cmbPers2a.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbPers3.assignLookup(formTables, "lkpCDR_Inf_Pers3")
        cmbPers3a.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbPers4.assignLookup(formTables, "lkpCDR_Inf_Pers4")
        cmbPers4a.assignLookup(formTables, "lkpYNNAUnk1239")

        'DemFamHx & VisHear load independently & dynamically
        loadDemFamHxData("DementiaFamilyHx")
        loadVisHearData("VisionAndHearing")
    End Sub
    Private Sub setDefaultValues()
        cmbInfSource.SelectedValue = -1
        cmbRelation.SelectedValue = -1
        cmbConfLevel.SelectedValue = -1
        cmbInfSex.SelectedValue = -1
        cmbInfCommProbs.SelectedValue = -1
        cmbInfComProbSev.SelectedValue = -1
        cmbRace.SelectedValue = -1
        cmbInfLiveWithSub.SelectedValue = -1
        cmbFreqVisitsPerson.SelectedValue = -1
        cmbFreqVisitsPhone.SelectedValue = -1
        cmbReliability.SelectedValue = -1
        cmbMem1.SelectedValue = -1
        cmbMem1Freq.SelectedValue = -1
        cmbMem1a.SelectedValue = -1
        cmbMem1aFreq.SelectedValue = -1
        cmbMem2.SelectedValue = -1
        cmbMem2Freq.SelectedValue = -1
        cmbMem3.SelectedValue = -1
        cmbMem3Freq.SelectedValue = -1
        cmbMem4.SelectedValue = -1
        cmbMem4Freq.SelectedValue = -1
        cmbMem4a.SelectedValue = -1
        cmbMem4aFreq.SelectedValue = -1
        cmbMem5.SelectedValue = -1
        cmbMem5Freq.SelectedValue = -1
        cmbMem6.SelectedValue = -1
        cmbMem6Freq.SelectedValue = -1
        cmbMem7.SelectedValue = -1
        cmbMem7Freq.SelectedValue = -1
        cmbOrient1.SelectedValue = -1
        cmbOrient2.SelectedValue = -1
        cmbOrient3.SelectedValue = -1
        cmbOrient4.SelectedValue = -1
        cmbOrient5.SelectedValue = -1
        cmbOrient6.SelectedValue = -1
        cmbOrient7.SelectedValue = -1
        cmbOrient8.SelectedValue = -1
        cmbJudge1.SelectedValue = -1
        cmbJudge2.SelectedValue = -1
        cmbJudge3.SelectedValue = -1
        cmbJudge4.SelectedValue = -1
        cmbJudge4a.SelectedValue = -1
        cmbComm1.SelectedValue = -1
        cmbComm1a.SelectedValue = -1
        cmbComm2.SelectedValue = -1
        cmbComm3.SelectedValue = -1
        cmbHome1.SelectedValue = -1
        cmbHome1a.SelectedValue = -1
        cmbHome2.SelectedValue = -1
        cmbHome3.SelectedValue = -1
        cmbHome4.SelectedValue = -1
        cmbHome4a.SelectedValue = -1
        cmbHome5.SelectedValue = -1
        cmbHome6.SelectedValue = -1
        cmbHome7.SelectedValue = -1
        cmbHome7a.SelectedValue = -1
        cmbHome8.SelectedValue = -1
        cmbHome8a.SelectedValue = -1
        cmbPers1.SelectedValue = -1
        cmbPers1a.SelectedValue = -1
        cmbPers2.SelectedValue = -1
        cmbPers2a.SelectedValue = -1
        cmbPers3.SelectedValue = -1
        cmbPers3a.SelectedValue = -1
        cmbPers4.SelectedValue = -1
        cmbPers4a.SelectedValue = -1
    End Sub
    Private Sub loadExistingData()
        formTables.Tables.Add(Database.ReturnTable("CDR_Inf_Interview", , "SubNum = " & WarehouseShell.SubNum))
        cmbInfSource.setValue(formTables, "CDR_Inf_Interview", "InfSource")
        txtInfName.setValue(formTables, "CDR_Inf_Interview", "InfName")
        cmbRelation.setValue(formTables, "CDR_Inf_Interview", "InfRelation")
        cmbConfLevel.setValue(formTables, "CDR_Inf_Interview", "ConfLevel")
        dtInfMoYrBirth.setValue(formTables, "CDR_Inf_Interview", "InfMoYrBirth")
        cmbInfSex.setValue(formTables, "CDR_Inf_Interview", "InfSex")
        cmbInfCommProbs.setValue(formTables, "CDR_Inf_Interview", "InfCommProbs")
        cmbInfComProbSev.setValue(formTables, "CDR_Inf_Interview", "InfCommProbSev")
        txtInfCommProbNote.setValue(formTables, "CDR_Inf_Interview", "InfCommProbNote")
        cmbRace.setValue(formTables, "CDR_Inf_Interview", "InfRace")
        txtRaceNote.setValue(formTables, "CDR_Inf_Interview", "InfRaceNote")
        intYrsEd.setValue(formTables, "CDR_Inf_Interview", "InfYrsEd")
        cmbInfLiveWithSub.setValue(formTables, "CDR_Inf_Interview", "InfLiveWSub")
        cmbFreqVisitsPerson.setValue(formTables, "CDR_Inf_Interview", "InfVisitPers")
        cmbFreqVisitsPhone.setValue(formTables, "CDR_Inf_Interview", "InfVisitPhone")
        cmbReliability.setValue(formTables, "CDR_Inf_Interview", "InfReliability")
        txtInterviewNotes.setValue(formTables, "CDR_Inf_Interview", "InfIntNotes")
        cmbMem1.setValue(formTables, "CDR_Inf_Interview", "Mem1")
        cmbMem1Freq.setValue(formTables, "CDR_Inf_Interview", "Mem1Freq")
        cmbMem1a.setValue(formTables, "CDR_Inf_Interview", "Mem1a")
        cmbMem1aFreq.setValue(formTables, "CDR_Inf_Interview", "Mem1aFreq")
        cmbMem2.setValue(formTables, "CDR_Inf_Interview", "Mem2")
        cmbMem2Freq.setValue(formTables, "CDR_Inf_Interview", "Mem2Freq")
        cmbMem3.setValue(formTables, "CDR_Inf_Interview", "Mem3")
        cmbMem3Freq.setValue(formTables, "CDR_Inf_Interview", "Mem3Freq")
        cmbMem4.setValue(formTables, "CDR_Inf_Interview", "Mem4")
        cmbMem4Freq.setValue(formTables, "CDR_Inf_Interview", "Mem4Freq")
        cmbMem4a.setValue(formTables, "CDR_Inf_Interview", "Mem4a")
        cmbMem4aFreq.setValue(formTables, "CDR_Inf_Interview", "Mem4aFreq")
        txtMem4aNote.setValue(formTables, "CDR_Inf_Interview", "Mem4aNote")
        cmbMem5.setValue(formTables, "CDR_Inf_Interview", "Mem5")
        cmbMem5Freq.setValue(formTables, "CDR_Inf_Interview", "Mem5Freq")
        cmbMem6.setValue(formTables, "CDR_Inf_Interview", "Mem6")
        cmbMem6Freq.setValue(formTables, "CDR_Inf_Interview", "Mem6Freq")
        cmbMem7.setValue(formTables, "CDR_Inf_Interview", "Mem7")
        cmbMem7Freq.setValue(formTables, "CDR_Inf_Interview", "Mem7Freq")
        txtMem8aNote.setValue(formTables, "CDR_Inf_Interview", "Mem8aNote")
        txtMem8bNote.setValue(formTables, "CDR_Inf_Interview", "Mem8bNote")
        cmbOrient1.setValue(formTables, "CDR_Inf_Interview", "Orient1")
        cmbOrient2.setValue(formTables, "CDR_Inf_Interview", "Orient2")
        cmbOrient3.setValue(formTables, "CDR_Inf_Interview", "Orient3")
        cmbOrient4.setValue(formTables, "CDR_Inf_Interview", "Orient4")
        cmbOrient5.setValue(formTables, "CDR_Inf_Interview", "Orient5")
        cmbOrient6.setValue(formTables, "CDR_Inf_Interview", "Orient6")
        cmbOrient7.setValue(formTables, "CDR_Inf_Interview", "Orient7")
        cmbOrient8.setValue(formTables, "CDR_Inf_Interview", "Orient8")
        cmbJudge1.setValue(formTables, "CDR_Inf_Interview", "Judge1")
        cmbJudge2.setValue(formTables, "CDR_Inf_Interview", "Judge2")
        cmbJudge3.setValue(formTables, "CDR_Inf_Interview", "Judge3")
        cmbJudge4.setValue(formTables, "CDR_Inf_Interview", "Judge4")
        cmbJudge4a.setValue(formTables, "CDR_Inf_Interview", "Judge4a")
        cmbComm1.setValue(formTables, "CDR_Inf_Interview", "Comm1")
        cmbComm1a.setValue(formTables, "CDR_Inf_Interview", "Comm1a")
        txtComm1bNote.setValue(formTables, "CDR_Inf_Interview", "Comm1b")
        cmbComm2.setValue(formTables, "CDR_Inf_Interview", "Comm2")
        cmbComm3.setValue(formTables, "CDR_Inf_Interview", "Comm3")
        txtComm3aNote.setValue(formTables, "CDR_Inf_Interview", "Comm3a")
        cmbHome1.setValue(formTables, "CDR_Inf_Interview", "Home1")
        cmbHome1a.setValue(formTables, "CDR_Inf_Interview", "Home1a")
        cmbHome2.setValue(formTables, "CDR_Inf_Interview", "Home2")
        cmbHome3.setValue(formTables, "CDR_Inf_Interview", "Home3")
        cmbHome4.setValue(formTables, "CDR_Inf_Interview", "Home4")
        cmbHome4a.setValue(formTables, "CDR_Inf_Interview", "Home4a")
        cmbHome5.setValue(formTables, "CDR_Inf_Interview", "Home5")
        cmbHome6.setValue(formTables, "CDR_Inf_Interview", "Home6")
        txtHome6Note.setValue(formTables, "CDR_Inf_Interview", "Home6a")
        cmbHome7.setValue(formTables, "CDR_Inf_Interview", "Home7")
        cmbHome7a.setValue(formTables, "CDR_Inf_Interview", "Home7a")
        cmbHome8.setValue(formTables, "CDR_Inf_Interview", "Home8")
        cmbHome8a.setValue(formTables, "CDR_Inf_Interview", "Home8a")
        cmbPers1.setValue(formTables, "CDR_Inf_Interview", "Pers1")
        cmbPers1a.setValue(formTables, "CDR_Inf_Interview", "Pers1a")
        txtPers1b.setValue(formTables, "CDR_Inf_Interview", "Pers1b")
        cmbPers2.setValue(formTables, "CDR_Inf_Interview", "Pers2")
        cmbPers2a.setValue(formTables, "CDR_Inf_Interview", "Pers2a")
        txtPers2b.setValue(formTables, "CDR_Inf_Interview", "Pers2b")
        cmbPers3.setValue(formTables, "CDR_Inf_Interview", "Pers3")
        cmbPers3a.setValue(formTables, "CDR_Inf_Interview", "Pers3a")
        txtPers3b.setValue(formTables, "CDR_Inf_Interview", "Pers3b")
        cmbPers4.setValue(formTables, "CDR_Inf_Interview", "Pers4")
        cmbPers4a.setValue(formTables, "CDR_Inf_Interview", "Pers4a")
        txtPers4b.setValue(formTables, "CDR_Inf_Interview", "Pers4b")
    End Sub
    Private Sub enableInputFields(ByVal bool As Boolean)
        cmbInfSource.Enabled = bool
        txtInfName.Enabled = bool
        cmbRelation.Enabled = bool
        cmbConfLevel.Enabled = bool
        dtInfMoYrBirth.Enabled = bool
        cmbInfSex.Enabled = bool
        cmbInfCommProbs.Enabled = bool
        cmbInfComProbSev.Enabled = bool
        txtInfCommProbNote.Enabled = bool
        cmbRace.Enabled = bool
        txtRaceNote.Enabled = bool
        intYrsEd.Enabled = bool
        cmbInfLiveWithSub.Enabled = bool
        cmbFreqVisitsPerson.Enabled = bool
        cmbFreqVisitsPhone.Enabled = bool
        cmbReliability.Enabled = bool
        txtInterviewNotes.makeReadOnly(Not bool)
        cmbRelWDem.Enabled = bool
        intRelWDemNum.Enabled = bool
        intFullSib.Enabled = bool
        intFullSibWDem.Enabled = bool
        intChildNum.Enabled = bool
        intChildNumWDem.Enabled = bool
        intOthBloodRelWDemNum.Enabled = bool
        cmbVisNormWOLenses.Enabled = bool
        cmbWearCorrLenses.Enabled = bool
        cmbVisNormWLenses.Enabled = bool
        cmbHearNormWOAids.Enabled = bool
        cmbWearHearAids.Enabled = bool
        cmbMem1.Enabled = bool
        cmbMem1Freq.Enabled = bool
        cmbMem1a.Enabled = bool
        cmbMem1aFreq.Enabled = bool
        cmbMem2.Enabled = bool
        cmbMem2Freq.Enabled = bool
        cmbMem3.Enabled = bool
        cmbMem3Freq.Enabled = bool
        cmbMem4.Enabled = bool
        cmbMem4Freq.Enabled = bool
        cmbMem4a.Enabled = bool
        cmbMem4aFreq.Enabled = bool
        txtMem4aNote.makeReadOnly(Not bool)
        cmbMem5.Enabled = bool
        cmbMem5Freq.Enabled = bool
        cmbMem6.Enabled = bool
        cmbMem6Freq.Enabled = bool
        cmbMem7.Enabled = bool
        cmbMem7Freq.Enabled = bool
        txtMem8aNote.makeReadOnly(Not bool)
        txtMem8bNote.makeReadOnly(Not bool)
        cmbOrient1.Enabled = bool
        cmbOrient2.Enabled = bool
        cmbOrient3.Enabled = bool
        cmbOrient4.Enabled = bool
        cmbOrient5.Enabled = bool
        cmbOrient6.Enabled = bool
        cmbOrient7.Enabled = bool
        cmbOrient8.Enabled = bool
        cmbJudge1.Enabled = bool
        cmbJudge2.Enabled = bool
        cmbJudge3.Enabled = bool
        cmbJudge4.Enabled = bool
        cmbJudge4a.Enabled = bool
        cmbComm1.Enabled = bool
        cmbComm1a.Enabled = bool
        txtComm1bNote.makeReadOnly(Not bool)
        cmbComm2.Enabled = bool
        cmbComm2.Enabled = bool
        cmbComm3.Enabled = bool
        txtComm3aNote.makeReadOnly(Not bool)
        cmbHome1.Enabled = bool
        cmbHome1a.Enabled = bool
        cmbHome2.Enabled = bool
        cmbHome3.Enabled = bool
        cmbHome4.Enabled = bool
        cmbHome4a.Enabled = bool
        cmbHome5.Enabled = bool
        cmbHome6.Enabled = bool
        txtHome6Note.makeReadOnly(Not bool)
        cmbHome7.Enabled = bool
        cmbHome7a.Enabled = bool
        cmbHome8.Enabled = bool
        cmbHome8a.Enabled = bool
        cmbPers1.Enabled = bool
        cmbPers1a.Enabled = bool
        txtPers1b.Enabled = bool
        cmbPers2.Enabled = bool
        cmbPers2a.Enabled = bool
        txtPers2b.Enabled = bool
        cmbPers3.Enabled = bool
        cmbPers3a.Enabled = bool
        txtPers3b.Enabled = bool
        cmbPers4.Enabled = bool
        cmbPers4a.Enabled = bool
        txtPers4b.Enabled = bool
    End Sub

    Private Sub loadDemFamHxData(ByVal tableName As String)
        If formTables.Tables().Contains(tableName) Then
            formTables.Tables().Remove(tableName)
        End If
        If Database.ExistingRecordCheck(tableName, "SubNum = " & WarehouseShell.SubNum) Then
            formTables.Tables.Add(Database.ReturnTable(tableName, , "SubNum = " & WarehouseShell.SubNum))
            cmbRelWDem.setValue(formTables, tableName, "RelWDem")
            intRelWDemNum.setValue(formTables, tableName, "RelWDemNum")
            intFullSib.setValue(formTables, tableName, "FullSib")
            intFullSibWDem.setValue(formTables, tableName, "FullSibWDem")
            intChildNum.setValue(formTables, tableName, "ChildNum")
            intChildNumWDem.setValue(formTables, tableName, "ChildNumWDem")
            intOthBloodRelWDemNum.setValue(formTables, tableName, "OthBloodRelWDemNum")
        End If
    End Sub
    Private Sub saveDemFamHxData(ByVal tableName As String)
        'Determine if this is an insert or an update, and set action accordingly (1 = insert, 2 = update)
        Dim action As Integer = IIf(Database.ExistingRecordCheck(tableName, "SubNum = " & WarehouseShell.SubNum), 2, 1)

        'Define stored procedure parameters (same parameters for insert and update)
        Dim cmdText As String = "Exec modDementiaFamilyHxRecord @Action = " & action &
            ", @SubNum = " & WarehouseShell.SubNum &
            ", @RelWDem = " & cmbRelWDem.getSQLValue() &
            ", @RelWDemNum = " & intRelWDemNum.getSQLValue() &
            ", @FullSib = " & intFullSib.getSQLValue() &
            ", @FullSibWDem = " & intFullSibWDem.getSQLValue() &
            ", @ChildNum = " & intChildNum.getSQLValue() &
            ", @ChildNumWDem = " & intChildNumWDem.getSQLValue() &
            ", @OthBloodRelWDemNum = " & intOthBloodRelWDemNum.getSQLValue() &
            ", @LastModBy = '" & WarehouseShell.userName & "';"

        Dim cmd As New SqlCommand(cmdText, WarehouseShell.conn)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub loadVisHearData(ByVal tableName As String)
        If formTables.Tables().Contains(tableName) Then
            formTables.Tables().Remove(tableName)
        End If
        If Database.ExistingRecordCheck(tableName, "SubNum = " & WarehouseShell.SubNum) Then
            formTables.Tables.Add(Database.ReturnTable(tableName, , "SubNum = " & WarehouseShell.SubNum))
            cmbVisNormWOLenses.setValue(formTables, tableName, "VisNormWOLenses")
            cmbWearCorrLenses.setValue(formTables, tableName, "WearCorrLenses")
            cmbVisNormWLenses.setValue(formTables, tableName, "VisNormWLenses")
            cmbHearNormWOAids.setValue(formTables, tableName, "HearNormWOAids")
            cmbWearHearAids.setValue(formTables, tableName, "WearHearAids")
        End If
    End Sub
    Private Sub saveVisHearData(ByVal tableName As String)
        'Determine if this is an insert or an update, and set action accordingly (1 = insert, 2 = update)
        Dim action As Integer = IIf(Database.ExistingRecordCheck(tableName, "SubNum = " & WarehouseShell.SubNum), 2, 1)

        'Define stored procedure parameters (same parameters for insert and update)
        Dim cmdText As String = "Exec modVisionAndHearingRecord @Action = " & action &
            ", @SubNum = " & WarehouseShell.SubNum &
            ", @VisNormWOLenses = " & cmbVisNormWOLenses.getSQLValue() &
            ", @WearCorrLenses = " & cmbWearCorrLenses.getSQLValue() &
            ", @VisNormWLenses = " & cmbVisNormWLenses.getSQLValue() &
            ", @HearNormWOAids = " & cmbHearNormWOAids.getSQLValue() &
            ", @WearHearAids = " & cmbWearHearAids.getSQLValue() &
            ", @LastModBy = '" & WarehouseShell.userName & "';"

        Dim cmd As New SqlCommand(cmdText, WarehouseShell.conn)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub btnCDR_Inf_Click(sender As Object, e As EventArgs) Handles btnCDRInfTop.Click, btnCDRInfBottom.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_PMCR_CDR_INF", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                btnCDRInfTop.Text = "Save Changes"
                btnCDRInfBottom.Text = btnCDRInfTop.Text
                enableInputFields(True)
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If User.PermissionCheck("WA_PMCR_CDR_INF", "Modify") Then
                loadBaseForm()
                setDefaultValues()
                lblNoRecord.Visible = False
                btnCDRInfTop.Text = "Save New Record"
                btnCDRInfBottom.Text = "Save New Record"
                enableInputFields(True)
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
            End If
        Else 'By default, user is attempting to Insert or Edit a record. Run preSaveValidation.
            If preSaveValidation() Then 'If preSaveValidation returns true, take Insert or Update actions.
                Dim action As Integer = IIf(WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert, 1, 2)
                'Same parameters for Insert or Update SP's, so define here
                Dim cmdText As String = "Exec modCDR_Inf_Interview @Action = " & action &
                    ", @SubNum = " & WarehouseShell.SubNum &
                    ", @Visit = 888" & 'hardcoded visit since this is postmortem only
                    ", @InfSource = " & cmbInfSource.getSQLValue() &
                    ", @InfName = " & txtInfName.getSQLValue() &
                    ", @InfRelation = " & cmbRelation.getSQLValue() &
                    ", @ConfLevel = " & cmbConfLevel.getSQLValue() &
                    ", @InfMoYrBirth = " & dtInfMoYrBirth.getSQLValue() &
                    ", @InfSex = " & cmbInfSex.getSQLValue() &
                    ", @InfCommProbs = " & cmbInfCommProbs.getSQLValue() &
                    ", @InfCommProbSev = " & cmbInfComProbSev.getSQLValue() &
                    ", @InfCommProbNote = " & txtInfCommProbNote.getSQLValue() &
                    ", @InfRace = " & cmbRace.getSQLValue() &
                    ", @InfRaceNote = " & txtRaceNote.getSQLValue() &
                    ", @InfYrsEd = " & intYrsEd.getSQLValue() &
                    ", @InfLiveWSub = " & cmbInfLiveWithSub.getSQLValue() &
                    ", @InfVisitPers = " & cmbFreqVisitsPerson.getSQLValue() &
                    ", @InfVisitPhone = " & cmbFreqVisitsPhone.getSQLValue() &
                    ", @InfReliability = " & cmbReliability.getSQLValue() &
                    ", @InfIntNotes = " & txtInterviewNotes.getSQLValue() &
                    ", @Mem1 = " & cmbMem1.getSQLValue() &
                    ", @Mem1Freq = " & cmbMem1Freq.getSQLValue() &
                    ", @Mem1a = " & cmbMem1a.getSQLValue() &
                    ", @Mem1aFreq = " & cmbMem1aFreq.getSQLValue() &
                    ", @Mem2 = " & cmbMem2.getSQLValue() &
                    ", @Mem2Freq = " & cmbMem2Freq.getSQLValue() &
                    ", @Mem3 = " & cmbMem3.getSQLValue() &
                    ", @Mem3Freq = " & cmbMem3Freq.getSQLValue() &
                    ", @Mem4 = " & cmbMem4.getSQLValue() &
                    ", @Mem4Freq = " & cmbMem4Freq.getSQLValue() &
                    ", @Mem4a = " & cmbMem4a.getSQLValue() &
                    ", @Mem4aFreq = " & cmbMem4aFreq.getSQLValue() &
                    ", @Mem4aNote = " & txtMem4aNote.getSQLValue() &
                    ", @Mem5 = " & cmbMem5.getSQLValue() &
                    ", @Mem5Freq = " & cmbMem5Freq.getSQLValue() &
                    ", @Mem6 = " & cmbMem6.getSQLValue() &
                    ", @Mem6Freq = " & cmbMem6Freq.getSQLValue() &
                    ", @Mem7 = " & cmbMem7.getSQLValue() &
                    ", @Mem7Freq = " & cmbMem7Freq.getSQLValue() &
                    ", @Mem8aNote = " & txtMem8aNote.getSQLValue() &
                    ", @Mem8bNote = " & txtMem8bNote.getSQLValue() &
                    ", @Orient1 = " & cmbOrient1.getSQLValue() &
                    ", @Orient2 = " & cmbOrient2.getSQLValue() &
                    ", @Orient3 = " & cmbOrient3.getSQLValue() &
                    ", @Orient4 = " & cmbOrient4.getSQLValue() &
                    ", @Orient5 = " & cmbOrient5.getSQLValue() &
                    ", @Orient6 = " & cmbOrient6.getSQLValue() &
                    ", @Orient7 = " & cmbOrient7.getSQLValue() &
                    ", @Orient8 = " & cmbOrient8.getSQLValue() &
                    ", @Judge1 = " & cmbJudge1.getSQLValue() &
                    ", @Judge2 = " & cmbJudge2.getSQLValue() &
                    ", @Judge3 = " & cmbJudge3.getSQLValue() &
                    ", @Judge4 = " & cmbJudge4.getSQLValue() &
                    ", @Judge4a = " & cmbJudge4a.getSQLValue() &
                    ", @Comm1 = " & cmbComm1.getSQLValue() &
                    ", @Comm1a = " & cmbComm1a.getSQLValue() &
                    ", @Comm1b = " & txtComm1bNote.getSQLValue() &
                    ", @Comm2 = " & cmbComm2.getSQLValue() &
                    ", @Comm3 = " & cmbComm3.getSQLValue() &
                    ", @Comm3a = " & txtComm3aNote.getSQLValue() &
                    ", @Home1 = " & cmbHome1.getSQLValue() &
                    ", @Home1a = " & cmbHome1a.getSQLValue() &
                    ", @Home2 = " & cmbHome2.getSQLValue() &
                    ", @Home3 = " & cmbHome3.getSQLValue() &
                    ", @Home4 = " & cmbHome4.getSQLValue() &
                    ", @Home4a = " & cmbHome4a.getSQLValue() &
                    ", @Home5 = " & cmbHome5.getSQLValue() &
                    ", @Home6 = " & cmbHome6.getSQLValue() &
                    ", @Home6a = " & txtHome6Note.getSQLValue() &
                    ", @Home7 = " & cmbHome7.getSQLValue() &
                    ", @Home7a = " & cmbHome7a.getSQLValue() &
                    ", @Home8 = " & cmbHome8.getSQLValue() &
                    ", @Home8a = " & cmbHome8a.getSQLValue() &
                    ", @Pers1 = " & cmbPers1.getSQLValue() &
                    ", @Pers1a = " & cmbPers1a.getSQLValue() &
                    ", @Pers1b = " & txtPers1b.getSQLValue() &
                    ", @Pers2 = " & cmbPers2.getSQLValue() &
                    ", @Pers2a = " & cmbPers2a.getSQLValue() &
                    ", @Pers2b = " & txtPers2b.getSQLValue() &
                    ", @Pers3 = " & cmbPers3.getSQLValue() &
                    ", @Pers3a = " & cmbPers3a.getSQLValue() &
                    ", @Pers3b = " & txtPers3b.getSQLValue() &
                    ", @Pers4 = " & cmbPers4.getSQLValue() &
                    ", @Pers4a = " & cmbPers4a.getSQLValue() &
                    ", @Pers4b = " & txtPers4b.getSQLValue() &
                    ", @LastModBy = '" & WarehouseShell.userName & "';"
                Dim cmd As New SqlCommand(cmdText, WarehouseShell.conn)
                Try
                    cmd.ExecuteNonQuery()
                    saveDemFamHxData("DementiaFamilyHx")
                    saveVisHearData("VisionAndHearing")
                    MsgBox("Save successful", MsgBoxStyle.OkOnly)
                    enableInputFields(False)
                    btnCDRInfTop.Text = "Edit Record"
                    btnCDRInfBottom.Text = "Edit Record"
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

    'Imported IForm Methods
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
    Public Sub Parent1(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        'TODO: Save work action
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