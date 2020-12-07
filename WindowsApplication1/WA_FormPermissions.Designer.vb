<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WA_FormPermissions
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvFormPermissions = New System.Windows.Forms.DataGridView()
        Me.btnEdit = New DataWarehouse.Button_()
        CType(Me.dgvFormPermissions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 40)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Form Permissions"
        '
        'dgvFormPermissions
        '
        Me.dgvFormPermissions.AllowUserToAddRows = False
        Me.dgvFormPermissions.AllowUserToDeleteRows = False
        Me.dgvFormPermissions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvFormPermissions.BackgroundColor = System.Drawing.Color.Tan
        Me.dgvFormPermissions.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dgvFormPermissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFormPermissions.Location = New System.Drawing.Point(4, 54)
        Me.dgvFormPermissions.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvFormPermissions.MultiSelect = False
        Me.dgvFormPermissions.Name = "dgvFormPermissions"
        Me.dgvFormPermissions.ReadOnly = True
        Me.dgvFormPermissions.RowHeadersVisible = False
        Me.dgvFormPermissions.RowHeadersWidth = 62
        Me.dgvFormPermissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFormPermissions.Size = New System.Drawing.Size(1683, 935)
        Me.dgvFormPermissions.TabIndex = 6
        '
        'btnEdit
        '
        Me.btnEdit.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnEdit.Location = New System.Drawing.Point(4, 998)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(284, 35)
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.Text = "Add/Remove Roles"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'WA_FormPermissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvFormPermissions)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "WA_FormPermissions"
        Me.Size = New System.Drawing.Size(1692, 1038)
        CType(Me.dgvFormPermissions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEdit As Button_
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvFormPermissions As DataGridView
End Class
