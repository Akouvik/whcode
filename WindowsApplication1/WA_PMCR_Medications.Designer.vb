<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WA_PMCR_Medications
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
        Me.Label1358 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.numDosage = New DataWarehouse.TextBoxNumeric()
        Me.dtEnded = New DataWarehouse.TextBoxDatePast()
        Me.dtStarted = New DataWarehouse.TextBoxDatePast()
        Me.txtDosageUnits = New DataWarehouse.TextBox_()
        Me.txtGenericName = New DataWarehouse.TextBox_()
        Me.txtBrandName = New DataWarehouse.TextBox_()
        Me.btnEditMed = New DataWarehouse.Button_()
        Me.btnNewMed = New DataWarehouse.Button_()
        Me.dgvMeds = New DataWarehouse.dgvSingleRow()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbRoute = New DataWarehouse.ComboBox_()
        Me.eqModel = New Korzh.EasyQuery.Db.DbModel()
        Me.eqQuery = New Korzh.EasyQuery.Db.DbQuery()
        Me.pnlQuery = New Korzh.EasyQuery.WinControls.QueryPanel()
        Me.btnReset = New DataWarehouse.Button_()
        Me.btnQuery = New DataWarehouse.Button_()
        Me.btnExport = New DataWarehouse.Button_()
        Me.lblNumRows = New System.Windows.Forms.Label()
        CType(Me.dgvMeds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1358
        '
        Me.Label1358.AutoSize = True
        Me.Label1358.Location = New System.Drawing.Point(4, 566)
        Me.Label1358.Name = "Label1358"
        Me.Label1358.Size = New System.Drawing.Size(70, 13)
        Me.Label1358.TabIndex = 1180
        Me.Label1358.Text = "Daily Dosage"
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Location = New System.Drawing.Point(450, 566)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(38, 13)
        Me.Label80.TabIndex = 1165
        Me.Label80.Text = "Ended"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Location = New System.Drawing.Point(377, 566)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(41, 13)
        Me.Label79.TabIndex = 1164
        Me.Label79.Text = "Started"
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Location = New System.Drawing.Point(111, 566)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(135, 13)
        Me.Label77.TabIndex = 1162
        Me.Label77.Text = "Dosage Units (mg, mL, etc)"
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Location = New System.Drawing.Point(4, 527)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(164, 13)
        Me.Label76.TabIndex = 1161
        Me.Label76.Text = "Generic Name (Active Ingredient)"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Location = New System.Drawing.Point(4, 488)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(66, 13)
        Me.Label75.TabIndex = 1160
        Me.Label75.Text = "Brand Name"
        '
        'numDosage
        '
        Me.numDosage.Location = New System.Drawing.Point(7, 582)
        Me.numDosage.Name = "numDosage"
        Me.numDosage.Size = New System.Drawing.Size(100, 20)
        Me.numDosage.TabIndex = 4
        '
        'dtEnded
        '
        Me.dtEnded.Location = New System.Drawing.Point(453, 582)
        Me.dtEnded.Mask = "00/00/0000"
        Me.dtEnded.Name = "dtEnded"
        Me.dtEnded.Size = New System.Drawing.Size(67, 20)
        Me.dtEnded.TabIndex = 7
        Me.dtEnded.ValidatingType = GetType(Date)
        '
        'dtStarted
        '
        Me.dtStarted.Location = New System.Drawing.Point(380, 582)
        Me.dtStarted.Mask = "00/00/0000"
        Me.dtStarted.Name = "dtStarted"
        Me.dtStarted.Size = New System.Drawing.Size(67, 20)
        Me.dtStarted.TabIndex = 6
        Me.dtStarted.ValidatingType = GetType(Date)
        '
        'txtDosageUnits
        '
        Me.txtDosageUnits.Location = New System.Drawing.Point(113, 582)
        Me.txtDosageUnits.Name = "txtDosageUnits"
        Me.txtDosageUnits.Size = New System.Drawing.Size(133, 20)
        Me.txtDosageUnits.TabIndex = 5
        '
        'txtGenericName
        '
        Me.txtGenericName.Enabled = False
        Me.txtGenericName.Location = New System.Drawing.Point(7, 543)
        Me.txtGenericName.Name = "txtGenericName"
        Me.txtGenericName.Size = New System.Drawing.Size(1021, 20)
        Me.txtGenericName.TabIndex = 1170
        Me.txtGenericName.TabStop = False
        '
        'txtBrandName
        '
        Me.txtBrandName.Enabled = False
        Me.txtBrandName.Location = New System.Drawing.Point(7, 504)
        Me.txtBrandName.Name = "txtBrandName"
        Me.txtBrandName.Size = New System.Drawing.Size(1021, 20)
        Me.txtBrandName.TabIndex = 1169
        Me.txtBrandName.TabStop = False
        '
        'btnEditMed
        '
        Me.btnEditMed.Location = New System.Drawing.Point(193, 608)
        Me.btnEditMed.Name = "btnEditMed"
        Me.btnEditMed.Size = New System.Drawing.Size(180, 23)
        Me.btnEditMed.TabIndex = 9
        Me.btnEditMed.Text = "Edit Selected Medication"
        Me.btnEditMed.UseVisualStyleBackColor = True
        '
        'btnNewMed
        '
        Me.btnNewMed.Location = New System.Drawing.Point(7, 608)
        Me.btnNewMed.Name = "btnNewMed"
        Me.btnNewMed.Size = New System.Drawing.Size(180, 23)
        Me.btnNewMed.TabIndex = 8
        Me.btnNewMed.Text = "Add New Medication"
        Me.btnNewMed.UseVisualStyleBackColor = True
        '
        'dgvMeds
        '
        Me.dgvMeds.AllowUserToAddRows = False
        Me.dgvMeds.AllowUserToDeleteRows = False
        Me.dgvMeds.AllowUserToOrderColumns = True
        Me.dgvMeds.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige
        Me.dgvMeds.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMeds.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dgvMeds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvMeds.BackgroundColor = System.Drawing.Color.Tan
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMeds.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMeds.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMeds.GridColor = System.Drawing.Color.Linen
        Me.dgvMeds.Location = New System.Drawing.Point(3, 153)
        Me.dgvMeds.MultiSelect = False
        Me.dgvMeds.Name = "dgvMeds"
        Me.dgvMeds.ReadOnly = True
        Me.dgvMeds.RowHeadersVisible = False
        Me.dgvMeds.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.dgvMeds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMeds.Size = New System.Drawing.Size(1021, 298)
        Me.dgvMeds.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(250, 567)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 1189
        Me.Label9.Text = "Route"
        '
        'cmbRoute
        '
        Me.cmbRoute.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbRoute.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRoute.Enabled = False
        Me.cmbRoute.FormattingEnabled = True
        Me.cmbRoute.Location = New System.Drawing.Point(253, 582)
        Me.cmbRoute.Name = "cmbRoute"
        Me.cmbRoute.Size = New System.Drawing.Size(121, 21)
        Me.cmbRoute.TabIndex = 1188
        '
        'eqModel
        '
        Me.eqModel.CustomInfo = ""
        Me.eqModel.DbContext = Nothing
        Me.eqModel.DefQueryFilePath = ""
        Me.eqModel.Description = Nothing
        Me.eqModel.EntityContainerName = ""
        Me.eqModel.ID = "27d245c2-65a7-4903-be51-e6f9045992f3"
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
        Me.eqQuery.ID = "52928438-c559-4d25-a315-8e3e3c991769"
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
        Me.pnlQuery.Location = New System.Drawing.Point(3, 3)
        Me.pnlQuery.Name = "pnlQuery"
        Me.pnlQuery.Query = Me.eqQuery
        Me.pnlQuery.Size = New System.Drawing.Size(1021, 115)
        Me.pnlQuery.TabIndex = 1190
        Me.pnlQuery.TabStop = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(84, 124)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 1193
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnQuery
        '
        Me.btnQuery.Location = New System.Drawing.Point(3, 124)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(75, 23)
        Me.btnQuery.TabIndex = 1192
        Me.btnQuery.Text = "Apply Query"
        Me.btnQuery.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(895, 124)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(129, 23)
        Me.btnExport.TabIndex = 1191
        Me.btnExport.Text = "Export Table"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'lblNumRows
        '
        Me.lblNumRows.AutoSize = True
        Me.lblNumRows.Location = New System.Drawing.Point(3, 454)
        Me.lblNumRows.Name = "lblNumRows"
        Me.lblNumRows.Size = New System.Drawing.Size(39, 13)
        Me.lblNumRows.TabIndex = 1194
        Me.lblNumRows.Text = "Label2"
        '
        'WA_PMCR_Medications
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.Controls.Add(Me.lblNumRows)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnQuery)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.pnlQuery)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbRoute)
        Me.Controls.Add(Me.Label1358)
        Me.Controls.Add(Me.numDosage)
        Me.Controls.Add(Me.Label80)
        Me.Controls.Add(Me.Label79)
        Me.Controls.Add(Me.Label77)
        Me.Controls.Add(Me.Label76)
        Me.Controls.Add(Me.Label75)
        Me.Controls.Add(Me.dtEnded)
        Me.Controls.Add(Me.dtStarted)
        Me.Controls.Add(Me.txtDosageUnits)
        Me.Controls.Add(Me.txtGenericName)
        Me.Controls.Add(Me.txtBrandName)
        Me.Controls.Add(Me.btnEditMed)
        Me.Controls.Add(Me.btnNewMed)
        Me.Controls.Add(Me.dgvMeds)
        Me.Name = "WA_PMCR_Medications"
        Me.Size = New System.Drawing.Size(1031, 635)
        CType(Me.dgvMeds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1358 As System.Windows.Forms.Label
    Friend WithEvents numDosage As DataWarehouse.TextBoxNumeric
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents dtEnded As DataWarehouse.TextBoxDatePast
    Friend WithEvents dtStarted As DataWarehouse.TextBoxDatePast
    Friend WithEvents txtDosageUnits As DataWarehouse.TextBox_
    Friend WithEvents txtGenericName As DataWarehouse.TextBox_
    Friend WithEvents txtBrandName As DataWarehouse.TextBox_
    Friend WithEvents btnEditMed As DataWarehouse.Button_
    Friend WithEvents btnNewMed As DataWarehouse.Button_
    Friend WithEvents dgvMeds As DataWarehouse.dgvSingleRow
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbRoute As ComboBox_
    Friend WithEvents eqModel As Korzh.EasyQuery.Db.DbModel
    Friend WithEvents eqQuery As Korzh.EasyQuery.Db.DbQuery
    Friend WithEvents pnlQuery As Korzh.EasyQuery.WinControls.QueryPanel
    Friend WithEvents btnReset As Button_
    Friend WithEvents btnQuery As Button_
    Friend WithEvents btnExport As Button_
    Friend WithEvents lblNumRows As Label
End Class
