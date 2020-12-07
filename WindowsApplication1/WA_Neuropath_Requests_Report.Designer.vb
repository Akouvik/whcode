<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WA_Neuropath_Requests_Report
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvRequests = New DataWarehouse.dgvSingleRow()
        Me.btnHideCompleted = New DataWarehouse.Button_()
        Me.eqModel = New Korzh.EasyQuery.Db.DbModel()
        Me.eqQuery = New Korzh.EasyQuery.Db.DbQuery()
        Me.pnlQuery = New Korzh.EasyQuery.WinControls.QueryPanel()
        Me.btnReset = New DataWarehouse.Button_()
        Me.btnQuery = New DataWarehouse.Button_()
        Me.btnExport = New DataWarehouse.Button_()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 29)
        Me.Label1.TabIndex = 786
        Me.Label1.Text = "Neuropath Requests Report"
        '
        'dgvRequests
        '
        Me.dgvRequests.AllowUserToAddRows = False
        Me.dgvRequests.AllowUserToDeleteRows = False
        Me.dgvRequests.AllowUserToOrderColumns = True
        Me.dgvRequests.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige
        Me.dgvRequests.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRequests.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dgvRequests.BackgroundColor = System.Drawing.Color.Tan
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRequests.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRequests.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRequests.GridColor = System.Drawing.Color.Linen
        Me.dgvRequests.Location = New System.Drawing.Point(3, 167)
        Me.dgvRequests.MultiSelect = False
        Me.dgvRequests.Name = "dgvRequests"
        Me.dgvRequests.ReadOnly = True
        Me.dgvRequests.RowHeadersVisible = False
        Me.dgvRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRequests.Size = New System.Drawing.Size(1024, 472)
        Me.dgvRequests.TabIndex = 787
        '
        'btnHideCompleted
        '
        Me.btnHideCompleted.Location = New System.Drawing.Point(742, 138)
        Me.btnHideCompleted.Name = "btnHideCompleted"
        Me.btnHideCompleted.Size = New System.Drawing.Size(150, 23)
        Me.btnHideCompleted.TabIndex = 788
        Me.btnHideCompleted.Text = "Hide Completed Requests"
        Me.btnHideCompleted.UseVisualStyleBackColor = True
        '
        'eqModel
        '
        Me.eqModel.CustomInfo = ""
        Me.eqModel.DbContext = Nothing
        Me.eqModel.DefQueryFilePath = ""
        Me.eqModel.Description = Nothing
        Me.eqModel.EntityContainerName = ""
        Me.eqModel.ID = "fe2c3210-b43e-4a09-b651-63eef75f4f4a"
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
        Me.eqQuery.ID = "770c5d30-6cfc-4989-a316-80225bd4fd00"
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
        Me.pnlQuery.Size = New System.Drawing.Size(1024, 100)
        Me.pnlQuery.TabIndex = 789
        Me.pnlQuery.TabStop = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(84, 138)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 798
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnQuery
        '
        Me.btnQuery.Location = New System.Drawing.Point(3, 138)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(75, 23)
        Me.btnQuery.TabIndex = 797
        Me.btnQuery.Text = "Apply Query"
        Me.btnQuery.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(898, 138)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(129, 23)
        Me.btnExport.TabIndex = 796
        Me.btnExport.Text = "Export Table"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(347, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 13)
        Me.Label4.TabIndex = 795
        Me.Label4.Text = "Double-click a record to go to detailed view"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 642)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 799
        Me.Label2.Text = "Label2"
        '
        'WA_Neuropath_Requests_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnQuery)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pnlQuery)
        Me.Controls.Add(Me.btnHideCompleted)
        Me.Controls.Add(Me.dgvRequests)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WA_Neuropath_Requests_Report"
        Me.Size = New System.Drawing.Size(1030, 660)
        CType(Me.dgvRequests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvRequests As dgvSingleRow
    Friend WithEvents btnHideCompleted As Button_
    Friend WithEvents eqModel As Korzh.EasyQuery.Db.DbModel
    Friend WithEvents eqQuery As Korzh.EasyQuery.Db.DbQuery
    Friend WithEvents pnlQuery As Korzh.EasyQuery.WinControls.QueryPanel
    Friend WithEvents btnReset As Button_
    Friend WithEvents btnQuery As Button_
    Friend WithEvents btnExport As Button_
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
End Class
