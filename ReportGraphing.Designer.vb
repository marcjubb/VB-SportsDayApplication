<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportGraphing
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim CustomLabel1 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim CustomLabel2 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportGraphing))
        Me.lbLogout = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.cmbGraphselc = New System.Windows.Forms.ComboBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbLogout
        '
        Me.lbLogout.AutoSize = True
        Me.lbLogout.BackColor = System.Drawing.Color.Transparent
        Me.lbLogout.Location = New System.Drawing.Point(12, 9)
        Me.lbLogout.Name = "lbLogout"
        Me.lbLogout.Size = New System.Drawing.Size(40, 13)
        Me.lbLogout.TabIndex = 7
        Me.lbLogout.TabStop = True
        Me.lbLogout.Text = "Logout"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Location = New System.Drawing.Point(654, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(32, 13)
        Me.LinkLabel1.TabIndex = 16
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Back"
        '
        'cmbGraphselc
        '
        Me.cmbGraphselc.FormattingEnabled = True
        Me.cmbGraphselc.Items.AddRange(New Object() {"Overall Scores", "Flamsteed Score", "Chantrey Score", "Nightingale Score", "Brindley Score"})
        Me.cmbGraphselc.Location = New System.Drawing.Point(15, 35)
        Me.cmbGraphselc.Name = "cmbGraphselc"
        Me.cmbGraphselc.Size = New System.Drawing.Size(146, 21)
        Me.cmbGraphselc.TabIndex = 18
        '
        'Chart1
        '
        CustomLabel1.Text = "Male "
        ChartArea1.AxisY2.CustomLabels.Add(CustomLabel1)
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(15, 62)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Color = System.Drawing.Color.Yellow
        Series1.Legend = "Legend1"
        Series1.Name = "Chantrey"
        Series2.ChartArea = "ChartArea1"
        Series2.Color = System.Drawing.Color.Blue
        Series2.Legend = "Legend1"
        Series2.Name = "Flamsteed"
        Series3.ChartArea = "ChartArea1"
        Series3.Color = System.Drawing.Color.LimeGreen
        Series3.Legend = "Legend1"
        Series3.Name = "Brindley"
        Series4.ChartArea = "ChartArea1"
        Series4.Color = System.Drawing.Color.Red
        Series4.Legend = "Legend1"
        Series4.Name = "Nightingale"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Size = New System.Drawing.Size(639, 289)
        Me.Chart1.TabIndex = 19
        Me.Chart1.Text = "Housechart"
        '
        'Chart2
        '
        CustomLabel2.Text = "Male "
        ChartArea2.AxisY2.CustomLabels.Add(CustomLabel2)
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(12, 357)
        Me.Chart2.Name = "Chart2"
        Series5.ChartArea = "ChartArea1"
        Series5.Color = System.Drawing.Color.Yellow
        Series5.Legend = "Legend1"
        Series5.Name = "Chantrey"
        Series6.ChartArea = "ChartArea1"
        Series6.Color = System.Drawing.Color.Blue
        Series6.Legend = "Legend1"
        Series6.Name = "Flamsteed"
        Series7.ChartArea = "ChartArea1"
        Series7.Color = System.Drawing.Color.LimeGreen
        Series7.Legend = "Legend1"
        Series7.Name = "Brindley"
        Series8.ChartArea = "ChartArea1"
        Series8.Color = System.Drawing.Color.Red
        Series8.Legend = "Legend1"
        Series8.Name = "Nightingale"
        Me.Chart2.Series.Add(Series5)
        Me.Chart2.Series.Add(Series6)
        Me.Chart2.Series.Add(Series7)
        Me.Chart2.Series.Add(Series8)
        Me.Chart2.Size = New System.Drawing.Size(639, 289)
        Me.Chart2.TabIndex = 20
        Me.Chart2.Text = "Housechart"
        '
        'ReportGraphing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(698, 660)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.cmbGraphselc)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lbLogout)
        Me.Name = "ReportGraphing"
        Me.Text = " "
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbLogout As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents cmbGraphselc As System.Windows.Forms.ComboBox
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
