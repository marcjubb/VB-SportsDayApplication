<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnterResults
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EnterResults))
        Me.lbLogout = New System.Windows.Forms.LinkLabel()
        Me.lblBack = New System.Windows.Forms.LinkLabel()
        Me.participantDataset = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.participantDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbLogout
        '
        Me.lbLogout.AutoSize = True
        Me.lbLogout.BackColor = System.Drawing.Color.Transparent
        Me.lbLogout.Location = New System.Drawing.Point(12, 9)
        Me.lbLogout.Name = "lbLogout"
        Me.lbLogout.Size = New System.Drawing.Size(40, 13)
        Me.lbLogout.TabIndex = 6
        Me.lbLogout.TabStop = True
        Me.lbLogout.Text = "Logout"
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.BackColor = System.Drawing.Color.Transparent
        Me.lblBack.Location = New System.Drawing.Point(567, 9)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(32, 13)
        Me.lblBack.TabIndex = 13
        Me.lblBack.TabStop = True
        Me.lblBack.Text = "Back"
        '
        'participantDataset
        '
        Me.participantDataset.AllowUserToAddRows = False
        Me.participantDataset.AllowUserToDeleteRows = False
        Me.participantDataset.AllowUserToResizeColumns = False
        Me.participantDataset.AllowUserToResizeRows = False
        Me.participantDataset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.participantDataset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.participantDataset.Location = New System.Drawing.Point(12, 42)
        Me.participantDataset.MultiSelect = False
        Me.participantDataset.Name = "participantDataset"
        Me.participantDataset.RowHeadersVisible = False
        Me.participantDataset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.participantDataset.Size = New System.Drawing.Size(587, 261)
        Me.participantDataset.TabIndex = 49
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 309)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EnterResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(612, 386)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.participantDataset)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.lbLogout)
        Me.Name = "EnterResults"
        Me.Text = "EnterResults"
        CType(Me.participantDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbLogout As System.Windows.Forms.LinkLabel
    Friend WithEvents lblBack As System.Windows.Forms.LinkLabel
    Friend WithEvents participantDataset As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
