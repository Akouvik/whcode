<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PU_Labs_Add
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
        Me.cmbLabName = New DataWarehouse.ComboBox_()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtLabDate = New DataWarehouse.TextBoxDatePast()
        Me.btnSaveClose = New DataWarehouse.Button_()
        Me.btnCancel = New DataWarehouse.Button_()
        Me.cmbLabSource = New DataWarehouse.ComboBox_()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUoM = New DataWarehouse.TextBox_()
        Me.numRngFrom = New DataWarehouse.TextBoxNumeric()
        Me.numRngTo = New DataWarehouse.TextBoxNumeric()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSaveAdd = New DataWarehouse.Button_()
        Me.numResultQuant = New DataWarehouse.TextBoxNumeric()
        Me.btnSuggest = New DataWarehouse.Button_()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtResultQual = New DataWarehouse.TextBox_()
        Me.SuspendLayout()
        '
        'cmbLabName
        '
        Me.cmbLabName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbLabName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbLabName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLabName.FormattingEnabled = True
        Me.cmbLabName.Location = New System.Drawing.Point(12, 65)
        Me.cmbLabName.Name = "cmbLabName"
        Me.cmbLabName.Size = New System.Drawing.Size(228, 21)
        Me.cmbLabName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "UoM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(167, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Date"
        '
        'dtLabDate
        '
        Me.dtLabDate.Location = New System.Drawing.Point(170, 144)
        Me.dtLabDate.Mask = "00/00/0000"
        Me.dtLabDate.Name = "dtLabDate"
        Me.dtLabDate.Size = New System.Drawing.Size(70, 20)
        Me.dtLabDate.TabIndex = 7
        Me.dtLabDate.ValidatingType = GetType(Date)
        '
        'btnSaveClose
        '
        Me.btnSaveClose.Location = New System.Drawing.Point(64, 199)
        Me.btnSaveClose.Name = "btnSaveClose"
        Me.btnSaveClose.Size = New System.Drawing.Size(124, 23)
        Me.btnSaveClose.TabIndex = 9
        Me.btnSaveClose.Text = "Save and Close"
        Me.btnSaveClose.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(64, 228)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(124, 23)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cmbLabSource
        '
        Me.cmbLabSource.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbLabSource.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbLabSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLabSource.FormattingEnabled = True
        Me.cmbLabSource.Location = New System.Drawing.Point(12, 25)
        Me.cmbLabSource.Name = "cmbLabSource"
        Me.cmbLabSource.Size = New System.Drawing.Size(228, 21)
        Me.cmbLabSource.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Source"
        '
        'txtUoM
        '
        Me.txtUoM.Location = New System.Drawing.Point(12, 105)
        Me.txtUoM.Name = "txtUoM"
        Me.txtUoM.Size = New System.Drawing.Size(70, 20)
        Me.txtUoM.TabIndex = 2
        '
        'numRngFrom
        '
        Me.numRngFrom.Location = New System.Drawing.Point(91, 105)
        Me.numRngFrom.Name = "numRngFrom"
        Me.numRngFrom.Size = New System.Drawing.Size(70, 20)
        Me.numRngFrom.TabIndex = 3
        '
        'numRngTo
        '
        Me.numRngTo.Location = New System.Drawing.Point(170, 105)
        Me.numRngTo.Name = "numRngTo"
        Me.numRngTo.Size = New System.Drawing.Size(70, 20)
        Me.numRngTo.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(88, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Rng From"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(167, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Rng To"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Result Quant"
        '
        'btnSaveAdd
        '
        Me.btnSaveAdd.Location = New System.Drawing.Point(64, 170)
        Me.btnSaveAdd.Name = "btnSaveAdd"
        Me.btnSaveAdd.Size = New System.Drawing.Size(124, 23)
        Me.btnSaveAdd.TabIndex = 8
        Me.btnSaveAdd.Text = "Save and Add Another"
        Me.btnSaveAdd.UseVisualStyleBackColor = True
        '
        'numResultQuant
        '
        Me.numResultQuant.Location = New System.Drawing.Point(12, 144)
        Me.numResultQuant.Name = "numResultQuant"
        Me.numResultQuant.Size = New System.Drawing.Size(70, 20)
        Me.numResultQuant.TabIndex = 5
        '
        'btnSuggest
        '
        Me.btnSuggest.Location = New System.Drawing.Point(12, 257)
        Me.btnSuggest.Name = "btnSuggest"
        Me.btnSuggest.Size = New System.Drawing.Size(228, 23)
        Me.btnSuggest.TabIndex = 19
        Me.btnSuggest.Text = "Suggest a New Lab"
        Me.btnSuggest.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(88, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Result Qual"
        '
        'txtResultQual
        '
        Me.txtResultQual.Location = New System.Drawing.Point(91, 144)
        Me.txtResultQual.Name = "txtResultQual"
        Me.txtResultQual.Size = New System.Drawing.Size(70, 20)
        Me.txtResultQual.TabIndex = 22
        '
        'PU_Labs_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(253, 286)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtResultQual)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnSuggest)
        Me.Controls.Add(Me.numResultQuant)
        Me.Controls.Add(Me.btnSaveAdd)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.numRngTo)
        Me.Controls.Add(Me.numRngFrom)
        Me.Controls.Add(Me.txtUoM)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbLabSource)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSaveClose)
        Me.Controls.Add(Me.dtLabDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbLabName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PU_Labs_Add"
        Me.Text = "Subject Labs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbLabName As ComboBox_
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtLabDate As TextBoxDatePast
    Friend WithEvents btnSaveClose As Button_
    Friend WithEvents btnCancel As Button_
    Friend WithEvents cmbLabSource As ComboBox_
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUoM As TextBox_
    Friend WithEvents numRngFrom As TextBoxNumeric
    Friend WithEvents numRngTo As TextBoxNumeric
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSaveAdd As Button_
    Friend WithEvents numResultQuant As TextBoxNumeric
    Friend WithEvents btnSuggest As Button_
    Friend WithEvents Label8 As Label
    Friend WithEvents txtResultQual As TextBox_
End Class
