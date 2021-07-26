Public Class MainMenu
    Public accessLevel As Integer
    Private Sub btnStudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudent.Click
        Me.Hide()
        Students.Show()
    End Sub

    Private Sub btnEvents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEvents.Click
        Me.Hide()
        frmEvents.Show()
    End Sub

    Private Sub btnResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResults.Click
        Me.Hide()
        ResultSelectEvent.Show()
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeaderboard.Click
        Me.Hide()
        LEaderboard.Show()
    End Sub

    Private Sub btnAllocate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllocate.Click
        Me.Hide()
        AloSelectEvent.Show()
    End Sub

    Private Sub lbLogout_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbLogout.LinkClicked
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub MainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        If accessLevel = 1 Then
            btnAllocate.Hide()
            btnStudent.Hide()
            btnEvents.Hide()
        ElseIf accessLevel = 2 Then
            btnEvents.Hide()
            btnResults.Hide()
            btncreateuser.Hide()
        End If
    End Sub

    Private Sub btnReport_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Me.Hide()
        ReportGraphing.Show()
    End Sub

    Private Sub createuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncreateuser.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub MainMenu_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class