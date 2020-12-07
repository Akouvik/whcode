<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WA_External_Reporting_Exports
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.end_Date = New DataWarehouse.TextBoxDateAny()
        Me.start_Date = New DataWarehouse.TextBoxDateAny()
        Me.Submit = New DataWarehouse.Button_()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btn_Qtrly_Upload = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Btn_BDP_Report = New System.Windows.Forms.Button()
        Me.totaldist = New System.Windows.Forms.Label()
        Me.totalSamples = New System.Windows.Forms.Label()
        Me.nbbDist = New System.Windows.Forms.Label()
        Me.nbbSamp = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.distroEndDate = New DataWarehouse.TextBoxDateAny()
        Me.distroStartDate = New DataWarehouse.TextBoxDateAny()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.distroSubmit = New DataWarehouse.Button_()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 17)
        Me.Label3.TabIndex = 875
        Me.Label3.Text = "End Date (MM/DD/YYYY)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 17)
        Me.Label2.TabIndex = 874
        Me.Label2.Text = "Start Date (MM/DD/YYYY)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.end_Date)
        Me.GroupBox1.Controls.Add(Me.start_Date)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Submit)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(207, 147)
        Me.GroupBox1.TabIndex = 877
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NBB Qtrly Admin"
        '
        'end_Date
        '
        Me.end_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.end_Date.Location = New System.Drawing.Point(9, 85)
        Me.end_Date.Mask = "00/00/0000"
        Me.end_Date.Name = "end_Date"
        Me.end_Date.Size = New System.Drawing.Size(112, 23)
        Me.end_Date.TabIndex = 879
        Me.end_Date.ValidatingType = GetType(Date)
        '
        'start_Date
        '
        Me.start_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.start_Date.Location = New System.Drawing.Point(9, 39)
        Me.start_Date.Mask = "00/00/0000"
        Me.start_Date.Name = "start_Date"
        Me.start_Date.Size = New System.Drawing.Size(112, 23)
        Me.start_Date.TabIndex = 878
        Me.start_Date.ValidatingType = GetType(Date)
        '
        'Submit
        '
        Me.Submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit.Location = New System.Drawing.Point(6, 114)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(112, 26)
        Me.Submit.TabIndex = 876
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Btn_Qtrly_Upload)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(230, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(207, 147)
        Me.GroupBox2.TabIndex = 877
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "NBB Qtrly Upload"
        '
        'Btn_Qtrly_Upload
        '
        Me.Btn_Qtrly_Upload.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Qtrly_Upload.Location = New System.Drawing.Point(6, 22)
        Me.Btn_Qtrly_Upload.Name = "Btn_Qtrly_Upload"
        Me.Btn_Qtrly_Upload.Size = New System.Drawing.Size(194, 32)
        Me.Btn_Qtrly_Upload.TabIndex = 0
        Me.Btn_Qtrly_Upload.Text = "Generate Qtrly Upload"
        Me.Btn_Qtrly_Upload.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Btn_BDP_Report)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(443, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(207, 147)
        Me.GroupBox3.TabIndex = 877
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "View BDP Reporting"
        '
        'Btn_BDP_Report
        '
        Me.Btn_BDP_Report.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_BDP_Report.Location = New System.Drawing.Point(6, 24)
        Me.Btn_BDP_Report.Name = "Btn_BDP_Report"
        Me.Btn_BDP_Report.Size = New System.Drawing.Size(192, 30)
        Me.Btn_BDP_Report.TabIndex = 0
        Me.Btn_BDP_Report.Text = "Generate BDP Report"
        Me.Btn_BDP_Report.UseVisualStyleBackColor = True
        '
        'totaldist
        '
        Me.totaldist.AutoSize = True
        Me.totaldist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totaldist.Location = New System.Drawing.Point(191, 36)
        Me.totaldist.Name = "totaldist"
        Me.totaldist.Size = New System.Drawing.Size(119, 17)
        Me.totaldist.TabIndex = 880
        Me.totaldist.Text = "Total Distribution:"
        '
        'totalSamples
        '
        Me.totalSamples.AutoSize = True
        Me.totalSamples.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalSamples.Location = New System.Drawing.Point(191, 53)
        Me.totalSamples.Name = "totalSamples"
        Me.totalSamples.Size = New System.Drawing.Size(102, 17)
        Me.totalSamples.TabIndex = 881
        Me.totalSamples.Text = "Total Samples:"
        '
        'nbbDist
        '
        Me.nbbDist.AutoSize = True
        Me.nbbDist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nbbDist.Location = New System.Drawing.Point(191, 80)
        Me.nbbDist.Name = "nbbDist"
        Me.nbbDist.Size = New System.Drawing.Size(115, 17)
        Me.nbbDist.TabIndex = 882
        Me.nbbDist.Text = "NBB Distribution:"
        '
        'nbbSamp
        '
        Me.nbbSamp.AutoSize = True
        Me.nbbSamp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nbbSamp.Location = New System.Drawing.Point(191, 97)
        Me.nbbSamp.Name = "nbbSamp"
        Me.nbbSamp.Size = New System.Drawing.Size(98, 17)
        Me.nbbSamp.TabIndex = 883
        Me.nbbSamp.Text = "NBB Samples:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.distroEndDate)
        Me.GroupBox4.Controls.Add(Me.nbbDist)
        Me.GroupBox4.Controls.Add(Me.distroStartDate)
        Me.GroupBox4.Controls.Add(Me.nbbSamp)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.totaldist)
        Me.GroupBox4.Controls.Add(Me.totalSamples)
        Me.GroupBox4.Controls.Add(Me.distroSubmit)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(656, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(369, 147)
        Me.GroupBox4.TabIndex = 880
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tissue Distributions"
        '
        'distroEndDate
        '
        Me.distroEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.distroEndDate.Location = New System.Drawing.Point(9, 85)
        Me.distroEndDate.Mask = "00/00/0000"
        Me.distroEndDate.Name = "distroEndDate"
        Me.distroEndDate.Size = New System.Drawing.Size(112, 23)
        Me.distroEndDate.TabIndex = 879
        Me.distroEndDate.ValidatingType = GetType(Date)
        '
        'distroStartDate
        '
        Me.distroStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.distroStartDate.Location = New System.Drawing.Point(9, 39)
        Me.distroStartDate.Mask = "00/00/0000"
        Me.distroStartDate.Name = "distroStartDate"
        Me.distroStartDate.Size = New System.Drawing.Size(112, 23)
        Me.distroStartDate.TabIndex = 878
        Me.distroStartDate.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 17)
        Me.Label1.TabIndex = 874
        Me.Label1.Text = "Start Date (MM/DD/YYYY)"
        '
        'distroSubmit
        '
        Me.distroSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.distroSubmit.Location = New System.Drawing.Point(6, 114)
        Me.distroSubmit.Name = "distroSubmit"
        Me.distroSubmit.Size = New System.Drawing.Size(112, 26)
        Me.distroSubmit.TabIndex = 876
        Me.distroSubmit.Text = "Submit"
        Me.distroSubmit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 17)
        Me.Label4.TabIndex = 875
        Me.Label4.Text = "End Date (MM/DD/YYYY)"
        '
        'WA_External_Reporting_Exports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "WA_External_Reporting_Exports"
        Me.Size = New System.Drawing.Size(1097, 803)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Submit As Button_
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Btn_Qtrly_Upload As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Btn_BDP_Report As Button
    Friend WithEvents start_Date As TextBoxDateAny
    Friend WithEvents end_Date As TextBoxDateAny
    Friend WithEvents totaldist As Label
    Friend WithEvents totalSamples As Label
    Friend WithEvents nbbDist As Label
    Friend WithEvents nbbSamp As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents distroEndDate As TextBoxDateAny
    Friend WithEvents distroStartDate As TextBoxDateAny
    Friend WithEvents Label1 As Label
    Friend WithEvents distroSubmit As Button_
    Friend WithEvents Label4 As Label
End Class
