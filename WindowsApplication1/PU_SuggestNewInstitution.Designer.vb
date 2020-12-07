<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PU_SuggestNewInstitution
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
        Me.txtName = New DataWarehouse.TextBox_()
        Me.txtAddress1 = New DataWarehouse.TextBox_()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New DataWarehouse.Button_()
        Me.btnCancel = New DataWarehouse.Button_()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAddress2 = New DataWarehouse.TextBox_()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAddress4 = New DataWarehouse.TextBox_()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAddress3 = New DataWarehouse.TextBox_()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtZIP = New DataWarehouse.TextBox_()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtState = New DataWarehouse.TextBox_()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCity = New DataWarehouse.TextBox_()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNotes = New DataWarehouse.TextBox_()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtFax = New DataWarehouse.TextBox_()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTelephone = New DataWarehouse.TextBox_()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPOCRole = New DataWarehouse.TextBox_()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPOCName = New DataWarehouse.TextBox_()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(151, 6)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(470, 20)
        Me.txtName.TabIndex = 1
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New System.Drawing.Point(151, 25)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(470, 20)
        Me.txtAddress1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Institution Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Address 1"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(12, 300)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(93, 300)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Address 2"
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(151, 44)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(470, 20)
        Me.txtAddress2.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Address 4"
        '
        'txtAddress4
        '
        Me.txtAddress4.Location = New System.Drawing.Point(151, 82)
        Me.txtAddress4.Name = "txtAddress4"
        Me.txtAddress4.Size = New System.Drawing.Size(470, 20)
        Me.txtAddress4.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Address 3"
        '
        'txtAddress3
        '
        Me.txtAddress3.Location = New System.Drawing.Point(151, 63)
        Me.txtAddress3.Name = "txtAddress3"
        Me.txtAddress3.Size = New System.Drawing.Size(470, 20)
        Me.txtAddress3.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Zip"
        '
        'txtZIP
        '
        Me.txtZIP.Location = New System.Drawing.Point(151, 139)
        Me.txtZIP.Name = "txtZIP"
        Me.txtZIP.Size = New System.Drawing.Size(470, 20)
        Me.txtZIP.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "State"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(151, 120)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(470, 20)
        Me.txtState.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "City"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(151, 101)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(470, 20)
        Me.txtCity.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 237)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Notes"
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(151, 234)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(470, 60)
        Me.txtNotes.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 218)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 13)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Fax"
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(151, 215)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(470, 20)
        Me.txtFax.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 199)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Telephone"
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(151, 196)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(470, 20)
        Me.txtTelephone.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 180)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "POC Role"
        '
        'txtPOCRole
        '
        Me.txtPOCRole.Location = New System.Drawing.Point(151, 177)
        Me.txtPOCRole.Name = "txtPOCRole"
        Me.txtPOCRole.Size = New System.Drawing.Size(470, 20)
        Me.txtPOCRole.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 161)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "POC Name"
        '
        'txtPOCName
        '
        Me.txtPOCName.Location = New System.Drawing.Point(151, 158)
        Me.txtPOCName.Name = "txtPOCName"
        Me.txtPOCName.Size = New System.Drawing.Size(470, 20)
        Me.txtPOCName.TabIndex = 9
        '
        'PU_SuggestNewInstitution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(633, 330)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtTelephone)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtPOCRole)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtPOCName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtZIP)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAddress4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAddress3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAddress2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAddress1)
        Me.Controls.Add(Me.txtName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PU_SuggestNewInstitution"
        Me.Text = "Suggest New Institution"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As DataWarehouse.TextBox_
    Friend WithEvents txtAddress1 As DataWarehouse.TextBox_
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSave As DataWarehouse.Button_
    Friend WithEvents btnCancel As DataWarehouse.Button_
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAddress2 As DataWarehouse.TextBox_
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAddress4 As DataWarehouse.TextBox_
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAddress3 As DataWarehouse.TextBox_
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtZIP As DataWarehouse.TextBox_
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtState As DataWarehouse.TextBox_
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCity As DataWarehouse.TextBox_
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtNotes As DataWarehouse.TextBox_
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtFax As DataWarehouse.TextBox_
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTelephone As DataWarehouse.TextBox_
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtPOCRole As DataWarehouse.TextBox_
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPOCName As DataWarehouse.TextBox_
End Class
