Public Class WA_PMCR_Informants
    Implements IFormMethods

    Private formTables As New DataSet

    Private Sub WA_PMCR_Informants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_PMCR_tabInformants")
        loadBaseData()
        If Database.ExistingRecordCheck("PMCR_Informants", "SubNum = " & WarehouseShell.SubNum) Then
            loadExistingData()
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            lblNoRecord.Visible = False
            btnInformantsTop.Text = "Edit Record"
            btnInformantsBottom.Text = "Edit Record"
        Else
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            lblNoRecord.Visible = True
            btnInformantsTop.Text = "Add New Record"
            btnInformantsBottom.Text = "Add New Record"
        End If
        enableInputFields(False)
    End Sub
    Private Sub loadBaseData()
        WarehouseShell.highlightSelectedNode("WA_PMCR_tabInformants")
        'Grab any required comboLookUp tables and assign them to their appropriate boxes
        formTables.Tables.Add(Database.ReturnTable("lkpPMCR_InfType"))
        formTables.Tables.Add(Database.ReturnTable("lkpRelation"))
        comboInf1Type.assignLookup(formTables, "lkpPMCR_InfType")
        comboInf2Type.assignLookup(formTables, "lkpPMCR_InfType")
        comboInf3Type.assignLookup(formTables, "lkpPMCR_InfType")
        comboInf4Type.assignLookup(formTables, "lkpPMCR_InfType")
        comboInf1Relation.assignLookup(formTables, "lkpRelation")
        comboInf2Relation.assignLookup(formTables, "lkpRelation")
        comboInf3Relation.assignLookup(formTables, "lkpRelation")
        comboInf4Relation.assignLookup(formTables, "lkpRelation")
    End Sub
    Private Sub setDefaultValues()
        comboInf1Type.SelectedValue = -1
        comboInf2Type.SelectedValue = -1
        comboInf3Type.SelectedValue = -1
        comboInf4Type.SelectedValue = -1
        comboInf1Relation.SelectedValue = -1
        comboInf2Relation.SelectedValue = -1
        comboInf3Relation.SelectedValue = -1
        comboInf4Relation.SelectedValue = -1
    End Sub
    Private Sub loadExistingData()
        'Grab the individual record, based on RecordID, and assign values to their appropriate fields
        formTables.Tables.Add(Database.ReturnTable("PMCR_Informants", , "SubNum = " & WarehouseShell.SubNum))
        comboInf1Type.setValue(formTables, "PMCR_Informants", "Inf1Type")
        txtInf1Name.setValue(formTables, "PMCR_Informants", "Inf1Name")
        txtInf1Address.setValue(formTables, "PMCR_Informants", "Inf1Address")
        comboInf1Relation.setValue(formTables, "PMCR_Informants", "Inf1Relation")
        txtInf1WorkPhone.setValue(formTables, "PMCR_Informants", "Inf1WorkPhone")
        txtInf1HomePhone.setValue(formTables, "PMCR_Informants", "Inf1HomePhone")
        comboInf2Type.setValue(formTables, "PMCR_Informants", "Inf1Type")
        txtInf2Name.setValue(formTables, "PMCR_Informants", "Inf2Name")
        txtInf2Address.setValue(formTables, "PMCR_Informants", "Inf2Address")
        comboInf2Relation.setValue(formTables, "PMCR_Informants", "Inf2Relation")
        txtInf2WorkPhone.setValue(formTables, "PMCR_Informants", "Inf2WorkPhone")
        txtInf2Address.setValue(formTables, "PMCR_Informants", "Inf2HomePhone")
        comboInf3Type.setValue(formTables, "PMCR_Informants", "Inf3Type")
        txtInf3Name.setValue(formTables, "PMCR_Informants", "Inf3Name")
        txtInf3Address.setValue(formTables, "PMCR_Informants", "Inf3Address")
        comboInf3Relation.setValue(formTables, "PMCR_Informants", "Inf3Relation")
        txtInf3WorkPhone.setValue(formTables, "PMCR_Informants", "Inf3WorkPhone")
        txtInf3HomePhone.setValue(formTables, "PMCR_Informants", "Inf3HomePhone")
        comboInf4Type.setValue(formTables, "PMCR_Informants", "Inf4Type")
        txtInf4Name.setValue(formTables, "PMCR_Informants", "Inf4Name")
        txtInf4Address.setValue(formTables, "PMCR_Informants", "Inf4Address")
        comboInf4Relation.setValue(formTables, "PMCR_Informants", "Inf4Relation")
        txtInf4WorkPhone.setValue(formTables, "PMCR_Informants", "Inf4WorkPhone")
        txtInf4HomePhone.setValue(formTables, "PMCR_Informants", "Inf4HomePhone")
    End Sub
    Private Sub enableInputFields(ByVal bool As Boolean)
        If bool = True Then
            comboInf1Type.Enabled = True
            txtInf1Name.Enabled = True
            txtInf1Address.Enabled = True
            comboInf1Relation.Enabled = True
            txtInf1WorkPhone.Enabled = True
            txtInf1HomePhone.Enabled = True
            comboInf2Type.Enabled = True
            txtInf2Name.Enabled = True
            txtInf2Address.Enabled = True
            comboInf2Relation.Enabled = True
            txtInf2WorkPhone.Enabled = True
            txtInf2HomePhone.Enabled = True
            comboInf3Type.Enabled = True
            txtInf3Name.Enabled = True
            txtInf3Address.Enabled = True
            comboInf3Relation.Enabled = True
            txtInf3WorkPhone.Enabled = True
            txtInf3HomePhone.Enabled = True
            comboInf4Type.Enabled = True
            txtInf4Name.Enabled = True
            txtInf4Address.Enabled = True
            comboInf4Relation.Enabled = True
            txtInf4WorkPhone.Enabled = True
            txtInf4HomePhone.Enabled = True
        Else
            comboInf1Type.Enabled = False
            txtInf1Name.Enabled = False
            txtInf1Address.Enabled = False
            comboInf1Relation.Enabled = False
            txtInf1WorkPhone.Enabled = False
            txtInf1HomePhone.Enabled = False
            comboInf2Type.Enabled = False
            txtInf2Name.Enabled = False
            txtInf2Address.Enabled = False
            comboInf2Relation.Enabled = False
            txtInf2WorkPhone.Enabled = False
            txtInf2HomePhone.Enabled = False
            comboInf3Type.Enabled = False
            txtInf3Name.Enabled = False
            txtInf3Address.Enabled = False
            comboInf3Relation.Enabled = False
            txtInf3WorkPhone.Enabled = False
            txtInf3HomePhone.Enabled = False
            comboInf4Type.Enabled = False
            txtInf4Name.Enabled = False
            txtInf4Address.Enabled = False
            comboInf4Relation.Enabled = False
            txtInf4WorkPhone.Enabled = False
            txtInf4HomePhone.Enabled = False
        End If
    End Sub

    Private Sub btnInformantsBottom_Click(sender As Object, e As EventArgs) Handles btnInformantsBottom.Click, btnInformantsTop.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_PMCR_Informants", "Modify") Then
                btnInformantsBottom.Text = "Save Changes"
                btnInformantsTop.Text = "Save Changes"
                enableInputFields(True)
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If User.PermissionCheck("WA_PMCR_Informants", "Modify") Then
                setDefaultValues()
                lblNoRecord.Visible = False
                btnInformantsBottom.Text = "Save New Record"
                btnInformantsTop.Text = "Save New Record"
                enableInputFields(True)
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
            End If
        Else 'By default, user is attempting to Insert or Edit a record. Run preSaveValidation.
            If preSaveValidation() Then 'If preSaveValidation returns true, take Insert or Update actions.
                'Same parameters for Insert or Update SP's, so define here
                Dim cmd As New SqlCommand
                cmd.Connection = WarehouseShell.conn
                Dim parameters = "@SubNum = " & WarehouseShell.SubNum &
                        ", @Inf1Type = " & comboInf1Type.getSQLValue() &
                        ", @Inf1Name = " & txtInf1Name.getSQLValue() &
                        ", @Inf1Address = " & txtInf1Address.getSQLValue() &
                        ", @Inf1Relation = " & comboInf1Relation.getSQLValue() &
                        ", @Inf1WorkPhone = " & txtInf1WorkPhone.getSQLValue() &
                        ", @Inf1HomePhone = " & txtInf1HomePhone.getSQLValue() &
                        ", @Inf2Type = " & comboInf2Type.getSQLValue() &
                        ", @Inf2Name = " & txtInf2Name.getSQLValue() &
                        ", @Inf2Address = " & txtInf2Address.getSQLValue() &
                        ", @Inf2Relation = " & comboInf2Relation.getSQLValue() &
                        ", @Inf2WorkPhone = " & txtInf2WorkPhone.getSQLValue() &
                        ", @Inf2HomePhone = " & txtInf2HomePhone.getSQLValue() &
                        ", @Inf3Type = " & comboInf3Type.getSQLValue() &
                        ", @Inf3Name = " & txtInf3Name.getSQLValue() &
                        ", @Inf3Address = " & txtInf3Address.getSQLValue() &
                        ", @Inf3Relation = " & comboInf3Relation.getSQLValue() &
                        ", @Inf3WorkPhone = " & txtInf3WorkPhone.getSQLValue() &
                        ", @Inf3HomePhone = " & txtInf3HomePhone.getSQLValue() &
                        ", @Inf4Type = " & comboInf4Type.getSQLValue() &
                        ", @Inf4Name = " & txtInf4Name.getSQLValue() &
                        ", @Inf4Address = " & txtInf4Address.getSQLValue() &
                        ", @Inf4Relation = " & comboInf4Relation.getSQLValue() &
                        ", @Inf4WorkPhone = " & txtInf4WorkPhone.getSQLValue() &
                        ", @Inf4HomePhone = " & txtInf4HomePhone.getSQLValue() &
                        ", @LastModBy = '" & WarehouseShell.userName & "';"
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    Dim cmdString = "Exec modPMCR_InformantsRecord @Action = 1, " & parameters
                    cmd.CommandText = cmdString
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Record successfully added.", MsgBoxStyle.OkOnly, "Success")
                        enableInputFields(False)
                        btnInformantsBottom.Text = "Edit Record"
                        btnInformantsTop.Text = "Edit Record"
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else 'If this clause is invoked, datamode must be Edit
                    Dim cmdString = "Exec modPMCR_InformantsRecord @Action = 2, " & parameters
                    cmd.CommandText = cmdString
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Record successfully updated.", MsgBoxStyle.OkOnly, "Success")
                        enableInputFields(False)
                        btnInformantsBottom.Text = "Edit Record"
                        btnInformantsTop.Text = "Edit Record"
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

    Public Sub TopLevel(val As Boolean) Implements IFormMethods.TopLevel
    End Sub
    Private Sub IFormMethods_Parent(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Private Sub IFormMethods_Show() Implements IFormMethods.Show
        Show()
    End Sub
    Public Sub ShowPHI(val As Boolean) Implements IFormMethods.ShowPHI
        'TODO: do some stuff here to hide/show phi
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        btnInformantsTop.PerformClick()
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class