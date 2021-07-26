<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateEvent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateEvent))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEventname = New System.Windows.Forms.TextBox()
        Me.lbLogout = New System.Windows.Forms.LinkLabel()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblBack = New System.Windows.Forms.LinkLabel()
        Me.cmbAgeGroup = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(9, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Event Name"
        '
        'txtEventname
        '
        Me.txtEventname.Location = New System.Drawing.Point(10, 50)
        Me.txtEventname.Name = "txtEventname"
        Me.txtEventname.Size = New System.Drawing.Size(121, 20)
        Me.txtEventname.TabIndex = 6
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
        Me.btnEnter.Location = New System.Drawing.Point(10, 269)
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
        Me.lblBack.Location = New System.Drawing.Point(184, 9)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(32, 13)
        Me.lblBack.TabIndex = 12
        Me.lblBack.TabStop = True
        Me.lblBack.Text = "Back"
        '
        'cmbAgeGroup
        '
        Me.cmbAgeGroup.FormattingEnabled = True
        Me.cmbAgeGroup.Items.AddRange(New Object() {"Junior", "Intermediate"})
        Me.cmbAgeGroup.Location = New System.Drawing.Point(10, 90)
        Me.cmbAgeGroup.Name = "cmbAgeGroup"
        Me.cmbAgeGroup.Size = New System.Drawing.Size(121, 21)
        Me.cmbAgeGroup.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(7, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Age Group"
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"Flamsteed", "Chantrey", "Nightingale", "Brindley"})
        Me.cmbType.Location = New System.Drawing.Point(10, 138)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(121, 21)
        Me.cmbType.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(7, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Type of event"
        '
        'cmbGender
        '
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.cmbGender.Location = New System.Drawing.Point(10, 185)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(121, 21)
        Me.cmbGender.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(7, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Gender"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(12, 229)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 22
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(93, 229)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 23
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'UpdateEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(246, 304)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbAgeGroup)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lbLogout)
        Me.Controls.Add(Me.txtEventname)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UpdateEvent"
        Me.Text = "AddEvent"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEventname As System.Windows.Forms.TextBox
    Friend WithEvents lbLogout As System.Windows.Forms.LinkLabel
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents lblBack As System.Windows.Forms.LinkLabel
    Friend WithEvents cmbAgeGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
End Class
