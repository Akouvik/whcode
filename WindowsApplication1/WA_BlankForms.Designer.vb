<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WA_BlankForms
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpNBTR = New System.Windows.Forms.GroupBox()
        Me.btnNBTRRemove = New DataWarehouse.Button_()
        Me.btnNBTRReplace = New DataWarehouse.Button_()
        Me.btnNBTROpen = New DataWarehouse.Button_()
        Me.btnNBTRAdd = New DataWarehouse.Button_()
        Me.dgvNBTR = New DataWarehouse.dgvSingleRow()
        Me.grpNBTR.SuspendLayout()
        CType(Me.dgvNBTR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 29)
        Me.Label1.TabIndex = 786
        Me.Label1.Text = "Blank && Reference Forms"
        '
        'grpNBTR
        '
        Me.grpNBTR.Controls.Add(Me.btnNBTRRemove)
        Me.grpNBTR.Controls.Add(Me.btnNBTRReplace)
        Me.grpNBTR.Controls.Add(Me.btnNBTROpen)
        Me.grpNBTR.Controls.Add(Me.btnNBTRAdd)
        Me.grpNBTR.Controls.Add(Me.dgvNBTR)
        Me.grpNBTR.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpNBTR.Location = New System.Drawing.Point(5, 34)
        Me.grpNBTR.Name = "grpNBTR"
        Me.grpNBTR.Size = New System.Drawing.Size(1087, 330)
        Me.grpNBTR.TabIndex = 789
        Me.grpNBTR.TabStop = False
        Me.grpNBTR.Text = "NBTR Docs"
        '
        'btnNBTRRemove
        '
        Me.btnNBTRRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNBTRRemove.Location = New System.Drawing.Point(385, 298)
        Me.btnNBTRRemove.Name = "btnNBTRRemove"
        Me.btnNBTRRemove.Size = New System.Drawing.Size(185, 23)
        Me.btnNBTRRemove.TabIndex = 4
        Me.btnNBTRRemove.Text = "Remove Selected Doc"
        Me.btnNBTRRemove.UseVisualStyleBackColor = True
        '
        'btnNBTRReplace
        '
        Me.btnNBTRReplace.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNBTRReplace.Location = New System.Drawing.Point(194, 298)
        Me.btnNBTRReplace.Name = "btnNBTRReplace"
        Me.btnNBTRReplace.Size = New System.Drawing.Size(185, 23)
        Me.btnNBTRReplace.TabIndex = 3
        Me.btnNBTRReplace.Text = "Replace Selected Doc"
        Me.btnNBTRReplace.UseVisualStyleBackColor = True
        '
        'btnNBTROpen
        '
        Me.btnNBTROpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNBTROpen.Location = New System.Drawing.Point(3, 298)
        Me.btnNBTROpen.Name = "btnNBTROpen"
        Me.btnNBTROpen.Size = New System.Drawing.Size(185, 23)
        Me.btnNBTROpen.TabIndex = 2
        Me.btnNBTROpen.Text = "Open Selected Doc"
        Me.btnNBTROpen.UseVisualStyleBackColor = True
        '
        'btnNBTRAdd
        '
        Me.btnNBTRAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNBTRAdd.Location = New System.Drawing.Point(576, 298)
        Me.btnNBTRAdd.Name = "btnNBTRAdd"
        Me.btnNBTRAdd.Size = New System.Drawing.Size(185, 23)
        Me.btnNBTRAdd.TabIndex = 1
        Me.btnNBTRAdd.Text = "Add New Doc"
        Me.btnNBTRAdd.UseVisualStyleBackColor = True
        '
        'dgvNBTR
        '
        Me.dgvNBTR.AllowUserToAddRows = False
        Me.dgvNBTR.AllowUserToDeleteRows = False
        Me.dgvNBTR.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige
        Me.dgvNBTR.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvNBTR.BackgroundColor = System.Drawing.Color.Tan
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvNBTR.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvNBTR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvNBTR.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvNBTR.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvNBTR.GridColor = System.Drawing.Color.Linen
        Me.dgvNBTR.Location = New System.Drawing.Point(3, 16)
        Me.dgvNBTR.MultiSelect = False
        Me.dgvNBTR.Name = "dgvNBTR"
        Me.dgvNBTR.ReadOnly = True
        Me.dgvNBTR.RowHeadersVisible = False
        Me.dgvNBTR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvNBTR.Size = New System.Drawing.Size(1081, 276)
        Me.dgvNBTR.TabIndex = 0
        '
        'WA_BlankForms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.Controls.Add(Me.grpNBTR)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WA_BlankForms"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(1097, 1030)
        Me.grpNBTR.ResumeLayout(False)
        CType(Me.dgvNBTR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grpNBTR As GroupBox
    Friend WithEvents btnNBTRRemove As Button_
    Friend WithEvents btnNBTRReplace As Button_
    Friend WithEvents btnNBTROpen As Button_
    Friend WithEvents btnNBTRAdd As Button_
    Friend WithEvents dgvNBTR As dgvSingleRow
End Class
