<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PU_Specimen_Edit
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
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.intBoxRow = New DataWarehouse.TextBoxInteger()
        Me.intBoxCol = New DataWarehouse.TextBoxInteger()
        Me.intShelfCol = New DataWarehouse.TextBoxInteger()
        Me.txtBrainRegionDetail = New DataWarehouse.TextBox_()
        Me.txtNote = New DataWarehouse.TextBox_()
        Me.intProjectID = New DataWarehouse.TextBoxInteger()
        Me.cmbBrainRegion = New DataWarehouse.ComboBox_()
        Me.cmbUoM = New DataWarehouse.ComboBox_()
        Me.cmbStorageType = New DataWarehouse.ComboBox_()
        Me.intSize = New DataWarehouse.TextBoxInteger()
        Me.numBB = New DataWarehouse.TextBoxNumeric()
        Me.intBarcode = New DataWarehouse.TextBoxInteger()
        Me.btnSaveAndClose = New DataWarehouse.Button_()
        Me.btnCancelClose = New DataWarehouse.Button_()
        Me.intShelfRow = New DataWarehouse.TextBoxInteger()
        Me.intShelfNum = New DataWarehouse.TextBoxInteger()
        Me.intLocNum = New DataWarehouse.TextBoxInteger()
        Me.cmbLocType = New DataWarehouse.ComboBox_()
        Me.intBoxNum = New DataWarehouse.TextBoxInteger()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(60, 376)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 13)
        Me.Label17.TabIndex = 179
        Me.Label17.Text = "Box Row"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(67, 350)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 13)
        Me.Label16.TabIndex = 178
        Me.Label16.Text = "Box Col"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(61, 272)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 177
        Me.Label15.Text = "Shelf Col"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 115)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 13)
        Me.Label14.TabIndex = 153
        Me.Label14.Text = "Brain Region Detail"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(80, 428)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 13)
        Me.Label13.TabIndex = 152
        Me.Label13.Text = "Note"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(56, 402)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 151
        Me.Label12.Text = "Project ID"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(83, 167)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 150
        Me.Label11.Text = "Size"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(80, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 149
        Me.Label10.Text = "UoM"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(42, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 148
        Me.Label9.Text = "Brain Region"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 147
        Me.Label8.Text = "Storage Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(79, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 146
        Me.Label7.Text = "BB #"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(53, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 145
        Me.Label6.Text = "Barcode #"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 144
        Me.Label5.Text = "Shelf Row"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 143
        Me.Label4.Text = "Shelf #"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Loc #"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 141
        Me.Label2.Text = "Loc Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 324)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 140
        Me.Label1.Text = "Box #"
        '
        'intBoxRow
        '
        Me.intBoxRow.Location = New System.Drawing.Point(116, 373)
        Me.intBoxRow.Name = "intBoxRow"
        Me.intBoxRow.Size = New System.Drawing.Size(142, 20)
        Me.intBoxRow.TabIndex = 168
        '
        'intBoxCol
        '
        Me.intBoxCol.Location = New System.Drawing.Point(116, 347)
        Me.intBoxCol.Name = "intBoxCol"
        Me.intBoxCol.Size = New System.Drawing.Size(142, 20)
        Me.intBoxCol.TabIndex = 167
        '
        'intShelfCol
        '
        Me.intShelfCol.Location = New System.Drawing.Point(116, 269)
        Me.intShelfCol.Name = "intShelfCol"
        Me.intShelfCol.Size = New System.Drawing.Size(142, 20)
        Me.intShelfCol.TabIndex = 164
        '
        'txtBrainRegionDetail
        '
        Me.txtBrainRegionDetail.Location = New System.Drawing.Point(116, 112)
        Me.txtBrainRegionDetail.Name = "txtBrainRegionDetail"
        Me.txtBrainRegionDetail.Size = New System.Drawing.Size(142, 20)
        Me.txtBrainRegionDetail.TabIndex = 158
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(116, 425)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(142, 20)
        Me.txtNote.TabIndex = 170
        '
        'intProjectID
        '
        Me.intProjectID.Location = New System.Drawing.Point(116, 399)
        Me.intProjectID.Name = "intProjectID"
        Me.intProjectID.Size = New System.Drawing.Size(142, 20)
        Me.intProjectID.TabIndex = 169
        '
        'cmbBrainRegion
        '
        Me.cmbBrainRegion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbBrainRegion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBrainRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBrainRegion.FormattingEnabled = True
        Me.cmbBrainRegion.Location = New System.Drawing.Point(116, 85)
        Me.cmbBrainRegion.Name = "cmbBrainRegion"
        Me.cmbBrainRegion.Size = New System.Drawing.Size(142, 21)
        Me.cmbBrainRegion.TabIndex = 157
        '
        'cmbUoM
        '
        Me.cmbUoM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbUoM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbUoM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUoM.FormattingEnabled = True
        Me.cmbUoM.Location = New System.Drawing.Point(116, 138)
        Me.cmbUoM.Name = "cmbUoM"
        Me.cmbUoM.Size = New System.Drawing.Size(142, 21)
        Me.cmbUoM.TabIndex = 159
        '
        'cmbStorageType
        '
        Me.cmbStorageType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbStorageType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbStorageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStorageType.FormattingEnabled = True
        Me.cmbStorageType.Location = New System.Drawing.Point(116, 58)
        Me.cmbStorageType.Name = "cmbStorageType"
        Me.cmbStorageType.Size = New System.Drawing.Size(142, 21)
        Me.cmbStorageType.TabIndex = 156
        '
        'intSize
        '
        Me.intSize.Location = New System.Drawing.Point(116, 164)
        Me.intSize.Name = "intSize"
        Me.intSize.Size = New System.Drawing.Size(142, 20)
        Me.intSize.TabIndex = 160
        '
        'numBB
        '
        Me.numBB.Location = New System.Drawing.Point(116, 32)
        Me.numBB.Name = "numBB"
        Me.numBB.Size = New System.Drawing.Size(142, 20)
        Me.numBB.TabIndex = 155
        '
        'intBarcode
        '
        Me.intBarcode.Enabled = False
        Me.intBarcode.Location = New System.Drawing.Point(116, 6)
        Me.intBarcode.Name = "intBarcode"
        Me.intBarcode.Size = New System.Drawing.Size(142, 20)
        Me.intBarcode.TabIndex = 154
        '
        'btnSaveAndClose
        '
        Me.btnSaveAndClose.Location = New System.Drawing.Point(116, 451)
        Me.btnSaveAndClose.Name = "btnSaveAndClose"
        Me.btnSaveAndClose.Size = New System.Drawing.Size(142, 23)
        Me.btnSaveAndClose.TabIndex = 174
        Me.btnSaveAndClose.Text = "Save and close"
        Me.btnSaveAndClose.UseVisualStyleBackColor = True
        '
        'btnCancelClose
        '
        Me.btnCancelClose.Location = New System.Drawing.Point(116, 480)
        Me.btnCancelClose.Name = "btnCancelClose"
        Me.btnCancelClose.Size = New System.Drawing.Size(142, 23)
        Me.btnCancelClose.TabIndex = 176
        Me.btnCancelClose.Text = "Cancel/Close"
        Me.btnCancelClose.UseVisualStyleBackColor = True
        '
        'intShelfRow
        '
        Me.intShelfRow.Location = New System.Drawing.Point(116, 295)
        Me.intShelfRow.Name = "intShelfRow"
        Me.intShelfRow.Size = New System.Drawing.Size(142, 20)
        Me.intShelfRow.TabIndex = 165
        '
        'intShelfNum
        '
        Me.intShelfNum.Location = New System.Drawing.Point(116, 243)
        Me.intShelfNum.Name = "intShelfNum"
        Me.intShelfNum.Size = New System.Drawing.Size(142, 20)
        Me.intShelfNum.TabIndex = 163
        '
        'intLocNum
        '
        Me.intLocNum.Location = New System.Drawing.Point(116, 217)
        Me.intLocNum.Name = "intLocNum"
        Me.intLocNum.Size = New System.Drawing.Size(142, 20)
        Me.intLocNum.TabIndex = 162
        '
        'cmbLocType
        '
        Me.cmbLocType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbLocType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbLocType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLocType.FormattingEnabled = True
        Me.cmbLocType.Items.AddRange(New Object() {"Freezer", "Dry Rack"})
        Me.cmbLocType.Location = New System.Drawing.Point(116, 190)
        Me.cmbLocType.Name = "cmbLocType"
        Me.cmbLocType.Size = New System.Drawing.Size(142, 21)
        Me.cmbLocType.TabIndex = 161
        '
        'intBoxNum
        '
        Me.intBoxNum.Location = New System.Drawing.Point(116, 321)
        Me.intBoxNum.Name = "intBoxNum"
        Me.intBoxNum.Size = New System.Drawing.Size(142, 20)
        Me.intBoxNum.TabIndex = 166
        '
        'PU_Specimen_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(269, 508)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.intBoxRow)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.intBoxCol)
        Me.Controls.Add(Me.intShelfCol)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtBrainRegionDetail)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.intProjectID)
        Me.Controls.Add(Me.cmbBrainRegion)
        Me.Controls.Add(Me.cmbUoM)
        Me.Controls.Add(Me.cmbStorageType)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.intSize)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.numBB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.intBarcode)
        Me.Controls.Add(Me.btnSaveAndClose)
        Me.Controls.Add(Me.btnCancelClose)
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
        Me.Name = "PU_Specimen_Edit"
        Me.Text = "Edit Specimen Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As Label
    Friend WithEvents intBoxRow As TextBoxInteger
    Friend WithEvents Label16 As Label
    Friend WithEvents intBoxCol As TextBoxInteger
    Friend WithEvents intShelfCol As TextBoxInteger
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtBrainRegionDetail As TextBox_
    Friend WithEvents Label13 As Label
    Friend WithEvents txtNote As TextBox_
    Friend WithEvents Label12 As Label
    Friend WithEvents intProjectID As TextBoxInteger
    Friend WithEvents cmbBrainRegion As ComboBox_
    Friend WithEvents cmbUoM As ComboBox_
    Friend WithEvents cmbStorageType As ComboBox_
    Friend WithEvents Label11 As Label
    Friend WithEvents intSize As TextBoxInteger
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents numBB As TextBoxNumeric
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents intBarcode As TextBoxInteger
    Friend WithEvents btnSaveAndClose As Button_
    Friend WithEvents btnCancelClose As Button_
    Friend WithEvents intShelfRow As TextBoxInteger
    Friend WithEvents Label5 As Label
    Friend WithEvents intShelfNum As TextBoxInteger
    Friend WithEvents Label4 As Label
    Friend WithEvents intLocNum As TextBoxInteger
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbLocType As ComboBox_
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents intBoxNum As TextBoxInteger
End Class
