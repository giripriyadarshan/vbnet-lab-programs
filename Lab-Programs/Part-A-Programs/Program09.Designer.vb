<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Program09
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Program01ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Program02ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Program03ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Program04ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Program01ToolStripMenuItem, Me.Program02ToolStripMenuItem, Me.Program03ToolStripMenuItem, Me.Program04ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(683, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Program01ToolStripMenuItem
        '
        Me.Program01ToolStripMenuItem.Name = "Program01ToolStripMenuItem"
        Me.Program01ToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.Program01ToolStripMenuItem.Text = "Program01"
        '
        'Program02ToolStripMenuItem
        '
        Me.Program02ToolStripMenuItem.Name = "Program02ToolStripMenuItem"
        Me.Program02ToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.Program02ToolStripMenuItem.Text = "Program02"
        '
        'Program03ToolStripMenuItem
        '
        Me.Program03ToolStripMenuItem.Name = "Program03ToolStripMenuItem"
        Me.Program03ToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.Program03ToolStripMenuItem.Text = "Program03"
        '
        'Program04ToolStripMenuItem
        '
        Me.Program04ToolStripMenuItem.Name = "Program04ToolStripMenuItem"
        Me.Program04ToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.Program04ToolStripMenuItem.Text = "Program04"
        '
        'Program09
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 509)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "Program09"
        Me.Text = "Program09"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Program01ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Program02ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Program03ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Program04ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
