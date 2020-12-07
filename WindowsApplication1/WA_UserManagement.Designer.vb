<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WA_UserManagement
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
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUserInfo = New System.Windows.Forms.Button()
        Me.bntAdd = New DataWarehouse.Button_()
        Me.chkActive = New DataWarehouse.CheckBox_()
        Me.btnEditRoles = New System.Windows.Forms.Button()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvUsers
        '
        Me.dgvUsers.AllowUserToAddRows = False
        Me.dgvUsers.AllowUserToDeleteRows = False
        Me.dgvUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvUsers.BackgroundColor = System.Drawing.Color.Tan
        Me.dgvUsers.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Location = New System.Drawing.Point(11, 48)
        Me.dgvUsers.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvUsers.MultiSelect = False
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.ReadOnly = True
        Me.dgvUsers.RowHeadersVisible = False
        Me.dgvUsers.RowHeadersWidth = 62
        Me.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsers.Size = New System.Drawing.Size(1549, 832)
        Me.dgvUsers.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User Management"
        '
        'btnUserInfo
        '
        Me.btnUserInfo.Location = New System.Drawing.Point(656, 890)
        Me.btnUserInfo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUserInfo.Name = "btnUserInfo"
        Me.btnUserInfo.Size = New System.Drawing.Size(250, 35)
        Me.btnUserInfo.TabIndex = 3
        Me.btnUserInfo.Text = "Edit User Info"
        Me.btnUserInfo.UseVisualStyleBackColor = True
        '
        'bntAdd
        '
        Me.bntAdd.Location = New System.Drawing.Point(361, 890)
        Me.bntAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bntAdd.Name = "bntAdd"
        Me.bntAdd.Size = New System.Drawing.Size(287, 35)
        Me.bntAdd.TabIndex = 5
        Me.bntAdd.Text = "Add New User"
        Me.bntAdd.UseVisualStyleBackColor = True
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.BackColor = System.Drawing.Color.Tan
        Me.chkActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkActive.Location = New System.Drawing.Point(1392, 19)
        Me.chkActive.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(168, 24)
        Me.chkActive.TabIndex = 2
        Me.chkActive.Text = "Hide Inactive Users"
        Me.chkActive.UseVisualStyleBackColor = False
        '
        'btnEditRoles
        '
        Me.btnEditRoles.Location = New System.Drawing.Point(914, 890)
        Me.btnEditRoles.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEditRoles.Name = "btnEditRoles"
        Me.btnEditRoles.Size = New System.Drawing.Size(250, 35)
        Me.btnEditRoles.TabIndex = 7
        Me.btnEditRoles.Text = "Edit Roles"
        Me.btnEditRoles.UseVisualStyleBackColor = True
        '
        'WA_UserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.Controls.Add(Me.btnEditRoles)
        Me.Controls.Add(Me.bntAdd)
        Me.Controls.Add(Me.btnUserInfo)
        Me.Controls.Add(Me.chkActive)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvUsers)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "WA_UserManagement"
        Me.Size = New System.Drawing.Size(1607, 946)
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents chkActive As CheckBox_
    Friend WithEvents btnUserInfo As Button
    Friend WithEvents bntAdd As Button_
    Friend WithEvents btnEditRoles As Button
End Class
