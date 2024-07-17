Public Class TransaksiFumo
    Private Sub Kembali()
        Me.Dispose()
    End Sub

    Private Sub Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Kembali()
    End Sub

    Private Sub KembaliToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KembaliToolStripMenuItem.Click
        Kembali()
    End Sub
End Class