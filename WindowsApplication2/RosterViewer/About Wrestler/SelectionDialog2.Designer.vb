<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectionDialog2
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.innerPanel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.innerPanel)
        Me.Panel1.Location = New System.Drawing.Point(2, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(332, 313)
        Me.Panel1.TabIndex = 0
        '
        'innerPanel
        '
        Me.innerPanel.Location = New System.Drawing.Point(0, 0)
        Me.innerPanel.Name = "innerPanel"
        Me.innerPanel.Size = New System.Drawing.Size(120, 468)
        Me.innerPanel.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(126, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SelectionDialog2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SelectionDialog2"
        Me.Size = New System.Drawing.Size(171, 326)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents innerPanel As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
