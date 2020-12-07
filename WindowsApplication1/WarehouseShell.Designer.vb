<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WarehouseShell
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    Friend WithEvents ToolStripContainer As System.Windows.Forms.ToolStripContainer
    Friend WithEvents TreeNodeImageList As System.Windows.Forms.ImageList
    Friend WithEvents ListViewLargeImageList As System.Windows.Forms.ImageList
    Friend WithEvents ListViewSmallImageList As System.Windows.Forms.ImageList

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WarehouseShell))
        Me.TreeNodeImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStripContainer = New System.Windows.Forms.ToolStripContainer()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.lblDataStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.pnlWorkingArea = New System.Windows.Forms.Panel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlTreeView = New System.Windows.Forms.Panel()
        Me.tvReportMenu = New System.Windows.Forms.TreeView()
        Me.tvFormMenu = New System.Windows.Forms.TreeView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnShowPHI = New DataWarehouse.Button_()
        Me.pnlTopLevelNavl = New System.Windows.Forms.Panel()
        Me.btnSubjectRecords = New System.Windows.Forms.Button()
        Me.btn_DonationReferrals = New System.Windows.Forms.Button()
        Me.btn_Reports = New System.Windows.Forms.Button()
        Me.btnTissue = New System.Windows.Forms.Button()
        Me.ListViewLargeImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ListViewSmallImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStripContainer.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer.ContentPanel.SuspendLayout()
        Me.ToolStripContainer.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlTreeView.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlTopLevelNavl.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeNodeImageList
        '
        Me.TreeNodeImageList.ImageStream = CType(resources.GetObject("TreeNodeImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.TreeNodeImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.TreeNodeImageList.Images.SetKeyName(0, "ClosedFolder")
        Me.TreeNodeImageList.Images.SetKeyName(1, "OpenFolder")
        '
        'ToolStripContainer
        '
        '
        'ToolStripContainer.BottomToolStripPanel
        '
        Me.ToolStripContainer.BottomToolStripPanel.Controls.Add(Me.StatusStrip)
        '
        'ToolStripContainer.ContentPanel
        '
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.Panel4)
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.Panel1)
        Me.ToolStripContainer.ContentPanel.Size = New System.Drawing.Size(1284, 597)
        Me.ToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer.Name = "ToolStripContainer"
        Me.ToolStripContainer.Size = New System.Drawing.Size(1284, 644)
        Me.ToolStripContainer.TabIndex = 7
        Me.ToolStripContainer.TabStop = False
        Me.ToolStripContainer.Text = "ToolStripContainer1"
        '
        'StatusStrip
        '
        Me.StatusStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblDataStatus})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1284, 22)
        Me.StatusStrip.TabIndex = 6
        Me.StatusStrip.Text = "StatusStrip"
        '
        'lblDataStatus
        '
        Me.lblDataStatus.Name = "lblDataStatus"
        Me.lblDataStatus.Size = New System.Drawing.Size(0, 17)
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.pnlWorkingArea)
        Me.Panel4.Controls.Add(Me.pnlHeader)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(200, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1084, 597)
        Me.Panel4.TabIndex = 1
        '
        'pnlWorkingArea
        '
        Me.pnlWorkingArea.AutoScroll = True
        Me.pnlWorkingArea.AutoSize = True
        Me.pnlWorkingArea.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlWorkingArea.BackColor = System.Drawing.Color.Tan
        Me.pnlWorkingArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlWorkingArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlWorkingArea.Location = New System.Drawing.Point(0, 127)
        Me.pnlWorkingArea.Name = "pnlWorkingArea"
        Me.pnlWorkingArea.Size = New System.Drawing.Size(1082, 468)
        Me.pnlWorkingArea.TabIndex = 0
        '
        'pnlHeader
        '
        Me.pnlHeader.AutoScroll = True
        Me.pnlHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlHeader.BackColor = System.Drawing.Color.LightSkyBlue
        Me.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1082, 127)
        Me.pnlHeader.TabIndex = 0
        Me.pnlHeader.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pnlTreeView)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.pnlTopLevelNavl)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 597)
        Me.Panel1.TabIndex = 0
        '
        'pnlTreeView
        '
        Me.pnlTreeView.BackColor = System.Drawing.Color.Tan
        Me.pnlTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTreeView.Controls.Add(Me.tvReportMenu)
        Me.pnlTreeView.Controls.Add(Me.tvFormMenu)
        Me.pnlTreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTreeView.Location = New System.Drawing.Point(0, 164)
        Me.pnlTreeView.Name = "pnlTreeView"
        Me.pnlTreeView.Size = New System.Drawing.Size(200, 433)
        Me.pnlTreeView.TabIndex = 0
        '
        'tvReportMenu
        '
        Me.tvReportMenu.BackColor = System.Drawing.Color.Tan
        Me.tvReportMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvReportMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.tvReportMenu.Location = New System.Drawing.Point(0, 208)
        Me.tvReportMenu.Name = "tvReportMenu"
        Me.tvReportMenu.Size = New System.Drawing.Size(198, 205)
        Me.tvReportMenu.TabIndex = 1
        Me.tvReportMenu.TabStop = False
        Me.tvReportMenu.Visible = False
        '
        'tvFormMenu
        '
        Me.tvFormMenu.BackColor = System.Drawing.Color.Tan
        Me.tvFormMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvFormMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.tvFormMenu.Location = New System.Drawing.Point(0, 0)
        Me.tvFormMenu.Name = "tvFormMenu"
        Me.tvFormMenu.Size = New System.Drawing.Size(198, 208)
        Me.tvFormMenu.TabIndex = 0
        Me.tvFormMenu.TabStop = False
        Me.tvFormMenu.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnShowPHI)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 128)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 36)
        Me.Panel2.TabIndex = 0
        '
        'btnShowPHI
        '
        Me.btnShowPHI.Location = New System.Drawing.Point(63, 7)
        Me.btnShowPHI.Name = "btnShowPHI"
        Me.btnShowPHI.Size = New System.Drawing.Size(75, 23)
        Me.btnShowPHI.TabIndex = 5
        Me.btnShowPHI.TabStop = False
        Me.btnShowPHI.Text = "Show PHI"
        Me.btnShowPHI.UseVisualStyleBackColor = True
        '
        'pnlTopLevelNavl
        '
        Me.pnlTopLevelNavl.BackColor = System.Drawing.Color.LightSkyBlue
        Me.pnlTopLevelNavl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTopLevelNavl.Controls.Add(Me.btnSubjectRecords)
        Me.pnlTopLevelNavl.Controls.Add(Me.btn_DonationReferrals)
        Me.pnlTopLevelNavl.Controls.Add(Me.btn_Reports)
        Me.pnlTopLevelNavl.Controls.Add(Me.btnTissue)
        Me.pnlTopLevelNavl.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopLevelNavl.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopLevelNavl.Name = "pnlTopLevelNavl"
        Me.pnlTopLevelNavl.Size = New System.Drawing.Size(200, 128)
        Me.pnlTopLevelNavl.TabIndex = 0
        '
        'btnSubjectRecords
        '
        Me.btnSubjectRecords.Location = New System.Drawing.Point(9, 8)
        Me.btnSubjectRecords.Name = "btnSubjectRecords"
        Me.btnSubjectRecords.Size = New System.Drawing.Size(182, 23)
        Me.btnSubjectRecords.TabIndex = 2
        Me.btnSubjectRecords.TabStop = False
        Me.btnSubjectRecords.Text = "Subject Records"
        Me.btnSubjectRecords.UseVisualStyleBackColor = True
        '
        'btn_DonationReferrals
        '
        Me.btn_DonationReferrals.Location = New System.Drawing.Point(9, 95)
        Me.btn_DonationReferrals.Name = "btn_DonationReferrals"
        Me.btn_DonationReferrals.Size = New System.Drawing.Size(182, 23)
        Me.btn_DonationReferrals.TabIndex = 4
        Me.btn_DonationReferrals.TabStop = False
        Me.btn_DonationReferrals.Text = "Donation Referrals"
        Me.btn_DonationReferrals.UseVisualStyleBackColor = True
        '
        'btn_Reports
        '
        Me.btn_Reports.Location = New System.Drawing.Point(9, 66)
        Me.btn_Reports.Name = "btn_Reports"
        Me.btn_Reports.Size = New System.Drawing.Size(182, 23)
        Me.btn_Reports.TabIndex = 3
        Me.btn_Reports.TabStop = False
        Me.btn_Reports.Text = "Reports"
        Me.btn_Reports.UseVisualStyleBackColor = True
        '
        'btnTissue
        '
        Me.btnTissue.Location = New System.Drawing.Point(9, 37)
        Me.btnTissue.Name = "btnTissue"
        Me.btnTissue.Size = New System.Drawing.Size(182, 23)
        Me.btnTissue.TabIndex = 1
        Me.btnTissue.TabStop = False
        Me.btnTissue.Text = "Tissue"
        Me.btnTissue.UseVisualStyleBackColor = True
        '
        'ListViewLargeImageList
        '
        Me.ListViewLargeImageList.ImageStream = CType(resources.GetObject("ListViewLargeImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ListViewLargeImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ListViewLargeImageList.Images.SetKeyName(0, "Graph1")
        Me.ListViewLargeImageList.Images.SetKeyName(1, "Graph2")
        Me.ListViewLargeImageList.Images.SetKeyName(2, "Graph3")
        '
        'ListViewSmallImageList
        '
        Me.ListViewSmallImageList.ImageStream = CType(resources.GetObject("ListViewSmallImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ListViewSmallImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ListViewSmallImageList.Images.SetKeyName(0, "Graph1")
        Me.ListViewSmallImageList.Images.SetKeyName(1, "Graph2")
        Me.ListViewSmallImageList.Images.SetKeyName(2, "Graph3")
        '
        'WarehouseShell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 644)
        Me.Controls.Add(Me.ToolStripContainer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WarehouseShell"
        Me.Text = "Warehouse Database"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStripContainer.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer.ResumeLayout(False)
        Me.ToolStripContainer.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.pnlTreeView.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.pnlTopLevelNavl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlTopLevelNavl As System.Windows.Forms.Panel
    Friend WithEvents btn_DonationReferrals As System.Windows.Forms.Button
    Friend WithEvents btn_Reports As System.Windows.Forms.Button
    Friend WithEvents btnTissue As System.Windows.Forms.Button
    Friend WithEvents pnlWorkingArea As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents btnSubjectRecords As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pnlTreeView As System.Windows.Forms.Panel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents btnShowPHI As DataWarehouse.Button_
    Friend WithEvents tvFormMenu As System.Windows.Forms.TreeView
    Friend WithEvents tvReportMenu As System.Windows.Forms.TreeView
    Friend WithEvents lblDataStatus As System.Windows.Forms.ToolStripStatusLabel
End Class
