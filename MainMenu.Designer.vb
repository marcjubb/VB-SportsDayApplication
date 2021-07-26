<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.btnEvents = New System.Windows.Forms.Button()
        Me.btnResults = New System.Windows.Forms.Button()
        Me.btnLeaderboard = New System.Windows.Forms.Button()
        Me.btnAllocate = New System.Windows.Forms.Button()
        Me.lbLogout = New System.Windows.Forms.LinkLabel()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btncreateuser = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStudent
        '
        Me.btnStudent.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnStudent.FlatAppearance.BorderSize = 0
        Me.btnStudent.Font = New System.Drawing.Font("Minion Pro SmBd", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudent.Location = New System.Drawing.Point(25, 95)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(175, 68)
        Me.btnStudent.TabIndex = 0
        Me.btnStudent.Text = "Manage Students"
        Me.btnStudent.UseVisualStyleBackColor = False
        '
        'btnEvents
        '
        Me.btnEvents.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEvents.FlatAppearance.BorderSize = 0
        Me.btnEvents.Font = New System.Drawing.Font("Minion Pro SmBd", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEvents.Location = New System.Drawing.Point(25, 169)
        Me.btnEvents.Name = "btnEvents"
        Me.btnEvents.Size = New System.Drawing.Size(175, 68)
        Me.btnEvents.TabIndex = 1
        Me.btnEvents.Text = "Manage Events"
        Me.btnEvents.UseVisualStyleBackColor = False
        '
        'btnResults
        '
        Me.btnResults.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnResults.FlatAppearance.BorderSize = 0
        Me.btnResults.Font = New System.Drawing.Font("Minion Pro SmBd", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResults.Location = New System.Drawing.Point(206, 169)
        Me.btnResults.Name = "btnResults"
        Me.btnResults.Size = New System.Drawing.Size(175, 68)
        Me.btnResults.TabIndex = 2
        Me.btnResults.Text = "Attempts and Results"
        Me.btnResults.UseVisualStyleBackColor = False
        '
        'btnLeaderboard
        '
        Me.btnLeaderboard.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnLeaderboard.FlatAppearance.BorderSize = 0
        Me.btnLeaderboard.Font = New System.Drawing.Font("Minion Pro SmBd", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeaderboard.Location = New System.Drawing.Point(206, 95)
        Me.btnLeaderboard.Name = "btnLeaderboard"
        Me.btnLeaderboard.Size = New System.Drawing.Size(175, 68)
        Me.btnLeaderboard.TabIndex = 3
        Me.btnLeaderboard.Text = "Leaderboard"
        Me.btnLeaderboard.UseVisualStyleBackColor = False
        '
        'btnAllocate
        '
        Me.btnAllocate.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAllocate.FlatAppearance.BorderSize = 0
        Me.btnAllocate.Font = New System.Drawing.Font("Minion Pro SmBd", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllocate.Location = New System.Drawing.Point(387, 95)
        Me.btnAllocate.Name = "btnAllocate"
        Me.btnAllocate.Size = New System.Drawing.Size(175, 68)
        Me.btnAllocate.TabIndex = 4
        Me.btnAllocate.Text = "Allocate Students to Event"
        Me.btnAllocate.UseVisualStyleBackColor = False
        '
        'lbLogout
        '
        Me.lbLogout.AutoSize = True
        Me.lbLogout.BackColor = System.Drawing.Color.Transparent
        Me.lbLogout.Location = New System.Drawing.Point(22, 9)
        Me.lbLogout.Name = "lbLogout"
        Me.lbLogout.Size = New System.Drawing.Size(40, 13)
        Me.lbLogout.TabIndex = 5
        Me.lbLogout.TabStop = True
        Me.lbLogout.Text = "Logout"
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.Font = New System.Drawing.Font("Minion Pro SmBd", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Location = New System.Drawing.Point(387, 169)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(175, 68)
        Me.btnReport.TabIndex = 6
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(136, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(309, 30)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "The Ecclesbourne School"
        '
        'btncreateuser
        '
        Me.btncreateuser.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btncreateuser.FlatAppearance.BorderSize = 0
        Me.btncreateuser.Font = New System.Drawing.Font("Minion Pro SmBd", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncreateuser.Location = New System.Drawing.Point(206, 243)
        Me.btncreateuser.Name = "btncreateuser"
        Me.btncreateuser.Size = New System.Drawing.Size(175, 68)
        Me.btncreateuser.TabIndex = 8
        Me.btncreateuser.Text = "Create a New User"
        Me.btncreateuser.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(572, 320)
        Me.Controls.Add(Me.btncreateuser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.lbLogout)
        Me.Controls.Add(Me.btnAllocate)
        Me.Controls.Add(Me.btnLeaderboard)
        Me.Controls.Add(Me.btnResults)
        Me.Controls.Add(Me.btnEvents)
        Me.Controls.Add(Me.btnStudent)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStudent As System.Windows.Forms.Button
    Friend WithEvents btnEvents As System.Windows.Forms.Button
    Friend WithEvents btnResults As System.Windows.Forms.Button
    Friend WithEvents btnLeaderboard As System.Windows.Forms.Button
    Friend WithEvents btnAllocate As System.Windows.Forms.Button
    Friend WithEvents lbLogout As System.Windows.Forms.LinkLabel
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btncreateuser As System.Windows.Forms.Button
End Class
