Public Class frmEvents
    Dim changed As Boolean = False
    Private Sub lbLogout_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbLogout.LinkClicked
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub lblBack_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblBack.LinkClicked
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub UpdateDG()

        Dim ds As New DataSet
        If changed = False Then
            SQL = "SELECT entEvents.ID, entEvents.Event, entAgeGroups.AgeGroup, entGenders.Gender, entEventTypes.EventType FROM entAgeGroups INNER JOIN (entGenders INNER JOIN (entEventTypes INNER JOIN entEvents ON entEventTypes.ID = entEvents.EventType) ON entGenders.ID = entEvents.Gender) ON entAgeGroups.ID = entEvents.AgeGroup;"
        Else
            gender = cmbSelected(cmbGender.SelectedValue, gender)
            agegroup = cmbSelected(cmbAgeGroup.SelectedValue, agegroup)
            type = cmbSelected(cmbType.SelectedValue, type)
            SQL = "SELECT entEvents.ID, entEvents.Event, entAgeGroups.AgeGroup, entGenders.Gender, entEventTypes.EventType FROM entGenders INNER JOIN (entAgeGroups INNER JOIN (entEventTypes INNER JOIN entEvents ON entEventTypes.ID = entEvents.EventType) ON entAgeGroups.ID = entEvents.AgeGroup) ON entGenders.ID = entEvents.Gender WHERE entEvents.Event LIKE '" & txtEventname.Text & "%'" & " AND entEvents.AgeGroup LIKE '" & agegroup & "%' AND entEvents.Gender LIKE '" & gender & "%' AND entEvents.EventType LIKE " & "'" & type & "%'"
        End If
        ds = cntDatabase(SQL, "entEvents")
        EventsDataset.DataSource = ds
        EventsDataset.DataMember = "entEvents"
    End Sub

    Private Sub Events_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        UpdateDG()
        cmbFill("SELECT ID, Gender As Lbl FROM entGenders;", New ComboBox() {cmbGender}, "Gender")
        cmbFill("SELECT ID, AgeGroup As Lbl FROM entAgeGroups;", New ComboBox() {cmbAgeGroup}, "Age Group")
        cmbFill("SELECT ID, EventType As Lbl FROM entEventTypes;", New ComboBox() {cmbType}, "Type of event")
    End Sub
    Private Sub btnRemoveEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveEvent.Click
        Dim ds As New DataSet
        SQL = "DELETE FROM entEvents WHERE ID =" & EventsDataset.SelectedRows(0).Cells(0).Value
        SQLrun(SQL)
        UpdateDG()
    End Sub
    Private Sub btnAddevent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddevent.Click
        Me.Hide()
        AddEvent.Show()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateEvent.Click
        Try
            StartingId = EventsDataset.SelectedRows(0).Cells(0).Value
            Me.Hide()
            UpdateEvent.Show()
        Catch ex As Exception
            MsgBox("Please select a event to update.")
        End Try
    End Sub

    Private Sub cmbGender_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbGender.SelectionChangeCommitted
        changed = True
        UpdateDG()
    End Sub
    Private Sub cmbAgeGroup_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbAgeGroup.SelectionChangeCommitted
        changed = True
        UpdateDG()
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbType.SelectionChangeCommitted
        changed = True
        UpdateDG()
    End Sub
    Private Sub txtEventname_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtEventname.TextChanged
        changed = True
        UpdateDG()
    End Sub

End Class