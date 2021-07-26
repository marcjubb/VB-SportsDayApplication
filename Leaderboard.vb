Public Class Leaderboard
    Sub UpdateDG()
        Dim ds As New DataSet
        SQL = "SELECT entHouse.House, Sum(entResult.Points) AS SumOfPoints FROM (entHouse INNER JOIN entStudents ON entHouse.ID = entStudents.House) INNER JOIN (entParticipants INNER JOIN entResult ON entParticipants.ID = entResult.ParticipantID) ON entStudents.ID = entParticipants.StudentID GROUP BY entHouse.House;"
        ds = cntDatabase(SQL, "entpoint")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "entpoint"
        SQL = "SELECT TOP 1 entStudents.Firstname, entStudents.Surname, Sum(entResult.Points) AS SumOfPoints FROM entStudents INNER JOIN (entParticipants INNER JOIN entResult ON entParticipants.ID = entResult.ParticipantID) ON entStudents.ID = entParticipants.StudentID WHERE (((entStudents.AgeGroup)=1) AND ((entStudents.Gender)=1)) GROUP BY entStudents.Firstname, entStudents.Surname ORDER BY Sum(entResult.Points) DESC;"
        ds = cntDatabase(SQL, "entMJ")
        datagridMJ.DataSource = ds
        datagridMJ.DataMember = "entMJ"
        SQL = "SELECT TOP 1 entStudents.Firstname, entStudents.Surname, Sum(entResult.Points) AS SumOfPoints FROM entStudents INNER JOIN (entParticipants INNER JOIN entResult ON entParticipants.ID = entResult.ParticipantID) ON entStudents.ID = entParticipants.StudentID WHERE (((entStudents.AgeGroup)=2) AND ((entStudents.Gender)=1)) GROUP BY entStudents.Firstname, entStudents.Surname ORDER BY Sum(entResult.Points) DESC;"
        ds = cntDatabase(SQL, "entMI")
        datagridMI.DataSource = ds
        datagridMI.DataMember = "entMI"
        SQL = "SELECT TOP 1 entStudents.Firstname, entStudents.Surname, Sum(entResult.Points) AS SumOfPoints FROM entStudents INNER JOIN (entParticipants INNER JOIN entResult ON entParticipants.ID = entResult.ParticipantID) ON entStudents.ID = entParticipants.StudentID WHERE (((entStudents.AgeGroup)=2) AND ((entStudents.Gender)=2)) GROUP BY entStudents.Firstname, entStudents.Surname ORDER BY Sum(entResult.Points) DESC;"
        ds = cntDatabase(SQL, "entFJ")
        datagridFJ.DataSource = ds
        datagridFJ.DataMember = "entFJ"
        SQL = "SELECT TOP 1 entStudents.Firstname, entStudents.Surname, Sum(entResult.Points) AS SumOfPoints FROM entStudents INNER JOIN (entParticipants INNER JOIN entResult ON entParticipants.ID = entResult.ParticipantID) ON entStudents.ID = entParticipants.StudentID WHERE (((entStudents.AgeGroup)=1) AND ((entStudents.Gender)=2)) GROUP BY entStudents.Firstname, entStudents.Surname ORDER BY Sum(entResult.Points) DESC;"
        ds = cntDatabase(SQL, "entFI")
        datagridFI.DataSource = ds
        datagridFI.DataMember = "entFI"
    End Sub
    Private Sub lbLogout_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbLogout.LinkClicked
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub lblBack_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblBack.LinkClicked
        Me.Hide()
        MainMenu.Show()
    End Sub
    Private Sub report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UpdateDG()
    End Sub
End Class