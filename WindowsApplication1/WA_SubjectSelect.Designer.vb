<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WA_SubjectSelect
    Inherits Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSelectSubject = New System.Windows.Forms.Button()
        Me.btnAddSubject = New System.Windows.Forms.Button()
        Me.dgvSubject = New System.Windows.Forms.DataGridView()
        Me.eqModel = New Korzh.EasyQuery.Db.DbModel()
        Me.eqQuery = New Korzh.EasyQuery.Db.DbQuery()
        Me.pnlQuery = New Korzh.EasyQuery.WinControls.QueryPanel()
        Me.lblRowCount = New System.Windows.Forms.Label()
        Me.btnReset = New DataWarehouse.Button_()
        Me.btnQuery = New DataWarehouse.Button_()
        Me.btnExport = New DataWarehouse.Button_()
        Me.lblBBCount = New System.Windows.Forms.Label()
        Me.lblADRCCount = New System.Windows.Forms.Label()
        CType(Me.dgvSubject, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSelectSubject
        '
        Me.btnSelectSubject.Location = New System.Drawing.Point(395, 732)
        Me.btnSelectSubject.Name = "btnSelectSubject"
        Me.btnSelectSubject.Size = New System.Drawing.Size(184, 23)
        Me.btnSelectSubject.TabIndex = 3
        Me.btnSelectSubject.Text = "Select Highlighted Subject"
        Me.btnSelectSubject.UseVisualStyleBackColor = True
        '
        'btnAddSubject
        '
        Me.btnAddSubject.Location = New System.Drawing.Point(395, 761)
        Me.btnAddSubject.Name = "btnAddSubject"
        Me.btnAddSubject.Size = New System.Drawing.Size(184, 23)
        Me.btnAddSubject.TabIndex = 4
        Me.btnAddSubject.Text = "Add New Subject"
        Me.btnAddSubject.UseVisualStyleBackColor = True
        '
        'dgvSubject
        '
        Me.dgvSubject.AllowUserToAddRows = False
        Me.dgvSubject.AllowUserToDeleteRows = False
        Me.dgvSubject.AllowUserToOrderColumns = True
        Me.dgvSubject.BackgroundColor = System.Drawing.Color.Tan
        Me.dgvSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSubject.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSubject.Location = New System.Drawing.Point(12, 147)
        Me.dgvSubject.MultiSelect = False
        Me.dgvSubject.Name = "dgvSubject"
        Me.dgvSubject.ReadOnly = True
        Me.dgvSubject.RowHeadersVisible = False
        Me.dgvSubject.RowHeadersWidth = 62
        Me.dgvSubject.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSubject.Size = New System.Drawing.Size(950, 579)
        Me.dgvSubject.TabIndex = 5
        '
        'eqModel
        '
        Me.eqModel.CustomInfo = ""
        Me.eqModel.DbContext = Nothing
        Me.eqModel.DefQueryFilePath = ""
        Me.eqModel.Description = Nothing
        Me.eqModel.EntityContainerName = ""
        Me.eqModel.ID = "48228911-af5a-4b2b-9760-dd854adf53ed"
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
        Me.eqQuery.ID = "9db61bf1-f49a-4627-b08c-8b5fe650748b"
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
        Me.pnlQuery.Location = New System.Drawing.Point(12, 12)
        Me.pnlQuery.Name = "pnlQuery"
        Me.pnlQuery.Query = Me.eqQuery
        Me.pnlQuery.Size = New System.Drawing.Size(953, 100)
        Me.pnlQuery.TabIndex = 6
        Me.pnlQuery.TabStop = True
        '
        'lblRowCount
        '
        Me.lblRowCount.AutoSize = True
        Me.lblRowCount.Location = New System.Drawing.Point(12, 732)
        Me.lblRowCount.Name = "lblRowCount"
        Me.lblRowCount.Size = New System.Drawing.Size(60, 13)
        Me.lblRowCount.TabIndex = 7
        Me.lblRowCount.Text = "Row Count"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(93, 118)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 797
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnQuery
        '
        Me.btnQuery.Location = New System.Drawing.Point(12, 118)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(75, 23)
        Me.btnQuery.TabIndex = 796
        Me.btnQuery.Text = "Apply Query"
        Me.btnQuery.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(836, 118)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(129, 23)
        Me.btnExport.TabIndex = 795
        Me.btnExport.Text = "Export Table"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'lblBBCount
        '
        Me.lblBBCount.AutoSize = True
        Me.lblBBCount.Location = New System.Drawing.Point(12, 745)
        Me.lblBBCount.Name = "lblBBCount"
        Me.lblBBCount.Size = New System.Drawing.Size(52, 13)
        Me.lblBBCount.TabIndex = 798
        Me.lblBBCount.Text = "BB Count"
        '
        'lblADRCCount
        '
        Me.lblADRCCount.AutoSize = True
        Me.lblADRCCount.Location = New System.Drawing.Point(12, 758)
        Me.lblADRCCount.Name = "lblADRCCount"
        Me.lblADRCCount.Size = New System.Drawing.Size(68, 13)
        Me.lblADRCCount.TabIndex = 799
        Me.lblADRCCount.Text = "ADRC Count"
        '
        'WA_SubjectSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(977, 789)
        Me.Controls.Add(Me.lblADRCCount)
        Me.Controls.Add(Me.lblBBCount)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnQuery)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.lblRowCount)
        Me.Controls.Add(Me.pnlQuery)
        Me.Controls.Add(Me.dgvSubject)
        Me.Controls.Add(Me.btnAddSubject)
        Me.Controls.Add(Me.btnSelectSubject)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WA_SubjectSelect"
        Me.Text = "WA_SubjectSelect"
        CType(Me.dgvSubject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSelectSubject As System.Windows.Forms.Button
    Friend WithEvents btnAddSubject As System.Windows.Forms.Button
    Friend WithEvents dgvSubject As System.Windows.Forms.DataGridView
    Friend WithEvents eqModel As Korzh.EasyQuery.Db.DbModel
    Friend WithEvents eqQuery As Korzh.EasyQuery.Db.DbQuery
    Friend WithEvents pnlQuery As Korzh.EasyQuery.WinControls.QueryPanel
    Friend WithEvents lblRowCount As Label
    Friend WithEvents btnReset As Button_
    Friend WithEvents btnQuery As Button_
    Friend WithEvents btnExport As Button_
    Friend WithEvents lblBBCount As Label
    Friend WithEvents lblADRCCount As Label
End Class
