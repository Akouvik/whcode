<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PU_TaskerProgressReport
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
        Me.txtReportDate = New DataWarehouse.TextBoxDatePast()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSamplesCompleted = New DataWarehouse.TextBoxInteger()
        Me.btnReport = New DataWarehouse.Button_()
        Me.btnSave = New DataWarehouse.Button_()
        Me.btnCancel = New DataWarehouse.Button_()
        Me.btnRemove = New DataWarehouse.Button_()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNote = New DataWarehouse.TextBox_()
        Me.SuspendLayout()
        '
        'txtReportDate
        '
        Me.txtReportDate.Location = New System.Drawing.Point(83, 6)
        Me.txtReportDate.Mask = "00/00/0000"
        Me.txtReportDate.Name = "txtReportDate"
        Me.txtReportDate.Size = New System.Drawing.Size(67, 20)
        Me.txtReportDate.TabIndex = 0
        Me.txtReportDate.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Report Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "# Samples Completed"
        '
        'txtSamplesCompleted
        '
        Me.txtSamplesCompleted.Location = New System.Drawing.Point(272, 6)
        Me.txtSamplesCompleted.Name = "txtSamplesCompleted"
        Me.txtSamplesCompleted.Size = New System.Drawing.Size(90, 20)
        Me.txtSamplesCompleted.TabIndex = 3
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(387, 4)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(158, 23)
        Me.btnReport.TabIndex = 4
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(201, 93)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(282, 93)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(428, 27)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(76, 23)
        Me.btnRemove.TabIndex = 7
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Note"
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(48, 29)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(374, 58)
        Me.txtNote.TabIndex = 9
        '
        'PU_TaskerProgressReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(558, 123)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.txtSamplesCompleted)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtReportDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PU_TaskerProgressReport"
        Me.Text = "Tasker Progress Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtReportDate As DataWarehouse.TextBoxDatePast
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSamplesCompleted As DataWarehouse.TextBoxInteger
    Friend WithEvents btnReport As DataWarehouse.Button_
    Friend WithEvents btnSave As DataWarehouse.Button_
    Friend WithEvents btnCancel As DataWarehouse.Button_
    Friend WithEvents btnRemove As DataWarehouse.Button_
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNote As DataWarehouse.TextBox_
End Class
