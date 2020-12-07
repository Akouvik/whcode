<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WA_DNA_RNA_Volume
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgvResults = New System.Windows.Forms.DataGridView()
        Me.btnCopyResults = New DataWarehouse.Button_()
        Me.btnReset = New DataWarehouse.Button_()
        Me.btnQuery = New DataWarehouse.Button_()
        Me.pnlQuery = New Korzh.EasyQuery.WinControls.QueryPanel()
        Me.eqQuery = New Korzh.EasyQuery.Db.DbQuery()
        Me.eqModel = New Korzh.EasyQuery.Db.DbModel()
        Me.lblTotalRows = New System.Windows.Forms.Label()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(0, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(221, 29)
        Me.Label12.TabIndex = 203
        Me.Label12.Text = "DNA RNA Volume"
        '
        'dgvResults
        '
        Me.dgvResults.AllowUserToAddRows = False
        Me.dgvResults.AllowUserToDeleteRows = False
        Me.dgvResults.AllowUserToOrderColumns = True
        Me.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvResults.BackgroundColor = System.Drawing.Color.Tan
        Me.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResults.Location = New System.Drawing.Point(0, 221)
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.ReadOnly = True
        Me.dgvResults.RowHeadersVisible = False
        Me.dgvResults.ShowRowErrors = False
        Me.dgvResults.Size = New System.Drawing.Size(1117, 697)
        Me.dgvResults.TabIndex = 204
        '
        'btnCopyResults
        '
        Me.btnCopyResults.Location = New System.Drawing.Point(933, 3)
        Me.btnCopyResults.Name = "btnCopyResults"
        Me.btnCopyResults.Size = New System.Drawing.Size(182, 23)
        Me.btnCopyResults.TabIndex = 205
        Me.btnCopyResults.Text = "Copy Selected Cells to Clipboard"
        Me.btnCopyResults.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(84, 192)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 222
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnQuery
        '
        Me.btnQuery.Location = New System.Drawing.Point(3, 192)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(75, 23)
        Me.btnQuery.TabIndex = 221
        Me.btnQuery.Text = "Apply Query"
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
        Me.pnlQuery.Location = New System.Drawing.Point(3, 32)
        Me.pnlQuery.Name = "pnlQuery"
        Me.pnlQuery.Query = Me.eqQuery
        Me.pnlQuery.Size = New System.Drawing.Size(1111, 154)
        Me.pnlQuery.TabIndex = 220
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
        Me.eqQuery.ID = "6c0ba700-6bf7-4940-9c76-7e3d60a8a217"
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
        Me.eqModel.ID = "6c7f7f7f-5718-42d9-86e0-4f232ca1313e"
        Me.eqModel.IsLoadedFromDbContext = False
        Me.eqModel.ModelName = Nothing
        Me.eqModel.ProgressIndicator = Nothing
        '
        'lblTotalRows
        '
        Me.lblTotalRows.AutoSize = True
        Me.lblTotalRows.Location = New System.Drawing.Point(3, 921)
        Me.lblTotalRows.Name = "lblTotalRows"
        Me.lblTotalRows.Size = New System.Drawing.Size(39, 13)
        Me.lblTotalRows.TabIndex = 223
        Me.lblTotalRows.Text = "Label1"
        '
        'WA_DNA_RNA_Volume
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.Controls.Add(Me.lblTotalRows)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnQuery)
        Me.Controls.Add(Me.pnlQuery)
        Me.Controls.Add(Me.dgvResults)
        Me.Controls.Add(Me.btnCopyResults)
        Me.Controls.Add(Me.Label12)
        Me.Name = "WA_DNA_RNA_Volume"
        Me.Size = New System.Drawing.Size(1117, 942)
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dgvResults As System.Windows.Forms.DataGridView
    Friend WithEvents btnCopyResults As DataWarehouse.Button_
    Friend WithEvents btnReset As Button_
    Friend WithEvents btnQuery As Button_
    Friend WithEvents pnlQuery As Korzh.EasyQuery.WinControls.QueryPanel
    Friend WithEvents eqQuery As Korzh.EasyQuery.Db.DbQuery
    Friend WithEvents eqModel As Korzh.EasyQuery.Db.DbModel
    Friend WithEvents lblTotalRows As Label
End Class
