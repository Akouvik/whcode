<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PU_SmokingHistory
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtReportDate = New DataWarehouse.TextBoxDatePast()
        Me.btnEdit = New DataWarehouse.Button_()
        Me.btnCancel = New DataWarehouse.Button_()
        Me.btnSave = New DataWarehouse.Button_()
        Me.txtYearsSmoked = New DataWarehouse.TextBoxInteger()
        Me.txtDateStopped = New DataWarehouse.TextBoxDatePast()
        Me.txtAgeStarted = New DataWarehouse.TextBoxInteger()
        Me.comboStatus = New DataWarehouse.ComboBox_()
        Me.dgvSmokingHistory = New DataWarehouse.dgvSingleRow()
        CType(Me.dgvSmokingHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Smoker Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(362, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Age Started"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(482, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Date Stopped"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(634, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Years Smoked"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Report Date"
        '
        'txtReportDate
        '
        Me.txtReportDate.Location = New System.Drawing.Point(80, 185)
        Me.txtReportDate.Mask = "00/00/0000"
        Me.txtReportDate.Name = "txtReportDate"
        Me.txtReportDate.Size = New System.Drawing.Size(67, 20)
        Me.txtReportDate.TabIndex = 1
        Me.txtReportDate.ValidatingType = GetType(Date)
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(321, 212)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(130, 23)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "Edit Selected Record"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(457, 212)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(130, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel/Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(185, 212)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(130, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save New"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtYearsSmoked
        '
        Me.txtYearsSmoked.Location = New System.Drawing.Point(716, 185)
        Me.txtYearsSmoked.Name = "txtYearsSmoked"
        Me.txtYearsSmoked.Size = New System.Drawing.Size(45, 20)
        Me.txtYearsSmoked.TabIndex = 5
        '
        'txtDateStopped
        '
        Me.txtDateStopped.Location = New System.Drawing.Point(561, 185)
        Me.txtDateStopped.Mask = "00/00/0000"
        Me.txtDateStopped.Name = "txtDateStopped"
        Me.txtDateStopped.Size = New System.Drawing.Size(67, 20)
        Me.txtDateStopped.TabIndex = 4
        Me.txtDateStopped.ValidatingType = GetType(Date)
        '
        'txtAgeStarted
        '
        Me.txtAgeStarted.Location = New System.Drawing.Point(431, 185)
        Me.txtAgeStarted.Name = "txtAgeStarted"
        Me.txtAgeStarted.Size = New System.Drawing.Size(45, 20)
        Me.txtAgeStarted.TabIndex = 3
        '
        'comboStatus
        '
        Me.comboStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboStatus.FormattingEnabled = True
        Me.comboStatus.Location = New System.Drawing.Point(235, 185)
        Me.comboStatus.Name = "comboStatus"
        Me.comboStatus.Size = New System.Drawing.Size(121, 21)
        Me.comboStatus.TabIndex = 2
        '
        'dgvSmokingHistory
        '
        Me.dgvSmokingHistory.AllowUserToAddRows = False
        Me.dgvSmokingHistory.AllowUserToDeleteRows = False
        Me.dgvSmokingHistory.AllowUserToOrderColumns = True
        Me.dgvSmokingHistory.AllowUserToResizeRows = False
        Me.dgvSmokingHistory.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dgvSmokingHistory.BackgroundColor = System.Drawing.Color.Tan
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSmokingHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSmokingHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSmokingHistory.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSmokingHistory.GridColor = System.Drawing.Color.Linen
        Me.dgvSmokingHistory.Location = New System.Drawing.Point(12, 12)
        Me.dgvSmokingHistory.Name = "dgvSmokingHistory"
        Me.dgvSmokingHistory.RowHeadersVisible = False
        Me.dgvSmokingHistory.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.dgvSmokingHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSmokingHistory.Size = New System.Drawing.Size(749, 158)
        Me.dgvSmokingHistory.TabIndex = 999
        Me.dgvSmokingHistory.TabStop = False
        '
        'PU_SmokingHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(776, 241)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtReportDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtYearsSmoked)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDateStopped)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAgeStarted)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.comboStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvSmokingHistory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "PU_SmokingHistory"
        Me.Text = "Smoking History"
        CType(Me.dgvSmokingHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvSmokingHistory As DataWarehouse.dgvSingleRow
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents comboStatus As DataWarehouse.ComboBox_
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAgeStarted As DataWarehouse.TextBoxInteger
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDateStopped As DataWarehouse.TextBoxDatePast
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtYearsSmoked As DataWarehouse.TextBoxInteger
    Friend WithEvents btnSave As DataWarehouse.Button_
    Friend WithEvents btnCancel As DataWarehouse.Button_
    Friend WithEvents btnEdit As DataWarehouse.Button_
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtReportDate As DataWarehouse.TextBoxDatePast
End Class
