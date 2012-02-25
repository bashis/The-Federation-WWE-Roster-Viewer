<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DBEdit
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WrestlerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddWrestlerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckIfAlreadyExistsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveWrestlerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView1.Location = New System.Drawing.Point(9, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(822, 538)
        Me.DataGridView1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.WrestlerToolStripMenuItem, Me.NormalizeToolStripMenuItem, Me.RemoveWrestlerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(843, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.LoadToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.LoadToolStripMenuItem.Text = "Load"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'WrestlerToolStripMenuItem
        '
        Me.WrestlerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddWrestlerToolStripMenuItem1, Me.CheckIfAlreadyExistsToolStripMenuItem})
        Me.WrestlerToolStripMenuItem.Name = "WrestlerToolStripMenuItem"
        Me.WrestlerToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.WrestlerToolStripMenuItem.Text = "Wrestler"
        '
        'AddWrestlerToolStripMenuItem1
        '
        Me.AddWrestlerToolStripMenuItem1.Name = "AddWrestlerToolStripMenuItem1"
        Me.AddWrestlerToolStripMenuItem1.Size = New System.Drawing.Size(229, 22)
        Me.AddWrestlerToolStripMenuItem1.Text = "Add Wrestler"
        '
        'CheckIfAlreadyExistsToolStripMenuItem
        '
        Me.CheckIfAlreadyExistsToolStripMenuItem.Name = "CheckIfAlreadyExistsToolStripMenuItem"
        Me.CheckIfAlreadyExistsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.CheckIfAlreadyExistsToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.CheckIfAlreadyExistsToolStripMenuItem.Text = "Check if already exists"
        '
        'RemoveWrestlerToolStripMenuItem
        '
        Me.RemoveWrestlerToolStripMenuItem.Name = "RemoveWrestlerToolStripMenuItem"
        Me.RemoveWrestlerToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.RemoveWrestlerToolStripMenuItem.Text = "Remove Wrestler"
        Me.RemoveWrestlerToolStripMenuItem.Visible = False
        '
        'NormalizeToolStripMenuItem
        '
        Me.NormalizeToolStripMenuItem.Name = "NormalizeToolStripMenuItem"
        Me.NormalizeToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.NormalizeToolStripMenuItem.Text = "Normalize ids"
        '
        'DBEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 601)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "DBEdit"
        Me.Text = "DBEdit"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveWrestlerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NormalizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WrestlerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddWrestlerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckIfAlreadyExistsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
