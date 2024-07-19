Public Class MenuUtama
    Dim master As MasterFumo
    Dim transaksi As TransaksiFumo

    Private Sub MasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterToolStripMenuItem.Click
        master = New MasterFumo()
        master.Visible = True
    End Sub

    Private Sub TransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiToolStripMenuItem.Click
        transaksi = New TransaksiFumo()
        transaksi.Visible = True
    End Sub

    Private Sub Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi.Konek()
    End Sub
End Class
