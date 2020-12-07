<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WA_PreEnrollment_Anniversary
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGenMailers = New DataWarehouse.Button_()
        Me.dgvPreEnrollmentAnniversary = New DataWarehouse.dgvSingleRow()
        CType(Me.dgvPreEnrollmentAnniversary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(481, 29)
        Me.Label1.TabIndex = 787
        Me.Label1.Text = "PreEnrollment Anniversaries This Month"
        '
        'btnGenMailers
        '
        Me.btnGenMailers.Location = New System.Drawing.Point(418, 531)
        Me.btnGenMailers.Name = "btnGenMailers"
        Me.btnGenMailers.Size = New System.Drawing.Size(224, 23)
        Me.btnGenMailers.TabIndex = 788
        Me.btnGenMailers.Text = "Generate Anniversary Mailers"
        Me.btnGenMailers.UseVisualStyleBackColor = True
        '
        'dgvPreEnrollmentAnniversary
        '
        Me.dgvPreEnrollmentAnniversary.AllowUserToAddRows = False
        Me.dgvPreEnrollmentAnniversary.AllowUserToDeleteRows = False
        Me.dgvPreEnrollmentAnniversary.AllowUserToOrderColumns = True
        Me.dgvPreEnrollmentAnniversary.AllowUserToResizeRows = False
        Me.dgvPreEnrollmentAnniversary.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dgvPreEnrollmentAnniversary.BackgroundColor = System.Drawing.Color.Tan
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPreEnrollmentAnniversary.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPreEnrollmentAnniversary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPreEnrollmentAnniversary.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPreEnrollmentAnniversary.GridColor = System.Drawing.Color.Linen
        Me.dgvPreEnrollmentAnniversary.Location = New System.Drawing.Point(3, 32)
        Me.dgvPreEnrollmentAnniversary.MultiSelect = False
        Me.dgvPreEnrollmentAnniversary.Name = "dgvPreEnrollmentAnniversary"
        Me.dgvPreEnrollmentAnniversary.ReadOnly = True
        Me.dgvPreEnrollmentAnniversary.RowHeadersVisible = False
        Me.dgvPreEnrollmentAnniversary.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.dgvPreEnrollmentAnniversary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPreEnrollmentAnniversary.Size = New System.Drawing.Size(1054, 493)
        Me.dgvPreEnrollmentAnniversary.TabIndex = 0
        '
        'WA_PreEnrollment_Anniversary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.Controls.Add(Me.btnGenMailers)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvPreEnrollmentAnniversary)
        Me.Name = "WA_PreEnrollment_Anniversary"
        Me.Size = New System.Drawing.Size(1060, 559)
        CType(Me.dgvPreEnrollmentAnniversary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvPreEnrollmentAnniversary As dgvSingleRow
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGenMailers As Button_
End Class
