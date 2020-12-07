<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WA_ReportsSplash
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Josh = New DataWarehouse.Button_()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(528, 25)
        Me.Label2.TabIndex = 196
        Me.Label2.Text = "Please select a module from the tree menu on the left."
        '
        'Josh
        '
        Me.Josh.Location = New System.Drawing.Point(252, 41)
        Me.Josh.Name = "Josh"
        Me.Josh.Size = New System.Drawing.Size(75, 23)
        Me.Josh.TabIndex = 197
        Me.Josh.Text = "Button_1"
        Me.Josh.UseVisualStyleBackColor = True
        '
        'WA_ReportsSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.Controls.Add(Me.Josh)
        Me.Controls.Add(Me.Label2)
        Me.Name = "WA_ReportsSplash"
        Me.Size = New System.Drawing.Size(539, 74)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Josh As Button_
End Class
