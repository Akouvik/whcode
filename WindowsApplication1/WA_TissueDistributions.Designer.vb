<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WA_TissueDistributions
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgvDistribution = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDistribution, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(3, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(245, 29)
        Me.Label12.TabIndex = 200
        Me.Label12.Text = "Tissue Distributions"
        '
        'dgvDistribution
        '
        Me.dgvDistribution.AllowUserToAddRows = False
        Me.dgvDistribution.AllowUserToDeleteRows = False
        Me.dgvDistribution.AllowUserToOrderColumns = True
        Me.dgvDistribution.BackgroundColor = System.Drawing.Color.Tan
        Me.dgvDistribution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDistribution.Location = New System.Drawing.Point(8, 148)
        Me.dgvDistribution.Name = "dgvDistribution"
        Me.dgvDistribution.ReadOnly = True
        Me.dgvDistribution.Size = New System.Drawing.Size(1208, 855)
        Me.dgvDistribution.TabIndex = 201
        '
        'WA_TissueDistributions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.Controls.Add(Me.dgvDistribution)
        Me.Controls.Add(Me.Label12)
        Me.Name = "WA_TissueDistributions"
        Me.Size = New System.Drawing.Size(1264, 966)
        CType(Me.dgvDistribution, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label12 As Label
    Friend WithEvents dgvDistribution As DataGridView
End Class
