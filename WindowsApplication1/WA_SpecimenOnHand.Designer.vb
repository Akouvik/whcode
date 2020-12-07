<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WA_SpecimenOnHand
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
        Me.dgvResults = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnMoveBox = New DataWarehouse.Button_()
        Me.eqModel = New Korzh.EasyQuery.Db.DbModel()
        Me.eqQuery = New Korzh.EasyQuery.Db.DbQuery()
        Me.pnlQuery = New Korzh.EasyQuery.WinControls.QueryPanel()
        Me.btnQuery = New DataWarehouse.Button_()
        Me.btnAddNewSpecimen = New DataWarehouse.Button_()
        Me.lblTotalRows = New System.Windows.Forms.Label()
        Me.btnReset = New DataWarehouse.Button_()
        Me.chkLast100 = New System.Windows.Forms.CheckBox()
        Me.btnEditRecord = New DataWarehouse.Button_()
        Me.btnDeleteRecord = New DataWarehouse.Button_()
        Me.btnConsumeRecord = New DataWarehouse.Button_()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvResults
        '
        Me.dgvResults.AllowUserToAddRows = False
        Me.dgvResults.AllowUserToDeleteRows = False
        Me.dgvResults.AllowUserToOrderColumns = True
        Me.dgvResults.BackgroundColor = System.Drawing.Color.Tan
        Me.dgvResults.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResults.Location = New System.Drawing.Point(3, 239)
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.ReadOnly = True
        Me.dgvResults.RowHeadersVisible = False
        Me.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvResults.Size = New System.Drawing.Size(1117, 697)
        Me.dgvResults.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(0, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(241, 29)
        Me.Label12.TabIndex = 204
        Me.Label12.Text = "Specimen On-Hand"
        '
        'btnMoveBox
        '
        Me.btnMoveBox.Location = New System.Drawing.Point(3, 955)
        Me.btnMoveBox.Name = "btnMoveBox"
        Me.btnMoveBox.Size = New System.Drawing.Size(152, 23)
        Me.btnMoveBox.TabIndex = 205
        Me.btnMoveBox.Text = "Move Box"
        Me.btnMoveBox.UseVisualStyleBackColor = True
        '
        'eqModel
        '
        Me.eqModel.CustomInfo = ""
        Me.eqModel.DbContext = Nothing
        Me.eqModel.DefQueryFilePath = ""
        Me.eqModel.Description = Nothing
        Me.eqModel.EntityContainerName = ""
        Me.eqModel.ID = "d7953ffa-eee0-4d35-99b4-1f903a93bd32"
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
        Me.eqQuery.ID = "18cdcda4-687b-4728-8b7f-fd07954d8c3e"
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
        Me.pnlQuery.Location = New System.Drawing.Point(3, 32)
        Me.pnlQuery.Name = "pnlQuery"
        Me.pnlQuery.Query = Me.eqQuery
        Me.pnlQuery.Size = New System.Drawing.Size(1117, 172)
        Me.pnlQuery.TabIndex = 207
        Me.pnlQuery.TabStop = True
        '
        'btnQuery
        '
        Me.btnQuery.Location = New System.Drawing.Point(3, 210)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(75, 23)
        Me.btnQuery.TabIndex = 208
        Me.btnQuery.Text = "Apply Query"
        Me.btnQuery.UseVisualStyleBackColor = True
        '
        'btnAddNewSpecimen
        '
        Me.btnAddNewSpecimen.Location = New System.Drawing.Point(161, 955)
        Me.btnAddNewSpecimen.Name = "btnAddNewSpecimen"
        Me.btnAddNewSpecimen.Size = New System.Drawing.Size(152, 23)
        Me.btnAddNewSpecimen.TabIndex = 209
        Me.btnAddNewSpecimen.Text = "Add New Specimen"
        Me.btnAddNewSpecimen.UseVisualStyleBackColor = True
        '
        'lblTotalRows
        '
        Me.lblTotalRows.AutoSize = True
        Me.lblTotalRows.Location = New System.Drawing.Point(3, 939)
        Me.lblTotalRows.Name = "lblTotalRows"
        Me.lblTotalRows.Size = New System.Drawing.Size(39, 13)
        Me.lblTotalRows.TabIndex = 221
        Me.lblTotalRows.Text = "Label1"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(84, 210)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 222
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'chkLast100
        '
        Me.chkLast100.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkLast100.AutoSize = True
        Me.chkLast100.Location = New System.Drawing.Point(1015, 210)
        Me.chkLast100.Name = "chkLast100"
        Me.chkLast100.Size = New System.Drawing.Size(105, 23)
        Me.chkLast100.TabIndex = 223
        Me.chkLast100.Text = "Show My Last 100"
        Me.chkLast100.UseVisualStyleBackColor = True
        '
        'btnEditRecord
        '
        Me.btnEditRecord.Location = New System.Drawing.Point(319, 955)
        Me.btnEditRecord.Name = "btnEditRecord"
        Me.btnEditRecord.Size = New System.Drawing.Size(152, 23)
        Me.btnEditRecord.TabIndex = 224
        Me.btnEditRecord.Text = "Edit Selected Specimen"
        Me.btnEditRecord.UseVisualStyleBackColor = True
        '
        'btnDeleteRecord
        '
        Me.btnDeleteRecord.Location = New System.Drawing.Point(635, 955)
        Me.btnDeleteRecord.Name = "btnDeleteRecord"
        Me.btnDeleteRecord.Size = New System.Drawing.Size(152, 23)
        Me.btnDeleteRecord.TabIndex = 225
        Me.btnDeleteRecord.Text = "Delete Selected Specimen(s)"
        Me.btnDeleteRecord.UseVisualStyleBackColor = True
        '
        'btnConsumeRecord
        '
        Me.btnConsumeRecord.Location = New System.Drawing.Point(477, 955)
        Me.btnConsumeRecord.Name = "btnConsumeRecord"
        Me.btnConsumeRecord.Size = New System.Drawing.Size(152, 23)
        Me.btnConsumeRecord.TabIndex = 226
        Me.btnConsumeRecord.Text = "Consume Selected Specimen(s)"
        Me.btnConsumeRecord.UseVisualStyleBackColor = True
        '
        'WA_SpecimenOnHand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.Controls.Add(Me.btnConsumeRecord)
        Me.Controls.Add(Me.btnDeleteRecord)
        Me.Controls.Add(Me.btnEditRecord)
        Me.Controls.Add(Me.chkLast100)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblTotalRows)
        Me.Controls.Add(Me.btnAddNewSpecimen)
        Me.Controls.Add(Me.btnQuery)
        Me.Controls.Add(Me.pnlQuery)
        Me.Controls.Add(Me.btnMoveBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dgvResults)
        Me.Name = "WA_SpecimenOnHand"
        Me.Size = New System.Drawing.Size(1128, 985)
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvResults As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnMoveBox As Button_
    Friend WithEvents eqModel As Korzh.EasyQuery.Db.DbModel
    Friend WithEvents eqQuery As Korzh.EasyQuery.Db.DbQuery
    Friend WithEvents pnlQuery As Korzh.EasyQuery.WinControls.QueryPanel
    Friend WithEvents btnQuery As Button_
    Friend WithEvents btnAddNewSpecimen As Button_
    Friend WithEvents lblTotalRows As Label
    Friend WithEvents btnReset As Button_
    Friend WithEvents chkLast100 As CheckBox
    Friend WithEvents btnEditRecord As Button_
    Friend WithEvents btnDeleteRecord As Button_
    Friend WithEvents btnConsumeRecord As Button_
End Class
