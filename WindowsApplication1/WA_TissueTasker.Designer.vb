<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WA_TissueTasker
    Inherits System.Windows.Forms.Form

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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnTissueTaskerTop = New System.Windows.Forms.Button()
        Me.btnTissueTaskerBottom = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnTissueTaskerFile = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtTissueRequirements = New DataWarehouse.TextBox_()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbBlackCaps = New DataWarehouse.ComboBox_()
        Me.comboAssignedTo2 = New DataWarehouse.ComboBox_()
        Me.btnExportPDF = New DataWarehouse.Button_()
        Me.intNBTRReqNum = New DataWarehouse.TextBoxInteger()
        Me.txtTaskID = New DataWarehouse.TextBox_()
        Me.txtOldSubProject = New DataWarehouse.TextBox_()
        Me.txtOldProject = New DataWarehouse.TextBox_()
        Me.txtSubProject = New DataWarehouse.TextBox_()
        Me.dgvProgressReports = New DataWarehouse.dgvSingleRow()
        Me.comboAssignedTo1 = New DataWarehouse.ComboBox_()
        Me.txtCompDate = New DataWarehouse.TextBoxDatePast()
        Me.txtSamplesCompleted = New DataWarehouse.TextBoxInteger()
        Me.txtTotalSamples = New DataWarehouse.TextBoxInteger()
        Me.txtEstCompDt = New DataWarehouse.TextBoxDateAny()
        Me.txtRequestDate = New DataWarehouse.TextBoxDatePast()
        Me.txtProject = New DataWarehouse.TextBox_()
        Me.comboAssignedTo3 = New DataWarehouse.ComboBox_()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvProgressReports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTissueTaskerTop
        '
        Me.btnTissueTaskerTop.Location = New System.Drawing.Point(12, 12)
        Me.btnTissueTaskerTop.Name = "btnTissueTaskerTop"
        Me.btnTissueTaskerTop.Size = New System.Drawing.Size(178, 23)
        Me.btnTissueTaskerTop.TabIndex = 273
        Me.btnTissueTaskerTop.UseVisualStyleBackColor = True
        '
        'btnTissueTaskerBottom
        '
        Me.btnTissueTaskerBottom.Location = New System.Drawing.Point(9, 388)
        Me.btnTissueTaskerBottom.Name = "btnTissueTaskerBottom"
        Me.btnTissueTaskerBottom.Size = New System.Drawing.Size(178, 23)
        Me.btnTissueTaskerBottom.TabIndex = 271
        Me.btnTissueTaskerBottom.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(7, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 29)
        Me.Label1.TabIndex = 272
        Me.Label1.Text = "Tissue Tasker"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 274
        Me.Label2.Text = "Project"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 276
        Me.Label3.Text = "Request Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(645, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 278
        Me.Label4.Text = "Est Completion Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(161, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 13)
        Me.Label5.TabIndex = 281
        Me.Label5.Text = "Total Samples Requested"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(9, 143)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(106, 13)
        Me.Label20.TabIndex = 311
        Me.Label20.Text = "Tissue Requirements"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(9, 361)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(117, 13)
        Me.Label21.TabIndex = 313
        Me.Label21.Text = "# Samples in Database"
        '
        'btnTissueTaskerFile
        '
        Me.btnTissueTaskerFile.Location = New System.Drawing.Point(691, 356)
        Me.btnTissueTaskerFile.Name = "btnTissueTaskerFile"
        Me.btnTissueTaskerFile.Size = New System.Drawing.Size(144, 23)
        Me.btnTissueTaskerFile.TabIndex = 315
        Me.btnTissueTaskerFile.Text = "View Supporting Document"
        Me.btnTissueTaskerFile.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(231, 361)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 316
        Me.Label7.Text = "Date Completed"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(393, 361)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 318
        Me.Label8.Text = "Assigned to 1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(10, 418)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(218, 29)
        Me.Label9.TabIndex = 321
        Me.Label9.Text = "Progress Reports"
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(9, 643)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(178, 23)
        Me.btnReport.TabIndex = 322
        Me.btnReport.Text = "Add Progress Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Enabled = False
        Me.btnRemove.Location = New System.Drawing.Point(841, 356)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(56, 23)
        Me.btnRemove.TabIndex = 323
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(260, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 324
        Me.Label10.Text = "Sub Project"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 326
        Me.Label11.Text = "Old Project"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(260, 98)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 328
        Me.Label12.Text = "Old Sub Project"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(770, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 330
        Me.Label6.Text = "TaskID"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(742, 98)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 13)
        Me.Label13.TabIndex = 333
        Me.Label13.Text = "NBTR Req #"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.txtTissueRequirements)
        Me.Panel1.Location = New System.Drawing.Point(9, 159)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(888, 193)
        Me.Panel1.TabIndex = 335
        '
        'txtTissueRequirements
        '
        Me.txtTissueRequirements.AcceptsReturn = True
        Me.txtTissueRequirements.AcceptsTab = True
        Me.txtTissueRequirements.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTissueRequirements.Location = New System.Drawing.Point(0, 0)
        Me.txtTissueRequirements.MaximumSize = New System.Drawing.Size(871, 1500)
        Me.txtTissueRequirements.MinimumSize = New System.Drawing.Size(867, 180)
        Me.txtTissueRequirements.Multiline = True
        Me.txtTissueRequirements.Name = "txtTissueRequirements"
        Me.txtTissueRequirements.Size = New System.Drawing.Size(871, 1500)
        Me.txtTissueRequirements.TabIndex = 312
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(393, 388)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 13)
        Me.Label14.TabIndex = 336
        Me.Label14.Text = "Assigned to 2"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(402, 123)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 13)
        Me.Label15.TabIndex = 338
        Me.Label15.Text = "Additional Black Caps"
        '
        'cmbBlackCaps
        '
        Me.cmbBlackCaps.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbBlackCaps.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBlackCaps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBlackCaps.Enabled = False
        Me.cmbBlackCaps.FormattingEnabled = True
        Me.cmbBlackCaps.Location = New System.Drawing.Point(518, 120)
        Me.cmbBlackCaps.Name = "cmbBlackCaps"
        Me.cmbBlackCaps.Size = New System.Drawing.Size(121, 21)
        Me.cmbBlackCaps.TabIndex = 339
        '
        'comboAssignedTo2
        '
        Me.comboAssignedTo2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboAssignedTo2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboAssignedTo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboAssignedTo2.FormattingEnabled = True
        Me.comboAssignedTo2.Location = New System.Drawing.Point(463, 384)
        Me.comboAssignedTo2.Name = "comboAssignedTo2"
        Me.comboAssignedTo2.Size = New System.Drawing.Size(222, 21)
        Me.comboAssignedTo2.TabIndex = 337
        '
        'btnExportPDF
        '
        Me.btnExportPDF.Location = New System.Drawing.Point(796, 12)
        Me.btnExportPDF.Name = "btnExportPDF"
        Me.btnExportPDF.Size = New System.Drawing.Size(99, 23)
        Me.btnExportPDF.TabIndex = 334
        Me.btnExportPDF.Text = "Export To PDF"
        Me.btnExportPDF.UseVisualStyleBackColor = True
        '
        'intNBTRReqNum
        '
        Me.intNBTRReqNum.Enabled = False
        Me.intNBTRReqNum.Location = New System.Drawing.Point(818, 95)
        Me.intNBTRReqNum.Name = "intNBTRReqNum"
        Me.intNBTRReqNum.Size = New System.Drawing.Size(77, 20)
        Me.intNBTRReqNum.TabIndex = 332
        '
        'txtTaskID
        '
        Me.txtTaskID.Enabled = False
        Me.txtTaskID.Location = New System.Drawing.Point(818, 70)
        Me.txtTaskID.Name = "txtTaskID"
        Me.txtTaskID.Size = New System.Drawing.Size(77, 20)
        Me.txtTaskID.TabIndex = 331
        '
        'txtOldSubProject
        '
        Me.txtOldSubProject.Enabled = False
        Me.txtOldSubProject.Location = New System.Drawing.Point(347, 95)
        Me.txtOldSubProject.Name = "txtOldSubProject"
        Me.txtOldSubProject.Size = New System.Drawing.Size(180, 20)
        Me.txtOldSubProject.TabIndex = 329
        '
        'txtOldProject
        '
        Me.txtOldProject.Enabled = False
        Me.txtOldProject.Location = New System.Drawing.Point(74, 95)
        Me.txtOldProject.Name = "txtOldProject"
        Me.txtOldProject.Size = New System.Drawing.Size(180, 20)
        Me.txtOldProject.TabIndex = 327
        '
        'txtSubProject
        '
        Me.txtSubProject.Enabled = False
        Me.txtSubProject.Location = New System.Drawing.Point(347, 70)
        Me.txtSubProject.Name = "txtSubProject"
        Me.txtSubProject.Size = New System.Drawing.Size(180, 20)
        Me.txtSubProject.TabIndex = 325
        '
        'dgvProgressReports
        '
        Me.dgvProgressReports.AllowUserToAddRows = False
        Me.dgvProgressReports.AllowUserToDeleteRows = False
        Me.dgvProgressReports.AllowUserToOrderColumns = True
        Me.dgvProgressReports.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige
        Me.dgvProgressReports.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProgressReports.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dgvProgressReports.BackgroundColor = System.Drawing.Color.Tan
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProgressReports.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProgressReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProgressReports.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvProgressReports.GridColor = System.Drawing.Color.Linen
        Me.dgvProgressReports.Location = New System.Drawing.Point(9, 450)
        Me.dgvProgressReports.MultiSelect = False
        Me.dgvProgressReports.Name = "dgvProgressReports"
        Me.dgvProgressReports.ReadOnly = True
        Me.dgvProgressReports.RowHeadersVisible = False
        Me.dgvProgressReports.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.dgvProgressReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProgressReports.Size = New System.Drawing.Size(579, 187)
        Me.dgvProgressReports.TabIndex = 320
        '
        'comboAssignedTo1
        '
        Me.comboAssignedTo1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboAssignedTo1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboAssignedTo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboAssignedTo1.FormattingEnabled = True
        Me.comboAssignedTo1.Location = New System.Drawing.Point(463, 357)
        Me.comboAssignedTo1.Name = "comboAssignedTo1"
        Me.comboAssignedTo1.Size = New System.Drawing.Size(222, 21)
        Me.comboAssignedTo1.TabIndex = 319
        '
        'txtCompDate
        '
        Me.txtCompDate.Location = New System.Drawing.Point(320, 358)
        Me.txtCompDate.Mask = "00/00/0000"
        Me.txtCompDate.Name = "txtCompDate"
        Me.txtCompDate.Size = New System.Drawing.Size(67, 20)
        Me.txtCompDate.TabIndex = 317
        Me.txtCompDate.ValidatingType = GetType(Date)
        '
        'txtSamplesCompleted
        '
        Me.txtSamplesCompleted.Enabled = False
        Me.txtSamplesCompleted.Location = New System.Drawing.Point(126, 358)
        Me.txtSamplesCompleted.Name = "txtSamplesCompleted"
        Me.txtSamplesCompleted.Size = New System.Drawing.Size(100, 20)
        Me.txtSamplesCompleted.TabIndex = 314
        '
        'txtTotalSamples
        '
        Me.txtTotalSamples.Enabled = False
        Me.txtTotalSamples.Location = New System.Drawing.Point(296, 120)
        Me.txtTotalSamples.Name = "txtTotalSamples"
        Me.txtTotalSamples.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalSamples.TabIndex = 282
        '
        'txtEstCompDt
        '
        Me.txtEstCompDt.Location = New System.Drawing.Point(754, 120)
        Me.txtEstCompDt.Mask = "00/00/0000"
        Me.txtEstCompDt.Name = "txtEstCompDt"
        Me.txtEstCompDt.Size = New System.Drawing.Size(67, 20)
        Me.txtEstCompDt.TabIndex = 279
        Me.txtEstCompDt.ValidatingType = GetType(Date)
        '
        'txtRequestDate
        '
        Me.txtRequestDate.Location = New System.Drawing.Point(88, 120)
        Me.txtRequestDate.Mask = "00/00/0000"
        Me.txtRequestDate.Name = "txtRequestDate"
        Me.txtRequestDate.Size = New System.Drawing.Size(67, 20)
        Me.txtRequestDate.TabIndex = 277
        Me.txtRequestDate.ValidatingType = GetType(Date)
        '
        'txtProject
        '
        Me.txtProject.Enabled = False
        Me.txtProject.Location = New System.Drawing.Point(74, 70)
        Me.txtProject.Name = "txtProject"
        Me.txtProject.Size = New System.Drawing.Size(180, 20)
        Me.txtProject.TabIndex = 275
        '
        'comboAssignedTo3
        '
        Me.comboAssignedTo3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboAssignedTo3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboAssignedTo3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboAssignedTo3.FormattingEnabled = True
        Me.comboAssignedTo3.Location = New System.Drawing.Point(463, 411)
        Me.comboAssignedTo3.Name = "comboAssignedTo3"
        Me.comboAssignedTo3.Size = New System.Drawing.Size(222, 21)
        Me.comboAssignedTo3.TabIndex = 341
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(393, 415)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 13)
        Me.Label16.TabIndex = 340
        Me.Label16.Text = "Assigned to 3"
        '
        'WA_TissueTasker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(903, 678)
        Me.Controls.Add(Me.comboAssignedTo3)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cmbBlackCaps)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.comboAssignedTo2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnExportPDF)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.intNBTRReqNum)
        Me.Controls.Add(Me.txtTaskID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtOldSubProject)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtOldProject)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtSubProject)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dgvProgressReports)
        Me.Controls.Add(Me.comboAssignedTo1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCompDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnTissueTaskerFile)
        Me.Controls.Add(Me.txtSamplesCompleted)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtTotalSamples)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEstCompDt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtRequestDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtProject)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnTissueTaskerTop)
        Me.Controls.Add(Me.btnTissueTaskerBottom)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WA_TissueTasker"
        Me.Text = "WA_TissueTasker"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvProgressReports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTissueTaskerTop As System.Windows.Forms.Button
    Friend WithEvents btnTissueTaskerBottom As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtProject As DataWarehouse.TextBox_
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRequestDate As DataWarehouse.TextBoxDatePast
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEstCompDt As DataWarehouse.TextBoxDateAny
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTotalSamples As DataWarehouse.TextBoxInteger
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtTissueRequirements As DataWarehouse.TextBox_
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtSamplesCompleted As DataWarehouse.TextBoxInteger
    Friend WithEvents btnTissueTaskerFile As System.Windows.Forms.Button
    Friend WithEvents txtCompDate As DataWarehouse.TextBoxDatePast
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents comboAssignedTo1 As DataWarehouse.ComboBox_
    Friend WithEvents dgvProgressReports As DataWarehouse.dgvSingleRow
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents txtSubProject As DataWarehouse.TextBox_
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtOldProject As DataWarehouse.TextBox_
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtOldSubProject As DataWarehouse.TextBox_
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTaskID As DataWarehouse.TextBox_
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents intNBTRReqNum As TextBoxInteger
    Friend WithEvents Label13 As Label
    Friend WithEvents btnExportPDF As Button_
    Friend WithEvents Panel1 As Panel
    Friend WithEvents comboAssignedTo2 As ComboBox_
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cmbBlackCaps As ComboBox_
    Friend WithEvents comboAssignedTo3 As ComboBox_
    Friend WithEvents Label16 As Label
End Class
