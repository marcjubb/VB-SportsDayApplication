Public Class UpdateStudent
    Dim IDarr As Integer()
    Dim firstrun As Boolean
    Public Sub UpdateStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        cmbFill("SELECT ID, Gender As Lbl FROM entGenders;", New ComboBox() {cmbGender}, "Gender")
        cmbFill("SELECT ID, YearGroup As Lbl FROM entYearGroups;", New ComboBox() {cmbYearGroup}, "Year Group")
        cmbFill("SELECT ID, AgeGroup As Lbl FROM entAgeGroups;", New ComboBox() {cmbAgeGroup}, "Age Group")
        cmbFill("SELECT ID, House As Lbl FROM entHouse;", New ComboBox() {cmbHouse}, "House")
        firstrun = True
        FillStuInfo()
    End Sub
    Sub FillStuInfo()
        SQL = "SELECT entStudents.ID FROM entStudents;"
        Dim ds As New DataSet
        ds = cntDatabase(SQL, "ID")
        IDarr = (From myRow In ds.Tables(0).AsEnumerable
                        Select myRow.Field(Of Integer)("ID")).ToArray
        If firstrun = True Then
            StartingId = Array.IndexOf(IDarr, StartingId)
            firstrun = False
        End If
        SQL = "SELECT * FROM entStudents WHERE ID =" & IDarr(StartingId)
        ds = cntDatabase(SQL, "Students")
        txtForename.Text = ds.Tables("Students").Rows(0).Item(1)
        txtSurname.Text = ds.Tables("Students").Rows(0).Item(2)
        cmbAgeGroup.SelectedIndex = ds.Tables("Students").Rows(0).Item(5)
        cmbGender.SelectedIndex = ds.Tables("Students").Rows(0).Item(3)
        cmbYearGroup.SelectedIndex = ds.Tables("Students").Rows(0).Item(4)
        cmbHouse.SelectedIndex = ds.Tables("Students").Rows(0).Item(6)
    End Sub
    Private Sub lblBack_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblBack.LinkClicked
        Me.Hide()
        Students.Show()
    End Sub
    Private Sub lbLogout_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbLogout.LinkClicked
        Me.Hide()
        Form1.Show()
    End Sub
    Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        startingID = startingID - 1
        FillStuInfo()
    End Sub
    Sub bntNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntNext.Click
        startingID = startingID + 1
        FillStuInfo()
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        SQL = "UPDATE entStudents SET Firstname = '" & txtForename.Text & "' , Surname = '" & txtSurname.Text & "', Gender = " & cmbGender.SelectedValue & ", YearGroup = " & cmbYearGroup.SelectedValue & ", AgeGroup =" & cmbAgeGroup.SelectedValue & " , House = " & cmbHouse.SelectedValue & " WHERE ID = " & IDarr(StartingId)
        SQLrun(SQL)
        Me.Hide()
        Students.Show()
    End Sub

End Class