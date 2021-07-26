<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.cmbAccessLevel = New System.Windows.Forms.ComboBox()
        Me.lblBack = New System.Windows.Forms.LinkLabel()
        Me.lbLogout = New System.Windows.Forms.LinkLabel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbAccessLevel
        '
        Me.cmbAccessLevel.FormattingEnabled = True
        Me.cmbAccessLevel.Location = New System.Drawing.Point(12, 38)
        Me.cmbAccessLevel.Name = "cmbAccessLevel"
        Me.cmbAccessLevel.Size = New System.Drawing.Size(175, 21)
        Me.cmbAccessLevel.TabIndex = 0
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.BackColor = System.Drawing.Color.Transparent
        Me.lblBack.Location = New System.Drawing.Point(197, 9)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(32, 13)
        Me.lblBack.TabIndex = 28
        Me.lblBack.TabStop = True
        Me.lblBack.Text = "Back"
        '
        'lbLogout
        '
        Me.lbLogout.AutoSize = True
        Me.lbLogout.BackColor = System.Drawing.Color.Transparent
        Me.lbLogout.Location = New System.Drawing.Point(12, 9)
        Me.lbLogout.Name = "lbLogout"
        Me.lbLogout.Size = New System.Drawing.Size(40, 13)
        Me.lbLogout.TabIndex = 29
        Me.lbLogout.TabStop = True
        Me.lbLogout.Text = "Logout"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(15, 117)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(172, 20)
        Me.txtPassword.TabIndex = 34
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(15, 78)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(172, 20)
        Me.txtName.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Username"
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(15, 156)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(101, 23)
        Me.btnRegister.TabIndex = 35
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(242, 212)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbLogout)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.cmbAccessLevel)
        Me.Name = "Form2"
        Me.Text = "frmCreateUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbAccessLevel As System.Windows.Forms.ComboBox
    Friend WithEvents lblBack As System.Windows.Forms.LinkLabel
    Friend WithEvents lbLogout As System.Windows.Forms.LinkLabel
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnRegister As System.Windows.Forms.Button
End Class
