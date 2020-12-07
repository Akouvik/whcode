Public Class WA_PMCR_Dead4
    Implements IFormMethods
    Private formTables As New DataSet

    Private Sub WA_PMCR_Dead4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Database.ExistingRecordCheck("PMCR_DEAD4", "SubNum = " & WarehouseShell.SubNum) Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            loadBaseForm()
            loadExistingData()
            btnDEAD4Top.Text = "Edit Record"
            btnDEAD4Bottom.Text = btnDEAD4Top.Text
        Else 'If it doesn't exist, change mode to Undefined and show user banner
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            lblNoRecord.Visible = True
            btnDEAD4Top.Text = "Add New Record"
            btnDEAD4Bottom.Text = btnDEAD4Top.Text
        End If
        enableInputFields(False)
    End Sub
    Private Sub loadBaseForm()
        formTables.Tables.Add(Database.ReturnTable("lkpSex"))
        formTables.Tables.Add(Database.ReturnTable("lkpRace"))
        formTables.Tables.Add(Database.ReturnTable("lkpHandedness"))
        formTables.Tables.Add(Database.ReturnTable("lkpMaritalStatus"))
        formTables.Tables.Add(Database.ReturnTable("lkpPMCR_DEAD4_Certainty"))
        formTables.Tables.Add(Database.ReturnTable("lkpPMCR_DEAD4_Significance"))
        formTables.Tables.Add(Database.ReturnTable("lkpPMCR_DEAD4_TempPattern"))
        formTables.Tables.Add(Database.ReturnTable("lkpPMCR_DEAD4_Prominence"))
        formTables.Tables.Add(Database.ReturnTable("lkpPMCR_DEAD4_TypeCogDecline"))
        formTables.Tables.Add(Database.ReturnTable("lkpPMCR_DEAD4_CauseDeath"))
        formTables.Tables.Add(Database.ReturnTable("lkpPMCR_DEAD4_Degree"))
        formTables.Tables.Add(Database.ReturnTable("lkpPMCR_DEAD4_LifeSig"))
        formTables.Tables.Add(Database.ReturnTable("lkpPMCR_DEAD4_CogDecWhen"))
        formTables.Tables.Add(Database.ReturnTable("lkpYN12"))
        formTables.Tables.Add(Database.ReturnTable("lkpPMCR_DEAD4_ExpToNL"))
        cmbSex.assignLookup(formTables, "lkpSex")
        cmbRace.assignLookup(formTables, "lkpRace")
        cmbHandedness.assignLookup(formTables, "lkpHandedness")
        cmbMaritalStatus.assignLookup(formTables, "lkpMaritalStatus")
        cmbCertainty.assignLookup(formTables, "lkpPMCR_DEAD4_Certainty")
        cmbSignificance.assignLookup(formTables, "lkpPMCR_DEAD4_Significance")
        cmbTemporalPattern.assignLookup(formTables, "lkpPMCR_DEAD4_TempPattern")
        cmbProminence.assignLookup(formTables, "lkpPMCR_DEAD4_Prominence")
        cmbTypeCogDec.assignLookup(formTables, "lkpPMCR_DEAD4_TypeCogDecline")
        cmbCauseOfDeath.assignLookup(formTables, "lkpPMCR_DEAD4_CauseDeath")
        cmbDegree.assignLookup(formTables, "lkpPMCR_DEAD4_Degree")
        cmbLifeSignificance.assignLookup(formTables, "lkpPMCR_DEAD4_LifeSig")
        cmbCogDecWhen.assignLookup(formTables, "lkpPMCR_DEAD4_CogDecWhen")
        cmbMemInOMH.assignLookup(formTables, "lkpYN12")
        cmbExpNeuroleptics.assignLookup(formTables, "lkpPMCR_DEAD4_ExpToNL")
        importSubjectDemoData()
    End Sub
    Private Sub setDefaultValues()
        cmbCertainty.SelectedValue = -1
        cmbSignificance.SelectedValue = -1
        cmbTemporalPattern.SelectedValue = -1
        cmbProminence.SelectedValue = -1
        cmbTypeCogDec.SelectedValue = "-1"
        cmbCauseOfDeath.SelectedValue = -1
        cmbDegree.SelectedValue = -1
        cmbLifeSignificance.SelectedValue = -1
        cmbCogDecWhen.SelectedValue = -1
        cmbMemInOMH.SelectedValue = -1
        cmbExpNeuroleptics.SelectedValue = -1
    End Sub
    Private Sub loadExistingData()
        formTables.Tables.Add(Database.ReturnTable("viewPMCR_DEAD4", , "SubNum = " & WarehouseShell.SubNum))
        cmbCertainty.setValue(formTables, "viewPMCR_DEAD4", "Certainty")
        cmbSignificance.setValue(formTables, "viewPMCR_DEAD4", "Significance")
        cmbTemporalPattern.setValue(formTables, "viewPMCR_DEAD4", "TemporalPattern")
        cmbProminence.setValue(formTables, "viewPMCR_DEAD4", "Prominence")
        cmbTypeCogDec.setValue(formTables, "viewPMCR_DEAD4", "TypeCogDecline")
        cmbCauseOfDeath.setValue(formTables, "viewPMCR_DEAD4", "CauseOfDeath")
        cmbDegree.setValue(formTables, "viewPMCR_DEAD4", "Degree")
        cmbLifeSignificance.setValue(formTables, "viewPMCR_DEAD4", "LifetimeSignificance")
        cmbCogDecWhen.setValue(formTables, "viewPMCR_DEAD4", "CogDeclineWhen")
        cmbMemInOMH.setValue(formTables, "viewPMCR_DEAD4", "MemInOMH")
        cmbExpNeuroleptics.setValue(formTables, "viewPMCR_DEAD4", "ExposureToNL")
    End Sub
    Private Sub importSubjectDemoData()
        formTables.Tables.Add(Database.ReturnTable("Subject",, "SubNum = " & WarehouseShell.SubNum))
        cmbSex.setValue(formTables, "Subject", "SexValue")
        cmbRace.setValue(formTables, "Subject", "RaceValue")
        cmbMaritalStatus.setValue(formTables, "Subject", "MaritalStatusValue")
        cmbHandedness.setValue(formTables, "Subject", "HandednessValue")
    End Sub
    Private Sub enableInputFields(ByVal bool As Boolean)
        If bool = True Then
            cmbCertainty.Enabled = True
            cmbSignificance.Enabled = True
            cmbDegree.Enabled = True
            cmbLifeSignificance.Enabled = True
            cmbTemporalPattern.Enabled = True
            cmbProminence.Enabled = True
            cmbTypeCogDec.Enabled = True
            cmbCauseOfDeath.Enabled = True
            cmbCogDecWhen.Enabled = True
            cmbExpNeuroleptics.Enabled = True
            cmbMemInOMH.Enabled = True
        Else
            cmbSex.Enabled = False
            cmbRace.Enabled = False
            cmbCertainty.Enabled = False
            cmbSignificance.Enabled = False
            cmbDegree.Enabled = False
            cmbLifeSignificance.Enabled = False
            cmbHandedness.Enabled = False
            cmbTemporalPattern.Enabled = False
            cmbProminence.Enabled = False
            cmbTypeCogDec.Enabled = False
            cmbCauseOfDeath.Enabled = False
            cmbCogDecWhen.Enabled = False
            cmbMaritalStatus.Enabled = False
            cmbExpNeuroleptics.Enabled = False
            cmbMemInOMH.Enabled = False
        End If


    End Sub
    Private Sub btnDEAD4_Click(sender As Object, e As EventArgs) Handles btnDEAD4Top.Click, btnDEAD4Bottom.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_PMCR_Dead4", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                btnDEAD4Bottom.Text = "Save Changes"
                btnDEAD4Top.Text = btnDEAD4Bottom.Text
                enableInputFields(True)
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If User.PermissionCheck("WA_PMCR_Dead4", "Modify") Then
                loadBaseForm()
                setDefaultValues()
                lblNoRecord.Visible = False
                btnDEAD4Bottom.Text = "Save New Record"
                btnDEAD4Top.Text = "Save New Record"
                enableInputFields(True)
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
            End If
        Else 'By default, user is attempting to Insert or Edit a record. Run preSaveValidation.
            If preSaveValidation() Then 'If preSaveValidation returns true, take Insert or Update actions.
                'Same parameters for Insert or Update SP's, so define here
                Dim parameters = " @SubNum = " & WarehouseShell.SubNum &
                    ", @Certainty = " & cmbCertainty.getSQLValue() &
                    ", @Significance = " & cmbSignificance.getSQLValue() &
                    ", @TemporalPattern = " & cmbTemporalPattern.getSQLValue() &
                    ", @Prominence = " & cmbProminence.getSQLValue() &
                    ", @TypeCogDecline = " & cmbTypeCogDec.getSQLValue() &
                    ", @CauseOfDeath = " & cmbCauseOfDeath.getSQLValue() &
                    ", @Degree = " & cmbDegree.getSQLValue() &
                    ", @LifetimeSignificance = " & cmbLifeSignificance.getSQLValue() &
                    ", @CogDeclineWhen = " & cmbCogDecWhen.getSQLValue() &
                    ", @MemInOMH = " & cmbMemInOMH.getSQLValue() &
                    ", @ExposureToNL = " & cmbExpNeuroleptics.getSQLValue() &
                    ", @LastModBy = '" & WarehouseShell.userName & "';"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    Dim cmd As New SqlCommand("Exec modPMCR_DEAD4Record @Action = 1, " & parameters, WarehouseShell.conn)
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Save successful", MsgBoxStyle.OkOnly)
                        enableInputFields(False)
                        btnDEAD4Bottom.Text = "Edit Record"
                        btnDEAD4Top.Text = "Edit Record"
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else 'If this clause is invoked, datamode must be Edit
                    Dim cmd As New SqlCommand("Exec modPMCR_DEAD4Record @Action = 2, " & parameters, WarehouseShell.conn)
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Save successful", MsgBoxStyle.OkOnly)
                        enableInputFields(False)
                        btnDEAD4Bottom.Text = "Edit Record"
                        btnDEAD4Top.Text = "Edit Record"
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