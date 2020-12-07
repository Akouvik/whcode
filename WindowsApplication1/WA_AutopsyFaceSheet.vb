Imports iTextSharp.text.pdf

Public Class WA_AutopsyFaceSheet
    Implements IFormMethods
    Private formTables As New DataSet 'Holds the returned form data from the database for edit/view modes
    Private tooltip1 As New ToolTip 'Primarily called during data input validation

    'Load form and set data mode
    'Akouvi changes
    Private Sub WA_AutopsyFaceSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_AutopsyFaceSheet")
        loadBaseForm()
        defaultValues()
        enableInputFields(False)
        If Database.ExistingRecordCheck("AutopsyFaceSheet", "SubNum = " & WarehouseShell.SubNum) Then
            'Load the form data
            loadExistingData()
            btnAutopsyFaceSheetBottom.Text = "Edit this record"
            btnAutopsyFaceSheetTop.Text = btnAutopsyFaceSheetBottom.Text
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            loadFileData()
        Else
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            btnAutopsyFaceSheetBottom.Text = "Add New Record"
            btnAutopsyFaceSheetTop.Text = btnAutopsyFaceSheetBottom.Text
            lblNoRecord.Visible = True
            loadFileData()
        End If
        If Database.ExistingRecordCheck("PreEnrollment", "SubNum = " & WarehouseShell.SubNum) Then
            Dim cmd As New SqlCommand("select ReferralSourceValue from PreEnrollment where SubNum = " & WarehouseShell.SubNum & ";", WarehouseShell.conn)
            Dim value As Integer = cmd.ExecuteScalar()
            cmbPreEnrollmentSource.SelectedValue = value
        End If
    End Sub

    Private Sub LoadDonationTrackerInfo()
        If Database.ExistingRecordCheck("Subject", "SubNum = " & WarehouseShell.SubNum & " and DonationTrackerID <> 0 and DonationTrackerID is not null") Then
            Dim cmd As New SqlCommand("Select DonationTrackerID from Subject where Subnum = " & WarehouseShell.SubNum & ";", WarehouseShell.conn)
            Dim donationTrackerID As Integer = cmd.ExecuteScalar()
            formTables.Tables.Add(Database.ReturnTable("DonationReferralTracker",, "RecordID = " & donationTrackerID))
            cmbDonationCoordinator.setValue(formTables, "DonationReferralTracker", "ReceivedBy")
            txtExternalID.setValue(formTables, "DonationReferralTracker", "ReferralID")
            comboPlaceOfDeath.setValue(formTables, "DonationReferralTracker", "PlaceOfDeath")
            txtConsentorName.setValue(formTables, "DonationReferralTracker", "NoKName")
            comboConsentorRelation.setValue(formTables, "DonationReferralTracker", "NoKRelation")
        End If
    End Sub

    'Grab applicable lookup tables and assign the actual lookup values
    Private Sub loadBaseForm()
        ShowPHI(WarehouseShell.ShowingPHI)
        'Load all required lookup tables into the formTables DataSet
        formTables.Tables.Add(Database.ReturnTable("lkpAutopsyBloodTakenType"))
        formTables.Tables.Add(Database.ReturnTable("lkpAutopsyConsentType"))
        formTables.Tables.Add(Database.ReturnTable("refUser"))
        formTables.Tables.Add(Database.ReturnTable("lkpMannerOfDeath"))
        formTables.Tables.Add(Database.ReturnTable("refInstitution", , , "Name"))
        formTables.Tables.Add(Database.ReturnTable("lkpRelation"))
        formTables.Tables.Add(Database.ReturnTable("lkpYNUnk129"))
        formTables.Tables.Add(Database.ReturnTable("lkpYN12"))
        formTables.Tables.Add(Database.ReturnTable("lkpPreEnrollmentSources"))
        formTables.Tables.Add(Database.ReturnTable("lkpExternalConsentSource"))
        formTables.Tables.Add(Database.ReturnTable("lkpAlzAcceptCrit"))
        'Assign lookup values to each individual combobox
        ADCriteria.assignLookup(formTables, "lkpAlzAcceptCrit")
        comboBloodType.assignLookup(formTables, "lkpAutopsyBloodTakenType")
        comboConsentType.assignLookup(formTables, "lkpAutopsyConsentType")
        MannerOfDeath.assignLookup(formTables, "lkpMannerOfDeath")
        comboConsentorRelation.assignLookup(formTables, "lkpRelation")
        comboSpinal.assignLookup(formTables, "lkpYNUnk129")
        comboProsector1.assignLookup(formTables, "refUser", "RaterID", "Name", "Prosector = 1", "Name")
        comboProsector2.assignLookup(formTables, "refUser", "RaterID", "Name", "Prosector = 1", "Name")
        Dissectionist.assignLookup(formTables, "refUser", "RaterID", "Name", "Dissectionist = 1", "Name")
        comboAutopsySite.assignLookup(formTables, "refInstitution", "InstitutionID", "Name")
        comboPlaceOfDeath.assignLookup(formTables, "refInstitution", "InstitutionID", "Name")
        comboReferringInst.assignLookup(formTables, "refInstitution", "InstitutionID", "Name")
        cmbPreEnrollmentSource.assignLookup(formTables, "lkpPreEnrollmentSources")
        ExternalConsent.assignLookup(formTables, "lkpExternalConsentSource")
        cmbDonationCoordinator.assignLookup(formTables, "refUser", "RaterID", "Name", "DonationCoordinator = 1")
    End Sub

    'Sub to set default values for combo boxes.
    Private Sub defaultValues()
        MannerOfDeath.SelectedValue = 4
        comboSpinal.SelectedValue = -1
        comboBloodType.SelectedValue = -1
        comboConsentType.SelectedValue = -1
        comboConsentorRelation.SelectedValue = -1
        comboProsector1.SelectedValue = -1
        comboProsector2.SelectedValue = -1
        Dissectionist.SelectedValue = -1
        comboAutopsySite.SelectedValue = -1
        comboPlaceOfDeath.SelectedValue = -1
        comboReferringInst.SelectedValue = -1
        ExternalConsent.SelectedValue = -1
        cmbDonationCoordinator.SelectedValue = -1
        ADCriteria.SelectedValue = "-1"
        LoadDonationTrackerInfo()
    End Sub

    'Sub to load existing values into form if ExistingRecordCheck returns true
    Private Sub loadExistingData() 'CHECK CONSENT TIME CONVERSIONS!!!
        'Grab the record for this subnum
        'Long-form return table because dates and times must be converted.
        formTables.Tables.Add(Database.ReturnTable("viewAutopsyFaceSheet", , "SubNum = " & WarehouseShell.SubNum))
        'Apply the existing values to the input fields
        txtBBNum.setValue(formTables, "viewAutopsyFaceSheet", "BB")
        txtExternalID.setValue(formTables, "viewAutopsyFaceSheet", "ExternalID")
        cmbDonationCoordinator.setValue(formTables, "viewAutopsyFaceSheet", "DonationCoordinatorValue")
        txtDoD.setValue(formTables, "viewAutopsyFaceSheet", "DateOfDeath")
        txtToD.setValue(formTables, "viewAutopsyFaceSheet", "TimeOfDeath")
        txtDateOnIce.setValue(formTables, "viewAutopsyFaceSheet", "DateOnIce")
        txtTimeOnIce.setValue(formTables, "viewAutopsyFaceSheet", "TimeOnIce")
        intPMI.setValue(formTables, "viewAutopsyFaceSheet", "PMI")
        txtPrimCausDeath.setValue(formTables, "viewAutopsyFaceSheet", "PrimCauseDeath")
        txtSecCauseDeath.setValue(formTables, "viewAutopsyFaceSheet", "SecCauseDeath")
        txtTempDX.setValue(formTables, "viewAutopsyFaceSheet", "TempDx")
        MannerOfDeath.setValue(formTables, "viewAutopsyFaceSheet", "MannerOfDeathValue")
        MannerOfDeathSpec.setValue(formTables, "viewAutopsyFaceSheet", "MannerOfDeathSpec")
        ADCriteria.setValue(formTables, "viewAutopsyFaceSheet", "ADCriteriaValue")
        CovidCriteria.setValue(formTables, "viewAutopsyFaceSheet", "CovidCriteria")
        txtTotalBrainWeight.setValue(formTables, "viewAutopsyFaceSheet", "BrainWtTot")
        txtCerBSWeight.setValue(formTables, "viewAutopsyFaceSheet", "BrainWtCerBS")
        txtRightBrainWeight.setValue(formTables, "viewAutopsyFaceSheet", "BrainWtRt")
        txtLeftBrainWeight.setValue(formTables, "viewAutopsyFaceSheet", "BrainWtLt")
        comboSpinal.setValue(formTables, "viewAutopsyFaceSheet", "SpinalCordTakenValue")
        txtSpinal.setValue(formTables, "viewAutopsyFaceSheet", "SpinalCordWeight")
        txtCSF.setValue(formTables, "viewAutopsyFaceSheet", "CSFVials")
        comboBloodType.setValue(formTables, "viewAutopsyFaceSheet", "TypeBloodTakenValue")
        txtPlasma.setValue(formTables, "viewAutopsyFaceSheet", "PlasmaVials")
        txtSerum.setValue(formTables, "viewAutopsyFaceSheet", "SerumVials")
        txtBloodTox.setValue(formTables, "viewAutopsyFaceSheet", "BloodToxVials")
        txtDNA.setValue(formTables, "viewAutopsyFaceSheet", "DNAVials")
        txtRNA.setValue(formTables, "viewAutopsyFaceSheet", "RNAVials")
        Hemisphere.setValue(formTables, "viewAutopsyFaceSheet", "Hemisphere")
        Freezer.setValue(formTables, "viewAutopsyFaceSheet", "Freezer")
        Shelf.setValue(formTables, "viewAutopsyFaceSheet", "Shelf")
        Barcode.setValue(formTables, "viewAutopsyFaceSheet", "Barcode")
        MicrobiomeVials.setValue(formTables, "viewAutopsyFaceSheet", "MicrobiomeVials")
        txtConsentorName.setValue(formTables, "viewAutopsyFaceSheet", "Consentor")
        comboConsentorRelation.setValue(formTables, "viewAutopsyFaceSheet", "ConsentorRelationValue")
        txtRelationSpecify.setValue(formTables, "viewAutopsyFaceSheet", "ConsentorRelationNote")
        txtConsentorAddress1.setValue(formTables, "viewAutopsyFaceSheet", "ConsentorAddress1")
        txtConsentorAddress2.setValue(formTables, "viewAutopsyFaceSheet", "ConsentorAddress2")
        txtConsentorAddress3.setValue(formTables, "viewAutopsyFaceSheet", "ConsentorAddress3")
        txtConsentorCity.setValue(formTables, "viewAutopsyFaceSheet", "ConsentorCity")
        txtConsentorState.setValue(formTables, "viewAutopsyFaceSheet", "ConsentorState")
        txtConsentorZip.setValue(formTables, "viewAutopsyFaceSheet", "ConsentorZip")
        txtConsentorHomePhone.setValue(formTables, "viewAutopsyFaceSheet", "ConsentorHomePhone")
        txtConsentorMobilePhone.setValue(formTables, "viewAutopsyFaceSheet", "ConsentorMobilePhone")
        txtConsentorWorkPhone.setValue(formTables, "viewAutopsyFaceSheet", "ConsentorWorkPhone")
        txtConsentorEmail.setValue(formTables, "viewAutopsyFaceSheet", "ConsentorEmail")
        comboConsentType.setValue(formTables, "viewAutopsyFaceSheet", "ConsentTypeValue")
        txtConsentDate.setValue(formTables, "viewAutopsyFaceSheet", "ConsentDate")
        txtConsentTime.setValue(formTables, "viewAutopsyFaceSheet", "ConsentTime")
        comboProsector1.setValue(formTables, "viewAutopsyFaceSheet", "Prosector1Value")
        comboProsector2.setValue(formTables, "viewAutopsyFaceSheet", "Prosector2Value")
        Dissectionist.setValue(formTables, "viewAutopsyFaceSheet", "DissectionistValue")
        comboAutopsySite.setValue(formTables, "viewAutopsyFaceSheet", "AutopsyLocationValue")
        txtTimeProsectorInformed.setValue(formTables, "viewAutopsyFaceSheet", "TimeProsInformedOfDeath")
        txtTimeProsectorArrived.setValue(formTables, "viewAutopsyFaceSheet", "TimeProsArrAutLocation")
        txtTimeBodyArrived.setValue(formTables, "viewAutopsyFaceSheet", "TimeBodyArrAutLocation")
        txtTimeAutopsyStarted.setValue(formTables, "viewAutopsyFaceSheet", "TimeAutopsyStarted")
        txtTimeAutopsyFinished.setValue(formTables, "viewAutopsyFaceSheet", "TimeAutopsyEnded")
        txtDateFuneralDirAlerted.setValue(formTables, "viewAutopsyFaceSheet", "DateFuneralDirAlerted")
        txtTimeFuneralDirAlerted.setValue(formTables, "viewAutopsyFaceSheet", "TimeFuneralDirAlerted")
        comboPlaceOfDeath.setValue(formTables, "viewAutopsyFaceSheet", "PlaceOfDeathValue")
        comboReferringInst.setValue(formTables, "viewAutopsyFaceSheet", "ReferringInstitutionValue")
        txtRefPhys.setValue(formTables, "viewAutopsyFaceSheet", "ReferringPhysician")
        ExternalConsent.setValue(formTables, "viewAutopsyFaceSheet", "ExternalConsentSourceValue")
        txtComments.setValue(formTables, "viewAutopsyFaceSheet", "Notes")
        chkAutIssues.setValue(formTables, "viewAutopsyFaceSheet", "AutopsyIssues")
        txtAutIssuesNote.setValue(formTables, "viewAutopsyFaceSheet", "AutopsyIssuesNote")
        chkSpecTissProc.setValue(formTables, "viewAutopsyFaceSheet", "SpecTissProc")
        txtSpecTissProc.setValue(formTables, "viewAutopsyFaceSheet", "SpecTissProcNote")
    End Sub

    'Sub to load image data (ran on load, regardless of mode)
    Private Sub loadFileData()
        If SubjectFiles1to1.CheckFile("fileAutopsyConsent", WarehouseShell.SubNum) Then
            btnConsent.Text = "View Consent"
            btnConsent.BackColor = Color.Chartreuse
            btnConsentDelete.Visible = True
        Else
            btnConsent.Text = "Add Consent"
            btnConsent.BackColor = Color.Linen
            btnConsentDelete.Visible = False
        End If

        If SubjectFiles1to1.CheckFile("fileDeathCertificate", WarehouseShell.SubNum) Then
            btnDeathCert.Text = "View Death Certificate"
            btnDeathCert.BackColor = Color.Chartreuse
            btnDeathCertDelete.Visible = True
        Else
            btnDeathCert.Text = "Add Death Certificate"
            btnDeathCert.BackColor = Color.Linen
            btnDeathCertDelete.Visible = False
        End If

        If SubjectFiles1to1.CheckFile("fileReferralDocument", WarehouseShell.SubNum) Then
            btnReferralDoc.Text = "View Referral Doc"
            btnReferralDoc.BackColor = Color.Chartreuse
            btnReferralDocDelete.Visible = True
        Else
            btnReferralDoc.Text = "Add Referral Doc"
            btnReferralDoc.BackColor = Color.Linen
            btnReferralDocDelete.Visible = False
        End If

        If SubjectFiles1toMany.CheckFile("fileReleaseOfMedRecords", WarehouseShell.SubNum) Then
            btnMedicalRecordsRelease.Text = "View Rel. Med. Records"
            btnMedicalRecordsRelease.BackColor = Color.Chartreuse
            btnMedRecordsReleaseDelete.Visible = True
        Else
            btnMedicalRecordsRelease.Text = "Add Rel. Med. Records"
            btnMedicalRecordsRelease.BackColor = Color.Linen
            btnMedRecordsReleaseDelete.Visible = False
        End If

        If SubjectFiles1toMany.CheckFile("filePreEnrollment", WarehouseShell.SubNum) Then
            btnScannedForm.BackColor = Color.Chartreuse
            btnScannedForm.Enabled = True
        Else
            btnScannedForm.BackColor = Color.Linen
            btnScannedForm.Enabled = False
        End If
    End Sub

    'Subs to enable-disable fields during data input based on conditional logic.
    Private Sub enableInputFields(ByVal value As Boolean)
        If value = True Then
            txtBBNum.makeReadOnly(False)
            txtExternalID.makeReadOnly(False)
            cmbDonationCoordinator.Enabled = True
            txtDoD.makeReadOnly(False)
            txtToD.makeReadOnly(False)
            txtDateOnIce.makeReadOnly(False)
            txtTimeOnIce.makeReadOnly(False)
            txtPrimCausDeath.makeReadOnly(False)
            txtSecCauseDeath.makeReadOnly(False)
            txtTempDX.makeReadOnly(False)
            MannerOfDeath.Enabled = True
            MannerOfDeathSpec.makeReadOnly(False)
            ADCritSelect.Enabled = True
            CovidCritSelect.Enabled = True
            txtTotalBrainWeight.makeReadOnly(False)
            txtRightBrainWeight.makeReadOnly(False)
            txtLeftBrainWeight.makeReadOnly(False)
            txtCerBSWeight.makeReadOnly(False)
            txtCSF.makeReadOnly(False)
            txtPlasma.makeReadOnly(False)
            txtSerum.makeReadOnly(False)
            txtBloodTox.makeReadOnly(False)
            txtDNA.makeReadOnly(False)
            txtRNA.makeReadOnly(False)
            MicrobiomeVials.makeReadOnly(False)
            comboBloodType.Enabled = True
            comboSpinal.Enabled = True
            If comboSpinal.SelectedValue = 1 Then
                txtSpinal.makeReadOnly(False)
            End If
            comboConsentType.Enabled = True
            txtConsentDate.makeReadOnly(False)
            txtConsentTime.makeReadOnly(False)
            txtConsentorName.makeReadOnly(False)
            comboConsentorRelation.Enabled = True
            txtRelationSpecify.makeReadOnly(False)
            txtConsentorAddress1.makeReadOnly(False)
            txtConsentorAddress2.makeReadOnly(False)
            txtConsentorAddress3.makeReadOnly(False)
            txtConsentorCity.makeReadOnly(False)
            txtConsentorState.makeReadOnly(False)
            txtConsentorZip.makeReadOnly(False)
            txtConsentorHomePhone.makeReadOnly(False)
            txtConsentorMobilePhone.makeReadOnly(False)
            txtConsentorWorkPhone.makeReadOnly(False)
            txtConsentorEmail.makeReadOnly(False)
            btnConsent.Enabled = True
            btnConsentDelete.Enabled = True
            comboProsector1.Enabled = True
            comboProsector2.Enabled = True
            Dissectionist.Enabled = True
            comboAutopsySite.Enabled = True
            btnSuggestNewAutSite.Enabled = True
            txtTimeProsectorInformed.makeReadOnly(False)
            txtTimeProsectorArrived.makeReadOnly(False)
            txtTimeBodyArrived.makeReadOnly(False)
            txtTimeAutopsyStarted.makeReadOnly(False)
            txtTimeAutopsyFinished.makeReadOnly(False)
            txtDateFuneralDirAlerted.makeReadOnly(False)
            txtTimeFuneralDirAlerted.makeReadOnly(False)
            btnDeathCert.Enabled = True
            btnDeathCertDelete.Enabled = True
            btnReferralDoc.Enabled = True
            btnReferralDocDelete.Enabled = True
            btnMedicalRecordsRelease.Enabled = True
            comboPlaceOfDeath.Enabled = True
            btnSuggestNewPoD.Enabled = True
            comboReferringInst.Enabled = True
            btnSuggestNewRefInst.Enabled = True
            txtRefPhys.makeReadOnly(False)
            ExternalConsent.Enabled = True
            txtComments.makeReadOnly(False)
            chkAutIssues.Enabled = True
            If chkAutIssues.Checked = True Then
                txtAutIssuesNote.makeReadOnly(False)
            End If
            chkSpecTissProc.Enabled = True
            If chkSpecTissProc.Checked Then
                txtSpecTissProc.makeReadOnly(False)
            End If
        Else
            txtBBNum.makeReadOnly(True)
            txtExternalID.makeReadOnly(True)
            cmbDonationCoordinator.Enabled = False
            txtDoD.makeReadOnly(True)
            txtToD.makeReadOnly(True)
            txtDateOnIce.makeReadOnly(True)
            txtTimeOnIce.makeReadOnly(True)
            txtPrimCausDeath.makeReadOnly(True)
            txtSecCauseDeath.makeReadOnly(True)
            txtTempDX.makeReadOnly(True)
            MannerOfDeath.Enabled = False
            MannerOfDeathSpec.makeReadOnly(True)
            ADCritSelect.Enabled = False
            CovidCritSelect.Enabled = False
            txtTotalBrainWeight.makeReadOnly(True)
            txtRightBrainWeight.makeReadOnly(True)
            txtLeftBrainWeight.makeReadOnly(True)
            txtCerBSWeight.makeReadOnly(True)
            comboBloodType.Enabled = False
            comboSpinal.Enabled = False
            txtSpinal.makeReadOnly(True)
            txtCSF.makeReadOnly(True)
            txtPlasma.makeReadOnly(True)
            txtSerum.makeReadOnly(True)
            txtBloodTox.makeReadOnly(True)
            txtDNA.makeReadOnly(True)
            txtRNA.makeReadOnly(True)
            MicrobiomeVials.makeReadOnly(True)
            comboConsentType.Enabled = False
            txtConsentDate.makeReadOnly(True)
            txtConsentTime.makeReadOnly(True)
            txtConsentorName.makeReadOnly(True)
            comboConsentorRelation.Enabled = False
            txtRelationSpecify.makeReadOnly(True)
            txtConsentorAddress1.makeReadOnly(True)
            txtConsentorAddress2.makeReadOnly(True)
            txtConsentorAddress3.makeReadOnly(True)
            txtConsentorCity.makeReadOnly(True)
            txtConsentorState.makeReadOnly(True)
            txtConsentorZip.makeReadOnly(True)
            txtConsentorHomePhone.makeReadOnly(True)
            txtConsentorMobilePhone.makeReadOnly(True)
            txtConsentorWorkPhone.makeReadOnly(True)
            txtConsentorEmail.makeReadOnly(True)
            If SubjectFiles1to1.CheckFile("fileAutopsyConsent", WarehouseShell.SubNum) Then
                btnConsent.Enabled = True
            Else
                btnConsent.Enabled = False
            End If
            btnConsentDelete.Enabled = False
            comboProsector1.Enabled = False
            comboProsector2.Enabled = False
            Dissectionist.Enabled = False
            comboAutopsySite.Enabled = False
            btnSuggestNewAutSite.Enabled = False
            txtTimeProsectorInformed.makeReadOnly(True)
            txtTimeProsectorArrived.makeReadOnly(True)
            txtTimeBodyArrived.makeReadOnly(True)
            txtTimeAutopsyStarted.makeReadOnly(True)
            txtTimeAutopsyFinished.makeReadOnly(True)
            txtDateFuneralDirAlerted.makeReadOnly(True)
            txtTimeFuneralDirAlerted.makeReadOnly(True)
            If SubjectFiles1to1.CheckFile("fileDeathCertificate", WarehouseShell.SubNum) Then
                btnDeathCert.Enabled = True
            Else
                btnDeathCert.Enabled = False
            End If
            btnDeathCertDelete.Enabled = False
            If SubjectFiles1to1.CheckFile("fileReferralDocument", WarehouseShell.SubNum) Then
                btnReferralDoc.Enabled = True
            Else
                btnReferralDoc.Enabled = False
            End If
            btnReferralDocDelete.Enabled = False
            If SubjectFiles1to1.CheckFile("fileReleaseOfMedRecords", WarehouseShell.SubNum) Then
                btnMedicalRecordsRelease.Enabled = True
            Else
                btnMedicalRecordsRelease.Enabled = False
            End If
            comboPlaceOfDeath.Enabled = False
            btnSuggestNewPoD.Enabled = False
            comboReferringInst.Enabled = False
            btnSuggestNewRefInst.Enabled = False
            txtRefPhys.makeReadOnly(True)
            ExternalConsent.Enabled = False
            txtComments.makeReadOnly(True)
            chkAutIssues.Enabled = False
            txtAutIssuesNote.makeReadOnly(True)
            chkSpecTissProc.Enabled = False
            txtSpecTissProc.makeReadOnly(True)
        End If
    End Sub
    Private Sub comboConsentorRelation_LostFocus(sender As Object, e As EventArgs) Handles comboConsentorRelation.LostFocus
        If comboConsentorRelation.SelectedValue = 19 Then
            txtRelationSpecify.makeReadOnly(False)
            txtRelationSpecify.Focus()
        Else
            txtRelationSpecify.Clear()
            txtRelationSpecify.makeReadOnly(True)
        End If
    End Sub
    Private Sub calcPMI()
        'Calculates the minutes from when the subject died until their brain is on ice. Must account for blank input fields.
        If txtDoD.Text <> "  /  /" And txtToD.Text <> "  :" And txtDateOnIce.Text <> "  /  /" And txtTimeOnIce.Text <> "  :" Then 'Checks masked input boxes for blanks (no user inputs)

            Dim deathDate As Date = CType(txtDoD.Text, Date) 'Date of death date only string
            Dim deathTime As Date = CType(txtToD.Text, Date) 'Time of death time only string
            Dim death As DateTime = New DateTime(deathDate.Year, deathDate.Month, deathDate.Day, deathTime.Hour, deathTime.Minute, deathTime.Second) 'Concat date and time

            Dim iceDate As Date = CType(txtDateOnIce.Text, Date) 'Date brain on ice date only string
            Dim iceTime As Date = CType(txtTimeOnIce.Text, Date) 'Time brain on ice time only string
            Dim ice As DateTime = New DateTime(iceDate.Year, iceDate.Month, iceDate.Day, iceTime.Hour, iceTime.Minute, iceTime.Second) 'Concat date and time

            Dim span As TimeSpan = (ice - death)

            intPMI.Text = CType(span.TotalMinutes, Integer).ToString

        End If
    End Sub
    Private Sub comboSpinal_LostFocus(sender As Object, e As EventArgs) Handles comboSpinal.LostFocus
        If comboSpinal.SelectedValue = 1 Then
            txtSpinal.makeReadOnly(False)
            txtSpinal.Focus()
        Else
            txtSpinal.makeReadOnly(True)
            txtSpinal.Clear()
        End If
    End Sub
    Private Sub chkAutIssues_CheckedChanged(sender As Object, e As EventArgs) Handles chkAutIssues.CheckedChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
            If chkAutIssues.Checked Then
                txtAutIssuesNote.makeReadOnly(False)
            Else
                txtAutIssuesNote.makeReadOnly(True)
                txtAutIssuesNote.Clear()
            End If
        End If
    End Sub
    Private Sub txtAutIssuesNote_LostFocus(sender As Object, e As EventArgs) Handles txtAutIssuesNote.LostFocus
        If txtAutIssuesNote.Text = "" And chkAutIssues.Checked Then
            chkAutIssues.Focus()
            tooltip1.Show("If this box is checked, the comment field below must be filled in.", chkAutIssues, 0, 20, 5000)
        End If
    End Sub
    Private Sub chkSpecTissProc_CheckedChanged(sender As Object, e As EventArgs) Handles chkSpecTissProc.CheckedChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
            If chkSpecTissProc.Checked Then
                txtSpecTissProc.makeReadOnly(False)
            Else
                txtSpecTissProc.makeReadOnly(True)
                txtSpecTissProc.Clear()
            End If
        End If
    End Sub
    Private Sub txtSpecTissProc_LostFocus(sender As Object, e As EventArgs) Handles txtSpecTissProc.LostFocus
        If txtSpecTissProc.Text = "" And chkSpecTissProc.Checked Then
            chkSpecTissProc.Focus()
            tooltip1.Show("If this box is checked, the comment field below must be filled in.", chkSpecTissProc, 0, 20, 5000)
        End If
    End Sub

    'Subs to validate input fields during data input
    Private Sub txtDoD_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtDoD.Leave
        If txtDoD.Text <> "  /  /" Then
            calcPMI()
        Else
            intPMI.Text = ""
        End If
    End Sub
    Private Sub txtToD_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtToD.Leave
        If txtToD.Text <> "  :" Then
            calcPMI()
        Else
            intPMI.Text = ""
        End If
    End Sub
    Private Sub txtDateOnIce_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles txtDateOnIce.Leave
        If txtDateOnIce.Text <> "  /  /" Then
            calcPMI()
        Else
            intPMI.Text = ""
        End If
    End Sub
    Private Sub txtTimeOnIce_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles txtTimeOnIce.Leave
        If txtTimeOnIce.Text <> "  :" Then
            calcPMI()
        Else
            intPMI.Text = ""
        End If
    End Sub

    'Define button click events
    Private Sub btnAutopsyFaceSheet_Click(sender As Object, e As EventArgs) Handles btnAutopsyFaceSheetBottom.Click, btnAutopsyFaceSheetTop.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_AutopsyFaceSheet", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                enableInputFields(True)
                btnAutopsyFaceSheetBottom.Text = "Save changes"
                btnAutopsyFaceSheetTop.Text = btnAutopsyFaceSheetBottom.Text
            Else
                MsgBox("You do not have permission to edit this form.", MsgBoxStyle.OkOnly, "Warning")
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If User.PermissionCheck("WA_AutopsyFaceSheet", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
                enableInputFields(True)
                btnAutopsyFaceSheetBottom.Text = "Save new record"
                btnAutopsyFaceSheetTop.Text = btnAutopsyFaceSheetBottom.Text
                lblNoRecord.Visible = False
            Else
                MsgBox("You do not have permission to create this form.", MsgBoxStyle.OkOnly, "Warning")
            End If
        Else
            If preSaveValidation() Then
                Dim sqlCommand As New SqlCommand
                sqlCommand.Connection = WarehouseShell.conn
                Dim parameters = "@SubNum = " & WarehouseShell.SubNum &
                    ", @BB = " & txtBBNum.getSQLValue() &
                    ", @ExternalID = " & txtExternalID.getSQLValue() &
                    ", @DonationCoordinatorValue = " & cmbDonationCoordinator.getSQLValue() &
                    ", @DateOfDeath = " & txtDoD.getSQLValue() &
                    ", @TimeOfDeath = " & txtToD.getSQLValue() &
                    ", @DateOnIce = " & txtDateOnIce.getSQLValue() &
                    ", @TimeOnIce = " & txtTimeOnIce.getSQLValue() &
                    ", @PMI = " & intPMI.getSQLValue() &
                    ", @PrimCauseDeath = " & txtPrimCausDeath.getSQLValue() &
                    ", @SecCauseDeath = " & txtSecCauseDeath.getSQLValue() &
                    ", @TempDX = " & txtTempDX.getSQLValue() &
                    ", @MannerOfDeath = " & MannerOfDeath.getSQLValue() &
                    ", @MannerOfDeathSpec = " & MannerOfDeathSpec.getSQLValue() &
                    ", @ADCriteria = " & ADCriteria.getSQLValue() &
                    ", @CovidCriteria = " & CovidCriteria.getSQLValue() &
                    ", @BrainWtTot = " & txtTotalBrainWeight.getSQLValue() &
                    ", @BrainWtCerBS = " & txtCerBSWeight.getSQLValue() &
                    ", @BrainWtRt = " & txtRightBrainWeight.getSQLValue &
                    ", @BrainWtLt = " & txtLeftBrainWeight.getSQLValue() &
                    ", @CSFVials = " & txtCSF.getSQLValue() &
                    ", @SpinalCordTakenValue = " & comboSpinal.getSQLValue() &
                    ", @SpinalCordWeight = " & txtSpinal.getSQLValue &
                    ", @TypeBloodTakenValue = " & comboBloodType.getSQLValue() &
                    ", @PlasmaVials = " & txtPlasma.getSQLValue() &
                    ", @SerumVials = " & txtSerum.getSQLValue() &
                    ", @BloodToxVials = " & txtBloodTox.getSQLValue() &
                    ", @DNAVials = " & txtDNA.getSQLValue() &
                    ", @RNAVials = " & txtRNA.getSQLValue() &
                    ", @MicrobiomeVials = " & MicrobiomeVials.getSQLValue() &
                    ", @Consentor = " & txtConsentorName.getSQLValue() &
                    ", @ConsentTypeValue = " & comboConsentType.getSQLValue() &
                    ", @ConsentDate = " & txtConsentDate.getSQLValue() &
                    ", @ConsentTime = " & txtConsentTime.getSQLValue() &
                    ", @ConsentorRelationValue = " & comboConsentorRelation.getSQLValue() &
                    ", @ConsentorRelationNote = " & txtRelationSpecify.getSQLValue() &
                    ", @ConsentorAddress1 = " & txtConsentorAddress1.getSQLValue() &
                    ", @ConsentorAddress2 = " & txtConsentorAddress2.getSQLValue() &
                    ", @ConsentorAddress3 = " & txtConsentorAddress3.getSQLValue() &
                    ", @ConsentorCity = " & txtConsentorCity.getSQLValue() &
                    ", @ConsentorState = " & txtConsentorState.getSQLValue() &
                    ", @ConsentorZip = " & txtConsentorZip.getSQLValue() &
                    ", @ConsentorHomePhone = " & txtConsentorHomePhone.getSQLValue() &
                    ", @ConsentorMobilePhone = " & txtConsentorMobilePhone.getSQLValue() &
                    ", @ConsentorWorkPhone = " & txtConsentorWorkPhone.getSQLValue() &
                    ", @ConsentorEmail = " & txtConsentorEmail.getSQLValue() &
                    ", @Prosector1Value = " & comboProsector1.getSQLValue() &
                    ", @Prosector2Value = " & comboProsector2.getSQLValue() &
                    ", @Dissectionist = " & Dissectionist.getSQLValue() &
                    ", @AutopsyLocationValue = " & comboAutopsySite.getSQLValue() &
                    ", @TimeProsInformedOfDeath = " & txtTimeProsectorInformed.getSQLValue() &
                    ", @TimeProsArrAutLocation = " & txtTimeProsectorArrived.getSQLValue() &
                    ", @TimeBodyArrAutLocation = " & txtTimeBodyArrived.getSQLValue() &
                    ", @TimeAutopsyStarted = " & txtTimeAutopsyStarted.getSQLValue() &
                    ", @TimeAutopsyEnded = " & txtTimeAutopsyFinished.getSQLValue() &
                    ", @DateFuneralDirAlerted = " & txtDateFuneralDirAlerted.getSQLValue() &
                    ", @TimeFuneralDirAlerted = " & txtTimeFuneralDirAlerted.getSQLValue() &
                    ", @PlaceOfDeathValue = " & comboPlaceOfDeath.getSQLValue() &
                    ", @ReferringInstitutionValue = " & comboReferringInst.getSQLValue() &
                    ", @ReferringPhysician = " & txtRefPhys.getSQLValue() &
                    ", @ExternalConsentSource = " & ExternalConsent.getSQLValue() &
                    ", @Notes = " & txtComments.getSQLValue() &
                    ", @AutopsyIssues = " & chkAutIssues.getSQLValue() &
                    ", @AutopsyIssuesNote = " & txtAutIssuesNote.getSQLValue() &
                    ", @SpecTissProc = " & chkSpecTissProc.getSQLValue() &
                    ", @SpecTissProcNote = " & txtSpecTissProc.getSQLValue() &
                    ", @LastModBy = '" & WarehouseShell.userName & "';"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    sqlCommand.CommandText = "EXEC dbo.modAutopsyFaceSheetRecord @Action = 1, " & parameters
                    sqlCommand.ExecuteScalar()
                    WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    If IsDate(DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).dtDoB.Text) Then
                        Dim myAge As Integer
                        If IsDate(txtDoD.Text) Then
                            myAge = WarehouseShell.calcAge(CType(DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).dtDoB.Text, Date), CType(txtDoD.Text, Date))
                        Else
                            myAge = WarehouseShell.calcAge(CType(DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).dtDoB.Text, Date), Now())
                        End If
                        DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).manualUpdateHeaderData(WarehouseShell.SubNum,,,,,,, myAge.ToString)
                    End If
                    MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    WarehouseShell.LoadWorkingAreaForm(WarehouseShell.formType.WA_AutopsyFaceSheet)
                Else
                    sqlCommand.CommandText = "EXEC dbo.modAutopsyFaceSheetRecord @Action = 2, " & parameters
                    sqlCommand.ExecuteScalar()
                    WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    If IsDate(DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).dtDoB.Text) Then
                        Dim myAge As Integer
                        If IsDate(txtDoD.Text) Then
                            myAge = WarehouseShell.calcAge(CType(DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).dtDoB.Text, Date), CType(txtDoD.Text, Date))
                        Else
                            myAge = WarehouseShell.calcAge(CType(DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).dtDoB.Text, Date), Now())
                        End If
                        DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).manualUpdateHeaderData(WarehouseShell.SubNum,,,,,,, myAge.ToString)
                    End If
                    MessageBox.Show("Record successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    WarehouseShell.LoadWorkingAreaForm(WarehouseShell.formType.WA_AutopsyFaceSheet)
                End If
            End If
        End If
    End Sub
    Private Sub ADCritSelect_Click(sender As Object, e As EventArgs) Handles ADCritSelect.Click
        Dim pu As New PU_Alz_Acceptance(ADCriteria.SelectedValue)
        pu.ShowDialog()
        If pu.formResult <> "Cancel" Then
            ADCriteria.SelectedValue = pu.formResult
        End If
        pu.Dispose()
    End Sub
    Private Sub CovidCritSelect_Click(sender As Object, e As EventArgs) Handles CovidCritSelect.Click
        Dim cc As New PU_Covid_Acceptance
        cc.ShowDialog()
        If cc.formResult.Text <> "Cancel" Then
            CovidCriteria.Text = cc.formResult.Text
        End If
        cc.Dispose()
    End Sub
    Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDFTop.Click, btnPDFBottom.Click
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
            tooltip1.Show("This record must be saved before PDF Export can be created.", sender, 0, 20, 5000)
        Else
            Try
                'Define which template to use
                Dim pdfTemplate As String = "Q:\Warehouse Files\PDF Export Templates\Autopsy Face Sheet.pdf"
                'Define the output file name
                Dim outputFileName As String = "BB " & formTables.Tables("viewAutopsyFaceSheet").Rows(0).Item("BB").ToString & " Autopsy Face Sheet.pdf"
                'combine the output file name with the user's temp file path location so we can create and fill the PDF
                Dim filledPDF As String = IO.Path.GetTempPath() & outputFileName

                'Use the PDF API to start the the new file
                Dim pdfReader As PdfReader = New PdfReader(pdfTemplate)
                Dim pdfStamper As New PdfStamper(pdfReader, New FileStream(filledPDF, FileMode.Create))
                Dim pdfFormFields As AcroFields = pdfStamper.AcroFields

                'Fill the fields with values

                formTables.Tables.Add(Database.ReturnTable("Subject", "FirstName, LastName, SSN, convert(varchar, DoB, 101) as DoB, SexLabel as Sex, RaceLabel as Race", "SubNum = " & WarehouseShell.SubNum))
                pdfFormFields.SetField("BB", txtBBNum.Text)
                pdfFormFields.SetField("Sex", formTables.Tables("Subject").Rows(0).Item("Sex").ToString)
                pdfFormFields.SetField("Race", formTables.Tables("Subject").Rows(0).Item("Race").ToString)
                pdfFormFields.SetField("OthID", txtExternalID.Text)
                pdfFormFields.SetField("DonationCoordinator", cmbDonationCoordinator.Text)
                pdfFormFields.SetField("TimeOfDeath", txtToD.Text)
                pdfFormFields.SetField("TimeOnIce", txtTimeOnIce.Text)
                pdfFormFields.SetField("PMI", intPMI.Text)
                pdfFormFields.SetField("PrimCauseDeath", txtPrimCausDeath.Text)
                pdfFormFields.SetField("SecCauseDeath", txtSecCauseDeath.Text)
                pdfFormFields.SetField("TempDiagnosis", txtTempDX.Text)
                pdfFormFields.SetField("ConsentTime", txtConsentTime.Text)
                pdfFormFields.SetField("ConsentorRelation", comboConsentorRelation.Text)
                pdfFormFields.SetField("ConsentorRelationSpecify", txtRelationSpecify.Text)
                pdfFormFields.SetField("PlaceOfDeath", comboPlaceOfDeath.Text)
                pdfFormFields.SetField("AutopsyLocation", comboAutopsySite.Text)
                pdfFormFields.SetField("ConsentorRelation", comboConsentorRelation.Text)
                pdfFormFields.SetField("ReferringPhysician", txtRefPhys.Text)
                pdfFormFields.SetField("ReferringInstitution", comboReferringInst.Text)
                pdfFormFields.SetField("TotalBrainWeight", txtTotalBrainWeight.Text)
                pdfFormFields.SetField("RightBrainWeight", txtRightBrainWeight.Text)
                pdfFormFields.SetField("LeftBrainWeight", txtLeftBrainWeight.Text)
                pdfFormFields.SetField("CerBsWeight", txtCerBSWeight.Text)
                pdfFormFields.SetField("TypeBloodCollected", comboBloodType.Text)
                pdfFormFields.SetField("CSF", txtCSF.Text)
                pdfFormFields.SetField("Plasma", txtPlasma.Text)
                pdfFormFields.SetField("Serum", txtSerum.Text)
                pdfFormFields.SetField("BloodTox", txtBloodTox.Text)
                pdfFormFields.SetField("DNA", txtDNA.Text)
                pdfFormFields.SetField("RNA", txtRNA.Text)
                pdfFormFields.SetField("SpinalCordCollected", comboSpinal.Text)
                pdfFormFields.SetField("SpinalCordWeight", txtSpinal.Text)
                pdfFormFields.SetField("AutopsyNotes", txtComments.Text)
                pdfFormFields.SetField("AutopsyIssues", IIf(chkAutIssues.Checked = True, "1", ""))
                pdfFormFields.SetField("AutopsyIssuesNote", txtAutIssuesNote.Text)
                pdfFormFields.SetField("SpecTissueProcessing", IIf(chkSpecTissProc.Checked = True, "1", ""))
                pdfFormFields.SetField("SpecTissueProcessingNote", txtSpecTissProc.Text)
                pdfFormFields.SetField("Prosector1", comboProsector1.Text)
                pdfFormFields.SetField("Prosector2", comboProsector2.Text)
                pdfFormFields.SetField("TimeProsInformed", txtTimeProsectorInformed.Text)
                pdfFormFields.SetField("TimeProsArrived", txtTimeProsectorArrived.Text)
                pdfFormFields.SetField("TimeBodyArrived", txtTimeBodyArrived.Text)
                pdfFormFields.SetField("TimeAutopsyStarted", txtTimeAutopsyStarted.Text)
                pdfFormFields.SetField("TimeAutopsyFinished", txtTimeAutopsyFinished.Text)
                pdfFormFields.SetField("TimeFunDirAlerted", txtTimeFuneralDirAlerted.Text)
                If WarehouseShell.ShowingPHI = True Then
                    'code here to add subject table to formTables
                    pdfFormFields.SetField("LastName", formTables.Tables("Subject").Rows(0).Item("LastName").ToString)
                    pdfFormFields.SetField("FirstName", formTables.Tables("Subject").Rows(0).Item("FirstName").ToString)
                    pdfFormFields.SetField("SSN", formTables.Tables("Subject").Rows(0).Item("SSN").ToString)
                    pdfFormFields.SetField("DateOfBirth", formTables.Tables("Subject").Rows(0).Item("DoB").ToString)
                    pdfFormFields.SetField("DateOfDeath", IIf(txtDoD.Text <> "  /  /", txtDoD.Text, ""))
                    pdfFormFields.SetField("DateOnIce", IIf(txtDateOnIce.Text <> "  /  /", txtDateOnIce.Text, ""))
                    pdfFormFields.SetField("Consentor", txtConsentorName.Text)
                    pdfFormFields.SetField("ConsentDate", IIf(txtConsentDate.Text <> "  /  /", txtConsentDate.Text, ""))
                    pdfFormFields.SetField("ConsentorHomePhone", txtConsentorHomePhone.Text)
                    pdfFormFields.SetField("ConsentorMobilePhone", txtConsentorMobilePhone.Text)
                    pdfFormFields.SetField("ConsentorWorkPhone", txtConsentorWorkPhone.Text)
                    pdfFormFields.SetField("ConsentorEmail", txtConsentorEmail.Text)
                    pdfFormFields.SetField("ConsentorAddress1", txtConsentorAddress1.Text)
                    pdfFormFields.SetField("ConsentorAddress2", txtConsentorAddress2.Text)
                    pdfFormFields.SetField("ConsentorAddress3", txtConsentorAddress3.Text)
                    pdfFormFields.SetField("ConsentorCityStateZip", txtConsentorCity.Text & ", " & txtConsentorState.Text & " " & txtConsentorZip.Text)
                    pdfFormFields.SetField("DateFunDirAlerted", IIf(txtDateFuneralDirAlerted.Text <> "  /  /", txtDateFuneralDirAlerted.Text, ""))
                    'code here to dispose of the added subject table from the formTables
                    formTables.Tables.Remove("Subject")
                Else
                    pdfFormFields.SetField("LastName", "PHI Hidden")
                    pdfFormFields.SetField("dmLastName", "PHI Hidden")
                    pdfFormFields.SetField("miscLastName", "PHI Hidden")
                    pdfFormFields.SetField("FirstName", "PHI Hidden")
                    pdfFormFields.SetField("dmFirstName", "PHI Hidden")
                    pdfFormFields.SetField("miscFirstName", "PHI Hidden")
                    pdfFormFields.SetField("SSN", "PHI Hidden")
                    pdfFormFields.SetField("dmSSN", "PHI Hidden")
                    pdfFormFields.SetField("miscSSN", "PHI Hidden")
                    pdfFormFields.SetField("DateOfBirth", "PHI Hidden")
                    pdfFormFields.SetField("Sex", "PHI Hidden")
                    pdfFormFields.SetField("Race", "PHI Hidden")
                    pdfFormFields.SetField("DateOfDeath", "PHI Hidden")
                    pdfFormFields.SetField("DateOfAutopsy", "PHI Hidden")
                    pdfFormFields.SetField("DateOnIce", "PHI Hidden")
                    pdfFormFields.SetField("Consentor", "PHI Hidden")
                    pdfFormFields.SetField("ConsentorHomePhone", "PHI Hidden")
                    pdfFormFields.SetField("ConsentorMobilePhone", "PHI Hidden")
                    pdfFormFields.SetField("ConsentorWorkPhone", "PHI Hidden")
                    pdfFormFields.SetField("ConsentorEmail", "PHI Hidden")
                    pdfFormFields.SetField("ConsentorAddress1", "PHI Hidden")
                    pdfFormFields.SetField("ConsentorAddress2", "PHI Hidden")
                    pdfFormFields.SetField("ConsentorAddress3", "PHI Hidden")
                    pdfFormFields.SetField("ConsentorCityStateZip", "PHI Hidden")
                    pdfFormFields.SetField("ConsentDate", "PHI Hidden")
                    pdfFormFields.SetField("DateFunDirAlerted", "PHI Hidden")
                    pdfFormFields.SetField("npSumName", "PHI Hidden")
                    pdfFormFields.SetField("npSumAddress1", "PHI Hidden")
                    pdfFormFields.SetField("npSumAddress2", "PHI Hidden")
                    pdfFormFields.SetField("npSumAddress3", "PHI Hidden")
                    pdfFormFields.SetField("npSumCity", "PHI Hidden")
                    pdfFormFields.SetField("npSumState", "PHI Hidden")
                    pdfFormFields.SetField("npSumZip", "PHI Hidden")
                    pdfFormFields.SetField("npSumEmail", "PHI Hidden")
                    pdfFormFields.SetField("npSumPhone", "PHI Hidden")
                    pdfFormFields.SetField("npSumFax", "PHI Hidden")
                    pdfFormFields.SetField("npFullName", "PHI Hidden")
                    pdfFormFields.SetField("npFullAddress1", "PHI Hidden")
                    pdfFormFields.SetField("npFullAddress2", "PHI Hidden")
                    pdfFormFields.SetField("npFullAddress3", "PHI Hidden")
                    pdfFormFields.SetField("npFullCity", "PHI Hidden")
                    pdfFormFields.SetField("npFullState", "PHI Hidden")
                    pdfFormFields.SetField("npFullZip", "PHI Hidden")
                    pdfFormFields.SetField("npFullEmail", "PHI Hidden")
                    pdfFormFields.SetField("npFullPhone", "PHI Hidden")
                    pdfFormFields.SetField("npFullFax", "PHI Hidden")
                End If
                If Database.ExistingRecordCheck("AutopsyDissectionMap", "SubNum = " & WarehouseShell.SubNum) Then
                    formTables.Tables.Add(Database.ReturnTable("viewAutopsyDissectionMap", , "SubNum = " & WarehouseShell.SubNum))
                    pdfFormFields.SetField("Hemisphere", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("HemisphereLabel").ToString)
                    pdfFormFields.SetField("chkMuscle", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("MuscleTaken").ToString)
                    pdfFormFields.SetField("chkHair", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("HairTaken").ToString)
                    pdfFormFields.SetField("chkSkin", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("SkinTaken").ToString)
                    pdfFormFields.SetField("chkDura", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("DuraTaken").ToString)
                    pdfFormFields.SetField("chkLrgBloodVsl", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("LrgBldVslTaken").ToString)
                    pdfFormFields.SetField("chkLepto", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("LeptoTaken").ToString)
                    pdfFormFields.SetField("chkChoroid", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("ChoroidTaken").ToString)
                    pdfFormFields.SetField("chkRtOlf", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("RtOLFTaken").ToString)
                    pdfFormFields.SetField("chkLtOlf", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("LtOLFTaken").ToString)
                    pdfFormFields.SetField("chkCere1", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Cere1Taken").ToString)
                    pdfFormFields.SetField("chkCere2", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Cere2Taken").ToString)
                    pdfFormFields.SetField("chkCere3", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Cere3Taken").ToString)
                    pdfFormFields.SetField("chkCere4", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Cere4Taken").ToString)
                    pdfFormFields.SetField("chkPituit", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("PituitTaken").ToString)
                    pdfFormFields.SetField("chkBSMid", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("BSMidTaken").ToString)
                    pdfFormFields.SetField("chkBSPons", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("BSPonsTaken").ToString)
                    pdfFormFields.SetField("chkBSMed", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("BSMedTaken").ToString)
                    pdfFormFields.SetField("chkOth1", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Oth1Taken").ToString)
                    pdfFormFields.SetField("chkOth2", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Oth2Taken").ToString)
                    pdfFormFields.SetField("chkOth3", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Oth3Taken").ToString)
                    pdfFormFields.SetField("tagMuscle", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("MuscleTagNum").ToString)
                    pdfFormFields.SetField("tagHair", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("HairTagNum").ToString)
                    pdfFormFields.SetField("tagSkin", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("SkinTagNum").ToString)
                    pdfFormFields.SetField("tagDura", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("DuraTagNum").ToString)
                    pdfFormFields.SetField("tagLrgBloodVsl", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("LrgBldVslTagNum").ToString)
                    pdfFormFields.SetField("tagLepto", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("LeptoTagNum").ToString)
                    pdfFormFields.SetField("tagChoroid", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("ChoroidTagNum").ToString)
                    pdfFormFields.SetField("tagRtOlf", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("RtOLFTagNum").ToString)
                    pdfFormFields.SetField("tagLtOlf", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("LtOLFTagNum").ToString)
                    pdfFormFields.SetField("tagCere1", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Cere1TagNum").ToString)
                    pdfFormFields.SetField("tagCere2", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Cere2TagNum").ToString)
                    pdfFormFields.SetField("tagCere3", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Cere3TagNum").ToString)
                    pdfFormFields.SetField("tagCere4", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Cere4TagNum").ToString)
                    pdfFormFields.SetField("tagPituit", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("PituitTagNum").ToString)
                    pdfFormFields.SetField("tagBSMid", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("BSMidTagNum").ToString)
                    pdfFormFields.SetField("tagBSPons", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("BSPonsTagNum").ToString)
                    pdfFormFields.SetField("tagBSMed", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("BSMedTagNum").ToString)
                    pdfFormFields.SetField("tagOth1", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Oth1TagNum").ToString)
                    pdfFormFields.SetField("tagOth2", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Oth2TagNum").ToString)
                    pdfFormFields.SetField("tagOth3", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Oth3TagNum").ToString)
                    pdfFormFields.SetField("Oth1Desc", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Oth1Desc").ToString)
                    pdfFormFields.SetField("Oth2Desc", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Oth2Desc").ToString)
                    pdfFormFields.SetField("Oth3Desc", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Oth3Desc").ToString)
                    pdfFormFields.SetField("tagSlice1", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice1TagNum").ToString)
                    pdfFormFields.SetField("tagSlice2", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice2TagNum").ToString)
                    pdfFormFields.SetField("tagSlice3", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice3TagNum").ToString)
                    pdfFormFields.SetField("tagSlice4", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice4TagNum").ToString)
                    pdfFormFields.SetField("tagSlice5", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice5TagNum").ToString)
                    pdfFormFields.SetField("tagSlice6", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice6TagNum").ToString)
                    pdfFormFields.SetField("tagSlice7", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice7TagNum").ToString)
                    pdfFormFields.SetField("tagSlice8", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice8TagNum").ToString)
                    pdfFormFields.SetField("tagSlice9", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice9TagNum").ToString)
                    pdfFormFields.SetField("tagSlice10", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice10TagNum").ToString)
                    pdfFormFields.SetField("tagSlice11", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice11TagNum").ToString)
                    pdfFormFields.SetField("tagSlice12", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice12TagNum").ToString)
                    pdfFormFields.SetField("tagSlice13", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice13TagNum").ToString)
                    pdfFormFields.SetField("tagSlice14", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice14TagNum").ToString)
                    pdfFormFields.SetField("tagSlice15", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice15TagNum").ToString)
                    pdfFormFields.SetField("tagSlice16", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice16TagNum").ToString)
                    pdfFormFields.SetField("tagSlice17", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice17TagNum").ToString)
                    pdfFormFields.SetField("tagSlice18", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice18TagNum").ToString)
                    pdfFormFields.SetField("tagSlice19", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice19TagNum").ToString)
                    pdfFormFields.SetField("tagSlice20", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice20TagNum").ToString)
                    pdfFormFields.SetField("mapSlice1", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice1MapLevels").ToString)
                    pdfFormFields.SetField("mapSlice2", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice2MapLevels").ToString)
                    pdfFormFields.SetField("mapSlice3", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice3MapLevels").ToString)
                    pdfFormFields.SetField("mapSlice4", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice4MapLevels").ToString)
                    pdfFormFields.SetField("mapSlice5", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice5MapLevels").ToString)
                    pdfFormFields.SetField("mapSlice6", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice6MapLevels").ToString)
                    pdfFormFields.SetField("mapSlice7", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice7MapLevels").ToString)
                    pdfFormFields.SetField("mapSlice8", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice8MapLevels").ToString)
                    pdfFormFields.SetField("mapSlice9", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice9MapLevels").ToString)
                    pdfFormFields.SetField("mapSlice10", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice10MapLevels").ToString)
                    pdfFormFields.SetField("mapSlice11", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice11MapLevels").ToString)
                    pdfFormFields.SetField("mapSlice12", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice12MapLevels").ToString)
                    pdfFormFields.SetField("mapSlice13", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice13MapLevels").ToString)
                    pdfFormFields.SetField("mapSlice14", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice14MapLevels").ToString)
                    pdfFormFields.SetField("mapSlice15", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice15MapLevels").ToString)
                    pdfFormFields.SetField("mapSlice16", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice16MapLevels").ToString)
                    pdfFormFields.SetField("mapSlice17", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice17MapLevels").ToString)
                    pdfFormFields.SetField("mapSlice18", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice18MapLevels").ToString)
                    pdfFormFields.SetField("mapSlice19", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice19MapLevels").ToString)
                    pdfFormFields.SetField("mapSlice20", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("Slice20MapLevels").ToString)
                    pdfFormFields.SetField("GrossObservations", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("GrossObservations").ToString)
                    pdfFormFields.SetField("chkHepFollowed", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("HepFollowed").ToString)
                    pdfFormFields.SetField("chkToxFollowed", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("ToxFollowed").ToString)
                    pdfFormFields.SetField("chkPaxFollowed", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("PaxFollowed").ToString)
                    pdfFormFields.SetField("chkRightFixed", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("RightFixed").ToString)
                    pdfFormFields.SetField("chkLeftFixed", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("LeftFixed").ToString)
                    pdfFormFields.SetField("chkRightFrozen", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("RightFrozen").ToString)
                    pdfFormFields.SetField("chkLeftFrozen", formTables.Tables("viewAutopsyDissectionMap").Rows(0).Item("LeftFrozen").ToString)
                    formTables.Tables.Remove("viewAutopsyDissectionMap")
                End If

                'Flatten the form to dissuade manual editing of outputs
                pdfStamper.FormFlattening = True

                'Close the stamper (to finalize the Filled PDF)
                pdfStamper.Close()
                pdfReader.Dispose()

                'Launch the filled PDF for the user
                Dim P As New System.Diagnostics.Process
                Dim s As New System.Diagnostics.ProcessStartInfo(filledPDF)
                s.UseShellExecute = True
                s.WindowStyle = ProcessWindowStyle.Normal
                P.StartInfo = s
                P.Start()
            Catch ex As Exception
                ExceptionHandler.CatchWindowsException(ex)
            End Try
        End If
    End Sub
    Private Sub btnConsent_Click(sender As Object, e As EventArgs) Handles btnConsent.Click
        If SubjectFiles1to1.CheckFile("fileAutopsyConsent", WarehouseShell.SubNum) Then
            SubjectFiles1to1.OpenFile("fileAutopsyConsent", WarehouseShell.SubNum, "SubNum " & WarehouseShell.SubNum & " Autopsy Consent")
        Else
            If Database.ExistingRecordCheck("AutopsyFaceSheet", "SubNum = " & WarehouseShell.SubNum) Then
                SubjectFiles1to1.SaveFile("fileAutopsyConsent", WarehouseShell.SubNum)
            Else
                MsgBox("Since this is a new Autopsy Face Sheet, it must be saved before attempting to upload the consent.")
            End If
        End If
        loadFileData()
    End Sub
    Private Sub btnConsentDelete_Click(sender As Object, e As EventArgs) Handles btnConsentDelete.Click
        If SubjectFiles1to1.CheckDelete() Then
            SubjectFiles1to1.DeleteFile("fileAutopsyConsent", WarehouseShell.SubNum)
        End If
        loadFileData()
    End Sub
    Private Sub btnDeathCert_Click(sender As Object, e As EventArgs) Handles btnDeathCert.Click
        If SubjectFiles1to1.CheckFile("fileDeathCertificate", WarehouseShell.SubNum) Then
            SubjectFiles1to1.OpenFile("fileDeathCertificate", WarehouseShell.SubNum, "SubNum " & WarehouseShell.SubNum & " Death Certificate")
        Else
            SubjectFiles1to1.SaveFile("fileDeathCertificate", WarehouseShell.SubNum)
        End If
        loadFileData()
    End Sub
    Private Sub btnDeathCertDelete_Click(sender As Object, e As EventArgs) Handles btnDeathCertDelete.Click
        If SubjectFiles1to1.CheckDelete() Then
            SubjectFiles1to1.DeleteFile("fileDeathCertificate", WarehouseShell.SubNum)
        End If
        loadFileData()
    End Sub
    Private Sub btnReferralDoc_Click(sender As Object, e As EventArgs) Handles btnReferralDoc.Click
        If SubjectFiles1to1.CheckFile("fileReferralDocument", WarehouseShell.SubNum) Then
            SubjectFiles1to1.OpenFile("fileReferralDocument", WarehouseShell.SubNum, "SubNum " & WarehouseShell.SubNum & " Referral Document")
        Else
            SubjectFiles1to1.SaveFile("fileReferralDocument", WarehouseShell.SubNum)
        End If
        loadFileData()
    End Sub
    Private Sub btnReferralDocDelete_Click(sender As Object, e As EventArgs) Handles btnReferralDocDelete.Click
        If SubjectFiles1to1.CheckDelete() Then
            SubjectFiles1to1.DeleteFile("fileReferralDocument", WarehouseShell.SubNum)
        End If
        loadFileData()
    End Sub
    Private Sub btnMedicalRecordsRelease_Click(sender As Object, e As EventArgs) Handles btnMedicalRecordsRelease.Click
        If SubjectFiles1toMany.CheckFile("fileReleaseOfMedRecords", WarehouseShell.SubNum) Then
            Dim popup As New PU_ReleaseOfMedicalRecords
            popup.ShowDialog()
            popup.Dispose()
        Else
            SubjectFiles1toMany.SaveFile("fileReleaseOfMedRecords", WarehouseShell.SubNum)
        End If
        loadFileData()
    End Sub
    Private Sub btnScannedForm_Click(sender As Object, e As EventArgs) Handles btnScannedForm.Click
        If SubjectFiles1to1.CheckFile("filePreEnrollment", WarehouseShell.SubNum) Then
            SubjectFiles1to1.OpenFile("filePreEnrollment", WarehouseShell.SubNum, "SubNum- " & WarehouseShell.SubNum & " PreEnrollment")
        Else
            SubjectFiles1to1.SaveFile("filePreEnrollment", WarehouseShell.SubNum)
            loadFileData()
        End If
    End Sub
    Private Sub btnSuggestNewAutSite_Click(sender As Object, e As EventArgs) Handles btnSuggestNewAutSite.Click
        WarehouseShell.SuggestNewInstitution(WarehouseShell.SubNum, "Autopsy Face Sheet", "Autopsy Site")
    End Sub
    Private Sub btnSuggestNewPoD_Click(sender As Object, e As EventArgs) Handles btnSuggestNewPoD.Click
        WarehouseShell.SuggestNewInstitution(WarehouseShell.SubNum, "Autopsy Face Sheet", "Place of Death")
    End Sub
    Private Sub btnSuggestNewRefInst_Click(sender As Object, e As EventArgs) Handles btnSuggestNewRefInst.Click
        WarehouseShell.SuggestNewInstitution(WarehouseShell.SubNum, "Autopsy Face Sheet", "Referring Institution")
    End Sub

    Private Function preSaveValidation() As Boolean
        Dim result As Boolean = True
        Dim errMsg As String = "The following errors exist and need to be corrected before record can be saved:" & vbNewLine & vbNewLine

        'Check that Date/Time of Death and Date/Time on Ice and Date/Time of Consent make sense
        If txtDoD.Text <> "  /  /" Then
            'Check for available time values and perform comparisons
            If txtToD.Text <> "  :" Then
                'Compare death date/time values to OnIce date/time values
                If txtDateOnIce.Text <> "  /  /" Then
                    Dim DateOfDeath As Date
                    Dim DateOnIce As Date
                    If txtTimeOnIce.Text <> "  :" Then
                        DateOfDeath = "#" & txtDoD.Text & " " & txtToD.Text & ":00#"
                        DateOnIce = "#" & txtDateOnIce.Text & " " & txtTimeOnIce.Text & ":00#"
                    Else
                        DateOfDeath = "#" & txtDoD.Text & "#"
                        DateOnIce = "#" & txtDateOnIce.Text & "#"
                    End If
                    If DateOnIce < DateOfDeath Then
                        result = False
                        errMsg += "- Date/Time on Ice is before Date/Time of Death." & vbNewLine
                    End If
                End If
                'Compare death date/time values to consent date/time values
                If txtConsentDate.Text <> "  /  /" Then
                    Dim DateOfDeath As Date
                    Dim DateOfConsent As Date
                    If txtConsentTime.Text <> "  :" Then
                        DateOfDeath = "#" & txtDoD.Text & " " & txtToD.Text & ":00#"
                        DateOfConsent = "#" & txtConsentDate.Text & " " & txtConsentTime.Text & ":00#"
                    Else
                        DateOfDeath = "#" & txtDoD.Text & "#"
                        DateOfConsent = "#" & txtConsentDate.Text & "#"
                    End If
                    If DateOfConsent < DateOfDeath Then
                        Dim check As New MsgBoxResult
                        check = MsgBox("The consent date/time is before the death date/time. Continue?" & vbNewLine & "(clicking yes asserts that you have explained why in the Misc. Administrative Info Comments field)", MsgBoxStyle.YesNo, "Warning!")
                        If check = MsgBoxResult.No Then
                            result = False
                            errMsg += "- The consent date/time is before the death date/time." & vbNewLine
                            Return result
                            Exit Function
                        Else
                            If txtComments.Text = "" Then
                                MsgBox("You MUST explain the circumstances that led to consent being obtained before date of death before this record can be saved.")
                                txtComments.Focus()
                                Return False
                                Exit Function
                            End If
                        End If
                    End If
                End If
            Else
                'Ignore time values and compare date values
                If txtDateOnIce.Text <> "  /  /" Then
                    Dim DateOfDeath As Date = "#" & txtDoD.Text & "#"
                    Dim DateOnIce As Date = "#" & txtDateOnIce.Text & "#"
                    If DateOnIce < DateOfDeath Then
                        result = False
                        errMsg += "- Date on Ice is before Date of Death." & vbNewLine
                    End If
                End If
                If txtConsentDate.Text <> "  /  /" Then
                    Dim DateOfDeath As Date = "#" & txtDoD.Text & "#"
                    Dim DateOfConsent As Date = "#" & txtConsentDate.Text & "#"
                    Dim check As New MsgBoxResult
                    check = MsgBox("The consent date/time is before the death date/time. Continue?" & vbNewLine & "(clicking yes asserts that you have explained why in the Misc. Administrative Info Comments field)", MsgBoxStyle.YesNo, "Warning!")
                    If check = MsgBoxResult.No Then
                        result = False
                        errMsg += "- The consent date/time is before the death date/time." & vbNewLine
                        Return result
                        Exit Function
                    End If
                End If
            End If
        End If

        If MannerOfDeath.SelectedValue = 6 And MannerOfDeathSpec.Text = "" Then
            result = False
            errMsg += "- Manner of Death is ""Other- specify"" but the Specify field is blank." & vbNewLine
        ElseIf MannerOfDeath.SelectedValue <> 6 And MannerOfDeathSpec.Text <> "" Then
            result = False
            errMsg += "- Manner of Death not ""Other- specify"" but the Specify field has info entered." & vbNewLine
        End If

        If ADCriteria.SelectedValue = "-1" Then
            result = False
            errMsg += "- You must select an AD Acceptance Criteria (click the ""Select AD Criteria"" button)." & vbNewLine
        End If
        'Make sure left/right brain weights make sense
        If txtRightBrainWeight.Text <> "" And txtLeftBrainWeight.Text <> "" Then
            Dim weightDiffPercent As Decimal = CType(txtRightBrainWeight.Text, Decimal) / CType(txtLeftBrainWeight.Text, Decimal)
            If weightDiffPercent > 1.1 Or weightDiffPercent < 0.9 Then
                Dim check As New MsgBoxResult
                check = MsgBox("The difference between the right and left hemisphere weights is greater than 10%. Continue?", MsgBoxStyle.YesNo, "Warning!")
                If check = MsgBoxResult.No Then
                    result = False
                    errMsg += "- The difference between right and left hemisphere weights is greater than 10%." & vbNewLine
                    Return result
                    Exit Function
                End If
            End If
        End If

        'Make sure total brain weight and left/right brain weights make sense
        If txtTotalBrainWeight.Text <> "" And txtRightBrainWeight.Text <> "" And txtLeftBrainWeight.Text <> "" And txtCerBSWeight.Text <> "" Then
            Dim weightDiffPercent As Decimal = CType(txtTotalBrainWeight.Text, Decimal) / (CType(txtRightBrainWeight.Text, Decimal) + CType(txtLeftBrainWeight.Text, Decimal) + CType(txtCerBSWeight.Text, Decimal))
            If weightDiffPercent > 1.1 Or weightDiffPercent < 0.9 Then
                Dim check As New MsgBoxResult
                check = MsgBox("The difference between the total brain weight and the sum of its parts (R brain weight, L brain weight, Cer + BS weight) is greater than 10%. Continue?", MsgBoxStyle.YesNo, "Warning!")
                If MsgBoxResult.No Then
                    result = False
                    errMsg += "- The difference between the total brain weight and the sum of its parts (R brain weight + L brain weight + Cer + BS weight) is greater than 10%." & vbNewLine
                    Return result
                    Exit Function
                End If
            End If
        End If

        If result = False Then
            MsgBox(errMsg, , "Errors Exist!")
        End If

        Return result
    End Function

    'Imported IFormMethods
    Public Sub ShowPHI(showPHI As Boolean) Implements IFormMethods.ShowPHI
        If showPHI = False Then
            txtDoD.PasswordChar = "*"
            txtDateOnIce.PasswordChar = "*"
            txtConsentorName.PasswordChar = "*"
            txtConsentDate.PasswordChar = "*"
            txtConsentorHomePhone.PasswordChar = "*"
            txtConsentorAddress1.PasswordChar = "*"
            txtConsentorAddress2.PasswordChar = "*"
            txtConsentorCity.PasswordChar = "*"
            txtDateFuneralDirAlerted.PasswordChar = "*"
        Else
            txtDoD.PasswordChar = ""
            txtDateOnIce.PasswordChar = ""
            txtConsentorName.PasswordChar = ""
            txtConsentDate.PasswordChar = ""
            txtConsentorHomePhone.PasswordChar = ""
            txtConsentorAddress1.PasswordChar = ""
            txtConsentorAddress2.PasswordChar = ""
            txtConsentorCity.PasswordChar = ""
            txtDateFuneralDirAlerted.PasswordChar = ""
        End If
    End Sub
    Public Sub Parent1(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Public Sub Show1() Implements IFormMethods.Show
        Show()
    End Sub
    Public Sub TopLevel1(val As Boolean) Implements IFormMethods.TopLevel
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        btnAutopsyFaceSheetBottom.PerformClick()
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class