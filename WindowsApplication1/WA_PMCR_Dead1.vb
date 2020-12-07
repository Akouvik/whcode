Public Class WA_PMCR_Dead1
    Implements IFormMethods
    Private formTables As New DataSet
    Private testRecordID As Integer

    Private Sub WA_PMCR_Dead1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Database.ExistingRecordCheck("PMCR_DEAD1", "SubNum = " & WarehouseShell.SubNum) Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            loadBaseForm()
            loadExistingData()
            btnDEAD1Top.Text = "Edit Record"
            btnDEAD1Bottom.Text = btnDEAD1Top.Text
        Else 'If it doesn't exist, change mode to Undefined and show user banner
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            lblNoRecord.Visible = True
            btnDEAD1Top.Text = "Add New Record"
            btnDEAD1Bottom.Text = btnDEAD1Top.Text
        End If
        enableInputFields(False)
        loadPsychHosp()
        loadSigMedHx()
        loadDEAD1TestResults()
    End Sub
    Private Sub loadBaseForm()
        WarehouseShell.highlightSelectedNode("WA_PMCR_tabDEAD1")
        'Grab any required comboLookUp tables and assign them to their appropriate boxes
        formTables.Tables.Add(Database.ReturnTable("lkpYNNAUnk1239"))
        formTables.Tables.Add(Database.ReturnTable("refInstitution", , , "Name"))
        formTables.Tables.Add(Database.ReturnTable("lkpConfidence"))
        cmbEviPermCogImp.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbDemDx.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbCompCogFunct.assignLookup(formTables, "lkpYNNAUnk1239")
        cmbTardiveDyskConf.assignLookup(formTables, "lkpConfidence")
        cmbOthMovDisConf.assignLookup(formTables, "lkpConfidence")
        cmbMajorCVAConf.assignLookup(formTables, "lkpConfidence")
        cmbOthCerebroConf.assignLookup(formTables, "lkpConfidence")
        cmbHeadInjuryConf.assignLookup(formTables, "lkpConfidence")
        cmbtCNSConf.assignLookup(formTables, "lkpConfidence")
        cmbCNSInfectionConf.assignLookup(formTables, "lkpConfidence")
        cmbSeizureDisorderConf.assignLookup(formTables, "lkpConfidence")
        cmbToxicMetabolicConf.assignLookup(formTables, "lkpConfidence")
        cmbNeurosurgeryConf.assignLookup(formTables, "lkpConfidence")
        cmbOthNeuroIllnessConf.assignLookup(formTables, "lkpConfidence")
        'long form assign refInstitution combo lookups
        cmbPsychHospInstitution.DataSource = New DataView(formTables.Tables("refInstitution"))
        cmbPsychHospInstitution.DisplayMember = "Name"
        cmbPsychHospInstitution.ValueMember = "InstitutionID"
    End Sub
    Private Sub setDefaultValues()
        cmbEviPermCogImp.SelectedValue = 9
        cmbDemDx.SelectedValue = 9
        cmbCompCogFunct.SelectedValue = 9
        cmbTardiveDyskConf.SelectedValue = -1
        cmbOthMovDisConf.SelectedValue = -1
        cmbMajorCVAConf.SelectedValue = -1
        cmbOthCerebroConf.SelectedValue = -1
        cmbHeadInjuryConf.SelectedValue = -1
        cmbtCNSConf.SelectedValue = -1
        cmbCNSInfectionConf.SelectedValue = -1
        cmbSeizureDisorderConf.SelectedValue = -1
        cmbToxicMetabolicConf.SelectedValue = -1
        cmbNeurosurgeryConf.SelectedValue = -1
        cmbOthNeuroIllnessConf.SelectedValue = -1
        cmbPsychHospInstitution.SelectedValue = -1
    End Sub
    Private Sub loadExistingData() 'load all non-DGV values (handle DGV loads with separate subs)
        'Grab the individual record, based on RecordID, and assign values to their appropriate fields
        formTables.Tables.Add(Database.ReturnTable("PMCR_DEAD1", , "SubNum = " & WarehouseShell.SubNum))
        txtFamPsychHx.Text = formTables.Tables("PMCR_DEAD1").Rows(0).Item("FamPsychHx").ToString
        intMembInOMH.Text = formTables.Tables("PMCR_DEAD1").Rows(0).Item("MemInOMH").ToString
        intMembAvail.Text = formTables.Tables("PMCR_DEAD1").Rows(0).Item("MemAvail").ToString
        txtLastPsychDx.Text = formTables.Tables("PMCR_DEAD1").Rows(0).Item("LastPsychDiag").ToString
        cmbEviPermCogImp.SelectedValue = formTables.Tables("PMCR_DEAD1").Rows(0).Item("PermCogImp")
        If IsDate(formTables.Tables("PMCR_DEAD1").Rows(0).Item("LastPsychDiag")) Then
            dtEviPermCogimp.Text = Format(formTables.Tables("PMCR_DEAD1").Rows(0).Item("LastPsychDiag"), "MM-dd-yyyy").ToString
        End If
        cmbDemDx.SelectedValue = formTables.Tables("PMCR_DEAD1").Rows(0).Item("DementDiag")
        cmbCompCogFunct.SelectedValue = formTables.Tables("PMCR_DEAD1").Rows(0).Item("CompCogFunct")
        txtCogDecAgeOnset.Text = formTables.Tables("PMCR_DEAD1").Rows(0).Item("AgeOnsetCogDecline").ToString
        txtCogDecLess26.Text = formTables.Tables("PMCR_DEAD1").Rows(0).Item("PercentHosp26").ToString
        txtCogDec2645.Text = formTables.Tables("PMCR_DEAD1").Rows(0).Item("PercentHosp2645").ToString
        txtCogDec4655.Text = formTables.Tables("PMCR_DEAD1").Rows(0).Item("PercentHosp4655").ToString
        txtCogDec5665.Text = formTables.Tables("PMCR_DEAD1").Rows(0).Item("PercentHosp5665").ToString
        txtCogDec6675.Text = formTables.Tables("PMCR_DEAD1").Rows(0).Item("PercentHosp6675").ToString
        txtCogDecMore75.Text = formTables.Tables("PMCR_DEAD1").Rows(0).Item("PercentHosp75").ToString
        txtTotalYrsHosp.Text = formTables.Tables("PMCR_DEAD1").Rows(0).Item("TotalYrsHosp").ToString
        txtLenLastPsychHosp.Text = formTables.Tables("PMCR_DEAD1").Rows(0).Item("LenLastPsychHosp").ToString
        txtTotalNumPsychHosp.Text = formTables.Tables("PMCR_DEAD1").Rows(0).Item("TotNumHospPsych").ToString
        If formTables.Tables("PMCR_DEAD1").Rows(0).Item("TardDysk").ToString = "1" Then
            chkTardiveDysk.Checked = True
        Else
            chkTardiveDysk.Checked = False
        End If
        txtTardiveDyskAgeOnset.Text = formTables.Tables("PMCR_DEAD1").Rows(0).Item("TardDyskAoO").ToString
        cmbTardiveDyskConf.SelectedValue = formTables.Tables("PMCR_DEAD1").Rows(0).Item("TardDyskCert")
        If formTables.Tables("PMCR_DEAD1").Rows(0).Item("OtherMoveDisord").ToString = "1" Then
            chkOthMovDis.Checked = True
        Else
            chkOthMovDis.Checked = False
        End If
        txtOthMovDisAgeOnset.Text = formTables.Tables("PMCR_DEAD1").Rows(0).Item("OtherMoveDisordAoO").ToString
        cmbOthMovDisConf.SelectedValue = formTables.Tables("PMCR_DEAD1").Rows(0).Item("OtherMoveDisordCert")
        If formTables.Tables("PMCR_DEAD1").Rows(0).Item("MajCVA").ToString = "1" Then
            chkMajorCVA.Checked = True
        Else
            chkMajorCVA.Checked = False
        End If
        txtMajorCVAAgeOnset.Text = formTables.Tables("PMCR_DEAD1").Rows(0).Item("MajCVAAoO").ToString
        cmbMajorCVAConf.SelectedValue = formTables.Tables("PMCR_DEAD1").Rows(0).Item("MajCVACert")
        If formTables.Tables("PMCR_DEAD1").Rows(0).Item("OtherCerebro").ToString = "1" Then
            chkOtherCerebro.Checked = True
        Else
            chkOtherCerebro.Checked = False
        End If
        txtOthCerebroAgeOnset.Text = formTables.Tables("PMCR_DEAD1").Rows(0).Item("OtherCerebroAoO").ToString
        cmbOthCerebroConf.SelectedValue = formTables.Tables("PMCR_DEAD1").Rows(0).Item("OtherCerebroCert")
        If formTables.Tables("PMCR_DEAD1").Rows(0).Item("HeadInjury").ToString = "1" Then
            chkHeadInjury.Checked = True
        Else
            chkHeadInjury.Checked = False
        End If
        txtHeadInjuryAgeOnset.Text = formTables.Tables("PMCR_DEAD1").Rows(0).Item("HeadInjuryAoO").ToString
        cmbHeadInjuryConf.SelectedValue = formTables.Tables("PMCR_DEAD1").Rows(0).Item("HeadInjuryCert")
        If formTables.Tables("PMCR_DEAD1").Rows(0).Item("tCNSNeo").ToString = "1" Then
            chktCNS.Checked = True
        Else
            chktCNS.Checked = False
        End If
        txttCNSAgeOnset.Text = formTables.Tables("PMCR_DEAD1").Rows(0).Item("tCNSNeoAoO").ToString
        cmbtCNSConf.SelectedValue = formTables.Tables("PMCR_DEAD1").Rows(0).Item("tCNSNeoCert")
        If formTables.Tables("PMCR_DEAD1").Rows(0).Item("CNSInfect").ToString = "1" Then
            chkCNSInfection.Checked = True
        Else
            chkCNSInfection.Checked = False
        End If
        txtCNSInfectionAgeOnset.Text = formTables.Tables("PMCR_DEAD1").Rows(0).Item("CNSInfectAoO").ToString
        cmbCNSInfectionConf.SelectedValue = formTables.Tables("PMCR_DEAD1").Rows(0).Item("CNSInfectCert")
        If formTables.Tables("PMCR_DEAD1").Rows(0).Item("Seizure").ToString = "1" Then
            chkSeizureDisorder.Checked = True
        Else
            chkSeizureDisorder.Checked = False
        End If
        txtSeizureDisorderAgeOnset.Text = formTables.Tables("PMCR_DEAD1").Rows(0).Item("SeizureAoO").ToString
        cmbSeizureDisorderConf.SelectedValue = formTables.Tables("PMCR_DEAD1").Rows(0).Item("SeizureCert")
        If formTables.Tables("PMCR_DEAD1").Rows(0).Item("ToxMeta").ToString = "1" Then
            chkToxicMetabolic.Checked = True
        Else
            chkToxicMetabolic.Checked = False
        End If
        txtToxicMetabolicAgeOnset.Text = formTables.Tables("PMCR_DEAD1").Rows(0).Item("ToxMetaAoO").ToString
        cmbToxicMetabolicConf.SelectedValue = formTables.Tables("PMCR_DEAD1").Rows(0).Item("ToxMetaCert")
        If formTables.Tables("PMCR_DEAD1").Rows(0).Item("Neurosurgery").ToString = "1" Then
            chkNeurosurgery.Checked = True
        Else
            chkNeurosurgery.Checked = False
        End If
        txtNeuroSurgeryAgeOnset.Text = formTables.Tables("PMCR_DEAD1").Rows(0).Item("NeurosurgeryAoO").ToString
        cmbNeurosurgeryConf.SelectedValue = formTables.Tables("PMCR_DEAD1").Rows(0).Item("NeurosurgeryCert")
        If formTables.Tables("PMCR_DEAD1").Rows(0).Item("OtherNeuroIll").ToString = "1" Then
            chkOthNeuroIllness.Checked = True
        Else
            chkOthNeuroIllness.Checked = False
        End If
        txtOthNeuroIllnessAgeOnset.Text = formTables.Tables("PMCR_DEAD1").Rows(0).Item("OtherNeuroIllAoO").ToString
        cmbOthNeuroIllnessConf.SelectedValue = formTables.Tables("PMCR_DEAD1").Rows(0).Item("OtherNeuroIllCert")
    End Sub
    Private Sub enableInputFields(ByVal bool As Boolean)
        grpDEAD.Enabled = bool
        grpCognitiveDecline.Enabled = bool
        grpPsychHosp.Enabled = bool
        grpNeuroIllness.Enabled = bool
        grpSigMedHist.Enabled = bool
        grpTestResults.Enabled = bool
    End Sub
    Private Sub btnDEAD1_Click(sender As Object, e As EventArgs) Handles btnDEAD1Bottom.Click, btnDEAD1Top.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_PMCR_Dead1", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                btnDEAD1Bottom.Text = "Save Changes"
                btnDEAD1Top.Text = btnDEAD1Bottom.Text
                enableInputFields(True)
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If User.PermissionCheck("WA_PMCR_Dead1", "Modify") Then
                loadBaseForm()
                setDefaultValues()
                lblNoRecord.Visible = False
                btnDEAD1Bottom.Text = "Save New Record"
                btnDEAD1Top.Text = "Save New Record"
                enableInputFields(True)
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
            End If
        Else 'By default, user is attempting to Insert or Edit a record. Run preSaveValidation.
            If preSaveValidation() Then 'If preSaveValidation returns true, take Insert or Update actions.
                'Same parameters for Insert or Update SP's, so define here
                Dim parameters = " @SubNum = " & WarehouseShell.SubNum &
                    ", @FamPsychHx = " & txtFamPsychHx.getSQLValue() &
                    ", @MemInOMH = " & intMembInOMH.getSQLValue() &
                    ", @MemAvail = " & intMembAvail.getSQLValue() &
                    ", @LastPsychDiag = " & txtLastPsychDx.getSQLValue() &
                    ", @PermCogImp = " & cmbEviPermCogImp.getSQLValue() &
                    ", @PermCogImpDate = " & dtEviPermCogimp.getSQLValue() &
                    ", @DementDiag = " & cmbDemDx.getSQLValue() &
                    ", @CompCogFunct = " & cmbCompCogFunct.getSQLValue() &
                    ", @AgeOnsetCogDecline = " & txtCogDecAgeOnset.getSQLValue() &
                    ", @PercentHosp26 = " & txtCogDecLess26.getSQLValue() &
                    ", @PercentHosp2645 = " & txtCogDec2645.getSQLValue() &
                    ", @PercentHosp4655 = " & txtCogDec4655.getSQLValue() &
                    ", @PercentHosp5665 = " & txtCogDec5665.getSQLValue() &
                    ", @PercentHosp6675 = " & txtCogDec6675.getSQLValue() &
                    ", @PercentHosp75 = " & txtCogDecMore75.getSQLValue() &
                    ", @TotalYrsHosp = " & txtTotalYrsHosp.getSQLValue() &
                    ", @LenLastPsychHosp = " & txtLenLastPsychHosp.getSQLValue() &
                    ", @TotNumHospPsych = " & txtTotalNumPsychHosp.getSQLValue() &
                    ", @TardDysk = " & chkTardiveDysk.getSQLValue() &
                    ", @TardDyskAoO = " & txtTardiveDyskAgeOnset.getSQLValue() &
                    ", @TardDyskCert = " & cmbTardiveDyskConf.getSQLValue() &
                    ", @OtherMoveDisord = " & chkOthMovDis.getSQLValue() &
                    ", @OtherMoveDisordAoO = " & txtOthMovDisAgeOnset.getSQLValue() &
                    ", @OtherMoveDisordCert = " & cmbOthMovDisConf.getSQLValue() &
                    ", @MajCVA = " & chkMajorCVA.getSQLValue() &
                    ", @MajCVAAoO = " & txtMajorCVAAgeOnset.getSQLValue() &
                    ", @MajCVACert = " & cmbMajorCVAConf.getSQLValue() &
                    ", @OtherCerebro = " & chkOtherCerebro.getSQLValue() &
                    ", @OtherCerebroAoO = " & txtOthCerebroAgeOnset.getSQLValue() &
                    ", @OtherCerebroCert = " & txtOthCerebroAgeOnset.getSQLValue() &
                    ", @HeadInjury = " & chkHeadInjury.getSQLValue() &
                    ", @HeadInjuryAoO = " & txtHeadInjuryAgeOnset.getSQLValue() &
                    ", @HeadInjuryCert = " & cmbHeadInjuryConf.getSQLValue() &
                    ", @tCNSNeo = " & chktCNS.getSQLValue() &
                    ", @tCNSNeoAoO = " & txttCNSAgeOnset.getSQLValue() &
                    ", @tCNSNeoCert = " & cmbtCNSConf.getSQLValue() &
                    ", @CNSInfect = " & chkCNSInfection.getSQLValue() &
                    ", @CNSInfectAoO = " & txtCNSInfectionAgeOnset.getSQLValue() &
                    ", @CNSInfectCert = " & cmbCNSInfectionConf.getSQLValue() &
                    ", @Seizure = " & chkSeizureDisorder.getSQLValue() &
                    ", @SeizureAoO = " & txtSeizureDisorderAgeOnset.getSQLValue() &
                    ", @SeizureCert = " & cmbSeizureDisorderConf.getSQLValue() &
                    ", @ToxMeta = " & chkToxicMetabolic.getSQLValue() &
                    ", @ToxMetaAoO = " & txtToxicMetabolicAgeOnset.getSQLValue() &
                    ", @ToxMetaCert = " & cmbToxicMetabolicConf.getSQLValue() &
                    ", @Neurosurgery = " & chkNeurosurgery.getSQLValue() &
                    ", @NeurosurgeryAoO = " & txtNeuroSurgeryAgeOnset.getSQLValue() &
                    ", @NeurosurgeryCert = " & cmbNeurosurgeryConf.getSQLValue() &
                    ", @OtherNeuroIll = " & chkOthNeuroIllness.getSQLValue() &
                    ", @OtherNeuroIllAoO = " & txtOthNeuroIllnessAgeOnset.getSQLValue() &
                    ", @OtherNeuroIllCert = " & cmbOthNeuroIllnessConf.getSQLValue() &
                    ", @LastModBy = '" & WarehouseShell.userName & "';"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    Dim cmd As New SqlCommand("Exec modPMCR_DEAD1Record @Action = 1, " & parameters, WarehouseShell.conn)
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Save successful", MsgBoxStyle.OkOnly)
                        enableInputFields(False)
                        btnDEAD1Bottom.Text = "Edit Record"
                        btnDEAD1Top.Text = "Edit Record"
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else 'If this clause is invoked, datamode must be Edit
                    Dim cmd As New SqlCommand("Exec modPMCR_DEAD1Record @Action = 2, " & parameters, WarehouseShell.conn)
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Save successful", MsgBoxStyle.OkOnly)
                        enableInputFields(False)
                        btnDEAD1Bottom.Text = "Edit Record"
                        btnDEAD1Top.Text = "Edit Record"
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                End If
            End If
        End If
    End Sub

    'DEAD1 grpPsychHosp Subs
    Private PsychHospDataMode As String 'datamode specific to grpPsychoHosp
    Private PsychoHospRecordID As String
    Private Function getPsychHosp() As DataTable
        Dim cmd As New SqlCommand("select a.RecordID, a.SubNum, a.InstitutionID, b.Name as Institution, a.Admitted, a.Discharged, a.DischargeDx from PMCR_DEAD1_PsychHosp a left join refInstitution b on a.InstitutionID = b.InstitutionID where a.SubNum = " & WarehouseShell.SubNum & " Order By Admitted desc", WarehouseShell.conn)
        Dim Reader As System.Data.SqlClient.SqlDataAdapter
        Dim Result As New DataTable("PMCR_DEAD1_PsychHosp")
        Reader = New SqlDataAdapter(cmd)
        Reader.Fill(Result)
        Return Result
    End Function 'Return view of PMCR_DEAD1_PsychHosp adding InstitutionName
    Private Sub loadPsychHosp()
        PsychHospDataMode = "View"
        'Remove the table if it exists (helps when re-calling this sub after a record insert)
        If formTables.Tables.Contains("PMCR_DEAD1_PsychHosp") Then
            formTables.Tables.Remove("PMCR_DEAD1_PsychHosp")
        End If
        'Grab a fresh copy of the table and (re)attach it as the data source
        formTables.Tables.Add(getPsychHosp())
        dgvPsychHosp.DataSource = formTables.Tables("PMCR_DEAD1_PsychHosp")
        dgvPsychHosp.Columns("RecordID").Visible = False
        dgvPsychHosp.Columns("SubNum").Visible = False
        dgvPsychHosp.Columns("InstitutionID").Visible = False
        btnPsychHospEdit.Enabled = False
        'set input fields to default/blank
        cmbPsychHospInstitution.SelectedValue = -1
        dtPsychHospAdmitted.Clear()
        dtPsychHospDischarged.Clear()
        txtPsychHospDischargeDx.Clear()
        PsychoHospRecordID = Nothing
        'Set up buttons to defaults
        btnPsychHospAdd.Enabled = True
        btnPsychHospAdd.Text = "Add New"
        btnPsychHospEdit.Enabled = False 'This method clears input fields, so nothing to edit
        btnPsychHospEdit.Text = "Edit Record"
        btnPsychHospCancel.Visible = False 'Since this always loads into view & locked, there is never anything to cancel
    End Sub
    Private Sub enablePsychHospInputFields(ByVal bool As Boolean)
        If bool = True Then
            cmbPsychHospInstitution.Enabled = True
            dtPsychHospAdmitted.Enabled = True
            dtPsychHospDischarged.Enabled = True
            txtPsychHospDischargeDx.Enabled = True
        Else
            cmbPsychHospInstitution.Enabled = False
            dtPsychHospAdmitted.Enabled = False
            dtPsychHospDischarged.Enabled = False
            txtPsychHospDischargeDx.Enabled = False
        End If
    End Sub
    Private Sub dgvPsychoHosp_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPsychHosp.CellDoubleClick
        If PsychHospDataMode <> "View" Then
            Dim result As MsgBoxResult = MsgBox("You have potentially unsaved work in the Psychiatric Hospitalizations input fields. Would you like to continue loading the selected record? (this will overwrite any unsaved values you have added/edited in these input fields)", MsgBoxStyle.YesNo, "Warning")
            If result = MsgBoxResult.Yes Then
                'set mode and enable/disable fields
                PsychHospDataMode = "View"
                enablePsychHospInputFields(False)
                btnPsychHospAdd.Text = "Add Record"
                btnPsychHospEdit.Text = "Edit Record"
                btnPsychHospEdit.Enabled = True
                'load values into combo/text boxes
                cmbPsychHospInstitution.SelectedValue = dgvPsychHosp.SelectedRows(0).Cells("InstitutionID").Value
                If IsDate(dgvPsychHosp.SelectedRows(0).Cells("Admitted").Value) Then
                    dtPsychHospAdmitted.Text = Format(dgvPsychHosp.SelectedRows(0).Cells("Admitted").Value, "MM-dd-yyyy")
                End If
                If IsDate(dgvPsychHosp.SelectedRows(0).Cells("Discharged").Value) Then
                    dtPsychHospDischarged.Text = Format(dgvPsychHosp.SelectedRows(0).Cells("Discharged").Value, "MM-dd-yyyy")
                End If
                txtPsychHospDischargeDx.Text = dgvPsychHosp.SelectedRows(0).Cells("DischargeDx").Value.ToString
                'load affiliated PMCRRecordID into PsychoHospPMCRRecordID variable
                PsychoHospRecordID = dgvPsychHosp.SelectedRows(0).Cells("RecordID").Value.ToString
            End If
        Else
            'set mode and enable/disable fields
            PsychHospDataMode = "View"
            enablePsychHospInputFields(False)
            btnPsychHospAdd.Text = "Add Record"
            btnPsychHospEdit.Text = "Edit Record"
            btnPsychHospEdit.Enabled = True
            'load values into combo/text boxes
            cmbPsychHospInstitution.SelectedValue = dgvPsychHosp.SelectedRows(0).Cells("InstitutionID").Value
            If IsDate(dgvPsychHosp.SelectedRows(0).Cells("Admitted").Value) Then
                dtPsychHospAdmitted.Text = Format(dgvPsychHosp.SelectedRows(0).Cells("Admitted").Value, "MM-dd-yyyy").ToString
            End If
            If IsDate(dgvPsychHosp.SelectedRows(0).Cells("Discharged").Value) Then
                dtPsychHospDischarged.Text = Format(dgvPsychHosp.SelectedRows(0).Cells("Discharged").Value, "MM-dd-yyyy").ToString
            End If
            txtPsychHospDischargeDx.Text = dgvPsychHosp.SelectedRows(0).Cells("DischargeDx").Value.ToString
            'load affiliated PMCRRecordID into PsychoHospPMCRRecordID variable
            PsychoHospRecordID = dgvPsychHosp.SelectedRows(0).Cells("RecordID").Value.ToString
        End If
    End Sub
    Private Sub btnPsychHospAdd_Click(sender As Object, e As EventArgs) Handles btnPsychHospAdd.Click
        If PsychHospDataMode = "View" Then
            'Set mode and enable/disable fields
            PsychHospDataMode = "Insert"
            btnPsychHospCancel.Visible = True
            btnPsychHospAdd.Text = "Save Record"
            btnPsychHospEdit.Enabled = False
            enablePsychHospInputFields(True)
            'Clear input values and set focus to first field
            cmbPsychHospInstitution.SelectedValue = -1
            dtPsychHospAdmitted.Clear()
            dtPsychHospDischarged.Clear()
            txtPsychHospDischargeDx.Clear()
            cmbPsychHospInstitution.Focus()
        Else 'mode must already be in insert, so user is trying to save new data
            If PsychoHospPreSaveValidation() = True Then 'False result handled within validation sub. No need to do anything else here.
                Dim cmd As New SqlCommand("Exec modPMCR_DEAD1_PsychHospRecord @Action = 1, @RecordID = 0, @SubNum = " & WarehouseShell.SubNum &
                                          ", @InstitutionID = " & cmbPsychHospInstitution.getSQLValue() &
                                          ", @Admitted = " & dtPsychHospAdmitted.getSQLValue() &
                                          ", @Discharged = " & dtPsychHospDischarged.getSQLValue() &
                                          ", @DischargeDx = " & txtPsychHospDischargeDx.getSQLValue() &
                                          ";", WarehouseShell.conn)
                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    loadPsychHosp()
                    PsychHospDataMode = "View"
                    btnPsychHospCancel.Visible = False
                    enablePsychHospInputFields(False)
                    btnPsychHospEdit.Enabled = False
                    btnPsychHospAdd.Text = "Add New"
                Catch ex As Exception
                    ExceptionHandler.CatchSQLException(ex)
                End Try
            End If
        End If
    End Sub
    Private Sub btnPsychHospEdit_Click(sender As Object, e As EventArgs) Handles btnPsychHospEdit.Click
        If PsychHospDataMode = "View" Then
            'Set mode and enable/disable fields
            PsychHospDataMode = "Edit"
            btnPsychHospCancel.Visible = True
            btnPsychHospEdit.Text = "Save Changes"
            btnPsychHospAdd.Enabled = False
            'Enable the input fields and set focus to first field
            enablePsychHospInputFields(True)
            cmbPsychHospInstitution.Focus()
        Else 'mode must already be in insert, so user is trying to save new data
            If PsychoHospPreSaveValidation() = True Then 'False result handled within validation sub. No need to do anything else here.
                Dim cmd As New SqlCommand("Exec modPMCR_DEAD1_PsychHospRecord @Action = 2, @RecordID = " & PsychoHospRecordID &
                                          ", @SubNum = " & WarehouseShell.SubNum &
                                          ", @InstitutionID = " & cmbPsychHospInstitution.getSQLValue() &
                                          ", @Admitted = " & dtPsychHospAdmitted.getSQLValue() &
                                          ", @Discharged = " & dtPsychHospDischarged.getSQLValue() &
                                          ", @DischargeDx = " & txtPsychHospDischargeDx.getSQLValue() &
                                          ";", WarehouseShell.conn)
                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    loadPsychHosp()
                    PsychHospDataMode = "View"
                    btnPsychHospCancel.Visible = False
                    enablePsychHospInputFields(False)
                    btnPsychHospEdit.Text = "Edit Record"
                    btnPsychHospAdd.Enabled = True
                Catch ex As Exception
                    ExceptionHandler.CatchSQLException(ex)
                End Try
            End If
        End If
    End Sub
    Private Sub btnPsychHospCancel_Click(sender As Object, e As EventArgs) Handles btnPsychHospCancel.Click
        loadPsychHosp()
    End Sub
    Private Function PsychoHospPreSaveValidation() As Boolean
        Dim result As Boolean = True
        If IsDate(dtPsychHospAdmitted.Text) And IsDate(dtPsychHospDischarged.Text) Then
            If DateTime.Compare(dtPsychHospAdmitted.Text, dtPsychHospDischarged.Text) > 0 Then
                MsgBox("Discharge date cannot be before admitting date!", MsgBoxStyle.Critical, "Error!")
                result = False
            End If
        End If
        If txtPsychHospDischargeDx.Text = "" Then
            MsgBox("You must enter a Discharge Diagnosis!", MsgBoxStyle.Critical, "Error!")
            result = False
        End If
        Return result
    End Function

    'DEAD1 grpSigMedHx Subs
    Private SigMedHxDataMode As String 'datamode specific to grpSigMedHx
    Private SigMedHxRecordID As String
    Private Sub loadSigMedHx()
        SigMedHxDataMode = "View"
        'Remove the table if it exists (helps when re-calling this sub after a record insert)
        If formTables.Tables.Contains("PMCR_DEAD1_SigMedicalHx") Then
            formTables.Tables.Remove("PMCR_DEAD1_SigMedicalHx")
        End If
        'Grab a fresh copy of the table and (re)attach it as the data source
        formTables.Tables.Add(Database.ReturnTable("PMCR_DEAD1_SigMedicalHx", , "SubNum = " & WarehouseShell.SubNum, "AgeOfOnset asc"))
        dgvSigMedHx.DataSource = formTables.Tables("PMCR_DEAD1_SigMedicalHx")
        dgvSigMedHx.Columns("RecordID").Visible = False
        dgvSigMedHx.Columns("SubNum").Visible = False
        btnSigMedHxEdit.Enabled = False
        'set input fields to default/blank
        txtSigMedHxIllInj.Clear()
        txtSigMedHxAgeOnset.Clear()
        txtSigMedHxAgeConc.Clear()
        txtSigMedHxTreatment.Clear()
        txtSigMedHxOutcome.Clear()
        txtSigMedHxComplications.Clear()
        SigMedHxRecordID = Nothing
        'Set up buttons to defaults
        btnSigMedHxAdd.Enabled = True
        btnSigMedHxAdd.Text = "Add New"
        btnSigMedHxEdit.Enabled = False 'This method clears input fields, so nothing to edit
        btnSigMedHxEdit.Text = "Edit Record"
        btnSigMedHxCancel.Visible = False 'Since this always loads into view & locked, there is never anything to cancel
    End Sub
    Private Sub enableSigMedHxInputFields(ByVal bool As Boolean)
        If bool = True Then
            txtSigMedHxIllInj.Enabled = True
            txtSigMedHxAgeOnset.Enabled = True
            txtSigMedHxAgeConc.Enabled = True
            txtSigMedHxTreatment.Enabled = True
            txtSigMedHxOutcome.Enabled = True
            txtSigMedHxComplications.Enabled = True
        Else
            txtSigMedHxIllInj.Enabled = False
            txtSigMedHxAgeOnset.Enabled = False
            txtSigMedHxAgeConc.Enabled = False
            txtSigMedHxTreatment.Enabled = False
            txtSigMedHxOutcome.Enabled = False
            txtSigMedHxComplications.Enabled = False
        End If
    End Sub
    Private Sub dgvSigMedHx_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSigMedHx.CellDoubleClick
        Try
            If SigMedHxDataMode <> "View" Then
                Dim result As MsgBoxResult = MsgBox("You have potentially unsaved work in the Significant Medical History input fields. Would you like to continue loading the selected record? (this will overwrite any unsaved values you have added/edited in these input fields)", MsgBoxStyle.YesNo, "Warning")
                If result = MsgBoxResult.Yes Then
                    'set mode and enable/disable fields
                    SigMedHxDataMode = "View"
                    enableSigMedHxInputFields(False)
                    btnSigMedHxAdd.Text = "Add Record"
                    btnSigMedHxEdit.Text = "Edit Record"
                    btnSigMedHxEdit.Enabled = True
                    'load values into combo/text boxes
                    txtSigMedHxIllInj.Text = dgvSigMedHx.SelectedRows(0).Cells("IllnessInjury").Value.ToString
                    txtSigMedHxAgeOnset.Text = dgvSigMedHx.SelectedRows(0).Cells("AgeOfOnset").Value.ToString
                    txtSigMedHxAgeConc.Text = dgvSigMedHx.SelectedRows(0).Cells("AgeOfConclusion").Value.ToString
                    txtSigMedHxTreatment.Text = dgvSigMedHx.SelectedRows(0).Cells("Treatment").Value.ToString
                    txtSigMedHxOutcome.Text = dgvSigMedHx.SelectedRows(0).Cells("Outcome").Value.ToString
                    txtSigMedHxComplications.Text = dgvSigMedHx.SelectedRows(0).Cells("Complications").Value.ToString
                    SigMedHxRecordID = dgvSigMedHx.SelectedRows(0).Cells("RecordID").Value.ToString
                End If
            Else
                'set mode and enable/disable fields
                SigMedHxDataMode = "View"
                enableSigMedHxInputFields(False)
                btnSigMedHxAdd.Text = "Add Record"
                btnSigMedHxEdit.Text = "Edit Record"
                btnSigMedHxEdit.Enabled = True
                'load values into combo/text boxes
                txtSigMedHxIllInj.Text = dgvSigMedHx.SelectedRows(0).Cells("IllnessInjury").Value.ToString
                txtSigMedHxAgeOnset.Text = dgvSigMedHx.SelectedRows(0).Cells("AgeOfOnset").Value.ToString
                txtSigMedHxAgeConc.Text = dgvSigMedHx.SelectedRows(0).Cells("AgeOfConclusion").Value.ToString
                txtSigMedHxTreatment.Text = dgvSigMedHx.SelectedRows(0).Cells("Treatment").Value.ToString
                txtSigMedHxOutcome.Text = dgvSigMedHx.SelectedRows(0).Cells("Outcome").Value.ToString
                txtSigMedHxComplications.Text = dgvSigMedHx.SelectedRows(0).Cells("Complications").Value.ToString
                SigMedHxRecordID = dgvSigMedHx.SelectedRows(0).Cells("RecordID").Value.ToString
            End If
        Catch ex As Exception
            ExceptionHandler.CatchWindowsException(ex)
        End Try
    End Sub
    Private Sub btnSigMedHxAdd_Click(sender As Object, e As EventArgs) Handles btnSigMedHxAdd.Click
        If SigMedHxDataMode = "View" Then
            'Set mode and enable/disable fields
            SigMedHxDataMode = "Insert"
            btnSigMedHxCancel.Visible = True
            btnSigMedHxAdd.Text = "Save Record"
            btnSigMedHxEdit.Enabled = False
            enableSigMedHxInputFields(True)
            'Clear input values and set focus to first field
            txtSigMedHxIllInj.Clear()
            txtSigMedHxAgeOnset.Clear()
            txtSigMedHxAgeConc.Clear()
            txtSigMedHxTreatment.Clear()
            txtSigMedHxOutcome.Clear()
            txtSigMedHxComplications.Clear()
            txtSigMedHxIllInj.Focus()
        Else 'mode must already be in insert, so user is trying to save new data
            If SigMedHxPreSaveValidation() = True Then 'False result handled within validation sub. No need to do anything else here.
                Dim cmd As New SqlCommand("Exec modPMCR_DEAD1_SigMedicalHxRecord @Action = 1, @RecordID = 0, @SubNum = " & WarehouseShell.SubNum &
                                          ", @IllnessInjury = " & txtSigMedHxIllInj.getSQLValue() &
                                          ", @AgeOfOnset = " & txtSigMedHxAgeOnset.getSQLValue() &
                                          ", @AgeOfConclusion = " & txtSigMedHxAgeConc.getSQLValue() &
                                          ", @Treatment = " & txtSigMedHxTreatment.getSQLValue() &
                                          ", @Outcome = " & txtSigMedHxOutcome.getSQLValue() &
                                          ", @Complications = " & txtSigMedHxComplications.getSQLValue() &
                                          ";", WarehouseShell.conn)
                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    loadSigMedHx()
                    SigMedHxDataMode = "View"
                    btnSigMedHxCancel.Visible = False
                    enableSigMedHxInputFields(False)
                    btnSigMedHxEdit.Enabled = False
                    btnSigMedHxAdd.Text = "Add New"
                Catch sqlEx As SqlException
                    ExceptionHandler.CatchSQLException(sqlEx)
                Catch winEx As Exception
                    ExceptionHandler.CatchWindowsException(winEx)
                End Try
            End If
        End If
    End Sub
    Private Sub btnSigMedHxEdit_Click(sender As Object, e As EventArgs) Handles btnSigMedHxEdit.Click
        If SigMedHxDataMode = "View" Then
            'Set mode and enable/disable fields
            SigMedHxDataMode = "Edit"
            btnSigMedHxCancel.Visible = True
            btnSigMedHxEdit.Text = "Save Changes"
            btnSigMedHxAdd.Enabled = False
            'Enable the input fields and set focus to first field
            enableSigMedHxInputFields(True)
            txtSigMedHxIllInj.Focus()
        Else 'mode must already be in insert, so user is trying to save new data
            If SigMedHxPreSaveValidation() = True Then 'False result handled within validation sub. No need to do anything else here.
                Dim cmd As New SqlCommand("Exec modPMCR_DEAD1_SigMedicalHxRecord @Action = 2, @RecordID = " & SigMedHxRecordID &
                                          ", @SubNum = " & WarehouseShell.SubNum &
                                          ", @IllnessInjury = " & txtSigMedHxIllInj.getSQLValue() &
                                          ", @AgeOfOnset = " & txtSigMedHxAgeOnset.getSQLValue() &
                                          ", @AgeOfConclusion = " & txtSigMedHxAgeConc.getSQLValue() &
                                          ", @Treatment = " & txtSigMedHxTreatment.getSQLValue() &
                                          ", @Outcome = " & txtSigMedHxOutcome.getSQLValue() &
                                          ", @Complications = " & txtSigMedHxComplications.getSQLValue() &
                                          ";", WarehouseShell.conn)
                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    loadSigMedHx()
                    SigMedHxDataMode = "View"
                    btnSigMedHxCancel.Visible = False
                    enableSigMedHxInputFields(False)
                    btnSigMedHxEdit.Text = "Edit Record"
                    btnSigMedHxAdd.Enabled = True
                Catch ex As Exception
                    ExceptionHandler.CatchSQLException(ex)
                End Try
            End If
        End If
    End Sub
    Private Sub btnSigMedHxCancel_Click(sender As Object, e As EventArgs) Handles btnSigMedHxCancel.Click
        loadSigMedHx()
    End Sub
    Private Function SigMedHxPreSaveValidation()
        Return True
    End Function

    'DEAD1 grpTestResults Subs
    Private grpTestResultsDataMode As String 'datamode specific to grpTestResults
    Private Sub loadDEAD1TestResults()
        'Remove the table if it exists (helps when re-calling this sub after a record insert)
        If formTables.Tables.Contains("PMCR_DEAD1_TestResults") Then
            formTables.Tables.Remove("PMCR_DEAD1_TestResults")
        End If
        'Grab a fresh copy of the table and (re)attach it as the data source
        formTables.Tables.Add(Database.ReturnTable("PMCR_DEAD1_TestResults", , "SubNum = " & WarehouseShell.SubNum))
        dgvTestResults.DataSource = formTables.Tables("PMCR_DEAD1_TestResults")
        dgvTestResults.Columns("RecordID").Visible = False
        btnTestResultsEdit.Enabled = False
        'set input fields to default/blank
        txtTestResultsTest.Clear()
        dtTestResultsDate.Clear()
        txtTestResultsResults.Clear()
        grpTestResultsDataMode = "View"
        'reset testRecordID
        testRecordID = Nothing
    End Sub
    Private Sub enableDEAD1TestResultsInputFields(ByVal bool As Boolean)
        If bool = True Then
            txtTestResultsTest.Enabled = True
            dtTestResultsDate.Enabled = True
            txtTestResultsResults.Enabled = True
        Else
            txtTestResultsTest.Enabled = False
            dtTestResultsDate.Enabled = False
            txtTestResultsResults.Enabled = False
        End If
    End Sub
    Private Sub dgvTestResults_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTestResults.CellDoubleClick
        If grpTestResultsDataMode <> "View" Then
            Dim result As MsgBoxResult = MsgBox("You have potentially unsaved work in the Test Results input fields. Would you like to continue loading the selected record? (this will overwrite any unsaved values you have added/edited in these input fields)", MsgBoxStyle.YesNo, "Warning")
            If result = MsgBoxResult.Yes Then
                'set mode and enable/disable fields
                grpTestResultsDataMode = "View"
                enableDEAD1TestResultsInputFields(False)
                btnTestResultsAdd.Text = "Add Record"
                btnTestResultsEdit.Text = "Edit Record"
                btnTestResultsEdit.Enabled = True
                'load values into combo/text boxes
                txtTestResultsTest.Text = dgvTestResults.SelectedRows(0).Cells("Test").Value.ToString
                If IsDate(dgvTestResults.SelectedRows(0).Cells("TestDate").Value) Then
                    dtTestResultsDate.Text = Format(dgvTestResults.SelectedRows(0).Cells("TestDate").Value, "MM-dd-yyyy").ToString
                End If
                txtTestResultsResults.Text = dgvTestResults.SelectedRows(0).Cells("Results").Value.ToString
                testRecordID = dgvTestResults.SelectedRows(0).Cells("RecordID").Value
            End If
        Else
            'set mode and enable/disable fields
            grpTestResultsDataMode = "View"
            enableDEAD1TestResultsInputFields(False)
            btnTestResultsAdd.Text = "Add Record"
            btnTestResultsEdit.Text = "Edit Record"
            btnTestResultsEdit.Enabled = True
            'load values into combo/text boxes
            txtTestResultsTest.Text = dgvTestResults.SelectedRows(0).Cells("Test").Value.ToString
            If IsDate(dgvTestResults.SelectedRows(0).Cells("TestDate").Value) Then
                dtTestResultsDate.Text = Format(dgvTestResults.SelectedRows(0).Cells("TestDate").Value, "MM-dd-yyyy").ToString
            End If
            txtTestResultsResults.Text = dgvTestResults.SelectedRows(0).Cells("Results").Value.ToString
            testRecordID = dgvTestResults.SelectedRows(0).Cells("RecordID").Value
        End If
    End Sub
    Private Sub btnTestResultsAdd_Click(sender As Object, e As EventArgs) Handles btnTestResultsAdd.Click
        If grpTestResultsDataMode = "View" Then
            'Set mode and enable/disable fields
            grpTestResultsDataMode = "Insert"
            btnTestResultsAdd.Text = "Save Record"
            btnTestResultsEdit.Enabled = False
            enableDEAD1TestResultsInputFields(True)
            'Clear input values and set focus to first field
            txtTestResultsTest.Clear()
            dtTestResultsDate.Clear()
            txtTestResultsResults.Clear()
            txtTestResultsTest.Focus()
        Else 'mode must already be in insert, so user is trying to save new data
            If DEAD1TestResultsPreSaveValidation() = True Then 'False result handled within validation sub. No need to do anything else here.
                Dim cmd As New SqlCommand("Exec modPMCR_DEAD1_TestResultsRecord @Action = 1" &
                                          ", @RecordID = null" &
                                          ", @SubNum = " & WarehouseShell.SubNum &
                                          ", @Test = " & txtTestResultsTest.getSQLValue() &
                                          ", @TestDate = " & dtTestResultsDate.getSQLValue() &
                                          ", @Results = " & txtTestResultsResults.getSQLValue() &
                                          ";", WarehouseShell.conn)
                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    loadDEAD1TestResults()
                    grpTestResultsDataMode = "View"
                    enableDEAD1TestResultsInputFields(False)
                    btnTestResultsEdit.Enabled = False
                    btnTestResultsAdd.Text = "Add New"
                Catch sqlEx As SqlException
                    ExceptionHandler.CatchSQLException(sqlEx)
                Catch winEx As Exception
                    ExceptionHandler.CatchWindowsException(winEx)
                End Try
            End If
        End If
    End Sub
    Private Sub btnTestResultsEdit_Click(sender As Object, e As EventArgs) Handles btnTestResultsEdit.Click
        If grpTestResultsDataMode = "View" Then
            'Set mode and enable/disable fields
            grpTestResultsDataMode = "Edit"
            btnTestResultsEdit.Text = "Save Changes"
            btnTestResultsAdd.Enabled = False
            'Enable the input fields and set focus to first field
            enableDEAD1TestResultsInputFields(True)
            txtTestResultsTest.Focus()
        Else 'mode must already be in insert, so user is trying to save new data
            If DEAD1TestResultsPreSaveValidation() = True Then 'False result handled within validation sub. No need to do anything else here.
                Dim cmd As New SqlCommand("Exec modPMCR_DEAD1_TestResultsRecord @Action = 2, " &
                                          " @SubNum = " & WarehouseShell.SubNum &
                                          ", @Test = " & txtTestResultsTest.getSQLValue() &
                                          ", @TestDate = " & dtTestResultsDate.getSQLValue() &
                                          ", @Results = " & txtTestResultsResults.getSQLValue() &
                                          ", @RecordID = " & testRecordID &
                                          ";", WarehouseShell.conn)
                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    loadDEAD1TestResults()
                    grpTestResultsDataMode = "View"
                    enableDEAD1TestResultsInputFields(False)
                    btnTestResultsEdit.Text = "Edit Record"
                    btnTestResultsAdd.Enabled = True
                Catch ex As Exception
                    ExceptionHandler.CatchSQLException(ex)
                End Try
            End If
        End If
    End Sub
    Private Sub btnTestResultsCancel_Click(sender As Object, e As EventArgs) Handles btnTestResultsCancel.Click
        loadDEAD1TestResults()
    End Sub
    Private Function DEAD1TestResultsPreSaveValidation()
        Return True
    End Function
    Private Function preSaveValidation() As Boolean
        Return True
    End Function

    'Imported IForm Methods
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
    Public Sub Parent1(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        btnDEAD1Bottom.PerformClick()
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