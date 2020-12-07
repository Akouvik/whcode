<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PU_Specimen_Consume
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
        Me.txtNote = New DataWarehouse.TextBox_()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSaveAndClose = New DataWarehouse.Button_()
        Me.SuspendLayout()
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(15, 25)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(327, 20)
        Me.txtNote.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "What are you consuming this for? (ie- ""Consumed for RNA isolation"")"
        '
        'btnSaveAndClose
        '
        Me.btnSaveAndClose.Location = New System.Drawing.Point(108, 51)
        Me.btnSaveAndClose.Name = "btnSaveAndClose"
        Me.btnSaveAndClose.Size = New System.Drawing.Size(135, 23)
        Me.btnSaveAndClose.TabIndex = 108
        Me.btnSaveAndClose.Text = "Save and Close"
        Me.btnSaveAndClose.UseVisualStyleBackColor = True
        '
        'PU_Specimen_Consume
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(360, 82)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSaveAndClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNote)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PU_Specimen_Consume"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consume Specimen(s)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNote As TextBox_
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSaveAndClose As Button_
End Class
