<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Head_SubjectSelect
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
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.lbl_SSN = New System.Windows.Forms.Label()
        Me.lbl_DateOfBirth = New System.Windows.Forms.Label()
        Me.lbl_LastName = New System.Windows.Forms.Label()
        Me.lbl_FirstName = New System.Windows.Forms.Label()
        Me.lblBBList = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblDNC = New System.Windows.Forms.Label()
        Me.lblDNDiss = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblPMI = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblDNDist = New System.Windows.Forms.Label()
        Me.txtCDR = New DataWarehouse.TextBox_()
        Me.txtPMI = New DataWarehouse.TextBox_()
        Me.txtNP1 = New DataWarehouse.TextBox_()
        Me.txtCohorts = New DataWarehouse.TextBox_()
        Me.txtXENum = New DataWarehouse.TextBox_()
        Me.txtNACCID = New DataWarehouse.TextBox_()
        Me.intSubNum = New DataWarehouse.TextBoxInteger()
        Me.dtDoD = New DataWarehouse.TextBoxDatePast()
        Me.dtDoB = New DataWarehouse.TextBoxDatePast()
        Me.txtAge = New DataWarehouse.TextBoxNumeric()
        Me.txtBBList = New DataWarehouse.TextBox_()
        Me.txtSSN = New DataWarehouse.TextBox_()
        Me.txtLastName = New DataWarehouse.TextBox_()
        Me.txtFirstName = New DataWarehouse.TextBox_()
        Me.SuspendLayout()
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(3, 81)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(93, 23)
        Me.btnFilter.TabIndex = 11
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'lbl_SSN
        '
        Me.lbl_SSN.AutoSize = True
        Me.lbl_SSN.Location = New System.Drawing.Point(465, 27)
        Me.lbl_SSN.Name = "lbl_SSN"
        Me.lbl_SSN.Size = New System.Drawing.Size(29, 13)
        Me.lbl_SSN.TabIndex = 7
        Me.lbl_SSN.Text = "SSN"
        '
        'lbl_DateOfBirth
        '
        Me.lbl_DateOfBirth.AutoSize = True
        Me.lbl_DateOfBirth.Location = New System.Drawing.Point(234, 27)
        Me.lbl_DateOfBirth.Name = "lbl_DateOfBirth"
        Me.lbl_DateOfBirth.Size = New System.Drawing.Size(28, 13)
        Me.lbl_DateOfBirth.TabIndex = 5
        Me.lbl_DateOfBirth.Text = "DoB"
        '
        'lbl_LastName
        '
        Me.lbl_LastName.AutoSize = True
        Me.lbl_LastName.Location = New System.Drawing.Point(130, 27)
        Me.lbl_LastName.Name = "lbl_LastName"
        Me.lbl_LastName.Size = New System.Drawing.Size(58, 13)
        Me.lbl_LastName.TabIndex = 3
        Me.lbl_LastName.Text = "Last Name"
        '
        'lbl_FirstName
        '
        Me.lbl_FirstName.AutoSize = True
        Me.lbl_FirstName.Location = New System.Drawing.Point(25, 27)
        Me.lbl_FirstName.Name = "lbl_FirstName"
        Me.lbl_FirstName.Size = New System.Drawing.Size(57, 13)
        Me.lbl_FirstName.TabIndex = 1
        Me.lbl_FirstName.Text = "First Name"
        '
        'lblBBList
        '
        Me.lblBBList.AutoSize = True
        Me.lblBBList.Location = New System.Drawing.Point(21, 66)
        Me.lblBBList.Name = "lblBBList"
        Me.lblBBList.Size = New System.Drawing.Size(171, 13)
        Me.lblBBList.TabIndex = 15
        Me.lblBBList.Text = "BB (single or comma-separated list)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(379, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Age"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(307, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "DoD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(241, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "SubNum"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(457, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "NACC ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(358, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "XE #"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(457, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Cohorts"
        '
        'lblDNC
        '
        Me.lblDNC.AutoSize = True
        Me.lblDNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNC.Location = New System.Drawing.Point(535, 4)
        Me.lblDNC.Name = "lblDNC"
        Me.lblDNC.Size = New System.Drawing.Size(215, 31)
        Me.lblDNC.TabIndex = 29
        Me.lblDNC.Text = "Do Not Contact"
        Me.lblDNC.Visible = False
        '
        'lblDNDiss
        '
        Me.lblDNDiss.AutoSize = True
        Me.lblDNDiss.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNDiss.Location = New System.Drawing.Point(535, 35)
        Me.lblDNDiss.Name = "lblDNDiss"
        Me.lblDNDiss.Size = New System.Drawing.Size(211, 31)
        Me.lblDNDiss.TabIndex = 30
        Me.lblDNDiss.Text = "Do Not Dissect"
        Me.lblDNDiss.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(358, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "NP1"
        '
        'lblPMI
        '
        Me.lblPMI.AutoSize = True
        Me.lblPMI.Location = New System.Drawing.Point(250, 105)
        Me.lblPMI.Name = "lblPMI"
        Me.lblPMI.Size = New System.Drawing.Size(26, 13)
        Me.lblPMI.TabIndex = 34
        Me.lblPMI.Text = "PMI"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(144, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "CDR"
        '
        'lblDNDist
        '
        Me.lblDNDist.AutoSize = True
        Me.lblDNDist.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNDist.Location = New System.Drawing.Point(535, 66)
        Me.lblDNDist.Name = "lblDNDist"
        Me.lblDNDist.Size = New System.Drawing.Size(142, 31)
        Me.lblDNDist.TabIndex = 37
        Me.lblDNDist.Text = "Infectious"
        Me.lblDNDist.Visible = False
        '
        'txtCDR
        '
        Me.txtCDR.Enabled = False
        Me.txtCDR.Location = New System.Drawing.Point(109, 82)
        Me.txtCDR.Name = "txtCDR"
        Me.txtCDR.Size = New System.Drawing.Size(100, 20)
        Me.txtCDR.TabIndex = 35
        '
        'txtPMI
        '
        Me.txtPMI.Enabled = False
        Me.txtPMI.Location = New System.Drawing.Point(215, 82)
        Me.txtPMI.Name = "txtPMI"
        Me.txtPMI.Size = New System.Drawing.Size(100, 20)
        Me.txtPMI.TabIndex = 33
        '
        'txtNP1
        '
        Me.txtNP1.Enabled = False
        Me.txtNP1.Location = New System.Drawing.Point(323, 82)
        Me.txtNP1.Name = "txtNP1"
        Me.txtNP1.Size = New System.Drawing.Size(100, 20)
        Me.txtNP1.TabIndex = 31
        '
        'txtCohorts
        '
        Me.txtCohorts.Enabled = False
        Me.txtCohorts.Location = New System.Drawing.Point(429, 82)
        Me.txtCohorts.Name = "txtCohorts"
        Me.txtCohorts.Size = New System.Drawing.Size(100, 20)
        Me.txtCohorts.TabIndex = 27
        '
        'txtXENum
        '
        Me.txtXENum.Location = New System.Drawing.Point(323, 43)
        Me.txtXENum.Name = "txtXENum"
        Me.txtXENum.Size = New System.Drawing.Size(100, 20)
        Me.txtXENum.TabIndex = 25
        '
        'txtNACCID
        '
        Me.txtNACCID.Location = New System.Drawing.Point(429, 43)
        Me.txtNACCID.Name = "txtNACCID"
        Me.txtNACCID.Size = New System.Drawing.Size(100, 20)
        Me.txtNACCID.TabIndex = 23
        '
        'intSubNum
        '
        Me.intSubNum.Location = New System.Drawing.Point(215, 43)
        Me.intSubNum.Name = "intSubNum"
        Me.intSubNum.Size = New System.Drawing.Size(100, 20)
        Me.intSubNum.TabIndex = 21
        '
        'dtDoD
        '
        Me.dtDoD.Location = New System.Drawing.Point(288, 4)
        Me.dtDoD.Mask = "00/00/0000"
        Me.dtDoD.Name = "dtDoD"
        Me.dtDoD.Size = New System.Drawing.Size(67, 20)
        Me.dtDoD.TabIndex = 20
        Me.dtDoD.ValidatingType = GetType(Date)
        '
        'dtDoB
        '
        Me.dtDoB.Location = New System.Drawing.Point(215, 4)
        Me.dtDoB.Mask = "00/00/0000"
        Me.dtDoB.Name = "dtDoB"
        Me.dtDoB.Size = New System.Drawing.Size(67, 20)
        Me.dtDoB.TabIndex = 18
        Me.dtDoB.ValidatingType = GetType(Date)
        '
        'txtAge
        '
        Me.txtAge.Enabled = False
        Me.txtAge.Location = New System.Drawing.Point(361, 4)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(62, 20)
        Me.txtAge.TabIndex = 16
        '
        'txtBBList
        '
        Me.txtBBList.Location = New System.Drawing.Point(3, 43)
        Me.txtBBList.Name = "txtBBList"
        Me.txtBBList.Size = New System.Drawing.Size(206, 20)
        Me.txtBBList.TabIndex = 10
        '
        'txtSSN
        '
        Me.txtSSN.Location = New System.Drawing.Point(429, 4)
        Me.txtSSN.Name = "txtSSN"
        Me.txtSSN.Size = New System.Drawing.Size(100, 20)
        Me.txtSSN.TabIndex = 4
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(109, 4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 2
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(3, 4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'Head_SubjectSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(760, 124)
        Me.Controls.Add(Me.lblDNDist)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCDR)
        Me.Controls.Add(Me.lblPMI)
        Me.Controls.Add(Me.txtPMI)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNP1)
        Me.Controls.Add(Me.lblDNDiss)
        Me.Controls.Add(Me.lblDNC)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCohorts)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtXENum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNACCID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.intSubNum)
        Me.Controls.Add(Me.dtDoD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtDoB)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBBList)
        Me.Controls.Add(Me.lblBBList)
        Me.Controls.Add(Me.txtSSN)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.lbl_SSN)
        Me.Controls.Add(Me.lbl_FirstName)
        Me.Controls.Add(Me.lbl_DateOfBirth)
        Me.Controls.Add(Me.lbl_LastName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Head_SubjectSelect"
        Me.Text = "PatientHeader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents lbl_SSN As System.Windows.Forms.Label
    Friend WithEvents lbl_DateOfBirth As System.Windows.Forms.Label
    Friend WithEvents lbl_LastName As System.Windows.Forms.Label
    Friend WithEvents lbl_FirstName As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As DataWarehouse.TextBox_
    Friend WithEvents txtLastName As DataWarehouse.TextBox_
    Friend WithEvents txtSSN As DataWarehouse.TextBox_
    Friend WithEvents lblBBList As System.Windows.Forms.Label
    Friend WithEvents txtBBList As DataWarehouse.TextBox_
    Friend WithEvents txtAge As TextBoxNumeric
    Friend WithEvents Label2 As Label
    Friend WithEvents dtDoB As TextBoxDatePast
    Friend WithEvents dtDoD As TextBoxDatePast
    Friend WithEvents Label3 As Label
    Friend WithEvents intSubNum As TextBoxInteger
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNACCID As TextBox_
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtXENum As TextBox_
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCohorts As TextBox_
    Friend WithEvents lblDNC As Label
    Friend WithEvents lblDNDiss As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNP1 As TextBox_
    Friend WithEvents lblPMI As Label
    Friend WithEvents txtPMI As TextBox_
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCDR As TextBox_
    Friend WithEvents lblDNDist As Label
End Class
