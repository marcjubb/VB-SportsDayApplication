<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Students
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Students))
        Me.lbLogout = New System.Windows.Forms.LinkLabel()
        Me.btnAddStu = New System.Windows.Forms.Button()
        Me.btnRemoveStu = New System.Windows.Forms.Button()
        Me.StudentDataset = New System.Windows.Forms.DataGridView()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnCSV = New System.Windows.Forms.Button()
        Me.btnHTML = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.surnametxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.firstnameTxt = New System.Windows.Forms.TextBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbYearGroup = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbAgeGroup = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbHouse = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.StudentDataset, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'btnAddStu
        '
        Me.btnAddStu.Location = New System.Drawing.Point(15, 370)
        Me.btnAddStu.Name = "btnAddStu"
        Me.btnAddStu.Size = New System.Drawing.Size(75, 23)
        Me.btnAddStu.TabIndex = 8
        Me.btnAddStu.Text = "Add Student"
        Me.btnAddStu.UseVisualStyleBackColor = True
        '
        'btnRemoveStu
        '
        Me.btnRemoveStu.Location = New System.Drawing.Point(197, 370)
        Me.btnRemoveStu.Name = "btnRemoveStu"
        Me.btnRemoveStu.Size = New System.Drawing.Size(99, 23)
        Me.btnRemoveStu.TabIndex = 9
        Me.btnRemoveStu.Text = "Remove Student"
        Me.btnRemoveStu.UseVisualStyleBackColor = True
        '
        'StudentDataset
        '
        Me.StudentDataset.AllowUserToAddRows = False
        Me.StudentDataset.AllowUserToDeleteRows = False
        Me.StudentDataset.AllowUserToResizeColumns = False
        Me.StudentDataset.AllowUserToResizeRows = False
        Me.StudentDataset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StudentDataset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentDataset.Location = New System.Drawing.Point(15, 88)
        Me.StudentDataset.MultiSelect = False
        Me.StudentDataset.Name = "StudentDataset"
        Me.StudentDataset.ReadOnly = True
        Me.StudentDataset.RowHeadersVisible = False
        Me.StudentDataset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.StudentDataset.Size = New System.Drawing.Size(709, 276)
        Me.StudentDataset.TabIndex = 14
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Location = New System.Drawing.Point(681, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(32, 13)
        Me.LinkLabel1.TabIndex = 15
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Back"
        '
        'btnCSV
        '
        Me.btnCSV.Location = New System.Drawing.Point(464, 9)
        Me.btnCSV.Name = "btnCSV"
        Me.btnCSV.Size = New System.Drawing.Size(93, 27)
        Me.btnCSV.TabIndex = 16
        Me.btnCSV.Text = "Export to Excel"
        Me.btnCSV.UseVisualStyleBackColor = True
        '
        'btnHTML
        '
        Me.btnHTML.Location = New System.Drawing.Point(565, 9)
        Me.btnHTML.Name = "btnHTML"
        Me.btnHTML.Size = New System.Drawing.Size(98, 27)
        Me.btnHTML.TabIndex = 17
        Me.btnHTML.Text = "Export to Chrome"
        Me.btnHTML.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(96, 370)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(95, 23)
        Me.btnUpdate.TabIndex = 18
        Me.btnUpdate.Text = "Update Student"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(124, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Surname Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "First Name"
        '
        'surnametxt
        '
        Me.surnametxt.Location = New System.Drawing.Point(124, 62)
        Me.surnametxt.Name = "surnametxt"
        Me.surnametxt.Size = New System.Drawing.Size(103, 20)
        Me.surnametxt.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Search by"
        '
        'firstnameTxt
        '
        Me.firstnameTxt.Location = New System.Drawing.Point(15, 62)
        Me.firstnameTxt.Name = "firstnameTxt"
        Me.firstnameTxt.Size = New System.Drawing.Size(103, 20)
        Me.firstnameTxt.TabIndex = 29
        '
        'cmbGender
        '
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.cmbGender.Location = New System.Drawing.Point(233, 61)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(110, 21)
        Me.cmbGender.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(230, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Gender"
        '
        'cmbYearGroup
        '
        Me.cmbYearGroup.FormattingEnabled = True
        Me.cmbYearGroup.Items.AddRange(New Object() {"7", "8", "9", "10"})
        Me.cmbYearGroup.Location = New System.Drawing.Point(346, 61)
        Me.cmbYearGroup.Name = "cmbYearGroup"
        Me.cmbYearGroup.Size = New System.Drawing.Size(118, 21)
        Me.cmbYearGroup.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(346, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "School Year"
        '
        'cmbAgeGroup
        '
        Me.cmbAgeGroup.FormattingEnabled = True
        Me.cmbAgeGroup.Items.AddRange(New Object() {"Junior", "Intermediate"})
        Me.cmbAgeGroup.Location = New System.Drawing.Point(470, 61)
        Me.cmbAgeGroup.Name = "cmbAgeGroup"
        Me.cmbAgeGroup.Size = New System.Drawing.Size(127, 21)
        Me.cmbAgeGroup.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(467, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Age Group"
        '
        'cmbHouse
        '
        Me.cmbHouse.FormattingEnabled = True
        Me.cmbHouse.Items.AddRange(New Object() {"Flamsteed", "Chantrey", "Nightingale", "Brindley"})
        Me.cmbHouse.Location = New System.Drawing.Point(603, 61)
        Me.cmbHouse.Name = "cmbHouse"
        Me.cmbHouse.Size = New System.Drawing.Size(121, 21)
        Me.cmbHouse.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(600, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "House"
        '
        'Students
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(736, 405)
        Me.Controls.Add(Me.cmbHouse)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbAgeGroup)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbYearGroup)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.surnametxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.firstnameTxt)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnHTML)
        Me.Controls.Add(Me.btnCSV)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.StudentDataset)
        Me.Controls.Add(Me.btnRemoveStu)
        Me.Controls.Add(Me.btnAddStu)
        Me.Controls.Add(Me.lbLogout)
        Me.Name = "Students"
        Me.Text = "Students"
        CType(Me.StudentDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbLogout As System.Windows.Forms.LinkLabel
    Friend WithEvents btnAddStu As System.Windows.Forms.Button
    Friend WithEvents btnRemoveStu As System.Windows.Forms.Button
    Friend WithEvents StudentDataset As System.Windows.Forms.DataGridView
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents btnCSV As System.Windows.Forms.Button
    Friend WithEvents btnHTML As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents surnametxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents firstnameTxt As System.Windows.Forms.TextBox
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbYearGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbAgeGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbHouse As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
