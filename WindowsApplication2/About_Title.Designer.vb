<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About_Title
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
        Me.header = New System.Windows.Forms.Label()
        Me.body = New System.Windows.Forms.Label()
        Me.listview1 = New System.Windows.Forms.ListView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'header
        '
        Me.header.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.header.AutoSize = True
        Me.header.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.header.Location = New System.Drawing.Point(22, 12)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(102, 32)
        Me.header.TabIndex = 0
        Me.header.Text = "Label1"
        '
        'body
        '
        Me.body.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.body.AutoSize = True
        Me.body.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.body.Location = New System.Drawing.Point(77, 61)
        Me.body.MaximumSize = New System.Drawing.Size(400, 0)
        Me.body.Name = "body"
        Me.body.Size = New System.Drawing.Size(51, 17)
        Me.body.TabIndex = 1
        Me.body.Text = "Label1"
        '
        'listview1
        '
        Me.listview1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.listview1.Location = New System.Drawing.Point(80, 81)
        Me.listview1.MultiSelect = False
        Me.listview1.Name = "listview1"
        Me.listview1.Size = New System.Drawing.Size(367, 97)
        Me.listview1.TabIndex = 2
        Me.listview1.UseCompatibleStateImageBehavior = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.body)
        Me.Panel1.Controls.Add(Me.listview1)
        Me.Panel1.Controls.Add(Me.header)
        Me.Panel1.Location = New System.Drawing.Point(110, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(533, 455)
        Me.Panel1.TabIndex = 3
        '
        'About_Title
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RosterViewer.My.Resources.Resources.background2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(738, 479)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "About_Title"
        Me.Text = "About_Title"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents header As System.Windows.Forms.Label
    Friend WithEvents body As System.Windows.Forms.Label
    Friend WithEvents listview1 As System.Windows.Forms.ListView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
