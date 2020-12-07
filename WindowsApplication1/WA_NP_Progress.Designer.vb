<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WA_NP_Progress
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNumRows = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvNP_Progress = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkExcludeADRC = New DataWarehouse.CheckBox_()
        Me.btnRevert = New DataWarehouse.Button_()
        CType(Me.dgvNP_Progress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 29)
        Me.Label1.TabIndex = 864
        Me.Label1.Text = "Neuropath Progress"
        '
        'lblNumRows
        '
        Me.lblNumRows.AutoSize = True
        Me.lblNumRows.Location = New System.Drawing.Point(3, 782)
        Me.lblNumRows.Name = "lblNumRows"
        Me.lblNumRows.Size = New System.Drawing.Size(39, 13)
        Me.lblNumRows.TabIndex = 1196
        Me.lblNumRows.Text = "Label2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(400, 13)
        Me.Label5.TabIndex = 1197
        Me.Label5.Text = "This grid is EDITABLE. All edits are saved when you move from one row to another." &
    ""
        '
        'dgvNP_Progress
        '
        Me.dgvNP_Progress.AllowUserToAddRows = False
        Me.dgvNP_Progress.AllowUserToDeleteRows = False
        Me.dgvNP_Progress.BackgroundColor = System.Drawing.Color.Tan
        Me.dgvNP_Progress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNP_Progress.Location = New System.Drawing.Point(3, 85)
        Me.dgvNP_Progress.MultiSelect = False
        Me.dgvNP_Progress.Name = "dgvNP_Progress"
        Me.dgvNP_Progress.Size = New System.Drawing.Size(1484, 694)
        Me.dgvNP_Progress.TabIndex = 1199
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(1078, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(387, 13)
        Me.Label2.TabIndex = 1200
        Me.Label2.Text = "Rows in GREEN are cases where LiveOnNY is awaiting a Provisional NP Report"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.PaleVioletRed
        Me.Label3.Location = New System.Drawing.Point(1078, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(409, 13)
        Me.Label3.TabIndex = 1201
        Me.Label3.Text = "Rows in RED are changed but not saved. Move to another row to save the changes."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label4.Location = New System.Drawing.Point(1078, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 13)
        Me.Label4.TabIndex = 1203
        Me.Label4.Text = "Rows in BLUE are ADRC cases"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(1078, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(283, 13)
        Me.Label6.TabIndex = 1204
        Me.Label6.Text = "Rows with BLUE TEXT have a Clinical Summary uploaded"
        '
        'chkExcludeADRC
        '
        Me.chkExcludeADRC.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkExcludeADRC.AutoSize = True
        Me.chkExcludeADRC.BackColor = System.Drawing.Color.LightGray
        Me.chkExcludeADRC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkExcludeADRC.Location = New System.Drawing.Point(653, 43)
        Me.chkExcludeADRC.Name = "chkExcludeADRC"
        Me.chkExcludeADRC.Size = New System.Drawing.Size(120, 23)
        Me.chkExcludeADRC.TabIndex = 1202
        Me.chkExcludeADRC.Text = "Exclude ADRC Cases"
        Me.chkExcludeADRC.UseVisualStyleBackColor = False
        '
        'btnRevert
        '
        Me.btnRevert.Location = New System.Drawing.Point(663, 785)
        Me.btnRevert.Name = "btnRevert"
        Me.btnRevert.Size = New System.Drawing.Size(169, 23)
        Me.btnRevert.TabIndex = 1198
        Me.btnRevert.Text = "Revert Changes to Current Row"
        Me.btnRevert.UseVisualStyleBackColor = True
        '
        'WA_NP_Progress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkExcludeADRC)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvNP_Progress)
        Me.Controls.Add(Me.btnRevert)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblNumRows)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WA_NP_Progress"
        Me.Size = New System.Drawing.Size(1490, 811)
        CType(Me.dgvNP_Progress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNumRows As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnRevert As Button_
    Friend WithEvents dgvNP_Progress As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents chkExcludeADRC As CheckBox_
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
End Class
