Public Class WA_PMCR_Dead2
    Implements IFormMethods
    Private formTables As New DataSet

    Private Sub WA_PMCR_Dead2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Database.ExistingRecordCheck("PMCR_DEAD2", "SubNum = " & WarehouseShell.SubNum) Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            loadBaseForm()
            loadExistingData()
            btnDEAD2Top.Text = "Edit Record"
            btnDEAD2Bottom.Text = btnDEAD2Top.Text
        Else 'If it doesn't exist, change mode to Undefined and show user banner
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            lblNoRecord.Visible = True
            btnDEAD2Top.Text = "Add New Record"
            btnDEAD2Bottom.Text = btnDEAD2Top.Text
        End If
        enableInputFields(False)
    End Sub
    Private Sub loadBaseForm()
        WarehouseShell.highlightSelectedNode("WA_PMCR_tabDEAD2")
        'Grab any required comboLookUp tables and assign them to their appropriate boxes
        formTables.Tables.Add(Database.ReturnTable("lkpYNUnk129"))
        cmbNLDurYrBefDeath.assignLookup(formTables, "lkpYNUnk129")
    End Sub
    Private Sub setDefaultValues()
        cmbNLDurYrBefDeath.SelectedValue = 9
    End Sub
    Private Sub loadExistingData()
        'Grab the individual record, based on RecordID, and assign values to their appropriate fields
        formTables.Tables.Add(Database.ReturnTable("PMCR_DEAD2", , "SubNum = " & WarehouseShell.SubNum))
        txtECTSpec1.setValue(formTables, "PMCR_DEAD2", "ECTSpec1")
        txtECTSpec2.setValue(formTables, "PMCR_DEAD2", "ECTSpec2")
        txtECTSpec3.setValue(formTables, "PMCR_DEAD2", "ECTSpec3")
        chkECT26.setValue(formTables, "PMCR_DEAD2", "ECTLess26")
        chkECT2645.setValue(formTables, "PMCR_DEAD2", "ECT2645")
        chkECT4655.setValue(formTables, "PMCR_DEAD2", "ECT4655")
        chkECT5665.setValue(formTables, "PMCR_DEAD2", "ECT5665")
        chkECT6675.setValue(formTables, "PMCR_DEAD2", "ECT6675")
        chkECT75.setValue(formTables, "PMCR_DEAD2", "ECTMore75")
        txtPsychosurgSpec1.setValue(formTables, "PMCR_DEAD2", "PsychoSurgSpec1")
        txtPsychoSurgSpec2.setValue(formTables, "PMCR_DEAD2", "PsychoSurgSpec2")
        txtPsychosurgSpec3.setValue(formTables, "PMCR_DEAD2", "PsychoSurgSpec3")
        chkPsychoSurg26.setValue(formTables, "PMCR_DEAD2", "PsychoSurgLess26")
        chkPsychoSurg2645.setValue(formTables, "PMCR_DEAD2", "PsychoSurg2645")
        chkPsychoSurg4655.setValue(formTables, "PMCR_DEAD2", "PsychoSurg4655")
        chkPsychoSurg5665.setValue(formTables, "PMCR_DEAD2", "PsychoSurg5665")
        chkPsychoSurg6675.setValue(formTables, "PMCR_DEAD2", "PsychoSurg6675")
        chkPsychoSurg75.setValue(formTables, "PMCR_DEAD2", "PsychoSurgMore75")
        txtLithiumSpec1.setValue(formTables, "PMCR_DEAD2", "LithiumSpec1")
        txtLithiumSpec2.setValue(formTables, "PMCR_DEAD2", "LithiumSpec2")
        txtLithiumSpec3.setValue(formTables, "PMCR_DEAD2", "LithiumSpec3")
        chkLithium26.setValue(formTables, "PMCR_DEAD2", "LithiumLess26")
        chkLithium2645.setValue(formTables, "PMCR_DEAD2", "Lithium2645")
        chkLithium4655.setValue(formTables, "PMCR_DEAD2", "Lithium4655")
        chkLithium5665.setValue(formTables, "PMCR_DEAD2", "Lithium5665")
        chkLithium6675.setValue(formTables, "PMCR_DEAD2", "Lithium6675")
        chkLithium75.setValue(formTables, "PMCR_DEAD2", "LithiumMore75")
        txtHeteroSpec1.setValue(formTables, "PMCR_DEAD2", "HeteroSpec1")
        txtHeteroSpec2.setValue(formTables, "PMCR_DEAD2", "HeteroSpec2")
        txtHeteroSpec3.setValue(formTables, "PMCR_DEAD2", "HeteroSpec3")
        chkHetero26.setValue(formTables, "PMCR_DEAD2", "HeteroLess26")
        chkHetero2645.setValue(formTables, "PMCR_DEAD2", "Hetero2645")
        chkHetero4655.setValue(formTables, "PMCR_DEAD2", "Hetero4655")
        chkHetero5665.setValue(formTables, "PMCR_DEAD2", "Hetero5665")
        chkHetero6675.setValue(formTables, "PMCR_DEAD2", "Hetero6675")
        chkHetero75.setValue(formTables, "PMCR_DEAD2", "HeteroMore75")
        txtMAOISpec1.setValue(formTables, "PMCR_DEAD2", "MAOISpec1")
        txtMAOISpec2.setValue(formTables, "PMCR_DEAD2", "MAOISpec2")
        txtMAOISpec3.setValue(formTables, "PMCR_DEAD2", "MAOISpec3")
        chkMAOI26.setValue(formTables, "PMCR_DEAD2", "MAOILess26")
        chkMAOI2645.setValue(formTables, "PMCR_DEAD2", "MAOI2645")
        chkMAOI4655.setValue(formTables, "PMCR_DEAD2", "MAOI4655")
        chkMAOI5665.setValue(formTables, "PMCR_DEAD2", "MAOI5665")
        chkMAOI6675.setValue(formTables, "PMCR_DEAD2", "MAOI6675")
        chkMAOI75.setValue(formTables, "PMCR_DEAD2", "MAOIMore75")
        txtAnticholSpec1.setValue(formTables, "PMCR_DEAD2", "AnticholSpec1")
        txtAnticholSpec2.setValue(formTables, "PMCR_DEAD2", "AnticholSpec2")
        txtAnticholSpec3.setValue(formTables, "PMCR_DEAD2", "AnticholSpec3")
        chkAntichol26.setValue(formTables, "PMCR_DEAD2", "AnticholLess26")
        chkAntichol2645.setValue(formTables, "PMCR_DEAD2", "Antichol2645")
        chkAntichol4655.setValue(formTables, "PMCR_DEAD2", "Antichol4655")
        chkAntichol5665.setValue(formTables, "PMCR_DEAD2", "Antichol5665")
        chkAntichol6675.setValue(formTables, "PMCR_DEAD2", "Antichol6675")
        chkAntichol75.setValue(formTables, "PMCR_DEAD2", "AnticholMore75")
        txtSedativeSpec1.setValue(formTables, "PMCR_DEAD2", "SedativeSpec1")
        txtSedativeSpec2.setValue(formTables, "PMCR_DEAD2", "SedativeSpec2")
        txtSedativeSpec3.setValue(formTables, "PMCR_DEAD2", "SedativeSpec3")
        chkSedative26.setValue(formTables, "PMCR_DEAD2", "SedativeLess26")
        chkSedative2645.setValue(formTables, "PMCR_DEAD2", "Sedative2645")
        chkSedative4655.setValue(formTables, "PMCR_DEAD2", "Sedative4655")
        chkSedative5665.setValue(formTables, "PMCR_DEAD2", "Sedative5665")
        chkSedative6675.setValue(formTables, "PMCR_DEAD2", "Sedative6675")
        chkSedative75.setValue(formTables, "PMCR_DEAD2", "SedativeMore75")
        txtOtherSpec1.setValue(formTables, "PMCR_DEAD2", "OtherSomTreatSpec1")
        txtOtherSpec2.setValue(formTables, "PMCR_DEAD2", "OtherSomTreatSpec2")
        txtOtherSpec3.setValue(formTables, "PMCR_DEAD2", "OtherSomTreatSpec3")
        chkOther26.setValue(formTables, "PMCR_DEAD2", "OtherSomTreatLess26")
        chkOther2645.setValue(formTables, "PMCR_DEAD2", "OtherSomTreat2645")
        chkOther4655.setValue(formTables, "PMCR_DEAD2", "OtherSomTreat4655")
        chkOther5665.setValue(formTables, "PMCR_DEAD2", "OtherSomTreat5665")
        chkOther6675.setValue(formTables, "PMCR_DEAD2", "OtherSomTreat6675")
        chkOther75.setValue(formTables, "PMCR_DEAD2", "OtherSomTreatMore75")
        txtNeuroLowPotSpec1.setValue(formTables, "PMCR_DEAD2", "NeuroLowPotSpec1")
        txtNeuroLowPotSpec2.setValue(formTables, "PMCR_DEAD2", "NeuroLowPotSpec2")
        txtNeuroLowPotSpec3.setValue(formTables, "PMCR_DEAD2", "NeuroLowPotSpec3")
        chkNeuroLowPot26.setValue(formTables, "PMCR_DEAD2", "NeuroLowPotLess26")
        chkNeuroLowPot2645.setValue(formTables, "PMCR_DEAD2", "NeuroLowPot2645")
        chkNeuroLowPot4655.setValue(formTables, "PMCR_DEAD2", "NeuroLowPot4655")
        chkNeuroLowPot5665.setValue(formTables, "PMCR_DEAD2", "NeuroLowPot5665")
        chkNeuroLowPot6675.setValue(formTables, "PMCR_DEAD2", "NeuroLowPot6675")
        chkNeuroLowPot75.setValue(formTables, "PMCR_DEAD2", "NeuroLowPotMore75")
        txtNeuroHighPotSpec1.setValue(formTables, "PMCR_DEAD2", "NeuroHighPotSpec1")
        txtNeuroHighPotSpec2.setValue(formTables, "PMCR_DEAD2", "NeuroHighPotSpec2")
        txtNeuroHighPotSpec3.setValue(formTables, "PMCR_DEAD2", "NeuroHighPotSpec3")
        chkNeuroHighPot26.setValue(formTables, "PMCR_DEAD2", "NeuroHighPotLess26")
        chkNeuroHighPot2645.setValue(formTables, "PMCR_DEAD2", "NeuroHighPot2645")
        chkNeuroHighPot4655.setValue(formTables, "PMCR_DEAD2", "NeuroHighPot4655")
        chkNeuroHighPot5665.setValue(formTables, "PMCR_DEAD2", "NeuroHighPot5665")
        chkNeuroHighPot6675.setValue(formTables, "PMCR_DEAD2", "NeuroHighPot6675")
        chkNeuroHighPot75.setValue(formTables, "PMCR_DEAD2", "NeuroHighPotMore75")
        txtNeuroAtypSpec1.setValue(formTables, "PMCR_DEAD2", "NeuroAtypSpec1")
        txtNeuroAtypSpec2.setValue(formTables, "PMCR_DEAD2", "NeuroAtypSpec2")
        txtNeuroAtypSpec3.setValue(formTables, "PMCR_DEAD2", "NeuroAtypSpec3")
        chkNeuroAtyp26.setValue(formTables, "PMCR_DEAD2", "NeuroAtypLess26")
        chkNeuroAtyp2645.setValue(formTables, "PMCR_DEAD2", "NeuroAtyp2645")
        chkNeuroAtyp4655.setValue(formTables, "PMCR_DEAD2", "NeuroAtyp4655")
        chkNeuroAtyp5665.setValue(formTables, "PMCR_DEAD2", "NeuroAtyp5665")
        chkNeuroAtyp6675.setValue(formTables, "PMCR_DEAD2", "NeuroAtyp6675")
        chkNeuroAtyp75.setValue(formTables, "PMCR_DEAD2", "NeuroAtypMore75")
        intTotalDurNLExp.setValue(formTables, "PMCR_DEAD2", "TotDurNLExposure")
        cmbNLDurYrBefDeath.setValue(formTables, "PMCR_DEAD2", "NlYrBefDeath")
        chkDrinkingProb26.setValue(formTables, "PMCR_DEAD2", "DrinkingProbLess26")
        chkDrinkingProb2645.setValue(formTables, "PMCR_DEAD2", "DrinkingProb2645")
        chkDrinkingProb4655.setValue(formTables, "PMCR_DEAD2", "DrinkingProb4655")
        chkDrinkingProb5665.setValue(formTables, "PMCR_DEAD2", "DrinkingProb5665")
        chkDrinkingProb6675.setValue(formTables, "PMCR_DEAD2", "DrinkingProb6675")
        chkDrinkingProb75.setValue(formTables, "PMCR_DEAD2", "DrinkingProbMore75")
        chkExcessCons26.setValue(formTables, "PMCR_DEAD2", "ExcesConsumLess26")
        chkExcessCons2645.setValue(formTables, "PMCR_DEAD2", "ExcesConsum2645")
        chkExcessCons4655.setValue(formTables, "PMCR_DEAD2", "ExcesConsum4655")
        chkExcessCons5665.setValue(formTables, "PMCR_DEAD2", "ExcesConsum5665")
        chkExcessCons6675.setValue(formTables, "PMCR_DEAD2", "ExcesConsum6675")
        chkExcessCons75.setValue(formTables, "PMCR_DEAD2", "ExcesConsumMore75")
        chkAlcUseInt26.setValue(formTables, "PMCR_DEAD2", "AlcIntFunctLess26")
        chkAlcUseInt2645.setValue(formTables, "PMCR_DEAD2", "AlcIntFunct2645")
        chkAlcUseInt4655.setValue(formTables, "PMCR_DEAD2", "AlcIntFunct4655")
        chkAlcUseInt5665.setValue(formTables, "PMCR_DEAD2", "AlcIntFunct5665")
        chkAlcUseInt6675.setValue(formTables, "PMCR_DEAD2", "AlcIntFunct6675")
        chkAlcUseInt75.setValue(formTables, "PMCR_DEAD2", "AlcIntFunctMore75")
        chkContUse26.setValue(formTables, "PMCR_DEAD2", "AlcContUseLess26")
        chkContUse2645.setValue(formTables, "PMCR_DEAD2", "AlcContUse2645")
        chkContUse4655.setValue(formTables, "PMCR_DEAD2", "AlcContUse4655")
        chkContUse5665.setValue(formTables, "PMCR_DEAD2", "AlcContUse5665")
        chkContUse6675.setValue(formTables, "PMCR_DEAD2", "AlcContUse6675")
        chkContUse75.setValue(formTables, "PMCR_DEAD2", "AlcContUseMore75")
        chkEviTol26.setValue(formTables, "PMCR_DEAD2", "EvidOfTolLess26")
        chkEviTol2645.setValue(formTables, "PMCR_DEAD2", "EvidOfTol2645")
        chkEviTol4655.setValue(formTables, "PMCR_DEAD2", "EvidOfTol4655")
        chkEviTol5665.setValue(formTables, "PMCR_DEAD2", "EvidOfTol5665")
        chkEviTol6675.setValue(formTables, "PMCR_DEAD2", "EvidOfTol6675")
        chkEviTol75.setValue(formTables, "PMCR_DEAD2", "EvidOfTolMore75")
        chkMedComp26.setValue(formTables, "PMCR_DEAD2", "AlcMedCompLess26")
        chkMedComp2645.setValue(formTables, "PMCR_DEAD2", "AlcMedComp2645")
        chkMedComp4655.setValue(formTables, "PMCR_DEAD2", "AlcMedComp4655")
        chkMedComp5665.setValue(formTables, "PMCR_DEAD2", "AlcMedComp5665")
        chkMedComp6675.setValue(formTables, "PMCR_DEAD2", "AlcMedComp6675")
        chkMedComp75.setValue(formTables, "PMCR_DEAD2", "AlcMedCompMore75")
        chkOtherEvi26.setValue(formTables, "PMCR_DEAD2", "AlcOthEvidLess26")
        chkOtherEvi2645.setValue(formTables, "PMCR_DEAD2", "AlcOthEvid2645")
        chkOtherEvi4655.setValue(formTables, "PMCR_DEAD2", "AlcOthEvid4655")
        chkOtherEvi5665.setValue(formTables, "PMCR_DEAD2", "AlcOthEvid5665")
        chkOtherEvi6675.setValue(formTables, "PMCR_DEAD2", "AlcOthEvid6675")
        chkOtherEvi75.setValue(formTables, "PMCR_DEAD2", "AlcOthEvidMore75")
        txtAlcAbuseNotes.setValue(formTables, "PMCR_DEAD2", "AlcUseNotes")
        chkCannabis26.setValue(formTables, "PMCR_DEAD2", "CannabisLess26")
        chkCannabis2645.setValue(formTables, "PMCR_DEAD2", "Cannabis2645")
        chkCannabis4655.setValue(formTables, "PMCR_DEAD2", "Cannabis4655")
        chkCannabis5665.setValue(formTables, "PMCR_DEAD2", "Cannabis5665")
        chkCannabis6675.setValue(formTables, "PMCR_DEAD2", "Cannabis6675")
        chkCannabis75.setValue(formTables, "PMCR_DEAD2", "CannabisMore75")
        chkAmphet26.setValue(formTables, "PMCR_DEAD2", "AmphetLess26")
        chkAmphet2645.setValue(formTables, "PMCR_DEAD2", "Amphet2645")
        chkAmphet4655.setValue(formTables, "PMCR_DEAD2", "Amphet4655")
        chkAmphet5665.setValue(formTables, "PMCR_DEAD2", "Amphet5665")
        chkAmphet6675.setValue(formTables, "PMCR_DEAD2", "Amphet6675")
        chkAmphet75.setValue(formTables, "PMCR_DEAD2", "AmphetMore75")
        txtSedativesSpec.setValue(formTables, "PMCR_DEAD2", "SedativeDepSpec")
        chkSedatives26.setValue(formTables, "PMCR_DEAD2", "SedativeDepLess26")
        chkSedatives2645.setValue(formTables, "PMCR_DEAD2", "SedativeDep2645")
        chkSedatives4655.setValue(formTables, "PMCR_DEAD2", "SedativeDep4655")
        chkSedatives5665.setValue(formTables, "PMCR_DEAD2", "SedativeDep5665")
        chkSedatives6675.setValue(formTables, "PMCR_DEAD2", "SedativeDep6675")
        chkSedatives75.setValue(formTables, "PMCR_DEAD2", "SedativeDepMore75")
        chkCocaine26.setValue(formTables, "PMCR_DEAD2", "CocaineLess26")
        chkCocaine2645.setValue(formTables, "PMCR_DEAD2", "Cocaine2645")
        chkCocaine4655.setValue(formTables, "PMCR_DEAD2", "Cocaine4655")
        chkCocaine5665.setValue(formTables, "PMCR_DEAD2", "Cocaine5665")
        chkCocaine6675.setValue(formTables, "PMCR_DEAD2", "Cocaine6675")
        chkCocaine75.setValue(formTables, "PMCR_DEAD2", "CocaineMore75")
        txtOpiates.setValue(formTables, "PMCR_DEAD2", "OpiatesSpec")
        chkOpiates26.setValue(formTables, "PMCR_DEAD2", "OpiatesLess26")
        chkOpiates2645.setValue(formTables, "PMCR_DEAD2", "Opiates2645")
        chkOpiates4655.setValue(formTables, "PMCR_DEAD2", "Opiates4655")
        chkOpiates5665.setValue(formTables, "PMCR_DEAD2", "Opiates5665")
        chkOpiates6675.setValue(formTables, "PMCR_DEAD2", "Opiates6675")
        chkOpiates75.setValue(formTables, "PMCR_DEAD2", "OpiatesMore75")
        txtHallSpec.setValue(formTables, "PMCR_DEAD2", "HallucinogenSpec")
        chkHall26.setValue(formTables, "PMCR_DEAD2", "HallucinogenLess26")
        chkHall2645.setValue(formTables, "PMCR_DEAD2", "Hallucinogen2645")
        chkHall4655.setValue(formTables, "PMCR_DEAD2", "Hallucinogen4655")
        chkHall5665.setValue(formTables, "PMCR_DEAD2", "Hallucinogen5665")
        chkHall6675.setValue(formTables, "PMCR_DEAD2", "Hallucinogen6675")
        chkHall75.setValue(formTables, "PMCR_DEAD2", "HallucinogenMore75")
        txtOthDrugSpec.setValue(formTables, "PMCR_DEAD2", "OthDrugAbuseSpec")
        chkOthDrug26.setValue(formTables, "PMCR_DEAD2", "OthDrugAbuseLess26")
        chkOthDrug2645.setValue(formTables, "PMCR_DEAD2", "OthDrugAbuse2645")
        chkOthDrug4655.setValue(formTables, "PMCR_DEAD2", "OthDrugAbuse4655")
        chkOthDrug5665.setValue(formTables, "PMCR_DEAD2", "OthDrugAbuse5665")
        chkOthDrug6675.setValue(formTables, "PMCR_DEAD2", "OthDrugAbuse6675")
        chkOthDrug75.setValue(formTables, "PMCR_DEAD2", "OthDrugAbuseMore75")
        chkTobacco26.setValue(formTables, "PMCR_DEAD2", "TobaccoLess26")
        chkTobacco2645.setValue(formTables, "PMCR_DEAD2", "Tobacco2645")
        chkTobacco4655.setValue(formTables, "PMCR_DEAD2", "Tobacco4655")
        chkTobacco5665.setValue(formTables, "PMCR_DEAD2", "Tobacco5665")
        chkTobacco6675.setValue(formTables, "PMCR_DEAD2", "Tobacco6675")
        chkTobacco75.setValue(formTables, "PMCR_DEAD2", "TobaccoMore75")
        txtSubstanceAbuseNotes.setValue(formTables, "PMCR_DEAD2", "DrugAbuseNotes")
        chkPervDep26.setValue(formTables, "PMCR_DEAD2", "PervDepMoodLess26")
        chkPervDep2645.setValue(formTables, "PMCR_DEAD2", "PervDepMood2645")
        chkPervDep4655.setValue(formTables, "PMCR_DEAD2", "PervDepMood4655")
        chkPervDep5665.setValue(formTables, "PMCR_DEAD2", "PervDepMood5665")
        chkPervDep6675.setValue(formTables, "PMCR_DEAD2", "PervDepMood6675")
        chkPervDep75.setValue(formTables, "PMCR_DEAD2", "PervDepMoodMore75")
        chkLossInt26.setValue(formTables, "PMCR_DEAD2", "LossInterestLess26")
        chkLossInt2645.setValue(formTables, "PMCR_DEAD2", "LossInterest2645")
        chkLossInt4655.setValue(formTables, "PMCR_DEAD2", "LossInterest4655")
        chkLossInt5665.setValue(formTables, "PMCR_DEAD2", "LossInterest5665")
        chkLossInt6675.setValue(formTables, "PMCR_DEAD2", "LossInterest6675")
        chkLossInt75.setValue(formTables, "PMCR_DEAD2", "LossInterestMore75")
        chkDecApp26.setValue(formTables, "PMCR_DEAD2", "DecAppetiteLess26")
        chkDecApp2645.setValue(formTables, "PMCR_DEAD2", "DecAppetite2645")
        chkDecApp4655.setValue(formTables, "PMCR_DEAD2", "DecAppetite4655")
        chkDecApp5665.setValue(formTables, "PMCR_DEAD2", "DecAppetite5665")
        chkDecApp6675.setValue(formTables, "PMCR_DEAD2", "DecAppetite6675")
        chkDecApp75.setValue(formTables, "PMCR_DEAD2", "DecAppetiteMore75")
        chkIncApp26.setValue(formTables, "PMCR_DEAD2", "IncAppetiteLess26")
        chkIncApp2645.setValue(formTables, "PMCR_DEAD2", "IncAppetite2645")
        chkIncApp4655.setValue(formTables, "PMCR_DEAD2", "IncAppetite4655")
        chkIncApp5665.setValue(formTables, "PMCR_DEAD2", "IncAppetite5665")
        chkIncApp6675.setValue(formTables, "PMCR_DEAD2", "IncAppetite6675")
        chkIncApp75.setValue(formTables, "PMCR_DEAD2", "IncAppetiteMore75")
        chkInsom26.setValue(formTables, "PMCR_DEAD2", "InsomniaLess26")
        chkInsom2645.setValue(formTables, "PMCR_DEAD2", "Insomnia2645")
        chkInsom4655.setValue(formTables, "PMCR_DEAD2", "Insomnia4655")
        chkInsom5665.setValue(formTables, "PMCR_DEAD2", "Insomnia5665")
        chkInsom6675.setValue(formTables, "PMCR_DEAD2", "Insomnia6675")
        chkInsom75.setValue(formTables, "PMCR_DEAD2", "InsomniaMore75")
        chkHypersom26.setValue(formTables, "PMCR_DEAD2", "HypersomniaLess26")
        chkHypersom2645.setValue(formTables, "PMCR_DEAD2", "Hypersomnia2645")
        chkHypersom4655.setValue(formTables, "PMCR_DEAD2", "Hypersomnia4655")
        chkHypersom5665.setValue(formTables, "PMCR_DEAD2", "Hypersomnia5665")
        chkHypersom6675.setValue(formTables, "PMCR_DEAD2", "Hypersomnia6675")
        chkHypersom75.setValue(formTables, "PMCR_DEAD2", "HypersomniaMore75")
        chkFat26.setValue(formTables, "PMCR_DEAD2", "FatigueLess26")
        chkFat2645.setValue(formTables, "PMCR_DEAD2", "Fatigue2645")
        chkFat4655.setValue(formTables, "PMCR_DEAD2", "Fatigue4655")
        chkFat5665.setValue(formTables, "PMCR_DEAD2", "Fatigue5665")
        chkFat6675.setValue(formTables, "PMCR_DEAD2", "Fatigue6675")
        chkFat75.setValue(formTables, "PMCR_DEAD2", "FatigueMore75")
        chkPsychoRet26.setValue(formTables, "PMCR_DEAD2", "PsychoRetardLess26")
        chkPsychoRet2645.setValue(formTables, "PMCR_DEAD2", "PsychoRetard2645")
        chkPsychoRet4655.setValue(formTables, "PMCR_DEAD2", "PsychoRetard4655")
        chkPsychoRet5665.setValue(formTables, "PMCR_DEAD2", "PsychoRetard5665")
        chkPsychoRet6675.setValue(formTables, "PMCR_DEAD2", "PsychoRetard6675")
        chkPsychoRet75.setValue(formTables, "PMCR_DEAD2", "PsychoRetardMore75")
        chkPsychoAgi26.setValue(formTables, "PMCR_DEAD2", "PsychoAgiLess26")
        chkPsychoAgi2645.setValue(formTables, "PMCR_DEAD2", "PsychoAgi2645")
        chkPsychoAgi4655.setValue(formTables, "PMCR_DEAD2", "PsychoAgi4655")
        chkPsychoAgi5665.setValue(formTables, "PMCR_DEAD2", "PsychoAgi5665")
        chkPsychoAgi6675.setValue(formTables, "PMCR_DEAD2", "PsychoAgi6675")
        chkPsychoAgi75.setValue(formTables, "PMCR_DEAD2", "PsychoAgiMore75")
        chkSin26.setValue(formTables, "PMCR_DEAD2", "WorthlessLess26")
        chkSin2645.setValue(formTables, "PMCR_DEAD2", "Worthless2645")
        chkSin4655.setValue(formTables, "PMCR_DEAD2", "Worthless4655")
        chkSin5665.setValue(formTables, "PMCR_DEAD2", "Worthless5665")
        chkSin6675.setValue(formTables, "PMCR_DEAD2", "Worthless6675")
        chkSin75.setValue(formTables, "PMCR_DEAD2", "WorthlessMore75")
        chkTroubCon26.setValue(formTables, "PMCR_DEAD2", "TroubConcenLess26")
        chkTroubCon2645.setValue(formTables, "PMCR_DEAD2", "TroubConcen2645")
        chkTroubCon4655.setValue(formTables, "PMCR_DEAD2", "TroubConcen4655")
        chkTroubCon5665.setValue(formTables, "PMCR_DEAD2", "TroubConcen5665")
        chkTroubCon6675.setValue(formTables, "PMCR_DEAD2", "TroubConcen6675")
        chkTroubCon75.setValue(formTables, "PMCR_DEAD2", "TroubConcenMore75")
        chkTroubMon26.setValue(formTables, "PMCR_DEAD2", "TroubMoneyLess26")
        chkTroubMon2645.setValue(formTables, "PMCR_DEAD2", "TroubMoney2645")
        chkTroubMon4655.setValue(formTables, "PMCR_DEAD2", "TroubMoney4655")
        chkTroubMon5665.setValue(formTables, "PMCR_DEAD2", "TroubMoney5665")
        chkTroubMon6675.setValue(formTables, "PMCR_DEAD2", "TroubMoney6675")
        chkTroubMon75.setValue(formTables, "PMCR_DEAD2", "TroubMoneyMore75")
        chkThoughtDeath26.setValue(formTables, "PMCR_DEAD2", "ThoughtDeathLess26")
        chkThoughtDeath2645.setValue(formTables, "PMCR_DEAD2", "ThoughtDeath2645")
        chkThoughtDeath4655.setValue(formTables, "PMCR_DEAD2", "ThoughtDeath4655")
        chkThoughtDeath5665.setValue(formTables, "PMCR_DEAD2", "ThoughtDeath5665")
        chkThoughtDeath6675.setValue(formTables, "PMCR_DEAD2", "ThoughtDeath6675")
        chkThoughtDeath75.setValue(formTables, "PMCR_DEAD2", "ThoughtDeathMore75")
        chkSuicAtt26.setValue(formTables, "PMCR_DEAD2", "SuicideAttemptLess26")
        chkSuicAtt2645.setValue(formTables, "PMCR_DEAD2", "SuicideAttempt2645")
        chkSuicAtt4655.setValue(formTables, "PMCR_DEAD2", "SuicideAttempt4655")
        chkSuicAtt5665.setValue(formTables, "PMCR_DEAD2", "SuicideAttempt5665")
        chkSuicAtt6675.setValue(formTables, "PMCR_DEAD2", "SuicideAttempt6675")
        chkSuicAtt75.setValue(formTables, "PMCR_DEAD2", "SuicideAttemptMore75")
        chkEviDepOther26.setValue(formTables, "PMCR_DEAD2", "EviDepOtherLess26")
        chkEviDepOther2645.setValue(formTables, "PMCR_DEAD2", "EviDepOther2645")
        chkEviDepOther4655.setValue(formTables, "PMCR_DEAD2", "EviDepOther4655")
        chkEviDepOther5665.setValue(formTables, "PMCR_DEAD2", "EviDepOther5665")
        chkEviDepOther6675.setValue(formTables, "PMCR_DEAD2", "EviDepOther6675")
        chkEviDepOther75.setValue(formTables, "PMCR_DEAD2", "EviDepOtherMore75")
        txtEviDepOther.setValue(formTables, "PMCR_DEAD2", "EviDepOtherSpec")
        chkPsychoFeat26.setValue(formTables, "PMCR_DEAD2", "DepPsychoFeatLess26")
        chkPsychoFeat2645.setValue(formTables, "PMCR_DEAD2", "DepPsychoFeat2645")
        chkPsychoFeat4655.setValue(formTables, "PMCR_DEAD2", "DepPsychoFeat4655")
        chkPsychoFeat5665.setValue(formTables, "PMCR_DEAD2", "DepPsychoFeat5665")
        chkPsychoFeat6675.setValue(formTables, "PMCR_DEAD2", "DepPsychoFeat6675")
        chkPsychoFeat75.setValue(formTables, "PMCR_DEAD2", "DepPsychoFeatMore75")
        chkOrgFact26.setValue(formTables, "PMCR_DEAD2", "DepOrganicFactorLess26")
        chkOrgFact2645.setValue(formTables, "PMCR_DEAD2", "DepOrganicFactor2645")
        chkOrgFact4655.setValue(formTables, "PMCR_DEAD2", "DepOrganicFactor4655")
        chkOrgFact5665.setValue(formTables, "PMCR_DEAD2", "DepOrganicFactor5665")
        chkOrgFact6675.setValue(formTables, "PMCR_DEAD2", "DepOrganicFactor6675")
        chkOrgFact75.setValue(formTables, "PMCR_DEAD2", "DepOrganicFactorMore75")
        txtEvidenceOfDepressionNotes.setValue(formTables, "PMCR_DEAD2", "EviDepComments")
        chkElevMood26.setValue(formTables, "PMCR_DEAD2", "ElevMoodLess26")
        chkElevMood2645.setValue(formTables, "PMCR_DEAD2", "ElevMood2645")
        chkElevMood4655.setValue(formTables, "PMCR_DEAD2", "ElevMood4655")
        chkElevMood5665.setValue(formTables, "PMCR_DEAD2", "ElevMood5665")
        chkElevMood6675.setValue(formTables, "PMCR_DEAD2", "ElevMood6675")
        chkElevMood75.setValue(formTables, "PMCR_DEAD2", "ElevMoodMore75")
        chkGrand26.setValue(formTables, "PMCR_DEAD2", "InflateEsteemLess26")
        chkGrand2645.setValue(formTables, "PMCR_DEAD2", "InflateEsteem2645")
        chkGrand4655.setValue(formTables, "PMCR_DEAD2", "InflateEsteem4655")
        chkGrand5665.setValue(formTables, "PMCR_DEAD2", "InflateEsteem5665")
        chkGrand6675.setValue(formTables, "PMCR_DEAD2", "InflateEsteem6675")
        chkGrand75.setValue(formTables, "PMCR_DEAD2", "InflateEsteemMore75")
        chkDecSleep26.setValue(formTables, "PMCR_DEAD2", "DecNeedSleepLess26")
        chkDecSleep2645.setValue(formTables, "PMCR_DEAD2", "DecNeedSleep2645")
        chkDecSleep4655.setValue(formTables, "PMCR_DEAD2", "DecNeedSleep4655")
        chkDecSleep5665.setValue(formTables, "PMCR_DEAD2", "DecNeedSleep5665")
        chkDecSleep6675.setValue(formTables, "PMCR_DEAD2", "DecNeedSleep6675")
        chkDecSleep75.setValue(formTables, "PMCR_DEAD2", "DecNeedSleepMore75")
        chkPressSpeech26.setValue(formTables, "PMCR_DEAD2", "PressSpeechLess26")
        chkPressSpeech2645.setValue(formTables, "PMCR_DEAD2", "PressSpeech2645")
        chkPressSpeech4655.setValue(formTables, "PMCR_DEAD2", "PressSpeech4655")
        chkPressSpeech5665.setValue(formTables, "PMCR_DEAD2", "PressSpeech5665")
        chkPressSpeech6675.setValue(formTables, "PMCR_DEAD2", "PressSpeech6675")
        chkPressSpeech75.setValue(formTables, "PMCR_DEAD2", "PressSpeechMore75")
        chkDistract26.setValue(formTables, "PMCR_DEAD2", "DistractibilityLess26")
        chkDistract2645.setValue(formTables, "PMCR_DEAD2", "Distractibility2645")
        chkDistract4655.setValue(formTables, "PMCR_DEAD2", "Distractibility4655")
        chkDistract5665.setValue(formTables, "PMCR_DEAD2", "Distractibility5665")
        chkDistract6675.setValue(formTables, "PMCR_DEAD2", "Distractibility6675")
        chkDistract75.setValue(formTables, "PMCR_DEAD2", "DistractibilityMore75")
        chkIncAct26.setValue(formTables, "PMCR_DEAD2", "IncActivityLess26")
        chkIncAct2645.setValue(formTables, "PMCR_DEAD2", "IncActivity2645")
        chkIncAct4655.setValue(formTables, "PMCR_DEAD2", "IncActivity4655")
        chkIncAct5665.setValue(formTables, "PMCR_DEAD2", "IncActivity5665")
        chkIncAct6675.setValue(formTables, "PMCR_DEAD2", "IncActivity6675")
        chkIncAct75.setValue(formTables, "PMCR_DEAD2", "IncActivityMore75")
        chkExcessInvolv26.setValue(formTables, "PMCR_DEAD2", "ExcessInvolvLess26")
        chkExcessInvolv2645.setValue(formTables, "PMCR_DEAD2", "ExcessInvolv2645")
        chkExcessInvolv4655.setValue(formTables, "PMCR_DEAD2", "ExcessInvolv4655")
        chkExcessInvolv5665.setValue(formTables, "PMCR_DEAD2", "ExcessInvolv5665")
        chkExcessInvolv6675.setValue(formTables, "PMCR_DEAD2", "ExcessInvolv6675")
        chkExcessInvolv75.setValue(formTables, "PMCR_DEAD2", "ExcessInvolvMore75")
        txtOtherManiaNote.setValue(formTables, "PMCR_DEAD2", "OthBehSuggSpec")
        chkOtherMania26.setValue(formTables, "PMCR_DEAD2", "OthBehSuggLess26")
        chkOtherMania2645.setValue(formTables, "PMCR_DEAD2", "OthBehSugg2645")
        chkOtherMania4655.setValue(formTables, "PMCR_DEAD2", "OthBehSugg4655")
        chkOtherMania5665.setValue(formTables, "PMCR_DEAD2", "OthBehSugg5665")
        chkOtherMania6675.setValue(formTables, "PMCR_DEAD2", "OthBehSugg6675")
        chkOtherMania75.setValue(formTables, "PMCR_DEAD2", "OthBehSuggMore75")
        chkPsychFeat26.setValue(formTables, "PMCR_DEAD2", "ManicPsychoFeatLess26")
        chkPsychFeat2645.setValue(formTables, "PMCR_DEAD2", "ManicPsychoFeat2645")
        chkPsychFeat4655.setValue(formTables, "PMCR_DEAD2", "ManicPsychoFeat4655")
        chkPsychFeat5665.setValue(formTables, "PMCR_DEAD2", "ManicPsychoFeat5665")
        chkPsychFeat6675.setValue(formTables, "PMCR_DEAD2", "ManicPsychoFeat6675")
        chkPsychFeat75.setValue(formTables, "PMCR_DEAD2", "ManicPsychoFeatMore75")
        chkOrgFac26.setValue(formTables, "PMCR_DEAD2", "ManicOrganicFactorLess26")
        chkOrgFac2645.setValue(formTables, "PMCR_DEAD2", "ManicOrganicFactor2645")
        chkOrgFac4655.setValue(formTables, "PMCR_DEAD2", "ManicOrganicFactor4655")
        chkOrgFac5665.setValue(formTables, "PMCR_DEAD2", "ManicOrganicFactor5665")
        chkOrgFac6675.setValue(formTables, "PMCR_DEAD2", "ManicOrganicFactor6675")
        chkOrgFac75.setValue(formTables, "PMCR_DEAD2", "ManicOrganicFactorMore75")
        chkManicDur26.setValue(formTables, "PMCR_DEAD2", "ManicDurLess26")
        chkManicDur2645.setValue(formTables, "PMCR_DEAD2", "ManicDur2645")
        chkManicDur4655.setValue(formTables, "PMCR_DEAD2", "ManicDur4655")
        chkManicDur5665.setValue(formTables, "PMCR_DEAD2", "ManicDur5665")
        chkManicDur6675.setValue(formTables, "PMCR_DEAD2", "ManicDur6675")
        chkManicDur75.setValue(formTables, "PMCR_DEAD2", "ManicDurMore75")
        txtEvidenceOfManicNotes.setValue(formTables, "PMCR_DEAD2", "EviManicComments")
    End Sub
    Private Sub enableInputFields(ByVal bool As Boolean)
        If bool = True Then
            grpSomaticTreatments.Enabled = True
            grpAlcoholAbuse.Enabled = True
            grpSubstanceAbuse.Enabled = True
            grpEvidenceOfDepression.Enabled = True
            grpEvidenceOfManic.Enabled = True
        Else
            grpSomaticTreatments.Enabled = False
            grpAlcoholAbuse.Enabled = False
            grpSubstanceAbuse.Enabled = False
            grpEvidenceOfDepression.Enabled = False
            grpEvidenceOfManic.Enabled = False
        End If
    End Sub
    Private Sub btnDEAD2_Click(sender As Object, e As EventArgs) Handles btnDEAD2Bottom.Click, btnDEAD2Top.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_PMCR_Dead2", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                btnDEAD2Bottom.Text = "Save Changes"
                btnDEAD2Top.Text = btnDEAD2Bottom.Text
                enableInputFields(True)
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If User.PermissionCheck("WA_PMCR_Dead2", "Modify") Then
                loadBaseForm()
                setDefaultValues()
                lblNoRecord.Visible = False
                btnDEAD2Bottom.Text = "Save New Record"
                btnDEAD2Top.Text = "Save New Record"
                enableInputFields(True)
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
            End If
        Else 'By default, user is attempting to Insert or Edit a record. Run preSaveValidation.
            If preSaveValidation() Then 'If preSaveValidation returns true, take Insert or Update actions.
                'Same parameters for Insert or Update SP's, so define here
                Dim parameters = " @SubNum = " & WarehouseShell.SubNum &
                    ", @ECTSpec1 = " & txtECTSpec1.getSQLValue() &
                    ", @ECTSpec2 = " & txtECTSpec2.getSQLValue() &
                    ", @ECTSpec3 = " & txtECTSpec3.getSQLValue() &
                    ", @ECTLess26 = " & chkECT26.getSQLValue() &
                    ", @ECT2645 = " & chkECT2645.getSQLValue() &
                    ", @ECT4655 = " & chkECT4655.getSQLValue() &
                    ", @ECT5665 = " & chkECT5665.getSQLValue() &
                    ", @ECT6675 = " & chkECT6675.getSQLValue() &
                    ", @ECTMore75 = " & chkECT75.getSQLValue() &
                    ", @PsychosurgSpec1 = " & txtPsychosurgSpec1.getSQLValue() &
                    ", @PsychosurgSpec2 = " & txtPsychoSurgSpec2.getSQLValue() &
                    ", @PsychosurgSpec3 = " & txtPsychosurgSpec3.getSQLValue() &
                    ", @PsychosurgLess26 = " & chkPsychoSurg26.getSQLValue() &
                    ", @Psychosurg2645 = " & chkPsychoSurg2645.getSQLValue() &
                    ", @Psychosurg4655 = " & chkPsychoSurg4655.getSQLValue() &
                    ", @Psychosurg5665 = " & chkPsychoSurg5665.getSQLValue() &
                    ", @Psychosurg6675 = " & chkPsychoSurg6675.getSQLValue() &
                    ", @PsychosurgMore75 = " & chkPsychoSurg75.getSQLValue() &
                    ", @LithiumSpec1 = " & txtLithiumSpec1.getSQLValue() &
                    ", @LithiumSpec2 = " & txtLithiumSpec2.getSQLValue() &
                    ", @LithiumSpec3 = " & txtLithiumSpec3.getSQLValue() &
                    ", @LithiumLess26 = " & chkLithium26.getSQLValue() &
                    ", @Lithium2645 = " & chkLithium2645.getSQLValue() &
                    ", @Lithium4655 = " & chkLithium4655.getSQLValue() &
                    ", @Lithium5665 = " & chkLithium5665.getSQLValue() &
                    ", @Lithium6675 = " & chkLithium6675.getSQLValue() &
                    ", @LithiumMore75 = " & chkLithium75.getSQLValue() &
                    ", @HeteroSpec1 = " & txtHeteroSpec1.getSQLValue() &
                    ", @HeteroSpec2 = " & txtHeteroSpec2.getSQLValue() &
                    ", @HeteroSpec3 = " & txtHeteroSpec3.getSQLValue() &
                    ", @HeteroLess26 = " & chkHetero26.getSQLValue() &
                    ", @Hetero2645 = " & chkHetero2645.getSQLValue() &
                    ", @Hetero4655 = " & chkHetero4655.getSQLValue() &
                    ", @Hetero5665 = " & chkHetero5665.getSQLValue() &
                    ", @Hetero6675 = " & chkHetero6675.getSQLValue() &
                    ", @HeteroMore75 = " & chkHetero75.getSQLValue() &
                    ", @MAOISpec1 = " & txtMAOISpec1.getSQLValue() &
                    ", @MAOISpec2 = " & txtMAOISpec2.getSQLValue() &
                    ", @MAOISpec3 = " & txtMAOISpec3.getSQLValue() &
                    ", @MAOILess26 = " & chkMAOI26.getSQLValue() &
                    ", @MAOI2645 = " & chkMAOI2645.getSQLValue() &
                    ", @MAOI4655 = " & chkMAOI4655.getSQLValue() &
                    ", @MAOI5665 = " & chkMAOI5665.getSQLValue() &
                    ", @MAOI6675 = " & chkMAOI6675.getSQLValue() &
                    ", @MAOIMore75 = " & chkMAOI75.getSQLValue() &
                    ", @AnticholSpec1 = " & txtAnticholSpec1.getSQLValue() &
                    ", @AnticholSpec2 = " & txtAnticholSpec2.getSQLValue() &
                    ", @AnticholSpec3 = " & txtAnticholSpec3.getSQLValue() &
                    ", @AnticholLess26 = " & chkAntichol26.getSQLValue() &
                    ", @Antichol2645 = " & chkAntichol2645.getSQLValue() &
                    ", @Antichol4655 = " & chkAntichol4655.getSQLValue() &
                    ", @Antichol5665 = " & chkAntichol5665.getSQLValue() &
                    ", @Antichol6675 = " & chkAntichol6675.getSQLValue() &
                    ", @AnticholMore75 = " & chkAntichol75.getSQLValue() &
                    ", @SedativeSpec1 = " & txtSedativeSpec1.getSQLValue() &
                    ", @SedativeSpec2 = " & txtSedativeSpec2.getSQLValue() &
                    ", @SedativeSpec3 = " & txtSedativeSpec3.getSQLValue() &
                    ", @SedativeLess26 = " & chkSedative26.getSQLValue() &
                    ", @Sedative2645 = " & chkSedative2645.getSQLValue() &
                    ", @Sedative4655 = " & chkSedative4655.getSQLValue() &
                    ", @Sedative5665 = " & chkSedative5665.getSQLValue() &
                    ", @Sedative6675 = " & chkSedative6675.getSQLValue() &
                    ", @SedativeMore75 = " & chkSedative75.getSQLValue() &
                    ", @OtherSomTreatSpec1 = " & txtOtherSpec1.getSQLValue() &
                    ", @OtherSomTreatSpec2 = " & txtOtherSpec2.getSQLValue() &
                    ", @OtherSomTreatSpec3 = " & txtOtherSpec3.getSQLValue() &
                    ", @OtherSomTreatLess26 = " & chkOther26.getSQLValue() &
                    ", @OtherSomTreat2645 = " & chkOther2645.getSQLValue() &
                    ", @OtherSomTreat4655 = " & chkOther4655.getSQLValue() &
                    ", @OtherSomTreat5665 = " & chkOther5665.getSQLValue() &
                    ", @OtherSomTreat6675 = " & chkOther6675.getSQLValue() &
                    ", @OtherSomTreatMore75 = " & chkOther75.getSQLValue() &
                    ", @NeuroLowPotSpec1 = " & txtNeuroLowPotSpec1.getSQLValue() &
                    ", @NeuroLowPotSpec2 = " & txtNeuroLowPotSpec2.getSQLValue() &
                    ", @NeuroLowPotSpec3 = " & txtNeuroLowPotSpec3.getSQLValue() &
                    ", @NeuroLowPotLess26 = " & chkNeuroLowPot26.getSQLValue() &
                    ", @NeuroLowPot2645 = " & chkNeuroLowPot2645.getSQLValue() &
                    ", @NeuroLowPot4655 = " & chkNeuroLowPot4655.getSQLValue() &
                    ", @NeuroLowPot5665 = " & chkNeuroLowPot5665.getSQLValue() &
                    ", @NeuroLowPot6675 = " & chkNeuroLowPot6675.getSQLValue() &
                    ", @NeuroLowPotMore75 = " & chkNeuroLowPot75.getSQLValue() &
                    ", @NeuroHighPotSpec1 = " & txtNeuroHighPotSpec1.getSQLValue() &
                    ", @NeuroHighPotSpec2 = " & txtNeuroHighPotSpec2.getSQLValue() &
                    ", @NeuroHighPotSpec3 = " & txtNeuroHighPotSpec3.getSQLValue() &
                    ", @NeuroHighPotLess26 = " & chkNeuroHighPot26.getSQLValue() &
                    ", @NeuroHighPot2645 = " & chkNeuroHighPot2645.getSQLValue() &
                    ", @NeuroHighPot4655 = " & chkNeuroHighPot4655.getSQLValue() &
                    ", @NeuroHighPot5665 = " & chkNeuroHighPot5665.getSQLValue() &
                    ", @NeuroHighPot6675 = " & chkNeuroHighPot6675.getSQLValue() &
                    ", @NeuroHighPotMore75 = " & chkNeuroHighPot75.getSQLValue() &
                    ", @NeuroAtypSpec1 = " & txtNeuroAtypSpec1.getSQLValue() &
                    ", @NeuroAtypSpec2 = " & txtNeuroAtypSpec2.getSQLValue() &
                    ", @NeuroAtypSpec3 = " & txtNeuroAtypSpec3.getSQLValue() &
                    ", @NeuroAtypLess26 = " & chkNeuroAtyp26.getSQLValue() &
                    ", @NeuroAtyp2645 = " & chkNeuroAtyp2645.getSQLValue() &
                    ", @NeuroAtyp4655 = " & chkNeuroAtyp4655.getSQLValue() &
                    ", @NeuroAtyp5665 = " & chkNeuroAtyp5665.getSQLValue() &
                    ", @NeuroAtyp6675 = " & chkNeuroAtyp6675.getSQLValue() &
                    ", @NeuroAtypMore75 = " & chkNeuroAtyp75.getSQLValue() &
                    ", @TotDurNLExposure = " & intTotalDurNLExp.getSQLValue() &
                    ", @NlYrBefDeath = " & cmbNLDurYrBefDeath.getSQLValue() &
                    ", @DrinkingProbLess26 = " & chkDrinkingProb26.getSQLValue() &
                    ", @DrinkingProb2645 = " & chkDrinkingProb2645.getSQLValue() &
                    ", @DrinkingProb4655 = " & chkDrinkingProb4655.getSQLValue() &
                    ", @DrinkingProb5665 = " & chkDrinkingProb5665.getSQLValue() &
                    ", @DrinkingProb6675 = " & chkDrinkingProb6675.getSQLValue() &
                    ", @DrinkingProbMore75 = " & chkDrinkingProb75.getSQLValue() &
                    ", @ExcesConsumLess26 = " & chkExcessCons26.getSQLValue() &
                    ", @ExcesConsum2645 = " & chkExcessCons2645.getSQLValue() &
                    ", @ExcesConsum4655 = " & chkExcessCons4655.getSQLValue() &
                    ", @ExcesConsum5665 = " & chkExcessCons5665.getSQLValue() &
                    ", @ExcesConsum6675 = " & chkExcessCons6675.getSQLValue() &
                    ", @ExcesConsumMore75 = " & chkExcessCons75.getSQLValue() &
                    ", @AlcIntFunctLess26 = " & chkAlcUseInt26.getSQLValue() &
                    ", @AlcIntFunct2645 = " & chkAlcUseInt2645.getSQLValue() &
                    ", @AlcIntFunct4655 = " & chkAlcUseInt4655.getSQLValue() &
                    ", @AlcIntFunct5665 = " & chkAlcUseInt5665.getSQLValue() &
                    ", @AlcIntFunct6675 = " & chkAlcUseInt6675.getSQLValue() &
                    ", @AlcIntFunctMore75 = " & chkAlcUseInt75.getSQLValue() &
                    ", @AlcContUseLess26 = " & chkContUse26.getSQLValue() &
                    ", @AlcContUse2645 = " & chkContUse2645.getSQLValue() &
                    ", @AlcContUse4655 = " & chkContUse4655.getSQLValue() &
                    ", @AlcContUse5665 = " & chkContUse5665.getSQLValue() &
                    ", @AlcContUse6675 = " & chkContUse6675.getSQLValue() &
                    ", @AlcContUseMore75 = " & chkContUse75.getSQLValue() &
                    ", @EvidOfTolLess26 = " & chkEviTol26.getSQLValue() &
                    ", @EvidOfTol2645 = " & chkEviTol2645.getSQLValue() &
                    ", @EvidOfTol4655 = " & chkEviTol4655.getSQLValue() &
                    ", @EvidOfTol5665 = " & chkEviTol5665.getSQLValue() &
                    ", @EvidOfTol6675 = " & chkEviTol6675.getSQLValue() &
                    ", @EvidOfTolMore75 = " & chkEviTol75.getSQLValue() &
                    ", @AlcMedCompLess26 = " & chkMedComp26.getSQLValue() &
                    ", @AlcMedComp2645 = " & chkMedComp2645.getSQLValue() &
                    ", @AlcMedComp4655 = " & chkMedComp4655.getSQLValue() &
                    ", @AlcMedComp5665 = " & chkMedComp5665.getSQLValue() &
                    ", @AlcMedComp6675 = " & chkMedComp6675.getSQLValue() &
                    ", @AlcMedCompMore75 = " & chkMedComp75.getSQLValue() &
                    ", @AlcOthEvidLess26 = " & chkOtherEvi26.getSQLValue() &
                    ", @AlcOthEvid2645 = " & chkOtherEvi2645.getSQLValue() &
                    ", @AlcOthEvid4655 = " & chkOtherEvi4655.getSQLValue() &
                    ", @AlcOthEvid5665 = " & chkOtherEvi5665.getSQLValue() &
                    ", @AlcOthEvid6675 = " & chkOtherEvi6675.getSQLValue() &
                    ", @AlcOthEvidMore75 = " & chkOtherEvi75.getSQLValue() &
                    ", @AlcUseNotes = " & txtAlcAbuseNotes.getSQLValue() &
                    ", @CannabisLess26 = " & chkCannabis26.getSQLValue() &
                    ", @Cannabis2645 = " & chkCannabis2645.getSQLValue() &
                    ", @Cannabis4655 = " & chkCannabis4655.getSQLValue() &
                    ", @Cannabis5665 = " & chkCannabis5665.getSQLValue() &
                    ", @Cannabis6675 = " & chkCannabis6675.getSQLValue() &
                    ", @CannabisMore75 = " & chkCannabis75.getSQLValue() &
                    ", @AmphetLess26 = " & chkAmphet26.getSQLValue() &
                    ", @Amphet2645 = " & chkAmphet2645.getSQLValue() &
                    ", @Amphet4655 = " & chkAmphet4655.getSQLValue() &
                    ", @Amphet5665 = " & chkAmphet5665.getSQLValue() &
                    ", @Amphet6675 = " & chkAmphet6675.getSQLValue() &
                    ", @AmphetMore75 = " & chkAmphet75.getSQLValue() &
                    ", @SedativeDepSpec = " & txtSedativesSpec.getSQLValue() &
                    ", @SedativeDepLess26 = " & chkSedatives26.getSQLValue() &
                    ", @SedativeDep2645 = " & chkSedatives2645.getSQLValue() &
                    ", @SedativeDep4655 = " & chkSedatives4655.getSQLValue() &
                    ", @SedativeDep5665 = " & chkSedatives5665.getSQLValue() &
                    ", @SedativeDep6675 = " & chkSedatives6675.getSQLValue() &
                    ", @SedativeDepMore75 = " & chkSedatives75.getSQLValue() &
                    ", @CocaineLess26 = " & chkCocaine26.getSQLValue() &
                    ", @Cocaine2645 = " & chkCocaine2645.getSQLValue() &
                    ", @Cocaine4655 = " & chkCocaine4655.getSQLValue() &
                    ", @Cocaine5665 = " & chkCocaine5665.getSQLValue() &
                    ", @Cocaine6675 = " & chkCocaine6675.getSQLValue() &
                    ", @CocaineMore75 = " & chkCocaine75.getSQLValue() &
                    ", @OpiatesSpec = " & txtOpiates.getSQLValue() &
                    ", @OpiatesLess26 = " & chkOpiates26.getSQLValue() &
                    ", @Opiates2645 = " & chkOpiates2645.getSQLValue() &
                    ", @Opiates4655 = " & chkOpiates4655.getSQLValue() &
                    ", @Opiates5665 = " & chkOpiates5665.getSQLValue() &
                    ", @Opiates6675 = " & chkOpiates6675.getSQLValue() &
                    ", @OpiatesMore75 = " & chkOpiates75.getSQLValue() &
                    ", @HallucinogenSpec = " & txtHallSpec.getSQLValue() &
                    ", @HallucinogenLess26 = " & chkHall26.getSQLValue() &
                    ", @Hallucinogen2645 = " & chkHall2645.getSQLValue() &
                    ", @Hallucinogen4655 = " & chkHall4655.getSQLValue() &
                    ", @Hallucinogen5665 = " & chkHall5665.getSQLValue() &
                    ", @Hallucinogen6675 = " & chkHall6675.getSQLValue() &
                    ", @HallucinogenMore75 = " & chkHall75.getSQLValue() &
                    ", @OthDrugAbuseSpec = " & txtOthDrugSpec.getSQLValue() &
                    ", @OthDrugAbuseLess26 = " & chkOthDrug26.getSQLValue() &
                    ", @OthDrugAbuse2645 = " & chkOthDrug2645.getSQLValue() &
                    ", @OthDrugAbuse4655 = " & chkOthDrug4655.getSQLValue() &
                    ", @OthDrugAbuse5665 = " & chkOthDrug5665.getSQLValue() &
                    ", @OthDrugAbuse6675 = " & chkOthDrug6675.getSQLValue() &
                    ", @OthDrugAbuseMore75 = " & chkOthDrug75.getSQLValue() &
                    ", @TobaccoLess26 = " & chkTobacco26.getSQLValue() &
                    ", @Tobacco2645 = " & chkTobacco2645.getSQLValue() &
                    ", @Tobacco4655 = " & chkTobacco4655.getSQLValue() &
                    ", @Tobacco5665 = " & chkTobacco5665.getSQLValue() &
                    ", @Tobacco6675 = " & chkTobacco6675.getSQLValue() &
                    ", @TobaccoMore75 = " & chkTobacco75.getSQLValue() &
                    ", @DrugAbuseNotes = " & txtSubstanceAbuseNotes.getSQLValue() &
                    ", @PervDepMoodLess26 = " & chkPervDep26.getSQLValue() &
                    ", @PervDepMood2645 = " & chkPervDep2645.getSQLValue() &
                    ", @PervDepMood4655 = " & chkPervDep4655.getSQLValue() &
                    ", @PervDepMood5665 = " & chkPervDep5665.getSQLValue() &
                    ", @PervDepMood6675 = " & chkPervDep6675.getSQLValue() &
                    ", @PervDepMoodMore75 = " & chkPervDep75.getSQLValue() &
                    ", @LossInterestLess26 = " & chkLossInt26.getSQLValue() &
                    ", @LossInterest2645 = " & chkLossInt2645.getSQLValue() &
                    ", @LossInterest4655 = " & chkLossInt4655.getSQLValue() &
                    ", @LossInterest5665 = " & chkLossInt5665.getSQLValue() &
                    ", @LossInterest6675 = " & chkLossInt6675.getSQLValue() &
                    ", @LossInterestMore75 = " & chkLossInt75.getSQLValue() &
                    ", @DecAppetiteLess26 = " & chkDecApp26.getSQLValue() &
                    ", @DecAppetite2645 = " & chkDecApp2645.getSQLValue() &
                    ", @DecAppetite4655 = " & chkDecApp4655.getSQLValue() &
                    ", @DecAppetite5665 = " & chkDecApp5665.getSQLValue() &
                    ", @DecAppetite6675 = " & chkDecApp6675.getSQLValue() &
                    ", @DecAppetiteMore75 = " & chkDecApp75.getSQLValue() &
                    ", @IncAppetiteLess26 = " & chkIncApp26.getSQLValue() &
                    ", @IncAppetite2645 = " & chkIncApp2645.getSQLValue() &
                    ", @IncAppetite4655 = " & chkIncApp4655.getSQLValue() &
                    ", @IncAppetite5665 = " & chkIncApp5665.getSQLValue() &
                    ", @IncAppetite6675 = " & chkIncApp6675.getSQLValue() &
                    ", @IncAppetiteMore75 = " & chkIncApp75.getSQLValue() &
                    ", @InsomniaLess26 = " & chkInsom26.getSQLValue() &
                    ", @Insomnia2645 = " & chkInsom2645.getSQLValue() &
                    ", @Insomnia4655 = " & chkInsom4655.getSQLValue() &
                    ", @Insomnia5665 = " & chkInsom5665.getSQLValue() &
                    ", @Insomnia6675 = " & chkInsom6675.getSQLValue() &
                    ", @InsomniaMore75 = " & chkInsom75.getSQLValue() &
                    ", @HypersomniaLess26 = " & chkHypersom26.getSQLValue() &
                    ", @Hypersomnia2645 = " & chkHypersom2645.getSQLValue() &
                    ", @Hypersomnia4655 = " & chkHypersom4655.getSQLValue() &
                    ", @Hypersomnia5665 = " & chkHypersom5665.getSQLValue() &
                    ", @Hypersomnia6675 = " & chkHypersom6675.getSQLValue() &
                    ", @HypersomniaMore75 = " & chkHypersom75.getSQLValue() &
                    ", @FatigueLess26 = " & chkFat26.getSQLValue() &
                    ", @Fatigue2645 = " & chkFat2645.getSQLValue() &
                    ", @Fatigue4655 = " & chkFat4655.getSQLValue() &
                    ", @Fatigue5665 = " & chkFat5665.getSQLValue() &
                    ", @Fatigue6675 = " & chkFat6675.getSQLValue() &
                    ", @FatigueMore75 = " & chkFat75.getSQLValue() &
                    ", @PsychoRetardLess26 = " & chkPsychoRet26.getSQLValue() &
                    ", @PsychoRetard2645 = " & chkPsychoRet2645.getSQLValue() &
                    ", @PsychoRetard4655 = " & chkPsychoRet4655.getSQLValue() &
                    ", @PsychoRetard5665 = " & chkPsychoRet5665.getSQLValue() &
                    ", @PsychoRetard6675 = " & chkPsychoRet6675.getSQLValue() &
                    ", @PsychoRetardMore75 = " & chkPsychoRet75.getSQLValue() &
                    ", @PsychoAgiLess26 = " & chkPsychoAgi26.getSQLValue() &
                    ", @PsychoAgi2645 = " & chkPsychoAgi2645.getSQLValue() &
                    ", @PsychoAgi4655 = " & chkPsychoAgi4655.getSQLValue() &
                    ", @PsychoAgi5665 = " & chkPsychoAgi5665.getSQLValue() &
                    ", @PsychoAgi6675 = " & chkPsychoAgi6675.getSQLValue() &
                    ", @PsychoAgiMore75 = " & chkPsychoAgi75.getSQLValue() &
                    ", @WorthlessLess26 = " & chkSin26.getSQLValue() &
                    ", @Worthless2645 = " & chkSin2645.getSQLValue() &
                    ", @Worthless4655 = " & chkSin4655.getSQLValue() &
                    ", @Worthless5665 = " & chkSin5665.getSQLValue() &
                    ", @Worthless6675 = " & chkSin6675.getSQLValue() &
                    ", @WorthlessMore75 = " & chkSin75.getSQLValue() &
                    ", @TroubConcenLess26 = " & chkTroubCon26.getSQLValue() &
                    ", @TroubConcen2645 = " & chkTroubCon2645.getSQLValue() &
                    ", @TroubConcen4655 = " & chkTroubCon4655.getSQLValue() &
                    ", @TroubConcen5665 = " & chkTroubCon5665.getSQLValue() &
                    ", @TroubConcen6675 = " & chkTroubCon6675.getSQLValue() &
                    ", @TroubConcenMore75 = " & chkTroubCon75.getSQLValue() &
                    ", @TroubMoneyLess26 = " & chkTroubMon26.getSQLValue() &
                    ", @TroubMoney2645 = " & chkTroubMon2645.getSQLValue() &
                    ", @TroubMoney4655 = " & chkTroubMon4655.getSQLValue() &
                    ", @TroubMoney5665 = " & chkTroubMon5665.getSQLValue() &
                    ", @TroubMoney6675 = " & chkTroubMon6675.getSQLValue() &
                    ", @TroubMoneyMore75 = " & chkTroubMon75.getSQLValue() &
                    ", @ThoughtDeathLess26 = " & chkThoughtDeath26.getSQLValue() &
                    ", @ThoughtDeath2645 = " & chkThoughtDeath2645.getSQLValue() &
                    ", @ThoughtDeath4655 = " & chkThoughtDeath4655.getSQLValue() &
                    ", @ThoughtDeath5665 = " & chkThoughtDeath5665.getSQLValue() &
                    ", @ThoughtDeath6675 = " & chkThoughtDeath6675.getSQLValue() &
                    ", @ThoughtDeathMore75 = " & chkThoughtDeath75.getSQLValue() &
                    ", @SuicideAttemptLess26 = " & chkSuicAtt26.getSQLValue() &
                    ", @SuicideAttempt2645 = " & chkSuicAtt2645.getSQLValue() &
                    ", @SuicideAttempt4655 = " & chkSuicAtt4655.getSQLValue() &
                    ", @SuicideAttempt5665 = " & chkSuicAtt5665.getSQLValue() &
                    ", @SuicideAttempt6675 = " & chkSuicAtt6675.getSQLValue() &
                    ", @SuicideAttemptMore75 = " & chkSuicAtt75.getSQLValue() &
                    ", @EviDepOtherSpec = " & txtEviDepOther.getSQLValue() &
                    ", @EviDepOtherLess26 = " & chkEviDepOther26.getSQLValue() &
                    ", @EviDepOther2645 = " & chkEviDepOther2645.getSQLValue() &
                    ", @EviDepOther4655 = " & chkEviDepOther4655.getSQLValue() &
                    ", @EviDepOther5665 = " & chkEviDepOther5665.getSQLValue() &
                    ", @EviDepOther6675 = " & chkEviDepOther6675.getSQLValue() &
                    ", @EviDepOtherMore75 = " & chkEviDepOther75.getSQLValue() &
                    ", @DepPsychoFeatLess26 = " & chkPsychoFeat26.getSQLValue() &
                    ", @DepPsychoFeat2645 = " & chkPsychoFeat2645.getSQLValue() &
                    ", @DepPsychoFeat4655 = " & chkPsychoFeat4655.getSQLValue() &
                    ", @DepPsychoFeat5665 = " & chkPsychoFeat5665.getSQLValue() &
                    ", @DepPsychoFeat6675 = " & chkPsychoFeat6675.getSQLValue() &
                    ", @DepPsychoFeatMore75 = " & chkPsychoFeat75.getSQLValue() &
                    ", @DepOrganicFactorLess26 = " & chkOrgFact26.getSQLValue() &
                    ", @DepOrganicFactor2645 = " & chkOrgFact2645.getSQLValue() &
                    ", @DepOrganicFactor4655 = " & chkOrgFact4655.getSQLValue() &
                    ", @DepOrganicFactor5665 = " & chkOrgFact5665.getSQLValue() &
                    ", @DepOrganicFactor6675 = " & chkOrgFact6675.getSQLValue() &
                    ", @DepOrganicFactorMore75 = " & chkOrgFact75.getSQLValue() &
                    ", @EviDepComments = " & txtEvidenceOfDepressionNotes.getSQLValue() &
                    ", @ElevMoodLess26 = " & chkElevMood26.getSQLValue() &
                    ", @ElevMood2645 = " & chkElevMood2645.getSQLValue() &
                    ", @ElevMood4655 = " & chkElevMood4655.getSQLValue() &
                    ", @ElevMood5665 = " & chkElevMood5665.getSQLValue() &
                    ", @ElevMood6675 = " & chkElevMood6675.getSQLValue() &
                    ", @ElevMoodMore75 = " & chkElevMood75.getSQLValue() &
                    ", @InflateEsteemless26 = " & chkGrand26.getSQLValue() &
                    ", @InflateEsteem2645 = " & chkGrand2645.getSQLValue() &
                    ", @InflateEsteem4655 = " & chkGrand4655.getSQLValue() &
                    ", @InflateEsteem5665 = " & chkGrand5665.getSQLValue() &
                    ", @InflateEsteem6675 = " & chkGrand6675.getSQLValue() &
                    ", @InflateEsteemMore75 = " & chkGrand75.getSQLValue() &
                    ", @DecNeedSleepLess26 = " & chkDecSleep26.getSQLValue() &
                    ", @DecNeedSleep2645 = " & chkDecSleep2645.getSQLValue() &
                    ", @DecNeedSleep4655 = " & chkDecSleep4655.getSQLValue() &
                    ", @DecNeedSleep5665 = " & chkDecSleep5665.getSQLValue() &
                    ", @DecNeedSleep6675 = " & chkDecSleep6675.getSQLValue() &
                    ", @DecNeedSleepMore75 = " & chkDecSleep75.getSQLValue() &
                    ", @PressSpeechLess26 = " & chkPressSpeech26.getSQLValue() &
                    ", @PressSpeech2645 = " & chkPressSpeech2645.getSQLValue() &
                    ", @PressSpeech4655 = " & chkPressSpeech4655.getSQLValue() &
                    ", @PressSpeech5665 = " & chkPressSpeech5665.getSQLValue() &
                    ", @PressSpeech6675 = " & chkPressSpeech6675.getSQLValue() &
                    ", @PressSpeechMore75 = " & chkPressSpeech75.getSQLValue() &
                    ", @DistractibilityLess26 = " & chkDistract26.getSQLValue() &
                    ", @Distractibility2645 = " & chkDistract2645.getSQLValue() &
                    ", @Distractibility4655 = " & chkDistract4655.getSQLValue() &
                    ", @Distractibility5665 = " & chkDistract5665.getSQLValue() &
                    ", @Distractibility6675 = " & chkDistract6675.getSQLValue() &
                    ", @DistractibilityMore75 = " & chkDistract75.getSQLValue() &
                    ", @IncActivityLess26 = " & chkIncAct26.getSQLValue() &
                    ", @IncActivity2645 = " & chkIncAct2645.getSQLValue() &
                    ", @IncActivity4655 = " & chkIncAct4655.getSQLValue() &
                    ", @IncActivity5665 = " & chkIncAct5665.getSQLValue() &
                    ", @IncActivity6675 = " & chkIncAct6675.getSQLValue() &
                    ", @IncActivityMore75 = " & chkIncAct75.getSQLValue() &
                    ", @ExcessInvolvLess26 = " & chkExcessInvolv26.getSQLValue() &
                    ", @ExcessInvolv2645 = " & chkExcessInvolv2645.getSQLValue() &
                    ", @ExcessInvolv4655 = " & chkExcessInvolv4655.getSQLValue() &
                    ", @ExcessInvolv5665 = " & chkExcessInvolv5665.getSQLValue() &
                    ", @ExcessInvolv6675 = " & chkExcessInvolv6675.getSQLValue() &
                    ", @ExcessInvolvMore75 = " & chkExcessInvolv75.getSQLValue() &
                    ", @OthBehSuggSpec = " & txtOtherManiaNote.getSQLValue() &
                    ", @OthBehSuggLess26 = " & chkOtherMania26.getSQLValue() &
                    ", @OthBehSugg2645 = " & chkOtherMania2645.getSQLValue() &
                    ", @OthBehSugg4655 = " & chkOtherMania4655.getSQLValue() &
                    ", @OthBehSugg5665 = " & chkOtherMania5665.getSQLValue() &
                    ", @OthBehSugg6675 = " & chkOtherMania6675.getSQLValue() &
                    ", @OthBehSuggMore75 = " & chkOtherMania75.getSQLValue() &
                    ", @ManicDurWks = " & txtManicDur.getSQLValue() &
                    ", @ManicDurLess26 = " & chkManicDur26.getSQLValue() &
                    ", @ManicDur2645 = " & chkManicDur2645.getSQLValue() &
                    ", @ManicDur4655 = " & chkManicDur4655.getSQLValue() &
                    ", @ManicDur5665 = " & chkManicDur5665.getSQLValue() &
                    ", @ManicDur6675 = " & chkManicDur6675.getSQLValue() &
                    ", @ManicDurMore75 = " & chkManicDur75.getSQLValue() &
                    ", @ManicPsychoFeatLess26 = " & chkPsychFeat26.getSQLValue() &
                    ", @ManicPsychoFeat2645 = " & chkPsychFeat2645.getSQLValue() &
                    ", @ManicPsychoFeat4655 = " & chkPsychFeat4655.getSQLValue() &
                    ", @ManicPsychoFeat5665 = " & chkPsychFeat5665.getSQLValue() &
                    ", @ManicPsychoFeat6675 = " & chkPsychFeat6675.getSQLValue() &
                    ", @ManicPsychoFeatMore75 = " & chkPsychFeat75.getSQLValue() &
                    ", @ManicOrganicFactorLess26 = " & chkOrgFac26.getSQLValue() &
                    ", @ManicOrganicFactor2645 = " & chkOrgFac2645.getSQLValue() &
                    ", @ManicOrganicFactor4655 = " & chkOrgFac4655.getSQLValue() &
                    ", @ManicOrganicFactor5665 = " & chkOrgFac5665.getSQLValue() &
                    ", @ManicOrganicFactor6675 = " & chkOrgFac6675.getSQLValue() &
                    ", @ManicOrganicFactorMore75 = " & chkOrgFac75.getSQLValue() &
                    ", @EviManicComments = " & txtEvidenceOfManicNotes.getSQLValue() &
                    ", @LastModBy = '" & WarehouseShell.userName & "';"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    Dim cmd As New SqlCommand("Exec modPMCR_DEAD2Record @Action = 1, " & parameters, WarehouseShell.conn)
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Save successful", MsgBoxStyle.OkOnly)
                        enableInputFields(False)
                        btnDEAD2Bottom.Text = "Edit Record"
                        btnDEAD2Top.Text = "Edit Record"
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else 'If this clause is invoked, datamode must be Edit
                    Dim cmd As New SqlCommand("Exec modPMCR_DEAD2Record @Action = 2, " & parameters, WarehouseShell.conn)
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Save successful", MsgBoxStyle.OkOnly)
                        enableInputFields(False)
                        btnDEAD2Bottom.Text = "Edit Record"
                        btnDEAD2Top.Text = "Edit Record"
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
        btnDEAD2Bottom.PerformClick()
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