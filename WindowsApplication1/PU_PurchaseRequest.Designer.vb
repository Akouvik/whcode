<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PU_PurchaseRequest
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkReviewed = New DataWarehouse.CheckBox_()
        Me.chkSubmitted = New DataWarehouse.CheckBox_()
        Me.btnSubmit = New DataWarehouse.Button_()
        Me.Source = New DataWarehouse.ComboBox_()
        Me.btnSource = New DataWarehouse.Button_()
        Me.btnDelete = New DataWarehouse.Button_()
        Me.btnClose = New DataWarehouse.Button_()
        Me.btnAddItem = New DataWarehouse.Button_()
        Me.btnEditItem = New DataWarehouse.Button_()
        Me.btnRequestHeader = New DataWarehouse.Button_()
        Me.RequestDate = New DataWarehouse.TextBoxDatePast()
        Me.dgvLineItems = New DataWarehouse.dgvSingleRow()
        Me.ChargeTo = New DataWarehouse.ComboBox_()
        Me.Requestor = New DataWarehouse.ComboBox_()
        Me.Comments = New DataWarehouse.TextBox_()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvLineItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Comments"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Requestor"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(370, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Charge To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(297, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Source/Vendor"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkReviewed)
        Me.GroupBox1.Controls.Add(Me.chkSubmitted)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(735, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 76)
        Me.GroupBox1.TabIndex = 116
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Request Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "This request has been:"
        '
        'chkReviewed
        '
        Me.chkReviewed.AutoSize = True
        Me.chkReviewed.BackColor = System.Drawing.Color.Tan
        Me.chkReviewed.Enabled = False
        Me.chkReviewed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkReviewed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReviewed.Location = New System.Drawing.Point(39, 49)
        Me.chkReviewed.Name = "chkReviewed"
        Me.chkReviewed.Size = New System.Drawing.Size(335, 17)
        Me.chkReviewed.TabIndex = 17
        Me.chkReviewed.Text = "Reviewed and approved (see items below for individual approvals)"
        Me.chkReviewed.UseVisualStyleBackColor = False
        '
        'chkSubmitted
        '
        Me.chkSubmitted.AutoSize = True
        Me.chkSubmitted.BackColor = System.Drawing.Color.Tan
        Me.chkSubmitted.Enabled = False
        Me.chkSubmitted.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkSubmitted.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSubmitted.Location = New System.Drawing.Point(39, 32)
        Me.chkSubmitted.Name = "chkSubmitted"
        Me.chkSubmitted.Size = New System.Drawing.Size(119, 17)
        Me.chkSubmitted.TabIndex = 16
        Me.chkSubmitted.Text = "Submitted for review"
        Me.chkSubmitted.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(600, 153)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(129, 23)
        Me.btnSubmit.TabIndex = 115
        Me.btnSubmit.Text = "Dynamic Text"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Source
        '
        Me.Source.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Source.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Source.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Source.FormattingEnabled = True
        Me.Source.Location = New System.Drawing.Point(15, 67)
        Me.Source.Name = "Source"
        Me.Source.Size = New System.Drawing.Size(590, 21)
        Me.Source.TabIndex = 104
        '
        'btnSource
        '
        Me.btnSource.Location = New System.Drawing.Point(611, 66)
        Me.btnSource.Name = "btnSource"
        Me.btnSource.Size = New System.Drawing.Size(118, 23)
        Me.btnSource.TabIndex = 105
        Me.btnSource.Text = "Add New Source"
        Me.btnSource.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(284, 489)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(129, 23)
        Me.btnDelete.TabIndex = 113
        Me.btnDelete.Text = "Remove Selected Item"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(419, 489)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(129, 23)
        Me.btnClose.TabIndex = 114
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(14, 489)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(129, 23)
        Me.btnAddItem.TabIndex = 111
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'btnEditItem
        '
        Me.btnEditItem.Location = New System.Drawing.Point(149, 489)
        Me.btnEditItem.Name = "btnEditItem"
        Me.btnEditItem.Size = New System.Drawing.Size(129, 23)
        Me.btnEditItem.TabIndex = 112
        Me.btnEditItem.Text = "Edit Selected Item"
        Me.btnEditItem.UseVisualStyleBackColor = True
        '
        'btnRequestHeader
        '
        Me.btnRequestHeader.Location = New System.Drawing.Point(16, 153)
        Me.btnRequestHeader.Name = "btnRequestHeader"
        Me.btnRequestHeader.Size = New System.Drawing.Size(129, 23)
        Me.btnRequestHeader.TabIndex = 109
        Me.btnRequestHeader.Text = "Dynamic Text"
        Me.btnRequestHeader.UseVisualStyleBackColor = True
        '
        'RequestDate
        '
        Me.RequestDate.Location = New System.Drawing.Point(300, 26)
        Me.RequestDate.Mask = "00/00/0000"
        Me.RequestDate.Name = "RequestDate"
        Me.RequestDate.Size = New System.Drawing.Size(67, 20)
        Me.RequestDate.TabIndex = 102
        Me.RequestDate.ValidatingType = GetType(Date)
        '
        'dgvLineItems
        '
        Me.dgvLineItems.AllowUserToAddRows = False
        Me.dgvLineItems.AllowUserToDeleteRows = False
        Me.dgvLineItems.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige
        Me.dgvLineItems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLineItems.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dgvLineItems.BackgroundColor = System.Drawing.Color.Tan
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLineItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLineItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLineItems.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvLineItems.GridColor = System.Drawing.Color.Linen
        Me.dgvLineItems.Location = New System.Drawing.Point(15, 182)
        Me.dgvLineItems.MultiSelect = False
        Me.dgvLineItems.Name = "dgvLineItems"
        Me.dgvLineItems.ReadOnly = True
        Me.dgvLineItems.RowHeadersVisible = False
        Me.dgvLineItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvLineItems.Size = New System.Drawing.Size(1131, 301)
        Me.dgvLineItems.TabIndex = 110
        '
        'ChargeTo
        '
        Me.ChargeTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ChargeTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ChargeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ChargeTo.FormattingEnabled = True
        Me.ChargeTo.Location = New System.Drawing.Point(373, 25)
        Me.ChargeTo.Name = "ChargeTo"
        Me.ChargeTo.Size = New System.Drawing.Size(356, 21)
        Me.ChargeTo.TabIndex = 103
        '
        'Requestor
        '
        Me.Requestor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Requestor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Requestor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Requestor.FormattingEnabled = True
        Me.Requestor.Location = New System.Drawing.Point(15, 25)
        Me.Requestor.Name = "Requestor"
        Me.Requestor.Size = New System.Drawing.Size(279, 21)
        Me.Requestor.TabIndex = 101
        '
        'Comments
        '
        Me.Comments.Location = New System.Drawing.Point(15, 107)
        Me.Comments.Multiline = True
        Me.Comments.Name = "Comments"
        Me.Comments.Size = New System.Drawing.Size(714, 40)
        Me.Comments.TabIndex = 106
        '
        'PU_PurchaseRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(1159, 521)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Source)
        Me.Controls.Add(Me.btnSource)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.btnEditItem)
        Me.Controls.Add(Me.btnRequestHeader)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.RequestDate)
        Me.Controls.Add(Me.dgvLineItems)
        Me.Controls.Add(Me.ChargeTo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Requestor)
        Me.Controls.Add(Me.Comments)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PU_PurchaseRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Purchase Request"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvLineItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Comments As TextBox_
    Friend WithEvents Label6 As Label
    Friend WithEvents Requestor As ComboBox_
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ChargeTo As ComboBox_
    Friend WithEvents Label10 As Label
    Friend WithEvents Approved As ComboBox_
    Friend WithEvents btnEditItem As Button_
    Friend WithEvents btnClose As Button_
    Friend WithEvents dgvLineItems As dgvSingleRow
    Friend WithEvents btnAddItem As Button_
    Friend WithEvents btnDelete As Button_
    Friend WithEvents RequestDate As TextBoxDatePast
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRequestHeader As Button_
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSource As Button_
    Friend WithEvents Source As ComboBox_
    Friend WithEvents btnSubmit As Button_
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkReviewed As CheckBox_
    Friend WithEvents chkSubmitted As CheckBox_
    Friend WithEvents Label3 As Label
End Class
