<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PromoForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PromoForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Header = New System.Windows.Forms.PictureBox()
        Me.wrestler_image = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Header, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wrestler_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(553, 58)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Promo Overall:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Header
        '
        Me.Header.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Header.BackColor = System.Drawing.Color.Black
        Me.Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Header.Image = CType(resources.GetObject("Header.Image"), System.Drawing.Image)
        Me.Header.Location = New System.Drawing.Point(43, 12)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(553, 261)
        Me.Header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Header.TabIndex = 1
        Me.Header.TabStop = False
        '
        'wrestler_image
        '
        Me.wrestler_image.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.wrestler_image.BackColor = System.Drawing.Color.Transparent
        Me.wrestler_image.Location = New System.Drawing.Point(50, 12)
        Me.wrestler_image.Name = "wrestler_image"
        Me.wrestler_image.Size = New System.Drawing.Size(221, 261)
        Me.wrestler_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.wrestler_image.TabIndex = 3
        Me.wrestler_image.TabStop = False
        Me.wrestler_image.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 334)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(553, 87)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Additional promo stats are to be included"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PromoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 419)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.wrestler_image)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "PromoForm"
        Me.Text = "PromoForm"
        CType(Me.Header, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wrestler_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Header As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents wrestler_image As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
