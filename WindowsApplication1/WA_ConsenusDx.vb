Public Class WA_ConsenusDx
    Implements IFormMethods
    Private formTables As New DataSet
    Private tooltip1 As New ToolTip
    Private PU As PU_ExistingDxSelect

    'Load form subs
    Private Sub WA_ConsensusDx_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WarehouseShell.highlightSelectedNode("WA_ConsensusDx")
        If Database.ExistingRecordCheck("ConsensusDx", "SubNum = " & WarehouseShell.SubNum) = True Then
            loadExistingData()
            btnConsensusDxBottom.Text = "Edit this record"
            btnConsensusDxTop.Text = btnConsensusDxBottom.Text
            WarehouseShell.DataMode = WarehouseShell.userDataMode.View
            enableInputFields(False)
        Else
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined
            btnConsensusDxBottom.Text = "Add New Record"
            btnConsensusDxTop.Text = btnConsensusDxBottom.Text
            enableInputFields(False)
            lblNoRecord.Visible = True
        End If
    End Sub
    Private Sub loadExistingData()
        'Grab the record for this SubNum
        formTables.Tables.Add(Database.ReturnTable("ConsensusDx", , "SubNum = " & WarehouseShell.SubNum))
        'Apply the existing values to the input fields
        txtDate.setValue(formTables, "ConsensusDx", "Date")
        txtChartPrimDX.Text = getDxCode(formTables.Tables("ConsensusDx").Rows(0).Item("ChartPrimDx").ToString)
        txtChartPrimDxNote.Text = getDxText(formTables.Tables("ConsensusDx").Rows(0).Item("ChartPrimDx").ToString)
        txtChartSecDX.Text = getDxCode(formTables.Tables("ConsensusDx").Rows(0).Item("ChartSecDx").ToString)
        txtChartSecDxNote.Text = getDxText(formTables.Tables("ConsensusDx").Rows(0).Item("ChartSecDx").ToString)
        txtChartTert1Dx.Text = getDxCode(formTables.Tables("ConsensusDx").Rows(0).Item("ChartTert1Dx").ToString)
        txtChartTert1DxNote.Text = getDxText(formTables.Tables("ConsensusDx").Rows(0).Item("ChartTert1Dx").ToString)
        txtChartTert2DX.Text = getDxCode(formTables.Tables("ConsensusDx").Rows(0).Item("ChartTert2Dx").ToString)
        txtChartTert2DxNote.Text = getDxText(formTables.Tables("ConsensusDx").Rows(0).Item("ChartTert2Dx").ToString)
        txtChartTert3Dx.Text = getDxCode(formTables.Tables("ConsensusDx").Rows(0).Item("ChartTert3Dx").ToString)
        txtChartTert3DxNote.Text = getDxText(formTables.Tables("ConsensusDx").Rows(0).Item("ChartTert3Dx").ToString)
        txtClinPrimDx.Text = getDxCode(formTables.Tables("ConsensusDx").Rows(0).Item("ClinPrimDx").ToString)
        txtClinPrimDxNote.Text = getDxText(formTables.Tables("ConsensusDx").Rows(0).Item("ClinPrimDx").ToString)
        txtClinSecDx.Text = getDxCode(formTables.Tables("ConsensusDx").Rows(0).Item("ClinSecDx").ToString)
        txtClinSecDxNote.Text = getDxText(formTables.Tables("ConsensusDx").Rows(0).Item("ClinSecDx").ToString)
        txtClinTert1Dx.Text = getDxCode(formTables.Tables("ConsensusDx").Rows(0).Item("ClinTert1Dx").ToString)
        txtClinTert1DxNote.Text = getDxText(formTables.Tables("ConsensusDx").Rows(0).Item("ClinTert1Dx").ToString)
        txtClinTert2Dx.Text = getDxCode(formTables.Tables("ConsensusDx").Rows(0).Item("ClinTert2Dx").ToString)
        txtClinTert2DxNote.Text = getDxText(formTables.Tables("ConsensusDx").Rows(0).Item("ClinTert2Dx").ToString)
        txtClinTert3Dx.Text = getDxCode(formTables.Tables("ConsensusDx").Rows(0).Item("ClinTert3Dx").ToString)
        txtClinTert3DxNote.Text = getDxText(formTables.Tables("ConsensusDx").Rows(0).Item("ClinTert3Dx").ToString)
        txtClinConPrimDx.Text = getDxCode(formTables.Tables("ConsensusDx").Rows(0).Item("ClinConPrimDx").ToString)
        txtClinConPrimDxNote.Text = getDxText(formTables.Tables("ConsensusDx").Rows(0).Item("ClinConPrimDx").ToString)
        txtClinConSecDx.Text = getDxCode(formTables.Tables("ConsensusDx").Rows(0).Item("ClinConSecDx").ToString)
        txtClinConSecDxNote.Text = getDxText(formTables.Tables("ConsensusDx").Rows(0).Item("ClinConSecDx").ToString)
        txtClinConTert1Dx.Text = getDxCode(formTables.Tables("ConsensusDx").Rows(0).Item("ClinConTert1Dx").ToString)
        txtClinConTert1DxNote.Text = getDxText(formTables.Tables("ConsensusDx").Rows(0).Item("ClinConTert1Dx").ToString)
        txtClinConTert2Dx.Text = getDxCode(formTables.Tables("ConsensusDx").Rows(0).Item("ClinConTert2Dx").ToString)
        txtClinConTert2DxNote.Text = getDxText(formTables.Tables("ConsensusDx").Rows(0).Item("ClinConTert2Dx").ToString)
        txtClinConTert3Dx.Text = getDxCode(formTables.Tables("ConsensusDx").Rows(0).Item("ClinConTert3Dx").ToString)
        txtClinConTert3DxNote.Text = getDxText(formTables.Tables("ConsensusDx").Rows(0).Item("ClinConTert3Dx").ToString)
        txtNeuroPrimDx.Text = getDxCode(formTables.Tables("ConsensusDx").Rows(0).Item("NeuroPrimDx").ToString)
        txtNeuroPrimDxNote.Text = getDxText(formTables.Tables("ConsensusDx").Rows(0).Item("NeuroPrimDx").ToString)
        txtNeuroSecDx.Text = getDxCode(formTables.Tables("ConsensusDx").Rows(0).Item("NeuroSecDx").ToString)
        txtNeuroSecDxNote.Text = getDxText(formTables.Tables("ConsensusDx").Rows(0).Item("NeuroSecDx").ToString)
        txtNeuroTert1Dx.Text = getDxCode(formTables.Tables("ConsensusDx").Rows(0).Item("NeuroTert1Dx").ToString)
        txtNeuroTert1DxNote.Text = getDxText(formTables.Tables("ConsensusDx").Rows(0).Item("NeuroTert1Dx").ToString)
        txtNeuroTert2Dx.Text = getDxCode(formTables.Tables("ConsensusDx").Rows(0).Item("NeuroTert2Dx").ToString)
        txtNeuroTert2DxNote.Text = getDxText(formTables.Tables("ConsensusDx").Rows(0).Item("NeuroTert2Dx").ToString)
        txtNeuroTert3Dx.Text = getDxCode(formTables.Tables("ConsensusDx").Rows(0).Item("NeuroTert3Dx").ToString)
        txtNeuroTert3DxNote.Text = getDxText(formTables.Tables("ConsensusDx").Rows(0).Item("NeuroTert3Dx").ToString)
        txtFinPrimDx.Text = getDxCode(formTables.Tables("ConsensusDx").Rows(0).Item("FinPrimDx").ToString)
        txtFinPrimDxNote.Text = getDxText(formTables.Tables("ConsensusDx").Rows(0).Item("FinPrimDx").ToString)
        txtFinSecDx.Text = getDxCode(formTables.Tables("ConsensusDx").Rows(0).Item("FinSecDx").ToString)
        txtFinSecDxNote.Text = getDxText(formTables.Tables("ConsensusDx").Rows(0).Item("FinSecDx").ToString)
        txtFinTert1Dx.Text = getDxCode(formTables.Tables("ConsensusDx").Rows(0).Item("FinTert1Dx").ToString)
        txtFinTert1DxNote.Text = getDxText(formTables.Tables("ConsensusDx").Rows(0).Item("FinTert1Dx").ToString)
        txtFinTert2Dx.Text = getDxCode(formTables.Tables("ConsensusDx").Rows(0).Item("FinTert2Dx").ToString)
        txtFinTert2DxNote.Text = getDxText(formTables.Tables("ConsensusDx").Rows(0).Item("FinTert2Dx").ToString)
        txtFinTert3Dx.Text = getDxCode(formTables.Tables("ConsensusDx").Rows(0).Item("FinTert3Dx").ToString)
        txtFinTert3DxNote.Text = getDxText(formTables.Tables("ConsensusDx").Rows(0).Item("FinTert3Dx").ToString)
        txtNBBPrimDx.Text = getDxCode(formTables.Tables("ConsensusDx").Rows(0).Item("NBBPrimDx").ToString)
        txtNBBPrimDxNote.Text = getDxText(formTables.Tables("ConsensusDx").Rows(0).Item("NBBPrimDx").ToString)
        txtNBBSecDx.Text = getDxCode(formTables.Tables("ConsensusDx").Rows(0).Item("NBBSecDx").ToString)
        txtNBBSecDxNote.Text = getDxText(formTables.Tables("ConsensusDx").Rows(0).Item("NBBSecDx").ToString)
        txtNBBTert1Dx.Text = getDxCode(formTables.Tables("ConsensusDx").Rows(0).Item("NBBTert1Dx").ToString)
        txtNBBTert1DxNote.Text = getDxText(formTables.Tables("ConsensusDx").Rows(0).Item("NBBTert1Dx").ToString)
        txtNBBTert2Dx.Text = getDxCode(formTables.Tables("ConsensusDx").Rows(0).Item("NBBTert2Dx").ToString)
        txtNBBTert2DxNote.Text = getDxText(formTables.Tables("ConsensusDx").Rows(0).Item("NBBTert2Dx").ToString)
        txtNBBTert3Dx.Text = getDxCode(formTables.Tables("ConsensusDx").Rows(0).Item("NBBTert3Dx").ToString)
        txtNBBTert3DxNote.Text = getDxText(formTables.Tables("ConsensusDx").Rows(0).Item("NBBTert3Dx").ToString)
    End Sub
    Private Function getDxCode(ByVal recordID As String) As String
        Dim result As String = ""
        If recordID <> "" Then
            Dim table As DataTable = Database.ReturnTable("viewDiagnoses", "DxCode", "RecordID = " & recordID)
            result += table.Rows(0).Item("DxCode").ToString
        End If
        Return Result
    End Function
    Private Function getDxText(ByVal recordID As String) As String
        Dim result As String = ""
        If recordID <> "" Then
            Dim table As DataTable = Database.ReturnTable("viewDiagnoses", "DX", "RecordID = " & recordID)
            result += table.Rows(0).Item("Dx").ToString
        End If
        Return result
    End Function
    Private Sub setBaseTable()
        Dim ConsensusDx As DataTable = New DataTable("ConsensusDx")
        ConsensusDx.Columns.Add("ChartPrimDx", GetType(Integer))
        ConsensusDx.Columns.Add("ChartSecDx", GetType(Integer))
        ConsensusDx.Columns.Add("ChartTert1Dx", GetType(Integer))
        ConsensusDx.Columns.Add("ChartTert2Dx", GetType(Integer))
        ConsensusDx.Columns.Add("ChartTert3Dx", GetType(Integer))
        ConsensusDx.Columns.Add("ClinPrimDx", GetType(Integer))
        ConsensusDx.Columns.Add("ClinSecDx", GetType(Integer))
        ConsensusDx.Columns.Add("ClinTert1Dx", GetType(Integer))
        ConsensusDx.Columns.Add("ClinTert2Dx", GetType(Integer))
        ConsensusDx.Columns.Add("ClinTert3Dx", GetType(Integer))
        ConsensusDx.Columns.Add("ClinConPrimDx", GetType(Integer))
        ConsensusDx.Columns.Add("ClinConSecDx", GetType(Integer))
        ConsensusDx.Columns.Add("ClinConTert1Dx", GetType(Integer))
        ConsensusDx.Columns.Add("ClinConTert2Dx", GetType(Integer))
        ConsensusDx.Columns.Add("ClinConTert3Dx", GetType(Integer))
        ConsensusDx.Columns.Add("NeuroPrimDx", GetType(Integer))
        ConsensusDx.Columns.Add("NeuroSecDx", GetType(Integer))
        ConsensusDx.Columns.Add("NeuroTert1Dx", GetType(Integer))
        ConsensusDx.Columns.Add("NeuroTert2Dx", GetType(Integer))
        ConsensusDx.Columns.Add("NeuroTert3Dx", GetType(Integer))
        ConsensusDx.Columns.Add("FinPrimDx", GetType(Integer))
        ConsensusDx.Columns.Add("FinSecDx", GetType(Integer))
        ConsensusDx.Columns.Add("FinTert1Dx", GetType(Integer))
        ConsensusDx.Columns.Add("FinTert2Dx", GetType(Integer))
        ConsensusDx.Columns.Add("FinTert3Dx", GetType(Integer))
        ConsensusDx.Columns.Add("NBBPrimDx", GetType(Integer))
        ConsensusDx.Columns.Add("NBBSecDx", GetType(Integer))
        ConsensusDx.Columns.Add("NBBTert1Dx", GetType(Integer))
        ConsensusDx.Columns.Add("NBBTert2Dx", GetType(Integer))
        ConsensusDx.Columns.Add("NBBTert3Dx", GetType(Integer))
        ConsensusDx.Rows.Add(DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value)
        formTables.Tables.Add(ConsensusDx)
    End Sub

    'Subs to enable-disable fields during data input based on conditional logic.
    Private Sub enableInputFields(ByVal value As Boolean)
        If value = True Then
            txtDate.Enabled = True
            ChartPrimDx.Enabled = True
            ChartPrimDXRemove.Enabled = IIf(txtChartPrimDX.Text <> "", True, False)
            ChartSecDx.Enabled = True
            ChartSecDXRemove.Enabled = IIf(txtChartSecDX.Text <> "", True, False)
            ChartTert1Dx.Enabled = True
            ChartTert1DxRemove.Enabled = IIf(txtChartTert1Dx.Text <> "", True, False)
            ChartTert2Dx.Enabled = True
            ChartTert2DxRemove.Enabled = IIf(txtChartTert2Dx.Text <> "", True, False)
            ChartTert3Dx.Enabled = True
            ChartTert3DxRemove.Enabled = IIf(txtChartTert3Dx.Text <> "", True, False)
            ClinPrimDx.Enabled = True
            ClinPrimDxRemove.Enabled = IIf(txtClinPrimDx.Text <> "", True, False)
            ClinSecDx.Enabled = True
            ClinSecDxRemove.Enabled = IIf(txtClinSecDx.Text <> "", True, False)
            ClinTert1Dx.Enabled = True
            ClinTert1DxRemove.Enabled = IIf(txtClinTert1Dx.Text <> "", True, False)
            ClinTert2Dx.Enabled = True
            ClinTert2DxRemove.Enabled = IIf(txtClinTert2Dx.Text <> "", True, False)
            ClinTert3Dx.Enabled = True
            ClinTert3DxRemove.Enabled = IIf(txtClinTert3Dx.Text <> "", True, False)
            ClinConPrimDx.Enabled = True
            ClinConPrimDxRemove.Enabled = IIf(txtClinConPrimDx.Text <> "", True, False)
            ClinConSecDx.Enabled = True
            ClinConSecDxRemove.Enabled = IIf(txtClinConSecDx.Text <> "", True, False)
            ClinConTert1Dx.Enabled = True
            ClinConTert1DxRemove.Enabled = IIf(txtClinConTert1Dx.Text <> "", True, False)
            ClinConTert2Dx.Enabled = True
            ClinConTert2DxRemove.Enabled = IIf(txtClinConTert2Dx.Text <> "", True, False)
            ClinConTert3Dx.Enabled = True
            ClinConTert3DxRemove.Enabled = IIf(txtClinConTert3Dx.Text <> "", True, False)
            NeuroPrimDx.Enabled = True
            NeuroPrimDxRemove.Enabled = IIf(txtNeuroPrimDx.Text <> "", True, False)
            NeuroSecDx.Enabled = True
            NeuroSecDxRemove.Enabled = IIf(txtNeuroSecDx.Text <> "", True, False)
            NeuroTert1Dx.Enabled = True
            NeuroTert1DxRemove.Enabled = IIf(txtNeuroTert1Dx.Text <> "", True, False)
            NeuroTert2Dx.Enabled = True
            NeuroTert2DxRemove.Enabled = IIf(txtNeuroTert2Dx.Text <> "", True, False)
            NeuroTert3Dx.Enabled = True
            NeuroTert3DxRemove.Enabled = IIf(txtNeuroTert3Dx.Text <> "", True, False)
            FinPrimDx.Enabled = True
            If txtFinPrimDx.Text <> "" Then
                cmbDxBasis.Enabled = True
                chkPrimPsych1.Enabled = True
                chkPrimNeuro1.Enabled = True
                FinPrimDxRemove.Enabled = True
            Else
                cmbDxBasis.Enabled = False
                chkPrimPsych1.Enabled = False
                chkPrimPsych1.Checked = False
                chkPrimNeuro1.Enabled = False
                chkPrimNeuro1.Checked = False
                FinPrimDxRemove.Enabled = False
            End If
            FinSecDx.Enabled = True
            If txtFinSecDx.Text <> "" Then
                cmbDxBasis.Enabled = True
                chkPrimPsych2.Enabled = True
                chkPrimNeuro2.Enabled = True
                FinSecDxRemove.Enabled = True
            Else
                chkPrimPsych2.Enabled = False
                chkPrimPsych2.Checked = False
                chkPrimNeuro2.Enabled = False
                chkPrimNeuro2.Checked = False
                FinSecDxRemove.Enabled = False
            End If
            FinTert1Dx.Enabled = True
            If txtFinTert1Dx.Text <> "" Then
                chkPrimPsych3.Enabled = True
                chkPrimNeuro3.Enabled = True
                FinTert1DxRemove.Enabled = True
            Else
                chkPrimPsych3.Enabled = False
                chkPrimPsych3.Checked = False
                chkPrimNeuro3.Enabled = False
                chkPrimNeuro3.Checked = False
                FinTert1DxRemove.Enabled = False
            End If
            FinTert2Dx.Enabled = True
            If txtFinTert2Dx.Text <> "" Then
                chkPrimPsych4.Enabled = True
                chkPrimNeuro4.Enabled = True
                FinTert2DxRemove.Enabled = True
            Else
                chkPrimPsych4.Enabled = False
                chkPrimPsych4.Checked = False
                chkPrimNeuro4.Enabled = False
                chkPrimNeuro4.Checked = False
                FinTert2DxRemove.Enabled = False
            End If
            FinTert3Dx.Enabled = True
            If txtFinTert3Dx.Text <> "" Then
                chkPrimPsych4.Enabled = True
                chkPrimNeuro4.Enabled = True
                FinTert3DxRemove.Enabled = True
            Else
                chkPrimPsych4.Enabled = False
                chkPrimPsych4.Checked = False
                chkPrimNeuro4.Enabled = False
                chkPrimNeuro4.Checked = False
                FinTert3DxRemove.Enabled = False
            End If
            NBBPrimDx.Enabled = True
            NBBPrimDxRemove.Enabled = IIf(txtNBBPrimDx.Text <> "", True, False)
            NBBSecDx.Enabled = True
            NBBSecDxRemove.Enabled = IIf(txtNBBSecDx.Text <> "", True, False)
            NBBTert1Dx.Enabled = True
            NBBTert1DxRemove.Enabled = IIf(txtNBBTert1Dx.Text <> "", True, False)
            NBBTert2Dx.Enabled = True
            NBBTert2DxRemove.Enabled = IIf(txtNBBTert2Dx.Text <> "", True, False)
            NBBTert3Dx.Enabled = True
            NBBTert3DxRemove.Enabled = IIf(txtNBBTert3Dx.Text <> "", True, False)
        Else
            txtDate.Enabled = False
            ChartPrimDx.Enabled = False
            ChartPrimDXRemove.Enabled = False
            ChartSecDx.Enabled = False
            ChartSecDXRemove.Enabled = False
            ChartTert1Dx.Enabled = False
            ChartTert1DxRemove.Enabled = False
            ChartTert2Dx.Enabled = False
            ChartTert2DxRemove.Enabled = False
            ChartTert3Dx.Enabled = False
            ChartTert3DxRemove.Enabled = False
            ClinPrimDx.Enabled = False
            ClinPrimDxRemove.Enabled = False
            ClinSecDx.Enabled = False
            ClinSecDxRemove.Enabled = False
            ClinTert1Dx.Enabled = False
            ClinTert1DxRemove.Enabled = False
            ClinTert2Dx.Enabled = False
            ClinTert2DxRemove.Enabled = False
            ClinTert3Dx.Enabled = False
            ClinTert3DxRemove.Enabled = False
            ClinConPrimDx.Enabled = False
            ClinConPrimDxRemove.Enabled = False
            ClinConSecDx.Enabled = False
            ClinConSecDxRemove.Enabled = False
            ClinConTert1Dx.Enabled = False
            ClinConTert1DxRemove.Enabled = False
            ClinConTert2Dx.Enabled = False
            ClinConTert2DxRemove.Enabled = False
            ClinConTert3Dx.Enabled = False
            ClinConTert3DxRemove.Enabled = False
            NeuroPrimDx.Enabled = False
            NeuroPrimDxRemove.Enabled = False
            NeuroSecDx.Enabled = False
            NeuroSecDxRemove.Enabled = False
            NeuroTert1Dx.Enabled = False
            NeuroTert1DxRemove.Enabled = False
            NeuroTert2Dx.Enabled = False
            NeuroTert2DxRemove.Enabled = False
            NeuroTert3Dx.Enabled = False
            NeuroTert3DxRemove.Enabled = False
            FinPrimDx.Enabled = False
            FinPrimDxRemove.Enabled = False
            cmbDxBasis.Enabled = False
            chkPrimPsych1.Enabled = False
            chkPrimNeuro1.Enabled = False
            FinSecDx.Enabled = False
            FinSecDxRemove.Enabled = False
            chkPrimPsych2.Enabled = False
            chkPrimNeuro2.Enabled = False
            FinTert1Dx.Enabled = False
            FinTert1DxRemove.Enabled = False
            chkPrimPsych3.Enabled = False
            chkPrimNeuro3.Enabled = False
            FinTert2Dx.Enabled = False
            FinTert2DxRemove.Enabled = False
            chkPrimPsych4.Enabled = False
            chkPrimNeuro4.Enabled = False
            FinTert3Dx.Enabled = False
            FinTert3DxRemove.Enabled = False
            chkPrimPsych5.Enabled = False
            chkPrimNeuro5.Enabled = False
            NBBPrimDx.Enabled = False
            NBBPrimDxRemove.Enabled = False
            NBBSecDx.Enabled = False
            NBBSecDxRemove.Enabled = False
            NBBTert1Dx.Enabled = False
            NBBTert1DxRemove.Enabled = False
            NBBTert2Dx.Enabled = False
            NBBTert2DxRemove.Enabled = False
            NBBTert3Dx.Enabled = False
            NBBTert3DxRemove.Enabled = False
        End If
    End Sub
    Private Sub txtFinPrimDx_TextChanged(sender As Object, e As EventArgs) Handles txtFinPrimDx.TextChanged
        If txtFinPrimDx.Text = "" Then
            cmbDxBasis.Enabled = False
            chkPrimPsych1.Checked = False
            chkPrimPsych1.Enabled = False
            chkPrimNeuro1.Checked = False
            chkPrimNeuro1.Enabled = False
        Else
            cmbDxBasis.Enabled = True
            chkPrimPsych1.Enabled = True
            chkPrimNeuro1.Enabled = True
        End If
    End Sub
    Private Sub txtFinSecDx_TextChanged(sender As Object, e As EventArgs) Handles txtFinSecDx.TextChanged
        If txtFinSecDx.Text = "" Then
            chkPrimPsych2.Checked = False
            chkPrimPsych2.Enabled = False
            chkPrimNeuro2.Checked = False
            chkPrimNeuro2.Enabled = False
        Else
            chkPrimPsych2.Enabled = True
            chkPrimNeuro2.Enabled = True
        End If
    End Sub
    Private Sub txtFinTertDx1_TextChanged(sender As Object, e As EventArgs) Handles txtFinTert1Dx.TextChanged
        If txtFinTert1Dx.Text = "" Then
            chkPrimPsych3.Checked = False
            chkPrimPsych3.Enabled = False
            chkPrimNeuro3.Checked = False
            chkPrimNeuro3.Enabled = False
        Else
            chkPrimPsych3.Enabled = True
            chkPrimNeuro3.Enabled = True
        End If
    End Sub
    Private Sub txtFinTertDx2_TextChanged(sender As Object, e As EventArgs) Handles txtFinTert2Dx.TextChanged
        If txtFinTert2Dx.Text = "" Then
            chkPrimPsych4.Checked = False
            chkPrimPsych4.Enabled = False
            chkPrimNeuro4.Checked = False
            chkPrimNeuro4.Enabled = False
        Else
            chkPrimPsych4.Enabled = True
            chkPrimNeuro4.Enabled = True
        End If
    End Sub
    Private Sub txtFinTertDx3_TextChanged(sender As Object, e As EventArgs) Handles txtFinTert3Dx.TextChanged
        If txtFinTert3Dx.Text = "" Then
            chkPrimPsych5.Checked = False
            chkPrimPsych5.Enabled = False
            chkPrimNeuro5.Checked = False
            chkPrimNeuro5.Enabled = False
        Else
            chkPrimPsych5.Enabled = True
            chkPrimNeuro5.Enabled = True
        End If
    End Sub
    Private Sub chkPrimPsych1_CheckedChanged(sender As Object, e As EventArgs) Handles chkPrimPsych1.CheckedChanged
        If chkPrimPsych1.Checked = True Then
            chkPrimPsych2.Checked = False
            chkPrimPsych3.Checked = False
            chkPrimPsych4.Checked = False
            chkPrimPsych5.Checked = False
        End If
    End Sub
    Private Sub chkPrimPsych2_CheckedChanged(sender As Object, e As EventArgs) Handles chkPrimPsych2.CheckedChanged
        If chkPrimPsych2.Checked = True Then
            chkPrimPsych1.Checked = False
            chkPrimPsych3.Checked = False
            chkPrimPsych4.Checked = False
            chkPrimPsych5.Checked = False
        End If
    End Sub
    Private Sub chkPrimPsych3_CheckedChanged(sender As Object, e As EventArgs) Handles chkPrimPsych3.CheckedChanged
        If chkPrimPsych3.Checked = True Then
            chkPrimPsych1.Checked = False
            chkPrimPsych2.Checked = False
            chkPrimPsych4.Checked = False
            chkPrimPsych5.Checked = False
        End If
    End Sub
    Private Sub chkPrimPsych4_CheckedChanged(sender As Object, e As EventArgs) Handles chkPrimPsych4.CheckedChanged
        If chkPrimPsych4.Checked = True Then
            chkPrimPsych1.Checked = False
            chkPrimPsych2.Checked = False
            chkPrimPsych3.Checked = False
            chkPrimPsych5.Checked = False
        End If
    End Sub
    Private Sub chkPrimPsych5_CheckedChanged(sender As Object, e As EventArgs) Handles chkPrimPsych5.CheckedChanged
        If chkPrimPsych5.Checked = True Then
            chkPrimPsych1.Checked = False
            chkPrimPsych2.Checked = False
            chkPrimPsych3.Checked = False
            chkPrimPsych4.Checked = False
        End If
    End Sub
    Private Sub chkPrimNeuro1_CheckedChanged(sender As Object, e As EventArgs) Handles chkPrimNeuro1.CheckedChanged
        If chkPrimNeuro1.Checked = True Then
            chkPrimNeuro2.Checked = False
            chkPrimNeuro3.Checked = False
            chkPrimNeuro4.Checked = False
            chkPrimNeuro5.Checked = False
        End If
    End Sub
    Private Sub chkPrimNeuro2_CheckedChanged(sender As Object, e As EventArgs) Handles chkPrimNeuro2.CheckedChanged
        If chkPrimNeuro2.Checked = True Then
            chkPrimNeuro1.Checked = False
            chkPrimNeuro3.Checked = False
            chkPrimNeuro4.Checked = False
            chkPrimNeuro5.Checked = False
        End If
    End Sub
    Private Sub chkPrimNeuro3_CheckedChanged(sender As Object, e As EventArgs) Handles chkPrimNeuro3.CheckedChanged
        If chkPrimNeuro3.Checked = True Then
            chkPrimNeuro1.Checked = False
            chkPrimNeuro2.Checked = False
            chkPrimNeuro4.Checked = False
            chkPrimNeuro5.Checked = False
        End If
    End Sub
    Private Sub chkPrimNeuro4_CheckedChanged(sender As Object, e As EventArgs) Handles chkPrimNeuro4.CheckedChanged
        If chkPrimNeuro4.Checked = True Then
            chkPrimNeuro1.Checked = False
            chkPrimNeuro2.Checked = False
            chkPrimNeuro3.Checked = False
            chkPrimNeuro5.Checked = False
        End If
    End Sub
    Private Sub chkPrimNeuro5_CheckedChanged(sender As Object, e As EventArgs) Handles chkPrimNeuro5.CheckedChanged
        If chkPrimNeuro5.Checked = True Then
            chkPrimNeuro1.Checked = False
            chkPrimNeuro2.Checked = False
            chkPrimNeuro3.Checked = False
            chkPrimNeuro4.Checked = False
        End If
    End Sub

    'Helper sub to manage saving Primary Neuro and Psych Dx's
    Private Sub setPrimNeuroPsychValues()
        Dim SQLCommand As New SqlCommand
        SQLCommand.Connection = WarehouseShell.conn
        Dim CmdString = ""
        Dim checkCount As Integer = 0 +
            IIf(chkPrimPsych1.Checked, 1, 0) +
            IIf(chkPrimPsych2.Checked, 1, 0) +
            IIf(chkPrimPsych3.Checked, 1, 0) +
            IIf(chkPrimPsych4.Checked, 1, 0) +
            IIf(chkPrimPsych5.Checked, 1, 0) +
            IIf(chkPrimNeuro1.Checked, 1, 0) +
            IIf(chkPrimNeuro2.Checked, 1, 0) +
            IIf(chkPrimNeuro3.Checked, 1, 0) +
            IIf(chkPrimNeuro4.Checked, 1, 0) +
            IIf(chkPrimNeuro5.Checked, 1, 0)
        'Create appropriate SQL command string
        If checkCount > 0 Then
            If Database.ExistingRecordCheck("DiagnosesHeader", "SubNum = " & WarehouseShell.SubNum) Then
                If chkPrimPsych1.Checked Then
                    CmdString = "Update DiagnosesHeader set PrimPsychDxICD = " & txtFinPrimDx.getSQLValue() & ", PrimPsychDxText = " & txtFinPrimDxNote.getSQLValue() & " where SubNum = " & WarehouseShell.SubNum & ";"
                ElseIf chkPrimPsych2.Checked Then
                    CmdString = "Update DiagnosesHeader set PrimPsychDxICD = " & txtFinSecDx.getSQLValue() & ", PrimPsychDxText = " & txtFinSecDx.getSQLValue() & " where SubNum = " & WarehouseShell.SubNum & ";"
                ElseIf chkPrimPsych3.Checked Then
                    CmdString = "Update DiagnosesHeader set PrimPsychDxICD = " & txtFinTert1Dx.getSQLValue() & ", PrimPsychDxText = " & txtFinTert1DxNote.getSQLValue() & " where SubNum = " & WarehouseShell.SubNum & ";"
                ElseIf chkPrimPsych4.Checked Then
                    CmdString = "Update DiagnosesHeader set PrimPsychDxICD = " & txtFinTert2Dx.getSQLValue() & ", PrimPsychDxText = " & txtFinTert2DxNote.getSQLValue() & " where SubNum = " & WarehouseShell.SubNum & ";"
                ElseIf chkPrimPsych5.Checked Then
                    CmdString = "Update DiagnosesHeader set PrimPsychDxICD = " & txtFinTert3Dx.getSQLValue() & ", PrimPsychDxText = " & txtFinTert3DxNote.getSQLValue() & " where SubNum = " & WarehouseShell.SubNum & ";"
                Else
                    CmdString = "Update DiagnosesHeader set PrimPsychDxICD = NULL, PrimPsychDxText = NULL where SubNum = " & WarehouseShell.SubNum & ";"
                End If
            Else
                If chkPrimPsych1.Checked Then
                    CmdString = "Insert into DiagnosesHeader(SubNum, PrimPsychDxICD, PrimPsychDxText) values (" & WarehouseShell.SubNum & ", " & txtFinPrimDx.getSQLValue() & ", " & txtFinPrimDxNote.getSQLValue() & ");"
                ElseIf chkPrimPsych2.Checked Then
                    CmdString = "Insert into DiagnosesHeader(SubNum, PrimPsychDxICD, PrimPsychDxText) values (" & WarehouseShell.SubNum & ", " & txtFinSecDx.getSQLValue() & ", " & txtFinSecDxNote.getSQLValue() & ");"
                ElseIf chkPrimPsych3.Checked Then
                    CmdString = "Insert into DiagnosesHeader(SubNum, PrimPsychDxICD, PrimPsychDxText) values (" & WarehouseShell.SubNum & ", " & txtFinTert1Dx.getSQLValue() & ", " & txtFinTert1DxNote.getSQLValue() & ");"
                ElseIf chkPrimPsych4.Checked Then
                    CmdString = "Insert into DiagnosesHeader(SubNum, PrimPsychDxICD, PrimPsychDxText) values (" & WarehouseShell.SubNum & ", " & txtFinTert2Dx.getSQLValue() & ", " & txtFinTert2DxNote.getSQLValue() & ");"
                ElseIf chkPrimPsych5.Checked Then
                    CmdString = "Insert into DiagnosesHeader(SubNum, PrimPsychDxICD, PrimPsychDxText) values (" & WarehouseShell.SubNum & ", " & txtFinTert3Dx.getSQLValue() & ", " & txtFinTert3DxNote.getSQLValue() & ");"
                Else
                    CmdString = "Insert into DiagnosesHeader(SubNum) values (" & WarehouseShell.SubNum & ");"
                End If
            End If
            'Execute the SQLCommand using the CmdString
            SQLCommand.CommandText = CmdString
            SQLCommand.ExecuteNonQuery()

            'Previous block created DiagnosesHeader if none existed, so no need to check
            If chkPrimNeuro1.Checked Then
                CmdString = "Update DiagnosesHeader set PrimNeuroDxICD = " & txtFinPrimDx.getSQLValue() & ", PrimNeuroDxText = " & txtFinPrimDxNote.getSQLValue() & " where SubNum = " & WarehouseShell.SubNum & ";"
            ElseIf chkPrimNeuro2.Checked Then
                CmdString = "Update DiagnosesHeader set PrimNeuroDxICD = " & txtFinSecDx.getSQLValue() & ", PrimNeuroDxText = " & txtFinSecDxNote.getSQLValue() & " where SubNum = " & WarehouseShell.SubNum & ";"
            ElseIf chkPrimNeuro3.Checked Then
                CmdString = "Update DiagnosesHeader set PrimNeuroDxICD = " & txtFinTert1Dx.getSQLValue() & ", PrimNeuroDxText = " & txtFinTert1DxNote.getSQLValue() & " where SubNum = " & WarehouseShell.SubNum & ";"
            ElseIf chkPrimNeuro4.Checked Then
                CmdString = "Update DiagnosesHeader set PrimNeuroDxICD = " & txtFinTert2Dx.getSQLValue() & ", PrimNeuroDxText = " & txtFinTert2DxNote.getSQLValue() & " where SubNum = " & WarehouseShell.SubNum & ";"
            ElseIf chkPrimNeuro5.Checked Then
                CmdString = "Update DiagnosesHeader set PrimNeuroDxICD = " & txtFinTert3Dx.getSQLValue() & ", PrimNeuroDxText = " & txtFinTert3DxNote.getSQLValue() & " where SubNum = " & WarehouseShell.SubNum & ";"
            Else
                CmdString = "Update DiagnosesHeader set PrimNeuroDxICD = NULL, PrimNeuroDxText = NULL where SubNum = " & WarehouseShell.SubNum & ";"
            End If
            'Execute the SQLCommand using the CmdString
            SQLCommand.CommandText = CmdString
            SQLCommand.ExecuteNonQuery()
        Else
            'If there is no Prim Psych or Neuro Dx, there cannot be any relatives with similar Dx, so delete from that table
            CmdString = "Delete from Subject_RelWithSimDx where SubNum = " & WarehouseShell.SubNum & ";"
            SQLCommand.CommandText = CmdString
            SQLCommand.ExecuteNonQuery()
        End If
    End Sub

    'Define button click events
    Private Function preSaveValidation() As Boolean
        Dim result As Boolean = True
        Return result
    End Function
    Private Sub btnConsensusDx_Click(sender As Object, e As EventArgs) Handles btnConsensusDxBottom.Click, btnConsensusDxTop.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            If User.PermissionCheck("WA_ConsensusDx", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
                enableInputFields(True)
                btnConsensusDxBottom.Text = "Save changes"
                btnConsensusDxTop.Text = btnConsensusDxBottom.Text
            End If
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Undefined Then
            If User.PermissionCheck("WA_ConsensusDx", "Modify") Then
                WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
                setBaseTable()
                enableInputFields(True)
                btnConsensusDxBottom.Text = "Save new record"
                btnConsensusDxTop.Text = btnConsensusDxBottom.Text
                lblNoRecord.Visible = False
            End If
        Else
            If preSaveValidation() Then
                Dim sqlCommand As New SqlCommand
                sqlCommand.Connection = WarehouseShell.conn
                Dim parameters = ", @Date = " & txtDate.getSQLValue() &
                    ", @ChartPrimDx = " & getValue(formTables.Tables("ConsensusDx").Rows(0).Item("ChartPrimDx").ToString) &
                    ", @ChartSecDx = " & getValue(formTables.Tables("ConsensusDx").Rows(0).Item("ChartSecDx").ToString) &
                    ", @ChartTert1Dx = " & getValue(formTables.Tables("ConsensusDx").Rows(0).Item("ChartTert1Dx").ToString) &
                    ", @ChartTert2Dx = " & getValue(formTables.Tables("ConsensusDx").Rows(0).Item("ChartTert2Dx").ToString) &
                    ", @ChartTert3Dx = " & getValue(formTables.Tables("ConsensusDx").Rows(0).Item("ChartTert3Dx").ToString) &
                    ", @ClinPrimDx = " & getValue(formTables.Tables("ConsensusDx").Rows(0).Item("ClinPrimDx").ToString) &
                    ", @ClinSecDx = " & getValue(formTables.Tables("ConsensusDx").Rows(0).Item("ClinSecDx").ToString) &
                    ", @ClinTert1Dx = " & getValue(formTables.Tables("ConsensusDx").Rows(0).Item("ClinTert1Dx").ToString) &
                    ", @ClinTert2Dx = " & getValue(formTables.Tables("ConsensusDx").Rows(0).Item("ClinTert2Dx").ToString) &
                    ", @ClinTert3Dx = " & getValue(formTables.Tables("ConsensusDx").Rows(0).Item("ClinTert3Dx").ToString) &
                    ", @ClinConPrimDx = " & getValue(formTables.Tables("ConsensusDx").Rows(0).Item("ClinConPrimDx").ToString) &
                    ", @ClinConSecDx = " & getValue(formTables.Tables("ConsensusDx").Rows(0).Item("ClinConSecDx").ToString) &
                    ", @ClinConTert1Dx = " & getValue(formTables.Tables("ConsensusDx").Rows(0).Item("ClinConTert1Dx").ToString) &
                    ", @ClinConTert2Dx = " & getValue(formTables.Tables("ConsensusDx").Rows(0).Item("ClinConTert2Dx").ToString) &
                    ", @ClinConTert3Dx = " & getValue(formTables.Tables("ConsensusDx").Rows(0).Item("ClinConTert3Dx").ToString) &
                    ", @NeuroPrimDx = " & getValue(formTables.Tables("ConsensusDx").Rows(0).Item("NeuroPrimDx").ToString) &
                    ", @NeuroSecDx = " & getValue(formTables.Tables("ConsensusDx").Rows(0).Item("NeuroSecDx").ToString) &
                    ", @NeuroTert1Dx = " & getValue(formTables.Tables("ConsensusDx").Rows(0).Item("NeuroTert1Dx").ToString) &
                    ", @NeuroTert2Dx = " & getValue(formTables.Tables("ConsensusDx").Rows(0).Item("NeuroTert2Dx").ToString) &
                    ", @NeuroTert3Dx = " & getValue(formTables.Tables("ConsensusDx").Rows(0).Item("NeuroTert3Dx").ToString) &
                    ", @FinPrimDx = " & getValue(formTables.Tables("ConsensusDx").Rows(0).Item("FinPrimDx").ToString) &
                    ", @FinPrimBasis = " & IIf(cmbDxBasis.Text.ToString() = "", "null", "'" & cmbDxBasis.Text & "'") &
                    ", @FinPrimPsych = " & chkPrimPsych1.getSQLValue() &
                    ", @FinPrimNeuro = " & chkPrimNeuro1.getSQLValue() &
                    ", @FinSecDx = " & getValue(formTables.Tables("ConsensusDx").Rows(0).Item("FinSecDx").ToString) &
                    ", @FinSecPsych = " & chkPrimPsych2.getSQLValue() &
                    ", @FinSecNeuro = " & chkPrimNeuro2.getSQLValue() &
                    ", @FinTert1Dx = " & getValue(formTables.Tables("ConsensusDx").Rows(0).Item("FinTert1Dx").ToString) &
                    ", @FinTert1Psych = " & chkPrimPsych3.getSQLValue() &
                    ", @FinTert1Neuro = " & chkPrimNeuro3.getSQLValue() &
                    ", @FinTert2Dx = " & getValue(formTables.Tables("ConsensusDx").Rows(0).Item("FinTert2Dx").ToString) &
                    ", @FinTert2Psych = " & chkPrimPsych4.getSQLValue() &
                    ", @FinTert2Neuro = " & chkPrimNeuro4.getSQLValue() &
                    ", @FinTert3Dx = " & getValue(formTables.Tables("ConsensusDx").Rows(0).Item("FinTert3Dx").ToString) &
                    ", @FinTert3Psych = " & chkPrimPsych5.getSQLValue() &
                    ", @FinTert3Neuro = " & chkPrimNeuro5.getSQLValue() &
                    ", @NBBPrimDx = " & getValue(formTables.Tables("ConsensusDx").Rows(0).Item("NBBPrimDx").ToString) &
                    ", @NBBSecDx = " & getValue(formTables.Tables("ConsensusDx").Rows(0).Item("NBBSecDx").ToString) &
                    ", @NBBTert1Dx = " & getValue(formTables.Tables("ConsensusDx").Rows(0).Item("NBBTert1Dx").ToString) &
                    ", @NBBTert2Dx = " & getValue(formTables.Tables("ConsensusDx").Rows(0).Item("NBBTert2Dx").ToString) &
                    ", @NBBTert3Dx = " & getValue(formTables.Tables("ConsensusDx").Rows(0).Item("NBBTert3Dx").ToString) &
                    ", @LastModBy = '" & WarehouseShell.userName & "';"

                If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
                    'TODO: build data table
                    sqlCommand.CommandText = "EXEC dbo.modConsensusDxRecord @Action = 1, @SubNum = " & WarehouseShell.SubNum & parameters
                    Try
                        sqlCommand.ExecuteNonQuery()
                        setPrimNeuroPsychValues()
                        MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        enableInputFields(False)
                        btnConsensusDxBottom.Text = "Edit this record"
                        btnConsensusDxTop.Text = btnConsensusDxBottom.Text
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                Else
                    sqlCommand.CommandText = "EXEC dbo.modConsensusDxRecord @Action = 2, @SubNum = " & WarehouseShell.SubNum & parameters
                    Try
                        sqlCommand.ExecuteNonQuery()
                        setPrimNeuroPsychValues()
                        MessageBox.Show("Changes saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
                        enableInputFields(False)
                        btnConsensusDxBottom.Text = "Edit this record"
                        btnConsensusDxTop.Text = btnConsensusDxBottom.Text
                    Catch ex As SqlException
                        ExceptionHandler.CatchSQLException(ex)
                    End Try
                End If
            End If
        End If
    End Sub
    Private Function getValue(ByVal item As String) As String
        Dim myResult As String
        If item = "" Then
            myResult = "null"
        Else
            myResult = item
        End If
        Return myResult
    End Function
    Private Sub btnAddDx_Click(sender As Object, e As EventArgs) Handles ChartPrimDx.Click, ChartSecDx.Click, ChartTert1Dx.Click, ChartTert2Dx.Click, ChartTert3Dx.Click,
        ClinPrimDx.Click, ClinSecDx.Click, ClinTert1Dx.Click, ClinTert2Dx.Click, ClinTert3Dx.Click, ClinConPrimDx.Click, ClinConSecDx.Click, ClinConTert1Dx.Click,
        ClinConTert2Dx.Click, ClinConTert3Dx.Click, NeuroPrimDx.Click, NeuroSecDx.Click, NeuroTert1Dx.Click, NeuroTert2Dx.Click, NeuroTert3Dx.Click, FinPrimDx.Click,
        FinSecDx.Click, FinTert1Dx.Click, FinTert2Dx.Click, FinTert3Dx.Click, NBBPrimDx.Click, NBBSecDx.Click, NBBTert1Dx.Click, NBBTert2Dx.Click, NBBTert3Dx.Click

        'Define the pop-up to use
        PU = New PU_ExistingDxSelect

        'Open using ShowDialog (to make primary form inactive until user finishes with the pop up)
        PU.ShowDialog()

        'Define the sender object as a Button_ (so we can use the btn.Name to determine which fields to apply returned popup data to)
        Dim btn As Button_ = sender
        Dim grp As GroupBox = btn.Parent

        'Define the code boxes associated with the button that called the popup
        Dim codeBox As TextBox_ = Controls(grp.Name).Controls("txt" & btn.Name)
        Dim noteBox As TextBox_ = Controls(grp.Name).Controls("txt" & btn.Name & "Note")
        Dim removeBtn As Button_ = Controls(grp.Name).Controls(btn.Name & "Remove")

        'Apply the values from the popup to the text boxes
        If PU.DxSelected = True Then
            codeBox.Text = PU.dgvDx.SelectedRows(0).Cells("Code").Value.ToString
            noteBox.Text = PU.dgvDx.SelectedRows(0).Cells("Text").Value.ToString
            formTables.Tables("ConsensusDx").Rows(0).Item(btn.Name) = PU.dgvDx.SelectedRows(0).Cells("RecordID").Value
            removeBtn.Enabled = True
        End If

        'Close the (now hidden) popup.
        PU.Dispose()
    End Sub
    Private Sub btnRemoveDx_Click(sender As Object, e As EventArgs) Handles ChartPrimDXRemove.Click, ChartSecDXRemove.Click, ChartTert1DxRemove.Click,
        ChartTert2DxRemove.Click, ChartTert3DxRemove.Click, ClinConPrimDxRemove.Click, ClinConSecDxRemove.Click, ClinConTert1DxRemove.Click, ClinConTert2DxRemove.Click,
        ClinConTert3DxRemove.Click, ClinPrimDxRemove.Click, ClinSecDxRemove.Click, ClinTert1DxRemove.Click, ClinTert2DxRemove.Click, ClinTert3DxRemove.Click,
        NeuroPrimDxRemove.Click, NeuroSecDxRemove.Click, NeuroTert1DxRemove.Click, NeuroTert2DxRemove.Click, NeuroTert3DxRemove.Click, FinPrimDxRemove.Click,
        FinSecDxRemove.Click, FinTert1DxRemove.Click, FinTert2DxRemove.Click, FinTert3DxRemove.Click, NBBPrimDxRemove.Click, NBBSecDxRemove.Click, NBBTert1DxRemove.Click,
        NBBTert2DxRemove.Click, NBBTert3DxRemove.Click
        Dim btn As Button_ = sender
        Dim grp As GroupBox = btn.Parent
        Dim dxLocation As String = btn.Name.Substring(0, btn.Name.Length - 6)

        Dim codeBox As TextBox_ = Controls(grp.Name).Controls("txt" & dxLocation)
        Dim noteBox As TextBox_ = Controls(grp.Name).Controls("txt" & dxLocation & "Note")

        codeBox.Clear()
        noteBox.Clear()
        formTables.Tables("ConsensusDx").Rows(0).Item(dxLocation) = DBNull.Value
        btn.Enabled = False

        'Handle additional settings for Final Diagnosis group
        If grp.Name = "grpFinDx" Then
            Select Case btn.Name
                Case "FinPrimDxRemove"
                    chkPrimPsych1.Checked = False
                    chkPrimPsych1.Enabled = False
                    chkPrimNeuro1.Checked = False
                    chkPrimNeuro1.Enabled = False
                    cmbDxBasis.SelectedIndex = 0
                    cmbDxBasis.Enabled = False
                Case "FinSecDxRemove"
                    chkPrimPsych2.Checked = False
                    chkPrimPsych2.Enabled = False
                    chkPrimNeuro2.Checked = False
                    chkPrimNeuro2.Enabled = False
                Case "FinTertDx1Remove"
                    chkPrimPsych3.Checked = False
                    chkPrimPsych3.Enabled = False
                    chkPrimNeuro3.Checked = False
                    chkPrimNeuro3.Enabled = False
                Case "FinTertDx2Remove"
                    chkPrimPsych4.Checked = False
                    chkPrimPsych4.Enabled = False
                    chkPrimNeuro4.Checked = False
                    chkPrimNeuro4.Enabled = False
                Case "FinTertDx3Remove"
                    chkPrimPsych5.Checked = False
                    chkPrimPsych5.Enabled = False
                    chkPrimNeuro5.Checked = False
                    chkPrimNeuro5.Enabled = False
            End Select
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
        btnConsensusDxBottom.PerformClick()
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub

    Private Sub txtChartTertDx1Note_TextChanged(sender As Object, e As EventArgs) Handles txtChartTert1DxNote.TextChanged

    End Sub
End Class