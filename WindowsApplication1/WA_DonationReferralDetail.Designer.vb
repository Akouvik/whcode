<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WA_DonationReferralDetail
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPlaceOfDeathSpec = New DataWarehouse.TextBox_()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbReferralSource = New DataWarehouse.ComboBox_()
        Me.txtReferralSourceSpec = New DataWarehouse.TextBox_()
        Me.txtReferralID = New DataWarehouse.TextBox_()
        Me.txtFirstName = New DataWarehouse.TextBox_()
        Me.cmbPlaceOfDeath = New DataWarehouse.ComboBox_()
        Me.dtReferralDate = New DataWarehouse.TextBoxDatePast()
        Me.txtLastName = New DataWarehouse.TextBox_()
        Me.tmReferralTime = New DataWarehouse.TextBoxTime()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtConsentedSpec = New DataWarehouse.TextBox_()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cmbRelation = New DataWarehouse.ComboBox_()
        Me.txtRuleOutCriteriaSpec = New DataWarehouse.TextBox_()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmbConsented = New DataWarehouse.ComboBox_()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNoKName = New DataWarehouse.TextBox_()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbApproached = New DataWarehouse.ComboBox_()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbRuleOutCriteria = New DataWarehouse.ComboBox_()
        Me.cmbRuledOut = New DataWarehouse.ComboBox_()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtFinalDestinationPOCPhone = New DataWarehouse.TextBox_()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtFinalDestinationPOCName = New DataWarehouse.TextBox_()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtFinalDestination = New DataWarehouse.TextBox_()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtTransporterPOCPhone = New DataWarehouse.TextBox_()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtTransporterPOCName = New DataWarehouse.TextBox_()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmbTransporter = New DataWarehouse.ComboBox_()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbReceivedBy = New DataWarehouse.ComboBox_()
        Me.btnSave = New DataWarehouse.Button_()
        Me.txtNotes = New DataWarehouse.TextBox_()
        Me.btnAddNew = New DataWarehouse.Button_()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Referral Source"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(315, 29)
        Me.Label2.TabIndex = 196
        Me.Label2.Text = "Donation Referral Tracker"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(553, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 197
        Me.Label3.Text = "Referral ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 199
        Me.Label4.Text = "First Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(281, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 201
        Me.Label5.Text = "Last Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(532, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 200
        Me.Label6.Text = "Date Received"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(690, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 202
        Me.Label7.Text = "Time Received"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 205
        Me.Label8.Text = "Place of Death"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 362)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 13)
        Me.Label16.TabIndex = 222
        Me.Label16.Text = "Notes"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 54)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 13)
        Me.Label18.TabIndex = 227
        Me.Label18.Text = "Received By"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(297, 45)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 13)
        Me.Label19.TabIndex = 228
        Me.Label19.Text = "Specify"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPlaceOfDeathSpec)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbReferralSource)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtReferralSourceSpec)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtReferralID)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbPlaceOfDeath)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtReferralDate)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tmReferralTime)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(822, 97)
        Me.GroupBox1.TabIndex = 110
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Referral Info"
        '
        'txtPlaceOfDeathSpec
        '
        Me.txtPlaceOfDeathSpec.Location = New System.Drawing.Point(448, 69)
        Me.txtPlaceOfDeathSpec.Name = "txtPlaceOfDeathSpec"
        Me.txtPlaceOfDeathSpec.Size = New System.Drawing.Size(362, 20)
        Me.txtPlaceOfDeathSpec.TabIndex = 200
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(400, 72)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 13)
        Me.Label15.TabIndex = 230
        Me.Label15.Text = "Specify"
        '
        'cmbReferralSource
        '
        Me.cmbReferralSource.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbReferralSource.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbReferralSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReferralSource.FormattingEnabled = True
        Me.cmbReferralSource.Location = New System.Drawing.Point(93, 42)
        Me.cmbReferralSource.Name = "cmbReferralSource"
        Me.cmbReferralSource.Size = New System.Drawing.Size(181, 21)
        Me.cmbReferralSource.TabIndex = 160
        '
        'txtReferralSourceSpec
        '
        Me.txtReferralSourceSpec.Location = New System.Drawing.Point(345, 42)
        Me.txtReferralSourceSpec.Name = "txtReferralSourceSpec"
        Me.txtReferralSourceSpec.Size = New System.Drawing.Size(181, 20)
        Me.txtReferralSourceSpec.TabIndex = 170
        '
        'txtReferralID
        '
        Me.txtReferralID.Location = New System.Drawing.Point(617, 42)
        Me.txtReferralID.Name = "txtReferralID"
        Me.txtReferralID.Size = New System.Drawing.Size(127, 20)
        Me.txtReferralID.TabIndex = 180
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(93, 16)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(181, 20)
        Me.txtFirstName.TabIndex = 120
        '
        'cmbPlaceOfDeath
        '
        Me.cmbPlaceOfDeath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPlaceOfDeath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPlaceOfDeath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlaceOfDeath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPlaceOfDeath.FormattingEnabled = True
        Me.cmbPlaceOfDeath.Location = New System.Drawing.Point(93, 69)
        Me.cmbPlaceOfDeath.Name = "cmbPlaceOfDeath"
        Me.cmbPlaceOfDeath.Size = New System.Drawing.Size(301, 21)
        Me.cmbPlaceOfDeath.TabIndex = 190
        '
        'dtReferralDate
        '
        Me.dtReferralDate.Location = New System.Drawing.Point(617, 16)
        Me.dtReferralDate.Mask = "00/00/0000"
        Me.dtReferralDate.Name = "dtReferralDate"
        Me.dtReferralDate.Size = New System.Drawing.Size(67, 20)
        Me.dtReferralDate.TabIndex = 140
        Me.dtReferralDate.ValidatingType = GetType(Date)
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(345, 16)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(181, 20)
        Me.txtLastName.TabIndex = 130
        '
        'tmReferralTime
        '
        Me.tmReferralTime.Location = New System.Drawing.Point(775, 16)
        Me.tmReferralTime.Mask = "00:00"
        Me.tmReferralTime.Name = "tmReferralTime"
        Me.tmReferralTime.Size = New System.Drawing.Size(35, 20)
        Me.tmReferralTime.TabIndex = 150
        Me.tmReferralTime.ValidatingType = GetType(Date)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtConsentedSpec)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.cmbRelation)
        Me.GroupBox2.Controls.Add(Me.txtRuleOutCriteriaSpec)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.cmbConsented)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtNoKName)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.cmbApproached)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cmbRuleOutCriteria)
        Me.GroupBox2.Controls.Add(Me.cmbRuledOut)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 181)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(822, 98)
        Me.GroupBox2.TabIndex = 210
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pre-Qualification and Approach"
        '
        'txtConsentedSpec
        '
        Me.txtConsentedSpec.Location = New System.Drawing.Point(442, 71)
        Me.txtConsentedSpec.Name = "txtConsentedSpec"
        Me.txtConsentedSpec.Size = New System.Drawing.Size(276, 20)
        Me.txtConsentedSpec.TabIndex = 290
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(394, 74)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(42, 13)
        Me.Label26.TabIndex = 247
        Me.Label26.Text = "Specify"
        '
        'cmbRelation
        '
        Me.cmbRelation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbRelation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRelation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRelation.FormattingEnabled = True
        Me.cmbRelation.Location = New System.Drawing.Point(471, 44)
        Me.cmbRelation.Name = "cmbRelation"
        Me.cmbRelation.Size = New System.Drawing.Size(247, 21)
        Me.cmbRelation.TabIndex = 270
        '
        'txtRuleOutCriteriaSpec
        '
        Me.txtRuleOutCriteriaSpec.Location = New System.Drawing.Point(442, 17)
        Me.txtRuleOutCriteriaSpec.Name = "txtRuleOutCriteriaSpec"
        Me.txtRuleOutCriteriaSpec.Size = New System.Drawing.Size(276, 20)
        Me.txtRuleOutCriteriaSpec.TabIndex = 240
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(394, 20)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(42, 13)
        Me.Label20.TabIndex = 244
        Me.Label20.Text = "Specify"
        '
        'cmbConsented
        '
        Me.cmbConsented.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbConsented.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbConsented.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbConsented.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbConsented.FormattingEnabled = True
        Me.cmbConsented.Location = New System.Drawing.Point(77, 71)
        Me.cmbConsented.Name = "cmbConsented"
        Me.cmbConsented.Size = New System.Drawing.Size(311, 21)
        Me.cmbConsented.TabIndex = 280
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(10, 74)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 242
        Me.Label14.Text = "Consented"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(419, 47)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 240
        Me.Label13.Text = "Relation"
        '
        'txtNoKName
        '
        Me.txtNoKName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoKName.Location = New System.Drawing.Point(208, 44)
        Me.txtNoKName.Name = "txtNoKName"
        Me.txtNoKName.Size = New System.Drawing.Size(205, 20)
        Me.txtNoKName.TabIndex = 260
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(143, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 238
        Me.Label12.Text = "NoK Name"
        '
        'cmbApproached
        '
        Me.cmbApproached.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbApproached.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbApproached.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbApproached.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbApproached.FormattingEnabled = True
        Me.cmbApproached.Location = New System.Drawing.Point(77, 44)
        Me.cmbApproached.Name = "cmbApproached"
        Me.cmbApproached.Size = New System.Drawing.Size(60, 21)
        Me.cmbApproached.TabIndex = 250
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 236
        Me.Label11.Text = "Approached"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(143, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 235
        Me.Label10.Text = "Rule Out Criteria"
        '
        'cmbRuleOutCriteria
        '
        Me.cmbRuleOutCriteria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbRuleOutCriteria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRuleOutCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRuleOutCriteria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRuleOutCriteria.FormattingEnabled = True
        Me.cmbRuleOutCriteria.Location = New System.Drawing.Point(233, 17)
        Me.cmbRuleOutCriteria.Name = "cmbRuleOutCriteria"
        Me.cmbRuleOutCriteria.Size = New System.Drawing.Size(155, 21)
        Me.cmbRuleOutCriteria.TabIndex = 230
        '
        'cmbRuledOut
        '
        Me.cmbRuledOut.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbRuledOut.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRuledOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRuledOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRuledOut.FormattingEnabled = True
        Me.cmbRuledOut.Location = New System.Drawing.Point(77, 17)
        Me.cmbRuledOut.Name = "cmbRuledOut"
        Me.cmbRuledOut.Size = New System.Drawing.Size(60, 21)
        Me.cmbRuledOut.TabIndex = 220
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 232
        Me.Label9.Text = "Ruled Out"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtFinalDestinationPOCPhone)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.txtFinalDestinationPOCName)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.txtFinalDestination)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.txtTransporterPOCPhone)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.txtTransporterPOCName)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.cmbTransporter)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 285)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(822, 70)
        Me.GroupBox3.TabIndex = 300
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Coordinating Info"
        '
        'txtFinalDestinationPOCPhone
        '
        Me.txtFinalDestinationPOCPhone.Location = New System.Drawing.Point(628, 44)
        Me.txtFinalDestinationPOCPhone.Name = "txtFinalDestinationPOCPhone"
        Me.txtFinalDestinationPOCPhone.Size = New System.Drawing.Size(182, 20)
        Me.txtFinalDestinationPOCPhone.TabIndex = 360
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(584, 47)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(38, 13)
        Me.Label24.TabIndex = 10
        Me.Label24.Text = "Phone"
        '
        'txtFinalDestinationPOCName
        '
        Me.txtFinalDestinationPOCName.Location = New System.Drawing.Point(396, 44)
        Me.txtFinalDestinationPOCName.Name = "txtFinalDestinationPOCName"
        Me.txtFinalDestinationPOCName.Size = New System.Drawing.Size(182, 20)
        Me.txtFinalDestinationPOCName.TabIndex = 350
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(361, 47)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(29, 13)
        Me.Label25.TabIndex = 8
        Me.Label25.Text = "POC"
        '
        'txtFinalDestination
        '
        Me.txtFinalDestination.Location = New System.Drawing.Point(97, 44)
        Me.txtFinalDestination.Name = "txtFinalDestination"
        Me.txtFinalDestination.Size = New System.Drawing.Size(258, 20)
        Me.txtFinalDestination.TabIndex = 340
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 47)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(85, 13)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "Final Destination"
        '
        'txtTransporterPOCPhone
        '
        Me.txtTransporterPOCPhone.Location = New System.Drawing.Point(628, 17)
        Me.txtTransporterPOCPhone.Name = "txtTransporterPOCPhone"
        Me.txtTransporterPOCPhone.Size = New System.Drawing.Size(182, 20)
        Me.txtTransporterPOCPhone.TabIndex = 330
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(584, 20)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(38, 13)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "Phone"
        '
        'txtTransporterPOCName
        '
        Me.txtTransporterPOCName.Location = New System.Drawing.Point(396, 17)
        Me.txtTransporterPOCName.Name = "txtTransporterPOCName"
        Me.txtTransporterPOCName.Size = New System.Drawing.Size(182, 20)
        Me.txtTransporterPOCName.TabIndex = 320
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(361, 20)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(29, 13)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "POC"
        '
        'cmbTransporter
        '
        Me.cmbTransporter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTransporter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTransporter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTransporter.FormattingEnabled = True
        Me.cmbTransporter.Location = New System.Drawing.Point(83, 17)
        Me.cmbTransporter.Name = "cmbTransporter"
        Me.cmbTransporter.Size = New System.Drawing.Size(272, 21)
        Me.cmbTransporter.TabIndex = 310
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Transport Co."
        '
        'cmbReceivedBy
        '
        Me.cmbReceivedBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbReceivedBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbReceivedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReceivedBy.FormattingEnabled = True
        Me.cmbReceivedBy.Location = New System.Drawing.Point(116, 51)
        Me.cmbReceivedBy.Name = "cmbReceivedBy"
        Me.cmbReceivedBy.Size = New System.Drawing.Size(235, 21)
        Me.cmbReceivedBy.TabIndex = 100
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(12, 483)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(182, 23)
        Me.btnSave.TabIndex = 380
        Me.btnSave.Text = "Button_2"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(50, 359)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(784, 112)
        Me.txtNotes.TabIndex = 370
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(200, 483)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(182, 23)
        Me.btnAddNew.TabIndex = 401
        Me.btnAddNew.Text = "Add New Referral"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'WA_DonationReferralDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(844, 516)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.cmbReceivedBy)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNotes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WA_DonationReferralDetail"
        Me.Text = "WA_DonationReferralTracker"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbReferralSource As DataWarehouse.ComboBox_
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtReferralID As DataWarehouse.TextBox_
    Friend WithEvents txtFirstName As DataWarehouse.TextBox_
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As DataWarehouse.TextBox_
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtReferralDate As DataWarehouse.TextBoxDatePast
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tmReferralTime As DataWarehouse.TextBoxTime
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbPlaceOfDeath As DataWarehouse.ComboBox_
    Friend WithEvents txtNotes As DataWarehouse.TextBox_
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnSave As DataWarehouse.Button_
    Friend WithEvents Label18 As Label
    Friend WithEvents cmbReceivedBy As ComboBox_
    Friend WithEvents txtReferralSourceSpec As TextBox_
    Friend WithEvents Label19 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPlaceOfDeathSpec As TextBox_
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtRuleOutCriteriaSpec As TextBox_
    Friend WithEvents Label20 As Label
    Friend WithEvents cmbConsented As ComboBox_
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtNoKName As TextBox_
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbApproached As ComboBox_
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbRuleOutCriteria As ComboBox_
    Friend WithEvents cmbRuledOut As ComboBox_
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtFinalDestinationPOCPhone As TextBox_
    Friend WithEvents Label24 As Label
    Friend WithEvents txtFinalDestinationPOCName As TextBox_
    Friend WithEvents Label25 As Label
    Friend WithEvents txtFinalDestination As TextBox_
    Friend WithEvents Label23 As Label
    Friend WithEvents txtTransporterPOCPhone As TextBox_
    Friend WithEvents Label22 As Label
    Friend WithEvents txtTransporterPOCName As TextBox_
    Friend WithEvents Label21 As Label
    Friend WithEvents cmbTransporter As ComboBox_
    Friend WithEvents Label17 As Label
    Friend WithEvents cmbRelation As ComboBox_
    Friend WithEvents txtConsentedSpec As TextBox_
    Friend WithEvents Label26 As Label
    Friend WithEvents btnAddNew As Button_
End Class
