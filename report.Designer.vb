<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class report
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
        Me.lbLogout = New System.Windows.Forms.LinkLabel()
        Me.lblBack = New System.Windows.Forms.LinkLabel()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbLogout
        '
        Me.lbLogout.AutoSize = True
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
        Me.lblBack.Location = New System.Drawing.Point(231, 9)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(32, 13)
        Me.lblBack.TabIndex = 13
        Me.lblBack.TabStop = True
        Me.lblBack.Text = "Back"
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(76, 124)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(116, 23)
        Me.btnTest.TabIndex = 68
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.lbLogout)
        Me.Name = "report"
        Me.Text = "report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbLogout As System.Windows.Forms.LinkLabel
    Friend WithEvents lblBack As System.Windows.Forms.LinkLabel
    Friend WithEvents btnTest As System.Windows.Forms.Button
End Class
