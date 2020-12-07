<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PU_Subject_RelWithSimDx
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDelete = New DataWarehouse.Button_()
        Me.btnEdit = New DataWarehouse.Button_()
        Me.btnAdd = New DataWarehouse.Button_()
        Me.txtICDCode = New DataWarehouse.TextBox_()
        Me.txtICDText = New DataWarehouse.TextBox_()
        Me.cmbRace = New DataWarehouse.ComboBox_()
        Me.txtAgeAtDx = New DataWarehouse.TextBoxInteger()
        Me.cmbRelation = New DataWarehouse.ComboBox_()
        Me.txtLevelOfEd = New DataWarehouse.TextBox_()
        Me.dgvRelWithSimDx = New DataWarehouse.dgvSingleRow()
        CType(Me.dgvRelWithSimDx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Relation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(150, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Age at Dx"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(231, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Level of Education"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(404, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Race"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(150, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "ICD Text"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "ICD Code"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(294, 254)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(135, 23)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Delete Selected Record"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(153, 254)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(135, 23)
        Me.btnEdit.TabIndex = 14
        Me.btnEdit.Text = "Edit Selected Record"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 254)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(135, 23)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add New Record"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtICDCode
        '
        Me.txtICDCode.BackColor = System.Drawing.Color.LightGray
        Me.txtICDCode.Enabled = False
        Me.txtICDCode.Location = New System.Drawing.Point(12, 228)
        Me.txtICDCode.Name = "txtICDCode"
        Me.txtICDCode.Size = New System.Drawing.Size(135, 20)
        Me.txtICDCode.TabIndex = 11
        '
        'txtICDText
        '
        Me.txtICDText.BackColor = System.Drawing.Color.LightGray
        Me.txtICDText.Enabled = False
        Me.txtICDText.Location = New System.Drawing.Point(153, 228)
        Me.txtICDText.Name = "txtICDText"
        Me.txtICDText.Size = New System.Drawing.Size(779, 20)
        Me.txtICDText.TabIndex = 9
        '
        'cmbRace
        '
        Me.cmbRace.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbRace.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRace.FormattingEnabled = True
        Me.cmbRace.Location = New System.Drawing.Point(407, 188)
        Me.cmbRace.Name = "cmbRace"
        Me.cmbRace.Size = New System.Drawing.Size(135, 21)
        Me.cmbRace.TabIndex = 7
        '
        'txtAgeAtDx
        '
        Me.txtAgeAtDx.Location = New System.Drawing.Point(153, 189)
        Me.txtAgeAtDx.Name = "txtAgeAtDx"
        Me.txtAgeAtDx.Size = New System.Drawing.Size(75, 20)
        Me.txtAgeAtDx.TabIndex = 4
        '
        'cmbRelation
        '
        Me.cmbRelation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbRelation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRelation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRelation.FormattingEnabled = True
        Me.cmbRelation.Location = New System.Drawing.Point(12, 188)
        Me.cmbRelation.Name = "cmbRelation"
        Me.cmbRelation.Size = New System.Drawing.Size(135, 21)
        Me.cmbRelation.TabIndex = 2
        '
        'txtLevelOfEd
        '
        Me.txtLevelOfEd.Location = New System.Drawing.Point(234, 189)
        Me.txtLevelOfEd.Name = "txtLevelOfEd"
        Me.txtLevelOfEd.Size = New System.Drawing.Size(167, 20)
        Me.txtLevelOfEd.TabIndex = 1
        '
        'dgvRelWithSimDx
        '
        Me.dgvRelWithSimDx.AllowUserToAddRows = False
        Me.dgvRelWithSimDx.AllowUserToDeleteRows = False
        Me.dgvRelWithSimDx.AllowUserToOrderColumns = True
        Me.dgvRelWithSimDx.AllowUserToResizeRows = False
        Me.dgvRelWithSimDx.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dgvRelWithSimDx.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvRelWithSimDx.BackgroundColor = System.Drawing.Color.Tan
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRelWithSimDx.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRelWithSimDx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRelWithSimDx.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRelWithSimDx.GridColor = System.Drawing.Color.Linen
        Me.dgvRelWithSimDx.Location = New System.Drawing.Point(12, 12)
        Me.dgvRelWithSimDx.MultiSelect = False
        Me.dgvRelWithSimDx.Name = "dgvRelWithSimDx"
        Me.dgvRelWithSimDx.ReadOnly = True
        Me.dgvRelWithSimDx.RowHeadersVisible = False
        Me.dgvRelWithSimDx.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.dgvRelWithSimDx.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRelWithSimDx.Size = New System.Drawing.Size(920, 157)
        Me.dgvRelWithSimDx.TabIndex = 0
        '
        'PU_Subject_RelWithSimDx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(944, 282)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtICDCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtICDText)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbRace)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAgeAtDx)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbRelation)
        Me.Controls.Add(Me.txtLevelOfEd)
        Me.Controls.Add(Me.dgvRelWithSimDx)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PU_Subject_RelWithSimDx"
        Me.Text = "Relatives With Similar Diagnoses"
        CType(Me.dgvRelWithSimDx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvRelWithSimDx As DataWarehouse.dgvSingleRow
    Friend WithEvents txtLevelOfEd As DataWarehouse.TextBox_
    Friend WithEvents cmbRelation As DataWarehouse.ComboBox_
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAgeAtDx As DataWarehouse.TextBoxInteger
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbRace As DataWarehouse.ComboBox_
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtICDText As DataWarehouse.TextBox_
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtICDCode As DataWarehouse.TextBox_
    Friend WithEvents btnAdd As DataWarehouse.Button_
    Friend WithEvents btnEdit As DataWarehouse.Button_
    Friend WithEvents btnDelete As DataWarehouse.Button_
End Class
