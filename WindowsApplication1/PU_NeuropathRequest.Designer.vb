<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PU_NeuropathRequest
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
        Me.txtFax = New DataWarehouse.TextBox_()
        Me.txtZip = New DataWarehouse.TextBox_()
        Me.cmbSentBy = New DataWarehouse.ComboBox_()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.txtPhone = New DataWarehouse.TextBox_()
        Me.txtEmail = New DataWarehouse.TextBox_()
        Me.cmbDelMethod = New DataWarehouse.ComboBox_()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.dtDateSent = New DataWarehouse.TextBoxDatePast()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.txtState = New DataWarehouse.TextBox_()
        Me.txtCity = New DataWarehouse.TextBox_()
        Me.txtAdd4 = New DataWarehouse.TextBox_()
        Me.txtAdd3 = New DataWarehouse.TextBox_()
        Me.txtAdd2 = New DataWarehouse.TextBox_()
        Me.txtAdd1 = New DataWarehouse.TextBox_()
        Me.txtName = New DataWarehouse.TextBox_()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.cmbReqType = New DataWarehouse.ComboBox_()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNeuropath = New DataWarehouse.Button_()
        Me.btnMailerDelete = New DataWarehouse.Button_()
        Me.btnMailer = New DataWarehouse.Button_()
        Me.btnSave = New DataWarehouse.Button_()
        Me.btnClose = New DataWarehouse.Button_()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtReqDate = New DataWarehouse.TextBoxDatePast()
        Me.txtConsentor = New DataWarehouse.TextBox_()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbSalutation = New DataWarehouse.ComboBox_()
        Me.NextOfKin = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFax
        '
        Me.txtFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFax.Location = New System.Drawing.Point(575, 192)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(167, 20)
        Me.txtFax.TabIndex = 14
        '
        'txtZip
        '
        Me.txtZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZip.Location = New System.Drawing.Point(575, 173)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(167, 20)
        Me.txtZip.TabIndex = 11
        '
        'cmbSentBy
        '
        Me.cmbSentBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSentBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSentBy.BackColor = System.Drawing.Color.Linen
        Me.cmbSentBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSentBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSentBy.FormattingEnabled = True
        Me.cmbSentBy.Location = New System.Drawing.Point(192, 221)
        Me.cmbSentBy.Name = "cmbSentBy"
        Me.cmbSentBy.Size = New System.Drawing.Size(184, 21)
        Me.cmbSentBy.TabIndex = 16
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(142, 224)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(44, 13)
        Me.Label68.TabIndex = 1149
        Me.Label68.Text = "Sent By"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(545, 195)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(24, 13)
        Me.Label65.TabIndex = 1148
        Me.Label65.Text = "Fax"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(300, 195)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(38, 13)
        Me.Label66.TabIndex = 1147
        Me.Label66.Text = "Phone"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(12, 195)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(32, 13)
        Me.Label67.TabIndex = 1146
        Me.Label67.Text = "Email"
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(338, 192)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(201, 20)
        Me.txtPhone.TabIndex = 13
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(69, 192)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(225, 20)
        Me.txtEmail.TabIndex = 12
        '
        'cmbDelMethod
        '
        Me.cmbDelMethod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDelMethod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDelMethod.BackColor = System.Drawing.Color.Linen
        Me.cmbDelMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDelMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDelMethod.FormattingEnabled = True
        Me.cmbDelMethod.Location = New System.Drawing.Point(334, 10)
        Me.cmbDelMethod.Name = "cmbDelMethod"
        Me.cmbDelMethod.Size = New System.Drawing.Size(149, 21)
        Me.cmbDelMethod.TabIndex = 1
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(244, 13)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(84, 13)
        Me.Label64.TabIndex = 1145
        Me.Label64.Text = "Delivery Method"
        '
        'dtDateSent
        '
        Me.dtDateSent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateSent.Location = New System.Drawing.Point(69, 221)
        Me.dtDateSent.Mask = "00/00/0000"
        Me.dtDateSent.Name = "dtDateSent"
        Me.dtDateSent.Size = New System.Drawing.Size(67, 20)
        Me.dtDateSent.TabIndex = 15
        Me.dtDateSent.ValidatingType = GetType(Date)
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(12, 224)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(55, 13)
        Me.Label62.TabIndex = 1143
        Me.Label62.Text = "Date Sent"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(545, 176)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(22, 13)
        Me.Label61.TabIndex = 1142
        Me.Label61.Text = "Zip"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(300, 176)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(32, 13)
        Me.Label58.TabIndex = 1141
        Me.Label58.Text = "State"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(12, 176)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(24, 13)
        Me.Label53.TabIndex = 1140
        Me.Label53.Text = "City"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(12, 157)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(54, 13)
        Me.Label52.TabIndex = 1139
        Me.Label52.Text = "Address 4"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(12, 138)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(54, 13)
        Me.Label51.TabIndex = 1138
        Me.Label51.Text = "Address 3"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(12, 119)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(54, 13)
        Me.Label49.TabIndex = 1137
        Me.Label49.Text = "Address 2"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(12, 100)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(54, 13)
        Me.Label48.TabIndex = 1136
        Me.Label48.Text = "Address 1"
        '
        'txtState
        '
        Me.txtState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtState.Location = New System.Drawing.Point(338, 173)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(201, 20)
        Me.txtState.TabIndex = 10
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(69, 173)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(225, 20)
        Me.txtCity.TabIndex = 9
        '
        'txtAdd4
        '
        Me.txtAdd4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd4.Location = New System.Drawing.Point(69, 154)
        Me.txtAdd4.Name = "txtAdd4"
        Me.txtAdd4.Size = New System.Drawing.Size(673, 20)
        Me.txtAdd4.TabIndex = 8
        '
        'txtAdd3
        '
        Me.txtAdd3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd3.Location = New System.Drawing.Point(69, 135)
        Me.txtAdd3.Name = "txtAdd3"
        Me.txtAdd3.Size = New System.Drawing.Size(673, 20)
        Me.txtAdd3.TabIndex = 7
        '
        'txtAdd2
        '
        Me.txtAdd2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd2.Location = New System.Drawing.Point(69, 116)
        Me.txtAdd2.Name = "txtAdd2"
        Me.txtAdd2.Size = New System.Drawing.Size(673, 20)
        Me.txtAdd2.TabIndex = 6
        '
        'txtAdd1
        '
        Me.txtAdd1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd1.Location = New System.Drawing.Point(69, 97)
        Me.txtAdd1.Name = "txtAdd1"
        Me.txtAdd1.Size = New System.Drawing.Size(673, 20)
        Me.txtAdd1.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(69, 58)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(673, 20)
        Me.txtName.TabIndex = 4
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(12, 61)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(57, 13)
        Me.Label47.TabIndex = 1135
        Me.Label47.Text = "Name (To)"
        '
        'cmbReqType
        '
        Me.cmbReqType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbReqType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbReqType.BackColor = System.Drawing.Color.Linen
        Me.cmbReqType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReqType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReqType.FormattingEnabled = True
        Me.cmbReqType.Location = New System.Drawing.Point(92, 10)
        Me.cmbReqType.Name = "cmbReqType"
        Me.cmbReqType.Size = New System.Drawing.Size(149, 21)
        Me.cmbReqType.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 1166
        Me.Label1.Text = "Request Type"
        '
        'btnNeuropath
        '
        Me.btnNeuropath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNeuropath.Location = New System.Drawing.Point(6, 19)
        Me.btnNeuropath.Name = "btnNeuropath"
        Me.btnNeuropath.Size = New System.Drawing.Size(135, 21)
        Me.btnNeuropath.TabIndex = 19
        Me.btnNeuropath.Text = "View Neuropath"
        Me.btnNeuropath.UseVisualStyleBackColor = True
        '
        'btnMailerDelete
        '
        Me.btnMailerDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMailerDelete.Location = New System.Drawing.Point(48, 66)
        Me.btnMailerDelete.Name = "btnMailerDelete"
        Me.btnMailerDelete.Size = New System.Drawing.Size(50, 21)
        Me.btnMailerDelete.TabIndex = 21
        Me.btnMailerDelete.Tag = "Barcode, BB, StorageType, BrainRegion, UoM, Size, ProjectID, SubNum"
        Me.btnMailerDelete.Text = "Delete"
        Me.btnMailerDelete.UseVisualStyleBackColor = True
        '
        'btnMailer
        '
        Me.btnMailer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMailer.Location = New System.Drawing.Point(6, 46)
        Me.btnMailer.Name = "btnMailer"
        Me.btnMailer.Size = New System.Drawing.Size(135, 21)
        Me.btnMailer.TabIndex = 20
        Me.btnMailer.Text = "Generate Cover Sheet"
        Me.btnMailer.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(15, 289)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(135, 21)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(159, 289)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(135, 21)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "Close / Cancel"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnMailer)
        Me.GroupBox1.Controls.Add(Me.btnMailerDelete)
        Me.GroupBox1.Controls.Add(Me.btnNeuropath)
        Me.GroupBox1.Location = New System.Drawing.Point(594, 218)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(148, 92)
        Me.GroupBox1.TabIndex = 1173
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "For Harry"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(489, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 1174
        Me.Label2.Text = "Request Date"
        '
        'dtReqDate
        '
        Me.dtReqDate.Location = New System.Drawing.Point(568, 11)
        Me.dtReqDate.Mask = "00/00/0000"
        Me.dtReqDate.Name = "dtReqDate"
        Me.dtReqDate.Size = New System.Drawing.Size(67, 20)
        Me.dtReqDate.TabIndex = 3
        Me.dtReqDate.ValidatingType = GetType(Date)
        '
        'txtConsentor
        '
        Me.txtConsentor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsentor.Location = New System.Drawing.Point(69, 39)
        Me.txtConsentor.Name = "txtConsentor"
        Me.txtConsentor.Size = New System.Drawing.Size(593, 20)
        Me.txtConsentor.TabIndex = 1175
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 1176
        Me.Label3.Text = "Consentor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 1177
        Me.Label4.Text = "Salutation"
        '
        'cmbSalutation
        '
        Me.cmbSalutation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSalutation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSalutation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSalutation.FormattingEnabled = True
        Me.cmbSalutation.Location = New System.Drawing.Point(69, 77)
        Me.cmbSalutation.Name = "cmbSalutation"
        Me.cmbSalutation.Size = New System.Drawing.Size(121, 21)
        Me.cmbSalutation.TabIndex = 1178
        '
        'NextOfKin
        '
        Me.NextOfKin.AutoSize = True
        Me.NextOfKin.Enabled = False
        Me.NextOfKin.Location = New System.Drawing.Point(668, 41)
        Me.NextOfKin.Name = "NextOfKin"
        Me.NextOfKin.Size = New System.Drawing.Size(78, 17)
        Me.NextOfKin.TabIndex = 1179
        Me.NextOfKin.Text = "Next of Kin"
        Me.NextOfKin.UseVisualStyleBackColor = True
        '
        'PU_NeuropathRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(751, 319)
        Me.ControlBox = False
        Me.Controls.Add(Me.NextOfKin)
        Me.Controls.Add(Me.cmbSalutation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtConsentor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtReqDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbReqType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.cmbSentBy)
        Me.Controls.Add(Me.Label68)
        Me.Controls.Add(Me.Label65)
        Me.Controls.Add(Me.Label66)
        Me.Controls.Add(Me.Label67)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.cmbDelMethod)
        Me.Controls.Add(Me.Label64)
        Me.Controls.Add(Me.dtDateSent)
        Me.Controls.Add(Me.Label62)
        Me.Controls.Add(Me.Label61)
        Me.Controls.Add(Me.Label58)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAdd4)
        Me.Controls.Add(Me.txtAdd3)
        Me.Controls.Add(Me.txtAdd2)
        Me.Controls.Add(Me.txtAdd1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label47)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PU_NeuropathRequest"
        Me.Text = "PU_NeuropathRequest"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFax As TextBox_
    Friend WithEvents txtZip As TextBox_
    Friend WithEvents cmbSentBy As ComboBox_
    Friend WithEvents Label68 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents Label66 As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents txtPhone As TextBox_
    Friend WithEvents txtEmail As TextBox_
    Friend WithEvents cmbDelMethod As ComboBox_
    Friend WithEvents Label64 As Label
    Friend WithEvents dtDateSent As TextBoxDatePast
    Friend WithEvents Label62 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents txtState As TextBox_
    Friend WithEvents txtCity As TextBox_
    Friend WithEvents txtAdd4 As TextBox_
    Friend WithEvents txtAdd3 As TextBox_
    Friend WithEvents txtAdd2 As TextBox_
    Friend WithEvents txtAdd1 As TextBox_
    Friend WithEvents txtName As TextBox_
    Friend WithEvents Label47 As Label
    Friend WithEvents cmbReqType As ComboBox_
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNeuropath As Button_
    Friend WithEvents btnMailerDelete As Button_
    Friend WithEvents btnMailer As Button_
    Friend WithEvents btnSave As Button_
    Friend WithEvents btnClose As Button_
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtReqDate As TextBoxDatePast
    Friend WithEvents txtConsentor As TextBox_
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbSalutation As ComboBox_
    Friend WithEvents NextOfKin As CheckBox
End Class
