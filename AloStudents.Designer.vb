<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AloStudents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AloStudents))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.surnametxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.firstnameTxt = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.StudentDataset = New System.Windows.Forms.DataGridView()
        Me.lbLogout = New System.Windows.Forms.LinkLabel()
        Me.cmbHouse = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAllocate = New System.Windows.Forms.Button()
        Me.Participentdataset = New System.Windows.Forms.DataGridView()
        Me.btnremovepartice = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbYearGroup = New System.Windows.Forms.ComboBox()
        CType(Me.StudentDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Participentdataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(123, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Surname Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(11, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "First Name"
        '
        'surnametxt
        '
        Me.surnametxt.Location = New System.Drawing.Point(123, 73)
        Me.surnametxt.Name = "surnametxt"
        Me.surnametxt.Size = New System.Drawing.Size(103, 20)
        Me.surnametxt.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(11, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Search by"
        '
        'firstnameTxt
        '
        Me.firstnameTxt.Location = New System.Drawing.Point(14, 73)
        Me.firstnameTxt.Name = "firstnameTxt"
        Me.firstnameTxt.Size = New System.Drawing.Size(103, 20)
        Me.firstnameTxt.TabIndex = 42
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Location = New System.Drawing.Point(674, 20)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(32, 13)
        Me.LinkLabel1.TabIndex = 57
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Back"
        '
        'StudentDataset
        '
        Me.StudentDataset.AllowUserToAddRows = False
        Me.StudentDataset.AllowUserToDeleteRows = False
        Me.StudentDataset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentDataset.Location = New System.Drawing.Point(8, 99)
        Me.StudentDataset.MultiSelect = False
        Me.StudentDataset.Name = "StudentDataset"
        Me.StudentDataset.ReadOnly = True
        Me.StudentDataset.RowHeadersVisible = False
        Me.StudentDataset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.StudentDataset.Size = New System.Drawing.Size(709, 276)
        Me.StudentDataset.TabIndex = 56
        '
        'lbLogout
        '
        Me.lbLogout.AutoSize = True
        Me.lbLogout.BackColor = System.Drawing.Color.Transparent
        Me.lbLogout.Location = New System.Drawing.Point(5, 20)
        Me.lbLogout.Name = "lbLogout"
        Me.lbLogout.Size = New System.Drawing.Size(40, 13)
        Me.lbLogout.TabIndex = 55
        Me.lbLogout.TabStop = True
        Me.lbLogout.Text = "Logout"
        '
        'cmbHouse
        '
        Me.cmbHouse.FormattingEnabled = True
        Me.cmbHouse.Items.AddRange(New Object() {"Flamsteed", "Chantrey", "Nightingale", "Brindley"})
        Me.cmbHouse.Location = New System.Drawing.Point(356, 73)
        Me.cmbHouse.Name = "cmbHouse"
        Me.cmbHouse.Size = New System.Drawing.Size(121, 21)
        Me.cmbHouse.TabIndex = 65
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(353, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "House"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(211, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(312, 13)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Please select a student and click the ""Allocate To Event"" button"
        '
        'btnAllocate
        '
        Me.btnAllocate.Location = New System.Drawing.Point(282, 392)
        Me.btnAllocate.Name = "btnAllocate"
        Me.btnAllocate.Size = New System.Drawing.Size(116, 23)
        Me.btnAllocate.TabIndex = 67
        Me.btnAllocate.Text = "Allocate to Event"
        Me.btnAllocate.UseVisualStyleBackColor = True
        '
        'Participentdataset
        '
        Me.Participentdataset.AllowUserToAddRows = False
        Me.Participentdataset.AllowUserToDeleteRows = False
        Me.Participentdataset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Participentdataset.Location = New System.Drawing.Point(8, 421)
        Me.Participentdataset.MultiSelect = False
        Me.Participentdataset.Name = "Participentdataset"
        Me.Participentdataset.ReadOnly = True
        Me.Participentdataset.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Participentdataset.RowHeadersVisible = False
        Me.Participentdataset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Participentdataset.Size = New System.Drawing.Size(709, 276)
        Me.Participentdataset.TabIndex = 68
        '
        'btnremovepartice
        '
        Me.btnremovepartice.Location = New System.Drawing.Point(282, 712)
        Me.btnremovepartice.Name = "btnremovepartice"
        Me.btnremovepartice.Size = New System.Drawing.Size(116, 23)
        Me.btnremovepartice.TabIndex = 69
        Me.btnremovepartice.Text = "Remove Participent"
        Me.btnremovepartice.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(232, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "School Year"
        '
        'cmbYearGroup
        '
        Me.cmbYearGroup.FormattingEnabled = True
        Me.cmbYearGroup.Items.AddRange(New Object() {"7", "8", "9", "10"})
        Me.cmbYearGroup.Location = New System.Drawing.Point(232, 73)
        Me.cmbYearGroup.Name = "cmbYearGroup"
        Me.cmbYearGroup.Size = New System.Drawing.Size(118, 21)
        Me.cmbYearGroup.TabIndex = 61
        '
        'AloStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(729, 745)
        Me.Controls.Add(Me.btnremovepartice)
        Me.Controls.Add(Me.Participentdataset)
        Me.Controls.Add(Me.btnAllocate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbHouse)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbYearGroup)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.StudentDataset)
        Me.Controls.Add(Me.lbLogout)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.surnametxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.firstnameTxt)
        Me.Name = "AloStudents"
        Me.Text = "AloStudents"
        CType(Me.StudentDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Participentdataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents surnametxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents firstnameTxt As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents StudentDataset As System.Windows.Forms.DataGridView
    Friend WithEvents lbLogout As System.Windows.Forms.LinkLabel
    Friend WithEvents cmbHouse As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnAllocate As System.Windows.Forms.Button
    Friend WithEvents Participentdataset As System.Windows.Forms.DataGridView
    Friend WithEvents btnremovepartice As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbYearGroup As System.Windows.Forms.ComboBox
End Class
