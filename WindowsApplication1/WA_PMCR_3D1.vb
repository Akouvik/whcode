Public Class WA_PMCR_3D1
    Implements IFormMethods
    Private formTables As New DataSet

    Private Sub WA_PMCR_3D1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Database.ExistingRecordCheck("PMCR_3D1", "SubNum = " & WarehouseShell.SubNum) Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            loadBaseForm()
            loadExistingData()
            btn3D1Bottom.Text = "Edit Record"
            btn3D1Top.Text = btn3D1Bottom.Text
        Else 'If it doesn't exist, change mode to Undefined and show user banner
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            lblNoRecord.Visible = True
            btn3D1Bottom.Text = "Add New Record"
            btn3D1Top.Text = btn3D1Bottom.Text
        End If
        enableInputFields(False)
    End Sub
    Private Sub loadBaseForm()
        formTables.Tables.Add(Database.ReturnTable("lkpConfidence"))
        formTables.Tables.Add(Database.ReturnTable("refInstitution"))
        cmbPsychHospInst.DataSource = formTables.Tables("refInstitution")
        cmbPsychHospInst.DisplayMember = "Name"
        cmbPsychHospInst.ValueMember = "InstitutionID"
        formTables.Tables.Add(Database.ReturnTable("lkpPMCR_3D1_Source"))
        cmbPrimDxConf.assignLookup(formTables, "lkpConfidence")
        cmbSecDxConf.assignLookup(formTables, "lkpConfidence")
        cmbOthDxConf.assignLookup(formTables, "lkpConfidence")
        cmbCritB1019.assignLookup(formTables, "lkpPMCR_3D1_Source")
        cmbCritB2029.assignLookup(formTables, "lkpPMCR_3D1_Source")
        cmbCritB3039.assignLookup(formTables, "lkpPMCR_3D1_Source")
        cmbCritB4049.assignLookup(formTables, "lkpPMCR_3D1_Source")
        cmbCritB5059.assignLookup(formTables, "lkpPMCR_3D1_Source")
        cmbCritB6069.assignLookup(formTables, "lkpPMCR_3D1_Source")
        cmbCritB7079.assignLookup(formTables, "lkpPMCR_3D1_Source")
        cmbCritB8089.assignLookup(formTables, "lkpPMCR_3D1_Source")
        cmbCritB9099.assignLookup(formTables, "lkpPMCR_3D1_Source")
    End Sub
    Private Sub setDefaultValues()
        cmbPsychHospInst.SelectedValue = -1
        cmbPrimDxConf.SelectedValue = -1
        cmbSecDxConf.SelectedValue = -1
        cmbOthDxConf.SelectedValue = -1
        cmbCritB1019.SelectedValue = -1
        cmbCritB2029.SelectedValue = -1
        cmbCritB3039.SelectedValue = -1
        cmbCritB4049.SelectedValue = -1
        cmbCritB5059.SelectedValue = -1
        cmbCritB6069.SelectedValue = -1
        cmbCritB7079.SelectedValue = -1
        cmbCritB8089.SelectedValue = -1
        cmbCritB9099.SelectedValue = -1
    End Sub
    Private Sub loadExistingData() 'load all non-DGV values (handle DGV loads with separate subs)
        'Grab the individual record, based on RecordID, and assign values to their appropriate fields
        formTables.Tables.Add(Database.ReturnTable("PMCR_3D1", , "SubNum = " & WarehouseShell.SubNum))
        dt1stPsychHosp.setValue(formTables, "PMCR_3D1", "Date1stPsychHosp")
        txtAgeAtAdmit.setValue(formTables, "PMCR_3D1", "AgeAtAdmit")
        dtCurPsychHosp.setValue(formTables, "PMCR_3D1", "DateCurrentAdmit")
        cmbPsychHospInst.setValue(formTables, "PMCR_3D1", "InstitutionID")
        chkLobotomy.setValue(formTables, "PMCR_3D1", "Lobotomy")
        dtLobotomy.setValue(formTables, "PMCR_3D1", "LobotomyDate")
        chkECT.setValue(formTables, "PMCR_3D1", "ECT")
        dtECT.setValue(formTables, "PMCR_3D1", "ECTDate")
        chkInsulinTher.setValue(formTables, "PMCR_3D1", "InsulinTherapy")
        dtInsulinTher.setValue(formTables, "PMCR_3D1", "InsulinTherapyDate")
        txtCurChartDx.setValue(formTables, "PMCR_3D1", "CurChartDx")
        dtCurChartDx.setValue(formTables, "PMCR_3D1", "CurChartDxDate")
        txtPrimDxCodeType.setValue(formTables, "PMCR_3D1", "DxPrimCodeType")
        txtPrimDxCode.setValue(formTables, "PMCR_3D1", "DxPrimCode")
        txtPrimDxText.setValue(formTables, "PMCR_3D1", "DxPrimText")
        cmbPrimDxConf.setValue(formTables, "PMCR_3D1", "DxPrimConf")
        txtSecDxCodeType.setValue(formTables, "PMCR_3D1", "DxSecCodeType")
        txtSecDxCode.setValue(formTables, "PMCR_3D1", "DxSecCode")
        txtSecDxText.setValue(formTables, "PMCR_3D1", "DxSecText")
        cmbSecDxConf.setValue(formTables, "PMCR_3D1", "DxSecConf")
        txtOthDxCodeType.setValue(formTables, "PMCR_3D1", "DxOthCodeType")
        txtOthDxCode.setValue(formTables, "PMCR_3D1", "DxOthCode")
        txtOthDxText.setValue(formTables, "PMCR_3D1", "DxOthText")
        cmbOthDxConf.setValue(formTables, "PMCR_3D1", "DxOthConf")
        txtMedicalInfoNotes.setValue(formTables, "PMCR_3D1", "MedicalInfo")
        txtPsychSymp1019.setValue(formTables, "PMCR_3D1", "CritA1019Notes")
        txtPsychSymp2029.setValue(formTables, "PMCR_3D1", "CritA2029Notes")
        txtPsychSymp3039.setValue(formTables, "PMCR_3D1", "CritA3039Notes")
        txtPsychSymp4049.setValue(formTables, "PMCR_3D1", "CritA4049Notes")
        txtPsychSymp5059.setValue(formTables, "PMCR_3D1", "CritA5059Notes")
        txtPsychSymp6069.setValue(formTables, "PMCR_3D1", "CritA6069Notes")
        txtPsychSymp7079.setValue(formTables, "PMCR_3D1", "CritA7079Notes")
        txtPsychSymp8089.setValue(formTables, "PMCR_3D1", "CritA8089Notes")
        txtPsychSymp9099.setValue(formTables, "PMCR_3D1", "CritA9099Notes")
        cmbCritB1019.setValue(formTables, "PMCR_3D1", "CritB1019Source")
        cmbCritB2029.setValue(formTables, "PMCR_3D1", "CritB2029Source")
        cmbCritB3039.setValue(formTables, "PMCR_3D1", "CritB3039Source")
        cmbCritB4049.setValue(formTables, "PMCR_3D1", "CritB4049Source")
        cmbCritB5059.setValue(formTables, "PMCR_3D1", "CritB5059Source")
        cmbCritB6069.setValue(formTables, "PMCR_3D1", "CritB6069Source")
        cmbCritB7079.setValue(formTables, "PMCR_3D1", "CritB7079Source")
        cmbCritB8089.setValue(formTables, "PMCR_3D1", "CritB8089Source")
        cmbCritB9099.setValue(formTables, "PMCR_3D1", "CritB9099Source")
        txtCritB1019.setValue(formTables, "PMCR_3D1", "CritB1019Notes")
        txtCritB2029.setValue(formTables, "PMCR_3D1", "CritB2029Notes")
        txtCritB3030.setValue(formTables, "PMCR_3D1", "CritB3039Notes")
        txtCritB4049.setValue(formTables, "PMCR_3D1", "CritB4049Notes")
        txtCritB5059.setValue(formTables, "PMCR_3D1", "CritB5059Notes")
        txtCritB6069.setValue(formTables, "PMCR_3D1", "CritB6069Notes")
        txtCritB7079.setValue(formTables, "PMCR_3D1", "CritB7079Notes")
        txtCritB8089.setValue(formTables, "PMCR_3D1", "CritB8089Notes")
        txtCritB9099.setValue(formTables, "PMCR_3D1", "CritB9099Notes")
    End Sub
    Private Sub enableInputFields(ByVal bool As Boolean)
        If bool = True Then
            grpPsychiatricHospitalizations.Enabled = True
            grpLifetimeDx.Enabled = True
            grpMedicalInfo.Enabled = True
            grpPsychSympActPhase.Enabled = True
            grpCritB.Enabled = True
        Else
            grpPsychiatricHospitalizations.Enabled = False
            grpLifetimeDx.Enabled = False
            grpMedicalInfo.Enabled = False
            grpPsychSympActPhase.Enabled = False
            grpCritB.Enabled = False
        End If
    End Sub
    Private Sub btn3D1_Click(sender As Object, e As EventArgs) Handles btn3D1Bottom.Click, btn3D1Top.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_PMCR_3D1", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                btn3D1Bottom.Text = "Save Changes"
                btn3D1Top.Text = btn3D1Bottom.Text
                enableInputFields(True)
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If User.PermissionCheck("WA_PMCR_3D1", "Modify") Then
                loadBaseForm()
                setDefaultValues()
                lblNoRecord.Visible = False
                btn3D1Bottom.Text = "Save New Record"
                btn3D1Top.Text = "Save New Record"
                enableInputFields(True)
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
            End If
        Else 'By default, user is attempting to Insert or Edit a record. Run preSaveValidation.
            If preSaveValidation() Then 'If preSaveValidation returns true, take Insert or Update actions.
                'Same parameters for Insert or Update SP's, so define here
                Dim parameters = " @SubNum = " & WarehouseShell.SubNum &
                    ", @Date1stPsychHosp = " & dt1stPsychHosp.getSQLValue() &
                    ", @AgeAtAdmit = " & txtAgeAtAdmit.getSQLValue() &
                    ", @DateCurrentAdmit = " & dtCurPsychHosp.getSQLValue() &
                    ", @InstitutionID = " & cmbPsychHospInst.getSQLValue() &
                    ", @Lobotomy = " & chkLobotomy.getSQLValue() &
                    ", @LobotomyDate = " & dtLobotomy.getSQLValue() &
                    ", @ECT = " & chkECT.getSQLValue() &
                    ", @ECTDate = " & dtECT.getSQLValue() &
                    ", @InsulinTherapy = " & chkInsulinTher.getSQLValue() &
                    ", @InsulinTherapyDate = " & dtInsulinTher.getSQLValue() &
                    ", @CurChartDx = " & txtCurChartDx.getSQLValue() &
                    ", @CurChartDxDate = " & dtCurChartDx.getSQLValue() &
                    ", @DxPrimCodeType = " & txtPrimDxCodeType.getSQLValue() &
                    ", @DxPrimCode = " & txtPrimDxCode.getSQLValue() &
                    ", @DxPrimText = " & txtPrimDxText.getSQLValue() &
                    ", @DxPrimConf = " & cmbPrimDxConf.getSQLValue() &
                    ", @DxSecCodeType = " & txtSecDxCodeType.getSQLValue() &
                    ", @DxSecCode = " & txtSecDxCode.getSQLValue() &
                    ", @DxSecText = " & txtSecDxText.getSQLValue() &
                    ", @DxSecConf = " & cmbSecDxConf.getSQLValue() &
                    ", @DxOthCodeType = " & txtOthDxCodeType.getSQLValue() &
                    ", @DxOthCode = " & txtOthDxCode.getSQLValue() &
                    ", @DxOthText = " & txtOthDxText.getSQLValue() &
                    ", @DxOthConf = " & cmbOthDxConf.getSQLValue() &
                    ", @MedicalInfo = " & txtMedicalInfoNotes.getSQLValue() &
                    ", @CritA1019Notes = " & txtPsychSymp1019.getSQLValue() &
                    ", @CritA2029Notes = " & txtPsychSymp2029.getSQLValue() &
                    ", @CritA3039Notes = " & txtPsychSymp3039.getSQLValue() &
                    ", @CritA4049Notes = " & txtPsychSymp4049.getSQLValue() &
                    ", @CritA5059Notes = " & txtPsychSymp5059.getSQLValue() &
                    ", @CritA6069Notes = " & txtPsychSymp6069.getSQLValue() &
                    ", @CritA7079Notes = " & txtPsychSymp7079.getSQLValue() &
                    ", @CritA8089Notes = " & txtPsychSymp8089.getSQLValue() &
                    ", @CritA9099Notes = " & txtPsychSymp9099.getSQLValue() &
                    ", @CritB1019Source = " & cmbCritB1019.getSQLValue() &
                    ", @CritB1019Notes = " & txtCritB1019.getSQLValue() &
                    ", @CritB2029Source = " & cmbCritB2029.getSQLValue() &
                    ", @CritB2029Notes = " & txtCritB2029.getSQLValue() &
                    ", @CritB3039Source = " & cmbCritB3039.getSQLValue() &
                    ", @CritB3039Notes = " & txtCritB3030.getSQLValue() &
                    ", @CritB4049Source = " & cmbCritB4049.getSQLValue() &
                    ", @CritB4049Notes = " & txtCritB4049.getSQLValue() &
                    ", @CritB5059Source = " & cmbCritB5059.getSQLValue() &
                    ", @CritB5059Notes = " & txtCritB5059.getSQLValue() &
                    ", @CritB6069Source = " & cmbCritB6069.getSQLValue() &
                    ", @CritB6069Notes = " & txtCritB6069.getSQLValue() &
                    ", @CritB7079Source = " & cmbCritB7079.getSQLValue() &
                    ", @CritB7079Notes = " & txtCritB7079.getSQLValue() &
                    ", @CritB8089Source = " & cmbCritB8089.getSQLValue() &
                    ", @CritB8089Notes = " & txtCritB8089.getSQLValue() &
                    ", @CritB9099Source = " & cmbCritB9099.getSQLValue() &
                    ", @CritB9099Notes = " & txtCritB9099.getSQLValue() &
                    ", @LastModBy = '" & WarehouseShell.userName & "';"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    Dim cmd As New SqlCommand("Exec modPMCR_3D1Record @Action = 1, " & parameters, WarehouseShell.conn)
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Save successful", MsgBoxStyle.OkOnly)
                        enableInputFields(False)
                        btn3D1Bottom.Text = "Edit Record"
                        btn3D1Top.Text = "Edit Record"
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else 'If this clause is invoked, datamode must be Edit
                    Dim cmd As New SqlCommand("Exec modPMCR_3D1Record @Action = 2, " & parameters, WarehouseShell.conn)
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Save successful", MsgBoxStyle.OkOnly)
                        enableInputFields(False)
                        btn3D1Bottom.Text = "Edit Record"
                        btn3D1Top.Text = "Edit Record"
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                End If
            End If
        End If
    End Sub
    Private Function preSaveValidation() As Boolean
        Dim errMsg As String = "The following errors exist and need to be corrected before record can be saved:" & vbNewLine & vbNewLine
        Dim result As Boolean = True
        'Check for hard fails
        If result = True Then 'if no hard fails, check for warnings
            Dim warnResult As Boolean = True
            'check for warnings (like Prim Dx without confidence). If found, provide warning popup with Continue/Cancel options and set result accordingly.
            errMsg = "The following WARNINGS exist. Would you like to continue with save?" & vbNewLine & vbNewLine
            If txtPrimDxCodeType.Text <> "" And cmbPrimDxConf.SelectedValue = -1 Then
                errMsg += "- You have selected a Primary Lifetime Diagnosis, but not selected a Confidence Level." & vbNewLine
                warnResult = False
            End If
            If txtSecDxCodeType.Text <> "" And cmbSecDxConf.SelectedValue = -1 Then
                errMsg += "- You have selected a Secondaty Lifetime Diagnosis, but not selected a Confidence Level." & vbNewLine
                warnResult = False
            End If
            If txtOthDxCodeType.Text <> "" And cmbOthDxConf.SelectedValue = -1 Then
                errMsg += "- You have selected an Other Lifetime Diagnosis, but not selected a Confidence Level." & vbNewLine
                warnResult = False
            End If
            If warnResult = False Then
                Dim puResult As DialogResult = MsgBox(errMsg, MsgBoxStyle.YesNo, "Warning")
                If puResult = DialogResult.No Then
                    result = False
                End If
            End If
        End If
        Return result
    End Function

    Private Sub btnDxPrimAdd_Click(sender As Object, e As EventArgs) Handles btnDxPrimAdd.Click
        If User.PermissionCheck("WA_PMCR_3D1", "Modify") Then
            Dim PU = New PU_ExistingDxSelect
            PU.ShowDialog()
            If PU.DxSelected Then
                txtPrimDxCodeType.Text = PU.dgvDx.SelectedRows(0).Cells("Code Type").Value.ToString 'PU.txtDxCodeType.Text
                txtPrimDxCode.Text = PU.dgvDx.SelectedRows(0).Cells("Code").Value.ToString 'PU.txtDxCode.Text
                txtPrimDxText.Text = PU.dgvDx.SelectedRows(0).Cells("Text").Value.ToString 'PU.txtDxText.Text
            End If
            PU.Dispose()
        End If
    End Sub
    Private Sub btnDxSecAdd_Click(sender As Object, e As EventArgs) Handles btnDxSecAdd.Click
        If User.PermissionCheck("WA_PMCR_3D1", "Modify") Then
            Dim PU = New PU_ExistingDxSelect
            PU.ShowDialog()
            If PU.DxSelected Then
                txtSecDxCodeType.Text = PU.dgvDx.SelectedRows(0).Cells("Code Type").Value.ToString
                txtSecDxCode.Text = PU.dgvDx.SelectedRows(0).Cells("Code").Value.ToString
                txtSecDxText.Text = PU.dgvDx.SelectedRows(0).Cells("Text").Value.ToString
            End If
            PU.Dispose()
        End If
    End Sub
    Private Sub btnDxOthAdd_Click(sender As Object, e As EventArgs) Handles btnDxOthAdd.Click
        If User.PermissionCheck("WA_PMCR_3D1", "Modify") Then
            Dim PU = New PU_ExistingDxSelect
            PU.ShowDialog()
            If PU.DxSelected Then
                txtOthDxCodeType.Text = PU.dgvDx.SelectedRows(0).Cells("Code Type").Value.ToString
                txtOthDxCode.Text = PU.dgvDx.SelectedRows(0).Cells("Code").Value.ToString
                txtOthDxText.Text = PU.dgvDx.SelectedRows(0).Cells("Text").Value.ToString
            End If
            PU.Dispose()
        End If
    End Sub
    Private Sub btnDxPrimRemove_Click(sender As Object, e As EventArgs) Handles btnDxPrimRemove.Click
        If User.PermissionCheck("WA_PMCR_3D1", "Modify") Then
            txtPrimDxCodeType.Clear()
            txtPrimDxCode.Clear()
            txtPrimDxText.Clear()
            cmbPrimDxConf.SelectedValue = -1
        End If
    End Sub
    Private Sub btnDxSecRemove_Click(sender As Object, e As EventArgs) Handles btnDxSecRemove.Click
        If User.PermissionCheck("WA_PMCR_3D1", "Modify") Then
            txtSecDxCodeType.Clear()
            txtSecDxCode.Clear()
            txtSecDxText.Clear()
            cmbSecDxConf.SelectedValue = -1
        End If
    End Sub
    Private Sub btnDxOthRemove_Click(sender As Object, e As EventArgs) Handles btnDxOthRemove.Click
        If User.PermissionCheck("WA_PMCR_3D1", "Modify") Then
            txtOthDxCodeType.Clear()
            txtOthDxCode.Clear()
            txtOthDxText.Clear()
            cmbOthDxConf.SelectedValue = -1
        End If
    End Sub

    'Imported IForm Methods
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
    Public Sub Parent1(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        btn3D1Bottom.PerformClick()
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