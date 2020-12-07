<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WA_TissueRequest
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnNBBURL = New DataWarehouse.Button_()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtNBBURL = New DataWarehouse.TextBox_()
        Me.dtDateApprovedForDistro = New DataWarehouse.TextBoxDatePast()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.dtRequestDate = New DataWarehouse.TextBoxDatePast()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtProjectID = New DataWarehouse.TextBox_()
        Me.txtNBTRReqNum = New DataWarehouse.TextBox_()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.chkDistroApproved = New DataWarehouse.CheckBox_()
        Me.txtProject = New DataWarehouse.TextBox_()
        Me.txtSubProject = New DataWarehouse.TextBox_()
        Me.txtProjectTitle = New DataWarehouse.TextBox_()
        Me.txtRequestingPI = New DataWarehouse.TextBox_()
        Me.txtPIEmail = New DataWarehouse.TextBox_()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.intNumSamples = New DataWarehouse.TextBoxInteger()
        Me.cmbBlackCaps = New DataWarehouse.ComboBox_()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtDistributiveDiagnosis = New DataWarehouse.TextBox_()
        Me.btnTissuePrepModify = New System.Windows.Forms.Button()
        Me.btnBrainRegionModify = New System.Windows.Forms.Button()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtTissuePreparations = New DataWarehouse.TextBox_()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtBrainRegions = New DataWarehouse.TextBox_()
        Me.rdoExtSampDesc = New System.Windows.Forms.RadioButton()
        Me.rdoIntSampDesc = New System.Windows.Forms.RadioButton()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtExternalSampleDesc = New DataWarehouse.TextBox_()
        Me.btnRemoveDistroDoc = New DataWarehouse.Button_()
        Me.btnAddDistroDoc = New DataWarehouse.Button_()
        Me.txtSampleType = New DataWarehouse.TextBox_()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtInternalSampleDesc = New DataWarehouse.TextBox_()
        Me.btnViewTissueSamples = New DataWarehouse.Button_()
        Me.btnRemoveTissueFile = New DataWarehouse.Button_()
        Me.btnAddTissueFile = New DataWarehouse.Button_()
        Me.grpShippingInfo = New System.Windows.Forms.GroupBox()
        Me.txtReqShipAcctNum = New DataWarehouse.TextBox_()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.comboReqShippingMethod = New DataWarehouse.ComboBox_()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.btnRemoveShippingDoc = New DataWarehouse.Button_()
        Me.btnAddShippingFile = New DataWarehouse.Button_()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtInstituteName = New DataWarehouse.TextBox_()
        Me.txtZip = New DataWarehouse.TextBox_()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtState = New DataWarehouse.TextBox_()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtAddress4 = New DataWarehouse.TextBox_()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtAddress3 = New DataWarehouse.TextBox_()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCity = New DataWarehouse.TextBox_()
        Me.txtPOCName = New DataWarehouse.TextBox_()
        Me.txtAddress2 = New DataWarehouse.TextBox_()
        Me.txtPOCEmail = New DataWarehouse.TextBox_()
        Me.txtPOCPhone = New DataWarehouse.TextBox_()
        Me.txtAddress1 = New DataWarehouse.TextBox_()
        Me.txtDateShipped = New DataWarehouse.TextBoxDatePast()
        Me.comboShippingMethod = New DataWarehouse.ComboBox_()
        Me.txtTrackingNum = New DataWarehouse.TextBox_()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.chkHideProject = New DataWarehouse.CheckBox_()
        Me.btnDGVFilter = New DataWarehouse.Button_()
        Me.btnToggleHidden = New DataWarehouse.Button_()
        Me.btnPDFBottom = New DataWarehouse.Button_()
        Me.btnPDFTop = New DataWarehouse.Button_()
        Me.btnAddSubProjBottom = New DataWarehouse.Button_()
        Me.btnAddSubProjTop = New DataWarehouse.Button_()
        Me.btnFilterDGV = New DataWarehouse.Button_()
        Me.btnResetDGV = New DataWarehouse.Button_()
        Me.txtFilterString = New DataWarehouse.TextBox_()
        Me.btnNewProjectBottom = New DataWarehouse.Button_()
        Me.btnNewProjectTop = New DataWarehouse.Button_()
        Me.btnTissueEditBottom = New DataWarehouse.Button_()
        Me.btnTissueEditTop = New DataWarehouse.Button_()
        Me.dgvTissueRequests = New DataWarehouse.dgvSingleRow()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.dtEstCompDt = New DataWarehouse.TextBoxDatePast()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpShippingInfo.SuspendLayout()
        CType(Me.dgvTissueRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Project"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(347, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sub Project"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Requesting PI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(364, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "PI Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Project Title/Description"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Address 1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(537, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "POC Phone"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(280, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "POC Email"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "POC Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(353, 367)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Number of Samples"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Internal Sample Decription"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(10, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(209, 29)
        Me.Label12.TabIndex = 199
        Me.Label12.Text = "Tissue Requests"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(5, 229)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 200
        Me.Label13.Text = "Date Shipped"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(156, 229)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 203
        Me.Label14.Text = "Method"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(367, 229)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 13)
        Me.Label15.TabIndex = 204
        Me.Label15.Text = "Tracking #"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(260, 63)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(246, 13)
        Me.Label16.TabIndex = 213
        Me.Label16.Text = "* Double-click a record to view detailed info below."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 98)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 13)
        Me.Label17.TabIndex = 215
        Me.Label17.Text = "Address 2"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 176)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(24, 13)
        Me.Label18.TabIndex = 217
        Me.Label18.Text = "City"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label38)
        Me.GroupBox1.Controls.Add(Me.Label37)
        Me.GroupBox1.Controls.Add(Me.dtEstCompDt)
        Me.GroupBox1.Controls.Add(Me.btnNBBURL)
        Me.GroupBox1.Controls.Add(Me.Label36)
        Me.GroupBox1.Controls.Add(Me.txtNBBURL)
        Me.GroupBox1.Controls.Add(Me.dtDateApprovedForDistro)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.dtRequestDate)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.txtProjectID)
        Me.GroupBox1.Controls.Add(Me.txtNBTRReqNum)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chkDistroApproved)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtProject)
        Me.GroupBox1.Controls.Add(Me.txtSubProject)
        Me.GroupBox1.Controls.Add(Me.txtProjectTitle)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtRequestingPI)
        Me.GroupBox1.Controls.Add(Me.txtPIEmail)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 290)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(761, 221)
        Me.GroupBox1.TabIndex = 111
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Project Info"
        '
        'btnNBBURL
        '
        Me.btnNBBURL.Location = New System.Drawing.Point(332, 135)
        Me.btnNBBURL.Name = "btnNBBURL"
        Me.btnNBBURL.Size = New System.Drawing.Size(75, 23)
        Me.btnNBBURL.TabIndex = 320
        Me.btnNBBURL.Text = "Open URL"
        Me.btnNBBURL.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(6, 140)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(80, 13)
        Me.Label36.TabIndex = 319
        Me.Label36.Text = "NBB Req. URL"
        '
        'txtNBBURL
        '
        Me.txtNBBURL.Location = New System.Drawing.Point(92, 136)
        Me.txtNBBURL.Name = "txtNBBURL"
        Me.txtNBBURL.Size = New System.Drawing.Size(234, 20)
        Me.txtNBBURL.TabIndex = 318
        '
        'dtDateApprovedForDistro
        '
        Me.dtDateApprovedForDistro.Enabled = False
        Me.dtDateApprovedForDistro.Location = New System.Drawing.Point(153, 12)
        Me.dtDateApprovedForDistro.Mask = "00/00/0000"
        Me.dtDateApprovedForDistro.Name = "dtDateApprovedForDistro"
        Me.dtDateApprovedForDistro.Size = New System.Drawing.Size(67, 20)
        Me.dtDateApprovedForDistro.TabIndex = 113
        Me.dtDateApprovedForDistro.ValidatingType = GetType(Date)
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(193, 165)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(73, 13)
        Me.Label31.TabIndex = 317
        Me.Label31.Text = "Request Date"
        '
        'dtRequestDate
        '
        Me.dtRequestDate.Location = New System.Drawing.Point(272, 162)
        Me.dtRequestDate.Mask = "00/00/0000"
        Me.dtRequestDate.Name = "dtRequestDate"
        Me.dtRequestDate.Size = New System.Drawing.Size(67, 20)
        Me.dtRequestDate.TabIndex = 119
        Me.dtRequestDate.ValidatingType = GetType(Date)
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(347, 15)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(51, 13)
        Me.Label29.TabIndex = 315
        Me.Label29.Text = "ProjectID"
        '
        'txtProjectID
        '
        Me.txtProjectID.Enabled = False
        Me.txtProjectID.Location = New System.Drawing.Point(415, 12)
        Me.txtProjectID.Name = "txtProjectID"
        Me.txtProjectID.Size = New System.Drawing.Size(100, 20)
        Me.txtProjectID.TabIndex = 114
        '
        'txtNBTRReqNum
        '
        Me.txtNBTRReqNum.Location = New System.Drawing.Point(87, 162)
        Me.txtNBTRReqNum.Name = "txtNBTRReqNum"
        Me.txtNBTRReqNum.Size = New System.Drawing.Size(100, 20)
        Me.txtNBTRReqNum.TabIndex = 118
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 165)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(73, 13)
        Me.Label25.TabIndex = 312
        Me.Label25.Text = "NBTR Req. #"
        '
        'chkDistroApproved
        '
        Me.chkDistroApproved.AutoSize = True
        Me.chkDistroApproved.BackColor = System.Drawing.Color.Tan
        Me.chkDistroApproved.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDistroApproved.Location = New System.Drawing.Point(9, 15)
        Me.chkDistroApproved.Name = "chkDistroApproved"
        Me.chkDistroApproved.Size = New System.Drawing.Size(137, 17)
        Me.chkDistroApproved.TabIndex = 112
        Me.chkDistroApproved.Text = "Approved for distribution"
        Me.chkDistroApproved.UseVisualStyleBackColor = True
        '
        'txtProject
        '
        Me.txtProject.Location = New System.Drawing.Point(52, 34)
        Me.txtProject.Multiline = True
        Me.txtProject.Name = "txtProject"
        Me.txtProject.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtProject.Size = New System.Drawing.Size(289, 40)
        Me.txtProject.TabIndex = 115
        '
        'txtSubProject
        '
        Me.txtSubProject.Location = New System.Drawing.Point(415, 34)
        Me.txtSubProject.Multiline = True
        Me.txtSubProject.Name = "txtSubProject"
        Me.txtSubProject.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSubProject.Size = New System.Drawing.Size(289, 40)
        Me.txtSubProject.TabIndex = 116
        '
        'txtProjectTitle
        '
        Me.txtProjectTitle.Location = New System.Drawing.Point(20, 93)
        Me.txtProjectTitle.Multiline = True
        Me.txtProjectTitle.Name = "txtProjectTitle"
        Me.txtProjectTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtProjectTitle.Size = New System.Drawing.Size(684, 37)
        Me.txtProjectTitle.TabIndex = 117
        '
        'txtRequestingPI
        '
        Me.txtRequestingPI.Location = New System.Drawing.Point(87, 188)
        Me.txtRequestingPI.Name = "txtRequestingPI"
        Me.txtRequestingPI.Size = New System.Drawing.Size(274, 20)
        Me.txtRequestingPI.TabIndex = 120
        '
        'txtPIEmail
        '
        Me.txtPIEmail.Location = New System.Drawing.Point(415, 188)
        Me.txtPIEmail.Name = "txtPIEmail"
        Me.txtPIEmail.Size = New System.Drawing.Size(289, 20)
        Me.txtPIEmail.TabIndex = 121
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.intNumSamples)
        Me.GroupBox2.Controls.Add(Me.cmbBlackCaps)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.txtDistributiveDiagnosis)
        Me.GroupBox2.Controls.Add(Me.btnTissuePrepModify)
        Me.GroupBox2.Controls.Add(Me.btnBrainRegionModify)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.txtTissuePreparations)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.txtBrainRegions)
        Me.GroupBox2.Controls.Add(Me.rdoExtSampDesc)
        Me.GroupBox2.Controls.Add(Me.rdoIntSampDesc)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.txtExternalSampleDesc)
        Me.GroupBox2.Controls.Add(Me.btnRemoveDistroDoc)
        Me.GroupBox2.Controls.Add(Me.btnAddDistroDoc)
        Me.GroupBox2.Controls.Add(Me.txtSampleType)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtInternalSampleDesc)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.btnViewTissueSamples)
        Me.GroupBox2.Controls.Add(Me.btnRemoveTissueFile)
        Me.GroupBox2.Controls.Add(Me.btnAddTissueFile)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 517)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(761, 533)
        Me.GroupBox2.TabIndex = 122
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tissue Info"
        '
        'intNumSamples
        '
        Me.intNumSamples.Location = New System.Drawing.Point(356, 383)
        Me.intNumSamples.Name = "intNumSamples"
        Me.intNumSamples.Size = New System.Drawing.Size(107, 20)
        Me.intNumSamples.TabIndex = 224
        '
        'cmbBlackCaps
        '
        Me.cmbBlackCaps.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbBlackCaps.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBlackCaps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBlackCaps.FormattingEnabled = True
        Me.cmbBlackCaps.Location = New System.Drawing.Point(356, 422)
        Me.cmbBlackCaps.Name = "cmbBlackCaps"
        Me.cmbBlackCaps.Size = New System.Drawing.Size(107, 21)
        Me.cmbBlackCaps.TabIndex = 223
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(353, 406)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(159, 13)
        Me.Label35.TabIndex = 222
        Me.Label35.Text = "Additional generics (Black Caps)"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(6, 328)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(108, 13)
        Me.Label34.TabIndex = 221
        Me.Label34.Text = "Distributive Diagnosis"
        '
        'txtDistributiveDiagnosis
        '
        Me.txtDistributiveDiagnosis.Location = New System.Drawing.Point(9, 344)
        Me.txtDistributiveDiagnosis.Name = "txtDistributiveDiagnosis"
        Me.txtDistributiveDiagnosis.Size = New System.Drawing.Size(341, 20)
        Me.txtDistributiveDiagnosis.TabIndex = 220
        '
        'btnTissuePrepModify
        '
        Me.btnTissuePrepModify.Enabled = False
        Me.btnTissuePrepModify.Location = New System.Drawing.Point(630, 310)
        Me.btnTissuePrepModify.Name = "btnTissuePrepModify"
        Me.btnTissuePrepModify.Size = New System.Drawing.Size(75, 23)
        Me.btnTissuePrepModify.TabIndex = 219
        Me.btnTissuePrepModify.Text = "Modify"
        Me.btnTissuePrepModify.UseVisualStyleBackColor = True
        '
        'btnBrainRegionModify
        '
        Me.btnBrainRegionModify.Enabled = False
        Me.btnBrainRegionModify.Location = New System.Drawing.Point(276, 310)
        Me.btnBrainRegionModify.Name = "btnBrainRegionModify"
        Me.btnBrainRegionModify.Size = New System.Drawing.Size(75, 23)
        Me.btnBrainRegionModify.TabIndex = 218
        Me.btnBrainRegionModify.Text = "Modify"
        Me.btnBrainRegionModify.UseVisualStyleBackColor = True
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(353, 253)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(106, 13)
        Me.Label33.TabIndex = 217
        Me.Label33.Text = "Tissue Preparation(s)"
        '
        'txtTissuePreparations
        '
        Me.txtTissuePreparations.Location = New System.Drawing.Point(356, 269)
        Me.txtTissuePreparations.Multiline = True
        Me.txtTissuePreparations.Name = "txtTissuePreparations"
        Me.txtTissuePreparations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTissuePreparations.Size = New System.Drawing.Size(348, 40)
        Me.txtTissuePreparations.TabIndex = 216
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(6, 253)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(79, 13)
        Me.Label32.TabIndex = 215
        Me.Label32.Text = "Brain Region(s)"
        '
        'txtBrainRegions
        '
        Me.txtBrainRegions.Location = New System.Drawing.Point(9, 269)
        Me.txtBrainRegions.Multiline = True
        Me.txtBrainRegions.Name = "txtBrainRegions"
        Me.txtBrainRegions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBrainRegions.Size = New System.Drawing.Size(341, 40)
        Me.txtBrainRegions.TabIndex = 214
        '
        'rdoExtSampDesc
        '
        Me.rdoExtSampDesc.AutoSize = True
        Me.rdoExtSampDesc.Location = New System.Drawing.Point(493, 17)
        Me.rdoExtSampDesc.Name = "rdoExtSampDesc"
        Me.rdoExtSampDesc.Size = New System.Drawing.Size(115, 17)
        Me.rdoExtSampDesc.TabIndex = 213
        Me.rdoExtSampDesc.TabStop = True
        Me.rdoExtSampDesc.Text = "Use on PDF export"
        Me.rdoExtSampDesc.UseVisualStyleBackColor = True
        '
        'rdoIntSampDesc
        '
        Me.rdoIntSampDesc.AutoSize = True
        Me.rdoIntSampDesc.Location = New System.Drawing.Point(143, 17)
        Me.rdoIntSampDesc.Name = "rdoIntSampDesc"
        Me.rdoIntSampDesc.Size = New System.Drawing.Size(115, 17)
        Me.rdoIntSampDesc.TabIndex = 212
        Me.rdoIntSampDesc.TabStop = True
        Me.rdoIntSampDesc.Text = "Use on PDF export"
        Me.rdoIntSampDesc.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(353, 18)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(134, 13)
        Me.Label30.TabIndex = 210
        Me.Label30.Text = "External Sample Decription"
        '
        'txtExternalSampleDesc
        '
        Me.txtExternalSampleDesc.Location = New System.Drawing.Point(356, 34)
        Me.txtExternalSampleDesc.Multiline = True
        Me.txtExternalSampleDesc.Name = "txtExternalSampleDesc"
        Me.txtExternalSampleDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtExternalSampleDesc.Size = New System.Drawing.Size(348, 216)
        Me.txtExternalSampleDesc.TabIndex = 124
        '
        'btnRemoveDistroDoc
        '
        Me.btnRemoveDistroDoc.Location = New System.Drawing.Point(340, 504)
        Me.btnRemoveDistroDoc.Name = "btnRemoveDistroDoc"
        Me.btnRemoveDistroDoc.Size = New System.Drawing.Size(160, 23)
        Me.btnRemoveDistroDoc.TabIndex = 131
        Me.btnRemoveDistroDoc.Text = "Remove Distro Doc"
        Me.btnRemoveDistroDoc.UseVisualStyleBackColor = True
        '
        'btnAddDistroDoc
        '
        Me.btnAddDistroDoc.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAddDistroDoc.Location = New System.Drawing.Point(340, 475)
        Me.btnAddDistroDoc.Name = "btnAddDistroDoc"
        Me.btnAddDistroDoc.Size = New System.Drawing.Size(160, 23)
        Me.btnAddDistroDoc.TabIndex = 129
        Me.btnAddDistroDoc.Text = "Upload Distro Doc"
        Me.btnAddDistroDoc.UseVisualStyleBackColor = False
        '
        'txtSampleType
        '
        Me.txtSampleType.Location = New System.Drawing.Point(8, 383)
        Me.txtSampleType.Multiline = True
        Me.txtSampleType.Name = "txtSampleType"
        Me.txtSampleType.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSampleType.Size = New System.Drawing.Size(341, 86)
        Me.txtSampleType.TabIndex = 125
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(5, 367)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(74, 13)
        Me.Label26.TabIndex = 206
        Me.Label26.Text = "Sample Types"
        '
        'txtInternalSampleDesc
        '
        Me.txtInternalSampleDesc.Location = New System.Drawing.Point(9, 34)
        Me.txtInternalSampleDesc.Multiline = True
        Me.txtInternalSampleDesc.Name = "txtInternalSampleDesc"
        Me.txtInternalSampleDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInternalSampleDesc.Size = New System.Drawing.Size(341, 216)
        Me.txtInternalSampleDesc.TabIndex = 123
        '
        'btnViewTissueSamples
        '
        Me.btnViewTissueSamples.Location = New System.Drawing.Point(8, 475)
        Me.btnViewTissueSamples.Name = "btnViewTissueSamples"
        Me.btnViewTissueSamples.Size = New System.Drawing.Size(160, 23)
        Me.btnViewTissueSamples.TabIndex = 127
        Me.btnViewTissueSamples.Text = "View Associated Tissue"
        Me.btnViewTissueSamples.UseVisualStyleBackColor = True
        '
        'btnRemoveTissueFile
        '
        Me.btnRemoveTissueFile.Location = New System.Drawing.Point(506, 475)
        Me.btnRemoveTissueFile.Name = "btnRemoveTissueFile"
        Me.btnRemoveTissueFile.Size = New System.Drawing.Size(160, 23)
        Me.btnRemoveTissueFile.TabIndex = 130
        Me.btnRemoveTissueFile.Text = "Remove Tissue Spreadsheet"
        Me.btnRemoveTissueFile.UseVisualStyleBackColor = True
        '
        'btnAddTissueFile
        '
        Me.btnAddTissueFile.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAddTissueFile.Location = New System.Drawing.Point(174, 475)
        Me.btnAddTissueFile.Name = "btnAddTissueFile"
        Me.btnAddTissueFile.Size = New System.Drawing.Size(160, 23)
        Me.btnAddTissueFile.TabIndex = 128
        Me.btnAddTissueFile.Text = "Upload Tissue Spreadsheet"
        Me.btnAddTissueFile.UseVisualStyleBackColor = False
        '
        'grpShippingInfo
        '
        Me.grpShippingInfo.Controls.Add(Me.txtReqShipAcctNum)
        Me.grpShippingInfo.Controls.Add(Me.Label28)
        Me.grpShippingInfo.Controls.Add(Me.comboReqShippingMethod)
        Me.grpShippingInfo.Controls.Add(Me.Label27)
        Me.grpShippingInfo.Controls.Add(Me.btnRemoveShippingDoc)
        Me.grpShippingInfo.Controls.Add(Me.btnAddShippingFile)
        Me.grpShippingInfo.Controls.Add(Me.Label23)
        Me.grpShippingInfo.Controls.Add(Me.txtInstituteName)
        Me.grpShippingInfo.Controls.Add(Me.txtZip)
        Me.grpShippingInfo.Controls.Add(Me.Label22)
        Me.grpShippingInfo.Controls.Add(Me.txtState)
        Me.grpShippingInfo.Controls.Add(Me.Label21)
        Me.grpShippingInfo.Controls.Add(Me.txtAddress4)
        Me.grpShippingInfo.Controls.Add(Me.Label20)
        Me.grpShippingInfo.Controls.Add(Me.txtAddress3)
        Me.grpShippingInfo.Controls.Add(Me.Label19)
        Me.grpShippingInfo.Controls.Add(Me.Label9)
        Me.grpShippingInfo.Controls.Add(Me.Label6)
        Me.grpShippingInfo.Controls.Add(Me.Label7)
        Me.grpShippingInfo.Controls.Add(Me.txtCity)
        Me.grpShippingInfo.Controls.Add(Me.Label8)
        Me.grpShippingInfo.Controls.Add(Me.Label18)
        Me.grpShippingInfo.Controls.Add(Me.txtPOCName)
        Me.grpShippingInfo.Controls.Add(Me.txtAddress2)
        Me.grpShippingInfo.Controls.Add(Me.txtPOCEmail)
        Me.grpShippingInfo.Controls.Add(Me.Label17)
        Me.grpShippingInfo.Controls.Add(Me.txtPOCPhone)
        Me.grpShippingInfo.Controls.Add(Me.txtAddress1)
        Me.grpShippingInfo.Controls.Add(Me.Label13)
        Me.grpShippingInfo.Controls.Add(Me.txtDateShipped)
        Me.grpShippingInfo.Controls.Add(Me.comboShippingMethod)
        Me.grpShippingInfo.Controls.Add(Me.Label14)
        Me.grpShippingInfo.Controls.Add(Me.Label15)
        Me.grpShippingInfo.Controls.Add(Me.txtTrackingNum)
        Me.grpShippingInfo.Location = New System.Drawing.Point(3, 1056)
        Me.grpShippingInfo.Name = "grpShippingInfo"
        Me.grpShippingInfo.Size = New System.Drawing.Size(761, 281)
        Me.grpShippingInfo.TabIndex = 132
        Me.grpShippingInfo.TabStop = False
        Me.grpShippingInfo.Text = "Shipping Info"
        '
        'txtReqShipAcctNum
        '
        Me.txtReqShipAcctNum.Location = New System.Drawing.Point(462, 199)
        Me.txtReqShipAcctNum.Name = "txtReqShipAcctNum"
        Me.txtReqShipAcctNum.Size = New System.Drawing.Size(156, 20)
        Me.txtReqShipAcctNum.TabIndex = 145
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(315, 202)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(145, 13)
        Me.Label28.TabIndex = 321
        Me.Label28.Text = "Requestor's Shipping Acct. #"
        '
        'comboReqShippingMethod
        '
        Me.comboReqShippingMethod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboReqShippingMethod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboReqShippingMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboReqShippingMethod.FormattingEnabled = True
        Me.comboReqShippingMethod.Location = New System.Drawing.Point(153, 199)
        Me.comboReqShippingMethod.Name = "comboReqShippingMethod"
        Me.comboReqShippingMethod.Size = New System.Drawing.Size(156, 21)
        Me.comboReqShippingMethod.TabIndex = 144
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(5, 202)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(142, 13)
        Me.Label27.TabIndex = 319
        Me.Label27.Text = "Requested Shipping Method"
        '
        'btnRemoveShippingDoc
        '
        Me.btnRemoveShippingDoc.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnRemoveShippingDoc.Enabled = False
        Me.btnRemoveShippingDoc.Location = New System.Drawing.Point(170, 252)
        Me.btnRemoveShippingDoc.Name = "btnRemoveShippingDoc"
        Me.btnRemoveShippingDoc.Size = New System.Drawing.Size(156, 23)
        Me.btnRemoveShippingDoc.TabIndex = 150
        Me.btnRemoveShippingDoc.Text = "Remove Shipping Scan"
        Me.btnRemoveShippingDoc.UseVisualStyleBackColor = False
        '
        'btnAddShippingFile
        '
        Me.btnAddShippingFile.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAddShippingFile.Enabled = False
        Me.btnAddShippingFile.Location = New System.Drawing.Point(9, 252)
        Me.btnAddShippingFile.Name = "btnAddShippingFile"
        Me.btnAddShippingFile.Size = New System.Drawing.Size(156, 23)
        Me.btnAddShippingFile.TabIndex = 149
        Me.btnAddShippingFile.Text = "Upload Shipping Scan"
        Me.btnAddShippingFile.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 46)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(75, 13)
        Me.Label23.TabIndex = 316
        Me.Label23.Text = "Institute Name"
        '
        'txtInstituteName
        '
        Me.txtInstituteName.Location = New System.Drawing.Point(86, 43)
        Me.txtInstituteName.Name = "txtInstituteName"
        Me.txtInstituteName.Size = New System.Drawing.Size(426, 20)
        Me.txtInstituteName.TabIndex = 136
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(416, 173)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(151, 20)
        Me.txtZip.TabIndex = 143
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(388, 176)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(22, 13)
        Me.Label22.TabIndex = 225
        Me.Label22.Text = "Zip"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(231, 173)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(151, 20)
        Me.txtState.TabIndex = 142
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(193, 176)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(32, 13)
        Me.Label21.TabIndex = 223
        Me.Label21.Text = "State"
        '
        'txtAddress4
        '
        Me.txtAddress4.Location = New System.Drawing.Point(86, 147)
        Me.txtAddress4.Name = "txtAddress4"
        Me.txtAddress4.Size = New System.Drawing.Size(426, 20)
        Me.txtAddress4.TabIndex = 140
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 150)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(54, 13)
        Me.Label20.TabIndex = 221
        Me.Label20.Text = "Address 4"
        '
        'txtAddress3
        '
        Me.txtAddress3.Location = New System.Drawing.Point(86, 121)
        Me.txtAddress3.Name = "txtAddress3"
        Me.txtAddress3.Size = New System.Drawing.Size(426, 20)
        Me.txtAddress3.TabIndex = 139
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 124)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(54, 13)
        Me.Label19.TabIndex = 219
        Me.Label19.Text = "Address 3"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(36, 173)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(151, 20)
        Me.txtCity.TabIndex = 141
        '
        'txtPOCName
        '
        Me.txtPOCName.Location = New System.Drawing.Point(86, 17)
        Me.txtPOCName.Name = "txtPOCName"
        Me.txtPOCName.Size = New System.Drawing.Size(188, 20)
        Me.txtPOCName.TabIndex = 133
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(86, 95)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(426, 20)
        Me.txtAddress2.TabIndex = 138
        '
        'txtPOCEmail
        '
        Me.txtPOCEmail.Location = New System.Drawing.Point(343, 17)
        Me.txtPOCEmail.Name = "txtPOCEmail"
        Me.txtPOCEmail.Size = New System.Drawing.Size(188, 20)
        Me.txtPOCEmail.TabIndex = 134
        '
        'txtPOCPhone
        '
        Me.txtPOCPhone.Location = New System.Drawing.Point(606, 17)
        Me.txtPOCPhone.Name = "txtPOCPhone"
        Me.txtPOCPhone.Size = New System.Drawing.Size(141, 20)
        Me.txtPOCPhone.TabIndex = 135
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New System.Drawing.Point(86, 69)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(426, 20)
        Me.txtAddress1.TabIndex = 137
        '
        'txtDateShipped
        '
        Me.txtDateShipped.Location = New System.Drawing.Point(83, 226)
        Me.txtDateShipped.Mask = "00/00/0000"
        Me.txtDateShipped.Name = "txtDateShipped"
        Me.txtDateShipped.Size = New System.Drawing.Size(67, 20)
        Me.txtDateShipped.TabIndex = 146
        Me.txtDateShipped.ValidatingType = GetType(Date)
        '
        'comboShippingMethod
        '
        Me.comboShippingMethod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboShippingMethod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboShippingMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboShippingMethod.FormattingEnabled = True
        Me.comboShippingMethod.Location = New System.Drawing.Point(205, 226)
        Me.comboShippingMethod.Name = "comboShippingMethod"
        Me.comboShippingMethod.Size = New System.Drawing.Size(156, 21)
        Me.comboShippingMethod.TabIndex = 147
        '
        'txtTrackingNum
        '
        Me.txtTrackingNum.Location = New System.Drawing.Point(432, 226)
        Me.txtTrackingNum.Name = "txtTrackingNum"
        Me.txtTrackingNum.Size = New System.Drawing.Size(156, 20)
        Me.txtTrackingNum.TabIndex = 148
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(8, 38)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(41, 13)
        Me.Label24.TabIndex = 402
        Me.Label24.Text = "Search"
        '
        'chkHideProject
        '
        Me.chkHideProject.AutoSize = True
        Me.chkHideProject.BackColor = System.Drawing.Color.Tan
        Me.chkHideProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkHideProject.Location = New System.Drawing.Point(683, 1346)
        Me.chkHideProject.Name = "chkHideProject"
        Me.chkHideProject.Size = New System.Drawing.Size(81, 17)
        Me.chkHideProject.TabIndex = 155
        Me.chkHideProject.Text = "Hide Project"
        Me.chkHideProject.UseVisualStyleBackColor = False
        '
        'btnDGVFilter
        '
        Me.btnDGVFilter.Location = New System.Drawing.Point(631, 261)
        Me.btnDGVFilter.Name = "btnDGVFilter"
        Me.btnDGVFilter.Size = New System.Drawing.Size(133, 23)
        Me.btnDGVFilter.TabIndex = 110
        Me.btnDGVFilter.Text = "Hide Completed Projects"
        Me.btnDGVFilter.UseVisualStyleBackColor = True
        '
        'btnToggleHidden
        '
        Me.btnToggleHidden.Location = New System.Drawing.Point(631, 50)
        Me.btnToggleHidden.Name = "btnToggleHidden"
        Me.btnToggleHidden.Size = New System.Drawing.Size(133, 23)
        Me.btnToggleHidden.TabIndex = 104
        Me.btnToggleHidden.Text = "Show Hidden Projects"
        Me.btnToggleHidden.UseVisualStyleBackColor = True
        '
        'btnPDFBottom
        '
        Me.btnPDFBottom.Location = New System.Drawing.Point(424, 1343)
        Me.btnPDFBottom.Name = "btnPDFBottom"
        Me.btnPDFBottom.Size = New System.Drawing.Size(135, 23)
        Me.btnPDFBottom.TabIndex = 154
        Me.btnPDFBottom.Text = "Generate PDF Export"
        Me.btnPDFBottom.UseVisualStyleBackColor = True
        Me.btnPDFBottom.Visible = False
        '
        'btnPDFTop
        '
        Me.btnPDFTop.Location = New System.Drawing.Point(424, 261)
        Me.btnPDFTop.Name = "btnPDFTop"
        Me.btnPDFTop.Size = New System.Drawing.Size(135, 23)
        Me.btnPDFTop.TabIndex = 109
        Me.btnPDFTop.Text = "Generate PDF Export"
        Me.btnPDFTop.UseVisualStyleBackColor = True
        Me.btnPDFTop.Visible = False
        '
        'btnAddSubProjBottom
        '
        Me.btnAddSubProjBottom.Location = New System.Drawing.Point(283, 1343)
        Me.btnAddSubProjBottom.Name = "btnAddSubProjBottom"
        Me.btnAddSubProjBottom.Size = New System.Drawing.Size(135, 23)
        Me.btnAddSubProjBottom.TabIndex = 153
        Me.btnAddSubProjBottom.Text = "Create New SubProject"
        Me.btnAddSubProjBottom.UseVisualStyleBackColor = True
        Me.btnAddSubProjBottom.Visible = False
        '
        'btnAddSubProjTop
        '
        Me.btnAddSubProjTop.Location = New System.Drawing.Point(283, 261)
        Me.btnAddSubProjTop.Name = "btnAddSubProjTop"
        Me.btnAddSubProjTop.Size = New System.Drawing.Size(135, 23)
        Me.btnAddSubProjTop.TabIndex = 108
        Me.btnAddSubProjTop.Text = "Create New SubProject"
        Me.btnAddSubProjTop.UseVisualStyleBackColor = True
        Me.btnAddSubProjTop.Visible = False
        '
        'btnFilterDGV
        '
        Me.btnFilterDGV.Location = New System.Drawing.Point(283, 33)
        Me.btnFilterDGV.Name = "btnFilterDGV"
        Me.btnFilterDGV.Size = New System.Drawing.Size(75, 23)
        Me.btnFilterDGV.TabIndex = 102
        Me.btnFilterDGV.Text = "Filter"
        Me.btnFilterDGV.UseVisualStyleBackColor = True
        '
        'btnResetDGV
        '
        Me.btnResetDGV.Location = New System.Drawing.Point(364, 33)
        Me.btnResetDGV.Name = "btnResetDGV"
        Me.btnResetDGV.Size = New System.Drawing.Size(75, 23)
        Me.btnResetDGV.TabIndex = 103
        Me.btnResetDGV.Text = "Reset"
        Me.btnResetDGV.UseVisualStyleBackColor = True
        '
        'txtFilterString
        '
        Me.txtFilterString.Location = New System.Drawing.Point(55, 35)
        Me.txtFilterString.Name = "txtFilterString"
        Me.txtFilterString.Size = New System.Drawing.Size(222, 20)
        Me.txtFilterString.TabIndex = 101
        '
        'btnNewProjectBottom
        '
        Me.btnNewProjectBottom.Location = New System.Drawing.Point(143, 1343)
        Me.btnNewProjectBottom.Name = "btnNewProjectBottom"
        Me.btnNewProjectBottom.Size = New System.Drawing.Size(134, 23)
        Me.btnNewProjectBottom.TabIndex = 152
        Me.btnNewProjectBottom.Text = "Add New Project"
        Me.btnNewProjectBottom.UseVisualStyleBackColor = True
        '
        'btnNewProjectTop
        '
        Me.btnNewProjectTop.Location = New System.Drawing.Point(143, 261)
        Me.btnNewProjectTop.Name = "btnNewProjectTop"
        Me.btnNewProjectTop.Size = New System.Drawing.Size(134, 23)
        Me.btnNewProjectTop.TabIndex = 107
        Me.btnNewProjectTop.Text = "Add New Project"
        Me.btnNewProjectTop.UseVisualStyleBackColor = True
        '
        'btnTissueEditBottom
        '
        Me.btnTissueEditBottom.Location = New System.Drawing.Point(3, 1343)
        Me.btnTissueEditBottom.Name = "btnTissueEditBottom"
        Me.btnTissueEditBottom.Size = New System.Drawing.Size(134, 23)
        Me.btnTissueEditBottom.TabIndex = 151
        Me.btnTissueEditBottom.Text = "Edit This Project"
        Me.btnTissueEditBottom.UseVisualStyleBackColor = True
        Me.btnTissueEditBottom.Visible = False
        '
        'btnTissueEditTop
        '
        Me.btnTissueEditTop.Location = New System.Drawing.Point(3, 261)
        Me.btnTissueEditTop.Name = "btnTissueEditTop"
        Me.btnTissueEditTop.Size = New System.Drawing.Size(134, 23)
        Me.btnTissueEditTop.TabIndex = 106
        Me.btnTissueEditTop.Text = "Edit This Project"
        Me.btnTissueEditTop.UseVisualStyleBackColor = True
        Me.btnTissueEditTop.Visible = False
        '
        'dgvTissueRequests
        '
        Me.dgvTissueRequests.AllowUserToAddRows = False
        Me.dgvTissueRequests.AllowUserToDeleteRows = False
        Me.dgvTissueRequests.AllowUserToOrderColumns = True
        Me.dgvTissueRequests.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Beige
        Me.dgvTissueRequests.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvTissueRequests.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dgvTissueRequests.BackgroundColor = System.Drawing.Color.Tan
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTissueRequests.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvTissueRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTissueRequests.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvTissueRequests.GridColor = System.Drawing.Color.Linen
        Me.dgvTissueRequests.Location = New System.Drawing.Point(3, 81)
        Me.dgvTissueRequests.MultiSelect = False
        Me.dgvTissueRequests.Name = "dgvTissueRequests"
        Me.dgvTissueRequests.ReadOnly = True
        Me.dgvTissueRequests.RowHeadersVisible = False
        Me.dgvTissueRequests.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.dgvTissueRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTissueRequests.Size = New System.Drawing.Size(761, 176)
        Me.dgvTissueRequests.TabIndex = 105
        Me.dgvTissueRequests.TabStop = False
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(345, 165)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(78, 13)
        Me.Label37.TabIndex = 322
        Me.Label37.Text = "Est Comp Date"
        '
        'dtEstCompDt
        '
        Me.dtEstCompDt.Enabled = False
        Me.dtEstCompDt.Location = New System.Drawing.Point(429, 162)
        Me.dtEstCompDt.Mask = "00/00/0000"
        Me.dtEstCompDt.Name = "dtEstCompDt"
        Me.dtEstCompDt.Size = New System.Drawing.Size(67, 20)
        Me.dtEstCompDt.TabIndex = 321
        Me.dtEstCompDt.ValidatingType = GetType(Date)
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(498, 165)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(103, 13)
        Me.Label38.TabIndex = 323
        Me.Label38.Text = "(from Tissue Tasker)"
        '
        'WA_TissueRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.Controls.Add(Me.chkHideProject)
        Me.Controls.Add(Me.btnDGVFilter)
        Me.Controls.Add(Me.btnToggleHidden)
        Me.Controls.Add(Me.btnPDFBottom)
        Me.Controls.Add(Me.btnPDFTop)
        Me.Controls.Add(Me.btnAddSubProjBottom)
        Me.Controls.Add(Me.btnAddSubProjTop)
        Me.Controls.Add(Me.btnFilterDGV)
        Me.Controls.Add(Me.btnResetDGV)
        Me.Controls.Add(Me.txtFilterString)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.btnNewProjectBottom)
        Me.Controls.Add(Me.btnNewProjectTop)
        Me.Controls.Add(Me.grpShippingInfo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnTissueEditBottom)
        Me.Controls.Add(Me.btnTissueEditTop)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dgvTissueRequests)
        Me.Name = "WA_TissueRequest"
        Me.Size = New System.Drawing.Size(771, 1368)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpShippingInfo.ResumeLayout(False)
        Me.grpShippingInfo.PerformLayout()
        CType(Me.dgvTissueRequests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvTissueRequests As DataWarehouse.dgvSingleRow
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtProject As DataWarehouse.TextBox_
    Friend WithEvents txtSubProject As DataWarehouse.TextBox_
    Friend WithEvents txtProjectTitle As DataWarehouse.TextBox_
    Friend WithEvents txtInternalSampleDesc As DataWarehouse.TextBox_
    Friend WithEvents txtRequestingPI As DataWarehouse.TextBox_
    Friend WithEvents txtPIEmail As DataWarehouse.TextBox_
    Friend WithEvents txtPOCName As DataWarehouse.TextBox_
    Friend WithEvents txtPOCEmail As DataWarehouse.TextBox_
    Friend WithEvents txtPOCPhone As DataWarehouse.TextBox_
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDateShipped As DataWarehouse.TextBoxDatePast
    Friend WithEvents comboShippingMethod As DataWarehouse.ComboBox_
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTrackingNum As DataWarehouse.TextBox_
    Friend WithEvents btnTissueEditTop As DataWarehouse.Button_
    Friend WithEvents btnTissueEditBottom As DataWarehouse.Button_
    Friend WithEvents btnAddTissueFile As DataWarehouse.Button_
    Friend WithEvents btnRemoveTissueFile As DataWarehouse.Button_
    Friend WithEvents btnViewTissueSamples As DataWarehouse.Button_
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtAddress1 As DataWarehouse.TextBox_
    Friend WithEvents txtAddress2 As DataWarehouse.TextBox_
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCity As DataWarehouse.TextBox_
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grpShippingInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtAddress4 As DataWarehouse.TextBox_
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtAddress3 As DataWarehouse.TextBox_
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtZip As DataWarehouse.TextBox_
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtState As DataWarehouse.TextBox_
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnNewProjectTop As DataWarehouse.Button_
    Friend WithEvents btnNewProjectBottom As DataWarehouse.Button_
    Friend WithEvents chkDistroApproved As DataWarehouse.CheckBox_
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtInstituteName As DataWarehouse.TextBox_
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtFilterString As DataWarehouse.TextBox_
    Friend WithEvents btnResetDGV As DataWarehouse.Button_
    Friend WithEvents btnFilterDGV As DataWarehouse.Button_
    Friend WithEvents btnRemoveShippingDoc As DataWarehouse.Button_
    Friend WithEvents btnAddShippingFile As DataWarehouse.Button_
    Friend WithEvents txtNBTRReqNum As DataWarehouse.TextBox_
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtSampleType As DataWarehouse.TextBox_
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtReqShipAcctNum As DataWarehouse.TextBox_
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents comboReqShippingMethod As DataWarehouse.ComboBox_
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtProjectID As DataWarehouse.TextBox_
    Friend WithEvents btnAddSubProjTop As DataWarehouse.Button_
    Friend WithEvents btnAddSubProjBottom As DataWarehouse.Button_
    Friend WithEvents btnPDFTop As DataWarehouse.Button_
    Friend WithEvents btnPDFBottom As DataWarehouse.Button_
    Friend WithEvents btnRemoveDistroDoc As DataWarehouse.Button_
    Friend WithEvents btnAddDistroDoc As DataWarehouse.Button_
    Friend WithEvents Label30 As Label
    Friend WithEvents txtExternalSampleDesc As TextBox_
    Friend WithEvents Label31 As Label
    Friend WithEvents dtRequestDate As TextBoxDatePast
    Friend WithEvents dtDateApprovedForDistro As TextBoxDatePast
    Friend WithEvents btnToggleHidden As Button_
    Friend WithEvents btnDGVFilter As Button_
    Friend WithEvents chkHideProject As CheckBox_
    Friend WithEvents rdoExtSampDesc As RadioButton
    Friend WithEvents rdoIntSampDesc As RadioButton
    Friend WithEvents Label34 As Label
    Friend WithEvents txtDistributiveDiagnosis As TextBox_
    Friend WithEvents btnTissuePrepModify As Button
    Friend WithEvents btnBrainRegionModify As Button
    Friend WithEvents Label33 As Label
    Friend WithEvents txtTissuePreparations As TextBox_
    Friend WithEvents Label32 As Label
    Friend WithEvents txtBrainRegions As TextBox_
    Friend WithEvents cmbBlackCaps As ComboBox_
    Friend WithEvents Label35 As Label
    Friend WithEvents intNumSamples As TextBoxInteger
    Friend WithEvents btnNBBURL As Button_
    Friend WithEvents Label36 As Label
    Friend WithEvents txtNBBURL As TextBox_
    Friend WithEvents Label37 As Label
    Friend WithEvents dtEstCompDt As TextBoxDatePast
    Friend WithEvents Label38 As Label
End Class
