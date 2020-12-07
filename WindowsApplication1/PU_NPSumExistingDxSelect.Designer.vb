<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PU_NPSumExistingDxSelect
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.chkHideNonBrain = New DataWarehouse.CheckBox_()
        Me.btnAdd = New DataWarehouse.Button_()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnCancel = New DataWarehouse.Button_()
        Me.btnApply = New DataWarehouse.Button_()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDxText = New DataWarehouse.TextBox_()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDxCode = New DataWarehouse.TextBox_()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDxCodeType = New DataWarehouse.TextBox_()
        Me.btnClearFilter = New DataWarehouse.Button_()
        Me.btnApplyFilter = New DataWarehouse.Button_()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTerm4 = New DataWarehouse.TextBox_()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTerm3 = New DataWarehouse.TextBox_()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTerm2 = New DataWarehouse.TextBox_()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTerm1 = New DataWarehouse.TextBox_()
        Me.dgvDx = New DataWarehouse.dgvSingleRow()
        CType(Me.dgvDx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkHideNonBrain
        '
        Me.chkHideNonBrain.AutoSize = True
        Me.chkHideNonBrain.BackColor = System.Drawing.Color.Tan
        Me.chkHideNonBrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkHideNonBrain.Location = New System.Drawing.Point(835, 40)
        Me.chkHideNonBrain.Name = "chkHideNonBrain"
        Me.chkHideNonBrain.Size = New System.Drawing.Size(148, 17)
        Me.chkHideNonBrain.TabIndex = 240
        Me.chkHideNonBrain.Text = "Hide Non-Brain Diagnoses"
        Me.chkHideNonBrain.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(128, 471)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(110, 23)
        Me.btnAdd.TabIndex = 239
        Me.btnAdd.Text = "Add New Dx"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(576, 13)
        Me.Label11.TabIndex = 230
        Me.Label11.Text = "*Terms 2-4 are checked for matches against the Dx Text column only and may be use" &
    "d to further refine the below results."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(577, 13)
        Me.Label10.TabIndex = 229
        Me.Label10.Text = "* Term 1 is checked for matches against both the Dx Code and Dx Text columns and " &
    "is required to filter the below results."
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(244, 471)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(110, 23)
        Me.btnCancel.TabIndex = 238
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Enabled = False
        Me.btnApply.Location = New System.Drawing.Point(12, 471)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(110, 23)
        Me.btnApply.TabIndex = 237
        Me.btnApply.Text = "Apply Selected Dx"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(165, 429)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 228
        Me.Label7.Text = "Dx Text"
        '
        'txtDxText
        '
        Me.txtDxText.Enabled = False
        Me.txtDxText.Location = New System.Drawing.Point(168, 445)
        Me.txtDxText.Name = "txtDxText"
        Me.txtDxText.Size = New System.Drawing.Size(815, 20)
        Me.txtDxText.TabIndex = 227
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(87, 429)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 226
        Me.Label6.Text = "Dx Code"
        '
        'txtDxCode
        '
        Me.txtDxCode.Enabled = False
        Me.txtDxCode.Location = New System.Drawing.Point(90, 445)
        Me.txtDxCode.Name = "txtDxCode"
        Me.txtDxCode.Size = New System.Drawing.Size(72, 20)
        Me.txtDxCode.TabIndex = 225
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 429)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 224
        Me.Label5.Text = "Dx Code Type"
        '
        'txtDxCodeType
        '
        Me.txtDxCodeType.Enabled = False
        Me.txtDxCodeType.Location = New System.Drawing.Point(12, 445)
        Me.txtDxCodeType.Name = "txtDxCodeType"
        Me.txtDxCodeType.Size = New System.Drawing.Size(72, 20)
        Me.txtDxCodeType.TabIndex = 223
        '
        'btnClearFilter
        '
        Me.btnClearFilter.Location = New System.Drawing.Point(720, 4)
        Me.btnClearFilter.Name = "btnClearFilter"
        Me.btnClearFilter.Size = New System.Drawing.Size(91, 23)
        Me.btnClearFilter.TabIndex = 236
        Me.btnClearFilter.Text = "Clear Filter(s)"
        Me.btnClearFilter.UseVisualStyleBackColor = True
        '
        'btnApplyFilter
        '
        Me.btnApplyFilter.Location = New System.Drawing.Point(623, 4)
        Me.btnApplyFilter.Name = "btnApplyFilter"
        Me.btnApplyFilter.Size = New System.Drawing.Size(91, 23)
        Me.btnApplyFilter.TabIndex = 235
        Me.btnApplyFilter.Text = "Apply Filter(s)"
        Me.btnApplyFilter.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(462, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 222
        Me.Label4.Text = "Term 4"
        '
        'txtTerm4
        '
        Me.txtTerm4.Enabled = False
        Me.txtTerm4.Location = New System.Drawing.Point(506, 6)
        Me.txtTerm4.Name = "txtTerm4"
        Me.txtTerm4.Size = New System.Drawing.Size(100, 20)
        Me.txtTerm4.TabIndex = 234
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(312, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 221
        Me.Label3.Text = "Term 3"
        '
        'txtTerm3
        '
        Me.txtTerm3.Enabled = False
        Me.txtTerm3.Location = New System.Drawing.Point(356, 6)
        Me.txtTerm3.Name = "txtTerm3"
        Me.txtTerm3.Size = New System.Drawing.Size(100, 20)
        Me.txtTerm3.TabIndex = 233
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(162, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 220
        Me.Label2.Text = "Term 2"
        '
        'txtTerm2
        '
        Me.txtTerm2.Enabled = False
        Me.txtTerm2.Location = New System.Drawing.Point(206, 6)
        Me.txtTerm2.Name = "txtTerm2"
        Me.txtTerm2.Size = New System.Drawing.Size(100, 20)
        Me.txtTerm2.TabIndex = 232
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 219
        Me.Label1.Text = "Term 1"
        '
        'txtTerm1
        '
        Me.txtTerm1.Location = New System.Drawing.Point(56, 6)
        Me.txtTerm1.Name = "txtTerm1"
        Me.txtTerm1.Size = New System.Drawing.Size(100, 20)
        Me.txtTerm1.TabIndex = 231
        '
        'dgvDx
        '
        Me.dgvDx.AllowUserToAddRows = False
        Me.dgvDx.AllowUserToDeleteRows = False
        Me.dgvDx.AllowUserToOrderColumns = True
        Me.dgvDx.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Beige
        Me.dgvDx.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDx.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvDx.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvDx.BackgroundColor = System.Drawing.Color.Tan
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDx.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDx.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDx.GridColor = System.Drawing.Color.Linen
        Me.dgvDx.Location = New System.Drawing.Point(12, 58)
        Me.dgvDx.MultiSelect = False
        Me.dgvDx.Name = "dgvDx"
        Me.dgvDx.ReadOnly = True
        Me.dgvDx.RowHeadersVisible = False
        Me.dgvDx.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.dgvDx.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDx.Size = New System.Drawing.Size(971, 368)
        Me.dgvDx.TabIndex = 218
        '
        'PU_NPSumExistingDxSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(992, 499)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkHideNonBrain)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDxText)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDxCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDxCodeType)
        Me.Controls.Add(Me.btnClearFilter)
        Me.Controls.Add(Me.btnApplyFilter)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTerm4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTerm3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTerm2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTerm1)
        Me.Controls.Add(Me.dgvDx)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "PU_NPSumExistingDxSelect"
        Me.Text = "Existing Subject ICD-9 Diagnoses"
        CType(Me.dgvDx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkHideNonBrain As CheckBox_
    Friend WithEvents btnAdd As Button_
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnCancel As Button_
    Friend WithEvents btnApply As Button_
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDxText As TextBox_
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDxCode As TextBox_
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDxCodeType As TextBox_
    Friend WithEvents btnClearFilter As Button_
    Friend WithEvents btnApplyFilter As Button_
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTerm4 As TextBox_
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTerm3 As TextBox_
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTerm2 As TextBox_
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTerm1 As TextBox_
    Friend WithEvents dgvDx As dgvSingleRow
End Class
