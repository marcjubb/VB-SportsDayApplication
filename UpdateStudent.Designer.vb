<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateStudent))
        Me.cmbAgeGroup = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbHouse = New System.Windows.Forms.ComboBox()
        Me.cmbYearGroup = New System.Windows.Forms.ComboBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.lblBack = New System.Windows.Forms.LinkLabel()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lbLogout = New System.Windows.Forms.LinkLabel()
        Me.txtForename = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.bntNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbAgeGroup
        '
        Me.cmbAgeGroup.FormattingEnabled = True
        Me.cmbAgeGroup.Items.AddRange(New Object() {"Junior", "Intermediate"})
        Me.cmbAgeGroup.Location = New System.Drawing.Point(10, 241)
        Me.cmbAgeGroup.Name = "cmbAgeGroup"
        Me.cmbAgeGroup.Size = New System.Drawing.Size(121, 21)
        Me.cmbAgeGroup.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(7, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Age Group"
        '
        'cmbHouse
        '
        Me.cmbHouse.FormattingEnabled = True
        Me.cmbHouse.Items.AddRange(New Object() {"Flamsteed", "Chantrey", "Nightingale", "Brindley"})
        Me.cmbHouse.Location = New System.Drawing.Point(10, 283)
        Me.cmbHouse.Name = "cmbHouse"
        Me.cmbHouse.Size = New System.Drawing.Size(121, 21)
        Me.cmbHouse.TabIndex = 30
        '
        'cmbYearGroup
        '
        Me.cmbYearGroup.FormattingEnabled = True
        Me.cmbYearGroup.Items.AddRange(New Object() {"7", "8", "9", "10"})
        Me.cmbYearGroup.Location = New System.Drawing.Point(10, 201)
        Me.cmbYearGroup.Name = "cmbYearGroup"
        Me.cmbYearGroup.Size = New System.Drawing.Size(121, 21)
        Me.cmbYearGroup.TabIndex = 29
        '
        'cmbGender
        '
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.cmbGender.Location = New System.Drawing.Point(10, 161)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(121, 21)
        Me.cmbGender.TabIndex = 28
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.BackColor = System.Drawing.Color.Transparent
        Me.lblBack.Location = New System.Drawing.Point(184, 12)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(32, 13)
        Me.lblBack.TabIndex = 27
        Me.lblBack.TabStop = True
        Me.lblBack.Text = "Back"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(10, 310)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 26
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lbLogout
        '
        Me.lbLogout.AutoSize = True
        Me.lbLogout.BackColor = System.Drawing.Color.Transparent
        Me.lbLogout.Location = New System.Drawing.Point(7, 12)
        Me.lbLogout.Name = "lbLogout"
        Me.lbLogout.Size = New System.Drawing.Size(40, 13)
        Me.lbLogout.TabIndex = 25
        Me.lbLogout.TabStop = True
        Me.lbLogout.Text = "Logout"
        '
        'txtForename
        '
        Me.txtForename.Location = New System.Drawing.Point(10, 80)
        Me.txtForename.Name = "txtForename"
        Me.txtForename.Size = New System.Drawing.Size(121, 20)
        Me.txtForename.TabIndex = 24
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(10, 123)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(121, 20)
        Me.txtSurname.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(7, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Surname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(7, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(7, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "House"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(7, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "School Year"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(7, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Forename"
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(10, 38)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(105, 23)
        Me.btnPrevious.TabIndex = 33
        Me.btnPrevious.Text = "Previous Student"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'bntNext
        '
        Me.bntNext.Location = New System.Drawing.Point(126, 38)
        Me.bntNext.Name = "bntNext"
        Me.bntNext.Size = New System.Drawing.Size(90, 23)
        Me.bntNext.TabIndex = 34
        Me.bntNext.Text = "Next Student"
        Me.bntNext.UseVisualStyleBackColor = True
        '
        'UpdateStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(243, 359)
        Me.Controls.Add(Me.bntNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.cmbAgeGroup)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbHouse)
        Me.Controls.Add(Me.cmbYearGroup)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lbLogout)
        Me.Controls.Add(Me.txtForename)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UpdateStudent"
        Me.Text = "UpdateStudent"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbAgeGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbHouse As System.Windows.Forms.ComboBox
    Friend WithEvents cmbYearGroup As System.Windows.Forms.ComboBox
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents lblBack As System.Windows.Forms.LinkLabel
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lbLogout As System.Windows.Forms.LinkLabel
    Friend WithEvents txtForename As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents bntNext As System.Windows.Forms.Button
End Class
