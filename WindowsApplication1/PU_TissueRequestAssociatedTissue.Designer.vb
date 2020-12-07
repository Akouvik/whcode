<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PU_TissueRequestAssociatedTissue
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvAssociatedTissue = New DataWarehouse.dgvSingleRow()
        Me.Button_1 = New DataWarehouse.Button_()
        CType(Me.dgvAssociatedTissue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAssociatedTissue
        '
        Me.dgvAssociatedTissue.AllowUserToAddRows = False
        Me.dgvAssociatedTissue.AllowUserToDeleteRows = False
        Me.dgvAssociatedTissue.AllowUserToOrderColumns = True
        Me.dgvAssociatedTissue.AllowUserToResizeRows = False
        Me.dgvAssociatedTissue.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dgvAssociatedTissue.BackgroundColor = System.Drawing.Color.Tan
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAssociatedTissue.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvAssociatedTissue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAssociatedTissue.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvAssociatedTissue.GridColor = System.Drawing.Color.Linen
        Me.dgvAssociatedTissue.Location = New System.Drawing.Point(12, 41)
        Me.dgvAssociatedTissue.MultiSelect = False
        Me.dgvAssociatedTissue.Name = "dgvAssociatedTissue"
        Me.dgvAssociatedTissue.ReadOnly = True
        Me.dgvAssociatedTissue.RowHeadersVisible = False
        Me.dgvAssociatedTissue.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.dgvAssociatedTissue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAssociatedTissue.Size = New System.Drawing.Size(1024, 556)
        Me.dgvAssociatedTissue.TabIndex = 0
        '
        'Button_1
        '
        Me.Button_1.Location = New System.Drawing.Point(12, 12)
        Me.Button_1.Name = "Button_1"
        Me.Button_1.Size = New System.Drawing.Size(182, 23)
        Me.Button_1.TabIndex = 1
        Me.Button_1.Text = "Copy Selected Cells to Clipboard"
        Me.Button_1.UseVisualStyleBackColor = True
        '
        'PU_TissueRequestAssociatedTissue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(1048, 614)
        Me.Controls.Add(Me.Button_1)
        Me.Controls.Add(Me.dgvAssociatedTissue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PU_TissueRequestAssociatedTissue"
        Me.Text = "Associated Tissue"
        CType(Me.dgvAssociatedTissue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvAssociatedTissue As DataWarehouse.dgvSingleRow
    Friend WithEvents Button_1 As DataWarehouse.Button_
End Class
