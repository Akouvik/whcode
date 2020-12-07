<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WA_PMCR
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ChartReview = New System.Windows.Forms.TabControl()
        Me.tabHeader = New System.Windows.Forms.TabPage()
        Me.tabInformants = New System.Windows.Forms.TabPage()
        Me.tabHypoxia = New System.Windows.Forms.TabPage()
        Me.tabDiagnoses = New System.Windows.Forms.TabPage()
        Me.tabMedications = New System.Windows.Forms.TabPage()
        Me.tabCVD = New System.Windows.Forms.TabPage()
        Me.tabHachinski = New System.Windows.Forms.TabPage()
        Me.tabDepression = New System.Windows.Forms.TabPage()
        Me.tabMCIRS = New System.Windows.Forms.TabPage()
        Me.tabCDR = New System.Windows.Forms.TabPage()
        Me.tabCDR_INF = New System.Windows.Forms.TabPage()
        Me.tabAD8 = New System.Windows.Forms.TabPage()
        Me.tabDementia1 = New System.Windows.Forms.TabPage()
        Me.tabDementia2 = New System.Windows.Forms.TabPage()
        Me.tabParkinsonism = New System.Windows.Forms.TabPage()
        Me.tabVitalsAndLabs = New System.Windows.Forms.TabPage()
        Me.tabDEAD1 = New System.Windows.Forms.TabPage()
        Me.tabDEAD2 = New System.Windows.Forms.TabPage()
        Me.tabDEAD3 = New System.Windows.Forms.TabPage()
        Me.tabDEAD4 = New System.Windows.Forms.TabPage()
        Me.tab3D1 = New System.Windows.Forms.TabPage()
        Me.tab3D2 = New System.Windows.Forms.TabPage()
        Me.tab3D3 = New System.Windows.Forms.TabPage()
        Me.tab3D4 = New System.Windows.Forms.TabPage()
        Me.tabDemographics = New System.Windows.Forms.TabPage()
        Me.ChartReview.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(3, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(439, 29)
        Me.Label8.TabIndex = 198
        Me.Label8.Text = "Postmortem Clinical Review (PMCR)"
        '
        'ChartReview
        '
        Me.ChartReview.Controls.Add(Me.tabHeader)
        Me.ChartReview.Controls.Add(Me.tabDemographics)
        Me.ChartReview.Controls.Add(Me.tabInformants)
        Me.ChartReview.Controls.Add(Me.tabHypoxia)
        Me.ChartReview.Controls.Add(Me.tabDiagnoses)
        Me.ChartReview.Controls.Add(Me.tabMedications)
        Me.ChartReview.Controls.Add(Me.tabCVD)
        Me.ChartReview.Controls.Add(Me.tabHachinski)
        Me.ChartReview.Controls.Add(Me.tabDepression)
        Me.ChartReview.Controls.Add(Me.tabMCIRS)
        Me.ChartReview.Controls.Add(Me.tabCDR)
        Me.ChartReview.Controls.Add(Me.tabCDR_INF)
        Me.ChartReview.Controls.Add(Me.tabAD8)
        Me.ChartReview.Controls.Add(Me.tabDementia1)
        Me.ChartReview.Controls.Add(Me.tabDementia2)
        Me.ChartReview.Controls.Add(Me.tabParkinsonism)
        Me.ChartReview.Controls.Add(Me.tabVitalsAndLabs)
        Me.ChartReview.Controls.Add(Me.tabDEAD1)
        Me.ChartReview.Controls.Add(Me.tabDEAD2)
        Me.ChartReview.Controls.Add(Me.tabDEAD3)
        Me.ChartReview.Controls.Add(Me.tabDEAD4)
        Me.ChartReview.Controls.Add(Me.tab3D1)
        Me.ChartReview.Controls.Add(Me.tab3D2)
        Me.ChartReview.Controls.Add(Me.tab3D3)
        Me.ChartReview.Controls.Add(Me.tab3D4)
        Me.ChartReview.Location = New System.Drawing.Point(3, 36)
        Me.ChartReview.Multiline = True
        Me.ChartReview.Name = "ChartReview"
        Me.ChartReview.SelectedIndex = 0
        Me.ChartReview.Size = New System.Drawing.Size(1053, 2461)
        Me.ChartReview.TabIndex = 56
        Me.ChartReview.TabStop = False
        '
        'tabHeader
        '
        Me.tabHeader.BackColor = System.Drawing.Color.Tan
        Me.tabHeader.Location = New System.Drawing.Point(4, 40)
        Me.tabHeader.Name = "tabHeader"
        Me.tabHeader.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHeader.Size = New System.Drawing.Size(1045, 2417)
        Me.tabHeader.TabIndex = 25
        Me.tabHeader.Text = "Header"
        '
        'tabInformants
        '
        Me.tabInformants.BackColor = System.Drawing.Color.Tan
        Me.tabInformants.Location = New System.Drawing.Point(4, 22)
        Me.tabInformants.Name = "tabInformants"
        Me.tabInformants.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInformants.Size = New System.Drawing.Size(1045, 2435)
        Me.tabInformants.TabIndex = 0
        Me.tabInformants.Text = "Informants"
        '
        'tabHypoxia
        '
        Me.tabHypoxia.BackColor = System.Drawing.Color.Tan
        Me.tabHypoxia.Location = New System.Drawing.Point(4, 22)
        Me.tabHypoxia.Name = "tabHypoxia"
        Me.tabHypoxia.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHypoxia.Size = New System.Drawing.Size(1045, 2435)
        Me.tabHypoxia.TabIndex = 1
        Me.tabHypoxia.Text = "Hypoxia"
        '
        'tabDiagnoses
        '
        Me.tabDiagnoses.BackColor = System.Drawing.Color.Tan
        Me.tabDiagnoses.Location = New System.Drawing.Point(4, 22)
        Me.tabDiagnoses.Name = "tabDiagnoses"
        Me.tabDiagnoses.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDiagnoses.Size = New System.Drawing.Size(1045, 2435)
        Me.tabDiagnoses.TabIndex = 2
        Me.tabDiagnoses.Text = "Diagnoses"
        '
        'tabMedications
        '
        Me.tabMedications.BackColor = System.Drawing.Color.Tan
        Me.tabMedications.Location = New System.Drawing.Point(4, 22)
        Me.tabMedications.Name = "tabMedications"
        Me.tabMedications.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMedications.Size = New System.Drawing.Size(1045, 2435)
        Me.tabMedications.TabIndex = 3
        Me.tabMedications.Text = "Medications"
        '
        'tabCVD
        '
        Me.tabCVD.BackColor = System.Drawing.Color.Tan
        Me.tabCVD.Location = New System.Drawing.Point(4, 22)
        Me.tabCVD.Name = "tabCVD"
        Me.tabCVD.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCVD.Size = New System.Drawing.Size(1045, 2435)
        Me.tabCVD.TabIndex = 4
        Me.tabCVD.Text = "CVD"
        '
        'tabHachinski
        '
        Me.tabHachinski.BackColor = System.Drawing.Color.Tan
        Me.tabHachinski.Location = New System.Drawing.Point(4, 22)
        Me.tabHachinski.Name = "tabHachinski"
        Me.tabHachinski.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHachinski.Size = New System.Drawing.Size(1045, 2435)
        Me.tabHachinski.TabIndex = 5
        Me.tabHachinski.Text = "Hach"
        '
        'tabDepression
        '
        Me.tabDepression.BackColor = System.Drawing.Color.Tan
        Me.tabDepression.Location = New System.Drawing.Point(4, 22)
        Me.tabDepression.Name = "tabDepression"
        Me.tabDepression.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDepression.Size = New System.Drawing.Size(1045, 2435)
        Me.tabDepression.TabIndex = 21
        Me.tabDepression.Text = "Depression"
        '
        'tabMCIRS
        '
        Me.tabMCIRS.BackColor = System.Drawing.Color.Tan
        Me.tabMCIRS.Location = New System.Drawing.Point(4, 22)
        Me.tabMCIRS.Name = "tabMCIRS"
        Me.tabMCIRS.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMCIRS.Size = New System.Drawing.Size(1045, 2435)
        Me.tabMCIRS.TabIndex = 22
        Me.tabMCIRS.Text = "MCIRS"
        '
        'tabCDR
        '
        Me.tabCDR.BackColor = System.Drawing.Color.Tan
        Me.tabCDR.Location = New System.Drawing.Point(4, 22)
        Me.tabCDR.Name = "tabCDR"
        Me.tabCDR.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCDR.Size = New System.Drawing.Size(1045, 2435)
        Me.tabCDR.TabIndex = 7
        Me.tabCDR.Text = "CDR"
        '
        'tabCDR_INF
        '
        Me.tabCDR_INF.BackColor = System.Drawing.Color.Tan
        Me.tabCDR_INF.Location = New System.Drawing.Point(4, 22)
        Me.tabCDR_INF.Name = "tabCDR_INF"
        Me.tabCDR_INF.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCDR_INF.Size = New System.Drawing.Size(1045, 2435)
        Me.tabCDR_INF.TabIndex = 24
        Me.tabCDR_INF.Text = "CDR- Inf"
        '
        'tabAD8
        '
        Me.tabAD8.BackColor = System.Drawing.Color.Tan
        Me.tabAD8.Location = New System.Drawing.Point(4, 22)
        Me.tabAD8.Name = "tabAD8"
        Me.tabAD8.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAD8.Size = New System.Drawing.Size(1045, 2435)
        Me.tabAD8.TabIndex = 23
        Me.tabAD8.Text = "AD8"
        '
        'tabDementia1
        '
        Me.tabDementia1.BackColor = System.Drawing.Color.Tan
        Me.tabDementia1.Location = New System.Drawing.Point(4, 22)
        Me.tabDementia1.Name = "tabDementia1"
        Me.tabDementia1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDementia1.Size = New System.Drawing.Size(1045, 2435)
        Me.tabDementia1.TabIndex = 6
        Me.tabDementia1.Text = "Dementia 1"
        '
        'tabDementia2
        '
        Me.tabDementia2.BackColor = System.Drawing.Color.Tan
        Me.tabDementia2.Location = New System.Drawing.Point(4, 22)
        Me.tabDementia2.Name = "tabDementia2"
        Me.tabDementia2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDementia2.Size = New System.Drawing.Size(1045, 2435)
        Me.tabDementia2.TabIndex = 8
        Me.tabDementia2.Text = "Dementia 2"
        '
        'tabParkinsonism
        '
        Me.tabParkinsonism.BackColor = System.Drawing.Color.Tan
        Me.tabParkinsonism.Location = New System.Drawing.Point(4, 22)
        Me.tabParkinsonism.Name = "tabParkinsonism"
        Me.tabParkinsonism.Padding = New System.Windows.Forms.Padding(3)
        Me.tabParkinsonism.Size = New System.Drawing.Size(1045, 2435)
        Me.tabParkinsonism.TabIndex = 9
        Me.tabParkinsonism.Text = "Parkinsonism"
        '
        'tabVitalsAndLabs
        '
        Me.tabVitalsAndLabs.BackColor = System.Drawing.Color.Tan
        Me.tabVitalsAndLabs.Location = New System.Drawing.Point(4, 22)
        Me.tabVitalsAndLabs.Name = "tabVitalsAndLabs"
        Me.tabVitalsAndLabs.Padding = New System.Windows.Forms.Padding(3)
        Me.tabVitalsAndLabs.Size = New System.Drawing.Size(1045, 2435)
        Me.tabVitalsAndLabs.TabIndex = 10
        Me.tabVitalsAndLabs.Text = "Vitals && Labs"
        '
        'tabDEAD1
        '
        Me.tabDEAD1.BackColor = System.Drawing.Color.Tan
        Me.tabDEAD1.Location = New System.Drawing.Point(4, 22)
        Me.tabDEAD1.Name = "tabDEAD1"
        Me.tabDEAD1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDEAD1.Size = New System.Drawing.Size(1045, 2435)
        Me.tabDEAD1.TabIndex = 13
        Me.tabDEAD1.Text = "DEAD 1"
        '
        'tabDEAD2
        '
        Me.tabDEAD2.BackColor = System.Drawing.Color.Tan
        Me.tabDEAD2.Location = New System.Drawing.Point(4, 40)
        Me.tabDEAD2.Name = "tabDEAD2"
        Me.tabDEAD2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDEAD2.Size = New System.Drawing.Size(1045, 2417)
        Me.tabDEAD2.TabIndex = 14
        Me.tabDEAD2.Text = "DEAD 2"
        '
        'tabDEAD3
        '
        Me.tabDEAD3.BackColor = System.Drawing.Color.Tan
        Me.tabDEAD3.Location = New System.Drawing.Point(4, 40)
        Me.tabDEAD3.Name = "tabDEAD3"
        Me.tabDEAD3.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDEAD3.Size = New System.Drawing.Size(1045, 2417)
        Me.tabDEAD3.TabIndex = 15
        Me.tabDEAD3.Text = "DEAD 3"
        '
        'tabDEAD4
        '
        Me.tabDEAD4.BackColor = System.Drawing.Color.Tan
        Me.tabDEAD4.Location = New System.Drawing.Point(4, 40)
        Me.tabDEAD4.Name = "tabDEAD4"
        Me.tabDEAD4.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDEAD4.Size = New System.Drawing.Size(1045, 2417)
        Me.tabDEAD4.TabIndex = 16
        Me.tabDEAD4.Text = "DEAD 4"
        '
        'tab3D1
        '
        Me.tab3D1.BackColor = System.Drawing.Color.Tan
        Me.tab3D1.Location = New System.Drawing.Point(4, 40)
        Me.tab3D1.Name = "tab3D1"
        Me.tab3D1.Padding = New System.Windows.Forms.Padding(3)
        Me.tab3D1.Size = New System.Drawing.Size(1045, 2417)
        Me.tab3D1.TabIndex = 17
        Me.tab3D1.Text = "3D 1"
        '
        'tab3D2
        '
        Me.tab3D2.BackColor = System.Drawing.Color.Tan
        Me.tab3D2.Location = New System.Drawing.Point(4, 40)
        Me.tab3D2.Name = "tab3D2"
        Me.tab3D2.Padding = New System.Windows.Forms.Padding(3)
        Me.tab3D2.Size = New System.Drawing.Size(1045, 2417)
        Me.tab3D2.TabIndex = 18
        Me.tab3D2.Text = "3D 2"
        '
        'tab3D3
        '
        Me.tab3D3.BackColor = System.Drawing.Color.Tan
        Me.tab3D3.Location = New System.Drawing.Point(4, 40)
        Me.tab3D3.Name = "tab3D3"
        Me.tab3D3.Padding = New System.Windows.Forms.Padding(3)
        Me.tab3D3.Size = New System.Drawing.Size(1045, 2417)
        Me.tab3D3.TabIndex = 19
        Me.tab3D3.Text = "3D 3"
        '
        'tab3D4
        '
        Me.tab3D4.BackColor = System.Drawing.Color.Tan
        Me.tab3D4.Location = New System.Drawing.Point(4, 40)
        Me.tab3D4.Name = "tab3D4"
        Me.tab3D4.Padding = New System.Windows.Forms.Padding(3)
        Me.tab3D4.Size = New System.Drawing.Size(1045, 2417)
        Me.tab3D4.TabIndex = 20
        Me.tab3D4.Text = "3D 4"
        '
        'tabDemographics
        '
        Me.tabDemographics.BackColor = System.Drawing.Color.Tan
        Me.tabDemographics.ForeColor = System.Drawing.Color.Maroon
        Me.tabDemographics.Location = New System.Drawing.Point(4, 40)
        Me.tabDemographics.Name = "tabDemographics"
        Me.tabDemographics.Size = New System.Drawing.Size(1045, 2417)
        Me.tabDemographics.TabIndex = 26
        Me.tabDemographics.Text = "Demographics"
        '
        'WA_PMCR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Controls.Add(Me.ChartReview)
        Me.Controls.Add(Me.Label8)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "WA_PMCR"
        Me.Size = New System.Drawing.Size(1068, 2500)
        Me.ChartReview.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ChartReview As System.Windows.Forms.TabControl
    Friend WithEvents tabInformants As System.Windows.Forms.TabPage
    Friend WithEvents tabHypoxia As System.Windows.Forms.TabPage
    Friend WithEvents tabDiagnoses As System.Windows.Forms.TabPage
    Friend WithEvents tabMedications As System.Windows.Forms.TabPage
    Friend WithEvents tabCVD As System.Windows.Forms.TabPage
    Friend WithEvents tabHachinski As System.Windows.Forms.TabPage
    Friend WithEvents tabDementia1 As System.Windows.Forms.TabPage
    Friend WithEvents tabCDR As System.Windows.Forms.TabPage
    Friend WithEvents tabDementia2 As System.Windows.Forms.TabPage
    Friend WithEvents tabParkinsonism As System.Windows.Forms.TabPage
    Friend WithEvents tabVitalsAndLabs As System.Windows.Forms.TabPage
    Friend WithEvents tabDEAD1 As System.Windows.Forms.TabPage
    Friend WithEvents tabDEAD2 As System.Windows.Forms.TabPage
    Friend WithEvents tabDEAD3 As System.Windows.Forms.TabPage
    Friend WithEvents tabDEAD4 As System.Windows.Forms.TabPage
    Friend WithEvents tab3D1 As System.Windows.Forms.TabPage
    Friend WithEvents tab3D2 As System.Windows.Forms.TabPage
    Friend WithEvents tab3D3 As System.Windows.Forms.TabPage
    Friend WithEvents tab3D4 As System.Windows.Forms.TabPage
    Friend WithEvents tabDepression As System.Windows.Forms.TabPage
    Friend WithEvents tabMCIRS As System.Windows.Forms.TabPage
    Friend WithEvents tabAD8 As System.Windows.Forms.TabPage
    Friend WithEvents tabCDR_INF As System.Windows.Forms.TabPage
    Friend WithEvents tabHeader As TabPage
    Friend WithEvents tabDemographics As TabPage
End Class
