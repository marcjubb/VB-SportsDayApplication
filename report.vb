Public Class report

    Private Sub lbLogout_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbLogout.LinkClicked
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub lblBack_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblBack.LinkClicked
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub btnTest_Click(sender As System.Object, e As System.EventArgs) Handles btnTest.Click
        Dim ds As New DataSet
        SQL = "SELECT Sum(entResult.Points) AS SumOfPoints FROM (entHouse INNER JOIN entStudents ON entHouse.ID = entStudents.House) INNER JOIN (entParticipants INNER JOIN entResult ON entParticipants.ID = entResult.ParticipantID) ON entStudents.ID = entParticipants.StudentID WHERE (((entStudents.House)=4));"
        ds = cntDatabase(SQL, "sumofHouse")
        MsgBox(ds.Tables(0).Rows(0).Item(0))

    End Sub
End Class