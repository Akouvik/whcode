Public Class WA_PMCR_Dead3
    Implements IFormMethods
    Private formTables As New DataSet

    Private Sub WA_PMCR_Dead3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Database.ExistingRecordCheck("PMCR_DEAD3", "SubNum = " & WarehouseShell.SubNum) Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            loadBaseForm()
            loadExistingData()
            btnDEAD3Top.Text = "Edit Record"
            btnDEAD3Bottom.Text = btnDEAD3Top.Text
        Else 'If it doesn't exist, change mode to Undefined and show user banner
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            lblNoRecord.Visible = True
            btnDEAD3Top.Text = "Add New Record"
            btnDEAD3Bottom.Text = btnDEAD3Top.Text
        End If
        enableInputFields(False)
    End Sub
    Private Sub loadBaseForm()
        WarehouseShell.highlightSelectedNode("WA_PMCR_tabDEAD3")
        'Nothing needed here. No combo boxes to reference.
    End Sub
    Private Sub loadExistingData()
        'Grab the individual record, based on RecordID, and assign values to their appropriate fields
        formTables.Tables.Add(Database.ReturnTable("PMCR_DEAD3", , "SubNum = " & WarehouseShell.SubNum))
        txtUnspecAud.setValue(formTables, "PMCR_DEAD3", "UnspecAuditorySpec")
        chkUnspecAud26.setValue(formTables, "PMCR_DEAD3", "UnspecAuditoryLess26")
        chkUnspecAud2645.setValue(formTables, "PMCR_DEAD3", "UnspecAuditory2645")
        chkUnspecAud4655.setValue(formTables, "PMCR_DEAD3", "UnspecAuditory4655")
        chkUnspecAud5665.setValue(formTables, "PMCR_DEAD3", "UnspecAuditory5665")
        chkUnspecAud6675.setValue(formTables, "PMCR_DEAD3", "UnspecAuditory6675")
        chkUnspecAud75.setValue(formTables, "PMCR_DEAD3", "UnspecAuditoryMore75")
        txtVoiceSingle.setValue(formTables, "PMCR_DEAD3", "SingleVoiceSpec")
        chkVoiceSingle26.setValue(formTables, "PMCR_DEAD3", "SingleVoiceLess26")
        chkVoiceSingle2645.setValue(formTables, "PMCR_DEAD3", "SingleVoice2645")
        chkVoiceSingle4655.setValue(formTables, "PMCR_DEAD3", "SingleVoice4655")
        chkVoiceSingle5665.setValue(formTables, "PMCR_DEAD3", "SingleVoice5665")
        chkVoiceSingle6675.setValue(formTables, "PMCR_DEAD3", "SingleVoice6675")
        chkVoiceSingle75.setValue(formTables, "PMCR_DEAD3", "SingleVoiceMore75")
        txtVoiceTwo.setValue(formTables, "PMCR_DEAD3", "MultVoicesSpec")
        chkVoiceTwo26.setValue(formTables, "PMCR_DEAD3", "MultVoicesLess26")
        chkVoiceTwo2645.setValue(formTables, "PMCR_DEAD3", "MultVoices2645")
        chkVoiceTwo4655.setValue(formTables, "PMCR_DEAD3", "MultVoices4655")
        chkVoiceTwo5665.setValue(formTables, "PMCR_DEAD3", "MultVoices5665")
        chkVoiceTwo6675.setValue(formTables, "PMCR_DEAD3", "MultVoices6675")
        chkVoiceTwo75.setValue(formTables, "PMCR_DEAD3", "MultVoicesMore75")
        txtVoicesComm.Text = formTables.Tables("PMCR_DEAD3").Rows(0).Item("CommVoicesSpec").ToString
        txtVoicesComm.setValue(formTables, "PMCR_DEAD3", "CommVoicesSpec")
        chkVoicesComm26.setValue(formTables, "PMCR_DEAD3", "CommVoicesLess26")
        chkVoicesComm2645.setValue(formTables, "PMCR_DEAD3", "CommVoices2645")
        chkVoicesComm4655.setValue(formTables, "PMCR_DEAD3", "CommVoices4655")
        chkVoicesComm5665.setValue(formTables, "PMCR_DEAD3", "CommVoices5665")
        chkVoicesComm6675.setValue(formTables, "PMCR_DEAD3", "CommVoices6675")
        chkVoicesComm75.setValue(formTables, "PMCR_DEAD3", "CommVoicesMore75")
        txtNoises.setValue(formTables, "PMCR_DEAD3", "NoisesSpec")
        chkNoises26.setValue(formTables, "PMCR_DEAD3", "NoisesLess26")
        chkNoises2645.setValue(formTables, "PMCR_DEAD3", "Noises2645")
        chkNoises4655.setValue(formTables, "PMCR_DEAD3", "Noises4655")
        chkNoises5665.setValue(formTables, "PMCR_DEAD3", "Noises5665")
        chkNoises6675.setValue(formTables, "PMCR_DEAD3", "Noises6675")
        chkNoises75.setValue(formTables, "PMCR_DEAD3", "NoisesMore75")
        txtVisual.setValue(formTables, "PMCR_DEAD3", "VisualSpec")
        chkVisual26.setValue(formTables, "PMCR_DEAD3", "VisualLess26")
        chkVisual2645.setValue(formTables, "PMCR_DEAD3", "Visual2645")
        chkVisual4655.setValue(formTables, "PMCR_DEAD3", "Visual4655")
        chkVisual5665.setValue(formTables, "PMCR_DEAD3", "Visual5665")
        chkVisual6675.setValue(formTables, "PMCR_DEAD3", "Visual6675")
        chkVisual75.setValue(formTables, "PMCR_DEAD3", "VisualMore75")
        txtOlfact.setValue(formTables, "PMCR_DEAD3", "OlfactorySpec")
        chkOlfact26.setValue(formTables, "PMCR_DEAD3", "OlfactoryLess26")
        chkOlfact2645.setValue(formTables, "PMCR_DEAD3", "Olfactory2645")
        chkOlfact4655.setValue(formTables, "PMCR_DEAD3", "Olfactory4655")
        chkOlfact5665.setValue(formTables, "PMCR_DEAD3", "Olfactory5665")
        chkOlfact6675.setValue(formTables, "PMCR_DEAD3", "Olfactory6675")
        chkOlfact75.setValue(formTables, "PMCR_DEAD3", "OlfactoryMore75")
        txtTactile.setValue(formTables, "PMCR_DEAD3", "SomaticSpec")
        chkTactile26.setValue(formTables, "PMCR_DEAD3", "SomaticLess26")
        chkTactile2645.setValue(formTables, "PMCR_DEAD3", "Somatic2645")
        chkTactile4655.setValue(formTables, "PMCR_DEAD3", "Somatic4655")
        chkTactile5665.setValue(formTables, "PMCR_DEAD3", "Somatic5665")
        chkTactile6675.setValue(formTables, "PMCR_DEAD3", "Somatic6675")
        chkTactile75.setValue(formTables, "PMCR_DEAD3", "SomaticMore75")
        txtUnspecDel.setValue(formTables, "PMCR_DEAD3", "UnspecDelusionsSpec")
        chkUnspecDel26.setValue(formTables, "PMCR_DEAD3", "UnspecDelusionsLess26")
        chkUnspecDel2645.setValue(formTables, "PMCR_DEAD3", "UnspecDelusions2645")
        chkUnspecDel4655.setValue(formTables, "PMCR_DEAD3", "UnspecDelusions4655")
        chkUnspecDel5665.setValue(formTables, "PMCR_DEAD3", "UnspecDelusions5665")
        chkUnspecDel6675.setValue(formTables, "PMCR_DEAD3", "UnspecDelusions6675")
        chkUnspecDel75.setValue(formTables, "PMCR_DEAD3", "UnspecDelusionsMore75")
        txtPersecut.setValue(formTables, "PMCR_DEAD3", "PersecutorySpec")
        chkPersecut26.setValue(formTables, "PMCR_DEAD3", "PersecutoryLess26")
        chkPersecut2645.setValue(formTables, "PMCR_DEAD3", "Persecutory2645")
        chkPersecut4655.setValue(formTables, "PMCR_DEAD3", "Persecutory4655")
        chkPersecut5665.setValue(formTables, "PMCR_DEAD3", "Persecutory5665")
        chkPersecut6675.setValue(formTables, "PMCR_DEAD3", "Persecutory6675")
        chkPersecut75.setValue(formTables, "PMCR_DEAD3", "PersecutoryMore75")
        txtGrandiose.setValue(formTables, "PMCR_DEAD3", "GrandioseSpec")
        chkGrandiose26.setValue(formTables, "PMCR_DEAD3", "GrandioseLess26")
        chkGrandiose2645.setValue(formTables, "PMCR_DEAD3", "Grandiose2645")
        chkGrandiose4655.setValue(formTables, "PMCR_DEAD3", "Grandiose4655")
        chkGrandiose5665.setValue(formTables, "PMCR_DEAD3", "Grandiose5665")
        chkGrandiose6675.setValue(formTables, "PMCR_DEAD3", "Grandiose6675")
        chkGrandiose75.setValue(formTables, "PMCR_DEAD3", "GrandioseMore75")
        txtOfControl.setValue(formTables, "PMCR_DEAD3", "ThoughtControlSpec")
        chkOfControl26.setValue(formTables, "PMCR_DEAD3", "ThoughtControlLess26")
        chkOfControl2645.setValue(formTables, "PMCR_DEAD3", "ThoughtControl2645")
        chkOfControl4655.setValue(formTables, "PMCR_DEAD3", "ThoughtControl4655")
        chkOfControl5665.setValue(formTables, "PMCR_DEAD3", "ThoughtControl5665")
        chkOfControl6675.setValue(formTables, "PMCR_DEAD3", "ThoughtControl6675")
        chkOfControl75.setValue(formTables, "PMCR_DEAD3", "ThoughtControlMore75")
        txtThoughtInsert.setValue(formTables, "PMCR_DEAD3", "ThoughtInsertSpec")
        chkThoughtInsert26.setValue(formTables, "PMCR_DEAD3", "ThoughtInsertLess26")
        chkThoughtInsert2645.setValue(formTables, "PMCR_DEAD3", "ThoughtInsert2645")
        chkThoughtInsert4655.setValue(formTables, "PMCR_DEAD3", "ThoughtInsert4655")
        chkThoughtInsert5665.setValue(formTables, "PMCR_DEAD3", "ThoughtInsert5665")
        chkThoughtInsert6675.setValue(formTables, "PMCR_DEAD3", "ThoughtInsert6675")
        chkThoughtInsert75.setValue(formTables, "PMCR_DEAD3", "ThoughtInsertMore75")
        txtOthBizDel.setValue(formTables, "PMCR_DEAD3", "OtherBizDelsSpec")
        chkOthBizDel26.setValue(formTables, "PMCR_DEAD3", "OtherBizDelsLess26")
        chkOthBizDel2645.setValue(formTables, "PMCR_DEAD3", "OtherBizDels2645")
        chkOthBizDel4655.setValue(formTables, "PMCR_DEAD3", "OtherBizDels4655")
        chkOthBizDel5665.setValue(formTables, "PMCR_DEAD3", "OtherBizDels5665")
        chkOthBizDel6675.setValue(formTables, "PMCR_DEAD3", "OtherBizDels6675")
        chkOthBizDel75.setValue(formTables, "PMCR_DEAD3", "OtherBizDelsMore75")
        txtOthGuilt.setValue(formTables, "PMCR_DEAD3", "HallOtherSpec")
        chkOthGuilt26.setValue(formTables, "PMCR_DEAD3", "HallOtherLess26")
        chkOthGuilt2645.setValue(formTables, "PMCR_DEAD3", "HallOther2645")
        chkOthGuilt4655.setValue(formTables, "PMCR_DEAD3", "HallOther4655")
        chkOthGuilt5665.setValue(formTables, "PMCR_DEAD3", "HallOther5665")
        chkOthGuilt6675.setValue(formTables, "PMCR_DEAD3", "HallOther6675")
        chkOthGuilt75.setValue(formTables, "PMCR_DEAD3", "HallOtherMore75")
        txtIdeasOfRef.setValue(formTables, "PMCR_DEAD3", "IdeasOfRefSpec")
        chkIdeasOfRef26.setValue(formTables, "PMCR_DEAD3", "IdeasOfRefLess26")
        chkIdeasOfRef2645.setValue(formTables, "PMCR_DEAD3", "IdeasOfRef2645")
        chkIdeasOfRef4655.setValue(formTables, "PMCR_DEAD3", "IdeasOfRef4655")
        chkIdeasOfRef5665.setValue(formTables, "PMCR_DEAD3", "IdeasOfRef5665")
        chkIdeasOfRef6675.setValue(formTables, "PMCR_DEAD3", "IdeasOfRef6675")
        chkIdeasOfRef75.setValue(formTables, "PMCR_DEAD3", "IdeasOfRefMore75")
        chkPervDepMood26.setValue(formTables, "PMCR_DEAD3", "PervDepMoodLess26")
        chkPervDepMood2645.setValue(formTables, "PMCR_DEAD3", "PervDepMood2645")
        chkPervDepMood4655.setValue(formTables, "PMCR_DEAD3", "PervDepMood4655")
        chkPervDepMood5665.setValue(formTables, "PMCR_DEAD3", "PervDepMood5665")
        chkPervDepMood6675.setValue(formTables, "PMCR_DEAD3", "PervDepMood6675")
        chkPervDepMood75.setValue(formTables, "PMCR_DEAD3", "PervDepMoodMore75")
        chkLossIntAct26.setValue(formTables, "PMCR_DEAD3", "LossInterestLess26")
        chkLossIntAct2645.setValue(formTables, "PMCR_DEAD3", "LossInterest2645")
        chkLossIntAct4655.setValue(formTables, "PMCR_DEAD3", "LossInterest4655")
        chkLossIntAct5665.setValue(formTables, "PMCR_DEAD3", "LossInterest5665")
        chkLossIntAct6675.setValue(formTables, "PMCR_DEAD3", "LossInterest6675")
        chkLossIntAct75.setValue(formTables, "PMCR_DEAD3", "LossInterestMore75")
        chkFlightIdeas26.setValue(formTables, "PMCR_DEAD3", "FlightIdeasLess26")
        chkFlightIdeas2645.setValue(formTables, "PMCR_DEAD3", "FlightIdeas2645")
        chkFlightIdeas4655.setValue(formTables, "PMCR_DEAD3", "FlightIdeas4655")
        chkFlightIdeas5665.setValue(formTables, "PMCR_DEAD3", "FlightIdeas5665")
        chkFlightIdeas6675.setValue(formTables, "PMCR_DEAD3", "FlightIdeas6675")
        chkFlightIdeas75.setValue(formTables, "PMCR_DEAD3", "FlightIdeasMore75")
        chkPovCont26.setValue(formTables, "PMCR_DEAD3", "PovOfContentLess26")
        chkPovCont2645.setValue(formTables, "PMCR_DEAD3", "PovOfContent2645")
        chkPovCont4655.setValue(formTables, "PMCR_DEAD3", "PovOfContent4655")
        chkPovCont5665.setValue(formTables, "PMCR_DEAD3", "PovOfContent5665")
        chkPovCont6675.setValue(formTables, "PMCR_DEAD3", "PovOfContent6675")
        chkPovCont75.setValue(formTables, "PMCR_DEAD3", "PovOfContentMore75")
        chkWordSalad26.setValue(formTables, "PMCR_DEAD3", "IncoherentLess26")
        chkWordSalad2645.setValue(formTables, "PMCR_DEAD3", "Incoherent2645")
        chkWordSalad4655.setValue(formTables, "PMCR_DEAD3", "Incoherent4655")
        chkWordSalad5665.setValue(formTables, "PMCR_DEAD3", "Incoherent5665")
        chkWordSalad6675.setValue(formTables, "PMCR_DEAD3", "Incoherent6675")
        chkWordSalad75.setValue(formTables, "PMCR_DEAD3", "IncoherentMore75")
        chkNeologism26.setValue(formTables, "PMCR_DEAD3", "NeologismLess26")
        chkNeologism2645.setValue(formTables, "PMCR_DEAD3", "Neologism2645")
        chkNeologism4655.setValue(formTables, "PMCR_DEAD3", "Neologism4655")
        chkNeologism5665.setValue(formTables, "PMCR_DEAD3", "Neologism5665")
        chkNeologism6675.setValue(formTables, "PMCR_DEAD3", "Neologism6675")
        chkNeologism75.setValue(formTables, "PMCR_DEAD3", "NeologismMore75")
        txtOthThoughtDis.setValue(formTables, "PMCR_DEAD3", "OtherThoughtDisSpec")
        chkOthThoughtDis26.setValue(formTables, "PMCR_DEAD3", "OtherThoughtDisLess26")
        chkOthThoughtDis2645.setValue(formTables, "PMCR_DEAD3", "OtherThoughtDis2645")
        chkOthThoughtDis4655.setValue(formTables, "PMCR_DEAD3", "OtherThoughtDis4655")
        chkOthThoughtDis5665.setValue(formTables, "PMCR_DEAD3", "OtherThoughtDis5665")
        chkOthThoughtDis6675.setValue(formTables, "PMCR_DEAD3", "OtherThoughtDis6675")
        chkOthThoughtDis75.setValue(formTables, "PMCR_DEAD3", "OtherThoughtDisMore75")
        chkPosturing26.setValue(formTables, "PMCR_DEAD3", "PosturingLess26")
        chkPosturing2645.setValue(formTables, "PMCR_DEAD3", "Posturing2645")
        chkPosturing4655.setValue(formTables, "PMCR_DEAD3", "Posturing4655")
        chkPosturing5665.setValue(formTables, "PMCR_DEAD3", "Posturing5665")
        chkPosturing6675.setValue(formTables, "PMCR_DEAD3", "Posturing6675")
        chkPosturing75.setValue(formTables, "PMCR_DEAD3", "PosturingMore75")
        chkStupor26.setValue(formTables, "PMCR_DEAD3", "StuporLess26")
        chkStupor2645.setValue(formTables, "PMCR_DEAD3", "Stupor2645")
        chkStupor4655.setValue(formTables, "PMCR_DEAD3", "Stupor4655")
        chkStupor5665.setValue(formTables, "PMCR_DEAD3", "Stupor5665")
        chkStupor6675.setValue(formTables, "PMCR_DEAD3", "Stupor6675")
        chkStupor75.setValue(formTables, "PMCR_DEAD3", "StuporMore75")
        chkRigid26.setValue(formTables, "PMCR_DEAD3", "RigidityLess26")
        chkRigid2645.setValue(formTables, "PMCR_DEAD3", "Rigidity2645")
        chkRigid4655.setValue(formTables, "PMCR_DEAD3", "Rigidity4655")
        chkRigid5665.setValue(formTables, "PMCR_DEAD3", "Rigidity5665")
        chkRigid6675.setValue(formTables, "PMCR_DEAD3", "Rigidity6675")
        chkRigid75.setValue(formTables, "PMCR_DEAD3", "RigidityMore75")
        txtOthCatatonic.setValue(formTables, "PMCR_DEAD3", "OtherCatatonicSpec")
        chkOthCatatonic26.setValue(formTables, "PMCR_DEAD3", "OtherCatatonicLess26")
        chkOthCatatonic2645.setValue(formTables, "PMCR_DEAD3", "OtherCatatonic2645")
        chkOthCatatonic4655.setValue(formTables, "PMCR_DEAD3", "OtherCatatonic4655")
        chkOthCatatonic5665.setValue(formTables, "PMCR_DEAD3", "OtherCatatonic5665")
        chkOthCatatonic6675.setValue(formTables, "PMCR_DEAD3", "OtherCatatonic6675")
        chkOthCatatonic75.setValue(formTables, "PMCR_DEAD3", "OtherCatatonicMore75")
        chkEmotDull26.setValue(formTables, "PMCR_DEAD3", "EmotDullLess26")
        chkEmotDull2645.setValue(formTables, "PMCR_DEAD3", "EmotDull2645")
        chkEmotDull4655.setValue(formTables, "PMCR_DEAD3", "EmotDull4655")
        chkEmotDull5665.setValue(formTables, "PMCR_DEAD3", "EmotDull5665")
        chkEmotDull6675.setValue(formTables, "PMCR_DEAD3", "EmotDull6675")
        chkEmotDull75.setValue(formTables, "PMCR_DEAD3", "EmotDullMore75")
        chkInappAffect26.setValue(formTables, "PMCR_DEAD3", "InappAffectLess26")
        chkInappAffect2645.setValue(formTables, "PMCR_DEAD3", "InappAffect2645")
        chkInappAffect4655.setValue(formTables, "PMCR_DEAD3", "InappAffect4655")
        chkInappAffect5665.setValue(formTables, "PMCR_DEAD3", "InappAffect5665")
        chkInappAffect6675.setValue(formTables, "PMCR_DEAD3", "InappAffect6675")
        chkInappAffect75.setValue(formTables, "PMCR_DEAD3", "InappAffectMore75")
        chkBizBeh26.setValue(formTables, "PMCR_DEAD3", "BizBehaveLess26")
        chkBizBeh2645.setValue(formTables, "PMCR_DEAD3", "BizBehave2645")
        chkBizBeh4655.setValue(formTables, "PMCR_DEAD3", "BizBehave4655")
        chkBizBeh5665.setValue(formTables, "PMCR_DEAD3", "BizBehave5665")
        chkBizBeh6675.setValue(formTables, "PMCR_DEAD3", "BizBehave6675")
        chkBizBeh75.setValue(formTables, "PMCR_DEAD3", "BizBehaveMore75")
        chkMannerism26.setValue(formTables, "PMCR_DEAD3", "MannerismLess26")
        chkMannerism2645.setValue(formTables, "PMCR_DEAD3", "Mannerism2645")
        chkMannerism4655.setValue(formTables, "PMCR_DEAD3", "Mannerism4655")
        chkMannerism5665.setValue(formTables, "PMCR_DEAD3", "Mannerism5665")
        chkMannerism6675.setValue(formTables, "PMCR_DEAD3", "Mannerism6675")
        chkMannerism75.setValue(formTables, "PMCR_DEAD3", "MannerismMore75")
        chkExcessDrink26.setValue(formTables, "PMCR_DEAD3", "ExcessDrinkLess26")
        chkExcessDrink2645.setValue(formTables, "PMCR_DEAD3", "ExcessDrink2645")
        chkExcessDrink4655.setValue(formTables, "PMCR_DEAD3", "ExcessDrink4655")
        chkExcessDrink5665.setValue(formTables, "PMCR_DEAD3", "ExcessDrink5665")
        chkExcessDrink6675.setValue(formTables, "PMCR_DEAD3", "ExcessDrink6675")
        chkExcessDrink75.setValue(formTables, "PMCR_DEAD3", "ExcessDrinkMore75")
        chkSilly26.setValue(formTables, "PMCR_DEAD3", "SillyBehLess26")
        chkSilly2645.setValue(formTables, "PMCR_DEAD3", "SillyBeh2645")
        chkSilly4655.setValue(formTables, "PMCR_DEAD3", "SillyBeh4655")
        chkSilly5665.setValue(formTables, "PMCR_DEAD3", "SillyBeh5665")
        chkSilly6675.setValue(formTables, "PMCR_DEAD3", "SillyBeh6675")
        chkSilly75.setValue(formTables, "PMCR_DEAD3", "SillyBehMore75")
        chkOdd26.setValue(formTables, "PMCR_DEAD3", "OddBeliefLess26")
        chkOdd2645.setValue(formTables, "PMCR_DEAD3", "OddBelief2645")
        chkOdd4655.setValue(formTables, "PMCR_DEAD3", "OddBelief4655")
        chkOdd5665.setValue(formTables, "PMCR_DEAD3", "OddBelief5665")
        chkOdd6675.setValue(formTables, "PMCR_DEAD3", "OddBelief6675")
        chkOdd75.setValue(formTables, "PMCR_DEAD3", "OddBeliefMore75")
        chkSocIso26.setValue(formTables, "PMCR_DEAD3", "SocialIsolationLess26")
        chkSocIso2645.setValue(formTables, "PMCR_DEAD3", "SocialIsolation2645")
        chkSocIso4655.setValue(formTables, "PMCR_DEAD3", "SocialIsolation4655")
        chkSocIso5665.setValue(formTables, "PMCR_DEAD3", "SocialIsolation5665")
        chkSocIso6675.setValue(formTables, "PMCR_DEAD3", "SocialIsolation6675")
        chkSocIso75.setValue(formTables, "PMCR_DEAD3", "SocialIsolationMore75")
        chkImpHyg26.setValue(formTables, "PMCR_DEAD3", "HygieneImpairLess26")
        chkImpHyg2645.setValue(formTables, "PMCR_DEAD3", "HygieneImpair2645")
        chkImpHyg4655.setValue(formTables, "PMCR_DEAD3", "HygieneImpair4655")
        chkImpHyg5665.setValue(formTables, "PMCR_DEAD3", "HygieneImpair5665")
        chkImpHyg6675.setValue(formTables, "PMCR_DEAD3", "HygieneImpair6675")
        chkImpHyg75.setValue(formTables, "PMCR_DEAD3", "HygieneImpairMore75")
        chkDiffDailyRout26.setValue(formTables, "PMCR_DEAD3", "DiffDailyRoutLess26")
        chkDiffDailyRout2645.setValue(formTables, "PMCR_DEAD3", "DiffDailyRout2645")
        chkDiffDailyRout4655.setValue(formTables, "PMCR_DEAD3", "DiffDailyRout4655")
        chkDiffDailyRout5665.setValue(formTables, "PMCR_DEAD3", "DiffDailyRout5665")
        chkDiffDailyRout6675.setValue(formTables, "PMCR_DEAD3", "DiffDailyRout6675")
        chkDiffDailyRout75.setValue(formTables, "PMCR_DEAD3", "DiffDailyRoutMore75")
        chkSerSuic26.setValue(formTables, "PMCR_DEAD3", "SerSuicideBehLess26")
        chkSerSuic2645.setValue(formTables, "PMCR_DEAD3", "SerSuicideBeh2645")
        chkSerSuic4655.setValue(formTables, "PMCR_DEAD3", "SerSuicideBeh4655")
        chkSerSuic5665.setValue(formTables, "PMCR_DEAD3", "SerSuicideBeh5665")
        chkSerSuic6675.setValue(formTables, "PMCR_DEAD3", "SerSuicideBeh6675")
        chkSerSuic75.setValue(formTables, "PMCR_DEAD3", "SerSuicideBehMore75")
        chkOthSuic26.setValue(formTables, "PMCR_DEAD3", "OthSuicideBehLess26")
        chkOthSuic2645.setValue(formTables, "PMCR_DEAD3", "OthSuicideBeh2645")
        chkOthSuic4655.setValue(formTables, "PMCR_DEAD3", "OthSuicideBeh4655")
        chkOthSuic5665.setValue(formTables, "PMCR_DEAD3", "OthSuicideBeh5665")
        chkOthSuic6675.setValue(formTables, "PMCR_DEAD3", "OthSuicideBeh6675")
        chkOthSuic75.setValue(formTables, "PMCR_DEAD3", "OthSuicideBehMore75")
        chkSelfMut26.setValue(formTables, "PMCR_DEAD3", "SelfMutilationLess26")
        chkSelfMut2645.setValue(formTables, "PMCR_DEAD3", "SelfMutilation2645")
        chkSelfMut4655.setValue(formTables, "PMCR_DEAD3", "SelfMutilation4655")
        chkSelfMut5665.setValue(formTables, "PMCR_DEAD3", "SelfMutilation5665")
        chkSelfMut6675.setValue(formTables, "PMCR_DEAD3", "SelfMutilation6675")
        chkSelfMut75.setValue(formTables, "PMCR_DEAD3", "SelfMutilationMore75")
        chkViolence26.setValue(formTables, "PMCR_DEAD3", "ViolenceLess26")
        chkViolence2645.setValue(formTables, "PMCR_DEAD3", "Violence2645")
        chkViolence4655.setValue(formTables, "PMCR_DEAD3", "Violence4655")
        chkViolence5665.setValue(formTables, "PMCR_DEAD3", "Violence5665")
        chkViolence6675.setValue(formTables, "PMCR_DEAD3", "Violence6675")
        chkViolence75.setValue(formTables, "PMCR_DEAD3", "ViolenceMore75")
        chkRestraint26.setValue(formTables, "PMCR_DEAD3", "RestraintLess26")
        chkRestraint2645.setValue(formTables, "PMCR_DEAD3", "Restraint2645")
        chkRestraint4655.setValue(formTables, "PMCR_DEAD3", "Restraint4655")
        chkRestraint5665.setValue(formTables, "PMCR_DEAD3", "Restraint5665")
        chkRestraint6675.setValue(formTables, "PMCR_DEAD3", "Restraint6675")
        chkRestraint75.setValue(formTables, "PMCR_DEAD3", "RestraintMore75")
        txtPhobiaSpec.setValue(formTables, "PMCR_DEAD3", "PhobiaSpec")
        chkPhobia26.setValue(formTables, "PMCR_DEAD3", "PhobiaLess26")
        chkPhobia2645.setValue(formTables, "PMCR_DEAD3", "Phobia2645")
        chkPhobia4655.setValue(formTables, "PMCR_DEAD3", "Phobia4655")
        chkPhobia5665.setValue(formTables, "PMCR_DEAD3", "Phobia5665")
        chkPhobia6675.setValue(formTables, "PMCR_DEAD3", "Phobia6675")
        chkPhobia75.setValue(formTables, "PMCR_DEAD3", "PhobiaMore75")
        txtPanicAttackSpec.setValue(formTables, "PMCR_DEAD3", "PanicAttackSpec")
        chkPanicAttack26.setValue(formTables, "PMCR_DEAD3", "PanicAttackLess26")
        chkPanicAttack2645.setValue(formTables, "PMCR_DEAD3", "PanicAttack2645")
        chkPanicAttack4655.setValue(formTables, "PMCR_DEAD3", "PanicAttack4655")
        chkPanicAttack5665.setValue(formTables, "PMCR_DEAD3", "PanicAttack5665")
        chkPanicAttack6675.setValue(formTables, "PMCR_DEAD3", "PanicAttack6675")
        chkPanicAttack75.setValue(formTables, "PMCR_DEAD3", "PanicAttackMore75")
        txtObsessionsSpec.setValue(formTables, "PMCR_DEAD3", "ObsessionsSpec")
        chkObsessions26.setValue(formTables, "PMCR_DEAD3", "ObsessionsLess26")
        chkObsessions2645.setValue(formTables, "PMCR_DEAD3", "Obsessions2645")
        chkObsessions4655.setValue(formTables, "PMCR_DEAD3", "Obsessions4655")
        chkObsessions5665.setValue(formTables, "PMCR_DEAD3", "Obsessions5665")
        chkObsessions6675.setValue(formTables, "PMCR_DEAD3", "Obsessions6675")
        chkObsessions75.setValue(formTables, "PMCR_DEAD3", "ObsessionsMore75")
        txtCompulsionsSpec.setValue(formTables, "PMCR_DEAD3", "CompulsionsSpec")
        chkCompulsions26.setValue(formTables, "PMCR_DEAD3", "CompulsionsLess26")
        chkCompulsions2645.setValue(formTables, "PMCR_DEAD3", "Compulsions2645")
        chkCompulsions4655.setValue(formTables, "PMCR_DEAD3", "Compulsions4655")
        chkCompulsions5665.setValue(formTables, "PMCR_DEAD3", "Compulsions5665")
        chkCompulsions6675.setValue(formTables, "PMCR_DEAD3", "Compulsions6675")
        chkCompulsions75.setValue(formTables, "PMCR_DEAD3", "CompulsionsMore75")
        chkSevGenAnx26.setValue(formTables, "PMCR_DEAD3", "SevGenAnxietyLess26")
        chkSevGenAnx2645.setValue(formTables, "PMCR_DEAD3", "SevGenAnxiety2645")
        chkSevGenAnx4655.setValue(formTables, "PMCR_DEAD3", "SevGenAnxiety4655")
        chkSevGenAnx5665.setValue(formTables, "PMCR_DEAD3", "SevGenAnxiety5665")
        chkSevGenAnx6675.setValue(formTables, "PMCR_DEAD3", "SevGenAnxiety6675")
        chkSevGenAnx75.setValue(formTables, "PMCR_DEAD3", "SevGenAnxietyMore75")
        chkHypochon26.setValue(formTables, "PMCR_DEAD3", "HypochonLess26")
        chkHypochon2645.setValue(formTables, "PMCR_DEAD3", "Hypochon2645")
        chkHypochon4655.setValue(formTables, "PMCR_DEAD3", "Hypochon4655")
        chkHypochon5665.setValue(formTables, "PMCR_DEAD3", "Hypochon5665")
        chkHypochon6675.setValue(formTables, "PMCR_DEAD3", "Hypochon6675")
        chkHypochon75.setValue(formTables, "PMCR_DEAD3", "HypochonMore75")
        chkDeperson26.setValue(formTables, "PMCR_DEAD3", "DepersonLess26")
        chkDeperson2645.setValue(formTables, "PMCR_DEAD3", "Deperson2645")
        chkDeperson4655.setValue(formTables, "PMCR_DEAD3", "Deperson4655")
        chkDeperson5665.setValue(formTables, "PMCR_DEAD3", "Deperson5665")
        chkDeperson6675.setValue(formTables, "PMCR_DEAD3", "Deperson6675")
        chkDeperson75.setValue(formTables, "PMCR_DEAD3", "DepersonMore75")
        txtPersonDisordSpec.setValue(formTables, "PMCR_DEAD3", "PersDisorderSpec")
        chkPersonDisord26.setValue(formTables, "PMCR_DEAD3", "PersDisorderLess26")
        chkPersonDisord2645.setValue(formTables, "PMCR_DEAD3", "PersDisorder2645")
        chkPersonDisord4655.setValue(formTables, "PMCR_DEAD3", "PersDisorder4655")
        chkPersonDisord5665.setValue(formTables, "PMCR_DEAD3", "PersDisorder5665")
        chkPersonDisord6675.setValue(formTables, "PMCR_DEAD3", "PersDisorder6675")
        chkPersonDisord75.setValue(formTables, "PMCR_DEAD3", "PersDisorderMore75")
        txtMiscSyptomsNotes.setValue(formTables, "PMCR_DEAD3", "MiscSymptComments")
        chkEviDel26.setValue(formTables, "PMCR_DEAD3", "EviOfDeliriumLess26")
        chkEviDel2645.setValue(formTables, "PMCR_DEAD3", "EviOfDelirium2645")
        chkEviDel4655.setValue(formTables, "PMCR_DEAD3", "EviOfDelirium4655")
        chkEviDel5665.setValue(formTables, "PMCR_DEAD3", "EviOfDelirium5665")
        chkEviDel6675.setValue(formTables, "PMCR_DEAD3", "EviOfDelirium6675")
        chkEviDel75.setValue(formTables, "PMCR_DEAD3", "EviOfDeliriumMore75")
        chkDisorient26.setValue(formTables, "PMCR_DEAD3", "DisorientationLess26")
        chkDisorient2645.setValue(formTables, "PMCR_DEAD3", "Disorientation2645")
        chkDisorient4655.setValue(formTables, "PMCR_DEAD3", "Disorientation4655")
        chkDisorient5665.setValue(formTables, "PMCR_DEAD3", "Disorientation5665")
        chkDisorient6675.setValue(formTables, "PMCR_DEAD3", "Disorientation6675")
        chkDisorient75.setValue(formTables, "PMCR_DEAD3", "DisorientationMore75")
        chkMemImp26.setValue(formTables, "PMCR_DEAD3", "MemImpairLess26")
        chkMemImp2645.setValue(formTables, "PMCR_DEAD3", "MemImpair2645")
        chkMemImp4655.setValue(formTables, "PMCR_DEAD3", "MemImpair4655")
        chkMemImp5665.setValue(formTables, "PMCR_DEAD3", "MemImpair5665")
        chkMemImp6675.setValue(formTables, "PMCR_DEAD3", "MemImpair6675")
        chkMemImp75.setValue(formTables, "PMCR_DEAD3", "MemImpairMore75")
        chkOthEviDis26.setValue(formTables, "PMCR_DEAD3", "OthEviDisorientLess26")
        chkOthEviDis2645.setValue(formTables, "PMCR_DEAD3", "OthEviDisorient2645")
        chkOthEviDis4655.setValue(formTables, "PMCR_DEAD3", "OthEviDisorient4655")
        chkOthEviDis5665.setValue(formTables, "PMCR_DEAD3", "OthEviDisorient5665")
        chkOthEviDis6675.setValue(formTables, "PMCR_DEAD3", "OthEviDisorient6675")
        chkOthEviDis75.setValue(formTables, "PMCR_DEAD3", "OthEviDisorientMore75")
        chkEviLangImp26.setValue(formTables, "PMCR_DEAD3", "EviLangImpLess26")
        chkEviLangImp2645.setValue(formTables, "PMCR_DEAD3", "EviLangImp2645")
        chkEviLangImp4655.setValue(formTables, "PMCR_DEAD3", "EviLangImp4655")
        chkEviLangImp5665.setValue(formTables, "PMCR_DEAD3", "EviLangImp5665")
        chkEviLangImp6675.setValue(formTables, "PMCR_DEAD3", "EviLangImp6675")
        chkEviLangImp75.setValue(formTables, "PMCR_DEAD3", "EviLangImpMore75")
        chkEviImpAbs26.setValue(formTables, "PMCR_DEAD3", "EviAbstrImpLess26")
        chkEviImpAbs2645.setValue(formTables, "PMCR_DEAD3", "EviAbstrImp2645")
        chkEviImpAbs4655.setValue(formTables, "PMCR_DEAD3", "EviAbstrImp4655")
        chkEviImpAbs5665.setValue(formTables, "PMCR_DEAD3", "EviAbstrImp5665")
        chkEviImpAbs6675.setValue(formTables, "PMCR_DEAD3", "EviAbstrImp6675")
        chkEviImpAbs75.setValue(formTables, "PMCR_DEAD3", "EviAbstrImpMore75")
        chkImpJudge26.setValue(formTables, "PMCR_DEAD3", "ImpJudgementLess26")
        chkImpJudge2645.setValue(formTables, "PMCR_DEAD3", "ImpJudgement2645")
        chkImpJudge4655.setValue(formTables, "PMCR_DEAD3", "ImpJudgement4655")
        chkImpJudge5665.setValue(formTables, "PMCR_DEAD3", "ImpJudgement5665")
        chkImpJudge6675.setValue(formTables, "PMCR_DEAD3", "ImpJudgement6675")
        chkImpJudge75.setValue(formTables, "PMCR_DEAD3", "ImpJudgementMore75")
        chkNeedsHelp26.setValue(formTables, "PMCR_DEAD3", "HelpFeedLess26")
        chkNeedsHelp2645.setValue(formTables, "PMCR_DEAD3", "HelpFeed2645")
        chkNeedsHelp4655.setValue(formTables, "PMCR_DEAD3", "HelpFeed4655")
        chkNeedsHelp5665.setValue(formTables, "PMCR_DEAD3", "HelpFeed5665")
        chkNeedsHelp6675.setValue(formTables, "PMCR_DEAD3", "HelpFeed6675")
        chkNeedsHelp75.setValue(formTables, "PMCR_DEAD3", "HelpFeedMore75")
        chkUrinIncont26.setValue(formTables, "PMCR_DEAD3", "UrinIncontLess26")
        chkUrinIncont2645.setValue(formTables, "PMCR_DEAD3", "UrinIncont2645")
        chkUrinIncont4655.setValue(formTables, "PMCR_DEAD3", "UrinIncont4655")
        chkUrinIncont5665.setValue(formTables, "PMCR_DEAD3", "UrinIncont5665")
        chkUrinIncont6675.setValue(formTables, "PMCR_DEAD3", "UrinIncont6675")
        chkUrinIncont75.setValue(formTables, "PMCR_DEAD3", "UrinIncontMore75")
        chkFecalIncont26.setValue(formTables, "PMCR_DEAD3", "FecalIncontLess26")
        chkFecalIncont2645.setValue(formTables, "PMCR_DEAD3", "FecalIncont2645")
        chkFecalIncont4655.setValue(formTables, "PMCR_DEAD3", "FecalIncont4655")
        chkFecalIncont5665.setValue(formTables, "PMCR_DEAD3", "FecalIncont5665")
        chkFecalIncont6675.setValue(formTables, "PMCR_DEAD3", "FecalIncont6675")
        chkFecalIncont75.setValue(formTables, "PMCR_DEAD3", "FecalIncontMore75")
        chkInablePlan26.setValue(formTables, "PMCR_DEAD3", "InableToPlanLess26")
        chkInablePlan2645.setValue(formTables, "PMCR_DEAD3", "InableToPlan2645")
        chkInablePlan4655.setValue(formTables, "PMCR_DEAD3", "InableToPlan4655")
        chkInablePlan5665.setValue(formTables, "PMCR_DEAD3", "InableToPlan5665")
        chkInablePlan6675.setValue(formTables, "PMCR_DEAD3", "InableToPlan6675")
        chkInablePlan75.setValue(formTables, "PMCR_DEAD3", "InableToPlanMore75")
        chkPersChange26.setValue(formTables, "PMCR_DEAD3", "PersChangeLess26")
        chkPersChange2645.setValue(formTables, "PMCR_DEAD3", "PersChange2645")
        chkPersChange4655.setValue(formTables, "PMCR_DEAD3", "PersChange4655")
        chkPersChange5665.setValue(formTables, "PMCR_DEAD3", "PersChange5665")
        chkPersChange6675.setValue(formTables, "PMCR_DEAD3", "PersChange6675")
        chkPersChange75.setValue(formTables, "PMCR_DEAD3", "PersChangeMore75")
        txtOthEviDemSpec.setValue(formTables, "PMCR_DEAD3", "OthEviDemSpec")
        chkOthEviDem26.setValue(formTables, "PMCR_DEAD3", "OthEviDemLess26")
        chkOthEviDem2645.setValue(formTables, "PMCR_DEAD3", "OthEviDem2645")
        chkOthEviDem4655.setValue(formTables, "PMCR_DEAD3", "OthEviDem4655")
        chkOthEviDem5665.setValue(formTables, "PMCR_DEAD3", "OthEviDem5665")
        chkOthEviDem6675.setValue(formTables, "PMCR_DEAD3", "OthEviDem6675")
        chkOthEviDem75.setValue(formTables, "PMCR_DEAD3", "OthEviDemMore75")
        txtCogImpNotes.setValue(formTables, "PMCR_DEAD3", "CogImpairNotes")
    End Sub
    Private Sub enableInputFields(ByVal bool As Boolean)
        If bool = True Then
            grpHallucinations.Enabled = True
            grpThoughtDisorder.Enabled = True
            grpCatatonic.Enabled = True
            grpAffect.Enabled = True
            grpMiscSymptoms.Enabled = True
            grpCognitiveImpairment.Enabled = True
        Else
            grpHallucinations.Enabled = False
            grpThoughtDisorder.Enabled = False
            grpCatatonic.Enabled = False
            grpAffect.Enabled = False
            grpMiscSymptoms.Enabled = False
            grpCognitiveImpairment.Enabled = False
        End If
    End Sub
    Private Sub btnDEAD3_Click(sender As Object, e As EventArgs) Handles btnDEAD3Bottom.Click, btnDEAD3Top.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_PMCR_Dead3", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                btnDEAD3Bottom.Text = "Save Changes"
                btnDEAD3Top.Text = btnDEAD3Bottom.Text
                enableInputFields(True)
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If User.PermissionCheck("WA_PMCR_Dead3", "Modify") Then
                loadBaseForm()
                lblNoRecord.Visible = False
                btnDEAD3Bottom.Text = "Save New Record"
                btnDEAD3Top.Text = "Save New Record"
                enableInputFields(True)
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
            End If
        Else 'By default, user is attempting to Insert or Edit a record. Run preSaveValidation.
            If preSaveValidation() Then 'If preSaveValidation returns true, take Insert or Update actions.
                'Same parameters for Insert or Update SP's, so define here
                Dim parameters = " @SubNum = " & WarehouseShell.SubNum &
                    ", @UnspecAuditorySpec = " & txtUnspecAud.getSQLValue() &
                    ", @UnspecAuditoryLess26 = " & chkUnspecAud26.getSQLValue() &
                    ", @UnspecAuditory2645 = " & chkUnspecAud2645.getSQLValue() &
                    ", @UnspecAuditory4655 = " & chkUnspecAud4655.getSQLValue() &
                    ", @UnspecAuditory5665 = " & chkUnspecAud5665.getSQLValue() &
                    ", @UnspecAuditory6675 = " & chkUnspecAud6675.getSQLValue() &
                    ", @UnspecAuditoryMore75 = " & chkUnspecAud75.getSQLValue() &
                    ", @SingleVoiceSpec = " & txtVoiceSingle.getSQLValue() &
                    ", @SingleVoiceLess26 = " & chkVoiceSingle26.getSQLValue() &
                    ", @SingleVoice2645 = " & chkVoiceSingle2645.getSQLValue() &
                    ", @SingleVoice4655 = " & chkVoiceSingle4655.getSQLValue() &
                    ", @SingleVoice5665 = " & chkVoiceSingle5665.getSQLValue() &
                    ", @SingleVoice6675 = " & chkVoiceSingle6675.getSQLValue() &
                    ", @SingleVoiceMore75 = " & chkVoiceSingle75.getSQLValue() &
                    ", @MultVoicesSpec = " & txtVoiceTwo.getSQLValue() &
                    ", @MultVoicesLess26 = " & chkVoiceTwo26.getSQLValue() &
                    ", @MultVoices2645 = " & chkVoiceTwo2645.getSQLValue() &
                    ", @MultVoices4655 = " & chkVoiceTwo4655.getSQLValue() &
                    ", @MultVoices5665 = " & chkVoiceTwo5665.getSQLValue() &
                    ", @MultVoices6675 = " & chkVoiceTwo6675.getSQLValue() &
                    ", @MultVoicesMore75 = " & chkVoiceTwo75.getSQLValue() &
                    ", @CommVoicesSpec = " & txtVoicesComm.getSQLValue() &
                    ", @CommVoicesLess26 = " & chkVoicesComm26.getSQLValue() &
                    ", @CommVoices2645 = " & chkVoicesComm2645.getSQLValue() &
                    ", @CommVoices4655 = " & chkVoicesComm4655.getSQLValue() &
                    ", @CommVoices5665 = " & chkVoicesComm5665.getSQLValue() &
                    ", @CommVoices6675 = " & chkVoicesComm6675.getSQLValue() &
                    ", @CommVoicesMore75 = " & chkVoicesComm75.getSQLValue() &
                    ", @NoisesSpec = " & txtNoises.getSQLValue() &
                    ", @NoisesLess26 = " & chkNoises26.getSQLValue() &
                    ", @Noises2645 = " & chkNoises2645.getSQLValue() &
                    ", @Noises4655 = " & chkNoises4655.getSQLValue() &
                    ", @Noises5665 = " & chkNoises5665.getSQLValue() &
                    ", @Noises6675 = " & chkNoises6675.getSQLValue() &
                    ", @NoisesMore75 = " & chkNoises75.getSQLValue() &
                    ", @VisualSpec = " & txtVisual.getSQLValue() &
                    ", @VisualLess26 = " & chkVisual26.getSQLValue() &
                    ", @Visual2645 = " & chkVisual2645.getSQLValue() &
                    ", @Visual4655 = " & chkVisual4655.getSQLValue() &
                    ", @Visual5665 = " & chkVisual5665.getSQLValue() &
                    ", @Visual6675 = " & chkVisual6675.getSQLValue() &
                    ", @VisualMore75 = " & chkVisual75.getSQLValue() &
                    ", @OlfactorySpec = " & txtOlfact.getSQLValue() &
                    ", @OlfactoryLess26 = " & chkOlfact26.getSQLValue() &
                    ", @Olfactory2645 = " & chkOlfact2645.getSQLValue() &
                    ", @Olfactory4655 = " & chkOlfact4655.getSQLValue() &
                    ", @Olfactory5665 = " & chkOlfact5665.getSQLValue() &
                    ", @Olfactory6675 = " & chkOlfact6675.getSQLValue() &
                    ", @OlfactoryMore75 = " & chkOlfact75.getSQLValue() &
                    ", @SomaticSpec = " & txtTactile.getSQLValue() &
                    ", @SomaticLess26 = " & chkTactile26.getSQLValue() &
                    ", @Somatic2645 = " & chkTactile2645.getSQLValue() &
                    ", @Somatic4655 = " & chkTactile4655.getSQLValue() &
                    ", @Somatic5665 = " & chkTactile5665.getSQLValue() &
                    ", @Somatic6675 = " & chkTactile6675.getSQLValue() &
                    ", @SomaticMore75 = " & chkTactile75.getSQLValue() &
                    ", @UnspecDelusionsSpec = " & txtUnspecDel.getSQLValue() &
                    ", @UnspecDelusionsLess26 = " & chkUnspecDel26.getSQLValue() &
                    ", @UnspecDelusions2645 = " & chkUnspecDel2645.getSQLValue() &
                    ", @UnspecDelusions4655 = " & chkUnspecDel4655.getSQLValue() &
                    ", @UnspecDelusions5665 = " & chkUnspecDel5665.getSQLValue() &
                    ", @UnspecDelusions6675 = " & chkUnspecDel6675.getSQLValue() &
                    ", @UnspecDelusionsMore75 = " & chkUnspecDel75.getSQLValue() &
                    ", @PersecutorySpec = " & txtPersecut.getSQLValue() &
                    ", @PersecutoryLess26 = " & chkPersecut26.getSQLValue() &
                    ", @Persecutory2645 = " & chkPersecut2645.getSQLValue() &
                    ", @Persecutory4655 = " & chkPersecut4655.getSQLValue() &
                    ", @Persecutory5665 = " & chkPersecut5665.getSQLValue() &
                    ", @Persecutory6675 = " & chkPersecut6675.getSQLValue() &
                    ", @PersecutoryMore75 = " & chkPersecut75.getSQLValue() &
                    ", @GrandioseSpec = " & txtGrandiose.getSQLValue() &
                    ", @GrandioseLess26 = " & chkGrandiose26.getSQLValue() &
                    ", @Grandiose2645 = " & chkGrandiose2645.getSQLValue() &
                    ", @Grandiose4655 = " & chkGrandiose4655.getSQLValue() &
                    ", @Grandiose5665 = " & chkGrandiose5665.getSQLValue() &
                    ", @Grandiose6675 = " & chkGrandiose6675.getSQLValue() &
                    ", @GrandioseMore75 = " & chkGrandiose75.getSQLValue() &
                    ", @ThoughtControlSpec = " & txtOfControl.getSQLValue() &
                    ", @ThoughtControlLess26 = " & chkOfControl26.getSQLValue() &
                    ", @ThoughtControl2645 = " & chkOfControl2645.getSQLValue() &
                    ", @ThoughtControl4655 = " & chkOfControl4655.getSQLValue() &
                    ", @ThoughtControl5665 = " & chkOfControl5665.getSQLValue() &
                    ", @ThoughtControl6675 = " & chkOfControl6675.getSQLValue() &
                    ", @ThoughtControlMore75 = " & chkOfControl75.getSQLValue() &
                    ", @ThoughtInsertSpec = " & txtThoughtInsert.getSQLValue() &
                    ", @ThoughtInsertLess26 = " & chkThoughtInsert26.getSQLValue() &
                    ", @ThoughtInsert2645 = " & chkThoughtInsert2645.getSQLValue() &
                    ", @ThoughtInsert4655 = " & chkThoughtInsert4655.getSQLValue() &
                    ", @ThoughtInsert5665 = " & chkThoughtInsert5665.getSQLValue() &
                    ", @ThoughtInsert6675 = " & chkThoughtInsert6675.getSQLValue() &
                    ", @ThoughtInsertMore75 = " & chkThoughtInsert75.getSQLValue() &
                    ", @OtherBizDelsSpec = " & txtOthBizDel.getSQLValue() &
                    ", @OtherBizDelsLess26 = " & chkOthBizDel26.getSQLValue() &
                    ", @OtherBizDels2645 = " & chkOthBizDel2645.getSQLValue() &
                    ", @OtherBizDels4655 = " & chkOthBizDel4655.getSQLValue() &
                    ", @OtherBizDels5665 = " & chkOthBizDel5665.getSQLValue() &
                    ", @OtherBizDels6675 = " & chkOthBizDel6675.getSQLValue() &
                    ", @OtherBizDelsMore75 = " & chkOthBizDel75.getSQLValue() &
                    ", @HallOtherSpec = " & txtOthGuilt.getSQLValue() &
                    ", @HallOtherLess26 = " & chkOthGuilt26.getSQLValue() &
                    ", @HallOther2645 = " & chkOthGuilt2645.getSQLValue() &
                    ", @HallOther4655 = " & chkOthGuilt4655.getSQLValue() &
                    ", @HallOther5665 = " & chkOthGuilt5665.getSQLValue() &
                    ", @HallOther6675 = " & chkOthGuilt6675.getSQLValue() &
                    ", @HallOtherMore75 = " & chkOthGuilt75.getSQLValue() &
                    ", @IdeasOfRefSpec = " & txtIdeasOfRef.getSQLValue() &
                    ", @IdeasOfRefLess26 = " & chkIdeasOfRef26.getSQLValue() &
                    ", @IdeasOfRef2645 = " & chkIdeasOfRef2645.getSQLValue() &
                    ", @IdeasOfRef4655 = " & chkIdeasOfRef4655.getSQLValue() &
                    ", @IdeasOfRef5665 = " & chkIdeasOfRef5665.getSQLValue() &
                    ", @IdeasOfRef6675 = " & chkIdeasOfRef6675.getSQLValue() &
                    ", @IdeasOfRefMore75 = " & chkIdeasOfRef75.getSQLValue() &
                    ", @PervDepMoodLess26 = " & chkPervDepMood26.getSQLValue() &
                    ", @PervDepMood2645 = " & chkPervDepMood2645.getSQLValue() &
                    ", @PervDepMood4655 = " & chkPervDepMood4655.getSQLValue() &
                    ", @PervDepMood5665 = " & chkPervDepMood5665.getSQLValue() &
                    ", @PervDepMood6675 = " & chkPervDepMood6675.getSQLValue() &
                    ", @PervDepMoodMore75 = " & chkPervDepMood75.getSQLValue() &
                    ", @LossInterestLess26 = " & chkLossIntAct26.getSQLValue() &
                    ", @LossInterest2645 = " & chkLossIntAct2645.getSQLValue() &
                    ", @LossInterest4655 = " & chkLossIntAct4655.getSQLValue() &
                    ", @LossInterest5665 = " & chkLossIntAct5665.getSQLValue() &
                    ", @LossInterest6675 = " & chkLossIntAct6675.getSQLValue() &
                    ", @LossInterestMore75 = " & chkLossIntAct75.getSQLValue() &
                    ", @FlightIdeasLess26 = " & chkFlightIdeas26.getSQLValue() &
                    ", @FlightIdeas2645 = " & chkFlightIdeas2645.getSQLValue() &
                    ", @FlightIdeas4655 = " & chkFlightIdeas4655.getSQLValue() &
                    ", @FlightIdeas5665 = " & chkFlightIdeas5665.getSQLValue() &
                    ", @FlightIdeas6675 = " & chkFlightIdeas6675.getSQLValue() &
                    ", @FlightIdeasMore75 = " & chkFlightIdeas75.getSQLValue() &
                    ", @PovOfContentLess26 = " & chkPovCont26.getSQLValue() &
                    ", @PovOfContent2645 = " & chkPovCont2645.getSQLValue() &
                    ", @PovOfContent4655 = " & chkPovCont4655.getSQLValue() &
                    ", @PovOfContent5665 = " & chkPovCont5665.getSQLValue() &
                    ", @PovOfContent6675 = " & chkPovCont6675.getSQLValue() &
                    ", @PovOfContentMore75 = " & chkPovCont75.getSQLValue() &
                    ", @IncoherentLess26 = " & chkWordSalad26.getSQLValue() &
                    ", @Incoherent2645 = " & chkWordSalad2645.getSQLValue() &
                    ", @Incoherent4655 = " & chkWordSalad4655.getSQLValue() &
                    ", @Incoherent5665 = " & chkWordSalad5665.getSQLValue() &
                    ", @Incoherent6675 = " & chkWordSalad6675.getSQLValue() &
                    ", @IncoherentMore75 = " & chkWordSalad75.getSQLValue() &
                    ", @NeologismLess26 = " & chkNeologism26.getSQLValue() &
                    ", @Neologism2645 = " & chkNeologism2645.getSQLValue() &
                    ", @Neologism4655 = " & chkNeologism4655.getSQLValue() &
                    ", @Neologism5665 = " & chkNeologism5665.getSQLValue() &
                    ", @Neologism6675 = " & chkNeologism6675.getSQLValue() &
                    ", @NeologismMore75 = " & chkNeologism75.getSQLValue() &
                    ", @OtherThoughtDisSpec = " & txtOthThoughtDis.getSQLValue() &
                    ", @OtherThoughtDisLess26 = " & chkOthThoughtDis26.getSQLValue() &
                    ", @OtherThoughtDis2645 = " & chkOthThoughtDis2645.getSQLValue() &
                    ", @OtherThoughtDis4655 = " & chkOthThoughtDis4655.getSQLValue() &
                    ", @OtherThoughtDis5665 = " & chkOthThoughtDis5665.getSQLValue() &
                    ", @OtherThoughtDis6675 = " & chkOthThoughtDis6675.getSQLValue() &
                    ", @OtherThoughtDisMore75 = " & chkOthThoughtDis75.getSQLValue() &
                    ", @PosturingLess26 = " & chkPosturing26.getSQLValue() &
                    ", @Posturing2645 = " & chkPosturing2645.getSQLValue() &
                    ", @Posturing4655 = " & chkPosturing4655.getSQLValue() &
                    ", @Posturing5665 = " & chkPosturing5665.getSQLValue() &
                    ", @Posturing6675 = " & chkPosturing6675.getSQLValue() &
                    ", @PosturingMore75 = " & chkPosturing75.getSQLValue() &
                    ", @StuporLess26 = " & chkStupor26.getSQLValue() &
                    ", @Stupor2645 = " & chkStupor2645.getSQLValue() &
                    ", @Stupor4655 = " & chkStupor4655.getSQLValue() &
                    ", @Stupor5665 = " & chkStupor5665.getSQLValue() &
                    ", @Stupor6675 = " & chkStupor6675.getSQLValue() &
                    ", @StuporMore75 = " & chkStupor75.getSQLValue() &
                    ", @RigidityLess26 = " & chkRigid26.getSQLValue() &
                    ", @Rigidity2645 = " & chkRigid2645.getSQLValue() &
                    ", @Rigidity4655 = " & chkRigid4655.getSQLValue() &
                    ", @Rigidity5665 = " & chkRigid5665.getSQLValue() &
                    ", @Rigidity6675 = " & chkRigid6675.getSQLValue() &
                    ", @RigidityMore75 = " & chkRigid75.getSQLValue() &
                    ", @OtherCatatonicSpec = " & txtOthCatatonic.getSQLValue() &
                    ", @OtherCatatonicLess26 = " & chkOthCatatonic26.getSQLValue() &
                    ", @OtherCatatonic2645 = " & chkOthCatatonic2645.getSQLValue() &
                    ", @OtherCatatonic4655 = " & chkOthCatatonic4655.getSQLValue() &
                    ", @OtherCatatonic5665 = " & chkOthCatatonic5665.getSQLValue() &
                    ", @OtherCatatonic6675 = " & chkOthCatatonic6675.getSQLValue() &
                    ", @OtherCatatonicMore75 = " & chkOthCatatonic75.getSQLValue() &
                    ", @EmotDullLess26 = " & chkEmotDull26.getSQLValue() &
                    ", @EmotDull2645 = " & chkEmotDull2645.getSQLValue() &
                    ", @EmotDull4655 = " & chkEmotDull4655.getSQLValue() &
                    ", @EmotDull5665 = " & chkEmotDull5665.getSQLValue() &
                    ", @EmotDull6675 = " & chkEmotDull6675.getSQLValue() &
                    ", @EmotDullMore75 = " & chkEmotDull75.getSQLValue() &
                    ", @InappAffectLess26 = " & chkInappAffect26.getSQLValue() &
                    ", @InappAffect2645 = " & chkInappAffect2645.getSQLValue() &
                    ", @InappAffect4655 = " & chkInappAffect4655.getSQLValue() &
                    ", @InappAffect5665 = " & chkInappAffect5665.getSQLValue() &
                    ", @InappAffect6675 = " & chkInappAffect6675.getSQLValue() &
                    ", @InappAffectMore75 = " & chkInappAffect75.getSQLValue() &
                    ", @BizBehaveLess26 = " & chkBizBeh26.getSQLValue() &
                    ", @BizBehave2645 = " & chkBizBeh2645.getSQLValue() &
                    ", @BizBehave4655 = " & chkBizBeh4655.getSQLValue() &
                    ", @BizBehave5665 = " & chkBizBeh5665.getSQLValue() &
                    ", @BizBehave6675 = " & chkBizBeh6675.getSQLValue() &
                    ", @BizBehaveMore75 = " & chkBizBeh75.getSQLValue() &
                    ", @MannerismLess26 = " & chkMannerism26.getSQLValue() &
                    ", @Mannerism2645 = " & chkMannerism2645.getSQLValue() &
                    ", @Mannerism4655 = " & chkMannerism4655.getSQLValue() &
                    ", @Mannerism5665 = " & chkMannerism5665.getSQLValue() &
                    ", @Mannerism6675 = " & chkMannerism6675.getSQLValue() &
                    ", @MannerismMore75 = " & chkMannerism75.getSQLValue() &
                    ", @ExcessDrinkLess26 = " & chkExcessDrink26.getSQLValue() &
                    ", @ExcessDrink2645 = " & chkExcessDrink2645.getSQLValue() &
                    ", @ExcessDrink4655 = " & chkExcessDrink4655.getSQLValue() &
                    ", @ExcessDrink5665 = " & chkExcessDrink5665.getSQLValue() &
                    ", @ExcessDrink6675 = " & chkExcessDrink6675.getSQLValue() &
                    ", @ExcessDrinkMore75 = " & chkExcessDrink75.getSQLValue() &
                    ", @SillyBehLess26 = " & chkSilly26.getSQLValue() &
                    ", @SillyBeh2645 = " & chkSilly2645.getSQLValue() &
                    ", @SillyBeh4655 = " & chkSilly4655.getSQLValue() &
                    ", @SillyBeh5665 = " & chkSilly5665.getSQLValue() &
                    ", @SillyBeh6675 = " & chkSilly6675.getSQLValue() &
                    ", @SillyBehMore75 = " & chkSilly75.getSQLValue() &
                    ", @OddBeliefLess26 = " & chkOdd26.getSQLValue() &
                    ", @OddBelief2645 = " & chkOdd2645.getSQLValue() &
                    ", @OddBelief4655 = " & chkOdd4655.getSQLValue() &
                    ", @OddBelief5665 = " & chkOdd5665.getSQLValue() &
                    ", @OddBelief6675 = " & chkOdd6675.getSQLValue() &
                    ", @OddBeliefMore75 = " & chkOdd75.getSQLValue() &
                    ", @SocialIsolationLess26 = " & chkSocIso26.getSQLValue() &
                    ", @SocialIsolation2645 = " & chkSocIso2645.getSQLValue() &
                    ", @SocialIsolation4655 = " & chkSocIso4655.getSQLValue() &
                    ", @SocialIsolation5665 = " & chkSocIso5665.getSQLValue() &
                    ", @SocialIsolation6675 = " & chkSocIso6675.getSQLValue() &
                    ", @SocialIsolationMore75 = " & chkSocIso75.getSQLValue() &
                    ", @HygieneImpairLess26 = " & chkImpHyg26.getSQLValue() &
                    ", @HygieneImpair2645 = " & chkImpHyg2645.getSQLValue() &
                    ", @HygieneImpair4655 = " & chkImpHyg4655.getSQLValue() &
                    ", @HygieneImpair5665 = " & chkImpHyg5665.getSQLValue() &
                    ", @HygieneImpair6675 = " & chkImpHyg6675.getSQLValue() &
                    ", @HygieneImpairMore75 = " & chkImpHyg75.getSQLValue() &
                    ", @DiffDailyRoutLess26 = " & chkDiffDailyRout26.getSQLValue() &
                    ", @DiffDailyRout2645 = " & chkDiffDailyRout2645.getSQLValue() &
                    ", @DiffDailyRout4655 = " & chkDiffDailyRout4655.getSQLValue() &
                    ", @DiffDailyRout5665 = " & chkDiffDailyRout5665.getSQLValue() &
                    ", @DiffDailyRout6675 = " & chkDiffDailyRout6675.getSQLValue() &
                    ", @DiffDailyRoutMore75 = " & chkDiffDailyRout75.getSQLValue() &
                    ", @SerSuicideBehLess26 = " & chkSerSuic26.getSQLValue() &
                    ", @SerSuicideBeh2645 = " & chkSerSuic2645.getSQLValue() &
                    ", @SerSuicideBeh4655 = " & chkSerSuic4655.getSQLValue() &
                    ", @SerSuicideBeh5665 = " & chkSerSuic5665.getSQLValue() &
                    ", @SerSuicideBeh6675 = " & chkSerSuic6675.getSQLValue() &
                    ", @SerSuicideBehMore75 = " & chkSerSuic75.getSQLValue() &
                    ", @OthSuicideBehLess26 = " & chkOthSuic26.getSQLValue() &
                    ", @OthSuicideBeh2645 = " & chkOthSuic2645.getSQLValue() &
                    ", @OthSuicideBeh4655 = " & chkOthSuic4655.getSQLValue() &
                    ", @OthSuicideBeh5665 = " & chkOthSuic5665.getSQLValue() &
                    ", @OthSuicideBeh6675 = " & chkOthSuic6675.getSQLValue() &
                    ", @OthSuicideBehMore75 = " & chkOthSuic75.getSQLValue() &
                    ", @SelfMutilationLess26 = " & chkSelfMut26.getSQLValue() &
                    ", @SelfMutilation2645 = " & chkSelfMut2645.getSQLValue() &
                    ", @SelfMutilation4655 = " & chkSelfMut4655.getSQLValue() &
                    ", @SelfMutilation5665 = " & chkSelfMut5665.getSQLValue() &
                    ", @SelfMutilation6675 = " & chkSelfMut6675.getSQLValue() &
                    ", @SelfMutilationMore75 = " & chkSelfMut75.getSQLValue() &
                    ", @ViolenceLess26 = " & chkViolence26.getSQLValue() &
                    ", @Violence2645 = " & chkViolence2645.getSQLValue() &
                    ", @Violence4655 = " & chkViolence4655.getSQLValue() &
                    ", @Violence5665 = " & chkViolence5665.getSQLValue() &
                    ", @Violence6675 = " & chkViolence6675.getSQLValue() &
                    ", @ViolenceMore75 = " & chkViolence75.getSQLValue() &
                    ", @RestraintLess26 = " & chkRestraint26.getSQLValue() &
                    ", @Restraint2645 = " & chkRestraint2645.getSQLValue() &
                    ", @Restraint4655 = " & chkRestraint4655.getSQLValue() &
                    ", @Restraint5665 = " & chkRestraint5665.getSQLValue() &
                    ", @Restraint6675 = " & chkRestraint6675.getSQLValue() &
                    ", @RestraintMore75 = " & chkRestraint75.getSQLValue() &
                    ", @PhobiaSpec = " & txtPhobiaSpec.getSQLValue() &
                    ", @PhobiaLess26 = " & chkPhobia26.getSQLValue() &
                    ", @Phobia2645 = " & chkPhobia2645.getSQLValue() &
                    ", @Phobia4655 = " & chkPhobia4655.getSQLValue() &
                    ", @Phobia5665 = " & chkPhobia5665.getSQLValue() &
                    ", @Phobia6675 = " & chkPhobia6675.getSQLValue() &
                    ", @PhobiaMore75 = " & chkPhobia75.getSQLValue() &
                    ", @PanicAttackSpec = " & txtPanicAttackSpec.getSQLValue() &
                    ", @PanicAttackLess26 = " & chkPanicAttack26.getSQLValue() &
                    ", @PanicAttack2645 = " & chkPanicAttack2645.getSQLValue() &
                    ", @PanicAttack4655 = " & chkPanicAttack4655.getSQLValue() &
                    ", @PanicAttack5665 = " & chkPanicAttack5665.getSQLValue() &
                    ", @PanicAttack6675 = " & chkPanicAttack6675.getSQLValue() &
                    ", @PanicAttackMore75 = " & chkPanicAttack75.getSQLValue() &
                    ", @ObsessionsSpec = " & txtObsessionsSpec.getSQLValue() &
                    ", @ObsessionsLess26 = " & chkObsessions26.getSQLValue() &
                    ", @Obsessions2645 = " & chkObsessions2645.getSQLValue() &
                    ", @Obsessions4655 = " & chkObsessions4655.getSQLValue() &
                    ", @Obsessions5665 = " & chkObsessions5665.getSQLValue() &
                    ", @Obsessions6675 = " & chkObsessions6675.getSQLValue() &
                    ", @ObsessionsMore75 = " & chkObsessions75.getSQLValue() &
                    ", @CompulsionsSpec = " & txtCompulsionsSpec.getSQLValue() &
                    ", @CompulsionsLess26 = " & chkCompulsions26.getSQLValue() &
                    ", @Compulsions2645 = " & chkCompulsions2645.getSQLValue() &
                    ", @Compulsions4655 = " & chkCompulsions4655.getSQLValue() &
                    ", @Compulsions5665 = " & chkCompulsions5665.getSQLValue() &
                    ", @Compulsions6675 = " & chkCompulsions6675.getSQLValue() &
                    ", @CompulsionsMore75 = " & chkCompulsions75.getSQLValue() &
                    ", @SevGenAnxietyLess26 = " & chkSevGenAnx26.getSQLValue() &
                    ", @SevGenAnxiety2645 = " & chkSevGenAnx2645.getSQLValue() &
                    ", @SevGenAnxiety4655 = " & chkSevGenAnx4655.getSQLValue() &
                    ", @SevGenAnxiety5665 = " & chkSevGenAnx5665.getSQLValue() &
                    ", @SevGenAnxiety6675 = " & chkSevGenAnx6675.getSQLValue() &
                    ", @SevGenAnxietyMore75 = " & chkSevGenAnx75.getSQLValue() &
                    ", @HypochonLess26 = " & chkHypochon26.getSQLValue() &
                    ", @Hypochon2645 = " & chkHypochon2645.getSQLValue() &
                    ", @Hypochon4655 = " & chkHypochon4655.getSQLValue() &
                    ", @Hypochon5665 = " & chkHypochon5665.getSQLValue() &
                    ", @Hypochon6675 = " & chkHypochon6675.getSQLValue() &
                    ", @HypochonMore75 = " & chkHypochon75.getSQLValue() &
                    ", @DepersonLess26 = " & chkDeperson26.getSQLValue() &
                    ", @Deperson2645 = " & chkDeperson2645.getSQLValue() &
                    ", @Deperson4655 = " & chkDeperson4655.getSQLValue() &
                    ", @Deperson5665 = " & chkDeperson5665.getSQLValue() &
                    ", @Deperson6675 = " & chkDeperson6675.getSQLValue() &
                    ", @DepersonMore75 = " & chkDeperson75.getSQLValue() &
                    ", @PersDisorderSpec = " & txtPersonDisordSpec.getSQLValue() &
                    ", @PersDisorderLess26 = " & chkPersonDisord26.getSQLValue() &
                    ", @PersDisorder2645 = " & chkPersonDisord2645.getSQLValue() &
                    ", @PersDisorder4655 = " & chkPersonDisord4655.getSQLValue() &
                    ", @PersDisorder5665 = " & chkPersonDisord5665.getSQLValue() &
                    ", @PersDisorder6675 = " & chkPersonDisord6675.getSQLValue() &
                    ", @PersDisorderMore75 = " & chkPersonDisord75.getSQLValue() &
                    ", @MiscSymptComments = " & txtMiscSyptomsNotes.getSQLValue() &
                    ", @EviOfDeliriumLess26 = " & chkEviDel26.getSQLValue() &
                    ", @EviOfDelirium2645 = " & chkEviDel2645.getSQLValue() &
                    ", @EviOfDelirium4655 = " & chkEviDel4655.getSQLValue() &
                    ", @EviOfDelirium5665 = " & chkEviDel5665.getSQLValue() &
                    ", @EviOfDelirium6675 = " & chkEviDel6675.getSQLValue() &
                    ", @EviOfDeliriumMore75 = " & chkEviDel75.getSQLValue() &
                    ", @DisorientationLess26 = " & chkDisorient26.getSQLValue() &
                    ", @Disorientation2645 = " & chkDisorient2645.getSQLValue() &
                    ", @Disorientation4655 = " & chkDisorient4655.getSQLValue() &
                    ", @Disorientation5665 = " & chkDisorient5665.getSQLValue() &
                    ", @Disorientation6675 = " & chkDisorient6675.getSQLValue() &
                    ", @DisorientationMore75 = " & chkDisorient75.getSQLValue() &
                    ", @MemImpairLess26 = " & chkMemImp26.getSQLValue() &
                    ", @MemImpair2645 = " & chkMemImp2645.getSQLValue() &
                    ", @MemImpair4655 = " & chkMemImp4655.getSQLValue() &
                    ", @MemImpair5665 = " & chkMemImp5665.getSQLValue() &
                    ", @MemImpair6675 = " & chkMemImp6675.getSQLValue() &
                    ", @MemImpairMore75 = " & chkMemImp75.getSQLValue() &
                    ", @OthEviDisorientLess26 = " & chkOthEviDis26.getSQLValue() &
                    ", @OthEviDisorient2645 = " & chkOthEviDis2645.getSQLValue() &
                    ", @OthEviDisorient4655 = " & chkOthEviDis4655.getSQLValue() &
                    ", @OthEviDisorient5665 = " & chkOthEviDis5665.getSQLValue() &
                    ", @OthEviDisorient6675 = " & chkOthEviDis6675.getSQLValue() &
                    ", @OthEviDisorientMore75 = " & chkOthEviDis75.getSQLValue() &
                    ", @EviLangImpLess26 = " & chkEviLangImp26.getSQLValue() &
                    ", @EviLangImp2645 = " & chkEviLangImp2645.getSQLValue() &
                    ", @EviLangImp4655 = " & chkEviLangImp4655.getSQLValue() &
                    ", @EviLangImp5665 = " & chkEviLangImp5665.getSQLValue() &
                    ", @EviLangImp6675 = " & chkEviLangImp6675.getSQLValue() &
                    ", @EviLangImpMore75 = " & chkEviLangImp75.getSQLValue() &
                    ", @EviAbstrImpLess26 = " & chkEviImpAbs26.getSQLValue() &
                    ", @EviAbstrImp2645 = " & chkEviImpAbs2645.getSQLValue() &
                    ", @EviAbstrImp4655 = " & chkEviImpAbs4655.getSQLValue() &
                    ", @EviAbstrImp5665 = " & chkEviImpAbs5665.getSQLValue() &
                    ", @EviAbstrImp6675 = " & chkEviImpAbs6675.getSQLValue() &
                    ", @EviAbstrImpMore75 = " & chkEviImpAbs75.getSQLValue() &
                    ", @ImpJudgementLess26 = " & chkImpJudge26.getSQLValue() &
                    ", @ImpJudgement2645 = " & chkImpJudge2645.getSQLValue() &
                    ", @ImpJudgement4655 = " & chkImpJudge4655.getSQLValue() &
                    ", @ImpJudgement5665 = " & chkImpJudge5665.getSQLValue() &
                    ", @ImpJudgement6675 = " & chkImpJudge6675.getSQLValue() &
                    ", @ImpJudgementMore75 = " & chkImpJudge75.getSQLValue() &
                    ", @HelpFeedLess26 = " & chkNeedsHelp26.getSQLValue() &
                    ", @HelpFeed2645 = " & chkNeedsHelp2645.getSQLValue() &
                    ", @HelpFeed4655 = " & chkNeedsHelp4655.getSQLValue() &
                    ", @HelpFeed5665 = " & chkNeedsHelp5665.getSQLValue() &
                    ", @HelpFeed6675 = " & chkNeedsHelp6675.getSQLValue() &
                    ", @HelpFeedMore75 = " & chkNeedsHelp75.getSQLValue() &
                    ", @UrinIncontLess26 = " & chkUrinIncont26.getSQLValue() &
                    ", @UrinIncont2645 = " & chkUrinIncont2645.getSQLValue() &
                    ", @UrinIncont4655 = " & chkUrinIncont4655.getSQLValue() &
                    ", @UrinIncont5665 = " & chkUrinIncont5665.getSQLValue() &
                    ", @UrinIncont6675 = " & chkUrinIncont6675.getSQLValue() &
                    ", @UrinIncontMore75 = " & chkUrinIncont75.getSQLValue() &
                    ", @FecalIncontLess26 = " & chkFecalIncont26.getSQLValue() &
                    ", @FecalIncont2645 = " & chkFecalIncont2645.getSQLValue() &
                    ", @FecalIncont4655 = " & chkFecalIncont4655.getSQLValue() &
                    ", @FecalIncont5665 = " & chkFecalIncont5665.getSQLValue() &
                    ", @FecalIncont6675 = " & chkFecalIncont6675.getSQLValue() &
                    ", @FecalIncontMore75 = " & chkFecalIncont75.getSQLValue() &
                    ", @InableToPlanLess26 = " & chkInablePlan26.getSQLValue() &
                    ", @InableToPlan2645 = " & chkInablePlan2645.getSQLValue() &
                    ", @InableToPlan4655 = " & chkInablePlan4655.getSQLValue() &
                    ", @InableToPlan5665 = " & chkInablePlan5665.getSQLValue() &
                    ", @InableToPlan6675 = " & chkInablePlan6675.getSQLValue() &
                    ", @InableToPlanMore75 = " & chkInablePlan75.getSQLValue() &
                    ", @PersChangeLess26 = " & chkPersChange26.getSQLValue() &
                    ", @PersChange2645 = " & chkPersChange2645.getSQLValue() &
                    ", @PersChange4655 = " & chkPersChange4655.getSQLValue() &
                    ", @PersChange5665 = " & chkPersChange5665.getSQLValue() &
                    ", @PersChange6675 = " & chkPersChange6675.getSQLValue() &
                    ", @PersChangeMore75 = " & chkPersChange75.getSQLValue() &
                    ", @OthEviDemSpec = " & txtOthEviDemSpec.getSQLValue() &
                    ", @OthEviDemLess26 = " & chkOthEviDem26.getSQLValue() &
                    ", @OthEviDem2645 = " & chkOthEviDem2645.getSQLValue() &
                    ", @OthEviDem4655 = " & chkOthEviDem4655.getSQLValue() &
                    ", @OthEviDem5665 = " & chkOthEviDem5665.getSQLValue() &
                    ", @OthEviDem6675 = " & chkOthEviDem6675.getSQLValue() &
                    ", @OthEviDemMore75 = " & chkOthEviDem75.getSQLValue() &
                    ", @CogImpairNotes = " & txtCogImpNotes.getSQLValue() &
                    ", @LastModBy = '" & WarehouseShell.userName & "';"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    Dim cmd As New SqlCommand("Exec modPMCR_DEAD3Record @Action = 1, " & parameters, WarehouseShell.conn)
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Save successful", MsgBoxStyle.OkOnly)
                        enableInputFields(False)
                        btnDEAD3Bottom.Text = "Edit Record"
                        btnDEAD3Top.Text = "Edit Record"
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else 'If this clause is invoked, datamode must be Edit
                    Dim cmd As New SqlCommand("Exec modPMCR_DEAD3Record @Action = 2, " & parameters, WarehouseShell.conn)
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Save successful", MsgBoxStyle.OkOnly)
                        enableInputFields(False)
                        btnDEAD3Bottom.Text = "Edit Record"
                        btnDEAD3Top.Text = "Edit Record"
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
        btnDEAD3Bottom.PerformClick()
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