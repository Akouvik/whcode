<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pu_FormPermissions
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnClose = New DataWarehouse.Button_()
        Me.btnRemove = New DataWarehouse.Button_()
        Me.btnAddPermissions = New DataWarehouse.Button_()
        Me.dgvFormPermissions = New DataWarehouse.dgvSingleRow()
        CType(Me.dgvFormPermissions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(542, 601)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(250, 35)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(283, 601)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(250, 35)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "Remove Selected Permission"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAddPermissions
        '
        Me.btnAddPermissions.Location = New System.Drawing.Point(24, 601)
        Me.btnAddPermissions.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddPermissions.Name = "btnAddPermissions"
        Me.btnAddPermissions.Size = New System.Drawing.Size(250, 35)
        Me.btnAddPermissions.TabIndex = 1
        Me.btnAddPermissions.Text = "Add Permission"
        Me.btnAddPermissions.UseVisualStyleBackColor = True
        '
        'dgvFormPermissions
        '
        Me.dgvFormPermissions.AllowUserToAddRows = False
        Me.dgvFormPermissions.AllowUserToDeleteRows = False
        Me.dgvFormPermissions.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige
        Me.dgvFormPermissions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFormPermissions.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dgvFormPermissions.BackgroundColor = System.Drawing.Color.Tan
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFormPermissions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvFormPermissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFormPermissions.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvFormPermissions.GridColor = System.Drawing.Color.Linen
        Me.dgvFormPermissions.Location = New System.Drawing.Point(13, 14)
        Me.dgvFormPermissions.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvFormPermissions.MultiSelect = False
        Me.dgvFormPermissions.Name = "dgvFormPermissions"
        Me.dgvFormPermissions.ReadOnly = True
        Me.dgvFormPermissions.RowHeadersVisible = False
        Me.dgvFormPermissions.RowHeadersWidth = 62
        Me.dgvFormPermissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFormPermissions.Size = New System.Drawing.Size(806, 577)
        Me.dgvFormPermissions.TabIndex = 0
        '
        'pu_FormPermissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(840, 725)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAddPermissions)
        Me.Controls.Add(Me.dgvFormPermissions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "pu_FormPermissions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form Permissions"
        CType(Me.dgvFormPermissions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvFormPermissions As dgvSingleRow
    Friend WithEvents btnAddPermissions As Button_
    Friend WithEvents btnRemove As Button_
    Friend WithEvents btnClose As Button_
End Class
