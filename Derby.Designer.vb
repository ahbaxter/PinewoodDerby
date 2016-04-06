<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Derby
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
        Me.tabBehavior = New System.Windows.Forms.TabControl()
        Me.pageRegister = New System.Windows.Forms.TabPage()
        Me.lblRegisterHistory = New System.Windows.Forms.Label()
        Me.txtRegisterHistory = New System.Windows.Forms.TextBox()
        Me.btnRegisterAdd = New System.Windows.Forms.Button()
        Me.txtRegisterNumber = New System.Windows.Forms.TextBox()
        Me.lblRegisterNumber = New System.Windows.Forms.Label()
        Me.txtRegisterName = New System.Windows.Forms.TextBox()
        Me.lblRegisterName = New System.Windows.Forms.Label()
        Me.pageTourney = New System.Windows.Forms.TabPage()
        Me.pageRace = New System.Windows.Forms.TabPage()
        Me.grpRacesNow = New System.Windows.Forms.GroupBox()
        Me.dudRacesPort = New System.Windows.Forms.DomainUpDown()
        Me.lblRacePort = New System.Windows.Forms.Label()
        Me.pageResults = New System.Windows.Forms.TabPage()
        Me.grpRacesUpNext = New System.Windows.Forms.GroupBox()
        Me.grpRacesHole = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gridRacesCurrent = New System.Windows.Forms.DataGridView()
        Me.Lane = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Racer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeToFinish = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRacesNext = New System.Windows.Forms.Button()
        Me.tabBehavior.SuspendLayout()
        Me.pageRegister.SuspendLayout()
        Me.pageRace.SuspendLayout()
        Me.grpRacesNow.SuspendLayout()
        CType(Me.gridRacesCurrent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabBehavior
        '
        Me.tabBehavior.Controls.Add(Me.pageRegister)
        Me.tabBehavior.Controls.Add(Me.pageTourney)
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
        Me.txtRegisterNumber.Location = New System.Drawing.Point(74, 20)
        Me.txtRegisterNumber.Name = "txtRegisterNumber"
        Me.txtRegisterNumber.Size = New System.Drawing.Size(140, 20)
        Me.txtRegisterNumber.TabIndex = 2
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
        'pageTourney
        '
        Me.pageTourney.Location = New System.Drawing.Point(4, 22)
        Me.pageTourney.Name = "pageTourney"
        Me.pageTourney.Padding = New System.Windows.Forms.Padding(3)
        Me.pageTourney.Size = New System.Drawing.Size(672, 391)
        Me.pageTourney.TabIndex = 1
        Me.pageTourney.Text = "Generate Races"
        Me.pageTourney.UseVisualStyleBackColor = True
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
        'grpRacesNow
        '
        Me.grpRacesNow.Controls.Add(Me.btnRacesNext)
        Me.grpRacesNow.Controls.Add(Me.gridRacesCurrent)
        Me.grpRacesNow.Controls.Add(Me.Label1)
        Me.grpRacesNow.Controls.Add(Me.dudRacesPort)
        Me.grpRacesNow.Controls.Add(Me.lblRacePort)
        Me.grpRacesNow.Location = New System.Drawing.Point(3, 6)
        Me.grpRacesNow.Name = "grpRacesNow"
        Me.grpRacesNow.Size = New System.Drawing.Size(663, 277)
        Me.grpRacesNow.TabIndex = 0
        Me.grpRacesNow.TabStop = False
        Me.grpRacesNow.Text = "Current Race:"
        '
        'dudRacesPort
        '
        Me.dudRacesPort.Location = New System.Drawing.Point(594, 278)
        Me.dudRacesPort.Name = "dudRacesPort"
        Me.dudRacesPort.ReadOnly = True
        Me.dudRacesPort.Size = New System.Drawing.Size(63, 20)
        Me.dudRacesPort.TabIndex = 7
        Me.dudRacesPort.Text = "None"
        '
        'lblRacePort
        '
        Me.lblRacePort.AutoSize = True
        Me.lblRacePort.Location = New System.Drawing.Point(499, 280)
        Me.lblRacePort.Name = "lblRacePort"
        Me.lblRacePort.Size = New System.Drawing.Size(89, 13)
        Me.lblRacePort.TabIndex = 6
        Me.lblRacePort.Text = "Listening on Port:"
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
        'grpRacesUpNext
        '
        Me.grpRacesUpNext.Location = New System.Drawing.Point(7, 289)
        Me.grpRacesUpNext.Name = "grpRacesUpNext"
        Me.grpRacesUpNext.Size = New System.Drawing.Size(329, 96)
        Me.grpRacesUpNext.TabIndex = 1
        Me.grpRacesUpNext.TabStop = False
        Me.grpRacesUpNext.Text = "Up Next:"
        '
        'grpRacesHole
        '
        Me.grpRacesHole.Location = New System.Drawing.Point(342, 289)
        Me.grpRacesHole.Name = "grpRacesHole"
        Me.grpRacesHole.Size = New System.Drawing.Size(324, 96)
        Me.grpRacesHole.TabIndex = 2
        Me.grpRacesHole.TabStop = False
        Me.grpRacesHole.Text = "In The Hole:"
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
        'gridRacesCurrent
        '
        Me.gridRacesCurrent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridRacesCurrent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Lane, Me.Racer, Me.Rank, Me.TimeToFinish})
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
        'Racer
        '
        Me.Racer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Racer.HeaderText = "Racer"
        Me.Racer.Name = "Racer"
        Me.Racer.ReadOnly = True
        '
        'Rank
        '
        Me.Rank.HeaderText = "Rank"
        Me.Rank.Name = "Rank"
        Me.Rank.ReadOnly = True
        '
        'TimeToFinish
        '
        Me.TimeToFinish.HeaderText = "Time to Finish"
        Me.TimeToFinish.Name = "TimeToFinish"
        Me.TimeToFinish.ReadOnly = True
        '
        'btnRacesNext
        '
        Me.btnRacesNext.Location = New System.Drawing.Point(556, 238)
        Me.btnRacesNext.Name = "btnRacesNext"
        Me.btnRacesNext.Size = New System.Drawing.Size(101, 33)
        Me.btnRacesNext.TabIndex = 10
        Me.btnRacesNext.Text = "Next Race"
        Me.btnRacesNext.UseVisualStyleBackColor = True
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
        Me.pageRace.ResumeLayout(False)
        Me.grpRacesNow.ResumeLayout(False)
        Me.grpRacesNow.PerformLayout()
        CType(Me.gridRacesCurrent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabBehavior As TabControl
    Friend WithEvents pageTourney As TabPage
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
    Friend WithEvents dudRacesPort As DomainUpDown
    Friend WithEvents lblRacePort As Label
    Friend WithEvents grpRacesUpNext As GroupBox
    Friend WithEvents grpRacesHole As GroupBox
    Friend WithEvents gridRacesCurrent As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Lane As DataGridViewTextBoxColumn
    Friend WithEvents Racer As DataGridViewTextBoxColumn
    Friend WithEvents Rank As DataGridViewTextBoxColumn
    Friend WithEvents TimeToFinish As DataGridViewTextBoxColumn
    Friend WithEvents btnRacesNext As Button
End Class
