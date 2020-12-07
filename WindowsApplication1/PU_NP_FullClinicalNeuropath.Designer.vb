<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PU_NP_FullClinicalNeuropath
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PU_NP_FullClinicalNeuropath))
        Me.txtOther = New DataWarehouse.TextBox_()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New DataWarehouse.Button_()
        Me.btnSubmit = New DataWarehouse.Button_()
        Me.lblSignatureBlock = New System.Windows.Forms.Label()
        Me.btnSkip = New DataWarehouse.Button_()
        Me.grpIntroText = New System.Windows.Forms.GroupBox()
        Me.txtCustomIntro = New DataWarehouse.TextBox_()
        Me.rdoCustomIntro = New System.Windows.Forms.RadioButton()
        Me.rdoIntro1 = New System.Windows.Forms.RadioButton()
        Me.grpContactInfo = New System.Windows.Forms.GroupBox()
        Me.rdoContactInfoNBTR = New System.Windows.Forms.RadioButton()
        Me.rdoContactInfoADRC = New System.Windows.Forms.RadioButton()
        Me.rdoIntro2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.grpIntroText.SuspendLayout()
        Me.grpContactInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtOther
        '
        Me.txtOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOther.Location = New System.Drawing.Point(6, 19)
        Me.txtOther.Multiline = True
        Me.txtOther.Name = "txtOther"
        Me.txtOther.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOther.Size = New System.Drawing.Size(395, 102)
        Me.txtOther.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtOther)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 191)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(424, 157)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Optional: Insert Paragraph"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(134, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "***MAY BE LEFT BLANK***"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(92, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(222, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "***REMEMBER PROPER PUNCTUATION***"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Dear [RECEIVING DR NAME],"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(271, 549)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(109, 549)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 10
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblSignatureBlock
        '
        Me.lblSignatureBlock.AutoSize = True
        Me.lblSignatureBlock.Location = New System.Drawing.Point(12, 461)
        Me.lblSignatureBlock.Name = "lblSignatureBlock"
        Me.lblSignatureBlock.Size = New System.Drawing.Size(270, 78)
        Me.lblSignatureBlock.TabIndex = 20
        Me.lblSignatureBlock.Text = "Sincerely," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "V. Haroutunian, Ph.D." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Director, Mount Sinai Brain and Tissue Rep" &
    "ository" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For the Clinical and Biological Studies of the Brain Team"
        '
        'btnSkip
        '
        Me.btnSkip.Location = New System.Drawing.Point(190, 549)
        Me.btnSkip.Name = "btnSkip"
        Me.btnSkip.Size = New System.Drawing.Size(75, 23)
        Me.btnSkip.TabIndex = 11
        Me.btnSkip.Text = "Skip"
        Me.btnSkip.UseVisualStyleBackColor = True
        '
        'grpIntroText
        '
        Me.grpIntroText.Controls.Add(Me.rdoIntro2)
        Me.grpIntroText.Controls.Add(Me.txtCustomIntro)
        Me.grpIntroText.Controls.Add(Me.rdoCustomIntro)
        Me.grpIntroText.Controls.Add(Me.rdoIntro1)
        Me.grpIntroText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpIntroText.Location = New System.Drawing.Point(15, 25)
        Me.grpIntroText.Name = "grpIntroText"
        Me.grpIntroText.Size = New System.Drawing.Size(424, 160)
        Me.grpIntroText.TabIndex = 27
        Me.grpIntroText.TabStop = False
        Me.grpIntroText.Text = "Intro Paragraph"
        '
        'txtCustomIntro
        '
        Me.txtCustomIntro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomIntro.Location = New System.Drawing.Point(26, 91)
        Me.txtCustomIntro.Multiline = True
        Me.txtCustomIntro.Name = "txtCustomIntro"
        Me.txtCustomIntro.Size = New System.Drawing.Size(392, 60)
        Me.txtCustomIntro.TabIndex = 2
        Me.txtCustomIntro.Text = "[CUSTOM INTRO TEXT]"
        '
        'rdoCustomIntro
        '
        Me.rdoCustomIntro.AutoSize = True
        Me.rdoCustomIntro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoCustomIntro.Location = New System.Drawing.Point(6, 94)
        Me.rdoCustomIntro.Name = "rdoCustomIntro"
        Me.rdoCustomIntro.Size = New System.Drawing.Size(14, 13)
        Me.rdoCustomIntro.TabIndex = 1
        Me.rdoCustomIntro.TabStop = True
        Me.rdoCustomIntro.UseVisualStyleBackColor = True
        '
        'rdoIntro1
        '
        Me.rdoIntro1.AutoSize = True
        Me.rdoIntro1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoIntro1.Location = New System.Drawing.Point(6, 19)
        Me.rdoIntro1.Name = "rdoIntro1"
        Me.rdoIntro1.Size = New System.Drawing.Size(412, 30)
        Me.rdoIntro1.TabIndex = 0
        Me.rdoIntro1.TabStop = True
        Me.rdoIntro1.Text = "At the request of [CONSENTOR NAME], we would like to share the findings of our" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "n" &
    "europathology examination of [SUBJECT NAME]."
        Me.rdoIntro1.UseVisualStyleBackColor = True
        '
        'grpContactInfo
        '
        Me.grpContactInfo.Controls.Add(Me.rdoContactInfoNBTR)
        Me.grpContactInfo.Controls.Add(Me.rdoContactInfoADRC)
        Me.grpContactInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpContactInfo.Location = New System.Drawing.Point(15, 354)
        Me.grpContactInfo.Name = "grpContactInfo"
        Me.grpContactInfo.Size = New System.Drawing.Size(424, 104)
        Me.grpContactInfo.TabIndex = 28
        Me.grpContactInfo.TabStop = False
        Me.grpContactInfo.Text = "Contact Info"
        '
        'rdoContactInfoNBTR
        '
        Me.rdoContactInfoNBTR.AutoSize = True
        Me.rdoContactInfoNBTR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoContactInfoNBTR.Location = New System.Drawing.Point(6, 19)
        Me.rdoContactInfoNBTR.Name = "rdoContactInfoNBTR"
        Me.rdoContactInfoNBTR.Size = New System.Drawing.Size(304, 30)
        Me.rdoContactInfoNBTR.TabIndex = 1
        Me.rdoContactInfoNBTR.TabStop = True
        Me.rdoContactInfoNBTR.Text = "Please feel free to contact me at 718-584-9000 Ext 6082 or" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "vahram.haroutunian@ms" &
    "sm.edu if you have any questions."
        Me.rdoContactInfoNBTR.UseVisualStyleBackColor = True
        '
        'rdoContactInfoADRC
        '
        Me.rdoContactInfoADRC.AutoSize = True
        Me.rdoContactInfoADRC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoContactInfoADRC.Location = New System.Drawing.Point(6, 55)
        Me.rdoContactInfoADRC.Name = "rdoContactInfoADRC"
        Me.rdoContactInfoADRC.Size = New System.Drawing.Size(390, 43)
        Me.rdoContactInfoADRC.TabIndex = 0
        Me.rdoContactInfoADRC.TabStop = True
        Me.rdoContactInfoADRC.Text = resources.GetString("rdoContactInfoADRC.Text")
        Me.rdoContactInfoADRC.UseVisualStyleBackColor = True
        '
        'rdoIntro2
        '
        Me.rdoIntro2.AutoSize = True
        Me.rdoIntro2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoIntro2.Location = New System.Drawing.Point(6, 55)
        Me.rdoIntro2.Name = "rdoIntro2"
        Me.rdoIntro2.Size = New System.Drawing.Size(390, 30)
        Me.rdoIntro2.TabIndex = 3
        Me.rdoIntro2.TabStop = True
        Me.rdoIntro2.Text = "As per your request, we would like to share the findings of our neuropathology" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "e" &
    "xamination of [SUBJECT NAME]."
        Me.rdoIntro2.UseVisualStyleBackColor = True
        '
        'PU_NP_FullClinicalNeuropath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(447, 576)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpContactInfo)
        Me.Controls.Add(Me.grpIntroText)
        Me.Controls.Add(Me.btnSkip)
        Me.Controls.Add(Me.lblSignatureBlock)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "PU_NP_FullClinicalNeuropath"
        Me.Text = "Full Clinical Neuropath- Insert Custom Paragraph"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpIntroText.ResumeLayout(False)
        Me.grpIntroText.PerformLayout()
        Me.grpContactInfo.ResumeLayout(False)
        Me.grpContactInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOther As DataWarehouse.TextBox_
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As DataWarehouse.Button_
    Friend WithEvents btnSubmit As DataWarehouse.Button_
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSignatureBlock As System.Windows.Forms.Label
    Friend WithEvents btnSkip As DataWarehouse.Button_
    Friend WithEvents grpIntroText As GroupBox
    Friend WithEvents txtCustomIntro As TextBox_
    Friend WithEvents rdoCustomIntro As RadioButton
    Friend WithEvents rdoIntro1 As RadioButton
    Friend WithEvents grpContactInfo As GroupBox
    Friend WithEvents rdoContactInfoNBTR As RadioButton
    Friend WithEvents rdoContactInfoADRC As RadioButton
    Friend WithEvents rdoIntro2 As RadioButton
End Class
