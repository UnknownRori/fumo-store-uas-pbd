Public Class MasterFumo
    Private Sub Kembali()
        Me.Dispose()
    End Sub

    Private Sub Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Kembali()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Kembali()
    End Sub
End Class