Public Class WA_PMCR_CDR
    Implements IFormMethods
    Private formTables As New DataSet
    Private recordID As Integer = 0

    Private Sub WA_PMCR_CDR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_PMCR_tabCDR")
        WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
        If Database.ExistingRecordCheck("CDR", "SubNum = " & WarehouseShell.SubNum & " and Visit = 888") Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            loadBaseForm()
            loadExistingData()
            enableInputFields(False)
            btnCDRBottom.Text = "Edit Record"
            btnCDRTop.Text = btnCDRBottom.Text
            lblNoRecord.Visible = False
        Else 'If it doesn't exist, 
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            enableInputFields(False)
            btnCDRBottom.Text = "Add New Record"
            btnCDRTop.Text = btnCDRBottom.Text
            lblNoRecord.Visible = True
        End If
    End Sub

    Private Sub loadBaseForm()
        WarehouseShell.highlightSelectedNode("WA_PMCR_tabCDR")
        'Grab any required comboLookUp tables
        formTables.Tables.Add(Database.ReturnTable("lkpVisit"))
        formTables.Tables.Add(Database.ReturnTable("lkpCDRScores"))
        formTables.Tables.Add(Database.ReturnTable("lkpCDRReason"))
        formTables.Tables.Add(Database.ReturnTable("lkpCDRImpaired"))
        formTables.Tables.Add(Database.ReturnTable("lkpYNNAUnk1239"))

        'assign them to their appropriate boxes
        cmbVisit.assignLookup(formTables, "lkpVisit")
        comboMemoryScore.assignLookup(formTables, "lkpCDRScores")
        comboMemoryReason.assignLookup(formTables, "lkpCDRReason")
        comboOrientationScore.assignLookup(formTables, "lkpCDRScores")
        comboOrientationReason.assignLookup(formTables, "lkpCDRReason")
        comboJudgementScore.assignLookup(formTables, "lkpCDRScores")
        comboJudgementReason.assignLookup(formTables, "lkpCDRReason")
        comboCommunityScore.assignLookup(formTables, "lkpCDRScores")
        comboCommunityReason.assignLookup(formTables, "lkpCDRReason")
        comboHomeScore.assignLookup(formTables, "lkpCDRScores")
        comboHomeReason.assignLookup(formTables, "lkpCDRReason")
        comboPersonalScore.assignLookup(formTables, "lkpCDRScores",,, "Value <> 0.5")
        comboPersonalReason.assignLookup(formTables, "lkpCDRReason")
        comboSpeech.assignLookup(formTables, "lkpCDRImpaired")
        comboCommands.assignLookup(formTables, "lkpCDRImpaired")
        comboRecognition.assignLookup(formTables, "lkpCDRImpaired")
        comboFeeding.assignLookup(formTables, "lkpCDRImpaired")
        comboIncontinence.assignLookup(formTables, "lkpCDRImpaired")
        comboWalking.assignLookup(formTables, "lkpCDRImpaired")
        comboChangeFinalReasonCode.assignLookup(formTables, "lkpYNNAUnk1239")
        comboClinFinalReasonCode.assignLookup(formTables, "lkpCDRReason")
    End Sub
    Private Sub enableInputFields(ByVal bool As Boolean)
        dtCDRDate.Enabled = bool
        comboMemoryScore.Enabled = bool
        comboMemoryReason.Enabled = bool
        comboOrientationScore.Enabled = bool
        comboOrientationReason.Enabled = bool
        comboJudgementScore.Enabled = bool
        comboJudgementReason.Enabled = bool
        comboCommunityScore.Enabled = bool
        comboCommunityReason.Enabled = bool
        comboHomeScore.Enabled = bool
        comboHomeReason.Enabled = bool
        comboPersonalScore.Enabled = bool
        comboPersonalReason.Enabled = bool
        comboSpeech.Enabled = bool
        comboCommands.Enabled = bool
        comboRecognition.Enabled = bool
        comboFeeding.Enabled = bool
        comboIncontinence.Enabled = bool
        comboWalking.Enabled = bool
        comboChangeFinalReasonCode.Enabled = bool
        txtFinalReasonCode.Enabled = bool
        txtClinTotal.Enabled = bool
        comboClinFinalReasonCode.Enabled = bool
        txtClinZScore.Enabled = bool
        txtClinPercent.Enabled = bool
        txtNotes.makeReadOnly(Not bool)
    End Sub
    Private Sub setDefaultValues()
        cmbVisit.SelectedValue = 888
        dtCDRDate.Text = DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).dtDoD.Text
        comboMemoryScore.SelectedValue = 0.0
        comboMemoryReason.SelectedValue = 0 '0 = "Normal Response"
        comboOrientationScore.SelectedValue = 0.0
        comboOrientationReason.SelectedValue = 0
        comboJudgementScore.SelectedValue = 0.0
        comboJudgementReason.SelectedValue = 0
        comboCommunityScore.SelectedValue = 0.0
        comboCommunityReason.SelectedValue = 0
        comboHomeScore.SelectedValue = 0.0
        comboHomeReason.SelectedValue = 0
        comboPersonalScore.SelectedValue = 0.0
        comboPersonalReason.SelectedValue = 0
        comboSpeech.SelectedValue = -1
        comboCommands.SelectedValue = -1
        comboRecognition.SelectedValue = -1
        comboFeeding.SelectedValue = -1
        comboIncontinence.SelectedValue = -1
        comboWalking.SelectedValue = -1
        txtCDRSum.Text = "0"
        txtCDRScore.Text = "0"
        comboChangeFinalReasonCode.SelectedValue = 2
        comboClinFinalReasonCode.SelectedValue = 0
    End Sub
    Private Sub loadExistingData()
        'Grab the individual record, based on RecordID, and assign values to their appropriate fields
        formTables.Tables.Add(Database.ReturnTable("CDR", , "SubNum = " & WarehouseShell.SubNum))
        recordID = formTables.Tables("CDR").Rows(0).Item("RecordID")
        cmbVisit.setValue(formTables, "CDR", "Visit")
        dtCDRDate.setValue(formTables, "CDR", "CDRDate")
        comboMemoryScore.setValue(formTables, "CDR", "MemoryScore")
        comboMemoryReason.setValue(formTables, "CDR", "MemoryReason")
        comboOrientationScore.setValue(formTables, "CDR", "OrientationScore")
        comboOrientationReason.setValue(formTables, "CDR", "OrientationReason")
        comboJudgementScore.setValue(formTables, "CDR", "JudgeProbScore")
        comboJudgementReason.setValue(formTables, "CDR", "JudgeProbReason")
        comboCommunityScore.setValue(formTables, "CDR", "CommAffairsScore")
        comboCommunityReason.setValue(formTables, "CDR", "CommAffairsReason")
        comboHomeScore.setValue(formTables, "CDR", "HomeHobbyScore")
        comboHomeReason.setValue(formTables, "CDR", "HomeHobbyReason")
        comboPersonalScore.setValue(formTables, "CDR", "PersonalCareScore")
        comboPersonalReason.setValue(formTables, "CDR", "PersonalCareReason")
        comboSpeech.setValue(formTables, "CDR", "Speech")
        comboCommands.setValue(formTables, "CDR", "Commands")
        comboRecognition.setValue(formTables, "CDR", "Recognition")
        comboFeeding.setValue(formTables, "CDR", "Feeding")
        comboIncontinence.setValue(formTables, "CDR", "Incontinence")
        comboWalking.setValue(formTables, "CDR", "Walking")
        txtCDRSum.setValue(formTables, "CDR", "CDRSum")
        If formTables.Tables("CDR").Rows(0).Item("CDRScore").ToString = "" Then
            txtCDRScore.setValue(formTables, "CDR", "ExternalCDRScore")
        Else
            txtCDRScore.setValue(formTables, "CDR", "CDRScore")
        End If
        comboChangeFinalReasonCode.setValue(formTables, "CDR", "ChangeFinReasonCode")
        txtFinalReasonCode.setValue(formTables, "CDR", "FinalReasonCode")
        txtClinTotal.setValue(formTables, "CDR", "ClinTotal")
        comboClinFinalReasonCode.setValue(formTables, "CDR", "ClinFinReasonCode")
        txtClinZScore.setValue(formTables, "CDR", "ClinZScore")
        txtClinPercent.setValue(formTables, "CDR", "ClinPercentage")
        txtExternalCDRScore.setValue(formTables, "CDR", "ExternalCDRScore")
        txtNotes.setValue(formTables, "CDR", "Notes")
    End Sub

    Private Sub calcCDRScore(sender As Object, e As EventArgs) Handles comboMemoryScore.SelectedValueChanged, comboOrientationScore.SelectedValueChanged, comboJudgementScore.SelectedValueChanged, comboCommunityScore.SelectedValueChanged, comboHomeScore.SelectedValueChanged, comboPersonalScore.SelectedValueChanged
        'Prevent calc events from firing in View and Undefined modes
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View And WarehouseShell.DataMode <> WarehouseShell.userDataMode.Undefined Then
            'Make sure all scores are valid (no -1's)
            If comboMemoryScore.SelectedValue <> -1 And comboOrientationScore.SelectedValue <> -1 And comboJudgementScore.SelectedValue <> -1 And comboCommunityScore.SelectedValue <> -1 And comboHomeScore.SelectedValue <> -1 And comboPersonalScore.SelectedValue <> -1 Then

                Dim m As Decimal = comboMemoryScore.SelectedValue
                Dim mAbove As Integer = 0
                Dim mBelow As Integer = 0
                Dim mEqual As Integer = 0

                'drop the secondary scores into an array
                Dim secondaryScores = New Decimal() {
                    comboOrientationScore.SelectedValue,
                    comboJudgementScore.SelectedValue,
                    comboCommunityScore.SelectedValue,
                    comboHomeScore.SelectedValue,
                    comboPersonalScore.SelectedValue}

                'create a dictionary to hold the COUNTS of each secondary score value
                Dim scoreCounts As New Dictionary(Of Decimal, Integer)
                scoreCounts.Add(0, 0)
                scoreCounts.Add(0.5, 0)
                scoreCounts.Add(1, 0)
                scoreCounts.Add(2, 0)
                scoreCounts.Add(3, 0)
                scoreCounts.Add(4, 0)
                scoreCounts.Add(5, 0)

                'Find out how many secondary scores >, <, and = to memory score, and fill scoreCounts dictionary
                For Each score As Decimal In secondaryScores
                    If score > m Then
                        mAbove += 1
                    ElseIf score < m Then
                        mBelow += 1
                    ElseIf score = m Then
                        mEqual += 1
                    End If

                    scoreCounts(score) += 1
                Next

                'If 3 or more secondary scores = Memory score, set overall CDR score to Memory score (checking first for special case 1).
                If mEqual >= 3 Then
                    If m = 0.0 Then 'Check for special case 1
                        'If 2 secondary scores > 0, set score to 0.5, else set to 0.0
                        If mAbove >= 2 Then
                            txtCDRScore.Text = "0.5"
                        Else
                            txtCDRScore.Text = "0.0"
                        End If
                    Else
                        txtCDRScore.Text = m.ToString
                    End If
                Else
                    'If 3 on one side of Memory score and 2 on the other, set overall CDR score to Memory score.
                    If (mAbove = 3 And mBelow = 2) Or (mAbove = 2 And mBelow = 3) Then
                        If comboMemoryScore.SelectedValue = 0.5 Then 'Check for special case 2
                            If mAbove >= 3 Then 'if scores are above 0.5, they must be 1 or more
                                txtCDRScore.Text = "1.0"
                            Else
                                txtCDRScore.Text = "0.5"
                            End If
                        Else
                            txtCDRScore.Text = m.ToString
                        End If
                    Else
                        'define majority of secondary scores
                        Dim majCount As Integer = 0
                        Dim tie As Boolean = False
                        Dim majVal1 As Decimal = 6
                        Dim majVal2 As Decimal = Nothing

                        If m > 0 And scoreCounts(0) = 5 Then 'special case 3
                            txtCDRScore.Text = "0.5"
                        Else
                            If mAbove = 2 And mBelow = 2 And mEqual = 1 Then
                                txtCDRScore.Text = m.ToString
                            Else 'special case 5

                                'figure out which one(s) are majority
                                majCount = scoreCounts(0)
                                For Each item As KeyValuePair(Of Decimal, Integer) In scoreCounts
                                    If item.Value > majCount Then
                                        majCount = item.Value
                                    End If
                                Next

                                'set majVals and determine if there are ties
                                For Each item As KeyValuePair(Of Decimal, Integer) In scoreCounts
                                    If item.Value = majCount Then
                                        If majVal1 <> 6 Then
                                            majVal2 = item.Key
                                            tie = True
                                        Else
                                            majVal1 = item.Key
                                        End If
                                    End If
                                Next

                                'If tie, majVal closer to m
                                If tie = True Then
                                    'check for special case 4- 2 above, 2 below, and 1 equal to Memory Score (m)
                                    If majCount = 2 And ((majVal1 < m And majVal2 > m) Or (majVal1 > m And majVal2 < m)) And (secondaryScores(0) = m Or secondaryScores(1) = m Or secondaryScores(2) = m Or secondaryScores(3) = m Or secondaryScores(4) = m) Then
                                        txtCDRScore.Text = m.ToString
                                    Else
                                        'check for special case 4- majority closest to Memory Score (m)
                                        If Math.Abs(majVal1 - m) < Math.Abs(majVal2 - m) Then
                                            txtCDRScore.Text = majVal1.ToString
                                        Else
                                            txtCDRScore.Text = majVal2.ToString
                                        End If
                                    End If
                                Else 'return value that is majority of secondary scores
                                    If majVal1 = 0 And m >= 1 Then
                                        txtCDRScore.Text = "0.5"
                                    Else
                                        txtCDRScore.Text = majVal1.ToString
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Else
                txtCDRScore.setValue(formTables, "CDR", "ExternalCDRScore")
            End If
        End If
    End Sub
    Private Sub calcCDRSum(sender As Object, e As EventArgs) Handles comboMemoryScore.SelectedValueChanged, comboOrientationScore.SelectedValueChanged, comboJudgementScore.SelectedValueChanged, comboCommunityScore.SelectedValueChanged, comboHomeScore.SelectedValueChanged, comboPersonalScore.SelectedValueChanged
        'Prevent calc events from firing in View and Undefined modes
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View And WarehouseShell.DataMode <> WarehouseShell.userDataMode.Undefined Then
            Dim sum As Decimal = 0
            sum += IIf(comboMemoryScore.SelectedValue <> -1, comboMemoryScore.SelectedValue, 0)
            sum += IIf(comboOrientationScore.SelectedValue <> -1, comboOrientationScore.SelectedValue, 0)
            sum += IIf(comboJudgementScore.SelectedValue <> -1, comboJudgementScore.SelectedValue, 0)
            sum += IIf(comboCommunityScore.SelectedValue <> -1, comboCommunityScore.SelectedValue, 0)
            sum += IIf(comboHomeScore.SelectedValue <> -1, comboHomeScore.SelectedValue, 0)
            sum += IIf(comboPersonalScore.SelectedValue <> -1, comboPersonalScore.SelectedValue, 0)
            txtCDRSum.Text = sum.ToString
        End If
    End Sub

    Private Sub btnCDRBottom_Click(sender As Object, e As EventArgs) Handles btnCDRBottom.Click, btnCDRTop.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_PMCR_CDR", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                btnCDRBottom.Text = "Save Changes"
                btnCDRTop.Text = btnCDRBottom.Text
                enableInputFields(True)
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If User.PermissionCheck("WA_PMCR_CDR", "Modify") Then
                lblNoRecord.Visible = False
                loadBaseForm()
                setDefaultValues()
                btnCDRBottom.Text = "Save Record"
                btnCDRTop.Text = "Save Record"
                enableInputFields(True)
                ActiveControl = comboMemoryScore
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
            End If
        Else 'By default, user is attempting to Insert or Edit a record. Run preSaveValidation.
            If preSaveValidation() Then 'If preSaveValidation returns true, take Insert or Update actions.
                'Same parameters for Insert or Update SP's, so define here
                Dim parameters = " @RecordID = " & recordID &
                    ", @SubNum = " & WarehouseShell.SubNum &
                    ", @CDRDate = " & dtCDRDate.getSQLValue() &
                    ", @Visit = " & cmbVisit.getSQLValue() &
                    ", @MemoryScore = " & comboMemoryScore.getSQLValue() &
                    ", @MemoryReason = " & comboMemoryReason.getSQLValue() &
                    ", @OrientationScore = " & comboOrientationScore.getSQLValue() &
                    ", @OrientationReason = " & comboOrientationReason.getSQLValue() &
                    ", @JudgeProbScore = " & comboJudgementScore.getSQLValue() &
                    ", @JudgeProbReason = " & comboJudgementReason.getSQLValue() &
                    ", @CommAffairsScore = " & comboCommunityScore.getSQLValue() &
                    ", @CommAffairsReason = " & comboCommunityReason.getSQLValue() &
                    ", @HomeHobbyScore = " & comboHomeScore.getSQLValue() &
                    ", @HomeHobbyReason = " & comboHomeReason.getSQLValue() &
                    ", @PersonalCareScore = " & comboPersonalScore.getSQLValue() &
                    ", @PersonalCareReason = " & comboPersonalReason.getSQLValue() &
                    ", @Speech = " & comboSpeech.getSQLValue() &
                    ", @Commands = " & comboCommands.getSQLValue() &
                    ", @Recognition = " & comboRecognition.getSQLValue() &
                    ", @Feeding = " & comboFeeding.getSQLValue() &
                    ", @Incontinence = " & comboIncontinence.getSQLValue() &
                    ", @Walking = " & comboWalking.getSQLValue() &
                    ", @CDRSum = " & txtCDRSum.getSQLValue() &
                    ", @CDRScore = " & txtCDRScore.getSQLValue() &
                    ", @ChangeFinReasonCode = " & comboChangeFinalReasonCode.getSQLValue() &
                    ", @FinalReasonCode = " & txtFinalReasonCode.getSQLValue() &
                    ", @ClinTotal = " & txtClinTotal.getSQLValue() &
                    ", @ClinFinReasonCode = " & comboClinFinalReasonCode.getSQLValue() &
                    ", @ClinZScore = " & txtClinZScore.getSQLValue() &
                    ", @ClinPercentage = " & txtClinPercent.getSQLValue() &
                    ", @Notes = " & txtNotes.getSQLValue() &
                    ", @LastModBy = '" & WarehouseShell.userName & "';"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    Dim cmdString = "Exec modCDRRecord @Action = 1, " & parameters
                    Dim cmd As New SqlCommand(cmdString, WarehouseShell.conn)
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Record Saved", MsgBoxStyle.OkOnly)
                        enableInputFields(False)
                        btnCDRBottom.Text = "Edit Record"
                        btnCDRTop.Text = btnCDRBottom.Text
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else 'If this clause is invoked, datamode must be Edit
                    Dim cmdString = "Exec modCDRRecord @Action = 2, " & parameters
                    Dim cmd As New SqlCommand(cmdString, WarehouseShell.conn)
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Record Saved", MsgBoxStyle.OkOnly)
                        enableInputFields(False)
                        btnCDRBottom.Text = "Edit Record"
                        btnCDRTop.Text = btnCDRBottom.Text
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                End If
            End If
        End If
    End Sub
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
        btnCDRBottom.PerformClick()
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