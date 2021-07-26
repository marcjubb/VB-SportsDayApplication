Public Class Students
    Dim yeargroup, house As String
    Dim changed As Boolean = False
    Private Sub UpdateDG()
        Dim ds As New DataSet
        If changed = False Then
            Sql = "SELECT entStudents.ID, entStudents.Firstname, entStudents.Surname, entYearGroups.YearGroup, entAgeGroups.AgeGroup, entGenders.Gender, entHouse.House FROM entYearGroups INNER JOIN (entAgeGroups INNER JOIN (entGenders INNER JOIN (entHouse INNER JOIN entStudents ON entHouse.ID = entStudents.House) ON entGenders.ID = entStudents.Gender) ON entAgeGroups.ID = entStudents.AgeGroup) ON entYearGroups.ID = entStudents.YearGroup;"
        Else
            gender = cmbSelected(cmbGender.SelectedValue, gender)
            agegroup = cmbSelected(cmbAgeGroup.SelectedValue, agegroup)
            yeargroup = cmbSelected(cmbYearGroup.SelectedValue, yeargroup)
            house = cmbSelected(cmbHouse.SelectedValue, house)
            SQL = "SELECT entStudents.ID, entStudents.Firstname, entStudents.Surname, entGenders.Gender, entYearGroups.YearGroup, entAgeGroups.AgeGroup, entHouse.House FROM entHouse INNER JOIN (entYearGroups INNER JOIN (entAgeGroups INNER JOIN (entGenders INNER JOIN entStudents ON entGenders.ID = entStudents.Gender) ON entAgeGroups.ID = entStudents.AgeGroup) ON entYearGroups.ID = entStudents.YearGroup) ON entHouse.ID = entStudents.House WHERE entStudents.Firstname LIKE '" & firstnameTxt.Text & "%'" & " AND entStudents.Surname LIKE '" & surnametxt.Text & "%'" & " AND entStudents.Gender LIKE " & "'" & gender & "%' AND entStudents.AgeGroup LIKE " & "'" & agegroup & "%' AND entStudents.YearGroup LIKE " & "'" & yeargroup & "%' AND entStudents.House LIKE " & "'" & house & "%'"
        End If
        ds = cntDatabase(Sql, "entStudents")
        StudentDataset.DataSource = ds
        StudentDataset.DataMember = "entStudents"
        colourDGV(StudentDataset, 6)
    End Sub
    Private Sub lbLogout_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbLogout.LinkClicked
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub btnAddStu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddStu.Click
        Me.Hide()
        AddStudent.Show()
    End Sub
    Private Sub lblBack_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Me.Hide()
        MainMenu.Show()
    End Sub
    Private Sub Students_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        UpdateDG()
        cmbFill("SELECT ID, Gender As Lbl FROM entGenders;", New ComboBox() {cmbGender}, "Gender")
        cmbFill("SELECT ID, YearGroup As Lbl FROM entYearGroups;", New ComboBox() {cmbYearGroup}, "Year Group")
        cmbFill("SELECT ID, AgeGroup As Lbl FROM entAgeGroups;", New ComboBox() {cmbAgeGroup}, "Age Group")
        cmbFill("SELECT ID, House As Lbl FROM entHouse;", New ComboBox() {cmbHouse}, "House")
    End Sub
    Private Sub btnRemoveStu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveStu.Click
        Dim ds As New DataSet
        StartingId = StudentDataset.SelectedRows(0).Cells(0).Value
        SQL = "DELETE entParticipants.StudentID, entFieldAttempts.* FROM entParticipants INNER JOIN entFieldAttempts ON entParticipants.ID = entFieldAttempts.ParticipantID WHERE (((entParticipants.StudentID)=" & StartingId & "));"
        SQLrun(SQL)
        SQL = "DELETE entResult.*, entParticipants.StudentID FROM entParticipants INNER JOIN entResult ON entParticipants.ID = entResult.ParticipantID WHERE (((entParticipants.StudentID)=" & StartingId & "));"
        SQLrun(SQL)
        SQL = "DELETE entParticipants.*, entParticipants.StudentID FROM entParticipants WHERE (((entParticipants.StudentID)=" & StartingId & "));"
        SQLrun(SQL)
        SQL = "DELETE entStudents.*, entStudents.ID FROM entStudents WHERE (((entStudents.ID)=" & StartingId & "));"
        SQLrun(SQL)
        UpdateDG()
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        MainMenu.Show()
    End Sub
    Private Sub btnCSV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCSV.Click
        DGVtoCSV(StudentDataset)
    End Sub
    Private Sub btnHTML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHTML.Click
        DGVtoHTML(StudentDataset)
    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            StartingId = StudentDataset.SelectedRows(0).Cells(0).Value
            Me.Hide()
            UpdateStudent.Show()
        Catch ex As Exception
            MsgBox("Please select a student to update.")
        End Try
    End Sub
    Private Sub firstnameTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles firstnameTxt.TextChanged
        changed = True
        UpdateDG()
    End Sub
    Private Sub surnametxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles surnametxt.TextChanged
        changed = True
        UpdateDG()
    End Sub
    Private Sub cmbGender_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGender.SelectionChangeCommitted
        changed = True
        UpdateDG()
    End Sub
    Private Sub cmbYearGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbYearGroup.SelectionChangeCommitted

        changed = True
        UpdateDG()
    End Sub
    Private Sub cmbAgeGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAgeGroup.SelectionChangeCommitted
        changed = True
        UpdateDG()
    End Sub
    Private Sub cmbHouse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHouse.SelectionChangeCommitted
        changed = True
        UpdateDG()
    End Sub
End Class