<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrainingForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tmplabel = New System.Windows.Forms.Label()
        Me.fullsize_image = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.fullsize_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.tmplabel)
        Me.Panel1.Controls.Add(Me.fullsize_image)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(235, 331)
        Me.Panel1.TabIndex = 0
        '
        'tmplabel
        '
        Me.tmplabel.AutoSize = True
        Me.tmplabel.Location = New System.Drawing.Point(74, 142)
        Me.tmplabel.Name = "tmplabel"
        Me.tmplabel.Size = New System.Drawing.Size(39, 13)
        Me.tmplabel.TabIndex = 17
        Me.tmplabel.Text = "Label2"
        '
        'fullsize_image
        '
        Me.fullsize_image.BackColor = System.Drawing.Color.Transparent
        Me.fullsize_image.Image = Global.RosterViewer.My.Resources.Resources._9999
        Me.fullsize_image.Location = New System.Drawing.Point(3, 65)
        Me.fullsize_image.Name = "fullsize_image"
        Me.fullsize_image.Size = New System.Drawing.Size(221, 261)
        Me.fullsize_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fullsize_image.TabIndex = 16
        Me.fullsize_image.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Average wrestler:"
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(253, 78)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(435, 265)
        Me.Panel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(253, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(435, 62)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Training"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TrainingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 351)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "TrainingForm"
        Me.Text = "TrainingForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.fullsize_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fullsize_image As System.Windows.Forms.PictureBox
    Friend WithEvents tmplabel As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
