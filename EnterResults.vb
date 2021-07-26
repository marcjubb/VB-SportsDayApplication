Public Class EnterResults
    Private Sub lblBack_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblBack.LinkClicked
        Me.Hide()
        ResultSelectEvent.Show()
    End Sub
    Private Sub lbLogout_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbLogout.LinkClicked
        Me.Hide()
        Form1.Show()
    End Sub
    Sub UpdateDG()
        Dim ds As New DataSet
        If istrack Then
            SQL = "SELECT entResult.ParticipantID, entStudents.Firstname, entStudents.Surname, entResult.FinalResult, entResult.Points FROM entStudents INNER JOIN (entParticipants INNER JOIN entResult ON entParticipants.ID = entResult.ParticipantID) ON entStudents.ID = entParticipants.StudentID WHERE (((entParticipants.EventID)=" & eventID & "));"
        Else
            SQL = "SELECT entFieldAttempts.ParticipantID, entStudents.Firstname, entStudents.Surname, entResult.FinalResult, entFieldAttempts.Attempt1, entFieldAttempts.Attempt2, entFieldAttempts.Attempt3, entResult.Points FROM entStudents INNER JOIN ((entParticipants INNER JOIN entResult ON entParticipants.ID = entResult.ParticipantID) INNER JOIN entFieldAttempts ON entParticipants.ID = entFieldAttempts.ParticipantID) ON entStudents.ID = entParticipants.StudentID WHERE (((entParticipants.EventID)=" & eventID & "));"
        End If
        ds = cntDatabase(SQL, "entResults")
        participantDataset.DataSource = ds
        participantDataset.DataMember = "entResults"
        participantDataset.Columns(3).DefaultCellStyle.Format = "0.00"
    End Sub
    Private Sub EnterResults_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.VisibleChanged
        UpdateDG()
        If istrack Then
            participantDataset.Columns(0).ReadOnly = True
            participantDataset.Columns(1).ReadOnly = True
            participantDataset.Columns(2).ReadOnly = True
            participantDataset.Columns(3).ReadOnly = False
            participantDataset.Columns(4).ReadOnly = True
        Else
            participantDataset.Columns(0).ReadOnly = True
            participantDataset.Columns(1).ReadOnly = True
            participantDataset.Columns(2).ReadOnly = True
            participantDataset.Columns(3).ReadOnly = True
            participantDataset.Columns(4).ReadOnly = False
            participantDataset.Columns(5).ReadOnly = False
            participantDataset.Columns(6).ReadOnly = False
            participantDataset.Columns(7).ReadOnly = True
        End If
    End Sub
    Private Sub Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        StartingId = participantDataset.RowCount - 1
        Dim counter As Integer = 0
        If istrack Then
            For x = 0 To StartingId
                SQL = "UPDATE entResult SET FinalResult = " & participantDataset.Rows(x).Cells(3).Value & " WHERE ParticipantID = " & participantDataset.Rows(x).Cells(0).Value
                SQLrun(SQL)
            Next
        Else
            For x = 0 To StartingId
                SQL = "UPDATE entFieldAttempts SET Attempt1 = " & participantDataset.Rows(x).Cells(4).Value & ", Attempt2 = " & participantDataset.Rows(x).Cells(5).Value & ", Attempt3 = " & participantDataset.Rows(x).Cells(6).Value & " WHERE ParticipantID = " & participantDataset.Rows(x).Cells(0).Value
                SQLrun(SQL)
                SQL = "UPDATE entResult SET FinalResult = " & AttemptCalc(x) & " WHERE ParticipantID = " & participantDataset.Rows(x).Cells(0).Value
                SQLrun(SQL)
            Next
        End If
        UpdateDG()
        If istrack Then
            participantDataset.Sort(participantDataset.Columns(3), System.ComponentModel.ListSortDirection.Ascending)

        Else
            participantDataset.Sort(participantDataset.Columns(3), System.ComponentModel.ListSortDirection.Descending)

        End If

        For x = 0 To StartingId
            SQL = "UPDATE entResult SET Points = " & (8 - x) & " WHERE ParticipantID = " & participantDataset.Rows(x).Cells(0).Value
            SQLrun(SQL)
        Next
        UpdateDG()
    End Sub
    Function AttemptCalc(ByVal x)
        Dim c As Integer
        If participantDataset.Rows(x).Cells(4).Value > participantDataset.Rows(x).Cells(5).Value And participantDataset.Rows(x).Cells(4).Value > participantDataset.Rows(x).Cells(6).Value Then
            c = participantDataset.Rows(x).Cells(4).Value
        ElseIf participantDataset.Rows(x).Cells(5).Value > participantDataset.Rows(x).Cells(4).Value And participantDataset.Rows(x).Cells(5).Value > participantDataset.Rows(x).Cells(6).Value Then
            c = participantDataset.Rows(x).Cells(5).Value
        Else
            c = participantDataset.Rows(x).Cells(6).Value
        End If
        Return c
    End Function
End Class