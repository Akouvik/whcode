<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WA_PurchaseRequests
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgvResults = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New DataWarehouse.Button_()
        Me.btnDelete = New DataWarehouse.Button_()
        Me.chkHideComplete = New DataWarehouse.CheckBox_()
        Me.btnEdit = New DataWarehouse.Button_()
        Me.btnExport = New DataWarehouse.Button_()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(0, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(239, 29)
        Me.Label12.TabIndex = 208
        Me.Label12.Text = "Purchase Requests"
        '
        'dgvResults
        '
        Me.dgvResults.AllowUserToAddRows = False
        Me.dgvResults.AllowUserToDeleteRows = False
        Me.dgvResults.AllowUserToOrderColumns = True
        Me.dgvResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvResults.BackgroundColor = System.Drawing.Color.Tan
        Me.dgvResults.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResults.Location = New System.Drawing.Point(5, 32)
        Me.dgvResults.MultiSelect = False
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.ReadOnly = True
        Me.dgvResults.RowHeadersVisible = False
        Me.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvResults.Size = New System.Drawing.Size(1117, 697)
        Me.dgvResults.TabIndex = 209
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(135, 735)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(210, 23)
        Me.btnAdd.TabIndex = 210
        Me.btnAdd.Text = "Create New Request"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(567, 735)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(210, 23)
        Me.btnDelete.TabIndex = 211
        Me.btnDelete.Text = "Delete Selected Request"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'chkHideComplete
        '
        Me.chkHideComplete.AutoSize = True
        Me.chkHideComplete.BackColor = System.Drawing.Color.Tan
        Me.chkHideComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkHideComplete.Location = New System.Drawing.Point(979, 10)
        Me.chkHideComplete.Name = "chkHideComplete"
        Me.chkHideComplete.Size = New System.Drawing.Size(146, 17)
        Me.chkHideComplete.TabIndex = 212
        Me.chkHideComplete.Text = "Hide Completed Requests"
        Me.chkHideComplete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(351, 735)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(210, 23)
        Me.btnEdit.TabIndex = 213
        Me.btnEdit.Text = "Edit Selected Request"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(783, 735)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(210, 23)
        Me.btnExport.TabIndex = 214
        Me.btnExport.Text = "Export Selected Request To PDF"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'WA_PurchaseRequests
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.chkHideComplete)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvResults)
        Me.Controls.Add(Me.Label12)
        Me.Name = "WA_PurchaseRequests"
        Me.Size = New System.Drawing.Size(1128, 770)
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As Label
    Friend WithEvents dgvResults As DataGridView
    Friend WithEvents btnAdd As Button_
    Friend WithEvents btnDelete As Button_
    Friend WithEvents chkHideComplete As CheckBox_
    Friend WithEvents btnEdit As Button_
    Friend WithEvents btnExport As Button_
End Class
