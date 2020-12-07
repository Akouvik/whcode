<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PU_Vitals
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numHeight = New DataWarehouse.TextBoxNumeric()
        Me.numWeight = New DataWarehouse.TextBoxNumeric()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numWaist = New DataWarehouse.TextBoxNumeric()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numBMI = New DataWarehouse.TextBoxNumeric()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtVitalsDate = New DataWarehouse.TextBoxDatePast()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.intPulse = New DataWarehouse.TextBoxInteger()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.intRespirations = New DataWarehouse.TextBoxInteger()
        Me.intSystolic = New DataWarehouse.TextBoxInteger()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.intDiastolic = New DataWarehouse.TextBoxInteger()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.numMeanBP = New DataWarehouse.TextBoxNumeric()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.numTempF = New DataWarehouse.TextBoxNumeric()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.numTempC = New DataWarehouse.TextBoxNumeric()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.numPh = New DataWarehouse.TextBoxNumeric()
        Me.btnSave = New DataWarehouse.Button_()
        Me.btnCancel = New DataWarehouse.Button_()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Height (in)"
        '
        'numHeight
        '
        Me.numHeight.Location = New System.Drawing.Point(81, 44)
        Me.numHeight.Name = "numHeight"
        Me.numHeight.Size = New System.Drawing.Size(49, 20)
        Me.numHeight.TabIndex = 2
        '
        'numWeight
        '
        Me.numWeight.Location = New System.Drawing.Point(81, 63)
        Me.numWeight.Name = "numWeight"
        Me.numWeight.Size = New System.Drawing.Size(49, 20)
        Me.numWeight.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Weight (lbs)"
        '
        'numWaist
        '
        Me.numWaist.Location = New System.Drawing.Point(81, 82)
        Me.numWaist.Name = "numWaist"
        Me.numWaist.Size = New System.Drawing.Size(49, 20)
        Me.numWaist.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Waist (in)"
        '
        'numBMI
        '
        Me.numBMI.Location = New System.Drawing.Point(81, 101)
        Me.numBMI.Name = "numBMI"
        Me.numBMI.Size = New System.Drawing.Size(49, 20)
        Me.numBMI.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "BMI (%)"
        '
        'dtVitalsDate
        '
        Me.dtVitalsDate.Location = New System.Drawing.Point(110, 6)
        Me.dtVitalsDate.Mask = "00/00/0000"
        Me.dtVitalsDate.Name = "dtVitalsDate"
        Me.dtVitalsDate.Size = New System.Drawing.Size(67, 20)
        Me.dtVitalsDate.TabIndex = 1
        Me.dtVitalsDate.ValidatingType = GetType(Date)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Vitals Taken Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(136, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Respirations"
        '
        'intPulse
        '
        Me.intPulse.Location = New System.Drawing.Point(207, 63)
        Me.intPulse.Name = "intPulse"
        Me.intPulse.Size = New System.Drawing.Size(49, 20)
        Me.intPulse.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(168, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Pulse"
        '
        'intRespirations
        '
        Me.intRespirations.Location = New System.Drawing.Point(207, 44)
        Me.intRespirations.Name = "intRespirations"
        Me.intRespirations.Size = New System.Drawing.Size(49, 20)
        Me.intRespirations.TabIndex = 6
        '
        'intSystolic
        '
        Me.intSystolic.Location = New System.Drawing.Point(207, 82)
        Me.intSystolic.Name = "intSystolic"
        Me.intSystolic.Size = New System.Drawing.Size(49, 20)
        Me.intSystolic.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(158, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Systolic"
        '
        'intDiastolic
        '
        Me.intDiastolic.Location = New System.Drawing.Point(207, 101)
        Me.intDiastolic.Name = "intDiastolic"
        Me.intDiastolic.Size = New System.Drawing.Size(49, 20)
        Me.intDiastolic.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(154, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Diastolic"
        '
        'numMeanBP
        '
        Me.numMeanBP.Enabled = False
        Me.numMeanBP.Location = New System.Drawing.Point(207, 120)
        Me.numMeanBP.Name = "numMeanBP"
        Me.numMeanBP.Size = New System.Drawing.Size(49, 20)
        Me.numMeanBP.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(150, 123)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Mean BP"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(263, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Temp (F)"
        '
        'numTempF
        '
        Me.numTempF.Location = New System.Drawing.Point(318, 44)
        Me.numTempF.Name = "numTempF"
        Me.numTempF.Size = New System.Drawing.Size(49, 20)
        Me.numTempF.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(262, 66)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Temp (C)"
        '
        'numTempC
        '
        Me.numTempC.Location = New System.Drawing.Point(318, 63)
        Me.numTempC.Name = "numTempC"
        Me.numTempC.Size = New System.Drawing.Size(49, 20)
        Me.numTempC.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(291, 85)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "pH"
        '
        'numPh
        '
        Me.numPh.Location = New System.Drawing.Point(318, 82)
        Me.numPh.Name = "numPh"
        Me.numPh.Size = New System.Drawing.Size(49, 20)
        Me.numPh.TabIndex = 13
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(116, 148)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(197, 148)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'PU_Vitals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(387, 184)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.numPh)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.numTempC)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.numTempF)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.numMeanBP)
        Me.Controls.Add(Me.intDiastolic)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.intSystolic)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.intRespirations)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.intPulse)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtVitalsDate)
        Me.Controls.Add(Me.numBMI)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.numWaist)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.numWeight)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.numHeight)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PU_Vitals"
        Me.Text = "Subject Vitals"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents numHeight As TextBoxNumeric
    Friend WithEvents numWeight As TextBoxNumeric
    Friend WithEvents Label2 As Label
    Friend WithEvents numWaist As TextBoxNumeric
    Friend WithEvents Label3 As Label
    Friend WithEvents numBMI As TextBoxNumeric
    Friend WithEvents Label4 As Label
    Friend WithEvents dtVitalsDate As TextBoxDatePast
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents intPulse As TextBoxInteger
    Friend WithEvents Label7 As Label
    Friend WithEvents intRespirations As TextBoxInteger
    Friend WithEvents intSystolic As TextBoxInteger
    Friend WithEvents Label8 As Label
    Friend WithEvents intDiastolic As TextBoxInteger
    Friend WithEvents Label9 As Label
    Friend WithEvents numMeanBP As TextBoxNumeric
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents numTempF As TextBoxNumeric
    Friend WithEvents Label12 As Label
    Friend WithEvents numTempC As TextBoxNumeric
    Friend WithEvents Label13 As Label
    Friend WithEvents numPh As TextBoxNumeric
    Friend WithEvents btnSave As Button_
    Friend WithEvents btnCancel As Button_
End Class
