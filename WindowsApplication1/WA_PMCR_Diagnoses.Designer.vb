<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WA_PMCR_Diagnoses
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnRemoveDx = New DataWarehouse.Button_()
        Me.btnDxChange = New DataWarehouse.Button_()
        Me.btnDxSave = New DataWarehouse.Button_()
        Me.lblDxCodeSearch = New System.Windows.Forms.Label()
        Me.lblDxTextSearch = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.txtDxCodeSearch = New DataWarehouse.TextBox_()
        Me.txtDxTextSearch = New DataWarehouse.TextBox_()
        Me.btnDxSearch = New DataWarehouse.Button_()
        Me.btnAddCode = New DataWarehouse.Button_()
        Me.cmbDxMethod = New DataWarehouse.ComboBox_()
        Me.txtDxCode = New DataWarehouse.TextBox_()
        Me.txtDxDate = New DataWarehouse.TextBoxDatePast()
        Me.txtDx = New DataWarehouse.TextBox_()
        Me.dgvDx = New DataWarehouse.dgvSingleRow()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDxCodeType = New DataWarehouse.TextBox_()
        Me.chkBrainClin = New DataWarehouse.CheckBox_()
        Me.grpClinDx = New System.Windows.Forms.GroupBox()
        Me.lblNoRecord = New System.Windows.Forms.Label()
        Me.ClinTertDx3 = New DataWarehouse.Button_()
        Me.ClinTertDx2 = New DataWarehouse.Button_()
        Me.ClinTertDx1 = New DataWarehouse.Button_()
        Me.ClinSecDx = New DataWarehouse.Button_()
        Me.ClinPrimDx = New DataWarehouse.Button_()
        Me.txtClinTertDx3 = New DataWarehouse.TextBox_()
        Me.txtClinTertDx3Note = New DataWarehouse.TextBox_()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtClinTertDx2 = New DataWarehouse.TextBox_()
        Me.txtClinTertDx2Note = New DataWarehouse.TextBox_()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtClinTertDx1 = New DataWarehouse.TextBox_()
        Me.txtClinTertDx1Note = New DataWarehouse.TextBox_()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtClinSecDx = New DataWarehouse.TextBox_()
        Me.txtClinSecDxNote = New DataWarehouse.TextBox_()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtClinPrimDxNote = New DataWarehouse.TextBox_()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtClinPrimDx = New DataWarehouse.TextBox_()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnShowBrainOnly = New DataWarehouse.Button_()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBrainRelatedRank = New DataWarehouse.TextBoxInteger()
        Me.lblNumRows = New System.Windows.Forms.Label()
        Me.eqModel = New Korzh.EasyQuery.Db.DbModel()
        Me.eqQuery = New Korzh.EasyQuery.Db.DbQuery()
        Me.pnlQuery = New Korzh.EasyQuery.WinControls.QueryPanel()
        Me.btnQuery = New DataWarehouse.Button_()
        Me.btnReset = New DataWarehouse.Button_()
        Me.btnExport = New DataWarehouse.Button_()
        CType(Me.dgvDx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpClinDx.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRemoveDx
        '
        Me.btnRemoveDx.Location = New System.Drawing.Point(390, 718)
        Me.btnRemoveDx.Name = "btnRemoveDx"
        Me.btnRemoveDx.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveDx.TabIndex = 256
        Me.btnRemoveDx.Text = "Remove Dx"
        Me.btnRemoveDx.UseVisualStyleBackColor = True
        Me.btnRemoveDx.Visible = False
        '
        'btnDxChange
        '
        Me.btnDxChange.Location = New System.Drawing.Point(309, 718)
        Me.btnDxChange.Name = "btnDxChange"
        Me.btnDxChange.Size = New System.Drawing.Size(75, 23)
        Me.btnDxChange.TabIndex = 255
        Me.btnDxChange.Text = "Change Dx"
        Me.btnDxChange.UseVisualStyleBackColor = True
        '
        'btnDxSave
        '
        Me.btnDxSave.Location = New System.Drawing.Point(909, 784)
        Me.btnDxSave.Name = "btnDxSave"
        Me.btnDxSave.Size = New System.Drawing.Size(75, 23)
        Me.btnDxSave.TabIndex = 254
        Me.btnDxSave.Text = "Save"
        Me.btnDxSave.UseVisualStyleBackColor = True
        '
        'lblDxCodeSearch
        '
        Me.lblDxCodeSearch.AutoSize = True
        Me.lblDxCodeSearch.Location = New System.Drawing.Point(356, 770)
        Me.lblDxCodeSearch.Name = "lblDxCodeSearch"
        Me.lblDxCodeSearch.Size = New System.Drawing.Size(69, 13)
        Me.lblDxCodeSearch.TabIndex = 253
        Me.lblDxCodeSearch.Text = "Add By Code"
        '
        'lblDxTextSearch
        '
        Me.lblDxTextSearch.AutoSize = True
        Me.lblDxTextSearch.Location = New System.Drawing.Point(9, 770)
        Me.lblDxTextSearch.Name = "lblDxTextSearch"
        Me.lblDxTextSearch.Size = New System.Drawing.Size(115, 13)
        Me.lblDxTextSearch.TabIndex = 251
        Me.lblDxTextSearch.Text = "Search New Diagnosis"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Location = New System.Drawing.Point(906, 731)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(59, 13)
        Me.Label73.TabIndex = 248
        Me.Label73.Text = "Dx Method"
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Location = New System.Drawing.Point(832, 731)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(48, 13)
        Me.Label72.TabIndex = 247
        Me.Label72.Text = "Dx Code"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Location = New System.Drawing.Point(688, 732)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(30, 13)
        Me.Label71.TabIndex = 246
        Me.Label71.Text = "Date"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(655, 673)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(108, 13)
        Me.Label70.TabIndex = 245
        Me.Label70.Text = "Dx Type Descriptions"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(655, 712)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(387, 13)
        Me.Label69.TabIndex = 244
        Me.Label69.Text = "Review Quantitative- NO diagnosis noted BUT clinical evidence exists (labs, etc)"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(655, 699)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(353, 13)
        Me.Label68.TabIndex = 243
        Me.Label68.Text = "Chart Qualitative- Diagnosis noted WITHOUT clinical evidence (labs, etc)"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(655, 686)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(337, 13)
        Me.Label67.TabIndex = 242
        Me.Label67.Text = "Chart Quantitative- Diagnosis noted WITH clinical evidence (labs, etc)"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(9, 731)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(53, 13)
        Me.Label66.TabIndex = 241
        Me.Label66.Text = "Diagnosis"
        '
        'txtDxCodeSearch
        '
        Me.txtDxCodeSearch.Location = New System.Drawing.Point(359, 786)
        Me.txtDxCodeSearch.Name = "txtDxCodeSearch"
        Me.txtDxCodeSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtDxCodeSearch.TabIndex = 252
        '
        'txtDxTextSearch
        '
        Me.txtDxTextSearch.Location = New System.Drawing.Point(9, 786)
        Me.txtDxTextSearch.Name = "txtDxTextSearch"
        Me.txtDxTextSearch.Size = New System.Drawing.Size(246, 20)
        Me.txtDxTextSearch.TabIndex = 250
        '
        'btnDxSearch
        '
        Me.btnDxSearch.Location = New System.Drawing.Point(261, 784)
        Me.btnDxSearch.Name = "btnDxSearch"
        Me.btnDxSearch.Size = New System.Drawing.Size(62, 23)
        Me.btnDxSearch.TabIndex = 239
        Me.btnDxSearch.Text = "Search"
        Me.btnDxSearch.UseVisualStyleBackColor = True
        '
        'btnAddCode
        '
        Me.btnAddCode.Location = New System.Drawing.Point(465, 784)
        Me.btnAddCode.Name = "btnAddCode"
        Me.btnAddCode.Size = New System.Drawing.Size(68, 23)
        Me.btnAddCode.TabIndex = 240
        Me.btnAddCode.Text = "Go"
        Me.btnAddCode.UseVisualStyleBackColor = True
        '
        'cmbDxMethod
        '
        Me.cmbDxMethod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDxMethod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDxMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDxMethod.FormattingEnabled = True
        Me.cmbDxMethod.Location = New System.Drawing.Point(909, 746)
        Me.cmbDxMethod.Name = "cmbDxMethod"
        Me.cmbDxMethod.Size = New System.Drawing.Size(121, 21)
        Me.cmbDxMethod.TabIndex = 238
        '
        'txtDxCode
        '
        Me.txtDxCode.Enabled = False
        Me.txtDxCode.Location = New System.Drawing.Point(835, 747)
        Me.txtDxCode.Name = "txtDxCode"
        Me.txtDxCode.Size = New System.Drawing.Size(68, 20)
        Me.txtDxCode.TabIndex = 237
        '
        'txtDxDate
        '
        Me.txtDxDate.Location = New System.Drawing.Point(688, 747)
        Me.txtDxDate.Mask = "00/00/0000"
        Me.txtDxDate.Name = "txtDxDate"
        Me.txtDxDate.Size = New System.Drawing.Size(67, 20)
        Me.txtDxDate.TabIndex = 236
        Me.txtDxDate.ValidatingType = GetType(Date)
        '
        'txtDx
        '
        Me.txtDx.Enabled = False
        Me.txtDx.Location = New System.Drawing.Point(9, 747)
        Me.txtDx.Name = "txtDx"
        Me.txtDx.Size = New System.Drawing.Size(673, 20)
        Me.txtDx.TabIndex = 235
        '
        'dgvDx
        '
        Me.dgvDx.AllowUserToAddRows = False
        Me.dgvDx.AllowUserToDeleteRows = False
        Me.dgvDx.AllowUserToOrderColumns = True
        Me.dgvDx.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Beige
        Me.dgvDx.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDx.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dgvDx.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvDx.BackgroundColor = System.Drawing.Color.Tan
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDx.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDx.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDx.GridColor = System.Drawing.Color.Linen
        Me.dgvDx.Location = New System.Drawing.Point(9, 198)
        Me.dgvDx.MultiSelect = False
        Me.dgvDx.Name = "dgvDx"
        Me.dgvDx.ReadOnly = True
        Me.dgvDx.RowHeadersVisible = False
        Me.dgvDx.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.dgvDx.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDx.Size = New System.Drawing.Size(1021, 472)
        Me.dgvDx.TabIndex = 233
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(758, 732)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1160
        Me.Label1.Text = "Code Type"
        '
        'txtDxCodeType
        '
        Me.txtDxCodeType.Enabled = False
        Me.txtDxCodeType.Location = New System.Drawing.Point(761, 747)
        Me.txtDxCodeType.Name = "txtDxCodeType"
        Me.txtDxCodeType.Size = New System.Drawing.Size(68, 20)
        Me.txtDxCodeType.TabIndex = 1159
        '
        'chkBrainClin
        '
        Me.chkBrainClin.AutoSize = True
        Me.chkBrainClin.BackColor = System.Drawing.Color.Tan
        Me.chkBrainClin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBrainClin.Location = New System.Drawing.Point(642, 787)
        Me.chkBrainClin.Name = "chkBrainClin"
        Me.chkBrainClin.Size = New System.Drawing.Size(155, 17)
        Me.chkBrainClin.TabIndex = 1161
        Me.chkBrainClin.Text = "Brain Related (or significant)"
        Me.chkBrainClin.UseVisualStyleBackColor = False
        '
        'grpClinDx
        '
        Me.grpClinDx.Controls.Add(Me.lblNoRecord)
        Me.grpClinDx.Controls.Add(Me.ClinTertDx3)
        Me.grpClinDx.Controls.Add(Me.ClinTertDx2)
        Me.grpClinDx.Controls.Add(Me.ClinTertDx1)
        Me.grpClinDx.Controls.Add(Me.ClinSecDx)
        Me.grpClinDx.Controls.Add(Me.ClinPrimDx)
        Me.grpClinDx.Controls.Add(Me.txtClinTertDx3)
        Me.grpClinDx.Controls.Add(Me.txtClinTertDx3Note)
        Me.grpClinDx.Controls.Add(Me.Label13)
        Me.grpClinDx.Controls.Add(Me.Label14)
        Me.grpClinDx.Controls.Add(Me.txtClinTertDx2)
        Me.grpClinDx.Controls.Add(Me.txtClinTertDx2Note)
        Me.grpClinDx.Controls.Add(Me.Label15)
        Me.grpClinDx.Controls.Add(Me.Label16)
        Me.grpClinDx.Controls.Add(Me.txtClinTertDx1)
        Me.grpClinDx.Controls.Add(Me.txtClinTertDx1Note)
        Me.grpClinDx.Controls.Add(Me.Label17)
        Me.grpClinDx.Controls.Add(Me.txtClinSecDx)
        Me.grpClinDx.Controls.Add(Me.txtClinSecDxNote)
        Me.grpClinDx.Controls.Add(Me.Label18)
        Me.grpClinDx.Controls.Add(Me.txtClinPrimDxNote)
        Me.grpClinDx.Controls.Add(Me.Label19)
        Me.grpClinDx.Controls.Add(Me.txtClinPrimDx)
        Me.grpClinDx.Controls.Add(Me.Label20)
        Me.grpClinDx.Controls.Add(Me.Label21)
        Me.grpClinDx.Controls.Add(Me.Label22)
        Me.grpClinDx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpClinDx.Location = New System.Drawing.Point(9, 813)
        Me.grpClinDx.Name = "grpClinDx"
        Me.grpClinDx.Size = New System.Drawing.Size(1021, 117)
        Me.grpClinDx.TabIndex = 1162
        Me.grpClinDx.TabStop = False
        Me.grpClinDx.Text = "Clinical Diagnosis"
        '
        'lblNoRecord
        '
        Me.lblNoRecord.AutoSize = True
        Me.lblNoRecord.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lblNoRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNoRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoRecord.Location = New System.Drawing.Point(145, 40)
        Me.lblNoRecord.Name = "lblNoRecord"
        Me.lblNoRecord.Size = New System.Drawing.Size(379, 33)
        Me.lblNoRecord.TabIndex = 1157
        Me.lblNoRecord.Text = "This section in development"
        '
        'ClinTertDx3
        '
        Me.ClinTertDx3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClinTertDx3.Location = New System.Drawing.Point(195, 88)
        Me.ClinTertDx3.Name = "ClinTertDx3"
        Me.ClinTertDx3.Size = New System.Drawing.Size(76, 21)
        Me.ClinTertDx3.TabIndex = 113
        Me.ClinTertDx3.Text = "Add/Change"
        Me.ClinTertDx3.UseVisualStyleBackColor = True
        '
        'ClinTertDx2
        '
        Me.ClinTertDx2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClinTertDx2.Location = New System.Drawing.Point(195, 69)
        Me.ClinTertDx2.Name = "ClinTertDx2"
        Me.ClinTertDx2.Size = New System.Drawing.Size(76, 21)
        Me.ClinTertDx2.TabIndex = 112
        Me.ClinTertDx2.Text = "Add/Change"
        Me.ClinTertDx2.UseVisualStyleBackColor = True
        '
        'ClinTertDx1
        '
        Me.ClinTertDx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClinTertDx1.Location = New System.Drawing.Point(195, 50)
        Me.ClinTertDx1.Name = "ClinTertDx1"
        Me.ClinTertDx1.Size = New System.Drawing.Size(76, 21)
        Me.ClinTertDx1.TabIndex = 111
        Me.ClinTertDx1.Text = "Add/Change"
        Me.ClinTertDx1.UseVisualStyleBackColor = True
        '
        'ClinSecDx
        '
        Me.ClinSecDx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClinSecDx.Location = New System.Drawing.Point(195, 31)
        Me.ClinSecDx.Name = "ClinSecDx"
        Me.ClinSecDx.Size = New System.Drawing.Size(76, 21)
        Me.ClinSecDx.TabIndex = 110
        Me.ClinSecDx.Text = "Add/Change"
        Me.ClinSecDx.UseVisualStyleBackColor = True
        '
        'ClinPrimDx
        '
        Me.ClinPrimDx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClinPrimDx.Location = New System.Drawing.Point(195, 12)
        Me.ClinPrimDx.Name = "ClinPrimDx"
        Me.ClinPrimDx.Size = New System.Drawing.Size(76, 21)
        Me.ClinPrimDx.TabIndex = 109
        Me.ClinPrimDx.Text = "Add/Change"
        Me.ClinPrimDx.UseVisualStyleBackColor = True
        '
        'txtClinTertDx3
        '
        Me.txtClinTertDx3.BackColor = System.Drawing.Color.LightGray
        Me.txtClinTertDx3.Enabled = False
        Me.txtClinTertDx3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClinTertDx3.Location = New System.Drawing.Point(86, 89)
        Me.txtClinTertDx3.Name = "txtClinTertDx3"
        Me.txtClinTertDx3.Size = New System.Drawing.Size(100, 20)
        Me.txtClinTertDx3.TabIndex = 22
        '
        'txtClinTertDx3Note
        '
        Me.txtClinTertDx3Note.BackColor = System.Drawing.Color.LightGray
        Me.txtClinTertDx3Note.Enabled = False
        Me.txtClinTertDx3Note.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClinTertDx3Note.Location = New System.Drawing.Point(340, 89)
        Me.txtClinTertDx3Note.Name = "txtClinTertDx3Note"
        Me.txtClinTertDx3Note.Size = New System.Drawing.Size(675, 20)
        Me.txtClinTertDx3Note.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(274, 92)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Description"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 92)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Tertiary Dx 3"
        '
        'txtClinTertDx2
        '
        Me.txtClinTertDx2.BackColor = System.Drawing.Color.LightGray
        Me.txtClinTertDx2.Enabled = False
        Me.txtClinTertDx2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClinTertDx2.Location = New System.Drawing.Point(86, 70)
        Me.txtClinTertDx2.Name = "txtClinTertDx2"
        Me.txtClinTertDx2.Size = New System.Drawing.Size(100, 20)
        Me.txtClinTertDx2.TabIndex = 20
        '
        'txtClinTertDx2Note
        '
        Me.txtClinTertDx2Note.BackColor = System.Drawing.Color.LightGray
        Me.txtClinTertDx2Note.Enabled = False
        Me.txtClinTertDx2Note.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClinTertDx2Note.Location = New System.Drawing.Point(340, 70)
        Me.txtClinTertDx2Note.Name = "txtClinTertDx2Note"
        Me.txtClinTertDx2Note.Size = New System.Drawing.Size(675, 20)
        Me.txtClinTertDx2Note.TabIndex = 21
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(274, 73)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 13)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Description"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 73)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 13)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Tertiary Dx 2"
        '
        'txtClinTertDx1
        '
        Me.txtClinTertDx1.BackColor = System.Drawing.Color.LightGray
        Me.txtClinTertDx1.Enabled = False
        Me.txtClinTertDx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClinTertDx1.Location = New System.Drawing.Point(86, 51)
        Me.txtClinTertDx1.Name = "txtClinTertDx1"
        Me.txtClinTertDx1.Size = New System.Drawing.Size(100, 20)
        Me.txtClinTertDx1.TabIndex = 18
        '
        'txtClinTertDx1Note
        '
        Me.txtClinTertDx1Note.BackColor = System.Drawing.Color.LightGray
        Me.txtClinTertDx1Note.Enabled = False
        Me.txtClinTertDx1Note.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClinTertDx1Note.Location = New System.Drawing.Point(340, 51)
        Me.txtClinTertDx1Note.Name = "txtClinTertDx1Note"
        Me.txtClinTertDx1Note.Size = New System.Drawing.Size(675, 20)
        Me.txtClinTertDx1Note.TabIndex = 19
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(274, 54)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 13)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Description"
        '
        'txtClinSecDx
        '
        Me.txtClinSecDx.BackColor = System.Drawing.Color.LightGray
        Me.txtClinSecDx.Enabled = False
        Me.txtClinSecDx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClinSecDx.Location = New System.Drawing.Point(86, 32)
        Me.txtClinSecDx.Name = "txtClinSecDx"
        Me.txtClinSecDx.Size = New System.Drawing.Size(100, 20)
        Me.txtClinSecDx.TabIndex = 16
        '
        'txtClinSecDxNote
        '
        Me.txtClinSecDxNote.BackColor = System.Drawing.Color.LightGray
        Me.txtClinSecDxNote.Enabled = False
        Me.txtClinSecDxNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClinSecDxNote.Location = New System.Drawing.Point(340, 32)
        Me.txtClinSecDxNote.Name = "txtClinSecDxNote"
        Me.txtClinSecDxNote.Size = New System.Drawing.Size(675, 20)
        Me.txtClinSecDxNote.TabIndex = 17
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(274, 35)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 13)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Description"
        '
        'txtClinPrimDxNote
        '
        Me.txtClinPrimDxNote.BackColor = System.Drawing.Color.LightGray
        Me.txtClinPrimDxNote.Enabled = False
        Me.txtClinPrimDxNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClinPrimDxNote.Location = New System.Drawing.Point(340, 13)
        Me.txtClinPrimDxNote.Name = "txtClinPrimDxNote"
        Me.txtClinPrimDxNote.Size = New System.Drawing.Size(675, 20)
        Me.txtClinPrimDxNote.TabIndex = 15
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(274, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 13)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Description"
        '
        'txtClinPrimDx
        '
        Me.txtClinPrimDx.BackColor = System.Drawing.Color.LightGray
        Me.txtClinPrimDx.Enabled = False
        Me.txtClinPrimDx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClinPrimDx.Location = New System.Drawing.Point(86, 13)
        Me.txtClinPrimDx.Name = "txtClinPrimDx"
        Me.txtClinPrimDx.Size = New System.Drawing.Size(100, 20)
        Me.txtClinPrimDx.TabIndex = 14
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 54)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(67, 13)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Tertiary Dx 1"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(6, 35)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(74, 13)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Secondary Dx"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(6, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(57, 13)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Primary Dx"
        '
        'btnShowBrainOnly
        '
        Me.btnShowBrainOnly.Location = New System.Drawing.Point(422, 169)
        Me.btnShowBrainOnly.Name = "btnShowBrainOnly"
        Me.btnShowBrainOnly.Size = New System.Drawing.Size(195, 23)
        Me.btnShowBrainOnly.TabIndex = 1163
        Me.btnShowBrainOnly.Text = "Show Only Brain Related Dx's"
        Me.btnShowBrainOnly.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(800, 770)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 13)
        Me.Label12.TabIndex = 1165
        Me.Label12.Text = "Brain Related Rank"
        '
        'txtBrainRelatedRank
        '
        Me.txtBrainRelatedRank.Location = New System.Drawing.Point(803, 786)
        Me.txtBrainRelatedRank.Name = "txtBrainRelatedRank"
        Me.txtBrainRelatedRank.Size = New System.Drawing.Size(100, 20)
        Me.txtBrainRelatedRank.TabIndex = 1164
        '
        'lblNumRows
        '
        Me.lblNumRows.AutoSize = True
        Me.lblNumRows.Location = New System.Drawing.Point(6, 673)
        Me.lblNumRows.Name = "lblNumRows"
        Me.lblNumRows.Size = New System.Drawing.Size(39, 13)
        Me.lblNumRows.TabIndex = 1195
        Me.lblNumRows.Text = "Label2"
        '
        'eqModel
        '
        Me.eqModel.CustomInfo = ""
        Me.eqModel.DbContext = Nothing
        Me.eqModel.DefQueryFilePath = ""
        Me.eqModel.Description = Nothing
        Me.eqModel.EntityContainerName = ""
        Me.eqModel.ID = "edd0b313-9e62-4939-b414-df473fbfc35d"
        Me.eqModel.IsLoadedFromDbContext = False
        Me.eqModel.ModelName = Nothing
        Me.eqModel.ProgressIndicator = Nothing
        '
        'eqQuery
        '
        Me.eqQuery.ExtraColumns = ""
        Me.eqQuery.FilePath = ""
        Me.eqQuery.Formats.DateTimeFormat = "yyyy-MM-dd HH:mm"
        Me.eqQuery.Formats.EscapeSymbol = ""
        Me.eqQuery.Formats.FalseValue = "0"
        Me.eqQuery.Formats.FormatType = Korzh.EasyQuery.Db.FormatType.MsSqlServer
        Me.eqQuery.Formats.MoneySuffix = ""
        Me.eqQuery.Formats.OrderByStyle = Korzh.EasyQuery.OrderByStyles.Aliases
        Me.eqQuery.Formats.QuoteBool = False
        Me.eqQuery.Formats.QuoteColumnAlias = False
        Me.eqQuery.Formats.TimeFormat = "HH:mm"
        Me.eqQuery.Formats.TrueValue = "1"
        Me.eqQuery.Formats.WildSymbol = Global.Microsoft.VisualBasic.ChrW(37)
        Me.eqQuery.ID = "d5495f59-7414-4a1e-bceb-910361f5a3b7"
        Me.eqQuery.Model = Me.eqModel
        Me.eqQuery.NoPathResolution = Korzh.EasyQuery.NoPathResolution.ThrowException
        Me.eqQuery.SyncColSortOrder = True
        '
        'pnlQuery
        '
        Me.pnlQuery.Active = True
        Me.pnlQuery.ActiveRowIndex = 0
        Me.pnlQuery.Appearance.ActiveBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.pnlQuery.Appearance.ActiveForeColor = System.Drawing.SystemColors.HighlightText
        Me.pnlQuery.Appearance.ButtonForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlQuery.Appearance.FocusBorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pnlQuery.Appearance.ShowRootRow = True
        Me.pnlQuery.Location = New System.Drawing.Point(9, 3)
        Me.pnlQuery.Name = "pnlQuery"
        Me.pnlQuery.Query = Me.eqQuery
        Me.pnlQuery.Size = New System.Drawing.Size(1021, 160)
        Me.pnlQuery.TabIndex = 1196
        Me.pnlQuery.TabStop = True
        '
        'btnQuery
        '
        Me.btnQuery.Location = New System.Drawing.Point(9, 169)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(75, 23)
        Me.btnQuery.TabIndex = 1197
        Me.btnQuery.Text = "Apply Query"
        Me.btnQuery.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(90, 169)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 1198
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(901, 169)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(129, 23)
        Me.btnExport.TabIndex = 1199
        Me.btnExport.Text = "Export Table"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'WA_PMCR_Diagnoses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnQuery)
        Me.Controls.Add(Me.pnlQuery)
        Me.Controls.Add(Me.lblNumRows)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtBrainRelatedRank)
        Me.Controls.Add(Me.btnShowBrainOnly)
        Me.Controls.Add(Me.grpClinDx)
        Me.Controls.Add(Me.chkBrainClin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDxCodeType)
        Me.Controls.Add(Me.btnRemoveDx)
        Me.Controls.Add(Me.btnDxChange)
        Me.Controls.Add(Me.btnDxSave)
        Me.Controls.Add(Me.lblDxCodeSearch)
        Me.Controls.Add(Me.lblDxTextSearch)
        Me.Controls.Add(Me.Label73)
        Me.Controls.Add(Me.Label72)
        Me.Controls.Add(Me.Label71)
        Me.Controls.Add(Me.Label70)
        Me.Controls.Add(Me.Label69)
        Me.Controls.Add(Me.Label68)
        Me.Controls.Add(Me.Label67)
        Me.Controls.Add(Me.Label66)
        Me.Controls.Add(Me.txtDxCodeSearch)
        Me.Controls.Add(Me.txtDxTextSearch)
        Me.Controls.Add(Me.btnDxSearch)
        Me.Controls.Add(Me.btnAddCode)
        Me.Controls.Add(Me.cmbDxMethod)
        Me.Controls.Add(Me.txtDxCode)
        Me.Controls.Add(Me.txtDxDate)
        Me.Controls.Add(Me.txtDx)
        Me.Controls.Add(Me.dgvDx)
        Me.Name = "WA_PMCR_Diagnoses"
        Me.Size = New System.Drawing.Size(1046, 933)
        CType(Me.dgvDx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpClinDx.ResumeLayout(False)
        Me.grpClinDx.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRemoveDx As DataWarehouse.Button_
    Friend WithEvents btnDxChange As DataWarehouse.Button_
    Friend WithEvents btnDxSave As DataWarehouse.Button_
    Friend WithEvents lblDxCodeSearch As System.Windows.Forms.Label
    Friend WithEvents lblDxTextSearch As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents txtDxCodeSearch As DataWarehouse.TextBox_
    Friend WithEvents txtDxTextSearch As DataWarehouse.TextBox_
    Friend WithEvents btnDxSearch As DataWarehouse.Button_
    Friend WithEvents btnAddCode As DataWarehouse.Button_
    Friend WithEvents cmbDxMethod As DataWarehouse.ComboBox_
    Friend WithEvents txtDxCode As DataWarehouse.TextBox_
    Friend WithEvents txtDxDate As DataWarehouse.TextBoxDatePast
    Friend WithEvents txtDx As DataWarehouse.TextBox_
    Friend WithEvents dgvDx As DataWarehouse.dgvSingleRow
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDxCodeType As TextBox_
    Friend WithEvents chkBrainClin As CheckBox_
    Friend WithEvents grpClinDx As GroupBox
    Friend WithEvents ClinTertDx3 As Button_
    Friend WithEvents ClinTertDx2 As Button_
    Friend WithEvents ClinTertDx1 As Button_
    Friend WithEvents ClinSecDx As Button_
    Friend WithEvents ClinPrimDx As Button_
    Friend WithEvents txtClinTertDx3 As TextBox_
    Friend WithEvents txtClinTertDx3Note As TextBox_
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtClinTertDx2 As TextBox_
    Friend WithEvents txtClinTertDx2Note As TextBox_
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtClinTertDx1 As TextBox_
    Friend WithEvents txtClinTertDx1Note As TextBox_
    Friend WithEvents Label17 As Label
    Friend WithEvents txtClinSecDx As TextBox_
    Friend WithEvents txtClinSecDxNote As TextBox_
    Friend WithEvents Label18 As Label
    Friend WithEvents txtClinPrimDxNote As TextBox_
    Friend WithEvents Label19 As Label
    Friend WithEvents txtClinPrimDx As TextBox_
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lblNoRecord As Label
    Friend WithEvents btnShowBrainOnly As Button_
    Friend WithEvents Label12 As Label
    Friend WithEvents txtBrainRelatedRank As TextBoxInteger
    Friend WithEvents lblNumRows As Label
    Friend WithEvents eqModel As Korzh.EasyQuery.Db.DbModel
    Friend WithEvents eqQuery As Korzh.EasyQuery.Db.DbQuery
    Friend WithEvents pnlQuery As Korzh.EasyQuery.WinControls.QueryPanel
    Friend WithEvents btnQuery As Button_
    Friend WithEvents btnReset As Button_
    Friend WithEvents btnExport As Button_
End Class
