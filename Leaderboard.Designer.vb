<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Leaderboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Leaderboard))
        Me.lbLogout = New System.Windows.Forms.LinkLabel()
        Me.lblBack = New System.Windows.Forms.LinkLabel()
        Me.datagridMJ = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.datagridMI = New System.Windows.Forms.DataGridView()
        Me.datagridFJ = New System.Windows.Forms.DataGridView()
        Me.datagridFI = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.datagridMJ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagridMI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagridFJ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagridFI, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblBack.Location = New System.Drawing.Point(515, 9)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(32, 13)
        Me.lblBack.TabIndex = 13
        Me.lblBack.TabStop = True
        Me.lblBack.Text = "Back"
        '
        'datagridMJ
        '
        Me.datagridMJ.AllowUserToAddRows = False
        Me.datagridMJ.AllowUserToDeleteRows = False
        Me.datagridMJ.AllowUserToResizeColumns = False
        Me.datagridMJ.AllowUserToResizeRows = False
        Me.datagridMJ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridMJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridMJ.Location = New System.Drawing.Point(18, 277)
        Me.datagridMJ.MultiSelect = False
        Me.datagridMJ.Name = "datagridMJ"
        Me.datagridMJ.RowHeadersVisible = False
        Me.datagridMJ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.datagridMJ.Size = New System.Drawing.Size(268, 105)
        Me.datagridMJ.TabIndex = 51
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 82)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(529, 160)
        Me.DataGridView1.TabIndex = 52
        '
        'datagridMI
        '
        Me.datagridMI.AllowUserToAddRows = False
        Me.datagridMI.AllowUserToDeleteRows = False
        Me.datagridMI.AllowUserToResizeColumns = False
        Me.datagridMI.AllowUserToResizeRows = False
        Me.datagridMI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridMI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridMI.Location = New System.Drawing.Point(18, 406)
        Me.datagridMI.MultiSelect = False
        Me.datagridMI.Name = "datagridMI"
        Me.datagridMI.RowHeadersVisible = False
        Me.datagridMI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.datagridMI.Size = New System.Drawing.Size(268, 113)
        Me.datagridMI.TabIndex = 53
        '
        'datagridFJ
        '
        Me.datagridFJ.AllowUserToAddRows = False
        Me.datagridFJ.AllowUserToDeleteRows = False
        Me.datagridFJ.AllowUserToResizeColumns = False
        Me.datagridFJ.AllowUserToResizeRows = False
        Me.datagridFJ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridFJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridFJ.Location = New System.Drawing.Point(292, 406)
        Me.datagridFJ.MultiSelect = False
        Me.datagridFJ.Name = "datagridFJ"
        Me.datagridFJ.RowHeadersVisible = False
        Me.datagridFJ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.datagridFJ.Size = New System.Drawing.Size(255, 113)
        Me.datagridFJ.TabIndex = 54
        '
        'datagridFI
        '
        Me.datagridFI.AllowUserToAddRows = False
        Me.datagridFI.AllowUserToDeleteRows = False
        Me.datagridFI.AllowUserToResizeColumns = False
        Me.datagridFI.AllowUserToResizeRows = False
        Me.datagridFI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridFI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridFI.Location = New System.Drawing.Point(292, 277)
        Me.datagridFI.MultiSelect = False
        Me.datagridFI.Name = "datagridFI"
        Me.datagridFI.RowHeadersVisible = False
        Me.datagridFI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.datagridFI.Size = New System.Drawing.Size(255, 105)
        Me.datagridFI.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(233, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 18)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "House Scores"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(90, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 18)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Mens Junior MVP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 385)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 18)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Mens Intermediate MVP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(345, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 18)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Female Junior MVP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(307, 385)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(207, 18)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Female Intermediate MVP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(131, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(309, 30)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "The Ecclesbourne School"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(232, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 23)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Sports Day"
        '
        'LEaderboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(596, 531)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.datagridFI)
        Me.Controls.Add(Me.datagridFJ)
        Me.Controls.Add(Me.datagridMI)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.datagridMJ)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.lbLogout)
        Me.Name = "LEaderboard"
        Me.Text = "report"
        CType(Me.datagridMJ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagridMI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagridFJ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagridFI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbLogout As System.Windows.Forms.LinkLabel
    Friend WithEvents lblBack As System.Windows.Forms.LinkLabel
    Friend WithEvents datagridMJ As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents datagridMI As System.Windows.Forms.DataGridView
    Friend WithEvents datagridFJ As System.Windows.Forms.DataGridView
    Friend WithEvents datagridFI As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
