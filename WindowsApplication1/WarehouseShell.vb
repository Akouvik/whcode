Public Class WarehouseShell

    'Application wide variables
    Public conn As SqlConnection
    Public userName As String = ""
    Public password As String = ""
    Public phiAuthenticated As Boolean = False
    Public ShowingPHI As Boolean = False
    Public SubNum As String = ""
    Public RecordID As String = "" 'Allows opening forms to show a specific record on load in view/edit modes when there is a many-to-one relationship with SubNum (set by WA_AvalableSubjectRecords)
    Public Group As String = "" 'Allows loading ADRC or NBTR modes
    'Some general use public variables
    Public String1 As String = Nothing
    Public String2 As String = Nothing
    Public String3 As String = Nothing
    Public String4 As String = Nothing
    Public String5 As String = Nothing
    Public StringArray As String() = Nothing
    Public Num1 As Integer
    Public Num2 As Integer
    'This set of code defines data modes, and keeps the lbl in the status bar updated with the current data mode.
    Public Enum userDataMode
        View
        Edit
        Insert
        Undefined
    End Enum
    Public Enum formType
        WA_Welcome

        '//////////NBTR SubjectForms//////////
        WA_AutopsyDissectionMap
        WA_AutopsyFaceSheet
        WA_AutopsyBlockSampling
        WA_CERAD_Addendum
        WA_CERAD_Header
        WA_CERADB
        WA_CERADC
        WA_CERADD
        WA_CERADE
        WA_CERADF
        WA_CERADG_Screen
        WA_CERADG1
        WA_CERADG2
        WA_CERADH
        WA_CERADIJ
        WA_CERAD_ARTAG
        WA_ClinicalSummary
        WA_ConsenusDx
        WA_Demographics
        WA_ExistingSubjectRecords
        WA_Institutionalizations
        WA_Institutions
        WA_InstitutionSuggestions
        WA_MiscSubjectFiles
        WA_MRI_Tracking
        WA_NeuropathRequests
        WA_NoK
        WA_NP_BrainRegionMap
        WA_NPSummary
        WA_PlaqueCounts
        WA_PMCR
        WA_PreEnrollment_Anniversary
        WA_PreEnrollments_Detail
        WA_ShortInitialSummary
        WA_SubjectSelect
        WA_TangleCounts


        '//////////TissueForms//////////
        WA_TissueSplash
        WA_DNA_RNA_Volume
        WA_SlideScanBarcodesFile
        WA_Specimen_DNA
        WA_Specimen_RNA
        WA_SpecimenOnHand
        WA_SpecimenOnHand_Counts
        WA_TissueDistributions
        WA_TissueDistributions_Details
        WA_TissueRequest
        WA_TissueTasker
        WA_TissueTaskerReport

        '//////////ReportForms//////////
        WA_ReportsSplash
        WA_BlankForms
        WA_DonationReferrals
        WA_DonationReferralTracker
        WA_Neuropath_Requests_Report
        WA_PreEnrollments
        WA_ExistingRecordsReport
        WA_MicroscopicImages
        WA_NP_Progress
        WA_External_Reporting_Exports
        WA_NBB_QTR_Admin
        WA_PurchaseRequests
        WA_UserManagement
        WA_FormPermissions

    End Enum
    Private myDataMode As userDataMode = userDataMode.Undefined
    Public Property DataMode() As userDataMode
        Get
            Return myDataMode
        End Get
        Protected Friend Set(ByVal value As userDataMode)
            myDataMode = value
            lblDataStatus.Text = "Data Mode: " & value.ToString() & ".     Logged in as " & userName & ".     All activity is logged."
        End Set
    End Property

    'WarehouseShell specific variables
    Public HeaderForm As IFormMethods
    Public WorkingAreaForm As IFormMethods
    Public PopUpForm As IFormMethods
    Private loginForm As LoginForm
    Private myPopUp As Loading

    Private Sub WarehouseShell_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Check that LoadLogin() returned true. Exit application if not.
        If Not LoadLogin() Then
            Application.Exit()
        Else
            pnlWorkingArea.Show()
            LoadWorkingAreaForm(formType.WA_Welcome)
            tvFormMenu.Nodes.Clear()
            DataMode = userDataMode.View
            SetGroup()
            If User.CheckPermission("DonationCoordinator") = False Then
                btn_DonationReferrals.Enabled = False
            End If
        End If
    End Sub
    Private Sub SetGroup() 'TODO: Clean this up
        If User.CheckPermission("Dissectionist, DonationCoordinator, LabTech, LabTechLead, Neuropathologist, NPTech, PMCRAssessor, Prosector") Then
            Group = "NBTR"
        End If
    End Sub

    'Login function
    Private Function LoadLogin() As Boolean
        loginForm = New LoginForm
        Dim LoginResult As Windows.Forms.DialogResult = Windows.Forms.DialogResult.Abort
        While LoginResult = Windows.Forms.DialogResult.Abort
            LoginResult = loginForm.ShowDialog
            If LoginResult = Windows.Forms.DialogResult.OK Then
                password = loginForm.PasswordTextBox.Text
                userName = loginForm.UsernameTextBox.Text
                loginForm.Dispose()
                Return True
            ElseIf LoginResult = Windows.Forms.DialogResult.Cancel Then
                Return False
            End If
        End While
        Return False
    End Function
    Public Function Login(ByVal myUsername As String, ByVal myPassword As String) As Boolean
        Dim constr As String = "Data Source=10.93.17.42;Initial Catalog=Warehouse;Persist Security Info=True;User ID=" & myUsername & ";Password=" & myPassword & ";"
        Try
            'Return true if the connection successfully opens with the supplied credentials.
            conn = New SqlConnection(constr)
            conn.Open()
            userName = myUsername
            password = myPassword
            'Enable the PHI toggle button if the user is PHI Authorized
            btnShowPHI.Enabled = User.CheckPermission("PHIAuthorized")
            Return True
        Catch ex As SqlException
            ExceptionHandler.CatchSQLException(ex)
            Return False
        End Try
    End Function

    'Subs for the warehouse shell to call forms to put in the pnlHeader and pnlWorkingArea panels
    Public Sub LoadHeaderForm(ByVal value As IFormMethods)
        pnlHeader.Show()
        pnlHeader.Controls.Clear()
        HeaderForm = value
        HeaderForm.TopLevel(False)
        HeaderForm.Parent(pnlHeader)
        HeaderForm.Show()
    End Sub

    Private Sub setWorkingAreaForm(ByVal value As formType, ByVal specifier As String)
        If Not IsNothing(WorkingAreaForm) Then
            WorkingAreaForm.MyDispose()
        End If
        Select Case value
            Case formType.WA_Welcome
                WorkingAreaForm = New WA_Welcome

                '//////////NBTR SubjectForms//////////
            Case formType.WA_AutopsyDissectionMap
                WorkingAreaForm = New WA_AutopsyDissectionMap
            Case formType.WA_AutopsyFaceSheet
                WorkingAreaForm = New WA_AutopsyFaceSheet
            Case formType.WA_AutopsyBlockSampling
                WorkingAreaForm = New WA_AutopsyBlockSampling
            Case formType.WA_CERAD_Addendum
                WorkingAreaForm = New WA_CERAD_Addendum
            Case formType.WA_CERAD_Header
                WorkingAreaForm = New WA_CERAD_Header
            Case formType.WA_CERADB
                WorkingAreaForm = New WA_CERADB
            Case formType.WA_CERADC
                WorkingAreaForm = New WA_CERADC
            Case formType.WA_CERADD
                WorkingAreaForm = New WA_CERADD
            Case formType.WA_CERADE
                WorkingAreaForm = New WA_CERADE
            Case formType.WA_CERADF
                WorkingAreaForm = New WA_CERADF
            Case formType.WA_CERADG_Screen
                WorkingAreaForm = New WA_CERADG_Screen
            Case formType.WA_CERADG1
                WorkingAreaForm = New WA_CERADG1
            Case formType.WA_CERADG2
                WorkingAreaForm = New WA_CERADG2
            Case formType.WA_CERADH
                WorkingAreaForm = New WA_CERADH
            Case formType.WA_CERADIJ
                WorkingAreaForm = New WA_CERADIJ
            Case formType.WA_CERAD_ARTAG
                WorkingAreaForm = New WA_CERAD_ARTAG
            Case formType.WA_ConsenusDx
                WorkingAreaForm = New WA_ConsenusDx
            Case formType.WA_Demographics
                WorkingAreaForm = New WA_Demographics
            Case formType.WA_ExistingSubjectRecords
                WorkingAreaForm = New WA_ExistingSubjectRecords
            Case formType.WA_Institutionalizations
                WorkingAreaForm = New WA_Institutionalizations
            Case formType.WA_Institutions
                WorkingAreaForm = New WA_Institutions
            Case formType.WA_InstitutionSuggestions
                WorkingAreaForm = New WA_InstitutionSuggestions
            Case formType.WA_MRI_Tracking
                WorkingAreaForm = New WA_MRI_Tracking
            Case formType.WA_NeuropathRequests
                WorkingAreaForm = New WA_NeuropathRequests
            Case formType.WA_NoK
                WorkingAreaForm = New WA_NoK
            Case formType.WA_NPSummary
                WorkingAreaForm = New WA_NPSummary
            Case formType.WA_PlaqueCounts
                WorkingAreaForm = New WA_PlaqueCounts
            Case formType.WA_PMCR
                WorkingAreaForm = New WA_PMCR
            Case formType.WA_ClinicalSummary
                WorkingAreaForm = New WA_ClinicalSummary
            Case formType.WA_PreEnrollments_Detail
                WorkingAreaForm = New WA_PreEnrollments_Detail
            Case formType.WA_ShortInitialSummary
                WorkingAreaForm = New WA_ShortInitialSummary
            Case formType.WA_SubjectSelect
                WorkingAreaForm = New WA_SubjectSelect()
            Case formType.WA_TangleCounts
                WorkingAreaForm = New WA_TangleCounts
            Case formType.WA_MiscSubjectFiles
                WorkingAreaForm = New WA_MiscSubjectFiles
            Case formType.WA_NP_BrainRegionMap
                WorkingAreaForm = New WA_NP_BrainRegionMap

                '//////////TissueForms//////////
            Case formType.WA_TissueSplash
                WorkingAreaForm = New WA_TissueSplash
            Case formType.WA_DNA_RNA_Volume
                WorkingAreaForm = New WA_DNA_RNA_Volume
            Case formType.WA_MicroscopicImages
                WorkingAreaForm = New WA_MicroscopicImages
            Case formType.WA_SlideScanBarcodesFile
                WorkingAreaForm = New WA_SlideScanBarcodeFile
            Case formType.WA_Specimen_DNA
                WorkingAreaForm = New WA_Specimen_DNA
            Case formType.WA_Specimen_RNA
                WorkingAreaForm = New WA_Specimen_RNA
            Case formType.WA_SpecimenOnHand
                WorkingAreaForm = New WA_SpecimenOnHand
            Case formType.WA_SpecimenOnHand_Counts
                WorkingAreaForm = New WA_SpecimenOnHand_Counts
            Case formType.WA_TissueDistributions
                WorkingAreaForm = New WA_TissueDistributions
            Case formType.WA_TissueDistributions_Details
                WorkingAreaForm = New WA_TissueDistributions_Details
            Case formType.WA_TissueRequest
                WorkingAreaForm = New WA_TissueRequest
            Case formType.WA_TissueTasker
                WorkingAreaForm = New WA_TissueTasker
            Case formType.WA_TissueTaskerReport
                WorkingAreaForm = New WA_TissueTaskerReport


                '//////////ReportForms//////////
            Case formType.WA_ReportsSplash
                WorkingAreaForm = New WA_ReportsSplash
            Case formType.WA_BlankForms
                WorkingAreaForm = New WA_BlankForms
            Case formType.WA_DonationReferrals
                WorkingAreaForm = New WA_DonationReferrals
            Case formType.WA_DonationReferralTracker
                WorkingAreaForm = New WA_DonationReferralDetail
            Case formType.WA_ExistingRecordsReport
                WorkingAreaForm = New WA_ExistingRecordsReport
            Case formType.WA_Neuropath_Requests_Report
                WorkingAreaForm = New WA_Neuropath_Requests_Report
            Case formType.WA_PreEnrollments
                WorkingAreaForm = New WA_PreEnrollments
            Case formType.WA_PreEnrollment_Anniversary
                WorkingAreaForm = New WA_PreEnrollment_Anniversary
            Case formType.WA_NP_Progress
                WorkingAreaForm = New WA_NP_Progress
            Case formType.WA_External_Reporting_Exports
                WorkingAreaForm = New WA_External_Reporting_Exports
            Case formType.WA_NBB_QTR_Admin
                WorkingAreaForm = New WA_NBB_QTR_Admin
            Case formType.WA_PurchaseRequests
                WorkingAreaForm = New WA_PurchaseRequests
            Case formType.WA_UserManagement
                WorkingAreaForm = New WA_UserManagement
            Case formType.WA_FormPermissions
                WorkingAreaForm = New WA_FormPermissions
        End Select
        WorkingAreaForm.TopLevel(False)
        WorkingAreaForm.Parent(pnlWorkingArea)
        WorkingAreaForm.Show()
    End Sub
    Public Sub LoadWorkingAreaForm(ByVal value As formType, Optional ByVal specifier As String = "")
        If DataMode = userDataMode.View Or DataMode = userDataMode.Undefined Then
            setWorkingAreaForm(value, specifier) 'Dispose of existing WorkingAreaForm (if one exists), Set WorkingAreaForm = value, if specifier <> "" add (specifier) to value
        Else
            Dim checkform As New PU_SaveWork
            Dim myResult As DialogResult = checkform.ShowDialog()
            If myResult = Windows.Forms.DialogResult.OK Then
                WorkingAreaForm.SaveWork()
                setWorkingAreaForm(value, specifier)
            ElseIf myResult = Windows.Forms.DialogResult.Ignore Then
                setWorkingAreaForm(value, specifier)
            End If
            checkform.Dispose()
        End If
    End Sub

    'Define module button click events
    Private Sub btn_Tissue_Click(sender As Object, e As EventArgs) Handles btnTissue.Click
        If User.CheckPermission("Dissectionist, LabTech, Neuropathologist, NPTech, Prosector") = True Then
            LoadWorkingAreaForm(formType.WA_TissueSplash)
            pnlHeader.Hide()
            tvFormMenu.Nodes.Clear()
            LoadTissueTreeView()
            DataMode = userDataMode.View
        Else
            MsgBox("You do not have access to Tissue data. Please contact Dr. Haroutunian if you believe that you should have access.", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub btnViewSubjectRecords_Click(sender As Object, e As EventArgs) Handles btnSubjectRecords.Click 'TODO: Clean up team settings here
        If Group = "NBTR" Then
            LoadWorkingAreaForm(formType.WA_SubjectSelect)
            LoadHeaderForm(New Head_SubjectSelect)
            Head_SubjectSelect.assignHeaderBindingSource(DirectCast(WorkingAreaForm, WA_SubjectSelect).bs)
        End If
        pnlHeader.Show()
        DataMode = userDataMode.View
    End Sub
    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btn_Reports.Click
        LoadWorkingAreaForm(formType.WA_ReportsSplash)
        pnlHeader.Hide()
        tvFormMenu.Nodes.Clear()
        LoadReportsTreeView()
        DataMode = userDataMode.View
    End Sub
    Private Sub btnDonationReferrals_Click(sender As Object, e As EventArgs) Handles btn_DonationReferrals.Click
        RecordID = "0"
        LoadWorkingAreaForm(formType.WA_DonationReferrals)
        pnlHeader.Hide()
        tvFormMenu.Nodes.Clear()
    End Sub

    'Define btnShowPHI click events
    Private Sub btnShowPHI_Click(sender As Object, e As EventArgs) Handles btnShowPHI.Click
        If phiAuthenticated = False Then
            If PU_PHIPassword.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                phiAuthenticated = True
            End If
            PU_PHIPassword.Dispose()
        End If
        If phiAuthenticated = True Then
            If ShowingPHI = False Then
                btnShowPHI.Text = "Hide PHI"
                ShowingPHI = True
            Else
                btnShowPHI.Text = "Show PHI"
                ShowingPHI = False
            End If
            WorkingAreaForm.ShowPHI(ShowingPHI)
            If pnlHeader.Controls.Count > 0 Then
                HeaderForm.ShowPHI(ShowingPHI)
            End If
        End If
    End Sub

    'Make sure active WA form is saved before closing application.
    Private Sub WarehouseShell_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim checkform As New PU_SaveWork
        If DataMode = userDataMode.Insert Or DataMode = userDataMode.Edit Then
            Dim result As DialogResult = checkform.ShowDialog()
            If result = DialogResult.OK Then
                If TypeOf (WorkingAreaForm) Is WA_PMCR Then 'special case for tabbed forms (specifically PMCR here, but will need more if we convert CERAD to tabbed form)
                    DirectCast(WorkingAreaForm, WA_PMCR).activeForm.SaveWork()
                Else
                    WorkingAreaForm.SaveWork()
                End If
            ElseIf result = DialogResult.Cancel Then
                Exit Sub
            End If
        End If
    End Sub


    'Application wide Public Subs & Functions
    'Function to check for existing records (by SubNum)

    'Sub to suggest new Institution
    Public Sub SuggestNewInstitution(Optional ByVal Identifier As String = "", Optional ByVal Form As String = "", Optional ByVal Field As String = "")
        Dim myForm As New PU_SuggestNewInstitution
        If Identifier <> "" Then
            myForm.Identifier = Identifier
        End If
        If Form <> "" Then
            myForm.Form = Form
        End If
        If Field <> "" Then
            myForm.Field = Field
        End If
        myForm.ShowDialog()
        myForm.Dispose()
    End Sub

    'Subs to build/manipulate treeviews
    Public Sub LoadSubjectTreeView()
        Dim myParent As New TreeNode
        Dim myChild As New TreeNode

        tvFormMenu.Nodes.Clear()
        myParent = tvFormMenu.Nodes.Add("SS", "Subject Select")
        myParent = tvFormMenu.Nodes.Add("Subject", "Subject")
        myParent.Nodes.Add("Summary", "Summary")
        myParent.Nodes.Add("Demographics", "Demographics")
        myParent.Nodes.Add("NoK", "Next of Kin")
        myParent.Nodes.Add("PreEnrollment_Detail", "Pre Enrollment")
        myParent = tvFormMenu.Nodes.Add("Autopsy", "Autopsy")
        myParent.Nodes.Add("AutopsyFaceSheet", "Autopsy Face Sheet")
        myParent.Nodes.Add("AutopsyDissectionMap", "Autopsy Dissection Map")
        myParent.Nodes.Add("AutopsyBlockSampling", "Autopsy Block Sampling")
        myParent.Nodes.Add("MRI_Tracking", "MRI Tracking")
        myParent.Nodes.Add("NPRequests", "Neuropath Requests")
        myParent.Nodes.Add("SIS", "Short Init. Summary")
        myParent = tvFormMenu.Nodes.Add("Neuropath", "Neuropath")
        myChild = myParent.Nodes.Add("CERAD", "CERAD")
        myChild.Nodes.Add("CERADHeader", "CERAD Header")
        myChild.Nodes.Add("CERADB", "CERAD-B")
        myChild.Nodes.Add("CERADC", "CERAD-C")
        myChild.Nodes.Add("CERADD", "CERAD-D")
        myChild.Nodes.Add("CERADE", "CERAD-E")
        myChild.Nodes.Add("CERADF", "CERAD-F")
        myChild.Nodes.Add("CERADGScreen", "CERAD-G Screen")
        myChild.Nodes.Add("CERADG1", "CERAD-G1")
        myChild.Nodes.Add("CERADG2", "CERAD-G2")
        myChild.Nodes.Add("CERADH", "CERAD-H")
        myChild.Nodes.Add("CERADI", "CERAD-IJ")
        myChild.Nodes.Add("CERADAddendum", "CERAD Addendum")
        myChild.Nodes.Add("CERADARTAG", "CERAD ARTAG")
        myParent.Nodes.Add("PlaqueCounts", "Plaque Counts")
        myParent.Nodes.Add("TangleCounts", "Tangle Counts")
        myParent.Nodes.Add("NPRegionMap", "NP Region Map")
        myParent.Nodes.Add("NPSummary", "NP Summary")
        'myParent.Nodes.Add("MicroImages", "Microscopic Images")
        myParent.Nodes.Add("ConsensusDx", "Consensus Diagnosis")
        myParent = tvFormMenu.Nodes.Add("PMCR", "PMCR")
        myParent = tvFormMenu.Nodes.Add("ClinSum", "ClinicalSummary")
        myParent = tvFormMenu.Nodes.Add("MiscSubjectFiles", "Misc Subject Files")
        tvFormMenu.ExpandAll()
    End Sub
    Public Sub LoadTissueTreeView()
        tvFormMenu.Dock = DockStyle.Fill
        Dim myParent As New TreeNode
        Dim myChild As New TreeNode
        tvFormMenu.Show()

        tvFormMenu.Nodes.Clear()
        myParent = tvFormMenu.Nodes.Add("Tissue", "Tissue Inventory")
        myParent.Nodes.Add("OnHand", "View On-Hand Tissue")
        myParent.Nodes.Add("OnHandCounts", "View On-Hand Tissue (Counts)")
        myParent.Nodes.Add("Shipped", "View Distributions- Detailed")
        myParent.Nodes.Add("DNA", "View DNA Tissue")
        myParent.Nodes.Add("RNA", "View RNA Tissue")
        myParent.Nodes.Add("DNARNAVolumes", "View DNA/RNA by Volume")
        myParent = tvFormMenu.Nodes.Add("Requests", "Requests & Taskers")
        myParent.Nodes.Add("Request", "View Approved Requests")
        myParent.Nodes.Add("Tasker", "View Tissue Taskers")
        myParent.Nodes.Add("RequestBarcodes", "Request Barcodes")
        myParent = tvFormMenu.Nodes.Add("Slides", "Slide Scans")
        myParent.Nodes.Add("SlideScanFile", "Create Slide Scan Barcode")
        myParent.Nodes.Add("SlideScanView", "View Slide Scans")
        tvFormMenu.ExpandAll()
    End Sub
    Public Sub LoadReportsTreeView()
        tvFormMenu.Dock = DockStyle.Fill
        Dim myParent As New TreeNode
        Dim myChild As New TreeNode
        tvFormMenu.Show()

        tvFormMenu.Nodes.Clear()
        myParent = tvFormMenu.Nodes.Add("Blank", "Blank Forms")
        myParent = tvFormMenu.Nodes.Add("Donations", "Donation Referrals")
        myParent = tvFormMenu.Nodes.Add("NeuropathRequests", "Neuropath Requests")
        myParent = tvFormMenu.Nodes.Add("PreEnrollments", "Pre-Enrollments")
        myParent = tvFormMenu.Nodes.Add("PreEnrollAniv", "Pre-Enrollments Anniversaries")
        myParent = tvFormMenu.Nodes.Add("SubRecReport", "Subject Records Report")
        'myParent = tvFormMenu.Nodes.Add("MicroImages", "Microscopic Images")
        myParent = tvFormMenu.Nodes.Add("Progress", "Progress Reports")
        myChild = myParent.Nodes.Add("NPProgress", "NP Progress")
        myChild = myParent.Nodes.Add("PMCRProgress", "PMCR Progress")
        myParent = tvFormMenu.Nodes.Add("NBB", "NBB Reports")
        'myChild = myParent.Nodes.Add("NBB_Admin", "NBB Qtrly Admin")
        'myChild = myParent.Nodes.Add("NBB_Upload", "NBB Qtrly Upload")
        myParent = tvFormMenu.Nodes.Add("PurchaseRequests", "Purchase Requests")
        myParent = tvFormMenu.Nodes.Add("UserManagement", "User Management")
        myParent = tvFormMenu.Nodes.Add("FormPermissions", "Form Permissions")
        tvFormMenu.ExpandAll()
    End Sub
    Public Sub tvFormMenu_AfterSelect(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tvFormMenu.NodeMouseClick
        Select Case e.Node.Name.ToString

                '//////////SubjectNodes//////////
            Case "SS"
                btnSubjectRecords.PerformClick()
            Case "Summary"
                LoadWorkingAreaForm(formType.WA_ExistingSubjectRecords)
            Case "Demographics"
                LoadWorkingAreaForm(formType.WA_Demographics)
            Case "NoK"
                LoadWorkingAreaForm(formType.WA_NoK)
            Case "PreEnrollment_Detail"
                LoadWorkingAreaForm(formType.WA_PreEnrollments_Detail)
            Case "AutopsyFaceSheet"
                LoadWorkingAreaForm(formType.WA_AutopsyFaceSheet)
            Case "AutopsyDissectionMap"
                If Database.ExistingRecordCheck("AutopsyFaceSheet", "SubNum = " & SubNum) Then
                    LoadWorkingAreaForm(formType.WA_AutopsyDissectionMap)
                Else
                    MsgBox("The Autopsy Face Sheet has not been completed for this subject. This must be completed before an Autopsy Dissection Map can be created.", MsgBoxStyle.OkOnly, "Warning")
                End If
            Case "AutopsyBlockSampling"
                If Database.ExistingRecordCheck("AutopsyFaceSheet", "SubNum = " & SubNum) Then
                    LoadWorkingAreaForm(formType.WA_AutopsyBlockSampling)
                Else
                    MsgBox("The Autopsy Face Sheet has not been completed for this subject. This must be completed before an Autopsy Block Sampling can be created.", MsgBoxStyle.OkOnly, "Warning")
                End If
            Case "MRI_Tracking"
                LoadWorkingAreaForm(formType.WA_MRI_Tracking)
            Case "NPRequests"
                LoadWorkingAreaForm(formType.WA_NeuropathRequests)
            Case "SIS"
                LoadWorkingAreaForm(formType.WA_ShortInitialSummary)
            Case "CERADHeader"
                LoadWorkingAreaForm(formType.WA_CERAD_Header)
            Case "CERADB"
                LoadWorkingAreaForm(formType.WA_CERADB)
            Case "CERADC"
                LoadWorkingAreaForm(formType.WA_CERADC)
            Case "CERADD"
                LoadWorkingAreaForm(formType.WA_CERADD)
            Case "CERADE"
                LoadWorkingAreaForm(formType.WA_CERADE)
            Case "CERADF"
                LoadWorkingAreaForm(formType.WA_CERADF)
            Case "CERADGScreen"
                LoadWorkingAreaForm(formType.WA_CERADG_Screen)
            Case "CERADG1"
                LoadWorkingAreaForm(formType.WA_CERADG1)
            Case "CERADG2"
                LoadWorkingAreaForm(formType.WA_CERADG2)
            Case "CERADH"
                LoadWorkingAreaForm(formType.WA_CERADH)
            Case "CERADI"
                LoadWorkingAreaForm(formType.WA_CERADIJ)
            Case "CERADAddendum"
                LoadWorkingAreaForm(formType.WA_CERAD_Addendum)
            Case "CERADARTAG"
                LoadWorkingAreaForm(formType.WA_CERAD_ARTAG)
            Case "PlaqueCounts"
                LoadWorkingAreaForm(formType.WA_PlaqueCounts)
            Case "TangleCounts"
                LoadWorkingAreaForm(formType.WA_TangleCounts)
            Case "NPRegionMap"
                LoadWorkingAreaForm(formType.WA_NP_BrainRegionMap)
            Case "NPSummary"
                LoadWorkingAreaForm(formType.WA_NPSummary)
            Case "ConsensusDx"
                LoadWorkingAreaForm(formType.WA_ConsenusDx)
            Case "PMCR"
                LoadWorkingAreaForm(formType.WA_PMCR)
            Case "ClinSum"
                LoadWorkingAreaForm(formType.WA_ClinicalSummary)
            Case "MiscSubjectFiles"
                If ShowingPHI Then
                    LoadWorkingAreaForm(formType.WA_MiscSubjectFiles)
                Else
                    MsgBox("Please enable PHI before attempting to access this form.", MsgBoxStyle.OkOnly)
                End If

                '//////////TissueNodes//////////
            Case "MicroImages"
                LoadWorkingAreaForm(formType.WA_MicroscopicImages)
            Case "OnHand"
                LoadWorkingAreaForm(formType.WA_SpecimenOnHand)
            Case "OnHandCounts"
                LoadWorkingAreaForm(formType.WA_SpecimenOnHand_Counts)
            Case "Shipped"
                LoadWorkingAreaForm(formType.WA_TissueDistributions_Details)
            Case "DNA"
                LoadWorkingAreaForm(formType.WA_Specimen_DNA)
            Case "RNA"
                LoadWorkingAreaForm(formType.WA_Specimen_RNA)
            Case "DNARNAVolumes"
                LoadWorkingAreaForm(formType.WA_DNA_RNA_Volume)
            Case "Tasker"
                LoadWorkingAreaForm(formType.WA_TissueTaskerReport)
            Case "Request"
                LoadWorkingAreaForm(formType.WA_TissueRequest)
            Case "RequestBarcodes"
                Dim PU As New PU_BarcodeGenerator
                PU.ShowDialog()
                PU.Dispose()
            Case "SlideScanFile"
                LoadWorkingAreaForm(formType.WA_SlideScanBarcodesFile)
            Case "SlideScanView"
                LoadWorkingAreaForm(formType.WA_MicroscopicImages)

                '//////////ReportNodes//////////
            Case "Blank"
                LoadWorkingAreaForm(formType.WA_BlankForms)
            Case "Donations"
                LoadWorkingAreaForm(formType.WA_DonationReferrals)
            Case "NeuropathRequests"
                LoadWorkingAreaForm(formType.WA_Neuropath_Requests_Report)
            Case "PreEnrollments"
                LoadWorkingAreaForm(formType.WA_PreEnrollments)
            Case "PreEnrollAniv"
                LoadWorkingAreaForm(formType.WA_PreEnrollment_Anniversary)
            Case "SubRecReport"
                LoadWorkingAreaForm(formType.WA_ExistingRecordsReport)
            Case "MicroImages"
                LoadWorkingAreaForm(formType.WA_MicroscopicImages)
            Case "NPProgress"
                LoadWorkingAreaForm(formType.WA_NP_Progress)
            Case "NBB"
                LoadWorkingAreaForm(formType.WA_External_Reporting_Exports)
            Case "NBB_Admin"
                LoadWorkingAreaForm(formType.WA_NBB_QTR_Admin)
            Case "PurchaseRequests"
                LoadWorkingAreaForm(formType.WA_PurchaseRequests)
            Case "UserManagement"
                LoadWorkingAreaForm(formType.WA_UserManagement)
            Case "FormPermissions"
                LoadWorkingAreaForm(formType.WA_FormPermissions)
        End Select
    End Sub
    Public Sub highlightSelectedNode(formName As String)
        Dim myNode As TreeNode
        For Each myNode In tvFormMenu.Nodes()
            myNode.BackColor = Color.Tan
            Dim subNode As TreeNode
            For Each subNode In myNode.Nodes()
                subNode.BackColor = Color.Tan
                Dim subSubNode As TreeNode
                For Each subSubNode In subNode.Nodes()
                    subSubNode.BackColor = Color.Tan
                Next
            Next
        Next myNode

        If Group = "NBTR" Then
            Select Case formName
                Case "WA_ExistingSubjectRecords"
                    tvFormMenu.Nodes("Subject").Nodes("Summary").BackColor = Color.Chartreuse
                Case "WA_Demographics"
                    If Not IsNothing(SubNum) Then 'Special case. Tree does not load when initially creating a new subject
                        tvFormMenu.Nodes("Demographics").BackColor = Color.Chartreuse
                    End If
                Case "WA_NoK"
                    tvFormMenu.Nodes("Subject").Nodes("NoK").BackColor = Color.Chartreuse
                Case "WA_Neuropath_Requests_Report"
                    tvFormMenu.Nodes("NeuropathRequests").BackColor = Color.Chartreuse
                Case "WA_PreEnrollments_Detail"
                    tvFormMenu.Nodes("Subject").Nodes("PreEnrollment_Detail").BackColor = Color.Chartreuse
                Case "WA_AutopsyFaceSheet"
                    tvFormMenu.Nodes("Autopsy").Nodes("AutopsyFaceSheet").BackColor = Color.Chartreuse
                Case "WA_AutopsyDissectionMap"
                    tvFormMenu.Nodes("Autopsy").Nodes("AutopsyDissectionMap").BackColor = Color.Chartreuse
                Case "WA_AutopsyBlockSampling"
                    tvFormMenu.Nodes("Autopsy").Nodes("AutopsyBlockSampling").BackColor = Color.Chartreuse
                Case "WA_MRI_Tracking"
                    tvFormMenu.Nodes("Autopsy").Nodes("MRI_Tracking").BackColor = Color.Chartreuse
                Case "WA_ShortInitialSummary"
                    tvFormMenu.Nodes("Autopsy").Nodes("SIS").BackColor = Color.Chartreuse
                Case "WA_NP_Progress"
                    tvFormMenu.Nodes("Progress").Nodes("NPProgress").BackColor = Color.Chartreuse
                Case "WA_CERAD_Header"
                    tvFormMenu.Nodes("Neuropath").Nodes("CERAD").Nodes("CERADHeader").BackColor = Color.Chartreuse
                Case "WA_CERADB"
                    tvFormMenu.Nodes("Neuropath").Nodes("CERAD").Nodes("CERADB").BackColor = Color.Chartreuse
                Case "WA_CERADC"
                    tvFormMenu.Nodes("Neuropath").Nodes("CERAD").Nodes("CERADC").BackColor = Color.Chartreuse
                Case "WA_CERADD"
                    tvFormMenu.Nodes("Neuropath").Nodes("CERAD").Nodes("CERADD").BackColor = Color.Chartreuse
                Case "WA_CERADE"
                    tvFormMenu.Nodes("Neuropath").Nodes("CERAD").Nodes("CERADE").BackColor = Color.Chartreuse
                Case "WA_CERADF"
                    tvFormMenu.Nodes("Neuropath").Nodes("CERAD").Nodes("CERADF").BackColor = Color.Chartreuse
                Case "WA_CERADG_Screen"
                    tvFormMenu.Nodes("Neuropath").Nodes("CERAD").Nodes("CERADGScreen").BackColor = Color.Chartreuse
                Case "WA_CERADG1"
                    tvFormMenu.Nodes("Neuropath").Nodes("CERAD").Nodes("CERADG1").BackColor = Color.Chartreuse
                Case "WA_CERADG2"
                    tvFormMenu.Nodes("Neuropath").Nodes("CERAD").Nodes("CERADG2").BackColor = Color.Chartreuse
                Case "WA_CERADH"
                    tvFormMenu.Nodes("Neuropath").Nodes("CERAD").Nodes("CERADH").BackColor = Color.Chartreuse
                Case "WA_CERADIJ"
                    tvFormMenu.Nodes("Neuropath").Nodes("CERAD").Nodes("CERADI").BackColor = Color.Chartreuse
                Case "WA_CERAD_Addendum"
                    tvFormMenu.Nodes("Neuropath").Nodes("CERAD").Nodes("CERADAddendum").BackColor = Color.Chartreuse
                Case "WA_CERAD_ARTAG"
                    tvFormMenu.Nodes("Neuropath").Nodes("CERAD").Nodes("CERADARTAG").BackColor = Color.Chartreuse
                Case "WA_PlaqueCounts"
                    tvFormMenu.Nodes("Neuropath").Nodes("PlaqueCounts").BackColor = Color.Chartreuse
                Case "WA_TangleCounts"
                    tvFormMenu.Nodes("Neuropath").Nodes("TangleCounts").BackColor = Color.Chartreuse
                Case "WA_NPRegionMap"
                    tvFormMenu.Nodes("Neuropath").Nodes("NPRegionMap").BackColor = Color.Chartreuse
                Case "WA_NPSummary"
                    tvFormMenu.Nodes("Neuropath").Nodes("NPSummary").BackColor = Color.Chartreuse
                Case "WA_ConsensusDx"
                    tvFormMenu.Nodes("Neuropath").Nodes("ConsensusDx").BackColor = Color.Chartreuse
                Case "WA_PMCR"
                    tvFormMenu.Nodes("PMCR").BackColor = Color.Chartreuse
                Case "WA_ClinicalSummary"
                    tvFormMenu.Nodes("ClinSum").BackColor = Color.Chartreuse
                Case "WA_SpecimenOnHand"
                    tvFormMenu.Nodes("Tissue").Nodes("OnHand").BackColor = Color.Chartreuse
                Case "WA_SpecimenOnHand_Counts"
                    tvFormMenu.Nodes("Tissue").Nodes("OnHandCounts").BackColor = Color.Chartreuse
                Case "WA_TissueDistributions_Details"
                    tvFormMenu.Nodes("Tissue").Nodes("Shipped").BackColor = Color.Chartreuse
                Case "WA_Specimen_DNA"
                    tvFormMenu.Nodes("Tissue").Nodes("DNA").BackColor = Color.Chartreuse
                Case "WA_Specimen_RNA"
                    tvFormMenu.Nodes("Tissue").Nodes("RNA").BackColor = Color.Chartreuse
                Case "WA_DNA_RNA_Volume"
                    tvFormMenu.Nodes("Tissue").Nodes("DNARNAVolumes").BackColor = Color.Chartreuse
                Case "WA_SlideScanBarcodeFile"
                    tvFormMenu.Nodes("Slides").Nodes("SlideScanFile").BackColor = Color.Chartreuse
                Case "WA_TissueRequest"
                    tvFormMenu.Nodes("Requests").Nodes("Request").BackColor = Color.Chartreuse
                Case "WA_TissueTasker"
                    tvFormMenu.Nodes("Requests").Nodes("Tasker").BackColor = Color.Chartreuse
                    ActiveControl = WorkingAreaForm
                Case "WA_ExistingRecordsReport"
                    tvFormMenu.Nodes("SubRecReport").BackColor = Color.Chartreuse
                Case "WA_MicroscopicImages"
                    tvFormMenu.Nodes("MicroImages").BackColor = Color.Chartreuse
                Case "WA_PurchaseRequests"
                    tvFormMenu.Nodes("PurchaseRequests").BackColor = Color.Chartreuse
                Case "WA_UserManagement"
                    tvFormMenu.Nodes("UserManagement").BackColor = Color.Chartreuse
                Case "WA_FormPermissions"
                    tvFormMenu.Nodes("FormPermissions").BackColor = Color.Chartreuse
                Case "WA_ADRC_StudyParticipation"
                    tvFormMenu.Nodes("ADRC").Nodes("ADRCStudyParticipation").BackColor = Color.Chartreuse
                Case "WA_ADRC_Consensus_Cover"
                    tvFormMenu.Nodes("ADRC").Nodes("ADRCConArchive").BackColor = Color.Chartreuse
                Case "WA_ADRC_Summary_Cover"
                    tvFormMenu.Nodes("ADRC").Nodes("ADRCSumArchive").BackColor = Color.Chartreuse
                Case "WA_ADRC_ITA_Cover"
                    tvFormMenu.Nodes("ADRC").Nodes("ADRCITAArchive").BackColor = Color.Chartreuse
                Case "WA_ADRC_RUI_Cover"
                    tvFormMenu.Nodes("ADRC").Nodes("ADRCRUI").BackColor = Color.Chartreuse
                Case "WA_ADRC_AmyloidImaging_Cover"
                    tvFormMenu.Nodes("ADRC").Nodes("ADRCAmyloid").BackColor = Color.Chartreuse
                Case "WA_ADRC_SuppNPScoring_Cover"
                    tvFormMenu.Nodes("ADRC").Nodes("ADRCSuppNPScoring").BackColor = Color.Chartreuse
                Case "WA_ADRC_CGIC_Cover"
                    tvFormMenu.Nodes("ADRC").Nodes("ADRCCGIC").BackColor = Color.Chartreuse
                Case "WA_ADRC_CIRS_Cover"
                    tvFormMenu.Nodes("ADRC").Nodes("ADRCCIRS").BackColor = Color.Chartreuse
                Case "WA_ADRC_StudyPartner"
                    tvFormMenu.Nodes("ADRC").Nodes("ADRCStudyPartner").BackColor = Color.Chartreuse
                Case "WA_MiscSubjectFiles"
                    tvFormMenu.Nodes("MiscSubjectFiles").BackColor = Color.Chartreuse
                Case "WA_NBB_QTR_Admin"
                    tvFormMenu.Nodes("NBB").Nodes("NBB_Admin").BackColor = Color.Chartreuse

            End Select
        End If
    End Sub

    'Age calc function
    Public Function calcAge(ByVal DoB As Date, ByVal endDate As Date) As Integer
        Dim result As Integer = DateDiff("yyyy", DoB, endDate)
        If endDate < DateSerial(endDate.Year, DoB.Month, DoB.Day) Then
            result -= 1
        End If
        Return result
    End Function
End Class