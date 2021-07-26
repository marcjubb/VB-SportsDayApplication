Public Class register
    'Runs the sub when the register button is clicked.
    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click

        If txtName.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please fill in all of your details")
        Else
            'Uses 
            SQL = "INSERT INTO entUsers(Username,Passcode,Accesslevel) Values('" & txtName.Text & "','" & txtPassword.Text & "','1')"
            txtName.Text = ""
            txtPassword.Text = ""
        End If
        SQLrun(SQL)
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub lblBack_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblBack.LinkClicked
        Me.Hide()
        txtName.Text = ""
        txtPassword.Text = ""
        Form1.Show()
    End Sub

End Class