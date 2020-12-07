Public Class WA_Demographics
    Implements IFormMethods
    Private tempSubNum As String
    Private insertString As String = Nothing
    Private updateString As String = Nothing
    Private formTables As New DataSet

    'Load form based on current WarehouseShell.DataMode
    Private Sub WA_Demographics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_Subject")
        ShowPHI(WarehouseShell.ShowingPHI)
        'Load all required lookup tables into the comboValues DataSet
        formTables.Tables.Add(Database.ReturnTable("lkpSalutation"))
        formTables.Tables.Add(Database.ReturnTable("lkpYNUnk129"))
        formTables.Tables.Add(Database.ReturnTable("lkpGender"))
        formTables.Tables.Add(Database.ReturnTable("lkpSex"))
        formTables.Tables.Add(Database.ReturnTable("lkpRace"))
        formTables.Tables.Add(Database.ReturnTable("lkpLanguage"))
        formTables.Tables.Add(Database.ReturnTable("lkpMobilityStatus"))
        formTables.Tables.Add(Database.ReturnTable("lkpMaritalStatus"))
        formTables.Tables.Add(Database.ReturnTable("lkpSmokingHistory"))
        formTables.Tables.Add(Database.ReturnTable("lkpLevelOfIndependence"))
        formTables.Tables.Add(Database.ReturnTable("lkpDonationWishes"))
        formTables.Tables.Add(Database.ReturnTable("lkpHandedness"))
        formTables.Tables.Add(Database.ReturnTable("lkpYN12"))
        formTables.Tables.Add(Database.ReturnTable("lkpNicotineUseHx"))
        formTables.Tables.Add(Database.ReturnTable("lkpNicotineUseType"))
        formTables.Tables.Add(Database.ReturnTable("lkpADRC_NACCID_Type"))
        formTables.Tables.Add(Database.ReturnTable("lkpSexualOrientation"))
        formTables.Tables.Add(Database.ReturnTable("lkpMilitaryService"))
        formTables.Tables.Add(Database.ReturnTable("lkpYNNAUnk1239"))

        'Assign lookup values to each individual combobox
        cmbSalutation.assignLookup(formTables, "lkpSalutation")
        comboSex.assignLookup(formTables, "lkpSex")
        comboEthnicity.assignLookup(formTables, "lkpRace")
        comboRace.assignLookup(formTables, "lkpRace")
        comboPrimaryLanguage.assignLookup(formTables, "lkpLanguage")
        comboSecondaryLanguage.assignLookup(formTables, "lkpLanguage")
        comboMobility.assignLookup(formTables, "lkpMobilityStatus")
        comboMaritalStatus.assignLookup(formTables, "lkpMaritalStatus")
        cmbNicotineHx.assignLookup(formTables, "lkpSmokingHistory")
        comboLevelOfIndependence.assignLookup(formTables, "lkpLevelOfIndependence")
        comboDonationWishes.assignLookup(formTables, "lkpDonationWishes")
        comboHandedness.assignLookup(formTables, "lkpHandedness")
        comboMultiBirth.assignLookup(formTables, "lkpYNUnk129")
        cmbNicotineHx.assignLookup(formTables, "lkpNicotineUseHx")
        cmbNicOthType.assignLookup(formTables, "lkpNicotineUseType")
        NACCIDType.assignLookup(formTables, "lkpADRC_NACCID_Type")
        GenderATOD.assignLookup(formTables, "lkpGender")
        SexualOrientationATOD.assignLookup(formTables, "lkpSexualorientation")
        MilitaryService.assignLookup(formTables, "lkpMilitaryService")
        cmbHearingLoss.assignLookup(formTables, "lkpYNNAUnk1239")

        If Not IsNothing(WarehouseShell.SubNum) Then
            btnSubjectBottom.Text = "Edit Subject Data"
            btnSubjectTop.Text = btnSubjectBottom.Text
            loadExistingData()
            enableInputFields(False)
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        Else
            'Load a blank form with default values (and unique SubNum)
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
            ShowPHI(True)
            defaultComboValues()
            btnSubjectBottom.Text = "Save New Subject"
            btnSubjectTop.Text = btnSubjectBottom.Text
            generateSubNum()
            enableInputFields(True)
            btnPsychNeuroRelAdd.Enabled = False
            cmbSalutation.Focus()
            '##################
            If WarehouseShell.Num1 > 10000 Then
                formTables.Tables.Add(Database.ReturnTable("DonationReferralTracker",, "RecordID = " & WarehouseShell.Num1))
                txtFirstName.setValue(formTables, "DonationReferralTracker", "FirstName")
                txtLastName.setValue(formTables, "DonationReferralTracker", "LastName")
                chkNBTR.Checked = True
            End If

        End If
    End Sub

    'Sub to set default values for combo boxes. NOT called for view or edit modes.
    Private Sub defaultComboValues()
        cmbSalutation.SelectedValue = -1
        comboSex.SelectedValue = -1
        GenderATOD.SelectedValue = -1
        SexualOrientationATOD.SelectedValue = -1
        comboRace.SelectedValue = -1
        comboEthnicity.SelectedValue = -1
        comboPrimaryLanguage.SelectedValue = -1
        comboSecondaryLanguage.SelectedValue = -1
        comboMobility.SelectedValue = -1
        comboMaritalStatus.SelectedValue = -1
        GenderATOD.SelectedValue = -1
        SexualOrientationATOD.SelectedValue = -1
        MilitaryService.SelectedValue = -1
        cmbHearingLoss.SelectedValue = -1
        cmbNicotineHx.SelectedValue = -1
        comboLevelOfIndependence.SelectedValue = -1
        comboMultiBirth.SelectedValue = -1
        cmbNicotineHx.SelectedValue = -1
        cmbNicOthType.SelectedValue = -1
        NACCIDType.SelectedValue = -1
        txtFirstName.Text = DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).txtFirstName.Text
        txtLastName.Text = DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).txtLastName.Text
        Dim head = DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect)
    End Sub

    'Sub to generate unique SubNum for insert operations.
    Private Sub generateSubNum()
        Dim s As String = "0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 6
            Dim idx As Integer = r.Next(0, 10)
            sb.Append(s.Substring(idx, 1))
        Next
        'Check to see if SubNum exists. If so, restart the sub. If not, apply the generated SubNum to the txtSubNum field.
        If Database.ExistingRecordCheck("viewSubject", "SubNum = " & sb.ToString()) = True Then
            generateSubNum()
        Else
            txtSubNum.Text = sb.ToString()
        End If
    End Sub

    'Sub to load existing values into form for View/Edit modes
    Private Sub loadExistingData()
        'Grab the requisite tables
        formTables.Tables.Add(Database.ReturnTable("viewSubject", , "SubNum = " & WarehouseShell.SubNum))
        formTables.Tables.Add(Database.ReturnTable("Subject_RelWithSimDx", "RecordID, RelationValue, RelationLabel as Relation, AgeAtDx as 'Age at Dx', EdLevel as 'Ed. Level', RaceValue, RaceLabel as Race, DxICD as 'Dx ICD Code', DxText as 'Dx ICD Text'", "SubNum = " & WarehouseShell.SubNum))
        dgvRelWithSimilarDx.DataSource = formTables.Tables("Subject_RelWithSimDx")
        dgvRelWithSimilarDx.Columns("RecordID").Visible = False
        dgvRelWithSimilarDx.Columns("RelationValue").Visible = False
        dgvRelWithSimilarDx.Columns("RaceValue").Visible = False
        'Apply the values
        chkDNC.setValue(formTables, "viewSubject", "DoNotContact")
        chkDNDiss.setValue(formTables, "viewSubject", "DoNotDissect")
        chkDNDist.setValue(formTables, "viewSubject", "DoNotDistribute")
        Infectious()
        cmbSalutation.setValue(formTables, "viewSubject", "SalutationValue")
        txtFirstName.setValue(formTables, "viewSubject", "FirstName")
        txtMI.setValue(formTables, "viewSubject", "MI")
        txtLastName.setValue(formTables, "viewSubject", "LastName")
        txtSuffix.setValue(formTables, "viewSubject", "Suffix")
        txtSSN.setValue(formTables, "viewSubject", "SSN")
        txtDoB.setValue(formTables, "viewSubject", "DoB")
        txtAge.setValue(formTables, "viewSubject", "Age")
        txtAddress1.setValue(formTables, "viewSubject", "Address1")
        txtAddress2.setValue(formTables, "viewSubject", "Address2")
        txtCity.setValue(formTables, "viewSubject", "City")
        txtState.setValue(formTables, "viewSubject", "State")
        txtZip.setValue(formTables, "viewSubject", "ZIP")
        txtHomePhone.setValue(formTables, "viewSubject", "HomePhone")
        txtWorkPhone.setValue(formTables, "viewSubject", "WorkPhone")
        txtMobilePhone.setValue(formTables, "viewSubject", "MobilePhone")
        txtEmail.setValue(formTables, "viewSubject", "Email")
        chkSchizo.setValue(formTables, "viewSubject", "SchizoCohort")
        chkNACC.setValue(formTables, "viewSubject", "NACCCohort")
        chkPPG.setValue(formTables, "viewSubject", "PPGCohort")
        chkIsrael.setValue(formTables, "viewSubject", "IsraelCohort")
        chkADRC.setValue(formTables, "viewSubject", "ADRCCohort")
        chkNBTR.setValue(formTables, "viewSubject", "NBTRCohort")
        chkTBI.setValue(formTables, "viewSubject", "TBICohort")
        chkRelOrd.setValue(formTables, "viewSubject", "ReligiousOrderCohort")
        ADRCClinicalTrialsCohort.setValue(formTables, "viewSubject", "ClinicalTrialsCohort")
        comboSex.SelectedValue = formTables.Tables("viewSubject").Rows(0).Item("SexValue")
        GenderATOD.SelectedValue = formTables.Tables("viewSubject").Rows(0).Item("GenderValue")
        SexualOrientationATOD.SelectedValue = formTables.Tables("viewSubject").Rows(0).Item("SexualOrientationATODValue")
        MilitaryService.SelectedValue = formTables.Tables("viewSubject").Rows(0).Item("MilitaryServiceValue")
        comboEthnicity.SelectedValue = formTables.Tables("viewSubject").Rows(0).Item("EthnicityValue")
        txtEthSpec.setValue(formTables, "viewSubject", "EthnicityNote")
        comboRace.SelectedValue = formTables.Tables("viewSubject").Rows(0).Item("RaceValue")
        txtRaceSpec.setValue(formTables, "viewSubject", "RaceNote")
        comboPrimaryLanguage.SelectedValue = formTables.Tables("viewSubject").Rows(0).Item("PrimaryLanguageValue")
        comboSecondaryLanguage.SelectedValue = formTables.Tables("viewSubject").Rows(0).Item("SecondaryLanguageValue")
        txtLanguageNote.setValue(formTables, "viewSubject", "LanguageNote")
        txtYearsOfEducation.setValue(formTables, "viewSubject", "YearsOfEducation")
        txtPlaceOfBirth.setValue(formTables, "viewSubject", "PlaceOfBirth")
        txtLifetimeOccupation.setValue(formTables, "viewSubject", "LifetimeOccupation")
        comboHandedness.SelectedValue = formTables.Tables("viewSubject").Rows(0).Item("HandednessValue")
        comboMultiBirth.SelectedValue = formTables.Tables("viewSubject").Rows(0).Item("MultBirthValue")
        txtMultiBirth.setValue(formTables, "viewSubject", "MultBirthNote")
        comboMobility.SelectedValue = formTables.Tables("viewSubject").Rows(0).Item("MobilityStatusValue")
        comboMaritalStatus.SelectedValue = formTables.Tables("viewSubject").Rows(0).Item("MaritalStatusValue")
        comboLevelOfIndependence.SelectedValue = formTables.Tables("viewSubject").Rows(0).Item("LevelOfIndependenceValue")
        txtPrimPsychICD.setValue(formTables, "viewSubject", "PrimPsychDxICD")
        txtPrimPsychText.setValue(formTables, "viewSubject", "PrimPsychDxText")
        txtPrimNeuroICD.setValue(formTables, "viewSubject", "PrimNeuroDxICD")
        txtPrimNeuroText.setValue(formTables, "viewSubject", "PrimNeuroDxText")
        cmbNicotineHx.SelectedValue = formTables.Tables("viewSubject").Rows(0).Item("NicotineHxValue")
        txtCigAgeStarted.setValue(formTables, "viewSubject", "CigAgeStarted")
        dtCigDateQuit.setValue(formTables, "viewSubject", "CigDateQuit")
        txtCigYrsUse.setValue(formTables, "viewSubject", "CigYearsUsed")
        txtCigFreq.setValue(formTables, "viewSubject", "CigFreq")
        cmbNicOthType.SelectedValue = formTables.Tables("viewSubject").Rows(0).Item("NicOthTypeValue")
        txtNicOthAgeStarted.Text = formTables.Tables("viewSubject").Rows(0).Item("NicOthAgeStarted").ToString
        dtNicOthDateQuit.setValue(formTables, "viewSubject", "NicOthDateQuit")
        txtNicOthYrsUse.setValue(formTables, "viewSubject", "NicOthYearsUsed")
        txtNicOthFreq.setValue(formTables, "viewSubject", "NicOthFreq")
        txtSubNum.setValue(formTables, "viewSubject", "SubNum")
        txtBB.setValue(formTables, "viewSubject", "BB")
        txtNACCID.setValue(formTables, "viewSubject", "NACCID")
        NACCIDType.setValue(formTables, "viewSubject", "NACCIDTypeValue")
        txtXENum.setValue(formTables, "viewSubject", "XENum")
        txtNotes.setValue(formTables, "viewSubject", "Notes")
        cmbHearingLoss.SelectedValue = formTables.Tables("viewSubject").Rows(0).Item("HearingLoss")
        comboDonationWishes.SelectedValue = formTables.Tables("viewSubject").Rows(0).Item("DonationWishesValue")
        If txtPrimPsychText.Text = "" And txtPrimNeuroText.Text = "" Then
            lblEmptyPsychNeuroDx.Visible = True
            btnPsychNeuroRelAdd.Enabled = False
        Else
            lblEmptyPsychNeuroDx.Visible = False
            btnPsychNeuroRelAdd.Enabled = True
        End If
    End Sub
    Public Sub refreshRelWithSimDx()
        formTables.Tables.Remove("Subject_RelWithSimDx")
        formTables.Tables.Add(Database.ReturnTable("Subject_RelWithSimDx", "RecordID, RelationValue, RelationLabel as Relation, AgeAtDx as 'Age at Dx', EdLevel as 'Ed. Level', RaceValue, RaceLabel as Race, DxICD as 'Dx ICD Code', DxText as 'Dx ICD Text'", "SubNum = " & WarehouseShell.SubNum))
        dgvRelWithSimilarDx.DataSource = formTables.Tables("Subject_RelWithSimDx")
        dgvRelWithSimilarDx.Columns("RecordID").Visible = False
        dgvRelWithSimilarDx.Columns("RelationValue").Visible = False
        dgvRelWithSimilarDx.Columns("RaceValue").Visible = False
    End Sub

    'Subs to enable-disable fields during data input based on conditional logic and calculated fields.
    Private Sub enableInputFields(ByVal value As Boolean)
        If value = False Then
            chkDNC.Enabled = False
            chkDNDiss.Enabled = False
            chkDNDist.Enabled = False
            cmbSalutation.Enabled = False
            txtFirstName.Enabled = False
            txtMI.Enabled = False
            txtLastName.Enabled = False
            txtSuffix.Enabled = False
            txtSSN.Enabled = False
            txtDoB.Enabled = False
            txtAddress1.Enabled = False
            txtAddress2.Enabled = False
            txtCity.Enabled = False
            txtState.Enabled = False
            txtZip.Enabled = False
            txtHomePhone.Enabled = False
            txtMobilePhone.Enabled = False
            txtWorkPhone.Enabled = False
            txtEmail.Enabled = False
            chkNACC.Enabled = False
            chkIsrael.Enabled = False
            chkADRC.Enabled = False
            chkNBTR.Enabled = False
            chkTBI.Enabled = False
            chkRelOrd.Enabled = False
            chkPPG.Enabled = False
            chkSchizo.Enabled = False
            ADRCClinicalTrialsCohort.Enabled = False
            comboSex.Enabled = False
            GenderATOD.Enabled = False
            SexualOrientationATOD.Enabled = False
            MilitaryService.Enabled = False
            cmbHearingLoss.Enabled = False
            comboEthnicity.Enabled = False
            txtEthSpec.Enabled = False
            comboRace.Enabled = False
            txtRaceSpec.Enabled = False
            comboPrimaryLanguage.Enabled = False
            comboSecondaryLanguage.Enabled = False
            txtLanguageNote.makeReadOnly(True)
            txtYearsOfEducation.Enabled = False
            txtPlaceOfBirth.Enabled = False
            txtLifetimeOccupation.Enabled = False
            comboHandedness.Enabled = False
            comboMultiBirth.Enabled = False
            txtMultiBirth.makeReadOnly(True)
            comboMobility.Enabled = False
            comboMaritalStatus.Enabled = False
            comboLevelOfIndependence.Enabled = False
            cmbNicotineHx.Enabled = False
            txtCigAgeStarted.Enabled = False
            dtCigDateQuit.Enabled = False
            txtCigFreq.Enabled = False
            cmbNicOthType.Enabled = False
            txtNicOthAgeStarted.Enabled = False
            dtNicOthDateQuit.Enabled = False
            txtNicOthFreq.Enabled = False
            txtSubNum.Enabled = False
            txtBB.Enabled = False
            txtNACCID.Enabled = False
            txtNotes.makeReadOnly(True)
            comboDonationWishes.Enabled = False
            btnDonationFile.Enabled = False
        ElseIf value = True Then
            chkDNC.Enabled = True
            chkDNDiss.Enabled = True
            chkDNDist.Enabled = True
            cmbSalutation.Enabled = True
            txtFirstName.Enabled = True
            txtMI.Enabled = True
            txtLastName.Enabled = True
            txtSuffix.Enabled = True
            txtSSN.Enabled = True
            txtDoB.Enabled = True
            txtAddress1.Enabled = True
            txtAddress2.Enabled = True
            txtCity.Enabled = True
            txtState.Enabled = True
            txtZip.Enabled = True
            txtHomePhone.Enabled = True
            txtMobilePhone.Enabled = True
            txtWorkPhone.Enabled = True
            txtEmail.Enabled = True
            chkNACC.Enabled = True
            chkIsrael.Enabled = True
            chkADRC.Enabled = True
            chkNBTR.Enabled = True
            chkTBI.Enabled = True
            chkRelOrd.Enabled = True
            chkPPG.Enabled = True
            chkSchizo.Enabled = True
            ADRCClinicalTrialsCohort.Enabled = True
            comboSex.Enabled = True
            GenderATOD.Enabled = True
            SexualOrientationATOD.Enabled = True
            MilitaryService.Enabled = True
            cmbHearingLoss.Enabled = True
            comboEthnicity.Enabled = True
            If comboEthnicity.SelectedValue = 5 Then
                txtEthSpec.Enabled = True
            End If
            comboRace.Enabled = True
            If comboRace.SelectedValue = 5 Then
                txtRaceSpec.Enabled = True
            End If
            comboPrimaryLanguage.Enabled = True
            comboSecondaryLanguage.Enabled = True
            txtLanguageNote.makeReadOnly(False)
            txtYearsOfEducation.Enabled = True
            txtPlaceOfBirth.Enabled = True
            txtLifetimeOccupation.Enabled = True
            comboHandedness.Enabled = True
            comboMultiBirth.Enabled = True
            txtMultiBirth.makeReadOnly(False)
            comboMobility.Enabled = True
            comboMaritalStatus.Enabled = True
            comboLevelOfIndependence.Enabled = True
            cmbNicotineHx.Enabled = True
            If cmbNicotineHx.SelectedValue > 1 Then
                txtCigAgeStarted.Enabled = True
                dtCigDateQuit.Enabled = True
                txtCigFreq.Enabled = True
                cmbNicOthType.Enabled = True
                txtNicOthAgeStarted.Enabled = True
                dtNicOthDateQuit.Enabled = True
                txtNicOthFreq.Enabled = True
            End If
            txtNACCID.Enabled = True
            txtNotes.makeReadOnly(False)
            comboDonationWishes.Enabled = True
            btnDonationFile.Enabled = True
        End If
    End Sub
    Private Sub txtDoB_LostFocus(sender As Object, e As EventArgs) Handles txtDoB.LostFocus
        If IsDate(txtDoB.Text) Then
            If WarehouseShell.DataMode <> WarehouseShell.userDataMode.Insert Then
                Dim myDate As String = formTables.Tables("viewSubject").Rows(0).Item("DateOfDeath").ToString
                If IsDate(myDate) Then
                    txtAge.Text = WarehouseShell.calcAge(CType(txtDoB.Text, Date), CType(myDate, Date)).ToString
                Else
                    txtAge.Text = WarehouseShell.calcAge(CType(txtDoB.Text, Date), Now()).ToString
                End If
            Else
                txtAge.Text = WarehouseShell.calcAge(CType(txtDoB.Text, Date), Now()).ToString
            End If
        Else
            txtAge.Clear()
        End If
    End Sub
    ''HERE
    Private Sub comboEthnicity_LostFocus(sender As Object, e As EventArgs) Handles comboEthnicity.LostFocus
        If comboEthnicity.SelectedValue = 5 Then
            txtEthSpec.Enabled = True
            txtEthSpec.Focus()
        Else
            txtEthSpec.Enabled = False
            txtEthSpec.Clear()
        End If
    End Sub
    Private Sub comboRace_LostFocus(sender As Object, e As EventArgs) Handles comboRace.LostFocus
        If comboRace.SelectedValue = 5 Then
            txtRaceSpec.Enabled = True
            txtRaceSpec.Focus()
        Else
            txtRaceSpec.Enabled = False
            txtRaceSpec.Clear()
        End If
    End Sub
    Private Sub comboMultiBirth_LostFocus(sender As Object, e As EventArgs) Handles comboMultiBirth.LostFocus
        If comboMultiBirth.SelectedValue = 1 Then
            txtMultiBirth.Enabled = True
            txtMultiBirth.Focus()
        Else
            txtMultiBirth.Enabled = False
            txtMultiBirth.Clear()
        End If
    End Sub
    Private Sub cmbNicotineHx_LostFocus(sender As Object, e As EventArgs) Handles cmbNicotineHx.LostFocus
        If cmbNicotineHx.SelectedValue > 1 Then
            txtCigAgeStarted.Enabled = True
            dtCigDateQuit.Enabled = True
            txtCigFreq.Enabled = True
            cmbNicOthType.Enabled = True
            txtNicOthAgeStarted.Enabled = True
            dtNicOthDateQuit.Enabled = True
            txtNicOthFreq.Enabled = True
            txtCigAgeStarted.Focus()
        Else
            txtCigAgeStarted.Enabled = False
            txtCigAgeStarted.Clear()
            dtCigDateQuit.Enabled = False
            dtCigDateQuit.Clear()
            txtCigYrsUse.Clear()
            txtCigFreq.Enabled = False
            txtCigFreq.Clear()
            cmbNicOthType.Enabled = False
            cmbNicOthType.SelectedValue = -1
            txtNicOthAgeStarted.Enabled = False
            txtNicOthAgeStarted.Clear()
            dtNicOthDateQuit.Enabled = False
            dtNicOthDateQuit.Clear()
            txtNicOthYrsUse.Clear()
            txtNicOthFreq.Enabled = False
            txtNicOthFreq.Clear()
        End If
    End Sub
    Private Sub calcYearsSmoked(sender As Object, e As EventArgs) Handles txtCigAgeStarted.LostFocus, dtCigDateQuit.LostFocus
        'Any calculation requires AgeStarted and DoB to determine year started, else clear YearsSmoked
        'If txtCigAgeStarted.Text <> "" And txtDoB.Text <> " /  / " Then
        'Define year started
        'Dim YrStartedSmoking = CInt(txtDoB.Text.Substring(6, 4)) + CInt(txtCigAgeStarted.Text)
        'Check for other data points available (DateQuit, DateOfDeath, Now()) and calculate
        'If dtCigDateQuit.Text <> " /  / " Then
        'Dim YrStoppedSmoking = CInt(dtCigDateQuit.Text.Substring(6, 4))
        'txtCigYrsUse.Text = (YrStoppedSmoking - YrStartedSmoking).ToString
        'ElseIf IsDate(formTables.Tables("viewSubject").Rows(0).Item("DateOfDeath")) Then 'Assume person smoked until death
        'Dim YrStoppedSmoking = CInt(formTables.Tables("viewSubject").Rows(0).Item("DateOfDeath").ToString.Substring(6, 4))
        'txtCigYrsUse.Text = (YrStoppedSmoking - YrStartedSmoking).ToString
        'Else 'Assume person is still alive and smoking today
        'Dim YrStoppedSmoking = CInt(Format(Now(), "yyyy"))
        'txtCigYrsUse.Text = (YrStoppedSmoking - YrStartedSmoking).ToString
        'End If
        'Else
        'txtCigYrsUse.Clear()
        'End If
    End Sub
    Private Sub calcNicotineOtherYearsUsed(sender As Object, e As EventArgs) Handles txtNicOthAgeStarted.LostFocus, dtNicOthDateQuit.LostFocus
        'Any calculation requires AgeStarted and DoB to determine year started, else clear YearsUsed
        If txtNicOthAgeStarted.Text <> "" And txtDoB.Text <> "  /  /" Then
            'Define year started
            Dim YrStartedNicotine = CInt(txtDoB.Text.Substring(6, 4)) + CInt(txtNicOthAgeStarted.Text)
            'Check for other data points available (DateQuit, DateOfDeath, Now()) and calculate
            If dtNicOthDateQuit.Text <> "  /  /" Then
                Dim YrStoppedNicotine = CInt(dtCigDateQuit.Text.Substring(6, 4))
                txtNicOthYrsUse.Text = (YrStoppedNicotine - YrStartedNicotine).ToString
            ElseIf IsDate(formTables.Tables("viewSubject").Rows(0).Item("DateOfDeath")) Then 'Assume person used nicotine until death
                Dim YrStoppedNicotine = CInt(formTables.Tables("viewSubject").Rows(0).Item("DateOfDeath").ToString.Substring(6, 4))
                txtNicOthYrsUse.Text = (YrStoppedNicotine - YrStartedNicotine).ToString
            Else 'Assume person is still alive and smoking today
                Dim YrStoppedNicotine = CInt(Format(Now(), "yyyy"))
                txtNicOthYrsUse.Text = (YrStoppedNicotine - YrStartedNicotine).ToString
            End If
        Else
            txtNicOthYrsUse.Clear()
        End If
    End Sub
    Private Sub txtXENum_Leave(sender As Object, e As EventArgs) Handles txtXENum.Leave
        If Not txtXENum.Text Like "XE##-###" Or txtXENum.Text = "" Then
            ActiveControl = txtXENum
        End If
    End Sub

    Private Sub chkADRC_CheckChanged(sender As Object, e As EventArgs) Handles chkADRC.CheckedChanged
        If chkADRC.Checked Then
            txtNACCID.Text = txtSubNum.Text
            NACCIDType.SelectedValue = 1
        Else
            txtNACCID.Clear()
            NACCIDType.SelectedValue = -1
        End If
    End Sub

    'Define button click events
    Private Function preSaveValidation() As Boolean
        Dim result As Boolean = True
        Dim errorMessage As String = "This form cannot be saved until the following errors are corrected:" & vbNewLine & vbNewLine

        If Not (txtXENum.Text Like "XE##-###" Or txtXENum.Text = "") Then
            errorMessage += "- XE # is not in a valid format (XE##-### or blank)." & vbNewLine
            result = False
        End If

        If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
            If txtSSN.Text <> "" Then
                Dim cmd As New SqlCommand("select count(*) from Subject where SSN = '" & txtSSN.Text & "';", WarehouseShell.conn)
                Dim value As Integer = cmd.ExecuteScalar()
                If value > 0 Then
                    errorMessage += "- SSN already exists in Warehouse!" & vbNewLine
                    result = False
                End If
            End If
        End If

        If result = False Then
            MsgBox(errorMessage, MsgBoxStyle.OkOnly, "Error!")
        End If

        Return result
    End Function
    Private Function secondaryPreSaveValidation() As Boolean
        Dim errorMessage As String = "These fields are missing from the subject form. Are you sure you would like to continue?" & vbNewLine & vbNewLine
        Dim result As Boolean = True

        If cmbSalutation.SelectedValue = -1 Then
            errorMessage += "- Salutation is missing." & vbNewLine
            result = False
        End If
        If txtFirstName.Text = "" Then
            errorMessage += "- First Name is missing." & vbNewLine
            result = False
        End If
        If txtLastName.Text = "" Then
            errorMessage += "- Last Name is missing." & vbNewLine
            result = False
        End If
        If txtDoB.Text = "  /  /" Then
            errorMessage += "- Date of Birth is missing." & vbNewLine
            result = False
        End If
        If comboRace.SelectedValue = -1 Then
            errorMessage += "- Race is missing." & vbNewLine
            result = False
        End If
        If comboPrimaryLanguage.SelectedValue = -1 Then
            errorMessage += "- Primary Language is missing." & vbNewLine
            result = False
        End If
        If GenderATOD.SelectedValue = -1 Then
            errorMessage += "- Gender ATOD is missing." & vbNewLine
            result = False
        End If
        If SexualOrientationATOD.SelectedValue = -1 Then
            errorMessage += "- Sexual Orientation ATOD is missing." & vbNewLine
            result = False
        End If
        If result = False Then
            Dim dResult As DialogResult = MessageBox.Show(errorMessage, "Warning!", MessageBoxButtons.YesNo)
            If dResult = DialogResult.Yes Then
                result = True
            End If
        End If
        Return result
    End Function
    Private Sub btnSubject_Click(sender As Object, e As EventArgs) Handles btnSubjectBottom.Click, btnSubjectTop.Click
        Infectious()
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If Database.ExistingRecordCheck("AutopsyFaceSheet", "SubNum = " & WarehouseShell.SubNum) Then
                If User.PermissionCheck("WA_Demographics", "Modify") Then
                    WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                    enableInputFields(True)
                    btnSubjectBottom.Text = "Save changes"
                    btnSubjectTop.Text = btnSubjectBottom.Text
                Else
                    MsgBox("This is a postmortem case and you do not have permission to edit this form.", MsgBoxStyle.OkOnly, "Warning")
                End If
            Else
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                enableInputFields(True)
                btnSubjectBottom.Text = "Save changes"
                btnSubjectTop.Text = btnSubjectBottom.Text
            End If
        Else
            If preSaveValidation() Then
                If secondaryPreSaveValidation() Then
                    Try
                        Dim SqlCommand As New SqlCommand
                        SqlCommand.Connection = WarehouseShell.conn
                        Dim CmdString = "@SubNum = " & txtSubNum.Text &
                            ", @Salutation = " & cmbSalutation.getSQLValue() &
                            ", @FirstName = " & txtFirstName.getSQLValue() &
                            ", @MI = " & txtMI.getSQLValue() &
                            ", @LastName = " & txtLastName.getSQLValue() &
                            ", @Suffix = " & txtSuffix.getSQLValue() &
                            ", @SSN = " & txtSSN.getSQLValue() &
                            ", @DoB = " & txtDoB.getSQLValue() &
                            ", @Address1 = " & txtAddress1.getSQLValue() &
                            ", @Address2 = " & txtAddress2.getSQLValue() &
                            ", @City = " & txtCity.getSQLValue() &
                            ", @State = " & txtState.getSQLValue() &
                            ", @Zip = " & txtZip.getSQLValue() &
                            ", @HomePhone = " & txtHomePhone.getSQLValue() &
                            ", @MobilePhone = " & txtMobilePhone.getSQLValue() &
                            ", @WorkPhone = " & txtWorkPhone.getSQLValue() &
                            ", @Email = " & txtEmail.getSQLValue() &
                            ", @GenderValue = " & GenderATOD.getSQLValue() &
                            ", @SexualOrientationATOD = " & SexualOrientationATOD.getSQLValue() &
                            ", @MilitaryService = " & MilitaryService.getSQLValue() &
                            ", @SchizoCohort = " & chkSchizo.getSQLValue() &
                            ", @NACCCohort = " & chkNACC.getSQLValue() &
                            ", @PPGCohort = " & chkPPG.getSQLValue() &
                            ", @IsraelCohort = " & chkIsrael.getSQLValue() &
                            ", @ADRCCohort = " & chkADRC.getSQLValue() &
                            ", @NBTRCohort = " & chkNBTR.getSQLValue() &
                            ", @TBICohort = " & chkTBI.getSQLValue() &
                            ", @ReligiousOrderCohort = " & chkRelOrd.getSQLValue() &
                            ", @ClinicalTrialsCohort = " & ADRCClinicalTrialsCohort.getSQLValue() &
                            ", @SexValue = " & comboSex.getSQLValue() &
                            ", @SexLabel = " & comboSex.getSQLLabel() &
                            ", @EthnicityValue = " & comboEthnicity.getSQLValue() &
                            ", @EthnicityLabel = " & comboEthnicity.getSQLLabel() &
                            ", @EthnicityNote = " & txtEthSpec.getSQLValue() &
                            ", @RaceValue = " & comboRace.getSQLValue() &
                            ", @RaceLabel = " & comboRace.getSQLLabel() &
                            ", @RaceNote = " & txtRaceSpec.getSQLValue() &
                            ", @PrimaryLanguageValue = " & comboPrimaryLanguage.getSQLValue() &
                            ", @PrimaryLanguageLabel = " & comboPrimaryLanguage.getSQLLabel() &
                            ", @SecondaryLanguageValue = " & comboSecondaryLanguage.getSQLValue() &
                            ", @SecondaryLanguageLabel = " & comboSecondaryLanguage.getSQLLabel() &
                            ", @LanguageNote = " & txtLanguageNote.getSQLValue() &
                            ", @YearsOfEducation = " & txtYearsOfEducation.getSQLValue() &
                            ", @LevelOfIndependenceValue = " & comboLevelOfIndependence.getSQLValue() &
                            ", @LevelOfIndependenceLabel = " & comboLevelOfIndependence.getSQLLabel() &
                            ", @PlaceOfBirth = " & txtPlaceOfBirth.getSQLValue() &
                            ", @LifetimeOccupation = " & txtLifetimeOccupation.getSQLValue() &
                            ", @HandednessValue = " & comboHandedness.getSQLValue() &
                            ", @HandednessLabel = " & comboHandedness.getSQLLabel() &
                            ", @MultBirthValue = " & comboMultiBirth.getSQLValue() &
                            ", @MultBirthLabel = " & comboMultiBirth.getSQLLabel() &
                            ", @MultBirthNote = " & txtMultiBirth.getSQLValue() &
                            ", @MobilityStatusValue = " & comboMobility.getSQLValue() &
                            ", @MobilityStatusLabel = " & comboMobility.getSQLLabel() &
                            ", @MaritalStatusValue = " & comboMaritalStatus.getSQLValue() &
                            ", @MaritalStatusLabel = " & comboMaritalStatus.getSQLLabel() &
                            ", @NicotineHxValue = " & cmbNicotineHx.getSQLValue() &
                            ", @NicotineHxLabel = " & cmbNicotineHx.getSQLLabel() &
                            ", @CigAgeStarted = " & txtCigAgeStarted.getSQLValue() &
                            ", @CigDateQuit = " & dtCigDateQuit.getSQLValue() &
                            ", @CigYearsUsed = " & txtCigYrsUse.getSQLValue() &
                            ", @CigFreq = " & txtCigFreq.getSQLValue() &
                            ", @NicOthTypeValue = " & cmbNicOthType.getSQLValue() &
                            ", @NicOthTypeLabel = " & cmbNicOthType.getSQLLabel() &
                            ", @NicOthAgeStarted = " & txtNicOthAgeStarted.getSQLValue() &
                            ", @NicOthDateQuit = " & dtNicOthDateQuit.getSQLValue() &
                            ", @NicOthYearsUsed = " & txtNicOthYrsUse.getSQLValue() &
                            ", @NicOthFreq = " & txtNicOthFreq.getSQLValue() &
                            ", @Notes = " & txtNotes.getSQLValue() &
                            ", @DonationWishesValue = " & comboDonationWishes.getSQLValue() &
                            ", @DonationWishesLabel = " & comboDonationWishes.getSQLLabel() &
                            ", @NACCID = " & txtNACCID.getSQLValue() &
                            ", @NACCIDType = " & NACCIDType.getSQLValue() &
                            ", @DoNotContact = " & chkDNC.getSQLValue() &
                            ", @DoNotDissect = " & chkDNDiss.getSQLValue() &
                            ", @DoNotDistribute = " & chkDNDist.getSQLValue() &
                            ", @DonationTrackerID = " & IIf(WarehouseShell.RecordID.ToString = "", "Null", WarehouseShell.RecordID) &
                            ", @HearingLoss = " & cmbHearingLoss.getSQLValue() &
                            ", @LastModBy = " & WarehouseShell.userName &
                            ";"
                        If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                            SqlCommand.CommandText = "EXEC dbo.modSubjectRecord @Action = 1, " & CmdString
                            SqlCommand.ExecuteNonQuery()
                            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                            'TODO: Some code here to update the header with newly created subject data.
                            WarehouseShell.SubNum = txtSubNum.Text
                            DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).manualUpdateHeaderData(txtSubNum.Text, txtBB.Text, txtFirstName.Text, txtLastName.Text, IIf(txtDoB.Text <> "  /  /", txtDoB.Text, ""), , txtSSN.Text, txtAge.Text)
                            DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).enableInputFields(False)
                            DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).btnFilter.Visible = False
                            MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            WarehouseShell.tvFormMenu.Visible = True
                            WarehouseShell.tvReportMenu.Visible = False
                            WarehouseShell.tvFormMenu.Dock = DockStyle.Fill
                            WarehouseShell.tvFormMenu.Dock = DockStyle.Fill
                            WarehouseShell.LoadSubjectTreeView()
                            WarehouseShell.LoadWorkingAreaForm(WarehouseShell.formType.WA_ExistingSubjectRecords)
                            WarehouseShell.RecordID = Nothing
                        Else
                            SqlCommand.CommandText = "EXEC dbo.modSubjectRecord @Action = 2, " & CmdString
                            SqlCommand.ExecuteNonQuery()
                            DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).manualUpdateHeaderData(txtSubNum.Text, txtBB.Text, txtFirstName.Text, txtLastName.Text, IIf(txtDoB.Text <> "  /  /", txtDoB.Text, ""), txtSSN.Text, txtAge.Text)
                            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                            enableInputFields(False)
                            btnSubjectBottom.Text = "Edit Record"
                            btnSubjectTop.Text = btnSubjectBottom.Text
                            If Database.ExistingRecordCheck("CERAD_Header", "SubNum = " & WarehouseShell.SubNum) Then
                                If txtXENum.Text <> formTables.Tables("viewSubject").Rows(0).Item("XENum").ToString And txtXENum.Text <> "" Then
                                    Dim cmd As New SqlCommand("update CERAD_Header set XENum = " & txtXENum.getSQLValue() & " where SubNum = " & WarehouseShell.SubNum, WarehouseShell.conn)
                                    cmd.ExecuteNonQuery()
                                End If
                            Else
                                If txtXENum.Text <> "" Then
                                    Dim cmd As New SqlCommand("insert into CERAD_Header(SubNum, XENum) values (" & WarehouseShell.SubNum & ", " & txtXENum.getSQLValue() & ");", WarehouseShell.conn)
                                    cmd.ExecuteNonQuery()
                                End If
                            End If
                            MessageBox.Show("Record successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            WarehouseShell.RecordID = Nothing
                        End If
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                End If
            End If
        End If
    End Sub
    Private Sub btnPsychNeuroRelAdd_Click(sender As Object, e As EventArgs) Handles btnPsychNeuroRelAdd.Click
        PU_Subject_RelWithSimDx.ShowDialog()
        PU_Subject_RelWithSimDx.senderDataMode = WarehouseShell.DataMode
        PU_Subject_RelWithSimDx.Dispose()
    End Sub

    Private Sub chkDNC_CheckedChanged(sender As Object, e As EventArgs) Handles chkDNC.CheckedChanged
        If chkTBI.Checked And chkDNC.CheckState = 0 Then
            MsgBox("This subject is a member of the TBI Cohort so this cannot be unchecked", MsgBoxStyle.OkOnly, "Warning")
            chkDNC.Checked = True
        End If
        DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).DoNotContact(chkDNC.Checked)
    End Sub
    Private Sub chkDNDiss_CheckedChanged(sender As Object, e As EventArgs) Handles chkDNDiss.CheckedChanged
        If chkTBI.Checked And chkDNDiss.CheckState = 0 Then
            MsgBox("This subject is a member of the TBI Cohort so this cannot be unchecked", MsgBoxStyle.OkOnly, "Warning")
            chkDNDiss.Checked = True
        End If
        DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).DoNotDissect(chkDNDiss.Checked)
    End Sub
    Private Function Infectious() As Boolean
        Dim result As Boolean = False
        Dim query As String = "select count(*) from Labs where SubNum = '" & WarehouseShell.SubNum & "' and Lab in (select LabID from reflabs where Infectious = 1) and QualitativeResult = 'Positive' "
        Dim command As New SqlCommand(query, WarehouseShell.conn)
        Dim value As Integer = command.ExecuteScalar()
        If value > 0 Then
            result = True
        End If
        Return result
    End Function
    Private Sub chkDNDist_CheckedChanged(sender As Object, e As EventArgs) Handles chkDNDist.CheckedChanged
        If chkDNDist.CheckState = 0 Then
            If Infectious() Then
                MsgBox("This subject has tested positive for an infectious Disease and this cannot be unchecked", MsgBoxStyle.OkOnly, "Warning")
                chkDNDist.Checked = True
            End If
        End If
        DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).InfectiousState(chkDNDist.Checked)
    End Sub
    Private Sub chkTBI_CheckChanged(sender As Object, e As EventArgs) Handles chkTBI.CheckedChanged
        If chkTBI.Checked Then
            chkDNDiss.Checked = True
            chkDNC.Checked = True
        End If
    End Sub


    'Imported IFormMethods
    Public Sub Parent1(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Public Sub Show1() Implements IFormMethods.Show
        Show()
    End Sub
    Public Sub ShowPHI(val As Boolean) Implements IFormMethods.ShowPHI
        If val = False Then
            txtFirstName.PasswordChar = "*"
            txtMI.PasswordChar = "*"
            txtLastName.PasswordChar = "*"
            txtSSN.PasswordChar = "*"
            txtDoB.PasswordChar = "*"
            txtAddress1.PasswordChar = "*"
            txtAddress2.PasswordChar = "*"
            txtCity.PasswordChar = "*"
            txtHomePhone.PasswordChar = "*"
            txtMobilePhone.PasswordChar = "*"
            txtWorkPhone.PasswordChar = "*"
            txtEmail.PasswordChar = "*"
            txtPlaceOfBirth.PasswordChar = "*"
        Else
            txtFirstName.PasswordChar = ""
            txtMI.PasswordChar = ""
            txtLastName.PasswordChar = ""
            txtSSN.PasswordChar = ""
            txtDoB.PasswordChar = ""
            txtAddress1.PasswordChar = ""
            txtAddress2.PasswordChar = ""
            txtCity.PasswordChar = ""
            txtHomePhone.PasswordChar = ""
            txtMobilePhone.PasswordChar = ""
            txtWorkPhone.PasswordChar = ""
            txtEmail.PasswordChar = ""
            txtPlaceOfBirth.PasswordChar = ""
        End If
    End Sub
    Public Sub TopLevel1(val As Boolean) Implements IFormMethods.TopLevel
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        btnSubjectBottom.PerformClick()
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub

End Class