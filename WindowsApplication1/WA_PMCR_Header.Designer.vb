<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WA_PMCR_Header
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNoRecord = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPMCR_Header_Top = New DataWarehouse.Button_()
        Me.comboAssessedBy = New DataWarehouse.ComboBox_()
        Me.txtAssessmentDate = New DataWarehouse.TextBoxDatePast()
        Me.btnPDFExport = New DataWarehouse.Button_()
        Me.txtOverClinImp = New DataWarehouse.TextBox_()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkHarryReviewed = New DataWarehouse.CheckBox_()
        Me.chkSuicide = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 209
        Me.Label3.Text = "PMCR Conducted By"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 208
        Me.Label2.Text = "Date Completed"
        '
        'lblNoRecord
        '
        Me.lblNoRecord.AutoSize = True
        Me.lblNoRecord.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lblNoRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNoRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoRecord.Location = New System.Drawing.Point(3, 31)
        Me.lblNoRecord.Name = "lblNoRecord"
        Me.lblNoRecord.Size = New System.Drawing.Size(596, 64)
        Me.lblNoRecord.TabIndex = 1158
        Me.lblNoRecord.Text = "No PMCR Header exists for this subject" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click ""Add New Record"" above to create on" &
    "e"
        Me.lblNoRecord.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(211, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 17)
        Me.Label1.TabIndex = 1161
        Me.Label1.Text = "This means ALL DATA ENTRY COMPLETE!"
        '
        'btnPMCR_Header_Top
        '
        Me.btnPMCR_Header_Top.Location = New System.Drawing.Point(3, 5)
        Me.btnPMCR_Header_Top.Name = "btnPMCR_Header_Top"
        Me.btnPMCR_Header_Top.Size = New System.Drawing.Size(181, 23)
        Me.btnPMCR_Header_Top.TabIndex = 104
        Me.btnPMCR_Header_Top.Text = "Add New Record"
        Me.btnPMCR_Header_Top.UseVisualStyleBackColor = True
        '
        'comboAssessedBy
        '
        Me.comboAssessedBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboAssessedBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboAssessedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboAssessedBy.Enabled = False
        Me.comboAssessedBy.FormattingEnabled = True
        Me.comboAssessedBy.Location = New System.Drawing.Point(138, 34)
        Me.comboAssessedBy.Name = "comboAssessedBy"
        Me.comboAssessedBy.Size = New System.Drawing.Size(301, 21)
        Me.comboAssessedBy.TabIndex = 100
        '
        'txtAssessmentDate
        '
        Me.txtAssessmentDate.Enabled = False
        Me.txtAssessmentDate.Location = New System.Drawing.Point(138, 61)
        Me.txtAssessmentDate.Mask = "00/00/0000"
        Me.txtAssessmentDate.Name = "txtAssessmentDate"
        Me.txtAssessmentDate.Size = New System.Drawing.Size(67, 20)
        Me.txtAssessmentDate.TabIndex = 101
        Me.txtAssessmentDate.ValidatingType = GetType(Date)
        '
        'btnPDFExport
        '
        Me.btnPDFExport.Location = New System.Drawing.Point(3, 678)
        Me.btnPDFExport.Name = "btnPDFExport"
        Me.btnPDFExport.Size = New System.Drawing.Size(181, 23)
        Me.btnPDFExport.TabIndex = 1162
        Me.btnPDFExport.Text = "Generate PDF Export"
        Me.btnPDFExport.UseVisualStyleBackColor = True
        '
        'txtOverClinImp
        '
        Me.txtOverClinImp.Location = New System.Drawing.Point(138, 111)
        Me.txtOverClinImp.MaxLength = 600000
        Me.txtOverClinImp.Multiline = True
        Me.txtOverClinImp.Name = "txtOverClinImp"
        Me.txtOverClinImp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOverClinImp.Size = New System.Drawing.Size(904, 561)
        Me.txtOverClinImp.TabIndex = 1163
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 13)
        Me.Label4.TabIndex = 1164
        Me.Label4.Text = "Overall Clinical Impression"
        '
        'chkHarryReviewed
        '
        Me.chkHarryReviewed.AutoSize = True
        Me.chkHarryReviewed.BackColor = System.Drawing.Color.Tan
        Me.chkHarryReviewed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkHarryReviewed.Location = New System.Drawing.Point(190, 8)
        Me.chkHarryReviewed.Name = "chkHarryReviewed"
        Me.chkHarryReviewed.Size = New System.Drawing.Size(114, 17)
        Me.chkHarryReviewed.TabIndex = 1165
        Me.chkHarryReviewed.Text = "Harry has reviewed"
        Me.chkHarryReviewed.UseVisualStyleBackColor = False
        Me.chkHarryReviewed.Visible = False
        '
        'chkSuicide
        '
        Me.chkSuicide.AutoSize = True
        Me.chkSuicide.Enabled = False
        Me.chkSuicide.Location = New System.Drawing.Point(138, 88)
        Me.chkSuicide.Name = "chkSuicide"
        Me.chkSuicide.Size = New System.Drawing.Size(441, 17)
        Me.chkSuicide.TabIndex = 1166
        Me.chkSuicide.Text = "Suicide (this is set automatically based off of Manner of Death from Autopsy Face" &
    " Sheet)"
        Me.chkSuicide.UseVisualStyleBackColor = True
        '
        'WA_PMCR_Header
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.Controls.Add(Me.lblNoRecord)
        Me.Controls.Add(Me.chkSuicide)
        Me.Controls.Add(Me.chkHarryReviewed)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtOverClinImp)
        Me.Controls.Add(Me.btnPDFExport)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPMCR_Header_Top)
        Me.Controls.Add(Me.comboAssessedBy)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAssessmentDate)
        Me.Controls.Add(Me.Label2)
        Me.Name = "WA_PMCR_Header"
        Me.Size = New System.Drawing.Size(1045, 705)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents comboAssessedBy As ComboBox_
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAssessmentDate As TextBoxDatePast
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPMCR_Header_Top As Button_
    Friend WithEvents lblNoRecord As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPDFExport As Button_
    Friend WithEvents txtOverClinImp As TextBox_
    Friend WithEvents Label4 As Label
    Friend WithEvents chkHarryReviewed As CheckBox_
    Friend WithEvents chkSuicide As CheckBox
End Class
