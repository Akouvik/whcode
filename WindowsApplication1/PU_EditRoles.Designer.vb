<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PU_EditRoles
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
        Me.btnCancel = New DataWarehouse.Button_()
        Me.btnAddRole = New DataWarehouse.Button_()
        Me.dgvEditUserRoles = New DataWarehouse.dgvSingleRow()
        Me.btnRemoveRole = New DataWarehouse.Button_()
        CType(Me.dgvEditUserRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(265, 226)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(125, 22)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAddRole
        '
        Me.btnAddRole.Location = New System.Drawing.Point(8, 226)
        Me.btnAddRole.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAddRole.Name = "btnAddRole"
        Me.btnAddRole.Size = New System.Drawing.Size(125, 22)
        Me.btnAddRole.TabIndex = 1
        Me.btnAddRole.Text = "Add Role"
        Me.btnAddRole.UseVisualStyleBackColor = True
        '
        'dgvEditUserRoles
        '
        Me.dgvEditUserRoles.AllowUserToAddRows = False
        Me.dgvEditUserRoles.AllowUserToDeleteRows = False
        Me.dgvEditUserRoles.AllowUserToOrderColumns = True
        Me.dgvEditUserRoles.AllowUserToResizeColumns = False
        Me.dgvEditUserRoles.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige
        Me.dgvEditUserRoles.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEditUserRoles.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvEditUserRoles.BackgroundColor = System.Drawing.Color.Tan
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEditUserRoles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEditUserRoles.ColumnHeadersHeight = 34
        Me.dgvEditUserRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEditUserRoles.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvEditUserRoles.GridColor = System.Drawing.Color.Linen
        Me.dgvEditUserRoles.Location = New System.Drawing.Point(8, 4)
        Me.dgvEditUserRoles.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvEditUserRoles.MultiSelect = False
        Me.dgvEditUserRoles.Name = "dgvEditUserRoles"
        Me.dgvEditUserRoles.ReadOnly = True
        Me.dgvEditUserRoles.RowHeadersVisible = False
        Me.dgvEditUserRoles.RowHeadersWidth = 62
        Me.dgvEditUserRoles.RowTemplate.Height = 28
        Me.dgvEditUserRoles.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvEditUserRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEditUserRoles.Size = New System.Drawing.Size(382, 218)
        Me.dgvEditUserRoles.TabIndex = 0
        '
        'btnRemoveRole
        '
        Me.btnRemoveRole.Location = New System.Drawing.Point(137, 226)
        Me.btnRemoveRole.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRemoveRole.Name = "btnRemoveRole"
        Me.btnRemoveRole.Size = New System.Drawing.Size(125, 22)
        Me.btnRemoveRole.TabIndex = 3
        Me.btnRemoveRole.Text = "Remove Role"
        Me.btnRemoveRole.UseVisualStyleBackColor = True
        '
        'PU_EditRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(397, 254)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnRemoveRole)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAddRole)
        Me.Controls.Add(Me.dgvEditUserRoles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PU_EditRoles"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit User Form"
        CType(Me.dgvEditUserRoles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvEditUserRoles As dgvSingleRow
    Friend WithEvents btnAddRole As Button_
    Friend WithEvents btnCancel As Button_
    Friend WithEvents btnRemoveRole As Button_
End Class
