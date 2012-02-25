<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PushControl
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
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tip = New System.Windows.Forms.ToolTip(Me.components)
        Me.stringvalue = New System.Windows.Forms.Button()
        Me.bar = New RosterViewer.MTech010VerticalProgessBar()
        Me.pic = New System.Windows.Forms.PictureBox()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stringvalue
        '
        Me.stringvalue.Location = New System.Drawing.Point(0, 3)
        Me.stringvalue.Name = "stringvalue"
        Me.stringvalue.Size = New System.Drawing.Size(33, 23)
        Me.stringvalue.TabIndex = 8
        Me.stringvalue.Text = "Button1"
        Me.stringvalue.UseVisualStyleBackColor = True
        '
        'bar
        '
        Me.bar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bar.ForeColor = System.Drawing.Color.OrangeRed
        Me.bar.Location = New System.Drawing.Point(1, 29)
        Me.bar.Name = "bar"
        Me.bar.Size = New System.Drawing.Size(32, 231)
        Me.bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.bar.TabIndex = 7
        '
        'pic
        '
        Me.pic.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic.Image = Global.RosterViewer.My.Resources.Resources.push2
        Me.pic.Location = New System.Drawing.Point(1, 266)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(32, 32)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic.TabIndex = 6
        Me.pic.TabStop = False
        '
        'PushControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.stringvalue)
        Me.Controls.Add(Me.bar)
        Me.Controls.Add(Me.pic)
        Me.Name = "PushControl"
        Me.Size = New System.Drawing.Size(35, 301)
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents tip As System.Windows.Forms.ToolTip
    Friend WithEvents pic As System.Windows.Forms.PictureBox
    Friend WithEvents bar As RosterViewer.MTech010VerticalProgessBar
    Friend WithEvents stringvalue As System.Windows.Forms.Button

End Class
