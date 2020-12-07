<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PU_Specimen_MoveBox
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
        Me.intBoxNum = New DataWarehouse.TextBoxInteger()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbLocType = New DataWarehouse.ComboBox_()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.intLocNum = New DataWarehouse.TextBoxInteger()
        Me.intShelfNum = New DataWarehouse.TextBoxInteger()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.intShelfRow = New DataWarehouse.TextBoxInteger()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCancelClose = New DataWarehouse.Button_()
        Me.btnSaveAndClose = New DataWarehouse.Button_()
        Me.btnSaveAndContinue = New DataWarehouse.Button_()
        Me.intShelfCol = New DataWarehouse.TextBoxInteger()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'intBoxNum
        '
        Me.intBoxNum.Location = New System.Drawing.Point(71, 6)
        Me.intBoxNum.Name = "intBoxNum"
        Me.intBoxNum.Size = New System.Drawing.Size(226, 20)
        Me.intBoxNum.TabIndex = 101
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Box #"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Loc Type"
        '
        'cmbLocType
        '
        Me.cmbLocType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbLocType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbLocType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLocType.FormattingEnabled = True
        Me.cmbLocType.ItemHeight = 13
        Me.cmbLocType.Location = New System.Drawing.Point(71, 32)
        Me.cmbLocType.Name = "cmbLocType"
        Me.cmbLocType.Size = New System.Drawing.Size(226, 21)
        Me.cmbLocType.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Loc #"
        '
        'intLocNum
        '
        Me.intLocNum.Location = New System.Drawing.Point(71, 59)
        Me.intLocNum.Name = "intLocNum"
        Me.intLocNum.Size = New System.Drawing.Size(226, 20)
        Me.intLocNum.TabIndex = 103
        '
        'intShelfNum
        '
        Me.intShelfNum.Location = New System.Drawing.Point(71, 85)
        Me.intShelfNum.Name = "intShelfNum"
        Me.intShelfNum.Size = New System.Drawing.Size(226, 20)
        Me.intShelfNum.TabIndex = 104
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Shelf #"
        '
        'intShelfRow
        '
        Me.intShelfRow.Location = New System.Drawing.Point(71, 137)
        Me.intShelfRow.Name = "intShelfRow"
        Me.intShelfRow.Size = New System.Drawing.Size(226, 20)
        Me.intShelfRow.TabIndex = 105
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Shelf Row"
        '
        'btnCancelClose
        '
        Me.btnCancelClose.Location = New System.Drawing.Point(83, 221)
        Me.btnCancelClose.Name = "btnCancelClose"
        Me.btnCancelClose.Size = New System.Drawing.Size(135, 23)
        Me.btnCancelClose.TabIndex = 108
        Me.btnCancelClose.Text = "Cancel/Close"
        Me.btnCancelClose.UseVisualStyleBackColor = True
        '
        'btnSaveAndClose
        '
        Me.btnSaveAndClose.Location = New System.Drawing.Point(83, 192)
        Me.btnSaveAndClose.Name = "btnSaveAndClose"
        Me.btnSaveAndClose.Size = New System.Drawing.Size(135, 23)
        Me.btnSaveAndClose.TabIndex = 107
        Me.btnSaveAndClose.Text = "Save and Close"
        Me.btnSaveAndClose.UseVisualStyleBackColor = True
        '
        'btnSaveAndContinue
        '
        Me.btnSaveAndContinue.Location = New System.Drawing.Point(83, 163)
        Me.btnSaveAndContinue.Name = "btnSaveAndContinue"
        Me.btnSaveAndContinue.Size = New System.Drawing.Size(135, 23)
        Me.btnSaveAndContinue.TabIndex = 106
        Me.btnSaveAndContinue.Text = "Save and Move Another"
        Me.btnSaveAndContinue.UseVisualStyleBackColor = True
        '
        'intShelfCol
        '
        Me.intShelfCol.Location = New System.Drawing.Point(71, 111)
        Me.intShelfCol.Name = "intShelfCol"
        Me.intShelfCol.Size = New System.Drawing.Size(226, 20)
        Me.intShelfCol.TabIndex = 110
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Shelf Col"
        '
        'PU_Specimen_MoveBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(309, 257)
        Me.ControlBox = False
        Me.Controls.Add(Me.intShelfCol)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSaveAndClose)
        Me.Controls.Add(Me.btnCancelClose)
        Me.Controls.Add(Me.btnSaveAndContinue)
        Me.Controls.Add(Me.intShelfRow)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.intShelfNum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.intLocNum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbLocType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.intBoxNum)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PU_Specimen_MoveBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Box Location (and all specimens within that box)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents intBoxNum As TextBoxInteger
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbLocType As ComboBox_
    Friend WithEvents Label3 As Label
    Friend WithEvents intLocNum As TextBoxInteger
    Friend WithEvents intShelfNum As TextBoxInteger
    Friend WithEvents Label4 As Label
    Friend WithEvents intShelfRow As TextBoxInteger
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCancelClose As Button_
    Friend WithEvents btnSaveAndClose As Button_
    Friend WithEvents btnSaveAndContinue As Button_
    Friend WithEvents intShelfCol As TextBoxInteger
    Friend WithEvents Label6 As Label
End Class
