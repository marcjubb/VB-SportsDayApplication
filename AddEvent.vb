Public Class AddEvent
    'The code ran throughout each form which is used to traverse the program
    Private Sub lbLogout_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbLogout.LinkClicked
        Me.Hide()
        Form1.Show()
    End Sub
    'The code ran throughout each form which is used to traverse the program
    Private Sub lblBack_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblBack.LinkClicked
        Me.Hide()
        Students.Show()
    End Sub
    'When the form is loaded the combo box and search box parameters need to be set to default in order for the SQL to pull a dataset without parameters
    Private Sub AddStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        txtEventname.Text = ""
        'Inputting an SQL query, combobox name and category title the function can use the inputs to fill a combobox with the data pulled by the SQL.
        'The SQL sets the value of the item selected to ID but makes the combobox show that ID as a label of gender, eventtype or agegroup. 
        cmbFill("SELECT ID, Gender As Lbl FROM entGenders;", New ComboBox() {cmbGender}, "Gender")
        cmbFill("SELECT ID, EventType As Lbl FROM entEventTypes;", New ComboBox() {cmbType}, "Type Of event")
        cmbFill("SELECT ID, AgeGroup As Lbl FROM entAgeGroups;", New ComboBox() {cmbAgeGroup}, "Age Group")
    End Sub
    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        SQL = "INSERT INTO entEvents(Event, Gender, EventType, AgeGroup) Values('" & txtEventname.Text & "'," & cmbGender.SelectedValue & "," & cmbType.SelectedValue & "," & cmbAgeGroup.SelectedValue & ");"
        SQLrun(SQL)
        MsgBox("Event Added")
        Me.Hide()
        frmEvents.Show()
    End Sub
End Class