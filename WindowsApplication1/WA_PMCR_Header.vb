Imports iTextSharp.text.pdf

Public Class WA_PMCR_Header
    Implements IFormMethods
    Private formTables As New DataSet
    Private pdfFormFields As AcroFields
    Private BB As String

    'Normal form events
    Private Sub WA_PMCR_Header_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_PMCR_tabHeader")
        If Database.ExistingRecordCheck("PMCR_Header", "SubNum = " & WarehouseShell.SubNum) Then
            loadBaseForm()
            loadExistingData()
            btnPMCR_Header_Top.Text = "Edit this record"
            lblNoRecord.Visible = False
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        Else
            btnPMCR_Header_Top.Text = "Add new record"
            btnPMCR_Header_Top.Text = "Add new record"
            lblNoRecord.Visible = True
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
        End If
        enableInputFields(False)
        If WarehouseShell.userName = "harouv01" Or WarehouseShell.userName = "arnesj01" Then
            chkHarryReviewed.Visible = True
        End If
    End Sub
    Private Sub loadBaseForm()
        WarehouseShell.highlightSelectedNode("WA_PMCR_tabHeader")
        'Grab any required comboLookUp tables and assign them to their appropriate boxes
        formTables.Tables.Add(Database.ReturnTable("refUser", "RaterID, Name", "PMCRAssessor = 1", "Name"))
        formTables.Tables.Add(Database.ReturnTable("AutopsyFaceSheet", "MannerOfDeath", "SubNum = " & WarehouseShell.SubNum))
        comboAssessedBy.assignLookup(formTables, "refUser", "RaterID", "Name")
        If formTables.Tables("AutopsyFaceSheet").Rows(0).Item("MannerOfDeath").ToString = "3" Then
            chkSuicide.Checked = True
        Else
            chkSuicide.Checked = False
        End If
        'Set default values
        comboAssessedBy.SelectedValue = 88
    End Sub
    Private Sub loadExistingData()
        If Database.ExistingRecordCheck("PMCR_Header", "SubNum = " & WarehouseShell.SubNum) = True Then
            formTables.Tables.Add(Database.ReturnTable("viewPMCR_Header", , "SubNum = " & WarehouseShell.SubNum))
            chkHarryReviewed.setValue(formTables, "viewPMCR_Header", "HarryReviewed")
            txtAssessmentDate.setValue(formTables, "viewPMCR_Header", "AssessmentDate")
            comboAssessedBy.SelectedValue = formTables.Tables("viewPMCR_Header").Rows(0).Item("AssessedByValue")
            txtOverClinImp.setValue(formTables, "viewPMCR_Header", "OverallClinicalImpression")
        End If
    End Sub
    Private Sub enableInputFields(ByVal bool As Boolean)
        chkHarryReviewed.Enabled = bool
        comboAssessedBy.Enabled = bool
        txtAssessmentDate.Enabled = bool
        txtOverClinImp.makeReadOnly(Not bool)
    End Sub
    Private Sub btnPMCR_Header_Click(sender As Object, e As EventArgs) Handles btnPMCR_Header_Top.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If User.PermissionCheck("WA_PMCR_Header", "Modify") Then
                lblNoRecord.Visible = False
                enableInputFields(True)
                btnPMCR_Header_Top.Text = "Save New Record"
                loadBaseForm()
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_PMCR_Header", "Modify") Then
                enableInputFields(True)
                btnPMCR_Header_Top.Text = "Save Changes"
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
            End If
        Else
            Dim sqlCommand As New SqlCommand("", WarehouseShell.conn)
            Dim cmdText As String = "@SubNum = " & WarehouseShell.SubNum &
                ", @HarryReviewed = " & chkHarryReviewed.getSQLValue() &
                ", @AssessmentDate = " & txtAssessmentDate.getSQLValue() &
                ", @AssessedBy = " & comboAssessedBy.getSQLValue() &
                ", @OverallClinicalImpression = " & txtOverClinImp.getSQLValue() &
                ";"
            If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                sqlCommand.CommandText = "Exec dbo.modPMCR_HeaderRecord @Action = 1, " & cmdText
                Try
                    sqlCommand.ExecuteNonQuery()
                    MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    enableInputFields(False)
                    btnPMCR_Header_Top.Text = "Edit this record"
                    DirectCast(WarehouseShell.WorkingAreaForm, WA_PMCR).headerExisits = True
                Catch ex As SqlException
                    ExceptionHandler.CatchSQLException(ex)
                End Try
            Else
                sqlCommand.CommandText = "Exec dbo.modPMCR_HeaderRecord @Action = 2, " & cmdText
                Try
                    sqlCommand.ExecuteNonQuery()
                    MessageBox.Show("Record successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    enableInputFields(False)
                    btnPMCR_Header_Top.Text = "Edit this record"
                Catch ex As SqlException
                    ExceptionHandler.CatchSQLException(ex)
                End Try
            End If
        End If
    End Sub

    'PDF export events
    Private Sub btnPDFExport_Click(sender As Object, e As EventArgs) Handles btnPDFExport.Click
        Try
            'Define which template to use
            Dim pdfTemplate As String = "Q:\Warehouse Files\PDF Export Templates\PMCR Template.pdf"
            'Define the output file name
            Dim outputFileName As String = "SubNum " & WarehouseShell.SubNum.ToString & " PMCR" & IIf(WarehouseShell.ShowingPHI, "", "- Deidentified") & ".pdf"
            'combine the output file name with the user's temp file path location so we can create and fill the PDF
            Dim filledPDF As String = IO.Path.GetTempPath() & outputFileName

            'Use the PDF API to start the the new file
            Dim pdfReader As PdfReader = New PdfReader(pdfTemplate)
            Dim pdfStamper As New PdfStamper(pdfReader, New FileStream(filledPDF, FileMode.Create))
            pdfFormFields = pdfStamper.AcroFields

            'Fill the fields with values
            fillPDFDemographics(WarehouseShell.ShowingPHI)
            fillPDFFamilyHistory()
            fillPDFVisionAndHearing()
            fillPDFInformants(WarehouseShell.ShowingPHI)
            fillPDFHypoxia()
            fillPDFDiagnoses()
            fillPDFMedications()
            fillPDFCVD()
            fillPDFHachinski()
            fillPDFDepression()
            fillPDFMCIRS()
            fillPDFCDR()
            fillPDFAD8()
            fillPDFCDRInfInterview()
            fillPDFDementia1()
            fillPDFDementia2()
            fillPDFParkinsonism()
            fillPDFLabs()

            'Flatten the form to dissuade manual editing of outputs
            pdfStamper.FormFlattening = True

            'Close the stamper (to finalize the Filled PDF)
            pdfStamper.Dispose()
            pdfReader.Dispose()

            'Launch the filled PDF for the user
            Dim P As New Process
            Dim s As New ProcessStartInfo(filledPDF)
            s.UseShellExecute = True
            s.WindowStyle = ProcessWindowStyle.Normal
            P.StartInfo = s
            P.Start()
        Catch ex As Exception
            ExceptionHandler.CatchWindowsException(ex)
        End Try
    End Sub
    Private Sub fillPDFDemographics(ByVal ShowPHI As Boolean)
        'Grab requisite tables
        formTables.Tables.Add(Database.ReturnTable("viewSubject", , "SubNum = " & WarehouseShell.SubNum))
        formTables.Tables.Add(Database.ReturnTable("Subject", , "SubNum = " & WarehouseShell.SubNum))
        formTables.Tables.Add(Database.ReturnTable("viewAutopsyFaceSheet", "ReferringInstitutionLabel", "SubNum = " & WarehouseShell.SubNum))

        'Set non-PHI values
        pdfFormFields.SetField("Date", txtAssessmentDate.Text)
        pdfFormFields.SetField("Rater", comboAssessedBy.Text)
        pdfFormFields.SetField("BB", formTables.Tables("viewSubject").Rows(0).Item("BB").ToString)
        pdfFormFields.SetField("SubNum", WarehouseShell.SubNum.ToString)
        pdfFormFields.SetField("NACCID", formTables.Tables("viewSubject").Rows(0).Item("NACCID").ToString)
        pdfFormFields.SetField("Age", formTables.Tables("viewSubject").Rows(0).Item("Age").ToString)
        pdfFormFields.SetField("Race", formTables.Tables("Subject").Rows(0).Item("RaceLabel").ToString)
        pdfFormFields.SetField("Ethnicity", formTables.Tables("Subject").Rows(0).Item("EthnicityLabel").ToString)
        pdfFormFields.SetField("Gender", formTables.Tables("Subject").Rows(0).Item("SexLabel").ToString)
        pdfFormFields.SetField("MaritalStatus", formTables.Tables("Subject").Rows(0).Item("MaritalStatusLabel").ToString)
        pdfFormFields.SetField("MobilityStatus", formTables.Tables("Subject").Rows(0).Item("MobilityStatusLabel").ToString)
        pdfFormFields.SetField("YrsEd", formTables.Tables("Subject").Rows(0).Item("YearsOfEducation").ToString)
        pdfFormFields.SetField("NicUseHx", formTables.Tables("Subject").Rows(0).Item("NicotineHxLabel").ToString)
        pdfFormFields.SetField("CigStartedAge", formTables.Tables("Subject").Rows(0).Item("CigAgeStarted").ToString)
        pdfFormFields.SetField("CigDateQuit", formTables.Tables("Subject").Rows(0).Item("CigDateQuit").ToString)
        pdfFormFields.SetField("YrsSmoked", formTables.Tables("Subject").Rows(0).Item("CigYearsUsed").ToString)
        pdfFormFields.SetField("CigFreqDay", formTables.Tables("Subject").Rows(0).Item("CigFreq").ToString)
        pdfFormFields.SetField("OtherNicHxType", formTables.Tables("Subject").Rows(0).Item("NicOthTypeLabel").ToString)
        pdfFormFields.SetField("OthNicAgeStart", formTables.Tables("Subject").Rows(0).Item("NicOthAgeStarted").ToString)
        pdfFormFields.SetField("OthNicDateQuit", formTables.Tables("Subject").Rows(0).Item("NicOthDateQuit").ToString)
        pdfFormFields.SetField("OthNicYrsUsed", formTables.Tables("Subject").Rows(0).Item("NicOthYearsUsed").ToString)
        pdfFormFields.SetField("OthNicFreqDay", formTables.Tables("Subject").Rows(0).Item("NicOthFreq").ToString)
        pdfFormFields.SetField("LangPrim", formTables.Tables("Subject").Rows(0).Item("PrimaryLanguageLabel").ToString)
        pdfFormFields.SetField("LangSec", formTables.Tables("Subject").Rows(0).Item("SecondaryLanguageLabel").ToString)
        pdfFormFields.SetField("LangSpec", formTables.Tables("Subject").Rows(0).Item("LanguageNote").ToString)
        pdfFormFields.SetField("Handedness", formTables.Tables("Subject").Rows(0).Item("HandednessLabel").ToString)
        pdfFormFields.SetField("MultiBirth", formTables.Tables("Subject").Rows(0).Item("MultBirthLabel").ToString)
        pdfFormFields.SetField("MultiBirthSpec", formTables.Tables("Subject").Rows(0).Item("MultBirthNote").ToString)
        'pdfFormFields.SetField("Date1stNeuroPsychHosp", formTables.Tables("Subject").Rows(0).Item("RaceLabel").ToString)
        pdfFormFields.SetField("PsychDxCode", formTables.Tables("viewSubject").Rows(0).Item("PrimPsychDxICD").ToString)
        pdfFormFields.SetField("PsychDxText", formTables.Tables("viewSubject").Rows(0).Item("PrimPsychDxText").ToString)
        pdfFormFields.SetField("NeuroDxCode", formTables.Tables("viewSubject").Rows(0).Item("PrimNeuroDxICD").ToString)
        pdfFormFields.SetField("NeuroDxText", formTables.Tables("viewSubject").Rows(0).Item("PrimNeuroDxText").ToString)
        'pdfFormFields.SetField("Date1stNeuroPsychHosp", formTables.Tables("Subject").Rows(0).Item("RaceLabel").ToString)
        'pdfFormFields.SetField("Date1stNeuroPsychHosp", formTables.Tables("Subject").Rows(0).Item("RaceLabel").ToString)
        'pdfFormFields.SetField("Date1stNeuroPsychHosp", formTables.Tables("Subject").Rows(0).Item("RaceLabel").ToString)
        'pdfFormFields.SetField("Date1stNeuroPsychHosp", formTables.Tables("Subject").Rows(0).Item("RaceLabel").ToString)
        'pdfFormFields.SetField("Date1stNeuroPsychHosp", formTables.Tables("Subject").Rows(0).Item("RaceLabel").ToString)
        'pdfFormFields.SetField("Date1stNeuroPsychHosp", formTables.Tables("Subject").Rows(0).Item("RaceLabel").ToString)
        'pdfFormFields.SetField("Date1stNeuroPsychHosp", formTables.Tables("Subject").Rows(0).Item("RaceLabel").ToString)
        'pdfFormFields.SetField("Date1stNeuroPsychHosp", formTables.Tables("Subject").Rows(0).Item("RaceLabel").ToString)
        'pdfFormFields.SetField("Date1stNeuroPsychHosp", formTables.Tables("Subject").Rows(0).Item("RaceLabel").ToString)
        'pdfFormFields.SetField("Date1stNeuroPsychHosp", formTables.Tables("Subject").Rows(0).Item("RaceLabel").ToString)
        'pdfFormFields.SetField("Date1stNeuroPsychHosp", formTables.Tables("Subject").Rows(0).Item("RaceLabel").ToString)
        'pdfFormFields.SetField("Date1stNeuroPsychHosp", formTables.Tables("Subject").Rows(0).Item("RaceLabel").ToString)
        pdfFormFields.SetField("RefInst", formTables.Tables("viewAutopsyFaceSheet").Rows(0).Item("ReferringInstitutionLabel").ToString)
        pdfFormFields.SetField("NBTR", formTables.Tables("Subject").Rows(0).Item("NBTRCohort").ToString)
        pdfFormFields.SetField("ADRC", formTables.Tables("Subject").Rows(0).Item("ADRCCohort").ToString)
        pdfFormFields.SetField("NACC", formTables.Tables("Subject").Rows(0).Item("NACCCohort").ToString)
        pdfFormFields.SetField("Israel", formTables.Tables("Subject").Rows(0).Item("IsraelCohort").ToString)
        pdfFormFields.SetField("PPG", formTables.Tables("Subject").Rows(0).Item("PPGCohort").ToString)
        pdfFormFields.SetField("Schizo", formTables.Tables("Subject").Rows(0).Item("SchizoCohort").ToString)
        'pdfFormFields.SetField("OtherProjPart", formTables.Tables("Subject").Rows(0).Item("RaceLabel").ToString)
        'pdfFormFields.SetField("OtherProjPartSpec", formTables.Tables("Subject").Rows(0).Item("RaceLabel").ToString)
        pdfFormFields.SetField("CommentsNotes", txtOverClinImp.Text)

        'Set PHI values (based on ShowPHI)
        If ShowPHI Then
            pdfFormFields.SetField("LastName", formTables.Tables("viewSubject").Rows(0).Item("LastName").ToString)
            pdfFormFields.SetField("FirstName", formTables.Tables("viewSubject").Rows(0).Item("FirstName").ToString)
            pdfFormFields.SetField("MI", formTables.Tables("viewSubject").Rows(0).Item("MI").ToString)
            pdfFormFields.SetField("SSN", formTables.Tables("viewSubject").Rows(0).Item("SSN").ToString)
            pdfFormFields.SetField("DoB", returnFormattedDate("viewSubject", "DoB"))
            pdfFormFields.SetField("Suffix", formTables.Tables("Subject").Rows(0).Item("Suffix").ToString)
            pdfFormFields.SetField("PoB", formTables.Tables("Subject").Rows(0).Item("PlaceOfBirth").ToString)
            pdfFormFields.SetField("DoD", returnFormattedDate("viewSubject", "DateOfDeath"))
        Else
            pdfFormFields.SetField("LastName", "PHI Hidden")
            pdfFormFields.SetField("FirstName", "PHI Hidden")
            pdfFormFields.SetField("MI", "PHI Hidden")
            pdfFormFields.SetField("SSN", "PHI Hidden")
            pdfFormFields.SetField("DoB", "PHI Hidden")
            pdfFormFields.SetField("Suffix", "PHI Hidden")
            pdfFormFields.SetField("PoB", "PHI Hidden")
            pdfFormFields.SetField("DoD", "PHI Hidden")
        End If

        'Free up system memory by removing tables
        formTables.Tables.Remove("viewSubject")
        formTables.Tables.Remove("Subject")
        formTables.Tables.Remove("viewAutopsyFaceSheet")
    End Sub
    Private Sub fillPDFFamilyHistory()
        If Database.ExistingRecordCheck("DementiaFamilyHx", "SubNum = " & WarehouseShell.SubNum) Then
            'Grab requisite tables
            formTables.Tables.Add(Database.ReturnTable("viewDementiaFamilyHx", , "SubNum = " & WarehouseShell.SubNum))

            'Set values
            pdfFormFields.SetField("RelDem", formTables.Tables("viewDementiaFamilyHx").Rows(0).Item("RelWDemLabel").ToString)
            pdfFormFields.SetField("NumRelDem", formTables.Tables("viewDementiaFamilyHx").Rows(0).Item("RelWDemNum").ToString)
            pdfFormFields.SetField("NumFullSib", formTables.Tables("viewDementiaFamilyHx").Rows(0).Item("FullSib").ToString)
            pdfFormFields.SetField("NumFullSibDem", formTables.Tables("viewDementiaFamilyHx").Rows(0).Item("FullSibWDem").ToString)
            pdfFormFields.SetField("NumBioChild", formTables.Tables("viewDementiaFamilyHx").Rows(0).Item("ChildNum").ToString)
            pdfFormFields.SetField("NumBioChildDem", formTables.Tables("viewDementiaFamilyHx").Rows(0).Item("ChildNumWDem").ToString)
            pdfFormFields.SetField("NumOthBloodRelDem", formTables.Tables("viewDementiaFamilyHx").Rows(0).Item("OthBloodRelWDemNum").ToString)

            'Free up system memory by removing tables
            formTables.Tables.Remove("viewDementiaFamilyHx")
        End If
    End Sub
    Private Sub fillPDFVisionAndHearing()
        If Database.ExistingRecordCheck("VisionAndHearing", "SubNum = " & WarehouseShell.SubNum) Then
            'Grab requisite tables
            formTables.Tables.Add(Database.ReturnTable("viewVisionAndHearing", , "SubNum = " & WarehouseShell.SubNum))

            'Set values
            pdfFormFields.SetField("NormVision", formTables.Tables("viewVisionAndHearing").Rows(0).Item("VisNormWOLensesLabel").ToString)
            pdfFormFields.SetField("CorrectiveLenses", formTables.Tables("viewVisionAndHearing").Rows(0).Item("WearCorrLensesLabel").ToString)
            pdfFormFields.SetField("VisNormalWCorrectiveLenses", formTables.Tables("viewVisionAndHearing").Rows(0).Item("VisNormWLensesLabel").ToString)
            pdfFormFields.SetField("HearNormal", formTables.Tables("viewVisionAndHearing").Rows(0).Item("HearNormWOAidsLabel").ToString)
            pdfFormFields.SetField("HearingAids", formTables.Tables("viewVisionAndHearing").Rows(0).Item("WearHearAidsLabel").ToString)

            'Free up system memory by removing tables
            formTables.Tables.Remove("viewVisionAndHearing")
        End If
    End Sub
    Private Sub fillPDFInformants(ByVal ShowPHI As Boolean)
        'Check if informants table exists
        If Database.ExistingRecordCheck("PMCR_Informants", "SubNum = " & WarehouseShell.SubNum) Then
            'Grab requisite table
            formTables.Tables.Add(Database.ReturnTable("viewPMCR_Informants", , "SubNum = " & WarehouseShell.SubNum))

            'Set non-PHI values
            pdfFormFields.SetField("Inf1Type", formTables.Tables("viewPMCR_Informants").Rows(0).Item("Inf1TypeLabel").ToString)
            pdfFormFields.SetField("Inf1Relation", formTables.Tables("viewPMCR_Informants").Rows(0).Item("Inf1RelationLabel").ToString)
            pdfFormFields.SetField("Inf2Type", formTables.Tables("viewPMCR_Informants").Rows(0).Item("Inf2TypeLabel").ToString)
            pdfFormFields.SetField("Inf2Relation", formTables.Tables("viewPMCR_Informants").Rows(0).Item("Inf2RelationLabel").ToString)
            pdfFormFields.SetField("Inf3Type", formTables.Tables("viewPMCR_Informants").Rows(0).Item("Inf3TypeLabel").ToString)
            pdfFormFields.SetField("Inf3Relation", formTables.Tables("viewPMCR_Informants").Rows(0).Item("Inf3RelationLabel").ToString)
            pdfFormFields.SetField("Inf4Type", formTables.Tables("viewPMCR_Informants").Rows(0).Item("Inf4TypeLabel").ToString)
            pdfFormFields.SetField("Inf4Relation", formTables.Tables("viewPMCR_Informants").Rows(0).Item("Inf4RelationLabel").ToString)

            'Set PHI values (based on ShowPHI)
            If ShowPHI Then
                pdfFormFields.SetField("Inf1Name", formTables.Tables("viewPMCR_Informants").Rows(0).Item("Inf1Name").ToString)
                pdfFormFields.SetField("Inf1Address", formTables.Tables("viewPMCR_Informants").Rows(0).Item("Inf1Address").ToString)
                pdfFormFields.SetField("Inf1WorkPhone", formTables.Tables("viewPMCR_Informants").Rows(0).Item("Inf1WorkPhone").ToString)
                pdfFormFields.SetField("Inf1HomePhone", formTables.Tables("viewPMCR_Informants").Rows(0).Item("Inf1HomePhone").ToString)
                pdfFormFields.SetField("Inf2Name", formTables.Tables("viewPMCR_Informants").Rows(0).Item("Inf2Name").ToString)
                pdfFormFields.SetField("Inf2Address", formTables.Tables("viewPMCR_Informants").Rows(0).Item("Inf2Address").ToString)
                pdfFormFields.SetField("Inf2WorkPhone", formTables.Tables("viewPMCR_Informants").Rows(0).Item("Inf2WorkPhone").ToString)
                pdfFormFields.SetField("Inf2HomePhone", formTables.Tables("viewPMCR_Informants").Rows(0).Item("Inf2HomePhone").ToString)
                pdfFormFields.SetField("Inf3Name", formTables.Tables("viewPMCR_Informants").Rows(0).Item("Inf3Name").ToString)
                pdfFormFields.SetField("Inf3Address", formTables.Tables("viewPMCR_Informants").Rows(0).Item("Inf3Address").ToString)
                pdfFormFields.SetField("Inf3WorkPhone", formTables.Tables("viewPMCR_Informants").Rows(0).Item("Inf3WorkPhone").ToString)
                pdfFormFields.SetField("Inf3HomePhone", formTables.Tables("viewPMCR_Informants").Rows(0).Item("Inf3HomePhone").ToString)
                pdfFormFields.SetField("Inf4Name", formTables.Tables("viewPMCR_Informants").Rows(0).Item("Inf4Name").ToString)
                pdfFormFields.SetField("Inf4Address", formTables.Tables("viewPMCR_Informants").Rows(0).Item("Inf4Address").ToString)
                pdfFormFields.SetField("Inf4WorkPhone", formTables.Tables("viewPMCR_Informants").Rows(0).Item("Inf4WorkPhone").ToString)
                pdfFormFields.SetField("Inf4HomePhone", formTables.Tables("viewPMCR_Informants").Rows(0).Item("Inf4HomePhone").ToString)
            Else
                pdfFormFields.SetField("Inf1Name", "PHI Hidden")
                pdfFormFields.SetField("Inf1Address", "PHI Hidden")
                pdfFormFields.SetField("Inf1WorkPhone", "PHI Hidden")
                pdfFormFields.SetField("Inf1HomePhone", "PHI Hidden")
                pdfFormFields.SetField("Inf2Name", "PHI Hidden")
                pdfFormFields.SetField("Inf2Address", "PHI Hidden")
                pdfFormFields.SetField("Inf2WorkPhone", "PHI Hidden")
                pdfFormFields.SetField("Inf2HomePhone", "PHI Hidden")
                pdfFormFields.SetField("Inf3Name", "PHI Hidden")
                pdfFormFields.SetField("Inf3Address", "PHI Hidden")
                pdfFormFields.SetField("Inf3WorkPhone", "PHI Hidden")
                pdfFormFields.SetField("Inf3HomePhone", "PHI Hidden")
                pdfFormFields.SetField("Inf4Name", "PHI Hidden")
                pdfFormFields.SetField("Inf4Address", "PHI Hidden")
                pdfFormFields.SetField("Inf4WorkPhone", "PHI Hidden")
                pdfFormFields.SetField("Inf4HomePhone", "PHI Hidden")
            End If

            'Free up system memory by removing tables
            formTables.Tables.Remove("viewPMCR_Informants")
        End If
    End Sub
    Private Sub fillPDFHypoxia()
        If Database.ExistingRecordCheck("PMCR_Hypoxia", "SubNum = " & WarehouseShell.SubNum) Then
            'Grab requisite tables
            formTables.Tables.Add(Database.ReturnTable("viewPMCR_Hypoxia", , "SubNum = " & WarehouseShell.SubNum))

            'Set non-PHI values
            pdfFormFields.SetField("Intubation", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("IntubationLabel").ToString)
            pdfFormFields.SetField("IntubationDate", returnFormattedDate("viewPMCR_Hypoxia", "IntubationDate"))
            pdfFormFields.SetField("IntubationTotalHours", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("IntubationHours").ToString)
            pdfFormFields.SetField("NasalO2", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("NasalO2Label").ToString)
            pdfFormFields.SetField("NasalO2Date", returnFormattedDate("viewPMCR_Hypoxia", "NasalO2Date"))
            pdfFormFields.SetField("NasalO2TotalHours", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("NasalO2Hours").ToString)
            pdfFormFields.SetField("OthPeriEvent", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("OtherLabel").ToString)
            pdfFormFields.SetField("OthPeriEventDate", returnFormattedDate("viewPMCR_Hypoxia", "OtherDate"))
            pdfFormFields.SetField("OthPeriEventTotalHours", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("OtherHours").ToString)
            pdfFormFields.SetField("OthPeriEventSpec", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("OtherNote").ToString)
            pdfFormFields.SetField("Alert", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("AlertLabel").ToString)
            pdfFormFields.SetField("AlertSpec", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("AlertNote").ToString)
            pdfFormFields.SetField("Delirium", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("DeliriumLabel").ToString)
            pdfFormFields.SetField("DeliriumSpec", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("DeliriumNote").ToString)
            pdfFormFields.SetField("Coma", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("ComaLabel").ToString)
            pdfFormFields.SetField("ComaSpec", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("ComaNote").ToString)
            pdfFormFields.SetField("PremorbidStateWeeks", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("Weeks").ToString)
            pdfFormFields.SetField("PremorbidStateDays", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("Days").ToString)
            pdfFormFields.SetField("PremorbidStateHours", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("Hours").ToString)
            pdfFormFields.SetField("CGIHypox", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("CGIHypoxiaLabel").ToString)
            pdfFormFields.SetField("PresHall", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("HallucinationsLabel").ToString)
            pdfFormFields.SetField("PresHallDate", returnFormattedDate("viewPMCR_Hypoxia", "HallucinationsDate"))
            pdfFormFields.SetField("PresHallSpec", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("HallucinationsNote").ToString)
            pdfFormFields.SetField("PresDel", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("DelusionLabel").ToString)
            pdfFormFields.SetField("PresDelDate", returnFormattedDate("viewPMCR_Hypoxia", "DelusionDate"))
            pdfFormFields.SetField("PresDelSpec", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("DelusionNote").ToString)
            pdfFormFields.SetField("PresProbBeh", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("ProblemBehaviorLabel").ToString)
            pdfFormFields.SetField("PresProbBehDate", returnFormattedDate("viewPMCR_Hypoxia", "ProblemBehaviorDate"))
            pdfFormFields.SetField("PresProbBehSpec", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("ProblemBehaviorNote").ToString)
            pdfFormFields.SetField("PresPark", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("ParkinsonismLabel").ToString)
            pdfFormFields.SetField("PresParkDate", returnFormattedDate("viewPMCR_Hypoxia", "ParkinsonismDate"))
            pdfFormFields.SetField("PresParkSpec", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("ParkinsonismNote").ToString)
            pdfFormFields.SetField("PresTardDysk", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("TardiveDyskLabel").ToString)
            pdfFormFields.SetField("PresTardDyskDate", returnFormattedDate("viewPMCR_Hypoxia", "TardiveDyskDate"))
            pdfFormFields.SetField("PresTardDyskSpec", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("TardiveDyskNote").ToString)
            pdfFormFields.SetField("PresNonParkTrem", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("TremorLabel").ToString)
            pdfFormFields.SetField("PresNonParkTremDate", returnFormattedDate("viewPMCR_Hypoxia", "TremorDate"))
            pdfFormFields.SetField("PresNonParkTremSpec", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("TremorNote").ToString)
            pdfFormFields.SetField("GCSMotor", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("GlasgowMotorLabel").ToString)
            pdfFormFields.SetField("GCSVerb", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("GlasgowVerbalLabel").ToString)
            pdfFormFields.SetField("GCSEye", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("GlasgowEyeLabel").ToString)
            pdfFormFields.SetField("GCSTotal", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("GlasgowScore").ToString)
            pdfFormFields.SetField("HypoxiaNotes", formTables.Tables("viewPMCR_Hypoxia").Rows(0).Item("HypoxiaNotes").ToString)

            'Free up system memory by removing tables
            formTables.Tables.Remove("viewPMCR_Hypoxia")
        End If
    End Sub
    Private Sub fillPDFDiagnoses()
        If Database.ExistingRecordCheck("Diagnoses", "SubNum = " & WarehouseShell.SubNum) Then
            'Grab requisite tables
            formTables.Tables.Add(Database.ReturnTable("viewDiagnoses", "top(52) *", "SubNum = " & WarehouseShell.SubNum, "[Brain Related] desc, DxDate desc"))

            'Set table of values
            Dim rowNum As Integer = 0
            Dim dxDate As String = ""
            While rowNum < 51 And rowNum < formTables.Tables("viewDiagnoses").Rows().Count()
                Dim row As DataRow = formTables.Tables("viewDiagnoses").Rows(rowNum)
                pdfFormFields.SetField("Dx" & (rowNum + 1), row.Item("Dx").ToString)
                If Not row.IsNull("DxDate") Then
                    pdfFormFields.SetField("Dx" & (rowNum + 1) & "Date", Format(row.Item("DxDate"), "MM/dd/yyyy"))
                End If
                pdfFormFields.SetField("Dx" & (rowNum + 1) & "Code", row.Item("DxCode").ToString)
                pdfFormFields.SetField("Dx" & (rowNum + 1) & "CodeType", row.Item("DxCodeType").ToString)
                pdfFormFields.SetField("Dx" & (rowNum + 1) & "Method", row.Item("DxMethod").ToString)
                pdfFormFields.SetField("DxBrain" & (rowNum + 1), row.Item("Brain Related").ToString)
                rowNum += 1
            End While

            'set more records checkbox
            If rowNum = 51 Then
                pdfFormFields.SetField("DxMoreRecords", "1")
            End If

            'Free up system memory by removing tables
            formTables.Tables.Remove("viewDiagnoses")
        End If
    End Sub
    Private Sub fillPDFMedications()
        If Database.ExistingRecordCheck("Medications", "SubNum = " & WarehouseShell.SubNum) Then
            'Grab requisite tables
            formTables.Tables.Add(Database.ReturnTable("viewMedications", "top(52) *", "SubNum = " & WarehouseShell.SubNum, "DateStarted desc"))

            'Set table of values
            Dim rowNum As Integer = 0
            While rowNum < 51 And rowNum < formTables.Tables("viewMedications").Rows().Count()
                Dim row As DataRow = formTables.Tables("viewMedications").Rows(rowNum)
                pdfFormFields.SetField("Med" & (rowNum + 1) & "BrandName", Replace(row.Item("BrandName").ToString, "'", ""))
                pdfFormFields.SetField("Med" & (rowNum + 1) & "GenericName", Replace(row.Item("GenericName").ToString, "'", ""))
                pdfFormFields.SetField("Med" & (rowNum + 1) & "DailyDosage", row.Item("TotalDailyDosage").ToString)
                pdfFormFields.SetField("Med" & (rowNum + 1) & "Route", row.Item("Route").ToString)
                If Not row.IsNull("DateStarted") Then
                    pdfFormFields.SetField("Med" & (rowNum + 1) & "Started", Format(row.Item("DateStarted"), "MM/dd/yyyy"))
                End If
                'If IsDBNull(formTables.Tables("viewMedications").Rows(rowNum).Item("DateStarted")) Then
                '    pdfFormFields.SetField("Med" & (rowNum + 1) & "Started", "")
                'Else
                '    pdfFormFields.SetField("Med" & (rowNum + 1) & "Started", Format(formTables.Tables("viewMedications").Rows(rowNum).Item("DateStarted"), "MM/dd/yyyy"))
                'End If
                If Not row.IsNull("DateEnded") Then
                    pdfFormFields.SetField("Med" & (rowNum + 1) & "Ended", Format(row.Item("DateEnded"), "MM/dd/yyyy"))
                End If
                'If IsDBNull(formTables.Tables("viewMedications").Rows(rowNum).Item("DateEnded")) Then
                '    pdfFormFields.SetField("Med" & (rowNum + 1) & "Ended", "")
                'Else
                '    pdfFormFields.SetField("Med" & (rowNum + 1) & "Ended", Format(formTables.Tables("viewMedications").Rows(rowNum).Item("DateEnded"), "MM/dd/yyyy"))
                'End If
                rowNum += 1
            End While

            'set more records checkbox
            If rowNum = 51 Then
                pdfFormFields.SetField("MedMoreRecords", "1")
            End If

            'Free up system memory by removing tables
            formTables.Tables.Remove("viewMedications")
        End If
    End Sub
    Private Sub fillPDFCVD()
        If Database.ExistingRecordCheck("PMCR_CVD", "SubNum = " & WarehouseShell.SubNum) Then
            'Grab requisite tables
            formTables.Tables.Add(Database.ReturnTable("viewPMCR_CVD", , "SubNum = " & WarehouseShell.SubNum))

            'Set non-PHI values
            pdfFormFields.SetField("CVDHyper", formTables.Tables("viewPMCR_CVD").Rows(0).Item("HypertensionLabel").ToString)
            pdfFormFields.SetField("CVDHyperDate", returnFormattedDate("viewPMCR_CVD", "HypertensionDate"))
            pdfFormFields.SetField("CVDMyo", formTables.Tables("viewPMCR_CVD").Rows(0).Item("MyocardInfarctLabel").ToString)
            pdfFormFields.SetField("CVDMyoDate", returnFormattedDate("viewPMCR_CVD", "MyocardInfarctDate"))
            pdfFormFields.SetField("CVDAtrial", formTables.Tables("viewPMCR_CVD").Rows(0).Item("AtrialFibrillationLabel").ToString)
            pdfFormFields.SetField("CVDAtrialDate", returnFormattedDate("viewPMCR_CVD", "AtrialFibrillationDate"))
            pdfFormFields.SetField("CVDAngina", formTables.Tables("viewPMCR_CVD").Rows(0).Item("AnginaLabel").ToString)
            pdfFormFields.SetField("CVDAnginaDate", returnFormattedDate("viewPMCR_CVD", "AnginaDate"))
            pdfFormFields.SetField("CVDCardio", formTables.Tables("viewPMCR_CVD").Rows(0).Item("CardiomegalyLabel").ToString)
            pdfFormFields.SetField("CVDCardioDate", returnFormattedDate("viewPMCR_CVD", "CardiomegalyDate"))
            pdfFormFields.SetField("CVDCoag", formTables.Tables("viewPMCR_CVD").Rows(0).Item("CoagulopathyLabel").ToString)
            pdfFormFields.SetField("CVDCoagDate", returnFormattedDate("viewPMCR_CVD", "CoagulopathyDate"))
            pdfFormFields.SetField("CVD_PVD", formTables.Tables("viewPMCR_CVD").Rows(0).Item("PVDLabel").ToString)
            pdfFormFields.SetField("CVD_PVDDate", returnFormattedDate("viewPMCR_CVD", "PVDDate"))
            pdfFormFields.SetField("CVD_ASHD", formTables.Tables("viewPMCR_CVD").Rows(0).Item("ASHDLabel").ToString)
            pdfFormFields.SetField("CVD_ASHDDate", returnFormattedDate("viewPMCR_CVD", "ASHDDate"))
            pdfFormFields.SetField("CVD_CHF", formTables.Tables("viewPMCR_CVD").Rows(0).Item("CongHeartFailLabel").ToString)
            pdfFormFields.SetField("CVD_CHFDate", returnFormattedDate("viewPMCR_CVD", "CongHeartFailDate"))
            pdfFormFields.SetField("CVDOthArrh", formTables.Tables("viewPMCR_CVD").Rows(0).Item("OtherArrhythmiaLabel").ToString)
            pdfFormFields.SetField("CVDOthArrhDate", returnFormattedDate("viewPMCR_CVD", "OtherArrhythmiaDate"))
            pdfFormFields.SetField("CVDValv", formTables.Tables("viewPMCR_CVD").Rows(0).Item("ValvularLabel").ToString)
            pdfFormFields.SetField("CVDValvDate", returnFormattedDate("viewPMCR_CVD", "ValvularDate"))
            pdfFormFields.SetField("CVDDiabetes", formTables.Tables("viewPMCR_CVD").Rows(0).Item("DiabetesLabel").ToString)
            pdfFormFields.SetField("CVDDiabetesDate", returnFormattedDate("viewPMCR_CVD", "DiabetesDate"))
            pdfFormFields.SetField("CVD_COPD", formTables.Tables("viewPMCR_CVD").Rows(0).Item("COPDAsthmaLabel").ToString)
            pdfFormFields.SetField("CVD_COPDDate", returnFormattedDate("viewPMCR_CVD", "COPDAsthmaDate"))
            pdfFormFields.SetField("CVDCarot", formTables.Tables("viewPMCR_CVD").Rows(0).Item("CarotidBruitLabel").ToString)
            pdfFormFields.SetField("CVDCarotDate", returnFormattedDate("viewPMCR_CVD", "CarotidBruitDate"))
            pdfFormFields.SetField("CVDSync", formTables.Tables("viewPMCR_CVD").Rows(0).Item("SyncopalEpiLabel").ToString)
            pdfFormFields.SetField("CVDSyncDate", returnFormattedDate("viewPMCR_CVD", "SyncopalEpiDate"))
            pdfFormFields.SetField("CVDBrainHemo", formTables.Tables("viewPMCR_CVD").Rows(0).Item("BrainHemoLabel").ToString)
            pdfFormFields.SetField("CVDBrainHemoDate", returnFormattedDate("viewPMCR_CVD", "BrainHemoDate"))
            pdfFormFields.SetField("CVDMajHypox", formTables.Tables("viewPMCR_CVD").Rows(0).Item("MajHypoxicEventLabel").ToString)
            pdfFormFields.SetField("CVDMajHypoxDate", returnFormattedDate("viewPMCR_CVD", "MajHypoxicEventDate"))
            pdfFormFields.SetField("CVDParaFace", formTables.Tables("viewPMCR_CVD").Rows(0).Item("ParalysisFaceLabel").ToString)
            pdfFormFields.SetField("CVDParaFaceDate", returnFormattedDate("viewPMCR_CVD", "ParalysisFaceDate"))
            pdfFormFields.SetField("CVDVisField", formTables.Tables("viewPMCR_CVD").Rows(0).Item("VisFieldDefecitLabel").ToString)
            pdfFormFields.SetField("CVDVisFieldDate", returnFormattedDate("viewPMCR_CVD", "VisFieldDefecitDate"))
            pdfFormFields.SetField("CVDSensDef", formTables.Tables("viewPMCR_CVD").Rows(0).Item("ClinEviSensoryDefecitLabel").ToString)
            pdfFormFields.SetField("CVDSensDefDate", returnFormattedDate("viewPMCR_CVD", "ClinEviSensoryDefecitDate"))
            pdfFormFields.SetField("CVDRecAph", formTables.Tables("viewPMCR_CVD").Rows(0).Item("ReceptiveAphasiaLabel").ToString)
            pdfFormFields.SetField("CVDRecAphDate", returnFormattedDate("viewPMCR_CVD", "ReceptiveAphasiaDate"))
            pdfFormFields.SetField("CVD_CVA", formTables.Tables("viewPMCR_CVD").Rows(0).Item("ClinHxCVALabel").ToString)
            pdfFormFields.SetField("CVD_CVADate", returnFormattedDate("viewPMCR_CVD", "ClinHxCVADate"))
            pdfFormFields.SetField("CVD_CVASpec", formTables.Tables("viewPMCR_CVD").Rows(0).Item("ClinHxCVANote").ToString)
            pdfFormFields.SetField("CVDParaLimb", formTables.Tables("viewPMCR_CVD").Rows(0).Item("ParalysisLimbTrunkLabel").ToString)
            pdfFormFields.SetField("CVDParaLimbDate", returnFormattedDate("viewPMCR_CVD", "ParalysisLimbTrunkDate"))
            pdfFormFields.SetField("CVDExpAph", formTables.Tables("viewPMCR_CVD").Rows(0).Item("ExpressiveAphasiaLabel").ToString)
            pdfFormFields.SetField("CVDExpAphDate", returnFormattedDate("viewPMCR_CVD", "ExpressiveAphasiaDate"))
            pdfFormFields.SetField("CVDAtaxia", formTables.Tables("viewPMCR_CVD").Rows(0).Item("AtaxiaLimbTrunkLabel").ToString)
            pdfFormFields.SetField("CVDAtaxiaDate", returnFormattedDate("viewPMCR_CVD", "AtaxiaLimbTrunkDate"))
            pdfFormFields.SetField("CVDGait", formTables.Tables("viewPMCR_CVD").Rows(0).Item("GaitDisorderLabel").ToString)
            pdfFormFields.SetField("CVDGaitDate", returnFormattedDate("viewPMCR_CVD", "GaitDisorderDate"))
            pdfFormFields.SetField("CVDGaitSpec", formTables.Tables("viewPMCR_CVD").Rows(0).Item("GaitDisorderNote").ToString)
            pdfFormFields.SetField("CVDRigid", formTables.Tables("viewPMCR_CVD").Rows(0).Item("ischemicRigidityLabel").ToString)
            pdfFormFields.SetField("CVDRigidDate", returnFormattedDate("viewPMCR_CVD", "ischemicRigidityDate"))
            pdfFormFields.SetField("CVDOthNonFoc", formTables.Tables("viewPMCR_CVD").Rows(0).Item("IschemicOtherLabel").ToString)
            pdfFormFields.SetField("CVDOthNonFocDate", returnFormattedDate("viewPMCR_CVD", "IschemicOtherDate"))
            pdfFormFields.SetField("CVDOthNonFocSpec", formTables.Tables("viewPMCR_CVD").Rows(0).Item("IschemicOtherNote").ToString)
            pdfFormFields.SetField("CVDDysarth", formTables.Tables("viewPMCR_CVD").Rows(0).Item("DysarthiaLabel").ToString)
            pdfFormFields.SetField("CVDDysarthDate", returnFormattedDate("viewPMCR_CVD", "DysarthiaDate"))
            pdfFormFields.SetField("CVDPsychoRetard", formTables.Tables("viewPMCR_CVD").Rows(0).Item("PsychoRetardLabel").ToString)
            pdfFormFields.SetField("CVDPsychoRetardDate", returnFormattedDate("viewPMCR_CVD", "PsychoRetardDate"))
            pdfFormFields.SetField("CVDDiffSwal", formTables.Tables("viewPMCR_CVD").Rows(0).Item("DiffSwallowingLabel").ToString)
            pdfFormFields.SetField("CVDDiffSwalDate", returnFormattedDate("viewPMCR_CVD", "DiffSwallowingDate"))
            pdfFormFields.SetField("CVDNeuroNorm", formTables.Tables("viewPMCR_CVD").Rows(0).Item("NeuroNormalLabel").ToString)
            pdfFormFields.SetField("CVDNeuroNormDate", returnFormattedDate("viewPMCR_CVD", "NeuroNormalDate"))
            pdfFormFields.SetField("CVDIncTone", formTables.Tables("viewPMCR_CVD").Rows(0).Item("IncToneLabel").ToString)
            pdfFormFields.SetField("CVDIncToneDate", returnFormattedDate("viewPMCR_CVD", "IncToneDate"))
            pdfFormFields.SetField("CVDNaso", formTables.Tables("viewPMCR_CVD").Rows(0).Item("NasolabialLabel").ToString)
            pdfFormFields.SetField("CVDNasoDate", returnFormattedDate("viewPMCR_CVD", "NasolabialDate"))
            pdfFormFields.SetField("CVDWeak", formTables.Tables("viewPMCR_CVD").Rows(0).Item("ParaCentralLabel").ToString)
            pdfFormFields.SetField("CVDWeakDate", returnFormattedDate("viewPMCR_CVD", "ParaCentralDate"))
            pdfFormFields.SetField("CVDBab", formTables.Tables("viewPMCR_CVD").Rows(0).Item("BabinskiLabel").ToString)
            pdfFormFields.SetField("CVDBabDate", returnFormattedDate("viewPMCR_CVD", "BabinskiDate"))
            pdfFormFields.SetField("CVDNeuroOth", formTables.Tables("viewPMCR_CVD").Rows(0).Item("NeuroOtherLabel").ToString)
            pdfFormFields.SetField("CVDNeuroOthDate", returnFormattedDate("viewPMCR_CVD", "NeuroOtherDate"))
            pdfFormFields.SetField("CVDNeuroOthSpec", formTables.Tables("viewPMCR_CVD").Rows(0).Item("NeuroOtherNote").ToString)
            pdfFormFields.SetField("CVDExtra", formTables.Tables("viewPMCR_CVD").Rows(0).Item("ExtrapyramidalLabel").ToString)
            pdfFormFields.SetField("CVDExtraDate", returnFormattedDate("viewPMCR_CVD", "ExtrapyramidalDate"))
            pdfFormFields.SetField("CVDTremor", formTables.Tables("viewPMCR_CVD").Rows(0).Item("TremorLabel").ToString)
            pdfFormFields.SetField("CVDTremorDate", returnFormattedDate("viewPMCR_CVD", "TremorDate"))
            pdfFormFields.SetField("CVDMotor", formTables.Tables("viewPMCR_CVD").Rows(0).Item("MotorSpeechImpLabel").ToString)
            pdfFormFields.SetField("CVDMotorDate", returnFormattedDate("viewPMCR_CVD", "MotorSpeechImpDate"))
            pdfFormFields.SetField("CVDSens", formTables.Tables("viewPMCR_CVD").Rows(0).Item("NeuroSensoryDefecitLabel").ToString)
            pdfFormFields.SetField("CVDSensDate", returnFormattedDate("viewPMCR_CVD", "NeuroSensoryDefecitDate"))
            pdfFormFields.SetField("CVDFront", formTables.Tables("viewPMCR_CVD").Rows(0).Item("FrontReleaseReflLabel").ToString)
            pdfFormFields.SetField("CVDFrontDate", returnFormattedDate("viewPMCR_CVD", "FrontReleaseReflDate"))
            pdfFormFields.SetField("CVDSomatic", formTables.Tables("viewPMCR_CVD").Rows(0).Item("SomaticComplaintsLabel").ToString)
            pdfFormFields.SetField("CVDSomaticDate", returnFormattedDate("viewPMCR_CVD", "SomaticComplaintsDate"))
            pdfFormFields.SetField("CVDSomaticSpec", formTables.Tables("viewPMCR_CVD").Rows(0).Item("SomaticComplaintsNote").ToString)
            pdfFormFields.SetField("CVDInf", formTables.Tables("viewPMCR_CVD").Rows(0).Item("InfarctLabel").ToString)
            pdfFormFields.SetField("CVDInfDate", returnFormattedDate("viewPMCR_CVD", "InfarctDate"))
            pdfFormFields.SetField("CVDPark", formTables.Tables("viewPMCR_CVD").Rows(0).Item("ParkinsonsLabel").ToString)
            pdfFormFields.SetField("CVDParkDate", returnFormattedDate("viewPMCR_CVD", "ParkinsonsDate"))
            pdfFormFields.SetField("CVDAlc", formTables.Tables("viewPMCR_CVD").Rows(0).Item("AlcoholismLabel").ToString)
            pdfFormFields.SetField("CVDAlcDate", returnFormattedDate("viewPMCR_CVD", "AlcoholismDate"))
            pdfFormFields.SetField("CVDCJD", formTables.Tables("viewPMCR_CVD").Rows(0).Item("CJDLabel").ToString)
            pdfFormFields.SetField("CVDCJDDate", returnFormattedDate("viewPMCR_CVD", "CJDDate"))
            pdfFormFields.SetField("CVDHypox", formTables.Tables("viewPMCR_CVD").Rows(0).Item("HypoxicEpisodeLabel").ToString)
            pdfFormFields.SetField("CVDHypoxDate", returnFormattedDate("viewPMCR_CVD", "HypoxicEpisodeDate"))
            pdfFormFields.SetField("CVDNPH", formTables.Tables("viewPMCR_CVD").Rows(0).Item("NPHLabel").ToString)
            pdfFormFields.SetField("CVDNPHDate", returnFormattedDate("viewPMCR_CVD", "NPHDate"))
            pdfFormFields.SetField("CVDPick", formTables.Tables("viewPMCR_CVD").Rows(0).Item("PicksLabel").ToString)
            pdfFormFields.SetField("CVDPickDate", returnFormattedDate("viewPMCR_CVD", "PicksDate"))
            pdfFormFields.SetField("CVDHunt", formTables.Tables("viewPMCR_CVD").Rows(0).Item("HuntingtonsLabel").ToString)
            pdfFormFields.SetField("CVDHuntDate", returnFormattedDate("viewPMCR_CVD", "HuntingtonsDate"))
            pdfFormFields.SetField("CVDMajAff", formTables.Tables("viewPMCR_CVD").Rows(0).Item("MajAffDisorderLabel").ToString)
            pdfFormFields.SetField("CVDMajAffDate", returnFormattedDate("viewPMCR_CVD", "MajAffDisorderDate"))
            pdfFormFields.SetField("CVDHeadTrauma", formTables.Tables("viewPMCR_CVD").Rows(0).Item("HeadTraumaLabel").ToString)
            pdfFormFields.SetField("CVDHeadTraumaDate", returnFormattedDate("viewPMCR_CVD", "HeadTraumaDate"))
            pdfFormFields.SetField("CVDSeiz", formTables.Tables("viewPMCR_CVD").Rows(0).Item("SeizuresLabel").ToString)
            pdfFormFields.SetField("CVDSeizDate", returnFormattedDate("viewPMCR_CVD", "SeizuresDate"))
            pdfFormFields.SetField("CVDTumor", formTables.Tables("viewPMCR_CVD").Rows(0).Item("BrainTumorLabel").ToString)
            pdfFormFields.SetField("CVDTumorDate", returnFormattedDate("viewPMCR_CVD", "BrainTumorDate"))
            pdfFormFields.SetField("CVDSchiz", formTables.Tables("viewPMCR_CVD").Rows(0).Item("SchizoLabel").ToString)
            pdfFormFields.SetField("CVDSchizDate", returnFormattedDate("viewPMCR_CVD", "SchizoDate"))
            pdfFormFields.SetField("CVDThyroid", formTables.Tables("viewPMCR_CVD").Rows(0).Item("ThyroidDisorderLabel").ToString)
            pdfFormFields.SetField("CVDThyroidDate", returnFormattedDate("viewPMCR_CVD", "ThyroidDisorderDate"))
            pdfFormFields.SetField("CVDThyroidSpec", formTables.Tables("viewPMCR_CVD").Rows(0).Item("ThyroidDisorderNote").ToString)
            pdfFormFields.SetField("CVDCancer", formTables.Tables("viewPMCR_CVD").Rows(0).Item("CancerLabel").ToString)
            pdfFormFields.SetField("CVDCancerDate", returnFormattedDate("viewPMCR_CVD", "CancerDate"))
            pdfFormFields.SetField("CVDCancerSpec", formTables.Tables("viewPMCR_CVD").Rows(0).Item("CancerNote").ToString)
            pdfFormFields.SetField("CVDB12", formTables.Tables("viewPMCR_CVD").Rows(0).Item("B12Label").ToString)
            pdfFormFields.SetField("CVDB12Date", returnFormattedDate("viewPMCR_CVD", "B12Date"))
            pdfFormFields.SetField("CVDB12Spec", formTables.Tables("viewPMCR_CVD").Rows(0).Item("B12Note").ToString)
            pdfFormFields.SetField("CVDOthOth", formTables.Tables("viewPMCR_CVD").Rows(0).Item("OtherOtherLabel").ToString)
            pdfFormFields.SetField("CVDOthOthDate", returnFormattedDate("viewPMCR_CVD", "OtherOtherDate"))
            pdfFormFields.SetField("CVDOthOthSpec", formTables.Tables("viewPMCR_CVD").Rows(0).Item("OtherOtherNote").ToString)
            pdfFormFields.SetField("CVDCat", formTables.Tables("viewPMCR_CVD").Rows(0).Item("CATLabel").ToString)
            pdfFormFields.SetField("CVDCatDate", returnFormattedDate("viewPMCR_CVD", "CATDate"))
            pdfFormFields.SetField("CVDCatSpec", formTables.Tables("viewPMCR_CVD").Rows(0).Item("CATNote").ToString)
            pdfFormFields.SetField("CVDMri", formTables.Tables("viewPMCR_CVD").Rows(0).Item("MRILabel").ToString)
            pdfFormFields.SetField("CVDMriDate", returnFormattedDate("viewPMCR_CVD", "MRIDate"))
            pdfFormFields.SetField("CVDMriSpec", formTables.Tables("viewPMCR_CVD").Rows(0).Item("MRINote").ToString)

            'Free up system memory by removing tables
            formTables.Tables.Remove("viewPMCR_CVD")
        End If
    End Sub
    Private Sub fillPDFHachinski()
        If Database.ExistingRecordCheck("PMCR_Hachinski", "SubNum = " & WarehouseShell.SubNum) Then
            'Grab requisite tables
            formTables.Tables.Add(Database.ReturnTable("PMCR_Hachinski", , "SubNum = " & WarehouseShell.SubNum))

            'Set non-PHI values
            pdfFormFields.SetField("HachAbrupt", formTables.Tables("PMCR_Hachinski").Rows(0).Item("AbruptOnset").ToString)
            pdfFormFields.SetField("HachStep", formTables.Tables("PMCR_Hachinski").Rows(0).Item("StepWise").ToString)
            pdfFormFields.SetField("HachFluct", formTables.Tables("PMCR_Hachinski").Rows(0).Item("FluctCourse").ToString)
            pdfFormFields.SetField("HachNoc", formTables.Tables("PMCR_Hachinski").Rows(0).Item("NocturConf").ToString)
            pdfFormFields.SetField("HachRel", formTables.Tables("PMCR_Hachinski").Rows(0).Item("RelPreservPerson").ToString)
            pdfFormFields.SetField("HachDep", formTables.Tables("PMCR_Hachinski").Rows(0).Item("Depression").ToString)
            pdfFormFields.SetField("HachSomatic", formTables.Tables("PMCR_Hachinski").Rows(0).Item("SomaticComplaint").ToString)
            pdfFormFields.SetField("HachEmo", formTables.Tables("PMCR_Hachinski").Rows(0).Item("EmotIncont").ToString)
            pdfFormFields.SetField("HachHyper", formTables.Tables("PMCR_Hachinski").Rows(0).Item("HxHypertension").ToString)
            pdfFormFields.SetField("HachStroke", formTables.Tables("PMCR_Hachinski").Rows(0).Item("HxStrokes").ToString)
            pdfFormFields.SetField("HachAther", formTables.Tables("PMCR_Hachinski").Rows(0).Item("EvidAssocAtherosclerosis").ToString)
            pdfFormFields.SetField("HachFocNeuroSympt", formTables.Tables("PMCR_Hachinski").Rows(0).Item("FocalNeuroSympt").ToString)
            pdfFormFields.SetField("HachFocNeuroSign", formTables.Tables("PMCR_Hachinski").Rows(0).Item("FocalNeuroSigns").ToString)
            pdfFormFields.SetField("HachTotal", formTables.Tables("PMCR_Hachinski").Rows(0).Item("Total").ToString)

            'Free up system memory by removing tables
            formTables.Tables.Remove("PMCR_Hachinski")
        End If
    End Sub
    Private Sub fillPDFDepression()
        If Database.ExistingRecordCheck("PMCR_Depression", "SubNum = " & WarehouseShell.SubNum) Then
            'Grab requisite tables
            formTables.Tables.Add(Database.ReturnTable("viewPMCR_Depression", , "SubNum = " & WarehouseShell.SubNum))

            'Set non-PHI values
            pdfFormFields.SetField("DepMoodCur", formTables.Tables("viewPMCR_Depression").Rows(0).Item("MoodDysphCurLabel").ToString)
            pdfFormFields.SetField("DepMoodCurDate", returnFormattedDate("viewPMCR_Depression", "MoodDysphorCurDate"))
            pdfFormFields.SetField("DepMoodHx", formTables.Tables("viewPMCR_Depression").Rows(0).Item("MoodDysphorHxLabel").ToString)
            pdfFormFields.SetField("DepMoodHxDate", returnFormattedDate("viewPMCR_Depression", "MoodDysphorHxDate"))
            pdfFormFields.SetField("DepDecIntCur", formTables.Tables("viewPMCR_Depression").Rows(0).Item("DecInterestCurLabel").ToString)
            pdfFormFields.SetField("DepDecIntCurDate", returnFormattedDate("viewPMCR_Depression", "DecInterestCurDate"))
            pdfFormFields.SetField("DepDecIntHx", formTables.Tables("viewPMCR_Depression").Rows(0).Item("DecInterestHxLabel").ToString)
            pdfFormFields.SetField("DepDecIntHxDate", returnFormattedDate("viewPMCR_Depression", "DecInterestHxDate"))
            pdfFormFields.SetField("DepWtLossCur", formTables.Tables("viewPMCR_Depression").Rows(0).Item("WeightLossCurLabel").ToString)
            pdfFormFields.SetField("DepWtLossCurDate", returnFormattedDate("viewPMCR_Depression", "WeightLossCurDate"))
            pdfFormFields.SetField("DepWtLossHx", formTables.Tables("viewPMCR_Depression").Rows(0).Item("WeightLossHxLabel").ToString)
            pdfFormFields.SetField("DepWtLossHxDate", returnFormattedDate("viewPMCR_Depression", "WeightLossHxDate"))
            pdfFormFields.SetField("DepDecAppCur", formTables.Tables("viewPMCR_Depression").Rows(0).Item("DecAppetiteCurLabel").ToString)
            pdfFormFields.SetField("DepDecAppCurDate", returnFormattedDate("viewPMCR_Depression", "DecAppetiteCurDate"))
            pdfFormFields.SetField("DepDecAppHx", formTables.Tables("viewPMCR_Depression").Rows(0).Item("DecAppetiteHxLabel").ToString)
            pdfFormFields.SetField("DepDecAppHxDate", returnFormattedDate("viewPMCR_Depression", "DecAppetiteHxDate"))
            pdfFormFields.SetField("DepWtGainCur", formTables.Tables("viewPMCR_Depression").Rows(0).Item("WeightGainCurLabel").ToString)
            pdfFormFields.SetField("DepWtGainCurDate", returnFormattedDate("viewPMCR_Depression", "WeightGainCurDate"))
            pdfFormFields.SetField("DepWtGainHx", formTables.Tables("viewPMCR_Depression").Rows(0).Item("WeightGainHxLabel").ToString)
            pdfFormFields.SetField("DepWtGainHxDate", returnFormattedDate("viewPMCR_Depression", "WeightGainHxDate"))
            pdfFormFields.SetField("DepEarlyInsomCur", formTables.Tables("viewPMCR_Depression").Rows(0).Item("EarlyInsomCurLabel").ToString)
            pdfFormFields.SetField("DepEarlyInsomCurDate", returnFormattedDate("viewPMCR_Depression", "EarlyInsomCurDate"))
            pdfFormFields.SetField("DepEarlyInsomHx", formTables.Tables("viewPMCR_Depression").Rows(0).Item("EarlyInsomHxLabel").ToString)
            pdfFormFields.SetField("DepEarlyInsomHxDate", returnFormattedDate("viewPMCR_Depression", "EarlyInsomHxDate"))
            pdfFormFields.SetField("DepMidInsomCur", formTables.Tables("viewPMCR_Depression").Rows(0).Item("MidInsomCurLabel").ToString)
            pdfFormFields.SetField("DepMidInsomCurDate", returnFormattedDate("viewPMCR_Depression", "MidInsomCurDate"))
            pdfFormFields.SetField("DepMidInsomHx", formTables.Tables("viewPMCR_Depression").Rows(0).Item("MidInsomHxLabel").ToString)
            pdfFormFields.SetField("DepMidInsomHxDate", returnFormattedDate("viewPMCR_Depression", "MidInsomHxDate"))
            pdfFormFields.SetField("DepLateInsomCur", formTables.Tables("viewPMCR_Depression").Rows(0).Item("LateInsomCurLabel").ToString)
            pdfFormFields.SetField("DepLateInsomCurDate", returnFormattedDate("viewPMCR_Depression", "LateInsomCurDate"))
            pdfFormFields.SetField("DepLateInsomHx", formTables.Tables("viewPMCR_Depression").Rows(0).Item("LateInsomHxLabel").ToString)
            pdfFormFields.SetField("DepLateInsomHxDate", returnFormattedDate("viewPMCR_Depression", "LateInsomHxDate"))
            pdfFormFields.SetField("DepHyperCur", formTables.Tables("viewPMCR_Depression").Rows(0).Item("HypersomniaCurLabel").ToString)
            pdfFormFields.SetField("DepHyperCurDate", returnFormattedDate("viewPMCR_Depression", "HypersomniaCurDate"))
            pdfFormFields.SetField("DepHyperHx", formTables.Tables("viewPMCR_Depression").Rows(0).Item("HypersomniaHxLabel").ToString)
            pdfFormFields.SetField("DepHyperHxDate", returnFormattedDate("viewPMCR_Depression", "HypersomniaHxDate"))
            pdfFormFields.SetField("DepPsychoAgiCur", formTables.Tables("viewPMCR_Depression").Rows(0).Item("PsychoAgitationCurLabel").ToString)
            pdfFormFields.SetField("DepPsychoAgiCurDate", returnFormattedDate("viewPMCR_Depression", "PsychoAgitationCurDate"))
            pdfFormFields.SetField("DepPsychoAgiHx", formTables.Tables("viewPMCR_Depression").Rows(0).Item("PsychoAgitationHxLabel").ToString)
            pdfFormFields.SetField("DepPsychoAgiHxDate", returnFormattedDate("viewPMCR_Depression", "PsychoAgitationHxDate"))
            pdfFormFields.SetField("DepPsychoRetCur", formTables.Tables("viewPMCR_Depression").Rows(0).Item("PsychoRetardCurLabel").ToString)
            pdfFormFields.SetField("DepPsychoRetCurDate", returnFormattedDate("viewPMCR_Depression", "PsychoRetardCurDate"))
            pdfFormFields.SetField("DepPsychoRetHx", formTables.Tables("viewPMCR_Depression").Rows(0).Item("PsychoRetardHxLabel").ToString)
            pdfFormFields.SetField("DepPsychoRetCurHxDate", returnFormattedDate("viewPMCR_Depression", "PsychoRetardHxDate"))
            pdfFormFields.SetField("DepFatCur", formTables.Tables("viewPMCR_Depression").Rows(0).Item("FatigueCurLabel").ToString)
            pdfFormFields.SetField("DepFatCurDate", returnFormattedDate("viewPMCR_Depression", "FatigueCurDate"))
            pdfFormFields.SetField("DepFatHx", formTables.Tables("viewPMCR_Depression").Rows(0).Item("FatigueHxLabel").ToString)
            pdfFormFields.SetField("DepFatHxDate", returnFormattedDate("viewPMCR_Depression", "FatigueHxDate"))
            pdfFormFields.SetField("DepSinCur", formTables.Tables("viewPMCR_Depression").Rows(0).Item("WorthlessCurLabel").ToString)
            pdfFormFields.SetField("DepSinCurDate", returnFormattedDate("viewPMCR_Depression", "WorthlessCurDate"))
            pdfFormFields.SetField("DepSinHx", formTables.Tables("viewPMCR_Depression").Rows(0).Item("WorthlessHxLabel").ToString)
            pdfFormFields.SetField("DepSinHxDate", returnFormattedDate("viewPMCR_Depression", "WorthlessHxDate"))
            pdfFormFields.SetField("DepDelCur", formTables.Tables("viewPMCR_Depression").Rows(0).Item("DelusionCurLabel").ToString)
            pdfFormFields.SetField("DepDelCurDate", returnFormattedDate("viewPMCR_Depression", "DelusionCurDate"))
            pdfFormFields.SetField("DepDelHx", formTables.Tables("viewPMCR_Depression").Rows(0).Item("DelusionHxLabel").ToString)
            pdfFormFields.SetField("DepDelHxDate", returnFormattedDate("viewPMCR_Depression", "DelusionHxDate"))
            pdfFormFields.SetField("DepRumCur", formTables.Tables("viewPMCR_Depression").Rows(0).Item("RuminationsCurLabel").ToString)
            pdfFormFields.SetField("DepRumCurDate", returnFormattedDate("viewPMCR_Depression", "RuminationsCurDate"))
            pdfFormFields.SetField("DepRumHx", formTables.Tables("viewPMCR_Depression").Rows(0).Item("RuminationsHxLabel").ToString)
            pdfFormFields.SetField("DepRumHxDate", returnFormattedDate("viewPMCR_Depression", "RuminationsHxDate"))
            pdfFormFields.SetField("DepSuicCur", formTables.Tables("viewPMCR_Depression").Rows(0).Item("ThoughtDeathCurLabel").ToString)
            pdfFormFields.SetField("DepSuicCurDate", returnFormattedDate("viewPMCR_Depression", "ThoughtDeathCurDate"))
            pdfFormFields.SetField("DepSuicHx", formTables.Tables("viewPMCR_Depression").Rows(0).Item("ThoughtDeathHxLabel").ToString)
            pdfFormFields.SetField("DepSuicHxDate", returnFormattedDate("viewPMCR_Depression", "ThoughtDeathHxDate"))
            pdfFormFields.SetField("DepCur2WkCur", formTables.Tables("viewPMCR_Depression").Rows(0).Item("LastTwoWkCurLabel").ToString)
            pdfFormFields.SetField("DepCur2WkCurDate", returnFormattedDate("viewPMCR_Depression", "LastTwoWkCurDate"))
            pdfFormFields.SetField("DepCur2WkHx", formTables.Tables("viewPMCR_Depression").Rows(0).Item("LastTwoWkHxLabel").ToString)
            pdfFormFields.SetField("DepCur2WkHxDate", returnFormattedDate("viewPMCR_Depression", "LastTwoWkHxDate"))
            pdfFormFields.SetField("DepCont2WkCur", formTables.Tables("viewPMCR_Depression").Rows(0).Item("SixMoCurLabel").ToString)
            pdfFormFields.SetField("DepCont2WkCurDate", returnFormattedDate("viewPMCR_Depression", "SixMoCurDate"))
            pdfFormFields.SetField("DepCont2WkHx", formTables.Tables("viewPMCR_Depression").Rows(0).Item("SixMoHxLabel").ToString)
            pdfFormFields.SetField("DepCont2WkHxDate", returnFormattedDate("viewPMCR_Depression", "SixMoHxDate"))
            pdfFormFields.SetField("DepLifeDxCur", formTables.Tables("viewPMCR_Depression").Rows(0).Item("LifetimeCurLabel").ToString)
            pdfFormFields.SetField("DepLifeDxCurDate", returnFormattedDate("viewPMCR_Depression", "LifetimeCurDate"))
            pdfFormFields.SetField("DepLifeDxHx", formTables.Tables("viewPMCR_Depression").Rows(0).Item("LifetimeHxLabel").ToString)
            pdfFormFields.SetField("DepLifeDxHxDate", returnFormattedDate("viewPMCR_Depression", "LifetimeHxDate"))
            pdfFormFields.SetField("DepContDemCur", formTables.Tables("viewPMCR_Depression").Rows(0).Item("DepContDemCurLabel").ToString)
            pdfFormFields.SetField("DepContDemCurDate", returnFormattedDate("viewPMCR_Depression", "DepContDemCurDate"))
            pdfFormFields.SetField("DepContDemHx", formTables.Tables("viewPMCR_Depression").Rows(0).Item("DepContDemHxLabel").ToString)
            pdfFormFields.SetField("DepContDemHxDate", returnFormattedDate("viewPMCR_Depression", "DepContDemHxDate"))
            pdfFormFields.SetField("DepNotes", formTables.Tables("viewPMCR_Depression").Rows(0).Item("DepressionNote").ToString)

            'Free up system memory by removing tables
            formTables.Tables.Remove("viewPMCR_Depression")
        End If
    End Sub
    Private Sub fillPDFMCIRS()
        If Database.ExistingRecordCheck("PMCR_MCIRS", "SubNum = " & WarehouseShell.SubNum) Then
            'Grab requisite tables
            formTables.Tables.Add(Database.ReturnTable("viewPMCR_MCIRS", , "SubNum = " & WarehouseShell.SubNum))

            'Set non-PHI values
            pdfFormFields.SetField("MCIRSa", formTables.Tables("viewPMCR_MCIRS").Rows(0).Item("CardiacLabel").ToString)
            pdfFormFields.SetField("MCIRSb", formTables.Tables("viewPMCR_MCIRS").Rows(0).Item("HypertensionLabel").ToString)
            pdfFormFields.SetField("MCIRSc", formTables.Tables("viewPMCR_MCIRS").Rows(0).Item("VascularLabel").ToString)
            pdfFormFields.SetField("MCIRSd", formTables.Tables("viewPMCR_MCIRS").Rows(0).Item("RespiratoryLabel").ToString)
            pdfFormFields.SetField("MCIRSe", formTables.Tables("viewPMCR_MCIRS").Rows(0).Item("EENTLabel").ToString)
            pdfFormFields.SetField("MCIRSf", formTables.Tables("viewPMCR_MCIRS").Rows(0).Item("UpperGILabel").ToString)
            pdfFormFields.SetField("MCIRSg", formTables.Tables("viewPMCR_MCIRS").Rows(0).Item("LowerGILabel").ToString)
            pdfFormFields.SetField("MCIRSh", formTables.Tables("viewPMCR_MCIRS").Rows(0).Item("HepaticLabel").ToString)
            pdfFormFields.SetField("MCIRSi", formTables.Tables("viewPMCR_MCIRS").Rows(0).Item("RenalLabel").ToString)
            pdfFormFields.SetField("MCIRSj", formTables.Tables("viewPMCR_MCIRS").Rows(0).Item("OtherGULabel").ToString)
            pdfFormFields.SetField("MCIRSk", formTables.Tables("viewPMCR_MCIRS").Rows(0).Item("MusculoSkeletalLabel").ToString)
            pdfFormFields.SetField("MCIRSl", formTables.Tables("viewPMCR_MCIRS").Rows(0).Item("NeurologicalLabel").ToString)
            pdfFormFields.SetField("MCIRSm", formTables.Tables("viewPMCR_MCIRS").Rows(0).Item("EndocrineMetabolicLabel").ToString)
            pdfFormFields.SetField("MCIRSn", formTables.Tables("viewPMCR_MCIRS").Rows(0).Item("PsychBehavioralLabel").ToString)
            pdfFormFields.SetField("MCIRSTotal", formTables.Tables("viewPMCR_MCIRS").Rows(0).Item("TotalScore").ToString)

            'Free up system memory by removing tables
            formTables.Tables.Remove("viewPMCR_MCIRS")
        End If
    End Sub
    Private Sub fillPDFCDR()
        If Database.ExistingRecordCheck("viewCDR", "SubNum = " & WarehouseShell.SubNum & " and VisitValue = 888") Then
            'Grab requisite tables
            formTables.Tables.Add(Database.ReturnTable("viewCDR", , "SubNum = " & WarehouseShell.SubNum & " and VisitValue = 888"))

            'Set non-PHI values
            pdfFormFields.SetField("CDRMemScore", formTables.Tables("viewCDR").Rows(0).Item("MemoryScore").ToString)
            pdfFormFields.SetField("CDRMemReason", formTables.Tables("viewCDR").Rows(0).Item("MemoryReasonLabel").ToString)
            pdfFormFields.SetField("CDROrientScore", formTables.Tables("viewCDR").Rows(0).Item("OrientationScore").ToString)
            pdfFormFields.SetField("CDROrientReason", formTables.Tables("viewCDR").Rows(0).Item("OrientationReasonLabel").ToString)
            pdfFormFields.SetField("CDRJudgeScore", formTables.Tables("viewCDR").Rows(0).Item("JudgeProbScore").ToString)
            pdfFormFields.SetField("CDRJudgeReason", formTables.Tables("viewCDR").Rows(0).Item("JudgeProbReasonLabel").ToString)
            pdfFormFields.SetField("CDRCommScore", formTables.Tables("viewCDR").Rows(0).Item("CommAffairsScore").ToString)
            pdfFormFields.SetField("CDRCommReason", formTables.Tables("viewCDR").Rows(0).Item("CommAffairsReasonLabel").ToString)
            pdfFormFields.SetField("CDRHomeScore", formTables.Tables("viewCDR").Rows(0).Item("HomeHobbyScore").ToString)
            pdfFormFields.SetField("CDRHomeReason", formTables.Tables("viewCDR").Rows(0).Item("HomeHobbyReasonLabel").ToString)
            pdfFormFields.SetField("CDRPersScore", formTables.Tables("viewCDR").Rows(0).Item("PersonalCareScore").ToString)
            pdfFormFields.SetField("CDRPersReason", formTables.Tables("viewCDR").Rows(0).Item("PersonalCareReasonLabel").ToString)
            pdfFormFields.SetField("CDRSpeech", formTables.Tables("viewCDR").Rows(0).Item("SpeechLabel").ToString)
            pdfFormFields.SetField("CDRComm", formTables.Tables("viewCDR").Rows(0).Item("CommandsLabel").ToString)
            pdfFormFields.SetField("CDRRec", formTables.Tables("viewCDR").Rows(0).Item("RecognitionLabel").ToString)
            pdfFormFields.SetField("CDRFeed", formTables.Tables("viewCDR").Rows(0).Item("FeedingLabel").ToString)
            pdfFormFields.SetField("CDRIncont", formTables.Tables("viewCDR").Rows(0).Item("IncontinenceLabel").ToString)
            pdfFormFields.SetField("CDRWalk", formTables.Tables("viewCDR").Rows(0).Item("WalkingLabel").ToString)
            pdfFormFields.SetField("CDRScore", formTables.Tables("viewCDR").Rows(0).Item("CDRScore").ToString)
            pdfFormFields.SetField("CDRSum", formTables.Tables("viewCDR").Rows(0).Item("CDRSum").ToString)
            pdfFormFields.SetField("CDRChgFinReason", formTables.Tables("viewCDR").Rows(0).Item("ChangeFinReasonCodeLabel").ToString)
            pdfFormFields.SetField("CDRFinReason", formTables.Tables("viewCDR").Rows(0).Item("FinalReasonCode").ToString)
            pdfFormFields.SetField("CDRClinTotal", formTables.Tables("viewCDR").Rows(0).Item("ClinTotal").ToString)
            pdfFormFields.SetField("CDRClinFinReason", formTables.Tables("viewCDR").Rows(0).Item("ClinFinReasonCodeLabel").ToString)
            pdfFormFields.SetField("CDRClinZScore", formTables.Tables("viewCDR").Rows(0).Item("ClinZScore").ToString)
            pdfFormFields.SetField("CDRClinPercent", formTables.Tables("viewCDR").Rows(0).Item("ClinPercentage").ToString)
            pdfFormFields.SetField("CDRNotes", formTables.Tables("viewCDR").Rows(0).Item("Notes").ToString)

            'Free up system memory by removing tables
            formTables.Tables.Remove("viewCDR")
        End If
    End Sub
    Private Sub fillPDFAD8()
        If Database.ExistingRecordCheck("PMCR_AD8", "SubNum = " & WarehouseShell.SubNum) Then
            'Grab requisite tables
            formTables.Tables.Add(Database.ReturnTable("viewPMCR_AD8", , "SubNum = " & WarehouseShell.SubNum))

            'Set non-PHI values
            pdfFormFields.SetField("AD8_1", formTables.Tables("viewPMCR_AD8").Rows(0).Item("Q1Label").ToString)
            pdfFormFields.SetField("AD8_2", formTables.Tables("viewPMCR_AD8").Rows(0).Item("Q2Label").ToString)
            pdfFormFields.SetField("AD8_3", formTables.Tables("viewPMCR_AD8").Rows(0).Item("Q3Label").ToString)
            pdfFormFields.SetField("AD8_4", formTables.Tables("viewPMCR_AD8").Rows(0).Item("Q4Label").ToString)
            pdfFormFields.SetField("AD8_5", formTables.Tables("viewPMCR_AD8").Rows(0).Item("Q5Label").ToString)
            pdfFormFields.SetField("AD8_6", formTables.Tables("viewPMCR_AD8").Rows(0).Item("Q6Label").ToString)
            pdfFormFields.SetField("AD8_7", formTables.Tables("viewPMCR_AD8").Rows(0).Item("Q7Label").ToString)
            pdfFormFields.SetField("AD8_8", formTables.Tables("viewPMCR_AD8").Rows(0).Item("Q8Label").ToString)
            pdfFormFields.SetField("AD8Total", formTables.Tables("viewPMCR_AD8").Rows(0).Item("Score").ToString)

            'Free up system memory by removing tables
            formTables.Tables.Remove("viewPMCR_AD8")
        End If
    End Sub
    Private Sub fillPDFCDRInfInterview()
        If Database.ExistingRecordCheck("CDR_Inf_Interview", "SubNum = " & WarehouseShell.SubNum & " and Visit = 888") Then
            'Grab requisite tables
            formTables.Tables.Add(Database.ReturnTable("viewCDR_Inf_Interview", , "SubNum = " & WarehouseShell.SubNum))

            'Set non-PHI values
            pdfFormFields.SetField("CDRInf1", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("InfSourceLabel").ToString)
            pdfFormFields.SetField("CDRInf3", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("InfRelationLabel").ToString)
            pdfFormFields.SetField("CDRInf4", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("ConfLevelLabel").ToString)
            pdfFormFields.SetField("CDRInf5", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("InfMoYrBirth").ToString)
            pdfFormFields.SetField("CDRInf6", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("InfSexLabel").ToString)
            pdfFormFields.SetField("CDRInf7", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("InfCommProbsLabel").ToString)
            pdfFormFields.SetField("CDRInf7a", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("InfCommProbSevLabel").ToString)
            pdfFormFields.SetField("CDRInf7b", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("InfCommProbNote").ToString)
            pdfFormFields.SetField("CDRInf8", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("InfRaceLabel").ToString)
            pdfFormFields.SetField("CDRInf9", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("InfYrsEd").ToString)
            pdfFormFields.SetField("CDRInf10", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("InfLiveWSubLabel").ToString)
            pdfFormFields.SetField("CDRInf10a", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("InfVisitPersLabel").ToString)
            pdfFormFields.SetField("CDRInf10b", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("InfVisitPhoneLabel").ToString)
            pdfFormFields.SetField("CDRInf11", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("InfReliabilityLabel").ToString)
            pdfFormFields.SetField("CDRInfNotes", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("infIntNotes").ToString)
            pdfFormFields.SetField("CDRInfMem1", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Mem1Label").ToString)
            pdfFormFields.SetField("CDRInfMemFreq1", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Mem1FreqLabel").ToString)
            pdfFormFields.SetField("CDRInfMem1a", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Mem1aLabel").ToString)
            pdfFormFields.SetField("CDRInfMemFreq1a", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Mem1aFreqLabel").ToString)
            pdfFormFields.SetField("CDRInfMem2", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Mem2Label").ToString)
            pdfFormFields.SetField("CDRInfMemFreq2", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Mem2FreqLabel").ToString)
            pdfFormFields.SetField("CDRInfMem3", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Mem3Label").ToString)
            pdfFormFields.SetField("CDRInfMemFreq3", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Mem3FreqLabel").ToString)
            pdfFormFields.SetField("CDRInfMem4", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Mem4Label").ToString)
            pdfFormFields.SetField("CDRInfMemFreq4", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Mem4FreqLabel").ToString)
            pdfFormFields.SetField("CDRInfMem4a", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Mem4aLabel").ToString)
            pdfFormFields.SetField("CDRInfMemFreq4a", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Mem4aFreqLabel").ToString)
            pdfFormFields.SetField("CDRInfMem4b", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Mem4aNote").ToString)
            pdfFormFields.SetField("CDRInfMem5", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Mem5Label").ToString)
            pdfFormFields.SetField("CDRInfMemFreq5", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Mem5FreqLabel").ToString)
            pdfFormFields.SetField("CDRInfMem6", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Mem6Label").ToString)
            pdfFormFields.SetField("CDRInfMemFreq6", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Mem6FreqLabel").ToString)
            pdfFormFields.SetField("CDRInfMem7", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Mem7Label").ToString)
            pdfFormFields.SetField("CDRInfMemFreq7", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Mem7FreqLabel").ToString)
            pdfFormFields.SetField("CDRInfMem8a", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Mem8aNote").ToString)
            pdfFormFields.SetField("CDRInfMem8b", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Mem8bNote").ToString)
            pdfFormFields.SetField("CDRInfOrient1", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Orient1Label").ToString)
            pdfFormFields.SetField("CDRInfOrient2", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Orient2Label").ToString)
            pdfFormFields.SetField("CDRInfOrient3", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Orient3Label").ToString)
            pdfFormFields.SetField("CDRInfOrient4", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Orient4Label").ToString)
            pdfFormFields.SetField("CDRInfOrient5", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Orient5Label").ToString)
            pdfFormFields.SetField("CDRInfOrient6", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Orient6Label").ToString)
            pdfFormFields.SetField("CDRInfOrient7", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Orient7Label").ToString)
            pdfFormFields.SetField("CDRInfOrient8", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Orient8Label").ToString)
            pdfFormFields.SetField("CDRInfJudge1", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Judge1Label").ToString)
            pdfFormFields.SetField("CDRInfJudge2", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Judge2Label").ToString)
            pdfFormFields.SetField("CDRInfJudge3", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Judge3Label").ToString)
            pdfFormFields.SetField("CDRInfJudge4", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Judge4Label").ToString)
            pdfFormFields.SetField("CDRInfJudge4a", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Judge4aLabel").ToString)
            pdfFormFields.SetField("CDRInfComm1", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Comm1Label").ToString)
            pdfFormFields.SetField("CDRInfComm1a", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Comm1aLabel").ToString)
            pdfFormFields.SetField("CDRInfComm1b", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Comm1b").ToString)
            pdfFormFields.SetField("CDRInfComm2", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Comm2Label").ToString)
            pdfFormFields.SetField("CDRInfComm3", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Comm3Label").ToString)
            pdfFormFields.SetField("CDRInfComm3a", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Comm3a").ToString)
            pdfFormFields.SetField("CDRInfHome1", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Home1Label").ToString)
            pdfFormFields.SetField("CDRInfHome1a", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Home1aLabel").ToString)
            pdfFormFields.SetField("CDRInfHome2", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Home2Label").ToString)
            pdfFormFields.SetField("CDRInfHome3", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Home3Label").ToString)
            pdfFormFields.SetField("CDRInfHome4", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Home4Label").ToString)
            pdfFormFields.SetField("CDRInfHome4a", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Home4aLabel").ToString)
            pdfFormFields.SetField("CDRInfHome5", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Home5Label").ToString)
            pdfFormFields.SetField("CDRInfHome6", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Home6Label").ToString)
            pdfFormFields.SetField("CDRInfHome6a", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Home6a").ToString)
            pdfFormFields.SetField("CDRInfHome7", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Home7Label").ToString)
            pdfFormFields.SetField("CDRInfHome7a", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Home7aLabel").ToString)
            pdfFormFields.SetField("CDRInfHome8", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Home8Label").ToString)
            pdfFormFields.SetField("CDRInfHome8a", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Home8aLabel").ToString)
            pdfFormFields.SetField("CDRInfPers1", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Pers1Label").ToString)
            pdfFormFields.SetField("CDRInfPers1a", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Pers1aLabel").ToString)
            pdfFormFields.SetField("CDRInfPers1b", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Pers1b").ToString)
            pdfFormFields.SetField("CDRInfPers2", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Pers2Label").ToString)
            pdfFormFields.SetField("CDRInfPers2a", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Pers2aLabel").ToString)
            pdfFormFields.SetField("CDRInfPers2b", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Pers2b").ToString)
            pdfFormFields.SetField("CDRInfPers3", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Pers3Label").ToString)
            pdfFormFields.SetField("CDRInfPers3a", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Pers3aLabel").ToString)
            pdfFormFields.SetField("CDRInfPers3b", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Pers3b").ToString)
            pdfFormFields.SetField("CDRInfPers4", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Pers4Label").ToString)
            pdfFormFields.SetField("CDRInfPers4a", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Pers4aLabel").ToString)
            pdfFormFields.SetField("CDRInfPers4b", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("Pers4b").ToString)

            'Set PHI values
            If WarehouseShell.ShowingPHI Then
                pdfFormFields.SetField("CDRInf2", formTables.Tables("viewCDR_Inf_Interview").Rows(0).Item("InfName").ToString)
            Else
                pdfFormFields.SetField("CDRInf2", "PHI Hidden")
            End If

            'Free up system memory by removing tables
            formTables.Tables.Remove("viewCDR_Inf_Interview")
        End If
    End Sub
    Private Sub fillPDFDementia1()
        If Database.ExistingRecordCheck("PMCR_Dementia1", "SubNum = " & WarehouseShell.SubNum) Then
            'Grab requisite tables
            formTables.Tables.Add(Database.ReturnTable("viewPMCR_Dementia1", , "SubNum = " & WarehouseShell.SubNum))

            'Set non-PHI values
            pdfFormFields.SetField("CVD1", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("VascDementiaLabel").ToString)
            pdfFormFields.SetField("CVDDate1", returnFormattedDate("viewPMCR_Dementia1", "VascDementiaDate"))
            pdfFormFields.SetField("CVD2", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("IschemicStrokesLabel").ToString)
            pdfFormFields.SetField("CVDDate2", returnFormattedDate("viewPMCR_Dementia1", "IschemicStrokesDate"))
            pdfFormFields.SetField("CVD3", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("OneInfarctLabel").ToString)
            pdfFormFields.SetField("CVDDate3", returnFormattedDate("viewPMCR_Dementia1", "OneInfarctDate"))
            pdfFormFields.SetField("CVD4", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("MultInfarctsLabel").ToString)
            pdfFormFields.SetField("CVDDate4", returnFormattedDate("viewPMCR_Dementia1", "MultInfarctsDate"))
            pdfFormFields.SetField("CVD5", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("HxTIAsLabel").ToString)
            pdfFormFields.SetField("CVDDate5", returnFormattedDate("viewPMCR_Dementia1", "HxTIAsDate"))
            pdfFormFields.SetField("CVD6", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("HxVascRiskLabel").ToString)
            pdfFormFields.SetField("CVDDate6", returnFormattedDate("viewPMCR_Dementia1", "HxVascRiskDate"))
            pdfFormFields.SetField("CVD7", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("ElevHachinskiLabel").ToString)
            pdfFormFields.SetField("CVDDate7", returnFormattedDate("viewPMCR_Dementia1", "ElevHachinskiDate"))
            pdfFormFields.SetField("CVD8", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("HxSingleStrokeLabel").ToString)
            pdfFormFields.SetField("CVDDate8", returnFormattedDate("viewPMCR_Dementia1", "HxSingleStrokeDate"))
            pdfFormFields.SetField("CVD9", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("BinswangersLabel").ToString)
            pdfFormFields.SetField("CVDDate9", returnFormattedDate("viewPMCR_Dementia1", "BinswangersDate"))
            pdfFormFields.SetField("CVD10", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("DisorderRelDementiaLabel").ToString)
            pdfFormFields.SetField("CVDDate10", returnFormattedDate("viewPMCR_Dementia1", "DisorderRelDementiaDate"))
            pdfFormFields.SetField("CVD11", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("RelFocalSignsLabel").ToString)
            pdfFormFields.SetField("CVDDate11", returnFormattedDate("viewPMCR_Dementia1", "RelFocalSignsDate"))
            pdfFormFields.SetField("CVDNotes", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("VascNotes").ToString)
            pdfFormFields.SetField("CVDOverallScore", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("OverallScoreLabel").ToString)
            pdfFormFields.SetField("CVDOverallScoreDate", returnFormattedDate("viewPMCR_Dementia1", "OverallScoreDate"))
            pdfFormFields.SetField("CVDNINCDS", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("NINCDSLabel").ToString)
            pdfFormFields.SetField("CVDNINCDSDate", returnFormattedDate("viewPMCR_Dementia1", "NINCDSDate"))
            pdfFormFields.SetField("CVDDemPark", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("DemParkLabel").ToString)
            pdfFormFields.SetField("CVDDemParkDate", returnFormattedDate("viewPMCR_Dementia1", "DemParkDate"))
            pdfFormFields.SetField("CVDDemAlc", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("DemAlcoholLabel").ToString)
            pdfFormFields.SetField("CVDDemAlcDate", returnFormattedDate("viewPMCR_Dementia1", "DemAlcoholDate"))
            pdfFormFields.SetField("DemCogComp1", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("ClinDementiaLabel").ToString)
            pdfFormFields.SetField("DemCogCompDate1", returnFormattedDate("viewPMCR_Dementia1", "ClinDementiaDate"))
            pdfFormFields.SetField("DemCogComp2", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("OrgMentalSyndLabel").ToString)
            pdfFormFields.SetField("DemCogCompDate2", returnFormattedDate("viewPMCR_Dementia1", "OrgMentalSyndDate"))
            pdfFormFields.SetField("DemCogComp3", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("AlzheimersLabel").ToString)
            pdfFormFields.SetField("DemCogCompDate3", returnFormattedDate("viewPMCR_Dementia1", "AlzheimersDate"))
            pdfFormFields.SetField("DemCogComp4", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("EncephLabel").ToString)
            pdfFormFields.SetField("DemCogCompDate4", returnFormattedDate("viewPMCR_Dementia1", "EncephDate"))
            pdfFormFields.SetField("DemCogComp5", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("AbruptOnsetLabel").ToString)
            pdfFormFields.SetField("DemCogCompDate5", returnFormattedDate("viewPMCR_Dementia1", "AbruptOnsetDate"))
            pdfFormFields.SetField("DemCogComp6", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("LewyLabel").ToString)
            pdfFormFields.SetField("DemCogCompDate6", returnFormattedDate("viewPMCR_Dementia1", "LewyDate"))
            pdfFormFields.SetField("DemCogComp7", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("ConfusedLabel").ToString)
            pdfFormFields.SetField("DemCogCompDate7", returnFormattedDate("viewPMCR_Dementia1", "ConfusedDate"))
            pdfFormFields.SetField("DemCogComp8", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("NocturnalLabel").ToString)
            pdfFormFields.SetField("DemCogCompDate8", returnFormattedDate("viewPMCR_Dementia1", "NocturnalDate"))
            pdfFormFields.SetField("DemCogComp9", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("ClinOtherLabel").ToString)
            pdfFormFields.SetField("DemCogCompDate9", returnFormattedDate("viewPMCR_Dementia1", "ClinOtherDate"))
            pdfFormFields.SetField("DemCogComp9Spec", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("ClinOtherNote").ToString)
            pdfFormFields.SetField("DSMIII1", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("ShortTermMemLabel").ToString)
            pdfFormFields.SetField("DSMIIIDate1", returnFormattedDate("viewPMCR_Dementia1", "ShortTermMemDate"))
            pdfFormFields.SetField("DSMIII2", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("LongTermPersLabel").ToString)
            pdfFormFields.SetField("DSMIIIDate2", returnFormattedDate("viewPMCR_Dementia1", "LongTermPersDate"))
            pdfFormFields.SetField("DSMIII3", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("LongTermComKnowLabel").ToString)
            pdfFormFields.SetField("DSMIIIDate3", returnFormattedDate("viewPMCR_Dementia1", "LongTermComKnowDate"))
            pdfFormFields.SetField("DSMIII4", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("AbstractThinkingLabel").ToString)
            pdfFormFields.SetField("DSMIIIDate4", returnFormattedDate("viewPMCR_Dementia1", "AbstractThinkingDate"))
            pdfFormFields.SetField("DSMIII5", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("JudgementLabel").ToString)
            pdfFormFields.SetField("DSMIIIDate5", returnFormattedDate("viewPMCR_Dementia1", "JudgementDate"))
            pdfFormFields.SetField("DSMIII6", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("DistHighCortFunctLabel").ToString)
            pdfFormFields.SetField("DSMIIIDate6", returnFormattedDate("viewPMCR_Dementia1", "DistHighCortFunctDate"))
            pdfFormFields.SetField("DSMIII6a", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("DSMIIIAphasiaLabel").ToString)
            pdfFormFields.SetField("DSMIIIDate6a", returnFormattedDate("viewPMCR_Dementia1", "DSMIIIAphasiaDate"))
            pdfFormFields.SetField("DSMIII6b", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("DSMIIIApraxiaLabel").ToString)
            pdfFormFields.SetField("DSMIIIDate6b", returnFormattedDate("viewPMCR_Dementia1", "DSMIIIApraxiaDate"))
            pdfFormFields.SetField("DSMIII6c", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("DSMIIIAgnosiaLabel").ToString)
            pdfFormFields.SetField("DSMIIIDate6C", returnFormattedDate("viewPMCR_Dementia1", "DSMIIIAgnosiaDate"))
            pdfFormFields.SetField("DSMIII7", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("PersonalityChgLabel").ToString)
            pdfFormFields.SetField("DSMIIIDate7", returnFormattedDate("viewPMCR_Dementia1", "PersonalityChgDate"))
            pdfFormFields.SetField("DSMIV1", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("MemoryLabel").ToString)
            pdfFormFields.SetField("DSMIVDate1", returnFormattedDate("viewPMCR_Dementia1", "MemoryDate"))
            pdfFormFields.SetField("DSMIV2", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("DSMIVAphasiaLabel").ToString)
            pdfFormFields.SetField("DSMIVDate2", returnFormattedDate("viewPMCR_Dementia1", "DSMIVAphasiaDate"))
            pdfFormFields.SetField("DSMIV3", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("DSMIVApraxiaLabel").ToString)
            pdfFormFields.SetField("DSMIVDate3", returnFormattedDate("viewPMCR_Dementia1", "DSMIVApraxiaDate"))
            pdfFormFields.SetField("DSMIV4", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("DSMIVAgnosiaLabel").ToString)
            pdfFormFields.SetField("DSMIVDate4", returnFormattedDate("viewPMCR_Dementia1", "DSMIVAgnosiaDate"))
            pdfFormFields.SetField("DSMIV5", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("ExecFunctLabel").ToString)
            pdfFormFields.SetField("DSMIVDate5", returnFormattedDate("viewPMCR_Dementia1", "ExecFunctDate"))
            pdfFormFields.SetField("DSMMeetsCrit", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("MeetsDSMCriteriaLabel").ToString)
            pdfFormFields.SetField("DSMMeetsCritDate", returnFormattedDate("viewPMCR_Dementia1", "MeetsDSMCriteriaDate"))
            pdfFormFields.SetField("NINCDS1", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("BlessedLabel").ToString)
            pdfFormFields.SetField("NINCDSDate1", returnFormattedDate("viewPMCR_Dementia1", "BlessedDate"))
            pdfFormFields.SetField("NINCDS2", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("TwoDefecitsLabel").ToString)
            pdfFormFields.SetField("NINCDSDate2", returnFormattedDate("viewPMCR_Dementia1", "TwoDefecitsDate"))
            pdfFormFields.SetField("NINCDS3", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("ProgDetMemCogLabel").ToString)
            pdfFormFields.SetField("NINCDSDate3", returnFormattedDate("viewPMCR_Dementia1", "ProgDetMemCogDate"))
            pdfFormFields.SetField("NINCDS4", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("OnsetFourtyNinetyLabel").ToString)
            pdfFormFields.SetField("NINCDSDate4", returnFormattedDate("viewPMCR_Dementia1", "OnsetFourtyNinetyDate"))
            pdfFormFields.SetField("NINCDS5", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("NoOtherEtiologyLabel").ToString)
            pdfFormFields.SetField("NINCDSDate5", returnFormattedDate("viewPMCR_Dementia1", "NoOtherEtiologyDate"))
            pdfFormFields.SetField("NINCDS6", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("SecondDisorderLabel").ToString)
            pdfFormFields.SetField("NINCDSDate6", returnFormattedDate("viewPMCR_Dementia1", "SecondDisorderDate"))
            pdfFormFields.SetField("NINCDS7", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("SingProgDefecitLabel").ToString)
            pdfFormFields.SetField("NINCDSDate7", returnFormattedDate("viewPMCR_Dementia1", "SingProgDefecitDate"))
            pdfFormFields.SetField("NINCDSMeetsCrit", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("NINCDSADLabel").ToString)
            pdfFormFields.SetField("NINCDSMeetsCritDate", returnFormattedDate("viewPMCR_Dementia1", "NINCDSADDate"))
            pdfFormFields.SetField("NINCDSAgeOfOnset", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("AgeOfOnset").ToString)
            pdfFormFields.SetField("DementiaNotes", formTables.Tables("viewPMCR_Dementia1").Rows(0).Item("NINCDSNotes").ToString)

            'Free up system memory by removing tables
            formTables.Tables.Remove("viewPMCR_Dementia1")
        End If
    End Sub
    Private Sub fillPDFDementia2()
        If Database.ExistingRecordCheck("PMCR_Dementia2", "SubNum = " & WarehouseShell.SubNum) Then
            'Grab requisite tables
            formTables.Tables.Add(Database.ReturnTable("viewPMCR_Dementia2", , "SubNum = " & WarehouseShell.SubNum))

            'Set non-PHI values
            pdfFormFields.SetField("DLB1", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("CentralFeatureLabel").ToString)
            pdfFormFields.SetField("DLB2a", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("FluctCognitionLabel").ToString)
            pdfFormFields.SetField("DLB2b", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("RecurrentVisualLabel").ToString)
            pdfFormFields.SetField("DLB2c", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("SpontMotorLabel").ToString)
            pdfFormFields.SetField("DLB3a", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("RepeatedFallsLabel").ToString)
            pdfFormFields.SetField("DLB3b", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("Syncopelabel").ToString)
            pdfFormFields.SetField("DLB3c", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("LossConsciousLabel").ToString)
            pdfFormFields.SetField("DLB3d", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("NeurolepticLabel").ToString)
            pdfFormFields.SetField("DLB3e", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("SystDelusionsLabel").ToString)
            pdfFormFields.SetField("DLB3f", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("HallucinationsLabel").ToString)
            pdfFormFields.SetField("DLB4a", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("StrokeDiseaseLabel").ToString)
            pdfFormFields.SetField("DLB4b", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("PysIllDisorderLabel").ToString)
            pdfFormFields.SetField("DLBMeetsCrit", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("MeetsDLBCriteriaLabel").ToString)
            pdfFormFields.SetField("DxCERAD1", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("ProbADUncompLabel").ToString)
            pdfFormFields.SetField("DxCERAD2", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("ProbADCompLabel").ToString)
            pdfFormFields.SetField("DxCERAD3", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("PossADAtypLabel").ToString)
            pdfFormFields.SetField("DxCERAD4", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("PossADTypLabel").ToString)
            pdfFormFields.SetField("DxCERAD5", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("ProbVascDemLabel").ToString)
            pdfFormFields.SetField("DxCERAD6", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("PossVascDemLabel").ToString)
            pdfFormFields.SetField("DxCERAD7", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("UnusVascDemLabel").ToString)
            pdfFormFields.SetField("DxCERAD8", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("DemSyndDepLabel").ToString)
            pdfFormFields.SetField("DxCERAD9", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("DeliriumLabel").ToString)
            pdfFormFields.SetField("DxCERAD10", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("ProbConfDrugsLabel").ToString)
            pdfFormFields.SetField("DxCERAD11", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("PossConfDrugsLabel").ToString)
            pdfFormFields.SetField("DxCERAD12", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("ProbDemParkLabel").ToString)
            pdfFormFields.SetField("DxCERAD13", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("PossDemParkLabel").ToString)
            pdfFormFields.SetField("DxCERAD14", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("OtherDemDisLabel").ToString)
            pdfFormFields.SetField("DxCERADNotes", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("CERADNotes").ToString)
            pdfFormFields.SetField("FTD1", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("BehCogDeficitsLabel").ToString)
            pdfFormFields.SetField("FTD2", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("DeficitsSigImpLabel").ToString)
            pdfFormFields.SetField("FTD3", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("GradOnsetLabel").ToString)
            pdfFormFields.SetField("FTD4", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("NotDueNervousLabel").ToString)
            pdfFormFields.SetField("FTD5", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("NotDeliriumLabel").ToString)
            pdfFormFields.SetField("FTD6", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("NotPsychDiagLabel").ToString)
            pdfFormFields.SetField("FTD7", formTables.Tables("viewPMCR_Dementia2").Rows(0).Item("MeetsFTDCriteriaLabel").ToString)

            'Free up system memory by removing tables
            formTables.Tables.Remove("viewPMCR_Dementia2")
        End If
    End Sub
    Private Sub fillPDFParkinsonism()
        If Database.ExistingRecordCheck("PMCR_Parkinsonism", "SubNum = " & WarehouseShell.SubNum) Then
            'Grab requisite tables
            formTables.Tables.Add(Database.ReturnTable("viewPMCR_Parkinsonism", , "SubNum = " & WarehouseShell.SubNum))

            'Set non-PHI values
            pdfFormFields.SetField("ParkA1", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("TremorRestingLabel").ToString)
            pdfFormFields.SetField("ParkA1a", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("TremorPosturalLabel").ToString)
            pdfFormFields.SetField("ParkA1b", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("TremorActionLabel").ToString)
            pdfFormFields.SetField("ParkA2", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("RigidityLabel").ToString)
            pdfFormFields.SetField("ParkA2a", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("CogwheelingLabel").ToString)
            pdfFormFields.SetField("ParkA2b", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("LimitationROMLabel").ToString)
            pdfFormFields.SetField("ParkA3", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("BradyBodyLabel").ToString)
            pdfFormFields.SetField("ParkA3a", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("BradyFaceLabel").ToString)
            pdfFormFields.SetField("ParkA4", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("AsymetricOnsetLabel").ToString)
            pdfFormFields.SetField("ParkB5", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("PsychosisHallLabel").ToString)
            pdfFormFields.SetField("ParkB5a", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("PsychosisHallMonthLabel").ToString)
            pdfFormFields.SetField("ParkB5b", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("PsychosisHallYearLabel").ToString)
            pdfFormFields.SetField("ParkB5c", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("PsychosisHallLifeLabel").ToString)
            pdfFormFields.SetField("ParkB6", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("PosturalInstabLabel").ToString)
            pdfFormFields.SetField("ParkB7", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("FreezePhenomLabel").ToString)
            pdfFormFields.SetField("ParkB8", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("DemPrecMotorLabel").ToString)
            pdfFormFields.SetField("ParkB9", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("GazePalsyLabel").ToString)
            pdfFormFields.SetField("ParkB10", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("DysautonomiaLabel").ToString)
            pdfFormFields.SetField("ParkB11", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("CondProdParkLabel").ToString)
            pdfFormFields.SetField("Park12", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("EnBlocTurningLabel").ToString)
            pdfFormFields.SetField("Park13", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("ParkGaitLabel").ToString)
            pdfFormFields.SetField("Park14", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("ParkSpeechLabel").ToString)
            pdfFormFields.SetField("Park15", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("DyskinesiasLabel").ToString)
            pdfFormFields.SetField("Park16", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("AntiParkMedsLabel").ToString)
            pdfFormFields.SetField("Park17", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("ClinEvidImprovLabel").ToString)
            pdfFormFields.SetField("Park18", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("ExtraPyramidalMedsLabel").ToString)
            pdfFormFields.SetField("Park19", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("PDAntedateDemLabel").ToString)
            pdfFormFields.SetField("ParkLegHall", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("PsychoHallLabel").ToString)
            pdfFormFields.SetField("ParkLegDela", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("PsychoDeluMonthLabel").ToString)
            pdfFormFields.SetField("ParkLegDelb", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("PsychoDeluYearLabel").ToString)
            pdfFormFields.SetField("ParkLegDelc", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("PsychoDeluLifeLabel").ToString)
            pdfFormFields.SetField("ParkLegDel", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("PsychoDeluLabel").ToString)
            pdfFormFields.SetField("ParkDxa", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("ThreeGrpALabel").ToString)
            pdfFormFields.SetField("ParkDxb", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("NoneGrpBLabel").ToString)
            pdfFormFields.SetField("ParkDxc", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("RespoLevodopaLabel").ToString)
            pdfFormFields.SetField("ParkDxd", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("GrpATremorBradyLabel").ToString)
            pdfFormFields.SetField("ParkDxe", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("NoGrpBGrpALabel").ToString)
            pdfFormFields.SetField("ParkDxf", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("RespoLevoOrDrugTrialLabel").ToString)
            pdfFormFields.SetField("ParkClinLegDx", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("ClinLegDiagLabel").ToString)
            pdfFormFields.SetField("PDRelDem", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("PDRelatedDemLabel").ToString)
            pdfFormFields.SetField("ParkDx", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("ParkinsonsDxLabel").ToString)
            pdfFormFields.SetField("ParkNotes", formTables.Tables("viewPMCR_Parkinsonism").Rows(0).Item("Notes").ToString)

            'Free up system memory by removing tables
            formTables.Tables.Remove("viewPMCR_Parkinsonism")
        End If
    End Sub
    Private Sub fillPDFLabs()
        If Database.ExistingRecordCheck("Labs", "SubNum = " & WarehouseShell.SubNum) Then
            'Grab requisite tables
            formTables.Tables.Add(Database.ReturnTable("viewLabs", "top(52) *", "SubNum = " & WarehouseShell.SubNum, "LabDate desc"))

            'Set table of values
            Dim rowNum As Integer = 0
            While rowNum < 51 And rowNum < formTables.Tables("viewLabs").Rows().Count()
                Dim row As DataRow = formTables.Tables("viewLabs").Rows(rowNum)

                pdfFormFields.SetField("LabName" & (rowNum + 1), row.Item("LabName").ToString)
                pdfFormFields.SetField("LabUnit" & (rowNum + 1), row.Item("UoM").ToString)
                pdfFormFields.SetField("LabRngFrom" & (rowNum + 1), row.Item("RangeLow").ToString)
                pdfFormFields.SetField("LabRngTo" & (rowNum + 1), row.Item("RangeHigh").ToString)
                pdfFormFields.SetField("LabQuantRes" & (rowNum + 1), row.Item("QuantitativeResult").ToString)
                pdfFormFields.SetField("LabQualRes" & (rowNum + 1), row.Item("QualitativeResult").ToString)
                rowNum += 1
            End While

            'set more records checkbox
            If rowNum = 51 Then
                pdfFormFields.SetField("LabsMoreExist", "1")
            End If

            'Free up system memory by removing tables
            formTables.Tables.Remove("viewLabs")
        End If
    End Sub

    Private Function returnFormattedDate(ByVal table As String, ByVal field As String) As String
        Dim result As String
        If IsDBNull(formTables.Tables(table).Rows(0).Item(field)) Then
            result = ""
        Else
            result = Format(formTables.Tables(table).Rows(0).Item(field), "MM/dd/yyyy").ToString
        End If
        Return result
    End Function

    'IFormMethods
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
        btnPMCR_Header_Top.PerformClick()
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class