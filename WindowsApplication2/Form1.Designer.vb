<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.wrestler = New System.Windows.Forms.PictureBox()
        Me.newspic = New System.Windows.Forms.Panel()
        Me.Selector_panel = New System.Windows.Forms.Panel()
        Me.underbody = New System.Windows.Forms.Label()
        Me.title_image = New System.Windows.Forms.PictureBox()
        Me.body = New System.Windows.Forms.Label()
        Me.header = New System.Windows.Forms.Label()
        Me.Selector_timer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.wrestler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.newspic.SuspendLayout()
        CType(Me.title_image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(55, 323)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(660, 459)
        Me.Panel1.TabIndex = 3
        '
        'wrestler
        '
        Me.wrestler.BackColor = System.Drawing.Color.Transparent
        Me.wrestler.Image = Global.RosterViewer.My.Resources.Resources._9999
        Me.wrestler.Location = New System.Drawing.Point(370, 4)
        Me.wrestler.Name = "wrestler"
        Me.wrestler.Size = New System.Drawing.Size(289, 257)
        Me.wrestler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.wrestler.TabIndex = 5
        Me.wrestler.TabStop = False
        '
        'newspic
        '
        Me.newspic.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.newspic.BackgroundImage = CType(resources.GetObject("newspic.BackgroundImage"), System.Drawing.Image)
        Me.newspic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.newspic.Controls.Add(Me.Selector_panel)
        Me.newspic.Controls.Add(Me.underbody)
        Me.newspic.Controls.Add(Me.title_image)
        Me.newspic.Controls.Add(Me.body)
        Me.newspic.Controls.Add(Me.header)
        Me.newspic.Controls.Add(Me.wrestler)
        Me.newspic.Location = New System.Drawing.Point(55, 12)
        Me.newspic.Name = "newspic"
        Me.newspic.Size = New System.Drawing.Size(660, 261)
        Me.newspic.TabIndex = 6
        '
        'Selector_panel
        '
        Me.Selector_panel.AutoSize = True
        Me.Selector_panel.BackColor = System.Drawing.Color.Transparent
        Me.Selector_panel.Location = New System.Drawing.Point(30, 234)
        Me.Selector_panel.Name = "Selector_panel"
        Me.Selector_panel.Size = New System.Drawing.Size(193, 22)
        Me.Selector_panel.TabIndex = 11
        '
        'underbody
        '
        Me.underbody.AutoSize = True
        Me.underbody.Cursor = System.Windows.Forms.Cursors.Hand
        Me.underbody.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.underbody.ForeColor = System.Drawing.Color.White
        Me.underbody.Location = New System.Drawing.Point(39, 114)
        Me.underbody.Name = "underbody"
        Me.underbody.Size = New System.Drawing.Size(112, 22)
        Me.underbody.TabIndex = 10
        Me.underbody.Text = "underbody"
        '
        'title_image
        '
        Me.title_image.BackColor = System.Drawing.Color.Transparent
        Me.title_image.Location = New System.Drawing.Point(423, 212)
        Me.title_image.Name = "title_image"
        Me.title_image.Size = New System.Drawing.Size(195, 52)
        Me.title_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.title_image.TabIndex = 9
        Me.title_image.TabStop = False
        '
        'body
        '
        Me.body.AutoSize = True
        Me.body.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.body.ForeColor = System.Drawing.Color.White
        Me.body.Location = New System.Drawing.Point(41, 86)
        Me.body.MaximumSize = New System.Drawing.Size(360, 0)
        Me.body.Name = "body"
        Me.body.Size = New System.Drawing.Size(36, 16)
        Me.body.TabIndex = 8
        Me.body.Text = "body"
        '
        'header
        '
        Me.header.AutoSize = True
        Me.header.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.header.ForeColor = System.Drawing.SystemColors.Control
        Me.header.Location = New System.Drawing.Point(36, 65)
        Me.header.MaximumSize = New System.Drawing.Size(360, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(122, 37)
        Me.header.TabIndex = 6
        Me.header.Text = "header"
        Me.header.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Selector_timer
        '
        Me.Selector_timer.Interval = 10000
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.RosterViewer.My.Resources.Resources.mlogx
        Me.PictureBox1.Location = New System.Drawing.Point(86, 297)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(105, 304)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Roster"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.RosterViewer.My.Resources.Resources.background2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(773, 794)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.newspic)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Community"
        CType(Me.wrestler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.newspic.ResumeLayout(False)
        Me.newspic.PerformLayout()
        CType(Me.title_image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents wrestler As System.Windows.Forms.PictureBox
    Friend WithEvents newspic As System.Windows.Forms.Panel
    Friend WithEvents header As System.Windows.Forms.Label
    Friend WithEvents body As System.Windows.Forms.Label
    Friend WithEvents title_image As System.Windows.Forms.PictureBox
    Friend WithEvents underbody As System.Windows.Forms.Label
    Friend WithEvents Selector_panel As System.Windows.Forms.Panel
    Friend WithEvents Selector_timer As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
