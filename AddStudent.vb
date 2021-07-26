Public Class AddStudent
    Private Sub lbLogout_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbLogout.LinkClicked
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub lblBack_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblBack.LinkClicked
        Me.Hide()
        Students.Show()
    End Sub
    'When the form is loaded the combo box and search box parameters need to be set to default in order for the SQL to pull a dataset without parameters
    Private Sub AddStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        txtForename.Text = ""
        txtSurname.Text = ""
        cmbFill("SELECT ID, Gender As Lbl FROM entGenders;", New ComboBox() {cmbGender}, "Gender")
        cmbFill("SELECT ID, YearGroup As Lbl FROM entYearGroups;", New ComboBox() {cmbYearGroup}, "Year Group")
        cmbFill("SELECT ID, AgeGroup As Lbl FROM entAgeGroups;", New ComboBox() {cmbAgeGroup}, "Age Group")
        cmbFill("SELECT ID, House As Lbl FROM entHouse;", New ComboBox() {cmbHouse}, "House")
    End Sub
    'When the btn is clicked the program runs this code which sets the variable SQL to the required query necessary to execute.
    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        'Using parameterized SQL the query adapts to the parameters inputted in. The inputs are from text boxes or cmb boxes which are displayed on the form for the user.
        SQL = "INSERT INTO entStudents(Firstname, Surname, Gender, YearGroup, AgeGroup, House) Values('" & txtForename.Text & "','" & txtSurname.Text & "'," & cmbGender.SelectedValue & "," & cmbYearGroup.SelectedValue & "," & cmbAgeGroup.SelectedValue & "," & cmbHouse.SelectedValue & ");"
        SQLrun(SQL)
        MsgBox("Student Added")
        Me.Hide()
        Students.Show()
    End Sub

End Class