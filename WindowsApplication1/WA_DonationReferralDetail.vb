Public Class WA_DonationReferralDetail
    Implements IFormMethods
    Private formTables As New DataSet

    Private Sub WA_DonationReferralTracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_DonationReferralTracker")
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        loadBaseForm()
        loadDefaultValues()
        If Not IsNothing(WarehouseShell.RecordID) Then
            loadExistingData()
            enableInputFields(False)
            btnSave.Text = "Edit Record"
        Else
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
            enableInputFields(True)
            btnSave.Text = "Save Record"
        End If
        ShowPHI(WarehouseShell.ShowingPHI)
    End Sub
    Private Sub loadBaseForm()
        formTables.Tables.Add(Database.ReturnTable("refUser", "RaterID, Name", "DonationCoordinator = 1", "Name"))
        cmbReceivedBy.DataSource = New DataView(formTables.Tables("refUser"), "", "", DataViewRowState.CurrentRows)
        cmbReceivedBy.ValueMember = "RaterID"
        cmbReceivedBy.DisplayMember = "Name"
        formTables.Tables.Add(Database.ReturnTable("refInstitution", "InstitutionID, Name",, "Name"))
        cmbPlaceOfDeath.DataSource = New DataView(formTables.Tables("refInstitution"), "", "", DataViewRowState.CurrentRows)
        cmbPlaceOfDeath.ValueMember = "InstitutionID"
        cmbPlaceOfDeath.DisplayMember = "Name"
        formTables.Tables.Add(Database.ReturnTable("lkpDonationReferralSources",,, "Value"))
        formTables.Tables.Add(Database.ReturnTable("lkpRelation"))
        formTables.Tables.Add(Database.ReturnTable("lkpYN12"))
        formTables.Tables.Add(Database.ReturnTable("lkpDonationRuleOutCriteria",,, "Value"))
        formTables.Tables.Add(Database.ReturnTable("lkpDonationConsented",,, "Value"))
        formTables.Tables.Add(Database.ReturnTable("lkpDonationTransporter",,, "Value"))
        assignComboLookups(cmbReferralSource, "lkpDonationReferralSources")
        assignComboLookups(cmbRuledOut, "lkpYN12")
        assignComboLookups(cmbRuleOutCriteria, "lkpDonationRuleOutCriteria")
        assignComboLookups(cmbApproached, "lkpYN12")
        assignComboLookups(cmbRelation, "lkpRelation")
        assignComboLookups(cmbConsented, "lkpDonationConsented")
        assignComboLookups(cmbTransporter, "lkpDonationTransporter")
        loadDefaultValues()
    End Sub
    Private Sub assignComboLookups(ByVal ComboName As ComboBox, ByVal tableName As String)
        ComboName.DataSource = New DataView(formTables.Tables(tableName))
        ComboName.DisplayMember = "Label"
        ComboName.ValueMember = "Value"
    End Sub
    Private Sub loadDefaultValues()
        cmbReceivedBy.SelectedValue = -1
        dtReferralDate.Text = Format(Now(), "MMddyyyy")
        cmbReferralSource.SelectedValue = -1
        cmbPlaceOfDeath.SelectedValue = -1
        cmbRuledOut.SelectedValue = -1
        cmbRuleOutCriteria.SelectedValue = -1
        cmbApproached.SelectedValue = -1
        cmbRelation.SelectedValue = -1
        cmbConsented.SelectedValue = -1
        cmbTransporter.SelectedValue = -1
    End Sub
    Private Sub loadExistingData()
        If formTables.Tables.Contains("viewDonationReferralTracker") Then
            formTables.Tables.Remove("viewDonationReferralTracker")
        End If

        formTables.Tables.Add(Database.ReturnTable("viewDonationReferralTracker", , "RecordID = " & WarehouseShell.RecordID))
        cmbReceivedBy.setValue(formTables, "viewDonationReferralTracker", "ReceivedByValue")
        txtFirstName.setValue(formTables, "viewDonationReferralTracker", "FirstName")
        txtLastName.setValue(formTables, "viewDonationReferralTracker", "LastName")
        dtReferralDate.setValue(formTables, "viewDonationReferralTracker", "ReferralDate")
        tmReferralTime.setValue(formTables, "viewDonationReferralTracker", "ReferralTime")
        cmbReferralSource.setValue(formTables, "viewDonationReferralTracker", "ReferralSourceValue")
        txtReferralID.setValue(formTables, "viewDonationReferralTracker", "ReferralID")
        cmbPlaceOfDeath.setValue(formTables, "viewDonationReferralTracker", "PlaceOfDeathValue")
        txtPlaceOfDeathSpec.setValue(formTables, "viewDonationReferralTracker", "PlaceOfDeathNote")
        cmbRuledOut.setValue(formTables, "viewDonationReferralTracker", "RuledOutValue")
        cmbRuleOutCriteria.setValue(formTables, "viewDonationReferralTracker", "RuleOutCritValue")
        txtRuleOutCriteriaSpec.setValue(formTables, "viewDonationReferralTracker", "RuleOutCritNote")
        cmbApproached.setValue(formTables, "viewDonationReferralTracker", "ApproachedValue")
        txtNoKName.setValue(formTables, "viewDonationReferralTracker", "NoKName")
        cmbRelation.setValue(formTables, "viewDonationReferralTracker", "NoKRelationValue")
        cmbConsented.setValue(formTables, "viewDonationReferralTracker", "ConsentedValue")
        txtConsentedSpec.setValue(formTables, "viewDonationReferralTracker", "ConsentedNote")
        cmbTransporter.setValue(formTables, "viewDonationReferralTracker", "TransporterValue")
        txtTransporterPOCName.setValue(formTables, "viewDonationReferralTracker", "TransporterPOCName")
        txtTransporterPOCPhone.setValue(formTables, "viewDonationReferralTracker", "TransporterPOCPhone")
        txtFinalDestination.setValue(formTables, "viewDonationReferralTracker", "FinalDestination")
        txtFinalDestinationPOCName.setValue(formTables, "viewDonationReferralTracker", "FinalDestinationPOCName")
        txtFinalDestinationPOCPhone.setValue(formTables, "viewDonationReferralTracker", "FinalDestinationPOCPhone")
        txtNotes.setValue(formTables, "viewDonationReferralTracker", "Notes")
    End Sub
    Private Sub enableInputFields(ByVal value As Boolean)
        If value = True Then
            cmbReceivedBy.Enabled = True
            txtFirstName.Enabled = True
            txtLastName.Enabled = True
            dtReferralDate.Enabled = True
            tmReferralTime.Enabled = True
            cmbReferralSource.Enabled = True
            If cmbReferralSource.SelectedValue = 888 Then
                txtReferralSourceSpec.Enabled = True
            Else
                txtReferralSourceSpec.Enabled = False
            End If
            txtReferralID.Enabled = True
            cmbPlaceOfDeath.Enabled = True
            If cmbPlaceOfDeath.SelectedValue = 888 Then
                txtPlaceOfDeathSpec.Enabled = True
            Else
                txtPlaceOfDeathSpec.Enabled = False
            End If
            cmbRuledOut.Enabled = True
            If cmbRuledOut.SelectedValue <> 2 Then
                cmbApproached.Enabled = False
                txtNoKName.Enabled = False
                cmbRelation.Enabled = False
                cmbConsented.Enabled = False
                txtConsentedSpec.Enabled = False
                cmbTransporter.Enabled = False
                txtTransporterPOCName.Enabled = False
                txtTransporterPOCPhone.Enabled = False
                txtFinalDestination.Enabled = False
                txtFinalDestinationPOCName.Enabled = False
                txtFinalDestinationPOCPhone.Enabled = False
                If cmbRuledOut.SelectedValue = 1 Then
                    cmbRuleOutCriteria.Enabled = True
                    If cmbRuleOutCriteria.SelectedValue = 888 Then
                        txtRuleOutCriteriaSpec.Enabled = True
                    Else
                        txtRuleOutCriteriaSpec.Enabled = False
                    End If
                End If
            Else
                cmbRuleOutCriteria.Enabled = False
                cmbApproached.Enabled = True
                If cmbApproached.SelectedValue <> 2 Then
                    txtNoKName.Enabled = True
                    cmbRelation.Enabled = True
                    cmbConsented.Enabled = True
                End If
                If cmbConsented.SelectedValue = 888 Then
                    txtConsentedSpec.Enabled = True
                ElseIf cmbConsented.SelectedValue = 1 Then
                    cmbTransporter.Enabled = True
                    txtFinalDestination.Enabled = True
                    txtFinalDestinationPOCName.Enabled = True
                    txtFinalDestinationPOCPhone.Enabled = True
                    If cmbTransporter.SelectedValue <> -1 Then
                        txtTransporterPOCName.Enabled = True
                        txtTransporterPOCPhone.Enabled = True
                    End If
                End If
            End If
            txtNotes.makeReadOnly(False)
        Else
            cmbReceivedBy.Enabled = False
            txtFirstName.Enabled = False
            txtLastName.Enabled = False
            dtReferralDate.Enabled = False
            tmReferralTime.Enabled = False
            cmbReferralSource.Enabled = False
            txtReferralSourceSpec.Enabled = False
            txtReferralID.Enabled = False
            cmbPlaceOfDeath.Enabled = False
            txtPlaceOfDeathSpec.Enabled = False
            cmbRuledOut.Enabled = False
            cmbRuleOutCriteria.Enabled = False
            txtRuleOutCriteriaSpec.Enabled = False
            cmbApproached.Enabled = False
            txtNoKName.Enabled = False
            cmbRelation.Enabled = False
            cmbConsented.Enabled = False
            txtConsentedSpec.Enabled = False
            cmbTransporter.Enabled = False
            txtTransporterPOCName.Enabled = False
            txtTransporterPOCPhone.Enabled = False
            txtFinalDestination.Enabled = False
            txtFinalDestinationPOCName.Enabled = False
            txtFinalDestinationPOCPhone.Enabled = False
            txtNotes.makeReadOnly(True)
        End If
    End Sub

    Private Function preSaveValidation() As Boolean
        Dim result As Boolean = True
        Dim errMsg As String = "The following errors must be corrected before this record can be saved:" & vbNewLine & vbNewLine

        If cmbReceivedBy.SelectedValue = -1 Then
            result = False
            errMsg += "- Please select a name in ""Received By""." & vbNewLine
        End If
        If cmbReferralSource.SelectedValue = 888 And txtReferralSourceSpec.Text = "" Then
            result = False
            errMsg += "- You have selected ""Other"" as the Referral Source, but have not specified what other is." & vbNewLine
        End If
        If cmbPlaceOfDeath.SelectedValue = 103 And txtPlaceOfDeathSpec.Text = "" Then
            result = False
            errMsg += "- You have selected ""Other"" as the Place of Death, but have not specified what other is." & vbNewLine
        End If
        If cmbRuledOut.SelectedValue = 1 And cmbRuleOutCriteria.SelectedValue = -1 Then
            result = False
            errMsg += "- You have selected ""Yes"" for ""Ruled Out"". Please select a value in ""Rule Out Criteria""." & vbNewLine
        End If
        If cmbRuleOutCriteria.SelectedValue = 888 And txtRuleOutCriteriaSpec.Text = "" Then
            result = False
            errMsg += "- You have selected ""Other"" as the Rule Out Criteria, but have not specified what other is." & vbNewLine
        End If
        If cmbApproached.SelectedValue = 1 And txtNoKName.Text = "" Then
            result = False
            errMsg += "- You have selected ""Yes"" for Approached, but have not specified NoK Name." & vbNewLine
        End If
        If cmbConsented.SelectedValue = 888 And txtConsentedSpec.Text = "" Then
            result = False
            errMsg += "- You have selected ""Other"" for Consented, but have not specified what other is." & vbNewLine
        End If
        If cmbConsented.SelectedValue = 1 Then
            If txtFirstName.Text = "" Or txtLastName.Text = "" Then
                result = False
                errMsg += "- First Name and/or Last Name cannot be left blank for consented referrals." & vbNewLine
            End If
            If txtNoKName.Text = "" Then
                result = False
                errMsg += "- NoK name cannot be left blank for consented referrals." & vbNewLine
            End If
            If cmbRelation.SelectedValue = -1 Then
                result = False
                errMsg += "- NoK relation must be selected for consented referrals." & vbNewLine
            End If
        End If
        If cmbReferralSource.SelectedValue = 1 And Not (txtReferralID.Text Like "2016-######" Or txtReferralID.Text Like "2017-######" Or txtReferralID.Text Like "2018-######" Or txtReferralID.Text Like "2019-######" Or txtReferralID.Text Like "202#-######" Or txtReferralID.Text Like "########-*") Then
            result = False
            errMsg += "- Referral ID is not a valid LiveOnNY ID, or was left blank."
        End If

        If result = False Then
            MsgBox(errMsg, MsgBoxStyle.OkOnly)
        End If
        Return result
    End Function
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_DonationReferrals", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                enableInputFields(True)
                btnSave.Text = "Save Changes"
            End If
        Else
            If preSaveValidation() Then
                Dim sqlCommand As New SqlCommand
                sqlCommand.Connection = WarehouseShell.conn
                Dim cmdString = "@RecordID = " & IIf(IsNothing(WarehouseShell.RecordID), "NULL", WarehouseShell.RecordID) &
                    ", @ReceivedBy = " & cmbReceivedBy.getSQLValue() &
                    ", @FirstName = " & IIf(cmbRuledOut.SelectedValue = 1 Or cmbApproached.SelectedValue = 2 Or (cmbConsented.SelectedValue <> 1 And cmbConsented.SelectedValue <> 8 And cmbConsented.SelectedValue <> -1), "'Not Consented'", txtFirstName.getSQLValue()) &
                    ", @LastName = " & IIf(cmbRuledOut.SelectedValue = 1 Or cmbApproached.SelectedValue = 2 Or (cmbConsented.SelectedValue <> 1 And cmbConsented.SelectedValue <> 8 And cmbConsented.SelectedValue <> -1), "'Not Consented'", txtLastName.getSQLValue()) &
                    ", @ReferralDate = " & dtReferralDate.getSQLValue() &
                    ", @ReferralTime = " & tmReferralTime.getSQLValue() &
                    ", @ReferralSource = " & cmbReferralSource.getSQLValue() &
                    ", @ReferralID = " & txtReferralID.getSQLValue() &
                    ", @PlaceOfDeath = " & cmbPlaceOfDeath.getSQLValue() &
                    ", @PlaceOfDeathNote = " & txtPlaceOfDeathSpec.getSQLValue() &
                    ", @RuledOut = " & cmbRuledOut.getSQLValue() &
                    ", @RuleOutCrit = " & cmbRuleOutCriteria.getSQLValue() &
                    ", @RuleOutCritNote = " & txtRuleOutCriteriaSpec.getSQLValue() &
                    ", @Approached = " & cmbApproached.getSQLValue() &
                    ", @NoKName = " & IIf(cmbRuledOut.SelectedValue = 1 Or cmbApproached.SelectedValue = 2 Or (cmbConsented.SelectedValue <> 1 And cmbConsented.SelectedValue <> 8 And cmbConsented.SelectedValue <> -1), "'Not Consented'", txtNoKName.getSQLValue()) &
                    ", @NoKRelation = " & cmbRelation.getSQLValue() &
                    ", @Consented = " & cmbConsented.getSQLValue() &
                    ", @ConsentedNote = " & txtConsentedSpec.getSQLValue() &
                    ", @Transporter = " & cmbTransporter.getSQLValue() &
                    ", @TransporterPOCName = " & txtTransporterPOCName.getSQLValue() &
                    ", @TransporterPOCPhone = " & txtTransporterPOCPhone.getSQLValue() &
                    ", @FinalDestination = " & txtFinalDestination.getSQLValue() &
                    ", @FinalDestinationPOCName = " & txtFinalDestinationPOCName.getSQLValue() &
                    ", @FinalDestinationPOCPhone = " & txtFinalDestinationPOCPhone.getSQLValue() &
                    ", @Notes = " & txtNotes.getSQLValue() & ";"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    sqlCommand.CommandText = "EXEC dbo.modDonationReferralTrackerRecord @Action = 1, " & cmdString
                    Try
                        sqlCommand.ExecuteNonQuery()
                        MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        enableInputFields(False)
                        btnSave.Text = "Edit this record"
                        sqlCommand.CommandText = "select max(RecordID) from DonationReferralTracker;"
                        WarehouseShell.RecordID = sqlCommand.ExecuteScalar().ToString()
                        loadExistingData()
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else
                    sqlCommand.CommandText = "EXEC dbo.modDonationReferralTrackerRecord @Action = 2, " & cmdString
                    Try
                        sqlCommand.ExecuteNonQuery()
                        MessageBox.Show("Record successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        enableInputFields(False)
                        btnSave.Text = "Edit this record"
                        loadExistingData()
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                End If
            End If

            CreateNewSubject()
        End If
    End Sub

    Private Sub CreateNewSubject()
        If cmbConsented.SelectedValue = 1 Or cmbConsented.SelectedValue = 8 Then
            Dim value As DialogResult = MsgBox("Would you like to create a subject record for this donor?", MsgBoxStyle.YesNo, "Create New Subject?")
            If value = Windows.Forms.DialogResult.Yes Then
                Dim cmd As New SqlCommand("Select max(RecordID) from DonationReferralTracker", WarehouseShell.conn)
                WarehouseShell.RecordID = cmd.ExecuteScalar()
                WarehouseShell.Num1 = WarehouseShell.RecordID
                WarehouseShell.LoadHeaderForm(New Head_SubjectSelect)
                WarehouseShell.SubNum = Nothing
                DirectCast(WarehouseShell.HeaderForm, Head_SubjectSelect).enableInputFields(False)
                WarehouseShell.LoadWorkingAreaForm(WarehouseShell.formType.WA_Demographics)
            End If
        End If
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        If User.PermissionCheck("WA_DonationReferrals", "Modify") Then
            WarehouseShell.RecordID = Nothing
            WarehouseShell.LoadWorkingAreaForm(WarehouseShell.formType.WA_DonationReferralTracker)
        End If
    End Sub

    Private Sub cmbReferralSource_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbReferralSource.SelectedValueChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
            If cmbReferralSource.SelectedValue = 888 Then
                txtReferralSourceSpec.Enabled = True
            Else
                txtReferralSourceSpec.Enabled = False
                txtReferralSourceSpec.Clear()
            End If
        End If
    End Sub
    Private Sub cmbPlaceOfDeath_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbPlaceOfDeath.SelectedValueChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
            If cmbPlaceOfDeath.SelectedValue = 103 Then
                txtPlaceOfDeathSpec.Enabled = True
            Else
                txtPlaceOfDeathSpec.Enabled = False
                txtPlaceOfDeathSpec.Clear()
            End If
        End If
    End Sub
    Private Sub cmbRuledOut_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbRuledOut.SelectedValueChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
            If cmbRuledOut.SelectedValue = 1 Then
                cmbRuleOutCriteria.Enabled = True
                cmbApproached.Enabled = False
                cmbApproached.SelectedValue = -1
                cmbConsented.Enabled = False
                cmbConsented.SelectedValue = 7
                cmbTransporter.Enabled = False
                cmbTransporter.SelectedValue = -1
                txtFinalDestination.Enabled = False
                txtFinalDestination.Clear()
                txtFinalDestinationPOCName.Enabled = False
                txtFinalDestinationPOCName.Clear()
                txtFinalDestinationPOCPhone.Enabled = False
                txtFinalDestinationPOCPhone.Clear()
            Else
                cmbRuleOutCriteria.Enabled = False
                cmbRuleOutCriteria.SelectedValue = -1
                cmbApproached.Enabled = True
                txtNoKName.Enabled = True
                cmbRelation.Enabled = True
                cmbConsented.SelectedValue = -1
            End If
        End If
    End Sub
    Private Sub cmbRuleOutCriteria_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbRuleOutCriteria.SelectedValueChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
            If cmbRuleOutCriteria.SelectedValue = 888 Then
                txtRuleOutCriteriaSpec.Enabled = True
            Else
                txtRuleOutCriteriaSpec.Enabled = False
                txtRuleOutCriteriaSpec.Clear()
            End If
        End If
    End Sub
    Private Sub cmbApproached_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbApproached.SelectedValueChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
            If cmbApproached.SelectedValue = 1 Then
                txtNoKName.Enabled = True
                cmbRelation.Enabled = True
                cmbConsented.Enabled = True
            Else
                txtNoKName.Enabled = False
                txtNoKName.Clear()
                cmbRelation.Enabled = False
                cmbRelation.SelectedValue = -1
                cmbConsented.Enabled = False
                If cmbApproached.SelectedValue = 2 Then
                    cmbConsented.SelectedValue = 888
                End If
            End If
        End If
    End Sub
    Private Sub cmbConsented_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbConsented.SelectedValueChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
            If cmbConsented.SelectedValue = 1 Then
                cmbTransporter.Enabled = True
                txtFinalDestination.Enabled = True
                txtFinalDestinationPOCName.Enabled = True
                txtFinalDestinationPOCPhone.Enabled = True
            Else
                cmbTransporter.Enabled = False
                cmbTransporter.SelectedValue = -1
                txtFinalDestination.Enabled = False
                txtFinalDestination.Clear()
                txtFinalDestinationPOCName.Enabled = False
                txtFinalDestinationPOCName.Clear()
                txtFinalDestinationPOCPhone.Enabled = False
                txtFinalDestinationPOCPhone.Clear()
                If cmbConsented.SelectedValue = 888 Then
                    txtConsentedSpec.Enabled = True
                Else
                    txtConsentedSpec.Enabled = False
                    txtConsentedSpec.Clear()
                End If
            End If
        End If
    End Sub
    Private Sub cmbTransporter_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbTransporter.SelectedValueChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
            If cmbTransporter.SelectedValue <> -1 Then
                txtTransporterPOCName.Enabled = True
                txtTransporterPOCPhone.Enabled = True
            Else
                txtTransporterPOCName.Enabled = False
                txtTransporterPOCName.Clear()
                txtTransporterPOCPhone.Enabled = False
                txtTransporterPOCPhone.Clear()
            End If
        End If
    End Sub

    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        btnSave.PerformClick()
    End Sub
    Public Sub ShowPHI(val As Boolean) Implements IFormMethods.ShowPHI
        If val = True Then
            txtFirstName.PasswordChar = ""
            txtLastName.PasswordChar = ""
            txtNoKName.PasswordChar = ""
        Else
            txtFirstName.PasswordChar = "*"
            txtLastName.PasswordChar = "*"
            txtNoKName.PasswordChar = "*"
        End If
    End Sub
    Private Sub IFormMethods_Parent(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Private Sub IFormMethods_Show() Implements IFormMethods.Show
        Show()
    End Sub
    Private Sub IFormMethods_TopLevel(val As Boolean) Implements IFormMethods.TopLevel
        TopLevel = val
    End Sub
End Class