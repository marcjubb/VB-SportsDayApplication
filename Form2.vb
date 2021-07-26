Public Class Form2
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbFill("SELECT ID, Accesslevel As Lbl FROM entAccesslevel;", New ComboBox() {cmbAccessLevel}, "Access Level")
    End Sub
    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        If txtName.Text = "" Or txtPassword.Text = "" Or cmbAccessLevel.SelectedValue = 0 Then
            MsgBox("Please fill in all of your details")
        Else
            SQL = "INSERT INTO entUsers(Username,Passcode,Accesslevel) Values('" & txtName.Text & "','" & txtPassword.Text & "'," & cmbAccessLevel.SelectedValue & ");"
            SQLrun(SQL)
            txtName.Text = ""
            txtPassword.Text = ""
        End If
    End Sub

    Private Sub lbLogout_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbLogout.LinkClicked
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub lblBack_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblBack.LinkClicked
        Me.Hide()
        MainMenu.Show()
    End Sub
End Class