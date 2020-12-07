Public Class WA_NPSummary
    Implements IFormMethods
    Private formTables As New DataSet
    Private PU As PU_ExistingDxSelect

    'Load form subs
    Private Sub WA_NPSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_NPSummary")
        If Database.ExistingRecordCheck("NPSummary", "SubNum = " & WarehouseShell.SubNum) = True Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            loadBaseForm()
            loadExistingData()
            btnNPSummaryBottom.Text = "Edit this record"
            btnNPSummaryTop.Text = btnNPSummaryBottom.Text
            enableInputFields(False)
        Else
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            btnNPSummaryBottom.Text = "Add New Record"
            btnNPSummaryTop.Text = btnNPSummaryBottom.Text
            loadFileData()
            enableInputFields(False)
            lblNoRecord.Visible = True
        End If
    End Sub
    Private Sub loadBaseForm()
        'get the CERAD-IJ record for this subject
        formTables.Tables.Add(Database.ReturnTable("CERADIJ", , "SubNUm = " & WarehouseShell.SubNum))
        'Load all required lookup tables into the comboValues DataSet
        formTables.Tables.Add(Database.ReturnTable("lkpNPValues"))
        'Assign lookup values to each individual combobox
        comboNP1.assignLookup(formTables, "lkpNPValues",,,, "Value")
        comboNP2.assignLookup(formTables, "lkpNPValues",,,, "Value")
        comboNP3.assignLookup(formTables, "lkpNPValues",,,, "Value")
        comboNP4.assignLookup(formTables, "lkpNPValues",,,, "Value")
        defaultComboValues()
        If SubjectFiles1to1.CheckFile("fileNeuropathFull", WarehouseShell.SubNum) Then
            btnNPReport.Visible = True
        Else
            btnNPReport.Visible = False
        End If
    End Sub
    Private Sub defaultComboValues()
        comboNP1.SelectedValue = -1
        comboNP2.SelectedValue = -1
        comboNP3.SelectedValue = -1
        comboNP4.SelectedValue = -1
    End Sub
    Private Sub loadExistingData()
        'Grab the record for this subnum
        formTables.Tables.Add(Database.ReturnTable("NPSummary", , "SubNum = " & WarehouseShell.SubNum))
        'Apply the existing values to the input fields
        comboNP1.SelectedValue = formTables.Tables("NPSummary").Rows(0).Item("NP1") 'literal values for combo boxes
        txtNP1DxCodeType.Text = formTables.Tables("NPSummary").Rows(0).Item("NP1DxCodeType").ToString 'string values for text boxes
        txtNP1DxCode.Text = formTables.Tables("NPSummary").Rows(0).Item("NP1DxCode").ToString
        txtNP1.Text = formTables.Tables("NPSummary").Rows(0).Item("NP1Text").ToString
        comboNP2.SelectedValue = formTables.Tables("NPSummary").Rows(0).Item("NP2")
        txtNP2DxCodeType.Text = formTables.Tables("NPSummary").Rows(0).Item("NP2DxCodeType").ToString
        txtNP2DxCode.Text = formTables.Tables("NPSummary").Rows(0).Item("NP2DxCode").ToString
        txtNP2.Text = formTables.Tables("NPSummary").Rows(0).Item("NP2Text").ToString
        comboNP3.SelectedValue = formTables.Tables("NPSummary").Rows(0).Item("NP3")
        txtNP3DxCodeType.Text = formTables.Tables("NPSummary").Rows(0).Item("NP3DxCodeType").ToString
        txtNP3DxCode.Text = formTables.Tables("NPSummary").Rows(0).Item("NP3DxCode").ToString
        txtNP3.Text = formTables.Tables("NPSummary").Rows(0).Item("NP3Text").ToString
        comboNP4.SelectedValue = formTables.Tables("NPSummary").Rows(0).Item("NP4")
        txtNP4DxCodeType.Text = formTables.Tables("NPSummary").Rows(0).Item("NP4DxCodeType").ToString
        txtNP4DxCode.Text = formTables.Tables("NPSummary").Rows(0).Item("NP4DxCode").ToString
        txtNP4.Text = formTables.Tables("NPSummary").Rows(0).Item("NP4Text").ToString
        txtHarryNP1.setValue(formTables, "NPSummary", "HarryNP1")
        txtHarryText.setValue(formTables, "NPSummary", "HarryText")
        NewNP1.setValue(formTables, "NPSummary", "NewNP1")
        If formTables.Tables("NPSummary").Rows(0).Item("CVD").ToString = "True" Then
            chkCVD.Checked = True
        End If
        txtFinalNPDx.Text = formTables.Tables("NPSummary").Rows(0).Item("FinalNPDx").ToString
    End Sub
    Private Sub loadFileData()
        If SubjectFiles1to1.CheckFile("fileNeuropathFull", WarehouseShell.SubNum) Then
            btnNPReport.Text = "View NP Report"
            btnNPReport.BackColor = Color.Chartreuse
            btnNPReport.Enabled = True
        Else
            btnNPReport.Text = "View NP Report"
            btnNPReport.BackColor = Color.Linen
            btnNPReport.Enabled = False
        End If
    End Sub

    'Subs to enable-disable fields during data input based on conditional logic.
    Private Sub enableInputFields(ByVal bool As Boolean)
        If bool = True Then
            comboNP1.Enabled = True
            If comboNP1.SelectedValue Like "2#" Or comboNP1.SelectedValue Like "3#" Or comboNP1.SelectedValue Like "2#?" Or comboNP1.SelectedValue Like "3#?" Then
                btnNP1.Enabled = True
            Else
                btnNP1.Enabled = False
            End If
            comboNP2.Enabled = True
            If comboNP2.SelectedValue Like "2#" Or comboNP2.SelectedValue Like "3#" Or comboNP2.SelectedValue Like "2#?" Or comboNP2.SelectedValue Like "3#?" Then
                btnNP2.Enabled = True
            Else
                btnNP2.Enabled = False
            End If
            comboNP3.Enabled = True
            If comboNP3.SelectedValue Like "2#" Or comboNP3.SelectedValue Like "3#" Or comboNP3.SelectedValue Like "2#?" Or comboNP3.SelectedValue Like "3#?" Then
                btnNP3.Enabled = True
            Else
                btnNP3.Enabled = False
            End If
            comboNP4.Enabled = True
            If comboNP4.SelectedValue Like "2#" Or comboNP4.SelectedValue Like "3#" Or comboNP4.SelectedValue Like "2#?" Or comboNP4.SelectedValue Like "3#?" Then
                btnNP4.Enabled = True
            Else
                btnNP4.Enabled = False
            End If
            chkCVD.Enabled = True
            txtFinalNPDx.makeReadOnly(False)
            If WarehouseShell.userName = "harouv01" Or WarehouseShell.userName = "arnesj01" Then
                txtHarryNP1.Enabled = True
            Else
                txtHarryNP1.Enabled = False
            End If
            If WarehouseShell.userName = "harouv01" Or WarehouseShell.userName = "arnesj01" Then
                txtHarryText.makeReadOnly(False)
            Else
                txtHarryText.makeReadOnly(True)
            End If
        Else
            comboNP1.Enabled = False
            comboNP2.Enabled = False
            comboNP3.Enabled = False
            comboNP4.Enabled = False
            btnNP1.Enabled = False
            btnNP2.Enabled = False
            btnNP3.Enabled = False
            btnNP4.Enabled = False
            chkCVD.Enabled = False
            txtFinalNPDx.makeReadOnly(True)
            txtHarryNP1.Enabled = False
            txtHarryText.makeReadOnly(True)
        End If
        loadFileData()
        txtNP1.makeReadOnly(True)
        txtNP2.makeReadOnly(True)
        txtNP3.makeReadOnly(True)
        txtNP4.makeReadOnly(True)
        NewNP1.makeReadOnly(Not bool)
        NewNP1Text.Enabled = False
    End Sub
    Private Sub comboNP1_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboNP1.SelectedValueChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.Undefined And WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
            If comboNP1.SelectedValue = "-1" Then
                'Clear the associated text boxes.
                txtNP1DxCodeType.Clear()
                txtNP1DxCode.Clear()
                txtNP1.Clear()
                btnNP2.Enabled = False
            ElseIf comboNP1.SelectedValue Like "2#" Or comboNP1.SelectedValue Like "3#" Or comboNP1.SelectedValue Like "2#?" Or comboNP1.SelectedValue Like "3#?" Then
                'Enable the button to add a Dx value.
                PU = New PU_ExistingDxSelect
                PU.ShowDialog()
                If PU.DxSelected Then
                    txtNP1DxCodeType.Text = PU.dgvDx.SelectedRows(0).Cells("Code Type").Value.ToString
                    txtNP1DxCode.Text = PU.dgvDx.SelectedRows(0).Cells("Code").Value.ToString
                    txtNP1.Text = comboNP1.Text & " with " & PU.dgvDx.SelectedRows(0).Cells("Text").Value.ToString
                    btnNP1.Enabled = True
                Else
                    If txtNP1DxCodeType.Text = "" Then 'User may have wanted to change the appended diagnosis then changed mind when they looked at the available diagnoses
                        MsgBox("The selected NP1 value requires an additional diagnosis to be appended. Please append a diagnosis or change the selected NP1 value.", , "Error!")
                    End If
                End If
                PU.Dispose()
            ElseIf comboNP1.SelectedValue Like "#" Or comboNP1.SelectedValue Like "#?" Or comboNP1.SelectedValue Like "1#" Or comboNP1.SelectedValue Like "1#?" Then
                'Populate txtNP1Text with the plain text explanation of the NP1 Code only (no ICD-9 code or text). Clear txtNP1ICD9 (in case user went from a 20 series NP1 to a < 20 NP1).
                txtNP1DxCodeType.Clear()
                txtNP1DxCode.Clear()
                txtNP1.Text = comboNP1.Text
                btnNP1.Enabled = False
            End If
        End If
    End Sub
    Private Sub comboNP2_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboNP2.SelectedValueChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.Undefined And WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
            If comboNP2.SelectedValue = "-1" Then
                'Clear the associated text boxes.
                txtNP2DxCodeType.Clear()
                txtNP2DxCode.Clear()
                txtNP2.Clear()
                btnNP2.Enabled = False
            ElseIf comboNP2.SelectedValue Like "2#" Or comboNP2.SelectedValue Like "3#" Or comboNP2.SelectedValue Like "2#?" Or comboNP2.SelectedValue Like "3#?" Then
                'Enable the button to add a Dx value.
                PU = New PU_ExistingDxSelect
                PU.ShowDialog()
                If PU.DxSelected Then
                    txtNP2DxCodeType.Text = PU.dgvDx.SelectedRows(0).Cells("Code Type").Value.ToString
                    txtNP2DxCode.Text = PU.dgvDx.SelectedRows(0).Cells("Code").Value.ToString
                    txtNP2.Text = comboNP2.Text & " with " & PU.dgvDx.SelectedRows(0).Cells("Text").Value.ToString
                    btnNP2.Enabled = True
                Else
                    If txtNP2DxCodeType.Text = "" Then 'User may have wanted to change the appended diagnosis then changed mind when they looked at the available diagnoses
                        MsgBox("The selected NP2 value requires an additional diagnosis to be appended. Please append a diagnosis or change the selected NP2 value.", , "Error!")
                    End If
                End If
                PU.Dispose()
            ElseIf comboNP2.SelectedValue Like "#" Or comboNP2.SelectedValue Like "#?" Or comboNP2.SelectedValue Like "1#" Or comboNP2.SelectedValue Like "1#?" Then
                'Populate txtNP2Text with the plain text explanation of the NP2 Code only (no ICD-9 code or text). Clear txtNP2ICD9 (in case user went from a 20 series NP2 to a < 20 NP2).
                txtNP2DxCodeType.Clear()
                txtNP2DxCode.Clear()
                txtNP2.Text = comboNP2.Text
                btnNP2.Enabled = False
            End If
        End If
    End Sub
    Private Sub comboNP3_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboNP3.SelectedValueChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.Undefined And WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
            If comboNP3.SelectedValue = "-1" Then
                'Clear the associated text boxes.
                txtNP3DxCodeType.Clear()
                txtNP3DxCode.Clear()
                txtNP3.Clear()
                btnNP3.Enabled = False
            ElseIf comboNP3.SelectedValue Like "2#" Or comboNP3.SelectedValue Like "3#" Or comboNP3.SelectedValue Like "2#?" Or comboNP3.SelectedValue Like "3#?" Then
                'Enable the button to add a Dx value.
                PU = New PU_ExistingDxSelect
                PU.ShowDialog()
                If PU.DxSelected Then
                    txtNP3DxCodeType.Text = PU.dgvDx.SelectedRows(0).Cells("Code Type").Value.ToString
                    txtNP3DxCode.Text = PU.dgvDx.SelectedRows(0).Cells("Code").Value.ToString
                    txtNP3.Text = comboNP3.Text & " with " & PU.dgvDx.SelectedRows(0).Cells("Text").Value.ToString
                    btnNP3.Enabled = True
                Else
                    If txtNP3DxCodeType.Text = "" Then 'User may have wanted to change the appended diagnosis then changed mind when they looked at the available diagnoses
                        MsgBox("The selected NP3 value requires an additional diagnosis to be appended. Please append a diagnosis or change the selected NP3 value.", , "Error!")
                    End If
                End If
                PU.Dispose()
            ElseIf comboNP3.SelectedValue Like "#" Or comboNP3.SelectedValue Like "#?" Or comboNP3.SelectedValue Like "1#" Or comboNP3.SelectedValue Like "1#?" Then
                'Populate txtNP3Text with the plain text explanation of the NP3 Code only (no ICD-9 code or text). Clear txtNP3ICD9 (in case user went from a 20 series NP3 to a < 20 NP3).
                txtNP3DxCodeType.Clear()
                txtNP3DxCode.Clear()
                txtNP3.Text = comboNP3.Text
                btnNP3.Enabled = False
            End If
        End If
    End Sub
    Private Sub comboNP4_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboNP4.SelectedValueChanged
        If WarehouseShell.DataMode <> WarehouseShell.userDataMode.Undefined And WarehouseShell.DataMode <> WarehouseShell.userDataMode.View Then
            If comboNP4.SelectedValue = "-1" Then
                'Clear the associated text boxes.
                txtNP4DxCodeType.Clear()
                txtNP4DxCode.Clear()
                txtNP4.Clear()
                btnNP4.Enabled = False
            ElseIf comboNP4.SelectedValue Like "2#" Or comboNP4.SelectedValue Like "3#" Or comboNP4.SelectedValue Like "2#?" Or comboNP4.SelectedValue Like "3#?" Then
                'Enable the button to add a Dx value.
                PU = New PU_ExistingDxSelect
                PU.ShowDialog()
                If PU.DxSelected Then
                    txtNP4DxCodeType.Text = PU.dgvDx.SelectedRows(0).Cells("Code Type").Value.ToString
                    txtNP4DxCode.Text = PU.dgvDx.SelectedRows(0).Cells("Code").Value.ToString
                    txtNP4.Text = comboNP4.Text & " with " & PU.dgvDx.SelectedRows(0).Cells("Text").Value.ToString
                    btnNP4.Enabled = True
                Else
                    If txtNP4DxCodeType.Text = "" Then 'User may have wanted to change the appended diagnosis then changed mind when they looked at the available diagnoses
                        MsgBox("The selected NP4 value requires an additional diagnosis to be appended. Please append a diagnosis or change the selected NP4 value.", , "Error!")
                    End If
                End If
                PU.Dispose()
            ElseIf comboNP4.SelectedValue Like "#" Or comboNP4.SelectedValue Like "#?" Or comboNP4.SelectedValue Like "1#" Or comboNP4.SelectedValue Like "1#?" Then
                'Populate txtNP4Text with the plain text explanation of the NP4 Code only (no ICD-9 code or text). Clear txtNP4ICD9 (in case user went from a 20 series NP4 to a < 20 NP4).
                txtNP4DxCodeType.Clear()
                txtNP4DxCode.Clear()
                txtNP4.Text = comboNP4.Text
                btnNP4.Enabled = False
            End If
        End If
    End Sub
    Private Sub btnNPSummary_Click(sender As Object, e As EventArgs) Handles btnNPSummaryBottom.Click, btnNPSummaryTop.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_NPSummary", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                enableInputFields(True)
                btnNPSummaryBottom.Text = "Save changes"
                btnNPSummaryTop.Text = btnNPSummaryBottom.Text
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            loadBaseForm()
            defaultComboValues()
            btnNPSummaryBottom.Text = "Save new record"
            btnNPSummaryTop.Text = btnNPSummaryBottom.Text
            lblNoRecord.Visible = False
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
            enableInputFields(True)
        Else
            If User.PermissionCheck("WA_NPSummary", "Modify") Then
                Dim cmd As New SqlCommand
                cmd.Connection = WarehouseShell.conn
                Dim cmdString As String = "@SubNum = " & WarehouseShell.SubNum &
                        ", @NP1 = " & comboNP1.getSQLValue() &
                        ", @NP1DxCodeType = " & txtNP1DxCodeType.getSQLValue() &
                        ", @NP1DxCode = " & txtNP1DxCode.getSQLValue() &
                        ", @NP1Text = " & txtNP1.getSQLValue() &
                        ", @NP2 = " & comboNP2.getSQLValue() &
                        ", @NP2DxCodeType = " & txtNP2DxCodeType.getSQLValue() &
                        ", @NP2DxCode = " & txtNP2DxCode.getSQLValue() &
                        ", @NP2Text = " & txtNP2.getSQLValue() &
                        ", @NP3 = " & comboNP3.getSQLValue() &
                        ", @NP3DxCodeType = " & txtNP3DxCodeType.getSQLValue() &
                        ", @NP3DxCode = " & txtNP3DxCode.getSQLValue() &
                        ", @NP3Text = " & txtNP3.getSQLValue() &
                        ", @NP4 = " & comboNP4.getSQLValue() &
                        ", @NP4DxCodeType = " & txtNP4DxCodeType.getSQLValue() &
                        ", @NP4DxCode = " & txtNP4DxCode.getSQLValue() &
                        ", @NP4Text = " & txtNP4.getSQLValue() &
                        ", @HarryNP1 = " & txtHarryNP1.getSQLValue() &
                        ", @HarryText = " & txtHarryText.getSQLValue() &
                        ", @NewNP1 = " & NewNP1.getSQLValue() &
                        ", @CVD = " & chkCVD.getSQLValue() &
                        ", @FinalNPDx = " & txtFinalNPDx.getSQLValue() & ";"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    If preSaveValidation() Then
                        cmd.CommandText = "Exec dbo.modNPSummaryRecord @Action = 1, " & cmdString
                        Try
                            cmd.ExecuteNonQuery()
                            MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                            enableInputFields(False)
                            btnNPSummaryBottom.Text = "Edit this record"
                            btnNPSummaryTop.Text = btnNPSummaryBottom.Text
                        Catch ex As SqlException
                            ExceptionHandler.CatchSQLException(ex)
                        End Try
                    End If
                Else
                    cmd.CommandText = "Exec dbo.modNPSummaryRecord @Action = 2, " & cmdString
                    If formTables.Tables("NPSummary").Rows(0).Item("Legacy").ToString() = "True" Then
                        Try
                            cmd.ExecuteNonQuery()
                            MessageBox.Show("Changes saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                            enableInputFields(False)
                            btnNPSummaryBottom.Text = "Edit this record"
                            btnNPSummaryTop.Text = btnNPSummaryBottom.Text
                        Catch ex As SqlException
                            ExceptionHandler.CatchSQLException(ex)
                        End Try
                    Else
                        If preSaveValidation() Then
                            Try
                                cmd.ExecuteNonQuery()
                                MessageBox.Show("Changes saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                                WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                                enableInputFields(False)
                                btnNPSummaryBottom.Text = "Edit this record"
                                btnNPSummaryTop.Text = btnNPSummaryBottom.Text
                            Catch ex As SqlException
                                ExceptionHandler.CatchSQLException(ex)
                            End Try
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Function preSaveValidation() As Boolean
        Dim result As Boolean = True
        Dim errMsg As String = "The following errors exist and must be corrected before this record can be saved:" & vbNewLine & vbNewLine
        'Check to make sure that each of the NP & ICD9 value combinations are good and return true, else return false.
        If (comboNP1.SelectedValue Like "2#" Or comboNP1.SelectedValue Like "2#[abcdef]" Or comboNP1.SelectedValue Like "3#" Or comboNP1.SelectedValue Like "3#[abcdef]") And txtNP1DxCode.Text = "" Then
            result = False
            errMsg += "- In NP-1 you selected a code > 20 and have not specified an additional Dx." & vbNewLine
        End If
        If (comboNP1.SelectedValue Like "#" Or comboNP1.SelectedValue Like "#[abcdef]" Or comboNP1.SelectedValue Like "1#" Or comboNP1.SelectedValue Like "1#[abcdef]") And txtNP1DxCode.Text <> "" Then
            result = False
            errMsg += "- In NP-1 you selected a code < 20 and have specified an additional Dx." & vbNewLine
        End If
        If (comboNP2.SelectedValue Like "2#" Or comboNP2.SelectedValue Like "2#[abcdef]" Or comboNP2.SelectedValue Like "3#" Or comboNP2.SelectedValue Like "3#[abcdef]") And txtNP2DxCode.Text = "" Then
            result = False
            errMsg += "- In NP-2 you selected a code > 20 and have not specified an additional Dx." & vbNewLine
        End If
        If (comboNP2.SelectedValue Like "#" Or comboNP2.SelectedValue Like "#[abcdef]" Or comboNP2.SelectedValue Like "1#" Or comboNP2.SelectedValue Like "1#[abcdef]") And txtNP2DxCode.Text <> "" Then
            result = False
            errMsg += "- In NP-2 you selected a code < 20 and have specified an additional Dx." & vbNewLine
        End If
        If (comboNP3.SelectedValue Like "2#" Or comboNP3.SelectedValue Like "2#[abcdef]" Or comboNP3.SelectedValue Like "3#" Or comboNP3.SelectedValue Like "3#[abcdef]") And txtNP3DxCode.Text = "" Then
            result = False
            errMsg += "- In NP-3 you selected a code > 20 and have not specified an additional Dx." & vbNewLine
        End If
        If (comboNP3.SelectedValue Like "#" Or comboNP3.SelectedValue Like "#[abcdef]" Or comboNP3.SelectedValue Like "1#" Or comboNP3.SelectedValue Like "1#[abcdef]") And txtNP3DxCode.Text <> "" Then
            result = False
            errMsg += "- In NP-3 you selected a code < 20 and have specified an additional Dx." & vbNewLine
        End If
        If (comboNP4.SelectedValue Like "2#" Or comboNP4.SelectedValue Like "2#[abcdef]" Or comboNP4.SelectedValue Like "3#" Or comboNP4.SelectedValue Like "3#[abcdef]") And txtNP4DxCode.Text = "" Then
            result = False
            errMsg += "- In NP-4 you selected a code > 20 and have not specified an additional Dx." & vbNewLine
        End If
        If (comboNP4.SelectedValue Like "#" Or comboNP4.SelectedValue Like "#[abcdef]" Or comboNP4.SelectedValue Like "1#" Or comboNP4.SelectedValue Like "1#[abcdef]") And txtNP4DxCode.Text <> "" Then
            result = False
            errMsg += "- In NP-4 you selected a code < 20 and have specified an additional Dx." & vbNewLine
        End If

        If result = False Then
            MsgBox(errMsg, MsgBoxStyle.OkOnly)
        End If
        Return result
    End Function

    'Define button click events
    Private Sub btnNP1_Click(sender As Object, e As EventArgs) Handles btnNP1.Click
        PU = New PU_ExistingDxSelect
        PU.ShowDialog()
        If PU.DxSelected Then
            txtNP1DxCodeType.Text = PU.dgvDx.SelectedRows(0).Cells("Code Type").Value.ToString
            txtNP1DxCode.Text = PU.dgvDx.SelectedRows(0).Cells("Code").Value.ToString
            txtNP1.Text = comboNP1.Text & " with " & PU.dgvDx.SelectedRows(0).Cells("Text").Value.ToString
        Else
            If txtNP1DxCodeType.Text = "" Then 'User may have wanted to change the appended diagnosis then changed mind when they looked at the available diagnoses
                MsgBox("The selected NP1 value requires an additional diagnosis to be appended. Please append a diagnosis or change the selected NP1 value.", , "Error!")
                comboNP1.Focus()
            End If
        End If
        PU.Dispose()
    End Sub
    Private Sub btnNP2_Click(sender As Object, e As EventArgs) Handles btnNP2.Click
        PU = New PU_ExistingDxSelect
        PU.ShowDialog()
        If PU.DxSelected Then
            txtNP2DxCodeType.Text = PU.dgvDx.SelectedRows(0).Cells("Code Type").Value.ToString
            txtNP2DxCode.Text = PU.dgvDx.SelectedRows(0).Cells("Code").Value.ToString
            txtNP2.Text = comboNP2.Text & " with " & PU.dgvDx.SelectedRows(0).Cells("Text").Value.ToString
        Else
            If txtNP2DxCodeType.Text = "" Then 'User may have wanted to change the appended diagnosis then changed mind when they looked at the available diagnoses
                MsgBox("The selected NP2 value requires an additional diagnosis to be appended. Please append a diagnosis or change the selected NP2 value.", , "Error!")
                comboNP2.Focus()
            End If
        End If
        PU.Dispose()
    End Sub
    Private Sub btnNP3_Click(sender As Object, e As EventArgs) Handles btnNP3.Click
        PU = New PU_ExistingDxSelect
        PU.ShowDialog()
        If PU.DxSelected Then
            txtNP3DxCodeType.Text = PU.dgvDx.SelectedRows(0).Cells("Code Type").Value.ToString
            txtNP3DxCode.Text = PU.dgvDx.SelectedRows(0).Cells("Code").Value.ToString
            txtNP3.Text = comboNP3.Text & " with " & PU.dgvDx.SelectedRows(0).Cells("Text").Value.ToString
        Else
            If txtNP3DxCodeType.Text = "" Then 'User may have wanted to change the appended diagnosis then changed mind when they looked at the available diagnoses
                MsgBox("The selected NP3 value requires an additional diagnosis to be appended. Please append a diagnosis or change the selected NP3 value.", , "Error!")
                comboNP3.Focus()
            End If
        End If
        PU.Dispose()
    End Sub
    Private Sub btnNP4_Click(sender As Object, e As EventArgs) Handles btnNP4.Click
        PU = New PU_ExistingDxSelect
        PU.ShowDialog()
        If PU.DxSelected Then
            txtNP4DxCodeType.Text = PU.dgvDx.SelectedRows(0).Cells("Code Type").Value.ToString
            txtNP4DxCode.Text = PU.dgvDx.SelectedRows(0).Cells("Code").Value.ToString
            txtNP4.Text = comboNP4.Text & " with " & PU.dgvDx.SelectedRows(0).Cells("Text").Value.ToString
        Else
            If txtNP4DxCodeType.Text = "" Then 'User may have wanted to change the appended diagnosis then changed mind when they looked at the available diagnoses
                MsgBox("The selected NP4 value requires an additional diagnosis to be appended. Please append a diagnosis or change the selected NP4 value.", , "Error!")
                comboNP4.Focus()
            End If
        End If
        PU.Dispose()
    End Sub
    Private Sub btnNPReport_Click(sender As Object, e As EventArgs) Handles btnNPReport.Click
        If SubjectFiles1to1.CheckFile("fileNeuropathFull", WarehouseShell.SubNum) Then
            SubjectFiles1to1.OpenFile("fileNeuropathFull", WarehouseShell.SubNum, "SubNum " & WarehouseShell.SubNum & " Neuropath Report")
        End If
    End Sub

    'Imported IFormMethods
    Public Sub ShowPHI(showPHI As Boolean) Implements IFormMethods.ShowPHI
    End Sub
    Public Sub Parent1(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Public Sub Show1() Implements IFormMethods.Show
        Show()
    End Sub
    Public Sub TopLevel1(val As Boolean) Implements IFormMethods.TopLevel
        TopLevel = val
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        btnNPSummaryBottom.PerformClick()
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class