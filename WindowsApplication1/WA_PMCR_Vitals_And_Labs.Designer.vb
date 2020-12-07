<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WA_PMCR_Vitals_And_Labs
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grpMisc = New System.Windows.Forms.GroupBox()
        Me.btnXray = New DataWarehouse.Button_()
        Me.Label738 = New System.Windows.Forms.Label()
        Me.Label737 = New System.Windows.Forms.Label()
        Me.txtECG = New DataWarehouse.TextBox_()
        Me.Label736 = New System.Windows.Forms.Label()
        Me.dtECG = New DataWarehouse.TextBoxDatePast()
        Me.cmbECG = New DataWarehouse.ComboBox_()
        Me.txtChestXray = New DataWarehouse.TextBox_()
        Me.Label739 = New System.Windows.Forms.Label()
        Me.dtChestXRay = New DataWarehouse.TextBoxDatePast()
        Me.cmbChestXray = New DataWarehouse.ComboBox_()
        Me.grpLabs = New System.Windows.Forms.GroupBox()
        Me.CheckBox_2 = New DataWarehouse.CheckBox_()
        Me.CheckBox_1 = New DataWarehouse.CheckBox_()
        Me.btnReset = New DataWarehouse.Button_()
        Me.btnQuery = New DataWarehouse.Button_()
        Me.pnlQuery = New Korzh.EasyQuery.WinControls.QueryPanel()
        Me.eqQuery = New Korzh.EasyQuery.Db.DbQuery()
        Me.eqModel = New Korzh.EasyQuery.Db.DbModel()
        Me.btnEditLab = New DataWarehouse.Button_()
        Me.btnAddLab = New DataWarehouse.Button_()
        Me.dgvLabs = New DataWarehouse.dgvSingleRow()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbApoE = New DataWarehouse.ComboBox_()
        Me.btnApoEMod = New DataWarehouse.Button_()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpH = New DataWarehouse.TextBox_()
        Me.grpMisc.SuspendLayout()
        Me.grpLabs.SuspendLayout()
        CType(Me.dgvLabs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMisc
        '
        Me.grpMisc.Controls.Add(Me.btnXray)
        Me.grpMisc.Controls.Add(Me.Label738)
        Me.grpMisc.Controls.Add(Me.Label737)
        Me.grpMisc.Controls.Add(Me.txtECG)
        Me.grpMisc.Controls.Add(Me.Label736)
        Me.grpMisc.Controls.Add(Me.dtECG)
        Me.grpMisc.Controls.Add(Me.cmbECG)
        Me.grpMisc.Controls.Add(Me.txtChestXray)
        Me.grpMisc.Controls.Add(Me.Label739)
        Me.grpMisc.Controls.Add(Me.dtChestXRay)
        Me.grpMisc.Controls.Add(Me.cmbChestXray)
        Me.grpMisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMisc.Location = New System.Drawing.Point(3, 750)
        Me.grpMisc.Name = "grpMisc"
        Me.grpMisc.Size = New System.Drawing.Size(1033, 261)
        Me.grpMisc.TabIndex = 225
        Me.grpMisc.TabStop = False
        Me.grpMisc.Text = "Chest X-Ray"
        '
        'btnXray
        '
        Me.btnXray.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXray.Location = New System.Drawing.Point(6, 232)
        Me.btnXray.Name = "btnXray"
        Me.btnXray.Size = New System.Drawing.Size(130, 23)
        Me.btnXray.TabIndex = 14
        Me.btnXray.Text = "Button_1"
        Me.btnXray.UseVisualStyleBackColor = True
        '
        'Label738
        '
        Me.Label738.AutoSize = True
        Me.Label738.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label738.Location = New System.Drawing.Point(501, 16)
        Me.Label738.Name = "Label738"
        Me.Label738.Size = New System.Drawing.Size(56, 13)
        Me.Label738.TabIndex = 13
        Me.Label738.Text = "ECG/EKG"
        '
        'Label737
        '
        Me.Label737.AutoSize = True
        Me.Label737.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label737.Location = New System.Drawing.Point(6, 16)
        Me.Label737.Name = "Label737"
        Me.Label737.Size = New System.Drawing.Size(66, 13)
        Me.Label737.TabIndex = 12
        Me.Label737.Text = "Chest X-Ray"
        '
        'txtECG
        '
        Me.txtECG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtECG.Location = New System.Drawing.Point(504, 72)
        Me.txtECG.Multiline = True
        Me.txtECG.Name = "txtECG"
        Me.txtECG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtECG.Size = New System.Drawing.Size(492, 154)
        Me.txtECG.TabIndex = 11
        '
        'Label736
        '
        Me.Label736.AutoSize = True
        Me.Label736.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label736.Location = New System.Drawing.Point(501, 56)
        Me.Label736.Name = "Label736"
        Me.Label736.Size = New System.Drawing.Size(35, 13)
        Me.Label736.TabIndex = 10
        Me.Label736.Text = "Notes"
        '
        'dtECG
        '
        Me.dtECG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtECG.Location = New System.Drawing.Point(631, 32)
        Me.dtECG.Mask = "00/00/0000"
        Me.dtECG.Name = "dtECG"
        Me.dtECG.Size = New System.Drawing.Size(67, 20)
        Me.dtECG.TabIndex = 9
        Me.dtECG.ValidatingType = GetType(Date)
        '
        'cmbECG
        '
        Me.cmbECG.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbECG.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbECG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbECG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbECG.FormattingEnabled = True
        Me.cmbECG.Location = New System.Drawing.Point(504, 32)
        Me.cmbECG.Name = "cmbECG"
        Me.cmbECG.Size = New System.Drawing.Size(121, 21)
        Me.cmbECG.TabIndex = 8
        '
        'txtChestXray
        '
        Me.txtChestXray.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChestXray.Location = New System.Drawing.Point(6, 72)
        Me.txtChestXray.Multiline = True
        Me.txtChestXray.Name = "txtChestXray"
        Me.txtChestXray.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtChestXray.Size = New System.Drawing.Size(492, 154)
        Me.txtChestXray.TabIndex = 3
        '
        'Label739
        '
        Me.Label739.AutoSize = True
        Me.Label739.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label739.Location = New System.Drawing.Point(3, 56)
        Me.Label739.Name = "Label739"
        Me.Label739.Size = New System.Drawing.Size(35, 13)
        Me.Label739.TabIndex = 2
        Me.Label739.Text = "Notes"
        '
        'dtChestXRay
        '
        Me.dtChestXRay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtChestXRay.Location = New System.Drawing.Point(133, 32)
        Me.dtChestXRay.Mask = "00/00/0000"
        Me.dtChestXRay.Name = "dtChestXRay"
        Me.dtChestXRay.Size = New System.Drawing.Size(67, 20)
        Me.dtChestXRay.TabIndex = 1
        Me.dtChestXRay.ValidatingType = GetType(Date)
        '
        'cmbChestXray
        '
        Me.cmbChestXray.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbChestXray.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbChestXray.BackColor = System.Drawing.Color.LightSkyBlue
        Me.cmbChestXray.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChestXray.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbChestXray.FormattingEnabled = True
        Me.cmbChestXray.Location = New System.Drawing.Point(6, 32)
        Me.cmbChestXray.Name = "cmbChestXray"
        Me.cmbChestXray.Size = New System.Drawing.Size(121, 21)
        Me.cmbChestXray.TabIndex = 0
        '
        'grpLabs
        '
        Me.grpLabs.Controls.Add(Me.CheckBox_2)
        Me.grpLabs.Controls.Add(Me.CheckBox_1)
        Me.grpLabs.Controls.Add(Me.btnReset)
        Me.grpLabs.Controls.Add(Me.btnQuery)
        Me.grpLabs.Controls.Add(Me.pnlQuery)
        Me.grpLabs.Controls.Add(Me.btnEditLab)
        Me.grpLabs.Controls.Add(Me.btnAddLab)
        Me.grpLabs.Controls.Add(Me.dgvLabs)
        Me.grpLabs.Cursor = System.Windows.Forms.Cursors.Default
        Me.grpLabs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLabs.Location = New System.Drawing.Point(3, 3)
        Me.grpLabs.Name = "grpLabs"
        Me.grpLabs.Size = New System.Drawing.Size(1033, 695)
        Me.grpLabs.TabIndex = 224
        Me.grpLabs.TabStop = False
        Me.grpLabs.Text = "Vitals and Labs"
        '
        'CheckBox_2
        '
        Me.CheckBox_2.AutoSize = True
        Me.CheckBox_2.BackColor = System.Drawing.Color.Tan
        Me.CheckBox_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox_2.Location = New System.Drawing.Point(845, 203)
        Me.CheckBox_2.Name = "CheckBox_2"
        Me.CheckBox_2.Size = New System.Drawing.Size(72, 17)
        Me.CheckBox_2.TabIndex = 249
        Me.CheckBox_2.Text = "Serology"
        Me.CheckBox_2.UseVisualStyleBackColor = False
        '
        'CheckBox_1
        '
        Me.CheckBox_1.AutoSize = True
        Me.CheckBox_1.BackColor = System.Drawing.Color.Tan
        Me.CheckBox_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox_1.Location = New System.Drawing.Point(745, 203)
        Me.CheckBox_1.Name = "CheckBox_1"
        Me.CheckBox_1.Size = New System.Drawing.Size(84, 17)
        Me.CheckBox_1.TabIndex = 248
        Me.CheckBox_1.Text = "Toxicology"
        Me.CheckBox_1.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(119, 192)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(108, 23)
        Me.btnReset.TabIndex = 246
        Me.btnReset.Text = "Reset Query"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnQuery
        '
        Me.btnQuery.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuery.Location = New System.Drawing.Point(5, 192)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(108, 23)
        Me.btnQuery.TabIndex = 245
        Me.btnQuery.Text = "Run Query"
        Me.btnQuery.UseVisualStyleBackColor = True
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
        Me.pnlQuery.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlQuery.Location = New System.Drawing.Point(6, 19)
        Me.pnlQuery.Name = "pnlQuery"
        Me.pnlQuery.Query = Me.eqQuery
        Me.pnlQuery.Size = New System.Drawing.Size(1021, 167)
        Me.pnlQuery.TabIndex = 244
        Me.pnlQuery.TabStop = True
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
        Me.eqQuery.ID = "682e440f-3f52-48a2-9fe3-4b1b1750b623"
        Me.eqQuery.Model = Me.eqModel
        Me.eqQuery.NoPathResolution = Korzh.EasyQuery.NoPathResolution.ThrowException
        Me.eqQuery.SyncColSortOrder = True
        '
        'eqModel
        '
        Me.eqModel.CustomInfo = ""
        Me.eqModel.DbContext = Nothing
        Me.eqModel.DefQueryFilePath = ""
        Me.eqModel.Description = Nothing
        Me.eqModel.EntityContainerName = ""
        Me.eqModel.ID = "f8d4087d-c6db-4e26-9529-a9cf7f3933ac"
        Me.eqModel.IsLoadedFromDbContext = False
        Me.eqModel.ModelName = Nothing
        Me.eqModel.ProgressIndicator = Nothing
        '
        'btnEditLab
        '
        Me.btnEditLab.Enabled = False
        Me.btnEditLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditLab.Location = New System.Drawing.Point(6, 666)
        Me.btnEditLab.Name = "btnEditLab"
        Me.btnEditLab.Size = New System.Drawing.Size(130, 23)
        Me.btnEditLab.TabIndex = 243
        Me.btnEditLab.Text = "Edit Selected Record"
        Me.btnEditLab.UseVisualStyleBackColor = True
        '
        'btnAddLab
        '
        Me.btnAddLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddLab.Location = New System.Drawing.Point(140, 666)
        Me.btnAddLab.Name = "btnAddLab"
        Me.btnAddLab.Size = New System.Drawing.Size(130, 23)
        Me.btnAddLab.TabIndex = 236
        Me.btnAddLab.Text = "Add New Lab"
        Me.btnAddLab.UseVisualStyleBackColor = True
        '
        'dgvLabs
        '
        Me.dgvLabs.AllowUserToAddRows = False
        Me.dgvLabs.AllowUserToDeleteRows = False
        Me.dgvLabs.AllowUserToOrderColumns = True
        Me.dgvLabs.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige
        Me.dgvLabs.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLabs.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dgvLabs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvLabs.BackgroundColor = System.Drawing.Color.Tan
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLabs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLabs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLabs.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvLabs.GridColor = System.Drawing.Color.Linen
        Me.dgvLabs.Location = New System.Drawing.Point(6, 221)
        Me.dgvLabs.MultiSelect = False
        Me.dgvLabs.Name = "dgvLabs"
        Me.dgvLabs.ReadOnly = True
        Me.dgvLabs.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvLabs.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvLabs.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.dgvLabs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLabs.Size = New System.Drawing.Size(1021, 439)
        Me.dgvLabs.TabIndex = 235
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtpH)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbApoE)
        Me.GroupBox1.Controls.Add(Me.btnApoEMod)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 705)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1033, 39)
        Me.GroupBox1.TabIndex = 226
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Misc Labs"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(104, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "PostmortempH"
        '
        'cmbApoE
        '
        Me.cmbApoE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbApoE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbApoE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbApoE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbApoE.FormattingEnabled = True
        Me.cmbApoE.Items.AddRange(New Object() {"", "2/2", "2/3", "2/4", "3/3", "3/4", "4/4"})
        Me.cmbApoE.Location = New System.Drawing.Point(45, 13)
        Me.cmbApoE.Name = "cmbApoE"
        Me.cmbApoE.Size = New System.Drawing.Size(54, 21)
        Me.cmbApoE.TabIndex = 3
        '
        'btnApoEMod
        '
        Me.btnApoEMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApoEMod.Location = New System.Drawing.Point(251, 13)
        Me.btnApoEMod.Name = "btnApoEMod"
        Me.btnApoEMod.Size = New System.Drawing.Size(85, 23)
        Me.btnApoEMod.TabIndex = 2
        Me.btnApoEMod.Text = "Modify"
        Me.btnApoEMod.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ApoE"
        '
        'txtpH
        '
        Me.txtpH.Location = New System.Drawing.Point(185, 14)
        Me.txtpH.Name = "txtpH"
        Me.txtpH.Size = New System.Drawing.Size(54, 20)
        Me.txtpH.TabIndex = 7
        '
        'WA_PMCR_Vitals_And_Labs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpMisc)
        Me.Controls.Add(Me.grpLabs)
        Me.Name = "WA_PMCR_Vitals_And_Labs"
        Me.Size = New System.Drawing.Size(1043, 1017)
        Me.grpMisc.ResumeLayout(False)
        Me.grpMisc.PerformLayout()
        Me.grpLabs.ResumeLayout(False)
        Me.grpLabs.PerformLayout()
        CType(Me.dgvLabs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpMisc As GroupBox
    Friend WithEvents Label738 As Label
    Friend WithEvents Label737 As Label
    Friend WithEvents txtECG As TextBox_
    Friend WithEvents Label736 As Label
    Friend WithEvents dtECG As TextBoxDatePast
    Friend WithEvents cmbECG As ComboBox_
    Friend WithEvents txtChestXray As TextBox_
    Friend WithEvents Label739 As Label
    Friend WithEvents dtChestXRay As TextBoxDatePast
    Friend WithEvents cmbChestXray As ComboBox_
    Friend WithEvents btnEditLab As Button_
    Friend WithEvents btnAddLab As Button_
    Friend WithEvents dgvLabs As dgvSingleRow
    Friend WithEvents btnXray As Button_
    Friend WithEvents grpLabs As GroupBox
    Friend WithEvents pnlQuery As Korzh.EasyQuery.WinControls.QueryPanel
    Friend WithEvents eqQuery As Korzh.EasyQuery.Db.DbQuery
    Friend WithEvents eqModel As Korzh.EasyQuery.Db.DbModel
    Friend WithEvents btnReset As Button_
    Friend WithEvents btnQuery As Button_
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnApoEMod As Button_
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbApoE As ComboBox_
    Friend WithEvents CheckBox_2 As CheckBox_
    Friend WithEvents CheckBox_1 As CheckBox_
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpH As TextBox_
End Class
