<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MatchMenu
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
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.tLabel3 = New System.Windows.Forms.Label()
        Me.ItemsTypeLabel = New System.Windows.Forms.Label()
        Me.R_info = New System.Windows.Forms.Label()
        Me.tLabel4 = New System.Windows.Forms.Label()
        Me.result_stats = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Stars_image = New System.Windows.Forms.Label()
        Me.winner_label = New System.Windows.Forms.Label()
        Me.MatchStars1 = New RosterViewer.MatchStars()
        Me.ElementHost1 = New System.Windows.Forms.Integration.ElementHost()
        Me.PView1 = New RosterViewer.PView()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(12, 368)
        Me.NameLabel.MaximumSize = New System.Drawing.Size(507, 5000)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(190, 39)
        Me.NameLabel.TabIndex = 1
        Me.NameLabel.Text = "Label2"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tLabel3
        '
        Me.tLabel3.AutoSize = True
        Me.tLabel3.Location = New System.Drawing.Point(0, 68)
        Me.tLabel3.Name = "tLabel3"
        Me.tLabel3.Size = New System.Drawing.Size(35, 13)
        Me.tLabel3.TabIndex = 4
        Me.tLabel3.Text = "Items:"
        '
        'ItemsTypeLabel
        '
        Me.ItemsTypeLabel.AutoSize = True
        Me.ItemsTypeLabel.Location = New System.Drawing.Point(12, 81)
        Me.ItemsTypeLabel.Name = "ItemsTypeLabel"
        Me.ItemsTypeLabel.Size = New System.Drawing.Size(39, 13)
        Me.ItemsTypeLabel.TabIndex = 5
        Me.ItemsTypeLabel.Text = "Label2"
        '
        'R_info
        '
        Me.R_info.AutoSize = True
        Me.R_info.Location = New System.Drawing.Point(12, 37)
        Me.R_info.Name = "R_info"
        Me.R_info.Size = New System.Drawing.Size(39, 13)
        Me.R_info.TabIndex = 8
        Me.R_info.Text = "Label1"
        '
        'tLabel4
        '
        Me.tLabel4.AutoSize = True
        Me.tLabel4.Location = New System.Drawing.Point(4, 24)
        Me.tLabel4.Name = "tLabel4"
        Me.tLabel4.Size = New System.Drawing.Size(32, 13)
        Me.tLabel4.TabIndex = 9
        Me.tLabel4.Text = "Ring:"
        '
        'result_stats
        '
        Me.result_stats.AutoSize = True
        Me.result_stats.Location = New System.Drawing.Point(670, 24)
        Me.result_stats.Name = "result_stats"
        Me.result_stats.Size = New System.Drawing.Size(37, 13)
        Me.result_stats.TabIndex = 10
        Me.result_stats.Text = "Result"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ElementHost1)
        Me.Panel1.Location = New System.Drawing.Point(149, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(515, 322)
        Me.Panel1.TabIndex = 11
        '
        'Stars_image
        '
        Me.Stars_image.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Stars_image.Location = New System.Drawing.Point(149, 275)
        Me.Stars_image.Name = "Stars_image"
        Me.Stars_image.Size = New System.Drawing.Size(515, 90)
        Me.Stars_image.TabIndex = 12
        Me.Stars_image.Text = "*"
        Me.Stars_image.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Stars_image.Visible = False
        '
        'winner_label
        '
        Me.winner_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.winner_label.Location = New System.Drawing.Point(132, 429)
        Me.winner_label.Name = "winner_label"
        Me.winner_label.Size = New System.Drawing.Size(515, 60)
        Me.winner_label.TabIndex = 13
        Me.winner_label.Text = "winner"
        Me.winner_label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MatchStars1
        '
        Me.MatchStars1.Location = New System.Drawing.Point(284, 336)
        Me.MatchStars1.Name = "MatchStars1"
        Me.MatchStars1.Size = New System.Drawing.Size(232, 90)
        Me.MatchStars1.TabIndex = 14
        '
        'ElementHost1
        '
        Me.ElementHost1.Location = New System.Drawing.Point(3, 3)
        Me.ElementHost1.Name = "ElementHost1"
        Me.ElementHost1.Size = New System.Drawing.Size(507, 313)
        Me.ElementHost1.TabIndex = 0
        Me.ElementHost1.Text = "ElementHost1"
        Me.ElementHost1.Child = Me.PView1
        '
        'MatchMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 478)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.MatchStars1)
        Me.Controls.Add(Me.winner_label)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.result_stats)
        Me.Controls.Add(Me.tLabel4)
        Me.Controls.Add(Me.R_info)
        Me.Controls.Add(Me.ItemsTypeLabel)
        Me.Controls.Add(Me.tLabel3)
        Me.Controls.Add(Me.Stars_image)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MatchMenu"
        Me.Text = "MatchMenu"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents tLabel3 As System.Windows.Forms.Label
    Friend WithEvents ItemsTypeLabel As System.Windows.Forms.Label
    Friend WithEvents R_info As System.Windows.Forms.Label
    Friend WithEvents tLabel4 As System.Windows.Forms.Label
    Friend WithEvents result_stats As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Stars_image As System.Windows.Forms.Label
    Friend WithEvents winner_label As System.Windows.Forms.Label
    Friend WithEvents MatchStars1 As RosterViewer.MatchStars
    Friend WithEvents ElementHost1 As System.Windows.Forms.Integration.ElementHost
    Friend PView1 As RosterViewer.PView
End Class
