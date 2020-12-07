Public Class PU_PreEnrollmentDetail
    Private formTables As New DataSet
    Private SubNum As Integer

    Public Sub New(ByVal mySubNum As Integer)
        InitializeComponent()

        SubNum = mySubNum
    End Sub
    Private Sub PU_PreEnrollmentDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        loadBaseForm()
        loadExistingData()
        enableInputFields(False)
        btnPreEnrollTop.Text = "Edit this record"
        btnPreEnrollBottom.Text = btnPreEnrollTop.Text
        ShowPHI(WarehouseShell.ShowingPHI)
    End Sub
    Private Sub loadBaseForm()
        'load lookup table(s)
        formTables.Tables.Add(Database.ReturnTable("refUser"))
        formTables.Tables.Add(Database.ReturnTable("lkpRelation"))
        formTables.Tables.Add(Database.ReturnTable("lkpPreEnrollmentSources", , , "Value"))
        formTables.Tables.Add(Database.ReturnTable("lkpPreEnrollmentPacketSentMode"))
        formTables.Tables.Add(Database.ReturnTable("lkpPreEnrollmentPrefMethContact"))
        formTables.Tables.Add(Database.ReturnTable("lkpDonationWishes"))
        formTables.Tables.Add(Database.ReturnTable("lkpLanguage"))

        'assign lookups to comboboxes
        cmbEnrolledBy.DataSource = New DataView(formTables.Tables("refUser"), "DonationCoordinator = 1", "Name", DataViewRowState.CurrentRows)
        cmbEnrolledBy.DisplayMember = "Name"
        cmbEnrolledBy.ValueMember = "RaterID"
        cmbPrefMethContact.assignLookup(formTables, "lkpPreEnrollmentPrefMethContact")
        cmbSource.assignLookup(formTables, "lkpPreEnrollmentSources")
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
        cmbDonationType.assignLookup(formTables, "lkpDonationWishes")
        cmbNokRelation.assignLookup(formTables, "lkpRelation")
        NoKPrimLang.assignLookup(formTables, "lkpLanguage")
        NoKSecLang.assignLookup(formTables, "lkpLanguage")
        cmbAltPOCRelation.assignLookup(formTables, "lkpRelation")
        AltPOCPrimLang.assignLookup(formTables, "lkpLanguage")
        AltPOCSecLang.assignLookup(formTables, "lkpLanguage")
    End Sub
    Private Sub loadExistingData()
        'grab existing Pre-Enrollment data (including Contact History)
        formTables.Tables.Add(Database.ReturnTable("PreEnrollment",, "SubNum = " & SubNum))
        dtDateInterested.setValue(formTables, "PreEnrollment", "InterestDate")
        dtDateEnrolled.setValue(formTables, "PreEnrollment", "DateEnrolled")
        cmbEnrolledBy.setValue(formTables, "PreEnrollment", "EnrolledByValue")
        cmbDonationType.setValue(formTables, "PreEnrollment", "DonationType")
        txtEnrollNotes.setValue(formTables, "PreEnrollment", "Notes")
        cmbPrefMethContact.setValue(formTables, "PreEnrollment", "PrefMethContactValue")
        cmbSource.setValue(formTables, "PreEnrollment", "ReferralSourceValue")
        txtSourceSpec.setValue(formTables, "PreEnrollment", "ReferralSourceSpec")
        txtTempDx.setValue(formTables, "PreEnrollment", "TempDx")
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
        If Database.ExistingRecordCheck("AutopsyFaceSheet", "SubNum = " & SubNum) Then
            formTables.Tables.Add(Database.ReturnTable("AutopsyFaceSheet", "DateOfDeath", "SubNum = " & SubNum))
            dtDateOfDeath.setValue(formTables, "AutopsyFaceSheet", "DateOfDeath")
        End If

        'Apply existing subject contact info (subject record must exists to get here to begin with, so no need for existingRecordCheck)
        formTables.Tables.Add(Database.ReturnTable("Subject",, "SubNum = " & SubNum))
        chkDNC.setValue(formTables, "Subject", "DoNotContact")
        If chkDNC.Checked Then
            chkDNC.BackColor = Color.Red
        Else
            chkDNC.BackColor = Color.Tan
        End If
        txtSubAdd1.setValue(formTables, "Subject", "Address1")
        txtSubAdd2.setValue(formTables, "Subject", "Address2")
        txtSubCity.setValue(formTables, "Subject", "City")
        txtSubState.setValue(formTables, "Subject", "State")
        txtSubZip.setValue(formTables, "Subject", "Zip")
        txtSubHomePhone.setValue(formTables, "Subject", "HomePhone")
        txtSubMobilePhone.setValue(formTables, "Subject", "MobilePhone")
        txtSubWorkPhone.setValue(formTables, "Subject", "WorkPhone")
        txtSubEmail.setValue(formTables, "Subject", "Email")

        'check for existing NoK data and apply if it exists
        If Database.ExistingRecordCheck("NoK", "SubNum = " & SubNum) Then
            formTables.Tables.Add(Database.ReturnTable("NoK",, "SubNum = " & SubNum))
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
        'Set enabled state based on DataMode
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit Then
            btnScannedForm.Enabled = True
            If SubjectFiles1to1.CheckFile("filePreEnrollment", SubNum) Then
                btnScannedFormDelete.Visible = True
            Else
                btnScannedFormDelete.Visible = False
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If SubjectFiles1to1.CheckFile("filePreEnrollment", SubNum) Then
                btnScannedForm.Enabled = True
                btnScannedFormDelete.Visible = False
            End If
        Else
            btnScannedForm.Enabled = False
            btnScannedFormDelete.Visible = False
        End If

        'Set button text based on existence of file
        If SubjectFiles1to1.CheckFile("filePreEnrollment", SubNum) Then
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
        txtEnrollNotes.makeReadOnly(Not bool)
        cmbDonationType.Enabled = bool
        cmbSource.Enabled = bool
        txtSourceSpec.Enabled = bool
        txtTempDx.makeReadOnly(Not bool)
        cmbPrefMethContact.Enabled = bool
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
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If WarehouseShell.ShowingPHI = False Then
                MsgBox("Please enable PHI before attempting to edit this record.", MsgBoxStyle.OkOnly, "Error!")
            Else
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                enableInputFields(True)
                btnPreEnrollTop.Text = "Save changes"
                btnPreEnrollBottom.Text = btnPreEnrollTop.Text
            End If
        Else 'by default form must be in edit mode
            If preSaveValidation() Then
                Try
                    Dim cmdString = "EXEC modPreEnrollmentRecord @Action = 2" &
                        ", @SubNum = " & SubNum &
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
                    Dim cmd As New SqlCommand(cmdString, WarehouseShell.conn)
                    cmd.ExecuteNonQuery()

                    'handle subject address info
                    cmdString = "Execute modSubjectContactInfo @SubNum = " & SubNum &
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
                    cmdString = "@SubNum = " & SubNum &
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
                    If Database.ExistingRecordCheck("NoK", "SubNum = " & SubNum) Then
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
                    MessageBox.Show("Record was successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Catch ex As SqlException
                    ExceptionHandler.CatchSQLException(ex)
                End Try
            End If
        End If
    End Sub
    Private Sub btnScannedForm_Click(sender As Object, e As EventArgs) Handles btnScannedForm.Click
        If SubjectFiles1to1.CheckFile("filePreEnrollment", SubNum) Then
            SubjectFiles1to1.OpenFile("filePreEnrollment", SubNum, "SubNum- " & SubNum & " PreEnrollment")
        Else
            SubjectFiles1to1.SaveFile("filePreEnrollment", SubNum)
            loadFileData()
        End If
    End Sub
    Private Sub btnScannedFormDelete_Click(sender As Object, e As EventArgs) Handles btnScannedFormDelete.Click
        SubjectFiles1to1.DeleteFile("filePreEnrollment", SubNum)
        loadFileData()
    End Sub

    Private Function preSaveValidation() As Boolean
        Dim result As Boolean = True
        Dim errMsg As String = ""

        'handle failed notification here
        If result = False Then
            MsgBox(errMsg, MsgBoxStyle.OkOnly, "Error")
        End If
        Return result
    End Function
    Private Sub ShowPHI(val As Boolean)
        If val = False Then
            txtSubAdd1.PasswordChar = "*"
            txtSubAdd2.PasswordChar = "*"
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
End Class