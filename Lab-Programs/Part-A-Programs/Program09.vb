Public Class Program09

    Private Sub close_all_others()
        For Each form As Form In Me.MdiChildren
            form.Close()
        Next
    End Sub

    Private Sub Program01ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Program01ToolStripMenuItem.Click
        Program01.MdiParent = Me
        close_all_others()
        Program01.Show()
    End Sub

    Private Sub Program02ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Program02ToolStripMenuItem.Click
        Program02.MdiParent = Me
        close_all_others()
        Program02.Show()
    End Sub

    Private Sub Program03ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Program03ToolStripMenuItem.Click
        Program03.MdiParent = Me
        close_all_others()
        Program03.Show()
    End Sub

    Private Sub Program04ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Program04ToolStripMenuItem.Click
        Program04.MdiParent = Me
        close_all_others()
        Program04.Show()
    End Sub
End Class