<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PU_AddDx
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
        Me.txtBrainRelatedRank = New DataWarehouse.TextBoxInteger()
        Me.chkBrainClin = New DataWarehouse.CheckBox_()
        Me.btnOnlineSearch = New DataWarehouse.Button_()
        Me.btnCancel = New DataWarehouse.Button_()
        Me.btnSave = New DataWarehouse.Button_()
        Me.cmbDxMethod = New DataWarehouse.ComboBox_()
        Me.dtDx = New DataWarehouse.TextBoxDatePast()
        Me.txtDxText = New DataWarehouse.TextBox_()
        Me.txtDxCode = New DataWarehouse.TextBox_()
        Me.txtDxCodeType = New DataWarehouse.TextBox_()
        Me.btnClearFilter = New DataWarehouse.Button_()
        Me.btnApplyFilter = New DataWarehouse.Button_()
        Me.txtTerm4 = New DataWarehouse.TextBox_()
        Me.txtTerm3 = New DataWarehouse.TextBox_()
        Me.txtTerm2 = New DataWarehouse.TextBox_()
        Me.txtTerm1 = New DataWarehouse.TextBox_()
        Me.dgvDx = New DataWarehouse.dgvSingleRow()
        CType(Me.dgvDx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Term 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(243, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Term 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(468, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Term 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(693, 20)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Term 4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 521)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Dx Code Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(137, 521)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Dx Code"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(255, 521)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Dx Text"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 581)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Dx Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(137, 581)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 20)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Dx Method"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 51)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(918, 20)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "* Term 1 is checked for matches against both the Dx Code and Dx Text columns and " &
    "is required to filter the below results."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 71)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(919, 20)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "* Terms 2-4 are checked for matches against the Dx Text column only and may be us" &
    "ed to further refine the below results."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(629, 581)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(148, 20)
        Me.Label12.TabIndex = 194
        Me.Label12.Text = "Brain Related Rank"
        '
        'txtBrainRelatedRank
        '
        Me.txtBrainRelatedRank.Location = New System.Drawing.Point(634, 606)
        Me.txtBrainRelatedRank.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBrainRelatedRank.Name = "txtBrainRelatedRank"
        Me.txtBrainRelatedRank.Size = New System.Drawing.Size(148, 26)
        Me.txtBrainRelatedRank.TabIndex = 193
        '
        'chkBrainClin
        '
        Me.chkBrainClin.AutoSize = True
        Me.chkBrainClin.BackColor = System.Drawing.Color.Tan
        Me.chkBrainClin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBrainClin.Location = New System.Drawing.Point(393, 607)
        Me.chkBrainClin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkBrainClin.Name = "chkBrainClin"
        Me.chkBrainClin.Size = New System.Drawing.Size(230, 24)
        Me.chkBrainClin.TabIndex = 192
        Me.chkBrainClin.Text = "Brain Related (or significant)"
        Me.chkBrainClin.UseVisualStyleBackColor = False
        Me.chkBrainClin.Visible = False
        '
        'btnOnlineSearch
        '
        Me.btnOnlineSearch.Location = New System.Drawing.Point(1226, 11)
        Me.btnOnlineSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOnlineSearch.Name = "btnOnlineSearch"
        Me.btnOnlineSearch.Size = New System.Drawing.Size(136, 35)
        Me.btnOnlineSearch.TabIndex = 191
        Me.btnOnlineSearch.Text = "Search Online"
        Me.btnOnlineSearch.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(147, 672)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnCancel.TabIndex = 190
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(25, 672)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 35)
        Me.btnSave.TabIndex = 180
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cmbDxMethod
        '
        Me.cmbDxMethod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDxMethod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDxMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDxMethod.FormattingEnabled = True
        Me.cmbDxMethod.Location = New System.Drawing.Point(142, 606)
        Me.cmbDxMethod.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbDxMethod.Name = "cmbDxMethod"
        Me.cmbDxMethod.Size = New System.Drawing.Size(240, 28)
        Me.cmbDxMethod.TabIndex = 170
        '
        'dtDx
        '
        Me.dtDx.Location = New System.Drawing.Point(25, 606)
        Me.dtDx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtDx.Mask = "00/00/0000"
        Me.dtDx.Name = "dtDx"
        Me.dtDx.Size = New System.Drawing.Size(106, 26)
        Me.dtDx.TabIndex = 160
        Me.dtDx.ValidatingType = GetType(Date)
        '
        'txtDxText
        '
        Me.txtDxText.Enabled = False
        Me.txtDxText.Location = New System.Drawing.Point(259, 546)
        Me.txtDxText.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDxText.Name = "txtDxText"
        Me.txtDxText.Size = New System.Drawing.Size(1220, 26)
        Me.txtDxText.TabIndex = 15
        '
        'txtDxCode
        '
        Me.txtDxCode.Enabled = False
        Me.txtDxCode.Location = New System.Drawing.Point(142, 546)
        Me.txtDxCode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDxCode.Name = "txtDxCode"
        Me.txtDxCode.Size = New System.Drawing.Size(106, 26)
        Me.txtDxCode.TabIndex = 13
        '
        'txtDxCodeType
        '
        Me.txtDxCodeType.Enabled = False
        Me.txtDxCodeType.Location = New System.Drawing.Point(25, 546)
        Me.txtDxCodeType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDxCodeType.Name = "txtDxCodeType"
        Me.txtDxCodeType.Size = New System.Drawing.Size(106, 26)
        Me.txtDxCodeType.TabIndex = 11
        '
        'btnClearFilter
        '
        Me.btnClearFilter.Location = New System.Drawing.Point(1080, 12)
        Me.btnClearFilter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClearFilter.Name = "btnClearFilter"
        Me.btnClearFilter.Size = New System.Drawing.Size(136, 35)
        Me.btnClearFilter.TabIndex = 150
        Me.btnClearFilter.Text = "Clear Filter(s)"
        Me.btnClearFilter.UseVisualStyleBackColor = True
        '
        'btnApplyFilter
        '
        Me.btnApplyFilter.Location = New System.Drawing.Point(934, 12)
        Me.btnApplyFilter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnApplyFilter.Name = "btnApplyFilter"
        Me.btnApplyFilter.Size = New System.Drawing.Size(136, 35)
        Me.btnApplyFilter.TabIndex = 140
        Me.btnApplyFilter.Text = "Apply Filter(s)"
        Me.btnApplyFilter.UseVisualStyleBackColor = True
        '
        'txtTerm4
        '
        Me.txtTerm4.Location = New System.Drawing.Point(759, 15)
        Me.txtTerm4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTerm4.Name = "txtTerm4"
        Me.txtTerm4.Size = New System.Drawing.Size(148, 26)
        Me.txtTerm4.TabIndex = 130
        '
        'txtTerm3
        '
        Me.txtTerm3.Location = New System.Drawing.Point(534, 15)
        Me.txtTerm3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTerm3.Name = "txtTerm3"
        Me.txtTerm3.Size = New System.Drawing.Size(148, 26)
        Me.txtTerm3.TabIndex = 120
        '
        'txtTerm2
        '
        Me.txtTerm2.Location = New System.Drawing.Point(309, 15)
        Me.txtTerm2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTerm2.Name = "txtTerm2"
        Me.txtTerm2.Size = New System.Drawing.Size(148, 26)
        Me.txtTerm2.TabIndex = 110
        '
        'txtTerm1
        '
        Me.txtTerm1.Location = New System.Drawing.Point(84, 15)
        Me.txtTerm1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTerm1.Name = "txtTerm1"
        Me.txtTerm1.Size = New System.Drawing.Size(148, 26)
        Me.txtTerm1.TabIndex = 100
        '
        'dgvDx
        '
        Me.dgvDx.AllowUserToAddRows = False
        Me.dgvDx.AllowUserToDeleteRows = False
        Me.dgvDx.AllowUserToOrderColumns = True
        Me.dgvDx.AllowUserToResizeColumns = False
        Me.dgvDx.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Beige
        Me.dgvDx.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDx.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dgvDx.BackgroundColor = System.Drawing.Color.Tan
        Me.dgvDx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
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
        Me.dgvDx.Location = New System.Drawing.Point(25, 97)
        Me.dgvDx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvDx.MultiSelect = False
        Me.dgvDx.Name = "dgvDx"
        Me.dgvDx.ReadOnly = True
        Me.dgvDx.RowHeadersVisible = False
        Me.dgvDx.RowHeadersWidth = 62
        Me.dgvDx.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.dgvDx.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDx.Size = New System.Drawing.Size(1454, 412)
        Me.dgvDx.TabIndex = 0
        '
        'PU_AddDx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1479, 731)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtBrainRelatedRank)
        Me.Controls.Add(Me.chkBrainClin)
        Me.Controls.Add(Me.btnOnlineSearch)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbDxMethod)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtDx)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "PU_AddDx"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add a Diagnosis"
        CType(Me.dgvDx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDx As DataWarehouse.dgvSingleRow
    Friend WithEvents txtTerm1 As DataWarehouse.TextBox_
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTerm2 As DataWarehouse.TextBox_
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTerm3 As DataWarehouse.TextBox_
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTerm4 As DataWarehouse.TextBox_
    Friend WithEvents btnApplyFilter As DataWarehouse.Button_
    Friend WithEvents btnClearFilter As DataWarehouse.Button_
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDxCodeType As DataWarehouse.TextBox_
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDxCode As DataWarehouse.TextBox_
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDxText As DataWarehouse.TextBox_
    Friend WithEvents dtDx As DataWarehouse.TextBoxDatePast
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbDxMethod As DataWarehouse.ComboBox_
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnSave As DataWarehouse.Button_
    Friend WithEvents btnCancel As DataWarehouse.Button_
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnOnlineSearch As Button_
    Friend WithEvents chkBrainClin As CheckBox_
    Friend WithEvents txtBrainRelatedRank As TextBoxInteger
    Friend WithEvents Label12 As Label
End Class
