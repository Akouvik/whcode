<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PU_Alz_Acceptance
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Cancel = New DataWarehouse.Button_()
        Me.NA = New DataWarehouse.CheckBox_()
        Me.Save = New DataWarehouse.Button_()
        Me.Result = New DataWarehouse.ComboBox_()
        Me.Q6N = New DataWarehouse.CheckBox_()
        Me.Q6Y = New DataWarehouse.CheckBox_()
        Me.Q5N = New DataWarehouse.CheckBox_()
        Me.Q5Y = New DataWarehouse.CheckBox_()
        Me.Q3N = New DataWarehouse.CheckBox_()
        Me.Q3Y = New DataWarehouse.CheckBox_()
        Me.Q4N = New DataWarehouse.CheckBox_()
        Me.Q4Y = New DataWarehouse.CheckBox_()
        Me.Q1N = New DataWarehouse.CheckBox_()
        Me.Q1Y = New DataWarehouse.CheckBox_()
        Me.Q2N = New DataWarehouse.CheckBox_()
        Me.Q2Y = New DataWarehouse.CheckBox_()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(461, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "2. Was the donor diagnosed with Alzheimer's before age 60 (regardless of who made" &
    " diagnosis)?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(257, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "1. Is the AD donor registered (ADRC or pre-enrolled)?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(257, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "4. Was the donor diagnosed with AD by a physician?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(234, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "3. Is the donor a minority (not white/caucasian)?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(470, 26)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "5. Is there any significant family history of dementia (3 or more relatives of th" &
    "e donor with dementia) " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    OR has the family participated in a genetic study o" &
    "n families with dementia?"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(379, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "6. Has the donor participated in AD or dementia clinical trials or other research" &
    "?"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(608, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Please answer these questions in order. Once a determinitation can be made, it wi" &
    "ll populate the results dropdown automatically."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Accept Result"
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(319, 235)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 23
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'NA
        '
        Me.NA.AutoSize = True
        Me.NA.BackColor = System.Drawing.Color.Tan
        Me.NA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NA.Location = New System.Drawing.Point(214, 35)
        Me.NA.Name = "NA"
        Me.NA.Size = New System.Drawing.Size(214, 17)
        Me.NA.TabIndex = 22
        Me.NA.Text = "N/A (No mention of Alzheimer's Disease)"
        Me.NA.UseVisualStyleBackColor = False
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(238, 235)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(75, 23)
        Me.Save.TabIndex = 21
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Result
        '
        Me.Result.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Result.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Result.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Result.Enabled = False
        Me.Result.FormattingEnabled = True
        Me.Result.Location = New System.Drawing.Point(120, 208)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(471, 21)
        Me.Result.TabIndex = 19
        '
        'Q6N
        '
        Me.Q6N.AutoSize = True
        Me.Q6N.BackColor = System.Drawing.Color.Tan
        Me.Q6N.Enabled = False
        Me.Q6N.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Q6N.Location = New System.Drawing.Point(554, 186)
        Me.Q6N.Name = "Q6N"
        Me.Q6N.Size = New System.Drawing.Size(37, 17)
        Me.Q6N.TabIndex = 17
        Me.Q6N.Text = "No"
        Me.Q6N.UseVisualStyleBackColor = False
        '
        'Q6Y
        '
        Me.Q6Y.AutoSize = True
        Me.Q6Y.BackColor = System.Drawing.Color.Tan
        Me.Q6Y.Enabled = False
        Me.Q6Y.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Q6Y.Location = New System.Drawing.Point(507, 186)
        Me.Q6Y.Name = "Q6Y"
        Me.Q6Y.Size = New System.Drawing.Size(41, 17)
        Me.Q6Y.TabIndex = 16
        Me.Q6Y.Text = "Yes"
        Me.Q6Y.UseVisualStyleBackColor = False
        '
        'Q5N
        '
        Me.Q5N.AutoSize = True
        Me.Q5N.BackColor = System.Drawing.Color.Tan
        Me.Q5N.Enabled = False
        Me.Q5N.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Q5N.Location = New System.Drawing.Point(554, 155)
        Me.Q5N.Name = "Q5N"
        Me.Q5N.Size = New System.Drawing.Size(37, 17)
        Me.Q5N.TabIndex = 14
        Me.Q5N.Text = "No"
        Me.Q5N.UseVisualStyleBackColor = False
        '
        'Q5Y
        '
        Me.Q5Y.AutoSize = True
        Me.Q5Y.BackColor = System.Drawing.Color.Tan
        Me.Q5Y.Enabled = False
        Me.Q5Y.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Q5Y.Location = New System.Drawing.Point(507, 155)
        Me.Q5Y.Name = "Q5Y"
        Me.Q5Y.Size = New System.Drawing.Size(41, 17)
        Me.Q5Y.TabIndex = 13
        Me.Q5Y.Text = "Yes"
        Me.Q5Y.UseVisualStyleBackColor = False
        '
        'Q3N
        '
        Me.Q3N.AutoSize = True
        Me.Q3N.BackColor = System.Drawing.Color.Tan
        Me.Q3N.Enabled = False
        Me.Q3N.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Q3N.Location = New System.Drawing.Point(554, 109)
        Me.Q3N.Name = "Q3N"
        Me.Q3N.Size = New System.Drawing.Size(37, 17)
        Me.Q3N.TabIndex = 11
        Me.Q3N.Text = "No"
        Me.Q3N.UseVisualStyleBackColor = False
        '
        'Q3Y
        '
        Me.Q3Y.AutoSize = True
        Me.Q3Y.BackColor = System.Drawing.Color.Tan
        Me.Q3Y.Enabled = False
        Me.Q3Y.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Q3Y.Location = New System.Drawing.Point(507, 109)
        Me.Q3Y.Name = "Q3Y"
        Me.Q3Y.Size = New System.Drawing.Size(41, 17)
        Me.Q3Y.TabIndex = 10
        Me.Q3Y.Text = "Yes"
        Me.Q3Y.UseVisualStyleBackColor = False
        '
        'Q4N
        '
        Me.Q4N.AutoSize = True
        Me.Q4N.BackColor = System.Drawing.Color.Tan
        Me.Q4N.Enabled = False
        Me.Q4N.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Q4N.Location = New System.Drawing.Point(554, 132)
        Me.Q4N.Name = "Q4N"
        Me.Q4N.Size = New System.Drawing.Size(37, 17)
        Me.Q4N.TabIndex = 8
        Me.Q4N.Text = "No"
        Me.Q4N.UseVisualStyleBackColor = False
        '
        'Q4Y
        '
        Me.Q4Y.AutoSize = True
        Me.Q4Y.BackColor = System.Drawing.Color.Tan
        Me.Q4Y.Enabled = False
        Me.Q4Y.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Q4Y.Location = New System.Drawing.Point(507, 132)
        Me.Q4Y.Name = "Q4Y"
        Me.Q4Y.Size = New System.Drawing.Size(41, 17)
        Me.Q4Y.TabIndex = 7
        Me.Q4Y.Text = "Yes"
        Me.Q4Y.UseVisualStyleBackColor = False
        '
        'Q1N
        '
        Me.Q1N.AutoSize = True
        Me.Q1N.BackColor = System.Drawing.Color.Tan
        Me.Q1N.Enabled = False
        Me.Q1N.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Q1N.Location = New System.Drawing.Point(554, 63)
        Me.Q1N.Name = "Q1N"
        Me.Q1N.Size = New System.Drawing.Size(37, 17)
        Me.Q1N.TabIndex = 5
        Me.Q1N.Text = "No"
        Me.Q1N.UseVisualStyleBackColor = False
        '
        'Q1Y
        '
        Me.Q1Y.AutoSize = True
        Me.Q1Y.BackColor = System.Drawing.Color.Tan
        Me.Q1Y.Enabled = False
        Me.Q1Y.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Q1Y.Location = New System.Drawing.Point(507, 63)
        Me.Q1Y.Name = "Q1Y"
        Me.Q1Y.Size = New System.Drawing.Size(41, 17)
        Me.Q1Y.TabIndex = 4
        Me.Q1Y.Text = "Yes"
        Me.Q1Y.UseVisualStyleBackColor = False
        '
        'Q2N
        '
        Me.Q2N.AutoSize = True
        Me.Q2N.BackColor = System.Drawing.Color.Tan
        Me.Q2N.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Q2N.Location = New System.Drawing.Point(554, 86)
        Me.Q2N.Name = "Q2N"
        Me.Q2N.Size = New System.Drawing.Size(37, 17)
        Me.Q2N.TabIndex = 2
        Me.Q2N.Text = "No"
        Me.Q2N.UseVisualStyleBackColor = False
        '
        'Q2Y
        '
        Me.Q2Y.AutoSize = True
        Me.Q2Y.BackColor = System.Drawing.Color.Tan
        Me.Q2Y.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Q2Y.Location = New System.Drawing.Point(507, 86)
        Me.Q2Y.Name = "Q2Y"
        Me.Q2Y.Size = New System.Drawing.Size(41, 17)
        Me.Q2Y.TabIndex = 1
        Me.Q2Y.Text = "Yes"
        Me.Q2Y.UseVisualStyleBackColor = False
        '
        'PU_Alz_Acceptance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(630, 264)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.NA)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Q6N)
        Me.Controls.Add(Me.Q6Y)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Q5N)
        Me.Controls.Add(Me.Q5Y)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Q3N)
        Me.Controls.Add(Me.Q3Y)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Q4N)
        Me.Controls.Add(Me.Q4Y)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Q1N)
        Me.Controls.Add(Me.Q1Y)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Q2N)
        Me.Controls.Add(Me.Q2Y)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PU_Alz_Acceptance"
        Me.Text = "Alzheimer's Acceptance Criteria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Q2Y As CheckBox_
    Friend WithEvents Q2N As CheckBox_
    Friend WithEvents Q1N As CheckBox_
    Friend WithEvents Q1Y As CheckBox_
    Friend WithEvents Label2 As Label
    Friend WithEvents Q4N As CheckBox_
    Friend WithEvents Q4Y As CheckBox_
    Friend WithEvents Label3 As Label
    Friend WithEvents Q3N As CheckBox_
    Friend WithEvents Q3Y As CheckBox_
    Friend WithEvents Label4 As Label
    Friend WithEvents Q5N As CheckBox_
    Friend WithEvents Q5Y As CheckBox_
    Friend WithEvents Label5 As Label
    Friend WithEvents Q6N As CheckBox_
    Friend WithEvents Q6Y As CheckBox_
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Result As ComboBox_
    Friend WithEvents Label8 As Label
    Friend WithEvents Save As Button_
    Friend WithEvents NA As CheckBox_
    Friend WithEvents Cancel As Button_
End Class
