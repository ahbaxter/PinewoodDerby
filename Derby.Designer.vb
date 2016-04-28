<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Derby
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tabBehavior = New System.Windows.Forms.TabControl()
        Me.pageRegister = New System.Windows.Forms.TabPage()
        Me.lblRegisterHistory = New System.Windows.Forms.Label()
        Me.txtRegisterHistory = New System.Windows.Forms.TextBox()
        Me.btnRegisterAdd = New System.Windows.Forms.Button()
        Me.txtRegisterNumber = New System.Windows.Forms.TextBox()
        Me.lblRegisterNumber = New System.Windows.Forms.Label()
        Me.txtRegisterName = New System.Windows.Forms.TextBox()
        Me.lblRegisterName = New System.Windows.Forms.Label()
        Me.pageGenerate = New System.Windows.Forms.TabPage()
        Me.lblGenLane4 = New System.Windows.Forms.Label()
        Me.lblGenLane3 = New System.Windows.Forms.Label()
        Me.lblGenLane2 = New System.Windows.Forms.Label()
        Me.lblGenLane1 = New System.Windows.Forms.Label()
        Me.txtGenLane4 = New System.Windows.Forms.TextBox()
        Me.txtGenLane3 = New System.Windows.Forms.TextBox()
        Me.txtGenLane2 = New System.Windows.Forms.TextBox()
        Me.txtGenLane1 = New System.Windows.Forms.TextBox()
        Me.prgGenerate = New System.Windows.Forms.ProgressBar()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.pageRace = New System.Windows.Forms.TabPage()
        Me.grpRacesHole = New System.Windows.Forms.GroupBox()
        Me.lblInTheHole = New System.Windows.Forms.Label()
        Me.grpRacesNow = New System.Windows.Forms.GroupBox()
        Me.btnLoadRace = New System.Windows.Forms.Button()
        Me.cmbSelectedPort = New System.Windows.Forms.ComboBox()
        Me.prgRace = New System.Windows.Forms.ProgressBar()
        Me.btnRacesNext = New System.Windows.Forms.Button()
        Me.gridRacesCurrent = New System.Windows.Forms.DataGridView()
        Me.Lane = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RacerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeToFinish = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRacePort = New System.Windows.Forms.Label()
        Me.grpRacesUpNext = New System.Windows.Forms.GroupBox()
        Me.lblUpNext = New System.Windows.Forms.Label()
        Me.pageResults = New System.Windows.Forms.TabPage()
        Me.com = New System.IO.Ports.SerialPort(Me.components)
        Me.tabBehavior.SuspendLayout()
        Me.pageRegister.SuspendLayout()
        Me.pageGenerate.SuspendLayout()
        Me.pageRace.SuspendLayout()
        Me.grpRacesHole.SuspendLayout()
        Me.grpRacesNow.SuspendLayout()
        CType(Me.gridRacesCurrent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRacesUpNext.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabBehavior
        '
        Me.tabBehavior.Controls.Add(Me.pageRegister)
        Me.tabBehavior.Controls.Add(Me.pageGenerate)
        Me.tabBehavior.Controls.Add(Me.pageRace)
        Me.tabBehavior.Controls.Add(Me.pageResults)
        Me.tabBehavior.Location = New System.Drawing.Point(12, 12)
        Me.tabBehavior.Multiline = True
        Me.tabBehavior.Name = "tabBehavior"
        Me.tabBehavior.SelectedIndex = 0
        Me.tabBehavior.Size = New System.Drawing.Size(680, 417)
        Me.tabBehavior.TabIndex = 0
        '
        'pageRegister
        '
        Me.pageRegister.AllowDrop = True
        Me.pageRegister.Controls.Add(Me.lblRegisterHistory)
        Me.pageRegister.Controls.Add(Me.txtRegisterHistory)
        Me.pageRegister.Controls.Add(Me.btnRegisterAdd)
        Me.pageRegister.Controls.Add(Me.txtRegisterNumber)
        Me.pageRegister.Controls.Add(Me.lblRegisterNumber)
        Me.pageRegister.Controls.Add(Me.txtRegisterName)
        Me.pageRegister.Controls.Add(Me.lblRegisterName)
        Me.pageRegister.Location = New System.Drawing.Point(4, 22)
        Me.pageRegister.Name = "pageRegister"
        Me.pageRegister.Padding = New System.Windows.Forms.Padding(3)
        Me.pageRegister.Size = New System.Drawing.Size(672, 391)
        Me.pageRegister.TabIndex = 0
        Me.pageRegister.Text = "Register Cars"
        Me.pageRegister.UseVisualStyleBackColor = True
        '
        'lblRegisterHistory
        '
        Me.lblRegisterHistory.AutoSize = True
        Me.lblRegisterHistory.Location = New System.Drawing.Point(21, 86)
        Me.lblRegisterHistory.Name = "lblRegisterHistory"
        Me.lblRegisterHistory.Size = New System.Drawing.Size(42, 13)
        Me.lblRegisterHistory.TabIndex = 7
        Me.lblRegisterHistory.Text = "History:"
        '
        'txtRegisterHistory
        '
        Me.txtRegisterHistory.Location = New System.Drawing.Point(23, 104)
        Me.txtRegisterHistory.Multiline = True
        Me.txtRegisterHistory.Name = "txtRegisterHistory"
        Me.txtRegisterHistory.ReadOnly = True
        Me.txtRegisterHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRegisterHistory.Size = New System.Drawing.Size(627, 267)
        Me.txtRegisterHistory.TabIndex = 6
        '
        'btnRegisterAdd
        '
        Me.btnRegisterAdd.Location = New System.Drawing.Point(220, 20)
        Me.btnRegisterAdd.Name = "btnRegisterAdd"
        Me.btnRegisterAdd.Size = New System.Drawing.Size(65, 52)
        Me.btnRegisterAdd.TabIndex = 5
        Me.btnRegisterAdd.Text = "Add"
        Me.btnRegisterAdd.UseVisualStyleBackColor = True
        '
        'txtRegisterNumber
        '
        Me.txtRegisterNumber.AcceptsReturn = True
        Me.txtRegisterNumber.Location = New System.Drawing.Point(74, 20)
        Me.txtRegisterNumber.Name = "txtRegisterNumber"
        Me.txtRegisterNumber.Size = New System.Drawing.Size(140, 20)
        Me.txtRegisterNumber.TabIndex = 2
        Me.txtRegisterNumber.Text = "1"
        '
        'lblRegisterNumber
        '
        Me.lblRegisterNumber.AutoSize = True
        Me.lblRegisterNumber.Location = New System.Drawing.Point(21, 23)
        Me.lblRegisterNumber.Name = "lblRegisterNumber"
        Me.lblRegisterNumber.Size = New System.Drawing.Size(47, 13)
        Me.lblRegisterNumber.TabIndex = 1
        Me.lblRegisterNumber.Text = "Number:"
        '
        'txtRegisterName
        '
        Me.txtRegisterName.AcceptsReturn = True
        Me.txtRegisterName.Location = New System.Drawing.Point(74, 52)
        Me.txtRegisterName.Name = "txtRegisterName"
        Me.txtRegisterName.Size = New System.Drawing.Size(140, 20)
        Me.txtRegisterName.TabIndex = 4
        '
        'lblRegisterName
        '
        Me.lblRegisterName.AutoSize = True
        Me.lblRegisterName.Location = New System.Drawing.Point(21, 55)
        Me.lblRegisterName.Name = "lblRegisterName"
        Me.lblRegisterName.Size = New System.Drawing.Size(38, 13)
        Me.lblRegisterName.TabIndex = 3
        Me.lblRegisterName.Text = "Name:"
        '
        'pageGenerate
        '
        Me.pageGenerate.Controls.Add(Me.lblGenLane4)
        Me.pageGenerate.Controls.Add(Me.lblGenLane3)
        Me.pageGenerate.Controls.Add(Me.lblGenLane2)
        Me.pageGenerate.Controls.Add(Me.lblGenLane1)
        Me.pageGenerate.Controls.Add(Me.txtGenLane4)
        Me.pageGenerate.Controls.Add(Me.txtGenLane3)
        Me.pageGenerate.Controls.Add(Me.txtGenLane2)
        Me.pageGenerate.Controls.Add(Me.txtGenLane1)
        Me.pageGenerate.Controls.Add(Me.prgGenerate)
        Me.pageGenerate.Controls.Add(Me.btnGenerate)
        Me.pageGenerate.Location = New System.Drawing.Point(4, 22)
        Me.pageGenerate.Name = "pageGenerate"
        Me.pageGenerate.Padding = New System.Windows.Forms.Padding(3)
        Me.pageGenerate.Size = New System.Drawing.Size(672, 391)
        Me.pageGenerate.TabIndex = 1
        Me.pageGenerate.Text = "Generate Races"
        Me.pageGenerate.UseVisualStyleBackColor = True
        '
        'lblGenLane4
        '
        Me.lblGenLane4.AutoSize = True
        Me.lblGenLane4.Location = New System.Drawing.Point(506, 66)
        Me.lblGenLane4.Name = "lblGenLane4"
        Me.lblGenLane4.Size = New System.Drawing.Size(43, 13)
        Me.lblGenLane4.TabIndex = 10
        Me.lblGenLane4.Text = "Lane 4:"
        '
        'lblGenLane3
        '
        Me.lblGenLane3.AutoSize = True
        Me.lblGenLane3.Location = New System.Drawing.Point(342, 66)
        Me.lblGenLane3.Name = "lblGenLane3"
        Me.lblGenLane3.Size = New System.Drawing.Size(43, 13)
        Me.lblGenLane3.TabIndex = 9
        Me.lblGenLane3.Text = "Lane 3:"
        '
        'lblGenLane2
        '
        Me.lblGenLane2.AutoSize = True
        Me.lblGenLane2.Location = New System.Drawing.Point(176, 66)
        Me.lblGenLane2.Name = "lblGenLane2"
        Me.lblGenLane2.Size = New System.Drawing.Size(43, 13)
        Me.lblGenLane2.TabIndex = 8
        Me.lblGenLane2.Text = "Lane 2:"
        '
        'lblGenLane1
        '
        Me.lblGenLane1.AutoSize = True
        Me.lblGenLane1.Location = New System.Drawing.Point(6, 66)
        Me.lblGenLane1.Name = "lblGenLane1"
        Me.lblGenLane1.Size = New System.Drawing.Size(43, 13)
        Me.lblGenLane1.TabIndex = 7
        Me.lblGenLane1.Text = "Lane 1:"
        '
        'txtGenLane4
        '
        Me.txtGenLane4.Location = New System.Drawing.Point(506, 82)
        Me.txtGenLane4.Multiline = True
        Me.txtGenLane4.Name = "txtGenLane4"
        Me.txtGenLane4.ReadOnly = True
        Me.txtGenLane4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGenLane4.Size = New System.Drawing.Size(160, 303)
        Me.txtGenLane4.TabIndex = 6
        '
        'txtGenLane3
        '
        Me.txtGenLane3.Location = New System.Drawing.Point(341, 82)
        Me.txtGenLane3.Multiline = True
        Me.txtGenLane3.Name = "txtGenLane3"
        Me.txtGenLane3.ReadOnly = True
        Me.txtGenLane3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGenLane3.Size = New System.Drawing.Size(160, 303)
        Me.txtGenLane3.TabIndex = 5
        '
        'txtGenLane2
        '
        Me.txtGenLane2.Location = New System.Drawing.Point(175, 82)
        Me.txtGenLane2.Multiline = True
        Me.txtGenLane2.Name = "txtGenLane2"
        Me.txtGenLane2.ReadOnly = True
        Me.txtGenLane2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGenLane2.Size = New System.Drawing.Size(160, 303)
        Me.txtGenLane2.TabIndex = 4
        '
        'txtGenLane1
        '
        Me.txtGenLane1.Location = New System.Drawing.Point(9, 82)
        Me.txtGenLane1.Multiline = True
        Me.txtGenLane1.Name = "txtGenLane1"
        Me.txtGenLane1.ReadOnly = True
        Me.txtGenLane1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGenLane1.Size = New System.Drawing.Size(160, 303)
        Me.txtGenLane1.TabIndex = 3
        '
        'prgGenerate
        '
        Me.prgGenerate.Location = New System.Drawing.Point(106, 15)
        Me.prgGenerate.Name = "prgGenerate"
        Me.prgGenerate.Size = New System.Drawing.Size(560, 32)
        Me.prgGenerate.TabIndex = 2
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(9, 15)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(91, 32)
        Me.btnGenerate.TabIndex = 1
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'pageRace
        '
        Me.pageRace.Controls.Add(Me.grpRacesHole)
        Me.pageRace.Controls.Add(Me.grpRacesNow)
        Me.pageRace.Controls.Add(Me.grpRacesUpNext)
        Me.pageRace.Location = New System.Drawing.Point(4, 22)
        Me.pageRace.Name = "pageRace"
        Me.pageRace.Padding = New System.Windows.Forms.Padding(3)
        Me.pageRace.Size = New System.Drawing.Size(672, 391)
        Me.pageRace.TabIndex = 2
        Me.pageRace.Text = "Run Races"
        Me.pageRace.UseVisualStyleBackColor = True
        '
        'grpRacesHole
        '
        Me.grpRacesHole.Controls.Add(Me.lblInTheHole)
        Me.grpRacesHole.Location = New System.Drawing.Point(342, 289)
        Me.grpRacesHole.Name = "grpRacesHole"
        Me.grpRacesHole.Size = New System.Drawing.Size(324, 96)
        Me.grpRacesHole.TabIndex = 2
        Me.grpRacesHole.TabStop = False
        Me.grpRacesHole.Text = "In The Hole:"
        '
        'lblInTheHole
        '
        Me.lblInTheHole.Location = New System.Drawing.Point(6, 16)
        Me.lblInTheHole.Name = "lblInTheHole"
        Me.lblInTheHole.Size = New System.Drawing.Size(312, 77)
        Me.lblInTheHole.TabIndex = 0
        '
        'grpRacesNow
        '
        Me.grpRacesNow.Controls.Add(Me.btnLoadRace)
        Me.grpRacesNow.Controls.Add(Me.cmbSelectedPort)
        Me.grpRacesNow.Controls.Add(Me.prgRace)
        Me.grpRacesNow.Controls.Add(Me.btnRacesNext)
        Me.grpRacesNow.Controls.Add(Me.gridRacesCurrent)
        Me.grpRacesNow.Controls.Add(Me.Label1)
        Me.grpRacesNow.Controls.Add(Me.lblRacePort)
        Me.grpRacesNow.Location = New System.Drawing.Point(3, 6)
        Me.grpRacesNow.Name = "grpRacesNow"
        Me.grpRacesNow.Size = New System.Drawing.Size(663, 277)
        Me.grpRacesNow.TabIndex = 0
        Me.grpRacesNow.TabStop = False
        Me.grpRacesNow.Text = "Current Race:"
        '
        'btnLoadRace
        '
        Me.btnLoadRace.Location = New System.Drawing.Point(81, 238)
        Me.btnLoadRace.Name = "btnLoadRace"
        Me.btnLoadRace.Size = New System.Drawing.Size(70, 35)
        Me.btnLoadRace.TabIndex = 12
        Me.btnLoadRace.Text = "Load Race"
        Me.btnLoadRace.UseVisualStyleBackColor = True
        '
        'cmbSelectedPort
        '
        Me.cmbSelectedPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelectedPort.FormattingEnabled = True
        Me.cmbSelectedPort.Location = New System.Drawing.Point(571, 250)
        Me.cmbSelectedPort.Name = "cmbSelectedPort"
        Me.cmbSelectedPort.Size = New System.Drawing.Size(86, 21)
        Me.cmbSelectedPort.TabIndex = 7
        '
        'prgRace
        '
        Me.prgRace.Location = New System.Drawing.Point(157, 238)
        Me.prgRace.MarqueeAnimationSpeed = 1
        Me.prgRace.Name = "prgRace"
        Me.prgRace.Size = New System.Drawing.Size(408, 33)
        Me.prgRace.TabIndex = 11
        '
        'btnRacesNext
        '
        Me.btnRacesNext.Location = New System.Drawing.Point(6, 238)
        Me.btnRacesNext.Name = "btnRacesNext"
        Me.btnRacesNext.Size = New System.Drawing.Size(69, 35)
        Me.btnRacesNext.TabIndex = 10
        Me.btnRacesNext.Text = "Next Race"
        Me.btnRacesNext.UseVisualStyleBackColor = True
        '
        'gridRacesCurrent
        '
        Me.gridRacesCurrent.AllowUserToResizeColumns = False
        Me.gridRacesCurrent.AllowUserToResizeRows = False
        Me.gridRacesCurrent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridRacesCurrent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Lane, Me.RacerName, Me.TimeToFinish})
        Me.gridRacesCurrent.Dock = System.Windows.Forms.DockStyle.Top
        Me.gridRacesCurrent.Location = New System.Drawing.Point(3, 16)
        Me.gridRacesCurrent.MinimumSize = New System.Drawing.Size(0, 216)
        Me.gridRacesCurrent.Name = "gridRacesCurrent"
        Me.gridRacesCurrent.ReadOnly = True
        Me.gridRacesCurrent.Size = New System.Drawing.Size(657, 216)
        Me.gridRacesCurrent.TabIndex = 9
        '
        'Lane
        '
        Me.Lane.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Lane.HeaderText = "Lane"
        Me.Lane.Name = "Lane"
        Me.Lane.ReadOnly = True
        Me.Lane.Width = 56
        '
        'RacerName
        '
        Me.RacerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RacerName.HeaderText = "Racer Name"
        Me.RacerName.Name = "RacerName"
        Me.RacerName.ReadOnly = True
        '
        'TimeToFinish
        '
        Me.TimeToFinish.HeaderText = "Time to Finish"
        Me.TimeToFinish.Name = "TimeToFinish"
        Me.TimeToFinish.ReadOnly = True
        Me.TimeToFinish.Width = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        '
        'lblRacePort
        '
        Me.lblRacePort.AutoSize = True
        Me.lblRacePort.Location = New System.Drawing.Point(568, 234)
        Me.lblRacePort.Name = "lblRacePort"
        Me.lblRacePort.Size = New System.Drawing.Size(89, 13)
        Me.lblRacePort.TabIndex = 6
        Me.lblRacePort.Text = "Listening on Port:"
        '
        'grpRacesUpNext
        '
        Me.grpRacesUpNext.Controls.Add(Me.lblUpNext)
        Me.grpRacesUpNext.Location = New System.Drawing.Point(7, 289)
        Me.grpRacesUpNext.Name = "grpRacesUpNext"
        Me.grpRacesUpNext.Size = New System.Drawing.Size(329, 96)
        Me.grpRacesUpNext.TabIndex = 1
        Me.grpRacesUpNext.TabStop = False
        Me.grpRacesUpNext.Text = "Up Next:"
        '
        'lblUpNext
        '
        Me.lblUpNext.Location = New System.Drawing.Point(6, 16)
        Me.lblUpNext.Name = "lblUpNext"
        Me.lblUpNext.Size = New System.Drawing.Size(317, 77)
        Me.lblUpNext.TabIndex = 0
        '
        'pageResults
        '
        Me.pageResults.Location = New System.Drawing.Point(4, 22)
        Me.pageResults.Name = "pageResults"
        Me.pageResults.Padding = New System.Windows.Forms.Padding(3)
        Me.pageResults.Size = New System.Drawing.Size(672, 391)
        Me.pageResults.TabIndex = 3
        Me.pageResults.Text = "Results"
        Me.pageResults.UseVisualStyleBackColor = True
        '
        'Derby
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 441)
        Me.Controls.Add(Me.tabBehavior)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Name = "Derby"
        Me.Text = "Derby"
        Me.tabBehavior.ResumeLayout(False)
        Me.pageRegister.ResumeLayout(False)
        Me.pageRegister.PerformLayout()
        Me.pageGenerate.ResumeLayout(False)
        Me.pageGenerate.PerformLayout()
        Me.pageRace.ResumeLayout(False)
        Me.grpRacesHole.ResumeLayout(False)
        Me.grpRacesNow.ResumeLayout(False)
        Me.grpRacesNow.PerformLayout()
        CType(Me.gridRacesCurrent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRacesUpNext.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabBehavior As TabControl
    Friend WithEvents pageGenerate As TabPage
    Friend WithEvents pageRace As TabPage
    Friend WithEvents pageResults As TabPage
    Friend WithEvents pageRegister As TabPage
    Friend WithEvents txtRegisterNumber As TextBox
    Friend WithEvents lblRegisterNumber As Label
    Friend WithEvents txtRegisterName As TextBox
    Friend WithEvents lblRegisterName As Label
    Friend WithEvents btnRegisterAdd As Button
    Friend WithEvents lblRegisterHistory As Label
    Friend WithEvents txtRegisterHistory As TextBox
    Friend WithEvents grpRacesNow As GroupBox
    Friend WithEvents lblRacePort As Label
    Friend WithEvents grpRacesUpNext As GroupBox
    Friend WithEvents grpRacesHole As GroupBox
    Friend WithEvents gridRacesCurrent As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRacesNext As Button
    Friend WithEvents lblInTheHole As Label
    Friend WithEvents prgRace As ProgressBar
    Friend WithEvents lblUpNext As Label
    Friend WithEvents Lane As DataGridViewTextBoxColumn
    Friend WithEvents RacerName As DataGridViewTextBoxColumn
    Friend WithEvents TimeToFinish As DataGridViewTextBoxColumn
    Friend WithEvents txtGenLane4 As TextBox
    Friend WithEvents txtGenLane3 As TextBox
    Friend WithEvents txtGenLane2 As TextBox
    Friend WithEvents txtGenLane1 As TextBox
    Friend WithEvents prgGenerate As ProgressBar
    Friend WithEvents btnGenerate As Button
    Friend WithEvents lblGenLane4 As Label
    Friend WithEvents lblGenLane3 As Label
    Friend WithEvents lblGenLane2 As Label
    Friend WithEvents lblGenLane1 As Label
    Friend WithEvents cmbSelectedPort As ComboBox
    Friend WithEvents btnLoadRace As Button
    Friend WithEvents com As IO.Ports.SerialPort
End Class
