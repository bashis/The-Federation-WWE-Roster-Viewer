<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Statviewer
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
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.MTech010VerticalProgessBar1 = New RosterViewer.MTech010VerticalProgessBar()
        Me.stringvalue = New System.Windows.Forms.Label()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic
        '
        Me.pic.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic.Location = New System.Drawing.Point(3, 266)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(32, 32)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic.TabIndex = 3
        Me.pic.TabStop = False
        '
        'MTech010VerticalProgessBar1
        '
        Me.MTech010VerticalProgessBar1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MTech010VerticalProgessBar1.ForeColor = System.Drawing.Color.OrangeRed
        Me.MTech010VerticalProgessBar1.Location = New System.Drawing.Point(3, 29)
        Me.MTech010VerticalProgessBar1.Name = "MTech010VerticalProgessBar1"
        Me.MTech010VerticalProgessBar1.Size = New System.Drawing.Size(32, 231)
        Me.MTech010VerticalProgessBar1.Step = 1
        Me.MTech010VerticalProgessBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.MTech010VerticalProgessBar1.TabIndex = 0
        '
        'stringvalue
        '
        Me.stringvalue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.stringvalue.Location = New System.Drawing.Point(3, 3)
        Me.stringvalue.Name = "stringvalue"
        Me.stringvalue.Size = New System.Drawing.Size(32, 23)
        Me.stringvalue.TabIndex = 2
        Me.stringvalue.Text = "0"
        Me.stringvalue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Statviewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.stringvalue)
        Me.Controls.Add(Me.MTech010VerticalProgessBar1)
        Me.Controls.Add(Me.pic)
        Me.Name = "Statviewer"
        Me.Size = New System.Drawing.Size(35, 301)
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pic As System.Windows.Forms.PictureBox
    Friend WithEvents MTech010VerticalProgessBar1 As RosterViewer.MTech010VerticalProgessBar
    Friend WithEvents stringvalue As System.Windows.Forms.Label

End Class
