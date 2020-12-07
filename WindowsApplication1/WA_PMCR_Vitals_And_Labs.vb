Imports System.Reflection
Imports Korzh.EasyQuery.Db

Public Class WA_PMCR_Vitals_And_Labs
    Implements IFormMethods

    Private formTables As New DataSet
    Private Results As DataTable
    Private Reader As SqlDataAdapter
    Dim labSource As String = ""
    Dim query As Boolean
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Dim _assembly As Assembly = Assembly.GetExecutingAssembly()
        eqModel.LoadFromStream(_assembly.GetManifestResourceStream("DataWarehouse.modelLabs.xml"))
    End Sub

    Private Sub WA_PMCR_Vitals_And_Labs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Sql As String = "select count(*)from viewLabs where SubNum = " & WarehouseShell.SubNum & " and (LabSource = 'NMS Toxicology' or LabSource = 'VRL Serology')"
        Dim cmd As New SqlCommand(Sql, WarehouseShell.conn)
        Dim result = cmd.ExecuteScalar()
        If result <= 0 Then
            CheckBox_1.Enabled = False
            CheckBox_2.Enabled = False
        End If
        WarehouseShell.highlightSelectedNode("WA_PMCR_tabVitalsAndLabs")
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        refreshForm()
        formTables.Tables.Add(Database.ReturnTable("lkpNormAbnorm01WithBlank"))
        cmbChestXray.assignLookup(formTables, "lkpNormAbnorm01WithBlank")
        cmbECG.assignLookup(formTables, "lkpNormAbnorm01WithBlank")
        If Database.ExistingRecordCheck("PMCR_ChestXray_ECG", "SubNum = " & WarehouseShell.SubNum) Then
            loadExistingData()
            btnXray.Text = "Edit Xray/ECG"
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        Else
            setDefaultValues()
            btnXray.Text = "Add Xray/ECG"
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
        End If
        If Database.ExistingRecordCheck("LabsMisc", "SubNum = " & WarehouseShell.SubNum) Then
            loadExistingMiscData()
        End If
        enableInputFields(False)
        cmbApoE.Enabled = False
        txtpH.Enabled = False
    End Sub

    Public Sub refreshForm()
        refreshDGV()
        'Enable the Edit button if at least 1 lab exists in DGV
        If dgvLabs.SelectedRows.Count = 1 Then
            btnEditLab.Enabled = True
        Else
            btnEditLab.Enabled = False
        End If
    End Sub

    Private Sub refreshDGV()
        If query Then
            btnQuery.PerformClick()
        Else
            Results = New DataTable("Results")
            If CheckBox_1.Checked Then
                Reader = New SqlDataAdapter("Select * from viewLabs where SubNum = " & WarehouseShell.SubNum & " And LabSource = 'NMS Toxicology' order by LabName, LabDate", WarehouseShell.conn)
                Reader.Fill(Results)
                dgvLabs.DataSource = Results
            ElseIf CheckBox_2.Checked Then
                Reader = New SqlDataAdapter("Select * from viewLabs where SubNum = " & WarehouseShell.SubNum & " And LabSource = 'VRL Serology' order by LabName, LabDate", WarehouseShell.conn)
                Reader.Fill(Results)
                dgvLabs.DataSource = Results
            Else
                Reader = New SqlDataAdapter("Select * from viewLabs where SubNum = " & WarehouseShell.SubNum & " order by LabName, LabDate", WarehouseShell.conn)
                Reader.Fill(Results)
                dgvLabs.DataSource = Results
            End If
        End If
    End Sub

    Private Sub CheckBox_1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_1.CheckedChanged
        If CheckBox_1.CheckState = 1 Then
            CheckBox_2.CheckState = 0
            labSource = " And LabSource = 'NMS Toxicology'"
        End If
        If CheckBox_1.CheckState = 0 Then
            labSource = ""
        End If
        refreshDGV()
    End Sub

    Private Sub CheckBox_2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_2.CheckedChanged
        If CheckBox_2.CheckState = 1 Then
            CheckBox_1.CheckState = 0
            labSource = " And LabSource = 'VRL Serology'"
        End If
        If CheckBox_2.CheckState = 0 Then
            labSource = ""
        End If
        refreshDGV()
    End Sub
    Private Sub btnQuery_Click(sender As Object, e As EventArgs) Handles btnQuery.Click
        Dim builder As New SqlQueryBuilder(eqQuery)

        If builder.CanBuild Then
            builder.BuildSQL()
            query = builder.BuildSQL()
            Dim sql As String = builder.Result.SQL & "and SubNum = " & WarehouseShell.SubNum & labSource
            Results = New DataTable("Result")
            Try
                Reader = New SqlDataAdapter(sql, WarehouseShell.conn)
                Reader.Fill(Results)
                dgvLabs.DataSource = Results
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        pnlQuery.Query.Clear()
        query = False
        refreshForm()
    End Sub

    Private Sub btnAddLab_Click(sender As Object, e As EventArgs) Handles btnAddLab.Click
        If User.PermissionCheck("WA_PMCR_Vitals_And_Labs", "Modify") Then
            Dim pu As New PU_Labs_Add()
            pu.StartPosition = FormStartPosition.CenterScreen
            pu.ShowDialog()
            pu.Dispose()
            refreshForm()
            pnlQuery.Query.Clear()
        End If
    End Sub
    Private Sub btnEditLab_Click(sender As Object, e As EventArgs) Handles btnEditLab.Click
        If User.PermissionCheck("WA_PMCR_Vitals_And_Labs", "Modify") Then
            'Dim selectedRecord As Integer = dgvLabs.SelectedRows(0).Cells("RecordID").Value
            Dim pu As New PU_Labs_Add(dgvLabs.SelectedRows(0).Cells("RecordID").Value)
            pu.StartPosition = FormStartPosition.CenterScreen
            pu.ShowDialog()
            pu.Dispose()
            refreshForm()
            pnlQuery.Query.Clear()
        End If
    End Sub

    'CHEST XRAY/ECG STUFF
    Private Sub setDefaultValues()
        cmbChestXray.SelectedValue = -1
        cmbECG.SelectedValue = -1
    End Sub
    Private Sub loadExistingData()
        formTables.Tables.Add(Database.ReturnTable("PMCR_ChestXray_ECG",, "SubNum = " & WarehouseShell.SubNum))
        cmbChestXray.setValue(formTables, "PMCR_ChestXray_ECG", "XrayResult")
        dtChestXRay.setValue(formTables, "PMCR_ChestXray_ECG", "XrayDate")
        txtChestXray.setValue(formTables, "PMCR_ChestXray_ECG", "XrayNotes")
        cmbECG.setValue(formTables, "PMCR_ChestXray_ECG", "ECGResult")
        dtECG.setValue(formTables, "PMCR_ChestXray_ECG", "ECGDate")
        txtECG.setValue(formTables, "PMCR_ChestXray_ECG", "ECGNotes")
    End Sub
    Private Sub enableInputFields(ByVal bool As Boolean)
        cmbChestXray.Enabled = bool
        dtChestXRay.Enabled = bool
        txtChestXray.makeReadOnly(Not bool)
        cmbECG.Enabled = bool
        dtECG.Enabled = bool
        txtECG.makeReadOnly(Not bool)
    End Sub
    Private Function preSaveValidation() As Boolean
        Dim result As Boolean = True
        Dim errMsg As String = "The following errors must be corrected before Chest Xray / ECG can be saved:" & vbNewLine & vbNewLine
        If cmbChestXray.SelectedValue = 1 And txtChestXray.Text = "" Then
            errMsg += "- If Chest Xray is Abnormal, please describe abnormalities." & vbNewLine
            result = False
        End If
        If cmbECG.SelectedValue = 1 And txtECG.Text = "" Then
            errMsg += "- If ECG/EKG is Abnormal, please describe abnormalities." & vbNewLine
            result = False
        End If
        If dtChestXRay.Text <> "  /  /" And cmbChestXray.SelectedValue = -1 Then
            errMsg += "- If please select Normal or Abnormal for Chest Xray if providing an Xray date." & vbNewLine
            result = False
        End If
        If dtECG.Text <> "  /  /" And cmbECG.SelectedValue = -1 Then
            errMsg += "- If please select Normal or Abnormal for ECG/EKG if providing an ECG/EKG date." & vbNewLine
            result = False
        End If

        If result = False Then
            MsgBox(errMsg, MsgBoxStyle.OkOnly, "Error")
        End If
        Return result
    End Function
    Private Sub btnXray_Click(sender As Object, e As EventArgs) Handles btnXray.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            enableInputFields(True)
            btnXray.Text = "Save Changes"
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            enableInputFields(True)
            btnXray.Text = "Save Results"
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
        Else
            If preSaveValidation() Then
                Dim params As String = "@SubNum = " & WarehouseShell.SubNum &
                ", @XrayResult = " & cmbChestXray.getSQLValue() &
                ", @XrayDate = " & dtChestXRay.getSQLValue() &
                ", @XrayNotes = " & txtChestXray.getSQLValue() &
                ", @ECGResult = " & cmbECG.getSQLValue() &
                ", @ECGDate = " & dtECG.getSQLValue() &
                ", @ECGNotes = " & txtECG.getSQLValue() &
                ", @LastModBy = '" & WarehouseShell.userName & "';"
                Dim cmd As New SqlCommand("", WarehouseShell.conn)
                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    cmd.CommandText = "Exec modPMCR_ChestXray_ECGRecord @Action = 1, " & params
                Else
                    cmd.CommandText = "Exec modPMCR_ChestXray_ECGRecord @Action = 2, " & params
                End If
                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Save Successful")
                    enableInputFields(False)
                    btnXray.Text = "Edit Xray/ECG"
                    WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                Catch ex As SqlException
                    ExceptionHandler.CatchSQLException(ex)
                End Try
            End If
        End If
    End Sub

    Private Sub txtpH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpH.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) AndAlso Asc(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If
    End Sub


    'MISC LABS STUFF
    Private Sub btnApoEMod_Click(sender As Object, e As EventArgs) Handles btnApoEMod.Click
        If btnApoEMod.Text = "Modify" Then
            btnApoEMod.Text = "Save"
            cmbApoE.Enabled = True
            txtpH.Enabled = True
        Else
            Dim cmd As New SqlCommand("", WarehouseShell.conn)

            If Database.ExistingRecordCheck("LabsMisc", "SubNum = " & WarehouseShell.SubNum) Then
                cmd.CommandText = "Update LabsMisc set ApoE = " & cmbApoE.getSQLLabel() & ", PostmortempH = " & txtpH.getSQLValue() & " where SubNum = " & WarehouseShell.SubNum & ";"
            Else
                cmd.CommandText = "Insert into LabsMisc (SubNum, ApoEm, PostmortempH) values (" & WarehouseShell.SubNum & ", " & cmbApoE.getSQLLabel() & ", " & txtpH.getSQLValue() & ");"
            End If

            Try
                cmd.ExecuteNonQuery()
                btnApoEMod.Text = "Modify"
                cmbApoE.Enabled = False
                txtpH.Enabled = False
                MsgBox("Save successful.", MsgBoxStyle.OkOnly, "Success")
            Catch ex As SqlException
                ExceptionHandler.CatchSQLException(ex)
            End Try
        End If
    End Sub
    Private Sub loadExistingMiscData()
        formTables.Tables.Add(Database.ReturnTable("LabsMisc",, "SubNum = " & WarehouseShell.SubNum))
        cmbApoE.Text = (formTables.Tables("LabsMisc").Rows(0).Item("ApoE").ToString())
        txtpH.Text = (formTables.Tables("LabsMisc").Rows(0).Item("PostmortempH").ToString())
    End Sub

    Public Sub TopLevel(val As Boolean) Implements IFormMethods.TopLevel
        SetTopLevel(val)
    End Sub
    Private Sub IFormMethods_Parent(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Private Sub IFormMethods_Show() Implements IFormMethods.Show
        Show()
    End Sub
    Public Sub ShowPHI(val As Boolean) Implements IFormMethods.ShowPHI
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        btnXray.PerformClick()
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub


End Class