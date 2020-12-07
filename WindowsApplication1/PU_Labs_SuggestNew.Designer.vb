<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PU_Labs_SuggestNew
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
        Me.btnSubmit = New DataWarehouse.Button_()
        Me.numResultQuant = New DataWarehouse.TextBoxNumeric()
        Me.txtResultQual = New DataWarehouse.TextBox_()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.numRngTo = New DataWarehouse.TextBoxNumeric()
        Me.numRngFrom = New DataWarehouse.TextBoxNumeric()
        Me.txtUoM = New DataWarehouse.TextBox_()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbLabSource = New DataWarehouse.ComboBox_()
        Me.dtLabDate = New DataWarehouse.TextBoxDatePast()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLabName = New DataWarehouse.TextBox_()
        Me.btnCancel = New DataWarehouse.Button_()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(15, 238)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(99, 23)
        Me.btnSubmit.TabIndex = 39
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'numResultQuant
        '
        Me.numResultQuant.Location = New System.Drawing.Point(15, 212)
        Me.numResultQuant.Name = "numResultQuant"
        Me.numResultQuant.Size = New System.Drawing.Size(70, 20)
        Me.numResultQuant.TabIndex = 28
        '
        'txtResultQual
        '
        Me.txtResultQual.Location = New System.Drawing.Point(94, 212)
        Me.txtResultQual.Name = "txtResultQual"
        Me.txtResultQual.Size = New System.Drawing.Size(70, 20)
        Me.txtResultQual.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(91, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Result Qual"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Result Quant"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(170, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Rng To"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Rng From"
        '
        'numRngTo
        '
        Me.numRngTo.Location = New System.Drawing.Point(173, 173)
        Me.numRngTo.Name = "numRngTo"
        Me.numRngTo.Size = New System.Drawing.Size(70, 20)
        Me.numRngTo.TabIndex = 26
        '
        'numRngFrom
        '
        Me.numRngFrom.Location = New System.Drawing.Point(94, 173)
        Me.numRngFrom.Name = "numRngFrom"
        Me.numRngFrom.Size = New System.Drawing.Size(70, 20)
        Me.numRngFrom.TabIndex = 25
        '
        'txtUoM
        '
        Me.txtUoM.Location = New System.Drawing.Point(15, 173)
        Me.txtUoM.Name = "txtUoM"
        Me.txtUoM.Size = New System.Drawing.Size(70, 20)
        Me.txtUoM.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Source"
        '
        'cmbLabSource
        '
        Me.cmbLabSource.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbLabSource.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbLabSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLabSource.FormattingEnabled = True
        Me.cmbLabSource.Location = New System.Drawing.Point(15, 93)
        Me.cmbLabSource.Name = "cmbLabSource"
        Me.cmbLabSource.Size = New System.Drawing.Size(228, 21)
        Me.cmbLabSource.TabIndex = 20
        '
        'dtLabDate
        '
        Me.dtLabDate.Location = New System.Drawing.Point(173, 212)
        Me.dtLabDate.Mask = "00/00/0000"
        Me.dtLabDate.Name = "dtLabDate"
        Me.dtLabDate.Size = New System.Drawing.Size(70, 20)
        Me.dtLabDate.TabIndex = 30
        Me.dtLabDate.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(170, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "UoM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Lab Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(244, 52)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Once approved, the below suggested lab will be " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "automatically added to the subje" &
    "ct from which" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you made the request, so please fill in all available " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "informati" &
    "on!"
        '
        'txtLabName
        '
        Me.txtLabName.Location = New System.Drawing.Point(15, 133)
        Me.txtLabName.Name = "txtLabName"
        Me.txtLabName.Size = New System.Drawing.Size(228, 20)
        Me.txtLabName.TabIndex = 41
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(144, 238)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(99, 23)
        Me.btnCancel.TabIndex = 42
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'PU_Labs_SuggestNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(257, 269)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtLabName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.numResultQuant)
        Me.Controls.Add(Me.txtResultQual)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.numRngTo)
        Me.Controls.Add(Me.numRngFrom)
        Me.Controls.Add(Me.txtUoM)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbLabSource)
        Me.Controls.Add(Me.dtLabDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PU_Labs_SuggestNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Suggest a New Lab"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button_
    Friend WithEvents numResultQuant As TextBoxNumeric
    Friend WithEvents txtResultQual As TextBox_
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents numRngTo As TextBoxNumeric
    Friend WithEvents numRngFrom As TextBoxNumeric
    Friend WithEvents txtUoM As TextBox_
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbLabSource As ComboBox_
    Friend WithEvents dtLabDate As TextBoxDatePast
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtLabName As TextBox_
    Friend WithEvents btnCancel As Button_
End Class
