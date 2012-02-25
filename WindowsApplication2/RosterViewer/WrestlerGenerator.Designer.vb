<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WrestlerGenerator
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.udk = New System.Windows.Forms.NumericUpDown()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.heelface = New System.Windows.Forms.ComboBox()
        Me.mini_image = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.fullsize_image = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        CType(Me.udk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mini_image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fullsize_image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(150, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Алгоритм 1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 92)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TextBox1.Size = New System.Drawing.Size(679, 48)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Finisher"
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(12, 25)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TextBox2.Size = New System.Drawing.Size(679, 48)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = "Name"
        Me.TextBox2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name:"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Finisher:"
        Me.Label2.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(15, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 27)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Generate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(12, 42)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(679, 405)
        Me.ListView1.TabIndex = 7
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(526, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Level of Recruit Agent"
        '
        'udk
        '
        Me.udk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.udk.Location = New System.Drawing.Point(645, 9)
        Me.udk.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.udk.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.udk.Name = "udk"
        Me.udk.Size = New System.Drawing.Size(43, 20)
        Me.udk.TabIndex = 9
        Me.udk.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button3.Location = New System.Drawing.Point(698, 320)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(314, 128)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Hire"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(798, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Hire as:"
        '
        'heelface
        '
        Me.heelface.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.heelface.FormattingEnabled = True
        Me.heelface.Items.AddRange(New Object() {"Face", "Heel"})
        Me.heelface.Location = New System.Drawing.Point(798, 292)
        Me.heelface.Name = "heelface"
        Me.heelface.Size = New System.Drawing.Size(109, 21)
        Me.heelface.TabIndex = 12
        '
        'mini_image
        '
        Me.mini_image.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mini_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mini_image.Image = Global.RosterViewer.My.Resources.Resources._99991
        Me.mini_image.Location = New System.Drawing.Point(697, 12)
        Me.mini_image.Name = "mini_image"
        Me.mini_image.Size = New System.Drawing.Size(98, 105)
        Me.mini_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mini_image.TabIndex = 13
        Me.mini_image.TabStop = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(697, 123)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(98, 35)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Change mini-image"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'fullsize_image
        '
        Me.fullsize_image.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fullsize_image.BackColor = System.Drawing.Color.Transparent
        Me.fullsize_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fullsize_image.Image = Global.RosterViewer.My.Resources.Resources._9999
        Me.fullsize_image.Location = New System.Drawing.Point(801, 12)
        Me.fullsize_image.Name = "fullsize_image"
        Me.fullsize_image.Size = New System.Drawing.Size(221, 261)
        Me.fullsize_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fullsize_image.TabIndex = 15
        Me.fullsize_image.TabStop = False
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Location = New System.Drawing.Point(698, 164)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(98, 35)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Change fullsize-image"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.Location = New System.Drawing.Point(698, 205)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(98, 35)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "Restore default images"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(916, 276)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "With push:"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown1.Location = New System.Drawing.Point(919, 293)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(87, 20)
        Me.NumericUpDown1.TabIndex = 19
        Me.NumericUpDown1.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'WrestlerGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 460)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.fullsize_image)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.mini_image)
        Me.Controls.Add(Me.heelface)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.udk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.MaximizeBox = False
        Me.Name = "WrestlerGenerator"
        Me.Text = "Finisher Generator"
        CType(Me.udk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mini_image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fullsize_image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents udk As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents heelface As System.Windows.Forms.ComboBox
    Friend WithEvents mini_image As System.Windows.Forms.PictureBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents fullsize_image As System.Windows.Forms.PictureBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown

End Class
