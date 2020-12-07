Imports iTextSharp.text.pdf
Imports System.IO
Imports System

Public Class WA_TissueRequest
    Implements IFormMethods

    Private insertString As String = Nothing
    Private updateString As String = Nothing
    Private formTables As New DataSet
    Private tooltip1 As New ToolTip
    Private projectBS As BindingSource
    Public ProjectID As String
    Private userFilterString As String = ""
    Private showingCompleted As Boolean = True
    Private showingHidden As Boolean = False
    Private tempString As String = ""
    'Private prepPU As PU_TissueRequest_SelectPreparation

    Private Sub WA_TissueProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
        WarehouseShell.highlightSelectedNode("WA_TissueRequest")
        loadDataGridView()
        loadComboValues()
        enableInputFields()
        rdoExtSampDesc.Checked = True
    End Sub

    Private Sub loadDataGridView()
        formTables.Tables.Clear()
        formTables.Tables.Add(Database.ReturnTable("TissueRequests", "ProjectID, NBTRRequestNum as 'NBTR Req #', Project, SubProject as 'Sub Project', ProjectTitle, RequestingPI as 'Requesting PI', POCName as 'POC Name', DateShipped as 'Date Shipped', Hidden, NBBURL", , "ProjectID desc"))
        projectBS = New BindingSource
        projectBS.DataSource = formTables.Tables("TissueRequests")
        dgvTissueRequests.DataSource = projectBS
        dgvTissueRequests.Columns("ProjectTitle").Visible = False
        dgvTissueRequests.Columns("Hidden").Visible = False
        dgvTissueRequests.Columns("NBBURL").Visible = False
        dgvTissueRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        UpdateFilter()
    End Sub

    Private Sub loadComboValues()
        formTables.Tables.Add(Database.ReturnTable("lkpShippingMethods"))
        formTables.Tables.Add(Database.ReturnTable("lkp0_10"))
        comboShippingMethod.DataSource = New DataView(formTables.Tables("lkpShippingMethods"))
        comboShippingMethod.DisplayMember = "Label"
        comboShippingMethod.ValueMember = "Label"
        comboReqShippingMethod.DataSource = New DataView(formTables.Tables("lkpShippingMethods"))
        comboReqShippingMethod.DisplayMember = "Label"
        comboReqShippingMethod.ValueMember = "Label"
        cmbBlackCaps.assignLookup(formTables, "lkp0_10",,,, "Value")
        cmbBlackCaps.SelectedValue = 0
    End Sub

    Private Sub enableInputFields()
        'Disable everything
        chkDistroApproved.Enabled = False
        txtProject.makeReadOnly(True)
        txtSubProject.makeReadOnly(True)
        txtProjectTitle.makeReadOnly(True)
        txtRequestingPI.makeReadOnly(True)
        txtPIEmail.makeReadOnly(True)
        txtNBTRReqNum.makeReadOnly(True)
        txtNBBURL.makeReadOnly(True)
        dtRequestDate.makeReadOnly(True)
        txtInternalSampleDesc.makeReadOnly(True)
        txtExternalSampleDesc.makeReadOnly(True)
        txtBrainRegions.makeReadOnly(True)
        txtTissuePreparations.makeReadOnly(True)
        btnBrainRegionModify.Enabled = False
        btnTissuePrepModify.Enabled = False
        txtDistributiveDiagnosis.makeReadOnly(True)
        intNumSamples.makeReadOnly(True)
        txtSampleType.makeReadOnly(True)
        cmbBlackCaps.Enabled = False
        'leave the tissue file button enabled if a tissue file already exists, otherwise disable it (so users cannot add a file in view mode)
        If SystemFiles1to1.CheckFile("fileTissueProjectDetailSpreadsheet", ProjectID) Then
            btnAddTissueFile.Enabled = True
        Else
            btnAddTissueFile.Enabled = False
        End If
        btnRemoveTissueFile.Enabled = False
        txtPOCName.makeReadOnly(True)
        txtPOCEmail.makeReadOnly(True)
        txtPOCPhone.makeReadOnly(True)
        txtInstituteName.makeReadOnly(True)
        txtAddress1.makeReadOnly(True)
        txtAddress2.makeReadOnly(True)
        txtAddress3.makeReadOnly(True)
        txtAddress4.makeReadOnly(True)
        txtCity.makeReadOnly(True)
        txtState.makeReadOnly(True)
        txtZip.makeReadOnly(True)
        comboReqShippingMethod.Enabled = False
        txtReqShipAcctNum.makeReadOnly(True)
        txtDateShipped.makeReadOnly(True)
        comboShippingMethod.Enabled = False
        txtTrackingNum.makeReadOnly(True)
        btnAddShippingFile.Enabled = False
        btnRemoveShippingDoc.Enabled = False
        chkHideProject.Enabled = False
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
            'Enable fields required for insert
            txtProject.makeReadOnly(False)
            txtSubProject.makeReadOnly(False)
            txtProjectTitle.makeReadOnly(False)
            txtRequestingPI.makeReadOnly(False)
            txtPIEmail.makeReadOnly(False)
            txtNBTRReqNum.makeReadOnly(False)
            txtNBBURL.makeReadOnly(False)
            dtRequestDate.makeReadOnly(False)
            txtInternalSampleDesc.makeReadOnly(False)
            txtExternalSampleDesc.makeReadOnly(False)
            btnBrainRegionModify.Enabled = True
            btnTissuePrepModify.Enabled = True
            txtDistributiveDiagnosis.makeReadOnly(False)
            intNumSamples.makeReadOnly(False)
            txtSampleType.makeReadOnly(False)
            cmbBlackCaps.Enabled = True
            txtPOCName.makeReadOnly(False)
            txtPOCEmail.makeReadOnly(False)
            txtPOCPhone.makeReadOnly(False)
            txtInstituteName.makeReadOnly(False)
            txtAddress1.makeReadOnly(False)
            txtAddress2.makeReadOnly(False)
            txtAddress3.makeReadOnly(False)
            txtAddress4.makeReadOnly(False)
            txtCity.makeReadOnly(False)
            txtState.makeReadOnly(False)
            txtZip.makeReadOnly(False)
            comboReqShippingMethod.Enabled = True
            txtReqShipAcctNum.makeReadOnly(False)
            chkDistroApproved.Enabled = True
            chkHideProject.Enabled = True
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            'Enable TissueFile button if file exists (so user can view it)
            btnViewTissueSamples.Enabled = True
            If User.CheckPermission("TissueProjectOverride") Then
                btnAddTissueFile.Enabled = True
                btnAddDistroDoc.Enabled = True
                btnRemoveDistroDoc.Enabled = True
            End If
            If btnAddShippingFile.Text = "View Shipping Scan" Then
                btnAddShippingFile.Enabled = True
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit Then
            'Enable appropriate fields for editing
            chkDistroApproved.Enabled = True
            txtProject.makeReadOnly(False)
            txtSubProject.makeReadOnly(False)
            txtProjectTitle.makeReadOnly(False)
            txtRequestingPI.makeReadOnly(False)
            txtPIEmail.makeReadOnly(False)
            txtNBTRReqNum.makeReadOnly(False)
            txtNBBURL.makeReadOnly(False)
            dtRequestDate.makeReadOnly(False)
            txtInternalSampleDesc.makeReadOnly(False)
            txtExternalSampleDesc.makeReadOnly(False)
            btnBrainRegionModify.Enabled = True
            btnTissuePrepModify.Enabled = True
            txtDistributiveDiagnosis.makeReadOnly(False)
            intNumSamples.makeReadOnly(False)
            txtSampleType.makeReadOnly(False)
            cmbBlackCaps.Enabled = True
            btnViewTissueSamples.Enabled = True
            btnAddTissueFile.Enabled = True
            If SystemFiles1to1.CheckFile("fileTissueProjectDetailSpreadsheet", ProjectID) Then
                btnRemoveTissueFile.Enabled = True
            End If
            txtPOCName.makeReadOnly(False)
            txtPOCEmail.makeReadOnly(False)
            txtPOCPhone.makeReadOnly(False)
            txtInstituteName.makeReadOnly(False)
            txtAddress1.makeReadOnly(False)
            txtAddress2.makeReadOnly(False)
            txtAddress3.makeReadOnly(False)
            txtAddress4.makeReadOnly(False)
            txtCity.makeReadOnly(False)
            txtState.makeReadOnly(False)
            txtZip.makeReadOnly(False)
            comboReqShippingMethod.Enabled = True
            txtReqShipAcctNum.makeReadOnly(False)
            If chkDistroApproved.Checked = True Then
                txtDateShipped.makeReadOnly(False)
                comboShippingMethod.Enabled = True
                txtTrackingNum.makeReadOnly(False)
                btnAddShippingFile.Enabled = True
                If SystemFiles1to1.CheckFile("fileTissueProjectShippingScan", ProjectID) Then
                    btnRemoveShippingDoc.Enabled = True
                End If
            End If
            chkHideProject.Enabled = True
        End If
    End Sub

    'Define button click events
    'Filter events
    Private Sub btnDGVFilter_Click(sender As Object, e As EventArgs) Handles btnDGVFilter.Click
        If showingCompleted = True Then
            showingCompleted = False
            btnDGVFilter.Text = "Show Completed Projects"
        Else
            showingCompleted = True
            btnDGVFilter.Text = "Hide Completed Projects"
        End If
        UpdateFilter()
    End Sub
    Private Sub btnFilterDGV_Click(sender As Object, e As EventArgs) Handles btnFilterDGV.Click
        'Check to see if the filter box has a value
        userFilterString = "(" & "Project like '%" & txtFilterString.Text &
            "%' or [Sub Project] like '%" & txtFilterString.Text &
            "%' or [Requesting PI] like '%" & txtFilterString.Text &
            "%' or [POC Name] like '%" & txtFilterString.Text &
            "%' or ProjectTitle like '%" & txtFilterString.Text &
            IIf(IsNumeric(txtFilterString.Text), "%' or [NBTR Req #] = " & txtFilterString.Text & " or ProjectID = " & txtFilterString.Text, "%'") &
            ")"
        UpdateFilter()
    End Sub
    Private Sub txtFilterString_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilterString.KeyDown
        'If the user presses the Enter key while in the filter text box, apply filter
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnFilterDGV.PerformClick()
        End If
    End Sub
    Private Sub btnResetDGV_Click(sender As Object, e As EventArgs) Handles btnResetDGV.Click
        'Clear the filter text box and apply the empty filter (returning all records)
        txtFilterString.Text = ""
        btnFilterDGV.PerformClick()
    End Sub
    Private Sub btnAddSubProj_Click(sender As Object, e As EventArgs) Handles btnAddSubProjBottom.Click, btnAddSubProjTop.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Or WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit Then
            Dim checkform As New PU_SaveWork
            Dim myResult As DialogResult = checkform.ShowDialog
            If myResult = Windows.Forms.DialogResult.OK Then
                SaveWork()
            ElseIf myResult = DialogResult.Cancel Then
                Exit Sub
            End If
            btnNewProjectBottom.Text = "Add New Project"
            btnNewProjectTop.Text = btnNewProjectBottom.Text
            checkform.Dispose()
        Else
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
            enableInputFields()
            txtProjectID.Text = getNextProjectID()
            chkDistroApproved.Checked = False
            dtDateApprovedForDistro.Clear()
            comboShippingMethod.SelectedValue = -1
            txtReqShipAcctNum.Clear()
            txtDateShipped.Clear()
            comboShippingMethod.SelectedValue = -1
            txtTrackingNum.Clear()
            btnNewProjectBottom.Text = "Save New SubProject"
            btnNewProjectTop.Text = btnNewProjectBottom.Text
            txtSubProject.Focus()
        End If
    End Sub
    Private Sub btnToggleHidden_Click(sender As Object, e As EventArgs) Handles btnToggleHidden.Click
        If showingHidden = False Then
            showingHidden = True
            btnToggleHidden.Text = "Hide Hidden Projects"
        Else
            showingHidden = False
            btnToggleHidden.Text = "Show Hidden Projects"
        End If
        UpdateFilter()
    End Sub
    Private Sub UpdateFilter()
        Dim filterString As String = ""
        If userFilterString <> "" Then
            filterString = userFilterString
        End If
        If showingCompleted = False Then
            If filterString = "" Then
                filterString = "([Date Shipped] is null)"
            Else
                filterString += " and ([Date Shipped] is null)"
            End If
        End If
        If showingHidden = False Then
            If filterString = "" Then
                filterString = "(Hidden = 0)"
            Else
                filterString += " and (Hidden = 0)"
            End If
        End If
        projectBS.Filter = filterString
    End Sub

    Public Function PreSaveValidation() As Boolean
        Dim result As Boolean = True
        Dim errorMessage As String = ""

        If txtProject.Text = "" Then
            result = False
            errorMessage += "- Please provide a project name." & vbNewLine
        End If

        'Handle result
        If result = False Then
            MsgBox("The following errors must be corrected before this record can be saved: " & vbNewLine & vbNewLine & errorMessage, MsgBoxStyle.OkOnly, "Error")
        End If
        Return result
    End Function
    Private Sub ClearInputFields()
        chkDistroApproved.Checked = False
        dtDateApprovedForDistro.Clear()
        txtProjectID.Clear()
        txtProject.Clear()
        txtSubProject.Clear()
        txtProjectTitle.Clear()
        txtNBBURL.Clear()
        txtNBTRReqNum.Clear()
        dtRequestDate.Clear()
        txtRequestingPI.Clear()
        txtPIEmail.Clear()
        rdoIntSampDesc.Checked = False
        rdoExtSampDesc.Checked = False
        txtInternalSampleDesc.Clear()
        txtExternalSampleDesc.Clear()
        txtBrainRegions.Clear()
        txtTissuePreparations.Clear()
        txtDistributiveDiagnosis.Clear()
        txtSampleType.Clear()
        intNumSamples.Clear()
        cmbBlackCaps.SelectedValue = 0
        txtPOCName.Clear()
        txtPOCEmail.Clear()
        txtPOCPhone.Clear()
        txtInstituteName.Clear()
        txtAddress1.Clear()
        txtAddress2.Clear()
        txtAddress3.Clear()
        txtAddress4.Clear()
        txtCity.Clear()
        txtState.Clear()
        txtZip.Clear()
        comboReqShippingMethod.SelectedValue = 1
        txtReqShipAcctNum.Clear()
        txtDateShipped.Clear()
        comboShippingMethod.SelectedValue = 1
        txtTrackingNum.Clear()
        chkHideProject.Checked = False
    End Sub

    'Edit existing record events
    Private Sub btnTissueEditBottom_Click(sender As Object, e As EventArgs) Handles btnTissueEditBottom.Click, btnTissueEditTop.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            'Check user permissions for TissueProjectOveride, if true, unlock everything
            If User.PermissionCheck("WA_TissueRequest", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                enableInputFields()
                btnTissueEditBottom.Text = "Save Changes"
                btnTissueEditTop.Text = btnTissueEditBottom.Text
            Else
                'Unlock the shipping fields and set mode to edit if distro is approved, else unlock nothing.
                If txtDateShipped.Text <> "  /  /" Then
                    If User.PermissionCheck("WA_TissueRequest", "Modify") Then
                        btnAddShippingFile.Enabled = True
                        If SystemFiles1to1.CheckFile("fileTissueProjectShippingScan", ProjectID) Then
                            btnRemoveShippingDoc.Enabled = True
                        End If
                    Else
                        MsgBox("This record is completed and locked. It may only be modified by Dr. Haroutunian.", MsgBoxStyle.OkOnly, "Record Locked")
                    End If
                ElseIf chkDistroApproved.Checked = False Then
                    MsgBox("This record is not yet approved for distribution and is locked. It may only be modified by Dr. Haroutunian.", MsgBoxStyle.OkOnly, "Record Locked")
                Else
                    If chkDistroApproved.Checked = True Then
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                        txtDateShipped.makeReadOnly(False)
                        comboShippingMethod.Enabled = True
                        txtTrackingNum.makeReadOnly(False)
                        btnAddShippingFile.Enabled = True
                        If SystemFiles1to1.CheckFile("fileTissueProjectShippingScan", ProjectID) Then
                            btnRemoveShippingDoc.Enabled = True
                        End If
                        btnTissueEditBottom.Text = "Save Changes"
                        btnTissueEditTop.Text = btnTissueEditBottom.Text
                    End If
                End If
            End If
        Else
            If SystemFiles1to1.CheckFile("fileTissueProjectShippingScan", ProjectID) = False And txtDateShipped.Text <> "  /  /" And comboShippingMethod.Text <> "Courier" And comboShippingMethod.Text <> "In House" Then
                Dim result As DialogResult = MsgBox("You are attempting to ship this project WITHOUT uploading a scan of the shipping document. Are you sure you want to continue?", MsgBoxStyle.YesNo, "Warning")
                If result = DialogResult.Yes Then
                    saveUpdate()
                End If
            Else
                saveUpdate()
            End If
        End If
    End Sub
    Private Sub saveUpdate()
        Try
            Dim updateCommand As New SqlCommand
            updateString = "@ProjectID = '" & ProjectID &
            "', @Project = " & txtProject.getSQLValue() &
            ", @SubProject = " & IIf(txtSubProject.Text = "", "''", "'" & Replace(txtSubProject.Text, "'", "''") & "'") &
            ", @ProjectTitle = " & txtProjectTitle.getSQLValue() &
            ", @RequestingPI = " & txtRequestingPI.getSQLValue() &
            ", @PIEmail = " & txtPIEmail.getSQLValue() &
            ", @NBTRRequestNum = " & txtNBTRReqNum.getSQLValue() &
            ", @NBBURL = " & txtNBBURL.getSQLValue() &
            ", @RequestDate = " & dtRequestDate.getSQLValue() &
            ", @InternalSampleDescription = " & txtInternalSampleDesc.getSQLValue() &
            ", @ExternalSampleDescription = " & txtExternalSampleDesc.getSQLValue() &
            ", @BrainRegions = " & txtBrainRegions.getSQLValue() &
            ", @TissuePreparations = " & txtTissuePreparations.getSQLValue() &
            ", @DistributiveDx = " & txtDistributiveDiagnosis.getSQLValue() &
            ", @NumSamples = " & intNumSamples.getSQLValue() &
            ", @NumGenerics = " & cmbBlackCaps.getSQLValue() &
            ", @SampleType = " & txtSampleType.getSQLValue() &
            ", @POCName = " & txtPOCName.getSQLValue() &
            ", @POCEmail = " & txtPOCEmail.getSQLValue() &
            ", @POCPhone = " & txtPOCPhone.getSQLValue() &
            ", @InstituteName = " & txtInstituteName.getSQLValue() &
            ", @Address1 = " & txtAddress1.getSQLValue() &
            ", @Address2 = " & txtAddress2.getSQLValue() &
            ", @Address3 = " & txtAddress3.getSQLValue() &
            ", @Address4 = " & txtAddress4.getSQLValue() &
            ", @City = " & txtCity.getSQLValue() &
            ", @State = " & txtState.getSQLValue() &
            ", @Zip = " & txtZip.getSQLValue() &
            ", @ReqShipMethod = " & comboReqShippingMethod.getSQLValue() &
            ", @ReqShipAcctNum = " & txtReqShipAcctNum.getSQLValue() &
            ", @DateShipped = " & txtDateShipped.getSQLValue() &
            ", @ShippingMethod = " & comboShippingMethod.getSQLValue() &
            ", @TrackingNum = " & txtTrackingNum.getSQLValue() &
            ", @ApprovedForDistro = " & chkDistroApproved.getSQLValue() &
            ", @ApprovedForDistroDate = " & dtDateApprovedForDistro.getSQLValue() &
            ", @Hidden = " & chkHideProject.getSQLValue() & ";"
            updateCommand.CommandText = "EXEC dbo.UpdateTissueRequestsRecord " & updateString
            updateCommand.Connection = WarehouseShell.conn
            updateCommand.ExecuteNonQuery()
            UpdateTissueTasker()
            MessageBox.Show("Changes saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            enableInputFields()
            If txtDateShipped.Text <> "  /  /" Then
                markAsShipped(txtProjectID.getSQLValue())
            End If
            btnTissueEditBottom.Text = "Edit This Project"
            btnTissueEditTop.Text = btnTissueEditBottom.Text
            loadDataGridView()
        Catch ex As SqlException
            ExceptionHandler.CatchSQLException(ex)
        End Try
    End Sub
    Private Sub markAsShipped(ByVal ProjectID As String)
        Dim cmd As New SqlCommand("UPDATE specimen SET shipped = 1 WHERE ProjectID = " & ProjectID & ";", WarehouseShell.conn)
        cmd.ExecuteNonQuery()
    End Sub
    'Add new record events
    Private Sub btnNewProject_Click(sender As Object, e As EventArgs) Handles btnNewProjectBottom.Click, btnNewProjectTop.Click
        'Handle unsaved work if exists
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit Then
            Dim checkform As New PU_SaveWork
            Dim myResult As DialogResult = checkform.ShowDialog
            If myResult = Windows.Forms.DialogResult.OK Then
                SaveWork()

            ElseIf myResult = DialogResult.Cancel Then
                Exit Sub
            End If
            checkform.Dispose()
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        End If
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
            Try
                Dim cmd As New SqlCommand
                insertString = "@Project = " & txtProject.getSQLValue() &
                    ", @SubProject = " & IIf(txtSubProject.Text = "", "''", "'" & Replace(txtSubProject.Text, "'", "''") & "'") &
                    ", @ProjectTitle = " & txtProjectTitle.getSQLValue() &
                    ", @RequestingPI = " & txtRequestingPI.getSQLValue() &
                    ", @PIEmail = " & txtPIEmail.getSQLValue() &
                    ", @NBTRRequestNum = " & txtNBTRReqNum.getSQLValue() &
                    ", @NBBURL = " & txtNBBURL.getSQLValue() &
                    ", @RequestDate = " & dtRequestDate.getSQLValue() &
                    ", @InternalSampleDescription = " & txtInternalSampleDesc.getSQLValue() &
                    ", @ExternalSampleDescription = " & txtExternalSampleDesc.getSQLValue() &
                    ", @BrainRegions = " & txtBrainRegions.getSQLValue() &
                    ", @TissuePreparations = " & txtTissuePreparations.getSQLValue() &
                    ", @DistributiveDx = " & txtDistributiveDiagnosis.getSQLValue() &
                    ", @NumSamples = " & intNumSamples.getSQLValue() &
                    ", @NumGenerics = " & cmbBlackCaps.getSQLValue() &
                    ", @SampleType = " & txtSampleType.getSQLValue() &
                    ", @POCName = " & txtPOCName.getSQLValue() &
                    ", @POCEmail = " & txtPOCName.getSQLValue() &
                    ", @POCPhone = " & txtPOCPhone.getSQLValue() &
                    ", @InstituteName = " & txtInstituteName.getSQLValue() &
                    ", @Address1 = " & txtAddress1.getSQLValue() &
                    ", @Address2 = " & txtAddress2.getSQLValue() &
                    ", @Address3 = " & txtAddress3.getSQLValue() &
                    ", @Address4 = " & txtAddress4.getSQLValue() &
                    ", @City = " & txtCity.getSQLValue() &
                    ", @State = " & txtState.getSQLValue() &
                    ", @Zip = " & txtZip.getSQLValue() &
                    ", @ReqShipMethod = " & comboReqShippingMethod.getSQLValue() &
                    ", @ReqShipAcctNum = " & txtReqShipAcctNum.getSQLValue() &
                    ", @DateShipped = " & txtDateShipped.getSQLValue() &
                    ", @ShippingMethod = " & comboShippingMethod.getSQLValue() &
                    ", @TrackingNum = " & txtTrackingNum.getSQLValue() &
                    ", @ApprovedForDistro = " & chkDistroApproved.getSQLValue() &
                    ", @ApprovedForDistroDate = " & dtDateApprovedForDistro.getSQLValue() &
                    ", @Hidden = " & chkHideProject.getSQLValue() & ";"
                cmd.CommandText = "EXEC dbo.InsertTissueRequestsRecord " & insertString
                cmd.Connection = WarehouseShell.conn
                cmd.ExecuteNonQuery()
                If txtDateShipped.Text <> "  /  /" Then
                    markAsShipped(txtProjectID.getSQLValue())
                End If
                MessageBox.Show("Changes saved. Proceeding to create new Tissue Tasker.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                'Grab the Project Name, SubProjet Name, and ProjectID for the newly created Project and store them in the WarehouseShell
                WarehouseShell.StringArray = {txtProject.Text, txtSubProject.Text, txtInternalSampleDesc.Text, txtNBTRReqNum.Text, intNumSamples.Text, cmbBlackCaps.Text}
                Dim cmd2 As New SqlCommand("Select Max(ProjectID) from TissueRequests;", WarehouseShell.conn)
                WarehouseShell.RecordID = cmd2.ExecuteScalar().ToString
                'Load a new TissueTasker in insert mode (Project, SubProject, and ProjectID will populate on-load inside of the TissueTasker)
                WarehouseShell.LoadWorkingAreaForm(WarehouseShell.formType.WA_TissueTasker)
            Catch ex As SqlException
                ExceptionHandler.CatchSQLException(ex)
            End Try
        Else
            If User.PermissionCheck("WA_TissueRequest", "Modify") Then
                'Set datamode to insert
                If Database.ExistingRecordCheck("refUser", "UserName = '" & WarehouseShell.userName & "' and TissueProjectOverride = 1") = True Then
                    WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
                    'Clear input fields
                    ClearInputFields()
                    'Enable appropriate input fields (based on datamode)
                    enableInputFields()
                    'Update button text
                    btnNewProjectBottom.Text = "Save New Project"
                    btnNewProjectTop.Text = btnNewProjectBottom.Text
                    'Set request date to today()
                    dtRequestDate.Text = Now().ToString("MM/dd/yyyy")
                    'Hide the existing record button
                    btnTissueEditBottom.Visible = False
                    btnTissueEditTop.Visible = False
                Else
                    MsgBox("You do not have permission to add a new Tissue Request. Please contact Dr. Haroutunian if you believe you should have this permission.", MsgBoxStyle.OkOnly, "Permission Denied")
                End If
            End If
        End If
    End Sub
    Private Sub btnViewTissueSamples_Click(sender As Object, e As EventArgs) Handles btnViewTissueSamples.Click
        PU_TissueRequestAssociatedTissue.Show()
    End Sub
    Private Sub chkDistroApproved_CheckedChanged(sender As Object, e As EventArgs) Handles chkDistroApproved.CheckedChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
            If chkDistroApproved.Checked = True Then
                If Database.ExistingRecordCheck("TissueTasker", "ProjectID = " & ProjectID & " and CompDate is null") Then
                    Dim result As MsgBoxResult
                    result = MsgBox("The Tissue Tasker associated with this request is not yet completed. " & vbNewLine & vbNewLine & "Are you SURE you would like to authorize this request for distrobution?", MsgBoxStyle.YesNo, "Warning!")
                    If result = MsgBoxResult.No Then
                        chkDistroApproved.Checked = False
                        Exit Sub
                    End If
                Else
                    Dim cmd As New SqlCommand("select count(*) from Specimen where ProjectID = " & txtProjectID.Text, WarehouseShell.conn)
                    Dim NumSpecimenInDB As Integer = cmd.ExecuteScalar()
                    Dim NumSpecimenReq As Integer = CType(intNumSamples.Text, Integer) + CType(cmbBlackCaps.SelectedValue, Integer)
                    If NumSpecimenInDB <> NumSpecimenReq Then
                        Dim result As MsgBoxResult
                        result = MsgBox("The number if samples in the Specimen table (" & NumSpecimenInDB & ") does not match the number of samples requested (" & NumSpecimenReq & ") for this request. Are you sure you'd like to approve this for distribution (if so, remember to update the Number of Samples box (minus Black Caps) before generating the tissue distro document.", MsgBoxStyle.YesNo, "Warning!")
                        If result = MsgBoxResult.No Then
                            chkDistroApproved.Checked = False
                            Exit Sub
                        End If
                    End If
                End If
                dtDateApprovedForDistro.Text = Format(Now(), "MM/dd/yyyy")
                txtDateShipped.makeReadOnly(False)
                comboShippingMethod.Enabled = True
                txtTrackingNum.makeReadOnly(False)
            Else
                txtDateShipped.makeReadOnly(True)
                comboShippingMethod.Enabled = False
                txtTrackingNum.makeReadOnly(True)
            End If
        End If
    End Sub
    Private Function getNextProjectID() As String
        Dim result As String = ""
        Dim projectID As Integer = 0
        Dim cmd As New SqlCommand("select max(ProjectID) from TissueRequests;", WarehouseShell.conn)
        projectID = cmd.ExecuteScalar() + 1
        result = projectID.ToString
        Return result
    End Function

    'FileStreamFile events
    Private Sub btnAddTissueFile_Click(sender As Object, e As EventArgs) Handles btnAddTissueFile.Click
        If SystemFiles1to1.CheckFile("fileTissueProjectDetailSpreadsheet", ProjectID) Then
            SystemFiles1to1.OpenFile("fileTissueProjectDetailSpreadsheet", ProjectID, "Tissue Project " & ProjectID & " Project Detail Spreadsheet")
        Else
            'Prevent unauthorized users from modifying locked (shipped) project file
            If Not User.PermissionCheck("WA_TissueRequest", "Modify") Then
                tooltip1.Show("This Project is closed and files are locked. Contact Dr. Haroutunian for changes.", btnAddTissueFile, 0, 22, 5000)
            Else
                SystemFiles1to1.SaveFile("fileTissueProjectDetailSpreadsheet", ProjectID)
            End If
        End If
        loadFileData()
    End Sub
    Private Sub btnRemoveTissueFile_Click(sender As Object, e As EventArgs) Handles btnRemoveTissueFile.Click
        If Not User.PermissionCheck("WA_TissueRequest", "Modify") Then
            tooltip1.Show("This Project is closed and files are locked. Contact Dr. Haroutunian for changes.", btnAddTissueFile, 0, 20, 5000)
        Else
            SystemFiles1to1.DeleteFile("fileTissueProjectDetailSpreadsheet", ProjectID)
            loadFileData()
        End If
    End Sub
    Private Sub btnAddDistroDoc_Click(sender As Object, e As EventArgs) Handles btnAddDistroDoc.Click
        If SystemFiles1to1.CheckFile("fileTissueProjectDistroDoc", ProjectID) Then
            SystemFiles1to1.OpenFile("fileTissueProjectDistroDoc", ProjectID, "Tissue Project " & ProjectID & " Distro Doc")
        Else
            If User.PermissionCheck("WA_TissueRequest", "Modify") Then
                SystemFiles1to1.SaveFile("fileTissueProjectDistroDoc", ProjectID)
            End If
        End If
        loadFileData()
    End Sub
    Private Sub btnRemoveDistroDoc_Click(sender As Object, e As EventArgs) Handles btnRemoveDistroDoc.Click
        If User.PermissionCheck("WA_TissueRequest", "Modify") Then
            SystemFiles1to1.DeleteFile("fileTissueProjectDistroDoc", ProjectID)
            loadFileData()
        End If
    End Sub
    Private Sub btnAddShippingFile_Click(sender As Object, e As EventArgs) Handles btnAddShippingFile.Click
        If SystemFiles1to1.CheckFile("fileTissueProjectShippingScan", ProjectID) Then
            SystemFiles1to1.OpenFile("fileTissueProjectShippingScan", ProjectID, "Tissue Project " & ProjectID & " Shipping Scan")
        Else
            'Prevent unauthorized users from modifying locked (shipped) project file
            If Not User.PermissionCheck("WA_TissueRequest", "Modify") Then
                tooltip1.Show("This Project is closed and files are locked. Contact Dr. Haroutunian for changes.", btnAddTissueFile, 0, 22, 5000)
            Else
                SystemFiles1to1.SaveFile("fileTissueProjectShippingScan", ProjectID)
            End If
        End If
        loadFileData()
    End Sub
    Private Sub btnRemoveShippingDoc_Click(sender As Object, e As EventArgs) Handles btnRemoveShippingDoc.Click
        If Not User.PermissionCheck("WA_TissueRequest", "Modify") Then
            tooltip1.Show("This Project is closed and files are locked. Contact Dr. Haroutunian for changes.", btnAddTissueFile, 0, 20, 5000)
        Else
            SystemFiles1to1.DeleteFile("fileTissueProjectShippingScan", ProjectID) 'WarehouseShell.deleteFile("Tissue Project Shipping Scan", "Tissue Project " & txtProject.Text & IIf(txtSubProject.Text <> "", " Sub- " & txtSubProject.Text, ""), ProjectID)
            loadFileData()
        End If
    End Sub

    'Sub to load/update file data (ran on load, regardless of mode)
    Private Sub loadFileData()
        If SystemFiles1to1.CheckFile("fileTissueProjectDetailSpreadsheet", ProjectID) Then
            btnAddTissueFile.Text = "View Tissue Spreadsheet"
            btnAddTissueFile.BackColor = Color.Chartreuse
            If WarehouseShell.userName = "harouv01" Or WarehouseShell.userName = "arnesj01" Or WarehouseShell.userName = "koueda01" Then
                btnRemoveTissueFile.Enabled = True
            End If
        Else
            btnAddTissueFile.Text = "Upload Tissue Spreadsheet"
            btnAddTissueFile.BackColor = SystemColors.ButtonFace
            btnRemoveTissueFile.Enabled = False
        End If

        If SystemFiles1to1.CheckFile("fileTissueProjectShippingScan", ProjectID) Then
            btnAddShippingFile.Text = "View Shipping Scan"
            btnAddShippingFile.BackColor = Color.Chartreuse
            btnAddShippingFile.Enabled = True
        Else
            btnAddShippingFile.Text = "Upload Shipping Scan"
            btnAddShippingFile.BackColor = SystemColors.ButtonFace
            btnAddShippingFile.Enabled = False
        End If

        If SystemFiles1to1.CheckFile("fileTissueProjectDistroDoc", ProjectID) Then
            btnAddDistroDoc.Text = "View Tissue Distro Doc"
            btnAddDistroDoc.BackColor = Color.Chartreuse
            btnAddDistroDoc.Enabled = True
            If WarehouseShell.userName = "harouv01" Or WarehouseShell.userName = "arnesj01" Then
                btnRemoveDistroDoc.Enabled = True
            End If
        Else
            btnAddDistroDoc.Text = "Upload Tissue Distro Doc"
            btnAddDistroDoc.BackColor = SystemColors.ButtonFace
            btnRemoveDistroDoc.Enabled = False
        End If
    End Sub

    'Allow user to double-click record to load its details into the lower section of the form
    Private Sub dgvTissueRequests_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTissueRequests.CellDoubleClick
        'Handle unsaved work if exists
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
            Dim checkform As New PU_SaveWork
            Dim myResult As DialogResult = checkform.ShowDialog
            If myResult = Windows.Forms.DialogResult.OK Then
                SaveWork()
            ElseIf myResult = DialogResult.Cancel Then
                Exit Sub
            End If
            btnNewProjectBottom.Text = "Add New Project"
            btnNewProjectTop.Text = btnNewProjectBottom.Text
            checkform.Dispose()
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit Then
            Dim checkform As New PU_SaveWork
            Dim myResult As DialogResult = checkform.ShowDialog
            If myResult = Windows.Forms.DialogResult.OK Then
                SaveWork()
            ElseIf myResult = DialogResult.Cancel Then
                Exit Sub
            End If
            btnTissueEditBottom.Text = "Edit This Project"
            btnTissueEditTop.Text = btnTissueEditBottom.Text
            checkform.Dispose()
        End If
        'Clear the exiting input fields
        ClearInputFields()

        'Set the projectID variable to the selected ProjectID(invisible)
        ProjectID = dgvTissueRequests.SelectedRows(0).Cells("ProjectID").Value.ToString
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View

        'Clear any existing formTable data (this is seperate from the "table" dataset that handles the DGV)
        formTables.Tables.Clear()

        'Load matching record into formTables (using Project & IIf SubProject filter)
        formTables.Tables.Add(Database.ReturnTable("TissueRequests", , "ProjectID = '" & ProjectID & "'"))

        'Apply the values to the form
        txtProjectID.Text = ProjectID
        txtProject.Text = formTables.Tables("TissueRequests").Rows(0).Item("Project").ToString()
        txtSubProject.Text = formTables.Tables("TissueRequests").Rows(0).Item("SubProject").ToString()
        txtProjectTitle.Text = formTables.Tables("TissueRequests").Rows(0).Item("ProjectTitle").ToString()
        txtRequestingPI.Text = formTables.Tables("TissueRequests").Rows(0).Item("RequestingPI").ToString()
        txtPIEmail.Text = formTables.Tables("TissueRequests").Rows(0).Item("PIEmail").ToString()
        txtNBTRReqNum.Text = formTables.Tables("TissueRequests").Rows(0).Item("NBTRRequestNum").ToString()
        txtNBBURL.Text = formTables.Tables("TissueRequests").Rows(0).Item("NBBURL").ToString()
        If IsDate(formTables.Tables("TissueRequests").Rows(0).Item("RequestDate")) Then
            dtRequestDate.Text = Format(formTables.Tables("TissueRequests").Rows(0).Item("RequestDate"), "MM-dd-yyyy").ToString
        Else
            dtRequestDate.Text = "  /  /"
        End If
        txtInternalSampleDesc.Text = formTables.Tables("TissueRequests").Rows(0).Item("InternalSampleDescription").ToString()
        txtExternalSampleDesc.Text = formTables.Tables("TissueRequests").Rows(0).Item("ExternalSampleDescription").ToString()
        txtBrainRegions.setValue(formTables, "TissueRequests", "BrainRegions")
        txtTissuePreparations.setValue(formTables, "TissueRequests", "TissuePreparations")
        txtDistributiveDiagnosis.setValue(formTables, "TissueRequests", "DistributiveDx")
        intNumSamples.Text = formTables.Tables("TissueRequests").Rows(0).Item("NumSamples").ToString()
        txtSampleType.Text = formTables.Tables("TissueRequests").Rows(0).Item("SampleType").ToString()
        txtPOCName.Text = formTables.Tables("TissueRequests").Rows(0).Item("POCName").ToString()
        txtPOCEmail.Text = formTables.Tables("TissueRequests").Rows(0).Item("POCEmail").ToString()
        txtPOCPhone.Text = formTables.Tables("TissueRequests").Rows(0).Item("POCPhone").ToString()
        txtInstituteName.Text = formTables.Tables("TissueRequests").Rows(0).Item("InstituteName").ToString()
        txtAddress1.Text = formTables.Tables("TissueRequests").Rows(0).Item("Address1").ToString()
        txtAddress2.Text = formTables.Tables("TissueRequests").Rows(0).Item("Address2").ToString()
        txtAddress3.Text = formTables.Tables("TissueRequests").Rows(0).Item("Address3").ToString()
        txtAddress4.Text = formTables.Tables("TissueRequests").Rows(0).Item("Address4").ToString()
        txtCity.Text = formTables.Tables("TissueRequests").Rows(0).Item("City").ToString()
        txtState.Text = formTables.Tables("TissueRequests").Rows(0).Item("State").ToString()
        txtZip.Text = formTables.Tables("TissueRequests").Rows(0).Item("Zip").ToString()
        comboReqShippingMethod.SelectedValue = formTables.Tables("TissueRequests").Rows(0).Item("ReqShipMethod")
        txtReqShipAcctNum.Text = formTables.Tables("TissueRequests").Rows(0).Item("ReqShipAcctNum").ToString()
        txtDateShipped.setValue(formTables, "TissueRequests", "DateShipped")
        comboShippingMethod.setValue(formTables, "TissueRequests", "ShippingMethod")
        txtTrackingNum.setValue(formTables, "TissueRequests", "TrackingNum")
        chkDistroApproved.setValue(formTables, "TissueRequests", "ApprovedForDistro")
        dtDateApprovedForDistro.setValue(formTables, "TissueRequests", "ApprovedForDistroDate")
        chkHideProject.Checked = formTables.Tables("TissueRequests").Rows(0).Item("Hidden")

        'grab estimated completion date from TissueTasker
        If formTables.Tables().Contains("TissueTasker") Then
            formTables.Tables().Remove("TissueTasker")
        End If
        formTables.Tables.Add(Database.ReturnTable("TissueTasker", "EstCompDt", "ProjectID = " & ProjectID))
        dtEstCompDt.setValue(formTables, "TissueTasker", "EstCompDt")

        'dlean up interactible controls
        btnTissueEditBottom.Text = "Edit Project"
        btnTissueEditTop.Text = btnTissueEditBottom.Text
        btnTissueEditBottom.Visible = True
        btnTissueEditTop.Visible = True
        enableInputFields()
        loadFileData()
        btnAddSubProjTop.Visible = True
        btnAddSubProjBottom.Visible = True
        btnPDFTop.Visible = True
        btnPDFBottom.Visible = True
    End Sub

    'PDF Events
    Private Sub btnPDFTop_Click(sender As Object, e As EventArgs) Handles btnPDFTop.Click, btnPDFBottom.Click
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
            tooltip1.Show("This record must be saved before PDF Export can be created.", btnPDFTop, 0, 20, 5000)
        Else
            Try
                'Define which template to use
                Dim pdfTemplate As String = "Q:\Warehouse Files\PDF Export Templates\NBTR Tissue Distribution.pdf"
                'Define the output file name
                Dim outputFileName As String = "Project " & ProjectID & " NBTR Tissue Distribution.pdf"
                'combine the output file name with the user's temp file path location so we can create and fill the PDF
                Dim filledPDF As String = Path.GetTempPath() & outputFileName

                'Use the PDF API to start the the new file
                Dim pdfReader As PdfReader = New PdfReader(pdfTemplate)
                Dim pdfStamper As New PdfStamper(pdfReader, New FileStream(filledPDF, FileMode.Create))
                Dim pdfFormFields As AcroFields = pdfStamper.AcroFields

                'Fill the fields with values
                pdfFormFields.SetField("FromInfo", "Mount Sinai NBTR" & vbNewLine &
                                       "V. Haroutunian, Ph.D." & vbNewLine &
                                       "Room 5F-04" & vbNewLine &
                                       "130 West Kingsbridge Road" & vbNewLine &
                                       "Bronx, NY 10468")
                pdfFormFields.SetField("POCInfo", txtPOCName.Text & vbNewLine &
                                       IIf(txtAddress1.Text <> "", txtAddress1.Text & vbNewLine, "") &
                                       IIf(txtAddress2.Text <> "", txtAddress2.Text & vbNewLine, "") &
                                       IIf(txtAddress3.Text <> "", txtAddress3.Text & vbNewLine, "") &
                                       IIf(txtAddress4.Text <> "", txtAddress4.Text & vbNewLine, "") &
                                       txtCity.Text & ", " & txtState.Text & " " & txtZip.Text)
                pdfFormFields.SetField("POCPhone", txtPOCPhone.Text)
                pdfFormFields.SetField("POCEmail", txtPOCEmail.Text)
                pdfFormFields.SetField("RequestingPI", txtRequestingPI.Text)
                pdfFormFields.SetField("PIEmail", txtPIEmail.Text)
                pdfFormFields.SetField("NBBReqNum", txtNBTRReqNum.Text)
                pdfFormFields.SetField("SampleDescription", IIf(rdoExtSampDesc.Checked, txtExternalSampleDesc.Text, txtInternalSampleDesc.Text))
                pdfFormFields.SetField("NumSamples", intNumSamples.Text)
                If txtDateShipped.Text <> "  /  /" Then
                    pdfFormFields.SetField("DateShipped", txtDateShipped.Text)
                End If
                pdfFormFields.SetField("SampleType", txtSampleType.Text)
                If txtTrackingNum.Text <> "" Then
                    pdfFormFields.SetField("TrackingNum", txtTrackingNum.Text & "(" & comboShippingMethod.Text & ")")
                End If
                pdfFormFields.SetField("ReqShipAcctNum", txtReqShipAcctNum.Text)
                pdfFormFields.SetField("ProjectTitle", txtProjectTitle.Text)

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

    'Harry ease of use events
    Private Sub txtRequestingPI_Leave(sender As Object, e As EventArgs) Handles txtRequestingPI.Leave
        If txtPOCName.Text = "" Then
            txtPOCName.Text = txtRequestingPI.Text
        End If
    End Sub
    Private Sub txtPIEmail_Leave(sender As Object, e As EventArgs) Handles txtPIEmail.Leave
        If txtPOCEmail.Text = "" Then
            txtPOCEmail.Text = txtPIEmail.Text
        End If
    End Sub
    Private Sub txtInternalSampleDesc_Leave(sender As Object, e As EventArgs) Handles txtInternalSampleDesc.Leave
        If txtExternalSampleDesc.Text = "" Then
            txtExternalSampleDesc.Text = txtInternalSampleDesc.Text
        End If
    End Sub

    Private Sub btnNBBURL_Click(sender As Object, e As EventArgs) Handles btnNBBURL.Click
        If txtNBBURL.Text <> "" Then
            Try
                Dim webAddress As String = txtNBBURL.Text
                Process.Start(webAddress)
            Catch ex As Exception

            End Try
        Else
            MsgBox("The NBB Req. URL box is empty.", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub
    Private Sub btnTissuePrepModify_Click(sender As Object, e As EventArgs) Handles btnTissuePrepModify.Click
        If User.PermissionCheck("WA_TissueRequest", "Modify") Then
            Dim prepPU = New PU_TissueRequest_SelectPreparation

            prepPU.ShowDialog()

            If prepPU.returnString <> "Cancel" Then
                txtTissuePreparations.Text = prepPU.returnString
            End If

            prepPU.Dispose()
        End If
    End Sub
    Private Sub btnBrainRegionModify_Click(sender As Object, e As EventArgs) Handles btnBrainRegionModify.Click
        If User.PermissionCheck("WA_TissueRequest", "Modify") Then
            Dim regionPU = New PU_TissueRequest_SelectBrainRegion

            regionPU.ShowDialog()

            If regionPU.returnString <> "Cancel" Then
                txtBrainRegions.Text = regionPU.returnString
            End If

            regionPU.Dispose()
        End If
    End Sub
    Private Sub UpdateTissueTasker()
        If txtInternalSampleDesc.Text <> formTables.Tables("TissueRequests").Rows(0).Item("InternalSampleDescription") Then
            Dim cmd As New SqlCommand("Update TissueTasker set TissueRequirements = " & txtInternalSampleDesc.getSQLValue() & " where ProjectID = " &
                                      formTables.Tables("TissueRequests").Rows(0).Item("ProjectID") & ";", WarehouseShell.conn)
            cmd.ExecuteNonQuery()
        End If
    End Sub

    'Imported IFormMethods interface methods (some used, some not, based on which form is using the interface)
    Public Sub ShowPHI(showPHI As Boolean) Implements IFormMethods.ShowPHI
    End Sub
    Public Sub Parent1(ByRef val As Object) Implements IFormMethods.Parent
        Me.Parent = val
    End Sub
    Public Sub Show1() Implements IFormMethods.Show
        Me.Show()
    End Sub
    Public Sub TopLevel1(val As Boolean) Implements IFormMethods.TopLevel
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit Then
            btnTissueEditBottom.PerformClick()
        Else
            btnNewProjectBottom.PerformClick()
        End If
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Me.Dispose()
    End Sub
End Class