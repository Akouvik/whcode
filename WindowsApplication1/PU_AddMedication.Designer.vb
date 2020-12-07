<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PU_AddMedication
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDosage = New DataWarehouse.TextBoxNumeric()
        Me.btnSuggestNewMedication = New DataWarehouse.Button_()
        Me.btnSaveAddAnother = New DataWarehouse.Button_()
        Me.dtEnded = New DataWarehouse.TextBoxDatePast()
        Me.dtStarted = New DataWarehouse.TextBoxDatePast()
        Me.txtDosageUnits = New DataWarehouse.TextBox_()
        Me.txtGenericName = New DataWarehouse.TextBox_()
        Me.btnCancel = New DataWarehouse.Button_()
        Me.btnSaveClose = New DataWarehouse.Button_()
        Me.txtBrandName = New DataWarehouse.TextBox_()
        Me.btnClearFilter = New DataWarehouse.Button_()
        Me.btnApplyFilter = New DataWarehouse.Button_()
        Me.txtTerm4 = New DataWarehouse.TextBox_()
        Me.txtTerm3 = New DataWarehouse.TextBox_()
        Me.txtTerm2 = New DataWarehouse.TextBox_()
        Me.txtTerm1 = New DataWarehouse.TextBox_()
        Me.dgvMedLookup = New DataWarehouse.dgvSingleRow()
        Me.cmbRoute = New DataWarehouse.ComboBox_()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.dgvMedLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 500)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 197
        Me.Label5.Text = "Brand Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(462, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 195
        Me.Label4.Text = "Term 4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(312, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 194
        Me.Label3.Text = "Term 3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(162, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 193
        Me.Label2.Text = "Term 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 192
        Me.Label1.Text = "Term 1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 539)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 13)
        Me.Label6.TabIndex = 217
        Me.Label6.Text = "Generic Name (Active Ingredient)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 578)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 219
        Me.Label7.Text = "Daily Dosage"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(380, 578)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 225
        Me.Label10.Text = "Started"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(453, 578)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 227
        Me.Label11.Text = "Ended"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(447, 13)
        Me.Label12.TabIndex = 230
        Me.Label12.Text = "*If using filter, Term 1 must be used first, then any combination of Terms 2-4 ca" &
    "n also be used."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(115, 578)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(135, 13)
        Me.Label13.TabIndex = 232
        Me.Label13.Text = "Dosage Units (mg, mL, etc)"
        '
        'txtDosage
        '
        Me.txtDosage.Enabled = False
        Me.txtDosage.Location = New System.Drawing.Point(12, 594)
        Me.txtDosage.Name = "txtDosage"
        Me.txtDosage.Size = New System.Drawing.Size(100, 20)
        Me.txtDosage.TabIndex = 109
        '
        'btnSuggestNewMedication
        '
        Me.btnSuggestNewMedication.Location = New System.Drawing.Point(839, 620)
        Me.btnSuggestNewMedication.Name = "btnSuggestNewMedication"
        Me.btnSuggestNewMedication.Size = New System.Drawing.Size(144, 23)
        Me.btnSuggestNewMedication.TabIndex = 118
        Me.btnSuggestNewMedication.Text = "Suggest New Medication"
        Me.btnSuggestNewMedication.UseVisualStyleBackColor = True
        '
        'btnSaveAddAnother
        '
        Me.btnSaveAddAnother.Location = New System.Drawing.Point(162, 620)
        Me.btnSaveAddAnother.Name = "btnSaveAddAnother"
        Me.btnSaveAddAnother.Size = New System.Drawing.Size(144, 23)
        Me.btnSaveAddAnother.TabIndex = 115
        Me.btnSaveAddAnother.Text = "Save && Add Another"
        Me.btnSaveAddAnother.UseVisualStyleBackColor = True
        '
        'dtEnded
        '
        Me.dtEnded.Enabled = False
        Me.dtEnded.Location = New System.Drawing.Point(456, 594)
        Me.dtEnded.Mask = "00/00/0000"
        Me.dtEnded.Name = "dtEnded"
        Me.dtEnded.Size = New System.Drawing.Size(67, 20)
        Me.dtEnded.TabIndex = 113
        Me.dtEnded.ValidatingType = GetType(Date)
        '
        'dtStarted
        '
        Me.dtStarted.Enabled = False
        Me.dtStarted.Location = New System.Drawing.Point(383, 594)
        Me.dtStarted.Mask = "00/00/0000"
        Me.dtStarted.Name = "dtStarted"
        Me.dtStarted.Size = New System.Drawing.Size(67, 20)
        Me.dtStarted.TabIndex = 112
        Me.dtStarted.ValidatingType = GetType(Date)
        '
        'txtDosageUnits
        '
        Me.txtDosageUnits.Enabled = False
        Me.txtDosageUnits.Location = New System.Drawing.Point(118, 594)
        Me.txtDosageUnits.Name = "txtDosageUnits"
        Me.txtDosageUnits.Size = New System.Drawing.Size(132, 20)
        Me.txtDosageUnits.TabIndex = 110
        '
        'txtGenericName
        '
        Me.txtGenericName.Enabled = False
        Me.txtGenericName.Location = New System.Drawing.Point(12, 555)
        Me.txtGenericName.Name = "txtGenericName"
        Me.txtGenericName.Size = New System.Drawing.Size(971, 20)
        Me.txtGenericName.TabIndex = 999
        Me.txtGenericName.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(312, 620)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(144, 23)
        Me.btnCancel.TabIndex = 116
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSaveClose
        '
        Me.btnSaveClose.Location = New System.Drawing.Point(12, 620)
        Me.btnSaveClose.Name = "btnSaveClose"
        Me.btnSaveClose.Size = New System.Drawing.Size(144, 23)
        Me.btnSaveClose.TabIndex = 114
        Me.btnSaveClose.Text = "Save && Close"
        Me.btnSaveClose.UseVisualStyleBackColor = True
        '
        'txtBrandName
        '
        Me.txtBrandName.Enabled = False
        Me.txtBrandName.Location = New System.Drawing.Point(12, 516)
        Me.txtBrandName.Name = "txtBrandName"
        Me.txtBrandName.Size = New System.Drawing.Size(971, 20)
        Me.txtBrandName.TabIndex = 999
        Me.txtBrandName.TabStop = False
        '
        'btnClearFilter
        '
        Me.btnClearFilter.Location = New System.Drawing.Point(720, 4)
        Me.btnClearFilter.Name = "btnClearFilter"
        Me.btnClearFilter.Size = New System.Drawing.Size(91, 23)
        Me.btnClearFilter.TabIndex = 106
        Me.btnClearFilter.Text = "Clear Filter(s)"
        Me.btnClearFilter.UseVisualStyleBackColor = True
        '
        'btnApplyFilter
        '
        Me.btnApplyFilter.Location = New System.Drawing.Point(623, 4)
        Me.btnApplyFilter.Name = "btnApplyFilter"
        Me.btnApplyFilter.Size = New System.Drawing.Size(91, 23)
        Me.btnApplyFilter.TabIndex = 105
        Me.btnApplyFilter.Text = "Apply Filter(s)"
        Me.btnApplyFilter.UseVisualStyleBackColor = True
        '
        'txtTerm4
        '
        Me.txtTerm4.Enabled = False
        Me.txtTerm4.Location = New System.Drawing.Point(506, 6)
        Me.txtTerm4.Name = "txtTerm4"
        Me.txtTerm4.Size = New System.Drawing.Size(100, 20)
        Me.txtTerm4.TabIndex = 104
        '
        'txtTerm3
        '
        Me.txtTerm3.Enabled = False
        Me.txtTerm3.Location = New System.Drawing.Point(356, 6)
        Me.txtTerm3.Name = "txtTerm3"
        Me.txtTerm3.Size = New System.Drawing.Size(100, 20)
        Me.txtTerm3.TabIndex = 103
        '
        'txtTerm2
        '
        Me.txtTerm2.Enabled = False
        Me.txtTerm2.Location = New System.Drawing.Point(206, 6)
        Me.txtTerm2.Name = "txtTerm2"
        Me.txtTerm2.Size = New System.Drawing.Size(100, 20)
        Me.txtTerm2.TabIndex = 102
        '
        'txtTerm1
        '
        Me.txtTerm1.Location = New System.Drawing.Point(56, 6)
        Me.txtTerm1.Name = "txtTerm1"
        Me.txtTerm1.Size = New System.Drawing.Size(100, 20)
        Me.txtTerm1.TabIndex = 101
        '
        'dgvMedLookup
        '
        Me.dgvMedLookup.AllowUserToAddRows = False
        Me.dgvMedLookup.AllowUserToDeleteRows = False
        Me.dgvMedLookup.AllowUserToOrderColumns = True
        Me.dgvMedLookup.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige
        Me.dgvMedLookup.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMedLookup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvMedLookup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvMedLookup.BackgroundColor = System.Drawing.Color.Tan
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMedLookup.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMedLookup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMedLookup.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMedLookup.GridColor = System.Drawing.Color.Linen
        Me.dgvMedLookup.Location = New System.Drawing.Point(12, 45)
        Me.dgvMedLookup.MultiSelect = False
        Me.dgvMedLookup.Name = "dgvMedLookup"
        Me.dgvMedLookup.ReadOnly = True
        Me.dgvMedLookup.RowHeadersVisible = False
        Me.dgvMedLookup.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.dgvMedLookup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMedLookup.Size = New System.Drawing.Size(971, 452)
        Me.dgvMedLookup.TabIndex = 107
        '
        'cmbRoute
        '
        Me.cmbRoute.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbRoute.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRoute.Enabled = False
        Me.cmbRoute.FormattingEnabled = True
        Me.cmbRoute.Location = New System.Drawing.Point(256, 593)
        Me.cmbRoute.Name = "cmbRoute"
        Me.cmbRoute.Size = New System.Drawing.Size(121, 21)
        Me.cmbRoute.TabIndex = 111
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(253, 578)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 1187
        Me.Label9.Text = "Route"
        '
        'PU_AddMedication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(993, 651)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbRoute)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtDosage)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnSuggestNewMedication)
        Me.Controls.Add(Me.btnSaveAddAnother)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dtEnded)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtStarted)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDosageUnits)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtGenericName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSaveClose)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBrandName)
        Me.Controls.Add(Me.btnClearFilter)
        Me.Controls.Add(Me.btnApplyFilter)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTerm4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTerm3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTerm2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTerm1)
        Me.Controls.Add(Me.dgvMedLookup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PU_AddMedication"
        Me.Text = "PU_AddMedication"
        CType(Me.dgvMedLookup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As DataWarehouse.Button_
    Friend WithEvents btnSaveClose As DataWarehouse.Button_
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBrandName As DataWarehouse.TextBox_
    Friend WithEvents btnClearFilter As DataWarehouse.Button_
    Friend WithEvents btnApplyFilter As DataWarehouse.Button_
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTerm4 As DataWarehouse.TextBox_
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTerm3 As DataWarehouse.TextBox_
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTerm2 As DataWarehouse.TextBox_
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTerm1 As DataWarehouse.TextBox_
    Friend WithEvents dgvMedLookup As DataWarehouse.dgvSingleRow
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtGenericName As DataWarehouse.TextBox_
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDosageUnits As DataWarehouse.TextBox_
    Friend WithEvents dtStarted As DataWarehouse.TextBoxDatePast
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtEnded As DataWarehouse.TextBoxDatePast
    Friend WithEvents btnSaveAddAnother As DataWarehouse.Button_
    Friend WithEvents btnSuggestNewMedication As DataWarehouse.Button_
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDosage As DataWarehouse.TextBoxNumeric
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbRoute As ComboBox_
    Friend WithEvents Label9 As Label
End Class
