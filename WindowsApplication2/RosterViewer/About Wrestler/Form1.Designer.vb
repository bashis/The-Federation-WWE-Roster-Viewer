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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.udk = New System.Windows.Forms.NumericUpDown()
        Me.face = New System.Windows.Forms.PictureBox()
        CType(Me.udk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.face, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(340, 9)
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
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(12, 42)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(676, 405)
        Me.ListView1.TabIndex = 7
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(526, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Level of Recruit Agent"
        '
        'udk
        '
        Me.udk.Location = New System.Drawing.Point(645, 9)
        Me.udk.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.udk.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.udk.Name = "udk"
        Me.udk.Size = New System.Drawing.Size(43, 20)
        Me.udk.TabIndex = 9
        Me.udk.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'face
        '
        Me.face.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.face.Location = New System.Drawing.Point(694, 42)
        Me.face.Name = "face"
        Me.face.Size = New System.Drawing.Size(400, 400)
        Me.face.TabIndex = 11
        Me.face.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 460)
        Me.Controls.Add(Me.face)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.udk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Finisher Generator"
        CType(Me.udk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.face, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents face As System.Windows.Forms.PictureBox

End Class
