Public Class WA_CERADB
    Implements IFormMethods
    Private formTables As New DataSet
    Private tooltip1 As New ToolTip

    'Load form and set data mode
    Private Sub WA_CERADB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_CERADB")
        If Database.ExistingRecordCheck("CERADB", "SubNum = " & WarehouseShell.SubNum) = True Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            enableInputFields(False)
            loadBaseForm()
            loadExistingData()
            btnCERADBBottom.Text = "Edit this record"
            btnCERADBTop.Text = btnCERADBBottom.Text
            btnCERADBTop.Focus()
            lblNoRecord.Visible = False
        Else
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            enableInputFields(False)
            btnCERADBTop.Text = "Add New Record"
            btnCERADBBottom.Text = btnCERADBTop.Text
            lblNoRecord.Visible = True
        End If
    End Sub
    'Grab applicable lookup tables and assign the actual lookup values
    Private Sub loadBaseForm()
        'Load all required lookup tables into the comboValues DataSet
        formTables.Tables.Add(Database.ReturnTable("lkpNYUnk019NoBlanks"))
        'Assign lookup values to each individual combobox
        comboAlzheimersDisease.assignLookup(formTables, "lkpNYUnk019NoBlanks")
        comboOtherDementia.assignLookup(formTables, "lkpNYUnk019NoBlanks")
        comboParkinsonsDisease.assignLookup(formTables, "lkpNYUnk019NoBlanks")
        comboHeartDisease.assignLookup(formTables, "lkpNYUnk019NoBlanks")
        comboHypertension.assignLookup(formTables, "lkpNYUnk019NoBlanks")
        comboStrokeOrDefiniteTIA.assignLookup(formTables, "lkpNYUnk019NoBlanks")
        comboSeizures.assignLookup(formTables, "lkpNYUnk019NoBlanks")
        comboThyroid.assignLookup(formTables, "lkpNYUnk019NoBlanks")
        comboDiabetes.assignLookup(formTables, "lkpNYUnk019NoBlanks")
        comboAlcoholism.assignLookup(formTables, "lkpNYUnk019NoBlanks")
        comboDrugIntoxication.assignLookup(formTables, "lkpNYUnk019NoBlanks")
        comboSevereHeadInjury.assignLookup(formTables, "lkpNYUnk019NoBlanks")
        comboB12Deficiency.assignLookup(formTables, "lkpNYUnk019NoBlanks")
        comboAffectiveDisorder.assignLookup(formTables, "lkpNYUnk019NoBlanks")
        comboOtherPsychiatric.assignLookup(formTables, "lkpNYUnk019NoBlanks")
        comboOtherNeurologic.assignLookup(formTables, "lkpNYUnk019NoBlanks")
        comboWasGeneralAutopsyDone.assignLookup(formTables, "lkpNYUnk019NoBlanks")
    End Sub
    'Sub to set default values for combo boxes.
    Private Sub defaultComboValues()
        comboAlzheimersDisease.SelectedValue = 0
        comboOtherDementia.SelectedValue = 0
        comboParkinsonsDisease.SelectedValue = 0
        comboHeartDisease.SelectedValue = 0
        comboHypertension.SelectedValue = 0
        comboStrokeOrDefiniteTIA.SelectedValue = 0
        comboSeizures.SelectedValue = 0
        comboThyroid.SelectedValue = 0
        comboDiabetes.SelectedValue = 0
        comboAlcoholism.SelectedValue = 0
        comboDrugIntoxication.SelectedValue = 0
        comboSevereHeadInjury.SelectedValue = 0
        comboB12Deficiency.SelectedValue = 0
        comboAffectiveDisorder.SelectedValue = 0
        comboOtherPsychiatric.SelectedValue = 0
        comboOtherNeurologic.SelectedValue = 0
        comboWasGeneralAutopsyDone.SelectedValue = 0
    End Sub
    'Sub to load existing values into form for View/Edit modes
    Private Sub loadExistingData()
        'Grab the CERADB record for this SubNum
        formTables.Tables.Add(Database.ReturnTable("CERADB", , "SubNum = " & WarehouseShell.SubNum))
        'Apply the existing values to the input fields
        comboAlzheimersDisease.setValue(formTables, "CERADB", "Alzheimers")
        comboOtherDementia.setValue(formTables, "CERADB", "OtherDementia")
        txtOtherDementiaNote.setValue(formTables, "CERADB", "OtherDementiaNote")
        comboParkinsonsDisease.setValue(formTables, "CERADB", "Parkinsons")
        comboHeartDisease.setValue(formTables, "CERADB", "HeartDisease")
        txtHeartDisease.setValue(formTables, "CERADB", "HeartDiseaseNote")
        comboHypertension.setValue(formTables, "CERADB", "Hypertension")
        comboStrokeOrDefiniteTIA.setValue(formTables, "CERADB", "StrokeOrTIA")
        comboSeizures.setValue(formTables, "CERADB", "Seizures")
        comboThyroid.setValue(formTables, "CERADB", "Thyroid")
        comboDiabetes.setValue(formTables, "CERADB", "Diabetes")
        comboAlcoholism.setValue(formTables, "CERADB", "Alcoholism")
        comboDrugIntoxication.setValue(formTables, "CERADB", "DrugIntox")
        comboSevereHeadInjury.setValue(formTables, "CERADB", "SevereHeadInjury")
        comboB12Deficiency.setValue(formTables, "CERADB", "B12Deficiency")
        comboAffectiveDisorder.setValue(formTables, "CERADB", "AffectiveDisorder")
        comboOtherPsychiatric.setValue(formTables, "CERADB", "OtherPsychiatric")
        txtOtherPsychiatricDisorder.setValue(formTables, "CERADB", "OtherPsychiatricNote")
        comboOtherNeurologic.setValue(formTables, "CERADB", "OtherNeurologic")
        txtOtherNeurologic.setValue(formTables, "CERADB", "OtherNeurologicNote")
        comboWasGeneralAutopsyDone.setValue(formTables, "CERADB", "GeneralAutopsyDone")
        txtA.Text = formTables.Tables("CERADB").Rows(0).Item("FindingA").ToString
        txtASNOMEDCode.Text = formTables.Tables("CERADB").Rows(0).Item("FindingASNOMED").ToString
        txtB.Text = formTables.Tables("CERADB").Rows(0).Item("FindingB").ToString
        txtBSNOMEDCode.Text = formTables.Tables("CERADB").Rows(0).Item("FindingBSNOMED").ToString
        txtC.Text = formTables.Tables("CERADB").Rows(0).Item("FindingC").ToString
        txtCSNOMEDCode.Text = formTables.Tables("CERADB").Rows(0).Item("FindingCSNOMED").ToString
        txtD.Text = formTables.Tables("CERADB").Rows(0).Item("FindingD").ToString
        txtDSNOMEDCode.Text = formTables.Tables("CERADB").Rows(0).Item("FindingDSNOMED").ToString
        txtE.Text = formTables.Tables("CERADB").Rows(0).Item("FindingE").ToString
        txtESNOMEDCode.Text = formTables.Tables("CERADB").Rows(0).Item("FindingESNOMED").ToString
    End Sub
    'Subs to enable-disable fields during data input based on conditional logic.
    Private Sub enableInputFields(ByVal value As Boolean)
        If value = True Then
            comboAlzheimersDisease.Enabled = True
            comboOtherDementia.Enabled = True
            txtOtherDementiaNote.Enabled = True
            comboParkinsonsDisease.Enabled = True
            comboHeartDisease.Enabled = True
            txtHeartDisease.Enabled = True
            comboHypertension.Enabled = True
            comboStrokeOrDefiniteTIA.Enabled = True
            comboSeizures.Enabled = True
            comboThyroid.Enabled = True
            comboDiabetes.Enabled = True
            comboAlcoholism.Enabled = True
            comboDrugIntoxication.Enabled = True
            comboSevereHeadInjury.Enabled = True
            comboB12Deficiency.Enabled = True
            comboAffectiveDisorder.Enabled = True
            comboOtherPsychiatric.Enabled = True
            txtOtherPsychiatricDisorder.Enabled = True
            comboOtherNeurologic.Enabled = True
            txtOtherNeurologic.Enabled = True
            comboWasGeneralAutopsyDone.Enabled = True
            txtA.Enabled = True
            txtASNOMEDCode.Enabled = True
            txtB.Enabled = True
            txtBSNOMEDCode.Enabled = True
            txtC.Enabled = True
            txtCSNOMEDCode.Enabled = True
            txtD.Enabled = True
            txtDSNOMEDCode.Enabled = True
            txtE.Enabled = True
            txtESNOMEDCode.Enabled = True
        Else
            comboAlzheimersDisease.Enabled = False
            comboOtherDementia.Enabled = False
            txtOtherDementiaNote.Enabled = False
            comboParkinsonsDisease.Enabled = False
            comboHeartDisease.Enabled = False
            txtHeartDisease.Enabled = False
            comboHypertension.Enabled = False
            comboStrokeOrDefiniteTIA.Enabled = False
            comboSeizures.Enabled = False
            comboThyroid.Enabled = False
            comboDiabetes.Enabled = False
            comboAlcoholism.Enabled = False
            comboDrugIntoxication.Enabled = False
            comboSevereHeadInjury.Enabled = False
            comboB12Deficiency.Enabled = False
            comboAffectiveDisorder.Enabled = False
            comboOtherPsychiatric.Enabled = False
            txtOtherPsychiatricDisorder.Enabled = False
            comboOtherNeurologic.Enabled = False
            txtOtherNeurologic.Enabled = False
            comboWasGeneralAutopsyDone.Enabled = False
            txtA.Enabled = False
            txtASNOMEDCode.Enabled = False
            txtB.Enabled = False
            txtBSNOMEDCode.Enabled = False
            txtC.Enabled = False
            txtCSNOMEDCode.Enabled = False
            txtD.Enabled = False
            txtDSNOMEDCode.Enabled = False
            txtE.Enabled = False
            txtESNOMEDCode.Enabled = False
        End If
    End Sub

    'Define button click events
    Private Sub btnCERADB_Click(sender As Object, e As EventArgs) Handles btnCERADBBottom.Click, btnCERADBTop.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_CERADB", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                enableInputFields(True)
                btnCERADBBottom.Text = "Save changes"
                btnCERADBTop.Text = btnCERADBBottom.Text
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If Database.ExistingRecordCheck("CERAD_Header", "SubNum = " & WarehouseShell.SubNum) Then
                If User.PermissionCheck("WA_CERADB", "Modify") Then
                    WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
                    loadBaseForm()
                    defaultComboValues()
                    enableInputFields(True)
                    btnCERADBBottom.Text = "Save new record"
                    btnCERADBTop.Text = btnCERADBBottom.Text
                    lblNoRecord.Visible = False
                End If
            Else
                MsgBox("Please create a CERAD Header for this subject before attempting to add CERAD information.", MsgBoxStyle.OkOnly, "Error!")
            End If
        Else
            If preSaveValidate() = True Then
                Dim sqlCommand As New SqlCommand
                sqlCommand.Connection = WarehouseShell.conn
                Dim cmdString = "@SubNum = " & WarehouseShell.SubNum &
                    ", @Alzheimers = " & comboAlzheimersDisease.getSQLValue() &
                    ", @OtherDementia = " & comboOtherDementia.getSQLValue() &
                    ", @OtherDementiaNote = " & txtOtherDementiaNote.getSQLValue() &
                    ", @Parkinsons = " & comboParkinsonsDisease.getSQLValue() &
                    ", @HeartDisease = " & comboHeartDisease.getSQLValue() &
                    ", @HeartDiseaseNote = " & txtHeartDisease.getSQLValue() &
                    ", @Hypertension = " & comboHypertension.getSQLValue() &
                    ", @StrokeOrTIA = " & comboStrokeOrDefiniteTIA.getSQLValue() &
                    ", @Seizures = " & comboSeizures.getSQLValue() &
                    ", @Thyroid = " & comboThyroid.getSQLValue() &
                    ", @Diabetes = " & comboDiabetes.getSQLValue() &
                    ", @Alcoholism = " & comboAlcoholism.getSQLValue() &
                    ", @DrugIntox = " & comboDrugIntoxication.getSQLValue() &
                    ", @SevereHeadInjury = " & comboSevereHeadInjury.getSQLValue() &
                    ", @B12Deficiency = " & comboB12Deficiency.getSQLValue() &
                    ", @AffectiveDisorder = " & comboAffectiveDisorder.getSQLValue() &
                    ", @OtherPsychiatric = " & comboOtherPsychiatric.getSQLValue() &
                    ", @OtherPsychiatricNote = " & txtOtherPsychiatricDisorder.getSQLValue() &
                    ", @OtherNeurologic = " & comboOtherNeurologic.getSQLValue() &
                    ", @OtherNeurologicNote = " & txtOtherNeurologic.getSQLValue() &
                    ", @GeneralAutopsyDone = " & comboWasGeneralAutopsyDone.getSQLValue() &
                    ", @FindingA = " & txtA.getSQLValue() &
                    ", @FindingASNOMED = " & txtASNOMEDCode.getSQLValue() &
                    ", @FindingB = " & txtB.getSQLValue() &
                    ", @FindingBSNOMED = " & txtBSNOMEDCode.getSQLValue() &
                    ", @FindingC = " & txtC.getSQLValue() &
                    ", @FindingCSNOMED = " & txtCSNOMEDCode.getSQLValue() &
                    ", @FindingD = " & txtD.getSQLValue() &
                    ", @FindingDSNOMED = " & txtDSNOMEDCode.getSQLValue() &
                    ", @FindingE = " & txtE.getSQLValue() &
                    ", @FindingESNOMED = " & txtESNOMEDCode.getSQLValue() &
                    ";"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    sqlCommand.CommandText = "EXEC dbo.modCERADBRecord @Action = 1, " & cmdString
                    Try
                        sqlCommand.ExecuteNonQuery()
                        MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        enableInputFields(False)
                        btnCERADBBottom.Text = "Edit this record"
                        btnCERADBTop.Text = btnCERADBBottom.Text
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else
                    sqlCommand.CommandText = "EXEC dbo.modCERADBRecord @Action = 2, " & cmdString
                    Try
                        sqlCommand.ExecuteNonQuery()
                        MessageBox.Show("Record successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        enableInputFields(False)
                        btnCERADBBottom.Text = "Edit this record"
                        btnCERADBTop.Text = btnCERADBBottom.Text
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                End If
            End If
        End If
    End Sub
    Private Function preSaveValidate() As Boolean
        Dim result As Boolean = True
        Dim errorMessage As String = ""

        'Validate comboOtherDementia
        If comboOtherDementia.SelectedValue <> 1 And txtOtherDementiaNote.Text <> "" Then
            result = False
            errorMessage += "- You have entered an Other Dementia note without selecting ""Yes"" for Other Dementia. Please clear the note or select ""Yes"" in the dropdown box." & vbNewLine
        End If
        If comboOtherDementia.SelectedValue = 1 And txtOtherDementiaNote.Text = "" Then
            result = False
            errorMessage += "- You have selected ""Yes"" for Other Dementia without specifying a note. Please add a note or change the value in the Other Dementia dropdown box." & vbNewLine
        End If

        'Validate comboHeartDisease
        If comboHeartDisease.SelectedValue <> 1 And txtHeartDisease.Text <> "" Then
            result = False
            errorMessage += "- You have entered a Heart Disease note without selecting ""Yes"" for Heart Disease. Please clear the note or select ""Yes"" in the dropdown box." & vbNewLine
        End If
        If comboHeartDisease.SelectedValue = 1 And txtHeartDisease.Text = "" Then
            result = False
            errorMessage += "- You have selected ""Yes"" for Heart Disease without specifying a note. Please add a note or change the value in the Heart Disease dropdown box." & vbNewLine
        End If

        'Validate comboOtherPsychiatric
        If comboOtherPsychiatric.SelectedValue <> 1 And txtOtherPsychiatricDisorder.Text <> "" Then
            result = False
            errorMessage += "- You have entered an Other Psychiatric Disorder note without selecting ""Yes"" for Other Psychiatric Disorder. Please clear the note or select ""Yes"" in the dropdown box." & vbNewLine
        End If
        If comboOtherPsychiatric.SelectedValue = 1 And txtOtherPsychiatricDisorder.Text = "" Then
            result = False
            errorMessage += "- You have selected ""Yes"" for Other Psychiatric Disorder without specifying a note. Please add a note or change the value in the Other Psychiatric Disorder dropdown box." & vbNewLine
        End If

        'Validate comboOtherNeurologic
        If comboOtherNeurologic.SelectedValue <> 1 And txtOtherNeurologic.Text <> "" Then
            result = False
            errorMessage += "- You have entered an Other Neurologic Diagnoses note without selecting ""Yes"" for Other Neurologic Diagnoses. Please clear the note or select ""Yes"" in the dropdown box." & vbNewLine
        End If
        If comboOtherNeurologic.SelectedValue = 1 And txtOtherNeurologic.Text = "" Then
            result = False
            errorMessage += "- You have selected ""Yes"" for Other Neurologic Diagnoses without specifying a note. Please add a note or change the value in the Other Neurologic Diagnoses dropdown box." & vbNewLine
        End If

        'Validate comboWasGenericAutopsyDone
        If comboWasGeneralAutopsyDone.SelectedValue <> 1 Then
            If txtA.Text <> "" Or txtB.Text <> "" Or txtC.Text <> "" Or txtD.Text <> "" Or txtE.Text <> "" Then
                result = False
                errorMessage += "- You have entered Patho-Anatomical Findings without selecting ""Yes"" in the General Autopsy Done dropdown box. Please clear the notes or select ""Yes"" in the dropdown box." & vbNewLine
            End If
        End If

        'Handle result
        If result = False Then
            MsgBox("The following errors must be corrected before this record can be saved: " & vbNewLine & vbNewLine & errorMessage, MsgBoxStyle.OkOnly, "Error")
        End If
        Return result
    End Function

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
        btnCERADBBottom.PerformClick()
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class