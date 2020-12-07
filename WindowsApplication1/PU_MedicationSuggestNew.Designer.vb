<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PU_MedicationSuggestNew
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.txtBrandName = New DataWarehouse.TextBox_()
        Me.txtGenericName = New DataWarehouse.TextBox_()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSubmit = New DataWarehouse.Button_()
        Me.btnCancel = New DataWarehouse.Button_()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDosageUnits = New DataWarehouse.TextBox_()
        Me.dtStarted = New DataWarehouse.TextBoxDatePast()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtEnded = New DataWarehouse.TextBoxDatePast()
        Me.numTotalDailyDosage = New DataWarehouse.TextBoxNumeric()
        Me.SuspendLayout()
        '
        'txtBrandName
        '
        Me.txtBrandName.Location = New System.Drawing.Point(96, 31)
        Me.txtBrandName.MaxLength = 225
        Me.txtBrandName.Name = "txtBrandName"
        Me.txtBrandName.Size = New System.Drawing.Size(330, 20)
        Me.txtBrandName.TabIndex = 0
        '
        'txtGenericName
        '
        Me.txtGenericName.Location = New System.Drawing.Point(96, 57)
        Me.txtGenericName.MaxLength = 225
        Me.txtGenericName.Name = "txtGenericName"
        Me.txtGenericName.Size = New System.Drawing.Size(330, 20)
        Me.txtGenericName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Brand Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Generic Name"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(14, 186)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 7
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(95, 186)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(12, 9)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(245, 13)
        Me.lblPrompt.TabIndex = 6
        Me.lblPrompt.Text = "Please provide a Brand or Generic Name (or both)."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Daily Dosage"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Dosage Units"
        '
        'txtDosageUnits
        '
        Me.txtDosageUnits.Location = New System.Drawing.Point(96, 109)
        Me.txtDosageUnits.MaxLength = 50
        Me.txtDosageUnits.Name = "txtDosageUnits"
        Me.txtDosageUnits.Size = New System.Drawing.Size(330, 20)
        Me.txtDosageUnits.TabIndex = 4
        '
        'dtStarted
        '
        Me.dtStarted.Location = New System.Drawing.Point(96, 135)
        Me.dtStarted.Mask = "00/00/0000"
        Me.dtStarted.Name = "dtStarted"
        Me.dtStarted.Size = New System.Drawing.Size(67, 20)
        Me.dtStarted.TabIndex = 5
        Me.dtStarted.ValidatingType = GetType(Date)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Started"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Ended"
        '
        'dtEnded
        '
        Me.dtEnded.Location = New System.Drawing.Point(96, 161)
        Me.dtEnded.Mask = "00/00/0000"
        Me.dtEnded.Name = "dtEnded"
        Me.dtEnded.Size = New System.Drawing.Size(67, 20)
        Me.dtEnded.TabIndex = 6
        Me.dtEnded.ValidatingType = GetType(Date)
        '
        'numTotalDailyDosage
        '
        Me.numTotalDailyDosage.Location = New System.Drawing.Point(96, 83)
        Me.numTotalDailyDosage.Name = "numTotalDailyDosage"
        Me.numTotalDailyDosage.Size = New System.Drawing.Size(330, 20)
        Me.numTotalDailyDosage.TabIndex = 3
        '
        'PU_MedicationSuggestNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(438, 215)
        Me.Controls.Add(Me.numTotalDailyDosage)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtEnded)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtStarted)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDosageUnits)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGenericName)
        Me.Controls.Add(Me.txtBrandName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PU_MedicationSuggestNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Suggest New Medication"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBrandName As TextBox_
    Friend WithEvents txtGenericName As TextBox_
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSubmit As Button_
    Friend WithEvents btnCancel As Button_
    Friend WithEvents lblPrompt As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDosageUnits As TextBox_
    Friend WithEvents dtStarted As TextBoxDatePast
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dtEnded As TextBoxDatePast
    Friend WithEvents numTotalDailyDosage As TextBoxNumeric
End Class
