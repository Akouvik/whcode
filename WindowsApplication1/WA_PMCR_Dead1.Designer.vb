<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WA_PMCR_Dead1
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnDEAD1Bottom = New DataWarehouse.Button_()
        Me.grpTestResults = New System.Windows.Forms.GroupBox()
        Me.btnTestResultsCancel = New DataWarehouse.Button_()
        Me.btnTestResultsEdit = New DataWarehouse.Button_()
        Me.btnTestResultsAdd = New DataWarehouse.Button_()
        Me.txtTestResultsResults = New DataWarehouse.TextBox_()
        Me.Label777 = New System.Windows.Forms.Label()
        Me.dtTestResultsDate = New DataWarehouse.TextBoxDatePast()
        Me.Label776 = New System.Windows.Forms.Label()
        Me.Label775 = New System.Windows.Forms.Label()
        Me.txtTestResultsTest = New DataWarehouse.TextBox_()
        Me.dgvTestResults = New DataWarehouse.dgvSingleRow()
        Me.grpSigMedHist = New System.Windows.Forms.GroupBox()
        Me.btnSigMedHxCancel = New DataWarehouse.Button_()
        Me.btnSigMedHxEdit = New DataWarehouse.Button_()
        Me.btnSigMedHxAdd = New DataWarehouse.Button_()
        Me.txtSigMedHxComplications = New DataWarehouse.TextBox_()
        Me.txtSigMedHxOutcome = New DataWarehouse.TextBox_()
        Me.txtSigMedHxTreatment = New DataWarehouse.TextBox_()
        Me.txtSigMedHxIllInj = New DataWarehouse.TextBox_()
        Me.txtSigMedHxAgeOnset = New DataWarehouse.TextBoxInteger()
        Me.txtSigMedHxAgeConc = New DataWarehouse.TextBoxInteger()
        Me.Label774 = New System.Windows.Forms.Label()
        Me.Label773 = New System.Windows.Forms.Label()
        Me.Label772 = New System.Windows.Forms.Label()
        Me.Label770 = New System.Windows.Forms.Label()
        Me.Label769 = New System.Windows.Forms.Label()
        Me.Label768 = New System.Windows.Forms.Label()
        Me.dgvSigMedHx = New DataWarehouse.dgvSingleRow()
        Me.grpNeuroIllness = New System.Windows.Forms.GroupBox()
        Me.cmbOthNeuroIllnessConf = New DataWarehouse.ComboBox_()
        Me.cmbNeurosurgeryConf = New DataWarehouse.ComboBox_()
        Me.cmbToxicMetabolicConf = New DataWarehouse.ComboBox_()
        Me.cmbSeizureDisorderConf = New DataWarehouse.ComboBox_()
        Me.cmbCNSInfectionConf = New DataWarehouse.ComboBox_()
        Me.cmbtCNSConf = New DataWarehouse.ComboBox_()
        Me.cmbHeadInjuryConf = New DataWarehouse.ComboBox_()
        Me.cmbOthCerebroConf = New DataWarehouse.ComboBox_()
        Me.cmbMajorCVAConf = New DataWarehouse.ComboBox_()
        Me.cmbOthMovDisConf = New DataWarehouse.ComboBox_()
        Me.cmbTardiveDyskConf = New DataWarehouse.ComboBox_()
        Me.chkOthNeuroIllness = New DataWarehouse.CheckBox_()
        Me.chkNeurosurgery = New DataWarehouse.CheckBox_()
        Me.chkToxicMetabolic = New DataWarehouse.CheckBox_()
        Me.chkSeizureDisorder = New DataWarehouse.CheckBox_()
        Me.chkCNSInfection = New DataWarehouse.CheckBox_()
        Me.chktCNS = New DataWarehouse.CheckBox_()
        Me.chkHeadInjury = New DataWarehouse.CheckBox_()
        Me.chkOtherCerebro = New DataWarehouse.CheckBox_()
        Me.chkMajorCVA = New DataWarehouse.CheckBox_()
        Me.chkOthMovDis = New DataWarehouse.CheckBox_()
        Me.chkTardiveDysk = New DataWarehouse.CheckBox_()
        Me.Label766 = New System.Windows.Forms.Label()
        Me.txtOthNeuroIllnessAgeOnset = New DataWarehouse.TextBoxInteger()
        Me.txtNeuroSurgeryAgeOnset = New DataWarehouse.TextBoxInteger()
        Me.txtToxicMetabolicAgeOnset = New DataWarehouse.TextBoxInteger()
        Me.txtSeizureDisorderAgeOnset = New DataWarehouse.TextBoxInteger()
        Me.txtCNSInfectionAgeOnset = New DataWarehouse.TextBoxInteger()
        Me.Label767 = New System.Windows.Forms.Label()
        Me.Label765 = New System.Windows.Forms.Label()
        Me.txttCNSAgeOnset = New DataWarehouse.TextBoxInteger()
        Me.txtHeadInjuryAgeOnset = New DataWarehouse.TextBoxInteger()
        Me.txtOthCerebroAgeOnset = New DataWarehouse.TextBoxInteger()
        Me.txtMajorCVAAgeOnset = New DataWarehouse.TextBoxInteger()
        Me.txtOthMovDisAgeOnset = New DataWarehouse.TextBoxInteger()
        Me.txtTardiveDyskAgeOnset = New DataWarehouse.TextBoxInteger()
        Me.Label764 = New System.Windows.Forms.Label()
        Me.grpPsychHosp = New System.Windows.Forms.GroupBox()
        Me.btnPsychHospCancel = New DataWarehouse.Button_()
        Me.btnPsychHospEdit = New DataWarehouse.Button_()
        Me.btnPsychHospAdd = New DataWarehouse.Button_()
        Me.Label763 = New System.Windows.Forms.Label()
        Me.txtPsychHospDischargeDx = New DataWarehouse.TextBox_()
        Me.dtPsychHospDischarged = New DataWarehouse.TextBoxDatePast()
        Me.Label762 = New System.Windows.Forms.Label()
        Me.dtPsychHospAdmitted = New DataWarehouse.TextBoxDatePast()
        Me.Label761 = New System.Windows.Forms.Label()
        Me.cmbPsychHospInstitution = New DataWarehouse.ComboBox_()
        Me.Label760 = New System.Windows.Forms.Label()
        Me.dgvPsychHosp = New DataWarehouse.dgvSingleRow()
        Me.grpDEAD = New System.Windows.Forms.GroupBox()
        Me.intMembAvail = New DataWarehouse.TextBoxInteger()
        Me.intMembInOMH = New DataWarehouse.TextBoxInteger()
        Me.lblNoRecord = New System.Windows.Forms.Label()
        Me.Label741 = New System.Windows.Forms.Label()
        Me.txtLastPsychDx = New DataWarehouse.TextBox_()
        Me.txtFamPsychHx = New DataWarehouse.TextBox_()
        Me.Label744 = New System.Windows.Forms.Label()
        Me.Label742 = New System.Windows.Forms.Label()
        Me.Label743 = New System.Windows.Forms.Label()
        Me.btnDEAD1Top = New DataWarehouse.Button_()
        Me.grpCognitiveDecline = New System.Windows.Forms.GroupBox()
        Me.txtTotalNumPsychHosp = New DataWarehouse.TextBoxNumeric()
        Me.Label759 = New System.Windows.Forms.Label()
        Me.txtLenLastPsychHosp = New DataWarehouse.TextBoxNumeric()
        Me.Label758 = New System.Windows.Forms.Label()
        Me.txtTotalYrsHosp = New DataWarehouse.TextBoxNumeric()
        Me.Label757 = New System.Windows.Forms.Label()
        Me.txtCogDecMore75 = New DataWarehouse.TextBoxNumeric()
        Me.Label755 = New System.Windows.Forms.Label()
        Me.txtCogDec6675 = New DataWarehouse.TextBoxNumeric()
        Me.Label756 = New System.Windows.Forms.Label()
        Me.txtCogDec5665 = New DataWarehouse.TextBoxNumeric()
        Me.Label753 = New System.Windows.Forms.Label()
        Me.txtCogDec4655 = New DataWarehouse.TextBoxNumeric()
        Me.Label754 = New System.Windows.Forms.Label()
        Me.txtCogDec2645 = New DataWarehouse.TextBoxNumeric()
        Me.Label752 = New System.Windows.Forms.Label()
        Me.txtCogDecLess26 = New DataWarehouse.TextBoxNumeric()
        Me.Label751 = New System.Windows.Forms.Label()
        Me.Label750 = New System.Windows.Forms.Label()
        Me.txtCogDecAgeOnset = New DataWarehouse.TextBoxInteger()
        Me.Label749 = New System.Windows.Forms.Label()
        Me.cmbCompCogFunct = New DataWarehouse.ComboBox_()
        Me.Label748 = New System.Windows.Forms.Label()
        Me.cmbDemDx = New DataWarehouse.ComboBox_()
        Me.Label747 = New System.Windows.Forms.Label()
        Me.dtEviPermCogimp = New DataWarehouse.TextBoxDatePast()
        Me.Label746 = New System.Windows.Forms.Label()
        Me.cmbEviPermCogImp = New DataWarehouse.ComboBox_()
        Me.Label745 = New System.Windows.Forms.Label()
        Me.grpTestResults.SuspendLayout()
        CType(Me.dgvTestResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSigMedHist.SuspendLayout()
        CType(Me.dgvSigMedHx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpNeuroIllness.SuspendLayout()
        Me.grpPsychHosp.SuspendLayout()
        CType(Me.dgvPsychHosp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDEAD.SuspendLayout()
        Me.grpCognitiveDecline.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDEAD1Bottom
        '
        Me.btnDEAD1Bottom.Location = New System.Drawing.Point(6, 1478)
        Me.btnDEAD1Bottom.Name = "btnDEAD1Bottom"
        Me.btnDEAD1Bottom.Size = New System.Drawing.Size(247, 23)
        Me.btnDEAD1Bottom.TabIndex = 183
        Me.btnDEAD1Bottom.Text = "Button_2"
        Me.btnDEAD1Bottom.UseVisualStyleBackColor = True
        '
        'grpTestResults
        '
        Me.grpTestResults.Controls.Add(Me.btnTestResultsCancel)
        Me.grpTestResults.Controls.Add(Me.btnTestResultsEdit)
        Me.grpTestResults.Controls.Add(Me.btnTestResultsAdd)
        Me.grpTestResults.Controls.Add(Me.txtTestResultsResults)
        Me.grpTestResults.Controls.Add(Me.Label777)
        Me.grpTestResults.Controls.Add(Me.dtTestResultsDate)
        Me.grpTestResults.Controls.Add(Me.Label776)
        Me.grpTestResults.Controls.Add(Me.Label775)
        Me.grpTestResults.Controls.Add(Me.txtTestResultsTest)
        Me.grpTestResults.Controls.Add(Me.dgvTestResults)
        Me.grpTestResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTestResults.Location = New System.Drawing.Point(6, 1212)
        Me.grpTestResults.Name = "grpTestResults"
        Me.grpTestResults.Size = New System.Drawing.Size(1033, 260)
        Me.grpTestResults.TabIndex = 175
        Me.grpTestResults.TabStop = False
        Me.grpTestResults.Text = "Test results: IQ, Neuropsych, etc."
        '
        'btnTestResultsCancel
        '
        Me.btnTestResultsCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTestResultsCancel.Location = New System.Drawing.Point(198, 232)
        Me.btnTestResultsCancel.Name = "btnTestResultsCancel"
        Me.btnTestResultsCancel.Size = New System.Drawing.Size(90, 23)
        Me.btnTestResultsCancel.TabIndex = 182
        Me.btnTestResultsCancel.Text = "Cancel"
        Me.btnTestResultsCancel.UseVisualStyleBackColor = True
        '
        'btnTestResultsEdit
        '
        Me.btnTestResultsEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTestResultsEdit.Location = New System.Drawing.Point(102, 232)
        Me.btnTestResultsEdit.Name = "btnTestResultsEdit"
        Me.btnTestResultsEdit.Size = New System.Drawing.Size(90, 23)
        Me.btnTestResultsEdit.TabIndex = 181
        Me.btnTestResultsEdit.Text = "Edit Record"
        Me.btnTestResultsEdit.UseVisualStyleBackColor = True
        '
        'btnTestResultsAdd
        '
        Me.btnTestResultsAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTestResultsAdd.Location = New System.Drawing.Point(6, 232)
        Me.btnTestResultsAdd.Name = "btnTestResultsAdd"
        Me.btnTestResultsAdd.Size = New System.Drawing.Size(90, 23)
        Me.btnTestResultsAdd.TabIndex = 180
        Me.btnTestResultsAdd.Text = "Add New"
        Me.btnTestResultsAdd.UseVisualStyleBackColor = True
        '
        'txtTestResultsResults
        '
        Me.txtTestResultsResults.Enabled = False
        Me.txtTestResultsResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTestResultsResults.Location = New System.Drawing.Point(185, 206)
        Me.txtTestResultsResults.Name = "txtTestResultsResults"
        Me.txtTestResultsResults.Size = New System.Drawing.Size(437, 20)
        Me.txtTestResultsResults.TabIndex = 179
        '
        'Label777
        '
        Me.Label777.AutoSize = True
        Me.Label777.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label777.Location = New System.Drawing.Point(182, 190)
        Me.Label777.Name = "Label777"
        Me.Label777.Size = New System.Drawing.Size(42, 13)
        Me.Label777.TabIndex = 7
        Me.Label777.Text = "Results"
        '
        'dtTestResultsDate
        '
        Me.dtTestResultsDate.Enabled = False
        Me.dtTestResultsDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTestResultsDate.Location = New System.Drawing.Point(112, 206)
        Me.dtTestResultsDate.Mask = "00/00/0000"
        Me.dtTestResultsDate.Name = "dtTestResultsDate"
        Me.dtTestResultsDate.Size = New System.Drawing.Size(67, 20)
        Me.dtTestResultsDate.TabIndex = 178
        Me.dtTestResultsDate.ValidatingType = GetType(Date)
        '
        'Label776
        '
        Me.Label776.AutoSize = True
        Me.Label776.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label776.Location = New System.Drawing.Point(109, 190)
        Me.Label776.Name = "Label776"
        Me.Label776.Size = New System.Drawing.Size(30, 13)
        Me.Label776.TabIndex = 5
        Me.Label776.Text = "Date"
        '
        'Label775
        '
        Me.Label775.AutoSize = True
        Me.Label775.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label775.Location = New System.Drawing.Point(3, 190)
        Me.Label775.Name = "Label775"
        Me.Label775.Size = New System.Drawing.Size(28, 13)
        Me.Label775.TabIndex = 4
        Me.Label775.Text = "Test"
        '
        'txtTestResultsTest
        '
        Me.txtTestResultsTest.Enabled = False
        Me.txtTestResultsTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTestResultsTest.Location = New System.Drawing.Point(6, 206)
        Me.txtTestResultsTest.Name = "txtTestResultsTest"
        Me.txtTestResultsTest.Size = New System.Drawing.Size(100, 20)
        Me.txtTestResultsTest.TabIndex = 177
        '
        'dgvTestResults
        '
        Me.dgvTestResults.AllowUserToAddRows = False
        Me.dgvTestResults.AllowUserToDeleteRows = False
        Me.dgvTestResults.AllowUserToOrderColumns = True
        Me.dgvTestResults.AllowUserToResizeRows = False
        Me.dgvTestResults.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dgvTestResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTestResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTestResults.BackgroundColor = System.Drawing.Color.Tan
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTestResults.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTestResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTestResults.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTestResults.GridColor = System.Drawing.Color.Linen
        Me.dgvTestResults.Location = New System.Drawing.Point(6, 19)
        Me.dgvTestResults.MultiSelect = False
        Me.dgvTestResults.Name = "dgvTestResults"
        Me.dgvTestResults.ReadOnly = True
        Me.dgvTestResults.RowHeadersVisible = False
        Me.dgvTestResults.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.dgvTestResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTestResults.Size = New System.Drawing.Size(1021, 168)
        Me.dgvTestResults.TabIndex = 176
        '
        'grpSigMedHist
        '
        Me.grpSigMedHist.Controls.Add(Me.btnSigMedHxCancel)
        Me.grpSigMedHist.Controls.Add(Me.btnSigMedHxEdit)
        Me.grpSigMedHist.Controls.Add(Me.btnSigMedHxAdd)
        Me.grpSigMedHist.Controls.Add(Me.txtSigMedHxComplications)
        Me.grpSigMedHist.Controls.Add(Me.txtSigMedHxOutcome)
        Me.grpSigMedHist.Controls.Add(Me.txtSigMedHxTreatment)
        Me.grpSigMedHist.Controls.Add(Me.txtSigMedHxIllInj)
        Me.grpSigMedHist.Controls.Add(Me.txtSigMedHxAgeOnset)
        Me.grpSigMedHist.Controls.Add(Me.txtSigMedHxAgeConc)
        Me.grpSigMedHist.Controls.Add(Me.Label774)
        Me.grpSigMedHist.Controls.Add(Me.Label773)
        Me.grpSigMedHist.Controls.Add(Me.Label772)
        Me.grpSigMedHist.Controls.Add(Me.Label770)
        Me.grpSigMedHist.Controls.Add(Me.Label769)
        Me.grpSigMedHist.Controls.Add(Me.Label768)
        Me.grpSigMedHist.Controls.Add(Me.dgvSigMedHx)
        Me.grpSigMedHist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSigMedHist.Location = New System.Drawing.Point(6, 946)
        Me.grpSigMedHist.Name = "grpSigMedHist"
        Me.grpSigMedHist.Size = New System.Drawing.Size(1033, 260)
        Me.grpSigMedHist.TabIndex = 164
        Me.grpSigMedHist.TabStop = False
        Me.grpSigMedHist.Text = "Significant Medical History"
        '
        'btnSigMedHxCancel
        '
        Me.btnSigMedHxCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSigMedHxCancel.Location = New System.Drawing.Point(198, 232)
        Me.btnSigMedHxCancel.Name = "btnSigMedHxCancel"
        Me.btnSigMedHxCancel.Size = New System.Drawing.Size(90, 23)
        Me.btnSigMedHxCancel.TabIndex = 174
        Me.btnSigMedHxCancel.Text = "Cancel"
        Me.btnSigMedHxCancel.UseVisualStyleBackColor = True
        '
        'btnSigMedHxEdit
        '
        Me.btnSigMedHxEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSigMedHxEdit.Location = New System.Drawing.Point(102, 232)
        Me.btnSigMedHxEdit.Name = "btnSigMedHxEdit"
        Me.btnSigMedHxEdit.Size = New System.Drawing.Size(90, 23)
        Me.btnSigMedHxEdit.TabIndex = 173
        Me.btnSigMedHxEdit.Text = "Edit Record"
        Me.btnSigMedHxEdit.UseVisualStyleBackColor = True
        '
        'btnSigMedHxAdd
        '
        Me.btnSigMedHxAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSigMedHxAdd.Location = New System.Drawing.Point(6, 232)
        Me.btnSigMedHxAdd.Name = "btnSigMedHxAdd"
        Me.btnSigMedHxAdd.Size = New System.Drawing.Size(90, 23)
        Me.btnSigMedHxAdd.TabIndex = 172
        Me.btnSigMedHxAdd.Text = "Add New"
        Me.btnSigMedHxAdd.UseVisualStyleBackColor = True
        '
        'txtSigMedHxComplications
        '
        Me.txtSigMedHxComplications.Enabled = False
        Me.txtSigMedHxComplications.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSigMedHxComplications.Location = New System.Drawing.Point(830, 206)
        Me.txtSigMedHxComplications.Name = "txtSigMedHxComplications"
        Me.txtSigMedHxComplications.Size = New System.Drawing.Size(200, 20)
        Me.txtSigMedHxComplications.TabIndex = 171
        '
        'txtSigMedHxOutcome
        '
        Me.txtSigMedHxOutcome.Enabled = False
        Me.txtSigMedHxOutcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSigMedHxOutcome.Location = New System.Drawing.Point(625, 206)
        Me.txtSigMedHxOutcome.Name = "txtSigMedHxOutcome"
        Me.txtSigMedHxOutcome.Size = New System.Drawing.Size(200, 20)
        Me.txtSigMedHxOutcome.TabIndex = 170
        '
        'txtSigMedHxTreatment
        '
        Me.txtSigMedHxTreatment.Enabled = False
        Me.txtSigMedHxTreatment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSigMedHxTreatment.Location = New System.Drawing.Point(420, 206)
        Me.txtSigMedHxTreatment.Name = "txtSigMedHxTreatment"
        Me.txtSigMedHxTreatment.Size = New System.Drawing.Size(200, 20)
        Me.txtSigMedHxTreatment.TabIndex = 169
        '
        'txtSigMedHxIllInj
        '
        Me.txtSigMedHxIllInj.Enabled = False
        Me.txtSigMedHxIllInj.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSigMedHxIllInj.Location = New System.Drawing.Point(6, 206)
        Me.txtSigMedHxIllInj.Name = "txtSigMedHxIllInj"
        Me.txtSigMedHxIllInj.Size = New System.Drawing.Size(219, 20)
        Me.txtSigMedHxIllInj.TabIndex = 166
        '
        'txtSigMedHxAgeOnset
        '
        Me.txtSigMedHxAgeOnset.Enabled = False
        Me.txtSigMedHxAgeOnset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSigMedHxAgeOnset.Location = New System.Drawing.Point(230, 206)
        Me.txtSigMedHxAgeOnset.Name = "txtSigMedHxAgeOnset"
        Me.txtSigMedHxAgeOnset.Size = New System.Drawing.Size(90, 20)
        Me.txtSigMedHxAgeOnset.TabIndex = 167
        '
        'txtSigMedHxAgeConc
        '
        Me.txtSigMedHxAgeConc.Enabled = False
        Me.txtSigMedHxAgeConc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSigMedHxAgeConc.Location = New System.Drawing.Point(325, 206)
        Me.txtSigMedHxAgeConc.Name = "txtSigMedHxAgeConc"
        Me.txtSigMedHxAgeConc.Size = New System.Drawing.Size(90, 20)
        Me.txtSigMedHxAgeConc.TabIndex = 168
        '
        'Label774
        '
        Me.Label774.AutoSize = True
        Me.Label774.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label774.Location = New System.Drawing.Point(827, 190)
        Me.Label774.Name = "Label774"
        Me.Label774.Size = New System.Drawing.Size(72, 13)
        Me.Label774.TabIndex = 7
        Me.Label774.Text = "Complications"
        '
        'Label773
        '
        Me.Label773.AutoSize = True
        Me.Label773.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label773.Location = New System.Drawing.Point(622, 190)
        Me.Label773.Name = "Label773"
        Me.Label773.Size = New System.Drawing.Size(50, 13)
        Me.Label773.TabIndex = 6
        Me.Label773.Text = "Outcome"
        '
        'Label772
        '
        Me.Label772.AutoSize = True
        Me.Label772.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label772.Location = New System.Drawing.Point(417, 190)
        Me.Label772.Name = "Label772"
        Me.Label772.Size = New System.Drawing.Size(55, 13)
        Me.Label772.TabIndex = 5
        Me.Label772.Text = "Treatment"
        '
        'Label770
        '
        Me.Label770.AutoSize = True
        Me.Label770.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label770.Location = New System.Drawing.Point(322, 190)
        Me.Label770.Name = "Label770"
        Me.Label770.Size = New System.Drawing.Size(93, 13)
        Me.Label770.TabIndex = 4
        Me.Label770.Text = "Age of Conclusion"
        '
        'Label769
        '
        Me.Label769.AutoSize = True
        Me.Label769.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label769.Location = New System.Drawing.Point(227, 190)
        Me.Label769.Name = "Label769"
        Me.Label769.Size = New System.Drawing.Size(69, 13)
        Me.Label769.TabIndex = 3
        Me.Label769.Text = "Age of Onset"
        '
        'Label768
        '
        Me.Label768.AutoSize = True
        Me.Label768.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label768.Location = New System.Drawing.Point(3, 190)
        Me.Label768.Name = "Label768"
        Me.Label768.Size = New System.Drawing.Size(66, 13)
        Me.Label768.TabIndex = 2
        Me.Label768.Text = "Illness/Injury"
        '
        'dgvSigMedHx
        '
        Me.dgvSigMedHx.AllowUserToAddRows = False
        Me.dgvSigMedHx.AllowUserToDeleteRows = False
        Me.dgvSigMedHx.AllowUserToOrderColumns = True
        Me.dgvSigMedHx.AllowUserToResizeRows = False
        Me.dgvSigMedHx.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dgvSigMedHx.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvSigMedHx.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvSigMedHx.BackgroundColor = System.Drawing.Color.Tan
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSigMedHx.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSigMedHx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSigMedHx.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvSigMedHx.GridColor = System.Drawing.Color.Linen
        Me.dgvSigMedHx.Location = New System.Drawing.Point(6, 19)
        Me.dgvSigMedHx.MultiSelect = False
        Me.dgvSigMedHx.Name = "dgvSigMedHx"
        Me.dgvSigMedHx.ReadOnly = True
        Me.dgvSigMedHx.RowHeadersVisible = False
        Me.dgvSigMedHx.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.dgvSigMedHx.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSigMedHx.Size = New System.Drawing.Size(1021, 168)
        Me.dgvSigMedHx.TabIndex = 165
        '
        'grpNeuroIllness
        '
        Me.grpNeuroIllness.Controls.Add(Me.cmbOthNeuroIllnessConf)
        Me.grpNeuroIllness.Controls.Add(Me.cmbNeurosurgeryConf)
        Me.grpNeuroIllness.Controls.Add(Me.cmbToxicMetabolicConf)
        Me.grpNeuroIllness.Controls.Add(Me.cmbSeizureDisorderConf)
        Me.grpNeuroIllness.Controls.Add(Me.cmbCNSInfectionConf)
        Me.grpNeuroIllness.Controls.Add(Me.cmbtCNSConf)
        Me.grpNeuroIllness.Controls.Add(Me.cmbHeadInjuryConf)
        Me.grpNeuroIllness.Controls.Add(Me.cmbOthCerebroConf)
        Me.grpNeuroIllness.Controls.Add(Me.cmbMajorCVAConf)
        Me.grpNeuroIllness.Controls.Add(Me.cmbOthMovDisConf)
        Me.grpNeuroIllness.Controls.Add(Me.cmbTardiveDyskConf)
        Me.grpNeuroIllness.Controls.Add(Me.chkOthNeuroIllness)
        Me.grpNeuroIllness.Controls.Add(Me.chkNeurosurgery)
        Me.grpNeuroIllness.Controls.Add(Me.chkToxicMetabolic)
        Me.grpNeuroIllness.Controls.Add(Me.chkSeizureDisorder)
        Me.grpNeuroIllness.Controls.Add(Me.chkCNSInfection)
        Me.grpNeuroIllness.Controls.Add(Me.chktCNS)
        Me.grpNeuroIllness.Controls.Add(Me.chkHeadInjury)
        Me.grpNeuroIllness.Controls.Add(Me.chkOtherCerebro)
        Me.grpNeuroIllness.Controls.Add(Me.chkMajorCVA)
        Me.grpNeuroIllness.Controls.Add(Me.chkOthMovDis)
        Me.grpNeuroIllness.Controls.Add(Me.chkTardiveDysk)
        Me.grpNeuroIllness.Controls.Add(Me.Label766)
        Me.grpNeuroIllness.Controls.Add(Me.txtOthNeuroIllnessAgeOnset)
        Me.grpNeuroIllness.Controls.Add(Me.txtNeuroSurgeryAgeOnset)
        Me.grpNeuroIllness.Controls.Add(Me.txtToxicMetabolicAgeOnset)
        Me.grpNeuroIllness.Controls.Add(Me.txtSeizureDisorderAgeOnset)
        Me.grpNeuroIllness.Controls.Add(Me.txtCNSInfectionAgeOnset)
        Me.grpNeuroIllness.Controls.Add(Me.Label767)
        Me.grpNeuroIllness.Controls.Add(Me.Label765)
        Me.grpNeuroIllness.Controls.Add(Me.txttCNSAgeOnset)
        Me.grpNeuroIllness.Controls.Add(Me.txtHeadInjuryAgeOnset)
        Me.grpNeuroIllness.Controls.Add(Me.txtOthCerebroAgeOnset)
        Me.grpNeuroIllness.Controls.Add(Me.txtMajorCVAAgeOnset)
        Me.grpNeuroIllness.Controls.Add(Me.txtOthMovDisAgeOnset)
        Me.grpNeuroIllness.Controls.Add(Me.txtTardiveDyskAgeOnset)
        Me.grpNeuroIllness.Controls.Add(Me.Label764)
        Me.grpNeuroIllness.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpNeuroIllness.Location = New System.Drawing.Point(6, 769)
        Me.grpNeuroIllness.Name = "grpNeuroIllness"
        Me.grpNeuroIllness.Size = New System.Drawing.Size(1033, 171)
        Me.grpNeuroIllness.TabIndex = 130
        Me.grpNeuroIllness.TabStop = False
        Me.grpNeuroIllness.Text = "Neurological Illness"
        '
        'cmbOthNeuroIllnessConf
        '
        Me.cmbOthNeuroIllnessConf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbOthNeuroIllnessConf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbOthNeuroIllnessConf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOthNeuroIllnessConf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOthNeuroIllnessConf.FormattingEnabled = True
        Me.cmbOthNeuroIllnessConf.Location = New System.Drawing.Point(630, 124)
        Me.cmbOthNeuroIllnessConf.Name = "cmbOthNeuroIllnessConf"
        Me.cmbOthNeuroIllnessConf.Size = New System.Drawing.Size(121, 21)
        Me.cmbOthNeuroIllnessConf.TabIndex = 163
        '
        'cmbNeurosurgeryConf
        '
        Me.cmbNeurosurgeryConf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbNeurosurgeryConf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbNeurosurgeryConf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNeurosurgeryConf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNeurosurgeryConf.FormattingEnabled = True
        Me.cmbNeurosurgeryConf.Location = New System.Drawing.Point(630, 101)
        Me.cmbNeurosurgeryConf.Name = "cmbNeurosurgeryConf"
        Me.cmbNeurosurgeryConf.Size = New System.Drawing.Size(121, 21)
        Me.cmbNeurosurgeryConf.TabIndex = 160
        '
        'cmbToxicMetabolicConf
        '
        Me.cmbToxicMetabolicConf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbToxicMetabolicConf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbToxicMetabolicConf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbToxicMetabolicConf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbToxicMetabolicConf.FormattingEnabled = True
        Me.cmbToxicMetabolicConf.Location = New System.Drawing.Point(630, 78)
        Me.cmbToxicMetabolicConf.Name = "cmbToxicMetabolicConf"
        Me.cmbToxicMetabolicConf.Size = New System.Drawing.Size(121, 21)
        Me.cmbToxicMetabolicConf.TabIndex = 157
        '
        'cmbSeizureDisorderConf
        '
        Me.cmbSeizureDisorderConf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSeizureDisorderConf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSeizureDisorderConf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSeizureDisorderConf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSeizureDisorderConf.FormattingEnabled = True
        Me.cmbSeizureDisorderConf.Location = New System.Drawing.Point(630, 55)
        Me.cmbSeizureDisorderConf.Name = "cmbSeizureDisorderConf"
        Me.cmbSeizureDisorderConf.Size = New System.Drawing.Size(121, 21)
        Me.cmbSeizureDisorderConf.TabIndex = 154
        '
        'cmbCNSInfectionConf
        '
        Me.cmbCNSInfectionConf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCNSInfectionConf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCNSInfectionConf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCNSInfectionConf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCNSInfectionConf.FormattingEnabled = True
        Me.cmbCNSInfectionConf.Location = New System.Drawing.Point(630, 32)
        Me.cmbCNSInfectionConf.Name = "cmbCNSInfectionConf"
        Me.cmbCNSInfectionConf.Size = New System.Drawing.Size(121, 21)
        Me.cmbCNSInfectionConf.TabIndex = 151
        '
        'cmbtCNSConf
        '
        Me.cmbtCNSConf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbtCNSConf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbtCNSConf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtCNSConf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtCNSConf.FormattingEnabled = True
        Me.cmbtCNSConf.Location = New System.Drawing.Point(227, 147)
        Me.cmbtCNSConf.Name = "cmbtCNSConf"
        Me.cmbtCNSConf.Size = New System.Drawing.Size(121, 21)
        Me.cmbtCNSConf.TabIndex = 148
        '
        'cmbHeadInjuryConf
        '
        Me.cmbHeadInjuryConf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbHeadInjuryConf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbHeadInjuryConf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHeadInjuryConf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbHeadInjuryConf.FormattingEnabled = True
        Me.cmbHeadInjuryConf.Location = New System.Drawing.Point(227, 124)
        Me.cmbHeadInjuryConf.Name = "cmbHeadInjuryConf"
        Me.cmbHeadInjuryConf.Size = New System.Drawing.Size(121, 21)
        Me.cmbHeadInjuryConf.TabIndex = 145
        '
        'cmbOthCerebroConf
        '
        Me.cmbOthCerebroConf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbOthCerebroConf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbOthCerebroConf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOthCerebroConf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOthCerebroConf.FormattingEnabled = True
        Me.cmbOthCerebroConf.Location = New System.Drawing.Point(227, 101)
        Me.cmbOthCerebroConf.Name = "cmbOthCerebroConf"
        Me.cmbOthCerebroConf.Size = New System.Drawing.Size(121, 21)
        Me.cmbOthCerebroConf.TabIndex = 142
        '
        'cmbMajorCVAConf
        '
        Me.cmbMajorCVAConf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbMajorCVAConf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMajorCVAConf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMajorCVAConf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMajorCVAConf.FormattingEnabled = True
        Me.cmbMajorCVAConf.Location = New System.Drawing.Point(227, 78)
        Me.cmbMajorCVAConf.Name = "cmbMajorCVAConf"
        Me.cmbMajorCVAConf.Size = New System.Drawing.Size(121, 21)
        Me.cmbMajorCVAConf.TabIndex = 139
        '
        'cmbOthMovDisConf
        '
        Me.cmbOthMovDisConf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbOthMovDisConf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbOthMovDisConf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOthMovDisConf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOthMovDisConf.FormattingEnabled = True
        Me.cmbOthMovDisConf.Location = New System.Drawing.Point(227, 55)
        Me.cmbOthMovDisConf.Name = "cmbOthMovDisConf"
        Me.cmbOthMovDisConf.Size = New System.Drawing.Size(121, 21)
        Me.cmbOthMovDisConf.TabIndex = 136
        '
        'cmbTardiveDyskConf
        '
        Me.cmbTardiveDyskConf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTardiveDyskConf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTardiveDyskConf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTardiveDyskConf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTardiveDyskConf.FormattingEnabled = True
        Me.cmbTardiveDyskConf.Location = New System.Drawing.Point(227, 32)
        Me.cmbTardiveDyskConf.Name = "cmbTardiveDyskConf"
        Me.cmbTardiveDyskConf.Size = New System.Drawing.Size(121, 21)
        Me.cmbTardiveDyskConf.TabIndex = 133
        '
        'chkOthNeuroIllness
        '
        Me.chkOthNeuroIllness.AutoSize = True
        Me.chkOthNeuroIllness.BackColor = System.Drawing.Color.Tan
        Me.chkOthNeuroIllness.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkOthNeuroIllness.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOthNeuroIllness.Location = New System.Drawing.Point(410, 126)
        Me.chkOthNeuroIllness.Name = "chkOthNeuroIllness"
        Me.chkOthNeuroIllness.Size = New System.Drawing.Size(140, 17)
        Me.chkOthNeuroIllness.TabIndex = 161
        Me.chkOthNeuroIllness.Text = "Other neurological illness"
        Me.chkOthNeuroIllness.UseVisualStyleBackColor = True
        '
        'chkNeurosurgery
        '
        Me.chkNeurosurgery.AutoSize = True
        Me.chkNeurosurgery.BackColor = System.Drawing.Color.Tan
        Me.chkNeurosurgery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkNeurosurgery.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNeurosurgery.Location = New System.Drawing.Point(410, 103)
        Me.chkNeurosurgery.Name = "chkNeurosurgery"
        Me.chkNeurosurgery.Size = New System.Drawing.Size(86, 17)
        Me.chkNeurosurgery.TabIndex = 158
        Me.chkNeurosurgery.Text = "Neurosurgery"
        Me.chkNeurosurgery.UseVisualStyleBackColor = True
        '
        'chkToxicMetabolic
        '
        Me.chkToxicMetabolic.AutoSize = True
        Me.chkToxicMetabolic.BackColor = System.Drawing.Color.Tan
        Me.chkToxicMetabolic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkToxicMetabolic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkToxicMetabolic.Location = New System.Drawing.Point(410, 80)
        Me.chkToxicMetabolic.Name = "chkToxicMetabolic"
        Me.chkToxicMetabolic.Size = New System.Drawing.Size(100, 17)
        Me.chkToxicMetabolic.TabIndex = 155
        Me.chkToxicMetabolic.Text = "Toxic/Metabolic"
        Me.chkToxicMetabolic.UseVisualStyleBackColor = True
        '
        'chkSeizureDisorder
        '
        Me.chkSeizureDisorder.AutoSize = True
        Me.chkSeizureDisorder.BackColor = System.Drawing.Color.Tan
        Me.chkSeizureDisorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkSeizureDisorder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeizureDisorder.Location = New System.Drawing.Point(410, 57)
        Me.chkSeizureDisorder.Name = "chkSeizureDisorder"
        Me.chkSeizureDisorder.Size = New System.Drawing.Size(98, 17)
        Me.chkSeizureDisorder.TabIndex = 152
        Me.chkSeizureDisorder.Text = "Seizure disorder"
        Me.chkSeizureDisorder.UseVisualStyleBackColor = True
        '
        'chkCNSInfection
        '
        Me.chkCNSInfection.AutoSize = True
        Me.chkCNSInfection.BackColor = System.Drawing.Color.Tan
        Me.chkCNSInfection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkCNSInfection.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCNSInfection.Location = New System.Drawing.Point(410, 34)
        Me.chkCNSInfection.Name = "chkCNSInfection"
        Me.chkCNSInfection.Size = New System.Drawing.Size(88, 17)
        Me.chkCNSInfection.TabIndex = 149
        Me.chkCNSInfection.Text = "CNS infection"
        Me.chkCNSInfection.UseVisualStyleBackColor = True
        '
        'chktCNS
        '
        Me.chktCNS.AutoSize = True
        Me.chktCNS.BackColor = System.Drawing.Color.Tan
        Me.chktCNS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chktCNS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chktCNS.Location = New System.Drawing.Point(6, 149)
        Me.chktCNS.Name = "chktCNS"
        Me.chktCNS.Size = New System.Drawing.Size(93, 17)
        Me.chktCNS.TabIndex = 146
        Me.chktCNS.Text = "CNS neoplasm"
        Me.chktCNS.UseVisualStyleBackColor = True
        '
        'chkHeadInjury
        '
        Me.chkHeadInjury.AutoSize = True
        Me.chkHeadInjury.BackColor = System.Drawing.Color.Tan
        Me.chkHeadInjury.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkHeadInjury.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHeadInjury.Location = New System.Drawing.Point(6, 126)
        Me.chkHeadInjury.Name = "chkHeadInjury"
        Me.chkHeadInjury.Size = New System.Drawing.Size(76, 17)
        Me.chkHeadInjury.TabIndex = 143
        Me.chkHeadInjury.Text = "Head injury"
        Me.chkHeadInjury.UseVisualStyleBackColor = True
        '
        'chkOtherCerebro
        '
        Me.chkOtherCerebro.AutoSize = True
        Me.chkOtherCerebro.BackColor = System.Drawing.Color.Tan
        Me.chkOtherCerebro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkOtherCerebro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOtherCerebro.Location = New System.Drawing.Point(6, 103)
        Me.chkOtherCerebro.Name = "chkOtherCerebro"
        Me.chkOtherCerebro.Size = New System.Drawing.Size(128, 17)
        Me.chkOtherCerebro.TabIndex = 140
        Me.chkOtherCerebro.Text = "Other cerebrovascular"
        Me.chkOtherCerebro.UseVisualStyleBackColor = True
        '
        'chkMajorCVA
        '
        Me.chkMajorCVA.AutoSize = True
        Me.chkMajorCVA.BackColor = System.Drawing.Color.Tan
        Me.chkMajorCVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkMajorCVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMajorCVA.Location = New System.Drawing.Point(6, 80)
        Me.chkMajorCVA.Name = "chkMajorCVA"
        Me.chkMajorCVA.Size = New System.Drawing.Size(73, 17)
        Me.chkMajorCVA.TabIndex = 137
        Me.chkMajorCVA.Text = "Major CVA"
        Me.chkMajorCVA.UseVisualStyleBackColor = True
        '
        'chkOthMovDis
        '
        Me.chkOthMovDis.AutoSize = True
        Me.chkOthMovDis.BackColor = System.Drawing.Color.Tan
        Me.chkOthMovDis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkOthMovDis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOthMovDis.Location = New System.Drawing.Point(6, 57)
        Me.chkOthMovDis.Name = "chkOthMovDis"
        Me.chkOthMovDis.Size = New System.Drawing.Size(141, 17)
        Me.chkOthMovDis.TabIndex = 134
        Me.chkOthMovDis.Text = "Other movement disorder"
        Me.chkOthMovDis.UseVisualStyleBackColor = True
        '
        'chkTardiveDysk
        '
        Me.chkTardiveDysk.AutoSize = True
        Me.chkTardiveDysk.BackColor = System.Drawing.Color.Tan
        Me.chkTardiveDysk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkTardiveDysk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTardiveDysk.Location = New System.Drawing.Point(6, 34)
        Me.chkTardiveDysk.Name = "chkTardiveDysk"
        Me.chkTardiveDysk.Size = New System.Drawing.Size(113, 17)
        Me.chkTardiveDysk.TabIndex = 131
        Me.chkTardiveDysk.Text = "Tardive Dyskinesia"
        Me.chkTardiveDysk.UseVisualStyleBackColor = True
        '
        'Label766
        '
        Me.Label766.AutoSize = True
        Me.Label766.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label766.Location = New System.Drawing.Point(630, 16)
        Me.Label766.Name = "Label766"
        Me.Label766.Size = New System.Drawing.Size(61, 13)
        Me.Label766.TabIndex = 31
        Me.Label766.Text = "Confidence"
        '
        'txtOthNeuroIllnessAgeOnset
        '
        Me.txtOthNeuroIllnessAgeOnset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOthNeuroIllnessAgeOnset.Location = New System.Drawing.Point(558, 124)
        Me.txtOthNeuroIllnessAgeOnset.Name = "txtOthNeuroIllnessAgeOnset"
        Me.txtOthNeuroIllnessAgeOnset.Size = New System.Drawing.Size(66, 20)
        Me.txtOthNeuroIllnessAgeOnset.TabIndex = 162
        '
        'txtNeuroSurgeryAgeOnset
        '
        Me.txtNeuroSurgeryAgeOnset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNeuroSurgeryAgeOnset.Location = New System.Drawing.Point(558, 101)
        Me.txtNeuroSurgeryAgeOnset.Name = "txtNeuroSurgeryAgeOnset"
        Me.txtNeuroSurgeryAgeOnset.Size = New System.Drawing.Size(66, 20)
        Me.txtNeuroSurgeryAgeOnset.TabIndex = 159
        '
        'txtToxicMetabolicAgeOnset
        '
        Me.txtToxicMetabolicAgeOnset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToxicMetabolicAgeOnset.Location = New System.Drawing.Point(558, 78)
        Me.txtToxicMetabolicAgeOnset.Name = "txtToxicMetabolicAgeOnset"
        Me.txtToxicMetabolicAgeOnset.Size = New System.Drawing.Size(66, 20)
        Me.txtToxicMetabolicAgeOnset.TabIndex = 156
        '
        'txtSeizureDisorderAgeOnset
        '
        Me.txtSeizureDisorderAgeOnset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeizureDisorderAgeOnset.Location = New System.Drawing.Point(558, 55)
        Me.txtSeizureDisorderAgeOnset.Name = "txtSeizureDisorderAgeOnset"
        Me.txtSeizureDisorderAgeOnset.Size = New System.Drawing.Size(66, 20)
        Me.txtSeizureDisorderAgeOnset.TabIndex = 153
        '
        'txtCNSInfectionAgeOnset
        '
        Me.txtCNSInfectionAgeOnset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCNSInfectionAgeOnset.Location = New System.Drawing.Point(558, 32)
        Me.txtCNSInfectionAgeOnset.Name = "txtCNSInfectionAgeOnset"
        Me.txtCNSInfectionAgeOnset.Size = New System.Drawing.Size(66, 20)
        Me.txtCNSInfectionAgeOnset.TabIndex = 150
        '
        'Label767
        '
        Me.Label767.AutoSize = True
        Me.Label767.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label767.Location = New System.Drawing.Point(555, 16)
        Me.Label767.Name = "Label767"
        Me.Label767.Size = New System.Drawing.Size(69, 13)
        Me.Label767.TabIndex = 25
        Me.Label767.Text = "Age of Onset"
        '
        'Label765
        '
        Me.Label765.AutoSize = True
        Me.Label765.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label765.Location = New System.Drawing.Point(227, 16)
        Me.Label765.Name = "Label765"
        Me.Label765.Size = New System.Drawing.Size(61, 13)
        Me.Label765.TabIndex = 18
        Me.Label765.Text = "Confidence"
        '
        'txttCNSAgeOnset
        '
        Me.txttCNSAgeOnset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttCNSAgeOnset.Location = New System.Drawing.Point(155, 147)
        Me.txttCNSAgeOnset.Name = "txttCNSAgeOnset"
        Me.txttCNSAgeOnset.Size = New System.Drawing.Size(66, 20)
        Me.txttCNSAgeOnset.TabIndex = 147
        '
        'txtHeadInjuryAgeOnset
        '
        Me.txtHeadInjuryAgeOnset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeadInjuryAgeOnset.Location = New System.Drawing.Point(155, 124)
        Me.txtHeadInjuryAgeOnset.Name = "txtHeadInjuryAgeOnset"
        Me.txtHeadInjuryAgeOnset.Size = New System.Drawing.Size(66, 20)
        Me.txtHeadInjuryAgeOnset.TabIndex = 144
        '
        'txtOthCerebroAgeOnset
        '
        Me.txtOthCerebroAgeOnset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOthCerebroAgeOnset.Location = New System.Drawing.Point(155, 101)
        Me.txtOthCerebroAgeOnset.Name = "txtOthCerebroAgeOnset"
        Me.txtOthCerebroAgeOnset.Size = New System.Drawing.Size(66, 20)
        Me.txtOthCerebroAgeOnset.TabIndex = 141
        '
        'txtMajorCVAAgeOnset
        '
        Me.txtMajorCVAAgeOnset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMajorCVAAgeOnset.Location = New System.Drawing.Point(155, 78)
        Me.txtMajorCVAAgeOnset.Name = "txtMajorCVAAgeOnset"
        Me.txtMajorCVAAgeOnset.Size = New System.Drawing.Size(66, 20)
        Me.txtMajorCVAAgeOnset.TabIndex = 138
        '
        'txtOthMovDisAgeOnset
        '
        Me.txtOthMovDisAgeOnset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOthMovDisAgeOnset.Location = New System.Drawing.Point(155, 55)
        Me.txtOthMovDisAgeOnset.Name = "txtOthMovDisAgeOnset"
        Me.txtOthMovDisAgeOnset.Size = New System.Drawing.Size(66, 20)
        Me.txtOthMovDisAgeOnset.TabIndex = 135
        '
        'txtTardiveDyskAgeOnset
        '
        Me.txtTardiveDyskAgeOnset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTardiveDyskAgeOnset.Location = New System.Drawing.Point(155, 32)
        Me.txtTardiveDyskAgeOnset.Name = "txtTardiveDyskAgeOnset"
        Me.txtTardiveDyskAgeOnset.Size = New System.Drawing.Size(66, 20)
        Me.txtTardiveDyskAgeOnset.TabIndex = 132
        '
        'Label764
        '
        Me.Label764.AutoSize = True
        Me.Label764.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label764.Location = New System.Drawing.Point(152, 16)
        Me.Label764.Name = "Label764"
        Me.Label764.Size = New System.Drawing.Size(69, 13)
        Me.Label764.TabIndex = 11
        Me.Label764.Text = "Age of Onset"
        '
        'grpPsychHosp
        '
        Me.grpPsychHosp.Controls.Add(Me.btnPsychHospCancel)
        Me.grpPsychHosp.Controls.Add(Me.btnPsychHospEdit)
        Me.grpPsychHosp.Controls.Add(Me.btnPsychHospAdd)
        Me.grpPsychHosp.Controls.Add(Me.Label763)
        Me.grpPsychHosp.Controls.Add(Me.txtPsychHospDischargeDx)
        Me.grpPsychHosp.Controls.Add(Me.dtPsychHospDischarged)
        Me.grpPsychHosp.Controls.Add(Me.Label762)
        Me.grpPsychHosp.Controls.Add(Me.dtPsychHospAdmitted)
        Me.grpPsychHosp.Controls.Add(Me.Label761)
        Me.grpPsychHosp.Controls.Add(Me.cmbPsychHospInstitution)
        Me.grpPsychHosp.Controls.Add(Me.Label760)
        Me.grpPsychHosp.Controls.Add(Me.dgvPsychHosp)
        Me.grpPsychHosp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPsychHosp.Location = New System.Drawing.Point(6, 503)
        Me.grpPsychHosp.Name = "grpPsychHosp"
        Me.grpPsychHosp.Size = New System.Drawing.Size(1033, 260)
        Me.grpPsychHosp.TabIndex = 121
        Me.grpPsychHosp.TabStop = False
        Me.grpPsychHosp.Text = "List all psychiatric hospitalizations"
        '
        'btnPsychHospCancel
        '
        Me.btnPsychHospCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPsychHospCancel.Location = New System.Drawing.Point(198, 233)
        Me.btnPsychHospCancel.Name = "btnPsychHospCancel"
        Me.btnPsychHospCancel.Size = New System.Drawing.Size(90, 23)
        Me.btnPsychHospCancel.TabIndex = 129
        Me.btnPsychHospCancel.Text = "Cancel"
        Me.btnPsychHospCancel.UseVisualStyleBackColor = True
        '
        'btnPsychHospEdit
        '
        Me.btnPsychHospEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPsychHospEdit.Location = New System.Drawing.Point(102, 233)
        Me.btnPsychHospEdit.Name = "btnPsychHospEdit"
        Me.btnPsychHospEdit.Size = New System.Drawing.Size(90, 23)
        Me.btnPsychHospEdit.TabIndex = 128
        Me.btnPsychHospEdit.Text = "Edit Record"
        Me.btnPsychHospEdit.UseVisualStyleBackColor = True
        '
        'btnPsychHospAdd
        '
        Me.btnPsychHospAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPsychHospAdd.Location = New System.Drawing.Point(6, 233)
        Me.btnPsychHospAdd.Name = "btnPsychHospAdd"
        Me.btnPsychHospAdd.Size = New System.Drawing.Size(90, 23)
        Me.btnPsychHospAdd.TabIndex = 127
        Me.btnPsychHospAdd.Text = "Add New"
        Me.btnPsychHospAdd.UseVisualStyleBackColor = True
        '
        'Label763
        '
        Me.Label763.AutoSize = True
        Me.Label763.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label763.Location = New System.Drawing.Point(456, 190)
        Me.Label763.Name = "Label763"
        Me.Label763.Size = New System.Drawing.Size(104, 13)
        Me.Label763.TabIndex = 8
        Me.Label763.Text = "Discharge Diagnosis"
        '
        'txtPsychHospDischargeDx
        '
        Me.txtPsychHospDischargeDx.Enabled = False
        Me.txtPsychHospDischargeDx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPsychHospDischargeDx.Location = New System.Drawing.Point(459, 206)
        Me.txtPsychHospDischargeDx.Name = "txtPsychHospDischargeDx"
        Me.txtPsychHospDischargeDx.Size = New System.Drawing.Size(568, 20)
        Me.txtPsychHospDischargeDx.TabIndex = 126
        '
        'dtPsychHospDischarged
        '
        Me.dtPsychHospDischarged.Enabled = False
        Me.dtPsychHospDischarged.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPsychHospDischarged.Location = New System.Drawing.Point(386, 206)
        Me.dtPsychHospDischarged.Mask = "00/00/0000"
        Me.dtPsychHospDischarged.Name = "dtPsychHospDischarged"
        Me.dtPsychHospDischarged.Size = New System.Drawing.Size(67, 20)
        Me.dtPsychHospDischarged.TabIndex = 125
        Me.dtPsychHospDischarged.ValidatingType = GetType(Date)
        '
        'Label762
        '
        Me.Label762.AutoSize = True
        Me.Label762.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label762.Location = New System.Drawing.Point(383, 190)
        Me.Label762.Name = "Label762"
        Me.Label762.Size = New System.Drawing.Size(61, 13)
        Me.Label762.TabIndex = 5
        Me.Label762.Text = "Discharged"
        '
        'dtPsychHospAdmitted
        '
        Me.dtPsychHospAdmitted.Enabled = False
        Me.dtPsychHospAdmitted.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPsychHospAdmitted.Location = New System.Drawing.Point(313, 206)
        Me.dtPsychHospAdmitted.Mask = "00/00/0000"
        Me.dtPsychHospAdmitted.Name = "dtPsychHospAdmitted"
        Me.dtPsychHospAdmitted.Size = New System.Drawing.Size(67, 20)
        Me.dtPsychHospAdmitted.TabIndex = 124
        Me.dtPsychHospAdmitted.ValidatingType = GetType(Date)
        '
        'Label761
        '
        Me.Label761.AutoSize = True
        Me.Label761.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label761.Location = New System.Drawing.Point(310, 190)
        Me.Label761.Name = "Label761"
        Me.Label761.Size = New System.Drawing.Size(48, 13)
        Me.Label761.TabIndex = 3
        Me.Label761.Text = "Admitted"
        '
        'cmbPsychHospInstitution
        '
        Me.cmbPsychHospInstitution.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPsychHospInstitution.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPsychHospInstitution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPsychHospInstitution.Enabled = False
        Me.cmbPsychHospInstitution.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPsychHospInstitution.FormattingEnabled = True
        Me.cmbPsychHospInstitution.Location = New System.Drawing.Point(6, 206)
        Me.cmbPsychHospInstitution.Name = "cmbPsychHospInstitution"
        Me.cmbPsychHospInstitution.Size = New System.Drawing.Size(301, 21)
        Me.cmbPsychHospInstitution.TabIndex = 123
        '
        'Label760
        '
        Me.Label760.AutoSize = True
        Me.Label760.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label760.Location = New System.Drawing.Point(6, 190)
        Me.Label760.Name = "Label760"
        Me.Label760.Size = New System.Drawing.Size(52, 13)
        Me.Label760.TabIndex = 1
        Me.Label760.Text = "Institution"
        '
        'dgvPsychHosp
        '
        Me.dgvPsychHosp.AllowUserToAddRows = False
        Me.dgvPsychHosp.AllowUserToDeleteRows = False
        Me.dgvPsychHosp.AllowUserToOrderColumns = True
        Me.dgvPsychHosp.AllowUserToResizeRows = False
        Me.dgvPsychHosp.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dgvPsychHosp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPsychHosp.BackgroundColor = System.Drawing.Color.Tan
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPsychHosp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPsychHosp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPsychHosp.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvPsychHosp.GridColor = System.Drawing.Color.Linen
        Me.dgvPsychHosp.Location = New System.Drawing.Point(6, 19)
        Me.dgvPsychHosp.MultiSelect = False
        Me.dgvPsychHosp.Name = "dgvPsychHosp"
        Me.dgvPsychHosp.ReadOnly = True
        Me.dgvPsychHosp.RowHeadersVisible = False
        Me.dgvPsychHosp.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.dgvPsychHosp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPsychHosp.Size = New System.Drawing.Size(1021, 168)
        Me.dgvPsychHosp.TabIndex = 122
        '
        'grpDEAD
        '
        Me.grpDEAD.Controls.Add(Me.intMembAvail)
        Me.grpDEAD.Controls.Add(Me.intMembInOMH)
        Me.grpDEAD.Controls.Add(Me.lblNoRecord)
        Me.grpDEAD.Controls.Add(Me.Label741)
        Me.grpDEAD.Controls.Add(Me.txtLastPsychDx)
        Me.grpDEAD.Controls.Add(Me.txtFamPsychHx)
        Me.grpDEAD.Controls.Add(Me.Label744)
        Me.grpDEAD.Controls.Add(Me.Label742)
        Me.grpDEAD.Controls.Add(Me.Label743)
        Me.grpDEAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDEAD.Location = New System.Drawing.Point(6, 35)
        Me.grpDEAD.Name = "grpDEAD"
        Me.grpDEAD.Size = New System.Drawing.Size(1033, 268)
        Me.grpDEAD.TabIndex = 101
        Me.grpDEAD.TabStop = False
        Me.grpDEAD.Text = "Diagnostic Evaluation After Death"
        '
        'intMembAvail
        '
        Me.intMembAvail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intMembAvail.Location = New System.Drawing.Point(313, 107)
        Me.intMembAvail.Name = "intMembAvail"
        Me.intMembAvail.Size = New System.Drawing.Size(100, 20)
        Me.intMembAvail.TabIndex = 104
        '
        'intMembInOMH
        '
        Me.intMembInOMH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intMembInOMH.Location = New System.Drawing.Point(101, 107)
        Me.intMembInOMH.Name = "intMembInOMH"
        Me.intMembInOMH.Size = New System.Drawing.Size(100, 20)
        Me.intMembInOMH.TabIndex = 103
        '
        'lblNoRecord
        '
        Me.lblNoRecord.AutoSize = True
        Me.lblNoRecord.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lblNoRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNoRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoRecord.Location = New System.Drawing.Point(0, 6)
        Me.lblNoRecord.Name = "lblNoRecord"
        Me.lblNoRecord.Size = New System.Drawing.Size(620, 64)
        Me.lblNoRecord.TabIndex = 1164
        Me.lblNoRecord.Text = "No DEAD1 Record Exists For This Subject" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click ""Add New Record"" Above To Create O" &
    "ne"
        Me.lblNoRecord.Visible = False
        '
        'Label741
        '
        Me.Label741.AutoSize = True
        Me.Label741.BackColor = System.Drawing.Color.Tan
        Me.Label741.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label741.Location = New System.Drawing.Point(6, 16)
        Me.Label741.Name = "Label741"
        Me.Label741.Size = New System.Drawing.Size(125, 13)
        Me.Label741.TabIndex = 0
        Me.Label741.Text = "Family Psychiatric History"
        '
        'txtLastPsychDx
        '
        Me.txtLastPsychDx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastPsychDx.Location = New System.Drawing.Point(6, 146)
        Me.txtLastPsychDx.Multiline = True
        Me.txtLastPsychDx.Name = "txtLastPsychDx"
        Me.txtLastPsychDx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLastPsychDx.Size = New System.Drawing.Size(1021, 116)
        Me.txtLastPsychDx.TabIndex = 105
        '
        'txtFamPsychHx
        '
        Me.txtFamPsychHx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFamPsychHx.Location = New System.Drawing.Point(6, 32)
        Me.txtFamPsychHx.Multiline = True
        Me.txtFamPsychHx.Name = "txtFamPsychHx"
        Me.txtFamPsychHx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFamPsychHx.Size = New System.Drawing.Size(1021, 69)
        Me.txtFamPsychHx.TabIndex = 102
        '
        'Label744
        '
        Me.Label744.AutoSize = True
        Me.Label744.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label744.Location = New System.Drawing.Point(6, 130)
        Me.Label744.Name = "Label744"
        Me.Label744.Size = New System.Drawing.Size(232, 13)
        Me.Label744.TabIndex = 220
        Me.Label744.Text = "Last Psychiatric Diagnosis (Copy from the Chart)"
        '
        'Label742
        '
        Me.Label742.AutoSize = True
        Me.Label742.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label742.Location = New System.Drawing.Point(6, 110)
        Me.Label742.Name = "Label742"
        Me.Label742.Size = New System.Drawing.Size(89, 13)
        Me.Label742.TabIndex = 216
        Me.Label742.Text = "Members in OMH"
        '
        'Label743
        '
        Me.Label743.AutoSize = True
        Me.Label743.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label743.Location = New System.Drawing.Point(211, 110)
        Me.Label743.Name = "Label743"
        Me.Label743.Size = New System.Drawing.Size(96, 13)
        Me.Label743.TabIndex = 218
        Me.Label743.Text = "Members Available"
        '
        'btnDEAD1Top
        '
        Me.btnDEAD1Top.Location = New System.Drawing.Point(6, 6)
        Me.btnDEAD1Top.Name = "btnDEAD1Top"
        Me.btnDEAD1Top.Size = New System.Drawing.Size(247, 23)
        Me.btnDEAD1Top.TabIndex = 100
        Me.btnDEAD1Top.Text = "Button_2"
        Me.btnDEAD1Top.UseVisualStyleBackColor = True
        '
        'grpCognitiveDecline
        '
        Me.grpCognitiveDecline.Controls.Add(Me.txtTotalNumPsychHosp)
        Me.grpCognitiveDecline.Controls.Add(Me.Label759)
        Me.grpCognitiveDecline.Controls.Add(Me.txtLenLastPsychHosp)
        Me.grpCognitiveDecline.Controls.Add(Me.Label758)
        Me.grpCognitiveDecline.Controls.Add(Me.txtTotalYrsHosp)
        Me.grpCognitiveDecline.Controls.Add(Me.Label757)
        Me.grpCognitiveDecline.Controls.Add(Me.txtCogDecMore75)
        Me.grpCognitiveDecline.Controls.Add(Me.Label755)
        Me.grpCognitiveDecline.Controls.Add(Me.txtCogDec6675)
        Me.grpCognitiveDecline.Controls.Add(Me.Label756)
        Me.grpCognitiveDecline.Controls.Add(Me.txtCogDec5665)
        Me.grpCognitiveDecline.Controls.Add(Me.Label753)
        Me.grpCognitiveDecline.Controls.Add(Me.txtCogDec4655)
        Me.grpCognitiveDecline.Controls.Add(Me.Label754)
        Me.grpCognitiveDecline.Controls.Add(Me.txtCogDec2645)
        Me.grpCognitiveDecline.Controls.Add(Me.Label752)
        Me.grpCognitiveDecline.Controls.Add(Me.txtCogDecLess26)
        Me.grpCognitiveDecline.Controls.Add(Me.Label751)
        Me.grpCognitiveDecline.Controls.Add(Me.Label750)
        Me.grpCognitiveDecline.Controls.Add(Me.txtCogDecAgeOnset)
        Me.grpCognitiveDecline.Controls.Add(Me.Label749)
        Me.grpCognitiveDecline.Controls.Add(Me.cmbCompCogFunct)
        Me.grpCognitiveDecline.Controls.Add(Me.Label748)
        Me.grpCognitiveDecline.Controls.Add(Me.cmbDemDx)
        Me.grpCognitiveDecline.Controls.Add(Me.Label747)
        Me.grpCognitiveDecline.Controls.Add(Me.dtEviPermCogimp)
        Me.grpCognitiveDecline.Controls.Add(Me.Label746)
        Me.grpCognitiveDecline.Controls.Add(Me.cmbEviPermCogImp)
        Me.grpCognitiveDecline.Controls.Add(Me.Label745)
        Me.grpCognitiveDecline.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCognitiveDecline.Location = New System.Drawing.Point(6, 309)
        Me.grpCognitiveDecline.Name = "grpCognitiveDecline"
        Me.grpCognitiveDecline.Size = New System.Drawing.Size(1033, 188)
        Me.grpCognitiveDecline.TabIndex = 106
        Me.grpCognitiveDecline.TabStop = False
        Me.grpCognitiveDecline.Text = "Cognitive Decline"
        '
        'txtTotalNumPsychHosp
        '
        Me.txtTotalNumPsychHosp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalNumPsychHosp.Location = New System.Drawing.Point(620, 163)
        Me.txtTotalNumPsychHosp.Name = "txtTotalNumPsychHosp"
        Me.txtTotalNumPsychHosp.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalNumPsychHosp.TabIndex = 120
        '
        'Label759
        '
        Me.Label759.AutoSize = True
        Me.Label759.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label759.Location = New System.Drawing.Point(348, 166)
        Me.Label759.Name = "Label759"
        Me.Label759.Size = New System.Drawing.Size(266, 13)
        Me.Label759.TabIndex = 27
        Me.Label759.Text = "Total number of hospitalizations for psychiatric reasons:"
        '
        'txtLenLastPsychHosp
        '
        Me.txtLenLastPsychHosp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLenLastPsychHosp.Location = New System.Drawing.Point(242, 163)
        Me.txtLenLastPsychHosp.Name = "txtLenLastPsychHosp"
        Me.txtLenLastPsychHosp.Size = New System.Drawing.Size(100, 20)
        Me.txtLenLastPsychHosp.TabIndex = 119
        '
        'Label758
        '
        Me.Label758.AutoSize = True
        Me.Label758.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label758.Location = New System.Drawing.Point(6, 166)
        Me.Label758.Name = "Label758"
        Me.Label758.Size = New System.Drawing.Size(230, 13)
        Me.Label758.TabIndex = 25
        Me.Label758.Text = "Length of last psychiatric hospitalization (years):"
        '
        'txtTotalYrsHosp
        '
        Me.txtTotalYrsHosp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalYrsHosp.Location = New System.Drawing.Point(242, 144)
        Me.txtTotalYrsHosp.Name = "txtTotalYrsHosp"
        Me.txtTotalYrsHosp.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalYrsHosp.TabIndex = 118
        '
        'Label757
        '
        Me.Label757.AutoSize = True
        Me.Label757.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label757.Location = New System.Drawing.Point(6, 147)
        Me.Label757.Name = "Label757"
        Me.Label757.Size = New System.Drawing.Size(219, 13)
        Me.Label757.TabIndex = 23
        Me.Label757.Text = "Total amount of time spent in hospital (years):"
        '
        'txtCogDecMore75
        '
        Me.txtCogDecMore75.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCogDecMore75.Location = New System.Drawing.Point(336, 118)
        Me.txtCogDecMore75.Name = "txtCogDecMore75"
        Me.txtCogDecMore75.Size = New System.Drawing.Size(60, 20)
        Me.txtCogDecMore75.TabIndex = 117
        '
        'Label755
        '
        Me.Label755.AutoSize = True
        Me.Label755.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label755.Location = New System.Drawing.Point(352, 102)
        Me.Label755.Name = "Label755"
        Me.Label755.Size = New System.Drawing.Size(28, 13)
        Me.Label755.TabIndex = 21
        Me.Label755.Text = "> 75"
        '
        'txtCogDec6675
        '
        Me.txtCogDec6675.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCogDec6675.Location = New System.Drawing.Point(270, 118)
        Me.txtCogDec6675.Name = "txtCogDec6675"
        Me.txtCogDec6675.Size = New System.Drawing.Size(60, 20)
        Me.txtCogDec6675.TabIndex = 116
        '
        'Label756
        '
        Me.Label756.AutoSize = True
        Me.Label756.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label756.Location = New System.Drawing.Point(283, 102)
        Me.Label756.Name = "Label756"
        Me.Label756.Size = New System.Drawing.Size(34, 13)
        Me.Label756.TabIndex = 19
        Me.Label756.Text = "66-75"
        '
        'txtCogDec5665
        '
        Me.txtCogDec5665.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCogDec5665.Location = New System.Drawing.Point(204, 118)
        Me.txtCogDec5665.Name = "txtCogDec5665"
        Me.txtCogDec5665.Size = New System.Drawing.Size(60, 20)
        Me.txtCogDec5665.TabIndex = 115
        '
        'Label753
        '
        Me.Label753.AutoSize = True
        Me.Label753.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label753.Location = New System.Drawing.Point(217, 102)
        Me.Label753.Name = "Label753"
        Me.Label753.Size = New System.Drawing.Size(34, 13)
        Me.Label753.TabIndex = 17
        Me.Label753.Text = "56-65"
        '
        'txtCogDec4655
        '
        Me.txtCogDec4655.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCogDec4655.Location = New System.Drawing.Point(138, 118)
        Me.txtCogDec4655.Name = "txtCogDec4655"
        Me.txtCogDec4655.Size = New System.Drawing.Size(60, 20)
        Me.txtCogDec4655.TabIndex = 114
        '
        'Label754
        '
        Me.Label754.AutoSize = True
        Me.Label754.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label754.Location = New System.Drawing.Point(151, 102)
        Me.Label754.Name = "Label754"
        Me.Label754.Size = New System.Drawing.Size(34, 13)
        Me.Label754.TabIndex = 15
        Me.Label754.Text = "46-55"
        '
        'txtCogDec2645
        '
        Me.txtCogDec2645.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCogDec2645.Location = New System.Drawing.Point(72, 118)
        Me.txtCogDec2645.Name = "txtCogDec2645"
        Me.txtCogDec2645.Size = New System.Drawing.Size(60, 20)
        Me.txtCogDec2645.TabIndex = 113
        '
        'Label752
        '
        Me.Label752.AutoSize = True
        Me.Label752.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label752.Location = New System.Drawing.Point(85, 102)
        Me.Label752.Name = "Label752"
        Me.Label752.Size = New System.Drawing.Size(34, 13)
        Me.Label752.TabIndex = 13
        Me.Label752.Text = "26-45"
        '
        'txtCogDecLess26
        '
        Me.txtCogDecLess26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCogDecLess26.Location = New System.Drawing.Point(6, 118)
        Me.txtCogDecLess26.Name = "txtCogDecLess26"
        Me.txtCogDecLess26.Size = New System.Drawing.Size(60, 20)
        Me.txtCogDecLess26.TabIndex = 112
        '
        'Label751
        '
        Me.Label751.AutoSize = True
        Me.Label751.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label751.Location = New System.Drawing.Point(22, 102)
        Me.Label751.Name = "Label751"
        Me.Label751.Size = New System.Drawing.Size(28, 13)
        Me.Label751.TabIndex = 11
        Me.Label751.Text = "< 26"
        '
        'Label750
        '
        Me.Label750.AutoSize = True
        Me.Label750.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label750.Location = New System.Drawing.Point(6, 86)
        Me.Label750.Name = "Label750"
        Me.Label750.Size = New System.Drawing.Size(335, 13)
        Me.Label750.TabIndex = 10
        Me.Label750.Text = "Percent of time hospitalized for psychiatric reasons during each period"
        '
        'txtCogDecAgeOnset
        '
        Me.txtCogDecAgeOnset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCogDecAgeOnset.Location = New System.Drawing.Point(701, 59)
        Me.txtCogDecAgeOnset.Name = "txtCogDecAgeOnset"
        Me.txtCogDecAgeOnset.Size = New System.Drawing.Size(100, 20)
        Me.txtCogDecAgeOnset.TabIndex = 111
        '
        'Label749
        '
        Me.Label749.AutoSize = True
        Me.Label749.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label749.Location = New System.Drawing.Point(533, 62)
        Me.Label749.Name = "Label749"
        Me.Label749.Size = New System.Drawing.Size(162, 13)
        Me.Label749.TabIndex = 8
        Me.Label749.Text = "Age of onset of cognitive decline"
        '
        'cmbCompCogFunct
        '
        Me.cmbCompCogFunct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCompCogFunct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCompCogFunct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCompCogFunct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCompCogFunct.FormattingEnabled = True
        Me.cmbCompCogFunct.Location = New System.Drawing.Point(406, 59)
        Me.cmbCompCogFunct.Name = "cmbCompCogFunct"
        Me.cmbCompCogFunct.Size = New System.Drawing.Size(121, 21)
        Me.cmbCompCogFunct.TabIndex = 110
        '
        'Label748
        '
        Me.Label748.AutoSize = True
        Me.Label748.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label748.Location = New System.Drawing.Point(6, 62)
        Me.Label748.Name = "Label748"
        Me.Label748.Size = New System.Drawing.Size(368, 13)
        Me.Label748.TabIndex = 6
        Me.Label748.Text = "Compare cognitive function late in life to first presentation. Is there a decline" &
    "?"
        '
        'cmbDemDx
        '
        Me.cmbDemDx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDemDx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDemDx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDemDx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDemDx.FormattingEnabled = True
        Me.cmbDemDx.Location = New System.Drawing.Point(406, 39)
        Me.cmbDemDx.Name = "cmbDemDx"
        Me.cmbDemDx.Size = New System.Drawing.Size(121, 21)
        Me.cmbDemDx.TabIndex = 109
        '
        'Label747
        '
        Me.Label747.AutoSize = True
        Me.Label747.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label747.Location = New System.Drawing.Point(6, 42)
        Me.Label747.Name = "Label747"
        Me.Label747.Size = New System.Drawing.Size(323, 13)
        Me.Label747.TabIndex = 4
        Me.Label747.Text = "Did the patient have a dementia diagnosis on original presentation?"
        '
        'dtEviPermCogimp
        '
        Me.dtEviPermCogimp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtEviPermCogimp.Location = New System.Drawing.Point(698, 19)
        Me.dtEviPermCogimp.Mask = "00/00/0000"
        Me.dtEviPermCogimp.Name = "dtEviPermCogimp"
        Me.dtEviPermCogimp.Size = New System.Drawing.Size(67, 20)
        Me.dtEviPermCogimp.TabIndex = 108
        Me.dtEviPermCogimp.ValidatingType = GetType(Date)
        '
        'Label746
        '
        Me.Label746.AutoSize = True
        Me.Label746.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label746.Location = New System.Drawing.Point(533, 22)
        Me.Label746.Name = "Label746"
        Me.Label746.Size = New System.Drawing.Size(159, 13)
        Me.Label746.TabIndex = 2
        Me.Label746.Text = "When did the impairment begin?"
        '
        'cmbEviPermCogImp
        '
        Me.cmbEviPermCogImp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEviPermCogImp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEviPermCogImp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEviPermCogImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEviPermCogImp.FormattingEnabled = True
        Me.cmbEviPermCogImp.Location = New System.Drawing.Point(406, 19)
        Me.cmbEviPermCogImp.Name = "cmbEviPermCogImp"
        Me.cmbEviPermCogImp.Size = New System.Drawing.Size(121, 21)
        Me.cmbEviPermCogImp.TabIndex = 107
        '
        'Label745
        '
        Me.Label745.AutoSize = True
        Me.Label745.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label745.Location = New System.Drawing.Point(6, 22)
        Me.Label745.Name = "Label745"
        Me.Label745.Size = New System.Drawing.Size(394, 13)
        Me.Label745.TabIndex = 0
        Me.Label745.Text = "Did the patient ever show evidence of permanent (>2 years) cognitive impairment?"
        '
        'WA_PMCR_Dead1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.Controls.Add(Me.grpCognitiveDecline)
        Me.Controls.Add(Me.btnDEAD1Bottom)
        Me.Controls.Add(Me.grpTestResults)
        Me.Controls.Add(Me.grpSigMedHist)
        Me.Controls.Add(Me.grpNeuroIllness)
        Me.Controls.Add(Me.grpPsychHosp)
        Me.Controls.Add(Me.grpDEAD)
        Me.Controls.Add(Me.btnDEAD1Top)
        Me.Name = "WA_PMCR_Dead1"
        Me.Size = New System.Drawing.Size(1054, 1693)
        Me.grpTestResults.ResumeLayout(False)
        Me.grpTestResults.PerformLayout()
        CType(Me.dgvTestResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSigMedHist.ResumeLayout(False)
        Me.grpSigMedHist.PerformLayout()
        CType(Me.dgvSigMedHx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpNeuroIllness.ResumeLayout(False)
        Me.grpNeuroIllness.PerformLayout()
        Me.grpPsychHosp.ResumeLayout(False)
        Me.grpPsychHosp.PerformLayout()
        CType(Me.dgvPsychHosp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDEAD.ResumeLayout(False)
        Me.grpDEAD.PerformLayout()
        Me.grpCognitiveDecline.ResumeLayout(False)
        Me.grpCognitiveDecline.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDEAD1Bottom As DataWarehouse.Button_
    Friend WithEvents grpTestResults As System.Windows.Forms.GroupBox
    Friend WithEvents btnTestResultsCancel As DataWarehouse.Button_
    Friend WithEvents btnTestResultsEdit As DataWarehouse.Button_
    Friend WithEvents btnTestResultsAdd As DataWarehouse.Button_
    Friend WithEvents txtTestResultsResults As DataWarehouse.TextBox_
    Friend WithEvents Label777 As System.Windows.Forms.Label
    Friend WithEvents dtTestResultsDate As DataWarehouse.TextBoxDatePast
    Friend WithEvents Label776 As System.Windows.Forms.Label
    Friend WithEvents Label775 As System.Windows.Forms.Label
    Friend WithEvents txtTestResultsTest As DataWarehouse.TextBox_
    Friend WithEvents dgvTestResults As DataWarehouse.dgvSingleRow
    Friend WithEvents grpSigMedHist As System.Windows.Forms.GroupBox
    Friend WithEvents btnSigMedHxCancel As DataWarehouse.Button_
    Friend WithEvents btnSigMedHxEdit As DataWarehouse.Button_
    Friend WithEvents btnSigMedHxAdd As DataWarehouse.Button_
    Friend WithEvents txtSigMedHxComplications As DataWarehouse.TextBox_
    Friend WithEvents txtSigMedHxOutcome As DataWarehouse.TextBox_
    Friend WithEvents txtSigMedHxTreatment As DataWarehouse.TextBox_
    Friend WithEvents txtSigMedHxIllInj As DataWarehouse.TextBox_
    Friend WithEvents txtSigMedHxAgeOnset As DataWarehouse.TextBoxInteger
    Friend WithEvents txtSigMedHxAgeConc As DataWarehouse.TextBoxInteger
    Friend WithEvents Label774 As System.Windows.Forms.Label
    Friend WithEvents Label773 As System.Windows.Forms.Label
    Friend WithEvents Label772 As System.Windows.Forms.Label
    Friend WithEvents Label770 As System.Windows.Forms.Label
    Friend WithEvents Label769 As System.Windows.Forms.Label
    Friend WithEvents Label768 As System.Windows.Forms.Label
    Friend WithEvents dgvSigMedHx As DataWarehouse.dgvSingleRow
    Friend WithEvents grpNeuroIllness As System.Windows.Forms.GroupBox
    Friend WithEvents cmbOthNeuroIllnessConf As DataWarehouse.ComboBox_
    Friend WithEvents cmbNeurosurgeryConf As DataWarehouse.ComboBox_
    Friend WithEvents cmbToxicMetabolicConf As DataWarehouse.ComboBox_
    Friend WithEvents cmbSeizureDisorderConf As DataWarehouse.ComboBox_
    Friend WithEvents cmbCNSInfectionConf As DataWarehouse.ComboBox_
    Friend WithEvents cmbtCNSConf As DataWarehouse.ComboBox_
    Friend WithEvents cmbHeadInjuryConf As DataWarehouse.ComboBox_
    Friend WithEvents cmbOthCerebroConf As DataWarehouse.ComboBox_
    Friend WithEvents cmbMajorCVAConf As DataWarehouse.ComboBox_
    Friend WithEvents cmbOthMovDisConf As DataWarehouse.ComboBox_
    Friend WithEvents cmbTardiveDyskConf As DataWarehouse.ComboBox_
    Friend WithEvents chkOthNeuroIllness As DataWarehouse.CheckBox_
    Friend WithEvents chkNeurosurgery As DataWarehouse.CheckBox_
    Friend WithEvents chkToxicMetabolic As DataWarehouse.CheckBox_
    Friend WithEvents chkSeizureDisorder As DataWarehouse.CheckBox_
    Friend WithEvents chkCNSInfection As DataWarehouse.CheckBox_
    Friend WithEvents chktCNS As DataWarehouse.CheckBox_
    Friend WithEvents chkHeadInjury As DataWarehouse.CheckBox_
    Friend WithEvents chkOtherCerebro As DataWarehouse.CheckBox_
    Friend WithEvents chkMajorCVA As DataWarehouse.CheckBox_
    Friend WithEvents chkOthMovDis As DataWarehouse.CheckBox_
    Friend WithEvents chkTardiveDysk As DataWarehouse.CheckBox_
    Friend WithEvents Label766 As System.Windows.Forms.Label
    Friend WithEvents txtOthNeuroIllnessAgeOnset As DataWarehouse.TextBoxInteger
    Friend WithEvents txtNeuroSurgeryAgeOnset As DataWarehouse.TextBoxInteger
    Friend WithEvents txtToxicMetabolicAgeOnset As DataWarehouse.TextBoxInteger
    Friend WithEvents txtSeizureDisorderAgeOnset As DataWarehouse.TextBoxInteger
    Friend WithEvents txtCNSInfectionAgeOnset As DataWarehouse.TextBoxInteger
    Friend WithEvents Label767 As System.Windows.Forms.Label
    Friend WithEvents Label765 As System.Windows.Forms.Label
    Friend WithEvents txttCNSAgeOnset As DataWarehouse.TextBoxInteger
    Friend WithEvents txtHeadInjuryAgeOnset As DataWarehouse.TextBoxInteger
    Friend WithEvents txtOthCerebroAgeOnset As DataWarehouse.TextBoxInteger
    Friend WithEvents txtMajorCVAAgeOnset As DataWarehouse.TextBoxInteger
    Friend WithEvents txtOthMovDisAgeOnset As DataWarehouse.TextBoxInteger
    Friend WithEvents txtTardiveDyskAgeOnset As DataWarehouse.TextBoxInteger
    Friend WithEvents Label764 As System.Windows.Forms.Label
    Friend WithEvents grpPsychHosp As System.Windows.Forms.GroupBox
    Friend WithEvents btnPsychHospCancel As DataWarehouse.Button_
    Friend WithEvents btnPsychHospEdit As DataWarehouse.Button_
    Friend WithEvents btnPsychHospAdd As DataWarehouse.Button_
    Friend WithEvents Label763 As System.Windows.Forms.Label
    Friend WithEvents txtPsychHospDischargeDx As DataWarehouse.TextBox_
    Friend WithEvents dtPsychHospDischarged As DataWarehouse.TextBoxDatePast
    Friend WithEvents Label762 As System.Windows.Forms.Label
    Friend WithEvents dtPsychHospAdmitted As DataWarehouse.TextBoxDatePast
    Friend WithEvents Label761 As System.Windows.Forms.Label
    Friend WithEvents cmbPsychHospInstitution As DataWarehouse.ComboBox_
    Friend WithEvents Label760 As System.Windows.Forms.Label
    Friend WithEvents dgvPsychHosp As DataWarehouse.dgvSingleRow
    Friend WithEvents grpDEAD As System.Windows.Forms.GroupBox
    Friend WithEvents Label741 As System.Windows.Forms.Label
    Friend WithEvents txtLastPsychDx As DataWarehouse.TextBox_
    Friend WithEvents txtFamPsychHx As DataWarehouse.TextBox_
    Friend WithEvents Label744 As System.Windows.Forms.Label
    Friend WithEvents Label742 As System.Windows.Forms.Label
    Friend WithEvents Label743 As System.Windows.Forms.Label
    Friend WithEvents btnDEAD1Top As DataWarehouse.Button_
    Friend WithEvents grpCognitiveDecline As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotalNumPsychHosp As DataWarehouse.TextBoxNumeric
    Friend WithEvents Label759 As System.Windows.Forms.Label
    Friend WithEvents txtLenLastPsychHosp As DataWarehouse.TextBoxNumeric
    Friend WithEvents Label758 As System.Windows.Forms.Label
    Friend WithEvents txtTotalYrsHosp As DataWarehouse.TextBoxNumeric
    Friend WithEvents Label757 As System.Windows.Forms.Label
    Friend WithEvents txtCogDecMore75 As DataWarehouse.TextBoxNumeric
    Friend WithEvents Label755 As System.Windows.Forms.Label
    Friend WithEvents txtCogDec6675 As DataWarehouse.TextBoxNumeric
    Friend WithEvents Label756 As System.Windows.Forms.Label
    Friend WithEvents txtCogDec5665 As DataWarehouse.TextBoxNumeric
    Friend WithEvents Label753 As System.Windows.Forms.Label
    Friend WithEvents txtCogDec4655 As DataWarehouse.TextBoxNumeric
    Friend WithEvents Label754 As System.Windows.Forms.Label
    Friend WithEvents txtCogDec2645 As DataWarehouse.TextBoxNumeric
    Friend WithEvents Label752 As System.Windows.Forms.Label
    Friend WithEvents txtCogDecLess26 As DataWarehouse.TextBoxNumeric
    Friend WithEvents Label751 As System.Windows.Forms.Label
    Friend WithEvents Label750 As System.Windows.Forms.Label
    Friend WithEvents txtCogDecAgeOnset As DataWarehouse.TextBoxInteger
    Friend WithEvents Label749 As System.Windows.Forms.Label
    Friend WithEvents cmbCompCogFunct As DataWarehouse.ComboBox_
    Friend WithEvents Label748 As System.Windows.Forms.Label
    Friend WithEvents cmbDemDx As DataWarehouse.ComboBox_
    Friend WithEvents Label747 As System.Windows.Forms.Label
    Friend WithEvents dtEviPermCogimp As DataWarehouse.TextBoxDatePast
    Friend WithEvents Label746 As System.Windows.Forms.Label
    Friend WithEvents cmbEviPermCogImp As DataWarehouse.ComboBox_
    Friend WithEvents Label745 As System.Windows.Forms.Label
    Friend WithEvents lblNoRecord As Label
    Friend WithEvents intMembInOMH As TextBoxInteger
    Friend WithEvents intMembAvail As TextBoxInteger
End Class
