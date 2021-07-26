Public Class AloSelectEvent
    Dim changed As Boolean = False
    Private Sub lbLogout_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbLogout.LinkClicked
        Me.Hide()
        Form1.Show()
    End Sub
    '
    Private Sub UpdateDG()
        Dim ds As New DataSet
        If changed = False Then
            SQL = "SELECT entEvents.ID, entEvents.Event, entAgeGroups.AgeGroup, entGenders.Gender, entEventTypes.EventType FROM entAgeGroups INNER JOIN (entGenders INNER JOIN (entEventTypes INNER JOIN entEvents ON entEventTypes.ID = entEvents.EventType) ON entGenders.ID = entEvents.Gender) ON entAgeGroups.ID = entEvents.AgeGroup;"
        Else
            gender = cmbSelected(cmbGender.SelectedValue, gender)
            agegroup = cmbSelected(cmbAgeGroup.SelectedValue, agegroup)
            type = cmbSelected(cmbType.SelectedValue, type)
            SQL = "SELECT entEvents.ID, entEvents.Event, entAgeGroups.AgeGroup, entGenders.Gender, entEventTypes.EventType FROM entAgeGroups INNER JOIN (entGenders INNER JOIN (entEventTypes INNER JOIN entEvents ON entEventTypes.ID = entEvents.EventType) ON entGenders.ID = entEvents.Gender) ON entAgeGroups.ID = entEvents.AgeGroup WHERE entEvents.Event LIKE '" & txtEventname.Text & "%'" & " AND entEvents.AgeGroup LIKE '" & agegroup & "%' AND entEvents.Gender LIKE '" & gender & "%' AND entEvents.EventType LIKE " & "'" & type & "%'"
        End If
        ds = cntDatabase(SQL, "entEvents")
        EventsDataset.DataSource = ds
        EventsDataset.DataMember = "entEvents"
    End Sub
    Private Sub lblBack_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblBack.LinkClicked
        Me.Hide()
        MainMenu.Show()
    End Sub
    Private Sub cmbGender_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGender.SelectionChangeCommitted
        changed = True
        UpdateDG()
    End Sub
    Private Sub cmbAgeGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAgeGroup.SelectionChangeCommitted
        changed = True
        UpdateDG()
    End Sub
    Private Sub cmbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbType.SelectionChangeCommitted
        changed = True
        UpdateDG()
    End Sub
    Private Sub txtEventname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEventname.TextChanged
        changed = True
        UpdateDG()
    End Sub
    Private Sub AloSelectEvent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        UpdateDG()
        cmbFill("SELECT ID, Gender As Lbl FROM entGenders;", New ComboBox() {cmbGender}, "Gender")
        cmbFill("SELECT ID, AgeGroup As Lbl FROM entAgeGroups;", New ComboBox() {cmbAgeGroup}, "Age Group")
        cmbFill("SELECT ID, EventType As Lbl FROM entEventTypes;", New ComboBox() {cmbType}, "Type of event")
    End Sub
    Private Sub EventsDataset_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles EventsDataset.CellDoubleClick
        If EventsDataset.SelectedRows(0).Cells(2).Value = "Junior" Then
            agegroup = "1"
        Else
            agegroup = "2"
        End If
        If EventsDataset.SelectedRows(0).Cells(3).Value = "Male" Then
            gender = "1"
        Else
            gender = "2"
        End If
        eventID = EventsDataset.SelectedRows(0).Cells(0).Value
        If EventsDataset.SelectedRows(0).Cells(4).Value = "Track" Then
            istrack = True
        Else
            istrack = False
        End If
        changed = False
        Me.Hide()
        AloStudents.Show()
    End Sub
End Class