Public Class PU_Subject_RelWithSimDx
    Implements IFormMethods
    Private formTables As New DataSet
    Private RecordID As Integer = 0
    Private PU As PU_ExistingDxSelect
    Public senderDataMode As WarehouseShell.userDataMode

    Private Sub PU_Subject_RelWithSimDx_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formTables.Tables.Add(Database.ReturnTable("Subject_RelWithSimDx", "RecordID, RelationValue, RelationLabel as Relation, AgeAtDx as 'Age at Dx', EdLevel as 'Ed. Level', RaceValue, RaceLabel as Race, DxICD as 'Dx ICD Code', DxText as 'Dx ICD Text'", "SubNum = " & WarehouseShell.SubNum))
        dgvRelWithSimDx.DataSource = formTables.Tables("Subject_RelWithSimDx")
        dgvRelWithSimDx.Columns("RecordID").Visible = False
        dgvRelWithSimDx.Columns("RelationValue").Visible = False
        dgvRelWithSimDx.Columns("RaceValue").Visible = False
        formTables.Tables.Add(Database.ReturnTable("lkpRelation"))
        formTables.Tables.Add(Database.ReturnTable("lkpRace"))
        cmbRelation.DataSource = formTables.Tables("lkpRelation")
        cmbRelation.ValueMember = "Value"
        cmbRelation.DisplayMember = "Label"
        cmbRelation.SelectedValue = -1
        cmbRace.DataSource = formTables.Tables("lkpRace")
        cmbRace.ValueMember = "Value"
        cmbRace.DisplayMember = "Label"
        cmbRace.SelectedValue = -1
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
        cmbRelation.Enabled = False
        txtAgeAtDx.Enabled = False
        txtLevelOfEd.Enabled = False
        cmbRace.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub dgvRelWithSimDx_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRelWithSimDx.CellDoubleClick
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit Or WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
            Dim checkForm As New PU_SaveWork
            Dim myResult As DialogResult = checkForm.ShowDialog
            checkForm.Dispose()
            If myResult = Windows.Forms.DialogResult.OK Then
                Me.SaveWork()
                RecordID = dgvRelWithSimDx.SelectedRows(0).Cells("RecordID").Value
                cmbRelation.SelectedValue = dgvRelWithSimDx.SelectedRows(0).Cells("RelationValue").Value
                txtAgeAtDx.Text = dgvRelWithSimDx.SelectedRows(0).Cells("Age at Dx").Value.ToString
                txtLevelOfEd.Text = dgvRelWithSimDx.SelectedRows(0).Cells("Ed. Level").Value.ToString
                cmbRace.SelectedValue = dgvRelWithSimDx.SelectedRows(0).Cells("RaceValue").Value
                txtICDCode.Text = dgvRelWithSimDx.SelectedRows(0).Cells("Dx ICD Code").Value.ToString
                txtICDText.Text = dgvRelWithSimDx.SelectedRows(0).Cells("Dx ICD Text").Value.ToString
                btnEdit.Enabled = True
                btnDelete.Enabled = True
            ElseIf myResult = Windows.Forms.DialogResult.Ignore Then
                resetToView()
                RecordID = dgvRelWithSimDx.SelectedRows(0).Cells("RecordID").Value
                cmbRelation.SelectedValue = dgvRelWithSimDx.SelectedRows(0).Cells("RelationValue").Value
                txtAgeAtDx.Text = dgvRelWithSimDx.SelectedRows(0).Cells("Age at Dx").Value.ToString
                txtLevelOfEd.Text = dgvRelWithSimDx.SelectedRows(0).Cells("Ed. Level").Value.ToString
                cmbRace.SelectedValue = dgvRelWithSimDx.SelectedRows(0).Cells("RaceValue").Value
                txtICDCode.Text = dgvRelWithSimDx.SelectedRows(0).Cells("Dx ICD Code").Value.ToString
                txtICDText.Text = dgvRelWithSimDx.SelectedRows(0).Cells("Dx ICD Text").Value.ToString
                btnEdit.Enabled = True
                btnDelete.Enabled = True
            ElseIf myResult = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If
        Else
            RecordID = dgvRelWithSimDx.SelectedRows(0).Cells("RecordID").Value
            cmbRelation.SelectedValue = dgvRelWithSimDx.SelectedRows(0).Cells("RelationValue").Value
            txtAgeAtDx.Text = dgvRelWithSimDx.SelectedRows(0).Cells("Age at Dx").Value.ToString
            txtLevelOfEd.Text = dgvRelWithSimDx.SelectedRows(0).Cells("Ed. Level").Value.ToString
            cmbRace.SelectedValue = dgvRelWithSimDx.SelectedRows(0).Cells("RaceValue").Value
            txtICDCode.Text = dgvRelWithSimDx.SelectedRows(0).Cells("Dx ICD Code").Value.ToString
            txtICDText.Text = dgvRelWithSimDx.SelectedRows(0).Cells("Dx ICD Text").Value.ToString
            btnEdit.Enabled = True
            btnDelete.Enabled = True
        End If
    End Sub

    'Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
    '    If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
    '        PU = New PU_ExistingDxSelect
    '        PU.ShowDialog()
    '        If PU.ICD9Value <> "*" Then
    '            WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert
    '            txtICDCode.Text = PU.ICD9Value
    '            txtICDText.Text = PU.ICD9Label
    '            PU.Dispose()
    '            cmbRelation.Enabled = True
    '            txtAgeAtDx.Enabled = True
    '            txtLevelOfEd.Enabled = True
    '            cmbRace.Enabled = True
    '            btnEdit.Visible = False
    '            btnAdd.Text = "Save New Record"
    '            btnDelete.Enabled = True
    '            btnDelete.Text = "Cancel"
    '        Else
    '            resetToView()
    '        End If
    '        PU.Dispose()
    '    ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
    '        Try
    '            Dim SqlCommand As New SqlCommand
    '            SqlCommand.Connection = WarehouseShell.conn
    '            SqlCommand.CommandText = "Exec dbo.modSubject_RelWithSimDxRecord @Action = 1" & _
    '                ", @RecordID = NULL" & _
    '                ", @SubNum = " & WarehouseShell.SubNum & _
    '                ", @RelationValue = " & WarehouseShell.comboNullCheckReturnSelectedValue(cmbRelation) & _
    '                ", @RelationLabel = " & WarehouseShell.comboNullCheckReturnDisplayValue(cmbRelation) & _
    '                ", @AgeAtDx = " & WarehouseShell.txtNullCheck(txtAgeAtDx) & _
    '                ", @EdLevel = " & WarehouseShell.txtNullCheck(txtLevelOfEd) & _
    '                ", @RaceValue = " & WarehouseShell.comboNullCheckReturnSelectedValue(cmbRace) & _
    '                ", @RaceLabel = " & WarehouseShell.comboNullCheckReturnDisplayValue(cmbRace) & _
    '                ", @DxICD = " & WarehouseShell.txtNullCheck(txtICDCode) & _
    '                ", @DxText = " & WarehouseShell.txtNullCheck(txtICDText) & _
    '                ";"
    '            SqlCommand.ExecuteNonQuery()
    '            MessageBox.Show("Record was successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    '            resetToView()
    '        Catch ex As SqlException
    '            ExceptionHandler.CatchSQLException(ex)
    '        End Try
    '    ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit Then
    '        PU = New PU_ExistingDxSelect
    '        PU.ShowDialog()
    '        If PU.ICD9Value <> "" Then
    '            txtICDCode.Text = PU.ICD9Value
    '            txtICDText.Text = PU.ICD9Label
    '        End If
    '        PU.Dispose()
    '    End If
    'End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit
            btnAdd.Text = "Change ICD Code/Text"
            btnEdit.Text = "Save Changes"
            btnDelete.Text = "Cancel"
            cmbRelation.Enabled = True
            txtAgeAtDx.Enabled = True
            txtLevelOfEd.Enabled = True
            cmbRace.Enabled = True
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit Then
            Try
                Dim SqlCommand As New SqlCommand
                SqlCommand.Connection = WarehouseShell.conn
                SqlCommand.CommandText = "Exec dbo.modSubject_RelWithSimDxRecord @Action = 2" &
                    ", @RecordID = " & RecordID &
                    ", @SubNum = " & WarehouseShell.SubNum &
                    ", @RelationValue = " & cmbRelation.getSQLValue() &
                    ", @RelationLabel = " & cmbRelation.getSQLLabel() &
                    ", @AgeAtDx = " & txtAgeAtDx.getSQLValue() &
                    ", @EdLevel = " & txtLevelOfEd.getSQLValue() &
                    ", @RaceValue = " & cmbRace.getSQLValue() &
                    ", @RaceLabel = " & cmbRace.getSQLLabel() &
                    ", @DxICD = " & txtICDCode.getSQLValue() &
                    ", @DxText = " & txtICDText.getSQLValue() &
                    ";"
                SqlCommand.ExecuteNonQuery()
                MessageBox.Show("Changes Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                resetToView()
            Catch ex As SqlException
                ExceptionHandler.CatchSQLException(ex)
            End Try
        End If
    End Sub

    Private Sub resetToView()
        'Reload the DGV
        formTables.Tables.Remove("Subject_RelWithSimDx")
        formTables.Tables.Add(Database.ReturnTable("Subject_RelWithSimDx", "RecordID, RelationValue, RelationLabel as Relation, AgeAtDx as 'Age at Dx', EdLevel as 'Ed. Level', RaceValue, RaceLabel as Race, DxICD as 'Dx ICD Code', DxText as 'Dx ICD Text'", "SubNum = " & WarehouseShell.SubNum))
        dgvRelWithSimDx.DataSource = formTables.Tables("Subject_RelWithSimDx")
        dgvRelWithSimDx.Columns("RecordID").Visible = False
        dgvRelWithSimDx.Columns("RelationValue").Visible = False
        dgvRelWithSimDx.Columns("RaceValue").Visible = False
        'Baseline all the user fields
        cmbRelation.Enabled = False
        cmbRelation.SelectedValue = -1
        txtAgeAtDx.Clear()
        txtAgeAtDx.Enabled = False
        txtLevelOfEd.Clear()
        txtLevelOfEd.Enabled = False
        txtICDCode.Clear()
        txtICDText.Clear()
        cmbRace.Enabled = False
        cmbRace.SelectedValue = -1
        btnAdd.Text = "Add New Record"
        btnEdit.Text = "Edit Selected Record"
        btnEdit.Visible = True
        btnEdit.Enabled = False
        btnDelete.Text = "Delete Selected Record"
        btnDelete.Enabled = False
        WarehouseShell.DataMode = WarehouseShell.userDataMode.View
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.View Then
            Try
                Dim SqlCommand As New SqlCommand
                SqlCommand.Connection = WarehouseShell.conn
                SqlCommand.CommandText = "Delete from Subject_RelWithSimDx where RecordID = " & RecordID & ";"
                SqlCommand.ExecuteNonQuery()
                MessageBox.Show("Record Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                resetToView()
            Catch ex As SqlException
                ExceptionHandler.CatchSQLException(ex)
            End Try
        Else
            resetToView()
        End If
    End Sub

    Private Sub PU_Subject_RelWithSimDx_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit Or WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
            Dim checkForm As New PU_SaveWork
            Dim myResult As DialogResult = checkForm.ShowDialog
            checkForm.Dispose()
            If myResult = Windows.Forms.DialogResult.OK Then
                Me.SaveWork()
                WarehouseShell.DataMode = senderDataMode
                formTables.Tables.Clear()
                DirectCast(WarehouseShell.WorkingAreaForm, WA_Demographics).refreshRelWithSimDx()
            ElseIf myResult = Windows.Forms.DialogResult.Ignore Then
                WarehouseShell.DataMode = senderDataMode
                formTables.Tables.Clear()
                DirectCast(WarehouseShell.WorkingAreaForm, WA_Demographics).refreshRelWithSimDx()
            Else
                e.Cancel = True
            End If
        Else
            formTables.Tables.Clear()
            DirectCast(WarehouseShell.WorkingAreaForm, WA_Demographics).refreshRelWithSimDx()
        End If
    End Sub

    'Imported IFormMethods
    Public Sub Parent1(ByRef val As Object) Implements IFormMethods.Parent
        Parent = val
    End Sub
    Public Sub SaveWork() Implements IFormMethods.SaveWork
        If WarehouseShell.DataMode = WarehouseShell.userDataMode.Insert Then
            btnAdd.PerformClick()
        ElseIf WarehouseShell.DataMode = WarehouseShell.userDataMode.Edit Then
            btnEdit.PerformClick()
        End If
    End Sub
    Public Sub Show1() Implements IFormMethods.Show
        Show()
    End Sub
    Public Sub ShowPHI(val As Boolean) Implements IFormMethods.ShowPHI
    End Sub
    Public Sub TopLevel1(val As Boolean) Implements IFormMethods.TopLevel
        TopLevel = val
    End Sub
    Public Sub MyDispose() Implements IFormMethods.MyDispose
        Dispose()
    End Sub
End Class