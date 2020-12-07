Public Class WA_PreEnrollments_Detail
    Implements IFormMethods
    Private formTables As New DataSet

    Private Sub WA_PreEnrollments_Detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_PreEnrollments_Detail")
        loadBaseForm()

        'load Pre-Enrollment specific fields
        If Database.ExistingRecordCheck("PreEnrollment", "SubNum = " & WarehouseShell.SubNum) Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            lblNoRecord.Visible = False
            loadExistingData()
            loadExistingSubjectData()
            loadExistingNoKData()
            btnPreEnrollTop.Text = "Edit this record"
            btnPreEnrollBottom.Text = btnPreEnrollTop.Text
        Else
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            lblNoRecord.Visible = True
            btnPreEnrollTop.Text = "Add new record"
            btnPreEnrollBottom.Text = btnPreEnrollTop.Text
        End If

        enableInputFields(False)

        ShowPHI(WarehouseShell.ShowingPHI)
    End Sub
    Private Sub loadBaseForm()
        'load lookup table(s)
        formTables.Tables.Add(Database.ReturnTable("refUser"))
        formTables.Tables.Add(Database.ReturnTable("lkpDonationWishes"))
        formTables.Tables.Add(Database.ReturnTable("lkpRelation"))
        formTables.Tables.Add(Database.ReturnTable("lkpPreEnrollmentSources", , , "Value"))
        formTables.Tables.Add(Database.ReturnTable("lkpPreEnrollmentPacketSentMode"))
        formTables.Tables.Add(Database.ReturnTable("lkpPreEnrollmentPrefMethContact"))
        formTables.Tables.Add(Database.ReturnTable("lkpLanguage"))
        formTables.Tables.Add(Database.ReturnTable("lkpPreEnrollmentDeclineReason"))

        'assign lookups to comboboxes
        cmbEnrolledBy.DataSource = New DataView(formTables.Tables("refUser"), "DonationCoordinator = 1", "Name", DataViewRowState.CurrentRows)
        cmbEnrolledBy.DisplayMember = "Name"
        cmbEnrolledBy.ValueMember = "RaterID"
        cmbDonationType.assignLookup(formTables, "lkpDonationWishes")
        cmbPrefMethContact.assignLookup(formTables, "lkpPreEnrollmentPrefMethContact")
        cmbSource.assignLookup(formTables, "lkpPreEnrollmentSources")
        DeclineReason.assignLookup(formTables, "lkpPreEnrollmentDeclineReason")
        cmbWPSentBy.DataSource = New DataView(formTables.Tables("refUser"), "DonationCoordinator = 1", "Name", DataViewRowState.CurrentRows)
        cmbWPSentBy.DisplayMember = "Name"
        cmbWPSentBy.ValueMember = "RaterID"
        cmbWPSentMode.assignLookup(formTables, "lkpPreEnrollmentPacketSentMode")
        cmbWPProcBy.DataSource = New DataView(formTables.Tables("refUser"), "DonationCoordinator = 1", "Name", DataViewRowState.CurrentRows)
        cmbWPProcBy.DisplayMember = "Name"
        cmbWPProcBy.ValueMember = "RaterID"
        cmbAPSentBy.DataSource = New DataView(formTables.Tables("refUser"), "DonationCoordinator = 1", "Name", DataViewRowState.CurrentRows)
        cmbAPSentBy.DisplayMember = "Name"
        cmbAPSentBy.ValueMember = "RaterID"
        cmbAPSentMode.assignLookup(formTables, "lkpPreEnrollmentPacketSentMode")
        cmbAPProcBy.DataSource = New DataView(formTables.Tables("refUser"), "DonationCoordinator = 1", "Name", DataViewRowState.CurrentRows)
        cmbAPProcBy.DisplayMember = "Name"
        cmbAPProcBy.ValueMember = "RaterID"
        cmbNokRelation.assignLookup(formTables, "lkpRelation")
        NoKPrimLang.assignLookup(formTables, "lkpLanguage")
        NoKSecLang.assignLookup(formTables, "lkpLanguage")
        cmbAltPOCRelation.assignLookup(formTables, "lkpRelation")
        AltPOCPrimLang.assignLookup(formTables, "lkpLanguage")
        AltPOCSecLang.assignLookup(formTables, "lkpLanguage")
    End Sub
    Private Sub defaultValues()
        'set combobox default values
        cmbEnrolledBy.SelectedValue = -1
        cmbDonationType.SelectedValue = -1
        cmbSource.SelectedValue = -1
        cmbPrefMethContact.SelectedValue = -1
        DeclineReason.SelectedValue = -1
        cmbWPSentBy.SelectedValue = -1
        cmbWPSentMode.SelectedValue = -1
        cmbWPProcBy.SelectedValue = -1
        cmbAPSentBy.SelectedValue = -1
        cmbAPSentMode.SelectedValue = -1
        cmbAPProcBy.SelectedValue = -1
        cmbNokRelation.SelectedValue = -1
        NoKPrimLang.SelectedValue = -1
        NoKSecLang.SelectedValue = -1
        cmbAltPOCRelation.SelectedValue = -1
        AltPOCPrimLang.SelectedValue = -1
        AltPOCSecLang.SelectedValue = -1
    End Sub
    Private Sub loadExistingData()
        'grab existing Pre-Enrollment data (including Contact History)
        formTables.Tables.Add(Database.ReturnTable("PreEnrollment",, "SubNum = " & WarehouseShell.SubNum))
        dtDateInterested.setValue(formTables, "PreEnrollment", "InterestDate")
        dtDateEnrolled.setValue(formTables, "PreEnrollment", "DateEnrolled")
        cmbEnrolledBy.setValue(formTables, "PreEnrollment", "EnrolledByValue")
        cmbDonationType.setValue(formTables, "PreEnrollment", "DonationType")
        txtEnrollNotes.setValue(formTables, "PreEnrollment", "Notes")
        cmbPrefMethContact.setValue(formTables, "PreEnrollment", "PrefMethContactValue")
        cmbSource.setValue(formTables, "PreEnrollment", "ReferralSourceValue")
        txtSourceSpec.setValue(formTables, "PreEnrollment", "ReferralSourceSpec")
        ReferrerID.setValue(formTables, "PreEnrollment", "ReferrerID")
        txtTempDx.setValue(formTables, "PreEnrollment", "TempDx")
        DateDeclined.setValue(formTables, "PreEnrollment", "DateDeclined")
        DeclineReason.setValue(formTables, "PreEnrollment", "DeclineReason")
        DeclineSpec.setValue(formTables, "PreEnrollment", "DeclineSpec")
        dtWPSent.setValue(formTables, "PreEnrollment", "WPSentDate")
        cmbWPSentBy.setValue(formTables, "PreEnrollment", "WPSentByValue")
        cmbWPSentMode.setValue(formTables, "PreEnrollment", "WPSentModeValue")
        dtWPReceived.setValue(formTables, "PreEnrollment", "WPReceivedDate")
        cmbWPProcBy.setValue(formTables, "PreEnrollment", "WPProcByValue")
        dtAPSent.setValue(formTables, "PreEnrollment", "APSentDate")
        cmbAPSentBy.setValue(formTables, "PreEnrollment", "APSentByValue")
        cmbAPSentMode.setValue(formTables, "PreEnrollment", "APSentModeValue")
        dtAPReceived.setValue(formTables, "PreEnrollment", "APReceivedDate")
        cmbAPProcBy.setValue(formTables, "PreEnrollment", "APProcByValue")
        'check for existing DateOfDeath and apply if it exists
        If Database.ExistingRecordCheck("AutopsyFaceSheet", "SubNum = " & WarehouseShell.SubNum) Then
            formTables.Tables.Add(Database.ReturnTable("AutopsyFaceSheet", "DateOfDeath", "SubNum = " & WarehouseShell.SubNum))
            dtDateOfDeath.setValue(formTables, "AutopsyFaceSheet", "DateOfDeath")
        End If
    End Sub
    Private Sub loadExistingSubjectData()
        formTables.Tables.Add(Database.ReturnTable("Subject",, "SubNum = " & WarehouseShell.SubNum))
        txtSubAdd1.setValue(formTables, "Subject", "Address1")
        txtSubAdd2.setValue(formTables, "Subject", "Address2")
        txtSubCity.setValue(formTables, "Subject", "City")
        txtSubState.setValue(formTables, "Subject", "State")
        txtSubZip.setValue(formTables, "Subject", "Zip")
        txtSubHomePhone.setValue(formTables, "Subject", "HomePhone")
        txtSubMobilePhone.setValue(formTables, "Subject", "MobilePhone")
        txtSubWorkPhone.setValue(formTables, "Subject", "WorkPhone")
        txtSubEmail.setValue(formTables, "Subject", "Email")
        chkDNC.setValue(formTables, "Subject", "DoNotContact")
    End Sub
    Private Sub loadExistingNoKData()
        If Database.ExistingRecordCheck("NoK", "SubNum = " & WarehouseShell.SubNum) Then
            formTables.Tables.Add(Database.ReturnTable("NoK",, "SubNum = " & WarehouseShell.SubNum))
            txtNoKName.setValue(formTables, "NoK", "NoKName")
            cmbNokRelation.setValue(formTables, "NoK", "NoKRelation")
            txtNokRelationSpec.setValue(formTables, "NoK", "NoKRelationSpec")
            NoKPrimLang.setValue(formTables, "NoK", "NoKPrimLang")
            NoKSecLang.setValue(formTables, "NoK", "NoKSecLang")
            NoKLangSpec.setValue(formTables, "NoK", "NoKLangSpec")
            txtNoKAdd1.setValue(formTables, "NoK", "NoKAddress1")
            txtNoKAdd2.setValue(formTables, "NoK", "NoKAddress2")
            txtNoKCity.setValue(formTables, "NoK", "NoKCity")
            txtNoKState.setValue(formTables, "NoK", "NoKState")
            txtNoKZip.setValue(formTables, "NoK", "NoKZip")
            txtNoKHomePhone.setValue(formTables, "NoK", "NoKHomePhone")
            txtNoKMobilePhone.setValue(formTables, "NoK", "NoKMobilePhone")
            txtNoKWorkPhone.setValue(formTables, "NoK", "NoKWorkPhone")
            txtNoKEmail.setValue(formTables, "NoK", "NoKEmail")
            txtAltPOCName.setValue(formTables, "NoK", "AltPOCName")
            cmbAltPOCRelation.setValue(formTables, "NoK", "AltPOCRelation")
            txtAltPOCRelationSpec.setValue(formTables, "NoK", "AltPOCRelationSpec")
            AltPOCPrimLang.setValue(formTables, "NoK", "AltPOCPrimLang")
            AltPOCSecLang.setValue(formTables, "NoK", "AltPOCSecLang")
            AltPOCLangSpec.setValue(formTables, "NoK", "AltPOCLangSpec")
            txtAltPOCAdd1.setValue(formTables, "NoK", "AltPOCAddress1")
            txtAltPOCAdd2.setValue(formTables, "NoK", "AltPOCAddress2")
            txtAltPOCCity.setValue(formTables, "NoK", "AltPOCCity")
            txtAltPOCState.setValue(formTables, "NoK", "AltPOCState")
            txtAltPOCZip.setValue(formTables, "NoK", "AltPOCZip")
            txtAltPOCHomePhone.setValue(formTables, "NoK", "AltPOCHomePhone")
            txtAltPOCMobilePhone.setValue(formTables, "NoK", "AltPOCMobilePhone")
            txtAltPOCWorkPhone.setValue(formTables, "NoK", "AltPOCWorkPhone")
            txtAltPOCEmail.setValue(formTables, "NoK", "AltPOCEmail")
            txtNoKNotes.setValue(formTables, "NoK", "Notes")
        End If
    End Sub
    Private Sub loadFileData()
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit Then
            btnScannedForm.Enabled = True
            If SubjectFiles1to1.CheckFile("filePreEnrollment", WarehouseShell.SubNum) Then
                btnScannedFormDelete.Visible = True
            Else
                btnScannedFormDelete.Visible = False
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If SubjectFiles1to1.CheckFile("filePreEnrollment", WarehouseShell.SubNum) Then
                btnScannedForm.Enabled = True
                btnScannedFormDelete.Visible = False
            End If
        Else
            btnScannedForm.Enabled = False
            btnScannedFormDelete.Visible = False
        End If

        'Set button text based on existence of file
        If SubjectFiles1to1.CheckFile("filePreEnrollment", WarehouseShell.SubNum) Then
            btnScannedForm.BackColor = Color.Chartreuse
            btnScannedForm.Text = "View Signed Form"
        Else
            btnScannedForm.BackColor = Color.Linen
            btnScannedForm.Text = "Add Signed Form"
        End If
    End Sub
    Private Sub enableInputFields(ByVal bool As Boolean)
        chkDNC.Enabled = bool
        dtDateInterested.Enabled = bool
        dtDateEnrolled.Enabled = bool
        cmbEnrolledBy.Enabled = bool
        cmbDonationType.Enabled = bool
        txtEnrollNotes.makeReadOnly(Not bool)
        cmbSource.Enabled = bool
        txtSourceSpec.Enabled = bool
        txtTempDx.makeReadOnly(Not bool)
        cmbPrefMethContact.Enabled = bool
        ReferrerID.makeReadOnly(Not bool)
        DateDeclined.makeReadOnly(Not bool)
        DeclineReason.Enabled = bool
        DeclineSpec.makeReadOnly(Not bool)
        txtSubAdd1.Enabled = bool
        txtSubAdd2.Enabled = bool
        txtSubCity.Enabled = bool
        txtSubState.Enabled = bool
        txtSubZip.Enabled = bool
        txtSubHomePhone.Enabled = bool
        txtSubWorkPhone.Enabled = bool
        txtSubMobilePhone.Enabled = bool
        txtSubEmail.Enabled = bool
        dtWPSent.Enabled = bool
        cmbWPSentBy.Enabled = bool
        cmbWPSentMode.Enabled = bool
        dtWPReceived.Enabled = bool
        cmbWPProcBy.Enabled = bool
        dtAPSent.Enabled = bool
        cmbAPSentBy.Enabled = bool
        cmbAPSentMode.Enabled = bool
        dtAPReceived.Enabled = bool
        cmbAPProcBy.Enabled = bool
        txtNoKName.Enabled = bool
        cmbNokRelation.Enabled = bool
        txtNokRelationSpec.Enabled = bool
        NoKPrimLang.Enabled = bool
        NoKSecLang.Enabled = bool
        NoKLangSpec.Enabled = bool
        txtNoKAdd1.Enabled = bool
        txtNoKAdd2.Enabled = bool
        txtNoKCity.Enabled = bool
        txtNoKState.Enabled = bool
        txtNoKZip.Enabled = bool
        txtNoKHomePhone.Enabled = bool
        txtNoKMobilePhone.Enabled = bool
        txtNoKWorkPhone.Enabled = bool
        txtNoKEmail.Enabled = bool
        txtAltPOCName.Enabled = bool
        cmbAltPOCRelation.Enabled = bool
        txtAltPOCRelationSpec.Enabled = bool
        AltPOCPrimLang.Enabled = bool
        AltPOCSecLang.Enabled = bool
        AltPOCLangSpec.Enabled = bool
        txtAltPOCAdd1.Enabled = bool
        txtAltPOCAdd2.Enabled = bool
        txtAltPOCCity.Enabled = bool
        txtAltPOCState.Enabled = bool
        txtAltPOCZip.Enabled = bool
        txtAltPOCHomePhone.Enabled = bool
        txtAltPOCMobilePhone.Enabled = bool
        txtAltPOCWorkPhone.Enabled = bool
        txtAltPOCEmail.Enabled = bool
        txtNoKNotes.makeReadOnly(Not bool)
        btnScannedForm.Enabled = bool
        loadFileData()
    End Sub

    Private Sub btnPreEnroll_Click(sender As Object, e As EventArgs) Handles btnPreEnrollBottom.Click, btnPreEnrollTop.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If User.PermissionCheck("WA_PreEnrollments_Detail", "Modify") Then
                If WarehouseShell.ShowingPHI = False Then
                    MsgBox("Please enable PHI before attempting to add a new record.", MsgBoxStyle.OkOnly, "Error!")
                Else
                    WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
                    lblNoRecord.Visible = False
                    defaultValues()
                    loadExistingSubjectData()
                    loadExistingNoKData()
                    enableInputFields(True)
                    btnPreEnrollTop.Text = "Save record"
                    btnPreEnrollBottom.Text = btnPreEnrollTop.Text
                End If
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_PreEnrollments_Detail", "Modify") Then
                If WarehouseShell.ShowingPHI = False Then
                    MsgBox("Please enable PHI before attempting to edit this record.", MsgBoxStyle.OkOnly, "Error!")
                Else
                    WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                    enableInputFields(True)
                    btnPreEnrollTop.Text = "Save changes"
                    btnPreEnrollBottom.Text = btnPreEnrollTop.Text
                End If
            End If
        Else
            If preSaveValidation() Then
                Try
                    Dim cmd As New SqlCommand
                    cmd.Connection = WarehouseShell.conn

                    'handle PreEnrollment data
                    Dim cmdString = "@SubNum = " & WarehouseShell.SubNum &
                        ", @InterestDate = " & dtDateInterested.getSQLValue() &
                        ", @DateEnrolled = " & dtDateEnrolled.getSQLValue() &
                        ", @EnrolledByValue = " & cmbEnrolledBy.getSQLValue() &
                        ", @EnrolledByLabel = " & cmbEnrolledBy.getSQLLabel() &
                        ", @DonationType = " & cmbDonationType.getSQLValue() &
                        ", @TempDx = " & txtTempDx.getSQLValue() &
                        ", @ReferralSourceValue = " & cmbSource.getSQLValue() &
                        ", @ReferralSourceLabel = " & cmbSource.getSQLLabel() &
                        ", @ReferralSourceSpec = " & txtSourceSpec.getSQLValue() &
                        ", @PrefMEthContactValue = " & cmbPrefMethContact.getSQLValue() &
                        ", @PrefMEthContactLabel = " & cmbPrefMethContact.getSQLLabel() &
                        ", @ReferrerID = " & ReferrerID.getSQLValue() &
                        ", @DateDeclined = " & DateDeclined.getSQLValue() &
                        ", @DeclineReason = " & DeclineReason.getSQLValue() &
                        ", @DeclineSpec = " & DeclineSpec.getSQLValue() &
                        ", @WPSentDate = " & dtWPSent.getSQLValue() &
                        ", @WPSentByValue = " & cmbWPSentBy.getSQLValue() &
                        ", @WPSentByLabel = " & cmbWPSentBy.getSQLLabel() &
                        ", @WPSentModeValue = " & cmbWPSentMode.getSQLValue() &
                        ", @WPSentModeLabel = " & cmbWPSentMode.getSQLLabel() &
                        ", @WPReceivedDate = " & dtWPReceived.getSQLValue() &
                        ", @WPProcByValue = " & cmbWPProcBy.getSQLValue() &
                        ", @WPProcByLabel = " & cmbWPProcBy.getSQLLabel() &
                        ", @APSentDate = " & dtAPSent.getSQLValue() &
                        ", @APSentByValue = " & cmbAPSentBy.getSQLValue() &
                        ", @APSentByLabel = " & cmbAPSentBy.getSQLLabel() &
                        ", @APSentModeValue = " & cmbAPSentMode.getSQLValue() &
                        ", @APSentModeLabel = " & cmbAPSentMode.getSQLLabel() &
                        ", @APReceivedDate = " & dtAPReceived.getSQLValue() &
                        ", @APProcByValue = " & cmbAPProcBy.getSQLValue() &
                        ", @APProcByLabel = " & cmbAPProcBy.getSQLLabel() &
                        ", @Notes = " & txtEnrollNotes.getSQLValue() &
                        ";"
                    If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                        cmd.CommandText = "EXEC modPreEnrollmentRecord @Action = 1, " & cmdString
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Else
                        cmd.CommandText = "EXEC modPreEnrollmentRecord @Action = 2, " & cmdString
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Record was successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    End If

                    'handle subject address info
                    cmdString = "Execute modSubjectContactInfo @SubNum = " & WarehouseShell.SubNum &
                        ", @Address1 = " & txtSubAdd1.getSQLValue() &
                        ", @Address2 = " & txtSubAdd2.getSQLValue() &
                        ", @City = " & txtSubCity.getSQLValue() &
                        ", @State = " & txtSubState.getSQLValue() &
                        ", @Zip = " & txtSubZip.getSQLValue() &
                        ", @HomePhone = " & txtSubHomePhone.getSQLValue() &
                        ", @MobilePhone = " & txtSubMobilePhone.getSQLValue() &
                        ", @WorkPhone = " & txtSubWorkPhone.getSQLValue() &
                        ", @Email = " & txtSubEmail.getSQLValue() &
                        ", @DoNotContact = " & chkDNC.getSQLValue() &
                        ";"
                    cmd.CommandText = cmdString
                    cmd.ExecuteNonQuery()

                    'handle NoK data
                    cmdString = "@SubNum = " & WarehouseShell.SubNum &
                        ", @NoKName = " & txtNoKName.getSQLValue() &
                        ", @NoKRelation = " & cmbNokRelation.getSQLValue() &
                        ", @NoKRelationSpec = " & txtNokRelationSpec.getSQLValue() &
                        ", @NoKPrimLang = " & NoKPrimLang.getSQLValue() &
                        ", @NoKSecLang = " & NoKSecLang.getSQLValue() &
                        ", @NoKLangSpec = " & NoKLangSpec.getSQLValue() &
                        ", @NoKAddress1 = " & txtNoKAdd1.getSQLValue() &
                        ", @NoKAddress2 = " & txtNoKAdd2.getSQLValue() &
                        ", @NoKCity = " & txtNoKCity.getSQLValue() &
                        ", @NoKState = " & txtNoKState.getSQLValue() &
                        ", @NoKZip = " & txtNoKZip.getSQLValue() &
                        ", @NoKHomePhone = " & txtNoKHomePhone.getSQLValue() &
                        ", @NoKMobilePhone = " & txtNoKMobilePhone.getSQLValue() &
                        ", @NoKWorkPhone = " & txtNoKWorkPhone.getSQLValue() &
                        ", @NoKEmail = " & txtNoKEmail.getSQLValue() &
                        ", @AltPOCName = " & txtAltPOCName.getSQLValue() &
                        ", @AltPOCRelation = " & cmbAltPOCRelation.getSQLValue() &
                        ", @AltPOCRelationSpec = " & txtAltPOCRelationSpec.getSQLValue() &
                        ", @AltPOCPrimLang = " & AltPOCPrimLang.getSQLValue() &
                        ", @AltPOCSecLang = " & AltPOCSecLang.getSQLValue() &
                        ", @AltPOCLangSpec = " & AltPOCLangSpec.getSQLValue() &
                        ", @AltPOCAddress1 = " & txtAltPOCAdd1.getSQLValue() &
                        ", @AltPOCAddress2 = " & txtAltPOCAdd2.getSQLValue() &
                        ", @AltPOCCity = " & txtAltPOCCity.getSQLValue() &
                        ", @AltPOCState = " & txtAltPOCState.getSQLValue() &
                        ", @AltPOCZip = " & txtAltPOCZip.getSQLValue() &
                        ", @AltPOCHomePhone = " & txtAltPOCHomePhone.getSQLValue() &
                        ", @AltPOCMobilePhone = " & txtAltPOCMobilePhone.getSQLValue() &
                        ", @AltPOCWorkPhone = " & txtAltPOCWorkPhone.getSQLValue() &
                        ", @AltPOCEmail = " & txtAltPOCEmail.getSQLValue() &
                        ", @Notes = " & txtNoKNotes.getSQLValue() & ";"
                    If Database.ExistingRecordCheck("NoK", "SubNum = " & WarehouseShell.SubNum) Then
                        cmd.CommandText = "EXEC modNoKRecord @Action = 2, " & cmdString
                        cmd.ExecuteNonQuery()
                    Else
                        cmd.CommandText = "EXEC modNoKRecord @Action = 1, " & cmdString
                        cmd.ExecuteNonQuery()
                    End If

                    'close out save routine
                    WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    enableInputFields(False)
                    btnPreEnrollTop.Text = "Edit this record"
                    btnPreEnrollBottom.Text = btnPreEnrollTop.Text
                Catch ex As SqlException
                    ExceptionHandler.CatchSQLException(ex)
                End Try
            End If
        End If
    End Sub
    Private Sub btnScannedForm_Click(sender As Object, e As EventArgs) Handles btnScannedForm.Click
        If SubjectFiles1to1.CheckFile("filePreEnrollment", WarehouseShell.SubNum) Then
            SubjectFiles1to1.OpenFile("filePreEnrollment", WarehouseShell.SubNum, "SubNum- " & WarehouseShell.SubNum & " PreEnrollment")
        Else
            If User.PermissionCheck("WA_PreEnrollments_Detail", "Modify") Then
                SubjectFiles1to1.SaveFile("filePreEnrollment", WarehouseShell.SubNum)
                loadFileData()
            End If
        End If
    End Sub
    Private Sub btnScannedFormDelete_Click(sender As Object, e As EventArgs) Handles btnScannedFormDelete.Click
        If User.PermissionCheck("WA_PreEnrollments_Detail", "Modify") Then
            SubjectFiles1to1.DeleteFile("filePreEnrollment", WarehouseShell.SubNum)
            loadFileData()
        End If
    End Sub

    Private Function preSaveValidation() As Boolean
        Dim result As Boolean = True
        Dim errMsg As String = "The following errors exist and must be corrected before this record can be saved:" & vbNewLine & vbNewLine

        If cmbSource.SelectedValue = 4 And chkDNC.Checked = False Then
            errMsg += "- If the referral source is TBI, the Do Not Contact checkbox must be checked." & vbNewLine
            result = False
        End If

        If (DeclineReason.SelectedValue = 1 Or DeclineReason.SelectedValue = 999) And DeclineSpec.Text = "" Then
            errMsg += "- Please provide a Decline Specify value or change Decline Reason value." & vbNewLine
            result = False
        ElseIf DeclineReason.SelectedValue <> 1 And DeclineReason.SelectedValue <> 999 And DeclineSpec.Text <> "" Then
            errMsg += "- Please only provide a Decline Specify value if the selected Decline Reason dropdown value requires specify." & vbNewLine
            result = False
        End If

        'handle failed notification here
        If result = False Then
            MsgBox(errMsg, MsgBoxStyle.OkOnly, "Error")
        End If
        Return result
    End Function

    Private Sub chkDNC_CheckedChanged(sender As Object, e As EventArgs) Handles chkDNC.CheckedChanged
        DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).DoNotContact(chkDNC.Checked)
    End Sub

    Public Sub TopLevel(val As Boolean) Implements IFormMethods.TopLevel
    End Sub
    Private Sub IFormMethods_Parent(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Private Sub IFormMethods_Show() Implements IFormMethods.Show
        Show()
    End Sub
    Public Sub ShowPHI(val As Boolean) Implements IFormMethods.ShowPHI
        If val = False Then
            txtSubAdd1.PasswordChar = "*"
            txtSubAdd2.PasswordChar = "*"
            txtSubAdd3.PasswordChar = "*"
            txtSubCity.PasswordChar = "*"
            txtSubState.PasswordChar = "*"
            txtSubZip.PasswordChar = "*"
            txtSubHomePhone.PasswordChar = "*"
            txtSubMobilePhone.PasswordChar = "*"
            txtSubWorkPhone.PasswordChar = "*"
            txtSubEmail.PasswordChar = "*"
            txtNoKName.PasswordChar = "*"
            txtNoKAdd1.PasswordChar = "*"
            txtNoKAdd2.PasswordChar = "*"
            txtNoKCity.PasswordChar = "*"
            txtNoKState.PasswordChar = "*"
            txtNoKZip.PasswordChar = "*"
            txtNoKHomePhone.PasswordChar = "*"
            txtNoKMobilePhone.PasswordChar = "*"
            txtNoKWorkPhone.PasswordChar = "*"
            txtNoKEmail.PasswordChar = "*"
            txtAltPOCName.PasswordChar = "*"
            txtAltPOCAdd1.PasswordChar = "*"
            txtAltPOCAdd2.PasswordChar = "*"
            txtAltPOCCity.PasswordChar = "*"
            txtAltPOCState.PasswordChar = "*"
            txtAltPOCZip.PasswordChar = "*"
            txtAltPOCHomePhone.PasswordChar = "*"
            txtAltPOCMobilePhone.PasswordChar = "*"
            txtAltPOCWorkPhone.PasswordChar = "*"
            txtAltPOCEmail.PasswordChar = "*"
        Else
            txtSubAdd1.PasswordChar = ""
            txtSubAdd2.PasswordChar = ""
            txtSubAdd3.PasswordChar = ""
            txtSubCity.PasswordChar = ""
            txtSubState.PasswordChar = ""
            txtSubZip.PasswordChar = ""
            txtSubHomePhone.PasswordChar = ""
            txtSubMobilePhone.PasswordChar = ""
            txtSubWorkPhone.PasswordChar = ""
            txtSubEmail.PasswordChar = ""
            txtNoKName.PasswordChar = ""
            txtNoKAdd1.PasswordChar = ""
            txtNoKAdd2.PasswordChar = ""
            txtNoKCity.PasswordChar = ""
            txtNoKState.PasswordChar = ""
            txtNoKZip.PasswordChar = ""
            txtNoKHomePhone.PasswordChar = ""
            txtNoKMobilePhone.PasswordChar = ""
            txtNoKWorkPhone.PasswordChar = ""
            txtNoKEmail.PasswordChar = ""
            txtAltPOCName.PasswordChar = ""
            txtAltPOCAdd1.PasswordChar = ""
            txtAltPOCAdd2.PasswordChar = ""
            txtAltPOCCity.PasswordChar = ""
            txtAltPOCState.PasswordChar = ""
            txtAltPOCZip.PasswordChar = ""
            txtAltPOCHomePhone.PasswordChar = ""
            txtAltPOCMobilePhone.PasswordChar = ""
            txtAltPOCWorkPhone.PasswordChar = ""
            txtAltPOCEmail.PasswordChar = ""
        End If
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        btnPreEnrollTop.PerformClick()
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class