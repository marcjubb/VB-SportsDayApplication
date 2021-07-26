<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddStudent))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtForename = New System.Windows.Forms.TextBox()
        Me.lbLogout = New System.Windows.Forms.LinkLabel()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblBack = New System.Windows.Forms.LinkLabel()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.cmbYearGroup = New System.Windows.Forms.ComboBox()
        Me.cmbHouse = New System.Windows.Forms.ComboBox()
        Me.cmbAgeGroup = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(9, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Forename"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(9, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "School Year"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(9, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "House"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(9, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(9, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Surname"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(12, 93)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(121, 20)
        Me.txtSurname.TabIndex = 5
        '
        'txtForename
        '
        Me.txtForename.Location = New System.Drawing.Point(12, 50)
        Me.txtForename.Name = "txtForename"
        Me.txtForename.Size = New System.Drawing.Size(121, 20)
        Me.txtForename.TabIndex = 6
        '
        'lbLogout
        '
        Me.lbLogout.AutoSize = True
        Me.lbLogout.BackColor = System.Drawing.Color.Transparent
        Me.lbLogout.Location = New System.Drawing.Point(7, 9)
        Me.lbLogout.Name = "lbLogout"
        Me.lbLogout.Size = New System.Drawing.Size(40, 13)
        Me.lbLogout.TabIndex = 10
        Me.lbLogout.TabStop = True
        Me.lbLogout.Text = "Logout"
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(12, 294)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 11
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.BackColor = System.Drawing.Color.Transparent
        Me.lblBack.Location = New System.Drawing.Point(369, 9)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(32, 13)
        Me.lblBack.TabIndex = 12
        Me.lblBack.TabStop = True
        Me.lblBack.Text = "Back"
        '
        'cmbGender
        '
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.cmbGender.Location = New System.Drawing.Point(12, 131)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(121, 21)
        Me.cmbGender.TabIndex = 13
        '
        'cmbYearGroup
        '
        Me.cmbYearGroup.FormattingEnabled = True
        Me.cmbYearGroup.Items.AddRange(New Object() {"7", "8", "9", "10"})
        Me.cmbYearGroup.Location = New System.Drawing.Point(12, 171)
        Me.cmbYearGroup.Name = "cmbYearGroup"
        Me.cmbYearGroup.Size = New System.Drawing.Size(121, 21)
        Me.cmbYearGroup.TabIndex = 14
        '
        'cmbHouse
        '
        Me.cmbHouse.FormattingEnabled = True
        Me.cmbHouse.Items.AddRange(New Object() {"Flamsteed", "Chantrey", "Nightingale", "Brindley"})
        Me.cmbHouse.Location = New System.Drawing.Point(12, 253)
        Me.cmbHouse.Name = "cmbHouse"
        Me.cmbHouse.Size = New System.Drawing.Size(121, 21)
        Me.cmbHouse.TabIndex = 15
        '
        'cmbAgeGroup
        '
        Me.cmbAgeGroup.FormattingEnabled = True
        Me.cmbAgeGroup.Items.AddRange(New Object() {"Junior", "Intermediate"})
        Me.cmbAgeGroup.Location = New System.Drawing.Point(12, 211)
        Me.cmbAgeGroup.Name = "cmbAgeGroup"
        Me.cmbAgeGroup.Size = New System.Drawing.Size(121, 21)
        Me.cmbAgeGroup.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(9, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Age Group"
        '
        'AddStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(242, 320)
        Me.Controls.Add(Me.cmbAgeGroup)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbHouse)
        Me.Controls.Add(Me.cmbYearGroup)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lbLogout)
        Me.Controls.Add(Me.txtForename)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "AddStudent"
        Me.Text = "AddStudent"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtForename As System.Windows.Forms.TextBox
    Friend WithEvents lbLogout As System.Windows.Forms.LinkLabel
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents lblBack As System.Windows.Forms.LinkLabel
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents cmbYearGroup As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHouse As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAgeGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
