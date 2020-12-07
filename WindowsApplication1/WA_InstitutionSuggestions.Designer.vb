<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WA_InstitutionSuggestions
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnDeny = New DataWarehouse.Button_()
        Me.btnApprove = New DataWarehouse.Button_()
        Me.txtFromField = New DataWarehouse.TextBox_()
        Me.txtIdentifier = New DataWarehouse.TextBox_()
        Me.txtFromForm = New DataWarehouse.TextBox_()
        Me.txtSuggestedBy = New DataWarehouse.TextBox_()
        Me.btnHideApproved = New DataWarehouse.Button_()
        Me.txtNotes = New DataWarehouse.TextBox_()
        Me.txtFax = New DataWarehouse.TextBox_()
        Me.txtTelephone = New DataWarehouse.TextBox_()
        Me.txtPOCRole = New DataWarehouse.TextBox_()
        Me.txtPOCName = New DataWarehouse.TextBox_()
        Me.txtZIP = New DataWarehouse.TextBox_()
        Me.txtState = New DataWarehouse.TextBox_()
        Me.txtCity = New DataWarehouse.TextBox_()
        Me.txtAddress4 = New DataWarehouse.TextBox_()
        Me.txtAddress3 = New DataWarehouse.TextBox_()
        Me.txtAddress2 = New DataWarehouse.TextBox_()
        Me.txtAddress1 = New DataWarehouse.TextBox_()
        Me.txtName = New DataWarehouse.TextBox_()
        Me.dgvInstitutionSuggestions = New DataWarehouse.dgvSingleRow()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtDenyMessage = New DataWarehouse.TextBox_()
        Me.Label21 = New System.Windows.Forms.Label()
        CType(Me.dgvInstitutionSuggestions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 29)
        Me.Label1.TabIndex = 275
        Me.Label1.Text = "New Institution Suggestions"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 421)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 302
        Me.Label11.Text = "Notes"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 402)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 13)
        Me.Label12.TabIndex = 300
        Me.Label12.Text = "Fax"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(5, 383)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 13)
        Me.Label13.TabIndex = 298
        Me.Label13.Text = "Telephone"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(5, 364)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 296
        Me.Label14.Text = "POC Role"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(5, 345)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 13)
        Me.Label15.TabIndex = 294
        Me.Label15.Text = "POC Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 326)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 13)
        Me.Label7.TabIndex = 292
        Me.Label7.Text = "Zip"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 307)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 290
        Me.Label8.Text = "State"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 288)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 13)
        Me.Label9.TabIndex = 288
        Me.Label9.Text = "City"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 286
        Me.Label5.Text = "Address 4"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 284
        Me.Label6.Text = "Address 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 282
        Me.Label4.Text = "Address 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 280
        Me.Label2.Text = "Address 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 279
        Me.Label3.Text = "Institution Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 548)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 311
        Me.Label10.Text = "Form Field"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(5, 529)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 13)
        Me.Label16.TabIndex = 309
        Me.Label16.Text = "Identifier"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(5, 510)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 13)
        Me.Label17.TabIndex = 307
        Me.Label17.Text = "From Form"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(5, 491)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 13)
        Me.Label18.TabIndex = 305
        Me.Label18.Text = "Requested By"
        '
        'btnDeny
        '
        Me.btnDeny.Enabled = False
        Me.btnDeny.Location = New System.Drawing.Point(8, 661)
        Me.btnDeny.Name = "btnDeny"
        Me.btnDeny.Size = New System.Drawing.Size(75, 23)
        Me.btnDeny.TabIndex = 313
        Me.btnDeny.Text = "Deny"
        Me.btnDeny.UseVisualStyleBackColor = True
        '
        'btnApprove
        '
        Me.btnApprove.Enabled = False
        Me.btnApprove.Location = New System.Drawing.Point(8, 575)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(75, 23)
        Me.btnApprove.TabIndex = 312
        Me.btnApprove.Text = "Approve"
        Me.btnApprove.UseVisualStyleBackColor = True
        '
        'txtFromField
        '
        Me.txtFromField.Enabled = False
        Me.txtFromField.Location = New System.Drawing.Point(93, 545)
        Me.txtFromField.Name = "txtFromField"
        Me.txtFromField.Size = New System.Drawing.Size(524, 20)
        Me.txtFromField.TabIndex = 310
        '
        'txtIdentifier
        '
        Me.txtIdentifier.Enabled = False
        Me.txtIdentifier.Location = New System.Drawing.Point(93, 526)
        Me.txtIdentifier.Name = "txtIdentifier"
        Me.txtIdentifier.Size = New System.Drawing.Size(524, 20)
        Me.txtIdentifier.TabIndex = 308
        '
        'txtFromForm
        '
        Me.txtFromForm.Enabled = False
        Me.txtFromForm.Location = New System.Drawing.Point(93, 507)
        Me.txtFromForm.Name = "txtFromForm"
        Me.txtFromForm.Size = New System.Drawing.Size(524, 20)
        Me.txtFromForm.TabIndex = 306
        '
        'txtSuggestedBy
        '
        Me.txtSuggestedBy.Enabled = False
        Me.txtSuggestedBy.Location = New System.Drawing.Point(93, 488)
        Me.txtSuggestedBy.Name = "txtSuggestedBy"
        Me.txtSuggestedBy.Size = New System.Drawing.Size(524, 20)
        Me.txtSuggestedBy.TabIndex = 304
        '
        'btnHideApproved
        '
        Me.btnHideApproved.Location = New System.Drawing.Point(502, 3)
        Me.btnHideApproved.Name = "btnHideApproved"
        Me.btnHideApproved.Size = New System.Drawing.Size(115, 23)
        Me.btnHideApproved.TabIndex = 303
        Me.btnHideApproved.Text = "Hide Resolved"
        Me.btnHideApproved.UseVisualStyleBackColor = True
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(93, 418)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(524, 60)
        Me.txtNotes.TabIndex = 301
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(93, 399)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(524, 20)
        Me.txtFax.TabIndex = 299
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(93, 380)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(524, 20)
        Me.txtTelephone.TabIndex = 297
        '
        'txtPOCRole
        '
        Me.txtPOCRole.Location = New System.Drawing.Point(93, 361)
        Me.txtPOCRole.Name = "txtPOCRole"
        Me.txtPOCRole.Size = New System.Drawing.Size(524, 20)
        Me.txtPOCRole.TabIndex = 295
        '
        'txtPOCName
        '
        Me.txtPOCName.Location = New System.Drawing.Point(93, 342)
        Me.txtPOCName.Name = "txtPOCName"
        Me.txtPOCName.Size = New System.Drawing.Size(524, 20)
        Me.txtPOCName.TabIndex = 293
        '
        'txtZIP
        '
        Me.txtZIP.Location = New System.Drawing.Point(93, 323)
        Me.txtZIP.Name = "txtZIP"
        Me.txtZIP.Size = New System.Drawing.Size(524, 20)
        Me.txtZIP.TabIndex = 291
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(93, 304)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(524, 20)
        Me.txtState.TabIndex = 289
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(93, 285)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(524, 20)
        Me.txtCity.TabIndex = 287
        '
        'txtAddress4
        '
        Me.txtAddress4.Location = New System.Drawing.Point(93, 266)
        Me.txtAddress4.Name = "txtAddress4"
        Me.txtAddress4.Size = New System.Drawing.Size(524, 20)
        Me.txtAddress4.TabIndex = 285
        '
        'txtAddress3
        '
        Me.txtAddress3.Location = New System.Drawing.Point(93, 247)
        Me.txtAddress3.Name = "txtAddress3"
        Me.txtAddress3.Size = New System.Drawing.Size(524, 20)
        Me.txtAddress3.TabIndex = 283
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(93, 228)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(524, 20)
        Me.txtAddress2.TabIndex = 281
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New System.Drawing.Point(93, 209)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(524, 20)
        Me.txtAddress1.TabIndex = 278
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(93, 190)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(524, 20)
        Me.txtName.TabIndex = 277
        '
        'dgvInstitutionSuggestions
        '
        Me.dgvInstitutionSuggestions.AllowUserToAddRows = False
        Me.dgvInstitutionSuggestions.AllowUserToDeleteRows = False
        Me.dgvInstitutionSuggestions.AllowUserToOrderColumns = True
        Me.dgvInstitutionSuggestions.AllowUserToResizeRows = False
        Me.dgvInstitutionSuggestions.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dgvInstitutionSuggestions.BackgroundColor = System.Drawing.Color.Tan
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInstitutionSuggestions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvInstitutionSuggestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInstitutionSuggestions.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvInstitutionSuggestions.GridColor = System.Drawing.Color.Linen
        Me.dgvInstitutionSuggestions.Location = New System.Drawing.Point(8, 32)
        Me.dgvInstitutionSuggestions.MultiSelect = False
        Me.dgvInstitutionSuggestions.Name = "dgvInstitutionSuggestions"
        Me.dgvInstitutionSuggestions.ReadOnly = True
        Me.dgvInstitutionSuggestions.RowHeadersVisible = False
        Me.dgvInstitutionSuggestions.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.dgvInstitutionSuggestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInstitutionSuggestions.Size = New System.Drawing.Size(1049, 152)
        Me.dgvInstitutionSuggestions.TabIndex = 276
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(5, 601)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(442, 13)
        Me.Label19.TabIndex = 314
        Me.Label19.Text = "***If approving with modifications, please make modifications before clicking App" & _
    "rove button."
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(5, 625)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(78, 13)
        Me.Label20.TabIndex = 316
        Me.Label20.Text = "Deny Message"
        '
        'txtDenyMessage
        '
        Me.txtDenyMessage.Enabled = False
        Me.txtDenyMessage.Location = New System.Drawing.Point(93, 622)
        Me.txtDenyMessage.Name = "txtDenyMessage"
        Me.txtDenyMessage.Size = New System.Drawing.Size(524, 20)
        Me.txtDenyMessage.TabIndex = 315
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(5, 645)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(566, 13)
        Me.Label21.TabIndex = 317
        Me.Label21.Text = "***If denying, please provide a short message back tot he requestor (ie- ""This is" & _
    " the same as [Existing Institute Name]"")."
        '
        'WA_InstitutionSuggestions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtDenyMessage)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.btnDeny)
        Me.Controls.Add(Me.btnApprove)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtFromField)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtIdentifier)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtFromForm)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtSuggestedBy)
        Me.Controls.Add(Me.btnHideApproved)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtTelephone)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtPOCRole)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtPOCName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtZIP)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAddress4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAddress3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAddress2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAddress1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.dgvInstitutionSuggestions)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WA_InstitutionSuggestions"
        Me.Size = New System.Drawing.Size(1060, 748)
        CType(Me.dgvInstitutionSuggestions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvInstitutionSuggestions As DataWarehouse.dgvSingleRow
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtNotes As DataWarehouse.TextBox_
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtFax As DataWarehouse.TextBox_
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTelephone As DataWarehouse.TextBox_
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtPOCRole As DataWarehouse.TextBox_
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPOCName As DataWarehouse.TextBox_
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtZIP As DataWarehouse.TextBox_
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtState As DataWarehouse.TextBox_
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCity As DataWarehouse.TextBox_
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAddress4 As DataWarehouse.TextBox_
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAddress3 As DataWarehouse.TextBox_
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAddress2 As DataWarehouse.TextBox_
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAddress1 As DataWarehouse.TextBox_
    Friend WithEvents txtName As DataWarehouse.TextBox_
    Friend WithEvents btnHideApproved As DataWarehouse.Button_
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtFromField As DataWarehouse.TextBox_
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtIdentifier As DataWarehouse.TextBox_
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtFromForm As DataWarehouse.TextBox_
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtSuggestedBy As DataWarehouse.TextBox_
    Friend WithEvents btnApprove As DataWarehouse.Button_
    Friend WithEvents btnDeny As DataWarehouse.Button_
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtDenyMessage As DataWarehouse.TextBox_
    Friend WithEvents Label21 As System.Windows.Forms.Label

End Class
