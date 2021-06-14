<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Program01
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
        Me.components = New System.ComponentModel.Container()
        Me.moving_label = New System.Windows.Forms.Label()
        Me.mover = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'moving_label
        '
        Me.moving_label.AutoSize = True
        Me.moving_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moving_label.Location = New System.Drawing.Point(12, 9)
        Me.moving_label.Name = "moving_label"
        Me.moving_label.Size = New System.Drawing.Size(216, 25)
        Me.moving_label.TabIndex = 0
        Me.moving_label.Text = "WHEEEEEE!!!!!!!!!!!!"
        '
        'mover
        '
        Me.mover.Enabled = True
        '
        'Program01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 49)
        Me.Controls.Add(Me.moving_label)
        Me.Name = "Program01"
        Me.Text = "annimashun"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents moving_label As System.Windows.Forms.Label
    Friend WithEvents mover As System.Windows.Forms.Timer

End Class
