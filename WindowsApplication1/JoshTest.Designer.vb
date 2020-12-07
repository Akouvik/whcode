<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JoshTest
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
        Me.Admin = New DataWarehouse.CheckBox_()
        Me.Prosector = New DataWarehouse.CheckBox_()
        Me.Close = New DataWarehouse.Button_()
        Me.SuspendLayout()
        '
        'Admin
        '
        Me.Admin.AutoSize = True
        Me.Admin.BackColor = System.Drawing.Color.Tan
        Me.Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Admin.Location = New System.Drawing.Point(12, 37)
        Me.Admin.Name = "Admin"
        Me.Admin.Size = New System.Drawing.Size(52, 17)
        Me.Admin.TabIndex = 0
        Me.Admin.Text = "Admin"
        Me.Admin.UseVisualStyleBackColor = False
        '
        'Prosector
        '
        Me.Prosector.AutoSize = True
        Me.Prosector.BackColor = System.Drawing.Color.Tan
        Me.Prosector.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Prosector.Location = New System.Drawing.Point(12, 54)
        Me.Prosector.Name = "Prosector"
        Me.Prosector.Size = New System.Drawing.Size(68, 17)
        Me.Prosector.TabIndex = 1
        Me.Prosector.Text = "Prosector"
        Me.Prosector.UseVisualStyleBackColor = False
        '
        'Close
        '
        Me.Close.Location = New System.Drawing.Point(12, 245)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(75, 23)
        Me.Close.TabIndex = 2
        Me.Close.Text = "Close"
        Me.Close.UseVisualStyleBackColor = True
        '
        'JoshTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Close)
        Me.Controls.Add(Me.Prosector)
        Me.Controls.Add(Me.Admin)
        Me.Name = "JoshTest"
        Me.Size = New System.Drawing.Size(315, 284)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Admin As CheckBox_
    Friend WithEvents Prosector As CheckBox_
    Friend WithEvents Close As Button_
End Class
