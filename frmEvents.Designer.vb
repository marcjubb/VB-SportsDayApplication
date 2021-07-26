<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEvents
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEvents))
        Me.btnHTML = New System.Windows.Forms.Button()
        Me.btnCSV = New System.Windows.Forms.Button()
        Me.EventsDataset = New System.Windows.Forms.DataGridView()
        Me.btnRemoveEvent = New System.Windows.Forms.Button()
        Me.btnAddevent = New System.Windows.Forms.Button()
        Me.lblBack = New System.Windows.Forms.LinkLabel()
        Me.lbLogout = New System.Windows.Forms.LinkLabel()
        Me.btnUpdateEvent = New System.Windows.Forms.Button()
        Me.cmbAgeGroup = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEventname = New System.Windows.Forms.TextBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.EventsDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHTML
        '
        Me.btnHTML.Location = New System.Drawing.Point(428, 1)
        Me.btnHTML.Name = "btnHTML"
        Me.btnHTML.Size = New System.Drawing.Size(98, 27)
        Me.btnHTML.TabIndex = 31
        Me.btnHTML.Text = "Export to HTML"
        Me.btnHTML.UseVisualStyleBackColor = True
        '
        'btnCSV
        '
        Me.btnCSV.Location = New System.Drawing.Point(329, 1)
        Me.btnCSV.Name = "btnCSV"
        Me.btnCSV.Size = New System.Drawing.Size(93, 27)
        Me.btnCSV.TabIndex = 30
        Me.btnCSV.Text = "Export to Excel"
        Me.btnCSV.UseVisualStyleBackColor = True
        '
        'EventsDataset
        '
        Me.EventsDataset.AllowUserToAddRows = False
        Me.EventsDataset.AllowUserToDeleteRows = False
        Me.EventsDataset.AllowUserToResizeColumns = False
        Me.EventsDataset.AllowUserToResizeRows = False
        Me.EventsDataset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.EventsDataset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EventsDataset.Location = New System.Drawing.Point(12, 77)
        Me.EventsDataset.MultiSelect = False
        Me.EventsDataset.Name = "EventsDataset"
        Me.EventsDataset.ReadOnly = True
        Me.EventsDataset.RowHeadersVisible = False
        Me.EventsDataset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EventsDataset.Size = New System.Drawing.Size(556, 276)
        Me.EventsDataset.TabIndex = 29
        '
        'btnRemoveEvent
        '
        Me.btnRemoveEvent.Location = New System.Drawing.Point(200, 359)
        Me.btnRemoveEvent.Name = "btnRemoveEvent"
        Me.btnRemoveEvent.Size = New System.Drawing.Size(99, 23)
        Me.btnRemoveEvent.TabIndex = 28
        Me.btnRemoveEvent.Text = "Remove Event"
        Me.btnRemoveEvent.UseVisualStyleBackColor = True
        '
        'btnAddevent
        '
        Me.btnAddevent.Location = New System.Drawing.Point(12, 359)
        Me.btnAddevent.Name = "btnAddevent"
        Me.btnAddevent.Size = New System.Drawing.Size(75, 23)
        Me.btnAddevent.TabIndex = 27
        Me.btnAddevent.Text = "Add Event"
        Me.btnAddevent.UseVisualStyleBackColor = True
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.BackColor = System.Drawing.Color.Transparent
        Me.lblBack.Location = New System.Drawing.Point(536, 15)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(32, 13)
        Me.lblBack.TabIndex = 26
        Me.lblBack.TabStop = True
        Me.lblBack.Text = "Back"
        '
        'lbLogout
        '
        Me.lbLogout.AutoSize = True
        Me.lbLogout.BackColor = System.Drawing.Color.Transparent
        Me.lbLogout.Location = New System.Drawing.Point(9, 15)
        Me.lbLogout.Name = "lbLogout"
        Me.lbLogout.Size = New System.Drawing.Size(40, 13)
        Me.lbLogout.TabIndex = 25
        Me.lbLogout.TabStop = True
        Me.lbLogout.Text = "Logout"
        '
        'btnUpdateEvent
        '
        Me.btnUpdateEvent.Location = New System.Drawing.Point(93, 359)
        Me.btnUpdateEvent.Name = "btnUpdateEvent"
        Me.btnUpdateEvent.Size = New System.Drawing.Size(99, 23)
        Me.btnUpdateEvent.TabIndex = 32
        Me.btnUpdateEvent.Text = "Update Event"
        Me.btnUpdateEvent.UseVisualStyleBackColor = True
        '
        'cmbAgeGroup
        '
        Me.cmbAgeGroup.FormattingEnabled = True
        Me.cmbAgeGroup.Items.AddRange(New Object() {"Junior", "Intermediate"})
        Me.cmbAgeGroup.Location = New System.Drawing.Point(244, 51)
        Me.cmbAgeGroup.Name = "cmbAgeGroup"
        Me.cmbAgeGroup.Size = New System.Drawing.Size(127, 21)
        Me.cmbAgeGroup.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(241, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Age Group"
        '
        'cmbGender
        '
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"7", "8", "9", "10"})
        Me.cmbGender.Location = New System.Drawing.Point(120, 51)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(118, 21)
        Me.cmbGender.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(120, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Gender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(9, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Event Name"
        '
        'txtEventname
        '
        Me.txtEventname.Location = New System.Drawing.Point(12, 51)
        Me.txtEventname.Name = "txtEventname"
        Me.txtEventname.Size = New System.Drawing.Size(103, 20)
        Me.txtEventname.TabIndex = 40
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"Junior", "Intermediate"})
        Me.cmbType.Location = New System.Drawing.Point(377, 50)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(127, 21)
        Me.cmbType.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(374, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(60, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Search by"
        '
        'frmEvents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(581, 408)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbAgeGroup)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEventname)
        Me.Controls.Add(Me.btnUpdateEvent)
        Me.Controls.Add(Me.btnHTML)
        Me.Controls.Add(Me.btnCSV)
        Me.Controls.Add(Me.EventsDataset)
        Me.Controls.Add(Me.btnRemoveEvent)
        Me.Controls.Add(Me.btnAddevent)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.lbLogout)
        Me.Name = "frmEvents"
        Me.Text = "frmEvents"
        CType(Me.EventsDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHTML As System.Windows.Forms.Button
    Friend WithEvents btnCSV As System.Windows.Forms.Button
    Friend WithEvents EventsDataset As System.Windows.Forms.DataGridView
    Friend WithEvents btnRemoveEvent As System.Windows.Forms.Button
    Friend WithEvents btnAddevent As System.Windows.Forms.Button
    Friend WithEvents lblBack As System.Windows.Forms.LinkLabel
    Friend WithEvents lbLogout As System.Windows.Forms.LinkLabel
    Friend WithEvents btnUpdateEvent As System.Windows.Forms.Button
    Friend WithEvents cmbAgeGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEventname As System.Windows.Forms.TextBox
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
