Imports System.Text
Imports System.IO
Imports System.Linq
Module Recylcle

    'Most common varriables that have large usage declared here 
    Public con As New OleDb.OleDbConnection
    Public SQL, type, gender, agegroup As String
    Public StartingId, eventID As Integer
    Public searching As Boolean = False
    Public istrack As Boolean
    'This function is called upon when the export buttons are pressed within different forms.
    'It takes in a Datagridview as a ref input that is going to be translated into CSV (comma separated values).
    Sub DGVtoCSV(ByRef dgDataView As DataGridView)
        'Declares the file path which will be the temp folder
        Dim filePath As String = "C:/windows/temp/export.csv"
        Dim spacer As String = ","
        Dim sb As New StringBuilder
        'Builds the csv string which will be saved within export.csv
        For i As Integer = 0 To dgDataView.Rows.Count - 1
            Dim arr As String() = New String(dgDataView.Columns.Count - 1) {}
            If i = 0 Then
                For x As Integer = 0 To dgDataView.Columns.Count - 1
                    arr(x) = dgDataView.Columns(x).HeaderText
                Next
                sb.AppendLine(String.Join(spacer, arr))
            End If
            For x As Integer = 0 To dgDataView.Columns.Count - 1
                If Not dgDataView.Rows(i).IsNewRow Then
                    arr(x) = dgDataView(x, i).Value.ToString
                End If
            Next
            If Not dgDataView.Rows(i).IsNewRow Then
                sb.AppendLine(String.Join(spacer, arr))
            End If
        Next
        File.WriteAllText(filePath, sb.ToString)
        Process.Start(filePath)
    End Sub
    'This subroutine is called when a combo box is needed to be filled with values pulled from a query using SQL.
    'The subroutine takes in the inputs when called upon which makes it adaptably usable throughout my project.
    Sub FillcmbBox(ByVal SQL As String, ByVal entName As String, ByRef cmbBoxes As Array)
        Dim ds As New DataSet
        Dim field As Boolean = True
        ds = cntDatabase(SQL, entName)
        Dim dataRow = ds.Tables(0).NewRow()
        dataRow(0) = 0
        dataRow("Lbl") = "Select " & entName
        ds.Tables(0).Rows.InsertAt(dataRow, 0)
        For Each Box In cmbBoxes
            Box.DataSource = ds.Tables(0)
            Box.DisplayMember = entName
            Box.DisplayMember = "Lbl"
            Dim val = ds.Tables(0).Rows(0).Item(1)
            field = False
            If field Then
                Box.ValueMember = "GenderID"
            End If
        Next
    End Sub
    'This function is in order to simply help build the SQL statements in order for them to run by adjusting the varables to the combobox value
    Function cmbSelected(ByVal cmbValue As Integer, ByRef name As String)
        If cmbValue = 0 Then
            'blank variable is needed as it would search for all outputs.
            name = ""
        Else
            name = cmbValue
        End If
        Return name
    End Function
    'This function is called when having to fill a Dataset with data from a query that is input as a String, naming thats table as the other input
    Function cntDatabase(ByVal SQL As String, ByVal table As String)
        'Builds a connection to the database using OLEDB
        con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = D:\Marcs Coding Project\SportsDayDatabase2.mdb"
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        'Trys to open the connection using the connection string
        Try
            con.Open()
            'if it doesnt connect it shows the error as an exception
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'With the connection running it uses the SQL which is passed through to generate the data and fill the DS with the DA
        da = New OleDb.OleDbDataAdapter(SQL, con)
        da.Fill(ds, table)
        'Closes connection and returns the DS to the original calling of the function
        con.Close()
        Return ds
    End Function
    'This is to calculate each of the houses total score in order to be displayed upon the leaderboard.
    Function Housetotal(ByVal house As Integer) As Integer
        Dim x As Integer
        Dim ds As New DataSet
        'Using Sum(x) As SumOfPoints access adds the points up
        SQL = "SELECT Sum(entResult.Points) AS SumOfPoints FROM (entHouse INNER JOIN entStudents ON entHouse.ID = entStudents.House) INNER JOIN (entParticipants INNER JOIN entResult ON entParticipants.ID = entResult.ParticipantID) ON entStudents.ID = entParticipants.StudentID WHERE (((entStudents.House)=" & house & "));"
        ds = cntDatabase(SQL, "sumofHouse")
        x = ds.Tables(0).Rows(0).Item(0)
        'Returns the total points of the house that was input
        Return x
    End Function
    'This and cntdatabase are the most utilised routines througout this program.
    'The diffrence is that this sub doesnt return a DS and runs the query. 
    'Therefore I run UPDATE, DELETE and INSERT statements with using this routine.
    Sub SQLrun(ByVal SQL As String)
        con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = D:\Marcs Coding Project\SportsDayDatabase2.mdb"
        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim command As New OleDb.OleDbCommand(SQL, con)
        Dim rows = command.ExecuteNonQuery()
        con.Close()
    End Sub
    'This routine is very useful when needing to utilise the value selected in a combobox 
    Sub cmbFill(ByVal SQL As String, ByRef cmbBoxes As Array, ByVal entName As String)
        'pulls a dataset using the cntDatabase routine
        Dim ds As New DataSet
        Dim check As Boolean = True
        ds = cntDatabase(SQL, entName)
        Dim dataRow = ds.Tables(0).NewRow()
        dataRow(0) = 0
        dataRow("Lbl") = "Select " & entName
        ds.Tables(0).Rows.InsertAt(dataRow, 0)
        For Each box In cmbBoxes
            box.DataSource = ds.Tables(0)
            box.DisplayMember = entName
            box.DisplayMember = "Lbl"
            Try
                Dim val = ds.Tables(0).Rows(0).Item(1)
            Catch ex As Exception
                check = False
            End Try
            If check Then
                box.ValueMember = "ID"
            End If
        Next
    End Sub
    'Whilst I use Datagridviews many times within my project I have this sub to export to HTML. 
    Sub DGVtoHTML(ByRef dgDataView As DataGridView)
        Try
            Dim html As String = "<table border=1 cellspacing=0 cellpadding=0 width=""100%"">" + vbNewLine
            html += vbTab + "<tr>" + vbNewLine
            For Each col As DataGridViewColumn In dgDataView.Columns
                html += vbTab + vbTab + String.Format("<td bgcolor={0} align=center>&nbsp;{1}</td>", Color.White.Name, col.HeaderText) + vbNewLine
            Next
            html += vbTab + "</tr>" + vbNewLine
            For Each row As DataGridViewRow In dgDataView.Rows
                html += vbTab + "<tr>" + vbNewLine
                For Each cel As DataGridViewCell In row.Cells
                    html += vbTab + vbTab + String.Format("<td bgcolor={0}>&nbsp;{1}</td>", Color.Azure.Name, cel.Value) + vbNewLine
                Next
                html += vbTab + "</tr>" + vbNewLine
            Next
            html += "</table>"
            Dim fs As New IO.FileStream("C:/windows/temp/test.html", IO.FileMode.Create)
            Dim sw As New IO.StreamWriter(fs)
            sw.Write(html)
            sw.Close()
            fs.Close()
            'Runs the HTML using Word.
            Process.Start("winword.exe", "--new-window file:///C:/windows/temp/test.html")
            'Process.Start("chrome.exe", "--new-window file:///C:/windows/temp/test.html")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub colourDGV(ByVal dvg As DataGridView, ByVal index As Integer)
        For x = 0 To dvg.RowCount - 1
            If dvg.Rows(x).Cells(index).Value.ToString = "Nightingale" Then
                dvg.Rows(x).DefaultCellStyle.BackColor = Color.Red
            ElseIf dvg.Rows(x).Cells(index).Value.ToString = "Chantrey" Then
                dvg.Rows(x).DefaultCellStyle.BackColor = Color.Yellow
            ElseIf dvg.Rows(x).Cells(index).Value = "Flamsteed" Then
                dvg.Rows(x).DefaultCellStyle.BackColor = Color.Blue
            ElseIf dvg.Rows(x).Cells(index).Value.ToString = "Brindley" Then
                dvg.Rows(x).DefaultCellStyle.BackColor = Color.Green
            End If
        Next
    End Sub
End Module
