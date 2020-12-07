<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WA_ExistingRecordsReport
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExport = New DataWarehouse.Button_()
        Me.dgvExistingRecordsReport = New DataWarehouse.dgvSingleRow()
        Me.lblNumRows = New System.Windows.Forms.Label()
        Me.eqModel = New Korzh.EasyQuery.Db.DbModel()
        Me.eqQuery = New Korzh.EasyQuery.Db.DbQuery()
        Me.pnlQuery = New Korzh.EasyQuery.WinControls.QueryPanel()
        Me.btnReset = New DataWarehouse.Button_()
        Me.btnQuery = New DataWarehouse.Button_()
        CType(Me.dgvExistingRecordsReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(391, 29)
        Me.Label1.TabIndex = 786
        Me.Label1.Text = "Existing Subject Records Report"
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(951, 156)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(129, 23)
        Me.btnExport.TabIndex = 787
        Me.btnExport.Text = "Export Table"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'dgvExistingRecordsReport
        '
        Me.dgvExistingRecordsReport.AllowUserToAddRows = False
        Me.dgvExistingRecordsReport.AllowUserToDeleteRows = False
        Me.dgvExistingRecordsReport.AllowUserToOrderColumns = True
        Me.dgvExistingRecordsReport.AllowUserToResizeRows = False
        Me.dgvExistingRecordsReport.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dgvExistingRecordsReport.BackgroundColor = System.Drawing.Color.Tan
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvExistingRecordsReport.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvExistingRecordsReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvExistingRecordsReport.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvExistingRecordsReport.GridColor = System.Drawing.Color.Linen
        Me.dgvExistingRecordsReport.Location = New System.Drawing.Point(3, 185)
        Me.dgvExistingRecordsReport.MultiSelect = False
        Me.dgvExistingRecordsReport.Name = "dgvExistingRecordsReport"
        Me.dgvExistingRecordsReport.ReadOnly = True
        Me.dgvExistingRecordsReport.RowHeadersVisible = False
        Me.dgvExistingRecordsReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvExistingRecordsReport.Size = New System.Drawing.Size(1077, 730)
        Me.dgvExistingRecordsReport.TabIndex = 0
        '
        'lblNumRows
        '
        Me.lblNumRows.AutoSize = True
        Me.lblNumRows.Location = New System.Drawing.Point(3, 921)
        Me.lblNumRows.Name = "lblNumRows"
        Me.lblNumRows.Size = New System.Drawing.Size(39, 13)
        Me.lblNumRows.TabIndex = 788
        Me.lblNumRows.Text = "Label2"
        '
        'eqModel
        '
        Me.eqModel.CustomInfo = ""
        Me.eqModel.DbContext = Nothing
        Me.eqModel.DefQueryFilePath = ""
        Me.eqModel.Description = Nothing
        Me.eqModel.EntityContainerName = ""
        Me.eqModel.ID = "88236f5b-a39e-41ec-9872-b6577dbd21b0"
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
        Me.eqQuery.ID = "54c52213-3ff4-43ff-ae89-ee723de78613"
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
        Me.pnlQuery.Location = New System.Drawing.Point(3, 37)
        Me.pnlQuery.Name = "pnlQuery"
        Me.pnlQuery.Query = Me.eqQuery
        Me.pnlQuery.Size = New System.Drawing.Size(1077, 113)
        Me.pnlQuery.TabIndex = 789
        Me.pnlQuery.TabStop = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(84, 156)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 791
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnQuery
        '
        Me.btnQuery.Location = New System.Drawing.Point(3, 156)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(75, 23)
        Me.btnQuery.TabIndex = 790
        Me.btnQuery.Text = "Apply Query"
        Me.btnQuery.UseVisualStyleBackColor = True
        '
        'WA_ExistingRecordsReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnQuery)
        Me.Controls.Add(Me.pnlQuery)
        Me.Controls.Add(Me.lblNumRows)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvExistingRecordsReport)
        Me.Name = "WA_ExistingRecordsReport"
        Me.Size = New System.Drawing.Size(1083, 956)
        CType(Me.dgvExistingRecordsReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvExistingRecordsReport As dgvSingleRow
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExport As Button_
    Friend WithEvents lblNumRows As Label
    Friend WithEvents eqModel As Korzh.EasyQuery.Db.DbModel
    Friend WithEvents eqQuery As Korzh.EasyQuery.Db.DbQuery
    Friend WithEvents pnlQuery As Korzh.EasyQuery.WinControls.QueryPanel
    Friend WithEvents btnReset As Button_
    Friend WithEvents btnQuery As Button_
End Class
