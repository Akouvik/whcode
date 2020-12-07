<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WA_TissueTaskerReport
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
        Me.chkFilterTasks = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btnFilterDGV = New DataWarehouse.Button_()
        Me.btnResetDGV = New DataWarehouse.Button_()
        Me.txtFilterString = New DataWarehouse.TextBox_()
        Me.btnAddTissueTasker = New DataWarehouse.Button_()
        Me.dgvTissueTaskers = New DataWarehouse.dgvSingleRow()
        Me.chkShowMyTasks = New System.Windows.Forms.CheckBox()
        CType(Me.dgvTissueTaskers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 29)
        Me.Label1.TabIndex = 273
        Me.Label1.Text = "Tissue Taskers"
        '
        'chkFilterTasks
        '
        Me.chkFilterTasks.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkFilterTasks.AutoSize = True
        Me.chkFilterTasks.Location = New System.Drawing.Point(924, 16)
        Me.chkFilterTasks.Name = "chkFilterTasks"
        Me.chkFilterTasks.Size = New System.Drawing.Size(124, 23)
        Me.chkFilterTasks.TabIndex = 274
        Me.chkFilterTasks.Text = "Hide Completed Tasks"
        Me.chkFilterTasks.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(357, 345)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 13)
        Me.Label2.TabIndex = 275
        Me.Label2.Text = "***Add new taskers by creating a new project***"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(266, 21)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(41, 13)
        Me.Label24.TabIndex = 406
        Me.Label24.Text = "Search"
        '
        'btnFilterDGV
        '
        Me.btnFilterDGV.Location = New System.Drawing.Point(541, 16)
        Me.btnFilterDGV.Name = "btnFilterDGV"
        Me.btnFilterDGV.Size = New System.Drawing.Size(75, 23)
        Me.btnFilterDGV.TabIndex = 409
        Me.btnFilterDGV.Text = "Filter"
        Me.btnFilterDGV.UseVisualStyleBackColor = True
        '
        'btnResetDGV
        '
        Me.btnResetDGV.Location = New System.Drawing.Point(622, 16)
        Me.btnResetDGV.Name = "btnResetDGV"
        Me.btnResetDGV.Size = New System.Drawing.Size(75, 23)
        Me.btnResetDGV.TabIndex = 408
        Me.btnResetDGV.Text = "Reset"
        Me.btnResetDGV.UseVisualStyleBackColor = True
        '
        'txtFilterString
        '
        Me.txtFilterString.Location = New System.Drawing.Point(313, 18)
        Me.txtFilterString.Name = "txtFilterString"
        Me.txtFilterString.Size = New System.Drawing.Size(222, 20)
        Me.txtFilterString.TabIndex = 407
        '
        'btnAddTissueTasker
        '
        Me.btnAddTissueTasker.Location = New System.Drawing.Point(411, 361)
        Me.btnAddTissueTasker.Name = "btnAddTissueTasker"
        Me.btnAddTissueTasker.Size = New System.Drawing.Size(124, 23)
        Me.btnAddTissueTasker.TabIndex = 276
        Me.btnAddTissueTasker.Text = "Add Tissue Tasker"
        Me.btnAddTissueTasker.UseVisualStyleBackColor = True
        Me.btnAddTissueTasker.Visible = False
        '
        'dgvTissueTaskers
        '
        Me.dgvTissueTaskers.AllowUserToAddRows = False
        Me.dgvTissueTaskers.AllowUserToDeleteRows = False
        Me.dgvTissueTaskers.AllowUserToOrderColumns = True
        Me.dgvTissueTaskers.AllowUserToResizeRows = False
        Me.dgvTissueTaskers.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dgvTissueTaskers.BackgroundColor = System.Drawing.Color.Tan
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTissueTaskers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTissueTaskers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTissueTaskers.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTissueTaskers.GridColor = System.Drawing.Color.Linen
        Me.dgvTissueTaskers.Location = New System.Drawing.Point(12, 45)
        Me.dgvTissueTaskers.MultiSelect = False
        Me.dgvTissueTaskers.Name = "dgvTissueTaskers"
        Me.dgvTissueTaskers.ReadOnly = True
        Me.dgvTissueTaskers.RowHeadersVisible = False
        Me.dgvTissueTaskers.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.dgvTissueTaskers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTissueTaskers.Size = New System.Drawing.Size(1036, 297)
        Me.dgvTissueTaskers.TabIndex = 0
        '
        'chkShowMyTasks
        '
        Me.chkShowMyTasks.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkShowMyTasks.AutoSize = True
        Me.chkShowMyTasks.Location = New System.Drawing.Point(796, 16)
        Me.chkShowMyTasks.Name = "chkShowMyTasks"
        Me.chkShowMyTasks.Size = New System.Drawing.Size(122, 23)
        Me.chkShowMyTasks.TabIndex = 410
        Me.chkShowMyTasks.Text = "Show My Open Tasks"
        Me.chkShowMyTasks.UseVisualStyleBackColor = True
        '
        'WA_TissueTaskerReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(1060, 771)
        Me.Controls.Add(Me.chkShowMyTasks)
        Me.Controls.Add(Me.btnFilterDGV)
        Me.Controls.Add(Me.btnResetDGV)
        Me.Controls.Add(Me.txtFilterString)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.btnAddTissueTasker)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkFilterTasks)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvTissueTaskers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WA_TissueTaskerReport"
        Me.Text = "WA_TissueTaskerReport"
        CType(Me.dgvTissueTaskers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvTissueTaskers As DataWarehouse.dgvSingleRow
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkFilterTasks As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAddTissueTasker As DataWarehouse.Button_
    Friend WithEvents btnFilterDGV As DataWarehouse.Button_
    Friend WithEvents btnResetDGV As DataWarehouse.Button_
    Friend WithEvents txtFilterString As DataWarehouse.TextBox_
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents chkShowMyTasks As CheckBox
End Class
