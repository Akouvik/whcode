Public Class WA_CERADG_Screen
    Implements IFormMethods

    Private formTables As New DataSet
    Private G1_Complete As Integer

    Private Sub WA_CERADG_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_CERADG_Screen")
        If Database.ExistingRecordCheck("CERADG1", "SubNum = " & WarehouseShell.SubNum & " and Screen = 1") Then 'G1 exists and screen has been entered
            loadBaseForm()
            loadExistingData()
            btnCERADScreenBottom.Text = "Edit this record"
            btnCERADGScreenTop.Text = btnCERADScreenBottom.Text
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            enableInputFields(False)
            btnCERADGScreenTop.Focus()
        Else
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            btnCERADScreenBottom.Text = "Add New Record"
            btnCERADGScreenTop.Text = btnCERADScreenBottom.Text
            enableInputFields(False)
            lblNoRecord.Visible = True
        End If
    End Sub
    Private Sub loadBaseForm()
        'Load required lkp tables
        formTables.Tables.Add(Database.ReturnTable("lkpFrequency01359"))
        'Assign lookups
        cmbMFGRostralHypoxic.assignLookup(formTables, "lkpFrequency01359")
        cmbMFGRostralWMDegen.assignLookup(formTables, "lkpFrequency01359")
        cmbMFGRostralInflam.assignLookup(formTables, "lkpFrequency01359")
        cmbMFGRostralNeuro.assignLookup(formTables, "lkpFrequency01359")
        cmbMFGRostralOth.assignLookup(formTables, "lkpFrequency01359")
        cmbMFGCaudalHypoxic.assignLookup(formTables, "lkpFrequency01359")
        cmbMFGCaudalWMDegen.assignLookup(formTables, "lkpFrequency01359")
        cmbMFGCaudalInflam.assignLookup(formTables, "lkpFrequency01359")
        cmbMFGCaudalNeuro.assignLookup(formTables, "lkpFrequency01359")
        cmbMFGCaudalOth.assignLookup(formTables, "lkpFrequency01359")
        cmbPeriventHypoxic.assignLookup(formTables, "lkpFrequency01359")
        cmbPeriventWMDegen.assignLookup(formTables, "lkpFrequency01359")
        cmbPeriventInflam.assignLookup(formTables, "lkpFrequency01359")
        cmbPeriventNeuro.assignLookup(formTables, "lkpFrequency01359")
        cmbPeriventOth.assignLookup(formTables, "lkpFrequency01359")
        cmbBasGangHypoxic.assignLookup(formTables, "lkpFrequency01359")
        cmbBasGangWMDegen.assignLookup(formTables, "lkpFrequency01359")
        cmbBasGangInflam.assignLookup(formTables, "lkpFrequency01359")
        cmbBasGangNeuro.assignLookup(formTables, "lkpFrequency01359")
        cmbBasGangOth.assignLookup(formTables, "lkpFrequency01359")
        cmbCereHypoxic.assignLookup(formTables, "lkpFrequency01359")
        cmbCereWMDegen.assignLookup(formTables, "lkpFrequency01359")
        cmbCereInflam.assignLookup(formTables, "lkpFrequency01359")
        cmbCereNeuro.assignLookup(formTables, "lkpFrequency01359")
        cmbCereOth.assignLookup(formTables, "lkpFrequency01359")
        cmbOtherHypoxic.assignLookup(formTables, "lkpFrequency01359")
        cmbOtherWMDegen.assignLookup(formTables, "lkpFrequency01359")
        cmbOtherInflam.assignLookup(formTables, "lkpFrequency01359")
        cmbOtherNeuro.assignLookup(formTables, "lkpFrequency01359")
        cmbOtherOth.assignLookup(formTables, "lkpFrequency01359")
    End Sub
    Private Sub defaultValues()
        cmbMFGRostralHypoxic.SelectedValue = 0
        cmbMFGRostralWMDegen.SelectedValue = 0
        cmbMFGRostralInflam.SelectedValue = 0
        cmbMFGRostralNeuro.SelectedValue = 0
        cmbMFGRostralOth.SelectedValue = 9
        cmbMFGCaudalHypoxic.SelectedValue = 0
        cmbMFGCaudalWMDegen.SelectedValue = 0
        cmbMFGCaudalInflam.SelectedValue = 0
        cmbMFGCaudalNeuro.SelectedValue = 0
        cmbMFGCaudalOth.SelectedValue = 9
        cmbPeriventHypoxic.SelectedValue = 0
        cmbPeriventWMDegen.SelectedValue = 0
        cmbPeriventInflam.SelectedValue = 0
        cmbPeriventNeuro.SelectedValue = 0
        cmbPeriventOth.SelectedValue = 9
        cmbBasGangHypoxic.SelectedValue = 0
        cmbBasGangWMDegen.SelectedValue = 0
        cmbBasGangInflam.SelectedValue = 0
        cmbBasGangNeuro.SelectedValue = 0
        cmbBasGangOth.SelectedValue = 9
        cmbCereHypoxic.SelectedValue = 0
        cmbCereWMDegen.SelectedValue = 0
        cmbCereInflam.SelectedValue = 0
        cmbCereNeuro.SelectedValue = 0
        cmbCereOth.SelectedValue = 9
        cmbOtherHypoxic.SelectedValue = 9
        cmbOtherWMDegen.SelectedValue = 9
        cmbOtherInflam.SelectedValue = 9
        cmbOtherNeuro.SelectedValue = 9
        cmbOtherOth.SelectedValue = 9
    End Sub
    Private Sub loadExistingData()
        formTables.Tables.Add(Database.ReturnTable("viewCERADG_Screen", , "SubNum = " & WarehouseShell.SubNum))
        G1_Complete = formTables.Tables("viewCERADG_Screen").Rows(0).Item("Complete")
        chkHE.setValue(formTables, "viewCERADG_Screen", "HandE")
        chkCongoRed.setValue(formTables, "viewCERADG_Screen", "CongoRed")
        chkThioflavinS.setValue(formTables, "viewCERADG_Screen", "ThioflavinS")
        chkAmyloidBeta.setValue(formTables, "viewCERADG_Screen", "AmyloidBeta")
        chkTau.setValue(formTables, "viewCERADG_Screen", "Tau")
        chkSynuclein.setValue(formTables, "viewCERADG_Screen", "Synuclein")
        chkTDP43.setValue(formTables, "viewCERADG_Screen", "TDP43")
        chkUbiquitin.setValue(formTables, "viewCERADG_Screen", "Ubiquitin")
        chkSilverStain.setValue(formTables, "viewCERADG_Screen", "Silver")
        txtSilverStain.setValue(formTables, "viewCERADG_Screen", "SilverNote")
        chkOtherStain1.setValue(formTables, "viewCERADG_Screen", "OtherStain1")
        txtOtherStain1.setValue(formTables, "viewCERADG_Screen", "OtherStain1Note")
        chkOtherStain2.setValue(formTables, "viewCERADG_Screen", "OtherStain2")
        txtOtherStain2.setValue(formTables, "viewCERADG_Screen", "OtherStain2Note")
        chkOtherStain3.setValue(formTables, "viewCERADG_Screen", "OtherStain3")
        txtOtherStain3.setValue(formTables, "viewCERADG_Screen", "OtherStain3Note")
        chkOtherStain4.setValue(formTables, "viewCERADG_Screen", "OtherStain4")
        txtOtherStain4.setValue(formTables, "viewCERADG_Screen", "OtherStain4Note")
        cmbMFGRostralHypoxic.setValue(formTables, "viewCERADG_Screen", "MFGRostralHypoxic")
        cmbMFGRostralWMDegen.setValue(formTables, "viewCERADG_Screen", "MFGRostralWMDegen")
        cmbMFGRostralInflam.setValue(formTables, "viewCERADG_Screen", "MFGRostralInflam")
        cmbMFGRostralNeuro.setValue(formTables, "viewCERADG_Screen", "MFGRostralNeuro")
        cmbMFGRostralOth.setValue(formTables, "viewCERADG_Screen", "MFGRostralOth")
        cmbMFGCaudalHypoxic.setValue(formTables, "viewCERADG_Screen", "MFGCaudalHypoxic")
        cmbMFGCaudalWMDegen.setValue(formTables, "viewCERADG_Screen", "MFGCaudalWMDegen")
        cmbMFGCaudalInflam.setValue(formTables, "viewCERADG_Screen", "MFGCaudalInflam")
        cmbMFGCaudalNeuro.setValue(formTables, "viewCERADG_Screen", "MFGCaudalNeuro")
        cmbMFGCaudalOth.setValue(formTables, "viewCERADG_Screen", "MFGCaudalOth")
        cmbPeriventHypoxic.setValue(formTables, "viewCERADG_Screen", "PeriventHypoxic")
        cmbPeriventWMDegen.setValue(formTables, "viewCERADG_Screen", "PeriventWMDegen")
        cmbPeriventInflam.setValue(formTables, "viewCERADG_Screen", "PeriventInflam")
        cmbPeriventNeuro.setValue(formTables, "viewCERADG_Screen", "PeriventNeuro")
        cmbPeriventOth.setValue(formTables, "viewCERADG_Screen", "PeriventOth")
        cmbBasGangHypoxic.setValue(formTables, "viewCERADG_Screen", "BasGangHypoxic")
        cmbBasGangWMDegen.setValue(formTables, "viewCERADG_Screen", "BasGangWMDegen")
        cmbBasGangInflam.setValue(formTables, "viewCERADG_Screen", "BasGangInflam")
        cmbBasGangNeuro.setValue(formTables, "viewCERADG_Screen", "BasGangNeuro")
        cmbBasGangOth.setValue(formTables, "viewCERADG_Screen", "BasGangOth")
        cmbCereHypoxic.setValue(formTables, "viewCERADG_Screen", "CereHypoxic")
        cmbCereWMDegen.setValue(formTables, "viewCERADG_Screen", "CereWMDegen")
        cmbCereInflam.setValue(formTables, "viewCERADG_Screen", "CereInflam")
        cmbCereNeuro.setValue(formTables, "viewCERADG_Screen", "CereNeuro")
        cmbCereOth.setValue(formTables, "viewCERADG_Screen", "CereOth")
        cmbOtherHypoxic.setValue(formTables, "viewCERADG_Screen", "OtherHypoxic")
        cmbOtherWMDegen.setValue(formTables, "viewCERADG_Screen", "OtherWMDegen")
        cmbOtherInflam.setValue(formTables, "viewCERADG_Screen", "OtherInflam")
        cmbOtherNeuro.setValue(formTables, "viewCERADG_Screen", "OtherNeuro")
        cmbOtherOth.setValue(formTables, "viewCERADG_Screen", "OtherOth")
        txtOtherRegionSpec.setValue(formTables, "viewCERADG_Screen", "OtherRegionSpec")
        txtOtherCritSpec.setValue(formTables, "viewCERADG_Screen", "OtherCritSpec")
    End Sub
    Private Sub enableInputFields(ByVal bool As Boolean)
        If bool Then
            chkHE.Enabled = True
            chkCongoRed.Enabled = True
            chkThioflavinS.Enabled = True
            chkAmyloidBeta.Enabled = True
            chkTau.Enabled = True
            chkSynuclein.Enabled = True
            chkTDP43.Enabled = True
            chkUbiquitin.Enabled = True
            chkSilverStain.Enabled = True
            txtSilverStain.Enabled = True
            chkOtherStain1.Enabled = True
            txtOtherStain1.Enabled = True
            chkOtherStain2.Enabled = True
            txtOtherStain2.Enabled = True
            chkOtherStain3.Enabled = True
            txtOtherStain3.Enabled = True
            chkOtherStain4.Enabled = True
            txtOtherStain4.Enabled = True
            cmbMFGRostralHypoxic.Enabled = True
            cmbMFGRostralWMDegen.Enabled = True
            cmbMFGRostralInflam.Enabled = True
            cmbMFGRostralNeuro.Enabled = True
            cmbMFGRostralOth.Enabled = True
            cmbMFGCaudalHypoxic.Enabled = True
            cmbMFGCaudalWMDegen.Enabled = True
            cmbMFGCaudalInflam.Enabled = True
            cmbMFGCaudalNeuro.Enabled = True
            cmbMFGCaudalOth.Enabled = True
            cmbPeriventHypoxic.Enabled = True
            cmbPeriventWMDegen.Enabled = True
            cmbPeriventInflam.Enabled = True
            cmbPeriventNeuro.Enabled = True
            cmbPeriventOth.Enabled = True
            cmbBasGangHypoxic.Enabled = True
            cmbBasGangWMDegen.Enabled = True
            cmbBasGangInflam.Enabled = True
            cmbBasGangNeuro.Enabled = True
            cmbBasGangOth.Enabled = True
            cmbCereHypoxic.Enabled = True
            cmbCereWMDegen.Enabled = True
            cmbCereInflam.Enabled = True
            cmbCereNeuro.Enabled = True
            cmbCereOth.Enabled = True
            cmbOtherHypoxic.Enabled = True
            cmbOtherWMDegen.Enabled = True
            cmbOtherInflam.Enabled = True
            cmbOtherNeuro.Enabled = True
            cmbOtherOth.Enabled = True
            txtOtherRegionSpec.Enabled = True
            txtOtherCritSpec.Enabled = True
            btnMFGRostral.Enabled = True
            btnMFGCaudal.Enabled = True
            btnPerivent.Enabled = True
            btnBasGang.Enabled = True
            btnCere.Enabled = True
            btnOther.Enabled = True
        Else
            chkHE.Enabled = False
            chkCongoRed.Enabled = False
            chkThioflavinS.Enabled = False
            chkAmyloidBeta.Enabled = False
            chkTau.Enabled = False
            chkSynuclein.Enabled = False
            chkTDP43.Enabled = False
            chkUbiquitin.Enabled = False
            chkSilverStain.Enabled = False
            txtSilverStain.Enabled = False
            chkOtherStain1.Enabled = False
            txtOtherStain1.Enabled = False
            chkOtherStain2.Enabled = False
            txtOtherStain2.Enabled = False
            chkOtherStain3.Enabled = False
            txtOtherStain3.Enabled = False
            chkOtherStain4.Enabled = False
            txtOtherStain4.Enabled = False
            cmbMFGRostralHypoxic.Enabled = False
            cmbMFGRostralWMDegen.Enabled = False
            cmbMFGRostralInflam.Enabled = False
            cmbMFGRostralNeuro.Enabled = False
            cmbMFGRostralOth.Enabled = False
            cmbMFGCaudalHypoxic.Enabled = False
            cmbMFGCaudalWMDegen.Enabled = False
            cmbMFGCaudalInflam.Enabled = False
            cmbMFGCaudalNeuro.Enabled = False
            cmbMFGCaudalOth.Enabled = False
            cmbPeriventHypoxic.Enabled = False
            cmbPeriventWMDegen.Enabled = False
            cmbPeriventInflam.Enabled = False
            cmbPeriventNeuro.Enabled = False
            cmbPeriventOth.Enabled = False
            cmbBasGangHypoxic.Enabled = False
            cmbBasGangWMDegen.Enabled = False
            cmbBasGangInflam.Enabled = False
            cmbBasGangNeuro.Enabled = False
            cmbBasGangOth.Enabled = False
            cmbCereHypoxic.Enabled = False
            cmbCereWMDegen.Enabled = False
            cmbCereInflam.Enabled = False
            cmbCereNeuro.Enabled = False
            cmbCereOth.Enabled = False
            cmbOtherHypoxic.Enabled = False
            cmbOtherWMDegen.Enabled = False
            cmbOtherInflam.Enabled = False
            cmbOtherNeuro.Enabled = False
            cmbOtherOth.Enabled = False
            txtOtherRegionSpec.Enabled = False
            txtOtherCritSpec.Enabled = False
            btnMFGRostral.Enabled = False
            btnMFGCaudal.Enabled = False
            btnPerivent.Enabled = False
            btnBasGang.Enabled = False
            btnCere.Enabled = False
            btnOther.Enabled = False
        End If
    End Sub
    Private Sub btnCERADScreen_Click(sender As Object, e As EventArgs) Handles btnCERADGScreenTop.Click, btnCERADScreenBottom.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_CERADG_Screen", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                enableInputFields(True)
                btnCERADScreenBottom.Text = "Save changes"
                btnCERADGScreenTop.Text = btnCERADScreenBottom.Text
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If Database.ExistingRecordCheck("CERAD_Header", "SubNum = " & WarehouseShell.SubNum) Then
                If Database.ExistingRecordCheck("CERADG1", "SubNum = " & WarehouseShell.SubNum) Then 'G1 exists but no screen has been entered
                    If User.PermissionCheck("WA_CERADG_Screen", "Modify") Then
                        loadBaseForm()
                        loadExistingData() 'to grab exiting stains
                        defaultValues() 'to overwrite nulls with defaults
                        btnCERADScreenBottom.Text = "Save new record"
                        btnCERADGScreenTop.Text = btnCERADScreenBottom.Text
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                        lblNoRecord.Visible = False
                        enableInputFields(True)
                    End If
                Else
                    If User.PermissionCheck("WA_CERADG_Screen", "Modify") Then
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
                        loadBaseForm()
                        defaultValues()
                        enableInputFields(True)
                        btnCERADScreenBottom.Text = "Save new record"
                        btnCERADGScreenTop.Text = btnCERADScreenBottom.Text
                        lblNoRecord.Visible = False
                    End If
                End If
            Else
                MsgBox("Please create a CERAD Header for this subject before attempting to add CERAD information.", MsgBoxStyle.OkOnly, "Error!")
            End If
        Else
            If preSaveValidation() = True Then
                Dim sqlCommand As New SqlCommand
                sqlCommand.Connection = WarehouseShell.conn
                Dim cmdString = "@SubNum = " & WarehouseShell.SubNum &
                    ", @HandE = " & chkHE.getSQLValue() &
                    ", @CongoRed = " & chkCongoRed.getSQLValue() &
                    ", @ThioflavinS = " & chkThioflavinS.getSQLValue() &
                    ", @AmyloidBeta = " & chkAmyloidBeta.getSQLValue() &
                    ", @Tau = " & chkTau.getSQLValue() &
                    ", @Synuclein = " & chkSynuclein.getSQLValue() &
                    ", @TDP43 = " & chkTDP43.getSQLValue() &
                    ", @Ubiquitin = " & chkUbiquitin.getSQLValue() &
                    ", @Silver = " & chkSilverStain.getSQLValue() &
                    ", @SilverNote = " & txtSilverStain.getSQLValue() &
                    ", @OtherStain1 = " & chkOtherStain1.getSQLValue() &
                    ", @OtherStain1Note = " & txtOtherStain1.getSQLValue() &
                    ", @OtherStain2 = " & chkOtherStain2.getSQLValue() &
                    ", @OtherStain2Note = " & txtOtherStain2.getSQLValue() &
                    ", @OtherStain3 = " & chkOtherStain3.getSQLValue() &
                    ", @OtherStain3Note = " & txtOtherStain3.getSQLValue() &
                    ", @OtherStain4 = " & chkOtherStain4.getSQLValue() &
                    ", @OtherStain4Note = " & txtOtherStain4.getSQLValue() &
                    ", @Complete = " & G1_Complete &
                    ", @MFGRostralHypoxic = " & cmbMFGRostralHypoxic.getSQLValue() &
                    ", @MFGRostralWMDegen = " & cmbMFGRostralWMDegen.getSQLValue() &
                    ", @MFGRostralInflam = " & cmbMFGRostralInflam.getSQLValue() &
                    ", @MFGRostralNeuro = " & cmbMFGRostralNeuro.getSQLValue() &
                    ", @MFGRostralOth = " & cmbMFGRostralOth.getSQLValue() &
                    ", @MFGCaudalHypoxic = " & cmbMFGCaudalHypoxic.getSQLValue() &
                    ", @MFGCaudalWMDegen = " & cmbMFGCaudalWMDegen.getSQLValue() &
                    ", @MFGCaudalInflam = " & cmbMFGCaudalInflam.getSQLValue() &
                    ", @MFGCaudalNeuro = " & cmbMFGCaudalNeuro.getSQLValue() &
                    ", @MFGCaudalOth = " & cmbMFGCaudalOth.getSQLValue() &
                    ", @PeriventHypoxic = " & cmbPeriventHypoxic.getSQLValue() &
                    ", @PeriventWMDegen = " & cmbPeriventWMDegen.getSQLValue() &
                    ", @PeriventInflam = " & cmbPeriventInflam.getSQLValue() &
                    ", @PeriventNeuro = " & cmbPeriventNeuro.getSQLValue() &
                    ", @PeriventOth = " & cmbPeriventOth.getSQLValue() &
                    ", @BasGangHypoxic = " & cmbBasGangHypoxic.getSQLValue() &
                    ", @BasGangWMDegen = " & cmbBasGangWMDegen.getSQLValue() &
                    ", @BasGangInflam = " & cmbBasGangInflam.getSQLValue() &
                    ", @BasGangNeuro = " & cmbBasGangNeuro.getSQLValue() &
                    ", @BasGangOth = " & cmbBasGangOth.getSQLValue() &
                    ", @CereHypoxic = " & cmbCereHypoxic.getSQLValue() &
                    ", @CereWMDegen = " & cmbCereWMDegen.getSQLValue() &
                    ", @CereInflam = " & cmbCereInflam.getSQLValue() &
                    ", @CereNeuro = " & cmbCereNeuro.getSQLValue() &
                    ", @CereOth = " & cmbCereOth.getSQLValue() &
                    ", @OtherHypoxic = " & cmbOtherHypoxic.getSQLValue() &
                    ", @OtherWMDegen = " & cmbOtherWMDegen.getSQLValue() &
                    ", @OtherInflam = " & cmbOtherInflam.getSQLValue() &
                    ", @OtherNeuro = " & cmbOtherNeuro.getSQLValue() &
                    ", @OtherOth = " & cmbOtherOth.getSQLValue() &
                    ", @OtherRegionSpec = " & txtOtherRegionSpec.getSQLValue() &
                    ", @OtherCritSpec = " & txtOtherCritSpec.getSQLValue() &
                    ", @Screen = 1" &
                    ";"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    sqlCommand.CommandText = "EXEC dbo.modCERADGScreen @Action = 1, " & cmdString
                    Try
                        sqlCommand.ExecuteScalar()
                        MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        enableInputFields(False)
                        btnCERADScreenBottom.Text = "Edit this record"
                        btnCERADGScreenTop.Text = btnCERADScreenBottom.Text
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else
                    sqlCommand.CommandText = "EXEC dbo.modCERADGScreen @Action = 2, " & cmdString
                    Try
                        sqlCommand.ExecuteScalar()
                        MessageBox.Show("Changes saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        enableInputFields(False)
                        btnCERADScreenBottom.Text = "Edit this record"
                        btnCERADGScreenTop.Text = btnCERADScreenBottom.Text
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                End If
            End If
        End If
    End Sub
    Private Function preSaveValidation() As Boolean
        Dim result As Boolean = True
        Dim errorMessage As String = ""

        'Make sure at least one stain is checked
        Dim stainCount As Integer = 0
        For Each chk As Control In Controls
            If TypeOf chk Is CheckBox_ Then
                If CType(chk, CheckBox_).Checked Then
                    stainCount += 1
                End If
            End If
        Next
        If stainCount = 0 Then
            result = False
            errorMessage += "- Please select at least one stain." & vbNewLine
        End If

        'Check stain specify dependencies
        If chkSilverStain.Checked = False And txtSilverStain.Text <> "" Then
            result = False
            errorMessage += "- You have entered a Silver Stain note without checking the Silver Stain box. Please clear the note or check the Silver Stain box." & vbNewLine
        End If
        If chkSilverStain.Checked And txtSilverStain.Text = "" Then
            result = False
            errorMessage += "- You have checked the Silver Stain box without specifying a note. Please add a note or uncheck the Silver Stain box." & vbNewLine
        End If
        If chkOtherStain1.Checked = False And txtOtherStain1.Text <> "" Then
            result = False
            errorMessage += "- You have entered a Other Stain note without checking the Other Stain 1 box. Please clear the note or check the Other Stain 1 box." & vbNewLine
        End If
        If chkOtherStain1.Checked And txtOtherStain1.Text = "" Then
            result = False
            errorMessage += "- You have checked the Other Stain 1 box without specifying a note. Please add a note or uncheck the Other Stain 1 box." & vbNewLine
        End If
        If chkOtherStain2.Checked = False And txtOtherStain2.Text <> "" Then
            result = False
            errorMessage += "- You have entered a Other Stain note without checking the Other Stain 2 box. Please clear the note or check the Other Stain 2 box." & vbNewLine
        End If
        If chkOtherStain2.Checked And txtOtherStain2.Text = "" Then
            result = False
            errorMessage += "- You have checked the Other Stain 2 box without specifying a note. Please add a note or uncheck the Other Stain 2 box." & vbNewLine
        End If
        If chkOtherStain3.Checked = False And txtOtherStain3.Text <> "" Then
            result = False
            errorMessage += "- You have entered a Other Stain note without checking the Other Stain 3 box. Please clear the note or check the Other Stain 3 box." & vbNewLine
        End If
        If chkOtherStain3.Checked And txtOtherStain3.Text = "" Then
            result = False
            errorMessage += "- You have checked the Other Stain 3 box without specifying a note. Please add a note or uncheck the Other Stain 3 box." & vbNewLine
        End If
        If chkOtherStain4.Checked = False And txtOtherStain4.Text <> "" Then
            result = False
            errorMessage += "- You have entered a Other Stain note without checking the Other Stain 4 box. Please clear the note or check the Other Stain 4 box." & vbNewLine
        End If
        If chkOtherStain4.Checked And txtOtherStain4.Text = "" Then
            result = False
            errorMessage += "- You have checked the Other Stain 4 box without specifying a note. Please add a note or uncheck the Other Stain 4 box." & vbNewLine
        End If

        'Check OtherRegion dependencies
        If (cmbOtherHypoxic.SelectedValue <> 9 Or cmbOtherWMDegen.SelectedValue <> 9 Or cmbOtherInflam.SelectedValue <> 9 Or cmbOtherNeuro.SelectedValue <> 9 Or cmbOtherOth.SelectedValue <> 9) And txtOtherRegionSpec.Text = "" Then
            result = False
            errorMessage += "- You have set a non-N/A value under Other Region, but have not defined the region for Other. Please define Other Region or set all values to N/A." & vbNewLine
        End If
        If cmbOtherHypoxic.SelectedValue = 9 And cmbOtherWMDegen.SelectedValue = 9 And cmbOtherInflam.SelectedValue = 9 And cmbOtherNeuro.SelectedValue = 9 And cmbOtherOth.SelectedValue = 9 And txtOtherRegionSpec.Text <> "" Then
            result = False
            errorMessage += "- You have defined Other Region but set all criteria values to N/A. Please provide at least 1 non-N/A criteria result, or clear the Other Region text." & vbNewLine
        End If

        'Check OtherCriteria dependencies
        If (cmbMFGCaudalOth.SelectedValue <> 9 Or cmbMFGCaudalOth.SelectedValue <> 9 Or cmbPeriventOth.SelectedValue <> 9 Or cmbBasGangOth.SelectedValue <> 9 Or cmbCereOth.SelectedValue <> 9 Or cmbOtherOth.SelectedValue <> 9) And txtOtherCritSpec.Text = "" Then
            result = False
            errorMessage += "- You have set a non-N/A value for Other Criteria, but have not defined the Other Criteria. Please define Other Criteria or set all values to N/A." & vbNewLine
        End If
        If cmbMFGRostralOth.SelectedValue = 9 And cmbMFGCaudalOth.SelectedValue = 9 And cmbPeriventOth.SelectedValue = 9 And cmbBasGangOth.SelectedValue = 9 And cmbCereOth.SelectedValue = 9 And cmbOtherOth.SelectedValue = 9 And txtOtherCritSpec.Text <> "" Then
            result = False
            errorMessage += "- You have defined Other Criteria but set all region values to N/A. Please provide at least 1 non-N/A region result, or clear the Other Criteria text." & vbNewLine
        End If

        'Handle result
        If result = False Then
            MsgBox("The following errors exist and must be corrected before this record can be saved:" & vbNewLine & vbNewLine & errorMessage, MsgBoxStyle.OkOnly, "Error")
        End If
        Return result
    End Function

    Private Sub btnMFGRostral_Click(sender As Object, e As EventArgs) Handles btnMFGRostral.Click
        cmbMFGRostralHypoxic.SelectedValue = 9
        cmbMFGRostralWMDegen.SelectedValue = 9
        cmbMFGRostralInflam.SelectedValue = 9
        cmbMFGRostralNeuro.SelectedValue = 9
        cmbMFGRostralOth.SelectedValue = 9
    End Sub
    Private Sub btnMFGCaudal_Click(sender As Object, e As EventArgs) Handles btnMFGCaudal.Click
        cmbMFGCaudalHypoxic.SelectedValue = 9
        cmbMFGCaudalWMDegen.SelectedValue = 9
        cmbMFGCaudalInflam.SelectedValue = 9
        cmbMFGCaudalNeuro.SelectedValue = 9
        cmbMFGCaudalOth.SelectedValue = 9
    End Sub
    Private Sub btnPerivent_Click(sender As Object, e As EventArgs) Handles btnPerivent.Click
        cmbPeriventHypoxic.SelectedValue = 9
        cmbPeriventWMDegen.SelectedValue = 9
        cmbPeriventInflam.SelectedValue = 9
        cmbPeriventNeuro.SelectedValue = 9
        cmbPeriventOth.SelectedValue = 9
    End Sub
    Private Sub btnBasGang_Click(sender As Object, e As EventArgs) Handles btnBasGang.Click
        cmbBasGangHypoxic.SelectedValue = 9
        cmbBasGangWMDegen.SelectedValue = 9
        cmbBasGangInflam.SelectedValue = 9
        cmbBasGangNeuro.SelectedValue = 9
        cmbBasGangOth.SelectedValue = 9
    End Sub
    Private Sub btnCere_Click(sender As Object, e As EventArgs) Handles btnCere.Click
        cmbCereHypoxic.SelectedValue = 9
        cmbCereWMDegen.SelectedValue = 9
        cmbCereInflam.SelectedValue = 9
        cmbCereNeuro.SelectedValue = 9
        cmbCereOth.SelectedValue = 9
    End Sub
    Private Sub btnOther_Click(sender As Object, e As EventArgs) Handles btnOther.Click
        cmbOtherHypoxic.SelectedValue = 9
        cmbOtherWMDegen.SelectedValue = 9
        cmbOtherInflam.SelectedValue = 9
        cmbOtherNeuro.SelectedValue = 9
        cmbOtherOth.SelectedValue = 9
    End Sub

    Public Sub TopLevel(val As Boolean) Implements IFormMethods.TopLevel
    End Sub
    Public Sub ShowPHI(val As Boolean) Implements IFormMethods.ShowPHI
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
    Private Sub IFormMethods_Parent(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Private Sub IFormMethods_Show() Implements IFormMethods.Show
        Show()
    End Sub
End Class