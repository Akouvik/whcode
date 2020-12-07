<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WA_CERAD_Header
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNoRecord = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNPReportProvisionalRemove = New DataWarehouse.Button_()
        Me.btnNPReportProvisional = New DataWarehouse.Button_()
        Me.chkHarryReviewed = New DataWarehouse.CheckBox_()
        Me.cmbNPType = New DataWarehouse.ComboBox_()
        Me.btnExportPDF = New DataWarehouse.Button_()
        Me.btnCERADHeader = New DataWarehouse.Button_()
        Me.txtXENum = New DataWarehouse.TextBox_()
        Me.btnNPReportRemove = New DataWarehouse.Button_()
        Me.txtCERADDate = New DataWarehouse.TextBoxDatePast()
        Me.comboNeuropathologist = New DataWarehouse.ComboBox_()
        Me.btnNPReport = New DataWarehouse.Button_()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 29)
        Me.Label1.TabIndex = 786
        Me.Label1.Text = "CERAD Header"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(708, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 794
        Me.Label7.Text = "XE#"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(546, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 790
        Me.Label6.Text = "Date Completed"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(222, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 788
        Me.Label5.Text = "Neuropathologist"
        '
        'lblNoRecord
        '
        Me.lblNoRecord.AutoSize = True
        Me.lblNoRecord.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lblNoRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNoRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoRecord.Location = New System.Drawing.Point(9, 485)
        Me.lblNoRecord.Name = "lblNoRecord"
        Me.lblNoRecord.Size = New System.Drawing.Size(620, 64)
        Me.lblNoRecord.TabIndex = 1157
        Me.lblNoRecord.Text = "No CERAD Header Exists For This Subject" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click ""Add New Record"" Above To Create O" &
    "ne"
        Me.lblNoRecord.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 1160
        Me.Label2.Text = "Neuropath Type"
        '
        'btnNPReportProvisionalRemove
        '
        Me.btnNPReportProvisionalRemove.Location = New System.Drawing.Point(229, 96)
        Me.btnNPReportProvisionalRemove.Name = "btnNPReportProvisionalRemove"
        Me.btnNPReportProvisionalRemove.Size = New System.Drawing.Size(72, 23)
        Me.btnNPReportProvisionalRemove.TabIndex = 1163
        Me.btnNPReportProvisionalRemove.Text = "Delete"
        Me.btnNPReportProvisionalRemove.UseVisualStyleBackColor = True
        '
        'btnNPReportProvisional
        '
        Me.btnNPReportProvisional.Enabled = False
        Me.btnNPReportProvisional.Location = New System.Drawing.Point(192, 73)
        Me.btnNPReportProvisional.Name = "btnNPReportProvisional"
        Me.btnNPReportProvisional.Size = New System.Drawing.Size(146, 23)
        Me.btnNPReportProvisional.TabIndex = 1162
        Me.btnNPReportProvisional.Text = "View Provisional NP Report"
        Me.btnNPReportProvisional.UseVisualStyleBackColor = True
        '
        'chkHarryReviewed
        '
        Me.chkHarryReviewed.AutoSize = True
        Me.chkHarryReviewed.BackColor = System.Drawing.Color.Tan
        Me.chkHarryReviewed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkHarryReviewed.Location = New System.Drawing.Point(202, 7)
        Me.chkHarryReviewed.Name = "chkHarryReviewed"
        Me.chkHarryReviewed.Size = New System.Drawing.Size(114, 17)
        Me.chkHarryReviewed.TabIndex = 1161
        Me.chkHarryReviewed.Text = "Harry has reviewed"
        Me.chkHarryReviewed.UseVisualStyleBackColor = False
        Me.chkHarryReviewed.Visible = False
        '
        'cmbNPType
        '
        Me.cmbNPType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbNPType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbNPType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNPType.FormattingEnabled = True
        Me.cmbNPType.Location = New System.Drawing.Point(95, 46)
        Me.cmbNPType.Name = "cmbNPType"
        Me.cmbNPType.Size = New System.Drawing.Size(121, 21)
        Me.cmbNPType.TabIndex = 1159
        '
        'btnExportPDF
        '
        Me.btnExportPDF.Location = New System.Drawing.Point(496, 73)
        Me.btnExportPDF.Name = "btnExportPDF"
        Me.btnExportPDF.Size = New System.Drawing.Size(146, 23)
        Me.btnExportPDF.TabIndex = 1158
        Me.btnExportPDF.Text = "Export CERAD to PDF"
        Me.btnExportPDF.UseVisualStyleBackColor = True
        '
        'btnCERADHeader
        '
        Me.btnCERADHeader.Location = New System.Drawing.Point(8, 73)
        Me.btnCERADHeader.Name = "btnCERADHeader"
        Me.btnCERADHeader.Size = New System.Drawing.Size(178, 23)
        Me.btnCERADHeader.TabIndex = 795
        Me.btnCERADHeader.UseVisualStyleBackColor = True
        '
        'txtXENum
        '
        Me.txtXENum.Location = New System.Drawing.Point(742, 46)
        Me.txtXENum.Name = "txtXENum"
        Me.txtXENum.Size = New System.Drawing.Size(100, 20)
        Me.txtXENum.TabIndex = 793
        '
        'btnNPReportRemove
        '
        Me.btnNPReportRemove.Location = New System.Drawing.Point(381, 96)
        Me.btnNPReportRemove.Name = "btnNPReportRemove"
        Me.btnNPReportRemove.Size = New System.Drawing.Size(72, 23)
        Me.btnNPReportRemove.TabIndex = 792
        Me.btnNPReportRemove.Text = "Delete"
        Me.btnNPReportRemove.UseVisualStyleBackColor = True
        '
        'txtCERADDate
        '
        Me.txtCERADDate.Location = New System.Drawing.Point(635, 46)
        Me.txtCERADDate.Mask = "00/00/0000"
        Me.txtCERADDate.Name = "txtCERADDate"
        Me.txtCERADDate.Size = New System.Drawing.Size(67, 20)
        Me.txtCERADDate.TabIndex = 791
        Me.txtCERADDate.ValidatingType = GetType(Date)
        '
        'comboNeuropathologist
        '
        Me.comboNeuropathologist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboNeuropathologist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboNeuropathologist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboNeuropathologist.FormattingEnabled = True
        Me.comboNeuropathologist.Location = New System.Drawing.Point(315, 46)
        Me.comboNeuropathologist.Name = "comboNeuropathologist"
        Me.comboNeuropathologist.Size = New System.Drawing.Size(225, 21)
        Me.comboNeuropathologist.TabIndex = 789
        '
        'btnNPReport
        '
        Me.btnNPReport.Enabled = False
        Me.btnNPReport.Location = New System.Drawing.Point(344, 73)
        Me.btnNPReport.Name = "btnNPReport"
        Me.btnNPReport.Size = New System.Drawing.Size(146, 23)
        Me.btnNPReport.TabIndex = 787
        Me.btnNPReport.Text = "View NP Report"
        Me.btnNPReport.UseVisualStyleBackColor = True
        '
        'WA_CERAD_Header
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.Controls.Add(Me.btnNPReportProvisionalRemove)
        Me.Controls.Add(Me.btnNPReportProvisional)
        Me.Controls.Add(Me.chkHarryReviewed)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbNPType)
        Me.Controls.Add(Me.btnExportPDF)
        Me.Controls.Add(Me.lblNoRecord)
        Me.Controls.Add(Me.btnCERADHeader)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtXENum)
        Me.Controls.Add(Me.btnNPReportRemove)
        Me.Controls.Add(Me.txtCERADDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.comboNeuropathologist)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnNPReport)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WA_CERAD_Header"
        Me.Size = New System.Drawing.Size(1060, 760)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtXENum As TextBox_
    Friend WithEvents btnNPReportRemove As Button_
    Friend WithEvents txtCERADDate As TextBoxDatePast
    Friend WithEvents Label6 As Label
    Friend WithEvents comboNeuropathologist As ComboBox_
    Friend WithEvents Label5 As Label
    Friend WithEvents btnNPReport As Button_
    Friend WithEvents btnCERADHeader As Button_
    Friend WithEvents lblNoRecord As Label
    Friend WithEvents btnExportPDF As Button_
    Friend WithEvents cmbNPType As ComboBox_
    Friend WithEvents Label2 As Label
    Friend WithEvents chkHarryReviewed As CheckBox_
    Friend WithEvents btnNPReportProvisionalRemove As Button_
    Friend WithEvents btnNPReportProvisional As Button_
End Class
