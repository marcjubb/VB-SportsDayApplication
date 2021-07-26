Imports System.Windows.Forms.DataVisualization.Charting
'1*This form is created in order to report the results on the application for the end user can view in a visual way using graphs. 
'2*The form also shows skills of coding a graph that changes depending on the data inputted through high level SQL cross table parameterized SQL.
Public Class ReportGraphing
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        MainMenu.Show()
    End Sub
    Sub Overallres()
        Chart2.Hide()
        Dim ds As New DataSet
        '1*
        Chart1.ChartAreas("ChartArea1").AxisX.Title = "Categories of events"
        Chart1.ChartAreas("ChartArea1").AxisY.Title = "Points scored"
        '2*
        For x = 0 To 3
            If x = 0 Then
                SQL = "SELECT entHouse.House, Sum(entResult.Points) AS SumOfPoints, entGenders.Gender, entAgeGroups.AgeGroup FROM entEventTypes, (entHouse INNER JOIN (entGenders INNER JOIN (entAgeGroups INNER JOIN entStudents ON entAgeGroups.ID = entStudents.AgeGroup) ON entGenders.ID = entStudents.Gender) ON entHouse.ID = entStudents.House) INNER JOIN (entParticipants INNER JOIN entResult ON entParticipants.ID = entResult.ParticipantID) ON entStudents.ID = entParticipants.StudentID GROUP BY entHouse.House, entGenders.Gender, entAgeGroups.AgeGroup HAVING (((entGenders.Gender)=" & "'Male'" & ") AND ((entAgeGroups.AgeGroup)=" & "'Junior'" & ")) ORDER BY Sum(entResult.Points);"
            ElseIf x = 1 Then
                SQL = "SELECT entHouse.House, Sum(entResult.Points) AS SumOfPoints, entGenders.Gender, entAgeGroups.AgeGroup FROM entEventTypes, (entHouse INNER JOIN (entGenders INNER JOIN (entAgeGroups INNER JOIN entStudents ON entAgeGroups.ID = entStudents.AgeGroup) ON entGenders.ID = entStudents.Gender) ON entHouse.ID = entStudents.House) INNER JOIN (entParticipants INNER JOIN entResult ON entParticipants.ID = entResult.ParticipantID) ON entStudents.ID = entParticipants.StudentID GROUP BY entHouse.House, entGenders.Gender, entAgeGroups.AgeGroup HAVING (((entGenders.Gender)=" & "'Male'" & ") AND ((entAgeGroups.AgeGroup)=" & "'Intermediate'" & ")) ORDER BY Sum(entResult.Points);"
            ElseIf x = 2 Then
                SQL = "SELECT entHouse.House, Sum(entResult.Points) AS SumOfPoints, entGenders.Gender, entAgeGroups.AgeGroup FROM entEventTypes, (entHouse INNER JOIN (entGenders INNER JOIN (entAgeGroups INNER JOIN entStudents ON entAgeGroups.ID = entStudents.AgeGroup) ON entGenders.ID = entStudents.Gender) ON entHouse.ID = entStudents.House) INNER JOIN (entParticipants INNER JOIN entResult ON entParticipants.ID = entResult.ParticipantID) ON entStudents.ID = entParticipants.StudentID GROUP BY entHouse.House, entGenders.Gender, entAgeGroups.AgeGroup HAVING (((entGenders.Gender)=" & "'Female'" & ") AND ((entAgeGroups.AgeGroup)='Junior'" & ")) ORDER BY Sum(entResult.Points);"
            ElseIf x = 3 Then
                SQL = "SELECT entHouse.House, Sum(entResult.Points) AS SumOfPoints, entGenders.Gender, entAgeGroups.AgeGroup FROM entEventTypes, (entHouse INNER JOIN (entGenders INNER JOIN (entAgeGroups INNER JOIN entStudents ON entAgeGroups.ID = entStudents.AgeGroup) ON entGenders.ID = entStudents.Gender) ON entHouse.ID = entStudents.House) INNER JOIN (entParticipants INNER JOIN entResult ON entParticipants.ID = entResult.ParticipantID) ON entStudents.ID = entParticipants.StudentID GROUP BY entHouse.House, entGenders.Gender, entAgeGroups.AgeGroup HAVING (((entGenders.Gender)=" & "'Female'" & ") AND ((entAgeGroups.AgeGroup)='Intermediate')) ORDER BY Sum(entResult.Points);"
            End If
            ds = cntDatabase(SQL, "graph")
            For i = 0 To 3
                Chart1.Series(ds.Tables("graph").Rows(i).Item(0).ToString).Points.AddXY(ds.Tables("graph").Rows(i).Item(2).ToString & " " & ds.Tables("graph").Rows(i).Item(3).ToString, ds.Tables("graph").Rows(i).Item(1))
            Next
        Next
        '2*
    End Sub

    Private Sub lbLogout_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbLogout.LinkClicked
        Me.Hide()
        Form1.Show()
    End Sub
    'Uses the combo box selected index to load the graphs required
    Private Sub cmbGraphselc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGraphselc.SelectedIndexChanged
        For x = 0 To 3
            '1*
            Chart1.Series(x).Points.Clear()
            Chart2.Series(x).Points.Clear()
        Next
        Dim house As String
        If cmbGraphselc.SelectedIndex > 0 Then
            Me.Size = New Size(714, 699)
        End If
        If cmbGraphselc.SelectedIndex = 0 Then
            Me.Size = New Size(714, 394)
            Overallres()
        ElseIf cmbGraphselc.SelectedIndex = 1 Then
            house = "Flamsteed"
            Housegraph(house)
        ElseIf cmbGraphselc.SelectedIndex = 2 Then
            house = "Chantrey"
            Housegraph(house)
        ElseIf cmbGraphselc.SelectedIndex = 3 Then
            house = "Nightingale"
            Housegraph(house)
        ElseIf cmbGraphselc.SelectedIndex = 4 Then
            house = "Brindley"
            Housegraph(house)
        End If
    End Sub
    'This sub takes an input of the cmb index sub and uses it as an input into the
    Sub Housegraph(ByVal house)
        Chart2.Show()
        Dim ds, ds1 As New DataSet
        '2*
        SQL = "SELECT Sum(entResult.Points) AS SumOfPoints, entGenders.Gender, entAgeGroups.AgeGroup, entEventTypes.EventType FROM entEventTypes, (entHouse INNER JOIN (entGenders INNER JOIN (entAgeGroups INNER JOIN entStudents ON entAgeGroups.ID = entStudents.AgeGroup) ON entGenders.ID = entStudents.Gender) ON entHouse.ID = entStudents.House) INNER JOIN (entParticipants INNER JOIN entResult ON entParticipants.ID = entResult.ParticipantID) ON entStudents.ID = entParticipants.StudentID GROUP BY entHouse.House, entGenders.Gender, entAgeGroups.AgeGroup, entEventTypes.EventType HAVING (((entHouse.House)='" & house & "') AND ((entEventTypes.EventType)='Field'));"
        ds = cntDatabase(SQL, house)
        '2*
        SQL = "SELECT Sum(entResult.Points) AS SumOfPoints, entGenders.Gender, entAgeGroups.AgeGroup, entEventTypes.EventType FROM entEventTypes INNER JOIN (((entHouse INNER JOIN (entGenders INNER JOIN (entAgeGroups INNER JOIN entStudents ON entAgeGroups.ID = entStudents.AgeGroup) ON entGenders.ID = entStudents.Gender) ON entHouse.ID = entStudents.House) INNER JOIN (entParticipants INNER JOIN entResult ON entParticipants.ID = entResult.ParticipantID) ON entStudents.ID = entParticipants.StudentID) INNER JOIN entEvents ON (entGenders.ID = entEvents.Gender) AND (entEvents.ID = entParticipants.EventID) AND (entAgeGroups.ID = entEvents.AgeGroup)) ON entEventTypes.ID = entEvents.EventType GROUP BY entGenders.Gender, entAgeGroups.AgeGroup, entEventTypes.EventType, entHouse.House HAVING (((entEventTypes.EventType)='Field') AND ((entHouse.House)='" & house & "'));"
        ds1 = cntDatabase(SQL, "track")
        For x = 0 To 3
            '1*
            Chart1.Series(house).Points.AddXY(ds.Tables(house).Rows(x).Item(1).ToString & " " & ds.Tables(house).Rows(x).Item(2).ToString, ds.Tables(house).Rows(x).Item(0))
            Chart2.Series(house).Points.AddXY(ds1.Tables("track").Rows(x).Item(1).ToString & " " & ds1.Tables("track").Rows(x).Item(2).ToString, ds1.Tables("track").Rows(x).Item(0))
        Next
    End Sub
    Private Sub ReportGraphing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Changes the cmb box selected index in order to trigger the code that creates the graph.
        cmbGraphselc.SelectedIndex = 0
    End Sub
End Class