<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PU_PurchaseRequestItem
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
        Me.ItemDescription = New DataWarehouse.TextBox_()
        Me.Quantity = New DataWarehouse.TextBoxInteger()
        Me.UnitCost = New DataWarehouse.TextBoxNumeric()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSaveClose = New DataWarehouse.Button_()
        Me.btnSaveAdd = New DataWarehouse.Button_()
        Me.btnCancel = New DataWarehouse.Button_()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Recipient = New DataWarehouse.ComboBox_()
        Me.Category = New DataWarehouse.ComboBox_()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCategory = New DataWarehouse.Button_()
        Me.SuspendLayout()
        '
        'ItemDescription
        '
        Me.ItemDescription.Location = New System.Drawing.Point(12, 65)
        Me.ItemDescription.Name = "ItemDescription"
        Me.ItemDescription.Size = New System.Drawing.Size(532, 20)
        Me.ItemDescription.TabIndex = 201
        '
        'Quantity
        '
        Me.Quantity.Location = New System.Drawing.Point(15, 104)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(56, 20)
        Me.Quantity.TabIndex = 202
        '
        'UnitCost
        '
        Me.UnitCost.Location = New System.Drawing.Point(77, 104)
        Me.UnitCost.Name = "UnitCost"
        Me.UnitCost.Size = New System.Drawing.Size(100, 20)
        Me.UnitCost.TabIndex = 203
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Item Description (include web links where appropriate)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Qty"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Unit Cost"
        '
        'btnSaveClose
        '
        Me.btnSaveClose.Location = New System.Drawing.Point(35, 131)
        Me.btnSaveClose.Name = "btnSaveClose"
        Me.btnSaveClose.Size = New System.Drawing.Size(157, 23)
        Me.btnSaveClose.TabIndex = 205
        Me.btnSaveClose.Text = "Save and Close"
        Me.btnSaveClose.UseVisualStyleBackColor = True
        '
        'btnSaveAdd
        '
        Me.btnSaveAdd.Location = New System.Drawing.Point(198, 131)
        Me.btnSaveAdd.Name = "btnSaveAdd"
        Me.btnSaveAdd.Size = New System.Drawing.Size(157, 23)
        Me.btnSaveAdd.TabIndex = 206
        Me.btnSaveAdd.Text = "Save and Add Another"
        Me.btnSaveAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(361, 131)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(157, 23)
        Me.btnCancel.TabIndex = 207
        Me.btnCancel.Text = "Cancel/Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(183, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Recipient (who needs this item)"
        '
        'Recipient
        '
        Me.Recipient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Recipient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Recipient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Recipient.FormattingEnabled = True
        Me.Recipient.Location = New System.Drawing.Point(183, 104)
        Me.Recipient.Name = "Recipient"
        Me.Recipient.Size = New System.Drawing.Size(361, 21)
        Me.Recipient.TabIndex = 204
        '
        'Category
        '
        Me.Category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Category.FormattingEnabled = True
        Me.Category.Location = New System.Drawing.Point(12, 25)
        Me.Category.Name = "Category"
        Me.Category.Size = New System.Drawing.Size(195, 21)
        Me.Category.TabIndex = 200
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(195, 13)
        Me.Label5.TabIndex = 207
        Me.Label5.Text = "Category (for use in Sinai Central orders)"
        '
        'btnCategory
        '
        Me.btnCategory.Location = New System.Drawing.Point(213, 24)
        Me.btnCategory.Name = "btnCategory"
        Me.btnCategory.Size = New System.Drawing.Size(118, 23)
        Me.btnCategory.TabIndex = 208
        Me.btnCategory.Text = "Add New Category"
        Me.btnCategory.UseVisualStyleBackColor = True
        '
        'PU_PurchaseRequestItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(558, 161)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCategory)
        Me.Controls.Add(Me.Category)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Recipient)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSaveAdd)
        Me.Controls.Add(Me.btnSaveClose)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UnitCost)
        Me.Controls.Add(Me.Quantity)
        Me.Controls.Add(Me.ItemDescription)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PU_PurchaseRequestItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Purchase Request Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ItemDescription As TextBox_
    Friend WithEvents Quantity As TextBoxInteger
    Friend WithEvents UnitCost As TextBoxNumeric
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSaveClose As Button_
    Friend WithEvents btnSaveAdd As Button_
    Friend WithEvents btnCancel As Button_
    Friend WithEvents Label4 As Label
    Friend WithEvents Recipient As ComboBox_
    Friend WithEvents Category As ComboBox_
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCategory As Button_
End Class
