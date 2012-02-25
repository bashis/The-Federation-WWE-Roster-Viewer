<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MatchSetup
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MatchTypeBox = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ItemsDGV = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.WrestlersDGV = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.isPPV = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.ItemsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WrestlersDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of wrestlers:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Match Type:"
        '
        'MatchTypeBox
        '
        Me.MatchTypeBox.FormattingEnabled = True
        Me.MatchTypeBox.Location = New System.Drawing.Point(12, 64)
        Me.MatchTypeBox.Name = "MatchTypeBox"
        Me.MatchTypeBox.Size = New System.Drawing.Size(233, 95)
        Me.MatchTypeBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Items:"
        '
        'ItemsDGV
        '
        Me.ItemsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemsDGV.Location = New System.Drawing.Point(15, 178)
        Me.ItemsDGV.MaximumSize = New System.Drawing.Size(230, 150)
        Me.ItemsDGV.Name = "ItemsDGV"
        Me.ItemsDGV.Size = New System.Drawing.Size(230, 150)
        Me.ItemsDGV.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 331)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Wrestlers:"
        '
        'WrestlersDGV
        '
        Me.WrestlersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.WrestlersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WrestlersDGV.Location = New System.Drawing.Point(15, 351)
        Me.WrestlersDGV.Name = "WrestlersDGV"
        Me.WrestlersDGV.Size = New System.Drawing.Size(230, 310)
        Me.WrestlersDGV.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 667)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 27)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Generate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'isPPV
        '
        Me.isPPV.AutoSize = True
        Me.isPPV.Location = New System.Drawing.Point(251, 64)
        Me.isPPV.Name = "isPPV"
        Me.isPPV.Size = New System.Drawing.Size(89, 17)
        Me.isPPV.TabIndex = 9
        Me.isPPV.Text = "Pay-Per-View"
        Me.isPPV.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(251, 351)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Force winner"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(251, 374)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(87, 20)
        Me.TextBox1.TabIndex = 11
        '
        'MatchSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 695)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.isPPV)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.WrestlersDGV)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ItemsDGV)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MatchTypeBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MatchSetup"
        Me.Text = "MatchSetup"
        CType(Me.ItemsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WrestlersDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
     Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MatchTypeBox As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ItemsDGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents WrestlersDGV As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents isPPV As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
