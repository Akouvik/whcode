<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WA_CERADF
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblNoRecord = New System.Windows.Forms.Label()
        Me.btnCERADFTop = New DataWarehouse.Button_()
        Me.btnCERADFBottom = New DataWarehouse.Button_()
        Me.txtAbnormalBLocation = New DataWarehouse.TextBox_()
        Me.txtAbnormalCLocation = New DataWarehouse.TextBox_()
        Me.txtAbnormalALocation = New DataWarehouse.TextBox_()
        Me.txtAbnormalB = New DataWarehouse.TextBox_()
        Me.txtAbnormalC = New DataWarehouse.TextBox_()
        Me.txtAbnormalA = New DataWarehouse.TextBox_()
        Me.comboAbnormalities = New DataWarehouse.ComboBox_()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(239, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "or Spinal Cord (excluding Degenerative Changes)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Major Non-Vascular Micorscopic Findings of Brain"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 39)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "F"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(295, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "For example, meningitis, metastatic carcinoma, microabscess."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Non-vascular microscopic abnormalities:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "If yes, describe"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(301, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Location"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "a."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "b."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 169)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "c."
        '
        'lblNoRecord
        '
        Me.lblNoRecord.AutoSize = True
        Me.lblNoRecord.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lblNoRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNoRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoRecord.Location = New System.Drawing.Point(12, 98)
        Me.lblNoRecord.Name = "lblNoRecord"
        Me.lblNoRecord.Size = New System.Drawing.Size(620, 64)
        Me.lblNoRecord.TabIndex = 1158
        Me.lblNoRecord.Text = "No CERAD-F Exists For This Subject" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click ""Add New Record"" Above To Create One"
        Me.lblNoRecord.Visible = False
        '
        'btnCERADFTop
        '
        Me.btnCERADFTop.Location = New System.Drawing.Point(12, 12)
        Me.btnCERADFTop.Name = "btnCERADFTop"
        Me.btnCERADFTop.Size = New System.Drawing.Size(178, 23)
        Me.btnCERADFTop.TabIndex = 26
        Me.btnCERADFTop.UseVisualStyleBackColor = True
        '
        'btnCERADFBottom
        '
        Me.btnCERADFBottom.Location = New System.Drawing.Point(12, 192)
        Me.btnCERADFBottom.Name = "btnCERADFBottom"
        Me.btnCERADFBottom.Size = New System.Drawing.Size(178, 23)
        Me.btnCERADFBottom.TabIndex = 8
        Me.btnCERADFBottom.UseVisualStyleBackColor = True
        '
        'txtAbnormalBLocation
        '
        Me.txtAbnormalBLocation.Enabled = False
        Me.txtAbnormalBLocation.Location = New System.Drawing.Point(304, 147)
        Me.txtAbnormalBLocation.Name = "txtAbnormalBLocation"
        Me.txtAbnormalBLocation.Size = New System.Drawing.Size(264, 20)
        Me.txtAbnormalBLocation.TabIndex = 5
        '
        'txtAbnormalCLocation
        '
        Me.txtAbnormalCLocation.Enabled = False
        Me.txtAbnormalCLocation.Location = New System.Drawing.Point(304, 166)
        Me.txtAbnormalCLocation.Name = "txtAbnormalCLocation"
        Me.txtAbnormalCLocation.Size = New System.Drawing.Size(264, 20)
        Me.txtAbnormalCLocation.TabIndex = 7
        '
        'txtAbnormalALocation
        '
        Me.txtAbnormalALocation.Enabled = False
        Me.txtAbnormalALocation.Location = New System.Drawing.Point(304, 128)
        Me.txtAbnormalALocation.Name = "txtAbnormalALocation"
        Me.txtAbnormalALocation.Size = New System.Drawing.Size(264, 20)
        Me.txtAbnormalALocation.TabIndex = 3
        '
        'txtAbnormalB
        '
        Me.txtAbnormalB.Enabled = False
        Me.txtAbnormalB.Location = New System.Drawing.Point(34, 147)
        Me.txtAbnormalB.Name = "txtAbnormalB"
        Me.txtAbnormalB.Size = New System.Drawing.Size(264, 20)
        Me.txtAbnormalB.TabIndex = 4
        '
        'txtAbnormalC
        '
        Me.txtAbnormalC.Enabled = False
        Me.txtAbnormalC.Location = New System.Drawing.Point(34, 166)
        Me.txtAbnormalC.Name = "txtAbnormalC"
        Me.txtAbnormalC.Size = New System.Drawing.Size(264, 20)
        Me.txtAbnormalC.TabIndex = 6
        '
        'txtAbnormalA
        '
        Me.txtAbnormalA.Enabled = False
        Me.txtAbnormalA.Location = New System.Drawing.Point(34, 128)
        Me.txtAbnormalA.Name = "txtAbnormalA"
        Me.txtAbnormalA.Size = New System.Drawing.Size(264, 20)
        Me.txtAbnormalA.TabIndex = 2
        '
        'comboAbnormalities
        '
        Me.comboAbnormalities.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboAbnormalities.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboAbnormalities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboAbnormalities.FormattingEnabled = True
        Me.comboAbnormalities.Location = New System.Drawing.Point(211, 90)
        Me.comboAbnormalities.Name = "comboAbnormalities"
        Me.comboAbnormalities.Size = New System.Drawing.Size(121, 21)
        Me.comboAbnormalities.TabIndex = 1
        '
        'WA_CERADF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(660, 281)
        Me.Controls.Add(Me.lblNoRecord)
        Me.Controls.Add(Me.btnCERADFTop)
        Me.Controls.Add(Me.btnCERADFBottom)
        Me.Controls.Add(Me.txtAbnormalBLocation)
        Me.Controls.Add(Me.txtAbnormalCLocation)
        Me.Controls.Add(Me.txtAbnormalALocation)
        Me.Controls.Add(Me.txtAbnormalB)
        Me.Controls.Add(Me.txtAbnormalC)
        Me.Controls.Add(Me.txtAbnormalA)
        Me.Controls.Add(Me.comboAbnormalities)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WA_CERADF"
        Me.Text = "WA_CERADF"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents comboAbnormalities As DataWarehouse.ComboBox_
    Friend WithEvents txtAbnormalA As DataWarehouse.TextBox_
    Friend WithEvents txtAbnormalC As DataWarehouse.TextBox_
    Friend WithEvents txtAbnormalB As DataWarehouse.TextBox_
    Friend WithEvents txtAbnormalALocation As DataWarehouse.TextBox_
    Friend WithEvents txtAbnormalCLocation As DataWarehouse.TextBox_
    Friend WithEvents txtAbnormalBLocation As DataWarehouse.TextBox_
    Friend WithEvents btnCERADFBottom As DataWarehouse.Button_
    Friend WithEvents btnCERADFTop As DataWarehouse.Button_
    Friend WithEvents lblNoRecord As Label
End Class
