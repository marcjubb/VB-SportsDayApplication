Public Class AloStudents
    Dim yeargroup, house As String
    Dim changed As Boolean = False
    'Whilst using DGV within my project at multiple instances, they regularly need to be updated and refreshed due to the updates in the database. Here is where I update the DGV to the newest instance of the database as every time this piece of code is ran it pulls in the freshly updated data from the base.
    Private Sub UpdateDG()
        Dim ds As New DataSet
        yeargroup = cmbSelected(cmbYearGroup.SelectedValue, yeargroup)
        house = cmbSelected(cmbHouse.SelectedValue, house)
        'Here is where cross-tabular parameterized SQL is used in order to display the students information on the DGV
        SQL = "SELECT entStudents.ID, entStudents.Firstname, entStudents.Surname, entGenders.Gender, entYearGroups.YearGroup, entAgeGroups.AgeGroup, entHouse.House FROM entYearGroups INNER JOIN (entHouse INNER JOIN (entGenders INNER JOIN (entAgeGroups INNER JOIN entStudents ON entAgeGroups.ID = entStudents.AgeGroup) ON entGenders.ID = entStudents.Gender) ON entHouse.ID = entStudents.House) ON entYearGroups.ID = entStudents.YearGroup WHERE entStudents.Firstname LIKE '" & firstnameTxt.Text & "%'" & " AND entStudents.Surname LIKE '" & surnametxt.Text & "%'" & " AND entGenders.ID LIKE " & "'" & gender & "%' AND entAgeGroups.ID LIKE " & "'" & agegroup & "%'" & " AND entHouse.ID LIKE " & "'" & house & "%' AND entYearGroups.ID LIKE " & "'" & yeargroup & "%' AND ((Exists (SELECT entParticipants.StudentID FROM entParticipants WHERE entParticipants.EventID = " & eventID & " and entStudents.ID = entParticipants.StudentID))=False);"
        'Calls upon the heavily used function cntdatabase in order to pull the data for the program.
        ds = cntDatabase(SQL, "entStudents")
        StudentDataset.DataSource = ds
        StudentDataset.DataMember = "entStudents"
        colourDGV(StudentDataset, 6)
    End Sub
    'Whilst using DGV within my project at multiple instances, they regularly need to be updated and refreshed due to the updates in the database. Here is where I update the DGV to the newest instance of the database as every time this piece of code is ran it pulls in the freshly updated data from the base.
    Private Sub UpdateParticiDG()
        Dim ds As New DataSet
        SQL = "SELECT entStudents.ID, entStudents.Firstname, entStudents.Surname, entGenders.Gender, entYearGroups.YearGroup, entAgeGroups.AgeGroup, entHouse.House FROM entYearGroups INNER JOIN ((entHouse INNER JOIN (entGenders INNER JOIN (entAgeGroups INNER JOIN entStudents ON entAgeGroups.ID = entStudents.AgeGroup) ON entGenders.ID = entStudents.Gender) ON entHouse.ID = entStudents.House) INNER JOIN entParticipants ON entStudents.ID = entParticipants.StudentID) ON entYearGroups.ID = entStudents.YearGroup WHERE entStudents.ID = entParticipants.StudentID and entParticipants.EventID = " & eventID & " ;"
        ds = cntDatabase(SQL, "entParticipents")
        Participentdataset.DataSource = ds
        Participentdataset.DataMember = "entParticipents"
        colourDGV(Participentdataset, 6)
    End Sub
    'These subs are for the automation of the DGV's being updated when using the search filter system
    Private Sub firstnameTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles firstnameTxt.TextChanged
        UpdateDG()
    End Sub
    Private Sub surnametxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles surnametxt.TextChanged
        UpdateDG()
    End Sub
    Private Sub cmbYearGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbYearGroup.SelectionChangeCommitted
        UpdateDG()
    End Sub
    Private Sub lbLogout_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbLogout.LinkClicked
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub lblBack_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        AloSelectEvent.Show()
    End Sub
    'When the form is loaded the combo box and search box parameters need to be set to default in order for the SQL to pull a dataset without parameters
    Private Sub AloStudents_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.VisibleChanged
        UpdateDG()
        UpdateParticiDG()
        firstnameTxt.Text = ""
        surnametxt.Text = ""
        cmbFill("SELECT ID, YearGroup As Lbl FROM entYearGroups;", New ComboBox() {cmbYearGroup}, "Year Group")
        cmbFill("SELECT ID, House As Lbl FROM entHouse;", New ComboBox() {cmbHouse}, "House")
    End Sub
    'This sub is the main interest of this form as it is used for inserting data into the database from the selected rows
    'The order of insertion of the data is important here as the participants need to be inserted into the entParticipant table before the result table and if the event is track it will then be inserted into track table as well. 
    Private Sub btnAllocate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllocate.Click
        'Useful application of DGV.SelectedRows
        StartingId = StudentDataset.SelectedRows(0).Cells(0).Value
        SQL = "INSERT INTO entParticipants(EventID, StudentID) Values(" & eventID & "," & StartingId & ");"
        SQLrun(SQL)
        SQL = "INSERT INTO entResult(ParticipantID) SELECT entParticipants.ID FROM entParticipants WHERE (((entParticipants.EventID)=" & eventID & ") AND ((entParticipants.StudentID)=" & StartingId & "));"
        SQLrun(SQL)
        If istrack = False Then
            SQL = "INSERT INTO entFieldAttempts(ParticipantID) SELECT entParticipants.ID FROM entParticipants WHERE (((entParticipants.EventID)=" & eventID & ") AND ((entParticipants.StudentID)=" & StartingId & "));"
            SQLrun(SQL)
        End If
        'Runs the update subs to ensure the presented data is automatically shown 
        UpdateDG()
        UpdateParticiDG()
    End Sub
    'Another sub showing use of SQL but this time the purpose of this sub is to delete the selected row the user highlights 
    Private Sub btnremovepartice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremovepartice.Click
        Dim ds As New DataSet
        'Two diffrent queries needed for if the event is track or not due to the normalisation of the database and how that is needed to be traversed
        If istrack Then
            'High level SQL using parameters and cross-tabular connections.
            SQL = "DELETE entParticipants.*, entResult.* FROM entParticipants INNER JOIN entResult ON entParticipants.ID = entResult.ParticipantID WHERE (((entParticipants.StudentID)=" & Participentdataset.SelectedRows(0).Cells(0).Value & " AND entParticipants.EventID = " & eventID & "));"
        Else
            'High level SQL using parameters and cross-tabular connections.
            SQL = "DELETE entParticipants.*, entResult.*, entFieldAttempts.*, entParticipants.StudentID FROM (entParticipants INNER JOIN entResult ON entParticipants.ID = entResult.ParticipantID) INNER JOIN entFieldAttempts ON entParticipants.ID = entFieldAttempts.ParticipantID WHERE (((entParticipants.StudentID)=" & Participentdataset.SelectedRows(0).Cells(0).Value & " AND entParticipants.EventID = " & eventID & "));"
        End If
        'Runs and updates
        SQLrun(SQL)
        UpdateParticiDG()
        UpdateDG()
    End Sub
    Private Sub cmbHouse_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHouse.SelectionChangeCommitted
        UpdateDG()
    End Sub
End Class