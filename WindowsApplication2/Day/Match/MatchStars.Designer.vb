<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MatchStars
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.back = New System.Windows.Forms.Label()
        Me.front = New System.Windows.Forms.Label()
        Me.vlabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'back
        '
        Me.back.AutoSize = True
        Me.back.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.back.Location = New System.Drawing.Point(3, 0)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(230, 108)
        Me.back.TabIndex = 0
        Me.back.Text = "*****"
        '
        'front
        '
        Me.front.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.front.Location = New System.Drawing.Point(53, 51)
        Me.front.Name = "front"
        Me.front.Size = New System.Drawing.Size(230, 108)
        Me.front.TabIndex = 1
        '
        'vlabel
        '
        Me.vlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.vlabel.Location = New System.Drawing.Point(0, 63)
        Me.vlabel.Name = "vlabel"
        Me.vlabel.Size = New System.Drawing.Size(229, 23)
        Me.vlabel.TabIndex = 2
        Me.vlabel.Text = "% stars"
        Me.vlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MatchStars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.vlabel)
        Me.Controls.Add(Me.front)
        Me.Controls.Add(Me.back)
        Me.Name = "MatchStars"
        Me.Size = New System.Drawing.Size(232, 93)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents back As System.Windows.Forms.Label
    Friend WithEvents front As System.Windows.Forms.Label
    Friend WithEvents vlabel As System.Windows.Forms.Label

End Class
