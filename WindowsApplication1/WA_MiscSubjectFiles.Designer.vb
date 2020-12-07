<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WA_MiscSubjectFiles
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvMiscFiles = New DataWarehouse.dgvSingleRow()
        Me.btnMiscAddFile = New DataWarehouse.Button_()
        Me.btnMiscDeleteFile = New DataWarehouse.Button_()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnMedDeleteFile = New DataWarehouse.Button_()
        Me.btnMedAddFile = New DataWarehouse.Button_()
        Me.dgvMedFiles = New DataWarehouse.dgvSingleRow()
        Me.grpMiscFiles = New System.Windows.Forms.GroupBox()
        Me.grpMedRecords = New System.Windows.Forms.GroupBox()
        CType(Me.dgvMiscFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMedFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMiscFiles.SuspendLayout()
        Me.grpMedRecords.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 29)
        Me.Label1.TabIndex = 792
        Me.Label1.Text = "Misc. Subject File Uploads"
        '
        'dgvMiscFiles
        '
        Me.dgvMiscFiles.AllowUserToAddRows = False
        Me.dgvMiscFiles.AllowUserToDeleteRows = False
        Me.dgvMiscFiles.AllowUserToOrderColumns = True
        Me.dgvMiscFiles.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige
        Me.dgvMiscFiles.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMiscFiles.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dgvMiscFiles.BackgroundColor = System.Drawing.Color.Tan
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMiscFiles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMiscFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMiscFiles.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMiscFiles.GridColor = System.Drawing.Color.Linen
        Me.dgvMiscFiles.Location = New System.Drawing.Point(6, 32)
        Me.dgvMiscFiles.MultiSelect = False
        Me.dgvMiscFiles.Name = "dgvMiscFiles"
        Me.dgvMiscFiles.ReadOnly = True
        Me.dgvMiscFiles.RowHeadersVisible = False
        Me.dgvMiscFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMiscFiles.Size = New System.Drawing.Size(858, 269)
        Me.dgvMiscFiles.TabIndex = 793
        '
        'btnMiscAddFile
        '
        Me.btnMiscAddFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMiscAddFile.Location = New System.Drawing.Point(270, 307)
        Me.btnMiscAddFile.Name = "btnMiscAddFile"
        Me.btnMiscAddFile.Size = New System.Drawing.Size(163, 23)
        Me.btnMiscAddFile.TabIndex = 794
        Me.btnMiscAddFile.Text = "Add File"
        Me.btnMiscAddFile.UseVisualStyleBackColor = True
        '
        'btnMiscDeleteFile
        '
        Me.btnMiscDeleteFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMiscDeleteFile.Location = New System.Drawing.Point(439, 307)
        Me.btnMiscDeleteFile.Name = "btnMiscDeleteFile"
        Me.btnMiscDeleteFile.Size = New System.Drawing.Size(163, 23)
        Me.btnMiscDeleteFile.TabIndex = 795
        Me.btnMiscDeleteFile.Text = "Delete Selected File"
        Me.btnMiscDeleteFile.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(302, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 13)
        Me.Label2.TabIndex = 796
        Me.Label2.Text = "Double-click a record below to open the associated file"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(302, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(266, 13)
        Me.Label3.TabIndex = 800
        Me.Label3.Text = "Double-click a record below to open the associated file"
        '
        'btnMedDeleteFile
        '
        Me.btnMedDeleteFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMedDeleteFile.Location = New System.Drawing.Point(439, 307)
        Me.btnMedDeleteFile.Name = "btnMedDeleteFile"
        Me.btnMedDeleteFile.Size = New System.Drawing.Size(140, 23)
        Me.btnMedDeleteFile.TabIndex = 799
        Me.btnMedDeleteFile.Text = "Delete Selected File"
        Me.btnMedDeleteFile.UseVisualStyleBackColor = True
        '
        'btnMedAddFile
        '
        Me.btnMedAddFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMedAddFile.Location = New System.Drawing.Point(293, 307)
        Me.btnMedAddFile.Name = "btnMedAddFile"
        Me.btnMedAddFile.Size = New System.Drawing.Size(140, 23)
        Me.btnMedAddFile.TabIndex = 798
        Me.btnMedAddFile.Text = "Add File"
        Me.btnMedAddFile.UseVisualStyleBackColor = True
        '
        'dgvMedFiles
        '
        Me.dgvMedFiles.AllowUserToAddRows = False
        Me.dgvMedFiles.AllowUserToDeleteRows = False
        Me.dgvMedFiles.AllowUserToOrderColumns = True
        Me.dgvMedFiles.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Beige
        Me.dgvMedFiles.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMedFiles.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dgvMedFiles.BackgroundColor = System.Drawing.Color.Tan
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMedFiles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvMedFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMedFiles.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvMedFiles.GridColor = System.Drawing.Color.Linen
        Me.dgvMedFiles.Location = New System.Drawing.Point(5, 32)
        Me.dgvMedFiles.MultiSelect = False
        Me.dgvMedFiles.Name = "dgvMedFiles"
        Me.dgvMedFiles.ReadOnly = True
        Me.dgvMedFiles.RowHeadersVisible = False
        Me.dgvMedFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMedFiles.Size = New System.Drawing.Size(858, 269)
        Me.dgvMedFiles.TabIndex = 797
        '
        'grpMiscFiles
        '
        Me.grpMiscFiles.Controls.Add(Me.Label2)
        Me.grpMiscFiles.Controls.Add(Me.dgvMiscFiles)
        Me.grpMiscFiles.Controls.Add(Me.btnMiscAddFile)
        Me.grpMiscFiles.Controls.Add(Me.btnMiscDeleteFile)
        Me.grpMiscFiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMiscFiles.Location = New System.Drawing.Point(3, 32)
        Me.grpMiscFiles.Name = "grpMiscFiles"
        Me.grpMiscFiles.Size = New System.Drawing.Size(870, 338)
        Me.grpMiscFiles.TabIndex = 801
        Me.grpMiscFiles.TabStop = False
        Me.grpMiscFiles.Text = "Misc Individual Files"
        '
        'grpMedRecords
        '
        Me.grpMedRecords.Controls.Add(Me.Label3)
        Me.grpMedRecords.Controls.Add(Me.dgvMedFiles)
        Me.grpMedRecords.Controls.Add(Me.btnMedDeleteFile)
        Me.grpMedRecords.Controls.Add(Me.btnMedAddFile)
        Me.grpMedRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMedRecords.Location = New System.Drawing.Point(3, 376)
        Me.grpMedRecords.Name = "grpMedRecords"
        Me.grpMedRecords.Size = New System.Drawing.Size(870, 336)
        Me.grpMedRecords.TabIndex = 802
        Me.grpMedRecords.TabStop = False
        Me.grpMedRecords.Text = "Scanned Medical Records"
        '
        'WA_MiscSubjectFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.Controls.Add(Me.grpMedRecords)
        Me.Controls.Add(Me.grpMiscFiles)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WA_MiscSubjectFiles"
        Me.Size = New System.Drawing.Size(876, 851)
        CType(Me.dgvMiscFiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMedFiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMiscFiles.ResumeLayout(False)
        Me.grpMiscFiles.PerformLayout()
        Me.grpMedRecords.ResumeLayout(False)
        Me.grpMedRecords.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvMiscFiles As dgvSingleRow
    Friend WithEvents btnMiscAddFile As Button_
    Friend WithEvents btnMiscDeleteFile As Button_
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnMedDeleteFile As Button_
    Friend WithEvents btnMedAddFile As Button_
    Friend WithEvents dgvMedFiles As dgvSingleRow
    Friend WithEvents grpMiscFiles As GroupBox
    Friend WithEvents grpMedRecords As GroupBox
End Class
