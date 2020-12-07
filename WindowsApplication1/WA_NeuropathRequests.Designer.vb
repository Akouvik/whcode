<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WA_NeuropathRequests
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnViewEdit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgvNPRequest = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.dgvNPRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnViewEdit
        '
        Me.btnViewEdit.Location = New System.Drawing.Point(8, 287)
        Me.btnViewEdit.Name = "btnViewEdit"
        Me.btnViewEdit.Size = New System.Drawing.Size(162, 23)
        Me.btnViewEdit.TabIndex = 786
        Me.btnViewEdit.Text = "View / Edit Selected Record"
        Me.btnViewEdit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 29)
        Me.Label1.TabIndex = 787
        Me.Label1.Text = "Neuropath Requests"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 789
        Me.Label2.Text = "Existing Requests"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(176, 287)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(162, 23)
        Me.btnAdd.TabIndex = 790
        Me.btnAdd.Text = "Add A New Request"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dgvNPRequest
        '
        Me.dgvNPRequest.AllowUserToAddRows = False
        Me.dgvNPRequest.AllowUserToDeleteRows = False
        Me.dgvNPRequest.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvNPRequest.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvNPRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvNPRequest.BackgroundColor = System.Drawing.Color.Tan
        Me.dgvNPRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNPRequest.Location = New System.Drawing.Point(3, 56)
        Me.dgvNPRequest.Name = "dgvNPRequest"
        Me.dgvNPRequest.ReadOnly = True
        Me.dgvNPRequest.RowHeadersVisible = False
        Me.dgvNPRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvNPRequest.Size = New System.Drawing.Size(761, 225)
        Me.dgvNPRequest.TabIndex = 791
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(344, 287)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(162, 23)
        Me.btnDelete.TabIndex = 792
        Me.btnDelete.Text = "Delete Selected Record"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'WA_NeuropathRequests
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.dgvNPRequest)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnViewEdit)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WA_NeuropathRequests"
        Me.Size = New System.Drawing.Size(767, 313)
        CType(Me.dgvNPRequest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnViewEdit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvNPRequests As dgvSingleRow
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents dgvNPRequest As DataGridView
    Friend WithEvents btnDelete As Button
End Class
