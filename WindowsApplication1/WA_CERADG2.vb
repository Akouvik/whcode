Public Class WA_CERADG2
    Implements IFormMethods
    Private insertString As String = Nothing
    Private updateString As String = Nothing
    Private formTables As New DataSet
    Private errorMessage As String = ""

    'Load form subs
    Private Sub WA_CERADG2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_CERADG2")
        'Take OnLoad actions based on WarehouseShell.DateMode
        If Database.ExistingRecordCheck("CERADG2", "SubNum = " & WarehouseShell.SubNum) = True Then
            loadBaseForm()
            enableInputFields(False)
            loadExistingData()
            btnCERADG2Bottom.Text = "Edit this record"
            btnCERADG2Top.Text = btnCERADG2Bottom.Text
            btnCERADG2Top.Focus()
        Else
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            btnCERADG2Top.Text = "Add New Record"
            btnCERADG2Bottom.Text = btnCERADG2Top.Text
            enableInputFields(False)
            lblNoRecord.Visible = True
        End If
    End Sub
    Private Sub loadBaseForm()
        'Load all required lookup tables into the comboValues DataSet
        formTables.Tables.Add(Database.ReturnTable("lkpCERADNYUnk019"))
        formTables.Tables.Add(Database.ReturnTable("lkpCERADSeverity01359"))
        formTables.Tables.Add(Database.ReturnTable("lkpCERADAbsentPresentNA"))
        formTables.Tables.Add(Database.ReturnTable("lkpCERADGOccBM"))
        'Assign lookup values to each individual combobox
        comboBMArea.assignLookup(formTables, "lkpCERADGOccBM")
        assignComboLookups(comboPlaquesMid, "lkpCERADSeverity01359")
        assignComboLookups(comboPlaquesSup, "lkpCERADSeverity01359")
        assignComboLookups(comboPlaquesInf, "lkpCERADSeverity01359")
        assignComboLookups(comboPlaquesBM, "lkpCERADSeverity01359")
        assignComboLookups(comboWithCoresMid, "lkpCERADSeverity01359")
        assignComboLookups(comboWithCoresSup, "lkpCERADSeverity01359")
        assignComboLookups(comboWithCoresInf, "lkpCERADSeverity01359")
        assignComboLookups(comboWithCoresBM, "lkpCERADSeverity01359")
        assignComboLookups(comboDiffuseMid, "lkpCERADSeverity01359")
        assignComboLookups(comboDiffuseSup, "lkpCERADSeverity01359")
        assignComboLookups(comboDiffuseInf, "lkpCERADSeverity01359")
        assignComboLookups(comboDiffuseBM, "lkpCERADSeverity01359")
        assignComboLookups(comboTanglesMid, "lkpCERADSeverity01359")
        assignComboLookups(comboTanglesSup, "lkpCERADSeverity01359")
        assignComboLookups(comboTanglesInf, "lkpCERADSeverity01359")
        assignComboLookups(ComboTanglesBM, "lkpCERADSeverity01359")
        assignComboLookups(comboParenchMid, "lkpCERADSeverity01359")
        assignComboLookups(comboParenchSup, "lkpCERADSeverity01359")
        assignComboLookups(comboParenchInf, "lkpCERADSeverity01359")
        assignComboLookups(comboParenchBM, "lkpCERADSeverity01359")
        assignComboLookups(comboMeninMid, "lkpCERADSeverity01359")
        assignComboLookups(comboMeninSup, "lkpCERADSeverity01359")
        assignComboLookups(comboMeninInf, "lkpCERADSeverity01359")
        assignComboLookups(comboMeninBM, "lkpCERADSeverity01359")
        assignComboLookups(comboHemoMid, "lkpCERADSeverity01359")
        assignComboLookups(comboHemoSup, "lkpCERADSeverity01359")
        assignComboLookups(comboHemoInf, "lkpCERADSeverity01359")
        assignComboLookups(comboHemoBM, "lkpCERADSeverity01359")
        assignComboLookups(comboNeuroMid, "lkpCERADAbsentPresentNA")
        assignComboLookups(comboNeuroSup, "lkpCERADAbsentPresentNA")
        assignComboLookups(comboNeuroInf, "lkpCERADAbsentPresentNA")
        assignComboLookups(comboNeuroBM, "lkpCERADAbsentPresentNA")
        assignComboLookups(comboGliosisMid, "lkpCERADAbsentPresentNA")
        assignComboLookups(comboGliosisSup, "lkpCERADAbsentPresentNA")
        assignComboLookups(comboGliosisInf, "lkpCERADAbsentPresentNA")
        assignComboLookups(comboGliosisBM, "lkpCERADAbsentPresentNA")
        assignComboLookups(comboPickMid, "lkpCERADAbsentPresentNA")
        assignComboLookups(comboPickSup, "lkpCERADAbsentPresentNA")
        assignComboLookups(comboPickInf, "lkpCERADAbsentPresentNA")
        assignComboLookups(comboPickBM, "lkpCERADAbsentPresentNA")
        assignComboLookups(comboLewyMid, "lkpCERADAbsentPresentNA")
        assignComboLookups(comboLewySup, "lkpCERADAbsentPresentNA")
        assignComboLookups(comboLewyInf, "lkpCERADAbsentPresentNA")
        assignComboLookups(comboLewyBM, "lkpCERADAbsentPresentNA")
        assignComboLookups(comboOtherMid, "lkpCERADAbsentPresentNA")
        assignComboLookups(comboOtherSup, "lkpCERADAbsentPresentNA")
        assignComboLookups(comboOtherInf, "lkpCERADAbsentPresentNA")
        assignComboLookups(comboOtherBM, "lkpCERADAbsentPresentNA")
        assignComboLookups(comboLewySub, "lkpCERADSeverity01359")
        assignComboLookups(comboLewyNucleus, "lkpCERADSeverity01359")
        assignComboLookups(comboLewyDorsalR, "lkpCERADSeverity01359")
        assignComboLookups(comboLewyLocus, "lkpCERADSeverity01359")
        assignComboLookups(comboLewyDorsalV, "lkpCERADSeverity01359")
        assignComboLookups(comboLewyCerebellum, "lkpCERADSeverity01359")
        assignComboLookups(comboLewyOther, "lkpCERADSeverity01359")
        assignComboLookups(comboNeuroSub, "lkpCERADSeverity01359")
        assignComboLookups(comboNeuroNucleus, "lkpCERADSeverity01359")
        assignComboLookups(comboNeuroDorsalR, "lkpCERADSeverity01359")
        assignComboLookups(comboNeuroLocus, "lkpCERADSeverity01359")
        assignComboLookups(comboNeuroDorsalV, "lkpCERADSeverity01359")
        assignComboLookups(comboNeuroCerebellum, "lkpCERADSeverity01359")
        assignComboLookups(comboNeuroOther, "lkpCERADSeverity01359")
        assignComboLookups(comboGlioSub, "lkpCERADSeverity01359")
        assignComboLookups(comboGlioNucleus, "lkpCERADSeverity01359")
        assignComboLookups(comboGlioDorsalR, "lkpCERADSeverity01359")
        assignComboLookups(comboGlioLocus, "lkpCERADSeverity01359")
        assignComboLookups(comboGlioDorsalV, "lkpCERADSeverity01359")
        assignComboLookups(comboGlioCerebellum, "lkpCERADSeverity01359")
        assignComboLookups(comboGlioOther, "lkpCERADSeverity01359")
        assignComboLookups(comboPigmentSub, "lkpCERADSeverity01359")
        assignComboLookups(comboPigmentNucleus, "lkpCERADSeverity01359")
        assignComboLookups(comboPigmentDorsalR, "lkpCERADSeverity01359")
        assignComboLookups(comboPigmentLocus, "lkpCERADSeverity01359")
        assignComboLookups(comboPigmentDorsalV, "lkpCERADSeverity01359")
        assignComboLookups(comboPigmentCerebellum, "lkpCERADSeverity01359")
        assignComboLookups(comboPigmentOther, "lkpCERADSeverity01359")
        assignComboLookups(comboTanglesSub, "lkpCERADSeverity01359")
        assignComboLookups(comboTanglesNucleus, "lkpCERADSeverity01359")
        assignComboLookups(comboTanglesDorsalR, "lkpCERADSeverity01359")
        assignComboLookups(comboTanglesLocus, "lkpCERADSeverity01359")
        assignComboLookups(comboTanglesDorsalV, "lkpCERADSeverity01359")
        assignComboLookups(comboTanglesCerebellum, "lkpCERADSeverity01359")
        assignComboLookups(comboTanglesOther, "lkpCERADSeverity01359")
        assignComboLookups(comboPlaquesSub, "lkpCERADSeverity01359")
        assignComboLookups(comboPlaquesNucleus, "lkpCERADSeverity01359")
        assignComboLookups(comboPlaquesDorsalR, "lkpCERADSeverity01359")
        assignComboLookups(comboPlaquesLocus, "lkpCERADSeverity01359")
        assignComboLookups(comboPlaquesDorsalV, "lkpCERADSeverity01359")
        assignComboLookups(comboPlaquesCerebellum, "lkpCERADSeverity01359")
        assignComboLookups(comboPlaquesOther, "lkpCERADSeverity01359")
        assignComboLookups(comboOtherSub, "lkpCERADSeverity01359")
        assignComboLookups(comboOtherNucleus, "lkpCERADSeverity01359")
        assignComboLookups(comboOtherDorsalR, "lkpCERADSeverity01359")
        assignComboLookups(comboOtherLocus, "lkpCERADSeverity01359")
        assignComboLookups(comboOtherDorsalV, "lkpCERADSeverity01359")
        assignComboLookups(comboOtherCerebellum, "lkpCERADSeverity01359")
        assignComboLookups(comboOtherOther, "lkpCERADSeverity01359")
        assignComboLookups(comboSub, "lkpCERADNYUnk019")
        assignComboLookups(comboLocus, "lkpCERADNYUnk019")
        assignComboLookups(comboDorsalV, "lkpCERADNYUnk019")
    End Sub
    Private Sub assignComboLookups(ByVal ComboName As ComboBox, ByVal tableName As String)
        ComboName.DataSource = New DataView(formTables.Tables(tableName))
        ComboName.DisplayMember = "Label"
        ComboName.ValueMember = "Value"
    End Sub
    Private Sub defaultValues()
        'Set all of the combo boxes to 0 (No/None)
        comboPlaquesMid.SelectedValue = 0
        comboPlaquesSup.SelectedValue = 0
        comboPlaquesInf.SelectedValue = 0
        comboPlaquesBM.SelectedValue = 9
        comboWithCoresMid.SelectedValue = 0
        comboWithCoresSup.SelectedValue = 0
        comboWithCoresInf.SelectedValue = 0
        comboWithCoresBM.SelectedValue = 9
        comboDiffuseMid.SelectedValue = 0
        comboDiffuseSup.SelectedValue = 0
        comboDiffuseInf.SelectedValue = 0
        comboDiffuseBM.SelectedValue = 9
        comboTanglesMid.SelectedValue = 0
        comboTanglesSup.SelectedValue = 0
        comboTanglesInf.SelectedValue = 0
        ComboTanglesBM.SelectedValue = 9
        comboParenchMid.SelectedValue = 0
        comboParenchSup.SelectedValue = 0
        comboParenchInf.SelectedValue = 0
        comboParenchBM.SelectedValue = 9
        comboMeninMid.SelectedValue = 0
        comboMeninSup.SelectedValue = 0
        comboMeninInf.SelectedValue = 0
        comboMeninBM.SelectedValue = 9
        comboHemoMid.SelectedValue = 0
        comboHemoSup.SelectedValue = 0
        comboHemoInf.SelectedValue = 0
        comboHemoBM.SelectedValue = 9
        comboNeuroMid.SelectedValue = 0
        comboNeuroSup.SelectedValue = 0
        comboNeuroInf.SelectedValue = 0
        comboNeuroBM.SelectedValue = 9
        comboGliosisMid.SelectedValue = 0
        comboGliosisSup.SelectedValue = 0
        comboGliosisInf.SelectedValue = 0
        comboGliosisBM.SelectedValue = 9
        comboPickMid.SelectedValue = 0
        comboPickSup.SelectedValue = 0
        comboPickInf.SelectedValue = 0
        comboPickBM.SelectedValue = 9
        comboLewyMid.SelectedValue = 0
        comboLewySup.SelectedValue = 0
        comboLewyInf.SelectedValue = 0
        comboLewyBM.SelectedValue = 9
        comboOtherMid.SelectedValue = 0
        comboOtherSup.SelectedValue = 0
        comboOtherInf.SelectedValue = 0
        comboOtherBM.SelectedValue = 9
        comboLewySub.SelectedValue = 0
        comboLewyNucleus.SelectedValue = 0
        comboLewyDorsalR.SelectedValue = 0
        comboLewyLocus.SelectedValue = 0
        comboLewyDorsalV.SelectedValue = 0
        comboLewyCerebellum.SelectedValue = 0
        comboLewyOther.SelectedValue = 9
        comboNeuroSub.SelectedValue = 0
        comboNeuroNucleus.SelectedValue = 0
        comboNeuroDorsalR.SelectedValue = 0
        comboNeuroLocus.SelectedValue = 0
        comboNeuroDorsalV.SelectedValue = 0
        comboNeuroCerebellum.SelectedValue = 0
        comboNeuroOther.SelectedValue = 9
        comboGlioSub.SelectedValue = 0
        comboGlioNucleus.SelectedValue = 0
        comboGlioDorsalR.SelectedValue = 0
        comboGlioLocus.SelectedValue = 0
        comboGlioDorsalV.SelectedValue = 0
        comboGlioCerebellum.SelectedValue = 0
        comboGlioOther.SelectedValue = 9
        comboPigmentSub.SelectedValue = 0
        comboPigmentNucleus.SelectedValue = 0
        comboPigmentDorsalR.SelectedValue = 0
        comboPigmentLocus.SelectedValue = 0
        comboPigmentDorsalV.SelectedValue = 0
        comboPigmentCerebellum.SelectedValue = 0
        comboPigmentOther.SelectedValue = 9
        comboTanglesSub.SelectedValue = 0
        comboTanglesNucleus.SelectedValue = 0
        comboTanglesDorsalR.SelectedValue = 0
        comboTanglesLocus.SelectedValue = 0
        comboTanglesDorsalV.SelectedValue = 0
        comboTanglesCerebellum.SelectedValue = 0
        comboTanglesOther.SelectedValue = 9
        comboPlaquesSub.SelectedValue = 0
        comboPlaquesNucleus.SelectedValue = 0
        comboPlaquesDorsalR.SelectedValue = 0
        comboPlaquesLocus.SelectedValue = 0
        comboPlaquesDorsalV.SelectedValue = 0
        comboPlaquesCerebellum.SelectedValue = 0
        comboPlaquesOther.SelectedValue = 9
        comboOtherSub.SelectedValue = 9
        comboOtherNucleus.SelectedValue = 9
        comboOtherDorsalR.SelectedValue = 9
        comboOtherLocus.SelectedValue = 9
        comboOtherDorsalV.SelectedValue = 9
        comboOtherCerebellum.SelectedValue = 9
        comboOtherOther.SelectedValue = 9
        comboSub.SelectedValue = 0
        comboLocus.SelectedValue = 0
        comboDorsalV.SelectedValue = 0
    End Sub
    Private Sub loadExistingData()
        'Grab the CERADG2 record for this SubNum
        formTables.Tables.Add(Database.ReturnTable("CERADG2", , "SubNum = " & WarehouseShell.SubNum))
        'Apply the existing values to the input fields
        comboBMArea.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("OcciBM")
        comboPlaquesMid.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("MidPlaques")
        comboPlaquesSup.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("SupPlaques")
        comboPlaquesInf.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("InfPlaques")
        comboPlaquesBM.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("OcciPlaques")
        comboWithCoresMid.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("MidPlaquesWCores")
        comboWithCoresSup.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("SupPlaquesWCores")
        comboWithCoresInf.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("InfPlaquesWCores")
        comboWithCoresBM.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("OcciPlaquesWCores")
        comboDiffuseMid.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("MidDiffuse")
        comboDiffuseSup.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("SupDiffuse")
        comboDiffuseInf.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("InfDiffuse")
        comboDiffuseBM.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("OcciDiffuse")
        comboTanglesMid.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("MidTangles")
        comboTanglesSup.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("SupTangles")
        comboTanglesInf.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("InfTangles")
        ComboTanglesBM.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("OcciTangles")
        comboParenchMid.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("MidParench")
        comboParenchSup.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("SupParench")
        comboParenchInf.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("InfParench")
        comboParenchBM.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("OcciParench")
        comboMeninMid.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("MidMenin")
        comboMeninSup.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("SupMenin")
        comboMeninInf.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("InfMenin")
        comboMeninBM.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("OcciMenin")
        comboHemoMid.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("MidHemo")
        comboHemoSup.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("SupHemo")
        comboHemoInf.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("InfHemo")
        comboHemoBM.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("OcciHemo")
        comboNeuroMid.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("MidNeuro")
        comboNeuroSup.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("SupNeuro")
        comboNeuroInf.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("InfNeuro")
        comboNeuroBM.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("OcciNeuro")
        comboGliosisMid.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("MidGliosis")
        comboGliosisSup.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("SupGliosis")
        comboGliosisInf.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("InfGliosis")
        comboGliosisBM.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("OcciGliosis")
        comboPickMid.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("MidPick")
        comboPickSup.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("SupPick")
        comboPickInf.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("InfPick")
        comboPickBM.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("OcciPick")
        comboLewyMid.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("MidLewy")
        comboLewySup.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("SupLewy")
        comboLewyInf.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("InfLewy")
        comboLewyBM.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("OcciLewy")
        comboOtherMid.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("MidOther")
        comboOtherSup.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("SupOther")
        comboOtherInf.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("InfOther")
        comboOtherBM.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("OcciOther")
        txt8Other.Text = formTables.Tables("CERADG2").Rows(0).Item("Other8Note").ToString
        txtOther.Text = formTables.Tables("CERADG2").Rows(0).Item("OtherRegion").ToString 'string values for text boxes
        comboLewySub.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("LewySub") 'literal values for combo boxes
        comboLewyNucleus.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("LewyNucleus")
        comboLewyLocus.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("LewyLocus")
        comboLewyDorsalV.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("LewyDorsalV")
        comboLewyCerebellum.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("LewyCerebellum")
        comboLewyOther.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("LewyOther")
        comboNeuroSub.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("NeuroSub")
        comboNeuroNucleus.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("NeuroNucleus")
        comboNeuroDorsalR.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("NeuroDorsalR")
        comboNeuroLocus.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("NeuroLocus")
        comboNeuroDorsalV.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("NeuroDorsalV")
        comboNeuroCerebellum.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("NeuroCerebellum")
        comboNeuroOther.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("NeuroOther")
        comboGlioSub.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("GlioSub")
        comboGlioNucleus.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("GlioNucleus")
        comboGlioDorsalR.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("GlioDorsalR")
        comboGlioLocus.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("GlioLocus")
        comboGlioDorsalV.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("GlioDorsalV")
        comboGlioCerebellum.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("GlioCerebellum")
        comboGlioOther.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("GlioOther")
        comboPigmentSub.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("PigmentSub")
        comboPigmentNucleus.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("PigmentNucleus")
        comboPigmentDorsalR.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("PigmentDorsalR")
        comboPigmentLocus.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("PigmentLocus")
        comboPigmentDorsalV.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("PigmentDorsalV")
        comboPigmentCerebellum.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("PigmentCerebellum")
        comboPigmentOther.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("PigmentOther")
        comboTanglesSub.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("TanglesSub")
        comboTanglesNucleus.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("TanglesNucleus")
        comboTanglesDorsalR.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("TanglesDorsalR")
        comboTanglesLocus.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("TanglesLocus")
        comboTanglesDorsalV.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("TanglesDorsalV")
        comboTanglesCerebellum.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("TanglesCerebellum")
        comboTanglesOther.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("TanglesOther")
        comboPlaquesSub.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("PlaquesSub")
        comboPlaquesNucleus.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("PlaquesNucleus")
        comboPlaquesDorsalR.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("PlaquesDorsalR")
        comboPlaquesLocus.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("PlaquesLocus")
        comboPlaquesDorsalV.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("PlaquesDorsalV")
        comboPlaquesCerebellum.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("PlaquesCerebellum")
        comboPlaquesOther.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("PlaquesOther")
        comboOtherSub.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("OtherSub")
        comboOtherNucleus.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("OtherNucleus")
        comboOtherDorsalR.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("OtherDorsalR")
        comboOtherLocus.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("OtherLocus")
        comboOtherDorsalV.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("OtherDorsalV")
        comboOtherCerebellum.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("OtherCerebellum")
        comboOtherOther.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("OtherOther")
        txt7Other.Text = formTables.Tables("CERADG2").Rows(0).Item("OtherNote").ToString
        comboSub.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("SubNigra")
        comboLocus.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("LocusCeruleus")
        comboDorsalV.SelectedValue = formTables.Tables("CERADG2").Rows(0).Item("DorsalVagus")
    End Sub

    'Subs to enable-disable fields during data input based on conditional logic.
    Private Sub enableInputFields(ByVal value As Boolean)
        If value = True Then
            comboBMArea.Enabled = True
            comboPlaquesMid.Enabled = True
            comboPlaquesSup.Enabled = True
            comboPlaquesInf.Enabled = True
            comboPlaquesBM.Enabled = True
            comboWithCoresMid.Enabled = True
            comboWithCoresSup.Enabled = True
            comboWithCoresInf.Enabled = True
            comboWithCoresBM.Enabled = True
            comboDiffuseMid.Enabled = True
            comboDiffuseSup.Enabled = True
            comboDiffuseInf.Enabled = True
            comboDiffuseBM.Enabled = True
            comboTanglesMid.Enabled = True
            comboTanglesSup.Enabled = True
            comboTanglesInf.Enabled = True
            ComboTanglesBM.Enabled = True
            comboParenchMid.Enabled = True
            comboParenchSup.Enabled = True
            comboParenchInf.Enabled = True
            comboParenchBM.Enabled = True
            comboMeninMid.Enabled = True
            comboMeninSup.Enabled = True
            comboMeninInf.Enabled = True
            comboMeninBM.Enabled = True
            comboHemoMid.Enabled = True
            comboHemoSup.Enabled = True
            comboHemoInf.Enabled = True
            comboHemoBM.Enabled = True
            comboNeuroMid.Enabled = True
            comboNeuroSup.Enabled = True
            comboNeuroInf.Enabled = True
            comboNeuroBM.Enabled = True
            comboGliosisMid.Enabled = True
            comboGliosisSup.Enabled = True
            comboGliosisInf.Enabled = True
            comboGliosisBM.Enabled = True
            comboPickMid.Enabled = True
            comboPickSup.Enabled = True
            comboPickInf.Enabled = True
            comboPickBM.Enabled = True
            comboLewyMid.Enabled = True
            comboLewySup.Enabled = True
            comboLewyInf.Enabled = True
            comboLewyBM.Enabled = True
            comboOtherMid.Enabled = True
            comboOtherSup.Enabled = True
            comboOtherInf.Enabled = True
            comboOtherBM.Enabled = True
            txt8Other.Enabled = True
            txtOther.Enabled = True
            comboLewySub.Enabled = True
            comboLewyNucleus.Enabled = True
            comboLewyDorsalR.Enabled = True
            comboLewyLocus.Enabled = True
            comboLewyDorsalV.Enabled = True
            comboLewyCerebellum.Enabled = True
            comboLewyOther.Enabled = True
            comboNeuroSub.Enabled = True
            comboNeuroNucleus.Enabled = True
            comboNeuroDorsalR.Enabled = True
            comboNeuroLocus.Enabled = True
            comboNeuroDorsalV.Enabled = True
            comboNeuroCerebellum.Enabled = True
            comboNeuroOther.Enabled = True
            comboGlioSub.Enabled = True
            comboGlioNucleus.Enabled = True
            comboGlioDorsalR.Enabled = True
            comboGlioLocus.Enabled = True
            comboGlioDorsalV.Enabled = True
            comboGlioCerebellum.Enabled = True
            comboGlioOther.Enabled = True
            comboPigmentSub.Enabled = True
            comboPigmentNucleus.Enabled = True
            comboPigmentDorsalR.Enabled = True
            comboPigmentLocus.Enabled = True
            comboPigmentDorsalV.Enabled = True
            comboPigmentCerebellum.Enabled = True
            comboPigmentOther.Enabled = True
            comboTanglesSub.Enabled = True
            comboTanglesNucleus.Enabled = True
            comboTanglesDorsalR.Enabled = True
            comboTanglesLocus.Enabled = True
            comboTanglesDorsalV.Enabled = True
            comboTanglesCerebellum.Enabled = True
            comboTanglesOther.Enabled = True
            comboPlaquesSub.Enabled = True
            comboPlaquesNucleus.Enabled = True
            comboPlaquesDorsalR.Enabled = True
            comboPlaquesLocus.Enabled = True
            comboPlaquesDorsalV.Enabled = True
            comboPlaquesCerebellum.Enabled = True
            comboPlaquesOther.Enabled = True
            comboOtherSub.Enabled = True
            comboOtherNucleus.Enabled = True
            comboOtherDorsalR.Enabled = True
            comboOtherLocus.Enabled = True
            comboOtherDorsalV.Enabled = True
            comboOtherCerebellum.Enabled = True
            comboOtherOther.Enabled = True
            txt7Other.Enabled = True
            comboSub.Enabled = True
            comboLocus.Enabled = True
            comboDorsalV.Enabled = True
        Else
            comboBMArea.Enabled = False
            comboPlaquesMid.Enabled = False
            comboPlaquesSup.Enabled = False
            comboPlaquesInf.Enabled = False
            comboPlaquesBM.Enabled = False
            comboWithCoresMid.Enabled = False
            comboWithCoresSup.Enabled = False
            comboWithCoresInf.Enabled = False
            comboWithCoresBM.Enabled = False
            comboDiffuseMid.Enabled = False
            comboDiffuseSup.Enabled = False
            comboDiffuseInf.Enabled = False
            comboDiffuseBM.Enabled = False
            comboTanglesMid.Enabled = False
            comboTanglesSup.Enabled = False
            comboTanglesInf.Enabled = False
            ComboTanglesBM.Enabled = False
            comboParenchMid.Enabled = False
            comboParenchSup.Enabled = False
            comboParenchInf.Enabled = False
            comboParenchBM.Enabled = False
            comboMeninMid.Enabled = False
            comboMeninSup.Enabled = False
            comboMeninInf.Enabled = False
            comboMeninBM.Enabled = False
            comboHemoMid.Enabled = False
            comboHemoSup.Enabled = False
            comboHemoInf.Enabled = False
            comboHemoBM.Enabled = False
            comboNeuroMid.Enabled = False
            comboNeuroSup.Enabled = False
            comboNeuroInf.Enabled = False
            comboNeuroBM.Enabled = False
            comboGliosisMid.Enabled = False
            comboGliosisSup.Enabled = False
            comboGliosisInf.Enabled = False
            comboGliosisBM.Enabled = False
            comboPickMid.Enabled = False
            comboPickSup.Enabled = False
            comboPickInf.Enabled = False
            comboPickBM.Enabled = False
            comboLewyMid.Enabled = False
            comboLewySup.Enabled = False
            comboLewyInf.Enabled = False
            comboLewyBM.Enabled = False
            comboOtherMid.Enabled = False
            comboOtherSup.Enabled = False
            comboOtherInf.Enabled = False
            comboOtherBM.Enabled = False
            txt8Other.Enabled = False
            txtOther.Enabled = False
            comboLewySub.Enabled = False
            comboLewyNucleus.Enabled = False
            comboLewyDorsalR.Enabled = False
            comboLewyLocus.Enabled = False
            comboLewyDorsalV.Enabled = False
            comboLewyCerebellum.Enabled = False
            comboLewyOther.Enabled = False
            comboNeuroSub.Enabled = False
            comboNeuroNucleus.Enabled = False
            comboNeuroDorsalR.Enabled = False
            comboNeuroLocus.Enabled = False
            comboNeuroDorsalV.Enabled = False
            comboNeuroCerebellum.Enabled = False
            comboNeuroOther.Enabled = False
            comboGlioSub.Enabled = False
            comboGlioNucleus.Enabled = False
            comboGlioDorsalR.Enabled = False
            comboGlioLocus.Enabled = False
            comboGlioDorsalV.Enabled = False
            comboGlioCerebellum.Enabled = False
            comboGlioOther.Enabled = False
            comboPigmentSub.Enabled = False
            comboPigmentNucleus.Enabled = False
            comboPigmentDorsalR.Enabled = False
            comboPigmentLocus.Enabled = False
            comboPigmentDorsalV.Enabled = False
            comboPigmentCerebellum.Enabled = False
            comboPigmentOther.Enabled = False
            comboTanglesSub.Enabled = False
            comboTanglesNucleus.Enabled = False
            comboTanglesDorsalR.Enabled = False
            comboTanglesLocus.Enabled = False
            comboTanglesDorsalV.Enabled = False
            comboTanglesCerebellum.Enabled = False
            comboTanglesOther.Enabled = False
            comboPlaquesSub.Enabled = False
            comboPlaquesNucleus.Enabled = False
            comboPlaquesDorsalR.Enabled = False
            comboPlaquesLocus.Enabled = False
            comboPlaquesDorsalV.Enabled = False
            comboPlaquesCerebellum.Enabled = False
            comboPlaquesOther.Enabled = False
            comboOtherSub.Enabled = False
            comboOtherNucleus.Enabled = False
            comboOtherDorsalR.Enabled = False
            comboOtherLocus.Enabled = False
            comboOtherDorsalV.Enabled = False
            comboOtherCerebellum.Enabled = False
            comboOtherOther.Enabled = False
            txt7Other.Enabled = False
            comboSub.Enabled = False
            comboLocus.Enabled = False
            comboDorsalV.Enabled = False
        End If
    End Sub

    'Define button click events
    Private Sub btnCERADG2_Click(sender As Object, e As EventArgs) Handles btnCERADG2Bottom.Click, btnCERADG2Top.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_CERADG2", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                enableInputFields(True)
                btnCERADG2Bottom.Text = "Save changes"
                btnCERADG2Top.Text = btnCERADG2Bottom.Text
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If Database.ExistingRecordCheck("CERAD_Header", "SubNum = " & WarehouseShell.SubNum) Then
                If User.PermissionCheck("WA_CERADG1", "Modify") Then
                    WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
                    loadBaseForm()
                    defaultValues()
                    enableInputFields(True)
                    btnCERADG2Bottom.Text = "Save new record"
                    btnCERADG2Top.Text = btnCERADG2Bottom.Text
                    lblNoRecord.Visible = False
                End If
            Else
                MsgBox("Please create a CERAD Header for this subject before attempting to add CERAD information.", MsgBoxStyle.OkOnly, "Error!")
            End If
        Else
            If preSaveValidation() Then
                Dim sqlCommand As New SqlCommand
                sqlCommand.Connection = WarehouseShell.conn
                Dim cmdString = "@SubNum = " & WarehouseShell.SubNum &
                        ", @OcciBM = " & comboBMArea.getSQLValue() &
                        ", @MidPlaques = " & comboPlaquesMid.getSQLValue() &
                        ", @SupPlaques = " & comboPlaquesSup.getSQLValue() &
                        ", @InfPlaques = " & comboPlaquesInf.getSQLValue() &
                        ", @OcciPlaques = " & comboPlaquesBM.getSQLValue() &
                        ", @MidPlaquesWCores = " & comboWithCoresMid.getSQLValue() &
                        ", @SupPlaquesWCores = " & comboWithCoresSup.getSQLValue() &
                        ", @InfPlaquesWCores = " & comboWithCoresInf.getSQLValue() &
                        ", @OcciPlaquesWCores = " & comboWithCoresBM.getSQLValue() &
                        ", @MidDiffuse = " & comboDiffuseMid.getSQLValue() &
                        ", @SupDiffuse = " & comboDiffuseSup.getSQLValue() &
                        ", @InfDiffuse = " & comboDiffuseInf.getSQLValue() &
                        ", @OcciDiffuse = " & comboDiffuseBM.getSQLValue() &
                        ", @MidTangles = " & comboTanglesMid.getSQLValue() &
                        ", @SupTangles = " & comboTanglesSup.getSQLValue() &
                        ", @InfTangles = " & comboTanglesInf.getSQLValue() &
                        ", @OcciTangles = " & ComboTanglesBM.getSQLValue() &
                        ", @MidParench = " & comboParenchMid.getSQLValue() &
                        ", @SupParench = " & comboParenchSup.getSQLValue() &
                        ", @InfParench = " & comboParenchInf.getSQLValue() &
                        ", @OcciParench = " & comboParenchBM.getSQLValue() &
                        ", @MidMenin = " & comboMeninMid.getSQLValue() &
                        ", @SupMenin = " & comboMeninSup.getSQLValue() &
                        ", @InfMenin = " & comboMeninInf.getSQLValue() &
                        ", @OcciMenin = " & comboMeninBM.getSQLValue() &
                        ", @MidHemo = " & comboHemoMid.getSQLValue() &
                        ", @SupHemo = " & comboHemoSup.getSQLValue() &
                        ", @InfHemo = " & comboHemoInf.getSQLValue() &
                        ", @OcciHemo = " & comboHemoBM.getSQLValue() &
                        ", @MidNeuro = " & comboNeuroMid.getSQLValue() &
                        ", @SupNeuro = " & comboNeuroSup.getSQLValue() &
                        ", @InfNeuro = " & comboNeuroInf.getSQLValue() &
                        ", @OcciNeuro = " & comboNeuroBM.getSQLValue() &
                        ", @MidGliosis = " & comboGliosisMid.getSQLValue() &
                        ", @SupGliosis = " & comboGliosisSup.getSQLValue() &
                        ", @InfGliosis = " & comboGliosisInf.getSQLValue() &
                        ", @OcciGliosis = " & comboGliosisBM.getSQLValue() &
                        ", @MidPick = " & comboPickMid.getSQLValue() &
                        ", @SupPick = " & comboPickSup.getSQLValue() &
                        ", @InfPick = " & comboPickInf.getSQLValue() &
                        ", @OcciPick = " & comboPickBM.getSQLValue() &
                        ", @MidLewy = " & comboLewyMid.getSQLValue() &
                        ", @SupLewy = " & comboLewySup.getSQLValue() &
                        ", @InfLewy = " & comboLewyInf.getSQLValue() &
                        ", @OcciLewy = " & comboLewyBM.getSQLValue() &
                        ", @MidOther = " & comboOtherMid.getSQLValue() &
                        ", @SupOther = " & comboOtherSup.getSQLValue() &
                        ", @InfOther = " & comboOtherInf.getSQLValue() &
                        ", @OcciOther = " & comboOtherBM.getSQLValue() &
                        ", @Other8Note = " & txt8Other.getSQLValue() &
                        ", @OtherRegion = " & txtOther.getSQLValue() &
                        ", @LewySub = " & comboLewySub.getSQLValue() &
                        ", @LewyNucleus = " & comboLewyNucleus.getSQLValue() &
                        ", @LewyLocus = " & comboLewyLocus.getSQLValue() &
                        ", @LewyDorsalV = " & comboLewyDorsalV.getSQLValue() &
                        ", @LewyCerebellum = " & comboLewyCerebellum.getSQLValue() &
                        ", @LewyOther = " & comboLewyOther.getSQLValue() &
                        ", @NeuroSub = " & comboNeuroSub.getSQLValue() &
                        ", @NeuroNucleus = " & comboNeuroNucleus.getSQLValue() &
                        ", @NeuroDorsalR = " & comboNeuroDorsalR.getSQLValue() &
                        ", @NeuroLocus = " & comboNeuroLocus.getSQLValue() &
                        ", @NeuroDorsalV = " & comboNeuroDorsalV.getSQLValue() &
                        ", @NeuroCerebellum = " & comboNeuroCerebellum.getSQLValue() &
                        ", @NeuroOther = " & comboNeuroOther.getSQLValue() &
                        ", @GlioSub = " & comboGlioSub.getSQLValue() &
                        ", @GlioNucleus = " & comboGlioNucleus.getSQLValue() &
                        ", @GlioDorsalR = " & comboGlioDorsalR.getSQLValue() &
                        ", @GlioLocus = " & comboGlioLocus.getSQLValue() &
                        ", @GlioDorsalV = " & comboGlioDorsalV.getSQLValue() &
                        ", @GlioCerebellum = " & comboGlioCerebellum.getSQLValue() &
                        ", @GlioOther = " & comboGlioOther.getSQLValue() &
                        ", @PigmentSub = " & comboPigmentSub.getSQLValue() &
                        ", @PigmentNucleus = " & comboPigmentNucleus.getSQLValue() &
                        ", @PigmentDorsalR = " & comboPigmentDorsalR.getSQLValue() &
                        ", @PigmentLocus = " & comboPigmentLocus.getSQLValue() &
                        ", @PigmentDorsalV = " & comboPigmentDorsalV.getSQLValue() &
                        ", @PigmentCerebellum = " & comboPigmentCerebellum.getSQLValue() &
                        ", @PigmentOther = " & comboPigmentOther.getSQLValue() &
                        ", @TanglesSub = " & comboTanglesSub.getSQLValue() &
                        ", @TanglesNucleus = " & comboTanglesNucleus.getSQLValue() &
                        ", @TanglesDorsalR = " & comboTanglesDorsalR.getSQLValue() &
                        ", @TanglesLocus = " & comboTanglesLocus.getSQLValue() &
                        ", @TanglesDorsalV = " & comboTanglesDorsalV.getSQLValue() &
                        ", @TanglesCerebellum = " & comboTanglesCerebellum.getSQLValue() &
                        ", @TanglesOther = " & comboTanglesOther.getSQLValue() &
                        ", @PlaquesSub = " & comboPlaquesSub.getSQLValue() &
                        ", @PlaquesNucleus = " & comboPlaquesNucleus.getSQLValue() &
                        ", @PlaquesDorsalR = " & comboPlaquesDorsalR.getSQLValue() &
                        ", @PlaquesLocus = " & comboPlaquesLocus.getSQLValue() &
                        ", @PlaquesDorsalV = " & comboPlaquesDorsalV.getSQLValue() &
                        ", @PlaquesCerebellum = " & comboPlaquesCerebellum.getSQLValue() &
                        ", @PlaquesOther = " & comboPlaquesOther.getSQLValue() &
                        ", @OtherSub = " & comboOtherSub.getSQLValue() &
                        ", @OtherNucleus = " & comboOtherNucleus.getSQLValue() &
                        ", @OtherDorsalR = " & comboOtherDorsalR.getSQLValue() &
                        ", @OtherLocus = " & comboOtherLocus.getSQLValue() &
                        ", @OtherDorsalV = " & comboOtherDorsalV.getSQLValue() &
                        ", @OtherCerebellum = " & comboOtherCerebellum.getSQLValue() &
                        ", @OtherOther = " & comboOtherOther.getSQLValue() &
                        ", @OtherNote = " & txt7Other.getSQLValue() &
                        ", @SubNigra = " & comboSub.getSQLValue() &
                        ", @LocusCeruleus = " & comboLocus.getSQLValue() &
                        ", @DorsalVagus = " & comboDorsalV.getSQLValue() & ";"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    sqlCommand.CommandText = "EXEC dbo.modCERADG2Record @Action = 1, " & cmdString
                    Try
                        sqlCommand.ExecuteNonQuery()
                        MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        enableInputFields(False)
                        btnCERADG2Bottom.Text = "Edit this record"
                        btnCERADG2Top.Text = btnCERADG2Bottom.Text
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else
                    sqlCommand.CommandText = "EXEC dbo.modCERADG2Record @Action = 2, " & cmdString
                    Try
                        sqlCommand.ExecuteNonQuery()
                        MessageBox.Show("Record successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        enableInputFields(False)
                        btnCERADG2Bottom.Text = "Edit this record"
                        btnCERADG2Top.Text = btnCERADG2Bottom.Text
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                End If
            Else
                MsgBox(errorMessage & vbNewLine & vbNewLine & "These errors must be corrected before the record can be saved.", MsgBoxStyle.Exclamation, "Input Validation Error")
            End If
        End If
    End Sub
    Private Function preSaveValidation() As Boolean
        Dim result As Boolean = True
        If txt8Other.Text <> "" Then
            If (comboOtherMid.SelectedValue = 0 Or comboOtherMid.SelectedValue = 9) And _
                (comboOtherSup.SelectedValue = 0 Or comboOtherSup.SelectedValue = 9) And _
                (comboOtherInf.SelectedValue = 0 Or comboOtherInf.SelectedValue = 9) And _
                (comboOtherBM.SelectedValue = 0 Or comboOtherBM.SelectedValue = 9) Then
                errorMessage = "You have entered an Other Microscopic Abnormality (item 8) note without indicating a severity in any of the Mid-Superior-Inferior-BM regions. Please add a severity " & _
                    "greater than None in at least one of the fields or clear the note."
                result = False
            End If
        End If
        If txt7Other.Text <> "" Then
            If (comboOtherSub.SelectedValue = 0 Or comboOtherSub.SelectedValue = 9) And _
                (comboOtherNucleus.SelectedValue = 0 Or comboOtherNucleus.SelectedValue = 9) And _
                (comboOtherDorsalR.SelectedValue = 0 Or comboOtherDorsalR.SelectedValue = 9) And _
                (comboOtherLocus.SelectedValue = 0 Or comboOtherLocus.SelectedValue = 9) And _
                (comboOtherDorsalV.SelectedValue = 0 Or comboOtherDorsalV.SelectedValue = 9) And _
                (comboOtherCerebellum.SelectedValue = 0 Or comboOtherCerebellum.SelectedValue = 9) And _
                (comboOtherOther.SelectedValue = 0 Or comboOtherOther.SelectedValue = 9) Then
                errorMessage = "You have entered an Other Microscopic Abnormality (item 7) note without indicating a severity in the associated anotomical region fields. Please add a severity " & _
                    "greater than None in at least one of the fields or clear the note."
                Return False
            End If
        End If
        Return result
    End Function

    'Imported IFormMethods
    Public Sub ShowPHI(showPHI As Boolean) Implements IFormMethods.ShowPHI
    End Sub
    Public Sub Parent1(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Public Sub Show1() Implements IFormMethods.Show
        Show()
    End Sub
    Public Sub TopLevel1(val As Boolean) Implements IFormMethods.TopLevel
        TopLevel = val
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        btnCERADG2Bottom.PerformClick()
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub

    Private Sub btnMidFront_Click(sender As Object, e As EventArgs) Handles btnMidFront.Click
        comboPlaquesMid.SelectedValue = 9
        comboWithCoresMid.SelectedValue = 9
        comboDiffuseMid.SelectedValue = 9
        comboTanglesMid.SelectedValue = 9
        comboParenchMid.SelectedValue = 9
        comboMeninMid.SelectedValue = 9
        comboHemoMid.SelectedValue = 9
        comboNeuroMid.SelectedValue = 9
        comboGliosisMid.SelectedValue = 9
        comboPickMid.SelectedValue = 9
        comboLewyMid.SelectedValue = 9
        comboOtherMid.SelectedValue = 9
    End Sub
    Private Sub btnSupMid_Click(sender As Object, e As EventArgs) Handles btnSupMid.Click
        comboPlaquesSup.SelectedValue = 9
        comboWithCoresSup.SelectedValue = 9
        comboDiffuseSup.SelectedValue = 9
        comboTanglesSup.SelectedValue = 9
        comboParenchSup.SelectedValue = 9
        comboMeninSup.SelectedValue = 9
        comboHemoSup.SelectedValue = 9
        comboNeuroSup.SelectedValue = 9
        comboGliosisSup.SelectedValue = 9
        comboPickSup.SelectedValue = 9
        comboLewySup.SelectedValue = 9
        comboOtherSup.SelectedValue = 9
    End Sub
    Private Sub btnInfPar_Click(sender As Object, e As EventArgs) Handles btnInfPar.Click
        comboPlaquesInf.SelectedValue = 9
        comboWithCoresInf.SelectedValue = 9
        comboDiffuseInf.SelectedValue = 9
        comboTanglesInf.SelectedValue = 9
        comboParenchInf.SelectedValue = 9
        comboMeninInf.SelectedValue = 9
        comboHemoInf.SelectedValue = 9
        comboNeuroInf.SelectedValue = 9
        comboGliosisInf.SelectedValue = 9
        comboPickInf.SelectedValue = 9
        comboLewyInf.SelectedValue = 9
        comboOtherInf.SelectedValue = 9
    End Sub
    Private Sub btnBMArea_Click(sender As Object, e As EventArgs) Handles btnBMArea.Click
        comboPlaquesBM.SelectedValue = 9
        comboWithCoresBM.SelectedValue = 9
        comboDiffuseBM.SelectedValue = 9
        ComboTanglesBM.SelectedValue = 9
        comboParenchBM.SelectedValue = 9
        comboMeninBM.SelectedValue = 9
        comboHemoBM.SelectedValue = 9
        comboNeuroBM.SelectedValue = 9
        comboGliosisBM.SelectedValue = 9
        comboPickBM.SelectedValue = 9
        comboLewyBM.SelectedValue = 9
        comboOtherBM.SelectedValue = 9
    End Sub
    Private Sub btnSubNig_Click(sender As Object, e As EventArgs) Handles btnSubNig.Click
        comboLewySub.SelectedValue = 9
        comboNeuroSub.SelectedValue = 9
        comboGlioSub.SelectedValue = 9
        comboPigmentSub.SelectedValue = 9
        comboTanglesSub.SelectedValue = 9
        comboPlaquesSub.SelectedValue = 9
        comboOtherSub.SelectedValue = 9
    End Sub
    Private Sub btnNucBas_Click(sender As Object, e As EventArgs) Handles btnNucBas.Click
        comboLewyNucleus.SelectedValue = 9
        comboNeuroNucleus.SelectedValue = 9
        comboGlioNucleus.SelectedValue = 9
        comboPigmentNucleus.SelectedValue = 9
        comboTanglesNucleus.SelectedValue = 9
        comboPlaquesNucleus.SelectedValue = 9
        comboOtherNucleus.SelectedValue = 9
    End Sub
    Private Sub btnDorRaph_Click(sender As Object, e As EventArgs) Handles btnDorRaph.Click
        comboLewyDorsalR.SelectedValue = 9
        comboNeuroDorsalR.SelectedValue = 9
        comboGlioDorsalR.SelectedValue = 9
        comboPigmentDorsalR.SelectedValue = 9
        comboTanglesDorsalR.SelectedValue = 9
        comboPlaquesDorsalR.SelectedValue = 9
        comboOtherDorsalR.SelectedValue = 9
    End Sub
    Private Sub btnLocCer_Click(sender As Object, e As EventArgs) Handles btnLocCer.Click
        comboLewyLocus.SelectedValue = 9
        comboNeuroLocus.SelectedValue = 9
        comboGlioLocus.SelectedValue = 9
        comboPigmentLocus.SelectedValue = 9
        comboTanglesLocus.SelectedValue = 9
        comboPlaquesLocus.SelectedValue = 9
        comboOtherLocus.SelectedValue = 9
    End Sub
    Private Sub btnDorVag_Click(sender As Object, e As EventArgs) Handles btnDorVag.Click
        comboLewyDorsalV.SelectedValue = 9
        comboNeuroDorsalV.SelectedValue = 9
        comboGlioDorsalV.SelectedValue = 9
        comboPigmentDorsalV.SelectedValue = 9
        comboTanglesDorsalV.SelectedValue = 9
        comboPlaquesDorsalV.SelectedValue = 9
        comboOtherDorsalV.SelectedValue = 9
    End Sub
    Private Sub btnCere_Click(sender As Object, e As EventArgs) Handles btnCere.Click
        comboLewyCerebellum.SelectedValue = 9
        comboNeuroCerebellum.SelectedValue = 9
        comboGlioCerebellum.SelectedValue = 9
        comboPigmentCerebellum.SelectedValue = 9
        comboTanglesCerebellum.SelectedValue = 9
        comboPlaquesCerebellum.SelectedValue = 9
        comboOtherCerebellum.SelectedValue = 9
    End Sub
    Private Sub btnOther_Click(sender As Object, e As EventArgs) Handles btnOther.Click
        comboLewyOther.SelectedValue = 9
        comboNeuroOther.SelectedValue = 9
        comboGlioOther.SelectedValue = 9
        comboPigmentOther.SelectedValue = 9
        comboTanglesOther.SelectedValue = 9
        comboPlaquesOther.SelectedValue = 9
        comboOtherOther.SelectedValue = 9
    End Sub
End Class