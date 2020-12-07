<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PU_ReleaseOfMedicalRecords
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
        Me.dgvReleaseOfMedicalRecords = New DataWarehouse.dgvSingleRow()
        Me.btnAddNew = New DataWarehouse.Button_()
        Me.btnDelete = New DataWarehouse.Button_()
        Me.btnOpen = New DataWarehouse.Button_()
        CType(Me.dgvReleaseOfMedicalRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvReleaseOfMedicalRecords
        '
        Me.dgvReleaseOfMedicalRecords.AllowUserToAddRows = False
        Me.dgvReleaseOfMedicalRecords.AllowUserToDeleteRows = False
        Me.dgvReleaseOfMedicalRecords.AllowUserToOrderColumns = True
        Me.dgvReleaseOfMedicalRecords.AllowUserToResizeRows = False
        Me.dgvReleaseOfMedicalRecords.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dgvReleaseOfMedicalRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvReleaseOfMedicalRecords.BackgroundColor = System.Drawing.Color.Tan
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvReleaseOfMedicalRecords.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvReleaseOfMedicalRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvReleaseOfMedicalRecords.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvReleaseOfMedicalRecords.GridColor = System.Drawing.Color.Linen
        Me.dgvReleaseOfMedicalRecords.Location = New System.Drawing.Point(12, 12)
        Me.dgvReleaseOfMedicalRecords.MultiSelect = False
        Me.dgvReleaseOfMedicalRecords.Name = "dgvReleaseOfMedicalRecords"
        Me.dgvReleaseOfMedicalRecords.ReadOnly = True
        Me.dgvReleaseOfMedicalRecords.RowHeadersVisible = False
        Me.dgvReleaseOfMedicalRecords.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.dgvReleaseOfMedicalRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReleaseOfMedicalRecords.Size = New System.Drawing.Size(324, 126)
        Me.dgvReleaseOfMedicalRecords.TabIndex = 0
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(12, 144)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(95, 23)
        Me.btnAddNew.TabIndex = 1
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(240, 144)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(95, 23)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete Selected"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(126, 144)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(95, 23)
        Me.btnOpen.TabIndex = 3
        Me.btnOpen.Text = "Open Selected"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'PU_ReleaseOfMedicalRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(348, 173)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.dgvReleaseOfMedicalRecords)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PU_ReleaseOfMedicalRecords"
        Me.Text = "Release of Medical Records"
        CType(Me.dgvReleaseOfMedicalRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvReleaseOfMedicalRecords As dgvSingleRow
    Friend WithEvents btnAddNew As Button_
    Friend WithEvents btnDelete As Button_
    Friend WithEvents btnOpen As Button_
End Class
