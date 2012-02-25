<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MData
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.st = New System.Windows.Forms.ToolStripStatusLabel()
        Me.AutosaveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Notify1 = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SelectionDialog21 = New RosterViewer.SelectionDialog2()
        Me.WrestlerSelectionDialog1 = New RosterViewer.WrestlerSelectionDialog()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(2, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(207, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Roster Viewer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(2, 60)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(207, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Create-a-match"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(2, 205)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(207, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Edit wrestlers DataBase"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(2, 263)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(207, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(2, 234)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(131, 23)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Save current DataBase"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.st})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 293)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(215, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(98, 17)
        Me.ToolStripStatusLabel1.Text = "Money: $1000000"
        '
        'st
        '
        Me.st.Name = "st"
        Me.st.Size = New System.Drawing.Size(50, 17)
        Me.st.Text = "Loading"
        '
        'AutosaveTimer
        '
        Me.AutosaveTimer.Interval = 900000
        '
        'Notify1
        '
        Me.Notify1.Interval = 1000
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(139, 238)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(71, 17)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Autosave"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(2, 89)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(207, 23)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "Create-a-promo"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(2, 118)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(207, 23)
        Me.Button7.TabIndex = 3
        Me.Button7.Text = "Create-a-show"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(2, 176)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(207, 23)
        Me.Button8.TabIndex = 4
        Me.Button8.Text = "Hire wrestlers"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Enabled = False
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Location = New System.Drawing.Point(2, 147)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(207, 23)
        Me.Button9.TabIndex = 10
        Me.Button9.Text = "Training"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(438, 300)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(145, 38)
        Me.Button10.TabIndex = 12
        Me.Button10.Text = "Button10"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(2, 6)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(207, 21)
        Me.ComboBox1.TabIndex = 13
        '
        'SelectionDialog21
        '
        Me.SelectionDialog21.Location = New System.Drawing.Point(559, 12)
        Me.SelectionDialog21.Name = "SelectionDialog21"
        Me.SelectionDialog21.Size = New System.Drawing.Size(173, 337)
        Me.SelectionDialog21.TabIndex = 11
        '
        'WrestlerSelectionDialog1
        '
        Me.WrestlerSelectionDialog1.Location = New System.Drawing.Point(216, 2)
        Me.WrestlerSelectionDialog1.Name = "WrestlerSelectionDialog1"
        Me.WrestlerSelectionDialog1.Size = New System.Drawing.Size(300, 365)
        Me.WrestlerSelectionDialog1.TabIndex = 9
        '
        'MData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(215, 315)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.SelectionDialog21)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.WrestlerSelectionDialog1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "MData"
        Me.Text = "MData"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents st As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AutosaveTimer As System.Windows.Forms.Timer
    Friend WithEvents Notify1 As System.Windows.Forms.Timer
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents WrestlerSelectionDialog1 As RosterViewer.WrestlerSelectionDialog
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents SelectionDialog21 As RosterViewer.SelectionDialog2
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
