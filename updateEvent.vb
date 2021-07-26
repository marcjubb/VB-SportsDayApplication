Public Class UpdateEvent
    Dim IDarr As Integer()
    Dim firstrun As Boolean = True
    Private Sub lbLogout_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbLogout.LinkClicked
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub lblBack_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblBack.LinkClicked
        Me.Hide()
        frmEvents.Show()
    End Sub
    Sub reset()
        cmbFill("SELECT ID, Gender As Lbl FROM entGenders;", New ComboBox() {cmbGender}, "Gender")
        cmbFill("SELECT ID, EventType As Lbl FROM entEventTypes;", New ComboBox() {cmbType}, "Type Of event")
        cmbFill("SELECT ID, AgeGroup As Lbl FROM entAgeGroups;", New ComboBox() {cmbAgeGroup}, "Age Group")
        filleventinfo()
    End Sub
    Sub filleventinfo()
        SQL = "SELECT entEvents.ID FROM entEvents;"
        Dim ds As New DataSet
        ds = cntDatabase(SQL, "ID")
        IDarr = (From myRow In ds.Tables(0).AsEnumerable
                        Select myRow.Field(Of Integer)("ID")).ToArray
        If firstrun = True Then
            StartingId = Array.IndexOf(IDarr, StartingId)
            firstrun = False
        End If
        SQL = "SELECT * FROM entEvents WHERE ID =" & IDarr(StartingId)
        ds = cntDatabase(SQL, "Events")
        txtEventname.Text = ds.Tables("Events").Rows(0).Item(1)
        cmbAgeGroup.SelectedIndex = ds.Tables("Events").Rows(0).Item(2)
        cmbGender.SelectedIndex = ds.Tables("Events").Rows(0).Item(3)
        cmbType.SelectedIndex = ds.Tables("Events").Rows(0).Item(4)
    End Sub
    Private Sub UpdateEvent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        reset()
    End Sub
    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        SQL = "UPDATE entEvents SET Event = '" & txtEventname.Text & "', Gender = " & cmbGender.SelectedValue & ", AgeGroup =" & cmbAgeGroup.SelectedValue & " , EventType = " & cmbType.SelectedValue & " WHERE ID = " & IDarr(StartingId)
        SQLrun(SQL)
        Me.Hide()
        frmEvents.Show()
    End Sub
    Private Sub btnNext_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click
        StartingId = StartingId + 1
        filleventinfo()
    End Sub

    Private Sub btnPrevious_Click(sender As System.Object, e As System.EventArgs) Handles btnPrevious.Click
        StartingId = StartingId - 1
        filleventinfo()
    End Sub
End Class


