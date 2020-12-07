<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PU_ConvertICD9To10
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
        Me.Button_1 = New DataWarehouse.Button_()
        Me.dgvICDConversion = New DataWarehouse.dgvSingleRow()
        CType(Me.dgvICDConversion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_1
        '
        Me.Button_1.Location = New System.Drawing.Point(247, 365)
        Me.Button_1.Name = "Button_1"
        Me.Button_1.Size = New System.Drawing.Size(175, 33)
        Me.Button_1.TabIndex = 2
        Me.Button_1.Text = "Cancel"
        Me.Button_1.UseVisualStyleBackColor = True
        '
        'dgvICDConversion
        '
        Me.dgvICDConversion.AllowUserToAddRows = False
        Me.dgvICDConversion.AllowUserToDeleteRows = False
        Me.dgvICDConversion.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige
        Me.dgvICDConversion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvICDConversion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvICDConversion.BackgroundColor = System.Drawing.Color.Tan
        Me.dgvICDConversion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvICDConversion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvICDConversion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvICDConversion.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvICDConversion.GridColor = System.Drawing.Color.Linen
        Me.dgvICDConversion.Location = New System.Drawing.Point(1, 3)
        Me.dgvICDConversion.MultiSelect = False
        Me.dgvICDConversion.Name = "dgvICDConversion"
        Me.dgvICDConversion.ReadOnly = True
        Me.dgvICDConversion.RowHeadersVisible = False
        Me.dgvICDConversion.RowHeadersWidth = 62
        Me.dgvICDConversion.RowTemplate.Height = 28
        Me.dgvICDConversion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvICDConversion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvICDConversion.Size = New System.Drawing.Size(654, 335)
        Me.dgvICDConversion.TabIndex = 1
        '
        'PU_ConvertICD9To10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(750, 452)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button_1)
        Me.Controls.Add(Me.dgvICDConversion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PU_ConvertICD9To10"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ICD-9 To ICD-10 Conversion"
        CType(Me.dgvICDConversion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvICDConversion As dgvSingleRow
    Friend WithEvents Button_1 As Button_
End Class
