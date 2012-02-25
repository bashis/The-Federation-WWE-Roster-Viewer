<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShowViewer))
        Me.Header = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.templateButton = New System.Windows.Forms.Button()
        Me.newEventButton = New System.Windows.Forms.Button()
        Me.RandomButton = New System.Windows.Forms.Button()
        CType(Me.Header, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Header
        '
        Me.Header.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Header.BackColor = System.Drawing.Color.Black
        Me.Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Header.Image = CType(resources.GetObject("Header.Image"), System.Drawing.Image)
        Me.Header.Location = New System.Drawing.Point(12, 12)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(553, 261)
        Me.Header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Header.TabIndex = 2
        Me.Header.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.templateButton)
        Me.Panel1.Location = New System.Drawing.Point(12, 279)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(553, 59)
        Me.Panel1.TabIndex = 3
        '
        'templateButton
        '
        Me.templateButton.Location = New System.Drawing.Point(3, 3)
        Me.templateButton.Name = "templateButton"
        Me.templateButton.Size = New System.Drawing.Size(75, 32)
        Me.templateButton.TabIndex = 0
        Me.templateButton.Text = "Event"
        Me.templateButton.UseVisualStyleBackColor = True
        Me.templateButton.Visible = False
        '
        'newEventButton
        '
        Me.newEventButton.BackColor = System.Drawing.Color.Transparent
        Me.newEventButton.Location = New System.Drawing.Point(12, 176)
        Me.newEventButton.Name = "newEventButton"
        Me.newEventButton.Size = New System.Drawing.Size(550, 23)
        Me.newEventButton.TabIndex = 4
        Me.newEventButton.Text = "newEventButton"
        Me.newEventButton.UseVisualStyleBackColor = False
        '
        'RandomButton
        '
        Me.RandomButton.BackColor = System.Drawing.Color.Transparent
        Me.RandomButton.Location = New System.Drawing.Point(12, 205)
        Me.RandomButton.Name = "RandomButton"
        Me.RandomButton.Size = New System.Drawing.Size(550, 23)
        Me.RandomButton.TabIndex = 5
        Me.RandomButton.Text = "RandomButton"
        Me.RandomButton.UseVisualStyleBackColor = False
        '
        'ShowViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 466)
        Me.Controls.Add(Me.RandomButton)
        Me.Controls.Add(Me.newEventButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Header)
        Me.Name = "ShowViewer"
        Me.Text = "ShowViewer"
        CType(Me.Header, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Header As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents templateButton As System.Windows.Forms.Button
    Friend WithEvents newEventButton As System.Windows.Forms.Button
    Friend WithEvents RandomButton As System.Windows.Forms.Button
End Class
