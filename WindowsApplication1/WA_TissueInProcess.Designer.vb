<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WA_TissueInProcess
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlTaskCompNotApproved = New System.Windows.Forms.Panel()
        Me.btnTaskCompNotApproved = New DataWarehouse.Button_()
        Me.dgvTaskCompNotApproved = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlDistroApprovedNotShipped = New System.Windows.Forms.Panel()
        Me.btnDistroApprovedNotShipped = New DataWarehouse.Button_()
        Me.dgvDistroApprovedNotShipped = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlTaskCompNotApproved.SuspendLayout()
        CType(Me.dgvTaskCompNotApproved, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDistroApprovedNotShipped.SuspendLayout()
        CType(Me.dgvDistroApprovedNotShipped, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(380, 29)
        Me.Label1.TabIndex = 273
        Me.Label1.Text = "Tissue Projects Awaiting Action"
        '
        'pnlTaskCompNotApproved
        '
        Me.pnlTaskCompNotApproved.Controls.Add(Me.btnTaskCompNotApproved)
        Me.pnlTaskCompNotApproved.Controls.Add(Me.dgvTaskCompNotApproved)
        Me.pnlTaskCompNotApproved.Controls.Add(Me.Label2)
        Me.pnlTaskCompNotApproved.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTaskCompNotApproved.Location = New System.Drawing.Point(0, 29)
        Me.pnlTaskCompNotApproved.Name = "pnlTaskCompNotApproved"
        Me.pnlTaskCompNotApproved.Size = New System.Drawing.Size(903, 178)
        Me.pnlTaskCompNotApproved.TabIndex = 274
        '
        'btnTaskCompNotApproved
        '
        Me.btnTaskCompNotApproved.Location = New System.Drawing.Point(766, 0)
        Me.btnTaskCompNotApproved.Name = "btnTaskCompNotApproved"
        Me.btnTaskCompNotApproved.Size = New System.Drawing.Size(134, 23)
        Me.btnTaskCompNotApproved.TabIndex = 2
        Me.btnTaskCompNotApproved.Text = "Copy Table to Clipboard"
        Me.btnTaskCompNotApproved.UseVisualStyleBackColor = True
        '
        'dgvTaskCompNotApproved
        '
        Me.dgvTaskCompNotApproved.AllowUserToAddRows = False
        Me.dgvTaskCompNotApproved.AllowUserToDeleteRows = False
        Me.dgvTaskCompNotApproved.AllowUserToOrderColumns = True
        Me.dgvTaskCompNotApproved.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTaskCompNotApproved.BackgroundColor = System.Drawing.Color.Tan
        Me.dgvTaskCompNotApproved.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dgvTaskCompNotApproved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTaskCompNotApproved.Location = New System.Drawing.Point(5, 23)
        Me.dgvTaskCompNotApproved.Name = "dgvTaskCompNotApproved"
        Me.dgvTaskCompNotApproved.ReadOnly = True
        Me.dgvTaskCompNotApproved.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvTaskCompNotApproved.RowHeadersVisible = False
        Me.dgvTaskCompNotApproved.Size = New System.Drawing.Size(895, 150)
        Me.dgvTaskCompNotApproved.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(267, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Taskers Complete Not Yet Approved"
        '
        'pnlDistroApprovedNotShipped
        '
        Me.pnlDistroApprovedNotShipped.Controls.Add(Me.btnDistroApprovedNotShipped)
        Me.pnlDistroApprovedNotShipped.Controls.Add(Me.dgvDistroApprovedNotShipped)
        Me.pnlDistroApprovedNotShipped.Controls.Add(Me.Label3)
        Me.pnlDistroApprovedNotShipped.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDistroApprovedNotShipped.Location = New System.Drawing.Point(0, 207)
        Me.pnlDistroApprovedNotShipped.Name = "pnlDistroApprovedNotShipped"
        Me.pnlDistroApprovedNotShipped.Size = New System.Drawing.Size(903, 178)
        Me.pnlDistroApprovedNotShipped.TabIndex = 275
        '
        'btnDistroApprovedNotShipped
        '
        Me.btnDistroApprovedNotShipped.Location = New System.Drawing.Point(766, 0)
        Me.btnDistroApprovedNotShipped.Name = "btnDistroApprovedNotShipped"
        Me.btnDistroApprovedNotShipped.Size = New System.Drawing.Size(134, 23)
        Me.btnDistroApprovedNotShipped.TabIndex = 2
        Me.btnDistroApprovedNotShipped.Text = "Copy Table to Clipboard"
        Me.btnDistroApprovedNotShipped.UseVisualStyleBackColor = True
        '
        'dgvDistroApprovedNotShipped
        '
        Me.dgvDistroApprovedNotShipped.AllowUserToAddRows = False
        Me.dgvDistroApprovedNotShipped.AllowUserToDeleteRows = False
        Me.dgvDistroApprovedNotShipped.AllowUserToOrderColumns = True
        Me.dgvDistroApprovedNotShipped.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvDistroApprovedNotShipped.BackgroundColor = System.Drawing.Color.Tan
        Me.dgvDistroApprovedNotShipped.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dgvDistroApprovedNotShipped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDistroApprovedNotShipped.Location = New System.Drawing.Point(5, 23)
        Me.dgvDistroApprovedNotShipped.Name = "dgvDistroApprovedNotShipped"
        Me.dgvDistroApprovedNotShipped.ReadOnly = True
        Me.dgvDistroApprovedNotShipped.RowHeadersVisible = False
        Me.dgvDistroApprovedNotShipped.Size = New System.Drawing.Size(895, 150)
        Me.dgvDistroApprovedNotShipped.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(244, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Distro Approved Not Yet Shipped"
        '
        'WA_TissueInProcess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.Controls.Add(Me.pnlDistroApprovedNotShipped)
        Me.Controls.Add(Me.pnlTaskCompNotApproved)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WA_TissueInProcess"
        Me.Size = New System.Drawing.Size(903, 807)
        Me.pnlTaskCompNotApproved.ResumeLayout(False)
        Me.pnlTaskCompNotApproved.PerformLayout()
        CType(Me.dgvTaskCompNotApproved, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDistroApprovedNotShipped.ResumeLayout(False)
        Me.pnlDistroApprovedNotShipped.PerformLayout()
        CType(Me.dgvDistroApprovedNotShipped, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pnlTaskCompNotApproved As Panel
    Friend WithEvents dgvTaskCompNotApproved As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTaskCompNotApproved As Button_
    Friend WithEvents pnlDistroApprovedNotShipped As Panel
    Friend WithEvents btnDistroApprovedNotShipped As Button_
    Friend WithEvents dgvDistroApprovedNotShipped As DataGridView
    Friend WithEvents Label3 As Label
End Class
