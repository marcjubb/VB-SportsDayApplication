Public Class Form1
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim ds As New DataSet
        SQL = "SELECT entUsers.ID, entUsers.Username, entUsers.Passcode, entUsers.AccessLevel FROM entUsers WHERE entUsers.Username = '" & txtName.Text & "' AND entUsers.Passcode = '" & txtPassword.Text & "'"
        txtName.Text = ""
        txtPassword.Text = ""
        ds = cntDatabase(SQL, "entUsers")
        Dim MainMenu = New MainMenu
        If (ds.Tables("entUsers").Rows.Count = 0) Then
            MsgBox("Incorrect username or password")
            txtName.Text = ""
            txtPassword.Text = ""
        Else
            MainMenu.accessLevel = ds.Tables("entUsers").Rows(0).Item(3)
            Me.Hide()
            MainMenu.Show()
        End If
    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        Me.Hide()
        register.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtName.Text = "jasongormo"
        txtPassword.Text = "jason"
    End Sub
End Class
