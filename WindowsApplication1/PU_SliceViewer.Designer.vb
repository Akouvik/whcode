<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PU_SliceViewer
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
        Me.lblPictureTitle = New System.Windows.Forms.Label()
        Me.pbxPicture = New System.Windows.Forms.PictureBox()
        Me.btnLast = New DataWarehouse.Button_()
        Me.btnNext = New DataWarehouse.Button_()
        Me.btnPrev = New DataWarehouse.Button_()
        Me.btnFirst = New DataWarehouse.Button_()
        CType(Me.pbxPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPictureTitle
        '
        Me.lblPictureTitle.AutoSize = True
        Me.lblPictureTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPictureTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPictureTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblPictureTitle.Name = "lblPictureTitle"
        Me.lblPictureTitle.Size = New System.Drawing.Size(139, 26)
        Me.lblPictureTitle.TabIndex = 0
        Me.lblPictureTitle.Text = "Picture Title"
        '
        'pbxPicture
        '
        Me.pbxPicture.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbxPicture.Location = New System.Drawing.Point(0, 26)
        Me.pbxPicture.Name = "pbxPicture"
        Me.pbxPicture.Size = New System.Drawing.Size(384, 450)
        Me.pbxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxPicture.TabIndex = 1
        Me.pbxPicture.TabStop = False
        '
        'btnLast
        '
        Me.btnLast.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnLast.Location = New System.Drawing.Point(225, 476)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 25)
        Me.btnLast.TabIndex = 7
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnNext.Location = New System.Drawing.Point(150, 476)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 25)
        Me.btnNext.TabIndex = 6
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPrev.Enabled = False
        Me.btnPrev.Location = New System.Drawing.Point(75, 476)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(75, 25)
        Me.btnPrev.TabIndex = 5
        Me.btnPrev.Text = "Prev"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnFirst.Location = New System.Drawing.Point(0, 476)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 25)
        Me.btnFirst.TabIndex = 4
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'PU_SliceViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(384, 501)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.pbxPicture)
        Me.Controls.Add(Me.lblPictureTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PU_SliceViewer"
        Me.Text = "Slice Viewer"
        CType(Me.pbxPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPictureTitle As System.Windows.Forms.Label
    Friend WithEvents pbxPicture As System.Windows.Forms.PictureBox
    Friend WithEvents btnFirst As DataWarehouse.Button_
    Friend WithEvents btnPrev As DataWarehouse.Button_
    Friend WithEvents btnNext As DataWarehouse.Button_
    Friend WithEvents btnLast As DataWarehouse.Button_
End Class
