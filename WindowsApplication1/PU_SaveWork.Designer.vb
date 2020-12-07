<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PU_SaveWork
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
        Me.lblUserText = New System.Windows.Forms.Label()
        Me.btnSaveCont = New DataWarehouse.Button_()
        Me.btnContWOSave = New DataWarehouse.Button_()
        Me.btnCancel = New DataWarehouse.Button_()
        Me.SuspendLayout()
        '
        'lblUserText
        '
        Me.lblUserText.AutoSize = True
        Me.lblUserText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserText.Location = New System.Drawing.Point(13, 13)
        Me.lblUserText.Name = "lblUserText"
        Me.lblUserText.Size = New System.Drawing.Size(45, 20)
        Me.lblUserText.TabIndex = 0
        Me.lblUserText.Text = "temp"
        '
        'btnSaveCont
        '
        Me.btnSaveCont.Location = New System.Drawing.Point(3, 73)
        Me.btnSaveCont.Name = "btnSaveCont"
        Me.btnSaveCont.Size = New System.Drawing.Size(141, 23)
        Me.btnSaveCont.TabIndex = 1
        Me.btnSaveCont.Text = "Save and continue"
        Me.btnSaveCont.UseVisualStyleBackColor = True
        '
        'btnContWOSave
        '
        Me.btnContWOSave.Location = New System.Drawing.Point(148, 73)
        Me.btnContWOSave.Name = "btnContWOSave"
        Me.btnContWOSave.Size = New System.Drawing.Size(141, 23)
        Me.btnContWOSave.TabIndex = 2
        Me.btnContWOSave.Text = "Continue without saving"
        Me.btnContWOSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(293, 73)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(141, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Return to current form"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'PU_SaveWork
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 108)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnContWOSave)
        Me.Controls.Add(Me.btnSaveCont)
        Me.Controls.Add(Me.lblUserText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "PU_SaveWork"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Save your work"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUserText As System.Windows.Forms.Label
    Friend WithEvents btnSaveCont As DataWarehouse.Button_
    Friend WithEvents btnContWOSave As DataWarehouse.Button_
    Friend WithEvents btnCancel As DataWarehouse.Button_
End Class
