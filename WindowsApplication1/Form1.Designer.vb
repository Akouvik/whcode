<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NA = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(608, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please answer these questions in order. Once a determinitation can be made, it wi" &
    "ll populate the results dropdown automatically."
        '
        'NA
        '
        Me.NA.AutoSize = True
        Me.NA.Location = New System.Drawing.Point(277, 41)
        Me.NA.Name = "NA"
        Me.NA.Size = New System.Drawing.Size(210, 17)
        Me.NA.TabIndex = 1
        Me.NA.Text = "N/A (No mention of Covid-19 Infection)"
        Me.NA.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(328, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "1.  Did the Donor test positive for SARS-COV-2 at the time of death?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(90, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(323, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "2. Does the donor have any clinical history of COVID-19 diagnosis?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(90, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(326, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "3. Is the Donor suspected to have been diagnosed with COVID-19?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(90, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(326, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "4. Is the Donor suspected to have been diagnosed with COVID-19?"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(90, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(308, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "5. Has the donor been exposed to a COVID-19 positive person?"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(90, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(506, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "6. Were there any COVID-19 infections in care facility where decedent was located" &
    " near/at time of death?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NA)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Covid-19 Acceptance Criteria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
