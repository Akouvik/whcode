<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WA_Institutions
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Filter = New System.Windows.Forms.Label()
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
        Me.btnEdit = New DataWarehouse.Button_()
        Me.txtNotes = New DataWarehouse.TextBox_()
        Me.txtFax = New DataWarehouse.TextBox_()
        Me.txtTelephone = New DataWarehouse.TextBox_()
        Me.txtPOCRole = New DataWarehouse.TextBox_()
        Me.txtPOCName = New DataWarehouse.TextBox_()
        Me.txtZip = New DataWarehouse.TextBox_()
        Me.txtState = New DataWarehouse.TextBox_()
        Me.txtCity = New DataWarehouse.TextBox_()
        Me.txtAddress4 = New DataWarehouse.TextBox_()
        Me.txtAddress3 = New DataWarehouse.TextBox_()
        Me.txtAddress2 = New DataWarehouse.TextBox_()
        Me.txtAddress1 = New DataWarehouse.TextBox_()
        Me.txtInstitute = New DataWarehouse.TextBox_()
        Me.txtFilter = New DataWarehouse.TextBox_()
        Me.btnAdd = New DataWarehouse.Button_()
        Me.dgvInstitutions = New DataWarehouse.dgvSingleRow()
        CType(Me.dgvInstitutions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 29)
        Me.Label1.TabIndex = 274
        Me.Label1.Text = "Institutions"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(407, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 13)
        Me.Label2.TabIndex = 276
        Me.Label2.Text = "Double-click a record below to view/edit full record."
        '
        'Filter
        '
        Me.Filter.AutoSize = True
        Me.Filter.Location = New System.Drawing.Point(4, 34)
        Me.Filter.Name = "Filter"
        Me.Filter.Size = New System.Drawing.Size(29, 13)
        Me.Filter.TabIndex = 278
        Me.Filter.Text = "Filter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 361)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 281
        Me.Label3.Text = "Institute"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 380)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 283
        Me.Label4.Text = "Address 1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 399)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 285
        Me.Label5.Text = "Address 2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 437)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 289
        Me.Label6.Text = "Address 4"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 418)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 287
        Me.Label7.Text = "Address 3"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(488, 418)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 13)
        Me.Label8.TabIndex = 295
        Me.Label8.Text = "Zip"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(488, 399)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 293
        Me.Label9.Text = "State"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(488, 380)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 13)
        Me.Label10.TabIndex = 291
        Me.Label10.Text = "City"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(488, 463)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 299
        Me.Label11.Text = "POC Role"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(4, 463)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 297
        Me.Label12.Text = "POC Name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(488, 482)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 13)
        Me.Label13.TabIndex = 303
        Me.Label13.Text = "Fax"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(4, 482)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 301
        Me.Label14.Text = "Telephone"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(4, 508)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 13)
        Me.Label15.TabIndex = 305
        Me.Label15.Text = "Notes"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(138, 331)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(125, 23)
        Me.btnEdit.TabIndex = 306
        Me.btnEdit.Text = "Edit Selected Record"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(70, 505)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(889, 60)
        Me.txtNotes.TabIndex = 304
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(548, 479)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(411, 20)
        Me.txtFax.TabIndex = 302
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(70, 479)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(411, 20)
        Me.txtTelephone.TabIndex = 300
        '
        'txtPOCRole
        '
        Me.txtPOCRole.Location = New System.Drawing.Point(548, 460)
        Me.txtPOCRole.Name = "txtPOCRole"
        Me.txtPOCRole.Size = New System.Drawing.Size(411, 20)
        Me.txtPOCRole.TabIndex = 298
        '
        'txtPOCName
        '
        Me.txtPOCName.Location = New System.Drawing.Point(70, 460)
        Me.txtPOCName.Name = "txtPOCName"
        Me.txtPOCName.Size = New System.Drawing.Size(411, 20)
        Me.txtPOCName.TabIndex = 296
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(548, 415)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(411, 20)
        Me.txtZip.TabIndex = 294
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(548, 396)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(411, 20)
        Me.txtState.TabIndex = 292
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(548, 377)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(411, 20)
        Me.txtCity.TabIndex = 290
        '
        'txtAddress4
        '
        Me.txtAddress4.Location = New System.Drawing.Point(70, 434)
        Me.txtAddress4.Name = "txtAddress4"
        Me.txtAddress4.Size = New System.Drawing.Size(411, 20)
        Me.txtAddress4.TabIndex = 288
        '
        'txtAddress3
        '
        Me.txtAddress3.Location = New System.Drawing.Point(70, 415)
        Me.txtAddress3.Name = "txtAddress3"
        Me.txtAddress3.Size = New System.Drawing.Size(411, 20)
        Me.txtAddress3.TabIndex = 286
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(70, 396)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(411, 20)
        Me.txtAddress2.TabIndex = 284
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New System.Drawing.Point(70, 377)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(411, 20)
        Me.txtAddress1.TabIndex = 282
        '
        'txtInstitute
        '
        Me.txtInstitute.Location = New System.Drawing.Point(70, 358)
        Me.txtInstitute.Name = "txtInstitute"
        Me.txtInstitute.Size = New System.Drawing.Size(411, 20)
        Me.txtInstitute.TabIndex = 280
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(39, 31)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(278, 20)
        Me.txtFilter.TabIndex = 279
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(7, 331)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(125, 23)
        Me.btnAdd.TabIndex = 277
        Me.btnAdd.Text = "Add New Record"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dgvInstitutions
        '
        Me.dgvInstitutions.AllowUserToAddRows = False
        Me.dgvInstitutions.AllowUserToDeleteRows = False
        Me.dgvInstitutions.AllowUserToOrderColumns = True
        Me.dgvInstitutions.AllowUserToResizeRows = False
        Me.dgvInstitutions.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dgvInstitutions.BackgroundColor = System.Drawing.Color.Tan
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInstitutions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvInstitutions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInstitutions.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvInstitutions.GridColor = System.Drawing.Color.Linen
        Me.dgvInstitutions.Location = New System.Drawing.Point(7, 57)
        Me.dgvInstitutions.MultiSelect = False
        Me.dgvInstitutions.Name = "dgvInstitutions"
        Me.dgvInstitutions.ReadOnly = True
        Me.dgvInstitutions.RowHeadersVisible = False
        Me.dgvInstitutions.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.dgvInstitutions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvInstitutions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInstitutions.Size = New System.Drawing.Size(1049, 268)
        Me.dgvInstitutions.TabIndex = 275
        '
        'WA_Institutions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtTelephone)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtPOCRole)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPOCName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAddress4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAddress3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAddress2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAddress1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtInstitute)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.Filter)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvInstitutions)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WA_Institutions"
        Me.Size = New System.Drawing.Size(1060, 800)
        CType(Me.dgvInstitutions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvInstitutions As DataWarehouse.dgvSingleRow
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As DataWarehouse.Button_
    Friend WithEvents Filter As System.Windows.Forms.Label
    Friend WithEvents txtFilter As DataWarehouse.TextBox_
    Friend WithEvents txtInstitute As DataWarehouse.TextBox_
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAddress1 As DataWarehouse.TextBox_
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAddress2 As DataWarehouse.TextBox_
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAddress4 As DataWarehouse.TextBox_
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAddress3 As DataWarehouse.TextBox_
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtZip As DataWarehouse.TextBox_
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtState As DataWarehouse.TextBox_
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCity As DataWarehouse.TextBox_
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPOCRole As DataWarehouse.TextBox_
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPOCName As DataWarehouse.TextBox_
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtFax As DataWarehouse.TextBox_
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtTelephone As DataWarehouse.TextBox_
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtNotes As DataWarehouse.TextBox_
    Friend WithEvents btnEdit As DataWarehouse.Button_

End Class
