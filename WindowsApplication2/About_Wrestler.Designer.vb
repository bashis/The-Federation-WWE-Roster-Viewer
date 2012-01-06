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
        Me.Wrestler_Header = New System.Windows.Forms.PictureBox()
        Me.namelabel = New System.Windows.Forms.Label()
        Me.wrestler_image = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Wrestler_Header, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wrestler_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Wrestler_Header
        '
        Me.Wrestler_Header.BackColor = System.Drawing.Color.Black
        Me.Wrestler_Header.Image = CType(resources.GetObject("Wrestler_Header.Image"), System.Drawing.Image)
        Me.Wrestler_Header.Location = New System.Drawing.Point(12, 12)
        Me.Wrestler_Header.Name = "Wrestler_Header"
        Me.Wrestler_Header.Size = New System.Drawing.Size(553, 261)
        Me.Wrestler_Header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Wrestler_Header.TabIndex = 0
        Me.Wrestler_Header.TabStop = False
        '
        'namelabel
        '
        Me.namelabel.AutoSize = True
        Me.namelabel.BackColor = System.Drawing.Color.Black
        Me.namelabel.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.namelabel.ForeColor = System.Drawing.Color.White
        Me.namelabel.Location = New System.Drawing.Point(45, 73)
        Me.namelabel.MaximumSize = New System.Drawing.Size(250, 0)
        Me.namelabel.Name = "namelabel"
        Me.namelabel.Size = New System.Drawing.Size(93, 37)
        Me.namelabel.TabIndex = 1
        Me.namelabel.Text = "[N/A]"
        '
        'wrestler_image
        '
        Me.wrestler_image.BackColor = System.Drawing.Color.Transparent
        Me.wrestler_image.Location = New System.Drawing.Point(304, 12)
        Me.wrestler_image.Name = "wrestler_image"
        Me.wrestler_image.Size = New System.Drawing.Size(221, 261)
        Me.wrestler_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.wrestler_image.TabIndex = 2
        Me.wrestler_image.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(485, 55)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "NOT AVAILABLE YET"
        '
        'About_Wrestler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 337)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.wrestler_image)
        Me.Controls.Add(Me.namelabel)
        Me.Controls.Add(Me.Wrestler_Header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "About_Wrestler"
        Me.Text = "About_Wrestler"
        CType(Me.Wrestler_Header, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wrestler_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Wrestler_Header As System.Windows.Forms.PictureBox
    Friend WithEvents namelabel As System.Windows.Forms.Label
    Friend WithEvents wrestler_image As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
