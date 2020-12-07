<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PU_AddBlankDoc
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New DataWarehouse.Button_()
        Me.btnChooseFile = New DataWarehouse.Button_()
        Me.txtDescription = New DataWarehouse.TextBox_()
        Me.ExpiryDate = New DataWarehouse.TextBoxDateAny()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Document Name"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(243, 57)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 103
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnChooseFile
        '
        Me.btnChooseFile.Location = New System.Drawing.Point(162, 57)
        Me.btnChooseFile.Name = "btnChooseFile"
        Me.btnChooseFile.Size = New System.Drawing.Size(75, 23)
        Me.btnChooseFile.TabIndex = 102
        Me.btnChooseFile.Text = "Choose File"
        Me.btnChooseFile.UseVisualStyleBackColor = True
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(105, 6)
        Me.txtDescription.MaxLength = 200
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(363, 20)
        Me.txtDescription.TabIndex = 100
        '
        'ExpiryDate
        '
        Me.ExpiryDate.Location = New System.Drawing.Point(105, 32)
        Me.ExpiryDate.Mask = "00/00/0000"
        Me.ExpiryDate.Name = "ExpiryDate"
        Me.ExpiryDate.Size = New System.Drawing.Size(67, 20)
        Me.ExpiryDate.TabIndex = 101
        Me.ExpiryDate.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Expiry Date"
        '
        'PU_AddBlankDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(480, 87)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ExpiryDate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnChooseFile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescription)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PU_AddBlankDoc"
        Me.Text = "Upload Blank or Reference Document"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDescription As TextBox_
    Friend WithEvents Label1 As Label
    Friend WithEvents btnChooseFile As Button_
    Friend WithEvents btnCancel As Button_
    Friend WithEvents ExpiryDate As TextBoxDateAny
    Friend WithEvents Label2 As Label
End Class
