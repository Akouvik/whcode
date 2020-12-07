<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WA_SlideScanBarcodeFile
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvResults = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRegionName = New DataWarehouse.TextBox_()
        Me.btnReset = New DataWarehouse.Button_()
        Me.btnSave = New DataWarehouse.Button_()
        Me.btnAdd = New DataWarehouse.Button_()
        Me.cmbStain = New DataWarehouse.ComboBox_()
        Me.intRegion = New DataWarehouse.TextBoxInteger()
        Me.txtXENum = New DataWarehouse.TextBox_()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 29)
        Me.Label1.TabIndex = 787
        Me.Label1.Text = "Create Slide Label Files"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 789
        Me.Label2.Text = "XE #"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(515, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 792
        Me.Label3.Text = "Stain"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(148, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 795
        Me.Label4.Text = "Region"
        '
        'dgvResults
        '
        Me.dgvResults.AllowUserToAddRows = False
        Me.dgvResults.AllowUserToDeleteRows = False
        Me.dgvResults.AllowUserToOrderColumns = True
        Me.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvResults.BackgroundColor = System.Drawing.Color.Tan
        Me.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResults.Location = New System.Drawing.Point(8, 74)
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.ReadOnly = True
        Me.dgvResults.Size = New System.Drawing.Size(746, 568)
        Me.dgvResults.TabIndex = 796
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(353, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 797
        Me.Label5.Text = "Results"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(229, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 800
        Me.Label6.Text = "Region Name"
        '
        'txtRegionName
        '
        Me.txtRegionName.Location = New System.Drawing.Point(302, 35)
        Me.txtRegionName.Name = "txtRegionName"
        Me.txtRegionName.Size = New System.Drawing.Size(207, 20)
        Me.txtRegionName.TabIndex = 792
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(385, 646)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(124, 23)
        Me.btnReset.TabIndex = 799
        Me.btnReset.Text = "Cancel and Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(255, 646)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(124, 23)
        Me.btnSave.TabIndex = 798
        Me.btnSave.Text = "Save and Export"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(679, 34)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 795
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'cmbStain
        '
        Me.cmbStain.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbStain.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbStain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStain.FormattingEnabled = True
        Me.cmbStain.Location = New System.Drawing.Point(552, 35)
        Me.cmbStain.Name = "cmbStain"
        Me.cmbStain.Size = New System.Drawing.Size(121, 21)
        Me.cmbStain.TabIndex = 794
        '
        'intRegion
        '
        Me.intRegion.Location = New System.Drawing.Point(195, 35)
        Me.intRegion.Name = "intRegion"
        Me.intRegion.Size = New System.Drawing.Size(28, 20)
        Me.intRegion.TabIndex = 790
        '
        'txtXENum
        '
        Me.txtXENum.Location = New System.Drawing.Point(42, 35)
        Me.txtXENum.Name = "txtXENum"
        Me.txtXENum.Size = New System.Drawing.Size(100, 20)
        Me.txtXENum.TabIndex = 788
        '
        'WA_SlideScanBarcodeFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.Controls.Add(Me.txtRegionName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvResults)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cmbStain)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.intRegion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtXENum)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WA_SlideScanBarcodeFile"
        Me.Size = New System.Drawing.Size(761, 674)
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtXENum As TextBox_
    Friend WithEvents Label2 As Label
    Friend WithEvents intRegion As TextBoxInteger
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbStain As ComboBox_
    Friend WithEvents btnAdd As Button_
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvResults As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSave As Button_
    Friend WithEvents btnReset As Button_
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRegionName As TextBox_
End Class
