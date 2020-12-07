<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WA_Demographics
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grpSubjectIDs = New System.Windows.Forms.GroupBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.NACCIDType = New DataWarehouse.ComboBox_()
        Me.txtXENum = New DataWarehouse.TextBox_()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNACCID = New DataWarehouse.TextBox_()
        Me.txtBB = New DataWarehouse.TextBox_()
        Me.txtSubNum = New DataWarehouse.TextBox_()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSubNum = New System.Windows.Forms.Label()
        Me.grpCohort = New System.Windows.Forms.GroupBox()
        Me.chkRelOrd = New DataWarehouse.CheckBox_()
        Me.ADRCClinicalTrialsCohort = New DataWarehouse.CheckBox_()
        Me.chkTBI = New DataWarehouse.CheckBox_()
        Me.chkNBTR = New DataWarehouse.CheckBox_()
        Me.chkIsrael = New DataWarehouse.CheckBox_()
        Me.chkSchizo = New DataWarehouse.CheckBox_()
        Me.chkNACC = New DataWarehouse.CheckBox_()
        Me.chkPPG = New DataWarehouse.CheckBox_()
        Me.chkADRC = New DataWarehouse.CheckBox_()
        Me.grpMisc = New System.Windows.Forms.GroupBox()
        Me.btnRemove = New DataWarehouse.Button_()
        Me.btnDonationFile = New DataWarehouse.Button_()
        Me.comboDonationWishes = New DataWarehouse.ComboBox_()
        Me.txtNotes = New DataWarehouse.TextBox_()
        Me.lblSpecialInstructions = New System.Windows.Forms.Label()
        Me.lblDonationWishes = New System.Windows.Forms.Label()
        Me.grpDemographics = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbHearingLoss = New DataWarehouse.ComboBox_()
        Me.MilitaryService = New DataWarehouse.ComboBox_()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.SexualOrientationATOD = New DataWarehouse.ComboBox_()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.GenderATOD = New DataWarehouse.ComboBox_()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.comboMaritalStatus = New DataWarehouse.ComboBox_()
        Me.comboMobility = New DataWarehouse.ComboBox_()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtRaceSpec = New DataWarehouse.TextBox_()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtEthSpec = New DataWarehouse.TextBox_()
        Me.txtMultiBirth = New DataWarehouse.TextBox_()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.comboMultiBirth = New DataWarehouse.ComboBox_()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.comboHandedness = New DataWarehouse.ComboBox_()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.comboLevelOfIndependence = New DataWarehouse.ComboBox_()
        Me.txtLifetimeOccupation = New DataWarehouse.TextBox_()
        Me.txtPlaceOfBirth = New DataWarehouse.TextBox_()
        Me.txtYearsOfEducation = New DataWarehouse.TextBox_()
        Me.txtLanguageNote = New DataWarehouse.TextBox_()
        Me.comboSecondaryLanguage = New DataWarehouse.ComboBox_()
        Me.comboPrimaryLanguage = New DataWarehouse.ComboBox_()
        Me.comboRace = New DataWarehouse.ComboBox_()
        Me.comboEthnicity = New DataWarehouse.ComboBox_()
        Me.comboSex = New DataWarehouse.ComboBox_()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblEthnicity = New System.Windows.Forms.Label()
        Me.lblRace = New System.Windows.Forms.Label()
        Me.lblLanguageNote = New System.Windows.Forms.Label()
        Me.lblYearsOfEducation = New System.Windows.Forms.Label()
        Me.lblPrimaryLanguage = New System.Windows.Forms.Label()
        Me.lblSecondaryLanguage = New System.Windows.Forms.Label()
        Me.grpNicotine = New System.Windows.Forms.GroupBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.grpNicotineOther = New System.Windows.Forms.GroupBox()
        Me.cmbNicOthType = New DataWarehouse.ComboBox_()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtNicOthFreq = New DataWarehouse.TextBoxInteger()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtNicOthYrsUse = New DataWarehouse.TextBoxInteger()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtNicOthAgeStarted = New DataWarehouse.TextBoxInteger()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.dtNicOthDateQuit = New DataWarehouse.TextBoxDatePast()
        Me.grpCigarettes = New System.Windows.Forms.GroupBox()
        Me.txtCigFreq = New DataWarehouse.TextBoxInteger()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtCigYrsUse = New DataWarehouse.TextBoxInteger()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCigAgeStarted = New DataWarehouse.TextBoxInteger()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtCigDateQuit = New DataWarehouse.TextBoxDatePast()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbNicotineHx = New DataWarehouse.ComboBox_()
        Me.grpAddress = New System.Windows.Forms.GroupBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtZip = New DataWarehouse.TextBox_()
        Me.txtState = New DataWarehouse.TextBox_()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtEmail = New DataWarehouse.TextBox_()
        Me.txtWorkPhone = New DataWarehouse.TextBox_()
        Me.txtMobilePhone = New DataWarehouse.TextBox_()
        Me.txtHomePhone = New DataWarehouse.TextBox_()
        Me.txtCity = New DataWarehouse.TextBox_()
        Me.txtAddress2 = New DataWarehouse.TextBox_()
        Me.txtAddress1 = New DataWarehouse.TextBox_()
        Me.lblAddress1 = New System.Windows.Forms.Label()
        Me.lblAddress2 = New System.Windows.Forms.Label()
        Me.lblCityStateZip = New System.Windows.Forms.Label()
        Me.lblHomePhone = New System.Windows.Forms.Label()
        Me.lblMobilePhone = New System.Windows.Forms.Label()
        Me.lblWorkPhone = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.grpSubjectInfo = New System.Windows.Forms.GroupBox()
        Me.cmbSalutation = New DataWarehouse.ComboBox_()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtAge = New DataWarehouse.TextBox_()
        Me.txtSSN = New DataWarehouse.TextBox_()
        Me.txtSuffix = New DataWarehouse.TextBox_()
        Me.txtLastName = New DataWarehouse.TextBox_()
        Me.txtMI = New DataWarehouse.TextBox_()
        Me.txtFirstName = New DataWarehouse.TextBox_()
        Me.txtDoB = New DataWarehouse.TextBoxDatePast()
        Me.lblSalutation = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblMI = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblSuffix = New System.Windows.Forms.Label()
        Me.lblSSN = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.grpPsychNeuroDx = New System.Windows.Forms.GroupBox()
        Me.lblEmptyPsychNeuroDx = New System.Windows.Forms.Label()
        Me.btnPsychNeuroRelAdd = New DataWarehouse.Button_()
        Me.dgvRelWithSimilarDx = New DataWarehouse.dgvSingleRow()
        Me.txtPrimNeuroText = New DataWarehouse.TextBox_()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtPrimNeuroICD = New DataWarehouse.TextBox_()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtPrimPsychText = New DataWarehouse.TextBox_()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPrimPsychICD = New DataWarehouse.TextBox_()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.chkDNDiss = New DataWarehouse.CheckBox_()
        Me.chkDNDist = New DataWarehouse.CheckBox_()
        Me.chkDNC = New DataWarehouse.CheckBox_()
        Me.btnSubjectTop = New DataWarehouse.Button_()
        Me.btnSubjectBottom = New DataWarehouse.Button_()
        Me.grpSubjectIDs.SuspendLayout()
        Me.grpCohort.SuspendLayout()
        Me.grpMisc.SuspendLayout()
        Me.grpDemographics.SuspendLayout()
        Me.grpNicotine.SuspendLayout()
        Me.grpNicotineOther.SuspendLayout()
        Me.grpCigarettes.SuspendLayout()
        Me.grpAddress.SuspendLayout()
        Me.grpSubjectInfo.SuspendLayout()
        Me.grpPsychNeuroDx.SuspendLayout()
        CType(Me.dgvRelWithSimilarDx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpSubjectIDs
        '
        Me.grpSubjectIDs.Controls.Add(Me.Label34)
        Me.grpSubjectIDs.Controls.Add(Me.NACCIDType)
        Me.grpSubjectIDs.Controls.Add(Me.txtXENum)
        Me.grpSubjectIDs.Controls.Add(Me.Label13)
        Me.grpSubjectIDs.Controls.Add(Me.txtNACCID)
        Me.grpSubjectIDs.Controls.Add(Me.txtBB)
        Me.grpSubjectIDs.Controls.Add(Me.txtSubNum)
        Me.grpSubjectIDs.Controls.Add(Me.Label3)
        Me.grpSubjectIDs.Controls.Add(Me.Label2)
        Me.grpSubjectIDs.Controls.Add(Me.lblSubNum)
        Me.grpSubjectIDs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSubjectIDs.Location = New System.Drawing.Point(3, 812)
        Me.grpSubjectIDs.Name = "grpSubjectIDs"
        Me.grpSubjectIDs.Size = New System.Drawing.Size(255, 119)
        Me.grpSubjectIDs.TabIndex = 600
        Me.grpSubjectIDs.TabStop = False
        Me.grpSubjectIDs.Text = "Subject ID's"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(11, 97)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(77, 13)
        Me.Label34.TabIndex = 612
        Me.Label34.Text = "NACC ID Type"
        '
        'NACCIDType
        '
        Me.NACCIDType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.NACCIDType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NACCIDType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NACCIDType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NACCIDType.FormattingEnabled = True
        Me.NACCIDType.Location = New System.Drawing.Point(94, 93)
        Me.NACCIDType.Name = "NACCIDType"
        Me.NACCIDType.Size = New System.Drawing.Size(155, 21)
        Me.NACCIDType.TabIndex = 611
        '
        'txtXENum
        '
        Me.txtXENum.BackColor = System.Drawing.Color.White
        Me.txtXENum.Enabled = False
        Me.txtXENum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtXENum.Location = New System.Drawing.Point(94, 55)
        Me.txtXENum.Name = "txtXENum"
        Me.txtXENum.Size = New System.Drawing.Size(155, 20)
        Me.txtXENum.TabIndex = 168
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(57, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "XE #"
        '
        'txtNACCID
        '
        Me.txtNACCID.BackColor = System.Drawing.Color.White
        Me.txtNACCID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNACCID.Location = New System.Drawing.Point(94, 74)
        Me.txtNACCID.Name = "txtNACCID"
        Me.txtNACCID.Size = New System.Drawing.Size(155, 20)
        Me.txtNACCID.TabIndex = 610
        '
        'txtBB
        '
        Me.txtBB.BackColor = System.Drawing.Color.White
        Me.txtBB.Enabled = False
        Me.txtBB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBB.Location = New System.Drawing.Point(94, 36)
        Me.txtBB.Name = "txtBB"
        Me.txtBB.Size = New System.Drawing.Size(155, 20)
        Me.txtBB.TabIndex = 166
        '
        'txtSubNum
        '
        Me.txtSubNum.BackColor = System.Drawing.Color.White
        Me.txtSubNum.Enabled = False
        Me.txtSubNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubNum.Location = New System.Drawing.Point(94, 17)
        Me.txtSubNum.Name = "txtSubNum"
        Me.txtSubNum.Size = New System.Drawing.Size(155, 20)
        Me.txtSubNum.TabIndex = 165
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "NACC ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "BB #"
        '
        'lblSubNum
        '
        Me.lblSubNum.AutoSize = True
        Me.lblSubNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubNum.Location = New System.Drawing.Point(41, 20)
        Me.lblSubNum.Name = "lblSubNum"
        Me.lblSubNum.Size = New System.Drawing.Size(48, 13)
        Me.lblSubNum.TabIndex = 0
        Me.lblSubNum.Text = "SubNum"
        '
        'grpCohort
        '
        Me.grpCohort.Controls.Add(Me.chkRelOrd)
        Me.grpCohort.Controls.Add(Me.ADRCClinicalTrialsCohort)
        Me.grpCohort.Controls.Add(Me.chkTBI)
        Me.grpCohort.Controls.Add(Me.chkNBTR)
        Me.grpCohort.Controls.Add(Me.chkIsrael)
        Me.grpCohort.Controls.Add(Me.chkSchizo)
        Me.grpCohort.Controls.Add(Me.chkNACC)
        Me.grpCohort.Controls.Add(Me.chkPPG)
        Me.grpCohort.Controls.Add(Me.chkADRC)
        Me.grpCohort.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCohort.Location = New System.Drawing.Point(592, 32)
        Me.grpCohort.Name = "grpCohort"
        Me.grpCohort.Size = New System.Drawing.Size(293, 173)
        Me.grpCohort.TabIndex = 200
        Me.grpCohort.TabStop = False
        Me.grpCohort.Text = "Cohort Participation"
        '
        'chkRelOrd
        '
        Me.chkRelOrd.AutoSize = True
        Me.chkRelOrd.BackColor = System.Drawing.Color.Tan
        Me.chkRelOrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkRelOrd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRelOrd.Location = New System.Drawing.Point(6, 110)
        Me.chkRelOrd.Name = "chkRelOrd"
        Me.chkRelOrd.Size = New System.Drawing.Size(127, 17)
        Me.chkRelOrd.TabIndex = 263
        Me.chkRelOrd.Text = "Religious Order (nuns)"
        Me.chkRelOrd.UseVisualStyleBackColor = True
        '
        'ADRCClinicalTrialsCohort
        '
        Me.ADRCClinicalTrialsCohort.AutoSize = True
        Me.ADRCClinicalTrialsCohort.BackColor = System.Drawing.Color.Tan
        Me.ADRCClinicalTrialsCohort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ADRCClinicalTrialsCohort.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADRCClinicalTrialsCohort.Location = New System.Drawing.Point(155, 52)
        Me.ADRCClinicalTrialsCohort.Name = "ADRCClinicalTrialsCohort"
        Me.ADRCClinicalTrialsCohort.Size = New System.Drawing.Size(84, 17)
        Me.ADRCClinicalTrialsCohort.TabIndex = 262
        Me.ADRCClinicalTrialsCohort.Text = "Clinical Trials"
        Me.ADRCClinicalTrialsCohort.UseVisualStyleBackColor = True
        '
        'chkTBI
        '
        Me.chkTBI.AutoSize = True
        Me.chkTBI.BackColor = System.Drawing.Color.Tan
        Me.chkTBI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkTBI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTBI.Location = New System.Drawing.Point(6, 91)
        Me.chkTBI.Name = "chkTBI"
        Me.chkTBI.Size = New System.Drawing.Size(40, 17)
        Me.chkTBI.TabIndex = 261
        Me.chkTBI.Text = "TBI"
        Me.chkTBI.UseVisualStyleBackColor = True
        '
        'chkNBTR
        '
        Me.chkNBTR.AutoSize = True
        Me.chkNBTR.BackColor = System.Drawing.Color.Tan
        Me.chkNBTR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkNBTR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNBTR.Location = New System.Drawing.Point(6, 16)
        Me.chkNBTR.Name = "chkNBTR"
        Me.chkNBTR.Size = New System.Drawing.Size(53, 17)
        Me.chkNBTR.TabIndex = 210
        Me.chkNBTR.Text = "NBTR"
        Me.chkNBTR.UseVisualStyleBackColor = True
        '
        'chkIsrael
        '
        Me.chkIsrael.AutoSize = True
        Me.chkIsrael.BackColor = System.Drawing.Color.Tan
        Me.chkIsrael.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkIsrael.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIsrael.Location = New System.Drawing.Point(6, 35)
        Me.chkIsrael.Name = "chkIsrael"
        Me.chkIsrael.Size = New System.Drawing.Size(48, 17)
        Me.chkIsrael.TabIndex = 240
        Me.chkIsrael.Text = "Israel"
        Me.chkIsrael.UseVisualStyleBackColor = True
        '
        'chkSchizo
        '
        Me.chkSchizo.AutoSize = True
        Me.chkSchizo.BackColor = System.Drawing.Color.Tan
        Me.chkSchizo.Enabled = False
        Me.chkSchizo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkSchizo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSchizo.Location = New System.Drawing.Point(6, 72)
        Me.chkSchizo.Name = "chkSchizo"
        Me.chkSchizo.Size = New System.Drawing.Size(90, 17)
        Me.chkSchizo.TabIndex = 260
        Me.chkSchizo.Text = "Schizophrenia"
        Me.chkSchizo.UseVisualStyleBackColor = True
        '
        'chkNACC
        '
        Me.chkNACC.AutoSize = True
        Me.chkNACC.BackColor = System.Drawing.Color.Tan
        Me.chkNACC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkNACC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNACC.Location = New System.Drawing.Point(155, 33)
        Me.chkNACC.Name = "chkNACC"
        Me.chkNACC.Size = New System.Drawing.Size(52, 17)
        Me.chkNACC.TabIndex = 230
        Me.chkNACC.Text = "NACC"
        Me.chkNACC.UseVisualStyleBackColor = True
        '
        'chkPPG
        '
        Me.chkPPG.AutoSize = True
        Me.chkPPG.BackColor = System.Drawing.Color.Tan
        Me.chkPPG.Enabled = False
        Me.chkPPG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkPPG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPPG.Location = New System.Drawing.Point(6, 54)
        Me.chkPPG.Name = "chkPPG"
        Me.chkPPG.Size = New System.Drawing.Size(45, 17)
        Me.chkPPG.TabIndex = 250
        Me.chkPPG.Text = "PPG"
        Me.chkPPG.UseVisualStyleBackColor = True
        '
        'chkADRC
        '
        Me.chkADRC.AutoSize = True
        Me.chkADRC.BackColor = System.Drawing.Color.Tan
        Me.chkADRC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkADRC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkADRC.Location = New System.Drawing.Point(155, 16)
        Me.chkADRC.Name = "chkADRC"
        Me.chkADRC.Size = New System.Drawing.Size(53, 17)
        Me.chkADRC.TabIndex = 220
        Me.chkADRC.Text = "ADRC"
        Me.chkADRC.UseVisualStyleBackColor = True
        '
        'grpMisc
        '
        Me.grpMisc.Controls.Add(Me.btnRemove)
        Me.grpMisc.Controls.Add(Me.btnDonationFile)
        Me.grpMisc.Controls.Add(Me.comboDonationWishes)
        Me.grpMisc.Controls.Add(Me.txtNotes)
        Me.grpMisc.Controls.Add(Me.lblSpecialInstructions)
        Me.grpMisc.Controls.Add(Me.lblDonationWishes)
        Me.grpMisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMisc.Location = New System.Drawing.Point(264, 812)
        Me.grpMisc.Name = "grpMisc"
        Me.grpMisc.Size = New System.Drawing.Size(621, 119)
        Me.grpMisc.TabIndex = 620
        Me.grpMisc.TabStop = False
        Me.grpMisc.Text = "Miscellaneous Info"
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(470, 92)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(66, 23)
        Me.btnRemove.TabIndex = 660
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnDonationFile
        '
        Me.btnDonationFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDonationFile.Location = New System.Drawing.Point(391, 69)
        Me.btnDonationFile.Name = "btnDonationFile"
        Me.btnDonationFile.Size = New System.Drawing.Size(225, 23)
        Me.btnDonationFile.TabIndex = 650
        Me.btnDonationFile.UseVisualStyleBackColor = True
        '
        'comboDonationWishes
        '
        Me.comboDonationWishes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboDonationWishes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboDonationWishes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboDonationWishes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboDonationWishes.FormattingEnabled = True
        Me.comboDonationWishes.Location = New System.Drawing.Point(130, 70)
        Me.comboDonationWishes.Name = "comboDonationWishes"
        Me.comboDonationWishes.Size = New System.Drawing.Size(225, 21)
        Me.comboDonationWishes.TabIndex = 640
        '
        'txtNotes
        '
        Me.txtNotes.BackColor = System.Drawing.Color.White
        Me.txtNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.Location = New System.Drawing.Point(50, 17)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(565, 52)
        Me.txtNotes.TabIndex = 630
        '
        'lblSpecialInstructions
        '
        Me.lblSpecialInstructions.AutoSize = True
        Me.lblSpecialInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpecialInstructions.Location = New System.Drawing.Point(6, 22)
        Me.lblSpecialInstructions.Name = "lblSpecialInstructions"
        Me.lblSpecialInstructions.Size = New System.Drawing.Size(38, 13)
        Me.lblSpecialInstructions.TabIndex = 44
        Me.lblSpecialInstructions.Text = "Notes:"
        '
        'lblDonationWishes
        '
        Me.lblDonationWishes.AutoSize = True
        Me.lblDonationWishes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDonationWishes.Location = New System.Drawing.Point(6, 73)
        Me.lblDonationWishes.Name = "lblDonationWishes"
        Me.lblDonationWishes.Size = New System.Drawing.Size(118, 13)
        Me.lblDonationWishes.TabIndex = 46
        Me.lblDonationWishes.Text = "Brain Donation Wishes:"
        '
        'grpDemographics
        '
        Me.grpDemographics.Controls.Add(Me.Label1)
        Me.grpDemographics.Controls.Add(Me.cmbHearingLoss)
        Me.grpDemographics.Controls.Add(Me.MilitaryService)
        Me.grpDemographics.Controls.Add(Me.Label37)
        Me.grpDemographics.Controls.Add(Me.SexualOrientationATOD)
        Me.grpDemographics.Controls.Add(Me.Label36)
        Me.grpDemographics.Controls.Add(Me.GenderATOD)
        Me.grpDemographics.Controls.Add(Me.Label35)
        Me.grpDemographics.Controls.Add(Me.comboMaritalStatus)
        Me.grpDemographics.Controls.Add(Me.comboMobility)
        Me.grpDemographics.Controls.Add(Me.Label5)
        Me.grpDemographics.Controls.Add(Me.Label12)
        Me.grpDemographics.Controls.Add(Me.Label21)
        Me.grpDemographics.Controls.Add(Me.txtRaceSpec)
        Me.grpDemographics.Controls.Add(Me.Label20)
        Me.grpDemographics.Controls.Add(Me.txtEthSpec)
        Me.grpDemographics.Controls.Add(Me.txtMultiBirth)
        Me.grpDemographics.Controls.Add(Me.Label16)
        Me.grpDemographics.Controls.Add(Me.comboMultiBirth)
        Me.grpDemographics.Controls.Add(Me.Label15)
        Me.grpDemographics.Controls.Add(Me.comboHandedness)
        Me.grpDemographics.Controls.Add(Me.Label14)
        Me.grpDemographics.Controls.Add(Me.comboLevelOfIndependence)
        Me.grpDemographics.Controls.Add(Me.txtLifetimeOccupation)
        Me.grpDemographics.Controls.Add(Me.txtPlaceOfBirth)
        Me.grpDemographics.Controls.Add(Me.txtYearsOfEducation)
        Me.grpDemographics.Controls.Add(Me.txtLanguageNote)
        Me.grpDemographics.Controls.Add(Me.comboSecondaryLanguage)
        Me.grpDemographics.Controls.Add(Me.comboPrimaryLanguage)
        Me.grpDemographics.Controls.Add(Me.comboRace)
        Me.grpDemographics.Controls.Add(Me.comboEthnicity)
        Me.grpDemographics.Controls.Add(Me.comboSex)
        Me.grpDemographics.Controls.Add(Me.Label10)
        Me.grpDemographics.Controls.Add(Me.Label6)
        Me.grpDemographics.Controls.Add(Me.Label4)
        Me.grpDemographics.Controls.Add(Me.lblSex)
        Me.grpDemographics.Controls.Add(Me.lblEthnicity)
        Me.grpDemographics.Controls.Add(Me.lblRace)
        Me.grpDemographics.Controls.Add(Me.lblLanguageNote)
        Me.grpDemographics.Controls.Add(Me.lblYearsOfEducation)
        Me.grpDemographics.Controls.Add(Me.lblPrimaryLanguage)
        Me.grpDemographics.Controls.Add(Me.lblSecondaryLanguage)
        Me.grpDemographics.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDemographics.Location = New System.Drawing.Point(3, 211)
        Me.grpDemographics.Name = "grpDemographics"
        Me.grpDemographics.Size = New System.Drawing.Size(882, 223)
        Me.grpDemographics.TabIndex = 270
        Me.grpDemographics.TabStop = False
        Me.grpDemographics.Text = "Demographics"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(615, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 452
        Me.Label1.Text = "Hearing Loss"
        '
        'cmbHearingLoss
        '
        Me.cmbHearingLoss.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbHearingLoss.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbHearingLoss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHearingLoss.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbHearingLoss.FormattingEnabled = True
        Me.cmbHearingLoss.Location = New System.Drawing.Point(690, 78)
        Me.cmbHearingLoss.Name = "cmbHearingLoss"
        Me.cmbHearingLoss.Size = New System.Drawing.Size(183, 21)
        Me.cmbHearingLoss.TabIndex = 451
        '
        'MilitaryService
        '
        Me.MilitaryService.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.MilitaryService.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MilitaryService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MilitaryService.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MilitaryService.FormattingEnabled = True
        Me.MilitaryService.Location = New System.Drawing.Point(690, 59)
        Me.MilitaryService.Name = "MilitaryService"
        Me.MilitaryService.Size = New System.Drawing.Size(183, 21)
        Me.MilitaryService.TabIndex = 450
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(606, 62)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(78, 13)
        Me.Label37.TabIndex = 449
        Me.Label37.Text = "Military Service"
        '
        'SexualOrientationATOD
        '
        Me.SexualOrientationATOD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SexualOrientationATOD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SexualOrientationATOD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SexualOrientationATOD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SexualOrientationATOD.FormattingEnabled = True
        Me.SexualOrientationATOD.Location = New System.Drawing.Point(690, 39)
        Me.SexualOrientationATOD.Name = "SexualOrientationATOD"
        Me.SexualOrientationATOD.Size = New System.Drawing.Size(183, 21)
        Me.SexualOrientationATOD.TabIndex = 448
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(559, 43)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(126, 13)
        Me.Label36.TabIndex = 447
        Me.Label36.Text = "Sexual Orientation ATOD"
        '
        'GenderATOD
        '
        Me.GenderATOD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.GenderATOD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GenderATOD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderATOD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderATOD.FormattingEnabled = True
        Me.GenderATOD.Location = New System.Drawing.Point(690, 19)
        Me.GenderATOD.Name = "GenderATOD"
        Me.GenderATOD.Size = New System.Drawing.Size(183, 21)
        Me.GenderATOD.TabIndex = 446
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(609, 23)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(75, 13)
        Me.Label35.TabIndex = 445
        Me.Label35.Text = "Gender ATOD"
        '
        'comboMaritalStatus
        '
        Me.comboMaritalStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboMaritalStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboMaritalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboMaritalStatus.Enabled = False
        Me.comboMaritalStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboMaritalStatus.FormattingEnabled = True
        Me.comboMaritalStatus.Location = New System.Drawing.Point(405, 176)
        Me.comboMaritalStatus.Name = "comboMaritalStatus"
        Me.comboMaritalStatus.Size = New System.Drawing.Size(148, 21)
        Me.comboMaritalStatus.TabIndex = 444
        '
        'comboMobility
        '
        Me.comboMobility.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboMobility.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboMobility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboMobility.Enabled = False
        Me.comboMobility.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboMobility.FormattingEnabled = True
        Me.comboMobility.Location = New System.Drawing.Point(405, 156)
        Me.comboMobility.Name = "comboMobility"
        Me.comboMobility.Size = New System.Drawing.Size(148, 21)
        Me.comboMobility.TabIndex = 443
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(328, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 442
        Me.Label5.Text = "Marital Status"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(324, 159)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 441
        Me.Label12.Text = "Mobility Status"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(43, 101)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(71, 13)
        Me.Label21.TabIndex = 248
        Me.Label21.Text = "Race Specify"
        '
        'txtRaceSpec
        '
        Me.txtRaceSpec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRaceSpec.Location = New System.Drawing.Point(129, 98)
        Me.txtRaceSpec.Name = "txtRaceSpec"
        Me.txtRaceSpec.Size = New System.Drawing.Size(163, 20)
        Me.txtRaceSpec.TabIndex = 320
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(30, 62)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(85, 13)
        Me.Label20.TabIndex = 246
        Me.Label20.Text = "Ethnicity Specify"
        '
        'txtEthSpec
        '
        Me.txtEthSpec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEthSpec.Location = New System.Drawing.Point(129, 59)
        Me.txtEthSpec.Name = "txtEthSpec"
        Me.txtEthSpec.Size = New System.Drawing.Size(163, 20)
        Me.txtEthSpec.TabIndex = 300
        '
        'txtMultiBirth
        '
        Me.txtMultiBirth.BackColor = System.Drawing.Color.White
        Me.txtMultiBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMultiBirth.Location = New System.Drawing.Point(405, 117)
        Me.txtMultiBirth.Multiline = True
        Me.txtMultiBirth.Name = "txtMultiBirth"
        Me.txtMultiBirth.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMultiBirth.Size = New System.Drawing.Size(148, 40)
        Me.txtMultiBirth.TabIndex = 410
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(306, 120)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 13)
        Me.Label16.TabIndex = 244
        Me.Label16.Text = "Multiple Birth Note"
        '
        'comboMultiBirth
        '
        Me.comboMultiBirth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboMultiBirth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboMultiBirth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboMultiBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboMultiBirth.FormattingEnabled = True
        Me.comboMultiBirth.Location = New System.Drawing.Point(405, 97)
        Me.comboMultiBirth.Name = "comboMultiBirth"
        Me.comboMultiBirth.Size = New System.Drawing.Size(148, 21)
        Me.comboMultiBirth.TabIndex = 400
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(332, 100)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 13)
        Me.Label15.TabIndex = 242
        Me.Label15.Text = "Multiple Birth"
        '
        'comboHandedness
        '
        Me.comboHandedness.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboHandedness.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboHandedness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboHandedness.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboHandedness.FormattingEnabled = True
        Me.comboHandedness.Location = New System.Drawing.Point(405, 77)
        Me.comboHandedness.Name = "comboHandedness"
        Me.comboHandedness.Size = New System.Drawing.Size(148, 21)
        Me.comboHandedness.TabIndex = 390
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(332, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 240
        Me.Label14.Text = "Handedness"
        '
        'comboLevelOfIndependence
        '
        Me.comboLevelOfIndependence.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboLevelOfIndependence.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboLevelOfIndependence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboLevelOfIndependence.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboLevelOfIndependence.FormattingEnabled = True
        Me.comboLevelOfIndependence.Location = New System.Drawing.Point(129, 196)
        Me.comboLevelOfIndependence.Name = "comboLevelOfIndependence"
        Me.comboLevelOfIndependence.Size = New System.Drawing.Size(424, 21)
        Me.comboLevelOfIndependence.TabIndex = 440
        '
        'txtLifetimeOccupation
        '
        Me.txtLifetimeOccupation.BackColor = System.Drawing.Color.White
        Me.txtLifetimeOccupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLifetimeOccupation.Location = New System.Drawing.Point(405, 58)
        Me.txtLifetimeOccupation.Name = "txtLifetimeOccupation"
        Me.txtLifetimeOccupation.Size = New System.Drawing.Size(148, 20)
        Me.txtLifetimeOccupation.TabIndex = 380
        '
        'txtPlaceOfBirth
        '
        Me.txtPlaceOfBirth.BackColor = System.Drawing.Color.White
        Me.txtPlaceOfBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaceOfBirth.Location = New System.Drawing.Point(405, 39)
        Me.txtPlaceOfBirth.Name = "txtPlaceOfBirth"
        Me.txtPlaceOfBirth.Size = New System.Drawing.Size(148, 20)
        Me.txtPlaceOfBirth.TabIndex = 370
        '
        'txtYearsOfEducation
        '
        Me.txtYearsOfEducation.BackColor = System.Drawing.Color.White
        Me.txtYearsOfEducation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYearsOfEducation.Location = New System.Drawing.Point(405, 20)
        Me.txtYearsOfEducation.Name = "txtYearsOfEducation"
        Me.txtYearsOfEducation.Size = New System.Drawing.Size(148, 20)
        Me.txtYearsOfEducation.TabIndex = 360
        '
        'txtLanguageNote
        '
        Me.txtLanguageNote.BackColor = System.Drawing.Color.White
        Me.txtLanguageNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLanguageNote.Location = New System.Drawing.Point(129, 157)
        Me.txtLanguageNote.Multiline = True
        Me.txtLanguageNote.Name = "txtLanguageNote"
        Me.txtLanguageNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLanguageNote.Size = New System.Drawing.Size(163, 40)
        Me.txtLanguageNote.TabIndex = 350
        '
        'comboSecondaryLanguage
        '
        Me.comboSecondaryLanguage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboSecondaryLanguage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboSecondaryLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboSecondaryLanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboSecondaryLanguage.FormattingEnabled = True
        Me.comboSecondaryLanguage.Location = New System.Drawing.Point(129, 137)
        Me.comboSecondaryLanguage.Name = "comboSecondaryLanguage"
        Me.comboSecondaryLanguage.Size = New System.Drawing.Size(163, 21)
        Me.comboSecondaryLanguage.TabIndex = 340
        '
        'comboPrimaryLanguage
        '
        Me.comboPrimaryLanguage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboPrimaryLanguage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboPrimaryLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboPrimaryLanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboPrimaryLanguage.FormattingEnabled = True
        Me.comboPrimaryLanguage.Location = New System.Drawing.Point(129, 117)
        Me.comboPrimaryLanguage.Name = "comboPrimaryLanguage"
        Me.comboPrimaryLanguage.Size = New System.Drawing.Size(163, 21)
        Me.comboPrimaryLanguage.TabIndex = 330
        '
        'comboRace
        '
        Me.comboRace.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboRace.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboRace.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboRace.FormattingEnabled = True
        Me.comboRace.Location = New System.Drawing.Point(129, 78)
        Me.comboRace.Name = "comboRace"
        Me.comboRace.Size = New System.Drawing.Size(163, 21)
        Me.comboRace.TabIndex = 310
        '
        'comboEthnicity
        '
        Me.comboEthnicity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboEthnicity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboEthnicity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboEthnicity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboEthnicity.FormattingEnabled = True
        Me.comboEthnicity.Location = New System.Drawing.Point(129, 39)
        Me.comboEthnicity.Name = "comboEthnicity"
        Me.comboEthnicity.Size = New System.Drawing.Size(163, 21)
        Me.comboEthnicity.TabIndex = 290
        '
        'comboSex
        '
        Me.comboSex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboSex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboSex.FormattingEnabled = True
        Me.comboSex.Location = New System.Drawing.Point(129, 19)
        Me.comboSex.Name = "comboSex"
        Me.comboSex.Size = New System.Drawing.Size(163, 21)
        Me.comboSex.TabIndex = 280
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 199)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 13)
        Me.Label10.TabIndex = 234
        Me.Label10.Text = "Level of Independence"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(298, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 226
        Me.Label6.Text = "Lifetime Occupation"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(329, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 222
        Me.Label4.Text = "Place of Birth"
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSex.Location = New System.Drawing.Point(37, 22)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(78, 13)
        Me.lblSex.TabIndex = 16
        Me.lblSex.Text = "Sex (biological)"
        '
        'lblEthnicity
        '
        Me.lblEthnicity.AutoSize = True
        Me.lblEthnicity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEthnicity.Location = New System.Drawing.Point(68, 42)
        Me.lblEthnicity.Name = "lblEthnicity"
        Me.lblEthnicity.Size = New System.Drawing.Size(47, 13)
        Me.lblEthnicity.TabIndex = 32
        Me.lblEthnicity.Text = "Ethnicity"
        '
        'lblRace
        '
        Me.lblRace.AutoSize = True
        Me.lblRace.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRace.Location = New System.Drawing.Point(82, 81)
        Me.lblRace.Name = "lblRace"
        Me.lblRace.Size = New System.Drawing.Size(33, 13)
        Me.lblRace.TabIndex = 34
        Me.lblRace.Text = "Race"
        '
        'lblLanguageNote
        '
        Me.lblLanguageNote.AutoSize = True
        Me.lblLanguageNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLanguageNote.Location = New System.Drawing.Point(33, 160)
        Me.lblLanguageNote.Name = "lblLanguageNote"
        Me.lblLanguageNote.Size = New System.Drawing.Size(81, 13)
        Me.lblLanguageNote.TabIndex = 42
        Me.lblLanguageNote.Text = "Language Note"
        '
        'lblYearsOfEducation
        '
        Me.lblYearsOfEducation.AutoSize = True
        Me.lblYearsOfEducation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearsOfEducation.Location = New System.Drawing.Point(302, 23)
        Me.lblYearsOfEducation.Name = "lblYearsOfEducation"
        Me.lblYearsOfEducation.Size = New System.Drawing.Size(97, 13)
        Me.lblYearsOfEducation.TabIndex = 36
        Me.lblYearsOfEducation.Text = "Years of Education"
        '
        'lblPrimaryLanguage
        '
        Me.lblPrimaryLanguage.AutoSize = True
        Me.lblPrimaryLanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrimaryLanguage.Location = New System.Drawing.Point(22, 120)
        Me.lblPrimaryLanguage.Name = "lblPrimaryLanguage"
        Me.lblPrimaryLanguage.Size = New System.Drawing.Size(92, 13)
        Me.lblPrimaryLanguage.TabIndex = 38
        Me.lblPrimaryLanguage.Text = "Primary Language"
        '
        'lblSecondaryLanguage
        '
        Me.lblSecondaryLanguage.AutoSize = True
        Me.lblSecondaryLanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecondaryLanguage.Location = New System.Drawing.Point(5, 140)
        Me.lblSecondaryLanguage.Name = "lblSecondaryLanguage"
        Me.lblSecondaryLanguage.Size = New System.Drawing.Size(109, 13)
        Me.lblSecondaryLanguage.TabIndex = 40
        Me.lblSecondaryLanguage.Text = "Secondary Language"
        '
        'grpNicotine
        '
        Me.grpNicotine.Controls.Add(Me.Label28)
        Me.grpNicotine.Controls.Add(Me.grpNicotineOther)
        Me.grpNicotine.Controls.Add(Me.grpCigarettes)
        Me.grpNicotine.Controls.Add(Me.Label7)
        Me.grpNicotine.Controls.Add(Me.cmbNicotineHx)
        Me.grpNicotine.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpNicotine.Location = New System.Drawing.Point(3, 665)
        Me.grpNicotine.Name = "grpNicotine"
        Me.grpNicotine.Size = New System.Drawing.Size(882, 141)
        Me.grpNicotine.TabIndex = 470
        Me.grpNicotine.TabStop = False
        Me.grpNicotine.Text = "Nicotine Use History"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(362, 31)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(186, 13)
        Me.Label28.TabIndex = 241
        Me.Label28.Text = "If dates are approx, use 06/15/XXXX."
        '
        'grpNicotineOther
        '
        Me.grpNicotineOther.Controls.Add(Me.cmbNicOthType)
        Me.grpNicotineOther.Controls.Add(Me.Label27)
        Me.grpNicotineOther.Controls.Add(Me.txtNicOthFreq)
        Me.grpNicotineOther.Controls.Add(Me.Label22)
        Me.grpNicotineOther.Controls.Add(Me.txtNicOthYrsUse)
        Me.grpNicotineOther.Controls.Add(Me.Label24)
        Me.grpNicotineOther.Controls.Add(Me.txtNicOthAgeStarted)
        Me.grpNicotineOther.Controls.Add(Me.Label25)
        Me.grpNicotineOther.Controls.Add(Me.Label26)
        Me.grpNicotineOther.Controls.Add(Me.dtNicOthDateQuit)
        Me.grpNicotineOther.Location = New System.Drawing.Point(5, 88)
        Me.grpNicotineOther.Name = "grpNicotineOther"
        Me.grpNicotineOther.Size = New System.Drawing.Size(871, 44)
        Me.grpNicotineOther.TabIndex = 540
        Me.grpNicotineOther.TabStop = False
        Me.grpNicotineOther.Text = "Other (Vapor Device, Cigar, Pipe, Chewing Tobacco, etc)"
        '
        'cmbNicOthType
        '
        Me.cmbNicOthType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbNicOthType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbNicOthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNicOthType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNicOthType.FormattingEnabled = True
        Me.cmbNicOthType.Location = New System.Drawing.Point(43, 16)
        Me.cmbNicOthType.Name = "cmbNicOthType"
        Me.cmbNicOthType.Size = New System.Drawing.Size(121, 21)
        Me.cmbNicOthType.TabIndex = 550
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(6, 19)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(31, 13)
        Me.Label27.TabIndex = 238
        Me.Label27.Text = "Type"
        '
        'txtNicOthFreq
        '
        Me.txtNicOthFreq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNicOthFreq.Location = New System.Drawing.Point(676, 16)
        Me.txtNicOthFreq.Name = "txtNicOthFreq"
        Me.txtNicOthFreq.Size = New System.Drawing.Size(67, 20)
        Me.txtNicOthFreq.TabIndex = 590
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(618, 19)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(52, 13)
        Me.Label22.TabIndex = 236
        Me.Label22.Text = "Freq/Day"
        '
        'txtNicOthYrsUse
        '
        Me.txtNicOthYrsUse.BackColor = System.Drawing.Color.LightGray
        Me.txtNicOthYrsUse.Enabled = False
        Me.txtNicOthYrsUse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNicOthYrsUse.Location = New System.Drawing.Point(545, 16)
        Me.txtNicOthYrsUse.Name = "txtNicOthYrsUse"
        Me.txtNicOthYrsUse.Size = New System.Drawing.Size(67, 20)
        Me.txtNicOthYrsUse.TabIndex = 580
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(477, 19)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(62, 13)
        Me.Label24.TabIndex = 234
        Me.Label24.Text = "Years Used"
        '
        'txtNicOthAgeStarted
        '
        Me.txtNicOthAgeStarted.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNicOthAgeStarted.Location = New System.Drawing.Point(239, 16)
        Me.txtNicOthAgeStarted.Name = "txtNicOthAgeStarted"
        Me.txtNicOthAgeStarted.Size = New System.Drawing.Size(67, 20)
        Me.txtNicOthAgeStarted.TabIndex = 560
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(170, 19)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(63, 13)
        Me.Label25.TabIndex = 230
        Me.Label25.Text = "Age Started"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(312, 19)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(88, 13)
        Me.Label26.TabIndex = 232
        Me.Label26.Text = "Approx Date Quit"
        '
        'dtNicOthDateQuit
        '
        Me.dtNicOthDateQuit.BackColor = System.Drawing.Color.White
        Me.dtNicOthDateQuit.Enabled = False
        Me.dtNicOthDateQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtNicOthDateQuit.Location = New System.Drawing.Point(404, 16)
        Me.dtNicOthDateQuit.Mask = "00/00/0000"
        Me.dtNicOthDateQuit.Name = "dtNicOthDateQuit"
        Me.dtNicOthDateQuit.Size = New System.Drawing.Size(67, 20)
        Me.dtNicOthDateQuit.TabIndex = 570
        Me.dtNicOthDateQuit.ValidatingType = GetType(Date)
        '
        'grpCigarettes
        '
        Me.grpCigarettes.Controls.Add(Me.txtCigFreq)
        Me.grpCigarettes.Controls.Add(Me.Label23)
        Me.grpCigarettes.Controls.Add(Me.txtCigYrsUse)
        Me.grpCigarettes.Controls.Add(Me.Label11)
        Me.grpCigarettes.Controls.Add(Me.txtCigAgeStarted)
        Me.grpCigarettes.Controls.Add(Me.Label8)
        Me.grpCigarettes.Controls.Add(Me.Label9)
        Me.grpCigarettes.Controls.Add(Me.dtCigDateQuit)
        Me.grpCigarettes.Location = New System.Drawing.Point(5, 40)
        Me.grpCigarettes.Name = "grpCigarettes"
        Me.grpCigarettes.Size = New System.Drawing.Size(871, 42)
        Me.grpCigarettes.TabIndex = 490
        Me.grpCigarettes.TabStop = False
        Me.grpCigarettes.Text = "Cigarettes"
        '
        'txtCigFreq
        '
        Me.txtCigFreq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCigFreq.Location = New System.Drawing.Point(574, 13)
        Me.txtCigFreq.Name = "txtCigFreq"
        Me.txtCigFreq.Size = New System.Drawing.Size(67, 20)
        Me.txtCigFreq.TabIndex = 530
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(512, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(56, 13)
        Me.Label23.TabIndex = 236
        Me.Label23.Text = "# Cig/Day"
        '
        'txtCigYrsUse
        '
        Me.txtCigYrsUse.BackColor = System.Drawing.Color.LightGray
        Me.txtCigYrsUse.Enabled = False
        Me.txtCigYrsUse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCigYrsUse.Location = New System.Drawing.Point(439, 13)
        Me.txtCigYrsUse.Name = "txtCigYrsUse"
        Me.txtCigYrsUse.Size = New System.Drawing.Size(67, 20)
        Me.txtCigYrsUse.TabIndex = 520
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(357, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 234
        Me.Label11.Text = "Years Smoked"
        '
        'txtCigAgeStarted
        '
        Me.txtCigAgeStarted.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCigAgeStarted.Location = New System.Drawing.Point(119, 13)
        Me.txtCigAgeStarted.Name = "txtCigAgeStarted"
        Me.txtCigAgeStarted.Size = New System.Drawing.Size(67, 20)
        Me.txtCigAgeStarted.TabIndex = 500
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 13)
        Me.Label8.TabIndex = 230
        Me.Label8.Text = "Age Started Smoking"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(192, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 232
        Me.Label9.Text = "Approx Date Quit"
        '
        'dtCigDateQuit
        '
        Me.dtCigDateQuit.BackColor = System.Drawing.Color.White
        Me.dtCigDateQuit.Enabled = False
        Me.dtCigDateQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtCigDateQuit.Location = New System.Drawing.Point(284, 13)
        Me.dtCigDateQuit.Mask = "00/00/0000"
        Me.dtCigDateQuit.Name = "dtCigDateQuit"
        Me.dtCigDateQuit.Size = New System.Drawing.Size(67, 20)
        Me.dtCigDateQuit.TabIndex = 510
        Me.dtCigDateQuit.ValidatingType = GetType(Date)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 228
        Me.Label7.Text = "Use History"
        '
        'cmbNicotineHx
        '
        Me.cmbNicotineHx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbNicotineHx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbNicotineHx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNicotineHx.Enabled = False
        Me.cmbNicotineHx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNicotineHx.FormattingEnabled = True
        Me.cmbNicotineHx.Location = New System.Drawing.Point(73, 15)
        Me.cmbNicotineHx.Name = "cmbNicotineHx"
        Me.cmbNicotineHx.Size = New System.Drawing.Size(160, 21)
        Me.cmbNicotineHx.TabIndex = 480
        '
        'grpAddress
        '
        Me.grpAddress.BackColor = System.Drawing.Color.Transparent
        Me.grpAddress.Controls.Add(Me.Label32)
        Me.grpAddress.Controls.Add(Me.txtZip)
        Me.grpAddress.Controls.Add(Me.txtState)
        Me.grpAddress.Controls.Add(Me.Label31)
        Me.grpAddress.Controls.Add(Me.txtEmail)
        Me.grpAddress.Controls.Add(Me.txtWorkPhone)
        Me.grpAddress.Controls.Add(Me.txtMobilePhone)
        Me.grpAddress.Controls.Add(Me.txtHomePhone)
        Me.grpAddress.Controls.Add(Me.txtCity)
        Me.grpAddress.Controls.Add(Me.txtAddress2)
        Me.grpAddress.Controls.Add(Me.txtAddress1)
        Me.grpAddress.Controls.Add(Me.lblAddress1)
        Me.grpAddress.Controls.Add(Me.lblAddress2)
        Me.grpAddress.Controls.Add(Me.lblCityStateZip)
        Me.grpAddress.Controls.Add(Me.lblHomePhone)
        Me.grpAddress.Controls.Add(Me.lblMobilePhone)
        Me.grpAddress.Controls.Add(Me.lblWorkPhone)
        Me.grpAddress.Controls.Add(Me.lblEmail)
        Me.grpAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAddress.Location = New System.Drawing.Point(220, 32)
        Me.grpAddress.Name = "grpAddress"
        Me.grpAddress.Size = New System.Drawing.Size(366, 173)
        Me.grpAddress.TabIndex = 190
        Me.grpAddress.TabStop = False
        Me.grpAddress.Text = "Address and Phone"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(233, 73)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(24, 13)
        Me.Label32.TabIndex = 120
        Me.Label32.Text = "ZIP"
        '
        'txtZip
        '
        Me.txtZip.BackColor = System.Drawing.Color.White
        Me.txtZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZip.Location = New System.Drawing.Point(263, 70)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(97, 20)
        Me.txtZip.TabIndex = 150
        '
        'txtState
        '
        Me.txtState.BackColor = System.Drawing.Color.White
        Me.txtState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtState.Location = New System.Drawing.Point(90, 70)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(141, 20)
        Me.txtState.TabIndex = 140
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(52, 72)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(32, 13)
        Me.Label31.TabIndex = 117
        Me.Label31.Text = "State"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(90, 146)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(270, 20)
        Me.txtEmail.TabIndex = 190
        '
        'txtWorkPhone
        '
        Me.txtWorkPhone.BackColor = System.Drawing.Color.White
        Me.txtWorkPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWorkPhone.Location = New System.Drawing.Point(90, 127)
        Me.txtWorkPhone.Name = "txtWorkPhone"
        Me.txtWorkPhone.Size = New System.Drawing.Size(270, 20)
        Me.txtWorkPhone.TabIndex = 180
        '
        'txtMobilePhone
        '
        Me.txtMobilePhone.BackColor = System.Drawing.Color.White
        Me.txtMobilePhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobilePhone.Location = New System.Drawing.Point(90, 108)
        Me.txtMobilePhone.Name = "txtMobilePhone"
        Me.txtMobilePhone.Size = New System.Drawing.Size(270, 20)
        Me.txtMobilePhone.TabIndex = 170
        '
        'txtHomePhone
        '
        Me.txtHomePhone.BackColor = System.Drawing.Color.White
        Me.txtHomePhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHomePhone.Location = New System.Drawing.Point(90, 89)
        Me.txtHomePhone.Name = "txtHomePhone"
        Me.txtHomePhone.Size = New System.Drawing.Size(270, 20)
        Me.txtHomePhone.TabIndex = 160
        '
        'txtCity
        '
        Me.txtCity.BackColor = System.Drawing.Color.White
        Me.txtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(90, 51)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(270, 20)
        Me.txtCity.TabIndex = 130
        '
        'txtAddress2
        '
        Me.txtAddress2.BackColor = System.Drawing.Color.White
        Me.txtAddress2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress2.Location = New System.Drawing.Point(90, 32)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(270, 20)
        Me.txtAddress2.TabIndex = 120
        '
        'txtAddress1
        '
        Me.txtAddress1.BackColor = System.Drawing.Color.White
        Me.txtAddress1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress1.Location = New System.Drawing.Point(90, 13)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(270, 20)
        Me.txtAddress1.TabIndex = 110
        '
        'lblAddress1
        '
        Me.lblAddress1.AutoSize = True
        Me.lblAddress1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress1.Location = New System.Drawing.Point(30, 16)
        Me.lblAddress1.Name = "lblAddress1"
        Me.lblAddress1.Size = New System.Drawing.Size(54, 13)
        Me.lblAddress1.TabIndex = 18
        Me.lblAddress1.Text = "Address 1"
        '
        'lblAddress2
        '
        Me.lblAddress2.AutoSize = True
        Me.lblAddress2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress2.Location = New System.Drawing.Point(30, 34)
        Me.lblAddress2.Name = "lblAddress2"
        Me.lblAddress2.Size = New System.Drawing.Size(54, 13)
        Me.lblAddress2.TabIndex = 20
        Me.lblAddress2.Text = "Address 2"
        '
        'lblCityStateZip
        '
        Me.lblCityStateZip.AutoSize = True
        Me.lblCityStateZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCityStateZip.Location = New System.Drawing.Point(60, 53)
        Me.lblCityStateZip.Name = "lblCityStateZip"
        Me.lblCityStateZip.Size = New System.Drawing.Size(24, 13)
        Me.lblCityStateZip.TabIndex = 22
        Me.lblCityStateZip.Text = "City"
        '
        'lblHomePhone
        '
        Me.lblHomePhone.AutoSize = True
        Me.lblHomePhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomePhone.Location = New System.Drawing.Point(15, 91)
        Me.lblHomePhone.Name = "lblHomePhone"
        Me.lblHomePhone.Size = New System.Drawing.Size(69, 13)
        Me.lblHomePhone.TabIndex = 24
        Me.lblHomePhone.Text = "Home Phone"
        '
        'lblMobilePhone
        '
        Me.lblMobilePhone.AutoSize = True
        Me.lblMobilePhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobilePhone.Location = New System.Drawing.Point(12, 110)
        Me.lblMobilePhone.Name = "lblMobilePhone"
        Me.lblMobilePhone.Size = New System.Drawing.Size(72, 13)
        Me.lblMobilePhone.TabIndex = 26
        Me.lblMobilePhone.Text = "Mobile Phone"
        '
        'lblWorkPhone
        '
        Me.lblWorkPhone.AutoSize = True
        Me.lblWorkPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorkPhone.Location = New System.Drawing.Point(17, 129)
        Me.lblWorkPhone.Name = "lblWorkPhone"
        Me.lblWorkPhone.Size = New System.Drawing.Size(67, 13)
        Me.lblWorkPhone.TabIndex = 28
        Me.lblWorkPhone.Text = "Work Phone"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(52, 148)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 30
        Me.lblEmail.Text = "Email"
        '
        'grpSubjectInfo
        '
        Me.grpSubjectInfo.Controls.Add(Me.cmbSalutation)
        Me.grpSubjectInfo.Controls.Add(Me.Label33)
        Me.grpSubjectInfo.Controls.Add(Me.txtAge)
        Me.grpSubjectInfo.Controls.Add(Me.txtSSN)
        Me.grpSubjectInfo.Controls.Add(Me.txtSuffix)
        Me.grpSubjectInfo.Controls.Add(Me.txtLastName)
        Me.grpSubjectInfo.Controls.Add(Me.txtMI)
        Me.grpSubjectInfo.Controls.Add(Me.txtFirstName)
        Me.grpSubjectInfo.Controls.Add(Me.txtDoB)
        Me.grpSubjectInfo.Controls.Add(Me.lblSalutation)
        Me.grpSubjectInfo.Controls.Add(Me.lblFirstName)
        Me.grpSubjectInfo.Controls.Add(Me.lblMI)
        Me.grpSubjectInfo.Controls.Add(Me.lblLastName)
        Me.grpSubjectInfo.Controls.Add(Me.lblSuffix)
        Me.grpSubjectInfo.Controls.Add(Me.lblSSN)
        Me.grpSubjectInfo.Controls.Add(Me.lblDOB)
        Me.grpSubjectInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSubjectInfo.Location = New System.Drawing.Point(3, 32)
        Me.grpSubjectInfo.Name = "grpSubjectInfo"
        Me.grpSubjectInfo.Size = New System.Drawing.Size(211, 173)
        Me.grpSubjectInfo.TabIndex = 110
        Me.grpSubjectInfo.TabStop = False
        Me.grpSubjectInfo.Text = "Subject Info"
        '
        'cmbSalutation
        '
        Me.cmbSalutation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSalutation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSalutation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSalutation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSalutation.FormattingEnabled = True
        Me.cmbSalutation.Location = New System.Drawing.Point(66, 12)
        Me.cmbSalutation.Name = "cmbSalutation"
        Me.cmbSalutation.Size = New System.Drawing.Size(134, 21)
        Me.cmbSalutation.TabIndex = 262
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(30, 149)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(26, 13)
        Me.Label33.TabIndex = 182
        Me.Label33.Text = "Age"
        '
        'txtAge
        '
        Me.txtAge.Enabled = False
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(66, 146)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(134, 20)
        Me.txtAge.TabIndex = 181
        '
        'txtSSN
        '
        Me.txtSSN.BackColor = System.Drawing.Color.White
        Me.txtSSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSSN.Location = New System.Drawing.Point(66, 108)
        Me.txtSSN.Name = "txtSSN"
        Me.txtSSN.Size = New System.Drawing.Size(134, 20)
        Me.txtSSN.TabIndex = 170
        '
        'txtSuffix
        '
        Me.txtSuffix.BackColor = System.Drawing.Color.White
        Me.txtSuffix.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuffix.Location = New System.Drawing.Point(66, 89)
        Me.txtSuffix.Name = "txtSuffix"
        Me.txtSuffix.Size = New System.Drawing.Size(134, 20)
        Me.txtSuffix.TabIndex = 160
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.White
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(66, 70)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(134, 20)
        Me.txtLastName.TabIndex = 150
        '
        'txtMI
        '
        Me.txtMI.BackColor = System.Drawing.Color.White
        Me.txtMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMI.Location = New System.Drawing.Point(66, 51)
        Me.txtMI.Name = "txtMI"
        Me.txtMI.Size = New System.Drawing.Size(134, 20)
        Me.txtMI.TabIndex = 140
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.White
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(66, 32)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(134, 20)
        Me.txtFirstName.TabIndex = 130
        '
        'txtDoB
        '
        Me.txtDoB.BackColor = System.Drawing.Color.White
        Me.txtDoB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoB.Location = New System.Drawing.Point(66, 127)
        Me.txtDoB.Mask = "00/00/0000"
        Me.txtDoB.Name = "txtDoB"
        Me.txtDoB.Size = New System.Drawing.Size(134, 20)
        Me.txtDoB.TabIndex = 180
        Me.txtDoB.ValidatingType = GetType(Date)
        '
        'lblSalutation
        '
        Me.lblSalutation.AutoSize = True
        Me.lblSalutation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalutation.Location = New System.Drawing.Point(6, 16)
        Me.lblSalutation.Name = "lblSalutation"
        Me.lblSalutation.Size = New System.Drawing.Size(54, 13)
        Me.lblSalutation.TabIndex = 0
        Me.lblSalutation.Text = "Salutation"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(3, 35)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "First Name"
        '
        'lblMI
        '
        Me.lblMI.AutoSize = True
        Me.lblMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMI.Location = New System.Drawing.Point(35, 54)
        Me.lblMI.Name = "lblMI"
        Me.lblMI.Size = New System.Drawing.Size(25, 13)
        Me.lblMI.TabIndex = 4
        Me.lblMI.Text = "M.I."
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(2, 73)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 6
        Me.lblLastName.Text = "Last Name"
        '
        'lblSuffix
        '
        Me.lblSuffix.AutoSize = True
        Me.lblSuffix.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuffix.Location = New System.Drawing.Point(27, 92)
        Me.lblSuffix.Name = "lblSuffix"
        Me.lblSuffix.Size = New System.Drawing.Size(33, 13)
        Me.lblSuffix.TabIndex = 8
        Me.lblSuffix.Text = "Suffix"
        '
        'lblSSN
        '
        Me.lblSSN.AutoSize = True
        Me.lblSSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSSN.Location = New System.Drawing.Point(31, 111)
        Me.lblSSN.Name = "lblSSN"
        Me.lblSSN.Size = New System.Drawing.Size(29, 13)
        Me.lblSSN.TabIndex = 10
        Me.lblSSN.Text = "SSN"
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOB.Location = New System.Drawing.Point(30, 130)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(30, 13)
        Me.lblDOB.TabIndex = 12
        Me.lblDOB.Text = "DOB"
        '
        'grpPsychNeuroDx
        '
        Me.grpPsychNeuroDx.Controls.Add(Me.lblEmptyPsychNeuroDx)
        Me.grpPsychNeuroDx.Controls.Add(Me.btnPsychNeuroRelAdd)
        Me.grpPsychNeuroDx.Controls.Add(Me.dgvRelWithSimilarDx)
        Me.grpPsychNeuroDx.Controls.Add(Me.txtPrimNeuroText)
        Me.grpPsychNeuroDx.Controls.Add(Me.Label30)
        Me.grpPsychNeuroDx.Controls.Add(Me.txtPrimNeuroICD)
        Me.grpPsychNeuroDx.Controls.Add(Me.Label29)
        Me.grpPsychNeuroDx.Controls.Add(Me.txtPrimPsychText)
        Me.grpPsychNeuroDx.Controls.Add(Me.Label18)
        Me.grpPsychNeuroDx.Controls.Add(Me.Label17)
        Me.grpPsychNeuroDx.Controls.Add(Me.txtPrimPsychICD)
        Me.grpPsychNeuroDx.Controls.Add(Me.Label19)
        Me.grpPsychNeuroDx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPsychNeuroDx.Location = New System.Drawing.Point(3, 440)
        Me.grpPsychNeuroDx.Name = "grpPsychNeuroDx"
        Me.grpPsychNeuroDx.Size = New System.Drawing.Size(882, 219)
        Me.grpPsychNeuroDx.TabIndex = 450
        Me.grpPsychNeuroDx.TabStop = False
        Me.grpPsychNeuroDx.Text = "Psychiatric or Neurological Dx"
        '
        'lblEmptyPsychNeuroDx
        '
        Me.lblEmptyPsychNeuroDx.AutoSize = True
        Me.lblEmptyPsychNeuroDx.Location = New System.Drawing.Point(159, 132)
        Me.lblEmptyPsychNeuroDx.Name = "lblEmptyPsychNeuroDx"
        Me.lblEmptyPsychNeuroDx.Size = New System.Drawing.Size(589, 13)
        Me.lblEmptyPsychNeuroDx.TabIndex = 161
        Me.lblEmptyPsychNeuroDx.Text = "No Primary Psych or Neuro Diagnoses have been designated yet on the Consensus Dx " &
    "for this subject."
        '
        'btnPsychNeuroRelAdd
        '
        Me.btnPsychNeuroRelAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPsychNeuroRelAdd.Location = New System.Drawing.Point(9, 190)
        Me.btnPsychNeuroRelAdd.Name = "btnPsychNeuroRelAdd"
        Me.btnPsychNeuroRelAdd.Size = New System.Drawing.Size(105, 23)
        Me.btnPsychNeuroRelAdd.TabIndex = 460
        Me.btnPsychNeuroRelAdd.Text = "Make Changes"
        Me.btnPsychNeuroRelAdd.UseVisualStyleBackColor = True
        '
        'dgvRelWithSimilarDx
        '
        Me.dgvRelWithSimilarDx.AllowUserToAddRows = False
        Me.dgvRelWithSimilarDx.AllowUserToDeleteRows = False
        Me.dgvRelWithSimilarDx.AllowUserToOrderColumns = True
        Me.dgvRelWithSimilarDx.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige
        Me.dgvRelWithSimilarDx.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRelWithSimilarDx.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dgvRelWithSimilarDx.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvRelWithSimilarDx.BackgroundColor = System.Drawing.Color.Tan
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRelWithSimilarDx.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRelWithSimilarDx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRelWithSimilarDx.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRelWithSimilarDx.GridColor = System.Drawing.Color.Linen
        Me.dgvRelWithSimilarDx.Location = New System.Drawing.Point(9, 88)
        Me.dgvRelWithSimilarDx.MultiSelect = False
        Me.dgvRelWithSimilarDx.Name = "dgvRelWithSimilarDx"
        Me.dgvRelWithSimilarDx.ReadOnly = True
        Me.dgvRelWithSimilarDx.RowHeadersVisible = False
        Me.dgvRelWithSimilarDx.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.dgvRelWithSimilarDx.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRelWithSimilarDx.Size = New System.Drawing.Size(867, 99)
        Me.dgvRelWithSimilarDx.TabIndex = 159
        Me.dgvRelWithSimilarDx.TabStop = False
        '
        'txtPrimNeuroText
        '
        Me.txtPrimNeuroText.BackColor = System.Drawing.Color.LightGray
        Me.txtPrimNeuroText.Enabled = False
        Me.txtPrimNeuroText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimNeuroText.Location = New System.Drawing.Point(207, 49)
        Me.txtPrimNeuroText.Name = "txtPrimNeuroText"
        Me.txtPrimNeuroText.Size = New System.Drawing.Size(669, 20)
        Me.txtPrimNeuroText.TabIndex = 158
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(6, 52)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(89, 13)
        Me.Label30.TabIndex = 157
        Me.Label30.Text = "Primary Neuro Dx"
        '
        'txtPrimNeuroICD
        '
        Me.txtPrimNeuroICD.BackColor = System.Drawing.Color.LightGray
        Me.txtPrimNeuroICD.Enabled = False
        Me.txtPrimNeuroICD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimNeuroICD.Location = New System.Drawing.Point(101, 49)
        Me.txtPrimNeuroICD.Name = "txtPrimNeuroICD"
        Me.txtPrimNeuroICD.Size = New System.Drawing.Size(100, 20)
        Me.txtPrimNeuroICD.TabIndex = 156
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(205, 14)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(44, 13)
        Me.Label29.TabIndex = 155
        Me.Label29.Text = "Dx Text"
        '
        'txtPrimPsychText
        '
        Me.txtPrimPsychText.BackColor = System.Drawing.Color.LightGray
        Me.txtPrimPsychText.Enabled = False
        Me.txtPrimPsychText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimPsychText.Location = New System.Drawing.Point(207, 30)
        Me.txtPrimPsychText.Name = "txtPrimPsychText"
        Me.txtPrimPsychText.Size = New System.Drawing.Size(669, 20)
        Me.txtPrimPsychText.TabIndex = 154
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(98, 14)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 13)
        Me.Label18.TabIndex = 153
        Me.Label18.Text = "ICD Code"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 33)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 13)
        Me.Label17.TabIndex = 152
        Me.Label17.Text = "Primary Psych Dx"
        '
        'txtPrimPsychICD
        '
        Me.txtPrimPsychICD.BackColor = System.Drawing.Color.LightGray
        Me.txtPrimPsychICD.Enabled = False
        Me.txtPrimPsychICD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimPsychICD.Location = New System.Drawing.Point(101, 30)
        Me.txtPrimPsychICD.Name = "txtPrimPsychICD"
        Me.txtPrimPsychICD.Size = New System.Drawing.Size(100, 20)
        Me.txtPrimPsychICD.TabIndex = 151
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(365, 72)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(155, 13)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Relatives with similar diagnoses"
        '
        'chkDNDiss
        '
        Me.chkDNDiss.AutoSize = True
        Me.chkDNDiss.BackColor = System.Drawing.Color.Tan
        Me.chkDNDiss.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDNDiss.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDNDiss.Location = New System.Drawing.Point(301, 6)
        Me.chkDNDiss.Name = "chkDNDiss"
        Me.chkDNDiss.Size = New System.Drawing.Size(95, 17)
        Me.chkDNDiss.TabIndex = 813
        Me.chkDNDiss.Text = "Do Not Dissect"
        Me.chkDNDiss.UseVisualStyleBackColor = False
        '
        'chkDNDist
        '
        Me.chkDNDist.AutoSize = True
        Me.chkDNDist.BackColor = System.Drawing.Color.Tan
        Me.chkDNDist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDNDist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDNDist.Location = New System.Drawing.Point(402, 6)
        Me.chkDNDist.Name = "chkDNDist"
        Me.chkDNDist.Size = New System.Drawing.Size(104, 17)
        Me.chkDNDist.TabIndex = 812
        Me.chkDNDist.Text = "Do Not Distribute"
        Me.chkDNDist.UseVisualStyleBackColor = False
        '
        'chkDNC
        '
        Me.chkDNC.AutoSize = True
        Me.chkDNC.BackColor = System.Drawing.Color.Tan
        Me.chkDNC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDNC.Location = New System.Drawing.Point(198, 6)
        Me.chkDNC.Name = "chkDNC"
        Me.chkDNC.Size = New System.Drawing.Size(97, 17)
        Me.chkDNC.TabIndex = 811
        Me.chkDNC.Text = "Do Not Contact"
        Me.chkDNC.UseVisualStyleBackColor = False
        '
        'btnSubjectTop
        '
        Me.btnSubjectTop.Location = New System.Drawing.Point(3, 3)
        Me.btnSubjectTop.Name = "btnSubjectTop"
        Me.btnSubjectTop.Size = New System.Drawing.Size(189, 23)
        Me.btnSubjectTop.TabIndex = 100
        Me.btnSubjectTop.UseVisualStyleBackColor = True
        '
        'btnSubjectBottom
        '
        Me.btnSubjectBottom.Location = New System.Drawing.Point(3, 937)
        Me.btnSubjectBottom.Name = "btnSubjectBottom"
        Me.btnSubjectBottom.Size = New System.Drawing.Size(189, 23)
        Me.btnSubjectBottom.TabIndex = 670
        Me.btnSubjectBottom.UseVisualStyleBackColor = True
        '
        'WA_Demographics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.Controls.Add(Me.chkDNDiss)
        Me.Controls.Add(Me.chkDNDist)
        Me.Controls.Add(Me.chkDNC)
        Me.Controls.Add(Me.grpPsychNeuroDx)
        Me.Controls.Add(Me.btnSubjectTop)
        Me.Controls.Add(Me.btnSubjectBottom)
        Me.Controls.Add(Me.grpSubjectIDs)
        Me.Controls.Add(Me.grpCohort)
        Me.Controls.Add(Me.grpMisc)
        Me.Controls.Add(Me.grpDemographics)
        Me.Controls.Add(Me.grpAddress)
        Me.Controls.Add(Me.grpSubjectInfo)
        Me.Controls.Add(Me.grpNicotine)
        Me.Name = "WA_Demographics"
        Me.Size = New System.Drawing.Size(900, 973)
        Me.grpSubjectIDs.ResumeLayout(False)
        Me.grpSubjectIDs.PerformLayout()
        Me.grpCohort.ResumeLayout(False)
        Me.grpCohort.PerformLayout()
        Me.grpMisc.ResumeLayout(False)
        Me.grpMisc.PerformLayout()
        Me.grpDemographics.ResumeLayout(False)
        Me.grpDemographics.PerformLayout()
        Me.grpNicotine.ResumeLayout(False)
        Me.grpNicotine.PerformLayout()
        Me.grpNicotineOther.ResumeLayout(False)
        Me.grpNicotineOther.PerformLayout()
        Me.grpCigarettes.ResumeLayout(False)
        Me.grpCigarettes.PerformLayout()
        Me.grpAddress.ResumeLayout(False)
        Me.grpAddress.PerformLayout()
        Me.grpSubjectInfo.ResumeLayout(False)
        Me.grpSubjectInfo.PerformLayout()
        Me.grpPsychNeuroDx.ResumeLayout(False)
        Me.grpPsychNeuroDx.PerformLayout()
        CType(Me.dgvRelWithSimilarDx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSubjectTop As DataWarehouse.Button_
    Friend WithEvents btnSubjectBottom As DataWarehouse.Button_
    Friend WithEvents grpSubjectIDs As System.Windows.Forms.GroupBox
    Friend WithEvents txtXENum As DataWarehouse.TextBox_
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtNACCID As DataWarehouse.TextBox_
    Friend WithEvents txtBB As DataWarehouse.TextBox_
    Friend WithEvents txtSubNum As DataWarehouse.TextBox_
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblSubNum As System.Windows.Forms.Label
    Friend WithEvents grpCohort As System.Windows.Forms.GroupBox
    Friend WithEvents chkIsrael As DataWarehouse.CheckBox_
    Friend WithEvents chkSchizo As DataWarehouse.CheckBox_
    Friend WithEvents chkNACC As DataWarehouse.CheckBox_
    Friend WithEvents chkPPG As DataWarehouse.CheckBox_
    Friend WithEvents chkADRC As DataWarehouse.CheckBox_
    Friend WithEvents grpMisc As System.Windows.Forms.GroupBox
    Friend WithEvents btnDonationFile As DataWarehouse.Button_
    Friend WithEvents comboDonationWishes As DataWarehouse.ComboBox_
    Friend WithEvents txtNotes As DataWarehouse.TextBox_
    Friend WithEvents lblSpecialInstructions As System.Windows.Forms.Label
    Friend WithEvents lblDonationWishes As System.Windows.Forms.Label
    Friend WithEvents grpDemographics As System.Windows.Forms.GroupBox
    Friend WithEvents comboLevelOfIndependence As DataWarehouse.ComboBox_
    Friend WithEvents cmbNicotineHx As DataWarehouse.ComboBox_
    Friend WithEvents txtLifetimeOccupation As DataWarehouse.TextBox_
    Friend WithEvents txtPlaceOfBirth As DataWarehouse.TextBox_
    Friend WithEvents txtYearsOfEducation As DataWarehouse.TextBox_
    Friend WithEvents txtLanguageNote As DataWarehouse.TextBox_
    Friend WithEvents comboSecondaryLanguage As DataWarehouse.ComboBox_
    Friend WithEvents comboPrimaryLanguage As DataWarehouse.ComboBox_
    Friend WithEvents comboRace As DataWarehouse.ComboBox_
    Friend WithEvents comboEthnicity As DataWarehouse.ComboBox_
    Friend WithEvents comboSex As DataWarehouse.ComboBox_
    Friend WithEvents dtCigDateQuit As DataWarehouse.TextBoxDatePast
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSex As System.Windows.Forms.Label
    Friend WithEvents lblEthnicity As System.Windows.Forms.Label
    Friend WithEvents lblRace As System.Windows.Forms.Label
    Friend WithEvents lblLanguageNote As System.Windows.Forms.Label
    Friend WithEvents lblYearsOfEducation As System.Windows.Forms.Label
    Friend WithEvents lblPrimaryLanguage As System.Windows.Forms.Label
    Friend WithEvents lblSecondaryLanguage As System.Windows.Forms.Label
    Friend WithEvents grpAddress As System.Windows.Forms.GroupBox
    Friend WithEvents txtEmail As DataWarehouse.TextBox_
    Friend WithEvents txtWorkPhone As DataWarehouse.TextBox_
    Friend WithEvents txtMobilePhone As DataWarehouse.TextBox_
    Friend WithEvents txtHomePhone As DataWarehouse.TextBox_
    Friend WithEvents txtCity As DataWarehouse.TextBox_
    Friend WithEvents txtAddress2 As DataWarehouse.TextBox_
    Friend WithEvents txtAddress1 As DataWarehouse.TextBox_
    Friend WithEvents lblAddress1 As System.Windows.Forms.Label
    Friend WithEvents lblAddress2 As System.Windows.Forms.Label
    Friend WithEvents lblCityStateZip As System.Windows.Forms.Label
    Friend WithEvents lblHomePhone As System.Windows.Forms.Label
    Friend WithEvents lblMobilePhone As System.Windows.Forms.Label
    Friend WithEvents lblWorkPhone As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents grpSubjectInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtSSN As DataWarehouse.TextBox_
    Friend WithEvents txtSuffix As DataWarehouse.TextBox_
    Friend WithEvents txtLastName As DataWarehouse.TextBox_
    Friend WithEvents txtMI As DataWarehouse.TextBox_
    Friend WithEvents txtFirstName As DataWarehouse.TextBox_
    Friend WithEvents txtDoB As DataWarehouse.TextBoxDatePast
    Friend WithEvents lblSalutation As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblMI As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblSuffix As System.Windows.Forms.Label
    Friend WithEvents lblSSN As System.Windows.Forms.Label
    Friend WithEvents lblDOB As System.Windows.Forms.Label
    Friend WithEvents txtMultiBirth As DataWarehouse.TextBox_
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents comboMultiBirth As DataWarehouse.ComboBox_
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents comboHandedness As DataWarehouse.ComboBox_
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents grpNicotine As System.Windows.Forms.GroupBox
    Friend WithEvents grpPsychNeuroDx As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnRemove As DataWarehouse.Button_
    Friend WithEvents chkNBTR As DataWarehouse.CheckBox_
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents grpNicotineOther As System.Windows.Forms.GroupBox
    Friend WithEvents cmbNicOthType As DataWarehouse.ComboBox_
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtNicOthFreq As DataWarehouse.TextBoxInteger
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtNicOthYrsUse As DataWarehouse.TextBoxInteger
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtNicOthAgeStarted As DataWarehouse.TextBoxInteger
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents dtNicOthDateQuit As DataWarehouse.TextBoxDatePast
    Friend WithEvents grpCigarettes As System.Windows.Forms.GroupBox
    Friend WithEvents txtCigFreq As DataWarehouse.TextBoxInteger
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtCigYrsUse As DataWarehouse.TextBoxInteger
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCigAgeStarted As DataWarehouse.TextBoxInteger
    Friend WithEvents btnPsychNeuroRelAdd As DataWarehouse.Button_
    Friend WithEvents dgvRelWithSimilarDx As DataWarehouse.dgvSingleRow
    Friend WithEvents txtPrimNeuroText As DataWarehouse.TextBox_
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtPrimNeuroICD As DataWarehouse.TextBox_
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtPrimPsychText As DataWarehouse.TextBox_
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtPrimPsychICD As DataWarehouse.TextBox_
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtRaceSpec As DataWarehouse.TextBox_
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtEthSpec As DataWarehouse.TextBox_
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtZip As DataWarehouse.TextBox_
    Friend WithEvents txtState As DataWarehouse.TextBox_
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents lblEmptyPsychNeuroDx As System.Windows.Forms.Label
    Friend WithEvents Label33 As Label
    Friend WithEvents txtAge As TextBox_
    Friend WithEvents chkTBI As CheckBox_
    Friend WithEvents comboMaritalStatus As ComboBox_
    Friend WithEvents comboMobility As ComboBox_
    Friend WithEvents Label5 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents chkDNC As CheckBox_
    Friend WithEvents cmbSalutation As ComboBox_
    Friend WithEvents ADRCClinicalTrialsCohort As CheckBox_
    Friend WithEvents Label34 As Label
    Friend WithEvents NACCIDType As ComboBox_
    Friend WithEvents chkRelOrd As CheckBox_
    Friend WithEvents SexualOrientationATOD As ComboBox_
    Friend WithEvents Label36 As Label
    Friend WithEvents GenderATOD As ComboBox_
    Friend WithEvents Label35 As Label
    Friend WithEvents MilitaryService As ComboBox_
    Friend WithEvents Label37 As Label
    Friend WithEvents chkDNDist As CheckBox_
    Friend WithEvents chkDNDiss As CheckBox_
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbHearingLoss As ComboBox_
End Class
