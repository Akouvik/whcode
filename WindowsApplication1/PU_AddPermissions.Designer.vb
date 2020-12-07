<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PU_AddPermissions
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbPermissionType = New DataWarehouse.ComboBox_()
        Me.cmbPermission = New DataWarehouse.ComboBox_()
        Me.Button_2 = New DataWarehouse.Button_()
        Me.Button_1 = New DataWarehouse.Button_()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Permission / Role"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Permission Type"
        '
        'cmbPermissionType
        '
        Me.cmbPermissionType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPermissionType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPermissionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPermissionType.FormattingEnabled = True
        Me.cmbPermissionType.Location = New System.Drawing.Point(12, 87)
        Me.cmbPermissionType.Name = "cmbPermissionType"
        Me.cmbPermissionType.Size = New System.Drawing.Size(211, 28)
        Me.cmbPermissionType.TabIndex = 5
        '
        'cmbPermission
        '
        Me.cmbPermission.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPermission.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPermission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPermission.FormattingEnabled = True
        Me.cmbPermission.Location = New System.Drawing.Point(12, 32)
        Me.cmbPermission.Name = "cmbPermission"
        Me.cmbPermission.Size = New System.Drawing.Size(211, 28)
        Me.cmbPermission.TabIndex = 3
        '
        'Button_2
        '
        Me.Button_2.Location = New System.Drawing.Point(27, 132)
        Me.Button_2.Name = "Button_2"
        Me.Button_2.Size = New System.Drawing.Size(82, 32)
        Me.Button_2.TabIndex = 2
        Me.Button_2.Text = "Add"
        Me.Button_2.UseVisualStyleBackColor = True
        '
        'Button_1
        '
        Me.Button_1.Location = New System.Drawing.Point(115, 132)
        Me.Button_1.Name = "Button_1"
        Me.Button_1.Size = New System.Drawing.Size(82, 32)
        Me.Button_1.TabIndex = 1
        Me.Button_1.Text = "Cancel"
        Me.Button_1.UseVisualStyleBackColor = True
        '
        'PU_AddPermissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(240, 175)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbPermissionType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbPermission)
        Me.Controls.Add(Me.Button_2)
        Me.Controls.Add(Me.Button_1)
        Me.Name = "PU_AddPermissions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Permissions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_1 As Button_
    Friend WithEvents Button_2 As Button_
    Friend WithEvents cmbPermission As ComboBox_
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbPermissionType As ComboBox_
End Class
