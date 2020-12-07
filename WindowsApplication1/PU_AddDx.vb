Public Class PU_AddDx

    Private DxCodes As New DataSet
    Public bs As BindingSource = New BindingSource
    Public DxAdded As Boolean = False
    Private ClinNeuro As String = ""

    Public Sub New(Optional ByVal ClinOrNeuro As String = "", Optional ByVal FilterTerm1 As String = "", Optional ByVal FilterTerm2 As String = "", Optional ByVal FilterTerm3 As String = "", Optional ByVal FilterTerm4 As String = "")
        InitializeComponent()
        ClinNeuro = ClinOrNeuro
        txtTerm1.Text = FilterTerm1
        txtTerm2.Text = FilterTerm2
        txtTerm3.Text = FilterTerm3
        txtTerm4.Text = FilterTerm4
        setDGVFilter()
    End Sub
    Private Sub PU_AddDx_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DxCodes.Tables.Add(Database.ReturnTable("view_lkpDxAll", "DxCodeType as 'Code Type', DxCode as 'Code', DxText as 'Text'"))
        bs.DataSource = DxCodes.Tables("view_lkpDxAll")
        dgvDx.DataSource = bs
        'code here to populate combobox values
        DxCodes.Tables.Add(Database.ReturnTable("lkpDiagnosesDxMethod"))
        cmbDxMethod.DataSource = New DataView(DxCodes.Tables("lkpDiagnosesDxMethod"))
        cmbDxMethod.DisplayMember = "Label"
        cmbDxMethod.ValueMember = "Value"
        cmbDxMethod.SelectedValue = -1
        If txtTerm1.Text <> "" Then
            txtTerm2.Enabled = True
        End If
        dgvDx.Columns("Code Type").Width = 70
        dgvDx.Columns("Code").Width = 60
        dgvDx.Columns("Text").Width = 820
        If ClinNeuro = "Clin" Then
            chkBrainClin.Visible = True
        End If
    End Sub


    Private Sub txtTerm_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTerm1.KeyDown, txtTerm2.KeyDown, txtTerm3.KeyDown, txtTerm4.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            setDGVFilter()
        End If
    End Sub

    Private Sub chkBrainClin_CheckedChanged(sender As Object, e As EventArgs) Handles chkBrainClin.CheckedChanged
        If Not chkBrainClin.Checked Then
            txtBrainRelatedRank.Clear()
        End If
    End Sub

    Private Sub setDGVFilter()
        Dim myFilter As String = ""
        If txtTerm1.Text <> "" Then
            myFilter += "(Code like '%" & Replace(txtTerm1.Text, "'", "''") & "%' or Text like '%" & Replace(txtTerm1.Text, "'", "''") & "%')"
            myFilter += IIf(txtTerm2.Text <> "", " and Text like '%" & Replace(txtTerm2.Text, "'", "''") & "%'", "")
            myFilter += IIf(txtTerm3.Text <> "", " and Text like '%" & Replace(txtTerm3.Text, "'", "''") & "%'", "")
            myFilter += IIf(txtTerm4.Text <> "", " and Text like '%" & Replace(txtTerm4.Text, "'", "''") & "%'", "")
        End If
        bs.Filter = myFilter
    End Sub

    'Click events (BTN and DGV)
    Private Sub btnApplyFilter_Click(sender As Object, e As EventArgs) Handles btnApplyFilter.Click
        setDGVFilter()
    End Sub
    Public Sub dgvDx_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs, Optional ByVal icdTenCodeType As String = "", Optional ByVal icdTenCode As String = "", Optional ByVal icdTenCodeText As String = "") Handles dgvDx.CellDoubleClick
        Dim codeType As String = dgvDx.SelectedRows(0).Cells("Code Type").Value.ToString()
        Dim Code As String = dgvDx.SelectedRows(0).Cells("Code").Value.ToString()
        Dim codeText = dgvDx.SelectedRows(0).Cells("Text").Value.ToString()

        If codeType = "ICD-9 " Then
            Dim pu As New PU_ConvertICD9To10(Code, txtDxCodeType, txtDxCode, txtDxText)
            pu.ShowDialog()
        Else
            txtDxCodeType.Text = codeType
            txtDxCode.Text = Code
            txtDxText.Text = codeText
        End If

        dtDx.Focus()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If preSaveValidation() Then
            Try
                Dim cmd As New SqlCommand
                cmd.Connection = WarehouseShell.conn
                cmd.CommandText = "Exec modDiagnosesRecord @Action = 1" &
                    ", @RecordID = 0" &
                    ", @SubNum = " & WarehouseShell.SubNum &
                    ", @DxCodeType = " & txtDxCodeType.getSQLValue() &
                    ", @DxCode = " & txtDxCode.getSQLValue() &
                    ", @Dx = " & txtDxText.getSQLValue() &
                    ", @DxDate = " & dtDx.getSQLValue() &
                    ", @DxMethod = " & cmbDxMethod.getSQLValue() &
                    ", @BrainClin = " & chkBrainClin.getSQLValue() &
                    ", @BrainClinRank = " & txtBrainRelatedRank.getSQLValue() &
                    ";"
                cmd.ExecuteNonQuery()
                MessageBox.Show("Diagnosis successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                DxAdded = True
                Close()
            Catch ex As SqlException
                ExceptionHandler.CatchSQLException(ex)
            End Try
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnOnlineSearch_Click(sender As Object, e As EventArgs) Handles btnOnlineSearch.Click
        If txtTerm1.Text <> "" Then
            Dim searchText As String = txtTerm1.Text.Replace(" ", "+")
            searchText += IIf(txtTerm2.Text <> "", "+" & txtTerm2.Text.Replace(" ", "+"), "")
            searchText += IIf(txtTerm3.Text <> "", "+" & txtTerm3.Text.Replace(" ", "+"), "")
            searchText += IIf(txtTerm4.Text <> "", "+" & txtTerm4.Text.Replace(" ", "+"), "")
            Dim webAddress As String = "http://icd9.chrisendres.com/index.php?srchtype=diseases&srchtext=" & searchText & "&Submit=Search&action=search"
            Process.Start(webAddress)
        Else
            MsgBox("Please enter at least one search term to search online.", vbOKOnly, "Error")
        End If
    End Sub

    Private Function preSaveValidation() As Boolean
        Dim result As Boolean = True
        Dim errMsg As String = "The following errors exist and need to be corrected before record can be saved:" & vbNewLine & vbNewLine

        If txtDxCode.Text = "" Then
            errMsg += "- You have not selected a diagnosis to save. Please select a diagnosis (by double-clicking a row in the table) or click ""Cancel"" button to exit this pop-up." & vbNewLine
            result = False
        ElseIf dtDx.Text <> "  /  /" Then
            If Database.ExistingRecordCheck("Diagnoses", "SubNum = " & WarehouseShell.SubNum & " and DxCode = " & txtDxCode.getSQLValue() & " and DxDate = " & dtDx.getSQLValue()) Then
                errMsg += "- This diagnosis alerady exists on this date for this subject." & vbNewLine
                result = False
            End If
        Else
            If Database.ExistingRecordCheck("Diagnoses", "SubNum = " & WarehouseShell.SubNum & " and DxCode = " & txtDxCode.getSQLValue() & " and DxDate is null") Then
                errMsg += "- This diagnosis alerady exists without a date for this subject." & vbNewLine
                result = False
            End If
        End If

        If result = False Then
            MsgBox(errMsg, MsgBoxStyle.OkOnly, "Error")
        End If

        Return result
    End Function

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub txtBrainRelatedRank_TextChanged(sender As Object, e As EventArgs) Handles txtBrainRelatedRank.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub cmbDxMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDxMethod.SelectedIndexChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub dtDx_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles dtDx.MaskInputRejected

    End Sub

    Private Sub txtDxText_TextChanged(sender As Object, e As EventArgs) Handles txtDxText.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtDxCode_TextChanged(sender As Object, e As EventArgs) Handles txtDxCode.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtDxCodeType_TextChanged(sender As Object, e As EventArgs) Handles txtDxCodeType.TextChanged

    End Sub
End Class