Public Class WA_PMCR_Hachinski
    Implements IFormMethods

    Private formTables As New DataSet
    Private HachScore As Integer = 0 'Used for calculating Hachinski score

    Private Sub WA_PMCR_Hachinski_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadBaseForm()
        WarehouseShell.highlightSelectedNode("WA_PMCR_tabHachinski")
        If Database.ExistingRecordCheck("PMCR_Hachinski", "SubNum = " & WarehouseShell.SubNum) Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            loadExistingData()
            enableInputFields(False)
            btnHachinski.Text = "Edit Record"
            lblNoRecord.Visible = False
        Else 'If it doesn't exist, alert user
            enableInputFields(False)
            btnHachinski.Text = "Add New Record"
            lblNoRecord.Visible = True
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
        End If
    End Sub
    Private Sub loadBaseForm()
        WarehouseShell.highlightSelectedNode("WA_PMCR_tabHachinski")
        intHachTotalScore.Text = 0
        formTables.Tables.Add(Database.ReturnTable("lkpHachinskiCriteria"))
        cmbHachinskiCriteria.assignLookup(formTables, "lkpHachinskiCriteria")
        cmbHachinskiCriteria.SelectedValue = -1
    End Sub
    Private Sub loadExistingData()
        'Grab the individual record, based on RecordID, and assign values to their appropriate fields
        formTables.Tables.Add(Database.ReturnTable("PMCR_Hachinski", , "SubNum = " & WarehouseShell.SubNum))
        chkHachAbruptOnset.setValue(formTables, "PMCR_Hachinski", "AbruptOnset")
        chkHachStepwise.setValue(formTables, "PMCR_Hachinski", "StepWise")
        chkHachFluctuatingCourse.setValue(formTables, "PMCR_Hachinski", "FluctCourse")
        chkHachNocturnConf.setValue(formTables, "PMCR_Hachinski", "NocturConf")
        chkHachRelPresPersonality.setValue(formTables, "PMCR_Hachinski", "RelPreservPerson")
        chkHachDepression.setValue(formTables, "PMCR_Hachinski", "Depression")
        chkHachSomaticComplaints.setValue(formTables, "PMCR_Hachinski", "SomaticComplaint")
        chkHachEmotIncont.setValue(formTables, "PMCR_Hachinski", "EmotIncont")
        chkHachHxHypertension.setValue(formTables, "PMCR_Hachinski", "HxHypertension")
        chkHachHxStrokes.setValue(formTables, "PMCR_Hachinski", "HxStrokes")
        chkHachEviAssocAthersclerosis.setValue(formTables, "PMCR_Hachinski", "EvidAssocAtherosclerosis")
        chkHachFocalNeuroSymptoms.setValue(formTables, "PMCR_Hachinski", "FocalNeuroSympt")
        chkHachFocalNeuroSigns.setValue(formTables, "PMCR_Hachinski", "FocalNeuroSigns")
        cmbHachinskiCriteria.setValue(formTables, "PMCR_Hachinski", "HachinskiCriteria")
    End Sub
    Private Sub enableInputFields(ByVal bool As Boolean)
        For Each chk As Control In grpHachinski.Controls
            If TypeOf chk Is CheckBox_ Then
                chk.Enabled = bool
            End If
        Next
    End Sub

    Private Sub chkHach_CheckedChanged2Pt(sender As Object, e As EventArgs) Handles chkHachAbruptOnset.CheckedChanged, chkHachFluctuatingCourse.CheckedChanged, chkHachHxStrokes.CheckedChanged, chkHachFocalNeuroSymptoms.CheckedChanged, chkHachFocalNeuroSigns.CheckedChanged
        If sender.Checked = True Then
            HachScore += 2
        Else
            HachScore -= 2
        End If
        intHachTotalScore.Text = HachScore.ToString
        calcHachDx()
    End Sub
    Private Sub chkHach_CheckChanged1Pt(sender As Object, e As EventArgs) Handles chkHachStepwise.CheckedChanged, chkHachNocturnConf.CheckedChanged, chkHachRelPresPersonality.CheckedChanged, chkHachDepression.CheckedChanged, chkHachSomaticComplaints.CheckedChanged, chkHachEmotIncont.CheckedChanged, chkHachHxHypertension.CheckedChanged, chkHachEviAssocAthersclerosis.CheckedChanged
        If sender.Checked = True Then
            HachScore += 1
        Else
            HachScore -= 1
        End If
        intHachTotalScore.Text = HachScore.ToString
        calcHachDx()
    End Sub
    Private Sub calcHachDx()
        If HachScore <= 4 Then
            cmbHachinskiCriteria.SelectedValue = 1
        ElseIf HachScore >= 7 Then
            cmbHachinskiCriteria.SelectedValue = 2
        Else
            cmbHachinskiCriteria.SelectedValue = 3
        End If
    End Sub
    Private Sub btnHachinski_Click(sender As Object, e As EventArgs) Handles btnHachinski.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_PMCR_Hachinski", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                btnHachinski.Text = "Save Changes"
                enableInputFields(True)
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If User.PermissionCheck("WA_PMCR_Hachinski", "Modify") Then
                enableInputFields(True)
                btnHachinski.Text = "Save Record"
                lblNoRecord.Visible = False
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
            End If
        Else 'By default, user is attempting to Insert or Edit a record. Run preSaveValidation.
            If preSaveValidation() Then 'If preSaveValidation returns true, take Insert or Update actions.
                'Same parameters for Insert or Update SP's, so define here
                Dim parameters = " @SubNum = " & WarehouseShell.SubNum &
                        ", @AbruptOnset = " & chkHachAbruptOnset.getSQLValue() &
                        ", @StepWise = " & chkHachStepwise.getSQLValue() &
                        ", @FluctCourse = " & chkHachFluctuatingCourse.getSQLValue() &
                        ", @NocturConf = " & chkHachNocturnConf.getSQLValue() &
                        ", @RelPreservPerson = " & chkHachRelPresPersonality.getSQLValue() &
                        ", @Depression = " & chkHachDepression.getSQLValue() &
                        ", @SomaticComplaint = " & chkHachSomaticComplaints.getSQLValue() &
                        ", @EmotIncont = " & chkHachEmotIncont.getSQLValue() &
                        ", @HxHypertension = " & chkHachHxHypertension.getSQLValue() &
                        ", @HxStrokes = " & chkHachHxStrokes.getSQLValue() &
                        ", @EvidAssocAtherosclerosis = " & chkHachEviAssocAthersclerosis.getSQLValue() &
                        ", @FocalNeuroSympt = " & chkHachFocalNeuroSymptoms.getSQLValue() &
                        ", @FocalNeuroSigns = " & chkHachFocalNeuroSigns.getSQLValue() &
                        ", @HachinskiCriteria = " & cmbHachinskiCriteria.getSQLValue() &
                        ", @LastModBy = '" & WarehouseShell.userName & "';"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    Dim cmdString = "Exec modPMCR_HachinskiRecord @Action = 1, " & parameters
                    Dim cmd As New SqlCommand(cmdString, WarehouseShell.conn)
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Record Saved", MsgBoxStyle.OkOnly)
                        enableInputFields(False)
                        btnHachinski.Text = "Edit Record"
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else 'If this clause is invoked, datamode must be Edit
                    Dim cmdString = "Exec modPMCR_HachinskiRecord @Action = 2, " & parameters
                    Dim cmd As New SqlCommand(cmdString, WarehouseShell.conn)
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Record Saved", MsgBoxStyle.OkOnly)
                        enableInputFields(False)
                        btnHachinski.Text = "Edit Record"
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
        btnHachinski.PerformClick()
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