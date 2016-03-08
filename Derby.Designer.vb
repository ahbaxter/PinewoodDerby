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
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblRegisterRacer = New System.Windows.Forms.Label()
        Me.lblRegisterManual = New System.Windows.Forms.Label()
        Me.pageTourney = New System.Windows.Forms.TabPage()
        Me.pageRace = New System.Windows.Forms.TabPage()
        Me.pageResults = New System.Windows.Forms.TabPage()
        Me.tabBehavior.SuspendLayout()
        Me.pageRegister.SuspendLayout()
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
        Me.pageRegister.Controls.Add(Me.TextBox2)
        Me.pageRegister.Controls.Add(Me.lblID)
        Me.pageRegister.Controls.Add(Me.TextBox1)
        Me.pageRegister.Controls.Add(Me.lblRegisterRacer)
        Me.pageRegister.Controls.Add(Me.lblRegisterManual)
        Me.pageRegister.Location = New System.Drawing.Point(4, 22)
        Me.pageRegister.Name = "pageRegister"
        Me.pageRegister.Padding = New System.Windows.Forms.Padding(3)
        Me.pageRegister.Size = New System.Drawing.Size(672, 391)
        Me.pageRegister.TabIndex = 0
        Me.pageRegister.Text = "Register Cars"
        Me.pageRegister.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(51, 89)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(140, 20)
        Me.TextBox2.TabIndex = 8
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(6, 92)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 13)
        Me.lblID.TabIndex = 7
        Me.lblID.Text = "ID:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(51, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(140, 20)
        Me.TextBox1.TabIndex = 3
        '
        'lblRegisterRacer
        '
        Me.lblRegisterRacer.AutoSize = True
        Me.lblRegisterRacer.Location = New System.Drawing.Point(6, 57)
        Me.lblRegisterRacer.Name = "lblRegisterRacer"
        Me.lblRegisterRacer.Size = New System.Drawing.Size(39, 13)
        Me.lblRegisterRacer.TabIndex = 1
        Me.lblRegisterRacer.Text = "Racer:"
        '
        'lblRegisterManual
        '
        Me.lblRegisterManual.AutoSize = True
        Me.lblRegisterManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegisterManual.Location = New System.Drawing.Point(28, 34)
        Me.lblRegisterManual.Name = "lblRegisterManual"
        Me.lblRegisterManual.Size = New System.Drawing.Size(139, 17)
        Me.lblRegisterManual.TabIndex = 0
        Me.lblRegisterManual.Text = "Enter Cars Manually:"
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
        Me.pageRace.Location = New System.Drawing.Point(4, 22)
        Me.pageRace.Name = "pageRace"
        Me.pageRace.Padding = New System.Windows.Forms.Padding(3)
        Me.pageRace.Size = New System.Drawing.Size(672, 391)
        Me.pageRace.TabIndex = 2
        Me.pageRace.Text = "Run Races"
        Me.pageRace.UseVisualStyleBackColor = True
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
        Me.Text = "Derby Jockey"
        Me.tabBehavior.ResumeLayout(False)
        Me.pageRegister.ResumeLayout(False)
        Me.pageRegister.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabBehavior As TabControl
    Friend WithEvents pageTourney As TabPage
    Friend WithEvents pageRace As TabPage
    Friend WithEvents pageResults As TabPage
    Friend WithEvents pageRegister As TabPage
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblRegisterRacer As Label
    Friend WithEvents lblRegisterManual As Label
End Class
