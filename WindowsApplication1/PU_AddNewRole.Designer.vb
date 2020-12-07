<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PU_AddNewRole
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
        Me.btnCancel = New DataWarehouse.Button_()
        Me.btnAddRole = New DataWarehouse.Button_()
        Me.cmbAddNewRole = New DataWarehouse.ComboBox_()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(95, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Role To Add"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(145, 46)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(66, 21)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAddRole
        '
        Me.btnAddRole.Location = New System.Drawing.Point(75, 46)
        Me.btnAddRole.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddRole.Name = "btnAddRole"
        Me.btnAddRole.Size = New System.Drawing.Size(67, 21)
        Me.btnAddRole.TabIndex = 2
        Me.btnAddRole.Text = "Add"
        Me.btnAddRole.UseVisualStyleBackColor = True
        '
        'cmbAddNewRole
        '
        Me.cmbAddNewRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbAddNewRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAddNewRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAddNewRole.FormattingEnabled = True
        Me.cmbAddNewRole.Location = New System.Drawing.Point(66, 24)
        Me.cmbAddNewRole.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbAddNewRole.Name = "cmbAddNewRole"
        Me.cmbAddNewRole.Size = New System.Drawing.Size(165, 21)
        Me.cmbAddNewRole.TabIndex = 0
        '
        'PU_AddNewRole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(287, 73)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAddRole)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbAddNewRole)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "PU_AddNewRole"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add New Role"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbAddNewRole As ComboBox_
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddRole As Button_
    Friend WithEvents btnCancel As Button_
End Class
