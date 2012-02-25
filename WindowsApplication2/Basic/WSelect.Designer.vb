<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WSelect
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
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.WrestlerSelectionDialog1 = New RosterViewer.WrestlerSelectionDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.OK_Button.Location = New System.Drawing.Point(309, 147)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 143)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'WrestlerSelectionDialog1
        '
        Me.WrestlerSelectionDialog1.Location = New System.Drawing.Point(12, 37)
        Me.WrestlerSelectionDialog1.Name = "WrestlerSelectionDialog1"
        Me.WrestlerSelectionDialog1.Size = New System.Drawing.Size(291, 388)
        Me.WrestlerSelectionDialog1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Choose the wrestler:"
        '
        'WSelect
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 401)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.WrestlerSelectionDialog1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WSelect"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "WSelect"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents WrestlerSelectionDialog1 As RosterViewer.WrestlerSelectionDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
