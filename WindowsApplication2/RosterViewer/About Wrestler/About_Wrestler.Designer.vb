<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About_Wrestler
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About_Wrestler))
        Me.namelabel = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.desc_label = New System.Windows.Forms.Label()
        Me.Infopanel = New System.Windows.Forms.Panel()
        Me.info = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.p2Pic = New System.Windows.Forms.PictureBox()
        Me.p1Pic = New System.Windows.Forms.PictureBox()
        Me.isFacePic = New System.Windows.Forms.PictureBox()
        Me.StylePic = New System.Windows.Forms.PictureBox()
        Me.s2 = New System.Windows.Forms.PictureBox()
        Me.s1 = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.wrestler_image = New System.Windows.Forms.PictureBox()
        Me.Wrestler_Header = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.infLabel = New System.Windows.Forms.Label()
        Me.Push = New RosterViewer.PushControl()
        Me.template_stviewer = New RosterViewer.Statviewer()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Infopanel.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.p2Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p1Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.isFacePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StylePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.s2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.s1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.wrestler_image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wrestler_Header, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'namelabel
        '
        Me.namelabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.namelabel.AutoSize = True
        Me.namelabel.BackColor = System.Drawing.Color.Black
        Me.namelabel.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.namelabel.ForeColor = System.Drawing.Color.White
        Me.namelabel.Location = New System.Drawing.Point(39, 73)
        Me.namelabel.MaximumSize = New System.Drawing.Size(250, 0)
        Me.namelabel.Name = "namelabel"
        Me.namelabel.Size = New System.Drawing.Size(93, 37)
        Me.namelabel.TabIndex = 1
        Me.namelabel.Text = "[N/A]"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 279)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(608, 449)
        Me.TabControl1.TabIndex = 4
        Me.TabControl1.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.Infopanel)
        Me.TabPage1.Controls.Add(Me.SplitContainer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(600, 423)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "About"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.desc_label)
        Me.Panel1.Location = New System.Drawing.Point(333, 381)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(261, 36)
        Me.Panel1.TabIndex = 3
        '
        'desc_label
        '
        Me.desc_label.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.desc_label.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.desc_label.Location = New System.Drawing.Point(9, 1)
        Me.desc_label.Name = "desc_label"
        Me.desc_label.Size = New System.Drawing.Size(261, 34)
        Me.desc_label.TabIndex = 0
        Me.desc_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Infopanel
        '
        Me.Infopanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Infopanel.AutoScroll = True
        Me.Infopanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Infopanel.Controls.Add(Me.info)
        Me.Infopanel.Location = New System.Drawing.Point(6, 6)
        Me.Infopanel.Name = "Infopanel"
        Me.Infopanel.Size = New System.Drawing.Size(325, 411)
        Me.Infopanel.TabIndex = 0
        '
        'info
        '
        Me.info.AllowDrop = True
        Me.info.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.info.AutoSize = True
        Me.info.Location = New System.Drawing.Point(3, 6)
        Me.info.MaximumSize = New System.Drawing.Size(300, 5000)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(300, 884)
        Me.info.TabIndex = 0
        Me.info.Text = resources.GetString("info.Text")
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.SplitContainer1.Location = New System.Drawing.Point(333, 6)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Push)
        Me.SplitContainer1.Panel1.Controls.Add(Me.template_stviewer)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.p2Pic)
        Me.SplitContainer1.Panel2.Controls.Add(Me.p1Pic)
        Me.SplitContainer1.Panel2.Controls.Add(Me.isFacePic)
        Me.SplitContainer1.Panel2.Controls.Add(Me.StylePic)
        Me.SplitContainer1.Panel2.Controls.Add(Me.s2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.s1)
        Me.SplitContainer1.Panel2MinSize = 48
        Me.SplitContainer1.Size = New System.Drawing.Size(261, 371)
        Me.SplitContainer1.SplitterDistance = 311
        Me.SplitContainer1.TabIndex = 2
        '
        'p2Pic
        '
        Me.p2Pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p2Pic.Location = New System.Drawing.Point(196, 3)
        Me.p2Pic.Name = "p2Pic"
        Me.p2Pic.Size = New System.Drawing.Size(48, 48)
        Me.p2Pic.TabIndex = 5
        Me.p2Pic.TabStop = False
        '
        'p1Pic
        '
        Me.p1Pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p1Pic.Location = New System.Drawing.Point(142, 3)
        Me.p1Pic.Name = "p1Pic"
        Me.p1Pic.Size = New System.Drawing.Size(48, 48)
        Me.p1Pic.TabIndex = 4
        Me.p1Pic.TabStop = False
        '
        'isFacePic
        '
        Me.isFacePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.isFacePic.Location = New System.Drawing.Point(77, 3)
        Me.isFacePic.Name = "isFacePic"
        Me.isFacePic.Size = New System.Drawing.Size(48, 48)
        Me.isFacePic.TabIndex = 3
        Me.isFacePic.TabStop = False
        '
        'StylePic
        '
        Me.StylePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StylePic.Location = New System.Drawing.Point(13, 3)
        Me.StylePic.Name = "StylePic"
        Me.StylePic.Size = New System.Drawing.Size(48, 48)
        Me.StylePic.TabIndex = 2
        Me.StylePic.TabStop = False
        '
        's2
        '
        Me.s2.Image = CType(resources.GetObject("s2.Image"), System.Drawing.Image)
        Me.s2.Location = New System.Drawing.Point(131, -2)
        Me.s2.Name = "s2"
        Me.s2.Size = New System.Drawing.Size(5, 80)
        Me.s2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.s2.TabIndex = 1
        Me.s2.TabStop = False
        '
        's1
        '
        Me.s1.Image = CType(resources.GetObject("s1.Image"), System.Drawing.Image)
        Me.s1.Location = New System.Drawing.Point(67, -2)
        Me.s1.Name = "s1"
        Me.s1.Size = New System.Drawing.Size(5, 80)
        Me.s1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.s1.TabIndex = 0
        Me.s1.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(600, 423)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Condition"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tired:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(600, 423)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Actions"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Controls.Add(Me.Button8)
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 123)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 111)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Title settings"
        '
        'Button9
        '
        Me.Button9.Enabled = False
        Me.Button9.Location = New System.Drawing.Point(6, 77)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(188, 23)
        Me.Button9.TabIndex = 3
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Enabled = False
        Me.Button8.Location = New System.Drawing.Point(6, 48)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(188, 23)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "Remove Title"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Enabled = False
        Me.Button7.Location = New System.Drawing.Point(6, 19)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(188, 23)
        Me.Button7.TabIndex = 1
        Me.Button7.Text = "Give a Title"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 111)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Basic Information"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(6, 48)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(188, 23)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "Change gimmick"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(6, 77)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(188, 23)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Change finisher"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(6, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(188, 23)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Change name"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Location = New System.Drawing.Point(212, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 111)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contract Information"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(6, 48)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(188, 23)
        Me.Button10.TabIndex = 2
        Me.Button10.Text = "Exchange"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 77)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(188, 23)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Break contract"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'wrestler_image
        '
        Me.wrestler_image.BackColor = System.Drawing.Color.Transparent
        Me.wrestler_image.Location = New System.Drawing.Point(302, 12)
        Me.wrestler_image.Name = "wrestler_image"
        Me.wrestler_image.Size = New System.Drawing.Size(221, 261)
        Me.wrestler_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.wrestler_image.TabIndex = 2
        Me.wrestler_image.TabStop = False
        '
        'Wrestler_Header
        '
        Me.Wrestler_Header.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Wrestler_Header.BackColor = System.Drawing.Color.Black
        Me.Wrestler_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Wrestler_Header.Image = CType(resources.GetObject("Wrestler_Header.Image"), System.Drawing.Image)
        Me.Wrestler_Header.Location = New System.Drawing.Point(35, 12)
        Me.Wrestler_Header.Name = "Wrestler_Header"
        Me.Wrestler_Header.Size = New System.Drawing.Size(553, 261)
        Me.Wrestler_Header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Wrestler_Header.TabIndex = 0
        Me.Wrestler_Header.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.BackColor = System.Drawing.Color.LightCoral
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(8, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 261)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(591, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 261)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = ">"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'infLabel
        '
        Me.infLabel.AutoSize = True
        Me.infLabel.BackColor = System.Drawing.Color.Black
        Me.infLabel.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.infLabel.ForeColor = System.Drawing.Color.White
        Me.infLabel.Location = New System.Drawing.Point(39, 110)
        Me.infLabel.MaximumSize = New System.Drawing.Size(250, 0)
        Me.infLabel.Name = "infLabel"
        Me.infLabel.Size = New System.Drawing.Size(47, 20)
        Me.infLabel.TabIndex = 7
        Me.infLabel.Text = "Label1"
        Me.infLabel.Visible = False
        '
        'Push
        '
        Me.Push.Location = New System.Drawing.Point(52, 6)
        Me.Push.Name = "Push"
        Me.Push.Size = New System.Drawing.Size(35, 301)
        Me.Push.TabIndex = 2
        '
        'template_stviewer
        '
        Me.template_stviewer.Location = New System.Drawing.Point(11, 6)
        Me.template_stviewer.Name = "template_stviewer"
        Me.template_stviewer.Size = New System.Drawing.Size(35, 301)
        Me.template_stviewer.TabIndex = 1
        '
        'About_Wrestler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RosterViewer.My.Resources.Resources.background2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(623, 734)
        Me.Controls.Add(Me.infLabel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.wrestler_image)
        Me.Controls.Add(Me.namelabel)
        Me.Controls.Add(Me.Wrestler_Header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "About_Wrestler"
        Me.Text = "About_Wrestler"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Infopanel.ResumeLayout(False)
        Me.Infopanel.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.p2Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p1Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.isFacePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StylePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.s2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.s1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.wrestler_image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wrestler_Header, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Wrestler_Header As System.Windows.Forms.PictureBox
    Friend WithEvents namelabel As System.Windows.Forms.Label
    Friend WithEvents wrestler_image As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents template_stviewer As RosterViewer.Statviewer
    Friend WithEvents info As System.Windows.Forms.Label
    Friend WithEvents Infopanel As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents desc_label As System.Windows.Forms.Label
    Friend WithEvents Push As RosterViewer.PushControl
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents infLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents p2Pic As System.Windows.Forms.PictureBox
    Friend WithEvents p1Pic As System.Windows.Forms.PictureBox
    Friend WithEvents isFacePic As System.Windows.Forms.PictureBox
    Friend WithEvents StylePic As System.Windows.Forms.PictureBox
    Friend WithEvents s2 As System.Windows.Forms.PictureBox
    Friend WithEvents s1 As System.Windows.Forms.PictureBox
End Class
