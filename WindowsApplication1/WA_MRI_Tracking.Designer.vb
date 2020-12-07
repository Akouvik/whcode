<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WA_MRI_Tracking
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PreppedForShip = New DataWarehouse.CheckBox_()
        Me.DroppedOffDate = New DataWarehouse.TextBoxDatePast()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ExpectedReturnDate = New DataWarehouse.TextBoxDatePast()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ActualReturnDate = New DataWarehouse.TextBoxDatePast()
        Me.Save = New DataWarehouse.Button_()
        Me.Export = New DataWarehouse.Button_()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 25)
        Me.Label2.TabIndex = 196
        Me.Label2.Text = "MRI Tracking"
        '
        'PreppedForShip
        '
        Me.PreppedForShip.AutoSize = True
        Me.PreppedForShip.BackColor = System.Drawing.Color.Tan
        Me.PreppedForShip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PreppedForShip.Location = New System.Drawing.Point(27, 68)
        Me.PreppedForShip.Name = "PreppedForShip"
        Me.PreppedForShip.Size = New System.Drawing.Size(126, 17)
        Me.PreppedForShip.TabIndex = 197
        Me.PreppedForShip.Text = "Prepared for shipment"
        Me.PreppedForShip.UseVisualStyleBackColor = False
        '
        'DroppedOffDate
        '
        Me.DroppedOffDate.Location = New System.Drawing.Point(27, 91)
        Me.DroppedOffDate.Mask = "00/00/0000"
        Me.DroppedOffDate.Name = "DroppedOffDate"
        Me.DroppedOffDate.Size = New System.Drawing.Size(67, 20)
        Me.DroppedOffDate.TabIndex = 198
        Me.DroppedOffDate.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 199
        Me.Label1.Text = "Date dropped off"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(100, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 13)
        Me.Label3.TabIndex = 201
        Me.Label3.Text = "Expected date of return"
        '
        'ExpectedReturnDate
        '
        Me.ExpectedReturnDate.Location = New System.Drawing.Point(27, 117)
        Me.ExpectedReturnDate.Mask = "00/00/0000"
        Me.ExpectedReturnDate.Name = "ExpectedReturnDate"
        Me.ExpectedReturnDate.Size = New System.Drawing.Size(67, 20)
        Me.ExpectedReturnDate.TabIndex = 200
        Me.ExpectedReturnDate.ValidatingType = GetType(Date)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(100, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 203
        Me.Label4.Text = "Actual date of return"
        '
        'ActualReturnDate
        '
        Me.ActualReturnDate.Location = New System.Drawing.Point(27, 143)
        Me.ActualReturnDate.Mask = "00/00/0000"
        Me.ActualReturnDate.Name = "ActualReturnDate"
        Me.ActualReturnDate.Size = New System.Drawing.Size(67, 20)
        Me.ActualReturnDate.TabIndex = 202
        Me.ActualReturnDate.ValidatingType = GetType(Date)
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(26, 169)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(160, 23)
        Me.Save.TabIndex = 204
        Me.Save.Text = "Button_1"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Export
        '
        Me.Export.Location = New System.Drawing.Point(26, 198)
        Me.Export.Name = "Export"
        Me.Export.Size = New System.Drawing.Size(160, 23)
        Me.Export.TabIndex = 205
        Me.Export.Text = "Export Non-PHI AFS"
        Me.Export.UseVisualStyleBackColor = True
        '
        'WA_MRI_Tracking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.Controls.Add(Me.Export)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ActualReturnDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ExpectedReturnDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DroppedOffDate)
        Me.Controls.Add(Me.PreppedForShip)
        Me.Controls.Add(Me.Label2)
        Me.Name = "WA_MRI_Tracking"
        Me.Size = New System.Drawing.Size(238, 249)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents PreppedForShip As CheckBox_
    Friend WithEvents DroppedOffDate As TextBoxDatePast
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ExpectedReturnDate As TextBoxDatePast
    Friend WithEvents Label4 As Label
    Friend WithEvents ActualReturnDate As TextBoxDatePast
    Friend WithEvents Save As Button_
    Friend WithEvents Export As Button_
End Class
