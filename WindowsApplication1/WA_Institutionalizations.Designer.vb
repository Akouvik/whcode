<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WA_Institutionalizations
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
        Me.dgvInstitutionalizations = New System.Windows.Forms.DataGridView()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comboInstitution = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSubjectInstID = New System.Windows.Forms.TextBox()
        Me.txtWard = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFloor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRoom = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtStartDate = New System.Windows.Forms.MaskedTextBox()
        Me.txtEndDate = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.dgvInstitutionalizations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 29)
        Me.Label1.TabIndex = 216
        Me.Label1.Text = "Institutionalizations"
        '
        'dgvInstitutionalizations
        '
        Me.dgvInstitutionalizations.AllowUserToAddRows = False
        Me.dgvInstitutionalizations.AllowUserToDeleteRows = False
        Me.dgvInstitutionalizations.AllowUserToOrderColumns = True
        Me.dgvInstitutionalizations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInstitutionalizations.Location = New System.Drawing.Point(13, 44)
        Me.dgvInstitutionalizations.Name = "dgvInstitutionalizations"
        Me.dgvInstitutionalizations.ReadOnly = True
        Me.dgvInstitutionalizations.Size = New System.Drawing.Size(767, 204)
        Me.dgvInstitutionalizations.TabIndex = 217
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(12, 254)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(171, 23)
        Me.btnEdit.TabIndex = 303
        Me.btnEdit.Text = "Edit Selected Record"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(207, 254)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(171, 23)
        Me.btnAdd.TabIndex = 304
        Me.btnAdd.Text = "Add New Institutionalization"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 305)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 306
        Me.Label2.Text = "Institution"
        '
        'comboInstitution
        '
        Me.comboInstitution.FormattingEnabled = True
        Me.comboInstitution.Location = New System.Drawing.Point(69, 302)
        Me.comboInstitution.Name = "comboInstitution"
        Me.comboInstitution.Size = New System.Drawing.Size(142, 21)
        Me.comboInstitution.TabIndex = 307
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(213, 305)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 308
        Me.Label3.Text = "Subject Inst ID"
        '
        'txtSubjectInstID
        '
        Me.txtSubjectInstID.Location = New System.Drawing.Point(290, 302)
        Me.txtSubjectInstID.Name = "txtSubjectInstID"
        Me.txtSubjectInstID.Size = New System.Drawing.Size(100, 20)
        Me.txtSubjectInstID.TabIndex = 309
        '
        'txtWard
        '
        Me.txtWard.Location = New System.Drawing.Point(425, 302)
        Me.txtWard.Name = "txtWard"
        Me.txtWard.Size = New System.Drawing.Size(148, 20)
        Me.txtWard.TabIndex = 311
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(392, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 310
        Me.Label4.Text = "Ward"
        '
        'txtFloor
        '
        Me.txtFloor.Location = New System.Drawing.Point(69, 322)
        Me.txtFloor.Name = "txtFloor"
        Me.txtFloor.Size = New System.Drawing.Size(100, 20)
        Me.txtFloor.TabIndex = 313
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 312
        Me.Label5.Text = "Floor"
        '
        'txtRoom
        '
        Me.txtRoom.Location = New System.Drawing.Point(290, 322)
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.Size = New System.Drawing.Size(100, 20)
        Me.txtRoom.TabIndex = 315
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(213, 325)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 314
        Me.Label6.Text = "Room"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 344)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 316
        Me.Label7.Text = "Start Date"
        '
        'txtStartDate
        '
        Me.txtStartDate.Location = New System.Drawing.Point(69, 341)
        Me.txtStartDate.Mask = "00/00/0000"
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.Size = New System.Drawing.Size(100, 20)
        Me.txtStartDate.TabIndex = 317
        Me.txtStartDate.ValidatingType = GetType(Date)
        '
        'txtEndDate
        '
        Me.txtEndDate.Location = New System.Drawing.Point(290, 341)
        Me.txtEndDate.Mask = "00/00/0000"
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.Size = New System.Drawing.Size(100, 20)
        Me.txtEndDate.TabIndex = 319
        Me.txtEndDate.ValidatingType = GetType(Date)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(213, 344)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 318
        Me.Label8.Text = "End Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 363)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 320
        Me.Label9.Text = "Comment"
        '
        'txtComment
        '
        Me.txtComment.Location = New System.Drawing.Point(69, 360)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(503, 35)
        Me.txtComment.TabIndex = 321
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(207, 401)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(171, 23)
        Me.btnSave.TabIndex = 322
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(33, 284)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(518, 13)
        Me.Label10.TabIndex = 323
        Me.Label10.Text = "*If the subject's location has changed within the same institution, please add a " & _
    "new institutionalization record."
        '
        'WA_Institutionalizations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(792, 448)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtEndDate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtStartDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtRoom)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFloor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtWard)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSubjectInstID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.comboInstitution)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.dgvInstitutionalizations)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WA_Institutionalizations"
        Me.Text = "WA_PMCRInstitutionalizations"
        CType(Me.dgvInstitutionalizations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvInstitutionalizations As System.Windows.Forms.DataGridView
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents comboInstitution As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSubjectInstID As System.Windows.Forms.TextBox
    Friend WithEvents txtWard As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFloor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRoom As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtStartDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtEndDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
