Public Class WA_PMCR_Depression
    Implements IFormMethods
    Private formTables As New DataSet

    Private Sub WA_PMCR_Depression_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_PMCR_tabDepression")
        loadBaseForm()
        enableInputFields(False)
        If Database.ExistingRecordCheck("PMCR_Depression", "SubNum = " & WarehouseShell.SubNum) Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            loadExistingData()
            btnDepressionBottom.Text = "Edit Record"
            btnDepressionTop.Text = btnDepressionBottom.Text
            lblNoRecord.Visible = False
        Else
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            btnDepressionBottom.Text = "Add New Record"
            btnDepressionTop.Text = btnDepressionBottom.Text
            lblNoRecord.Visible = True
        End If
        btnDepressionTop.Focus()
    End Sub
    Private Sub loadBaseForm()
        WarehouseShell.highlightSelectedNode("WA_PMCR_tabDepression")
        'Grab any required comboLookUp tables
        formTables.Tables.Add(Database.ReturnTable("lkpYNNAUnk1239", , , "Value asc"))

        'Assign combobox lookups
        For Each cmb As Control In grpDepression.Controls
            If TypeOf cmb Is ComboBox_ Then
                CType(cmb, ComboBox_).assignLookup(formTables, "lkpYNNAUnk1239")
            End If
        Next
    End Sub
    Private Sub setDefaultValues()
        For Each cmb As Control In grpDepression.Controls
            If TypeOf cmb Is ComboBox_ Then
                CType(cmb, ComboBox_).SelectedValue = 2
            End If
        Next
    End Sub
    Private Sub loadExistingData()
        'Grab the individual record, based on RecordID, and assign values to their appropriate fields
        formTables.Tables.Add(Database.ReturnTable("PMCR_Depression", , "SubNum = " & WarehouseShell.SubNum))
        comboCurMoodDys.setValue(formTables, "PMCR_Depression", "MoodDysphCur")
        txtCurMoodDysDate.setValue(formTables, "PMCR_Depression", "MoodDysphorCurDate")
        comboHxMoodDys.setValue(formTables, "PMCR_Depression", "MoodDysphorHx")
        txtHxMoodDysDate.setValue(formTables, "PMCR_Depression", "MoodDysphorHxDate")
        comboCurDecInt.setValue(formTables, "PMCR_Depression", "DecInterestCur")
        txtCurDecIntDate.setValue(formTables, "PMCR_Depression", "DecInterestCurDate")
        comboHxDecInt.setValue(formTables, "PMCR_Depression", "DecInterestHx")
        txtHxDecIntDate.setValue(formTables, "PMCR_Depression", "DecInterestHxDate")
        comboCurWtLoss.setValue(formTables, "PMCR_Depression", "WeightLossCur")
        txtCurWtLossDate.setValue(formTables, "PMCR_Depression", "WeightLossCurDate")
        comboHxWtLoss.setValue(formTables, "PMCR_Depression", "WeightLossHx")
        txtHxWtLossDate.setValue(formTables, "PMCR_Depression", "WeightLossHxDate")
        comboCurDecApp.setValue(formTables, "PMCR_Depression", "DecAppetiteCur")
        txtCurDecAppDate.setValue(formTables, "PMCR_Depression", "DecAppetiteCurDate")
        comboHxDecApp.setValue(formTables, "PMCR_Depression", "DecAppetiteHx")
        txtHxDecAppDate.setValue(formTables, "PMCR_Depression", "DecAppetiteHxDate")
        comboCurWtGain.setValue(formTables, "PMCR_Depression", "WeightGainCur")
        txtCurWtGainDate.setValue(formTables, "PMCR_Depression", "WeightGainCurDate")
        comboHxWtGain.setValue(formTables, "PMCR_Depression", "WeightGainHx")
        txtHxWtGainDate.setValue(formTables, "PMCR_Depression", "WeightGainHxDate")
        comboCurEarlyInsom.setValue(formTables, "PMCR_Depression", "EarlyInsomCur")
        txtCurEarlyInsomDate.setValue(formTables, "PMCR_Depression", "EarlyInsomCurDate")
        comboHxEarlyInsom.setValue(formTables, "PMCR_Depression", "EarlyInsomHx")
        txtHxEarlyInsomDate.setValue(formTables, "PMCR_Depression", "EarlyInsomHxDate")
        comboCurMidInsom.setValue(formTables, "PMCR_Depression", "MidInsomCur")
        txtCurMidInsomDate.setValue(formTables, "PMCR_Depression", "MidINsomCurDate")
        comboHxMidInsom.setValue(formTables, "PMCR_Depression", "MidInsomHx")
        txtHxMidInsomDate.setValue(formTables, "PMCR_Depression", "MidInsomHxDate")
        comboCurLateInsom.setValue(formTables, "PMCR_Depression", "LateInsomCur")
        txtCurLateInsomDate.setValue(formTables, "PMCR_Depression", "LateInsomCurDate")
        comboHxLateInsom.setValue(formTables, "PMCR_Depression", "LateInsomHx")
        txtHxLateInsomDate.setValue(formTables, "PMCR_Depression", "LateInsomHxDate")
        comboCurHypersom.setValue(formTables, "PMCR_Depression", "HypersomniaCur")
        txtCurHypersomDate.setValue(formTables, "PMCR_Depression", "HypersomniaCurDate")
        comboHxHypersom.setValue(formTables, "PMCR_Depression", "HypersomniaHx")
        txtHxHypersomDate.setValue(formTables, "PMCR_Depression", "HypersomniaHxDate")
        comboCurPsychoAgi.setValue(formTables, "PMCR_Depression", "PsychoAgitationCur")
        txtCurPsychoAgiDate.setValue(formTables, "PMCR_Depression", "PsychoAgitationCurDate")
        comboHxPsychoAgi.setValue(formTables, "PMCR_Depression", "PsychoAgitationHx")
        txtHxPsychoAgiDate.setValue(formTables, "PMCR_Depression", "PsychoAgitationHxDate")
        comboCurPsychoRet.setValue(formTables, "PMCR_Depression", "PsychoRetardCur")
        txtCurPsychoRetDate.setValue(formTables, "PMCR_Depression", "PsychoRetardCurDate")
        comboHxPsychoRet.setValue(formTables, "PMCR_Depression", "PsychoRetardHx")
        txtHxPsychoRetDate.setValue(formTables, "PMCR_Depression", "PsychoRetardHxDate")
        comboCurFat.setValue(formTables, "PMCR_Depression", "FatigueCur")
        txtCurFatDate.setValue(formTables, "PMCR_Depression", "FatigueCurDate")
        comboHxFat.setValue(formTables, "PMCR_Depression", "FatigueHx")
        txtHxFatDate.setValue(formTables, "PMCR_Depression", "FatigueHxDate")
        comboCurSin.setValue(formTables, "PMCR_Depression", "WorthlessCur")
        txtCurSinDate.setValue(formTables, "PMCR_Depression", "WorthlessCurDate")
        comboHxSin.setValue(formTables, "PMCR_Depression", "WorthlessHx")
        txtHxSinDate.setValue(formTables, "PMCR_Depression", "WorthlessHxDate")
        comboCurDelSin.setValue(formTables, "PMCR_Depression", "DelusionCur")
        txtCurDelSinDate.setValue(formTables, "PMCR_Depression", "DelusionCurDate")
        comboHxDelSin.setValue(formTables, "PMCR_Depression", "DelusionHx")
        txtHxDelSinDate.setValue(formTables, "PMCR_Depression", "DelusionHxDate")
        comboCurRumin.setValue(formTables, "PMCR_Depression", "RuminationsCur")
        txtCurRuminDate.setValue(formTables, "PMCR_Depression", "RuminationsCurDate")
        comboHxRumin.setValue(formTables, "PMCR_Depression", "RuminationsHx")
        txtHxRuminDate.setValue(formTables, "PMCR_Depression", "RuminationsHxDate")
        comboCurRecur.setValue(formTables, "PMCR_Depression", "ThoughtDeathCur")
        txtCurRecurDate.setValue(formTables, "PMCR_Depression", "ThoughtDeathCurDate")
        comboHxRecur.setValue(formTables, "PMCR_Depression", "ThoughtDeathHx")
        txtHxRecurDate.setValue(formTables, "PMCR_Depression", "ThoughtDeathHxDate")
        comboCur2Wk.setValue(formTables, "PMCR_Depression", "LastTwoWkCur")
        txtCur2WkDate.setValue(formTables, "PMCR_Depression", "LastTwoWkCurDate")
        comboHx2Wk.setValue(formTables, "PMCR_Depression", "LastTwoWkHx")
        txtHx2WkDate.setValue(formTables, "PMCR_Depression", "LastTwoWkHxDate")
        comboCur6Mo.setValue(formTables, "PMCR_Depression", "SixMoCur")
        txtCur6MoDate.setValue(formTables, "PMCR_Depression", "SixMoCurDate")
        comboHx6Mo.setValue(formTables, "PMCR_Depression", "SixMoHx")
        txtHx6MoDate.setValue(formTables, "PMCR_Depression", "SixMoHxDate")
        comboCurLifeDx.setValue(formTables, "PMCR_Depression", "LifetimeCur")
        txtCurLifeDxDate.setValue(formTables, "PMCR_Depression", "LifetimeCurDate")
        comboHxLifeDx.setValue(formTables, "PMCR_Depression", "LifetimeHx")
        txtHxLifeDxDate.setValue(formTables, "PMCR_Depression", "LifetimeHxDate")
        comboCurDepContDem.setValue(formTables, "PMCR_Depression", "DepContDemCur")
        txtCurDepContDemDate.setValue(formTables, "PMCR_Depression", "DepContDemCurDate")
        comboHxDepContDem.setValue(formTables, "PMCR_Depression", "DepContDemHx")
        txtHxDepContDemDate.setValue(formTables, "PMCR_Depression", "DepContDemHxDate")
        txtDepressionNote.setValue(formTables, "PMCR_Depression", "DepressionNote")
    End Sub
    Private Sub enableInputFields(ByVal bool As Boolean)
        For Each input As Control In grpDepression.Controls
            If TypeOf input Is ComboBox_ Or TypeOf input Is TextBoxDatePast Then
                input.Enabled = bool
            End If
            If TypeOf input Is TextBox_ Then
                CType(input, TextBox_).makeReadOnly(Not bool)
            End If
        Next
    End Sub

    Private Sub btnDepression_Click(sender As Object, e As EventArgs) Handles btnDepressionBottom.Click, btnDepressionTop.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_PMCR_Depression", "Modify") Then
                btnDepressionBottom.Text = "Save Changes"
                btnDepressionTop.Text = btnDepressionBottom.Text
                enableInputFields(True)
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If User.PermissionCheck("WA_PMCR_Depression", "Modify") Then
                setDefaultValues()
                btnDepressionBottom.Text = "Save Record"
                btnDepressionTop.Text = btnDepressionBottom.Text
                enableInputFields(True)
                lblNoRecord.Visible = False
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
            End If
        Else 'By default, user is attempting to Insert or Edit a record. Run preSaveValidation.
            If preSaveValidation() Then 'If preSaveValidation returns true, take Insert or Update actions.
                'Same parameters for Insert or Update SP's, so define here
                Dim parameters = " @SubNum = " & WarehouseShell.SubNum &
                        ", @MoodDysphCur = " & comboCurMoodDys.getSQLValue() &
                        ", @MoodDysphorCurDate = " & txtCurMoodDysDate.getSQLValue() &
                        ", @MoodDysphorHx = " & comboHxMoodDys.getSQLValue() &
                        ", @MoodDysphorHxDate = " & txtHxMoodDysDate.getSQLValue() &
                        ", @DecInterestCur = " & comboCurDecInt.getSQLValue() &
                        ", @DecInterestCurDate = " & txtCurDecIntDate.getSQLValue() &
                        ", @DecInterestHx = " & comboHxDecInt.getSQLValue() &
                        ", @DecInterestHxDate = " & txtHxDecIntDate.getSQLValue() &
                        ", @WeightLossCur = " & comboCurWtLoss.getSQLValue() &
                        ", @WeightLossCurDate = " & txtCurWtLossDate.getSQLValue() &
                        ", @WeightLossHx = " & comboHxWtLoss.getSQLValue() &
                        ", @WeightLossHxDate = " & txtHxWtLossDate.getSQLValue() &
                        ", @DecAppetiteCur = " & comboCurDecApp.getSQLValue() &
                        ", @DecAppetiteCurDate = " & txtCurDecAppDate.getSQLValue() &
                        ", @DecAppetiteHx = " & comboHxDecApp.getSQLValue() &
                        ", @DecAppetiteHxDate = " & txtHxDecAppDate.getSQLValue() &
                        ", @WeightGainCur = " & comboCurWtGain.getSQLValue() &
                        ", @WeightGainCurDate = " & txtCurWtGainDate.getSQLValue() &
                        ", @WeightGainHx = " & comboHxWtGain.getSQLValue() &
                        ", @WeightGainHxDate = " & txtHxWtGainDate.getSQLValue() &
                        ", @EarlyInsomCur = " & comboCurEarlyInsom.getSQLValue() &
                        ", @EarlyInsomCurDate = " & txtCurEarlyInsomDate.getSQLValue() &
                        ", @EarlyInsomHx = " & comboHxEarlyInsom.getSQLValue() &
                        ", @EarlyInsomHxDate = " & txtHxEarlyInsomDate.getSQLValue() &
                        ", @MidInsomCur = " & comboCurMidInsom.getSQLValue() &
                        ", @MidInsomCurDate = " & txtCurMidInsomDate.getSQLValue() &
                        ", @MidInsomHx = " & comboHxMidInsom.getSQLValue() &
                        ", @MidInsomHxDate = " & txtHxMidInsomDate.getSQLValue() &
                        ", @LateInsomCur = " & comboCurLateInsom.getSQLValue() &
                        ", @LateInsomCurDate = " & txtCurLateInsomDate.getSQLValue() &
                        ", @LateInsomHx = " & comboHxLateInsom.getSQLValue() &
                        ", @LateInsomHxDate = " & txtHxLateInsomDate.getSQLValue() &
                        ", @HypersomniaCur = " & comboCurHypersom.getSQLValue() &
                        ", @HypersomniaCurDate = " & txtCurHypersomDate.getSQLValue() &
                        ", @HypersomniaHx = " & comboHxHypersom.getSQLValue() &
                        ", @HypersomniaHxDate = " & txtHxHypersomDate.getSQLValue() &
                        ", @PsychoAgitationCur = " & comboCurPsychoAgi.getSQLValue() &
                        ", @PsychoAgitationCurDate = " & txtCurPsychoAgiDate.getSQLValue() &
                        ", @PsychoAgitationHx = " & comboHxPsychoAgi.getSQLValue() &
                        ", @PsychoAgitationHxDate = " & txtHxPsychoAgiDate.getSQLValue() &
                        ", @PsychoRetardCur = " & comboCurPsychoRet.getSQLValue() &
                        ", @PsychoRetardCurDate = " & txtCurPsychoRetDate.getSQLValue() &
                        ", @PsychoRetardHx = " & comboHxPsychoRet.getSQLValue() &
                        ", @PsychoRetardHxDate = " & txtHxPsychoRetDate.getSQLValue() &
                        ", @FatigueCur = " & comboCurFat.getSQLValue() &
                        ", @FatigueCurDate = " & txtCurFatDate.getSQLValue() &
                        ", @FatigueHx = " & comboHxFat.getSQLValue() &
                        ", @FatigueHxDate = " & txtHxFatDate.getSQLValue() &
                        ", @WorthlessCur = " & comboCurSin.getSQLValue() &
                        ", @WorthlessCurDate = " & txtCurSinDate.getSQLValue() &
                        ", @WorthlessHx = " & comboHxSin.getSQLValue() &
                        ", @WorthlessHxDate = " & txtHxSinDate.getSQLValue() &
                        ", @DelusionCur = " & comboCurDelSin.getSQLValue() &
                        ", @DelusionCurDate = " & txtCurDelSinDate.getSQLValue() &
                        ", @DelusionHx = " & comboHxDelSin.getSQLValue() &
                        ", @DelusionHxDate = " & txtHxDelSinDate.getSQLValue() &
                        ", @RuminationsCur = " & comboCurRumin.getSQLValue() &
                        ", @RuminationsCurDate = " & txtCurRuminDate.getSQLValue() &
                        ", @RuminationsHx = " & comboHxRumin.getSQLValue() &
                        ", @RuminationsHxDate = " & txtHxRuminDate.getSQLValue() &
                        ", @ThoughtDeathCur = " & comboCurRecur.getSQLValue() &
                        ", @ThoughtDeathCurDate = " & txtCurRecurDate.getSQLValue() &
                        ", @ThoughtDeathHx = " & comboHxRecur.getSQLValue() &
                        ", @ThoughtDeathHxDate = " & txtHxRecurDate.getSQLValue() &
                        ", @LastTwoWkCur = " & comboCur2Wk.getSQLValue() &
                        ", @LastTwoWkCurDate = " & txtCur2WkDate.getSQLValue() &
                        ", @LastTwoWkHx = " & comboHx2Wk.getSQLValue() &
                        ", @LastTwoWkHxDate = " & txtHx2WkDate.getSQLValue() &
                        ", @SixMoCur = " & comboCur6Mo.getSQLValue() &
                        ", @SixMoCurDate = " & txtCur6MoDate.getSQLValue() &
                        ", @SixMoHx = " & comboHx6Mo.getSQLValue() &
                        ", @SixMoHxDate = " & txtHx6MoDate.getSQLValue() &
                        ", @LifetimeCur = " & comboCurLifeDx.getSQLValue() &
                        ", @LifetimeCurDate = " & txtCurLifeDxDate.getSQLValue() &
                        ", @LifetimeHx = " & comboHxLifeDx.getSQLValue() &
                        ", @LifetimeHxDate = " & txtHxLifeDxDate.getSQLValue() &
                        ", @DepContDemCur = " & comboCurDepContDem.getSQLValue() &
                        ", @DepContDemCurDate = " & txtCurDepContDemDate.getSQLValue() &
                        ", @DepContDemHx = " & comboHxDepContDem.getSQLValue() &
                        ", @DepContDemHxDate = " & txtHxDepContDemDate.getSQLValue() &
                        ", @DepressionNote = " & txtDepressionNote.getSQLValue() &
                        ", @LastModBy = '" & WarehouseShell.userName & "';"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    Dim cmd As New SqlCommand("", WarehouseShell.conn)
                    Dim cmdString = "Exec modPMCR_DepressionRecord @Action = 1, " & parameters
                    cmd.CommandText = cmdString
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Record successfully added", MsgBoxStyle.OkOnly, "Success")
                        btnDepressionBottom.Text = "Edit Record"
                        btnDepressionTop.Text = btnDepressionBottom.Text
                        enableInputFields(False)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else 'If this clause is invoked, datamode must be Edit
                    Dim cmd As New SqlCommand("", WarehouseShell.conn)
                    Dim cmdString = "Exec modPMCR_DepressionRecord @Action = 2, " & parameters
                    cmd.CommandText = cmdString
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Record successfully updated", MsgBoxStyle.OkOnly, "Success")
                        btnDepressionBottom.Text = "Edit Record"
                        btnDepressionTop.Text = btnDepressionBottom.Text
                        enableInputFields(False)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                End If
            End If
        End If
    End Sub
    Private Function preSaveValidation() As Boolean
        Dim errMsg As String = ""

        'Check response/date dependencies
        If txtCurMoodDysDate.Text <> "  /  /" And comboCurMoodDys.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtHxMoodDysDate.Text <> "  /  /" And comboHxMoodDys.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtCurDecIntDate.Text <> "  /  /" And comboCurDecInt.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtHxDecIntDate.Text <> "  /  /" And comboHxDecInt.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtCurWtLossDate.Text <> "  /  /" And comboCurWtLoss.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtHxWtLossDate.Text <> "  /  /" And comboHxWtLoss.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtCurDecAppDate.Text <> "  /  /" And comboCurDecApp.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtHxDecAppDate.Text <> "  /  /" And comboHxDecApp.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtCurWtGainDate.Text <> "  /  /" And comboCurWtGain.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtHxWtGainDate.Text <> "  /  /" And comboHxWtGain.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtCurEarlyInsomDate.Text <> "  /  /" And comboCurEarlyInsom.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtHxEarlyInsomDate.Text <> "  /  /" And comboHxEarlyInsom.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtCurMidInsomDate.Text <> "  /  /" And comboCurMidInsom.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtHxMidInsomDate.Text <> "  /  /" And comboHxMidInsom.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtCurHypersomDate.Text <> "  /  /" And comboCurHypersom.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtHxHypersomDate.Text <> "  /  /" And comboHxHypersom.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtCurPsychoAgiDate.Text <> "  /  /" And comboCurPsychoAgi.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtHxPsychoAgiDate.Text <> "  /  /" And comboHxPsychoAgi.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtCurPsychoRetDate.Text <> "  /  /" And comboCurPsychoRet.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtHxPsychoRetDate.Text <> "  /  /" And comboHxPsychoRet.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtCurFatDate.Text <> "  /  /" And comboCurFat.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtHxFatDate.Text <> "  /  /" And comboHxFat.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtCurSinDate.Text <> "  /  /" And comboCurSin.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtHxSinDate.Text <> "  /  /" And comboHxSin.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtCurDelSinDate.Text <> "  /  /" And comboCurDelSin.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtHxDelSinDate.Text <> "  /  /" And comboHxDelSin.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtCurRuminDate.Text <> "  /  /" And comboCurRumin.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtHxRuminDate.Text <> "  /  /" And comboHxRumin.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtCurRecurDate.Text <> "  /  /" And comboCurRecur.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtHxRecurDate.Text <> "  /  /" And comboHxRecur.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtCur2WkDate.Text <> "  /  /" And comboCur2Wk.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtHx2WkDate.Text <> "  /  /" And comboHx2Wk.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtCur6MoDate.Text <> "  /  /" And comboCur6Mo.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtHx6MoDate.Text <> "  /  /" And comboHx6Mo.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtCurLifeDxDate.Text <> "  /  /" And comboCurLifeDx.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtHxLifeDxDate.Text <> "  /  /" And comboHxLifeDx.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtCurDepContDemDate.Text <> "  /  /" And comboCurDepContDem.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If
        If txtHxDepContDemDate.Text <> "  /  /" And comboHxDepContDem.SelectedValue <> 1 Then
            MsgBox("While Yes responses do not REQUIRE a date, if you enter a date the corresponding dropdown box must say Yes." & vbNewLine & vbNewLine & "Save cannot be compelted until this issue is resolved.", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If

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
        btnDepressionBottom.PerformClick()
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