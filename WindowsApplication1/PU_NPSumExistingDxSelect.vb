Public Class PU_NPSumExistingDxSelect
    Private DxCodes As New DataSet
    Public bs As BindingSource = New BindingSource
    Public DxSelected As Boolean = False

    Private Sub PU_NPSumExistingDxSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshDGV()
    End Sub

    Private Sub refreshDGV()
        'Clear existing tables and unlink binding source
        DxCodes.Tables.Clear()
        bs.DataSource = Nothing

        'Grab fresh data
        DxCodes.Tables.Add(Database.ReturnTable("Diagnoses", "DxCodeType as 'Code Type', DxCode as 'Code', Dx as 'Text', BrainClin as 'Brain Related'", "SubNum = " & WarehouseShell.SubNum & " and DxCodeType = 'ICD-9' and DxCode in (select DxCode from lkpICD9 where HarryDxCode is not null)"))

        'Add Control diagnosis
        Dim newRow As DataRow = DxCodes.Tables("Diagnoses").NewRow()
        newRow("Code Type") = "ICD-9"
        newRow("Code") = "000.00"
        newRow("Text") = "Control- No Brain-Related Diagnoses"
        newRow("Brain Related") = 1
        DxCodes.Tables("Diagnoses").Rows.Add(newRow)

        'Assign BS for filtering
        bs.DataSource = DxCodes.Tables("Diagnoses")
        dgvDx.DataSource = bs
        dgvDx.Sort(dgvDx.Columns("Code"), ComponentModel.ListSortDirection.Ascending)
    End Sub
    Private Sub resetInputs()
        'Clear all of the textboxes to reset the form
        Dim txtBox As Control
        For Each txtBox In Controls
            If TypeOf txtBox Is TextBox_ Then
                CType(txtBox, TextBox_).Clear()
            End If
        Next
        bs.Filter = Nothing
        DxSelected = False
    End Sub
    Private Sub txtTerm_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTerm1.KeyDown, txtTerm2.KeyDown, txtTerm3.KeyDown, txtTerm4.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            setDGVFilter()
        End If
    End Sub
    Private Sub setDGVFilter()
        Dim myFilter As String = ""
        If txtTerm1.Text <> "" Then
            myFilter += "(Code like '%" & txtTerm1.Text & "' or Text like '%" & txtTerm1.Text & "%')"
            myFilter += IIf(txtTerm2.Text <> "", " and Text like '%" & txtTerm2.Text & "%'", "")
            myFilter += IIf(txtTerm3.Text <> "", " and Text like '%" & txtTerm3.Text & "%'", "")
            myFilter += IIf(txtTerm4.Text <> "", " and Text like '%" & txtTerm4.Text & "%'", "")
        End If
        If chkHideNonBrain.Checked Then
            If myFilter = "" Then
                myFilter = "[Brain Related] = 1"
            Else
                myFilter += " and [Brain Related] = 1"
            End If
        End If
        bs.Filter = myFilter
    End Sub

    'BTN and DGV click events
    Private Sub dgvDx_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDx.CellDoubleClick
        txtDxCodeType.Text = dgvDx.SelectedRows(0).Cells("Code Type").Value.ToString()
        txtDxCode.Text = dgvDx.SelectedRows(0).Cells("Code").Value.ToString()
        txtDxText.Text = dgvDx.SelectedRows(0).Cells("Text").Value.ToString()
        btnApply.Enabled = True
    End Sub
    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        DxSelected = True
        Hide() 'Form must be disposed by calling function
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim DxPU As New PU_AddDx
        DxPU.ShowDialog()
        If DxPU.DxAdded = True Then 'Refresh the DGV if user added a Dx
            refreshDGV()
            resetInputs()
        End If
        DxPU.Dispose() 'Release the resources held by the AddDx pop-up form
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Hide() 'Form must be disposed by calling function
    End Sub
    Private Sub chkHideNonBrain_CheckedChanged(sender As Object, e As EventArgs) Handles chkHideNonBrain.CheckedChanged
        setDGVFilter()
    End Sub
End Class