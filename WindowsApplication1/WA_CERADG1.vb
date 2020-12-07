Public Class WA_CERADG1
    Implements IFormMethods
    Private formTables As New DataSet
    Private tooltip1 As New ToolTip
    Private Screen As Integer

    'Load form subs
    Private Sub WA_CERADG1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_CERADG1")
        If Database.ExistingRecordCheck("CERADG1", "SubNum = " & WarehouseShell.SubNum) = True Then 'G1 exists as a Complete
            loadBaseForm()
            loadExistingData()
            btnCERADG1Bottom.Text = "Edit this record"
            btnCERADG1Top.Text = btnCERADG1Bottom.Text
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            enableInputFields(False)
            btnCERADG1Top.Focus()
        Else
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            btnCERADG1Top.Text = "Add New Record"
            btnCERADG1Bottom.Text = btnCERADG1Top.Text
            enableInputFields(False)
            lblNoRecord.Visible = True
        End If
    End Sub
    Private Sub loadBaseForm()
        'Load all required lookup tables into the comboValues DataSet
        formTables.Tables.Add(Database.ReturnTable("lkpFrequency01359"))
        formTables.Tables.Add(Database.ReturnTable("lkpAbsPres01"))
        formTables.Tables.Add(Database.ReturnTable("lkpAbsPresNA019"))
        formTables.Tables.Add(Database.ReturnTable("lkpCERADTissueTakenLevel"))
        'Assign lookup values to each individual combobox
        comboPlaquesHippo.assignLookup(formTables, "lkpFrequency01359")
        comboPlaquesEntor.assignLookup(formTables, "lkpFrequency01359")
        comboPlaquesAmyg.assignLookup(formTables, "lkpFrequency01359")
        comboWithCoresHippo.assignLookup(formTables, "lkpFrequency01359")
        comboWithCoresEntor.assignLookup(formTables, "lkpFrequency01359")
        comboWithCoresAmyg.assignLookup(formTables, "lkpFrequency01359")
        comboTanglesHippo.assignLookup(formTables, "lkpFrequency01359")
        comboTanglesEntor.assignLookup(formTables, "lkpFrequency01359")
        comboTanglesAmyg.assignLookup(formTables, "lkpFrequency01359")
        comboParenchHippo.assignLookup(formTables, "lkpFrequency01359")
        comboParenchEntor.assignLookup(formTables, "lkpFrequency01359")
        comboParenchAmyg.assignLookup(formTables, "lkpFrequency01359")
        comboMeninHippo.assignLookup(formTables, "lkpFrequency01359")
        comboMeninEntor.assignLookup(formTables, "lkpFrequency01359")
        comboMeninAmyg.assignLookup(formTables, "lkpFrequency01359")
        comboHemoHippo.assignLookup(formTables, "lkpFrequency01359")
        comboHemoEntor.assignLookup(formTables, "lkpFrequency01359")
        comboHemoAmyg.assignLookup(formTables, "lkpFrequency01359")
        comboGranuloHippo.assignLookup(formTables, "lkpAbsPresNA019")
        comboGranuloEntor.assignLookup(formTables, "lkpAbsPresNA019")
        comboGranuloAmyg.assignLookup(formTables, "lkpAbsPresNA019")
        comboHiranoHippo.assignLookup(formTables, "lkpAbsPresNA019")
        comboHiranoEntor.assignLookup(formTables, "lkpAbsPresNA019")
        comboHiranoAmyg.assignLookup(formTables, "lkpAbsPresNA019")
        comboNeuroHippo.assignLookup(formTables, "lkpAbsPresNA019")
        comboNeuroEntor.assignLookup(formTables, "lkpAbsPresNA019")
        comboNeuroAmyg.assignLookup(formTables, "lkpAbsPresNA019")
        comboGliosisHippo.assignLookup(formTables, "lkpAbsPresNA019")
        comboGliosisEntor.assignLookup(formTables, "lkpAbsPresNA019")
        comboGliosisAmyg.assignLookup(formTables, "lkpAbsPresNA019")
        comboPickHippo.assignLookup(formTables, "lkpAbsPresNA019")
        comboPickEntor.assignLookup(formTables, "lkpAbsPresNA019")
        comboPickAmyg.assignLookup(formTables, "lkpAbsPresNA019")
        comboLewyHippo.assignLookup(formTables, "lkpAbsPresNA019")
        comboLewyEntor.assignLookup(formTables, "lkpAbsPresNA019")
        comboLewyAmyg.assignLookup(formTables, "lkpAbsPresNA019")
        comboOtherHippo.assignLookup(formTables, "lkpAbsPresNA019")
        comboOtherEntor.assignLookup(formTables, "lkpAbsPresNA019")
        comboOtherAmyg.assignLookup(formTables, "lkpAbsPresNA019")
        comboHippo.assignLookup(formTables, "lkpCERADTissueTakenLevel")
        comboEntor.assignLookup(formTables, "lkpCERADTissueTakenLevel")
    End Sub
    Private Sub defaultValues()
        'Default select stain boxes to checked
        chkHE.Checked = True
        chkThioflavinS.Checked = True
        chkSilverStain.Checked = True
        txtSilverStain.Text = "Modified Bielschowsky"
        'Set all of the combo boxes to -1 (blank)
        comboPlaquesHippo.SelectedValue = 0
        comboPlaquesEntor.SelectedValue = 0
        comboPlaquesAmyg.SelectedValue = 0
        comboWithCoresHippo.SelectedValue = 0
        comboWithCoresEntor.SelectedValue = 0
        comboWithCoresAmyg.SelectedValue = 0
        comboTanglesHippo.SelectedValue = 0
        comboTanglesEntor.SelectedValue = 0
        comboTanglesAmyg.SelectedValue = 0
        comboParenchHippo.SelectedValue = 0
        comboParenchEntor.SelectedValue = 0
        comboParenchAmyg.SelectedValue = 0
        comboMeninHippo.SelectedValue = 0
        comboMeninEntor.SelectedValue = 0
        comboMeninAmyg.SelectedValue = 0
        comboHemoHippo.SelectedValue = 0
        comboHemoEntor.SelectedValue = 0
        comboHemoAmyg.SelectedValue = 0
        comboGranuloHippo.SelectedValue = 0
        comboGranuloEntor.SelectedValue = 0
        comboGranuloAmyg.SelectedValue = 0
        comboHiranoHippo.SelectedValue = 0
        comboHiranoEntor.SelectedValue = 0
        comboHiranoAmyg.SelectedValue = 0
        comboNeuroHippo.SelectedValue = 0
        comboNeuroEntor.SelectedValue = 0
        comboNeuroAmyg.SelectedValue = 0
        comboGliosisHippo.SelectedValue = 0
        comboGliosisEntor.SelectedValue = 0
        comboGliosisAmyg.SelectedValue = 0
        comboPickHippo.SelectedValue = 0
        comboPickEntor.SelectedValue = 0
        comboPickAmyg.SelectedValue = 0
        comboLewyHippo.SelectedValue = 0
        comboLewyEntor.SelectedValue = 0
        comboLewyAmyg.SelectedValue = 0
        comboOtherHippo.SelectedValue = 9
        comboOtherEntor.SelectedValue = 9
        comboOtherAmyg.SelectedValue = 9
        comboHippo.SelectedValue = 3
        comboEntor.SelectedValue = 3
    End Sub
    Private Sub loadExistingData()
        'Grab the CERADF record for this SubNum
        formTables.Tables.Add(Database.ReturnTable("CERADG1", , "SubNum = " & WarehouseShell.SubNum))
        'Apply the existing values to the input fields
        Screen = formTables.Tables("CERADG1").Rows(0).Item("Screen")
        chkHE.setValue(formTables, "CERADG1", "HandE")
        chkCongoRed.setValue(formTables, "CERADG1", "CongoRed")
        chkThioflavinS.setValue(formTables, "CERADG1", "ThioflavinS")
        chkAmyloidBeta.setValue(formTables, "CERADG1", "AmyloidBeta")
        chkTau.setValue(formTables, "CERADG1", "Tau")
        chkSynuclein.setValue(formTables, "CERADG1", "Synuclein")
        chkTDP43.setValue(formTables, "CERADG1", "TDP43")
        chkUbiquitin.setValue(formTables, "CERADG1", "Ubiquitin")
        chkSilverStain.setValue(formTables, "CERADG1", "Silver")
        txtSilverStain.Text = formTables.Tables("CERADG1").Rows(0).Item("SilverNote").ToString
        chkOtherStain1.setValue(formTables, "CERADG1", "OtherStain1")
        txtOtherStain1.Text = formTables.Tables("CERADG1").Rows(0).Item("OtherStain1Note").ToString
        chkOtherStain2.setValue(formTables, "CERADG1", "OtherStain2")
        txtOtherStain2.Text = formTables.Tables("CERADG1").Rows(0).Item("OtherStain2Note").ToString
        chkOtherStain3.setValue(formTables, "CERADG1", "OtherStain3")
        txtOtherStain3.Text = formTables.Tables("CERADG1").Rows(0).Item("OtherStain3Note").ToString
        chkOtherStain4.setValue(formTables, "CERADG1", "OtherStain4")
        txtOtherStain4.Text = formTables.Tables("CERADG1").Rows(0).Item("OtherStain4Note").ToString
        comboPlaquesHippo.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("HippoPlaques")
        comboPlaquesEntor.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("EntorPlaques")
        comboPlaquesAmyg.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("AmygPlaques")
        comboWithCoresHippo.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("HippoPlaquesWCores")
        comboWithCoresEntor.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("EntorPlaquesWCores")
        comboWithCoresAmyg.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("AmygPlaquesWCores")
        comboTanglesHippo.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("HippoTangles")
        comboTanglesEntor.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("EntorTangles")
        comboTanglesAmyg.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("AmygTangles")
        comboParenchHippo.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("HippoParench")
        comboParenchEntor.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("EntorParench")
        comboParenchAmyg.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("AmygParench")
        comboMeninHippo.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("HippoMenin")
        comboMeninEntor.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("EntorMenin")
        comboMeninAmyg.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("AmygMenin")
        comboHemoHippo.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("HippoHemo")
        comboHemoEntor.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("EntorHemo")
        comboHemoAmyg.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("AmygHemo")
        comboGranuloHippo.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("HippoGranulo")
        comboGranuloEntor.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("EntorGranulo")
        comboGranuloAmyg.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("AmygGranulo")
        comboHiranoHippo.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("HippoHirano")
        comboHiranoEntor.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("EntorHirano")
        comboHiranoAmyg.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("AmygHirano")
        comboNeuroHippo.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("HippoNeuro")
        comboNeuroEntor.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("EntorNeuro")
        comboNeuroAmyg.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("AmygNeuro")
        comboGliosisHippo.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("HippoGliosis")
        comboGliosisEntor.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("EntorGliosis")
        comboGliosisAmyg.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("AmygGliosis")
        comboPickHippo.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("HippoPick")
        comboPickEntor.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("EntorPick")
        comboPickAmyg.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("AmygPick")
        comboLewyHippo.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("HippoLewy")
        comboLewyEntor.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("EntorLewy")
        comboLewyAmyg.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("AmygLewy")
        comboOtherHippo.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("HippoOther")
        comboOtherEntor.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("EntorOther")
        comboOtherAmyg.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("AmygOther")
        txt10Other.Text = formTables.Tables("CERADG1").Rows(0).Item("Other10Note").ToString
        comboHippo.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("HippoTissueTaken")
        comboEntor.SelectedValue = formTables.Tables("CERADG1").Rows(0).Item("EntorTissueTaken")
    End Sub

    'Sub to enable-disable fields.
    Private Sub enableInputFields(ByVal value As Boolean)
        If value = True Then
            chkHE.Enabled = True
            chkCongoRed.Enabled = True
            chkThioflavinS.Enabled = True
            chkAmyloidBeta.Enabled = True
            chkTau.Enabled = True
            chkSynuclein.Enabled = True
            chkTDP43.Enabled = True
            chkUbiquitin.Enabled = True
            chkSilverStain.Enabled = True
            txtSilverStain.Enabled = True
            chkOtherStain1.Enabled = True
            txtOtherStain1.Enabled = True
            chkOtherStain2.Enabled = True
            txtOtherStain2.Enabled = True
            chkOtherStain3.Enabled = True
            txtOtherStain3.Enabled = True
            chkOtherStain4.Enabled = True
            txtOtherStain4.Enabled = True
            btnHippoTop.Enabled = True
            btnHippoBottom.Enabled = True
            btnEntorTop.Enabled = True
            btnEntorBottom.Enabled = True
            btnAmygTop.Enabled = True
            btnAmygBottom.Enabled = True
            comboPlaquesHippo.Enabled = True
            comboPlaquesEntor.Enabled = True
            comboPlaquesAmyg.Enabled = True
            comboWithCoresHippo.Enabled = True
            comboWithCoresEntor.Enabled = True
            comboWithCoresAmyg.Enabled = True
            comboTanglesHippo.Enabled = True
            comboTanglesEntor.Enabled = True
            comboTanglesAmyg.Enabled = True
            comboParenchHippo.Enabled = True
            comboParenchEntor.Enabled = True
            comboParenchAmyg.Enabled = True
            comboMeninHippo.Enabled = True
            comboMeninEntor.Enabled = True
            comboMeninAmyg.Enabled = True
            comboHemoHippo.Enabled = True
            comboHemoEntor.Enabled = True
            comboHemoAmyg.Enabled = True
            comboGranuloHippo.Enabled = True
            comboGranuloEntor.Enabled = True
            comboGranuloAmyg.Enabled = True
            comboHiranoHippo.Enabled = True
            comboHiranoEntor.Enabled = True
            comboHiranoAmyg.Enabled = True
            comboNeuroHippo.Enabled = True
            comboNeuroEntor.Enabled = True
            comboNeuroAmyg.Enabled = True
            comboGliosisHippo.Enabled = True
            comboGliosisEntor.Enabled = True
            comboGliosisAmyg.Enabled = True
            comboPickHippo.Enabled = True
            comboPickEntor.Enabled = True
            comboPickAmyg.Enabled = True
            comboLewyHippo.Enabled = True
            comboLewyEntor.Enabled = True
            comboLewyAmyg.Enabled = True
            comboOtherHippo.Enabled = True
            comboOtherEntor.Enabled = True
            comboOtherAmyg.Enabled = True
            txt10Other.Enabled = True
            comboHippo.Enabled = True
            comboEntor.Enabled = True
        Else
            chkHE.Enabled = False
            chkCongoRed.Enabled = False
            chkThioflavinS.Enabled = False
            chkAmyloidBeta.Enabled = False
            chkTau.Enabled = False
            chkSynuclein.Enabled = False
            chkTDP43.Enabled = False
            chkUbiquitin.Enabled = False
            chkSilverStain.Enabled = False
            txtSilverStain.Enabled = False
            chkOtherStain1.Enabled = False
            txtOtherStain1.Enabled = False
            chkOtherStain2.Enabled = False
            txtOtherStain2.Enabled = False
            chkOtherStain3.Enabled = False
            txtOtherStain3.Enabled = False
            chkOtherStain4.Enabled = False
            txtOtherStain4.Enabled = False
            btnHippoTop.Enabled = False
            btnHippoBottom.Enabled = False
            btnEntorTop.Enabled = False
            btnEntorBottom.Enabled = False
            btnAmygTop.Enabled = False
            btnAmygBottom.Enabled = False
            comboPlaquesHippo.Enabled = False
            comboPlaquesEntor.Enabled = False
            comboPlaquesAmyg.Enabled = False
            comboWithCoresHippo.Enabled = False
            comboWithCoresEntor.Enabled = False
            comboWithCoresAmyg.Enabled = False
            comboTanglesHippo.Enabled = False
            comboTanglesEntor.Enabled = False
            comboTanglesAmyg.Enabled = False
            comboParenchHippo.Enabled = False
            comboParenchEntor.Enabled = False
            comboParenchAmyg.Enabled = False
            comboMeninHippo.Enabled = False
            comboMeninEntor.Enabled = False
            comboMeninAmyg.Enabled = False
            comboHemoHippo.Enabled = False
            comboHemoEntor.Enabled = False
            comboHemoAmyg.Enabled = False
            comboGranuloHippo.Enabled = False
            comboGranuloEntor.Enabled = False
            comboGranuloAmyg.Enabled = False
            comboHiranoHippo.Enabled = False
            comboHiranoEntor.Enabled = False
            comboHiranoAmyg.Enabled = False
            comboNeuroHippo.Enabled = False
            comboNeuroEntor.Enabled = False
            comboNeuroAmyg.Enabled = False
            comboGliosisHippo.Enabled = False
            comboGliosisEntor.Enabled = False
            comboGliosisAmyg.Enabled = False
            comboPickHippo.Enabled = False
            comboPickEntor.Enabled = False
            comboPickAmyg.Enabled = False
            comboLewyHippo.Enabled = False
            comboLewyEntor.Enabled = False
            comboLewyAmyg.Enabled = False
            comboOtherHippo.Enabled = False
            comboOtherEntor.Enabled = False
            comboOtherAmyg.Enabled = False
            txt10Other.Enabled = False
            comboHippo.Enabled = False
            comboEntor.Enabled = False
        End If
    End Sub

    'Form save events
    Private Sub btnCERADG1_Click(sender As Object, e As EventArgs) Handles btnCERADG1Bottom.Click, btnCERADG1Top.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_CERADG1", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                enableInputFields(True)
                btnCERADG1Bottom.Text = "Save changes"
                btnCERADG1Top.Text = btnCERADG1Bottom.Text
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If Database.ExistingRecordCheck("CERAD_Header", "SubNum = " & WarehouseShell.SubNum) Then
                If Database.ExistingRecordCheck("CERADG1", "SubNum = " & WarehouseShell.SubNum) = True Then 'G1 exists but only as Screen
                    If User.PermissionCheck("WA_CERADG1", "Modify") Then
                        loadBaseForm()
                        'loadExistingData() 'to grab existing stains
                        defaultValues() 'to overwrite nulls with defaults
                        btnCERADG1Bottom.Text = "Save new record"
                        btnCERADG1Top.Text = btnCERADG1Bottom.Text
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                        lblNoRecord.Visible = False
                        enableInputFields(True)
                    End If
                Else
                    If User.PermissionCheck("WA_CERADG1", "Modify") Then
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
                        loadBaseForm()
                        defaultValues()
                        enableInputFields(True)
                        btnCERADG1Bottom.Text = "Save new record"
                        btnCERADG1Top.Text = btnCERADG1Bottom.Text
                        lblNoRecord.Visible = False
                    End If
                End If
            Else
                MsgBox("Please create a CERAD Header for this subject before attempting to add CERAD information.", MsgBoxStyle.OkOnly, "Error!")
            End If
        Else
            If preSaveValidation() = True Then
                Dim sqlCommand As New SqlCommand
                sqlCommand.Connection = WarehouseShell.conn
                Dim cmdString = "@SubNum = " & WarehouseShell.SubNum &
                    ", @HandE = " & chkHE.getSQLValue() &
                    ", @CongoRed = " & chkCongoRed.getSQLValue() &
                    ", @ThioflavinS = " & chkThioflavinS.getSQLValue() &
                    ", @AmyloidBeta = " & chkAmyloidBeta.getSQLValue() &
                    ", @Tau = " & chkTau.getSQLValue() &
                    ", @Synuclein = " & chkSynuclein.getSQLValue() &
                    ", @TDP43 = " & chkTDP43.getSQLValue() &
                    ", @Ubiquitin = " & chkUbiquitin.getSQLValue() &
                    ", @Silver = " & chkSilverStain.getSQLValue() &
                    ", @SilverNote = " & txtSilverStain.getSQLValue() &
                    ", @OtherStain1 = " & chkOtherStain1.getSQLValue() &
                    ", @OtherStain1Note = " & txtOtherStain1.getSQLValue() &
                    ", @OtherStain2 = " & chkOtherStain2.getSQLValue() &
                    ", @OtherStain2Note = " & txtOtherStain2.getSQLValue() &
                    ", @OtherStain3 = " & chkOtherStain3.getSQLValue() &
                    ", @OtherStain3Note = " & txtOtherStain3.getSQLValue() &
                    ", @OtherStain4 = " & chkOtherStain4.getSQLValue() &
                    ", @OtherStain4Note = " & txtOtherStain4.getSQLValue() &
                    ", @Complete = 1" &
                    ", @HippoPlaques = " & comboPlaquesHippo.getSQLValue() &
                    ", @EntorPlaques = " & comboPlaquesEntor.getSQLValue() &
                    ", @AmygPlaques = " & comboPlaquesAmyg.getSQLValue() &
                    ", @HippoPlaquesWCores = " & comboWithCoresHippo.getSQLValue() &
                    ", @EntorPlaquesWCores = " & comboWithCoresEntor.getSQLValue() &
                    ", @AmygPlaquesWCores = " & comboWithCoresAmyg.getSQLValue() &
                    ", @HippoTangles = " & comboTanglesHippo.getSQLValue() &
                    ", @EntorTangles = " & comboTanglesEntor.getSQLValue() &
                    ", @AmygTangles = " & comboTanglesAmyg.getSQLValue() &
                    ", @HippoParench = " & comboParenchHippo.getSQLValue() &
                    ", @EntorParench = " & comboParenchEntor.getSQLValue() &
                    ", @AmygParench = " & comboParenchAmyg.getSQLValue() &
                    ", @HippoMenin = " & comboMeninHippo.getSQLValue() &
                    ", @EntorMenin = " & comboMeninEntor.getSQLValue() &
                    ", @AmygMenin = " & comboMeninAmyg.getSQLValue() &
                    ", @HippoHemo = " & comboHemoHippo.getSQLValue() &
                    ", @EntorHemo = " & comboHemoEntor.getSQLValue() &
                    ", @AmygHemo = " & comboHemoAmyg.getSQLValue() &
                    ", @HippoGranulo = " & comboGranuloHippo.getSQLValue() &
                    ", @EntorGranulo = " & comboGranuloEntor.getSQLValue() &
                    ", @AmygGranulo = " & comboGranuloAmyg.getSQLValue() &
                    ", @HippoHirano = " & comboHiranoHippo.getSQLValue() &
                    ", @EntorHirano = " & comboHiranoEntor.getSQLValue() &
                    ", @AmygHirano = " & comboHiranoAmyg.getSQLValue() &
                    ", @HippoNeuro = " & comboNeuroHippo.getSQLValue() &
                    ", @EntorNeuro = " & comboNeuroEntor.getSQLValue() &
                    ", @AmygNeuro = " & comboNeuroAmyg.getSQLValue() &
                    ", @HippoGliosis = " & comboGliosisHippo.getSQLValue() &
                    ", @EntorGliosis = " & comboGliosisEntor.getSQLValue() &
                    ", @AmygGliosis = " & comboGliosisAmyg.getSQLValue() &
                    ", @HippoPick = " & comboPickHippo.getSQLValue() &
                    ", @EntorPick = " & comboPickEntor.getSQLValue() &
                    ", @AmygPick = " & comboPickAmyg.getSQLValue() &
                    ", @HippoLewy = " & comboLewyHippo.getSQLValue() &
                    ", @EntorLewy = " & comboLewyEntor.getSQLValue() &
                    ", @AmygLewy = " & comboLewyAmyg.getSQLValue() &
                    ", @HippoOther = " & comboOtherHippo.getSQLValue() &
                    ", @EntorOther = " & comboOtherEntor.getSQLValue() &
                    ", @AmygOther = " & comboOtherAmyg.getSQLValue() &
                    ", @Other10Note = " & txt10Other.getSQLValue() &
                    ", @HippoTissueTaken = " & comboHippo.getSQLValue() &
                    ", @EntorTissueTaken = " & comboEntor.getSQLValue() &
                    ", @Screen = " & Screen &
                    ";"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    sqlCommand.CommandText = "EXEC dbo.modCERADG1Record @Action = 1, " & cmdString
                    Try
                        sqlCommand.ExecuteScalar()
                        MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        enableInputFields(False)
                        btnCERADG1Bottom.Text = "Edit this record"
                        btnCERADG1Top.Text = btnCERADG1Bottom.Text
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else
                    sqlCommand.CommandText = "EXEC dbo.modCERADG1Record @Action = 2, " & cmdString
                    Try
                        sqlCommand.ExecuteScalar()
                        MessageBox.Show("Changes saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        enableInputFields(False)
                        btnCERADG1Bottom.Text = "Edit this record"
                        btnCERADG1Top.Text = btnCERADG1Bottom.Text
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                End If
            End If
        End If
    End Sub
    Private Function preSaveValidation() As Boolean
        Dim result As Boolean = True
        Dim errorMessage As String = ""

        'Make sure at least one stain is checked
        Dim stainCount As Integer = 0
        For Each chk As Control In Controls
            If TypeOf chk Is CheckBox_ Then
                If CType(chk, CheckBox_).Checked Then
                    stainCount += 1
                End If
            End If
        Next
        If stainCount = 0 Then
            result = False
            errorMessage += "- Please select at least one stain." & vbNewLine
        End If

        'Check specify dependencies
        If chkSilverStain.Checked = False And txtSilverStain.Text <> "" Then
            result = False
            errorMessage += "- You have entered a Silver Stain note without checking the Silver Stain box. Please clear the note or check the Silver Stain box." & vbNewLine
        End If
        If chkSilverStain.Checked And txtSilverStain.Text = "" Then
            result = False
            errorMessage += "- You have checked the Silver Stain box without specifying a note. Please add a note or uncheck the Silver Stain box." & vbNewLine
        End If
        If chkOtherStain1.Checked = False And txtOtherStain1.Text <> "" Then
            result = False
            errorMessage += "- You have entered a Other Stain note without checking the Other Stain 1 box. Please clear the note or check the Other Stain 1 box." & vbNewLine
        End If
        If chkOtherStain1.Checked And txtOtherStain1.Text = "" Then
            result = False
            errorMessage += "- You have checked the Other Stain 1 box without specifying a note. Please add a note or uncheck the Other Stain 1 box." & vbNewLine
        End If
        If chkOtherStain2.Checked = False And txtOtherStain2.Text <> "" Then
            result = False
            errorMessage += "- You have entered a Other Stain note without checking the Other Stain 2 box. Please clear the note or check the Other Stain 2 box." & vbNewLine
        End If
        If chkOtherStain2.Checked And txtOtherStain2.Text = "" Then
            result = False
            errorMessage += "- You have checked the Other Stain 2 box without specifying a note. Please add a note or uncheck the Other Stain 2 box." & vbNewLine
        End If
        If chkOtherStain3.Checked = False And txtOtherStain3.Text <> "" Then
            result = False
            errorMessage += "- You have entered a Other Stain note without checking the Other Stain 3 box. Please clear the note or check the Other Stain 3 box." & vbNewLine
        End If
        If chkOtherStain3.Checked And txtOtherStain3.Text = "" Then
            result = False
            errorMessage += "- You have checked the Other Stain 3 box without specifying a note. Please add a note or uncheck the Other Stain 3 box." & vbNewLine
        End If
        If chkOtherStain4.Checked = False And txtOtherStain4.Text <> "" Then
            result = False
            errorMessage += "- You have entered a Other Stain note without checking the Other Stain 4 box. Please clear the note or check the Other Stain 4 box." & vbNewLine
        End If
        If chkOtherStain4.Checked And txtOtherStain4.Text = "" Then
            result = False
            errorMessage += "- You have checked the Other Stain 4 box without specifying a note. Please add a note or uncheck the Other Stain 4 box." & vbNewLine
        End If

        'Check section 2 other dependencies
        'TODO: Check if there's an Other Specify without any positive results for Other.
        If comboOtherHippo.SelectedValue <> 9 Or comboOtherEntor.SelectedValue <> 9 Or comboOtherAmyg.SelectedValue <> 9 Then
            If txt10Other.Text = "" Then
                result = False
                errorMessage += "- You have selected No or Yes for one or more of the regions in Section 2 Item 10. Other, but have not defined other. Please define other or set the three region values to NA." & vbNewLine
            End If
        End If

        'Handle result
        If result = False Then
            MsgBox("The following errors exist and must be corrected before this record can be saved:" & vbNewLine & vbNewLine & errorMessage, MsgBoxStyle.OkOnly, "Error")
        End If
        Return result
    End Function

    'Buttons to set subsets to N/A
    Private Sub btnHippoTop_Click(sender As Object, e As EventArgs) Handles btnHippoTop.Click
        comboPlaquesHippo.SelectedValue = 9
        comboWithCoresHippo.SelectedValue = 9
        comboTanglesHippo.SelectedValue = 9
        comboParenchHippo.SelectedValue = 9
        comboMeninHippo.SelectedValue = 9
        comboHemoHippo.SelectedValue = 9
    End Sub
    Private Sub btnHippoBottom_Click(sender As Object, e As EventArgs) Handles btnHippoBottom.Click
        comboGranuloHippo.SelectedValue = 9
        comboHiranoHippo.SelectedValue = 9
        comboNeuroHippo.SelectedValue = 9
        comboGliosisHippo.SelectedValue = 9
        comboPickHippo.SelectedValue = 9
        comboLewyHippo.SelectedValue = 9
        comboOtherHippo.SelectedValue = 9
    End Sub
    Private Sub btnEntorTop_Click(sender As Object, e As EventArgs) Handles btnEntorTop.Click
        comboPlaquesEntor.SelectedValue = 9
        comboWithCoresEntor.SelectedValue = 9
        comboTanglesEntor.SelectedValue = 9
        comboParenchEntor.SelectedValue = 9
        comboMeninEntor.SelectedValue = 9
        comboHemoEntor.SelectedValue = 9
    End Sub
    Private Sub btnEntorBottom_Click(sender As Object, e As EventArgs) Handles btnEntorBottom.Click
        comboGranuloEntor.SelectedValue = 9
        comboHiranoEntor.SelectedValue = 9
        comboNeuroEntor.SelectedValue = 9
        comboGliosisEntor.SelectedValue = 9
        comboPickEntor.SelectedValue = 9
        comboLewyEntor.SelectedValue = 9
        comboOtherEntor.SelectedValue = 9
    End Sub
    Private Sub btnAmygTop_Click(sender As Object, e As EventArgs) Handles btnAmygTop.Click
        comboPlaquesAmyg.SelectedValue = 9
        comboWithCoresAmyg.SelectedValue = 9
        comboTanglesAmyg.SelectedValue = 9
        comboParenchAmyg.SelectedValue = 9
        comboMeninAmyg.SelectedValue = 9
        comboHemoAmyg.SelectedValue = 9
    End Sub
    Private Sub btnAmygBottom_Click(sender As Object, e As EventArgs) Handles btnAmygBottom.Click
        comboGranuloAmyg.SelectedValue = 9
        comboHiranoAmyg.SelectedValue = 9
        comboNeuroAmyg.SelectedValue = 9
        comboGliosisAmyg.SelectedValue = 9
        comboPickAmyg.SelectedValue = 9
        comboLewyAmyg.SelectedValue = 9
        comboOtherAmyg.SelectedValue = 9
    End Sub

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
        btnCERADG1Bottom.PerformClick()
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class